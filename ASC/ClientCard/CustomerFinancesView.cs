using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Grid;

namespace ASC.ClientCard
{
	// Token: 0x02000322 RID: 802
	public class CustomerFinancesView : UserControl, IComponentConnector
	{
		// Token: 0x06002592 RID: 9618 RVA: 0x00072E80 File Offset: 0x00071080
		public CustomerFinancesView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00072E9C File Offset: 0x0007109C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1633356672;
			IL_0D:
			switch ((num ^ 2066235733) % 4)
			{
			case 0:
			{
				IL_2C:
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerfinancesview.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				num = 1324721438;
				goto IL_0D;
			}
			case 1:
				return;
			case 2:
				goto IL_08;
			}
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00072EF8 File Offset: 0x000710F8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.TableCashOrderses = (GridControl)target;
				return;
			case 2:
				this.Id = (GridColumn)target;
				return;
			case 3:
				this.Date = (GridColumn)target;
				return;
			case 4:
				this.Office = (GridColumn)target;
				return;
			case 5:
				this.Cash = (GridColumn)target;
				return;
			case 6:
				this.Cashless = (GridColumn)target;
				return;
			case 7:
				this.Card = (GridColumn)target;
				return;
			case 8:
				this.OtherPS = (GridColumn)target;
				return;
			case 9:
				this.Image = (GridColumn)target;
				return;
			case 10:
				this.Client = (GridColumn)target;
				return;
			case 11:
				this.Employee = (GridColumn)target;
				return;
			case 12:
				this.Notes = (GridColumn)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040013FF RID: 5119
		internal GridControl TableCashOrderses;

		// Token: 0x04001400 RID: 5120
		internal GridColumn Id;

		// Token: 0x04001401 RID: 5121
		internal GridColumn Date;

		// Token: 0x04001402 RID: 5122
		internal GridColumn Office;

		// Token: 0x04001403 RID: 5123
		internal GridColumn Cash;

		// Token: 0x04001404 RID: 5124
		internal GridColumn Cashless;

		// Token: 0x04001405 RID: 5125
		internal GridColumn Card;

		// Token: 0x04001406 RID: 5126
		internal GridColumn OtherPS;

		// Token: 0x04001407 RID: 5127
		internal GridColumn Image;

		// Token: 0x04001408 RID: 5128
		internal GridColumn Client;

		// Token: 0x04001409 RID: 5129
		internal GridColumn Employee;

		// Token: 0x0400140A RID: 5130
		internal GridColumn Notes;

		// Token: 0x0400140B RID: 5131
		private bool _contentLoaded;
	}
}
