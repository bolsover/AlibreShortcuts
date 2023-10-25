using System.Windows.Forms;
using AlibreX;

namespace Bolsover.Sample
{
    public partial class SampleUserControl : UserControl
    {
        private IADSession _session;

        public SampleUserControl(IADSession session)
        {
            this._session = session;
            InitializeComponent();
        }

        public void AppendText(string text)
        {
            textBox.DocumentText = text;
            
        }
    }
}