using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bolsover.Shortcuts.View
{
    public class KeyCodes
    {
        public int KeyCode { get; set; }
        public string KeyName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

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
            {"Backspace", new KeyCodes() {KeyCode = 8, KeyName = "Backspace", Code = "Backspace", Description = "Backspace"}},
            {"Tab", new KeyCodes() {KeyCode = 9, KeyName = "Tab", Code = "Tab", Description = "Tab"}},
            {"Enter", new KeyCodes() {KeyCode = 13, KeyName = "Enter", Code = "Enter", Description = "Enter"}},
            {"NumpadEnter", new KeyCodes() {KeyCode = 13, KeyName = "NumpadEnter", Code = "NumpadEnter", Description = "NumpadEnter"}},
            {"Shift", new KeyCodes() {KeyCode = 16, KeyName = "Shift", Code = "Shift", Description = "Shift"}},
            {"Ctrl", new KeyCodes() {KeyCode = 17, KeyName = "Ctrl", Code = "Ctrl", Description = "Ctrl"}},
            {"Alt", new KeyCodes() {KeyCode = 18, KeyName = "Alt", Code = "Alt", Description = "Alt"}},
            {"PauseBreak", new KeyCodes() {KeyCode = 19, KeyName = "PauseBreak", Code = "PauseBreak", Description = "PauseBreak"}},
            {"CapsLock", new KeyCodes() {KeyCode = 20, KeyName = "CapsLock", Code = "CapsLock", Description = "CapsLock"}},
            {"Escape", new KeyCodes() {KeyCode = 27, KeyName = "Escape", Code = "Escape", Description = "Escape"}},
            {"SpaceBar", new KeyCodes() {KeyCode = 32, KeyName = "SpaceBar", Code = "SpaceBar", Description = "SpaceBar"}},
            {"PageUp", new KeyCodes() {KeyCode = 33, KeyName = "PageUp", Code = "PageUp", Description = "PageUp"}},
            {"PageDown", new KeyCodes() {KeyCode = 34, KeyName = "PageDown", Code = "PageDown", Description = "PageDown"}},
            {"End", new KeyCodes() {KeyCode = 35, KeyName = "End", Code = "End", Description = "End"}},
            {"Home", new KeyCodes() {KeyCode = 36, KeyName = "Home", Code = "Home", Description = "Home"}},
            {"ArrowLeft", new KeyCodes() {KeyCode = 37, KeyName = "ArrowLeft", Code = "ArrowLeft", Description = "ArrowLeft"}},
            {"ArrowUp", new KeyCodes() {KeyCode = 38, KeyName = "ArrowUp", Code = "ArrowUp", Description = "ArrowUp"}},
            {"ArrowRight", new KeyCodes() {KeyCode = 39, KeyName = "ArrowRight", Code = "ArrowRight", Description = "ArrowRight"}},
            {"ArrowDown", new KeyCodes() {KeyCode = 40, KeyName = "ArrowDown", Code = "ArrowDown", Description = "ArrowDown"}},
            {"PrintScreen", new KeyCodes() {KeyCode = 44, KeyName = "PrintScreen", Code = "PrintScreen", Description = "PrintScreen"}},
            {"Insert", new KeyCodes() {KeyCode = 45, KeyName = "Insert", Code = "Insert", Description = "Insert"}},
            {"Delete", new KeyCodes() {KeyCode = 46, KeyName = "Delete", Code = "Delete", Description = "Delete"}},
            {"Zero", new KeyCodes() {KeyCode = 48, KeyName = "Zero", Code = "Zero", Description = "Zero"}},
            {"One", new KeyCodes() {KeyCode = 49, KeyName = "One", Code = "One", Description = "One"}},
            {"Two", new KeyCodes() {KeyCode = 50, KeyName = "Two", Code = "Two", Description = "Two"}},
            {"Three", new KeyCodes() {KeyCode = 51, KeyName = "Three", Code = "Three", Description = "Three"}},
            {"Four", new KeyCodes() {KeyCode = 52, KeyName = "Four", Code = "Four", Description = "Four"}},
            {"Five", new KeyCodes() {KeyCode = 53, KeyName = "Five", Code = "Five", Description = "Five"}},
            {"Six", new KeyCodes() {KeyCode = 54, KeyName = "Six", Code = "Six", Description = "Six"}},
            {"Seven", new KeyCodes() {KeyCode = 55, KeyName = "Seven", Code = "Seven", Description = "Seven"}},
            {"Eight", new KeyCodes() {KeyCode = 56, KeyName = "Eight", Code = "Eight", Description = "Eight"}},
            {"Nine", new KeyCodes() {KeyCode = 57, KeyName = "Nine", Code = "Nine", Description = "Nine"}},
            {"A", new KeyCodes() {KeyCode = 65, KeyName = "A", Code = "A", Description = "A"}},
            {"B", new KeyCodes() {KeyCode = 66, KeyName = "B", Code = "B", Description = "B"}},
            {"C", new KeyCodes() {KeyCode = 67, KeyName = "C", Code = "C", Description = "C"}},
            {"D", new KeyCodes() {KeyCode = 68, KeyName = "D", Code = "D", Description = "D"}},
            {"E", new KeyCodes() {KeyCode = 69, KeyName = "E", Code = "E", Description = "E"}},
            {"F", new KeyCodes() {KeyCode = 70, KeyName = "F", Code = "F", Description = "F"}},
            {"G", new KeyCodes() {KeyCode = 71, KeyName = "G", Code = "G", Description = "G"}},
            {"H", new KeyCodes() {KeyCode = 72, KeyName = "H", Code = "H", Description = "H"}},
            {"I", new KeyCodes() {KeyCode = 73, KeyName = "I", Code = "I", Description = "I"}},
            {"J", new KeyCodes() {KeyCode = 74, KeyName = "J", Code = "J", Description = "J"}},
            {"K", new KeyCodes() {KeyCode = 75, KeyName = "K", Code = "K", Description = "K"}},
            {"L", new KeyCodes() {KeyCode = 76, KeyName = "L", Code = "L", Description = "L"}},
            {"M", new KeyCodes() {KeyCode = 77, KeyName = "M", Code = "M", Description = "M"}},
            {"N", new KeyCodes() {KeyCode = 78, KeyName = "N", Code = "N", Description = "N"}},
            {"O", new KeyCodes() {KeyCode = 79, KeyName = "O", Code = "O", Description = "O"}},
            {"P", new KeyCodes() {KeyCode = 80, KeyName = "P", Code = "P", Description = "P"}},
            {"Q", new KeyCodes() {KeyCode = 81, KeyName = "Q", Code = "Q", Description = "Q"}},
            {"R", new KeyCodes() {KeyCode = 82, KeyName = "R", Code = "R", Description = "R"}},
            {"S", new KeyCodes() {KeyCode = 83, KeyName = "S", Code = "S", Description = "S"}},
            {"T", new KeyCodes() {KeyCode = 84, KeyName = "T", Code = "T", Description = "T"}},
            {"U", new KeyCodes() {KeyCode = 85, KeyName = "U", Code = "U", Description = "U"}},
            {"V", new KeyCodes() {KeyCode = 86, KeyName = "V", Code = "V", Description = "V"}},
            {"W", new KeyCodes() {KeyCode = 87, KeyName = "W", Code = "W", Description = "W"}},
            {"X", new KeyCodes() {KeyCode = 88, KeyName = "X", Code = "X", Description = "X"}},
            {"Y", new KeyCodes() {KeyCode = 89, KeyName = "Y", Code = "Y", Description = "Y"}},
            {"Z", new KeyCodes() {KeyCode = 90, KeyName = "Z", Code = "Z", Description = "Z"}},
            {"LeftWindows", new KeyCodes() {KeyCode = 91, KeyName = "LeftWindows", Code = "LeftWindows", Description = "LeftWindows"}},
            {"RightWindows", new KeyCodes() {KeyCode = 92, KeyName = "RightWindows", Code = "RightWindows", Description = "RightWindows"}},
            {"Select", new KeyCodes() {KeyCode = 93, KeyName = "Select", Code = "Select", Description = "Select"}},
            {"Numpad0", new KeyCodes() {KeyCode = 96, KeyName = "Numpad0", Code = "Numpad0", Description = "Numpad0"}},
            {"Numpad1", new KeyCodes() {KeyCode = 97, KeyName = "Numpad1", Code = "Numpad1", Description = "Numpad1"}},
            {"Numpad2", new KeyCodes() {KeyCode = 98, KeyName = "Numpad2", Code = "Numpad2", Description = "Numpad2"}},
            {"Numpad3", new KeyCodes() {KeyCode = 99, KeyName = "Numpad3", Code = "Numpad3", Description = "Numpad3"}},
            {"Numpad4", new KeyCodes() {KeyCode = 100, KeyName = "Numpad4", Code = "Numpad4", Description = "Numpad4"}},
            {"Numpad5", new KeyCodes() {KeyCode = 101, KeyName = "Numpad5", Code = "Numpad5", Description = "Numpad5"}},
            {"Numpad6", new KeyCodes() {KeyCode = 102, KeyName = "Numpad6", Code = "Numpad6", Description = "Numpad6"}},
            {"Numpad7", new KeyCodes() {KeyCode = 103, KeyName = "Numpad7", Code = "Numpad7", Description = "Numpad7"}},
            {"Numpad8", new KeyCodes() {KeyCode = 104, KeyName = "Numpad8", Code = "Numpad8", Description = "Numpad8"}},
            {"Numpad9", new KeyCodes() {KeyCode = 105, KeyName = "Numpad9", Code = "Numpad9", Description = "Numpad9"}},
            {"Multiply", new KeyCodes() {KeyCode = 106, KeyName = "Multiply", Code = "Multiply", Description = "Multiply"}},
            {"Add", new KeyCodes() {KeyCode = 107, KeyName = "Add", Code = "Add", Description = "Add"}},
            {"Subtract", new KeyCodes() {KeyCode = 109, KeyName = "Subtract", Code = "Subtract", Description = "Subtract"}},
            {"DecimalPoint", new KeyCodes() {KeyCode = 110, KeyName = "DecimalPoint", Code = "DecimalPoint", Description = "DecimalPoint"}},
            {"Divide", new KeyCodes() {KeyCode = 111, KeyName = "Divide", Code = "Divide", Description = "Divide"}},
            {"F1", new KeyCodes() {KeyCode = 112, KeyName = "F1", Code = "F1", Description = "F1"}},
            {"F2", new KeyCodes() {KeyCode = 113, KeyName = "F2", Code = "F2", Description = "F2"}},
            {"F3", new KeyCodes() {KeyCode = 114, KeyName = "F3", Code = "F3", Description = "F3"}},
            {"F4", new KeyCodes() {KeyCode = 115, KeyName = "F4", Code = "F4", Description = "F4"}},
            {"F5", new KeyCodes() {KeyCode = 116, KeyName = "F5", Code = "F5", Description = "F5"}},
            {"F6", new KeyCodes() {KeyCode = 117, KeyName = "F6", Code = "F6", Description = "F6"}},
            {"F7", new KeyCodes() {KeyCode = 118, KeyName = "F7", Code = "F7", Description = "F7"}},
            {"F8", new KeyCodes() {KeyCode = 119, KeyName = "F8", Code = "F8", Description = "F8"}},
            {"F9", new KeyCodes() {KeyCode = 120, KeyName = "F9", Code = "F9", Description = "F9"}},
            {"F10", new KeyCodes() {KeyCode = 121, KeyName = "F10", Code = "F10", Description = "F10"}},
            {"F11", new KeyCodes() {KeyCode = 122, KeyName = "F11", Code = "F11", Description = "F11"}},
            {"F12", new KeyCodes() {KeyCode = 123, KeyName = "F12", Code = "F12", Description = "F12"}},
            {"NumLock", new KeyCodes() {KeyCode = 144, KeyName = "NumLock", Code = "NumLock", Description = "NumLock"}},
            {"ScrollLock", new KeyCodes() {KeyCode = 145, KeyName = "ScrollLock", Code = "ScrollLock", Description = "ScrollLock"}},
            {"SemiColon", new KeyCodes() {KeyCode = 186, KeyName = "SemiColon", Code = "SemiColon", Description = "SemiColon"}},
            {"EqualSign", new KeyCodes() {KeyCode = 187, KeyName = "EqualSign", Code = "EqualSign", Description = "EqualSign"}},
            {"Comma", new KeyCodes() {KeyCode = 188, KeyName = "Comma", Code = "Comma", Description = "Comma"}},
            {"Dash", new KeyCodes() {KeyCode = 189, KeyName = "Dash", Code = "Dash", Description = "Dash"}},
            {"Period", new KeyCodes() {KeyCode = 190, KeyName = "Period", Code = "Period", Description = "Period"}},
            {"ForwardSlash", new KeyCodes() {KeyCode = 191, KeyName = "ForwardSlash", Code = "ForwardSlash", Description = "ForwardSlash"}},
            {"GraveAccent", new KeyCodes() {KeyCode = 192, KeyName = "GraveAccent", Code = "GraveAccent", Description = "GraveAccent"}},
            {"OpenBracket", new KeyCodes() {KeyCode = 219, KeyName = "OpenBracket", Code = "OpenBracket", Description = "OpenBracket"}},
            {"BackSlash", new KeyCodes() {KeyCode = 220, KeyName = "BackSlash", Code = "BackSlash", Description = "BackSlash"}},
            {"CloseBracket", new KeyCodes() {KeyCode = 221, KeyName = "CloseBracket", Code = "CloseBracket", Description = "CloseBracket"}},
            {"SingleQuote", new KeyCodes() {KeyCode = 222, KeyName = "SingleQuote", Code = "SingleQuote", Description = "SingleQuote"}}
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