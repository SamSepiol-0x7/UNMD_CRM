using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;

namespace ASC.Models
{
	// Token: 0x02000A6E RID: 2670
	public class Realizator : CollectionViewModel<RealizationItem>
	{
		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x00144F6C File Offset: 0x0014316C
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x00144F80 File Offset: 0x00143180
		public RealizatorStat Stat
		{
			[CompilerGenerated]
			get
			{
				return this.<Stat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Stat>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 733749593;
				IL_13:
				switch ((num ^ 1949234432) % 4)
				{
				case 0:
					IL_32:
					this.<Stat>k__BackingField = value;
					this.RaisePropertyChanged("Stat");
					num = 1241519402;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06004D52 RID: 19794 RVA: 0x00144FDC File Offset: 0x001431DC
		// (set) Token: 0x06004D53 RID: 19795 RVA: 0x00144FF0 File Offset: 0x001431F0
		public List<store_cats> StoreCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StoreCategories>k__BackingField, value))
				{
					return;
				}
				this.<StoreCategories>k__BackingField = value;
				this.RaisePropertyChanged("StoreCategories");
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06004D54 RID: 19796 RVA: 0x00145020 File Offset: 0x00143220
		// (set) Token: 0x06004D55 RID: 19797 RVA: 0x00145034 File Offset: 0x00143234
		public int SelectedCategory
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCategory>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedCategory>k__BackingField == value)
				{
					return;
				}
				this.<SelectedCategory>k__BackingField = value;
				this.RaisePropertyChanged("SelectedCategory");
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x00145060 File Offset: 0x00143260
		// (set) Token: 0x06004D57 RID: 19799 RVA: 0x00145074 File Offset: 0x00143274
		public int ItemsType
		{
			get
			{
				return this._itemsType;
			}
			set
			{
				if (this._itemsType == value)
				{
					return;
				}
				this._itemsType = value;
				this.RaisePropertyChanged("ItemsType");
				this.SetColVisibility();
				this.BgInit();
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x001450AC File Offset: 0x001432AC
		// (set) Token: 0x06004D59 RID: 19801 RVA: 0x001450C0 File Offset: 0x001432C0
		public bool Price2Visible
		{
			[CompilerGenerated]
			get
			{
				return this.<Price2Visible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Price2Visible>k__BackingField == value)
				{
					return;
				}
				this.<Price2Visible>k__BackingField = value;
				this.RaisePropertyChanged("Price2Visible");
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06004D5A RID: 19802 RVA: 0x001450EC File Offset: 0x001432EC
		// (set) Token: 0x06004D5B RID: 19803 RVA: 0x00145100 File Offset: 0x00143300
		public bool SoldSummVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<SoldSummVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SoldSummVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 802108726;
				IL_10:
				switch ((num ^ 1460923079) % 4)
				{
				case 0:
					IL_2F:
					this.<SoldSummVisible>k__BackingField = value;
					this.RaisePropertyChanged("SoldSummVisible");
					num = 1420736152;
					goto IL_10;
				case 1:
					return;
				case 2:
					goto IL_0B;
				}
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x00145158 File Offset: 0x00143358
		// (set) Token: 0x06004D5D RID: 19805 RVA: 0x0014516C File Offset: 0x0014336C
		public bool DateOfSaleVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<DateOfSaleVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DateOfSaleVisible>k__BackingField == value)
				{
					return;
				}
				this.<DateOfSaleVisible>k__BackingField = value;
				this.RaisePropertyChanged("DateOfSaleVisible");
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06004D5E RID: 19806 RVA: 0x00145198 File Offset: 0x00143398
		// (set) Token: 0x06004D5F RID: 19807 RVA: 0x001451AC File Offset: 0x001433AC
		public string SearchItems
		{
			[CompilerGenerated]
			get
			{
				return this.<SearchItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SearchItems>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SearchItems>k__BackingField = value;
				this.RaisePropertyChanged("SearchItems");
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x001451DC File Offset: 0x001433DC
		// (set) Token: 0x06004D61 RID: 19809 RVA: 0x001451F0 File Offset: 0x001433F0
		public ICommand PrintCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PrintCommand>k__BackingField, value))
				{
					return;
				}
				this.<PrintCommand>k__BackingField = value;
				this.RaisePropertyChanged("PrintCommand");
			}
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00145220 File Offset: 0x00143420
		public Realizator()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.Stat = new RealizatorStat();
			this._dealerModel = new DealerModel();
			this.SetColVisibility();
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00145268 File Offset: 0x00143468
		public Realizator(int dealerId) : this()
		{
			this._dealerId = dealerId;
			this.BgInit();
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00145288 File Offset: 0x00143488
		private void SetColVisibility()
		{
			this.Price2Visible = (this.ItemsType == 1);
			this.DateOfSaleVisible = (this.ItemsType != 1);
			this.SoldSummVisible = (this.ItemsType != 1);
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x001452C8 File Offset: 0x001434C8
		[Command]
		public void Search()
		{
			this.BgInit();
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x001452DC File Offset: 0x001434DC
		[Command]
		public void SearchKeyUp(KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				this.Search();
			}
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x000A5A34 File Offset: 0x000A3C34
		[Command]
		public void PrintTable(object obj)
		{
			TableView tableView = obj as TableView;
			if (tableView != null)
			{
				new PrintableControlLink(tableView)
				{
					PaperKind = PaperKind.A4,
					Landscape = true,
					Margins = new Margins(10, 10, 10, 10)
				}.ShowPrintPreview(Application.Current.MainWindow);
			}
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x001452F8 File Offset: 0x001434F8
		private void BgInit()
		{
			Realizator.<BgInit>d__45 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<Realizator.<BgInit>d__45>(ref <BgInit>d__);
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00145330 File Offset: 0x00143530
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(base.SelectedItem.Id, 0);
		}

		// Token: 0x040032CB RID: 13003
		private DealerModel _dealerModel;

		// Token: 0x040032CC RID: 13004
		private int _dealerId;

		// Token: 0x040032CD RID: 13005
		private int _itemsType = 1;

		// Token: 0x040032CE RID: 13006
		private INavigationService _navigationService;

		// Token: 0x040032CF RID: 13007
		[CompilerGenerated]
		private RealizatorStat <Stat>k__BackingField;

		// Token: 0x040032D0 RID: 13008
		[CompilerGenerated]
		private List<store_cats> <StoreCategories>k__BackingField;

		// Token: 0x040032D1 RID: 13009
		[CompilerGenerated]
		private int <SelectedCategory>k__BackingField;

		// Token: 0x040032D2 RID: 13010
		[CompilerGenerated]
		private bool <Price2Visible>k__BackingField;

		// Token: 0x040032D3 RID: 13011
		[CompilerGenerated]
		private bool <SoldSummVisible>k__BackingField;

		// Token: 0x040032D4 RID: 13012
		[CompilerGenerated]
		private bool <DateOfSaleVisible>k__BackingField;

		// Token: 0x040032D5 RID: 13013
		[CompilerGenerated]
		private string <SearchItems>k__BackingField;

		// Token: 0x040032D6 RID: 13014
		[CompilerGenerated]
		private ICommand <PrintCommand>k__BackingField;

		// Token: 0x02000A6F RID: 2671
		[CompilerGenerated]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x06004D6A RID: 19818 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x06004D6B RID: 19819 RVA: 0x00145360 File Offset: 0x00143560
			internal Task<RealizatorStat> <BgInit>b__0()
			{
				return this.<>4__this._dealerModel.GetDealerStat(this.<>4__this._dealerId);
			}

			// Token: 0x06004D6C RID: 19820 RVA: 0x00145388 File Offset: 0x00143588
			internal List<RealizationItem> <BgInit>b__1()
			{
				return this.storeModel.LoadDealerItemsV2(this.<>4__this._dealerId, this.<>4__this.SelectedCategory, this.<>4__this.ItemsType, this.<>4__this.SearchItems);
			}

			// Token: 0x040032D7 RID: 13015
			public Realizator <>4__this;

			// Token: 0x040032D8 RID: 13016
			public StoreModel storeModel;
		}

		// Token: 0x02000A70 RID: 2672
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__45 : IAsyncStateMachine
		{
			// Token: 0x06004D6D RID: 19821 RVA: 0x001453CC File Offset: 0x001435CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Realizator realizator = this.<>4__this;
				try
				{
					TaskAwaiter<RealizatorStat> awaiter;
					TaskAwaiter<List<store_cats>> awaiter2;
					TaskAwaiter<List<RealizationItem>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<RealizatorStat>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
						goto IL_131;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<List<RealizationItem>>);
						this.<>1__state = -1;
						goto IL_1AB;
					default:
						this.<>8__1 = new Realizator.<>c__DisplayClass45_0();
						this.<>8__1.<>4__this = this.<>4__this;
						realizator.ShowWait();
						awaiter = Task.Run<RealizatorStat>(new Func<Task<RealizatorStat>>(this.<>8__1.<BgInit>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RealizatorStat>, Realizator.<BgInit>d__45>(ref awaiter, ref this);
							return;
						}
						break;
					}
					RealizatorStat result = awaiter.GetResult();
					realizator.Stat = result;
					this.<>8__1.storeModel = new StoreModel();
					if (realizator.StoreCategories != null)
					{
						goto IL_147;
					}
					awaiter2 = this.<>8__1.storeModel.LoadStoreCategories(0, true, false).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, Realizator.<BgInit>d__45>(ref awaiter2, ref this);
						return;
					}
					IL_131:
					List<store_cats> result2 = awaiter2.GetResult();
					realizator.StoreCategories = new List<store_cats>(result2);
					IL_147:
					awaiter3 = Task.Run<List<RealizationItem>>(new Func<List<RealizationItem>>(this.<>8__1.<BgInit>b__1)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<RealizationItem>>, Realizator.<BgInit>d__45>(ref awaiter3, ref this);
						return;
					}
					IL_1AB:
					List<RealizationItem> result3 = awaiter3.GetResult();
					realizator.SetItems(result3);
					realizator.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004D6E RID: 19822 RVA: 0x001455F4 File Offset: 0x001437F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040032D9 RID: 13017
			public int <>1__state;

			// Token: 0x040032DA RID: 13018
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040032DB RID: 13019
			public Realizator <>4__this;

			// Token: 0x040032DC RID: 13020
			private Realizator.<>c__DisplayClass45_0 <>8__1;

			// Token: 0x040032DD RID: 13021
			private TaskAwaiter<RealizatorStat> <>u__1;

			// Token: 0x040032DE RID: 13022
			private TaskAwaiter<List<store_cats>> <>u__2;

			// Token: 0x040032DF RID: 13023
			private TaskAwaiter<List<RealizationItem>> <>u__3;
		}
	}
}
