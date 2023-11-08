using System.Collections.Generic;
using System.Windows.Forms;
using Bolsover.Shortcuts.View;

namespace Bolsover.Shortcuts.Model
{
    public class KeyButtons
    {
        private KeyboardControl _view;
        private Dictionary<string, Button> _buttonDictionary;
        private static KeyButtons _instance;

        
        
        private  KeyButtons(KeyboardControl view)
        {
            _view = view;
            InitButtonDictionary();
        }

        private static KeyButtons GetInstance(KeyboardControl view)
        {
            if (_instance == null)
            {
                _instance = new KeyButtons(view);
            }

            return _instance;
        }

        public static Button GetButton(KeyboardControl view, string key)
        {
            return GetInstance(view)._buttonDictionary[key];
        }

        public static Dictionary<string, Button> ButtonDictionary(KeyboardControl view)

        {
            return GetInstance(view)._buttonDictionary;
        }
        public static Dictionary<string, Button> ButtonDictionaryExcModifiers(KeyboardControl view)

        {
            Dictionary<string, Button> temp = GetInstance(view)._buttonDictionary;
            temp.Remove("LeftCtrlKey");
            temp.Remove("RightCtrlKey");
            temp.Remove("LeftShiftKey");
            temp.Remove("RightShiftKey");
            temp.Remove("LeftAltKey");
            temp.Remove("AltGrKey");
            
            return temp;
        }
        

