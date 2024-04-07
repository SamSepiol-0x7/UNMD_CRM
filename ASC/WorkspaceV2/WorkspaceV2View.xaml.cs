using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Editors.Flyout;
using DevExpress.Xpf.Navigation;
using DevExpress.Xpf.WindowsUI;

namespace ASC.WorkspaceV2
{
	// Token: 0x02000121 RID: 289
	public partial class WorkspaceV2View : ThemedWindow, IStyleConnector
	{
		// Token: 0x06001497 RID: 5271 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
		public WorkspaceV2View()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0002EFFC File Offset: 0x0002D1FC
		private void ClickableBase_OnClick(object sender, EventArgs e)
		{
			this.TileBar.CloseFlyout();
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			int num;
			switch (connectionId)
			{
			case 8:
				IL_721:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 9:
				IL_619:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 10:
				IL_107:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 600462335;
				goto IL_47B;
			case 11:
				IL_3A5:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1094940481;
				goto IL_47B;
			case 12:
				IL_37A:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 530575207;
				goto IL_47B;
			case 13:
				IL_2D5:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1384003063;
				goto IL_47B;
			case 14:
				IL_5FF:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 15:
				IL_16A:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 2033926344;
				goto IL_47B;
			case 16:
				IL_359:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1129172766;
				goto IL_47B;
			case 17:
				IL_63A:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 18:
				IL_1EE:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 68288129;
				goto IL_47B;
			case 19:
				IL_423:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 92341901;
				goto IL_47B;
			case 20:
				IL_6D2:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 21:
				IL_1AC:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 602772595;
				goto IL_47B;
			case 22:
				IL_655:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 23:
				IL_739:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 24:
				IL_20F:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1464526642;
				goto IL_47B;
			case 25:
				IL_5E7:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 26:
				IL_6B8:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 27:
				IL_317:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 2033047331;
				goto IL_47B;
			case 28:
				IL_705:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 29:
				IL_230:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 368334679;
				goto IL_47B;
			case 30:
				IL_66D:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 31:
				IL_3E7:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 722094918;
				goto IL_47B;
			case 32:
				IL_2F6:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1758726751;
				goto IL_47B;
			case 33:
				IL_6EB:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 34:
				IL_441:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1671046770;
				goto IL_47B;
			case 35:
				IL_E6:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1548954647;
				goto IL_47B;
			case 36:
				IL_293:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1256838797;
				goto IL_47B;
			case 37:
				IL_18B:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1576447974;
				goto IL_47B;
			case 38:
				IL_755:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 39:
				IL_338:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 599354854;
				goto IL_47B;
			case 40:
				IL_C5:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 995180397;
				goto IL_47B;
			case 41:
				IL_1CD:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1159546416;
				goto IL_47B;
			case 42:
				IL_128:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 686349120;
				goto IL_47B;
			case 43:
				IL_686:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 44:
				IL_272:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 578857983;
				goto IL_47B;
			case 45:
				IL_2B4:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 2041013001;
				goto IL_47B;
			case 46:
				IL_149:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 476377864;
				goto IL_47B;
			case 47:
				IL_45F:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1971141142;
				goto IL_47B;
			case 48:
				IL_69F:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			case 49:
				IL_3C6:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 724958663;
				goto IL_47B;
			case 50:
				IL_405:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 140249296;
				goto IL_47B;
			case 51:
				IL_251:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 998634123;
				goto IL_47B;
			case 52:
				IL_5C6:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				num = 1446059712;
				goto IL_47B;
			case 53:
				IL_76E:
				((TileBarItem)target).Click += this.ClickableBase_OnClick;
				return;
			}
			IL_39B:
			num = 70374725;
			IL_47B:
			switch ((num ^ 1095579461) % 78)
			{
			case 0:
				goto IL_5E7;
			case 1:
				goto IL_5FF;
			case 2:
				goto IL_45F;
			case 3:
				return;
			case 4:
				return;
			case 5:
				goto IL_619;
			case 6:
				return;
			case 7:
				goto IL_76E;
			case 8:
				return;
			case 9:
				goto IL_441;
			case 10:
				goto IL_423;
			case 11:
				return;
			case 12:
				goto IL_5C6;
			case 13:
				goto IL_405;
			case 14:
				goto IL_3E7;
			case 15:
				goto IL_3C6;
			case 16:
				return;
			case 17:
				goto IL_3A5;
			case 18:
				goto IL_39B;
			case 19:
				return;
			case 20:
				goto IL_37A;
			case 21:
				goto IL_359;
			case 22:
				goto IL_338;
			case 23:
				return;
			case 24:
				return;
			case 25:
				return;
			case 26:
				return;
			case 27:
				goto IL_317;
			case 28:
				goto IL_63A;
			case 29:
				return;
			case 30:
				return;
			case 31:
				goto IL_2F6;
			case 32:
				goto IL_2D5;
			case 33:
				goto IL_2B4;
			case 34:
				goto IL_293;
			case 35:
				goto IL_272;
			case 36:
				return;
			case 37:
				goto IL_655;
			case 38:
				goto IL_66D;
			case 39:
				return;
			case 40:
				goto IL_251;
			case 41:
				goto IL_686;
			case 42:
				return;
			case 43:
				goto IL_69F;
			case 44:
				return;
			case 45:
				goto IL_6B8;
			case 46:
				goto IL_230;
			case 47:
				return;
			case 48:
				return;
			case 49:
				goto IL_6D2;
			case 50:
				return;
			case 51:
				goto IL_20F;
			case 52:
				goto IL_6EB;
			case 53:
				return;
			case 54:
				return;
			case 55:
				goto IL_705;
			case 56:
				goto IL_1EE;
			case 57:
				goto IL_1CD;
			case 58:
				return;
			case 59:
				goto IL_1AC;
			case 60:
				goto IL_18B;
			case 61:
				return;
			case 62:
				return;
			case 63:
				goto IL_16A;
			case 64:
				goto IL_149;
			case 65:
				return;
			case 66:
				goto IL_128;
			case 67:
				goto IL_721;
			case 68:
				goto IL_739;
			case 69:
				goto IL_107;
			case 70:
				return;
			case 71:
				return;
			case 72:
				goto IL_E6;
			case 73:
				return;
			case 74:
				return;
			case 75:
				goto IL_755;
			case 76:
				return;
			case 77:
				goto IL_C5;
			default:
				goto IL_76E;
			}
		}
	}
}
