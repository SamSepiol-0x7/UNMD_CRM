using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x02000760 RID: 1888
	public class PriceEditorService : GenericModel, IPriceEditorService
	{
		// Token: 0x06003B2D RID: 15149 RVA: 0x000E5608 File Offset: 0x000E3808
		public PriceEditorService(IProductService productService, ILoggerService<PriceEditorService> loggerService)
		{
			this._productService = productService;
			this._loggerService = loggerService;
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x000E5634 File Offset: 0x000E3834
		public Task LogChanges(IEnumerable<store_items> items)
		{
			PriceEditorService.<LogChanges>d__4 <LogChanges>d__;
			<LogChanges>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LogChanges>d__.<>4__this = this;
			<LogChanges>d__.items = items;
			<LogChanges>d__.<>1__state = -1;
			<LogChanges>d__.<>t__builder.Start<PriceEditorService.<LogChanges>d__4>(ref <LogChanges>d__);
			return <LogChanges>d__.<>t__builder.Task;
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x000E5680 File Offset: 0x000E3880
		public Task<List<store_items>> LoadItems4Edit(int storeId, int availabilityMode, int categoryId, int stateId, string query, bool searchInDescription)
		{
			PriceEditorService.<LoadItems4Edit>d__5 <LoadItems4Edit>d__;
			<LoadItems4Edit>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_items>>.Create();
			<LoadItems4Edit>d__.<>4__this = this;
			<LoadItems4Edit>d__.storeId = storeId;
			<LoadItems4Edit>d__.availabilityMode = availabilityMode;
			<LoadItems4Edit>d__.categoryId = categoryId;
			<LoadItems4Edit>d__.stateId = stateId;
			<LoadItems4Edit>d__.query = query;
			<LoadItems4Edit>d__.searchInDescription = searchInDescription;
			<LoadItems4Edit>d__.<>1__state = -1;
			<LoadItems4Edit>d__.<>t__builder.Start<PriceEditorService.<LoadItems4Edit>d__5>(ref <LoadItems4Edit>d__);
			return <LoadItems4Edit>d__.<>t__builder.Task;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x000E56F8 File Offset: 0x000E38F8
		public void RejectChanges(IEnumerable<store_items> items)
		{
			if (items == null)
			{
				return;
			}
			foreach (store_items entity in items)
			{
				if (this._context.Entry<store_items>(entity).State == EntityState.Modified)
				{
					this._context.Entry<store_items>(entity).State = EntityState.Unchanged;
				}
			}
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x000E5768 File Offset: 0x000E3968
		public IAscResult SetHighlight(int itemId, bool value)
		{
			Result result = new Result();
			IAscResult result2;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					store_items store_items = new store_items
					{
						id = itemId,
						ge_highlight = !value
					};
					auseceEntities.store_items.Attach(store_items);
					store_items.ge_highlight = value;
					auseceEntities.SaveChanges();
				}
				goto IL_6E;
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
				result2 = result;
			}
			return result2;
			IL_6E:
			result.SetSuccess();
			return result;
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x000E5808 File Offset: 0x000E3A08
		public IAscResult SetHighlight(IEnumerable<int> itemIds, bool value)
		{
			Result result = new Result();
			IAscResult result2;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					foreach (int id in itemIds)
					{
						store_items store_items = new store_items
						{
							id = id,
							ge_highlight = !value
						};
						auseceEntities.store_items.Attach(store_items);
						store_items.ge_highlight = value;
					}
					auseceEntities.SaveChanges();
				}
				goto IL_98;
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
				result2 = result;
			}
			return result2;
			IL_98:
			result.SetSuccess();
			return result;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x000E58DC File Offset: 0x000E3ADC
		public bool SaveContext()
		{
			return base.SaveContext(false);
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x000E58F0 File Offset: 0x000E3AF0
		public Task SaveHistory()
		{
			return this._history.SaveAsync();
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x000E5908 File Offset: 0x000E3B08
		public void ResetHistory()
		{
			this._history = new HistoryV2();
		}

		// Token: 0x04002616 RID: 9750
		private readonly IProductService _productService;

		// Token: 0x04002617 RID: 9751
		private readonly ILoggerService<PriceEditorService> _loggerService;

		// Token: 0x04002618 RID: 9752
		private readonly StoreModel _storeModel = new StoreModel();

		// Token: 0x02000761 RID: 1889
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B36 RID: 15158 RVA: 0x000E5920 File Offset: 0x000E3B20
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003B37 RID: 15159 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002619 RID: 9753
			public static readonly PriceEditorService.<>c <>9 = new PriceEditorService.<>c();
		}

		// Token: 0x02000762 RID: 1890
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LogChanges>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003B38 RID: 15160 RVA: 0x000E5938 File Offset: 0x000E3B38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorService priceEditorService = this.<>4__this;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<>7__wrap1 = this.items.GetEnumerator();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num == 0)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_5A1;
							}
							IL_4C0:
							while (this.<>7__wrap1.MoveNext())
							{
								this.<item>5__3 = this.<>7__wrap1.Current;
								if (priceEditorService._context.Entry<store_items>(this.<item>5__3).State == EntityState.Modified)
								{
									this.<original>5__4 = priceEditorService._context.Entry<store_items>(this.<item>5__3).OriginalValues;
									this.<current>5__5 = priceEditorService._context.Entry<store_items>(this.<item>5__3).CurrentValues;
									if (!((string)this.<original>5__4["name"] != (string)this.<current>5__5["name"]))
									{
										goto IL_53B;
									}
									this.<>7__wrap5 = this.<item>5__3;
									awaiter = priceEditorService._productService.GetOrCreateArticul(priceEditorService._context, this.<item>5__3).GetAwaiter();
									if (awaiter.IsCompleted)
									{
										goto IL_5A1;
									}
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PriceEditorService.<LogChanges>d__4>(ref awaiter, ref this);
									return;
								}
							}
							goto IL_636;
							IL_53B:
							if ((int)this.<original>5__4["category"] != (int)this.<current>5__5["category"])
							{
								priceEditorService._context.Entry<store_items>(this.<item>5__3).Reference<store_cats>((store_items i) => i.store_cats).Load();
								priceEditorService._history.AddItemLog("changeCategory", this.<item>5__3.id, this.<item>5__3.store_cats.name, "");
							}
							if ((int)this.<original>5__4["state"] != (int)this.<current>5__5["state"])
							{
								priceEditorService._context.Entry<store_items>(this.<item>5__3).Reference<items_state>((store_items i) => i.items_state).Load();
								priceEditorService._history.AddItemLog("changeState", this.<item>5__3.id, this.<item>5__3.items_state.name, "");
							}
							if ((int)this.<original>5__4["articul"] != (int)this.<current>5__5["articul"])
							{
								int num4 = Convert.ToInt32(this.<original>5__4["articul"]);
								priceEditorService._history.AddItemLog("changeArticul", this.<item>5__3.id, num4.ToString("D6"), this.<item>5__3.articul.ToString("D6"));
							}
							int? num5 = (int?)this.<original>5__4["box"];
							int? num6 = (int?)this.<current>5__5["box"];
							if (!(num5.GetValueOrDefault() == num6.GetValueOrDefault() & num5 != null == (num6 != null)))
							{
								priceEditorService._context.Entry<store_items>(this.<item>5__3).Reference<boxes>((store_items i) => i.boxes).Load();
								this.<item>5__3.box_name = this.<item>5__3.boxes.name;
								priceEditorService._history.AddItemLog("setBox", this.<item>5__3.id, this.<item>5__3.boxes.name, "");
							}
							if ((decimal)this.<original>5__4["price"] != this.<item>5__3.price)
							{
								decimal num7 = Convert.ToDecimal(this.<original>5__4["price"]);
								priceEditorService._history.AddItemLog("changePrice", this.<item>5__3.id, num7.ToString("N2"), this.<item>5__3.price.ToString("N2"));
							}
							if ((decimal)this.<original>5__4["price2"] != this.<item>5__3.price2)
							{
								decimal num8 = Convert.ToDecimal(this.<original>5__4["price2"]);
								priceEditorService._history.AddItemLog("changePrice2", this.<item>5__3.id, num8.ToString("N2"), this.<item>5__3.price2.ToString("N2"));
							}
							if ((decimal)this.<original>5__4["price3"] != this.<item>5__3.price3)
							{
								decimal num9 = Convert.ToDecimal(this.<original>5__4["price3"]);
								priceEditorService._history.AddItemLog("changePrice34", this.<item>5__3.id, num9.ToString("N2"), this.<item>5__3.price3.ToString("N2"));
							}
							this.<original>5__4 = null;
							this.<current>5__5 = null;
							this.<item>5__3 = null;
							goto IL_4C0;
							IL_5A1:
							int result = awaiter.GetResult();
							this.<>7__wrap5.articul = result;
							this.<>7__wrap5 = null;
							priceEditorService._history.AddItemLog("changeName", this.<item>5__3.id, (string)this.<original>5__4["name"], this.<item>5__3.name);
							goto IL_53B;
						}
						finally
						{
							if (num < 0 && this.<>7__wrap1 != null)
							{
								this.<>7__wrap1.Dispose();
							}
						}
						IL_636:
						this.<>7__wrap1 = null;
					}
					catch (Exception e)
					{
						priceEditorService._loggerService.Error(e, "Log items changes error");
						throw;
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

			// Token: 0x06003B39 RID: 15161 RVA: 0x000E6014 File Offset: 0x000E4214
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400261A RID: 9754
			public int <>1__state;

			// Token: 0x0400261B RID: 9755
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400261C RID: 9756
			public IEnumerable<store_items> items;

			// Token: 0x0400261D RID: 9757
			public PriceEditorService <>4__this;

			// Token: 0x0400261E RID: 9758
			private IEnumerator<store_items> <>7__wrap1;

			// Token: 0x0400261F RID: 9759
			private store_items <item>5__3;

			// Token: 0x04002620 RID: 9760
			private DbPropertyValues <original>5__4;

			// Token: 0x04002621 RID: 9761
			private DbPropertyValues <current>5__5;

			// Token: 0x04002622 RID: 9762
			private store_items <>7__wrap5;

			// Token: 0x04002623 RID: 9763
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000763 RID: 1891
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003B3A RID: 15162 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x04002624 RID: 9764
			public int storeId;

			// Token: 0x04002625 RID: 9765
			public int stateId;

			// Token: 0x04002626 RID: 9766
			public string query;
		}

		// Token: 0x02000764 RID: 1892
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_1
		{
			// Token: 0x06003B3B RID: 15163 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_1()
			{
			}

			// Token: 0x04002627 RID: 9767
			public List<int> cats;
		}

		// Token: 0x02000765 RID: 1893
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems4Edit>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003B3C RID: 15164 RVA: 0x000E6030 File Offset: 0x000E4230
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorService priceEditorService = this.<>4__this;
				List<store_items> result;
				try
				{
					PriceEditorService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PriceEditorService.<>c__DisplayClass5_0();
						CS$<>8__locals1.storeId = this.storeId;
						CS$<>8__locals1.stateId = this.stateId;
						CS$<>8__locals1.query = this.query;
					}
					try
					{
						TaskAwaiter<List<store_items>> awaiter;
						if (num != 0)
						{
							IQueryable<store_items> source = from i in priceEditorService._context.store_items.Include((store_items i) => i.field_values)
							where i.store == CS$<>8__locals1.storeId
							select i;
							if (this.categoryId != 0)
							{
								PriceEditorService.<>c__DisplayClass5_1 CS$<>8__locals2 = new PriceEditorService.<>c__DisplayClass5_1();
								CS$<>8__locals2.cats = priceEditorService._storeModel.LoadChildCategoriesId(this.categoryId);
								CS$<>8__locals2.cats.Add(this.categoryId);
								source = from i in source
								where CS$<>8__locals2.cats.Contains(i.category)
								select i;
							}
							if (this.availabilityMode != 0)
							{
								source = source.Where(StoreModel.InStockS1(this.availabilityMode));
							}
							if (CS$<>8__locals1.stateId != 0)
							{
								source = from i in source
								where i.state == CS$<>8__locals1.stateId
								select i;
							}
							if (!string.IsNullOrEmpty(CS$<>8__locals1.query))
							{
								source = (this.searchInDescription ? (from i in source
								where i.name.Contains(CS$<>8__locals1.query) || i.description.Contains(CS$<>8__locals1.query)
								select i) : source.Where((store_items i) => i.name.Contains(CS$<>8__locals1.query)));
							}
							awaiter = source.ToListAsync<store_items>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, PriceEditorService.<LoadItems4Edit>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<store_items>>);
							this.<>1__state = -1;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Load items for edit fail");
						result = new List<store_items>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003B3D RID: 15165 RVA: 0x000E64D4 File Offset: 0x000E46D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002628 RID: 9768
			public int <>1__state;

			// Token: 0x04002629 RID: 9769
			public AsyncTaskMethodBuilder<List<store_items>> <>t__builder;

			// Token: 0x0400262A RID: 9770
			public int storeId;

			// Token: 0x0400262B RID: 9771
			public int stateId;

			// Token: 0x0400262C RID: 9772
			public string query;

			// Token: 0x0400262D RID: 9773
			public PriceEditorService <>4__this;

			// Token: 0x0400262E RID: 9774
			public int categoryId;

			// Token: 0x0400262F RID: 9775
			public int availabilityMode;

			// Token: 0x04002630 RID: 9776
			public bool searchInDescription;

			// Token: 0x04002631 RID: 9777
			private TaskAwaiter<List<store_items>> <>u__1;
		}
	}
}
