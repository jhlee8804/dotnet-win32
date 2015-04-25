using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WinFormCustomControls.Native
{
    internal static partial class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool FreeLibrary(IntPtr hModule);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();
    }
}
