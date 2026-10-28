using System;
using System.IO;
using System.Windows.Forms;
using Shortcuts.Calculator;
using com.alibre.client;
using com.alibre.ui;

namespace Shortcuts.View
{
    public partial class KeyboardShortcutForm : Form
    {
        private static KeyboardShortcutForm _instance;
        private readonly HtmlReport _htmlReport = new();
        private readonly ShortcutsCalculator _shortcutsCalculator = new();
        private DateTime _lastBackupTime = DateTime.MinValue;
        
        private KeyboardShortcutForm()
        {
            InitializeComponent();
            Icon = Globals.Icon;
            InitDropDown();
            
            
            FormClosing += (sender, args) =>
            {
                ((KeyboardShortcutForm) sender).Visible = false;
                args.Cancel = true;
            };

            VisibleChanged += (sender, args) =>
            {
                if (Visible)
                {
                    BackupProfile();
                }
            };
        }

        public void BackupProfile()
        {
            try
            {
                if ((DateTime.Now - _lastBackupTime).TotalSeconds < 1)
                {
                    return;
                }

                _lastBackupTime = DateTime.Now;
                _shortcutsCalculator.BackupUserProfile();
            }
            catch
            {
            }
        }
        
        /// <summary>
        ///     Retrieves the list of workspace prefixes from the KeyboardShortcutsMediator and populates the drop down
        ///     The list depends on user license type (Atom or Pro)
        /// </summary>
        private void InitDropDown()
        {
            var isAtom = false;
            try
            {
                isAtom = ShortcutsCalculator.SafeClientContext?.IsAtom ?? false;
            }
            catch
            {
            }

            var workspacePrefixes = isAtom
                ? KeyboardShortcutsMediator.ATOM_WORKSPACE_PREFIXES
                : KeyboardShortcutsMediator.ALL_WORKSPACE_PREFIXES;
            comboBox1.Items.AddRange(workspacePrefixes);
        }
        
        public static KeyboardShortcutForm Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new KeyboardShortcutForm();
            }
            
            _instance.BackupProfile();
            _instance.Visible = true;
            
            return _instance;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }

        public void RefreshReport()
        {
            if (comboBox1.SelectedItem == null) return;
            var profile = comboBox1.SelectedItem.ToString();
            
            var html = _htmlReport.BuildReport(profile);
            webBrowser1.DocumentText = html;
        }

        public static void RefreshIfVisible()
        {
            if (_instance != null && !_instance.IsDisposed && _instance.Visible)
            {
                _instance.RefreshReport();
            }
        }
        
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML page|*.html";
            saveFileDialog1.Title = "Save as HTML Page";
            saveFileDialog1.ShowDialog();
            
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName == "") return;
            // Saves the Image via a FileStream created by the OpenFile method.
            var fs =
                (FileStream) saveFileDialog1.OpenFile();
            
            var documentStream = webBrowser1.DocumentStream;
            if (documentStream != null)
            {
                documentStream.CopyTo(fs);
                documentStream.Close();
            }
            
            fs.Close();
        }
    }
}