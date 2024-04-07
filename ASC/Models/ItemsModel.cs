using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using ASC.Services.Concrete;
using NLog;
using Poly;

namespace ASC.Models
{
	// Token: 0x020009FF RID: 2559
	public class ItemsModel
	{
		// Token: 0x06004C02 RID: 19458 RVA: 0x00137690 File Offset: 0x00135890
		public Task<store_items> LoadItem(int itemId)
		{
			Task<store_items> firstOrDefaultAsync;
			using (GenericRepository<store_items> genericRepository = new GenericRepository<store_items>())
			{
				genericRepository.DisableProxyCreation();
				firstOrDefaultAsync = genericRepository.GetFirstOrDefaultAsync((store_items i) => i.id == itemId, "stores,store_cats,boxes,items_state");
			}
			return firstOrDefaultAsync;
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x0013773C File Offset: 0x0013593C
		public static store_items DefaultItem()
		{
			Localization localization = new Localization("UTC");
			return new store_items
			{
				created = new DateTime?(localization.Now),
				articul = 0,
				count = 0,
				reserved = 0,
				shop_enable = new bool?(false),
				in_price = 0m,
				price = 0m,
				price2 = 0m,
				price3 = 0m,
				price4 = 0m,
				minimum_in_stock = 0,
				price_option = 1,
				sold = 0,
				is_realization = false,
				in_summ = 0m,
				units = 0,
				ge_highlight = false
			};
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x001377F8 File Offset: 0x001359F8
		public static Task<IEnumerable<store_items>> LoadItems(List<int> ids)
		{
			ItemsModel.<LoadItems>d__3 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<store_items>>.Create();
			<LoadItems>d__.ids = ids;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<ItemsModel.<LoadItems>d__3>(ref <LoadItems>d__);
			return <LoadItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x0013783C File Offset: 0x00135A3C
		public Task<IEnumerable<store_items>> LoadFireItems()
		{
			ItemsModel.<LoadFireItems>d__4 <LoadFireItems>d__;
			<LoadFireItems>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<store_items>>.Create();
			<LoadFireItems>d__.<>1__state = -1;
			<LoadFireItems>d__.<>t__builder.Start<ItemsModel.<LoadFireItems>d__4>(ref <LoadFireItems>d__);
			return <LoadFireItems>d__.<>t__builder.Task;
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00137878 File Offset: 0x00135A78
		public static void SubstractItems(IEnumerable<store_items> items, bool isCancellation = false)
		{
			HistoryV2 historyV = new HistoryV2();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					DateTime serverUtcTime = Localization.GetServerUtcTime(auseceEntities);
					foreach (store_items store_items in items)
					{
						store_items store_items2 = auseceEntities.store_items.Find(new object[]
						{
							store_items.id
						});
						if (store_items2 == null)
						{
							ItemsModel.Log.Error("Cant find item to substract");
						}
						else
						{
							store_items2.count -= store_items.BuyCount;
							store_items2.sold += store_items.BuyCount;
							string action = isCancellation ? "ItemCancelled" : "ItemSold";
							historyV.AddItemLog(action, store_items2.id, store_items.BuyCount.ToString(), "");
							if (store_items2.count == 0 && store_items.box != null)
							{
								store_items2.box = null;
								historyV.AddItemLog("LastItemSold", store_items2.id, store_items.box_name, "");
							}
							store_items2.updated = new DateTime?(serverUtcTime);
						}
					}
					auseceEntities.SaveChanges();
					historyV.Save();
				}
			}
			catch (Exception exception)
			{
				ItemsModel.Log.Error(exception, "Substract items fail");
			}
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00137A34 File Offset: 0x00135C34
		public void CreateStoreSales(IEnumerable<store_items> items, int documentId)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					foreach (store_items store_items in items)
					{
						auseceEntities.store_sales.Add(new store_sales(true)
						{
							dealer = store_items.dealer,
							item_id = store_items.id,
							document_id = documentId,
							count = store_items.BuyCount,
							in_price = store_items.in_price,
							price = 0m,
							warranty = 0,
							is_realization = store_items.is_realization,
							return_percent = store_items.return_percent
						});
					}
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				ItemsModel.Log.Error(exception, "Sale items fail");
			}
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00137B34 File Offset: 0x00135D34
		public static Task<List<items_state>> LoadItemStates(bool includeAll = false)
		{
			ItemsModel.<LoadItemStates>d__7 <LoadItemStates>d__;
			<LoadItemStates>d__.<>t__builder = AsyncTaskMethodBuilder<List<items_state>>.Create();
			<LoadItemStates>d__.includeAll = includeAll;
			<LoadItemStates>d__.<>1__state = -1;
			<LoadItemStates>d__.<>t__builder.Start<ItemsModel.<LoadItemStates>d__7>(ref <LoadItemStates>d__);
			return <LoadItemStates>d__.<>t__builder.Task;
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00137B78 File Offset: 0x00135D78
		private void ArticulDuplicatesRemove(List<store_items> items)
		{
			foreach (var <>f__AnonymousType in (from x in items
			group x by new
			{
				x.name,
				x.category,
				x.state
			} into g
			where g.Count<store_items>() > 1
			select g into grp
			select new
			{
				groupId = grp.Key,
				gItems = grp.ToList<store_items>()
			}).ToList())
			{
				int num = 0;
				using (List<store_items>.Enumerator enumerator2 = <>f__AnonymousType.gItems.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						store_items item = enumerator2.Current;
						if (num != 0)
						{
							store_items store_items = items.FirstOrDefault((store_items i) => i.id == item.id);
							if (store_items != null)
							{
								store_items.articul = num;
							}
						}
						else
						{
							num = item.articul;
						}
					}
				}
			}
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00137CAC File Offset: 0x00135EAC
		public void ItemCreationLog(auseceEntities ctx, HistoryV2 history, IEnumerable<store_items> items)
		{
			bool flag = false;
			foreach (store_items store_items in items)
			{
				string text = string.Empty;
				if (store_items.box != null)
				{
					int? box = store_items.box;
					if (!(box.GetValueOrDefault() == 0 & box != null))
					{
						text = store_items.box_name;
					}
				}
				history.Add(51, new string[]
				{
					store_items.id.ToString(),
					store_items.document.ToString(),
					text
				});
				if (store_items.part_request != null)
				{
					parts_request parts_request = ctx.parts_request.Find(new object[]
					{
						store_items.part_request.Value
					});
					if (parts_request != null)
					{
						flag = true;
						parts_request parts_request2 = new parts_request();
						parts_request.CopyProperties(parts_request2);
						parts_request.state = 2;
						parts_request.end_date = new DateTime?(Localization.GetServerUtcTime(ctx));
						parts_request.dealer = new int?(store_items.dealer);
						PartsRequestService.LogChanges(history, parts_request2, parts_request);
						history.AddItemLog(store_items.id, parts_request);
					}
				}
			}
			if (flag)
			{
				ctx.SaveChanges();
			}
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00137E20 File Offset: 0x00136020
		public Task CreateProducts(auseceEntities ctx, HistoryV2 history, docs document, List<Product> i)
		{
			ItemsModel.<CreateProducts>d__10 <CreateProducts>d__;
			<CreateProducts>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateProducts>d__.<>4__this = this;
			<CreateProducts>d__.ctx = ctx;
			<CreateProducts>d__.history = history;
			<CreateProducts>d__.document = document;
			<CreateProducts>d__.i = i;
			<CreateProducts>d__.<>1__state = -1;
			<CreateProducts>d__.<>t__builder.Start<ItemsModel.<CreateProducts>d__10>(ref <CreateProducts>d__);
			return <CreateProducts>d__.<>t__builder.Task;
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x00137E84 File Offset: 0x00136084
		private static void SaveProductImages(auseceEntities ctx, List<Product> i, List<store_items> items)
		{
			/*
An exception occurred when decompiling this method (06004C0C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ASC.Models.ItemsModel::SaveProductImages(ASC.auseceEntities,System.Collections.Generic.List`1<ASC.Objects.Product>,System.Collections.Generic.List`1<ASC.store_items>)

 ---> System.Exception: Inconsistent stack size at IL_22
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x00137EBC File Offset: 0x001360BC
		private void AddItemBarcode(auseceEntities ctx, IEnumerable<store_items> items)
		{
			Barcode barcode = new Barcode(Barcode.Types.StoreItem);
			foreach (store_items store_items in items)
			{
				store_items.int_barcode = barcode.GenerateCode(store_items.id);
				ctx.SaveChanges();
			}
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x00137F20 File Offset: 0x00136120
		public void RestoreItemsCount(List<store_sales> items)
		{
			ItemsModel.<RestoreItemsCount>d__13 <RestoreItemsCount>d__;
			<RestoreItemsCount>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RestoreItemsCount>d__.items = items;
			<RestoreItemsCount>d__.<>1__state = -1;
			<RestoreItemsCount>d__.<>t__builder.Start<ItemsModel.<RestoreItemsCount>d__13>(ref <RestoreItemsCount>d__);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x000046B4 File Offset: 0x000028B4
		public ItemsModel()
		{
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00137F58 File Offset: 0x00136158
		// Note: this type is marked as 'beforefieldinit'.
		static ItemsModel()
		{
		}

		// Token: 0x04003115 RID: 12565
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x02000A00 RID: 2560
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06004C11 RID: 19473 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04003116 RID: 12566
			public int itemId;
		}

		// Token: 0x02000A01 RID: 2561
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004C12 RID: 19474 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04003117 RID: 12567
			public List<int> ids;
		}

		// Token: 0x02000A02 RID: 2562
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__3 : IAsyncStateMachine
		{
			// Token: 0x06004C13 RID: 19475 RVA: 0x00137F70 File Offset: 0x00136170
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<store_items> result;
				try
				{
					ItemsModel.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ItemsModel.<>c__DisplayClass3_0();
						CS$<>8__locals1.ids = this.ids;
						this.<repo>5__2 = new GenericRepository<store_items>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_items>> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.DisableProxyCreation();
							awaiter = this.<repo>5__2.GetAllAsync((store_items i) => CS$<>8__locals1.ids.Contains(i.id), null, "stores,store_cats,boxes,items_state,clients,field_values,field_values.fields").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, ItemsModel.<LoadItems>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004C14 RID: 19476 RVA: 0x00138114 File Offset: 0x00136314
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003118 RID: 12568
			public int <>1__state;

			// Token: 0x04003119 RID: 12569
			public AsyncTaskMethodBuilder<IEnumerable<store_items>> <>t__builder;

			// Token: 0x0400311A RID: 12570
			public List<int> ids;

			// Token: 0x0400311B RID: 12571
			private GenericRepository<store_items> <repo>5__2;

			// Token: 0x0400311C RID: 12572
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x02000A03 RID: 2563
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C15 RID: 19477 RVA: 0x00138130 File Offset: 0x00136330
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004C16 RID: 19478 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004C17 RID: 19479 RVA: 0x00138148 File Offset: 0x00136348
			internal <>f__AnonymousType12<string, int, int> <ArticulDuplicatesRemove>b__8_0(store_items x)
			{
				return new
				{
					x.name,
					x.category,
					x.state
				};
			}

			// Token: 0x06004C18 RID: 19480 RVA: 0x0013816C File Offset: 0x0013636C
			internal bool <ArticulDuplicatesRemove>b__8_1(IGrouping<<>f__AnonymousType12<string, int, int>, store_items> g)
			{
				return g.Count<store_items>() > 1;
			}

			// Token: 0x06004C19 RID: 19481 RVA: 0x00138184 File Offset: 0x00136384
			internal <>f__AnonymousType13<<>f__AnonymousType12<string, int, int>, List<store_items>> <ArticulDuplicatesRemove>b__8_2(IGrouping<<>f__AnonymousType12<string, int, int>, store_items> grp)
			{
				return new
				{
					groupId = grp.Key,
					gItems = grp.ToList<store_items>()
				};
			}

			// Token: 0x06004C1A RID: 19482 RVA: 0x001381A4 File Offset: 0x001363A4
			internal store_items <CreateProducts>b__10_0(Product it)
			{
				return it.BackToStoreItem();
			}

			// Token: 0x0400311D RID: 12573
			public static readonly ItemsModel.<>c <>9 = new ItemsModel.<>c();

			// Token: 0x0400311E RID: 12574
			public static Func<store_items, <>f__AnonymousType12<string, int, int>> <>9__8_0;

			// Token: 0x0400311F RID: 12575
			public static Func<IGrouping<<>f__AnonymousType12<string, int, int>, store_items>, bool> <>9__8_1;

			// Token: 0x04003120 RID: 12576
			public static Func<IGrouping<<>f__AnonymousType12<string, int, int>, store_items>, <>f__AnonymousType13<<>f__AnonymousType12<string, int, int>, List<store_items>>> <>9__8_2;

			// Token: 0x04003121 RID: 12577
			public static Func<Product, store_items> <>9__10_0;
		}

		// Token: 0x02000A04 RID: 2564
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadFireItems>d__4 : IAsyncStateMachine
		{
			// Token: 0x06004C1B RID: 19483 RVA: 0x001381B8 File Offset: 0x001363B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<store_items> result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<store_items>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_items>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((store_items i) => i.minimum_in_stock > 0 && i.count < i.minimum_in_stock && (!i.parts_request.Any<parts_request>() || i.parts_request.All((parts_request r) => r.state == 2)), null, "parts_request").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, ItemsModel.<LoadFireItems>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x06004C1C RID: 19484 RVA: 0x00138418 File Offset: 0x00136618
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003122 RID: 12578
			public int <>1__state;

			// Token: 0x04003123 RID: 12579
			public AsyncTaskMethodBuilder<IEnumerable<store_items>> <>t__builder;

			// Token: 0x04003124 RID: 12580
			private GenericRepository<store_items> <repo>5__2;

			// Token: 0x04003125 RID: 12581
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x02000A05 RID: 2565
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItemStates>d__7 : IAsyncStateMachine
		{
			// Token: 0x06004C1D RID: 19485 RVA: 0x00138434 File Offset: 0x00136634
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<items_state> result2;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<items_state>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<result>5__3 = new List<items_state>();
							if (this.includeAll)
							{
								this.<result>5__3.Add(new items_state
								{
									id = 0,
									name = Lang.t("All")
								});
							}
							awaiter = this.<ctx>5__2.items_state.AsNoTracking().ToListAsync<items_state>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<items_state>>.ConfiguredTaskAwaiter, ItemsModel.<LoadItemStates>d__7>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<items_state>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<items_state> result = awaiter.GetResult();
						this.<result>5__3.AddRange(result);
						result2 = this.<result>5__3;
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004C1E RID: 19486 RVA: 0x00138580 File Offset: 0x00136780
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003126 RID: 12582
			public int <>1__state;

			// Token: 0x04003127 RID: 12583
			public AsyncTaskMethodBuilder<List<items_state>> <>t__builder;

			// Token: 0x04003128 RID: 12584
			public bool includeAll;

			// Token: 0x04003129 RID: 12585
			private auseceEntities <ctx>5__2;

			// Token: 0x0400312A RID: 12586
			private List<items_state> <result>5__3;

			// Token: 0x0400312B RID: 12587
			private ConfiguredTaskAwaitable<List<items_state>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000A06 RID: 2566
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004C1F RID: 19487 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06004C20 RID: 19488 RVA: 0x0013859C File Offset: 0x0013679C
			internal bool <ArticulDuplicatesRemove>b__3(store_items i)
			{
				return i.id == this.item.id;
			}

			// Token: 0x0400312C RID: 12588
			public store_items item;
		}

		// Token: 0x02000A07 RID: 2567
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateProducts>d__10 : IAsyncStateMachine
		{
			// Token: 0x06004C21 RID: 19489 RVA: 0x001385BC File Offset: 0x001367BC
			void IAsyncStateMachine.MoveNext()
			{
				/*
An exception occurred when decompiling this method (06004C21)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ASC.Models.ItemsModel/<CreateProducts>d__10::MoveNext()

 ---> System.Exception: Inconsistent stack size at IL_B7
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06004C22 RID: 19490 RVA: 0x001386E4 File Offset: 0x001368E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400312D RID: 12589
			public int <>1__state;

			// Token: 0x0400312E RID: 12590
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400312F RID: 12591
			public List<Product> i;

			// Token: 0x04003130 RID: 12592
			public docs document;

			// Token: 0x04003131 RID: 12593
			public auseceEntities ctx;

			// Token: 0x04003132 RID: 12594
			public ItemsModel <>4__this;

			// Token: 0x04003133 RID: 12595
			public HistoryV2 history;

			// Token: 0x04003134 RID: 12596
			private List<store_items> <items>5__2;

			// Token: 0x04003135 RID: 12597
			private Boxes <boxesModel>5__3;

			// Token: 0x04003136 RID: 12598
			private int <index>5__4;

			// Token: 0x04003137 RID: 12599
			private IProductService <productService>5__5;

			// Token: 0x04003138 RID: 12600
			private List<store_items>.Enumerator <>7__wrap5;

			// Token: 0x04003139 RID: 12601
			private store_items <item>5__7;

			// Token: 0x0400313A RID: 12602
			private store_items <>7__wrap7;

			// Token: 0x0400313B RID: 12603
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000A08 RID: 2568
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06004C23 RID: 19491 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0400313C RID: 12604
			public List<int> ids;
		}

		// Token: 0x02000A09 RID: 2569
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RestoreItemsCount>d__13 : IAsyncStateMachine
		{
			// Token: 0x06004C24 RID: 19492 RVA: 0x00138700 File Offset: 0x00136900
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								DateTime serverUtcTime = Localization.GetServerUtcTime(this.<ctx>5__2);
								List<store_sales>.Enumerator enumerator = this.items.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										store_sales store_sales = enumerator.Current;
										store_items store_items = this.<ctx>5__2.store_items.Find(new object[]
										{
											store_sales.item_id
										});
										if (store_items != null)
										{
											store_items.count += store_sales.count;
											store_items.sold -= store_sales.count;
											store_items.updated = new DateTime?(serverUtcTime);
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
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ItemsModel.<RestoreItemsCount>d__13>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
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
						ItemsModel.Log.Error(exception, "Restore items count fail");
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004C25 RID: 19493 RVA: 0x001388F8 File Offset: 0x00136AF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400313D RID: 12605
			public int <>1__state;

			// Token: 0x0400313E RID: 12606
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400313F RID: 12607
			public List<store_sales> items;

			// Token: 0x04003140 RID: 12608
			private auseceEntities <ctx>5__2;

			// Token: 0x04003141 RID: 12609
			private TaskAwaiter<int> <>u__1;
		}
	}
}
