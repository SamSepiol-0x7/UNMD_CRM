using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Xpf.Grid;

namespace ASC.Extensions
{
	// Token: 0x02000B63 RID: 2915
	public class GridControlEx : GridControl
	{
		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x0015EAD8 File Offset: 0x0015CCD8
		public ICommand ExpandAllCommand
		{
			get
			{
				return new DelegateCommand(delegate()
				{
					for (int i = 0; i < base.VisibleRowCount; i++)
					{
						int rowHandleByVisibleIndex = base.GetRowHandleByVisibleIndex(i);
						base.ExpandMasterRow(rowHandleByVisibleIndex, null);
					}
				});
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x0015EAF8 File Offset: 0x0015CCF8
		public ICommand CollapseAllButThisCommand
		{
			get
			{
				return new DelegateCommand(delegate()
				{
					if (base.View.FocusedRowHandle >= 0)
					{
						base.ExpandMasterRow(base.View.FocusedRowHandle, null);
					}
					for (int i = 0; i < base.VisibleRowCount; i++)
					{
						if (i != base.View.FocusedRowHandle)
						{
							base.CollapseMasterRow(i, null);
						}
					}
				});
			}
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x0015EB18 File Offset: 0x0015CD18
		public GridControlEx()
		{
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x0015EB2C File Offset: 0x0015CD2C
		[CompilerGenerated]
		private void <get_ExpandAllCommand>b__1_0()
		{
			for (int i = 0; i < base.VisibleRowCount; i++)
			{
				int rowHandleByVisibleIndex = base.GetRowHandleByVisibleIndex(i);
				base.ExpandMasterRow(rowHandleByVisibleIndex, null);
			}
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x0015EB5C File Offset: 0x0015CD5C
		[CompilerGenerated]
		private void <get_CollapseAllButThisCommand>b__3_0()
		{
			if (base.View.FocusedRowHandle >= 0)
			{
				base.ExpandMasterRow(base.View.FocusedRowHandle, null);
			}
			for (int i = 0; i < base.VisibleRowCount; i++)
			{
				if (i != base.View.FocusedRowHandle)
				{
					base.CollapseMasterRow(i, null);
				}
			}
		}
	}
}
