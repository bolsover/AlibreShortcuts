using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Linq;
using Shortcuts.Model;
using com.alibre.client;
using com.alibre.executive.locale;
using com.alibre.ui;
using com.alibre.utils;
using com.objectspace.jgl;

namespace Shortcuts.Calculator
{
    public class CustomKeyboardShortcutsMediator : KeyboardShortcutsMediator
    {
        private static readonly FieldInfo CurrentShortcutsField =
            typeof(KeyboardShortcutsMediator).GetField("currentShortcuts", BindingFlags.NonPublic | BindingFlags.Instance);

        public Dictionary<string, Profile> GetCurrentShortcutsDictionary()
        {
            return CurrentShortcutsField?.GetValue(this) as Dictionary<string, Profile>;
        }

        public void EnsureInitialized(Profile userProfile = null)
        {
            var dict = GetCurrentShortcutsDictionary();
            if (dict != null && dict.Count > 0) return;

            // Try standard initialize with a BackgroundWorker to satisfy initDefaults progress reporting
            try
            {
                var worker = new System.ComponentModel.BackgroundWorker();
                var e = new System.ComponentModel.DoWorkEventArgs(null);
                initialize(worker, e);
                dict = GetCurrentShortcutsDictionary();
            }
            catch
            {
            }

            if (dict == null)
            {
                dict = new Dictionary<string, Profile>();
                CurrentShortcutsField?.SetValue(this, dict);
            }

            // Ensure all workspace profiles are populated
            var prefixes = ALL_WORKSPACE_PREFIXES;
            if (prefixes != null)
            {
                foreach (var prefix in prefixes)
                {
                    if (!dict.ContainsKey(prefix) || dict[prefix] == null)
                    {
                        Profile p = null;
                        try
                        {
                            p = userProfile?.getValue(prefix + @"\SHORTCUTS") as Profile;
                        }
                        catch
                        {
                        }

                        if (p != null)
                        {
                            try
                            {
                                p = (Profile) p.Clone();
                            }
                            catch
                            {
                            }
                        }

                        dict[prefix] = p ?? new Profile();
                    }
                }
            }
        }

        public void SetShortcutSafe(string workspace, string commandId, Keys keys)
        {
            EnsureInitialized();
            var dict = GetCurrentShortcutsDictionary();
            if (dict != null)
            {
                if (!dict.ContainsKey(workspace) || dict[workspace] == null)
                {
                    dict[workspace] = new Profile();
                }
                dict[workspace].setValue(commandId, keys);
            }
        }

        public void ClearShortcutSafe(string workspace, string commandId)
        {
            EnsureInitialized();
            var dict = GetCurrentShortcutsDictionary();
            if (dict != null && dict.TryGetValue(workspace, out var profile) && profile != null)
            {
                profile.setValue(commandId, 0);
            }
        }

        public Keys GetShortcutSafe(string workspace, string commandId)
        {
            EnsureInitialized();
            var dict = GetCurrentShortcutsDictionary();
            if (dict != null && dict.TryGetValue(workspace, out var profile) && profile != null)
            {
                var val = profile.getValue(commandId);
                if (val != null)
                {
                    try
                    {
                        return (Keys) Convert.ToInt32(val);
                    }
                    catch
                    {
                    }
                }
            }
            return Keys.None;
        }

