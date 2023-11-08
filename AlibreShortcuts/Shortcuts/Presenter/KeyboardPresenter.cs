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

        public void ProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profile = _view.ProfileComboBox.SelectedItem.ToString();
            ArrayList shortcuts = _shortcutsCalculator.RetrieveUserShortcutsByProfile(profile);
            // guard against null or empty list
            if (shortcuts   == null || shortcuts.Count == 0)
            {
                shortcuts = _shortcutsCalculator.RetrieveStandardShortcutsByProfile(profile);
            }
            _shortcutLists.AltShortcuts = new Dictionary<int, Shortcut>();
            _shortcutLists.AltShiftShortcuts = new Dictionary<int, Shortcut>();
            _shortcutLists.CtrlShortcuts = new Dictionary<int, Shortcut>();
            _shortcutLists.CtrlAltShortcuts = new Dictionary<int, Shortcut>();
            _shortcutLists.CtrlAltShiftShortcuts = new Dictionary<int, Shortcut>();
            _shortcutLists.CtrlShiftShortcuts = new Dictionary<int, Shortcut>();
            _shortcutLists.ShiftShortcuts = new Dictionary<int, Shortcut>();
            _shortcutLists.NoModifierShortcuts = new Dictionary<int, Shortcut>();
            var dictionary = KeyCodes.KeyCodesDictionaryByIndex();
            // clear all selections except modifer keys
            foreach (var key in KeyButtons.ButtonDictionaryExcModifiers(_view))
            {
                key.Value.BackColor = Color.Empty;
                key.Value.Text = "";
            }

            foreach (Shortcut sc in shortcuts)
            {
                if (sc.Hint == null)
                {
                    continue;
                }

                var nonModifierCode = sc.GetNonModifierCode(sc.Keycode, out var shortcutModifierType);
                switch (shortcutModifierType)
                {
                    case ShortcutModifierType.Alt:
                        _shortcutLists.AltShortcuts.Add(nonModifierCode, sc);
                        break;
                    case ShortcutModifierType.AltShift:
                        _shortcutLists.AltShiftShortcuts.Add(nonModifierCode, sc);
                        break;
                    case ShortcutModifierType.Ctrl:
                        _shortcutLists.CtrlShortcuts.Add(nonModifierCode, sc);
                        break;
                    case ShortcutModifierType.CtrlAlt:
                        _shortcutLists.CtrlAltShortcuts.Add(nonModifierCode, sc);
                        break;
                    case ShortcutModifierType.CtrlAltShift:
                        _shortcutLists.CtrlAltShiftShortcuts.Add(nonModifierCode, sc);
                        break;
                    case ShortcutModifierType.CtrlShift:
                        _shortcutLists.CtrlShiftShortcuts.Add(nonModifierCode, sc);
                        break;
                    case ShortcutModifierType.Shift:
                        _shortcutLists.ShiftShortcuts.Add(nonModifierCode, sc);
                        break;
                    case ShortcutModifierType.None:
                        _shortcutLists.NoModifierShortcuts.Add(nonModifierCode, sc);
                        break;
                }
            }

            ShowShortcutsByModifierType();
          
        }

        private void ShowShortcutsByModifierType()
        {
            // clear all selections except modifier keys
            foreach (var key in KeyButtons.ButtonDictionaryExcModifiers(_view))
            {
                key.Value.BackColor = Color.Empty;
                key.Value.Text = "";
            }
            var dictionary = KeyCodes.KeyCodesDictionaryByIndex();
            if (_isCtrlSelected && _isAltSelected && _isShiftSelected)
            {
                foreach (var v in _shortcutLists.CtrlAltShiftShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.Orange;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
            }
            else if (_isCtrlSelected && _isAltSelected)
            {
                foreach (var v in _shortcutLists.CtrlAltShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.Orange;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
            }
            else if (_isCtrlSelected && _isShiftSelected)
            {
                foreach (var v in _shortcutLists.CtrlShiftShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.Orange;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
            }
            else if (_isAltSelected && _isShiftSelected)
            {
                foreach (var v in _shortcutLists.AltShiftShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.Orange;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
            }
            else if (_isCtrlSelected)
            {
                foreach (var v in _shortcutLists.CtrlShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.Orchid;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
            }
            else if (_isAltSelected)
            {
                foreach (var v in _shortcutLists.AltShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.CornflowerBlue;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
            }
            else if (_isShiftSelected)
            {
                foreach (var v in _shortcutLists.ShiftShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.DarkSeaGreen;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
            }
            else
            {
                foreach (var v in _shortcutLists.NoModifierShortcuts)
                {
                    KeyCodes kc = dictionary[v.Key];
                    KeyButtons.GetButton(_view, kc.KeyName).BackColor = Color.Chartreuse;
                    KeyButtons.GetButton(_view, kc.KeyName).Text = v.Value.Hint;
                }
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

        private void TextOverlayFont(Font font)
        {
            foreach (var key in KeyButtons.ButtonDictionary(_view))
            {
                key.Value.Font = font;
            }
        }

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
                _view.LeftCtrlKey.BackColor = Color.MistyRose;
                _view.RightCtrlKey.BackColor = Color.MistyRose;
            }
            else
            {
                _view.LeftCtrlKey.BackColor = Color.Orchid;
                _view.RightCtrlKey.BackColor = Color.Orchid;
            }
            ShowShortcutsByModifierType();
        }

        public void ViewAlt_Click(object sender, EventArgs e)
        {
            _isAltSelected = !_isAltSelected;
            if (!_isAltSelected)
            {
                _view.LeftAltKey.BackColor = Color.LightSkyBlue;
                _view.AltGrKey.BackColor = Color.LightSkyBlue;
            }
            else
            {
                _view.LeftAltKey.BackColor = Color.CornflowerBlue;
                _view.AltGrKey.BackColor = Color.CornflowerBlue;
            }
            ShowShortcutsByModifierType();
        }

        public void ViewShift_Click(object sender, EventArgs e)
        {
            _isShiftSelected = !_isShiftSelected;
            if (!_isShiftSelected)
            {
                _view.LeftShiftKey.BackColor = Color.PaleGreen;
                _view.RightShiftKey.BackColor = Color.PaleGreen;
            }
            else
            {
                _view.LeftShiftKey.BackColor = Color.DarkSeaGreen;
                _view.RightShiftKey.BackColor = Color.DarkSeaGreen;
            }
            ShowShortcutsByModifierType();
        }

        private void DefaultBackColors()
        {
            KeyButtons.GetButton(_view, "LeftCtrlKey").BackColor = Color.MistyRose;
            KeyButtons.GetButton(_view, "RightCtrlKey").BackColor = Color.MistyRose;
            KeyButtons.GetButton(_view, "LeftShiftKey").BackColor = Color.PaleGreen;
            KeyButtons.GetButton(_view, "RightShiftKey").BackColor = Color.PaleGreen;
            KeyButtons.GetButton(_view, "LeftAltKey").BackColor = Color.LightSkyBlue;
            KeyButtons.GetButton(_view, "AltGrKey").BackColor = Color.LightSkyBlue;
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

        private void DoDataBindings()
        {
            foreach (KeyValuePair<string, Button> key in KeyButtons.ButtonDictionary(_view))
            {
                DoDataBinding(key.Value as Control, key.Key.ToString() + "Text");
            }
        }

        private void ClearDefaultText()
        {
            foreach (KeyValuePair<string, Button> key in KeyButtons.ButtonDictionary(_view))
            {
                key.Value.Text = "";
            }
        }

        private void SetupKeyImageLocation()
        {
            foreach (KeyValuePair<string, Button> key in KeyButtons.ButtonDictionary(_view))
            {
                key.Value.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            }
        }

        private void SetupKeyImages(string fontName, int size, Color bgColor, Color fgColor)
        {
            _view.F1Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F1, fontName, size, bgColor, fgColor);
            _view.F2Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F2, fontName, size, bgColor, fgColor);
            _view.F3Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F3, fontName, size, bgColor, fgColor);
            _view.F4Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F4, fontName, size, bgColor, fgColor);
            _view.F5Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F5, fontName, size, bgColor, fgColor);
            _view.F6Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F6, fontName, size, bgColor, fgColor);
            _view.F7Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F7, fontName, size, bgColor, fgColor);
            _view.F8Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F8, fontName, size, bgColor, fgColor);
            _view.F9Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F9, fontName, size, bgColor, fgColor);
            _view.F10Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F10, fontName, size, bgColor, fgColor);
            _view.F11Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F11, fontName, size, bgColor, fgColor);
            _view.F12Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F12, fontName, size, bgColor, fgColor);
            _view.AKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.A, fontName, size, bgColor, fgColor);
            _view.BKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.B, fontName, size, bgColor, fgColor);
            _view.CKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.C, fontName, size, bgColor, fgColor);
            _view.DKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.D, fontName, size, bgColor, fgColor);
            _view.EKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.E, fontName, size, bgColor, fgColor);
            _view.FKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.F, fontName, size, bgColor, fgColor);
            _view.GKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.G, fontName, size, bgColor, fgColor);
            _view.HKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.H, fontName, size, bgColor, fgColor);
            _view.IKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.I, fontName, size, bgColor, fgColor);
            _view.JKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.J, fontName, size, bgColor, fgColor);
            _view.KKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.K, fontName, size, bgColor, fgColor);
            _view.LKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.L, fontName, size, bgColor, fgColor);
            _view.MKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.M, fontName, size, bgColor, fgColor);
            _view.NKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.N, fontName, size, bgColor, fgColor);
            _view.OKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.O, fontName, size, bgColor, fgColor);
            _view.PKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.P, fontName, size, bgColor, fgColor);
            _view.QKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Q, fontName, size, bgColor, fgColor);
            _view.RKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.R, fontName, size, bgColor, fgColor);
            _view.SKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.S, fontName, size, bgColor, fgColor);
            _view.TKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.T, fontName, size, bgColor, fgColor);
            _view.UKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.U, fontName, size, bgColor, fgColor);
            _view.VKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.V, fontName, size, bgColor, fgColor);
            _view.WKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.W, fontName, size, bgColor, fgColor);
            _view.XKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.X, fontName, size, bgColor, fgColor);
            _view.YKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Y, fontName, size, bgColor, fgColor);
            _view.ZKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Z, fontName, size, bgColor, fgColor);
            _view.ZeroKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Zero, fontName, size, bgColor, fgColor);
            _view.OneKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.One, fontName, size, bgColor, fgColor);
            _view.TwoKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Two, fontName, size, bgColor, fgColor);
            _view.ThreeKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Three, fontName, size, bgColor, fgColor);
            _view.FourKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Four, fontName, size, bgColor, fgColor);
            _view.FiveKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Five, fontName, size, bgColor, fgColor);
            _view.SixKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Six, fontName, size, bgColor, fgColor);
            _view.SevenKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Seven, fontName, size, bgColor, fgColor);
            _view.EightKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Eight, fontName, size, bgColor, fgColor);
            _view.NineKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Nine, fontName, size, bgColor, fgColor);
            _view.SpaceKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Space, fontName, size, bgColor, fgColor);
            _view.TabKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Tab, fontName, size, bgColor, fgColor);
            _view.EnterKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Enter, fontName, size, bgColor, fgColor);
            _view.BackspaceKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Backspace, fontName, size, bgColor, fgColor);
            _view.EscapeKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Escape, fontName, size, bgColor, fgColor);
            _view.LeftShiftKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftShift, fontName, size, bgColor, fgColor);
            _view.RightShiftKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RightShift, fontName, size, bgColor, fgColor);
            _view.LeftCtrlKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftCtrl, fontName, size, bgColor, fgColor);
            _view.RightCtrlKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RightCtrl, fontName, size, bgColor, fgColor);
            _view.LeftAltKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftAlt, fontName, size, bgColor, fgColor);
            _view.AltGrKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.AltGr, fontName, size, bgColor, fgColor);
            _view.DeleteKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Delete, fontName, size, bgColor, fgColor);
            _view.InsertKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Insert, fontName, size, bgColor, fgColor);
            _view.HomeKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Home, fontName, size, bgColor, fgColor);
            _view.EndKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.End, fontName, size, bgColor, fgColor);
            _view.PageUpKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PageUp, fontName, size, bgColor, fgColor);
            _view.PageDownKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PageDown, fontName, size, bgColor, fgColor);
            _view.UpKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Up, fontName, size, bgColor, fgColor);
            _view.DownKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Down, fontName, size, bgColor, fgColor);
            _view.LeftKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Left, fontName, size, bgColor, fgColor);
            _view.RightKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Right, fontName, size, bgColor, fgColor);
            _view.NumLockKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumLock, fontName, size, bgColor, fgColor);
            _view.Num0Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad0, fontName, size, bgColor, fgColor);
            _view.Num1Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad1, fontName, size, bgColor, fgColor);
            _view.Num2Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad2, fontName, size, bgColor, fgColor);
            _view.Num3Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad3, fontName, size, bgColor, fgColor);
            _view.Num4Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad4, fontName, size, bgColor, fgColor);
            _view.Num5Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad5, fontName, size, bgColor, fgColor);
            _view.Num6Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad6, fontName, size, bgColor, fgColor);
            _view.Num7Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad7, fontName, size, bgColor, fgColor);
            _view.Num8Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad8, fontName, size, bgColor, fgColor);
            _view.Num9Key.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPad9, fontName, size, bgColor, fgColor);
            _view.NumPlusKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPadPlus, fontName, size, bgColor, fgColor);
            _view.NumMinusKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPadMinus, fontName, size, bgColor, fgColor);
            _view.NumMultiplyKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPadMultiply, fontName, size, bgColor, fgColor);
            _view.NumDivideKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPadDivide, fontName, size, bgColor, fgColor);
            _view.NumDecimalKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPadDecimal, fontName, size, bgColor, fgColor);
            _view.NumEnterKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.NumPadEnter, fontName, size, bgColor, fgColor);
            _view.PrintScreenKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PrintScreen, fontName, size, bgColor, fgColor);
            _view.PauseBreakKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.PauseBreak, fontName, size, bgColor, fgColor);
            _view.ScrollLockKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.ScrollLock, fontName, size, bgColor, fgColor);
            _view.CapsLockKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.CapsLock, fontName, size, bgColor, fgColor);
            _view.MinusKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Minus, fontName, size, bgColor, fgColor);
            _view.EqualKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Equal, fontName, size, bgColor, fgColor);
            _view.BackslashKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Backslash, fontName, size, bgColor, fgColor);
            _view.LeftBracketKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.LeftBracket, fontName, size, bgColor, fgColor);
            _view.RightBracketKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.RightBracket, fontName, size, bgColor, fgColor);
            _view.SemicolonKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Semicolon, fontName, size, bgColor, fgColor);
            _view.CommaKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Comma, fontName, size, bgColor, fgColor);
            _view.PeriodKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Period, fontName, size, bgColor, fgColor);
            _view.SlashKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Slash, fontName, size, bgColor, fgColor);
            _view.WindowKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Win, fontName, size, bgColor, fgColor);
            _view.FnKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Fn, fontName, size, bgColor, fgColor);
            _view.HashKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Hash, fontName, size, bgColor, fgColor);
            _view.ApostropheKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Apostrophe, fontName, size, bgColor, fgColor);
            _view.GraveKey.Image = StringImageUtils.ConvertTextToPngImage(KeyStrings.Grave, fontName, size, bgColor, fgColor);
        }
    }
}