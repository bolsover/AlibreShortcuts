using System;
using System.Windows.Forms;
using com.alibre.client;
using com.alibre.ui;
using com.objectspace.jgl;
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
            InitDropDown();


            FormClosing += (sender, args) =>
            {
                ((KeyboardShortcutForm) sender).Visible = false;
                args.Cancel = true;
            };
        }


        /// <summary>
        /// Retrieves the list of workspace prefixes from the KeyboardShortcutsMediator and populates the drop down
        /// The list depends on user license type (Atom or Pro)
        /// </summary>
        private void InitDropDown()
        {
            var workspacePrefixes = ClientContext.Singleton.IsAtom
                ? KeyboardShortcutsMediator.ATOM_WORKSPACE_PREFIXES
                : KeyboardShortcutsMediator.ALL_WORKSPACE_PREFIXES;
            comboBox1.Items.AddRange(workspacePrefixes);
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