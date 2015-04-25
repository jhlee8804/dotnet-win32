using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace WinFormCustomControls.Native
{
    internal static partial class NativeMethods
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public Int32 x;
            public Int32 y;

            public POINT(Int32 x, Int32 y) { this.x = x; this.y = y; }
            public POINT(Point pt) { this.x = pt.X; this.y = pt.Y; }

            public Point ToPoint() { return new Point(x, y); }

            public override string ToString() { return ToPoint().ToString(); }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SIZE
        {
            public Int32 cx;
            public Int32 cy;

            public SIZE(Int32 cx, Int32 cy) { this.cx = cx; this.cy = cy; }
            public SIZE(Size size) { this.cx = size.Width; this.cy = size.Height; }

            public Size ToSize() { return new Size(cx, cy); }

            public override string ToString() { return ToSize().ToString(); }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

            public RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public Rectangle ToRectangle() { return new Rectangle(Left, Top, Right - Left, Bottom - Top); }

            public static RECT FromRectangle(Rectangle rect)
            {
                return new RECT(rect.Left, rect.Top, rect.Right, rect.Bottom);
            }

            public override string ToString() { return ToRectangle().ToString(); }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PAINTSTRUCT
        {
            public IntPtr hdc;
            public int fErase;
            public RECT rcPaint;
            public int fRestore;
            public int fIncUpdate;
            public int Reserved1;
            public int Reserved2;
            public int Reserved3;
            public int Reserved4;
            public int Reserved5;
            public int Reserved6;
            public int Reserved7;
            public int Reserved8;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NCCALCSIZE_PARAMS
        {
            public RECT rect0;                  // new window
            public RECT rect1;                  // old window
            public RECT rect2;                  // client
            public IntPtr lppos;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct APPBARDATA
        {
            public uint cbSize;
            public IntPtr hWnd;
            public uint uCallbackMessage;
            public ABE uEdge;
            public RECT rc;
            public int lParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WindowPos
        {
            public IntPtr hwnd;
            public IntPtr hWndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public int flags;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ICONINFO
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }
    }
}
