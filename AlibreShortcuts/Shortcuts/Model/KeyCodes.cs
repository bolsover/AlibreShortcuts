using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bolsover.Shortcuts.Model
{
    public class KeyCodes
    {
        public int KeyCode { get; private set; }
        public string KeyName { get; private set; }
        public string Code { get; private set; }
        public string Description { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("KeyCode: " + KeyCode);
            sb.Append(" KeyName: " + KeyName);
            sb.Append(" Code: " + Code);
            sb.Append(" Description: " + Description);
            return sb.ToString();
        }

        public static Dictionary<string, KeyCodes> KeyCodesDictionary() => new()
        {
            {"Backspace", new KeyCodes() {KeyCode = 8, KeyName = "Backspace", Code = "Backspace", Description = "BackspaceKey"}},
            {"Tab", new KeyCodes() {KeyCode = 9, KeyName = "Tab", Code = "Tab", Description = "TabKey"}},
            {"Enter", new KeyCodes() {KeyCode = 13, KeyName = "Enter", Code = "Enter", Description = "EnterKey"}},
            {"NumEnter", new KeyCodes() {KeyCode = 13, KeyName = "NumpadEnter", Code = "NumpadEnter", Description = "NumEnterKey"}},
            {"LeftShift", new KeyCodes() {KeyCode = 16, KeyName = "LeftShift", Code = "LeftShift", Description = "LeftShiftKey"}},
            {"RightShift", new KeyCodes() {KeyCode = 16, KeyName = "RightShift", Code = "RightShift", Description = "RightShiftKey"}},
            {"RightCtrl", new KeyCodes() {KeyCode = 17, KeyName = "RightCtrl", Code = "RightCtrl", Description = "RightCtrlKey"}},
            {"LeftCtrl", new KeyCodes() {KeyCode = 17, KeyName = "LeftCtrl", Code = "LeftCtrl", Description = "LeftCtrlKey"}},
            {"LeftAlt", new KeyCodes() {KeyCode = 18, KeyName = "LeftAlt", Code = "LeftAlt", Description = "LeftAltKey"}},
            {"PauseBreak", new KeyCodes() {KeyCode = 19, KeyName = "PauseBreak", Code = "PauseBreak", Description = "PauseBreakKey"}},
            {"CapsLock", new KeyCodes() {KeyCode = 20, KeyName = "CapsLock", Code = "CapsLock", Description = "CapsLockKey"}},
            {"Escape", new KeyCodes() {KeyCode = 27, KeyName = "Escape", Code = "Escape", Description = "EscapeKey"}},
            {"Space", new KeyCodes() {KeyCode = 32, KeyName = "Space", Code = "Space", Description = "SpaceKey"}},
            {"PageUp", new KeyCodes() {KeyCode = 33, KeyName = "PageUp", Code = "PageUp", Description = "PageUpKey"}},
            {"PageDown", new KeyCodes() {KeyCode = 34, KeyName = "PageDown", Code = "PageDown", Description = "PageDownKey"}},
            {"End", new KeyCodes() {KeyCode = 35, KeyName = "End", Code = "End", Description = "EndKey"}},
            {"Home", new KeyCodes() {KeyCode = 36, KeyName = "Home", Code = "Home", Description = "HomeKey"}},
            {"Left", new KeyCodes() {KeyCode = 37, KeyName = "Left", Code = "Left", Description = "LeftKey"}},
            {"Up", new KeyCodes() {KeyCode = 38, KeyName = "Up", Code = "Up", Description = "UpKey"}},
            {"Right", new KeyCodes() {KeyCode = 39, KeyName = "Right", Code = "Right", Description = "RightKey"}},
            {"Down", new KeyCodes() {KeyCode = 40, KeyName = "Down", Code = "Down", Description = "DownKey"}},
            {"PrintScreen", new KeyCodes() {KeyCode = 44, KeyName = "PrintScreen", Code = "PrintScreen", Description = "PrintScreenKey"}},
            {"Insert", new KeyCodes() {KeyCode = 45, KeyName = "Insert", Code = "Insert", Description = "InsertKey"}},
            {"Delete", new KeyCodes() {KeyCode = 46, KeyName = "Delete", Code = "Delete", Description = "DeleteKey"}},
            {"Zero", new KeyCodes() {KeyCode = 48, KeyName = "Zero", Code = "Zero", Description = "ZeroKey"}},
            {"One", new KeyCodes() {KeyCode = 49, KeyName = "One", Code = "One", Description = "OneKey"}},
            {"Two", new KeyCodes() {KeyCode = 50, KeyName = "Two", Code = "Two", Description = "TwoKey"}},
            {"Three", new KeyCodes() {KeyCode = 51, KeyName = "Three", Code = "Three", Description = "ThreeKey"}},
            {"Four", new KeyCodes() {KeyCode = 52, KeyName = "Four", Code = "Four", Description = "FourKey"}},
            {"Five", new KeyCodes() {KeyCode = 53, KeyName = "Five", Code = "Five", Description = "FiveKey"}},
            {"Six", new KeyCodes() {KeyCode = 54, KeyName = "Six", Code = "Six", Description = "SixKey"}},
            {"Seven", new KeyCodes() {KeyCode = 55, KeyName = "Seven", Code = "Seven", Description = "SevenKey"}},
            {"Eight", new KeyCodes() {KeyCode = 56, KeyName = "Eight", Code = "Eight", Description = "EightKey"}},
            {"Nine", new KeyCodes() {KeyCode = 57, KeyName = "Nine", Code = "Nine", Description = "NineKey"}},
            {"A", new KeyCodes() {KeyCode = 65, KeyName = "A", Code = "A", Description = "AKey"}},
            {"B", new KeyCodes() {KeyCode = 66, KeyName = "B", Code = "B", Description = "BKey"}},
            {"C", new KeyCodes() {KeyCode = 67, KeyName = "C", Code = "C", Description = "CKey"}},
            {"D", new KeyCodes() {KeyCode = 68, KeyName = "D", Code = "D", Description = "DKey"}},
            {"E", new KeyCodes() {KeyCode = 69, KeyName = "E", Code = "E", Description = "EKey"}},
            {"F", new KeyCodes() {KeyCode = 70, KeyName = "F", Code = "F", Description = "FKey"}},
            {"G", new KeyCodes() {KeyCode = 71, KeyName = "G", Code = "G", Description = "GKey"}},
            {"H", new KeyCodes() {KeyCode = 72, KeyName = "H", Code = "H", Description = "HKey"}},
            {"I", new KeyCodes() {KeyCode = 73, KeyName = "I", Code = "I", Description = "IKey"}},
            {"J", new KeyCodes() {KeyCode = 74, KeyName = "J", Code = "J", Description = "JKey"}},
            {"K", new KeyCodes() {KeyCode = 75, KeyName = "K", Code = "K", Description = "KKey"}},
            {"L", new KeyCodes() {KeyCode = 76, KeyName = "L", Code = "L", Description = "LKey"}},
            {"M", new KeyCodes() {KeyCode = 77, KeyName = "M", Code = "M", Description = "MKey"}},
            {"N", new KeyCodes() {KeyCode = 78, KeyName = "N", Code = "N", Description = "NKey"}},
            {"O", new KeyCodes() {KeyCode = 79, KeyName = "O", Code = "O", Description = "OKey"}},
            {"P", new KeyCodes() {KeyCode = 80, KeyName = "P", Code = "P", Description = "PKey"}},
            {"Q", new KeyCodes() {KeyCode = 81, KeyName = "Q", Code = "Q", Description = "QKey"}},
            {"R", new KeyCodes() {KeyCode = 82, KeyName = "R", Code = "R", Description = "RKey"}},
            {"S", new KeyCodes() {KeyCode = 83, KeyName = "S", Code = "S", Description = "SKey"}},
            {"T", new KeyCodes() {KeyCode = 84, KeyName = "T", Code = "T", Description = "TKey"}},
            {"U", new KeyCodes() {KeyCode = 85, KeyName = "U", Code = "U", Description = "UKey"}},
            {"V", new KeyCodes() {KeyCode = 86, KeyName = "V", Code = "V", Description = "VKey"}},
            {"W", new KeyCodes() {KeyCode = 87, KeyName = "W", Code = "W", Description = "WKey"}},
            {"X", new KeyCodes() {KeyCode = 88, KeyName = "X", Code = "X", Description = "XKey"}},
            {"Y", new KeyCodes() {KeyCode = 89, KeyName = "Y", Code = "Y", Description = "YKey"}},
            {"Z", new KeyCodes() {KeyCode = 90, KeyName = "Z", Code = "Z", Description = "ZKey"}},
            {"Window", new KeyCodes() {KeyCode = 91, KeyName = "Window", Code = "Window", Description = "WindowKey"}},
            {"Fn", new KeyCodes() {KeyCode = 93, KeyName = "Fn", Code = "Fn", Description = "FnKey"}},
            {"AltGr", new KeyCodes() {KeyCode = 18, KeyName = "AltGr", Code = "AltGr", Description = "AltGrKey"}},
            {"Num0", new KeyCodes() {KeyCode = 96, KeyName = "Num0", Code = "Num0", Description = "Num0Key"}},
            {"Num1", new KeyCodes() {KeyCode = 97, KeyName = "Num1", Code = "Num1", Description = "Num1Key"}},
            {"Num2", new KeyCodes() {KeyCode = 98, KeyName = "Num2", Code = "Num2", Description = "Num2Key"}},
            {"Num3", new KeyCodes() {KeyCode = 99, KeyName = "Num3", Code = "Num3", Description = "Num3Key"}},
            {"Num4", new KeyCodes() {KeyCode = 100, KeyName = "Num4", Code = "Num4", Description = "Num4Key"}},
            {"Num5", new KeyCodes() {KeyCode = 101, KeyName = "Num5", Code = "Num5", Description = "Num5Key"}},
            {"Num6", new KeyCodes() {KeyCode = 102, KeyName = "Num6", Code = "Num6", Description = "Num6Key"}},
            {"Num7", new KeyCodes() {KeyCode = 103, KeyName = "Num7", Code = "Num7", Description = "Num7Key"}},
            {"Num8", new KeyCodes() {KeyCode = 104, KeyName = "Num8", Code = "Num8", Description = "Num8Key"}},
            {"Num9", new KeyCodes() {KeyCode = 105, KeyName = "Num9", Code = "Num9", Description = "Num9Key"}},
            {"NumMultiply", new KeyCodes() {KeyCode = 106, KeyName = "NumMultiply", Code = "NumMultiply", Description = "NumMultiplyKey"}},
            {"NumPlus", new KeyCodes() {KeyCode = 107, KeyName = "NumPlus", Code = "NumPlus", Description = "NumPlusKey"}},
            {"NumMinus", new KeyCodes() {KeyCode = 109, KeyName = "NumMinus", Code = "NumMinus", Description = "NumMinusKey"}},
            {"NumDecimal", new KeyCodes() {KeyCode = 110, KeyName = "NumDecimal", Code = "NumDecimal", Description = "NumDecimalKey"}},
            {"NumDivide", new KeyCodes() {KeyCode = 111, KeyName = "NumDivide", Code = "NumDivide", Description = "NumDivideKey"}},
            {"F1", new KeyCodes() {KeyCode = 112, KeyName = "F1", Code = "F1", Description = "F1Key"}},
            {"F2", new KeyCodes() {KeyCode = 113, KeyName = "F2", Code = "F2", Description = "F2Key"}},
            {"F3", new KeyCodes() {KeyCode = 114, KeyName = "F3", Code = "F3", Description = "F3Key"}},
            {"F4", new KeyCodes() {KeyCode = 115, KeyName = "F4", Code = "F4", Description = "F4Key"}},
            {"F5", new KeyCodes() {KeyCode = 116, KeyName = "F5", Code = "F5", Description = "F5Key"}},
            {"F6", new KeyCodes() {KeyCode = 117, KeyName = "F6", Code = "F6", Description = "F6Key"}},
            {"F7", new KeyCodes() {KeyCode = 118, KeyName = "F7", Code = "F7", Description = "F7Key"}},
            {"F8", new KeyCodes() {KeyCode = 119, KeyName = "F8", Code = "F8", Description = "F8Key"}},
            {"F9", new KeyCodes() {KeyCode = 120, KeyName = "F9", Code = "F9", Description = "F9Key"}},
            {"F10", new KeyCodes() {KeyCode = 121, KeyName = "F10", Code = "F10", Description = "F10Key"}},
            {"F11", new KeyCodes() {KeyCode = 122, KeyName = "F11", Code = "F11", Description = "F11Key"}},
            {"F12", new KeyCodes() {KeyCode = 123, KeyName = "F12", Code = "F12", Description = "F12Key"}},
            {"NumLock", new KeyCodes() {KeyCode = 144, KeyName = "NumLock", Code = "NumLock", Description = "NumLockKey"}},
            {"ScrollLock", new KeyCodes() {KeyCode = 145, KeyName = "ScrollLock", Code = "ScrollLock", Description = "ScrollLockKey"}},
            {"Semicolon", new KeyCodes() {KeyCode = 186, KeyName = "Semicolon", Code = "Semicolon", Description = "SemicolonKey"}},
            {"Equal", new KeyCodes() {KeyCode = 187, KeyName = "Equal", Code = "Equal", Description = "EqualKey"}},
            {"Comma", new KeyCodes() {KeyCode = 188, KeyName = "Comma", Code = "Comma", Description = "CommaKey"}},
            {"Minus", new KeyCodes() {KeyCode = 189, KeyName = "Minus", Code = "Minus", Description = "MinusKey"}},
            {"Period", new KeyCodes() {KeyCode = 190, KeyName = "Period", Code = "Period", Description = "PeriodKey"}},
            {"Slash", new KeyCodes() {KeyCode = 191, KeyName = "Slash", Code = "Slash", Description = "SlashKey"}},
            {"Grave", new KeyCodes() {KeyCode = 223, KeyName = "Grave", Code = "Grave", Description = "GraveKey"}},
            {"LeftBracket", new KeyCodes() {KeyCode = 219, KeyName = "LeftBracket", Code = "LeftBracket", Description = "LeftBracketKey"}},
            {"Backslash", new KeyCodes() {KeyCode = 220, KeyName = "Backslash", Code = "Backslash", Description = "BackslashKey"}},
            {"RightBracket", new KeyCodes() {KeyCode = 221, KeyName = "RightBracket", Code = "RightBracket", Description = "RightBracketKey"}},
            {"Apostrophe", new KeyCodes() {KeyCode = 192, KeyName = "Apostrophe", Code = "Apostrophe", Description = "ApostropheKey"}},
            {"Hash", new KeyCodes() {KeyCode = 222, KeyName = "Hash", Code = "Hash", Description = "HashKey"}}
        };

        public static Dictionary<int, KeyCodes> KeyCodesDictionaryByIndex() => new()
        {
            {8, new KeyCodes() {KeyCode = 8, KeyName = "BackspaceKey", Description = "Backspace", Code = "Backspace"}},
            {9, new KeyCodes() {KeyCode = 9, KeyName = "TabKey", Description = "Tab", Code = "Tab"}},
            {13, new KeyCodes() {KeyCode = 13, KeyName = "EnterKey", Description = "Enter", Code = "Enter"}},
            {16, new KeyCodes() {KeyCode = 16, KeyName = "LeftShiftKey", Description = "LeftShift", Code = "LeftShift"}},
            {17, new KeyCodes() {KeyCode = 17, KeyName = "RightCtrlKey", Description = "RightCtrl", Code = "RightCtrl"}},
            {18, new KeyCodes() {KeyCode = 18, KeyName = "LeftAltKey", Description = "LeftAlt", Code = "LeftAlt"}},

            // can not allow duplicate keys in dictionary
            //   {13, new KeyCodes() {KeyCode = 13, KeyName = "NumEnterKey", Description = "NumpadEnter", Code = "NumpadEnter"}},
            //   {16, new KeyCodes() {KeyCode = 16, KeyName = "RightShiftKey", Description = "RightShift", Code = "RightShift"}},
            //   {17, new KeyCodes() {KeyCode = 17, KeyName = "LeftCtrlKey", Description = "LeftCtrl", Code = "LeftCtrl"}},
            //   {18, new KeyCodes() {KeyCode = 18, KeyName = "AltGrKey", Description = "AltGr", Code = "AltGr"}},
            {19, new KeyCodes() {KeyCode = 19, KeyName = "PauseBreakKey", Description = "PauseBreak", Code = "PauseBreak"}},
            {20, new KeyCodes() {KeyCode = 20, KeyName = "CapsLockKey", Description = "CapsLock", Code = "CapsLock"}},
            {27, new KeyCodes() {KeyCode = 27, KeyName = "EscapeKey", Description = "Escape", Code = "Escape"}},
            {32, new KeyCodes() {KeyCode = 32, KeyName = "SpaceKey", Description = "Space", Code = "Space"}},
            {33, new KeyCodes() {KeyCode = 33, KeyName = "PageUpKey", Description = "PageUp", Code = "PageUp"}},
            {34, new KeyCodes() {KeyCode = 34, KeyName = "PageDownKey", Description = "PageDown", Code = "PageDown"}},
            {35, new KeyCodes() {KeyCode = 35, KeyName = "EndKey", Description = "End", Code = "End"}},
            {36, new KeyCodes() {KeyCode = 36, KeyName = "HomeKey", Description = "Home", Code = "Home"}},
            {37, new KeyCodes() {KeyCode = 37, KeyName = "LeftKey", Description = "Left", Code = "Left"}},
            {38, new KeyCodes() {KeyCode = 38, KeyName = "UpKey", Description = "Up", Code = "Up"}},
            {39, new KeyCodes() {KeyCode = 39, KeyName = "RightKey", Description = "Right", Code = "Right"}},
            {40, new KeyCodes() {KeyCode = 40, KeyName = "DownKey", Description = "Down", Code = "Down"}},
            {44, new KeyCodes() {KeyCode = 44, KeyName = "PrintScreenKey", Description = "PrintScreen", Code = "PrintScreen"}},
            {45, new KeyCodes() {KeyCode = 45, KeyName = "InsertKey", Description = "Insert", Code = "Insert"}},
            {46, new KeyCodes() {KeyCode = 46, KeyName = "DeleteKey", Description = "Delete", Code = "Delete"}},
            {48, new KeyCodes() {KeyCode = 48, KeyName = "ZeroKey", Description = "Zero", Code = "Zero"}},
            {49, new KeyCodes() {KeyCode = 49, KeyName = "OneKey", Description = "One", Code = "One"}},
            {50, new KeyCodes() {KeyCode = 50, KeyName = "TwoKey", Description = "Two", Code = "Two"}},
            {51, new KeyCodes() {KeyCode = 51, KeyName = "ThreeKey", Description = "Three", Code = "Three"}},
            {52, new KeyCodes() {KeyCode = 52, KeyName = "FourKey", Description = "Four", Code = "Four"}},
            {53, new KeyCodes() {KeyCode = 53, KeyName = "FiveKey", Description = "Five", Code = "Five"}},
            {54, new KeyCodes() {KeyCode = 54, KeyName = "SixKey", Description = "Six", Code = "Six"}},
            {55, new KeyCodes() {KeyCode = 55, KeyName = "SevenKey", Description = "Seven", Code = "Seven"}},
            {56, new KeyCodes() {KeyCode = 56, KeyName = "EightKey", Description = "Eight", Code = "Eight"}},
            {57, new KeyCodes() {KeyCode = 57, KeyName = "NineKey", Description = "Nine", Code = "Nine"}},
            {65, new KeyCodes() {KeyCode = 65, KeyName = "AKey", Description = "A", Code = "A"}},
            {66, new KeyCodes() {KeyCode = 66, KeyName = "BKey", Description = "B", Code = "B"}},
            {67, new KeyCodes() {KeyCode = 67, KeyName = "CKey", Description = "C", Code = "C"}},
            {68, new KeyCodes() {KeyCode = 68, KeyName = "DKey", Description = "D", Code = "D"}},
            {69, new KeyCodes() {KeyCode = 69, KeyName = "EKey", Description = "E", Code = "E"}},
            {70, new KeyCodes() {KeyCode = 70, KeyName = "FKey", Description = "F", Code = "F"}},
            {71, new KeyCodes() {KeyCode = 71, KeyName = "GKey", Description = "G", Code = "G"}},
            {72, new KeyCodes() {KeyCode = 72, KeyName = "HKey", Description = "H", Code = "H"}},
            {73, new KeyCodes() {KeyCode = 73, KeyName = "IKey", Description = "I", Code = "I"}},
            {74, new KeyCodes() {KeyCode = 74, KeyName = "JKey", Description = "J", Code = "J"}},
            {75, new KeyCodes() {KeyCode = 75, KeyName = "KKey", Description = "K", Code = "K"}},
            {76, new KeyCodes() {KeyCode = 76, KeyName = "LKey", Description = "L", Code = "L"}},
            {77, new KeyCodes() {KeyCode = 77, KeyName = "MKey", Description = "M", Code = "M"}},
            {78, new KeyCodes() {KeyCode = 78, KeyName = "NKey", Description = "N", Code = "N"}},
            {79, new KeyCodes() {KeyCode = 79, KeyName = "OKey", Description = "O", Code = "O"}},
            {80, new KeyCodes() {KeyCode = 80, KeyName = "PKey", Description = "P", Code = "P"}},
            {81, new KeyCodes() {KeyCode = 81, KeyName = "QKey", Description = "Q", Code = "Q"}},
            {82, new KeyCodes() {KeyCode = 82, KeyName = "RKey", Description = "R", Code = "R"}},
            {83, new KeyCodes() {KeyCode = 83, KeyName = "SKey", Description = "S", Code = "S"}},
            {84, new KeyCodes() {KeyCode = 84, KeyName = "TKey", Description = "T", Code = "T"}},
            {85, new KeyCodes() {KeyCode = 85, KeyName = "UKey", Description = "U", Code = "U"}},
            {86, new KeyCodes() {KeyCode = 86, KeyName = "VKey", Description = "V", Code = "V"}},
            {87, new KeyCodes() {KeyCode = 87, KeyName = "WKey", Description = "W", Code = "W"}},
            {88, new KeyCodes() {KeyCode = 88, KeyName = "XKey", Description = "X", Code = "X"}},
            {89, new KeyCodes() {KeyCode = 89, KeyName = "YKey", Description = "Y", Code = "Y"}},
            {90, new KeyCodes() {KeyCode = 90, KeyName = "ZKey", Description = "Z", Code = "Z"}},
            {91, new KeyCodes() {KeyCode = 91, KeyName = "WindowKey", Description = "Window", Code = "Window"}},
            {93, new KeyCodes() {KeyCode = 93, KeyName = "FnKey", Description = "Fn", Code = "Fn"}},
            {96, new KeyCodes() {KeyCode = 96, KeyName = "Num0Key", Description = "Num0", Code = "Num0"}},
            {97, new KeyCodes() {KeyCode = 97, KeyName = "Num1Key", Description = "Num1", Code = "Num1"}},
            {98, new KeyCodes() {KeyCode = 98, KeyName = "Num2Key", Description = "Num2", Code = "Num2"}},
            {99, new KeyCodes() {KeyCode = 99, KeyName = "Num3Key", Description = "Num3", Code = "Num3"}},
            {100, new KeyCodes() {KeyCode = 100, KeyName = "Num4Key", Description = "Num4", Code = "Num4"}},
            {101, new KeyCodes() {KeyCode = 101, KeyName = "Num5Key", Description = "Num5", Code = "Num5"}},
            {102, new KeyCodes() {KeyCode = 102, KeyName = "Num6Key", Description = "Num6", Code = "Num6"}},
            {103, new KeyCodes() {KeyCode = 103, KeyName = "Num7Key", Description = "Num7", Code = "Num7"}},
            {104, new KeyCodes() {KeyCode = 104, KeyName = "Num8Key", Description = "Num8", Code = "Num8"}},
            {105, new KeyCodes() {KeyCode = 105, KeyName = "Num9Key", Description = "Num9", Code = "Num9"}},
            {106, new KeyCodes() {KeyCode = 106, KeyName = "NumMultiplyKey", Description = "NumMultiply", Code = "NumMultiply"}},
            {107, new KeyCodes() {KeyCode = 107, KeyName = "NumPlusKey", Description = "NumPlus", Code = "NumPlus"}},
            {109, new KeyCodes() {KeyCode = 109, KeyName = "NumMinusKey", Description = "NumMinus", Code = "NumMinus"}},
            {110, new KeyCodes() {KeyCode = 110, KeyName = "NumDecimalKey", Description = "NumDecimal", Code = "NumDecimal"}},
            {111, new KeyCodes() {KeyCode = 111, KeyName = "NumDivideKey", Description = "NumDivide", Code = "NumDivide"}},
            {112, new KeyCodes() {KeyCode = 112, KeyName = "F1Key", Description = "F1", Code = "F1"}},
            {113, new KeyCodes() {KeyCode = 113, KeyName = "F2Key", Description = "F2", Code = "F2"}},
            {114, new KeyCodes() {KeyCode = 114, KeyName = "F3Key", Description = "F3", Code = "F3"}},
            {115, new KeyCodes() {KeyCode = 115, KeyName = "F4Key", Description = "F4", Code = "F4"}},
            {116, new KeyCodes() {KeyCode = 116, KeyName = "F5Key", Description = "F5", Code = "F5"}},
            {117, new KeyCodes() {KeyCode = 117, KeyName = "F6Key", Description = "F6", Code = "F6"}},
            {118, new KeyCodes() {KeyCode = 118, KeyName = "F7Key", Description = "F7", Code = "F7"}},
            {119, new KeyCodes() {KeyCode = 119, KeyName = "F8Key", Description = "F8", Code = "F8"}},
            {120, new KeyCodes() {KeyCode = 120, KeyName = "F9Key", Description = "F9", Code = "F9"}},
            {121, new KeyCodes() {KeyCode = 121, KeyName = "F10Key", Description = "F10", Code = "F10"}},
            {122, new KeyCodes() {KeyCode = 122, KeyName = "F11Key", Description = "F11", Code = "F11"}},
            {123, new KeyCodes() {KeyCode = 123, KeyName = "F12Key", Description = "F12", Code = "F12"}},
            {144, new KeyCodes() {KeyCode = 144, KeyName = "NumLockKey", Description = "NumLock", Code = "NumLock"}},
            {145, new KeyCodes() {KeyCode = 145, KeyName = "ScrollLockKey", Description = "ScrollLock", Code = "ScrollLock"}},
            {186, new KeyCodes() {KeyCode = 186, KeyName = "SemicolonKey", Description = "Semicolon", Code = "Semicolon"}},
            {187, new KeyCodes() {KeyCode = 187, KeyName = "EqualKey", Description = "Equal", Code = "Equal"}},
            {188, new KeyCodes() {KeyCode = 188, KeyName = "CommaKey", Description = "Comma", Code = "Comma"}},
            {189, new KeyCodes() {KeyCode = 189, KeyName = "MinusKey", Description = "Minus", Code = "Minus"}},
            {190, new KeyCodes() {KeyCode = 190, KeyName = "PeriodKey", Description = "Period", Code = "Period"}},
            {191, new KeyCodes() {KeyCode = 191, KeyName = "SlashKey", Description = "Slash", Code = "Slash"}},
            {192, new KeyCodes() {KeyCode = 192, KeyName = "ApostropheKey", Description = "Apostrophe", Code = "Apostrophe"}},
            {219, new KeyCodes() {KeyCode = 219, KeyName = "LeftBracketKey", Description = "LeftBracket", Code = "LeftBracket"}},
            {220, new KeyCodes() {KeyCode = 220, KeyName = "BackslashKey", Description = "Backslash", Code = "Backslash"}},
            {221, new KeyCodes() {KeyCode = 221, KeyName = "RightBracketKey", Description = "RightBracket", Code = "RightBracket"}},
            {222, new KeyCodes() {KeyCode = 222, KeyName = "HashKey", Description = "Hash", Code = "Hash"}},
            {223, new KeyCodes() {KeyCode = 223, KeyName = "GraveKey", Description = "Grave", Code = "Grave"}}
        };

        public static ArrayList DeconstructKeyCode(int keycode)
        {
            const int meta = 1048576;
            const int alt = 262144;
            const int ctrl = 131072;
            const int shift = 65536;

            ArrayList keycodes = new ArrayList();
            if (keycode >= meta)
            {
                keycodes.Add(91); // Keycode for Windows/Command key
                keycode -= meta;
            }

            if (keycode >= alt)
            {
                keycodes.Add(18); // Keycode for Alt
                keycode -= alt;
            }

            if (keycode >= ctrl)
            {
                keycodes.Add(17); // Keycode for Control
                keycode -= ctrl;
            }

            if (keycode >= shift)
            {
                keycodes.Add(16); // Keycode for Shift
                keycode -= shift;
            }


            // Remaining value is the ASCII value of the key pressed
            keycodes.Add(keycode);

            return keycodes;
        }
    }
}