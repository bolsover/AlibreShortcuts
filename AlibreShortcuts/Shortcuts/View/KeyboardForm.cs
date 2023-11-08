using System.Windows.Forms;
using Shortcuts;

namespace Bolsover.Shortcuts.View
{
    public partial class KeyboardForm : Form
    {
        
        private static KeyboardForm _instance;
        private KeyboardForm()
        {
            InitializeComponent();
            Icon = Globals.Icon;
           // InitDropDown();


            FormClosing += (sender, args) =>
            {
                ((KeyboardForm) sender).Visible = false;
                args.Cancel = true;
            };
        }
        
        public static KeyboardForm Instance()
        {
            if (_instance == null)
            {
                _instance = new KeyboardForm();
            }

            _instance.Visible = true;

            return _instance;
        }

    }
}