using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.WindowsUI;

namespace ASC
{
	// Token: 0x02000099 RID: 153
	public class ClientsView : NavigationPage, IComponentConnector
	{
		// Token: 0x0600126A RID: 4714 RVA: 0x000228F8 File Offset: 0x00020AF8
		public ClientsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00022914 File Offset: 0x00020B14
		private void TableView1_OnAllowProperty(object sender, AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary" || e.Property.Name == "SearchString")
			{
				e.Allow = false;
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00022958 File Offset: 0x00020B58
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 292044579;
			IL_0D:
			switch ((num ^ 1772043086) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				this._contentLoaded = true;
				num = 1535887796;
				goto IL_0D;
			}
			Uri resourceLocator = new Uri("/ASC;component/clients/clientsview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000229B4 File Offset: 0x00020BB4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.ClientsWin = (ClientsView)target;
				return;
			case 2:
				this.searchControl = (GridSearchControl)target;
				return;
			case 3:
				this.TableView1 = (GridControl)target;
				this.TableView1.AddHandler(DXSerializer.AllowPropertyEvent, new AllowPropertyEventHandler(this.TableView1_OnAllowProperty));
				return;
			case 4:
				this.Id = (GridColumn)target;
				return;
			case 5:
				this.Customer = (GridColumn)target;
				return;
			case 6:
				this.Balance = (GridColumn)target;
				return;
			case 7:
				this.Repairs = (GridColumn)target;
				return;
			case 8:
				this.Purchases = (GridColumn)target;
				return;
			case 9:
				this.Type = (GridColumn)target;
				return;
			case 10:
				this.Phone = (GridColumn)target;
				return;
			case 11:
				this.Email = (GridColumn)target;
				return;
			case 12:
				this.clientsTableView = (TableView)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040008B7 RID: 2231
		internal ClientsView ClientsWin;

		// Token: 0x040008B8 RID: 2232
		internal GridSearchControl searchControl;

		// Token: 0x040008B9 RID: 2233
		internal GridControl TableView1;

		// Token: 0x040008BA RID: 2234
		internal GridColumn Id;

		// Token: 0x040008BB RID: 2235
		internal GridColumn Customer;

		// Token: 0x040008BC RID: 2236
		internal GridColumn Balance;

		// Token: 0x040008BD RID: 2237
		internal GridColumn Repairs;

		// Token: 0x040008BE RID: 2238
		internal GridColumn Purchases;

		// Token: 0x040008BF RID: 2239
		internal GridColumn Type;

		// Token: 0x040008C0 RID: 2240
		internal GridColumn Phone;

		// Token: 0x040008C1 RID: 2241
		internal GridColumn Email;

		// Token: 0x040008C2 RID: 2242
		internal TableView clientsTableView;

		// Token: 0x040008C3 RID: 2243
		private bool _contentLoaded;
	}
}
