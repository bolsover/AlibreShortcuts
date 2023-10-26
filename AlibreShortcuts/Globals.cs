using System.Drawing;
using Microsoft.Win32;

namespace Shortcuts
{
    public class Globals
    {
        public static string InstallPath = (string) Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Alibre Design Add-Ons\",
            "{331d2798-21bf-4173-a33f-6b4f58e015bb}", null);

        public static Icon Icon = new Icon(InstallPath + "\\shortcuts.ico");
        
        public static readonly string AppName = "AlibreShortcuts";

    }
}