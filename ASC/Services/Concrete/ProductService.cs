using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x0200076E RID: 1902
	public class ProductService : IProductService
	{
		// Token: 0x06003B53 RID: 15187 RVA: 0x000E704C File Offset: 0x000E524C
		public ProductService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x000E7068 File Offset: 0x000E5268
		public Task<IEnumerable<images>> GetImages(int productId)
		{
			ProductService.<GetImages>d__2 <GetImages>d__;
			<GetImages>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<images>>.Create();
			<GetImages>d__.<>4__this = this;
			<GetImages>d__.productId = productId;
			<GetImages>d__.<>1__state = -1;
			<GetImages>d__.<>t__builder.Start<ProductService.<GetImages>d__2>(ref <GetImages>d__);
			return <GetImages>d__.<>t__builder.Task;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000E70B4 File Offset: 0x000E52B4
		public Task<IEnumerable<int>> GetImageIds(int productId)
		{
			ProductService.<GetImageIds>d__3 <GetImageIds>d__;
			<GetImageIds>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<int>>.Create();
			<GetImageIds>d__.<>4__this = this;
			<GetImageIds>d__.productId = productId;
			<GetImageIds>d__.<>1__state = -1;
			<GetImageIds>d__.<>t__builder.Start<ProductService.<GetImageIds>d__3>(ref <GetImageIds>d__);
			return <GetImageIds>d__.<>t__builder.Task;
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x000E7100 File Offset: 0x000E5300
		public Task UpdateProduct(store_items product, IEnumerable<IAttribute> attributes)
		{
			ProductService.<UpdateProduct>d__4 <UpdateProduct>d__;
			<UpdateProduct>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateProduct>d__.<>4__this = this;
			<UpdateProduct>d__.product = product;
			<UpdateProduct>d__.attributes = attributes;
			<UpdateProduct>d__.<>1__state = -1;
			<UpdateProduct>d__.<>t__builder.Start<ProductService.<UpdateProduct>d__4>(ref <UpdateProduct>d__);
			return <UpdateProduct>d__.<>t__builder.Task;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x000E7154 File Offset: 0x000E5354
		private Task LogChanges(store_items original, store_items current, auseceEntities ctx)
		{
			ProductService.<LogChanges>d__5 <LogChanges>d__;
			<LogChanges>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LogChanges>d__.original = original;
			<LogChanges>d__.current = current;
			<LogChanges>d__.ctx = ctx;
			<LogChanges>d__.<>1__state = -1;
			<LogChanges>d__.<>t__builder.Start<ProductService.<LogChanges>d__5>(ref <LogChanges>d__);
			return <LogChanges>d__.<>t__builder.Task;
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x000E71A8 File Offset: 0x000E53A8
		private Task RefreshArticul(store_items item)
		{
			ProductService.<RefreshArticul>d__6 <RefreshArticul>d__;
			<RefreshArticul>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RefreshArticul>d__.<>4__this = this;
			<RefreshArticul>d__.item = item;
			<RefreshArticul>d__.<>1__state = -1;
			<RefreshArticul>d__.<>t__builder.Start<ProductService.<RefreshArticul>d__6>(ref <RefreshArticul>d__);
			return <RefreshArticul>d__.<>t__builder.Task;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x000E71F4 File Offset: 0x000E53F4
		private static void UpdateAttributes(int productId, IEnumerable<IAttribute> attributes, auseceEntities ctx)
		{
			HistoryV2 historyV = new HistoryV2();
			using (IEnumerator<IAttribute> enumerator = attributes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IAttribute attribute = enumerator.Current;
					string text = string.IsNullOrEmpty(attribute.Text) ? "" : attribute.Text;
					field_values field_values = ctx.field_values.FirstOrDefault((field_values v) => v.item_id == (int?)productId && v.field_id == attribute.FieldId);
					if (field_values == null)
					{
						if (!string.IsNullOrEmpty(text))
						{
							ctx.field_values.Add(new field_values
							{
								field_id = attribute.FieldId,
								item_id = new int?(productId),
								value = text
							});
							historyV.AddItemLog("SetAttributeValue", productId, attribute.FieldName, text);
						}
					}
					else
					{
						if (!string.Equals(field_values.value, text, StringComparison.Ordinal))
						{
							historyV.AddItemLog("SetAttributeValue", productId, attribute.FieldName, text);
						}
						field_values.value = text;
					}
				}
			}
			historyV.Save();
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000E742C File Offset: 0x000E562C
		public Task<List<ItemOperation>> GetDocuments(int productId)
		{
			ProductService.<GetDocuments>d__8 <GetDocuments>d__;
			<GetDocuments>d__.<>t__builder = AsyncTaskMethodBuilder<List<ItemOperation>>.Create();
			<GetDocuments>d__.<>4__this = this;
			<GetDocuments>d__.productId = productId;
			<GetDocuments>d__.<>1__state = -1;
			<GetDocuments>d__.<>t__builder.Start<ProductService.<GetDocuments>d__8>(ref <GetDocuments>d__);
			return <GetDocuments>d__.<>t__builder.Task;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000E7478 File Offset: 0x000E5678
		public Task<List<logs>> GetHistory(int productId)
		{
			Task<List<logs>> result;
			using (auseceEntities auseceEntities = this._contextFactory.Create())
			{
				result = (from h in auseceEntities.logs.AsNoTracking().Include((logs h) => h.users)
				where h.item == (int?)productId
				select h).ToListAsync<logs>();
			}
			return result;
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x000E757C File Offset: 0x000E577C
		public Task<int> GetOrCreateArticul(auseceEntities ctx, store_items item)
		{
			ProductService.<GetOrCreateArticul>d__10 <GetOrCreateArticul>d__;
			<GetOrCreateArticul>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<GetOrCreateArticul>d__.ctx = ctx;
			<GetOrCreateArticul>d__.item = item;
			<GetOrCreateArticul>d__.<>1__state = -1;
			<GetOrCreateArticul>d__.<>t__builder.Start<ProductService.<GetOrCreateArticul>d__10>(ref <GetOrCreateArticul>d__);
			return <GetOrCreateArticul>d__.<>t__builder.Task;
		}

		// Token: 0x04002651 RID: 9809
		private readonly IContextFactory _contextFactory;

		// Token: 0x0200076F RID: 1903
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003B5D RID: 15197 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002652 RID: 9810
			public int productId;
		}

		// Token: 0x02000770 RID: 1904
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImages>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003B5E RID: 15198 RVA: 0x000E75C8 File Offset: 0x000E57C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductService productService = this.<>4__this;
				IEnumerable<images> result;
				try
				{
					ProductService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ProductService.<>c__DisplayClass2_0();
						CS$<>8__locals1.productId = this.productId;
						this.<ctx>5__2 = productService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.images.AsNoTracking()
							where i.item_id == (int?)CS$<>8__locals1.productId
							select i).ToListAsync<images>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter, ProductService.<GetImages>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003B5F RID: 15199 RVA: 0x000E7774 File Offset: 0x000E5974
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002653 RID: 9811
			public int <>1__state;

			// Token: 0x04002654 RID: 9812
			public AsyncTaskMethodBuilder<IEnumerable<images>> <>t__builder;

			// Token: 0x04002655 RID: 9813
			public int productId;

			// Token: 0x04002656 RID: 9814
			public ProductService <>4__this;

			// Token: 0x04002657 RID: 9815
			private auseceEntities <ctx>5__2;

			// Token: 0x04002658 RID: 9816
			private ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000771 RID: 1905
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003B60 RID: 15200 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04002659 RID: 9817
			public int productId;
		}

		// Token: 0x02000772 RID: 1906
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B61 RID: 15201 RVA: 0x000E7790 File Offset: 0x000E5990
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003B62 RID: 15202 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003B63 RID: 15203 RVA: 0x000E77A8 File Offset: 0x000E59A8
			internal ItemOperation <GetDocuments>b__8_0(store_int_reserve i)
			{
				return new ItemOperation
				{
					Id = i.id,
					Type = 0,
					Num = string.Format("I-{0:d6}", i.id),
					Date = ((i.created == null) ? DateTime.Now : Localization.ToLocalTimeZone(i.created.Value)),
					Status = new int?(i.state),
					Count = i.count,
					Summ = i.Summ,
					Employee = i.users.User2Employee()
				};
			}

			// Token: 0x06003B64 RID: 15204 RVA: 0x000E7854 File Offset: 0x000E5A54
			internal ItemOperation <GetDocuments>b__8_1(store_sales i)
			{
				return new ItemOperation
				{
					Id = i.document_id,
					Type = 1,
					Num = string.Format("E-{0:d6}", i.id),
					Date = Localization.ToLocalTimeZone(i.docs.created),
					Status = i.docs.state,
					Count = i.count,
					Summ = i.count * i.price,
					Employee = i.users.User2Employee()
				};
			}

			// Token: 0x06003B65 RID: 15205 RVA: 0x000E78F4 File Offset: 0x000E5AF4
			internal ItemOperation <GetDocuments>b__8_2(store_items i)
			{
				return new ItemOperation
				{
					Id = i.docs.id,
					Type = 5,
					Num = string.Format("I-{0:d6}", i.id),
					Date = Localization.ToLocalTimeZone(i.docs.created),
					Status = i.docs.state,
					Count = i.count,
					Summ = i.count * i.price,
					Employee = i.docs.users.User2Employee()
				};
			}

			// Token: 0x06003B66 RID: 15206 RVA: 0x000E79A0 File Offset: 0x000E5BA0
			internal ItemOperation <GetDocuments>b__8_3(store_sales i)
			{
				return new ItemOperation
				{
					Id = i.document_id,
					Type = 5,
					Num = string.Format("I-{0:d6}", i.id),
					Date = Localization.ToLocalTimeZone(i.docs.created),
					Status = i.docs.state,
					Count = i.count,
					Summ = i.count * i.price,
					Employee = i.users.User2Employee()
				};
			}

			// Token: 0x06003B67 RID: 15207 RVA: 0x000E7A40 File Offset: 0x000E5C40
			internal ItemOperation <GetDocuments>b__8_4(store_sales s)
			{
				return new ItemOperation
				{
					Id = s.document_id,
					Type = 2,
					Num = string.Format("S-{0:d6}", s.docs.id),
					Date = Localization.ToLocalTimeZone(s.docs.created),
					Status = s.docs.state,
					Count = s.count,
					Summ = s.count * s.price,
					Employee = s.users.User2Employee()
				};
			}

			// Token: 0x06003B68 RID: 15208 RVA: 0x000E7AE8 File Offset: 0x000E5CE8
			internal ItemOperation <GetDocuments>b__8_5(store_items s)
			{
				return new ItemOperation
				{
					Id = s.docs.id,
					Type = 3,
					Num = string.Format("A-{0:d6}", s.docs.id),
					Date = Localization.ToLocalTimeZone(s.docs.created),
					Status = null,
					Count = s.in_count,
					Summ = s.in_count * s.in_price,
					Employee = s.docs.users.User2Employee()
				};
			}

			// Token: 0x06003B69 RID: 15209 RVA: 0x000E7B98 File Offset: 0x000E5D98
			internal ItemOperation <GetDocuments>b__8_6(store_sales s)
			{
				return new ItemOperation
				{
					Id = s.document_id,
					Type = 4,
					Num = string.Format("C-{0:d6}", s.docs.id),
					Date = Localization.ToLocalTimeZone(s.docs.created),
					Status = s.docs.state,
					Count = s.count,
					Summ = s.count * s.price,
					Employee = s.users.User2Employee()
				};
			}

			// Token: 0x06003B6A RID: 15210 RVA: 0x000E7C40 File Offset: 0x000E5E40
			internal DateTime <GetDocuments>b__8_7(ItemOperation r)
			{
				return r.Date;
			}

			// Token: 0x0400265A RID: 9818
			public static readonly ProductService.<>c <>9 = new ProductService.<>c();

			// Token: 0x0400265B RID: 9819
			public static Func<store_int_reserve, ItemOperation> <>9__8_0;

			// Token: 0x0400265C RID: 9820
			public static Func<store_sales, ItemOperation> <>9__8_1;

			// Token: 0x0400265D RID: 9821
			public static Func<store_items, ItemOperation> <>9__8_2;

			// Token: 0x0400265E RID: 9822
			public static Func<store_sales, ItemOperation> <>9__8_3;

			// Token: 0x0400265F RID: 9823
			public static Func<store_sales, ItemOperation> <>9__8_4;

			// Token: 0x04002660 RID: 9824
			public static Func<store_items, ItemOperation> <>9__8_5;

			// Token: 0x04002661 RID: 9825
			public static Func<store_sales, ItemOperation> <>9__8_6;

			// Token: 0x04002662 RID: 9826
			public static Func<ItemOperation, DateTime> <>9__8_7;
		}

		// Token: 0x02000773 RID: 1907
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImageIds>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003B6B RID: 15211 RVA: 0x000E7C54 File Offset: 0x000E5E54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductService productService = this.<>4__this;
				IEnumerable<int> result;
				try
				{
					ProductService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ProductService.<>c__DisplayClass3_0();
						CS$<>8__locals1.productId = this.productId;
						this.<ctx>5__2 = productService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<List<int>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.images.AsNoTracking()
							where i.item_id == (int?)CS$<>8__locals1.productId
							select i.id).ToListAsync<int>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<int>>.ConfiguredTaskAwaiter, ProductService.<GetImageIds>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<int>>.ConfiguredTaskAwaiter);
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

			// Token: 0x06003B6C RID: 15212 RVA: 0x000E7E44 File Offset: 0x000E6044
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002663 RID: 9827
			public int <>1__state;

			// Token: 0x04002664 RID: 9828
			public AsyncTaskMethodBuilder<IEnumerable<int>> <>t__builder;

			// Token: 0x04002665 RID: 9829
			public int productId;

			// Token: 0x04002666 RID: 9830
			public ProductService <>4__this;

			// Token: 0x04002667 RID: 9831
			private auseceEntities <ctx>5__2;

			// Token: 0x04002668 RID: 9832
			private ConfiguredTaskAwaitable<List<int>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000774 RID: 1908
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003B6D RID: 15213 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002669 RID: 9833
			public store_items product;
		}

		// Token: 0x02000775 RID: 1909
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateProduct>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003B6E RID: 15214 RVA: 0x000E7E60 File Offset: 0x000E6060
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductService productService = this.<>4__this;
				try
				{
					if (num > 4)
					{
						this.<>8__1 = new ProductService.<>c__DisplayClass4_0();
						this.<>8__1.product = this.product;
						this.<ctx>5__2 = productService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<store_items> awaiter;
						TaskAwaiter awaiter2;
						TaskAwaiter<int> awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<store_items>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_1C4;
						}
						case 2:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_239;
						}
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<int>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_2DD;
						}
						case 4:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<int>);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_372;
						}
						default:
							awaiter = this.<ctx>5__2.store_items.SingleAsync((store_items i) => i.id == this.<>8__1.product.id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num7 = 0;
								num = 0;
								this.<>1__state = num7;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ProductService.<UpdateProduct>d__4>(ref awaiter, ref this);
								return;
							}
							break;
						}
						store_items result = awaiter.GetResult();
						this.<original>5__3 = result;
						if (!(this.<original>5__3.name != this.<>8__1.product.name))
						{
							goto IL_1CB;
						}
						awaiter2 = productService.RefreshArticul(this.<>8__1.product).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num8 = 1;
							num = 1;
							this.<>1__state = num8;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductService.<UpdateProduct>d__4>(ref awaiter2, ref this);
							return;
						}
						IL_1C4:
						awaiter2.GetResult();
						IL_1CB:
						awaiter2 = productService.LogChanges(this.<original>5__3, this.<>8__1.product, this.<ctx>5__2).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num9 = 2;
							num = 2;
							this.<>1__state = num9;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductService.<UpdateProduct>d__4>(ref awaiter2, ref this);
							return;
						}
						IL_239:
						awaiter2.GetResult();
						this.<ctx>5__2.Entry<store_items>(this.<original>5__3).CurrentValues.SetValues(this.<>8__1.product);
						this.<original>5__3.updated = new DateTime?(Localization.GetServerUtcTime(this.<ctx>5__2));
						awaiter3 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num10 = 3;
							num = 3;
							this.<>1__state = num10;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ProductService.<UpdateProduct>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_2DD:
						awaiter3.GetResult();
						if (!this.attributes.Any<IAttribute>())
						{
							goto IL_37A;
						}
						ProductService.UpdateAttributes(this.<>8__1.product.id, this.attributes, this.<ctx>5__2);
						awaiter3 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num11 = 4;
							num = 4;
							this.<>1__state = num11;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ProductService.<UpdateProduct>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_372:
						awaiter3.GetResult();
						IL_37A:
						this.<original>5__3 = null;
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003B6F RID: 15215 RVA: 0x000E8280 File Offset: 0x000E6480
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400266A RID: 9834
			public int <>1__state;

			// Token: 0x0400266B RID: 9835
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400266C RID: 9836
			public store_items product;

			// Token: 0x0400266D RID: 9837
			public ProductService <>4__this;

			// Token: 0x0400266E RID: 9838
			private ProductService.<>c__DisplayClass4_0 <>8__1;

			// Token: 0x0400266F RID: 9839
			public IEnumerable<IAttribute> attributes;

			// Token: 0x04002670 RID: 9840
			private auseceEntities <ctx>5__2;

			// Token: 0x04002671 RID: 9841
			private store_items <original>5__3;

			// Token: 0x04002672 RID: 9842
			private TaskAwaiter<store_items> <>u__1;

			// Token: 0x04002673 RID: 9843
			private TaskAwaiter <>u__2;

			// Token: 0x04002674 RID: 9844
			private TaskAwaiter<int> <>u__3;
		}

		// Token: 0x02000776 RID: 1910
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003B70 RID: 15216 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x04002675 RID: 9845
			public store_items current;
		}

		// Token: 0x02000777 RID: 1911
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LogChanges>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003B71 RID: 15217 RVA: 0x000E829C File Offset: 0x000E649C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						ProductService.<>c__DisplayClass5_0 CS$<>8__locals1 = new ProductService.<>c__DisplayClass5_0();
						CS$<>8__locals1.current = this.current;
						HistoryV2 historyV = new HistoryV2();
						if (this.original.name != CS$<>8__locals1.current.name)
						{
							historyV.AddItemLog("changeName", CS$<>8__locals1.current.id, this.original.name, CS$<>8__locals1.current.name);
						}
						if (this.original.category != CS$<>8__locals1.current.category)
						{
							historyV.AddItemLog("changeCategory", CS$<>8__locals1.current.id, CS$<>8__locals1.current.store_cats.name, "");
						}
						if (this.original.state != CS$<>8__locals1.current.state)
						{
							historyV.AddItemLog("changeState", CS$<>8__locals1.current.id, CS$<>8__locals1.current.items_state.name, "");
						}
						if (this.original.articul != CS$<>8__locals1.current.articul)
						{
							historyV.AddItemLog("changeArticul", CS$<>8__locals1.current.id, this.original.articul.ToString("D6"), CS$<>8__locals1.current.articul.ToString("D6"));
						}
						if (this.original.SN != CS$<>8__locals1.current.SN)
						{
							historyV.AddItemLog("changeSn", CS$<>8__locals1.current.id, this.original.SN, CS$<>8__locals1.current.SN);
						}
						if (this.original.count != CS$<>8__locals1.current.count)
						{
							historyV.AddItemLog("QuantityChanged", CS$<>8__locals1.current.id, this.original.count.ToString(), CS$<>8__locals1.current.count.ToString());
						}
						if (this.original.in_price != CS$<>8__locals1.current.in_price)
						{
							historyV.AddItemLog("InPriceChanged", CS$<>8__locals1.current.id, this.original.in_price.ToString("N2"), CS$<>8__locals1.current.in_price.ToString("N2"));
						}
						if (this.original.PN != CS$<>8__locals1.current.PN)
						{
							historyV.AddItemLog("changePn", CS$<>8__locals1.current.id, this.original.PN, CS$<>8__locals1.current.PN);
						}
						if (this.original.ext_barcode != CS$<>8__locals1.current.ext_barcode)
						{
							historyV.AddItemLog("changeBarcode", CS$<>8__locals1.current.id, this.original.ext_barcode, CS$<>8__locals1.current.ext_barcode);
						}
						if (this.original.minimum_in_stock != CS$<>8__locals1.current.minimum_in_stock)
						{
							historyV.AddItemLog("changeMinInStock", CS$<>8__locals1.current.id, CS$<>8__locals1.current.minimum_in_stock.ToString(), "");
						}
						int? box = this.original.box;
						int? box2 = CS$<>8__locals1.current.box;
						if (!(box.GetValueOrDefault() == box2.GetValueOrDefault() & box != null == (box2 != null)))
						{
							boxes boxes = this.ctx.boxes.FirstOrDefault((boxes b) => (int?)b.id == CS$<>8__locals1.current.box);
							historyV.AddItemLog("setBox", CS$<>8__locals1.current.id, (boxes != null) ? boxes.name : null, "");
						}
						if (this.original.price != CS$<>8__locals1.current.price)
						{
							historyV.AddItemLog("changePrice", CS$<>8__locals1.current.id, CS$<>8__locals1.current.FormatPrice(this.original.price).ToString("N2"), CS$<>8__locals1.current.Price1Raw.ToString("N2"));
						}
						if (this.original.price2 != CS$<>8__locals1.current.price2)
						{
							historyV.AddItemLog("changePrice2", CS$<>8__locals1.current.id, CS$<>8__locals1.current.FormatPrice(this.original.price2).ToString("N2"), CS$<>8__locals1.current.Price2Raw.ToString("N2"));
						}
						if (this.original.price3 != CS$<>8__locals1.current.price3)
						{
							historyV.AddItemLog("changePrice34", CS$<>8__locals1.current.id, CS$<>8__locals1.current.FormatPrice(this.original.price3).ToString("N2"), CS$<>8__locals1.current.Price3Raw.ToString("N2"));
						}
						if (this.original.price4 != CS$<>8__locals1.current.price4)
						{
							historyV.AddItemLog("changePrice34", CS$<>8__locals1.current.id, CS$<>8__locals1.current.FormatPrice(this.original.price4).ToString("N2"), CS$<>8__locals1.current.Price4Raw.ToString("N2"));
						}
						if (this.original.dealer != CS$<>8__locals1.current.dealer)
						{
							clients clients = this.ctx.clients.Find(new object[]
							{
								CS$<>8__locals1.current.dealer
							});
							historyV.AddItemLog("changeDealer", CS$<>8__locals1.current.id, (clients != null) ? clients.FioOrUrName : null, "");
						}
						awaiter = historyV.SaveAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ProductService.<LogChanges>d__5>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
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

			// Token: 0x06003B72 RID: 15218 RVA: 0x000E89AC File Offset: 0x000E6BAC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002676 RID: 9846
			public int <>1__state;

			// Token: 0x04002677 RID: 9847
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002678 RID: 9848
			public store_items current;

			// Token: 0x04002679 RID: 9849
			public store_items original;

			// Token: 0x0400267A RID: 9850
			public auseceEntities ctx;

			// Token: 0x0400267B RID: 9851
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000778 RID: 1912
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003B73 RID: 15219 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0400267C RID: 9852
			public int oldArticul;
		}

		// Token: 0x02000779 RID: 1913
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshArticul>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003B74 RID: 15220 RVA: 0x000E89C8 File Offset: 0x000E6BC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductService productService = this.<>4__this;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new ProductService.<>c__DisplayClass6_0();
						this.<>8__1.oldArticul = this.item.articul;
						this.<ctx>5__2 = productService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<List<materials>> awaiter2;
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
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<materials>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_1BB;
						}
						case 2:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_270;
						}
						default:
							this.<>7__wrap2 = this.item;
							awaiter = productService.GetOrCreateArticul(this.<ctx>5__2, this.item).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ProductService.<RefreshArticul>d__6>(ref awaiter, ref this);
								return;
							}
							break;
						}
						int result = awaiter.GetResult();
						this.<>7__wrap2.articul = result;
						this.<>7__wrap2 = null;
						awaiter2 = (from m in this.<ctx>5__2.materials
						where m.articul == (int?)this.<>8__1.oldArticul
						select m).ToListAsync<materials>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<materials>>, ProductService.<RefreshArticul>d__6>(ref awaiter2, ref this);
							return;
						}
						IL_1BB:
						List<materials> result2 = awaiter2.GetResult();
						if (!result2.Any<materials>())
						{
							goto IL_2BB;
						}
						List<materials>.Enumerator enumerator = result2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								materials materials = enumerator.Current;
								materials.articul = new int?(this.item.articul);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ProductService.<RefreshArticul>d__6>(ref awaiter, ref this);
							return;
						}
						IL_270:
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
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_2BB:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003B75 RID: 15221 RVA: 0x000E8CF8 File Offset: 0x000E6EF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400267D RID: 9853
			public int <>1__state;

			// Token: 0x0400267E RID: 9854
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400267F RID: 9855
			public store_items item;

			// Token: 0x04002680 RID: 9856
			public ProductService <>4__this;

			// Token: 0x04002681 RID: 9857
			private ProductService.<>c__DisplayClass6_0 <>8__1;

			// Token: 0x04002682 RID: 9858
			private auseceEntities <ctx>5__2;

			// Token: 0x04002683 RID: 9859
			private store_items <>7__wrap2;

			// Token: 0x04002684 RID: 9860
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04002685 RID: 9861
			private TaskAwaiter<List<materials>> <>u__2;
		}

		// Token: 0x0200077A RID: 1914
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003B76 RID: 15222 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04002686 RID: 9862
			public int productId;
		}

		// Token: 0x0200077B RID: 1915
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_1
		{
			// Token: 0x06003B77 RID: 15223 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_1()
			{
			}

			// Token: 0x04002687 RID: 9863
			public IAttribute attribute;

			// Token: 0x04002688 RID: 9864
			public ProductService.<>c__DisplayClass7_0 CS$<>8__locals1;
		}

		// Token: 0x0200077C RID: 1916
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06003B78 RID: 15224 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04002689 RID: 9865
			public int productId;
		}

		// Token: 0x0200077D RID: 1917
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDocuments>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003B79 RID: 15225 RVA: 0x000E8D14 File Offset: 0x000E6F14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductService productService = this.<>4__this;
				List<ItemOperation> result;
				try
				{
					if (num > 6)
					{
						this.<>8__1 = new ProductService.<>c__DisplayClass8_0();
						this.<>8__1.productId = this.productId;
						this.<result>5__2 = new List<ItemOperation>();
						this.<ctx>5__3 = productService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<store_int_reserve>> awaiter;
						TaskAwaiter<List<store_sales>> awaiter2;
						TaskAwaiter<List<store_items>> awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<store_int_reserve>>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<store_sales>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_2CA;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<List<store_items>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_4B8;
						}
						case 3:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<store_sales>>);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_6A6;
						}
						case 4:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<store_sales>>);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_8E7;
						}
						case 5:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<List<store_items>>);
							int num7 = -1;
							num = -1;
							this.<>1__state = num7;
							goto IL_AF6;
						}
						case 6:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<store_sales>>);
							int num8 = -1;
							num = -1;
							this.<>1__state = num8;
							goto IL_CDA;
						}
						default:
							awaiter = (from i in this.<ctx>5__3.store_int_reserve
							where i.item_id == this.<>8__1.productId
							select i).ToListAsync<store_int_reserve>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num9 = 0;
								num = 0;
								this.<>1__state = num9;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_int_reserve>>, ProductService.<GetDocuments>d__8>(ref awaiter, ref this);
								return;
							}
							break;
						}
						List<ItemOperation> collection = awaiter.GetResult().Select(new Func<store_int_reserve, ItemOperation>(ProductService.<>c.<>9.<GetDocuments>b__8_0)).ToList<ItemOperation>();
						this.<result>5__2.AddRange(collection);
						awaiter2 = (from s in this.<ctx>5__3.store_sales.Include((store_sales s) => s.docs)
						where s.item_id == this.<>8__1.productId && s.docs.type == 6
						select s).ToListAsync<store_sales>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num10 = 1;
							num = 1;
							this.<>1__state = num10;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, ProductService.<GetDocuments>d__8>(ref awaiter2, ref this);
							return;
						}
						IL_2CA:
						List<ItemOperation> collection2 = awaiter2.GetResult().Select(new Func<store_sales, ItemOperation>(ProductService.<>c.<>9.<GetDocuments>b__8_1)).ToList<ItemOperation>();
						this.<result>5__2.AddRange(collection2);
						awaiter3 = (from s in this.<ctx>5__3.store_items.AsNoTracking().Include((store_items s) => s.docs).Include((store_items s) => s.docs.users)
						where s.id == this.<>8__1.productId && s.docs.type == 4
						select s).ToListAsync<store_items>().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num11 = 2;
							num = 2;
							this.<>1__state = num11;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, ProductService.<GetDocuments>d__8>(ref awaiter3, ref this);
							return;
						}
						IL_4B8:
						List<ItemOperation> collection3 = awaiter3.GetResult().Select(new Func<store_items, ItemOperation>(ProductService.<>c.<>9.<GetDocuments>b__8_2)).ToList<ItemOperation>();
						this.<result>5__2.AddRange(collection3);
						awaiter2 = (from s in this.<ctx>5__3.store_sales.AsNoTracking().Include((store_sales s) => s.docs).Include((store_sales s) => s.docs.users)
						where s.item_id == this.<>8__1.productId && s.docs.type == 4
						select s).ToListAsync<store_sales>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num12 = 3;
							num = 3;
							this.<>1__state = num12;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, ProductService.<GetDocuments>d__8>(ref awaiter2, ref this);
							return;
						}
						IL_6A6:
						List<ItemOperation> collection4 = awaiter2.GetResult().Select(new Func<store_sales, ItemOperation>(ProductService.<>c.<>9.<GetDocuments>b__8_3)).ToList<ItemOperation>();
						this.<result>5__2.AddRange(collection4);
						awaiter2 = (from s in this.<ctx>5__3.store_sales.AsNoTracking().Include((store_sales s) => s.docs).Include((store_sales s) => s.users)
						where s.item_id == this.<>8__1.productId && (s.docs.state == (int?)5 || s.docs.state == (int?)7)
						select s).ToListAsync<store_sales>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num13 = 4;
							num = 4;
							this.<>1__state = num13;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, ProductService.<GetDocuments>d__8>(ref awaiter2, ref this);
							return;
						}
						IL_8E7:
						List<ItemOperation> collection5 = awaiter2.GetResult().Select(new Func<store_sales, ItemOperation>(ProductService.<>c.<>9.<GetDocuments>b__8_4)).ToList<ItemOperation>();
						this.<result>5__2.AddRange(collection5);
						awaiter3 = (from i in this.<ctx>5__3.store_items.Include((store_items i) => i.docs).Include((store_items i) => i.docs.users)
						where i.id == this.<>8__1.productId
						where i.docs.type == 1
						select i).ToListAsync<store_items>().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num14 = 5;
							num = 5;
							this.<>1__state = num14;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, ProductService.<GetDocuments>d__8>(ref awaiter3, ref this);
							return;
						}
						IL_AF6:
						List<ItemOperation> collection6 = awaiter3.GetResult().Select(new Func<store_items, ItemOperation>(ProductService.<>c.<>9.<GetDocuments>b__8_5)).ToList<ItemOperation>();
						this.<result>5__2.AddRange(collection6);
						awaiter2 = (from s in this.<ctx>5__3.store_sales.Include((store_sales s) => s.docs).Include((store_sales s) => s.users)
						where s.item_id == this.<>8__1.productId && s.docs.state == (int?)6
						select s).ToListAsync<store_sales>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num15 = 6;
							num = 6;
							this.<>1__state = num15;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, ProductService.<GetDocuments>d__8>(ref awaiter2, ref this);
							return;
						}
						IL_CDA:
						List<ItemOperation> collection7 = awaiter2.GetResult().Select(new Func<store_sales, ItemOperation>(ProductService.<>c.<>9.<GetDocuments>b__8_6)).ToList<ItemOperation>();
						this.<result>5__2.AddRange(collection7);
						result = this.<result>5__2.OrderByDescending(new Func<ItemOperation, DateTime>(ProductService.<>c.<>9.<GetDocuments>b__8_7)).ToList<ItemOperation>();
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
					this.<>8__1 = null;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003B7A RID: 15226 RVA: 0x000E9B04 File Offset: 0x000E7D04
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400268A RID: 9866
			public int <>1__state;

			// Token: 0x0400268B RID: 9867
			public AsyncTaskMethodBuilder<List<ItemOperation>> <>t__builder;

			// Token: 0x0400268C RID: 9868
			public int productId;

			// Token: 0x0400268D RID: 9869
			public ProductService <>4__this;

			// Token: 0x0400268E RID: 9870
			private ProductService.<>c__DisplayClass8_0 <>8__1;

			// Token: 0x0400268F RID: 9871
			private List<ItemOperation> <result>5__2;

			// Token: 0x04002690 RID: 9872
			private auseceEntities <ctx>5__3;

			// Token: 0x04002691 RID: 9873
			private TaskAwaiter<List<store_int_reserve>> <>u__1;

			// Token: 0x04002692 RID: 9874
			private TaskAwaiter<List<store_sales>> <>u__2;

			// Token: 0x04002693 RID: 9875
			private TaskAwaiter<List<store_items>> <>u__3;
		}

		// Token: 0x0200077E RID: 1918
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003B7B RID: 15227 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04002694 RID: 9876
			public int productId;
		}

		// Token: 0x0200077F RID: 1919
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003B7C RID: 15228 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04002695 RID: 9877
			public store_items item;
		}

		// Token: 0x02000780 RID: 1920
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetOrCreateArticul>d__10 : IAsyncStateMachine
		{
			// Token: 0x06003B7D RID: 15229 RVA: 0x000E9B20 File Offset: 0x000E7D20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int result2;
				try
				{
					TaskAwaiter<int?> awaiter;
					TaskAwaiter<int> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int?>);
							this.<>1__state = -1;
							goto IL_26D;
						}
						ProductService.<>c__DisplayClass10_0 CS$<>8__locals1 = new ProductService.<>c__DisplayClass10_0();
						CS$<>8__locals1.item = this.item;
						awaiter2 = (from i in this.ctx.store_items
						where i.name == CS$<>8__locals1.item.name && i.id != CS$<>8__locals1.item.id
						orderby i.id
						select i into a
						select a.articul).FirstOrDefaultAsync<int>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ProductService.<GetOrCreateArticul>d__10>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter2.GetResult();
					if (result != 0)
					{
						result2 = result;
						goto IL_2CB;
					}
					awaiter = this.ctx.store_items.MaxAsync((store_items i) => (int?)i.articul).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int?>, ProductService.<GetOrCreateArticul>d__10>(ref awaiter, ref this);
						return;
					}
					IL_26D:
					int valueOrDefault = awaiter.GetResult().GetValueOrDefault();
					result2 = ((valueOrDefault == 0) ? 1 : (valueOrDefault + 1));
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_2CB:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003B7E RID: 15230 RVA: 0x000E9E28 File Offset: 0x000E8028
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002696 RID: 9878
			public int <>1__state;

			// Token: 0x04002697 RID: 9879
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002698 RID: 9880
			public store_items item;

			// Token: 0x04002699 RID: 9881
			public auseceEntities ctx;

			// Token: 0x0400269A RID: 9882
			private TaskAwaiter<int> <>u__1;

			// Token: 0x0400269B RID: 9883
			private TaskAwaiter<int?> <>u__2;
		}
	}
}
