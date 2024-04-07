using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using ASC.Converters;
using ASC.Models;
using ASC.Objects.Converters;
using ASC.Properties;
using ASC.ViewModels;
using DevExpress.Data.Async.Helpers;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Utils;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.Grid;
using DevExpress.XtraGrid;

namespace ASC.StoreSimple
{
	// Token: 0x020002DC RID: 732
	public sealed class StoreSimpleViewModel : StoreViewModel
	{
		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x0006C44C File Offset: 0x0006A64C
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x0006C460 File Offset: 0x0006A660
		public EntityInstantFeedbackDataSource EntityServerModeSource
		{
			[CompilerGenerated]
			get
			{
				return this.<EntityServerModeSource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<EntityServerModeSource>k__BackingField, value))
				{
					return;
				}
				this.<EntityServerModeSource>k__BackingField = value;
				this.RaisePropertyChanged("EntityServerModeSource");
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0006C490 File Offset: 0x0006A690
		public StoreSimpleViewModel()
		{
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0006C4A4 File Offset: 0x0006A6A4
		public StoreSimpleViewModel(StoreViewModel.ReturnAction action, int repairId, bool warrantyRepair) : base(action, repairId, warrantyRepair)
		{
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0006C4BC File Offset: 0x0006A6BC
		public StoreSimpleViewModel(bool returnSelected, int itemsOption) : base(returnSelected, itemsOption)
		{
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
		[Command]
		public void SelectedItemChanged(object prm)
		{
			GridControl gridControl = prm as GridControl;
			if (gridControl != null)
			{
				ReadonlyThreadSafeProxyForObjectFromAnotherThread readonlyThreadSafeProxyForObjectFromAnotherThread = gridControl.CurrentItem as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
				if (readonlyThreadSafeProxyForObjectFromAnotherThread != null)
				{
					store_items store_items = readonlyThreadSafeProxyForObjectFromAnotherThread.OriginalRow as store_items;
					if (store_items != null)
					{
						base.SelectedItem = store_items.ToStoreItem();
						return;
					}
					base.SelectedItem = null;
				}
			}
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x0006C520 File Offset: 0x0006A720
		[Command]
		public void SelectionChanged(object prm)
		{
			GridControl gridControl = prm as GridControl;
			if (gridControl != null)
			{
				int[] selectedRowHandles = gridControl.GetSelectedRowHandles();
				if (selectedRowHandles == null)
				{
					return;
				}
				base.SelectedItems.Clear();
				foreach (int rowHandle in selectedRowHandles)
				{
					ReadonlyThreadSafeProxyForObjectFromAnotherThread readonlyThreadSafeProxyForObjectFromAnotherThread = gridControl.GetRow(rowHandle) as ReadonlyThreadSafeProxyForObjectFromAnotherThread;
					if (readonlyThreadSafeProxyForObjectFromAnotherThread != null)
					{
						base.SelectedItems.Add(((store_items)readonlyThreadSafeProxyForObjectFromAnotherThread.OriginalRow).ToStoreItem());
					}
				}
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0006C594 File Offset: 0x0006A794
		public override void OnLoad()
		{
			base.OnLoad();
			if (this.EntityServerModeSource != null)
			{
				goto IL_32;
			}
			IL_0E:
			int num = 1416768696;
			IL_13:
			switch ((num ^ 2079163817) % 4)
			{
			case 1:
				this.EntityServerModeSource = new EntityInstantFeedbackDataSource
				{
					QueryableSource = this.BuildQueryableSource(),
					KeyExpression = "id"
				};
				return;
			case 2:
				IL_32:
				this.EntityServerModeSource.QueryableSource = this.BuildQueryableSource();
				num = 1432733289;
				goto IL_13;
			case 3:
				goto IL_0E;
			}
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0006C610 File Offset: 0x0006A810
		[Command]
		public void Unloaded()
		{
			Auth.User.PutCategoriesStateToUserConfig();
			for (;;)
			{
				IL_4C:
				Settings.Default.Save();
				for (;;)
				{
					auseceEntities context = this._context;
					if (context != null)
					{
						context.Dispose();
						uint num;
						switch ((num = (num * 2878836610U ^ 2514830771U ^ 1334007674U)) % 5U)
						{
						case 0U:
							goto IL_59;
						case 1U:
						case 4U:
							goto IL_4C;
						case 3U:
							continue;
						}
						goto Block_2;
					}
					goto IL_58;
				}
			}
			Block_2:
			return;
			IL_58:
			IL_59:
			this._context = null;
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0006C680 File Offset: 0x0006A880
		private IQueryable<store_items> BuildQueryableSource()
		{
			if (this._context == null)
			{
				this._context = new auseceEntities(true);
				this._context.Configuration.ProxyCreationEnabled = false;
			}
			IQueryable<store_items> queryable = (from i in this._context.store_items.AsNoTracking()
			where !i.Hidden
			select i).Include((store_items i) => i.items_state).Include((store_items i) => i.boxes).Include((store_items i) => i.field_values).Where(StoreModel.InStockS1(base.SelectedItemOption));
			if (base.StoreCategoriesViewModel.SelectedStore != 0)
			{
				queryable = from i in queryable
				where i.store == this.StoreCategoriesViewModel.SelectedStore
				select i;
			}
			int selectedCategory = base.GetSelectedCategory();
			if (selectedCategory != 0)
			{
				ObjectResult<int?> catChildrens = this._context.getCatChildrens(new int?(selectedCategory));
				List<int> ids = (from i in catChildrens
				where i != null
				select i.Value).ToList<int>();
				queryable = from i in queryable
				where ids.Contains(i.category)
				select i;
			}
			return queryable;
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x0006C958 File Offset: 0x0006AB58
		protected override void BgLoadItems(string filter)
		{
			if (this.EntityServerModeSource != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1984157265;
			IL_0D:
			switch ((num ^ -1840981254) % 4)
			{
			case 1:
				return;
			case 2:
				IL_2C:
				this.EntityServerModeSource.QueryableSource = this.BuildQueryableSource();
				this.EntityServerModeSource.Refresh();
				num = -165781418;
				goto IL_0D;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0006C9B8 File Offset: 0x0006ABB8
		protected override Task ProductGridAttributeCols()
		{
			StoreSimpleViewModel.<ProductGridAttributeCols>d__14 <ProductGridAttributeCols>d__;
			<ProductGridAttributeCols>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProductGridAttributeCols>d__.<>4__this = this;
			<ProductGridAttributeCols>d__.<>1__state = -1;
			<ProductGridAttributeCols>d__.<>t__builder.Start<StoreSimpleViewModel.<ProductGridAttributeCols>d__14>(ref <ProductGridAttributeCols>d__);
			return <ProductGridAttributeCols>d__.<>t__builder.Task;
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0006C9FC File Offset: 0x0006ABFC
		private GridColumn AttributeColumn(fields field, ProductAttributesConverter cnv)
		{
			return new GridColumn
			{
				HorizontalHeaderContentAlignment = HorizontalAlignment.Center,
				Header = field.name,
				Name = "usercol_" + field.id.ToString(),
				Width = 150.0,
				Binding = new Binding
				{
					Path = new PropertyPath("Data.field_values", new object[0]),
					ConverterParameter = field.id,
					Converter = cnv,
					Mode = BindingMode.OneWay
				},
				AllowGrouping = DefaultBoolean.True,
				AllowMoving = DefaultBoolean.True,
				AllowSorting = DefaultBoolean.True,
				SortMode = ColumnSortMode.DisplayText,
				AllowSearchPanel = DefaultBoolean.False,
				AllowIncrementalSearch = false
			};
		}

		// Token: 0x04001301 RID: 4865
		[CompilerGenerated]
		private EntityInstantFeedbackDataSource <EntityServerModeSource>k__BackingField;

		// Token: 0x04001302 RID: 4866
		private auseceEntities _context;

		// Token: 0x020002DD RID: 733
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x0600244A RID: 9290 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04001303 RID: 4867
			public List<int> ids;
		}

		// Token: 0x020002DE RID: 734
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600244B RID: 9291 RVA: 0x0006CAC4 File Offset: 0x0006ACC4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600244C RID: 9292 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600244D RID: 9293 RVA: 0x0006CADC File Offset: 0x0006ACDC
			internal bool <BuildQueryableSource>b__12_5(int? i)
			{
				return i != null;
			}

			// Token: 0x0600244E RID: 9294 RVA: 0x0006CAF0 File Offset: 0x0006ACF0
			internal int <BuildQueryableSource>b__12_6(int? i)
			{
				return i.Value;
			}

			// Token: 0x04001304 RID: 4868
			public static readonly StoreSimpleViewModel.<>c <>9 = new StoreSimpleViewModel.<>c();

			// Token: 0x04001305 RID: 4869
			public static Func<int?, bool> <>9__12_5;

			// Token: 0x04001306 RID: 4870
			public static Func<int?, int> <>9__12_6;
		}

		// Token: 0x020002DF RID: 735
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600244F RID: 9295 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06002450 RID: 9296 RVA: 0x0006CB04 File Offset: 0x0006AD04
			internal bool <ProductGridAttributeCols>b__0(GridColumn c)
			{
				return c.Header.ToString() == this.field.name;
			}

			// Token: 0x04001307 RID: 4871
			public fields field;
		}

		// Token: 0x020002E0 RID: 736
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ProductGridAttributeCols>d__14 : IAsyncStateMachine
		{
			// Token: 0x06002451 RID: 9297 RVA: 0x0006CB2C File Offset: 0x0006AD2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreSimpleViewModel storeSimpleViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						awaiter = storeSimpleViewModel._storeService.GetCategoryFieldsAsync(storeSimpleViewModel.GetSelectedCategory()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, StoreSimpleViewModel.<ProductGridAttributeCols>d__14>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<fields>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<fields> result = awaiter.GetResult();
					if (result != null && result.Count != 0)
					{
						ProductAttributesConverter cnv = new ProductAttributesConverter();
						storeSimpleViewModel._grid.Columns.BeginUpdate();
						List<fields>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								StoreSimpleViewModel.<>c__DisplayClass14_0 CS$<>8__locals1 = new StoreSimpleViewModel.<>c__DisplayClass14_0();
								CS$<>8__locals1.field = enumerator.Current;
								if (!storeSimpleViewModel._grid.Columns.Any(new Func<GridColumn, bool>(CS$<>8__locals1.<ProductGridAttributeCols>b__0)))
								{
									GridColumn item = storeSimpleViewModel.AttributeColumn(CS$<>8__locals1.field, cnv);
									try
									{
										storeSimpleViewModel._grid.Columns.Add(item);
									}
									catch (Exception)
									{
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						storeSimpleViewModel._grid.Columns.EndUpdate();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002452 RID: 9298 RVA: 0x0006CCEC File Offset: 0x0006AEEC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001308 RID: 4872
			public int <>1__state;

			// Token: 0x04001309 RID: 4873
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400130A RID: 4874
			public StoreSimpleViewModel <>4__this;

			// Token: 0x0400130B RID: 4875
			private TaskAwaiter<List<fields>> <>u__1;
		}
	}
}
