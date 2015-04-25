using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WinFormCustomControls.Native
{
    internal static partial class NativeMethods
    {
        public const int GCS_COMPSTR = 8;

        [DllImport("imm32.dll")]
        public static extern IntPtr ImmGetContext(IntPtr hWnd);

        [DllImport("Imm32.dll")]
        public static extern bool ImmReleaseContext(IntPtr hWnd, IntPtr hIMC);

        [DllImport("Imm32.dll", CharSet = CharSet.Unicode)]
        public static extern int ImmGetCompositionStringW(
          IntPtr hIMC,
          int dwIndex,
          byte[] lpBuf,
          int dwBufLen);

        [DllImport("imm32.dll", CharSet = CharSet.Unicode)]
        public static extern int ImmGetCompositionString(
            IntPtr hIMC, 
            uint dwIndex, 
            char[] lpBuf, 
            uint dwBufLen);
    }
}
