namespace Bolsover.Shortcuts.Model
{
    public class Shortcut
    {
        public Shortcut(string profile, string command, string hint, int keycode, string keyChar)
        {
            Profile = profile;
            Command = command;
            Hint = hint;
            Keycode = keycode;
            KeyChar = keyChar;
        }

        public string Profile { get; set; }
        public string Command { get; set; }
        public string Hint { get; set; }
        public int Keycode { get; set; }
        public string KeyChar { get; set; }
        public ShortcutType ShortcutType { get; set; }

      
        public int GetNonModifierCode(int code, out ShortcutModifierType shortcutModifierType)
        {
           
                const int meta = 1048576;
                const int alt = 262144;
                const int ctrl = 131072;
                const int shift = 65536;
                bool isMeta = false;
                bool isAlt = false;
                bool isCtrl = false;
                bool isShift = false;

               
                if (code >= meta)
                {
                    isMeta = true; // Keycode for Windows/Command key
                    code -= meta;
                }

                if (code >= alt)
                {
                    isAlt = true; // Keycode for Alt
                    code -= alt;
                }

                if (code >= ctrl)
                {
                    isCtrl = true; // Keycode for Control
                    code -= ctrl;
                }

                if (code >= shift)
                {
                    isShift = true; // Keycode for Shift
                    code -= shift;
                }
                shortcutModifierType = ShortcutModifierType.None;
                if (isMeta)
                {
                    shortcutModifierType = ShortcutModifierType.Meta;
                }
                if (isCtrl && isAlt && isShift)
                {
                    shortcutModifierType = ShortcutModifierType.CtrlAltShift;
                }
                else if (isCtrl && isAlt)
                {
                    shortcutModifierType = ShortcutModifierType.CtrlAlt;
                }
                else if (isCtrl && isShift)
                {
                    shortcutModifierType = ShortcutModifierType.CtrlShift;
                }
                else if (isAlt && isShift)
                {
                    shortcutModifierType = ShortcutModifierType.AltShift;
                }
                else if (isCtrl)
                {
                    shortcutModifierType = ShortcutModifierType.Ctrl;
                }
                else if (isAlt)
                {
                    shortcutModifierType = ShortcutModifierType.Alt;
                }
                else if (isShift)
                {
                    shortcutModifierType = ShortcutModifierType.Shift;
                }
                // Remaining value is the ASCII value of the key pressed
                return code;


        }
    }
    public enum ShortcutType
    {
        Custom,
        Override,
        Default
    }
    
    public enum ShortcutModifierType
    {
        None,
        Ctrl,
        Alt,
        Shift,
        CtrlAlt,
        CtrlShift,
        AltShift,
        CtrlAltShift,
        Meta
     
    }
}