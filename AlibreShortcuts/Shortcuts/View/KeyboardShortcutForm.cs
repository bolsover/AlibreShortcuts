using System;
using System.Windows.Forms;
using Shortcuts.Shortcuts.Calculator;

namespace Shortcuts.Shortcuts.View
{
    public partial class KeyboardShortcutForm : Form
    {
        private static KeyboardShortcutForm _instance;
        private readonly ShortcutsHtmlReport _shortcutsHtmlReport = new();

        public KeyboardShortcutForm()
        {
            InitializeComponent();
            Icon = Globals.Icon;

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
            var profile = comboBox1.SelectedItem.ToString();
            var html = _shortcutsHtmlReport.BuildHtmlReport(profile);

            webBrowser1.DocumentText = html;
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

   }
}