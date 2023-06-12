using System;
using System.Windows.Forms;

namespace Perplex_Lite
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600001D RID: 29 RVA: 0x0000213F File Offset: 0x0000033F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
