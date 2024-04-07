using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Options;

namespace ASC.ItemsExport
{
	// Token: 0x0200030A RID: 778
	public class ExportItemsModel : ExportOptions
	{
		// Token: 0x060024D2 RID: 9426 RVA: 0x00070054 File Offset: 0x0006E254
		public Task<List<store_items>> LoadItems(int storeId, int categoryId, int stateId, int itemOption, string query)
		{
			ExportItemsModel.<LoadItems>d__0 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_items>>.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.storeId = storeId;
			<LoadItems>d__.categoryId = categoryId;
			<LoadItems>d__.stateId = stateId;
			<LoadItems>d__.itemOption = itemOption;
			<LoadItems>d__.query = query;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<ExportItemsModel.<LoadItems>d__0>(ref <LoadItems>d__);
			return <LoadItems>d__.<>t__builder.Task;
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000700C4 File Offset: 0x0006E2C4
		public void ExportFlagChange(store_items item)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					store_items store_items = new store_items
					{
						id = item.id,
						shop_enable = !item.shop_enable
					};
					auseceEntities.store_items.Attach(store_items);
					store_items.shop_enable = item.shop_enable;
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Item export flag change error");
			}
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00070188 File Offset: 0x0006E388
		public static void ExportFlagChange(IEnumerable<store_items> items, bool value)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					foreach (store_items store_items in items)
					{
						store_items store_items2 = new store_items
						{
							id = store_items.id,
							shop_enable = new bool?(!value)
						};
						auseceEntities.store_items.Attach(store_items2);
						store_items2.shop_enable = new bool?(value);
					}
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Item export flag change error");
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x0007025C File Offset: 0x0006E45C
		public ExportItemsModel()
		{
		}

		// Token: 0x0200030B RID: 779
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060024D6 RID: 9430 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x0400138F RID: 5007
			public int storeId;

			// Token: 0x04001390 RID: 5008
			public int categoryId;

			// Token: 0x04001391 RID: 5009
			public int stateId;

			// Token: 0x04001392 RID: 5010
			public string query;
		}

		// Token: 0x0200030C RID: 780
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_1
		{
			// Token: 0x060024D7 RID: 9431 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_1()
			{
			}

			// Token: 0x04001393 RID: 5011
			public List<int> categories;
		}

		// Token: 0x0200030D RID: 781
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060024D8 RID: 9432 RVA: 0x00070270 File Offset: 0x0006E470
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060024D9 RID: 9433 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04001394 RID: 5012
			public static readonly ExportItemsModel.<>c <>9 = new ExportItemsModel.<>c();
		}

		// Token: 0x0200030E RID: 782
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__0 : IAsyncStateMachine
		{
			// Token: 0x060024DA RID: 9434 RVA: 0x00070288 File Offset: 0x0006E488
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportItemsModel exportItemsModel = this.<>4__this;
				List<store_items> result;
				try
				{
					ExportItemsModel.<>c__DisplayClass0_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ExportItemsModel.<>c__DisplayClass0_0();
						CS$<>8__locals1.storeId = this.storeId;
						CS$<>8__locals1.categoryId = this.categoryId;
						CS$<>8__locals1.stateId = this.stateId;
						CS$<>8__locals1.query = this.query;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(false);
						}
						try
						{
							TaskAwaiter<List<store_items>> awaiter;
							if (num != 0)
							{
								IQueryable<store_items> source = exportItemsModel._context.store_items.Include((store_items i) => i.store_cats).Include((store_items i) => i.field_values).Include((store_items i) => from f in i.field_values
								select f.fields).Include((store_items i) => i.items_state).Include((store_items i) => i.boxes).AsNoTracking<store_items>().Where(StoreModel.InStockS1(this.itemOption)).DefaultIfEmpty<store_items>();
								source = from i in source
								where i.store == CS$<>8__locals1.storeId
								select i;
								if (CS$<>8__locals1.categoryId != 0)
								{
									ExportItemsModel.<>c__DisplayClass0_1 CS$<>8__locals2 = new ExportItemsModel.<>c__DisplayClass0_1();
									CS$<>8__locals2.categories = (from c in this.<ctx>5__2.store_cats
									where c.parent == (int?)CS$<>8__locals1.categoryId
									select c.id).ToList<int>();
									CS$<>8__locals2.categories.Add(CS$<>8__locals1.categoryId);
									source = from i in source
									where CS$<>8__locals2.categories.Contains(i.category)
									select i;
								}
								if (CS$<>8__locals1.stateId != 0)
								{
									source = from i in source
									where i.state == CS$<>8__locals1.stateId
									select i;
								}
								if (!string.IsNullOrEmpty(CS$<>8__locals1.query))
								{
									source = from i in source
									where i.name.Contains(CS$<>8__locals1.query) || i.description.Contains(CS$<>8__locals1.query) || i.PN.Contains(CS$<>8__locals1.query) || i.SN.Contains(CS$<>8__locals1.query) || i.id.ToString() == CS$<>8__locals1.query || i.boxes.name.Contains(CS$<>8__locals1.query) || i.articul.ToString() == CS$<>8__locals1.query
									select i;
								}
								awaiter = source.ToListAsync<store_items>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, ExportItemsModel.<LoadItems>d__0>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<store_items>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Load export items fail");
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

			// Token: 0x060024DB RID: 9435 RVA: 0x00070AD0 File Offset: 0x0006ECD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001395 RID: 5013
			public int <>1__state;

			// Token: 0x04001396 RID: 5014
			public AsyncTaskMethodBuilder<List<store_items>> <>t__builder;

			// Token: 0x04001397 RID: 5015
			public int storeId;

			// Token: 0x04001398 RID: 5016
			public int categoryId;

			// Token: 0x04001399 RID: 5017
			public int stateId;

			// Token: 0x0400139A RID: 5018
			public string query;

			// Token: 0x0400139B RID: 5019
			public ExportItemsModel <>4__this;

			// Token: 0x0400139C RID: 5020
			public int itemOption;

			// Token: 0x0400139D RID: 5021
			private auseceEntities <ctx>5__2;

			// Token: 0x0400139E RID: 5022
			private TaskAwaiter<List<store_items>> <>u__1;
		}
	}
}