        private void InitButtonDictionary()
        {
            _buttonDictionary = new Dictionary<string, Button>();
            _buttonDictionary.Add("PrintScreenKey", PrintScreenKey);
            _buttonDictionary.Add("ScrollLockKey", ScrollLockKey);
            _buttonDictionary.Add("PauseBreakKey", PauseBreakKey);
            _buttonDictionary.Add("InsertKey", InsertKey);
            _buttonDictionary.Add("HomeKey", HomeKey);
            _buttonDictionary.Add("PageUpKey", PageUpKey);
            _buttonDictionary.Add("DeleteKey", DeleteKey);
            _buttonDictionary.Add("EndKey", EndKey);
            _buttonDictionary.Add("PageDownKey", PageDownKey);
            _buttonDictionary.Add("UpKey", UpKey);
            _buttonDictionary.Add("LeftKey", LeftKey);
            _buttonDictionary.Add("DownKey", DownKey);
            _buttonDictionary.Add("RightKey", RightKey);
            _buttonDictionary.Add("F1Key", F1Key);
            _buttonDictionary.Add("F2Key", F2Key);
            _buttonDictionary.Add("F3Key", F3Key);
            _buttonDictionary.Add("F4Key", F4Key);
            _buttonDictionary.Add("F5Key", F5Key);
            _buttonDictionary.Add("F6Key", F6Key);
            _buttonDictionary.Add("F7Key", F7Key);
            _buttonDictionary.Add("F8Key", F8Key);
            _buttonDictionary.Add("F9Key", F9Key);
            _buttonDictionary.Add("F10Key", F10Key);
            _buttonDictionary.Add("F11Key", F11Key);
            _buttonDictionary.Add("F12Key", F12Key);
            _buttonDictionary.Add("EscapeKey", EscapeKey);
            _buttonDictionary.Add("HashKey", HashKey);
            _buttonDictionary.Add("LeftCtrlKey", LeftCtrlKey);
            _buttonDictionary.Add("QKey", QKey);
            _buttonDictionary.Add("WKey", WKey);
            _buttonDictionary.Add("EKey", EKey);
            _buttonDictionary.Add("RKey", RKey);
            _buttonDictionary.Add("TKey", TKey);
            _buttonDictionary.Add("YKey", YKey);
            _buttonDictionary.Add("RightBracketKey", RightBracketKey);
            _buttonDictionary.Add("LeftBracketKey", LeftBracketKey);
            _buttonDictionary.Add("PKey", PKey);
            _buttonDictionary.Add("OKey", OKey);
            _buttonDictionary.Add("IKey", IKey);
            _buttonDictionary.Add("UKey", UKey);
            _buttonDictionary.Add("TabKey", TabKey);
            _buttonDictionary.Add("ApostropheKey", ApostropheKey);
            _buttonDictionary.Add("SemicolonKey", SemicolonKey);
            _buttonDictionary.Add("LKey", LKey);
            _buttonDictionary.Add("KKey", KKey);
            _buttonDictionary.Add("JKey", JKey);
            _buttonDictionary.Add("HKey", HKey);
            _buttonDictionary.Add("GKey", GKey);
            _buttonDictionary.Add("FKey", FKey);
            _buttonDictionary.Add("DKey", DKey);
            _buttonDictionary.Add("SKey", SKey);
            _buttonDictionary.Add("AKey", AKey);
            _buttonDictionary.Add("SlashKey", SlashKey);
            _buttonDictionary.Add("PeriodKey", PeriodKey);
            _buttonDictionary.Add("CommaKey", CommaKey);
            _buttonDictionary.Add("MKey", MKey);
            _buttonDictionary.Add("NKey", NKey);
            _buttonDictionary.Add("BKey", BKey);
            _buttonDictionary.Add("VKey", VKey);
            _buttonDictionary.Add("CKey", CKey);
            _buttonDictionary.Add("XKey", XKey);
            _buttonDictionary.Add("ZKey", ZKey);
            _buttonDictionary.Add("CapsLockKey", CapsLockKey);
            _buttonDictionary.Add("LeftShiftKey", LeftShiftKey);
            _buttonDictionary.Add("BackslashKey", BackslashKey);
            _buttonDictionary.Add("RightShiftKey", RightShiftKey);
            _buttonDictionary.Add("BackspaceKey", BackspaceKey);
            _buttonDictionary.Add("EnterKey", EnterKey);
            _buttonDictionary.Add("GraveKey", GraveKey);
            _buttonDictionary.Add("ZeroKey", ZeroKey);
            _buttonDictionary.Add("NineKey", NineKey);
            _buttonDictionary.Add("EightKey", EightKey);
            _buttonDictionary.Add("SixKey", SixKey);
            _buttonDictionary.Add("FiveKey", FiveKey);
            _buttonDictionary.Add("FourKey", FourKey);
            _buttonDictionary.Add("ThreeKey", ThreeKey);
            _buttonDictionary.Add("TwoKey", TwoKey);
            _buttonDictionary.Add("OneKey", OneKey);
            _buttonDictionary.Add("SevenKey", SevenKey);
            _buttonDictionary.Add("EqualKey", EqualKey);
            _buttonDictionary.Add("MinusKey", MinusKey);
            _buttonDictionary.Add("Num4Key", Num4Key);
            _buttonDictionary.Add("Num5Key", Num5Key);
            _buttonDictionary.Add("Num6Key", Num6Key);
            _buttonDictionary.Add("Num9Key", Num9Key);
            _buttonDictionary.Add("Num8Key", Num8Key);
            _buttonDictionary.Add("Num7Key", Num7Key);
            _buttonDictionary.Add("NumDecimalKey", NumDecimalKey);
            _buttonDictionary.Add("Num0Key", Num0Key);
            _buttonDictionary.Add("Num3Key", Num3Key);
            _buttonDictionary.Add("Num2Key", Num2Key);
            _buttonDictionary.Add("Num1Key", Num1Key);
            _buttonDictionary.Add("NumMultiplyKey", NumMultiplyKey);
            _buttonDictionary.Add("NumDivideKey", NumDivideKey);
            _buttonDictionary.Add("NumMinusKey", NumMinusKey);
            _buttonDictionary.Add("NumPlusKey", NumPlusKey);
            _buttonDictionary.Add("NumEnterKey", NumEnterKey);
            _buttonDictionary.Add("SpaceKey", SpaceKey);
            _buttonDictionary.Add("WindowKey", WindowKey);
            _buttonDictionary.Add("FnKey", FnKey);
            _buttonDictionary.Add("LeftAltKey", LeftAltKey);
            _buttonDictionary.Add("RightCtrlKey", RightCtrlKey);
            _buttonDictionary.Add("AltGrKey", AltGrKey);
            _buttonDictionary.Add("NumLockKey", NumLockKey);
        }

