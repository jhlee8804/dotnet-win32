using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WinFormCustomControls.Native
{
    internal static partial class NativeMethods
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
    }
}
