using System.Drawing;
using Microsoft.Win32;

namespace Shortcuts
{
    public class Globals
    {
        public static string InstallPath = (string) Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Alibre Design Add-Ons\",
            "{90170D0D-AF9B-4893-8967-91C980203EA2}", null);

        public static Icon Icon = new Icon(InstallPath + "\\shortcuts.ico");

        public static readonly string AppName = "AlibreShortcuts";
    }
}