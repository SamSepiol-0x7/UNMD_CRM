using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace ASC.ClientCard
{
	// Token: 0x0200031E RID: 798
	public class CustomerBalanceView : UserControl, IComponentConnector
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x00072BD4 File Offset: 0x00070DD4
		public CustomerBalanceView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void TableBalance_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00072BF0 File Offset: 0x00070DF0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customerbalanceview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00072C20 File Offset: 0x00070E20
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.TableBalance = (GridControl)target;
				this.TableBalance.AddHandler(DXSerializer.AllowPropertyEvent, new AllowPropertyEventHandler(this.TableBalance_OnAllowProperty));
				return;
			case 2:
				this.Id = (GridColumn)target;
				return;
			case 3:
				this.Date = (GridColumn)target;
				return;
			case 4:
				this.Summ = (GridColumn)target;
				return;
			case 5:
				this.Reason = (GridColumn)target;
				return;
			case 6:
				this.Employee = (GridColumn)target;
				return;
			case 7:
				this.Office = (GridColumn)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040013EF RID: 5103
		internal GridControl TableBalance;

		// Token: 0x040013F0 RID: 5104
		internal GridColumn Id;

		// Token: 0x040013F1 RID: 5105
		internal GridColumn Date;

		// Token: 0x040013F2 RID: 5106
		internal GridColumn Summ;

		// Token: 0x040013F3 RID: 5107
		internal GridColumn Reason;

		// Token: 0x040013F4 RID: 5108
		internal GridColumn Employee;

		// Token: 0x040013F5 RID: 5109
		internal GridColumn Office;

		// Token: 0x040013F6 RID: 5110
		private bool _contentLoaded;
	}
}