        public bool IsShortcutInUseSafe(string workspace, Keys shortcut, out string conflictCommand)
        {
            conflictCommand = null;
            if (shortcut == Keys.None) return false;
            EnsureInitialized();
            var dict = GetCurrentShortcutsDictionary();
            if (dict != null && dict.TryGetValue(workspace, out var profile) && profile != null)
            {
                try
                {
                    var keysEnum = profile.getKeys(shortcut);
                    if (keysEnum != null && keysEnum.MoveNext())
                    {
                        conflictCommand = keysEnum.Current?.ToString();
                        return true;
                    }
                }
                catch
                {
                }

                try
                {
                    if (profile.Mapping?.Pairs != null)
                    {
                        var targetCode = (int) shortcut;
                        foreach (var pair in profile.Mapping.Pairs)
                        {
                            var w = pair.toWrappedObject();
                            if (w.second != null)
                            {
                                try
                                {
                                    if (Convert.ToInt32(w.second) == targetCode)
                                    {
                                        conflictCommand = w.first?.ToString();
                                        return true;
                                    }
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }
            return false;
        }

        public void CommitPendingChangesSafe(Profile userProfile = null)
        {
            EnsureInitialized(userProfile);
            var dict = GetCurrentShortcutsDictionary();
            if (dict != null)
            {
                Profile targetProfile = null;
                try
                {
                    targetProfile = ShortcutsCalculator.SafeClientContext?.UserProfile ?? userProfile;
                }
                catch
                {
                }

                if (targetProfile != null)
                {
                    foreach (var pair in dict)
                    {
                        try
                        {
                            targetProfile.setValue(pair.Key + @"\SHORTCUTS", pair.Value);
                        }
                        catch
                        {
                        }
                    }
                }
            }

            try
            {
                commitPendingChanges();
            }
            catch
            {
                try
                {
                    noteChanges();
                }
                catch
                {
                }
            }
        }
    }

    public class ShortcutsCalculator
    {
        private static readonly FieldInfo SingletonField =
            typeof(ClientContext).GetField("singleton", BindingFlags.NonPublic | BindingFlags.Static);

        public static ClientContext SafeClientContext
        {
            get
            {
                try
                {
                    return SingletonField?.GetValue(null) as ClientContext;
                }
                catch
                {
                    return null;
                }
            }
        }

        private readonly CustomKeyboardShortcutsMediator _mediator = new();
        private readonly ADResourceManager _adResourceManager = ADResourceManager.Singleton;
        private bool _isMediatorInitialized;

        public void EnsureMediatorInitialized()
        {
            if (_isMediatorInitialized) return;
            try
            {
                _mediator.EnsureInitialized(RetrieveUserProfile());
                _isMediatorInitialized = true;
            }
            catch
            {
                // Standalone or non-singleton context
            }
        }
        
        private List<AlibreShortcut> RetrieveUserShortcuts()
        {
            var userShortcutList = new List<AlibreShortcut>();
            var userProfile = RetrieveUserProfile();
            if (userProfile == null)
            {
                // MessageBox.Show("No user profile found", "Error");
                return userShortcutList;
            }
            
            var mapping = userProfile.Mapping;
            
            foreach (var mappingPair in mapping.Pairs)
            {
                var first = mappingPair.toWrappedObject().first;
                var second = mappingPair.toWrappedObject().second;
                var child = first.ToString();
                
                if (second is not Profile profile) continue;
                DumpUserProfile(profile, child, userShortcutList);
            }
            
            return userShortcutList;
        }
        
        public Dictionary<string, AlibreShortcut> ShortcutsDictionary(List<AlibreShortcut> shortcuts)
        {
            return shortcuts.ToDictionary(sc => sc.Profile + "." + sc.Command);
        }
        
        public List<AlibreShortcut> RetrieveUserShortcutsByProfile(string profile)
        {
            var shortcuts = RetrieveUserShortcuts();
            return shortcuts.Where(sc => sc.Profile == profile).ToList();
        }
        
        public XElement ProfileToXml(Profile profile)
        {
            var kc = new KeysConverter();
            var xml = new XElement("Profile");
            foreach (var pairXmlWrapper in profile.Mapping.Pairs)
            {
                var wrappedObjects = pairXmlWrapper.toWrappedObject();
                var first = wrappedObjects.first;
                var second = wrappedObjects.second;
                var child = first.ToString();
                child = child.Replace(" ", "_");
                child = child.Replace("\u00d8", "?");
                child = child.Replace("~", "_");
                
                if (!child.StartsWith("0"))
                {
                    if (second is Profile profile1)
                    {
                        var childXml = new XElement(child);
                        childXml.Add(ProfileToXml(profile1));
                        xml.Add(childXml);
                    }
                    else
                    {
                        var childXml = new XElement(child);
                        childXml.Add(second.ToString() + " : " + kc.ConvertToString(second));
                        xml.Add(childXml);
                    }
                }
            }
            
            return xml;
        }
        
        public List<AlibreShortcut> RetrieveStandardShortcutsByProfile(string profile)
        {
            var standardShortcuts = new List<AlibreShortcut>();
            try
            {
                switch (profile)
                {
                    case "Design Part Browser":
                        DumpStandardProfile(PartStandardShortcuts(), "Design Part Browser", standardShortcuts);
                        break;
                    case "BOM Editor":
                        DumpStandardProfile(BomStandardShortcuts(), "BOM Editor", standardShortcuts);
                        break;
                    case "Command Center Browser":
                        DumpStandardProfile(CommandCenterStandardShortcuts(), "Command Center Browser", standardShortcuts);
                        break;
                    case "Design Assembly Browser":
                        DumpStandardProfile(AssemblyStandardShortcuts(), "Design Assembly Browser", standardShortcuts);
                        break;
                    case "Design Assembly Exploded View Browser":
                        DumpStandardProfile(AssemblyExplodedViewStandardShortcuts(), "Design Assembly Exploded View Browser",
                            standardShortcuts);
                        break;
                    case "Design Boolean Browser":
                        DumpStandardProfile(DesignBooleanStandardShortcuts(), "Design Boolean Browser", standardShortcuts);
                        break;
                    case "Design Sheet Metal Browser":
                        DumpStandardProfile(SheetMetalStandardShortcuts(), "Design Sheet Metal Browser", standardShortcuts);
                        break;
                    case "Drawing Browser":
                        DumpStandardProfile(DrawingStandardShortcuts(), "Drawing Browser", standardShortcuts);
                        break;
                    case "GlobalParam Editor":
                        DumpStandardProfile(GlobalParamStandardShortcuts(), "GlobalParam Editor", standardShortcuts);
                        break;
                }
            }
            catch
            {
            }
            
            return standardShortcuts.Where(sc => !string.IsNullOrEmpty(sc.Hint)).ToList();
        }
        
        public List<AlibreShortcut> RetrieveStandardShortcuts()
        {
            var standardShortcuts = new List<AlibreShortcut>();
            try
            {
                DumpStandardProfile(PartStandardShortcuts(), "Design Part Browser", standardShortcuts);
                DumpStandardProfile(BomStandardShortcuts(), "BOM Editor", standardShortcuts);
                DumpStandardProfile(CommandCenterStandardShortcuts(), "Command Center Browser", standardShortcuts);
                DumpStandardProfile(AssemblyStandardShortcuts(), "Design Assembly Browser", standardShortcuts);
                DumpStandardProfile(AssemblyExplodedViewStandardShortcuts(), "Design Assembly Exploded View Browser",
                    standardShortcuts);
                DumpStandardProfile(DesignBooleanStandardShortcuts(), "Design Boolean Browser", standardShortcuts);
                DumpStandardProfile(SheetMetalStandardShortcuts(), "Design Sheet Metal Browser", standardShortcuts);
                DumpStandardProfile(DrawingStandardShortcuts(), "Drawing Browser", standardShortcuts);
                DumpStandardProfile(GlobalParamStandardShortcuts(), "GlobalParam Editor", standardShortcuts);
            }
            catch
            {
            }
            
            return standardShortcuts;
        }
        
        private void DumpStandardProfile(Profile profile, string profileName, List<AlibreShortcut> shortcuts)
        {
            if (profile?.Mapping?.Pairs == null) return;
            var mapping = profile.Mapping;
            var kc = new KeysConverter();
            shortcuts.AddRange(from mappingPair in mapping.Pairs
                select mappingPair.toWrappedObject()
                into wrappedObjects
                let first = wrappedObjects.first
                let second = wrappedObjects.second
                let keyChar = kc.ConvertToString(second)
                let hint = LString.getLocalizedString(first.ToString(), LStringToken.ToolbarHint)
                select new AlibreShortcut(profileName, (string) first, hint, (int) second, keyChar)
                    {SvgImage = _adResourceManager.GetSvgImage((string) first)});
        }
        
        private void DumpUserProfile(Profile profile, string parent, List<AlibreShortcut> shortcuts)
        {
            if (profile?.Mapping?.Pairs == null) return;
            var mapping = profile.Mapping;
            var kc = new KeysConverter();
            foreach (var mappingPair in mapping.Pairs)
            {
                var wrappedObjects = mappingPair.toWrappedObject();
                var first = wrappedObjects.first;
                var second = wrappedObjects.second;
                if (first == null || second == null) continue;

                var child = parent + ", " + first;
                var keyChar = kc.ConvertToString(second);
                if (child.ToUpper().Contains("SHORTCUTS") && !second.ToString().ToUpper().Contains("PROFILE"))
                {
                    const string toRemove = ", SHORTCUTS";
                    var idx = parent.IndexOf(toRemove, StringComparison.Ordinal);
                    var profilep = idx >= 0 ? parent.Remove(idx, toRemove.Length) : parent;
                    var hint = LString.getLocalizedString(first.ToString(), LStringToken.ToolbarHint);
                    int keyCode = 0;
                    try
                    {
                        keyCode = Convert.ToInt32(second);
                    }
                    catch
                    {
                    }

                    var alibreShortcut = new AlibreShortcut(profilep, (string) first, hint, keyCode, keyChar)
                    {
                        SvgImage = _adResourceManager.GetSvgImage((string) first)
                    };
                    if (!string.IsNullOrEmpty(alibreShortcut.Hint))
                    {
                        shortcuts.Add(alibreShortcut);
                    }
                }
                
                if (second is Profile p)
                {
                    DumpUserProfile(p, child, shortcuts);
                }
            }
        }
        
        private object ReadObjectFromFile(FileStream fileStream)
        {
            var formatter = new BinaryFormatter
            {
                Context = new StreamingContext(StreamingContextStates.All)
            };
            var surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(typeof(Profile), new StreamingContext(StreamingContextStates.All),
                new ProfileSerializationSurrogate());
            formatter.SurrogateSelector = surrogateSelector;
            var obj = formatter.Deserialize(fileStream);
            
            return obj;
        }
        
        public string RoamingProfilePath()
        {
            try
            {
                var userDir = SafeClientContext?.CurrentUserRoamingDirectory ?? SafeClientContext?.DefaultUserRoamingDirectory;
                var fileName = SafeClientContext?.UserProfileCurrentVersionFileName;
                if (userDir != null && !string.IsNullOrEmpty(fileName))
                {
                    var p = Path.Combine(userDir.FullName, fileName);
                    if (File.Exists(p)) return p;
                }
            }
            catch
            {
            }

            try
            {
                var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var alibreDir = Path.Combine(appData, "Alibre Design");
                if (Directory.Exists(alibreDir))
                {
                    var candidateDirs = new List<string> { Path.Combine(alibreDir, "default user") };
                    candidateDirs.AddRange(Directory.GetDirectories(alibreDir));
                    var usersDir = Path.Combine(alibreDir, "Users");
                    if (Directory.Exists(usersDir))
                    {
                        candidateDirs.AddRange(Directory.GetDirectories(usersDir));
                    }

                    var candidateProfiles = new List<(string Path, int Version, DateTime LastWriteTime)>();
                    foreach (var dir in candidateDirs.Distinct())
                    {
                        if (!Directory.Exists(dir)) continue;

                        var files = Directory.GetFiles(dir);
                        foreach (var f in files)
                        {
                            var name = Path.GetFileName(f);
                            var match = System.Text.RegularExpressions.Regex.Match(name, @"^User\.NET\.profile_(\d+)$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                            if (match.Success && int.TryParse(match.Groups[1].Value, out var ver))
                            {
                                candidateProfiles.Add((f, ver, File.GetLastWriteTimeUtc(f)));
                            }
                            else if (string.Equals(name, "user.profile", StringComparison.OrdinalIgnoreCase))
                            {
                                candidateProfiles.Add((f, 0, File.GetLastWriteTimeUtc(f)));
                            }
                        }
                    }

                    var bestProfile = candidateProfiles
                        .OrderByDescending(p => p.Version)
                        .ThenByDescending(p => p.LastWriteTime)
                        .FirstOrDefault();

                    if (!string.IsNullOrEmpty(bestProfile.Path) && File.Exists(bestProfile.Path))
                    {
                        return bestProfile.Path;
                    }
                }
            }
            catch
            {
            }

            return null;
        }

        public string BackupUserProfile(int maxCopies = 5)
        {
            try
            {
                try
                {
                    SafeClientContext?.saveUserProfile();
                }
                catch
                {
                }

                var profilePath = RoamingProfilePath();
                if (string.IsNullOrEmpty(profilePath) || !File.Exists(profilePath))
                {
                    return null;
                }

                var dir = Path.GetDirectoryName(profilePath);
                if (string.IsNullOrEmpty(dir) || !Directory.Exists(dir))
                {
                    return null;
                }

                var fileName = Path.GetFileName(profilePath);
                var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                var backupFileName = $"{fileName}_{timestamp}.bak";
                var backupFilePath = Path.Combine(dir, backupFileName);

                if (File.Exists(backupFilePath))
                {
                    backupFileName = $"{fileName}_{DateTime.Now:yyyyMMdd_HHmmssfff}.bak";
                    backupFilePath = Path.Combine(dir, backupFileName);
                }

                File.Copy(profilePath, backupFilePath, true);
                try
                {
                    File.SetLastWriteTime(backupFilePath, DateTime.Now);
                }
                catch
                {
                }

                RetainProfileBackups(dir, fileName, maxCopies);

                return backupFilePath;
            }
            catch
            {
                return null;
            }
        }

        public static void RetainProfileBackups(string directory, string originalFileName, int maxCopiesToRetain)
        {
            try
            {
                if (string.IsNullOrEmpty(directory) || !Directory.Exists(directory)) return;

                var dirInfo = new DirectoryInfo(directory);
                var pattern = @"^" + System.Text.RegularExpressions.Regex.Escape(originalFileName) + @"_\d{8}_\d{6}.*\.bak$";
                var backupFiles = dirInfo.GetFiles($"{originalFileName}_*.bak")
                    .Where(f => System.Text.RegularExpressions.Regex.IsMatch(f.Name, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    .OrderByDescending(f => f.Name)
                    .ThenByDescending(f => f.LastWriteTimeUtc)
                    .ToList();

                if (backupFiles.Count > maxCopiesToRetain)
                {
                    var filesToDelete = backupFiles.Skip(maxCopiesToRetain).ToList();
                    foreach (var file in filesToDelete)
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }
        }
        
        public Profile RetrieveUserProfile()
        {
            try
            {
                if (SafeClientContext?.UserProfile != null)
                {
                    return SafeClientContext.UserProfile;
                }
            }
            catch
            {
                // In non-Alibre session fallback to reading roaming profile
            }

            try
            {
                var profilePath = RoamingProfilePath();
                if (!string.IsNullOrEmpty(profilePath) && File.Exists(profilePath))
                {
                    return ReadProfileFromFile(profilePath);
                }
            }
            catch
            {
            }
            
            return null;
        }
        
        public Profile ReadProfileFromFile(string profilePath)
        {
            using var fileStream = new FileStream(profilePath, FileMode.Open, FileAccess.Read);
            return (Profile) ReadObjectFromFile(fileStream);
        }

        private static readonly Dictionary<string, Type> WorkspacePrototypeTypes = new()
        {
            { "Design Part Browser", typeof(com.alibre.design.app.PartProfilePrototype) },
            { "Design Sheet Metal Browser", typeof(com.alibre.design.app.SheetMetalProfilePrototype) },
            { "Weldments Browser", typeof(com.alibre.design.app.WeldmentsProfilePrototype) },
            { "Design Assembly Browser", typeof(com.alibre.design.app.AssemblyProfilePrototype) },
            { "Design Assembly Exploded View Browser", typeof(com.alibre.design.app.AssemblyExplodedViewProfilePrototype) },
            { "Design Boolean Browser", typeof(com.alibre.design.app.DesignBooleanProfilePrototype) },
            { "Drawing Browser", typeof(com.alibre.drawing.app.DrawingProfilePrototype) },
            { "BOM Editor", typeof(com.alibre.BOM.app.BOMProfilePrototype) },
            { "GlobalParam Editor", typeof(com.alibre.globalParam.app.GlobalParamProfilePrototype) },
            { "Command Center Browser", typeof(com.alibre.app.CommandCenterProfilePrototype) }
        };

        private HashMap GetWorkspaceCommandsMap(string workspace)
        {
            EnsureMediatorInitialized();
            HashMap hashMap = null;
            try
            {
                hashMap = _mediator.getCommandIDs(workspace);
            }
            catch
            {
            }

            if (hashMap == null && WorkspacePrototypeTypes.TryGetValue(workspace, out var protoType))
            {
                try
                {
                    var proto = Activator.CreateInstance(protoType, true) as ProfilePrototype;
                    hashMap = proto?.CustomShortcutCommands;
                }
                catch
                {
                }
            }

            return hashMap;
        }

        public List<WorkspaceCommand> GetAllAvailableCommands()
        {
            var commands = new List<WorkspaceCommand>();
            EnsureMediatorInitialized();
            
            var workspacePrefixes = KeyboardShortcutsMediator.ALL_WORKSPACE_PREFIXES;
            foreach (var ws in workspacePrefixes)
            {
                var wsCommands = GetAvailableCommandsForWorkspace(ws);
                commands.AddRange(wsCommands);
            }

            return commands;
        }

        public List<WorkspaceCommand> GetAvailableCommandsForWorkspace(string workspace)
        {
            var commands = new List<WorkspaceCommand>();
            var standard = RetrieveStandardShortcutsByProfile(workspace);
            var standardDict = standard?.ToDictionary(s => s.Command, s => s) ?? new Dictionary<string, AlibreShortcut>();
            var userShortcuts = RetrieveUserShortcutsByProfile(workspace);
            var userDict = userShortcuts?.ToDictionary(u => u.Command, u => u) ?? new Dictionary<string, AlibreShortcut>();

            var hashMap = GetWorkspaceCommandsMap(workspace);
            if (hashMap != null)
            {
                try
                {
                    var keysEnum = hashMap.keys();
                    while (keysEnum.MoveNext())
                    {
                        var category = keysEnum.Current?.ToString() ?? "";
                        var localizedCategory = LString.getLocalizedString(category);
                        if (string.IsNullOrEmpty(localizedCategory)) localizedCategory = category;

                        var cmdIds = hashMap.get(category) as string[];
                        if (cmdIds != null)
                        {
                            foreach (var cmdId in cmdIds)
                            {
                                if (string.IsNullOrEmpty(cmdId)) continue;
                                var hint = LString.getLocalizedString(cmdId, LStringToken.ToolbarHint);
                                if (string.IsNullOrEmpty(hint))
                                {
                                    hint = LString.getLocalizedString(cmdId);
                                }

                                Keys keys = Keys.None;
                                try
                                {
                                    keys = _mediator.getShortcut(workspace, cmdId);
                                }
                                catch
                                {
                                    keys = Keys.None;
                                }

                                if (keys == Keys.None)
                                {
                                    if (userDict.TryGetValue(cmdId, out var userSc))
                                    {
                                        keys = (Keys) userSc.Keycode;
                                    }
                                    else if (standardDict.TryGetValue(cmdId, out var stdSc))
                                    {
                                        keys = (Keys) stdSc.Keycode;
                                    }
                                }

                                var svg = _adResourceManager.GetSvgImage(cmdId);
                                commands.Add(new WorkspaceCommand
                                {
                                    Workspace = workspace,
                                    Category = localizedCategory,
                                    CommandId = cmdId,
                                    Hint = hint,
                                    ShortcutKeys = keys,
                                    SvgImage = svg
                                });
                            }
                        }
                    }
                }
                catch
                {
                }
            }

            // Fallback & Merge: Add any standard or user shortcuts that weren't included in the prototype map
            var existingIds = new HashSet<string>(commands.Select(c => c.CommandId));
            if (standard != null)
            {
                foreach (var sc in standard)
                {
                    if (!existingIds.Contains(sc.Command))
                    {
                        var keys = (Keys) sc.Keycode;
                        if (userDict.TryGetValue(sc.Command, out var userSc))
                        {
                            keys = (Keys) userSc.Keycode;
                        }

                        commands.Add(new WorkspaceCommand
                        {
                            Workspace = workspace,
                            Category = "Standard",
                            CommandId = sc.Command,
                            Hint = sc.Hint,
                            ShortcutKeys = keys,
                            SvgImage = sc.SvgImage
                        });
                        existingIds.Add(sc.Command);
                    }
                }
            }

            if (userShortcuts != null)
            {
                foreach (var userSc in userShortcuts)
                {
                    if (!existingIds.Contains(userSc.Command))
                    {
                        commands.Add(new WorkspaceCommand
                        {
                            Workspace = workspace,
                            Category = "Custom",
                            CommandId = userSc.Command,
                            Hint = userSc.Hint,
                            ShortcutKeys = (Keys) userSc.Keycode,
                            SvgImage = userSc.SvgImage
                        });
                        existingIds.Add(userSc.Command);
                    }
                }
            }

            return commands;
        }

        public bool ValidateShortcut(Keys keys, string workspace, out string conflictCommand)
        {
            conflictCommand = null;
            EnsureMediatorInitialized();
            try
            {
                if (!_mediator.isShortcutValid(keys))
                {
                    return false;
                }

                if (_mediator.IsShortcutInUseSafe(workspace, keys, out conflictCommand))
                {
                    return true;
                }

                return true;
            }
            catch
            {
                return true;
            }
        }

        public Keys GetShortcut(string workspace, string commandId)
        {
            EnsureMediatorInitialized();
            try
            {
                return _mediator.GetShortcutSafe(workspace, commandId);
            }
            catch
            {
                return Keys.None;
            }
        }

        public bool UpdateShortcut(string workspace, string commandId, Keys keys)
        {
            EnsureMediatorInitialized();
            try
            {
                _mediator.SetShortcutSafe(workspace, commandId, keys);
                _mediator.CommitPendingChangesSafe(RetrieveUserProfile());
                try
                {
                    SafeClientContext?.saveUserProfile();
                }
                catch
                {
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveShortcut(string workspace, string commandId)
        {
            EnsureMediatorInitialized();
            try
            {
                _mediator.ClearShortcutSafe(workspace, commandId);
                _mediator.CommitPendingChangesSafe(RetrieveUserProfile());
                try
                {
                    SafeClientContext?.saveUserProfile();
                }
                catch
                {
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        private Profile PartStandardShortcuts()
        {
            try { return _mediator.PartStandardShortcuts; } catch { return null; }
        }
        
        private Profile BomStandardShortcuts()
        {
            try { return _mediator.BOMStandardShortcuts; } catch { return null; }
        }
        
        private Profile CommandCenterStandardShortcuts()
        {
            try { return _mediator.CommandCenterStandardShortcuts; } catch { return null; }
        }
        
        private Profile AssemblyStandardShortcuts()
        {
            try { return _mediator.AssemblyStandardShortcuts; } catch { return null; }
        }
        
        private Profile AssemblyExplodedViewStandardShortcuts()
        {
            try { return _mediator.AssemblyExplodedViewStandardShortcuts; } catch { return null; }
        }
        
        private Profile DesignBooleanStandardShortcuts()
        {
            try { return _mediator.DesignBooleanStandardShortcuts; } catch { return null; }
        }
        
        private Profile SheetMetalStandardShortcuts()
        {
            try { return _mediator.SheetMetalStandardShortcuts; } catch { return null; }
        }
        
        private Profile DrawingStandardShortcuts()
        {
            try { return _mediator.DrawingStandardShortcuts; } catch { return null; }
        }
        
        private Profile GlobalParamStandardShortcuts()
        {
            try { return _mediator.GlobalParamStandardShortcuts; } catch { return null; }
        }
    }
}