        public Button PrintScreenKey
        {
            get => _view.PrintScreenKey;
        }

        public Button ScrollLockKey
        {
            get => _view.ScrollLockKey;
        }

        public Button PauseBreakKey
        {
            get => _view.PauseBreakKey;
        }

        public Button InsertKey
        {
            get => _view.InsertKey;
        }

        public Button HomeKey
        {
            get => _view.HomeKey;
        }

        public Button PageUpKey
        {
            get => _view.PageUpKey;
        }

        public Button DeleteKey
        {
            get => _view.DeleteKey;
        }

        public Button EndKey
        {
            get => _view.EndKey;
        }

        public Button PageDownKey
        {
            get => _view.PageDownKey;
        }

        public Button UpKey
        {
            get => _view.UpKey;
        }

        public Button LeftKey
        {
            get => _view.LeftKey;
        }

        public Button DownKey
        {
            get => _view.DownKey;
        }

        public Button RightKey
        {
            get => _view.RightKey;
        }

        public Button F1Key
        {
            get => _view.F1Key;
        }

        public Button F2Key
        {
            get => _view.F2Key;
        }

        public Button F3Key
        {
            get => _view.F3Key;
        }

        public Button F4Key
        {
            get => _view.F4Key;
        }

        public Button F5Key
        {
            get => _view.F5Key;
        }

        public Button F6Key
        {
            get => _view.F6Key;
        }

        public Button F7Key
        {
            get => _view.F7Key;
        }

        public Button F8Key
        {
            get => _view.F8Key;
        }

        public Button F9Key
        {
            get => _view.F9Key;
        }

        public Button F10Key
        {
            get => _view.F10Key;
        }

        public Button F11Key
        {
            get => _view.F11Key;
        }

        public Button F12Key
        {
            get => _view.F12Key;
        }

        public Button EscapeKey
        {
            get => _view.EscapeKey;
        }

        public Button HashKey
        {
            get => _view.HashKey;
        }

        public Button LeftCtrlKey
        {
            get => _view.LeftCtrlKey;
        }

        public Button QKey
        {
            get => _view.QKey;
        }

        public Button WKey
        {
            get => _view.WKey;
        }

        public Button EKey
        {
            get => _view.EKey;
        }

        public Button RKey
        {
            get => _view.RKey;
        }

        public Button TKey
        {
            get => _view.TKey;
        }

        public Button YKey
        {
            get => _view.YKey;
        }

        public Button RightBracketKey
        {
            get => _view.RightBracketKey;
        }

        public Button LeftBracketKey
        {
            get => _view.LeftBracketKey;
        }

        public Button PKey
        {
            get => _view.PKey;
        }

        public Button OKey
        {
            get => _view.OKey;
        }

        public Button IKey
        {
            get => _view.IKey;
        }

        public Button UKey
        {
            get => _view.UKey;
        }

        public Button TabKey
        {
            get => _view.TabKey;
        }

        public Button ApostropheKey
        {
            get => _view.ApostropheKey;
        }

        public Button SemicolonKey
        {
            get => _view.SemicolonKey;
        }

        public Button LKey
        {
            get => _view.LKey;
        }

        public Button KKey
        {
            get => _view.KKey;
        }

        public Button JKey
        {
            get => _view.JKey;
        }

        public Button HKey
        {
            get => _view.HKey;
        }

        public Button GKey
        {
            get => _view.GKey;
        }

        public Button FKey
        {
            get => _view.FKey;
        }

        public Button DKey
        {
            get => _view.DKey;
        }

        public Button SKey
        {
            get => _view.SKey;
        }

