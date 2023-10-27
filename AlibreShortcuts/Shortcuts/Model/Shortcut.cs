using System.Collections.Generic;
using System.Text;

namespace Shortcuts.Model
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

        
  
    }
    public enum ShortcutType
    {
        Custom,
        Override,
        Default
    }
}