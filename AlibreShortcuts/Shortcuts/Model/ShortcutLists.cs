using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public void InitializeShortcutLists()
        {
            AltShortcuts = new Dictionary<int, Shortcut>();
            AltShiftShortcuts = new Dictionary<int, Shortcut>();
            CtrlShortcuts = new Dictionary<int, Shortcut>();
            CtrlAltShortcuts = new Dictionary<int, Shortcut>();
            CtrlAltShiftShortcuts = new Dictionary<int, Shortcut>();
            CtrlShiftShortcuts = new Dictionary<int, Shortcut>();
            ShiftShortcuts = new Dictionary<int, Shortcut>();
            NoModifierShortcuts = new Dictionary<int, Shortcut>();
        }

        public void AddShortcutToAppropriateList(ShortcutModifierType shortcutModifierType, int nonModifierCode, Shortcut sc)
        {
            switch (shortcutModifierType)
            {
                case ShortcutModifierType.Alt:
                    AddShortcut(AltShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.AltShift:
                    AddShortcut(AltShiftShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.Ctrl:
                    AddShortcut(CtrlShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.CtrlAlt:
                    AddShortcut(CtrlAltShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.CtrlAltShift:
                    AddShortcut(CtrlAltShiftShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.CtrlShift:
                    AddShortcut(CtrlShiftShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.Shift:
                    AddShortcut(ShiftShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.None:
                    AddShortcut(NoModifierShortcuts, nonModifierCode, sc);
                    break;
                case ShortcutModifierType.Meta: break;
                default: throw new ArgumentOutOfRangeException();
            }
        }
        
        private static void AddShortcut(Dictionary<int, Shortcut> shortcutList, int nonModifierCode, Shortcut sc)
        {
            try
            {
                if (shortcutList.ContainsKey(nonModifierCode))
                {
                    shortcutList.Remove(nonModifierCode);
                }

                shortcutList.Add(nonModifierCode, sc);
            }
            catch (ArgumentException e1)
            {
                // Console.WriteLine(e1);
                MessageBox.Show("Duplicate key code: " + nonModifierCode + " for shortcut: " + sc.Hint);
            }
        }
    }
}