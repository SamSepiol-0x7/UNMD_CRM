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
	// Token: 0x0200031D RID: 797
	public class CustomerSalesView : UserControl, IComponentConnector
	{
		// Token: 0x0600257F RID: 9599 RVA: 0x00072AD8 File Offset: 0x00070CD8
		public CustomerSalesView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x0004EE44 File Offset: 0x0004D044
		private void DealerSalesGrid_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00072AF4 File Offset: 0x00070CF4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/customercard/customersalesview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00072B24 File Offset: 0x00070D24
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.DealerSalesGrid = (GridControl)target;
				this.DealerSalesGrid.AddHandler(DXSerializer.AllowPropertyEvent, new AllowPropertyEventHandler(this.DealerSalesGrid_OnAllowProperty));
				return;
			case 2:
				this.Articul = (GridColumn)target;
				return;
			case 3:
				this.Date = (GridColumn)target;
				return;
			case 4:
				this.Name = (GridColumn)target;
				return;
			case 5:
				this.Count = (GridColumn)target;
				return;
			case 6:
				this.InPrice = (GridColumn)target;
				return;
			case 7:
				this.InSumm = (GridColumn)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040013E7 RID: 5095
		internal GridControl DealerSalesGrid;

		// Token: 0x040013E8 RID: 5096
		internal GridColumn Articul;

		// Token: 0x040013E9 RID: 5097
		internal GridColumn Date;

		// Token: 0x040013EA RID: 5098
		internal new GridColumn Name;

		// Token: 0x040013EB RID: 5099
		internal GridColumn Count;

		// Token: 0x040013EC RID: 5100
		internal GridColumn InPrice;

		// Token: 0x040013ED RID: 5101
		internal GridColumn InSumm;

		// Token: 0x040013EE RID: 5102
		private bool _contentLoaded;
	}
}
