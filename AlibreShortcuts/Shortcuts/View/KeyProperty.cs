using System.Drawing;
using Bolsover.Shortcuts.Model;

namespace Bolsover.Shortcuts.View
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