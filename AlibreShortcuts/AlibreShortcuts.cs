using System;
using AlibreAddOn;
using AlibreX;
using Bolsover.Shortcuts.View;
using Shortcuts.Shortcuts.View;
using Array = System.Array;

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

        public AlibreShortcuts(IADRoot alibreRoot, IntPtr parentWinHandle)
        {
            _alibreRoot = alibreRoot;
            _parentWinHandle = parentWinHandle;
            BuildMenu();
        }

        #region Menus

        private void BuildMenu()
        {
            _menuIdsRoot = new int[2]
            {
                MenuIdShortcuts, MenuIdKeyboard
            };
        }

        /// <summary>
        /// Returns the menu ID of the add-on's root menu item
        /// </summary>
        public int RootMenuItem => MenuIdRoot;

        /// <summary>
        /// Description("Returns Whether the given Menu ID has any sub menus")
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public bool HasSubMenus(int menuId)
        {
            switch (menuId)
            {
                case MenuIdRoot:
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Returns the ID's of sub menu items under a popup menu item; the menu ID of a 'leaf' menu becomes its command ID
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public Array SubMenuItems(int menuId)
        {
            switch (menuId)
            {
                case MenuIdRoot:
                    return _menuIdsRoot;
            }

            return null;
        }

        /// <summary>
        /// Returns the display name of a menu item; a menu item with text of a single dash (“-“) is a separator
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public string MenuItemText(int menuId)
        {
            switch (menuId)
            {
                case MenuIdRoot:
                    return "Shortcuts";
                case MenuIdShortcuts: return "Shortcuts";
                case MenuIdKeyboard: return "Keyboard";
            }

            return "";
        }

        /// <summary>
        /// Returns True if input menu item has sub menus // seems odd given name of method
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public bool PopupMenu(int menuId)
        {
            return false;
        }

        /// <summary>
        /// Returns property bits providing information about the state of a menu item
        /// ADDON_MENU_ENABLED = 1,
        /// ADDON_MENU_GRAYED = 2,
        /// ADDON_MENU_CHECKED = 3,
        /// ADDON_MENU_UNCHECKED = 4,
        /// </summary>
        /// <param name="menuId"></param>
        /// <param name="sessionIdentifier"></param>
        /// <returns></returns>
        public ADDONMenuStates MenuItemState(int menuId, string sessionIdentifier)
        {
            //var session = _alibreRoot.Sessions.Item(sessionIdentifier);
            return ADDONMenuStates.ADDON_MENU_ENABLED;
        }

        /// <summary>
        /// Returns a tool tip string if input menu ID is that of a 'leaf' menu item
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public string MenuItemToolTip(int menuId)
        {
            return
                "Opens a simple window with a listing of available shortcuts. You can should add your own shortcuts using the system options keyboard shortcuts dialog.";
        }

        /// <summary>
        /// Returns the icon name (with extension) for a menu item; the icon will be searched under the folder where the add-on's .adc file is present
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public string MenuIcon(int menuId)
        {
            return "shortcuts.svg";
        }

        /// <summary>
        /// Returns True if AddOn has updated Persistent Data
        /// </summary>
        /// <param name="sessionIdentifier"></param>
        /// <returns></returns>
        public bool HasPersistentDataToSave(string sessionIdentifier)
        {
            return false;
        }

        /// <summary>
        /// Invokes the add-on command identified by menu ID; returning the add-on command interface is optional
        /// </summary>
        /// <param name="menuId"></param>
        /// <param name="sessionIdentifier"></param>
        /// <returns></returns>
        public IAlibreAddOnCommand InvokeCommand(int menuId, string sessionIdentifier)
        {
            var session = _alibreRoot.Sessions.Item(sessionIdentifier);
            switch (menuId)
            {
                case MenuIdShortcuts:
                    return DoShortcuts(session);
                case MenuIdKeyboard:
                    return DoKeyboard(session);
            }

            return null;
        }

        #endregion

        private KeyboardForm keyboardForm;

        private IAlibreAddOnCommand DoKeyboard(IADSession session)
        {
            if (keyboardForm == null)
            {
                keyboardForm = KeyboardForm.Instance();
                keyboardForm.keyboardControl1.ProfileComboBox.SelectedIndex = 0;
                keyboardForm.TopMost = true;
            }
            else
            {
                keyboardForm.Visible = true;
                keyboardForm.TopMost = true;
            }

            return null;
        }

        #region Shortcuts

        private KeyboardShortcutForm keyboardShortcutForm;

        private IAlibreAddOnCommand DoShortcuts(IADSession session)
        {
            if (keyboardShortcutForm == null)
            {
                keyboardShortcutForm = KeyboardShortcutForm.Instance();
                keyboardShortcutForm.comboBox1.SelectedIndex = 0;
                keyboardShortcutForm.TopMost = true;
            }
            else
            {
                keyboardShortcutForm.Visible = true;
                keyboardShortcutForm.TopMost = true;
            }

            return null;
        }

        #endregion

        /// <summary>
        /// Loads Data from AddOn
        /// </summary>
        /// <param name="pCustomData"></param>
        /// <param name="sessionIdentifier"></param>
        public void LoadData(IStream pCustomData, string sessionIdentifier)
        {
        }

        /// <summary>
        /// Saves Data to AddOn
        /// </summary>
        /// <param name="pCustomData"></param>
        /// <param name="sessionIdentifier"></param>
        public void SaveData(IStream pCustomData, string sessionIdentifier)
        {
        }

        /// <summary>
        /// Sets the IsLicensed bit for the tightly coupled Add-on
        /// </summary>
        /// <param name="isLicensed"></param>
        public void setIsAddOnLicensed(bool isLicensed)
        {
        }

        /// <summary>
        /// Returns True if the AddOn needs to use a Dedicated Ribbon Tab
        /// </summary>
        /// <returns></returns>
        public bool UseDedicatedRibbonTab()
        {
            return false;
        }
    }
}