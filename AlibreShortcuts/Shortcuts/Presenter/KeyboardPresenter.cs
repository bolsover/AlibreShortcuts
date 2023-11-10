using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bolsover.Shortcuts.Calculator;
using Bolsover.Shortcuts.Model;
using Bolsover.Shortcuts.Utils;
using Bolsover.Shortcuts.View;
using com.alibre.client;
using com.alibre.ui;
using Shortcut = Bolsover.Shortcuts.Model.Shortcut;

namespace Bolsover.Shortcuts.Presenter
{
    public class KeyboardPresenter
    {
        private readonly KeyboardControl _view;
        private readonly KeyText _keyText = new();
        private bool _isCtrlSelected;
        private bool _isAltSelected;
        private bool _isShiftSelected;
        private readonly ShortcutsCalculator _shortcutsCalculator = new();
        private readonly ShortcutLists _shortcutLists = new();
        private Color ctrlAltShiftColor = Color.Red;
        private Color ctrlAltColor = Color.Orange;
        private Color ctrlShiftColor = Color.Gold;
        private Color altShiftColor = Color.Chartreuse;
        private Color ctrlColor = Color.CornflowerBlue;
        private Color altColor = Color.MediumOrchid;
        private Color shiftColor = Color.Violet;
        private Color noModifierColor = Color.Bisque;
        private Color defaultModifierKeyColor = Color.Bisque;

        public KeyboardPresenter(KeyboardControl view)
        {
            _view = view;
            SetupKeyImageLocation();
            SetupKeyImages("Arial Narrow", 8, Color.Empty, Color.Black);
            ClearDefaultText();
            DoDataBindings();
            DisabledKeys();
            DefaultBackColors();
            TextOverlayLocation();
            TextOverlayFont(new Font("Arial Narrow", 8F, FontStyle.Regular, GraphicsUnit.Point, 0));
            InitDropDown();
        }

        /// <summary>
        /// Clears any existing background colors and text from the keyboard buttons passed in the dictionary.
        /// </summary>
        /// <param name="buttonDictionary"></param>
        private void ClearBackgroundColorsAndText(Dictionary<string, Button> buttonDictionary)
        {
            foreach (var key in buttonDictionary)
            {
                key.Value.BackColor = Color.Empty;
                key.Value.Text = "";
            }
        }

        
        /// <summary>
        /// Event handler for the ProfileComboBox's SelectedIndexChanged event.
        /// This method is triggered when the selected item in the ProfileComboBox is changed.
        /// It retrieves the shortcuts for the selected profile, initializes the shortcut lists,
        /// clears the background colors and text of the keyboard buttons, and then applies the shortcuts to the keyboard.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        public void ProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profile = _view.ProfileComboBox.SelectedItem.ToString();
            ArrayList shortcuts = _shortcutsCalculator.RetrieveUserShortcutsByProfile(profile);
            // guard against null or empty list
            if (shortcuts == null || shortcuts.Count == 0)
            {
                shortcuts = _shortcutsCalculator.RetrieveStandardShortcutsByProfile(profile);
            }
            _shortcutLists.InitializeShortcutLists();
            ClearBackgroundColorsAndText(KeyButtons.ButtonDictionaryExcModifiers(_view));

            foreach (Shortcut sc in shortcuts)
            {
                // omit any shortcuts that don't have a hint
                if (sc.Hint == null)
                {
                    continue;
                }

                var nonModifierCode = sc.GetNonModifierCode(sc.Keycode, out var shortcutModifierType);
                _shortcutLists.AddShortcutToAppropriateList(shortcutModifierType, nonModifierCode, sc);
            }

            ShowShortcutsByModifierType();
        }

        /// <summary>
        /// Applies the background color and text to the keyboard buttons based on the shortcut list passed in.
        /// </summary>
        /// <param name="shortCutList">A dictionary of key-value pairs where the key is the key code and the value is the Shortcut object.</param>
        /// <param name="backColor">The background color to be applied to the keyboard buttons.</param>
        private void ApplyShortcutsBasedOnKeys(Dictionary<int, Shortcut> shortCutList, Color backColor)
        {
            // Get the dictionary of key codes by index
            var dictionary = KeyCodes.KeyCodesDictionaryByIndex();

            // Iterate over each item in the shortcut list
            foreach (var v in shortCutList)
            {
                // Try to get the KeyCodes object from the dictionary using the key from the shortcut list
                // If the key is not found in the dictionary, skip the current iteration
                if (!dictionary.TryGetValue(v.Key, out KeyCodes kc))
                {
                    continue;
                }

                // Get the button corresponding to the key name from the KeyButtons class
                // If the button is not found, skip the current iteration
                Button button = KeyButtons.GetButton(_view, kc.KeyName);
                if (button == null)
                {
                    continue;
                }

                // Set the background color and text of the button
                button.BackColor = backColor;
                button.Text = v.Value.Hint;
            }
        }

