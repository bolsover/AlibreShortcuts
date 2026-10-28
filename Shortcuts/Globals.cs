using System.Drawing;
using System.IO;
using Microsoft.Win32;

namespace Shortcuts
{
    public class Globals
    {
        public static string InstallPath = (string) Registry.GetValue(
            @"HKEY_LOCAL_MACHINE\SOFTWARE\Alibre Design Add-Ons\",
            "{90170D0D-AF9B-4893-8967-91C980203EA2}", null);

        public static Icon Icon
        {
            get
            {
                try
                {
                    if (!string.IsNullOrEmpty(InstallPath) && File.Exists(Path.Combine(InstallPath, "shortcuts.ico")))
                    {
                        return new Icon(Path.Combine(InstallPath, "shortcuts.ico"));
                    }

                    if (File.Exists("shortcuts.ico"))
                    {
                        return new Icon("shortcuts.ico");
                    }
                }
                catch
                {
                }

                return null;
            }
        }

        public static readonly string AppName = "AlibreShortcuts";
        public static int MajorVersion = 0;
    }
}