using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WinFormCustomControls.Native
{
    internal static partial class NativeMethods
    {
        public static class HwndZPosition
        {
            public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
            public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
            public static readonly IntPtr HWND_TOP = new IntPtr(0);
            public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        }

        public enum ABM : uint
        {
            New = 0x00000000,
            Remove = 0x00000001,
            QueryPos = 0x00000002,
            SetPos = 0x00000003,
            GetState = 0x00000004,
            GetTaskbarPos = 0x00000005,
            Activate = 0x00000006,
            GetAutoHideBar = 0x00000007,
            SetAutoHideBar = 0x00000008,
            WindowPosChanged = 0x00000009,
            SetState = 0x0000000A,
        }

        public enum ABE : uint
        {
            Left = 0,
            Top = 1,
            Right = 2,
            Bottom = 3
        }

        public enum ScrollBar : int
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_CTL = 2,
            SB_BOTH = 3,
        }

        public enum ScrollBarEvent : int
        {
            SB_LINEUP = 0,
            SB_LINEDOWN = 1,
            SB_PAGEUP = 2,
            SB_PAGEDOWN = 3,
            SB_THUMBPOSITION = 4,
            SB_THUMBTRACK = 5,
            SB_TOP = 6,
            SB_BOTTOM = 7,
            SB_ENDSCROLL = 8
        }

        public enum DCX : int
        {
            DCX_CACHE = 0x00000002,
            DCX_CLIPCHILDREN = 0x00000008,
            DCX_CLIPSIBLINGS = 0x00000010,
            DCX_EXCLUDERGN = 0x00000040,
            DCX_EXCLUDEUPDATE = 0x00000100,
            DCX_INTERSECTRGN = 0x00000080,
            DCX_INTERSECTUPDATE = 0x00000200,
            DCX_LOCKWINDOWUPDATE = 0x00000400,
            DCX_NORECOMPUTE = 0x100000,
            DCX_NORESETATTRS = 0x00000004,
            DCX_PARENTCLIP = 0x00000020,
            DCX_VALIDATE = 0x00200000,
            DCX_WINDOW = 0x00000001,
        }

        public enum SWP : int
        {
            SWP_NOSIZE = 0x0001,
            SWP_NOMOVE = 0x0002,
            SWP_NOZORDER = 0x0004,
            SWP_NOREDRAW = 0x0008,
            SWP_NOACTIVATE = 0x0010,
            SWP_FRAMECHANGED = 0x0020,
            SWP_DRAWFRAME = SWP_FRAMECHANGED,
            SWP_SHOWWINDOW = 0x0040,
            SWP_HIDEWINDOW = 0x0080,
            SWP_NOCOPYBITS = 0x0100,
            SWP_NOOWNERZORDER = 0x0200,
            SWP_NOSENDCHANGING = 0x0400,
            SWP_DEFERERASE = 0x2000,
            SWP_ASYNCWINDOWPOS = 0x4000
        }

        public enum NonClientHitTest : int
        {
            HTERROR = -2,
            HTTRANSPARENT = -1,
            HTNOWHERE = 0,
            HTCLIENT = 1,
            HTCAPTION = 2,
            HTSYSMENU = 3,
            HTGROWBOX = 4,
            HTMENU = 5,
            HTHSCROLL = 6,
            HTVSCROLL = 7,
            HTSIZE = HTGROWBOX,
            HTMINBUTTON = 8,
            HTMAXBUTTON = 9,
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17,
            HTREDUCE = HTMINBUTTON,
            HTZOOM = HTMAXBUTTON,
            HTSIZEFIRST = HTLEFT,
            HTSIZELAST = HTBOTTOMRIGHT,
            HTBORDER = 18,
            HTOBJECT = 19,
            HTCLOSE = 20,
            HTHELP = 21,

            // Custom
            HTCUSTOM = 22,
            HTPIN = 23
        }

        public enum TabControlHitTest : int
        {
            TCHT_NOWHERE = 1,
        }

        public enum TabControlMessage : int
        {
            TCM_FIRST = 0x1300,
            TCM_ADJUSTRECT = TCM_FIRST + 40,
            TCM_DELETEALLITEMS = TCM_FIRST + 9,
            TCM_DELETEITEM = TCM_FIRST + 8,
            TCM_DESELECTALL = TCM_FIRST + 50,
            TCM_GETCURFOCUS = TCM_FIRST + 47,
            TCM_GETCURSEL = TCM_FIRST + 11,
            TCM_GETEXTENDEDSTYLE = TCM_FIRST + 53,
            TCM_GETIMAGELIST = TCM_FIRST + 2,
            TCM_GETITEM = TCM_FIRST + 60,
            TCM_GETITEMA = TCM_FIRST + 5,
            TCM_GETITEMCOUNT = TCM_FIRST + 4,
            TCM_GETITEMRECT = TCM_FIRST + 10,
            TCM_GETROWCOUNT = TCM_FIRST + 44,
            TCM_GETTOOLTIPS = TCM_FIRST + 45,
            //TCM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT
            TCM_HIGHLIGHTITEM = TCM_FIRST + 51,
            TCM_HITTEST = TCM_FIRST + 13,
            TCM_INSERTITEM = TCM_FIRST + 62,
            TCM_INSERTITEMA = TCM_FIRST + 7,
            TCM_REMOVEIMAGE = TCM_FIRST + 42,
            TCM_SETCURFOCUS = TCM_FIRST + 48,
            TCM_SETCURSEL = TCM_FIRST + 12,
            TCM_SETEXTENDEDSTYLE = TCM_FIRST + 52,
            TCM_SETIMAGELIST = TCM_FIRST + 3,
            TCM_SETITEM = TCM_FIRST + 61,
            TCM_SETITEMA = TCM_FIRST + 6,
            TCM_SETITEMEXTRA = TCM_FIRST + 14,
            TCM_SETITEMSIZE = TCM_FIRST + 41,
            TCM_SETMINTABWIDTH = TCM_FIRST + 49,
            TCM_SETPADDING = TCM_FIRST + 43,
            TCM_SETTOOLTIPS = TCM_FIRST + 46
            //TCM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT
        }

        public enum Messages : uint
        {
            WM_NULL = 0x0,
            WM_CREATE = 0x1,
            WM_DESTROY = 0x2,
            WM_MOVE = 0x3,
            WM_SIZE = 0x5,
            WM_ACTIVATE = 0x6,
            WM_SETFOCUS = 0x7,
            WM_KILLFOCUS = 0x8,
            WM_ENABLE = 0xa,
            WM_SETREDRAW = 0xb,
            WM_SETTEXT = 0xc,
            WM_GETTEXT = 0xd,
            WM_GETTEXTLENGTH = 0xe,
            WM_PAINT = 0xf,
            WM_CLOSE = 0x10,
            WM_QUERYENDSESSION = 0x11,
            WM_QUERYOPEN = 0x13,
            WM_ENDSESSION = 0x16,
            WM_QUIT = 0x12,
            WM_ERASEBKGND = 0x14,
            WM_SYSCOLORCHANGE = 0x15,
            WM_SHOWWINDOW = 0x18,
            WM_WININICHANGE = 0x1a,
            WM_SETTINGCHANGE = WM_WININICHANGE,
            WM_DEVMODECHANGE = 0x1b,
            WM_ACTIVATEAPP = 0x1c,
            WM_FONTCHANGE = 0x1d,
            WM_TIMECHANGE = 0x1e,
            WM_CANCELMODE = 0x1f,
            WM_SETCURSOR = 0x20,
            WM_MOUSEACTIVATE = 0x21,
            WM_CHILDACTIVATE = 0x22,
            WM_QUEUESYNC = 0x23,
            WM_GETMINMAXINFO = 0x24,
            WM_PAINTICON = 0x26,
            WM_ICONERASEBKGND = 0x27,
            WM_NEXTDLGCTL = 0x28,
            WM_SPOOLERSTATUS = 0x2a,
            WM_DRAWITEM = 0x2b,
            WM_MEASUREITEM = 0x2c,
            WM_DELETEITEM = 0x2d,
            WM_VKEYTOITEM = 0x2e,
            WM_CHARTOITEM = 0x2f,
            WM_SETFONT = 0x30,
            WM_GETFONT = 0x31,
            WM_SETHOTKEY = 0x32,
            WM_GETHOTKEY = 0x33,
            WM_QUERYDRAGICON = 0x37,
            WM_COMPAREITEM = 0x39,
            WM_GETOBJECT = 0x3d,
            WM_COMPACTING = 0x41,
            WM_COMMNOTIFY = 0x44,
            WM_WINDOWPOSCHANGING = 0x46,
            WM_WINDOWPOSCHANGED = 0x47,
            WM_POWER = 0x48,
            WM_COPYDATA = 0x4a,
            WM_CANCELJOURNAL = 0x4b,
            WM_NOTIFY = 0x4e,
            WM_INPUTLANGCHANGEREQUEST = 0x50,
            WM_INPUTLANGCHANGE = 0x51,
            WM_TCARD = 0x52,
            WM_HELP = 0x53,
            WM_USERCHANGED = 0x54,
            WM_NOTIFYFORMAT = 0x55,
            WM_CONTEXTMENU = 0x7b,
            WM_STYLECHANGING = 0x7c,
            WM_STYLECHANGED = 0x7d,
            WM_DISPLAYCHANGE = 0x7e,
            WM_GETICON = 0x7f,
            WM_SETICON = 0x80,
            WM_NCCREATE = 0x81,
            WM_NCDESTROY = 0x82,
            WM_NCCALCSIZE = 0x83,
            WM_NCHITTEST = 0x84,
            WM_NCPAINT = 0x85,
            WM_NCACTIVATE = 0x86,
            WM_GETDLGCODE = 0x87,
            WM_SYNCPAINT = 0x88,
            WM_NCMOUSEMOVE = 0xa0,
            WM_NCLBUTTONDOWN = 0xa1,
            WM_NCLBUTTONUP = 0xa2,
            WM_NCLBUTTONDBLCLK = 0xa3,
            WM_NCRBUTTONDOWN = 0xa4,
            WM_NCRBUTTONUP = 0xa5,
            WM_NCRBUTTONDBLCLK = 0xa6,
            WM_NCMBUTTONDOWN = 0xa7,
            WM_NCMBUTTONUP = 0xa8,
            WM_NCMBUTTONDBLCLK = 0xa9,
            WM_NCXBUTTONDOWN = 0xab,
            WM_NCXBUTTONUP = 0xac,
            WM_NCXBUTTONDBLCLK = 0xad,
            WM_NCUAHDRAWCAPTION = 0x00AE,
            WM_INPUT = 0xff,
            WM_KEYFIRST = 0x100,
            WM_KEYDOWN = 0x100,
            WM_KEYUP = 0x101,
            WM_CHAR = 0x102,
            WM_DEADCHAR = 0x103,
            WM_SYSKEYDOWN = 0x104,
            WM_SYSKEYUP = 0x105,
            WM_SYSCHAR = 0x106,
            WM_SYSDEADCHAR = 0x107,
            WM_UNICHAR = 0x109,
            WM_KEYLAST = 0x108,
            WM_IME_STARTCOMPOSITION = 0x10d,
            WM_IME_ENDCOMPOSITION = 0x10e,
            WM_IME_COMPOSITION = 0x10f,
            WM_IME_KEYLAST = 0x10f,
            WM_INITDIALOG = 0x110,
            WM_COMMAND = 0x111,
            WM_SYSCOMMAND = 0x112,
            WM_TIMER = 0x113,
            WM_HSCROLL = 0x114,
            WM_VSCROLL = 0x115,
            WM_INITMENU = 0x116,
            WM_INITMENUPOPUP = 0x117,
            WM_MENUSELECT = 0x11f,
            WM_MENUCHAR = 0x120,
            WM_ENTERIDLE = 0x121,
            WM_MENURBUTTONUP = 0x122,
            WM_MENUDRAG = 0x123,
            WM_MENUGETOBJECT = 0x124,
            WM_UNINITMENUPOPUP = 0x125,
            WM_MENUCOMMAND = 0x126,
            WM_CHANGEUISTATE = 0x127,
            WM_UPDATEUISTATE = 0x128,
            WM_QUERYUISTATE = 0x129,
            WM_CTLCOLOR = 0x19,
            WM_CTLCOLORMSGBOX = 0x132,
            WM_CTLCOLOREDIT = 0x133,
            WM_CTLCOLORLISTBOX = 0x134,
            WM_CTLCOLORBTN = 0x135,
            WM_CTLCOLORDLG = 0x136,
            WM_CTLCOLORSCROLLBAR = 0x137,
            WM_CTLCOLORSTATIC = 0x138,
            WM_MOUSEFIRST = 0x200,
            WM_MOUSEMOVE = 0x200,
            WM_LBUTTONDOWN = 0x201,
            WM_LBUTTONUP = 0x202,
            WM_LBUTTONDBLCLK = 0x203,
            WM_RBUTTONDOWN = 0x204,
            WM_RBUTTONUP = 0x205,
            WM_RBUTTONDBLCLK = 0x206,
            WM_MBUTTONDOWN = 0x207,
            WM_MBUTTONUP = 0x208,
            WM_MBUTTONDBLCLK = 0x209,
            WM_MOUSEWHEEL = 0x20a,
            WM_XBUTTONDOWN = 0x20b,
            WM_XBUTTONUP = 0x20c,
            WM_XBUTTONDBLCLK = 0x20d,
            WM_MOUSELAST = 0x20d,
            WM_PARENTNOTIFY = 0x210,
            WM_ENTERMENULOOP = 0x211,
            WM_EXITMENULOOP = 0x212,
            WM_NEXTMENU = 0x213,
            WM_SIZING = 0x214,
            WM_CAPTURECHANGED = 0x215,
            WM_MOVING = 0x216,
            WM_POWERBROADCAST = 0x218,
            WM_DEVICECHANGE = 0x219,
            WM_MDICREATE = 0x220,
            WM_MDIDESTROY = 0x221,
            WM_MDIACTIVATE = 0x222,
            WM_MDIRESTORE = 0x223,
            WM_MDINEXT = 0x224,
            WM_MDIMAXIMIZE = 0x225,
            WM_MDITILE = 0x226,
            WM_MDICASCADE = 0x227,
            WM_MDIICONARRANGE = 0x228,
            WM_MDIGETACTIVE = 0x229,
            WM_MDISETMENU = 0x230,
            WM_ENTERSIZEMOVE = 0x231,
            WM_EXITSIZEMOVE = 0x232,
            WM_DROPFILES = 0x233,
            WM_MDIREFRESHMENU = 0x234,
            WM_IME_SETCONTEXT = 0x281,
            WM_IME_NOTIFY = 0x282,
            WM_IME_CONTROL = 0x283,
            WM_IME_COMPOSITIONFULL = 0x284,
            WM_IME_SELECT = 0x285,
            WM_IME_CHAR = 0x286,
            WM_IME_REQUEST = 0x288,
            WM_IME_KEYDOWN = 0x290,
            WM_IME_KEYUP = 0x291,
            WM_NCMOUSEHOVER = 0x02a0,
            WM_MOUSEHOVER = 0x2a1,
            WM_MOUSELEAVE = 0x2a3,
            WM_NCMOUSELEAVE = 0x2a2,
            WM_WTSSESSION_CHANGE = 0x2b1,
            WM_TABLET_FIRST = 0x2c0,
            WM_TABLET_LAST = 0x2df,
            WM_CUT = 0x300,
            WM_COPY = 0x301,
            WM_PASTE = 0x302,
            WM_CLEAR = 0x303,
            WM_UNDO = 0x304,
            WM_RENDERFORMAT = 0x305,
            WM_RENDERALLFORMATS = 0x306,
            WM_DESTROYCLIPBOARD = 0x307,
            WM_DRAWCLIPBOARD = 0x308,
            WM_PAINTCLIPBOARD = 0x309,
            WM_VSCROLLCLIPBOARD = 0x30a,
            WM_SIZECLIPBOARD = 0x30b,
            WM_ASKCBFORMATNAME = 0x30c,
            WM_CHANGECBCHAIN = 0x30d,
            WM_HSCROLLCLIPBOARD = 0x30e,
            WM_QUERYNEWPALETTE = 0x30f,
            WM_PALETTEISCHANGING = 0x310,
            WM_PALETTECHANGED = 0x311,
            WM_HOTKEY = 0x312,
            WM_PRINT = 0x317,
            WM_PRINTCLIENT = 0x318,
            WM_APPCOMMAND = 0x319,
            WM_THEMECHANGED = 0x31a,
            WM_HANDHELDFIRST = 0x358,
            WM_HANDHELDLAST = 0x35f,
            WM_AFXFIRST = 0x360,
            WM_AFXLAST = 0x37f,
            WM_PENWINFIRST = 0x380,
            WM_PENWINLAST = 0x38f,
            WM_USER = 0x400,
            WM_REFLECT = 0x2000,
            WM_APP = 0x8000,
            WM_DWMCOMPOSITIONCHANGED = 0x031E,

            SC_MOVE = 0xF010,
            SC_MINIMIZE = 0XF020,
            SC_MAXIMIZE = 0xF030,
            SC_RESTORE = 0xF120,

            EM_SETCUEBANNER = 0x1501
        }

        public enum WA
        {
            WA_INACTIVE = 0,
            WA_ACTIVE = 1,
            WA_CLICKACTIVE = 2
        }

        public enum WindowStyle
        {
            WS_OVERLAPPED = 0x00000000,
            WS_POPUP = -2147483648, //0x80000000,
            WS_CHILD = 0x40000000,
            WS_MINIMIZE = 0x20000000,
            WS_VISIBLE = 0x10000000,
            WS_DISABLED = 0x08000000,
            WS_CLIPSIBLINGS = 0x04000000,
            WS_CLIPCHILDREN = 0x02000000,
            WS_MAXIMIZE = 0x01000000,
            WS_CAPTION = 0x00C00000,
            WS_BORDER = 0x00800000,
            WS_DLGFRAME = 0x00400000,
            WS_VSCROLL = 0x00200000,
            WS_HSCROLL = 0x00100000,
            WS_SYSMENU = 0x00080000,
            WS_THICKFRAME = 0x00040000,
            WS_GROUP = 0x00020000,
            WS_TABSTOP = 0x00010000,
            WS_MINIMIZEBOX = 0x00020000,
            WS_MAXIMIZEBOX = 0x00010000,
            WS_TILED = WS_OVERLAPPED,
            WS_ICONIC = WS_MINIMIZE,
            WS_SIZEBOX = WS_THICKFRAME,
            WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,
            WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU |
                                    WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
            WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),
            WS_CHILDWINDOW = (WS_CHILD)
        }

        public enum WindowStyleEx
        {
            WS_EX_DLGMODALFRAME = 0x00000001,
            WS_EX_NOPARENTNOTIFY = 0x00000004,
            WS_EX_TOPMOST = 0x00000008,
            WS_EX_ACCEPTFILES = 0x00000010,
            WS_EX_TRANSPARENT = 0x00000020,
            WS_EX_MDICHILD = 0x00000040,
            WS_EX_TOOLWINDOW = 0x00000080,
            WS_EX_WINDOWEDGE = 0x00000100,
            WS_EX_CLIENTEDGE = 0x00000200,
            WS_EX_CONTEXTHELP = 0x00000400,
            WS_EX_RIGHT = 0x00001000,
            WS_EX_LEFT = 0x00000000,
            WS_EX_RTLREADING = 0x00002000,
            WS_EX_LTRREADING = 0x00000000,
            WS_EX_LEFTSCROLLBAR = 0x00004000,
            WS_EX_RIGHTSCROLLBAR = 0x00000000,
            WS_EX_CONTROLPARENT = 0x00010000,
            WS_EX_STATICEDGE = 0x00020000,
            WS_EX_APPWINDOW = 0x00040000,
            WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE),
            WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST),
            WS_EX_LAYERED = 0x00080000,
            WS_EX_NOINHERITLAYOUT = 0x00100000, // Disable inheritence of mirroring by children
            WS_EX_LAYOUTRTL = 0x00400000, // Right to left mirroring
            WS_EX_COMPOSITED = 0x02000000,
            WS_EX_NOACTIVATE = 0x08000000,
        }

        public enum ClassStyles
        {
            CS_DROPSHADOW = 0x20000,
            CS_OWNDC = 0x0020,
            CS_CLASSDC = 0x0040
        }

        public enum SWStatus
        {
            SW_PARENTCLOSING = 0x01,
            SW_OTHERZOOM = 0x02,
            SW_PARENTOPENING = 0x03,
            SW_OTHERUNZOOM = 0x04
        }

        public enum SWCommands
        {
            SW_HIDE = 0x00,
            SW_SHOWNORMAL = 0x01,
            SW_SHOWMINIMIZED = 0x02,
            SW_MAXIMIZE = 0x03,
            SW_SHOWNOACTIVATE = 0x04,
            SW_SHOW = 0x05,
            SW_MINIMIZE = 0x06,
            SW_SHOWMINNOACTIVE = 0x07,
            SW_SHOWNA = 0x08,
            SW_RESTORE = 0x09,
            SW_SHOWDEFAULT = 0x10,
            SW_FORCEMINIMIZE = 0x11
        }

        [Flags()]
        public enum RedrawWindowFlags : uint
        {
            /// <summary>
            /// Invalidates the rectangle or region that you specify in lprcUpdate or hrgnUpdate.
            /// You can set only one of these parameters to a non-NULL value. If both are NULL, RDW_INVALIDATE invalidates the entire window.
            /// </summary>
            Invalidate = 0x1,

            /// <summary>Causes the OS to post a WM_PAINT message to the window regardless of whether a portion of the window is invalid.</summary>
            publicPaint = 0x2,

            /// <summary>
            /// Causes the window to receive a WM_ERASEBKGND message when the window is repainted.
            /// Specify this value in combination with the RDW_INVALIDATE value; otherwise, RDW_ERASE has no effect.
            /// </summary>
            Erase = 0x4,

            /// <summary>
            /// Validates the rectangle or region that you specify in lprcUpdate or hrgnUpdate.
            /// You can set only one of these parameters to a non-NULL value. If both are NULL, RDW_VALIDATE validates the entire window.
            /// This value does not affect public WM_PAINT messages.
            /// </summary>
            Validate = 0x8,

            NopublicPaint = 0x10,

            /// <summary>Suppresses any pending WM_ERASEBKGND messages.</summary>
            NoErase = 0x20,

            /// <summary>Excludes child windows, if any, from the repainting operation.</summary>
            NoChildren = 0x40,

            /// <summary>Includes child windows, if any, in the repainting operation.</summary>
            AllChildren = 0x80,

            /// <summary>Causes the affected windows, which you specify by setting the RDW_ALLCHILDREN and RDW_NOCHILDREN values, to receive WM_ERASEBKGND and WM_PAINT messages before the RedrawWindow returns, if necessary.</summary>
            UpdateNow = 0x100,

            /// <summary>
            /// Causes the affected windows, which you specify by setting the RDW_ALLCHILDREN and RDW_NOCHILDREN values, to receive WM_ERASEBKGND messages before RedrawWindow returns, if necessary.
            /// The affected windows receive WM_PAINT messages at the ordinary time.
            /// </summary>
            EraseNow = 0x200,

            Frame = 0x400,

            NoFrame
        }

        public enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
    }
}
