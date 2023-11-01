using System.Drawing;
using Shortcuts.Model;

namespace Shortcuts.Shortcuts.View
{
    public class KeyProperties
    {
        public string Name { get; set; }
        public string KeyValue { get; set; }
        public string Description { get; set; }
        public Color KeyColor { get; set; }
        public Color TextColor { get; set; }
        public bool IsEnabled { get; set; }
        public Shortcut Shortcut { get; set; }     
    }
}