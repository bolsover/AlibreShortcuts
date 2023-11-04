using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Bolsover.Shortcuts.View;
using NUnit.Framework;
using Shortcuts.Shortcuts.View;

namespace UnitTests
{
    public class KeyboardTests
    {
        private ConsoleIO io = new();

        [Test]
        public void TestKeyCodesDictionary()
        {
            foreach (KeyValuePair<string, KeyCodes> keyCode in KeyCodes.KeyCodesDictionary())
            {
                io.WriteLine(keyCode.Value.ToString());
            }
        }

        [Test]
        public void TestKeysConverterGetStandard()
        {
            var kc = new KeysConverter();
            ICollection svc = kc.GetStandardValues();
            io.WriteLine(svc.Count.ToString());
        }

        [Test]
        public void TestKeysEnum()
        {
            var k = Enum.GetValues(typeof(Keys));


            foreach (var key in k)
            {
                var enumType = typeof(Keys);
                foreach (var memberInfo in enumType.GetCustomAttributes(true))
                {
                    if (memberInfo is FlagsAttribute)
                    {
                        io.WriteLine("FlagsAttribute" + ((FlagsAttribute) memberInfo).GetType());
                    }
                }
            }
        }
        
        [Test]
        public void TestKeyboardControl()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TestKeyboardForm keyboardForm = new TestKeyboardForm();
            Application.Run(keyboardForm);
         
            
           
        }

        [Test]
        public void TestDeconstructKeyCode()
        {
            int testcode = 79;
            var kc = new KeysConverter();
            var keycodes = KeyCodes.DeconstructKeyCode(testcode);
            foreach (var k in keycodes)
            {
                io.WriteLine(k.ToString() + " " + kc.ConvertToString(k));
            }
            
        }
    }
}