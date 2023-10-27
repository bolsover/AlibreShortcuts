﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using com.alibre.client;
using com.alibre.executive.locale;
using com.alibre.ui;
using com.alibre.utils;
using Shortcut = Shortcuts.Model.Shortcut;

namespace Shortcuts.Shortcuts.Calculator
{
    public class ShortcutsCalculator
    {
        private readonly KeyboardShortcutsMediator _mediator = new();

        private ArrayList RetrieveUserShortcuts()
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


        public Dictionary<string, Shortcut> ShortcutsDictionary(ArrayList shortcuts)
        {
            Dictionary<string, Shortcut> standardShorcuts = new();
            foreach (Shortcut sc in shortcuts)
            {
                standardShorcuts.Add(sc.Profile + "." + sc.Command, sc);
            }

            return standardShorcuts;
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

        private object ReadObjectFromFile(FileStream fileStream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Context = new StreamingContext(StreamingContextStates.All);
            SurrogateSelector surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(typeof(Profile), new StreamingContext(StreamingContextStates.All), new ProfileSerializationSurrogate());
            formatter.SurrogateSelector = surrogateSelector;
            object obj = formatter.Deserialize(fileStream);

            return obj;
        }

        private string RoamingProfilePath()
        {
            var productRoamingDirectory = ClientContext.ProductRoamingDirectory;
            var userProfileCurrentVersionFileName = ClientContext.Singleton.UserProfileCurrentVersionFileName;
            var productRoamingProfilePath = Path.Combine(productRoamingDirectory.FullName + "\\default user", userProfileCurrentVersionFileName);
            return productRoamingProfilePath;
        }

        private string NonRoamingProfilePath()
        {
            var currentUserNonRoamingDirectory = ClientContext.Singleton.getCurrentUserNonRoamingDirectory(true);
            var userProfileCurrentVersionFileName = ClientContext.Singleton.UserProfileCurrentVersionFileName;
            var nonRoamingProfilePath = Path.Combine(currentUserNonRoamingDirectory.FullName, userProfileCurrentVersionFileName);
            return nonRoamingProfilePath;
        }


        private Profile RetrieveUserProfile()
        {
            Profile profile = null;

            var profilePath = RoamingProfilePath();

            if (File.Exists(profilePath))
            {
                profile = ReadProfileFromFile(profilePath);
            }
            // else
            // {
            //     profilePath = NonRoamingProfilePath();
            //     if (File.Exists(profilePath))
            //     {
            //         profile = ReadProfileFromFile(profilePath);
            //     }
            // }

            return profile;
        }

        private Profile ReadProfileFromFile(string profilePath)
        {
            using var fileStream = new FileStream(profilePath, FileMode.Open, FileAccess.Read);
            return (Profile) ReadObjectFromFile(fileStream);
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