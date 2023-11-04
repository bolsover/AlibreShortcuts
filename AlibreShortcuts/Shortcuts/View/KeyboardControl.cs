using System.Windows.Forms;
using Bolsover.Shortcuts.Presenter;


namespace Bolsover.Shortcuts.View
{
    public partial class KeyboardControl : UserControl
    {
    
        public KeyboardControl()
        {
            InitializeComponent();
            new KeyboardPresenter(this);
           
        }

        
    }
}