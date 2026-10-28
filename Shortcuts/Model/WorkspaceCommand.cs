using System.Windows.Forms;
using DevExpress.Utils.Svg;

namespace Shortcuts.Model
{
    public class WorkspaceCommand
    {
        public string Workspace { get; set; }
        public string Category { get; set; }
        public string CommandId { get; set; }
        public string Hint { get; set; }
        public Keys ShortcutKeys { get; set; }
        public SvgImage SvgImage { get; set; }

        public string DisplayName => !string.IsNullOrEmpty(Hint) ? Hint : CommandId;

        public override string ToString() => DisplayName;
    }
}
