using System;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Perplex_Lite
{


    // Token: 0x02000003 RID: 3
    internal class UIYRIYUTIYEWUTIRERTUERTUERT
	{
		// Token: 0x06000011 RID: 17
		[DllImport("user32.dll")]
		public static extern ushort GetAsyncKeyState(int vKey);
        // Token: 0x06000012 RID: 18
        [DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000013 RID: 19
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(ushort virtualKeyCode);

		// Token: 0x06000014 RID: 20
		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000210F File Offset: 0x0000030F
		public static int _ScreenWidth { get; } = Screen.PrimaryScreen.Bounds.Width;

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002116 File Offset: 0x00000316
		public static int _ScreenHeight { get; } = Screen.PrimaryScreen.Bounds.Height;

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000211D File Offset: 0x0000031D
		public static int _ScreenCenterX { get; } = UIYRIYUTIYEWUTIRERTUERTUERT._ScreenWidth / 2;

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002124 File Offset: 0x00000324
		public static int _ScreenCenterY { get; } = UIYRIYUTIYEWUTIRERTUERTUERT._ScreenHeight / 2;

		// Token: 0x06000019 RID: 25 RVA: 0x00003680 File Offset: 0x00001880
		public static bool bGetAsyncKeyState(Keys vKey)
		{
			int asyncKeyState = (int)UIYRIYUTIYEWUTIRERTUERTUERT.GetAsyncKeyState(vKey);
			return asyncKeyState == 1 || asyncKeyState == -32768;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000212B File Offset: 0x0000032B
		public static void Move(int xDelta, int yDelta)
		{
			UIYRIYUTIYEWUTIRERTUERTUERT.mouse_event(1, xDelta, yDelta, 0, 0);
		}

		// Token: 0x04000021 RID: 33
		private const int MOUSEEVENTF_MOVE = 1;
	}
}
