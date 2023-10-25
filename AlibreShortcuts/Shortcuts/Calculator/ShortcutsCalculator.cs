using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using com.alibre.client;
using com.alibre.executive.locale;
using com.alibre.ui;
using com.alibre.utils;
using Shortcuts.Model;
using Shortcut = Shortcuts.Model.Shortcut;

namespace Shortcuts.Shortcuts.Calculator
{
    public class ShortcutsCalculator
    {
        private readonly KeyboardShortcutsMediator _mediator = new();

        public ArrayList RetrieveUserShortcuts()
        {
            var userShortcutList = new ArrayList();
            var userProfile = RetrieveUserProfile();
            var mapping = userProfile.Mapping;

            foreach (var mappingPair in mapping.Pairs)
            {
                var first = mappingPair.toWrappedObject().first;
                var second = mappingPair.toWrappedObject().second;
                var child = first.ToString();

                if (second is Profile)
                {
                    Profile p = (Profile) second;
                    DumpUserProfile(p, child, userShortcutList);
                }
            }

            return userShortcutList;
        }

        private Dictionary<string, Shortcut> UserShortcuts()
        {
            Dictionary<string, Shortcut> userShortcuts = new();
            foreach (Shortcut sc in RetrieveUserShortcuts())
            {
                userShortcuts.Add(sc.Profile + "." + sc.Command, sc);
            }

            return userShortcuts;
        }

        private Dictionary<string, Shortcut> StandardShortcuts()
        {
            Dictionary<string, Shortcut> standardShorcuts = new();
            foreach (Shortcut sc in RetrieveStandardShortcuts())
            {
                standardShorcuts.Add(sc.Profile + "." + sc.Command, sc);
            }

            return standardShorcuts;
        }