        public Button AKey
        {
            get => _view.AKey;
        }

        public Button SlashKey
        {
            get => _view.SlashKey;
        }

        public Button PeriodKey
        {
            get => _view.PeriodKey;
        }

        public Button CommaKey
        {
            get => _view.CommaKey;
        }

        public Button MKey
        {
            get => _view.MKey;
        }

        public Button NKey
        {
            get => _view.NKey;
        }

        public Button BKey
        {
            get => _view.BKey;
        }

        public Button VKey
        {
            get => _view.VKey;
        }

        public Button CKey
        {
            get => _view.CKey;
        }

        public Button XKey
        {
            get => _view.XKey;
        }

        public Button ZKey
        {
            get => _view.ZKey;
        }

        public Button CapsLockKey
        {
            get => _view.CapsLockKey;
        }

        public Button LeftShiftKey
        {
            get => _view.LeftShiftKey;
        }

        public Button BackslashKey
        {
            get => _view.BackslashKey;
        }

        public Button RightShiftKey
        {
            get => _view.RightShiftKey;
        }

        public Button BackspaceKey
        {
            get => _view.BackspaceKey;
        }

        public Button EnterKey
        {
            get => _view.EnterKey;
        }

        public Button GraveKey
        {
            get => _view.GraveKey;
        }

        public Button ZeroKey
        {
            get => _view.ZeroKey;
        }

        public Button NineKey
        {
            get => _view.NineKey;
        }

        public Button EightKey
        {
            get => _view.EightKey;
        }

        public Button SixKey
        {
            get => _view.SixKey;
        }

        public Button FiveKey
        {
            get => _view.FiveKey;
        }

        public Button FourKey
        {
            get => _view.FourKey;
        }

        public Button ThreeKey
        {
            get => _view.ThreeKey;
        }

        public Button TwoKey
        {
            get => _view.TwoKey;
        }

        public Button OneKey
        {
            get => _view.OneKey;
        }

        public Button SevenKey
        {
            get => _view.SevenKey;
        }

        public Button EqualKey
        {
            get => _view.EqualKey;
        }

        public Button MinusKey
        {
            get => _view.MinusKey;
        }

        public Button Num4Key
        {
            get => _view.Num4Key;
        }

        public Button Num5Key
        {
            get => _view.Num5Key;
        }

        public Button Num6Key
        {
            get => _view.Num6Key;
        }

        public Button Num9Key
        {
            get => _view.Num9Key;
        }

        public Button Num8Key
        {
            get => _view.Num8Key;
        }

        public Button Num7Key
        {
            get => _view.Num7Key;
        }

        public Button NumDecimalKey
        {
            get => _view.NumDecimalKey;
        }

        public Button Num0Key
        {
            get => _view.Num0Key;
        }

        public Button Num3Key
        {
            get => _view.Num3Key;
        }

        public Button Num2Key
        {
            get => _view.Num2Key;
        }

        public Button Num1Key
        {
            get => _view.Num1Key;
        }

        public Button NumMultiplyKey
        {
            get => _view.NumMultiplyKey;
        }

        public Button NumDivideKey
        {
            get => _view.NumDivideKey;
        }

        public Button NumMinusKey
        {
            get => _view.NumMinusKey;
        }

        public Button NumPlusKey
        {
            get => _view.NumPlusKey;
        }

        public Button NumEnterKey
        {
            get => _view.NumEnterKey;
        }

        public Button SpaceKey
        {
            get => _view.SpaceKey;
        }

        public Button WindowKey
        {
            get => _view.WindowKey;
        }

        public Button FnKey
        {
            get => _view.FnKey;
        }

        public Button LeftAltKey
        {
            get => _view.LeftAltKey;
        }

        public Button RightCtrlKey
        {
            get => _view.RightCtrlKey;
        }

        public Button AltGrKey
        {
            get => _view.AltGrKey;
        }

        public Button NumLockKey
        {
            get => _view.NumLockKey;
        }
    }
}