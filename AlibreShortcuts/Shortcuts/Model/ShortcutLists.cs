using System.Collections.Generic;

namespace Bolsover.Shortcuts.Model
{
    /// <summary>
    /// Class to hold all the categorised shortcuts for a given profile
    /// </summary>
    public class ShortcutLists
    {
        public Dictionary<int, Shortcut> CtrlAltShiftShortcuts { get; set; }

        public Dictionary<int, Shortcut> CtrlAltShortcuts { get; set; }

        public Dictionary<int, Shortcut> CtrlShiftShortcuts { get; set; }

        public Dictionary<int, Shortcut> CtrlShortcuts { get; set; }

        public Dictionary<int, Shortcut> AltShiftShortcuts { get; set; }

        public Dictionary<int, Shortcut> AltShortcuts { get; set; }

        public Dictionary<int, Shortcut> ShiftShortcuts { get; set; }

        public Dictionary<int, Shortcut> NoModifierShortcuts { get; set; }
    }
}