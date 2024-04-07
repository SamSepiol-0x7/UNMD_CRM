using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Objects;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Objects.Reports;
using ASC.SimpleClasses;

namespace ASC.Services
{
	// Token: 0x0200069F RID: 1695
	public class StoreService : IStoreService
	{
		// Token: 0x060038EB RID: 14571 RVA: 0x000D0C98 File Offset: 0x000CEE98
		public Dictionary<int, string> GetPriceColumns()
		{
			return new Dictionary<int, string>
			{
				{
					2,
					Lang.t("Retail")
				},
				{
					3,
					Lang.t("Opt")
				},
				{
					4,
					Lang.t("PriceOpt2")
				},
				{
					5,
					Lang.t("PriceOpt3")
				}
			};
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x000D0CF0 File Offset: 0x000CEEF0
		public Task<stores> GetStoreAsync(int storeId)
		{
			StoreService.<GetStoreAsync>d__1 <GetStoreAsync>d__;
			<GetStoreAsync>d__.<>t__builder = AsyncTaskMethodBuilder<stores>.Create();
			<GetStoreAsync>d__.storeId = storeId;
			<GetStoreAsync>d__.<>1__state = -1;
			<GetStoreAsync>d__.<>t__builder.Start<StoreService.<GetStoreAsync>d__1>(ref <GetStoreAsync>d__);
			return <GetStoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x000D0D34 File Offset: 0x000CEF34
		public Task<List<stores>> GetStores()
		{
			StoreService.<GetStores>d__2 <GetStores>d__;
			<GetStores>d__.<>t__builder = AsyncTaskMethodBuilder<List<stores>>.Create();
			<GetStores>d__.<>1__state = -1;
			<GetStores>d__.<>t__builder.Start<StoreService.<GetStores>d__2>(ref <GetStores>d__);
			return <GetStores>d__.<>t__builder.Task;
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x000D0D70 File Offset: 0x000CEF70
		public Task<List<store_cats>> GetCategoriesAsync(int storeId)
		{
			StoreService.<GetCategoriesAsync>d__3 <GetCategoriesAsync>d__;
			<GetCategoriesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_cats>>.Create();
			<GetCategoriesAsync>d__.storeId = storeId;
			<GetCategoriesAsync>d__.<>1__state = -1;
			<GetCategoriesAsync>d__.<>t__builder.Start<StoreService.<GetCategoriesAsync>d__3>(ref <GetCategoriesAsync>d__);
			return <GetCategoriesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x000D0DB4 File Offset: 0x000CEFB4
		public Task<List<store_cats>> GetCategoriesAsync()
		{
			StoreService.<GetCategoriesAsync>d__4 <GetCategoriesAsync>d__;
			<GetCategoriesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<store_cats>>.Create();
			<GetCategoriesAsync>d__.<>1__state = -1;
			<GetCategoriesAsync>d__.<>t__builder.Start<StoreService.<GetCategoriesAsync>d__4>(ref <GetCategoriesAsync>d__);
			return <GetCategoriesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x000D0DF0 File Offset: 0x000CEFF0
		public Task<store_items> GetProduct(int productId)
		{
			Task<store_items> result;
			using (auseceEntities auseceEntities = new auseceEntities(false))
			{
				result = (from i in auseceEntities.store_items.AsNoTracking().Include((store_items i) => i.stores).Include((store_items i) => i.store_cats).Include((store_items i) => i.boxes).Include((store_items i) => i.items_state)
				where i.id == productId
				select i).FirstOrDefaultAsync<store_items>();
			}
			return result;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x000D0FA8 File Offset: 0x000CF1A8
		public Task<IEnumerable<Product>> GetProductsAsync(int categoryId, string searchString)
		{
			StoreService.<GetProductsAsync>d__6 <GetProductsAsync>d__;
			<GetProductsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<Product>>.Create();
			<GetProductsAsync>d__.categoryId = categoryId;
			<GetProductsAsync>d__.searchString = searchString;
			<GetProductsAsync>d__.<>1__state = -1;
			<GetProductsAsync>d__.<>t__builder.Start<StoreService.<GetProductsAsync>d__6>(ref <GetProductsAsync>d__);
			return <GetProductsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x000D0FF4 File Offset: 0x000CF1F4
		public Task<List<items_state>> GetProductStatesAsync()
		{
			StoreService.<GetProductStatesAsync>d__7 <GetProductStatesAsync>d__;
			<GetProductStatesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<items_state>>.Create();
			<GetProductStatesAsync>d__.<>1__state = -1;
			<GetProductStatesAsync>d__.<>t__builder.Start<StoreService.<GetProductStatesAsync>d__7>(ref <GetProductStatesAsync>d__);
			return <GetProductStatesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x000D1030 File Offset: 0x000CF230
		public Task<List<Product>> GetProductsOfDocumentAsync(int documentId)
		{
			StoreService.<GetProductsOfDocumentAsync>d__8 <GetProductsOfDocumentAsync>d__;
			<GetProductsOfDocumentAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<Product>>.Create();
			<GetProductsOfDocumentAsync>d__.documentId = documentId;
			<GetProductsOfDocumentAsync>d__.<>1__state = -1;
			<GetProductsOfDocumentAsync>d__.<>t__builder.Start<StoreService.<GetProductsOfDocumentAsync>d__8>(ref <GetProductsOfDocumentAsync>d__);
			return <GetProductsOfDocumentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x000D1074 File Offset: 0x000CF274
		public Task<GoodsMoveDocument> GetProductsMoveDocument(int documentId)
		{
			StoreService.<GetProductsMoveDocument>d__9 <GetProductsMoveDocument>d__;
			<GetProductsMoveDocument>d__.<>t__builder = AsyncTaskMethodBuilder<GoodsMoveDocument>.Create();
			<GetProductsMoveDocument>d__.documentId = documentId;
			<GetProductsMoveDocument>d__.<>1__state = -1;
			<GetProductsMoveDocument>d__.<>t__builder.Start<StoreService.<GetProductsMoveDocument>d__9>(ref <GetProductsMoveDocument>d__);
			return <GetProductsMoveDocument>d__.<>t__builder.Task;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x000D10B8 File Offset: 0x000CF2B8
		public Task<List<boxes>> GetBoxesAsync(int storeId)
		{
			StoreService.<GetBoxesAsync>d__10 <GetBoxesAsync>d__;
			<GetBoxesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<boxes>>.Create();
			<GetBoxesAsync>d__.storeId = storeId;
			<GetBoxesAsync>d__.<>1__state = -1;
			<GetBoxesAsync>d__.<>t__builder.Start<StoreService.<GetBoxesAsync>d__10>(ref <GetBoxesAsync>d__);
			return <GetBoxesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x000D10FC File Offset: 0x000CF2FC
		public Task<int> ItemsMoveDispatch(IGoodsMoveDocument document)
		{
			StoreService.<ItemsMoveDispatch>d__11 <ItemsMoveDispatch>d__;
			<ItemsMoveDispatch>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<ItemsMoveDispatch>d__.document = document;
			<ItemsMoveDispatch>d__.<>1__state = -1;
			<ItemsMoveDispatch>d__.<>t__builder.Start<StoreService.<ItemsMoveDispatch>d__11>(ref <ItemsMoveDispatch>d__);
			return <ItemsMoveDispatch>d__.<>t__builder.Task;
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x000D1140 File Offset: 0x000CF340
		public Task<bool> ItemsMoveArrived(int documentId)
		{
			StoreService.<ItemsMoveArrived>d__12 <ItemsMoveArrived>d__;
			<ItemsMoveArrived>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<ItemsMoveArrived>d__.documentId = documentId;
			<ItemsMoveArrived>d__.<>1__state = -1;
			<ItemsMoveArrived>d__.<>t__builder.Start<StoreService.<ItemsMoveArrived>d__12>(ref <ItemsMoveArrived>d__);
			return <ItemsMoveArrived>d__.<>t__builder.Task;
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x000D1184 File Offset: 0x000CF384
		public Task SetDocumentCashOrder(int documentId, int cashOrderId)
		{
			StoreService.<SetDocumentCashOrder>d__13 <SetDocumentCashOrder>d__;
			<SetDocumentCashOrder>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetDocumentCashOrder>d__.documentId = documentId;
			<SetDocumentCashOrder>d__.cashOrderId = cashOrderId;
			<SetDocumentCashOrder>d__.<>1__state = -1;
			<SetDocumentCashOrder>d__.<>t__builder.Start<StoreService.<SetDocumentCashOrder>d__13>(ref <SetDocumentCashOrder>d__);
			return <SetDocumentCashOrder>d__.<>t__builder.Task;
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x000D11D0 File Offset: 0x000CF3D0
		public Task<List<fields>> GetCategoryFieldsAsync(int categoryId)
		{
			StoreService.<GetCategoryFieldsAsync>d__14 <GetCategoryFieldsAsync>d__;
			<GetCategoryFieldsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<fields>>.Create();
			<GetCategoryFieldsAsync>d__.categoryId = categoryId;
			<GetCategoryFieldsAsync>d__.<>1__state = -1;
			<GetCategoryFieldsAsync>d__.<>t__builder.Start<StoreService.<GetCategoryFieldsAsync>d__14>(ref <GetCategoryFieldsAsync>d__);
			return <GetCategoryFieldsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x000D1214 File Offset: 0x000CF414
		public Task DeleteProductAsync(int productId)
		{
			StoreService.<DeleteProductAsync>d__15 <DeleteProductAsync>d__;
			<DeleteProductAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<DeleteProductAsync>d__.productId = productId;
			<DeleteProductAsync>d__.<>1__state = -1;
			<DeleteProductAsync>d__.<>t__builder.Start<StoreService.<DeleteProductAsync>d__15>(ref <DeleteProductAsync>d__);
			return <DeleteProductAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x000D1258 File Offset: 0x000CF458
		public Task<IList<int>> SearchSKU(string searchString)
		{
			StoreService.<SearchSKU>d__16 <SearchSKU>d__;
			<SearchSKU>d__.<>t__builder = AsyncTaskMethodBuilder<IList<int>>.Create();
			<SearchSKU>d__.searchString = searchString;
			<SearchSKU>d__.<>1__state = -1;
			<SearchSKU>d__.<>t__builder.Start<StoreService.<SearchSKU>d__16>(ref <SearchSKU>d__);
			return <SearchSKU>d__.<>t__builder.Task;
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x000D129C File Offset: 0x000CF49C
		public Task<IList<ArticulSearchLite>> GetProductsBySKU(IList<int> articuls)
		{
			StoreService.<GetProductsBySKU>d__17 <GetProductsBySKU>d__;
			<GetProductsBySKU>d__.<>t__builder = AsyncTaskMethodBuilder<IList<ArticulSearchLite>>.Create();
			<GetProductsBySKU>d__.articuls = articuls;
			<GetProductsBySKU>d__.<>1__state = -1;
			<GetProductsBySKU>d__.<>t__builder.Start<StoreService.<GetProductsBySKU>d__17>(ref <GetProductsBySKU>d__);
			return <GetProductsBySKU>d__.<>t__builder.Task;
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x000D12E0 File Offset: 0x000CF4E0
		public List<ItemUnits> GetUnits()
		{
			return new List<ItemUnits>
			{
				new ItemUnits(UnitCountType.pcs, Lang.t("Pcs"), Lang.t("Pcs") + "."),
				new ItemUnits(UnitCountType.gram, Lang.t("Gram2"), Lang.t("Gram") + "."),
				new ItemUnits(UnitCountType.Metre, Lang.t("Metre"), Lang.t("MetreShort") + "."),
				new ItemUnits(UnitCountType.Centimetre, Lang.t("Centimetre"), Lang.t("CentimetreShort") + "."),
				new ItemUnits(UnitCountType.Litre, Lang.t("Litre"), Lang.t("LitreShort") + ".")
			};
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x000046B4 File Offset: 0x000028B4
		public StoreService()
		{
		}

		// Token: 0x020006A0 RID: 1696
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetStoreAsync>d__1 : IAsyncStateMachine
		{
			// Token: 0x060038FF RID: 14591 RVA: 0x000D13C4 File Offset: 0x000CF5C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				stores result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<stores> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.stores.FindAsync(new object[]
							{
								this.storeId
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<stores>, StoreService.<GetStoreAsync>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<stores>);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003900 RID: 14592 RVA: 0x000D14C4 File Offset: 0x000CF6C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022E3 RID: 8931
			public int <>1__state;

			// Token: 0x040022E4 RID: 8932
			public AsyncTaskMethodBuilder<stores> <>t__builder;

			// Token: 0x040022E5 RID: 8933
			public int storeId;

			// Token: 0x040022E6 RID: 8934
			private auseceEntities <ctx>5__2;

			// Token: 0x040022E7 RID: 8935
			private TaskAwaiter<stores> <>u__1;
		}

		// Token: 0x020006A1 RID: 1697
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003901 RID: 14593 RVA: 0x000D14E0 File Offset: 0x000CF6E0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003902 RID: 14594 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003903 RID: 14595 RVA: 0x0006CADC File Offset: 0x0006ACDC
			internal bool <GetProductsAsync>b__6_3(int? i)
			{
				return i != null;
			}

			// Token: 0x06003904 RID: 14596 RVA: 0x0006CAF0 File Offset: 0x0006ACF0
			internal int <GetProductsAsync>b__6_4(int? i)
			{
				return i.Value;
			}

			// Token: 0x06003905 RID: 14597 RVA: 0x0009C454 File Offset: 0x0009A654
			internal Product <GetProductsAsync>b__6_2(store_items r)
			{
				return r.ToStoreItem();
			}

			// Token: 0x06003906 RID: 14598 RVA: 0x0009C454 File Offset: 0x0009A654
			internal Product <GetProductsOfDocumentAsync>b__8_0(store_items i)
			{
				return i.ToStoreItem();
			}

			// Token: 0x06003907 RID: 14599 RVA: 0x000D14F8 File Offset: 0x000CF6F8
			internal string <GetBoxesAsync>b__10_0(boxes x)
			{
				return x.name;
			}

			// Token: 0x06003908 RID: 14600 RVA: 0x000D150C File Offset: 0x000CF70C
			internal decimal <ItemsMoveDispatch>b__11_0(store_items i)
			{
				return i.BuyCost * i.BuyCount;
			}

			// Token: 0x06003909 RID: 14601 RVA: 0x000D1530 File Offset: 0x000CF730
			internal ArticulSearchLite <GetProductsBySKU>b__17_0(store_items r)
			{
				return r.ToArticulSearchLite();
			}

			// Token: 0x040022E8 RID: 8936
			public static readonly StoreService.<>c <>9 = new StoreService.<>c();

			// Token: 0x040022E9 RID: 8937
			public static Func<int?, bool> <>9__6_3;

			// Token: 0x040022EA RID: 8938
			public static Func<int?, int> <>9__6_4;

			// Token: 0x040022EB RID: 8939
			public static Func<store_items, Product> <>9__6_2;

			// Token: 0x040022EC RID: 8940
			public static Func<store_items, Product> <>9__8_0;

			// Token: 0x040022ED RID: 8941
			public static Func<boxes, string> <>9__10_0;

			// Token: 0x040022EE RID: 8942
			public static Func<store_items, decimal> <>9__11_0;

			// Token: 0x040022EF RID: 8943
			public static Func<store_items, ArticulSearchLite> <>9__17_0;
		}

		// Token: 0x020006A2 RID: 1698
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetStores>d__2 : IAsyncStateMachine
		{
			// Token: 0x0600390A RID: 14602 RVA: 0x000D1544 File Offset: 0x000CF744
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<stores> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<stores>> awaiter;
						if (num != 0)
						{
							awaiter = (from s in this.<ctx>5__2.stores
							where s.active
							select s).ToListAsync<stores>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, StoreService.<GetStores>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<stores>>);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600390B RID: 14603 RVA: 0x000D1670 File Offset: 0x000CF870
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022F0 RID: 8944
			public int <>1__state;

			// Token: 0x040022F1 RID: 8945
			public AsyncTaskMethodBuilder<List<stores>> <>t__builder;

			// Token: 0x040022F2 RID: 8946
			private auseceEntities <ctx>5__2;

			// Token: 0x040022F3 RID: 8947
			private TaskAwaiter<List<stores>> <>u__1;
		}

		// Token: 0x020006A3 RID: 1699
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600390C RID: 14604 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040022F4 RID: 8948
			public int storeId;
		}

		// Token: 0x020006A4 RID: 1700
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCategoriesAsync>d__3 : IAsyncStateMachine
		{
			// Token: 0x0600390D RID: 14605 RVA: 0x000D168C File Offset: 0x000CF88C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<store_cats> result;
				try
				{
					StoreService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreService.<>c__DisplayClass3_0();
						CS$<>8__locals1.storeId = this.storeId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<store_cats>> awaiter;
						if (num != 0)
						{
							awaiter = (from c in this.<ctx>5__2.store_cats.Include((store_cats c) => c.store_cats1)
							where c.enable != (bool?)false && c.store_id == (int?)CS$<>8__locals1.storeId
							orderby c.position
							select c).ToListAsync<store_cats>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, StoreService.<GetCategoriesAsync>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600390E RID: 14606 RVA: 0x000D18E0 File Offset: 0x000CFAE0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022F5 RID: 8949
			public int <>1__state;

			// Token: 0x040022F6 RID: 8950
			public AsyncTaskMethodBuilder<List<store_cats>> <>t__builder;

			// Token: 0x040022F7 RID: 8951
			public int storeId;

			// Token: 0x040022F8 RID: 8952
			private auseceEntities <ctx>5__2;

			// Token: 0x040022F9 RID: 8953
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x020006A5 RID: 1701
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCategoriesAsync>d__4 : IAsyncStateMachine
		{
			// Token: 0x0600390F RID: 14607 RVA: 0x000D18FC File Offset: 0x000CFAFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<store_cats> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<store_cats>> awaiter;
						if (num != 0)
						{
							awaiter = (from c in this.<ctx>5__2.store_cats.Include((store_cats c) => c.store_cats1).Include((store_cats c) => c.stores)
							where c.enable != (bool?)false
							select c).ToListAsync<store_cats>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, StoreService.<GetCategoriesAsync>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003910 RID: 14608 RVA: 0x000D1AE8 File Offset: 0x000CFCE8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022FA RID: 8954
			public int <>1__state;

			// Token: 0x040022FB RID: 8955
			public AsyncTaskMethodBuilder<List<store_cats>> <>t__builder;

			// Token: 0x040022FC RID: 8956
			private auseceEntities <ctx>5__2;

			// Token: 0x040022FD RID: 8957
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x020006A6 RID: 1702
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003911 RID: 14609 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040022FE RID: 8958
			public int productId;
		}

		// Token: 0x020006A7 RID: 1703
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003912 RID: 14610 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x040022FF RID: 8959
			public List<int> ids;
		}

		// Token: 0x020006A8 RID: 1704
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductsAsync>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003913 RID: 14611 RVA: 0x000D1B04 File Offset: 0x000CFD04
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<Product> result;
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
							IQueryable<store_items> source = (from i in this.<ctx>5__2.store_items.AsNoTracking()
							where !i.Hidden
							select i).Include((store_items i) => i.items_state).Where(StoreModel.ContainsQuery(this.searchString));
							if (this.categoryId > 0)
							{
								StoreService.<>c__DisplayClass6_0 CS$<>8__locals1 = new StoreService.<>c__DisplayClass6_0();
								ObjectResult<int?> catChildrens = this.<ctx>5__2.getCatChildrens(new int?(this.categoryId));
								CS$<>8__locals1.ids = catChildrens.Where(new Func<int?, bool>(StoreService.<>c.<>9.<GetProductsAsync>b__6_3)).Select(new Func<int?, int>(StoreService.<>c.<>9.<GetProductsAsync>b__6_4)).DefaultIfEmpty<int>().ToList<int>();
								source = from i in source
								where CS$<>8__locals1.ids.Contains(i.category)
								select i;
							}
							awaiter = source.ToListAsync<store_items>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, StoreService.<GetProductsAsync>d__6>(ref awaiter, ref this);
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
						result = awaiter.GetResult().AsParallel<store_items>().Select(new Func<store_items, Product>(StoreService.<>c.<>9.<GetProductsAsync>b__6_2)).ToList<Product>();
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003914 RID: 14612 RVA: 0x000D1DE0 File Offset: 0x000CFFE0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002300 RID: 8960
			public int <>1__state;

			// Token: 0x04002301 RID: 8961
			public AsyncTaskMethodBuilder<IEnumerable<Product>> <>t__builder;

			// Token: 0x04002302 RID: 8962
			public string searchString;

			// Token: 0x04002303 RID: 8963
			public int categoryId;

			// Token: 0x04002304 RID: 8964
			private auseceEntities <ctx>5__2;

			// Token: 0x04002305 RID: 8965
			private TaskAwaiter<List<store_items>> <>u__1;
		}

		// Token: 0x020006A9 RID: 1705
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductStatesAsync>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003915 RID: 14613 RVA: 0x000D1DFC File Offset: 0x000CFFFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<items_state> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<items_state>> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.items_state.AsNoTracking().ToListAsync<items_state>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, StoreService.<GetProductStatesAsync>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<items_state>>);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003916 RID: 14614 RVA: 0x000D1EEC File Offset: 0x000D00EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002306 RID: 8966
			public int <>1__state;

			// Token: 0x04002307 RID: 8967
			public AsyncTaskMethodBuilder<List<items_state>> <>t__builder;

			// Token: 0x04002308 RID: 8968
			private auseceEntities <ctx>5__2;

			// Token: 0x04002309 RID: 8969
			private TaskAwaiter<List<items_state>> <>u__1;
		}

		// Token: 0x020006AA RID: 1706
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06003917 RID: 14615 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x0400230A RID: 8970
			public int documentId;
		}

		// Token: 0x020006AB RID: 1707
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductsOfDocumentAsync>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003918 RID: 14616 RVA: 0x000D1F08 File Offset: 0x000D0108
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<Product> result;
				try
				{
					StoreService.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreService.<>c__DisplayClass8_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						TaskAwaiter<List<store_items>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.store_items.AsNoTracking()
							where i.document == (int?)CS$<>8__locals1.documentId
							select i).ToListAsync<store_items>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, StoreService.<GetProductsOfDocumentAsync>d__8>(ref awaiter, ref this);
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
						result = awaiter.GetResult().Select(new Func<store_items, Product>(StoreService.<>c.<>9.<GetProductsOfDocumentAsync>b__8_0)).ToList<Product>();
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003919 RID: 14617 RVA: 0x000D20C8 File Offset: 0x000D02C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400230B RID: 8971
			public int <>1__state;

			// Token: 0x0400230C RID: 8972
			public AsyncTaskMethodBuilder<List<Product>> <>t__builder;

			// Token: 0x0400230D RID: 8973
			public int documentId;

			// Token: 0x0400230E RID: 8974
			private auseceEntities <ctx>5__2;

			// Token: 0x0400230F RID: 8975
			private TaskAwaiter<List<store_items>> <>u__1;
		}

		// Token: 0x020006AC RID: 1708
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600391A RID: 14618 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04002310 RID: 8976
			public int documentId;
		}

		// Token: 0x020006AD RID: 1709
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductsMoveDocument>d__9 : IAsyncStateMachine
		{
			// Token: 0x0600391B RID: 14619 RVA: 0x000D20E4 File Offset: 0x000D02E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GoodsMoveDocument result;
				try
				{
					StoreService.<>c__DisplayClass9_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreService.<>c__DisplayClass9_0();
						CS$<>8__locals1.documentId = this.documentId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<docs> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.docs.Include((docs i) => i.clients).Include((docs i) => i.users).Include((docs i) => i.stores).Include((docs i) => i.stores1).Include((docs i) => i.companies).Include((docs i) => i.offices).Include((docs i) => from it in i.store_sales
							select it.store_items).FirstOrDefaultAsync((docs i) => i.id == CS$<>8__locals1.documentId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, StoreService.<GetProductsMoveDocument>d__9>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<docs>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToProductsMoveDocument();
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600391C RID: 14620 RVA: 0x000D2488 File Offset: 0x000D0688
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002311 RID: 8977
			public int <>1__state;

			// Token: 0x04002312 RID: 8978
			public AsyncTaskMethodBuilder<GoodsMoveDocument> <>t__builder;

			// Token: 0x04002313 RID: 8979
			public int documentId;

			// Token: 0x04002314 RID: 8980
			private auseceEntities <ctx>5__2;

			// Token: 0x04002315 RID: 8981
			private TaskAwaiter<docs> <>u__1;
		}

		// Token: 0x020006AE RID: 1710
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600391D RID: 14621 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04002316 RID: 8982
			public int storeId;
		}

		// Token: 0x020006AF RID: 1711
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetBoxesAsync>d__10 : IAsyncStateMachine
		{
			// Token: 0x0600391E RID: 14622 RVA: 0x000D24A4 File Offset: 0x000D06A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<boxes> result;
				try
				{
					StoreService.<>c__DisplayClass10_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreService.<>c__DisplayClass10_0();
						CS$<>8__locals1.storeId = this.storeId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<boxes>> awaiter;
						if (num != 0)
						{
							awaiter = (from b in this.<ctx>5__2.boxes.AsNoTracking()
							where b.store_id == (int?)CS$<>8__locals1.storeId && b.non_items == false
							select b).ToListAsync<boxes>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, StoreService.<GetBoxesAsync>d__10>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<boxes>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().OrderBy(new Func<boxes, string>(StoreService.<>c.<>9.<GetBoxesAsync>b__10_0), new NaturalComparer()).ToList<boxes>();
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600391F RID: 14623 RVA: 0x000D26A0 File Offset: 0x000D08A0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002317 RID: 8983
			public int <>1__state;

			// Token: 0x04002318 RID: 8984
			public AsyncTaskMethodBuilder<List<boxes>> <>t__builder;

			// Token: 0x04002319 RID: 8985
			public int storeId;

			// Token: 0x0400231A RID: 8986
			private auseceEntities <ctx>5__2;

			// Token: 0x0400231B RID: 8987
			private TaskAwaiter<List<boxes>> <>u__1;
		}

		// Token: 0x020006B0 RID: 1712
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003920 RID: 14624 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0400231C RID: 8988
			public store_items item;
		}

		// Token: 0x020006B1 RID: 1713
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ItemsMoveDispatch>d__11 : IAsyncStateMachine
		{
			// Token: 0x06003921 RID: 14625 RVA: 0x000D26BC File Offset: 0x000D08BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int result2;
				try
				{
					if (num > 2)
					{
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						if (num > 2)
						{
							this.<transaction>5__4 = this.<ctx>5__3.Database.BeginTransaction();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
								IL_101:
								try
								{
									TaskAwaiter<store_items> awaiter2;
									if (num == 1)
									{
										awaiter2 = this.<>u__2;
										this.<>u__2 = default(TaskAwaiter<store_items>);
										int num3 = -1;
										num = -1;
										this.<>1__state = num3;
										goto IL_2C6;
									}
									IL_131:
									if (!this.<>7__wrap6.MoveNext())
									{
										goto IL_44E;
									}
									this.<>8__1 = new StoreService.<>c__DisplayClass11_0();
									this.<>8__1.item = this.<>7__wrap6.Current;
									awaiter2 = this.<ctx>5__3.store_items.Include((store_items i) => i.boxes).FirstOrDefaultAsync((store_items i) => i.id == this.<>8__1.item.id).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										int num4 = 1;
										num = 1;
										this.<>1__state = num4;
										this.<>u__2 = awaiter2;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, StoreService.<ItemsMoveDispatch>d__11>(ref awaiter2, ref this);
										return;
									}
									IL_2C6:
									store_items result = awaiter2.GetResult();
									result.reserved += this.<>8__1.item.BuyCount;
									this.<ctx>5__3.store_sales.Add(new store_sales(true)
									{
										dealer = this.<>8__1.item.dealer,
										customer_id = this.document.DealerId,
										item_id = this.<>8__1.item.id,
										document_id = this.<documentId>5__6,
										count = this.<>8__1.item.BuyCount,
										in_price = this.<>8__1.item.in_price,
										price = this.<>8__1.item.BuyCost,
										warranty = this.<>8__1.item.warranty,
										is_realization = this.<>8__1.item.is_realization,
										return_percent = this.<>8__1.item.return_percent,
										sn = this.<>8__1.item.SN,
										d_category = new int?(this.<>8__1.item.category)
									});
									if (result.boxes != null)
									{
										if (result.Available == 0)
										{
											this.<history>5__2.AddItemLog("LastItemMove", result.id, result.boxes.name, "");
											result.box = null;
										}
										else
										{
											this.<history>5__2.AddItemLog("ProductDispatchedOutOfTheBox", result.id, this.<>8__1.item.BuyCount.ToString(), result.boxes.name);
										}
									}
									this.<>8__1 = null;
									goto IL_131;
								}
								finally
								{
									if (num < 0 && this.<>7__wrap6 != null)
									{
										this.<>7__wrap6.Dispose();
									}
								}
								IL_44E:
								this.<>7__wrap6 = null;
								this.<d>5__5.reason = Lang.t("ReservedItems");
								this.<d>5__5.state = new int?(3);
								this.<d>5__5.total = this.document.Items.Sum(new Func<store_items, decimal>(StoreService.<>c.<>9.<ItemsMoveDispatch>b__11_0));
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 2;
									num = 2;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, StoreService.<ItemsMoveDispatch>d__11>(ref awaiter, ref this);
									return;
								}
								goto IL_50E;
							case 2:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_50E;
							}
							default:
								this.<d>5__5 = this.document.ConvetBack();
								this.<ctx>5__3.docs.Add(this.<d>5__5);
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num7 = 0;
									num = 0;
									this.<>1__state = num7;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, StoreService.<ItemsMoveDispatch>d__11>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult();
							this.<documentId>5__6 = this.<d>5__5.id;
							this.<>7__wrap6 = this.document.Items.GetEnumerator();
							goto IL_101;
							IL_50E:
							awaiter.GetResult();
							this.<transaction>5__4.Commit();
							this.<history>5__2.AddDocumentLog("MoveDocumentCreated", this.<documentId>5__6, "");
							this.<history>5__2.Save();
							result2 = this.<documentId>5__6;
						}
						catch (Exception)
						{
							this.<transaction>5__4.Rollback();
							result2 = 0;
						}
						finally
						{
							if (num < 0 && this.<transaction>5__4 != null)
							{
								((IDisposable)this.<transaction>5__4).Dispose();
							}
						}
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003922 RID: 14626 RVA: 0x000D2D10 File Offset: 0x000D0F10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400231D RID: 8989
			public int <>1__state;

			// Token: 0x0400231E RID: 8990
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400231F RID: 8991
			public IGoodsMoveDocument document;

			// Token: 0x04002320 RID: 8992
			private StoreService.<>c__DisplayClass11_0 <>8__1;

			// Token: 0x04002321 RID: 8993
			private HistoryV2 <history>5__2;

			// Token: 0x04002322 RID: 8994
			private auseceEntities <ctx>5__3;

			// Token: 0x04002323 RID: 8995
			private DbContextTransaction <transaction>5__4;

			// Token: 0x04002324 RID: 8996
			private docs <d>5__5;

			// Token: 0x04002325 RID: 8997
			private int <documentId>5__6;

			// Token: 0x04002326 RID: 8998
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04002327 RID: 8999
			private IEnumerator<store_items> <>7__wrap6;

			// Token: 0x04002328 RID: 9000
			private TaskAwaiter<store_items> <>u__2;
		}

		// Token: 0x020006B2 RID: 1714
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003923 RID: 14627 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04002329 RID: 9001
			public int documentId;
		}

		// Token: 0x020006B3 RID: 1715
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_1
		{
			// Token: 0x06003924 RID: 14628 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_1()
			{
			}

			// Token: 0x0400232A RID: 9002
			public store_sales reserve;
		}

		// Token: 0x020006B4 RID: 1716
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ItemsMoveArrived>d__12 : IAsyncStateMachine
		{
			// Token: 0x06003925 RID: 14629 RVA: 0x000D2D2C File Offset: 0x000D0F2C
			void IAsyncStateMachine.MoveNext()
			{
				/*
An exception occurred when decompiling this method (06003925)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ASC.Services.StoreService/<ItemsMoveArrived>d__12::MoveNext()

 ---> System.Exception: Inconsistent stack size at IL_6D4
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06003926 RID: 14630 RVA: 0x000D35B4 File Offset: 0x000D17B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400232B RID: 9003
			public int <>1__state;

			// Token: 0x0400232C RID: 9004
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400232D RID: 9005
			public int documentId;

			// Token: 0x0400232E RID: 9006
			private StoreService.<>c__DisplayClass12_1 <>8__1;

			// Token: 0x0400232F RID: 9007
			private StoreService.<>c__DisplayClass12_0 <>8__2;

			// Token: 0x04002330 RID: 9008
			private HistoryV2 <history>5__2;

			// Token: 0x04002331 RID: 9009
			private auseceEntities <ctx>5__3;

			// Token: 0x04002332 RID: 9010
			private DbContextTransaction <transaction>5__4;

			// Token: 0x04002333 RID: 9011
			private docs <document>5__5;

			// Token: 0x04002334 RID: 9012
			private TaskAwaiter<docs> <>u__1;

			// Token: 0x04002335 RID: 9013
			private IEnumerator<store_sales> <>7__wrap5;

			// Token: 0x04002336 RID: 9014
			private int <reserveQuantity>5__7;

			// Token: 0x04002337 RID: 9015
			private store_items <product>5__8;

			// Token: 0x04002338 RID: 9016
			private store_items <arrivedProduct>5__9;

			// Token: 0x04002339 RID: 9017
			private TaskAwaiter<store_items> <>u__2;

			// Token: 0x0400233A RID: 9018
			private TaskAwaiter<int> <>u__3;

			// Token: 0x0400233B RID: 9019
			private TaskAwaiter<List<images>> <>u__4;
		}

		// Token: 0x020006B5 RID: 1717
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetDocumentCashOrder>d__13 : IAsyncStateMachine
		{
			// Token: 0x06003927 RID: 14631 RVA: 0x000D35D0 File Offset: 0x000D17D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<docs> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_E3;
							}
							awaiter2 = this.<ctx>5__2.docs.FindAsync(new object[]
							{
								this.documentId
							}).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, StoreService.<SetDocumentCashOrder>d__13>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<docs>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult().order_id = new int?(this.cashOrderId);
						awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, StoreService.<SetDocumentCashOrder>d__13>(ref awaiter, ref this);
							return;
						}
						IL_E3:
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
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

			// Token: 0x06003928 RID: 14632 RVA: 0x000D376C File Offset: 0x000D196C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400233C RID: 9020
			public int <>1__state;

			// Token: 0x0400233D RID: 9021
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400233E RID: 9022
			public int documentId;

			// Token: 0x0400233F RID: 9023
			public int cashOrderId;

			// Token: 0x04002340 RID: 9024
			private auseceEntities <ctx>5__2;

			// Token: 0x04002341 RID: 9025
			private TaskAwaiter<docs> <>u__1;

			// Token: 0x04002342 RID: 9026
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x020006B6 RID: 1718
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06003929 RID: 14633 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600392A RID: 14634 RVA: 0x000D3788 File Offset: 0x000D1988
			internal bool <GetCategoryFieldsAsync>b__0(fields i)
			{
				IEnumerable<string> source = i.categories.Split(new char[]
				{
					','
				});
				Func<string, bool> predicate;
				if ((predicate = this.<>9__2) == null)
				{
					predicate = (this.<>9__2 = ((string c) => c.Equals(this.categoryId.ToString())));
				}
				return source.Any(predicate);
			}

			// Token: 0x0600392B RID: 14635 RVA: 0x000D37D0 File Offset: 0x000D19D0
			internal bool <GetCategoryFieldsAsync>b__2(string c)
			{
				return c.Equals(this.categoryId.ToString());
			}

			// Token: 0x04002343 RID: 9027
			public int categoryId;

			// Token: 0x04002344 RID: 9028
			public Func<string, bool> <>9__2;
		}

		// Token: 0x020006B7 RID: 1719
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCategoryFieldsAsync>d__14 : IAsyncStateMachine
		{
			// Token: 0x0600392C RID: 14636 RVA: 0x000D37F0 File Offset: 0x000D19F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<fields> result;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new StoreService.<>c__DisplayClass14_0();
						this.<>8__1.categoryId = this.categoryId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						TaskAwaiter<List<fields>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.fields.AsNoTracking()
							where !i.archive && !string.IsNullOrEmpty(i.categories)
							select i).ToListAsync<fields>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, StoreService.<GetCategoryFieldsAsync>d__14>(ref awaiter, ref this);
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
						result = awaiter.GetResult().Where(new Func<fields, bool>(this.<>8__1.<GetCategoryFieldsAsync>b__0)).ToList<fields>();
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
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600392D RID: 14637 RVA: 0x000D39C8 File Offset: 0x000D1BC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002345 RID: 9029
			public int <>1__state;

			// Token: 0x04002346 RID: 9030
			public AsyncTaskMethodBuilder<List<fields>> <>t__builder;

			// Token: 0x04002347 RID: 9031
			public int categoryId;

			// Token: 0x04002348 RID: 9032
			private StoreService.<>c__DisplayClass14_0 <>8__1;

			// Token: 0x04002349 RID: 9033
			private auseceEntities <ctx>5__2;

			// Token: 0x0400234A RID: 9034
			private TaskAwaiter<List<fields>> <>u__1;
		}

		// Token: 0x020006B8 RID: 1720
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeleteProductAsync>d__15 : IAsyncStateMachine
		{
			// Token: 0x0600392E RID: 14638 RVA: 0x000D39E4 File Offset: 0x000D1BE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					store_items entity;
					if (num > 1)
					{
						entity = new store_items
						{
							Id = this.productId,
							Hidden = true
						};
						this.<history>5__2 = new HistoryV2();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<int> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_188;
							}
							this.<ctx>5__3.store_items.Attach(entity);
							this.<ctx>5__3.Entry<store_items>(entity).Property<bool>((store_items i) => i.Hidden).IsModified = true;
							this.<ctx>5__3.Configuration.ValidateOnSaveEnabled = false;
							awaiter2 = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, StoreService.<DeleteProductAsync>d__15>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult();
						this.<ctx>5__3.Configuration.ValidateOnSaveEnabled = true;
						this.<history>5__2.AddItemLog("ProductDeleted", this.productId, "", "");
						awaiter = this.<history>5__2.SaveAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, StoreService.<DeleteProductAsync>d__15>(ref awaiter, ref this);
							return;
						}
						IL_188:
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
					this.<ctx>5__3 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600392F RID: 14639 RVA: 0x000D3C34 File Offset: 0x000D1E34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400234B RID: 9035
			public int <>1__state;

			// Token: 0x0400234C RID: 9036
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400234D RID: 9037
			public int productId;

			// Token: 0x0400234E RID: 9038
			private HistoryV2 <history>5__2;

			// Token: 0x0400234F RID: 9039
			private auseceEntities <ctx>5__3;

			// Token: 0x04002350 RID: 9040
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04002351 RID: 9041
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020006B9 RID: 1721
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06003930 RID: 14640 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x04002352 RID: 9042
			public string searchString;
		}

		// Token: 0x020006BA RID: 1722
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SearchSKU>d__16 : IAsyncStateMachine
		{
			// Token: 0x06003931 RID: 14641 RVA: 0x000D3C50 File Offset: 0x000D1E50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IList<int> result;
				try
				{
					StoreService.<>c__DisplayClass16_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreService.<>c__DisplayClass16_0();
						CS$<>8__locals1.searchString = this.searchString;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<int>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.store_items
							where i.name.Contains(CS$<>8__locals1.searchString) || i.PN.Contains(CS$<>8__locals1.searchString) || i.articul.ToString() == CS$<>8__locals1.searchString
							select i.articul).Distinct<int>().ToListAsync<int>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, StoreService.<SearchSKU>d__16>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<int>>);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003932 RID: 14642 RVA: 0x000D3EE0 File Offset: 0x000D20E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002353 RID: 9043
			public int <>1__state;

			// Token: 0x04002354 RID: 9044
			public AsyncTaskMethodBuilder<IList<int>> <>t__builder;

			// Token: 0x04002355 RID: 9045
			public string searchString;

			// Token: 0x04002356 RID: 9046
			private auseceEntities <ctx>5__2;

			// Token: 0x04002357 RID: 9047
			private TaskAwaiter<List<int>> <>u__1;
		}

		// Token: 0x020006BB RID: 1723
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06003933 RID: 14643 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x04002358 RID: 9048
			public IList<int> articuls;
		}

		// Token: 0x020006BC RID: 1724
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetProductsBySKU>d__17 : IAsyncStateMachine
		{
			// Token: 0x06003934 RID: 14644 RVA: 0x000D3EFC File Offset: 0x000D20FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IList<ArticulSearchLite> result;
				try
				{
					StoreService.<>c__DisplayClass17_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new StoreService.<>c__DisplayClass17_0();
						CS$<>8__locals1.articuls = this.articuls;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<store_items>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.store_items.AsNoTracking().Include((store_items i) => i.items_state).Include((store_items i) => i.store_cats)
							where !i.Hidden
							where CS$<>8__locals1.articuls.Contains(i.articul)
							select i).ToListAsync<store_items>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, StoreService.<GetProductsBySKU>d__17>(ref awaiter, ref this);
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
						result = awaiter.GetResult().Select(new Func<store_items, ArticulSearchLite>(StoreService.<>c.<>9.<GetProductsBySKU>b__17_0)).ToList<ArticulSearchLite>();
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003935 RID: 14645 RVA: 0x000D4194 File Offset: 0x000D2394
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002359 RID: 9049
			public int <>1__state;

			// Token: 0x0400235A RID: 9050
			public AsyncTaskMethodBuilder<IList<ArticulSearchLite>> <>t__builder;

			// Token: 0x0400235B RID: 9051
			public IList<int> articuls;

			// Token: 0x0400235C RID: 9052
			private auseceEntities <ctx>5__2;

			// Token: 0x0400235D RID: 9053
			private TaskAwaiter<List<store_items>> <>u__1;
		}
	}
}
