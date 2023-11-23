using Bolsover.Shortcuts.View;
using NUnit.Framework;
using System.Windows.Forms;

namespace UnitTests
{
    public class KeyboardTests
    {
        private ConsoleIO io = new();

        // [Test]
        // public void TestKeyCodesDictionary()
        // {
        //     foreach (KeyValuePair<string, KeyCodes> keyCode in KeyCodes.KeyCodesDictionary())
        //     {
        //         io.WriteLine(keyCode.Value.ToString());
        //     }
        // }
        //
        // [Test]
        // public void TestKeysConverterGetStandard()
        // {
        //     var kc = new KeysConverter();
        //     ICollection svc = kc.GetStandardValues();
        //     io.WriteLine(svc.Count.ToString());
        // }
        //
        // [Test]
        // public void TestKeysEnum()
        // {
        //     var k = Enum.GetValues(typeof(Keys));
        //
        //
        //     foreach (var key in k)
        //     {
        //         var enumType = typeof(Keys);
        //         foreach (var memberInfo in enumType.GetCustomAttributes(true))
        //         {
        //             if (memberInfo is FlagsAttribute)
        //             {
        //                 io.WriteLine("FlagsAttribute" + ((FlagsAttribute) memberInfo).GetType());
        //             }
        //         }
        //     }
        // }

        [Test]
        public void TestKeyboardControl()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KeyboardForm keyboardForm = KeyboardForm.Instance();
            Application.Run(keyboardForm);
        }

        [Test]
        public void TestColorPreferences()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ColorPreferencesForm colorPreferencesForm = new ColorPreferencesForm();
            Application.Run(colorPreferencesForm);
        }

        // [Test]
        // public void KeyboardKeyTestForm()
        // {
        //     Application.EnableVisualStyles();
        //     Application.SetCompatibleTextRenderingDefault(false);
        //     KeyboardKeyTestForm keyboardForm = new KeyboardKeyTestForm();
        //     Application.Run(keyboardForm);
        // }

        // [Test]
        // public void TestDeconstructKeyCode()
        // {
        //     int testcode = 79;
        //     var kc = new KeysConverter();
        //     var keycodes = KeyCodes.DeconstructKeyCode(testcode);
        //     foreach (var k in keycodes)
        //     {
        //         io.WriteLine(k.ToString() + " " + kc.ConvertToString(k));
        //     }
        // }


        // [Test]
        // public void GenerateKeycodesDictionary()
        // {
        //     StringBuilder sb = new StringBuilder();
        //     foreach (var key in KeyCodes.KeyCodesDictionary())
        //     {
        //         sb.Append("{");
        //         sb.Append(key.Value.KeyCode);
        //         sb.Append(", ");
        //         sb.Append("new KeyCodes() { KeyCode = ");
        //         sb.Append(key.Value.KeyCode);
        //         sb.Append(", KeyName = \"");
        //         sb.Append(key.Value.Description);
        //         sb.Append("\", Description = \"");
        //         sb.Append(key.Value.KeyName);
        //         sb.Append("\", Code = \"");
        //         sb.Append(key.Value.Code);
        //         sb.Append("\", KeyImage = ");
        //         sb.Append("KeyStrings." + key.Value.Description);
        //         sb.Append(" } },");
        //         sb.AppendLine();
        //      //   io.WriteLine(key.Key + " " + key.Value);
        //     }
        //     
        //     io.WriteLine(sb.ToString());
        //    
        // }
        //

    }
}