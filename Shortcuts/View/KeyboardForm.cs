using System;
using System.Windows.Forms;
using Shortcuts;
using Shortcuts.Calculator;

namespace Shortcuts.View
{
    public partial class KeyboardForm : Form
    {
        private static KeyboardForm _instance;
        private readonly ShortcutsCalculator _shortcutsCalculator = new();
        private DateTime _lastBackupTime = DateTime.MinValue;
        
        private KeyboardForm()
        {
            InitializeComponent();
            Icon = Globals.Icon;
            
            Text = "Keyboard Shortcuts";
            
            FormClosing += (sender, args) =>
            {
                ((KeyboardForm) sender).Visible = false;
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
        
        public static KeyboardForm Instance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new KeyboardForm();
            }
            
            _instance.BackupProfile();
            _instance.Visible = true;
            
            return _instance;
        }
    }
}