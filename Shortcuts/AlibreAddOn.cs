using System;
using AlibreAddOn;
using AlibreX;

namespace AlibreAddOnAssembly
{
    public static class AlibreAddOn
    {
        private static IADRoot _root;
        private static Shortcuts.AlibreShortcuts _alibreShortcuts;
        private static IntPtr _parentWinHandle;

        public static void AddOnLoad(IntPtr hwnd, IAutomationHook pAutomationHook, IntPtr unused)
        {
            _root = (IADRoot) pAutomationHook.Root;
            _parentWinHandle = hwnd;
            _alibreShortcuts = new Shortcuts.AlibreShortcuts(_root, _parentWinHandle);
        }

        public static IADRoot GetRoot()
        {
            return _root;
        }

        public static void AddOnInvoke(IntPtr hwnd, IntPtr pAutomationHook, string sessionName, bool isLicensed, int reserved1, int reserved2)
        {
        }

        public static void AddOnUnload(IntPtr hwnd, bool forceUnload, ref bool cancel, int reserved1, int reserved2)
        {
            _alibreShortcuts = null;
            _root = null;
        }

        public static IAlibreAddOn GetAddOnInterface()
        {
            return _alibreShortcuts;
        }
    }
}
