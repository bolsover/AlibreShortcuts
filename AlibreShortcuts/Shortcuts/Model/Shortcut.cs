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

        
        public string ToTableRow()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<tr>");
        sb.Append("<td>");
        sb.Append(Profile);
        sb.Append("</td>");
        sb.Append("<td>");
        sb.Append(Command);
        sb.Append("</td>");
        sb.Append("<td>");
        sb.Append(Hint);
        sb.Append("</td>");
        sb.Append("<td>");
        sb.Append(Keycode);
        sb.Append("</td>");
        sb.Append("<td>");
        sb.Append(KeyChar);
        sb.Append("</td>");
        sb.Append("</tr>");
        
        return sb.ToString();
    }

   
    }
    public enum ShortcutType
    {
        Custom,
        Override,
        Default
    }
}