        /// <summary>
        /// Clears any existing background color and text from the keyboard buttons.
        /// Sets the background color and text based on the modifier keys selected.
        /// </summary>
        private void ShowShortcutsByModifierType()
        {
            // clear all selections except modifier keys
            ClearBackgroundColorsAndText(KeyButtons.ButtonDictionaryExcModifiers(_view));

            if (_isCtrlSelected && _isAltSelected && _isShiftSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.CtrlAltShiftShortcuts, ctrlAltShiftColor);
                _view.LeftCtrlKey.BackColor = ctrlAltShiftColor;
                _view.RightCtrlKey.BackColor = ctrlAltShiftColor;
                _view.LeftAltKey.BackColor = ctrlAltShiftColor;
                _view.AltGrKey.BackColor = ctrlAltShiftColor;
                _view.LeftShiftKey.BackColor = ctrlAltShiftColor;
                _view.RightShiftKey.BackColor = ctrlAltShiftColor;
                _view.ModifierText.Text = "Ctrl+Alt+Shift+";
            }
            else if (_isCtrlSelected && _isAltSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.CtrlAltShortcuts, ctrlAltColor);
                _view.LeftCtrlKey.BackColor = ctrlAltColor;
                _view.RightCtrlKey.BackColor = ctrlAltColor;
                _view.LeftAltKey.BackColor = ctrlAltColor;
                _view.AltGrKey.BackColor = ctrlAltColor;
                _view.ModifierText.Text = "Ctrl+Alt+";
            }
            else if (_isCtrlSelected && _isShiftSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.CtrlShiftShortcuts, ctrlShiftColor);
                _view.LeftCtrlKey.BackColor = ctrlShiftColor;
                _view.RightCtrlKey.BackColor = ctrlShiftColor;
                _view.LeftShiftKey.BackColor = ctrlShiftColor;
                _view.RightShiftKey.BackColor = ctrlShiftColor;
                _view.ModifierText.Text = "Ctrl+Shift+";
            }
            else if (_isAltSelected && _isShiftSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.AltShiftShortcuts, altShiftColor);
                _view.LeftAltKey.BackColor = altShiftColor;
                _view.AltGrKey.BackColor = altShiftColor;
                _view.LeftShiftKey.BackColor = altShiftColor;
                _view.RightShiftKey.BackColor = altShiftColor;
                _view.ModifierText.Text = "Alt+Shift+";
            }
            else if (_isCtrlSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.CtrlShortcuts, ctrlColor);
                _view.LeftCtrlKey.BackColor = ctrlColor;
                _view.RightCtrlKey.BackColor = ctrlColor;
                _view.ModifierText.Text = "Ctrl+";
            }
            else if (_isAltSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.AltShortcuts, altColor);
                _view.LeftAltKey.BackColor = altColor;
                _view.AltGrKey.BackColor = altColor;
                _view.ModifierText.Text = "Alt+";
            }
            else if (_isShiftSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.ShiftShortcuts, shiftColor);
                _view.LeftShiftKey.BackColor = shiftColor;
                _view.RightShiftKey.BackColor = shiftColor;
                _view.ModifierText.Text = "Shift+";
            }

            else if (!_isCtrlSelected && !_isAltSelected && !_isShiftSelected)
            {
                ApplyShortcutsBasedOnKeys(_shortcutLists.NoModifierShortcuts, noModifierColor);
                _view.ModifierText.Text = "No Modifier";
            }
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
            _view.ProfileComboBox.Items.AddRange(workspacePrefixes);
        }

        /// <summary>
        /// Sets the font of the text overlay on the key buttons.
        /// </summary>
        /// <param name="font"></param>
        private void TextOverlayFont(Font font)
        {
            foreach (var key in KeyButtons.ButtonDictionary(_view))
            {
                key.Value.Font = font;
            }
        }

        /// <summary>
        /// Sets the location of the text overlay on the key buttons to the top left.
        /// </summary>
        private void TextOverlayLocation()
        {
            foreach (var key in KeyButtons.ButtonDictionary(_view))
            {
                key.Value.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            }
        }

        public void ViewCtrl_Click(object sender, EventArgs e)
        {
            _isCtrlSelected = !_isCtrlSelected;
            if (!_isCtrlSelected)
            {
                _view.LeftCtrlKey.BackColor = defaultModifierKeyColor;
                _view.RightCtrlKey.BackColor = defaultModifierKeyColor;
            }

            ShowShortcutsByModifierType();
        }

        public void ViewAlt_Click(object sender, EventArgs e)
        {
            _isAltSelected = !_isAltSelected;
            if (!_isAltSelected)
            {
                _view.LeftAltKey.BackColor = defaultModifierKeyColor;
                _view.AltGrKey.BackColor = defaultModifierKeyColor;
            }

            ShowShortcutsByModifierType();
        }

        public void ViewShift_Click(object sender, EventArgs e)
        {
            _isShiftSelected = !_isShiftSelected;
            if (!_isShiftSelected)
            {
                _view.LeftShiftKey.BackColor = defaultModifierKeyColor;
                _view.RightShiftKey.BackColor = defaultModifierKeyColor;
            }

            ShowShortcutsByModifierType();
        }

        private void DefaultBackColors()
        {
            KeyButtons.GetButton(_view, "LeftCtrlKey").BackColor = defaultModifierKeyColor;
            KeyButtons.GetButton(_view, "RightCtrlKey").BackColor = defaultModifierKeyColor;
            KeyButtons.GetButton(_view, "LeftShiftKey").BackColor = defaultModifierKeyColor;
            KeyButtons.GetButton(_view, "RightShiftKey").BackColor = defaultModifierKeyColor;
            KeyButtons.GetButton(_view, "LeftAltKey").BackColor = defaultModifierKeyColor;
            KeyButtons.GetButton(_view, "AltGrKey").BackColor = defaultModifierKeyColor;
        }

        private void DisabledKeys()
        {
            KeyButtons.GetButton(_view, "CapsLockKey").Enabled = false;
            KeyButtons.GetButton(_view, "ScrollLockKey").Enabled = false;
            KeyButtons.GetButton(_view, "NumLockKey").Enabled = false;
            KeyButtons.GetButton(_view, "PrintScreenKey").Enabled = false;
            KeyButtons.GetButton(_view, "PauseBreakKey").Enabled = false;
            KeyButtons.GetButton(_view, "FnKey").Enabled = false;
            KeyButtons.GetButton(_view, "WindowKey").Enabled = false;
            KeyButtons.GetButton(_view, "NumDivideKey").Enabled = false;
            KeyButtons.GetButton(_view, "NumMultiplyKey").Enabled = false;
            KeyButtons.GetButton(_view, "NumEnterKey").Enabled = false;
            KeyButtons.GetButton(_view, "TabKey").Enabled = false;
            KeyButtons.GetButton(_view, "WindowKey").Enabled = false;
        }

        private void DoDataBinding(Control key, string keyTextName)
        {
            key.DataBindings.Add(new Binding("Text", _keyText, keyTextName, true, DataSourceUpdateMode.OnPropertyChanged));
        }

        /// <summary>
        /// Binds the text property of the key buttons to the KeyText class.
        /// </summary>
        private void DoDataBindings()
        {
            foreach (KeyValuePair<string, Button> key in KeyButtons.ButtonDictionary(_view))
            {
                DoDataBinding(key.Value, key.Key + "Text");
            }
        }

        /// <summary>
        /// Clears any default text from the keys.
        /// </summary>
        private void ClearDefaultText()
        {
            foreach (KeyValuePair<string, Button> key in KeyButtons.ButtonDictionary(_view))
            {
                key.Value.Text = "";
            }
        }

        /// <summary>
        /// Sets the location of the text overlay on the key images to the bottom right.
        /// </summary>
        private void SetupKeyImageLocation()
        {
            foreach (KeyValuePair<string, Button> key in KeyButtons.ButtonDictionary(_view))
            {
                key.Value.ImageAlign = ContentAlignment.BottomRight;
            }
        }

        private void SetupKeyImages(string fontName, int size, Color bgColor, Color fgColor)
        {
            _view.F1Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F1Key, fontName, size, bgColor, fgColor);
            _view.F2Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F2Key, fontName, size, bgColor, fgColor);
            _view.F3Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F3Key, fontName, size, bgColor, fgColor);
            _view.F4Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F4Key, fontName, size, bgColor, fgColor);
            _view.F5Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F5Key, fontName, size, bgColor, fgColor);
            _view.F6Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F6Key, fontName, size, bgColor, fgColor);
            _view.F7Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F7Key, fontName, size, bgColor, fgColor);
            _view.F8Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F8Key, fontName, size, bgColor, fgColor);
            _view.F9Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F9Key, fontName, size, bgColor, fgColor);
            _view.F10Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F10Key, fontName, size, bgColor, fgColor);
            _view.F11Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F11Key, fontName, size, bgColor, fgColor);
            _view.F12Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F12Key, fontName, size, bgColor, fgColor);
            _view.AKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.AKey, fontName, size, bgColor, fgColor);
            _view.BKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.BKey, fontName, size, bgColor, fgColor);
            _view.CKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.CKey, fontName, size, bgColor, fgColor);
            _view.DKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.DKey, fontName, size, bgColor, fgColor);
            _view.EKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.EKey, fontName, size, bgColor, fgColor);
            _view.FKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.FKey, fontName, size, bgColor, fgColor);
            _view.GKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.GKey, fontName, size, bgColor, fgColor);
            _view.HKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.HKey, fontName, size, bgColor, fgColor);
            _view.IKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.IKey, fontName, size, bgColor, fgColor);
            _view.JKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.JKey, fontName, size, bgColor, fgColor);
            _view.KKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.KKey, fontName, size, bgColor, fgColor);
            _view.LKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LKey, fontName, size, bgColor, fgColor);
            _view.MKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.MKey, fontName, size, bgColor, fgColor);
            _view.NKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NKey, fontName, size, bgColor, fgColor);
            _view.OKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.OKey, fontName, size, bgColor, fgColor);
            _view.PKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PKey, fontName, size, bgColor, fgColor);
            _view.QKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.QKey, fontName, size, bgColor, fgColor);
            _view.RKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RKey, fontName, size, bgColor, fgColor);
            _view.SKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.SKey, fontName, size, bgColor, fgColor);
            _view.TKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.TKey, fontName, size, bgColor, fgColor);
            _view.UKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.UKey, fontName, size, bgColor, fgColor);
            _view.VKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.VKey, fontName, size, bgColor, fgColor);
            _view.WKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.WKey, fontName, size, bgColor, fgColor);
            _view.XKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.XKey, fontName, size, bgColor, fgColor);
            _view.YKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.YKey, fontName, size, bgColor, fgColor);
            _view.ZKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.ZKey, fontName, size, bgColor, fgColor);
            _view.ZeroKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.ZeroKey, fontName, size, bgColor, fgColor);
            _view.OneKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.OneKey, fontName, size, bgColor, fgColor);
            _view.TwoKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.TwoKey, fontName, size, bgColor, fgColor);
            _view.ThreeKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.ThreeKey, fontName, size, bgColor, fgColor);
            _view.FourKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.FourKey, fontName, size, bgColor, fgColor);
            _view.FiveKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.FiveKey, fontName, size, bgColor, fgColor);
            _view.SixKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.SixKey, fontName, size, bgColor, fgColor);
            _view.SevenKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.SevenKey, fontName, size, bgColor, fgColor);
            _view.EightKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.EightKey, fontName, size, bgColor, fgColor);
            _view.NineKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NineKey, fontName, size, bgColor, fgColor);
            _view.SpaceKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.SpaceKey, fontName, size, bgColor, fgColor);
            _view.TabKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.TabKey, fontName, size, bgColor, fgColor);
            _view.EnterKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.EnterKey, fontName, size, bgColor, fgColor);
            _view.BackspaceKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.BackspaceKey, fontName, size, bgColor, fgColor);
            _view.EscapeKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.EscapeKey, fontName, size, bgColor, fgColor);
            _view.LeftShiftKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftShiftKey, fontName, size, bgColor, fgColor);
            _view.RightShiftKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RightShiftKey, fontName, size, bgColor, fgColor);
            _view.LeftCtrlKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftCtrlKey, fontName, size, bgColor, fgColor);
            _view.RightCtrlKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RightCtrlKey, fontName, size, bgColor, fgColor);
            _view.LeftAltKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftAltKey, fontName, size, bgColor, fgColor);
            _view.AltGrKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.AltGrKey, fontName, size, bgColor, fgColor);
            _view.DeleteKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.DeleteKey, fontName, size, bgColor, fgColor);
            _view.InsertKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.InsertKey, fontName, size, bgColor, fgColor);
            _view.HomeKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.HomeKey, fontName, size, bgColor, fgColor);
            _view.EndKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.EndKey, fontName, size, bgColor, fgColor);
            _view.PageUpKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PageUpKey, fontName, size, bgColor, fgColor);
            _view.PageDownKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PageDownKey, fontName, size, bgColor, fgColor);
            _view.UpKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.UpKey, fontName, size, bgColor, fgColor);
            _view.DownKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.DownKey, fontName, size, bgColor, fgColor);
            _view.LeftKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftKey, fontName, size, bgColor, fgColor);
            _view.RightKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RightKey, fontName, size, bgColor, fgColor);
            _view.NumLockKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumLockKey, fontName, size, bgColor, fgColor);
            _view.Num0Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num0Key, fontName, size, bgColor, fgColor);
            _view.Num1Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num1Key, fontName, size, bgColor, fgColor);
            _view.Num2Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num2Key, fontName, size, bgColor, fgColor);
            _view.Num3Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num3Key, fontName, size, bgColor, fgColor);
            _view.Num4Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num4Key, fontName, size, bgColor, fgColor);
            _view.Num5Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num5Key, fontName, size, bgColor, fgColor);
            _view.Num6Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num6Key, fontName, size, bgColor, fgColor);
            _view.Num7Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num7Key, fontName, size, bgColor, fgColor);
            _view.Num8Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num8Key, fontName, size, bgColor, fgColor);
            _view.Num9Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Num9Key, fontName, size, bgColor, fgColor);
            _view.NumPlusKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPlusKey, fontName, size, bgColor, fgColor);
            _view.NumMinusKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumMinusKey, fontName, size, bgColor, fgColor);
            _view.NumMultiplyKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumMultiplyKey, fontName, size, bgColor, fgColor);
            _view.NumDivideKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumDivideKey, fontName, size, bgColor, fgColor);
            _view.NumDecimalKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumDecimalKey, fontName, size, bgColor, fgColor);
            _view.NumEnterKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumEnterKey, fontName, size, bgColor, fgColor);
            _view.PrintScreenKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PrintScreenKey, fontName, size, bgColor, fgColor);
            _view.PauseBreakKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PauseBreakKey, fontName, size, bgColor, fgColor);
            _view.ScrollLockKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.ScrollLockKey, fontName, size, bgColor, fgColor);
            _view.CapsLockKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.CapsLockKey, fontName, size, bgColor, fgColor);
            _view.MinusKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.MinusKey, fontName, size, bgColor, fgColor);
            _view.EqualKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.EqualKey, fontName, size, bgColor, fgColor);
            _view.BackslashKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.BackslashKey, fontName, size, bgColor, fgColor);
            _view.LeftBracketKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftBracketKey, fontName, size, bgColor, fgColor);
            _view.RightBracketKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RightBracketKey, fontName, size, bgColor, fgColor);
            _view.SemicolonKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.SemicolonKey, fontName, size, bgColor, fgColor);
            _view.CommaKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.CommaKey, fontName, size, bgColor, fgColor);
            _view.PeriodKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PeriodKey, fontName, size, bgColor, fgColor);
            _view.SlashKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.SlashKey, fontName, size, bgColor, fgColor);
            _view.WindowKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.WindowKey, fontName, size, bgColor, fgColor);
            _view.FnKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.FnKey, fontName, size, bgColor, fgColor);
            _view.HashKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.HashKey, fontName, size, bgColor, fgColor);
            _view.ApostropheKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.ApostropheKey, fontName, size, bgColor, fgColor);
            _view.GraveKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.GraveKey, fontName, size, bgColor, fgColor);
        }
    }
}