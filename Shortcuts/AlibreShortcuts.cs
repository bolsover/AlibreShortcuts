using System;
using AlibreAddOn;
using AlibreX;
using Shortcuts.View;

namespace Shortcuts
{
    public class AlibreShortcuts : IAlibreAddOn
    {
        private const int MenuIdRoot = 401;
        private const int MenuIdShortcuts = 402;
        private const int MenuIdKeyboard = 403;
        private int[] _menuIdsRoot;

        private IADRoot _alibreRoot;
        private IntPtr _parentWinHandle;
        private KeyboardShortcutForm _keyboardShortcutForm;
        private KeyboardForm _keyboardForm;

        public AlibreShortcuts(IADRoot alibreRoot, IntPtr parentWinHandle)
        {
            _alibreRoot = alibreRoot;
            _parentWinHandle = parentWinHandle;
            BuildMenu();
        }

        private void BuildMenu()
        {
            _menuIdsRoot = new[]
            {
                MenuIdShortcuts,
                MenuIdKeyboard
            };
        }

        public int RootMenuItem => MenuIdRoot;

        public bool HasSubMenus(int menuId)
        {
            return menuId == MenuIdRoot;
        }

        public Array SubMenuItems(int menuId)
        {
            if (menuId == MenuIdRoot)
            {
                return _menuIdsRoot;
            }

            return null;
        }

        public string MenuItemText(int menuId)
        {
            switch (menuId)
            {
                case MenuIdRoot:
                    return "Shortcuts";
                case MenuIdShortcuts:
                    return "Shortcuts";
                case MenuIdKeyboard:
                    return "Keyboard";
            }

            return "";
        }

        public bool PopupMenu(int menuId)
        {
            return false;
        }

        public ADDONMenuStates MenuItemState(int menuId, string sessionIdentifier)
        {
            return ADDONMenuStates.ADDON_MENU_ENABLED;
        }

        public string MenuItemToolTip(int menuId)
        {
            return "Opens a simple window with a listing of available shortcuts. You can add your own shortcuts using the system options keyboard shortcuts dialog.";
        }

        public string MenuIcon(int menuId)
        {
            return "shortcuts.svg";
        }

        public bool HasPersistentDataToSave(string sessionIdentifier)
        {
            return false;
        }

        public IAlibreAddOnCommand InvokeCommand(int menuId, string sessionIdentifier)
        {
            var session = _alibreRoot?.Sessions?.Item(sessionIdentifier);
            switch (menuId)
            {
                case MenuIdShortcuts:
                    return DoShortcuts(session);
                case MenuIdKeyboard:
                    return DoKeyboard(session);
            }

            return null;
        }

        private IAlibreAddOnCommand DoKeyboard(IADSession session)
        {
            if (_keyboardForm == null || _keyboardForm.IsDisposed)
            {
                _keyboardForm = KeyboardForm.Instance();
                if (_keyboardForm.keyboardControl1?.ProfileComboBox?.Items.Count > 0)
                {
                    _keyboardForm.keyboardControl1.ProfileComboBox.SelectedIndex = 0;
                }
                _keyboardForm.TopMost = true;
            }
            else
            {
                _keyboardForm = KeyboardForm.Instance();
                _keyboardForm.TopMost = true;
            }

            return null;
        }

        private IAlibreAddOnCommand DoShortcuts(IADSession session)
        {
            if (_keyboardShortcutForm == null || _keyboardShortcutForm.IsDisposed)
            {
                _keyboardShortcutForm = KeyboardShortcutForm.Instance();
                if (_keyboardShortcutForm.comboBox1?.Items.Count > 0)
                {
                    _keyboardShortcutForm.comboBox1.SelectedIndex = 0;
                }
                _keyboardShortcutForm.TopMost = true;
            }
            else
            {
                _keyboardShortcutForm.Visible = true;
                _keyboardShortcutForm.TopMost = true;
            }

            return null;
        }

        public void LoadData(IStream pCustomData, string sessionIdentifier)
        {
        }

        public void SaveData(IStream pCustomData, string sessionIdentifier)
        {
        }

        public void setIsAddOnLicensed(bool isLicensed)
        {
        }

        public bool UseDedicatedRibbonTab()
        {
            return false;
        }
    }
}
