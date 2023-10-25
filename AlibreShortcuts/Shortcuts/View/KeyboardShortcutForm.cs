using System;
using System.Collections;
using System.Windows.Forms;
using Shortcuts.Shortcuts.Calculator;

namespace Shortcuts.Shortcuts.View
{
    public partial class KeyboardShortcutForm : Form
    {
    private static KeyboardShortcutForm _instance;
    private ShortcutsCalculator shortcutsCalculator = new ShortcutsCalculator();    
       
   
        public KeyboardShortcutForm()
        {
            ArrayList userShortcuts = shortcutsCalculator.RetrieveUserShortcutsByProfile("Design Part Browser");
            InitializeComponent();
          //  Icon = Globals.Icon;
        
            FormClosing += (sender, args) =>
            {
                ((KeyboardShortcutForm) sender).Visible = false;
                args.Cancel = true;
            };
        }
        
        public static KeyboardShortcutForm Instance()
        {
            if (_instance == null)
            {
                _instance = new KeyboardShortcutForm();
            }

            _instance.Visible = true;
            
            return _instance;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          string profile = comboBox1.SelectedItem.ToString();
          ArrayList userShortcuts = shortcutsCalculator.RetrieveUserShortcutsByProfile(profile);
         
          webBrowser1.DocumentText = shortcutsCalculator.AddHtmlHeaderFooter(shortcutsCalculator.ToAbbreviatedTable(userShortcuts));
        }
    }
}