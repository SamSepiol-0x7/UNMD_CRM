using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace ASC
{
	// Token: 0x020000B0 RID: 176
	public class InItems : UserControl, IComponentConnector
	{
		// Token: 0x060012FE RID: 4862 RVA: 0x0002967C File Offset: 0x0002787C
		public InItems()
		{
			this.InitializeComponent();
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00029698 File Offset: 0x00027898
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1661282416;
			IL_0D:
			Uri resourceLocator;
			switch ((num ^ 278066165) % 4)
			{
			case 0:
				IL_2C:
				this._contentLoaded = true;
				resourceLocator = new Uri("/ASC;component/itemsarrival/initems.xaml", UriKind.Relative);
				num = 333772898;
				goto IL_0D;
			case 1:
				return;
			case 2:
				goto IL_08;
			}
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000296F4 File Offset: 0x000278F4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.ArrivalWindow = (InItems)target;
				return;
			case 2:
				this.CheckBoxCreateRko = (CheckBox)target;
				return;
			case 3:
				this.StoreSelectComboBox = (ComboBoxEdit)target;
				return;
			case 4:
				this.CostType = (ComboBoxEdit)target;
				return;
			case 5:
				this.PrintStickersBtn = (SimpleButton)target;
				return;
			case 6:
				this.ExpandButton = (ToggleButton)target;
				return;
			case 7:
				this.ArrivalGrid = (GridControl)target;
				return;
			case 8:
				this.ID = (GridColumn)target;
				return;
			case 9:
				this.Articul = (GridColumn)target;
				return;
			case 10:
				this.Id = (GridColumn)target;
				return;
			case 11:
				this.Category = (GridColumn)target;
				return;
			case 12:
				this.Name = (GridColumn)target;
				return;
			case 13:
				this.State = (GridColumn)target;
				return;
			case 14:
				this.Count = (GridColumn)target;
				return;
			case 15:
				this.InPrice = (GridColumn)target;
				return;
			case 16:
				this.InSumm = (GridColumn)target;
				return;
			case 17:
				this.UID = (GridColumn)target;
				return;
			case 18:
				this.Partnumber = (GridColumn)target;
				return;
			case 19:
				this.Serialnumber = (GridColumn)target;
				return;
			case 20:
				this.NotForSale = (GridColumn)target;
				return;
			case 21:
				this.ShopEnable = (GridColumn)target;
				return;
			case 22:
				this.dataGrid = (DataGrid)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x0400090D RID: 2317
		internal InItems ArrivalWindow;

		// Token: 0x0400090E RID: 2318
		internal CheckBox CheckBoxCreateRko;

		// Token: 0x0400090F RID: 2319
		internal ComboBoxEdit StoreSelectComboBox;

		// Token: 0x04000910 RID: 2320
		internal ComboBoxEdit CostType;

		// Token: 0x04000911 RID: 2321
		internal SimpleButton PrintStickersBtn;

		// Token: 0x04000912 RID: 2322
		internal ToggleButton ExpandButton;

		// Token: 0x04000913 RID: 2323
		internal GridControl ArrivalGrid;

		// Token: 0x04000914 RID: 2324
		internal GridColumn ID;

		// Token: 0x04000915 RID: 2325
		internal GridColumn Articul;

		// Token: 0x04000916 RID: 2326
		internal GridColumn Id;

		// Token: 0x04000917 RID: 2327
		internal GridColumn Category;

		// Token: 0x04000918 RID: 2328
		internal new GridColumn Name;

		// Token: 0x04000919 RID: 2329
		internal GridColumn State;

		// Token: 0x0400091A RID: 2330
		internal GridColumn Count;

		// Token: 0x0400091B RID: 2331
		internal GridColumn InPrice;

		// Token: 0x0400091C RID: 2332
		internal GridColumn InSumm;

		// Token: 0x0400091D RID: 2333
		internal GridColumn UID;

		// Token: 0x0400091E RID: 2334
		internal GridColumn Partnumber;

		// Token: 0x0400091F RID: 2335
		internal GridColumn Serialnumber;

		// Token: 0x04000920 RID: 2336
		internal GridColumn NotForSale;

		// Token: 0x04000921 RID: 2337
		internal GridColumn ShopEnable;

		// Token: 0x04000922 RID: 2338
		internal DataGrid dataGrid;

		// Token: 0x04000923 RID: 2339
		private bool _contentLoaded;
	}
}