        public string ToAbbreviatedTable(ArrayList shortcuts)
        {
            Dictionary<string, Shortcut> standardShortcuts = StandardShortcuts();
            StringBuilder sb = new StringBuilder();
            Shortcut priorShortcut = null;

            foreach (Shortcut sc in shortcuts)
            {
                Shortcut standardShortcut = null;
                if (standardShortcuts.ContainsKey(sc.Profile + "." + sc.Command))
                {
                    standardShortcut = standardShortcuts[sc.Profile + "." + sc.Command];
                }

                if (standardShortcut != null && standardShortcut.KeyChar == sc.KeyChar)
                {
                    sc.ShortcutType = ShortcutType.Default;
                }

                if (standardShortcut != null && standardShortcut.KeyChar != sc.KeyChar)
                {
                    sc.ShortcutType = ShortcutType.Override;
                }

                if (standardShortcut == null)
                {
                    sc.ShortcutType = ShortcutType.Custom;
                }


                if (priorShortcut == null | (priorShortcut != null && priorShortcut.Profile != sc.Profile))
                {
                    sb.Append("<table>");
                    sb.Append("<tr>");
                    sb.Append("<th colspan=\"2\">");
                    sb.Append(sc.Profile);
                    sb.Append("</th>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("Hint");
                    sb.Append("</th>");
                    sb.Append("<th>");
                    sb.Append("Shortcut");
                    sb.Append("</th>");
                    sb.Append("</tr>");
                }
                else
                {
                    if (!string.IsNullOrEmpty(sc.Hint))
                    {
                        switch (sc.ShortcutType)
                        {
                            case ShortcutType.Default:
                                sb.Append("<tr>");
                                break;
                            case ShortcutType.Custom:
                                sb.Append("<tr style=\"color:#0000ff\">");
                                break;
                            case ShortcutType.Override:
                                sb.Append("<tr style=\"color:#ff0000\">");
                                break;
                        }

                        sb.Append("<td>");
                        sb.Append(sc.Hint);
                        sb.Append("</td>");
                        sb.Append("<td>");
                        sb.Append(sc.KeyChar);
                        sb.Append("</td>");
                        sb.Append("</tr>");
                    }
                }

                priorShortcut = sc;
                if (priorShortcut.Profile != sc.Profile)
                {
                    sb.Append("</table>");
                    sb.Append("<p></p>");
                    sb.Append("<p></p>");
                }
            }
            return sb.ToString();
        }


        public string AddHtmlHeaderFooter(string html)
        {
            var header =
                @"<html><head><style>  table, th, td {  border: 1px solid black;  border-collapse: collapse;  }  th, td {  padding: 5px;  text-align: left;  }  </style></head><body>";
            var footer = @"</body></html>";
            return header + html + footer;
        }


        public ArrayList RetrieveUserShortcutsByProfile(string profile)
        {
            ArrayList shortcuts = RetrieveUserShortcuts();
            ArrayList profileShortcuts = new ArrayList();
            foreach (var sc in shortcuts)
            {
                if (((Shortcut) sc).Profile == profile)
                {
                    profileShortcuts.Add(sc);
                }
            }

            return profileShortcuts;
        }


        public ArrayList RetrieveStandardShortcuts()
        {
            var standardShortcuts = new ArrayList();

            DumpStandardProfile(PartStandardShortcuts(), "Design Part Browser", standardShortcuts);
            DumpStandardProfile(BomStandardShortcuts(), "BOM Editor", standardShortcuts);
            DumpStandardProfile(CommandCenterStandardShortcuts(), "Command Center Browser", standardShortcuts);
            DumpStandardProfile(AssemblyStandardShortcuts(), "Design Assembly Browser", standardShortcuts);
            DumpStandardProfile(AssemblyExplodedViewStandardShortcuts(), "Design Assembly Exploded View Browser", standardShortcuts);
            DumpStandardProfile(DesignBooleanStandardShortcuts(), "Design Boolean Browser", standardShortcuts);
            DumpStandardProfile(SheetMetalStandardShortcuts(), "Design Sheet Metal Browser", standardShortcuts);
            DumpStandardProfile(DrawingStandardShortcuts(), "Drawing Browser", standardShortcuts);
            DumpStandardProfile(GlobalParamStandardShortcuts(), "GlobalParam Editor", standardShortcuts);

            return standardShortcuts;
        }


        private void DumpStandardProfile(Profile profile, string profileName, ArrayList shortcuts)
        {
            LinearMap mapping = profile.Mapping;
            var kc = new KeysConverter();
            foreach (var mappingPair in mapping.Pairs)
            {
                var wrappedObjects = mappingPair.toWrappedObject();
                var first = wrappedObjects.first;
                var second = wrappedObjects.second;
                var keyChar = kc.ConvertToString(second);
                var hint = LString.getLocalizedString(first.ToString(), LStringToken.ToolbarHint);
                shortcuts.Add(new Shortcut(profileName, (string) first, hint, (int) second, keyChar));
            }
        }

        private void DumpUserProfile(Profile profile, string parent, ArrayList shortcuts)
        {
            LinearMap mapping = profile.Mapping;
            var kc = new KeysConverter();
            foreach (var mappingPair in mapping.Pairs)
            {
                var wrappedObjects = mappingPair.toWrappedObject();
                var first = wrappedObjects.first;
                var second = wrappedObjects.second;

                var child = parent + ", " + first;

                var keyChar = kc.ConvertToString(second);
                if (child.ToUpper().Contains("SHORTCUTS") && !second.ToString().ToUpper().Contains("PROFILE"))
                {
                    var toRemove = ", SHORTCUTS";
                    var profilep = parent.Remove(parent.IndexOf(toRemove, StringComparison.Ordinal), toRemove.Length);
                    var hint = LString.getLocalizedString(first.ToString(), LStringToken.ToolbarHint);

                    shortcuts.Add(new Shortcut(profilep, (string) first, hint, (int) second, keyChar));
                }

                if (mappingPair.toWrappedObject().second is Profile)
                {
                    var p = (Profile) mappingPair.toWrappedObject().second;
                    DumpUserProfile(p, child, shortcuts);
                }
            }
        }

        public object ReadObjectFromFile(FileStream fileStream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Context = new StreamingContext(StreamingContextStates.All);
            SurrogateSelector surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(typeof(Profile), new StreamingContext(StreamingContextStates.All), new ProfileSerializationSurrogate());
            formatter.SurrogateSelector = surrogateSelector;
            object obj = formatter.Deserialize(fileStream);

            return obj;
        }

        public string ProfilePath()
        {
            var productRoamingDirectory = ClientContext.ProductRoamingDirectory;
            var userProfileCurrentVersionFileName = ClientContext.Singleton.UserProfileCurrentVersionFileName;
            var profilePath = Path.Combine(productRoamingDirectory.FullName + "\\default user", userProfileCurrentVersionFileName);

            return profilePath;
        }


        private Profile RetrieveUserProfile()
        {
            var profilePath = ProfilePath();

            if (File.Exists(profilePath))
            {
                return ReadProfileFromFile(profilePath);
            }

            return null;
        }

        private Profile ReadProfileFromFile(string profilePath)
        {
            using var fileStream = new FileStream(profilePath, FileMode.Open, FileAccess.Read);
            return (Profile) ReadObjectFromFile(fileStream);
        }

        public ArrayList StandardProfiles()
        {
            var profiles = new ArrayList();
            profiles.Add(PartStandardShortcuts());
            profiles.Add(BomStandardShortcuts());
            profiles.Add(CommandCenterStandardShortcuts());
            profiles.Add(AssemblyStandardShortcuts());
            profiles.Add(AssemblyExplodedViewStandardShortcuts());
            profiles.Add(DesignBooleanStandardShortcuts());
            profiles.Add(SheetMetalStandardShortcuts());
            profiles.Add(DrawingStandardShortcuts());
            profiles.Add(GlobalParamStandardShortcuts());
            return profiles;
        }

        private Profile PartStandardShortcuts()
        {
            return _mediator.PartStandardShortcuts;
        }


        private Profile BomStandardShortcuts()
        {
            return _mediator.BOMStandardShortcuts;
        }

        private Profile CommandCenterStandardShortcuts()
        {
            return _mediator.CommandCenterStandardShortcuts;
        }

        private Profile AssemblyStandardShortcuts()
        {
            return _mediator.AssemblyStandardShortcuts;
        }

        private Profile AssemblyExplodedViewStandardShortcuts()
        {
            return _mediator.AssemblyExplodedViewStandardShortcuts;
        }

        private Profile DesignBooleanStandardShortcuts()
        {
            return _mediator.DesignBooleanStandardShortcuts;
        }

        private Profile SheetMetalStandardShortcuts()
        {
            return _mediator.SheetMetalStandardShortcuts;
        }

        private Profile DrawingStandardShortcuts()
        {
            return _mediator.DrawingStandardShortcuts;
        }

        private Profile GlobalParamStandardShortcuts()
        {
            return _mediator.GlobalParamStandardShortcuts;
        }
    }
}