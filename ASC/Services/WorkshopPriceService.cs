using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Properties;
using ASC.SimpleClasses;
using Newtonsoft.Json;

namespace ASC.Services
{
	// Token: 0x020005FE RID: 1534
	public class WorkshopPriceService : IWorkshopPriceService
	{
		// Token: 0x06003775 RID: 14197 RVA: 0x000C0548 File Offset: 0x000BE748
		public Task<List<Category>> GetCategoriesAsync(int? vendorId, bool showArchive, bool includeAll = false)
		{
			WorkshopPriceService.<GetCategoriesAsync>d__0 <GetCategoriesAsync>d__;
			<GetCategoriesAsync>d__.<>t__builder = AsyncTaskMethodBuilder<List<Category>>.Create();
			<GetCategoriesAsync>d__.<>4__this = this;
			<GetCategoriesAsync>d__.vendorId = vendorId;
			<GetCategoriesAsync>d__.showArchive = showArchive;
			<GetCategoriesAsync>d__.includeAll = includeAll;
			<GetCategoriesAsync>d__.<>1__state = -1;
			<GetCategoriesAsync>d__.<>t__builder.Start<WorkshopPriceService.<GetCategoriesAsync>d__0>(ref <GetCategoriesAsync>d__);
			return <GetCategoriesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x000C05A4 File Offset: 0x000BE7A4
		private List<CategoryExpand> GetCategoriesExpandStateInfo()
		{
			if (string.IsNullOrEmpty(Settings.Default.PriceWorkCategoriesState))
			{
				return new List<CategoryExpand>();
			}
			return JsonConvert.DeserializeObject<List<CategoryExpand>>(Settings.Default.PriceWorkCategoriesState);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x000C05D8 File Offset: 0x000BE7D8
		public void UpdateCategoriesExpandState(IEnumerable<ICategory> c)
		{
			string priceWorkCategoriesState = JsonConvert.SerializeObject(new List<CategoryExpand>(from i in c
			select new CategoryExpand(i.Id, i.IsExpand)));
			Settings.Default.PriceWorkCategoriesState = priceWorkCategoriesState;
			Settings.Default.Save();
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x000C062C File Offset: 0x000BE82C
		private IEnumerable<workshop_cats> LoadChildrensCats(int categoryId)
		{
			IEnumerable<workshop_cats> result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				workshop_cats workshop_cats = auseceEntities.workshop_cats.FirstOrDefault((workshop_cats c) => c.id == categoryId);
				if (workshop_cats != null)
				{
					List<workshop_cats> list = new List<workshop_cats>
					{
						workshop_cats
					};
					foreach (workshop_cats workshop_cats2 in workshop_cats.workshop_cats1)
					{
						list.AddRange(this.LoadChildrensCats(workshop_cats2.id));
					}
					result = list;
				}
				else
				{
					result = new List<workshop_cats>();
				}
			}
			return result;
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x000C0744 File Offset: 0x000BE944
		public Task<List<workshop_price>> GetPriceItems(int? vendorId, int category)
		{
			WorkshopPriceService.<GetPriceItems>d__4 <GetPriceItems>d__;
			<GetPriceItems>d__.<>t__builder = AsyncTaskMethodBuilder<List<workshop_price>>.Create();
			<GetPriceItems>d__.<>4__this = this;
			<GetPriceItems>d__.vendorId = vendorId;
			<GetPriceItems>d__.category = category;
			<GetPriceItems>d__.<>1__state = -1;
			<GetPriceItems>d__.<>t__builder.Start<WorkshopPriceService.<GetPriceItems>d__4>(ref <GetPriceItems>d__);
			return <GetPriceItems>d__.<>t__builder.Task;
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x000C0798 File Offset: 0x000BE998
		public Task<bool> CreatePriceCategory(ICategory c)
		{
			WorkshopPriceService.<CreatePriceCategory>d__5 <CreatePriceCategory>d__;
			<CreatePriceCategory>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CreatePriceCategory>d__.c = c;
			<CreatePriceCategory>d__.<>1__state = -1;
			<CreatePriceCategory>d__.<>t__builder.Start<WorkshopPriceService.<CreatePriceCategory>d__5>(ref <CreatePriceCategory>d__);
			return <CreatePriceCategory>d__.<>t__builder.Task;
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x000C07DC File Offset: 0x000BE9DC
		public Task<bool> UpdatePriceCategory(ICategory c)
		{
			WorkshopPriceService.<UpdatePriceCategory>d__6 <UpdatePriceCategory>d__;
			<UpdatePriceCategory>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<UpdatePriceCategory>d__.c = c;
			<UpdatePriceCategory>d__.<>1__state = -1;
			<UpdatePriceCategory>d__.<>t__builder.Start<WorkshopPriceService.<UpdatePriceCategory>d__6>(ref <UpdatePriceCategory>d__);
			return <UpdatePriceCategory>d__.<>t__builder.Task;
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x000C0820 File Offset: 0x000BEA20
		public Task<bool> SaveCategoriesPosition(IEnumerable<ICategory> c)
		{
			WorkshopPriceService.<SaveCategoriesPosition>d__7 <SaveCategoriesPosition>d__;
			<SaveCategoriesPosition>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SaveCategoriesPosition>d__.c = c;
			<SaveCategoriesPosition>d__.<>1__state = -1;
			<SaveCategoriesPosition>d__.<>t__builder.Start<WorkshopPriceService.<SaveCategoriesPosition>d__7>(ref <SaveCategoriesPosition>d__);
			return <SaveCategoriesPosition>d__.<>t__builder.Task;
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x000046B4 File Offset: 0x000028B4
		public WorkshopPriceService()
		{
		}

		// Token: 0x020005FF RID: 1535
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x0600377E RID: 14206 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x04002055 RID: 8277
			public int? vendorId;
		}

		// Token: 0x02000600 RID: 1536
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_1
		{
			// Token: 0x0600377F RID: 14207 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_1()
			{
			}

			// Token: 0x06003780 RID: 14208 RVA: 0x000C0864 File Offset: 0x000BEA64
			internal bool <GetCategoriesAsync>b__5(CategoryExpand i)
			{
				return i.CategoryId == this.category.Id;
			}

			// Token: 0x04002056 RID: 8278
			public Category category;
		}

		// Token: 0x02000601 RID: 1537
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003781 RID: 14209 RVA: 0x000C0884 File Offset: 0x000BEA84
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003782 RID: 14210 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003783 RID: 14211 RVA: 0x000C089C File Offset: 0x000BEA9C
			internal Category <GetCategoriesAsync>b__0_3(workshop_cats c)
			{
				return c.ToCategory();
			}

			// Token: 0x06003784 RID: 14212 RVA: 0x000C08B0 File Offset: 0x000BEAB0
			internal int? <GetCategoriesAsync>b__0_4(Category c)
			{
				return c.Position;
			}

			// Token: 0x06003785 RID: 14213 RVA: 0x000C08C4 File Offset: 0x000BEAC4
			internal CategoryExpand <UpdateCategoriesExpandState>b__2_0(ICategory i)
			{
				return new CategoryExpand(i.Id, i.IsExpand);
			}

			// Token: 0x06003786 RID: 14214 RVA: 0x000C08E4 File Offset: 0x000BEAE4
			internal int <GetPriceItems>b__4_0(workshop_cats c)
			{
				return c.id;
			}

			// Token: 0x04002057 RID: 8279
			public static readonly WorkshopPriceService.<>c <>9 = new WorkshopPriceService.<>c();

			// Token: 0x04002058 RID: 8280
			public static Func<workshop_cats, Category> <>9__0_3;

			// Token: 0x04002059 RID: 8281
			public static Func<Category, int?> <>9__0_4;

			// Token: 0x0400205A RID: 8282
			public static Func<ICategory, CategoryExpand> <>9__2_0;

			// Token: 0x0400205B RID: 8283
			public static Func<workshop_cats, int> <>9__4_0;
		}

		// Token: 0x02000602 RID: 1538
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCategoriesAsync>d__0 : IAsyncStateMachine
		{
			// Token: 0x06003787 RID: 14215 RVA: 0x000C08F8 File Offset: 0x000BEAF8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopPriceService workshopPriceService = this.<>4__this;
				List<Category> result;
				try
				{
					WorkshopPriceService.<>c__DisplayClass0_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopPriceService.<>c__DisplayClass0_0();
						CS$<>8__locals1.vendorId = this.vendorId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<workshop_cats>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							IQueryable<workshop_cats> source = this.<ctx>5__2.workshop_cats.AsNoTracking().AsQueryable<workshop_cats>();
							if (!this.showArchive)
							{
								source = from i in source
								where i.archive == false
								select i;
							}
							int? num2 = CS$<>8__locals1.vendorId;
							source = ((num2.GetValueOrDefault() > 0 & num2 != null) ? (from i in source
							where i.vendor_id == CS$<>8__locals1.vendorId
							select i) : source.Where((workshop_cats i) => i.vendor_id == null));
							awaiter = source.ToListAsync<workshop_cats>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<workshop_cats>>.ConfiguredTaskAwaiter, WorkshopPriceService.<GetCategoriesAsync>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<workshop_cats>>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						List<Category> list = new List<Category>(awaiter.GetResult().Select(new Func<workshop_cats, Category>(WorkshopPriceService.<>c.<>9.<GetCategoriesAsync>b__0_3)).OrderBy(new Func<Category, int?>(WorkshopPriceService.<>c.<>9.<GetCategoriesAsync>b__0_4)).ToList<Category>());
						List<CategoryExpand> categoriesExpandStateInfo = workshopPriceService.GetCategoriesExpandStateInfo();
						List<Category>.Enumerator enumerator = list.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								WorkshopPriceService.<>c__DisplayClass0_1 CS$<>8__locals2 = new WorkshopPriceService.<>c__DisplayClass0_1();
								CS$<>8__locals2.category = enumerator.Current;
								CategoryExpand categoryExpand = categoriesExpandStateInfo.FirstOrDefault(new Func<CategoryExpand, bool>(CS$<>8__locals2.<GetCategoriesAsync>b__5));
								CS$<>8__locals2.category.IsExpand = (categoryExpand == null || categoryExpand.IsExpand);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						if (this.includeAll)
						{
							list.Insert(0, new Category
							{
								Id = 0,
								Name = (string)Application.Current.TryFindResource("AllCategories")
							});
						}
						result = list;
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

			// Token: 0x06003788 RID: 14216 RVA: 0x000C0CA8 File Offset: 0x000BEEA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400205C RID: 8284
			public int <>1__state;

			// Token: 0x0400205D RID: 8285
			public AsyncTaskMethodBuilder<List<Category>> <>t__builder;

			// Token: 0x0400205E RID: 8286
			public int? vendorId;

			// Token: 0x0400205F RID: 8287
			public bool showArchive;

			// Token: 0x04002060 RID: 8288
			public WorkshopPriceService <>4__this;

			// Token: 0x04002061 RID: 8289
			public bool includeAll;

			// Token: 0x04002062 RID: 8290
			private auseceEntities <ctx>5__2;

			// Token: 0x04002063 RID: 8291
			private ConfiguredTaskAwaitable<List<workshop_cats>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000603 RID: 1539
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003789 RID: 14217 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04002064 RID: 8292
			public int categoryId;
		}

		// Token: 0x02000604 RID: 1540
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600378A RID: 14218 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002065 RID: 8293
			public int? vendorId;

			// Token: 0x04002066 RID: 8294
			public List<int> ids;
		}

		// Token: 0x02000605 RID: 1541
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPriceItems>d__4 : IAsyncStateMachine
		{
			// Token: 0x0600378B RID: 14219 RVA: 0x000C0CC4 File Offset: 0x000BEEC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkshopPriceService workshopPriceService = this.<>4__this;
				List<workshop_price> result;
				try
				{
					WorkshopPriceService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new WorkshopPriceService.<>c__DisplayClass4_0();
						CS$<>8__locals1.vendorId = this.vendorId;
						IEnumerable<workshop_cats> source = workshopPriceService.LoadChildrensCats(this.category);
						CS$<>8__locals1.ids = source.Select(new Func<workshop_cats, int>(WorkshopPriceService.<>c.<>9.<GetPriceItems>b__4_0)).ToList<int>();
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<workshop_price>> awaiter;
						if (num != 0)
						{
							IQueryable<workshop_price> source2 = from i in this.<ctx>5__2.workshop_price.AsNoTracking()
							where i.enable
							select i;
							int? num2 = CS$<>8__locals1.vendorId;
							source2 = ((num2.GetValueOrDefault() > 0 & num2 != null) ? (from i in source2
							where i.vendor_id == CS$<>8__locals1.vendorId
							select i) : source2.Where((workshop_price i) => i.vendor_id == null));
							if (this.category > 0)
							{
								source2 = from i in source2
								where CS$<>8__locals1.ids.Contains(i.category)
								select i;
							}
							awaiter = source2.ToListAsync<workshop_price>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop_price>>, WorkshopPriceService.<GetPriceItems>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<workshop_price>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
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

			// Token: 0x0600378C RID: 14220 RVA: 0x000C0FF0 File Offset: 0x000BF1F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002067 RID: 8295
			public int <>1__state;

			// Token: 0x04002068 RID: 8296
			public AsyncTaskMethodBuilder<List<workshop_price>> <>t__builder;

			// Token: 0x04002069 RID: 8297
			public int? vendorId;

			// Token: 0x0400206A RID: 8298
			public WorkshopPriceService <>4__this;

			// Token: 0x0400206B RID: 8299
			public int category;

			// Token: 0x0400206C RID: 8300
			private auseceEntities <ctx>5__2;

			// Token: 0x0400206D RID: 8301
			private TaskAwaiter<List<workshop_price>> <>u__1;
		}

		// Token: 0x02000606 RID: 1542
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreatePriceCategory>d__5 : IAsyncStateMachine
		{
			// Token: 0x0600378D RID: 14221 RVA: 0x000C100C File Offset: 0x000BF20C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result;
				try
				{
					workshop_cats entity;
					if (num != 0)
					{
						entity = new workshop_cats
						{
							name = this.c.Name,
							parent = this.c.Parent,
							archive = false,
							ico = this.c.Icon,
							vendor_id = this.c.VendorId
						};
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<ctx>5__2.workshop_cats.Add(entity);
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkshopPriceService.<CreatePriceCategory>d__5>(ref awaiter, ref this);
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
					result = true;
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

			// Token: 0x0600378E RID: 14222 RVA: 0x000C1164 File Offset: 0x000BF364
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400206E RID: 8302
			public int <>1__state;

			// Token: 0x0400206F RID: 8303
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002070 RID: 8304
			public ICategory c;

			// Token: 0x04002071 RID: 8305
			private auseceEntities <ctx>5__2;

			// Token: 0x04002072 RID: 8306
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000607 RID: 1543
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdatePriceCategory>d__6 : IAsyncStateMachine
		{
			// Token: 0x0600378F RID: 14223 RVA: 0x000C1180 File Offset: 0x000BF380
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<workshop_cats> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.workshop_cats.FindAsync(new object[]
							{
								this.c.Id
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop_cats>, WorkshopPriceService.<UpdatePriceCategory>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<workshop_cats>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						workshop_cats result = awaiter.GetResult();
						result.name = this.c.Name;
						result.parent = this.c.Parent;
						result.archive = this.c.Archive;
						result.ico = this.c.Icon;
						result.vendor_id = this.c.VendorId;
						this.<ctx>5__2.SaveChanges();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
					result2 = true;
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

			// Token: 0x06003790 RID: 14224 RVA: 0x000C130C File Offset: 0x000BF50C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002073 RID: 8307
			public int <>1__state;

			// Token: 0x04002074 RID: 8308
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002075 RID: 8309
			public ICategory c;

			// Token: 0x04002076 RID: 8310
			private auseceEntities <ctx>5__2;

			// Token: 0x04002077 RID: 8311
			private TaskAwaiter<workshop_cats> <>u__1;
		}

		// Token: 0x02000608 RID: 1544
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003791 RID: 14225 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04002078 RID: 8312
			public ICategory cc;
		}

		// Token: 0x02000609 RID: 1545
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveCategoriesPosition>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003792 RID: 14226 RVA: 0x000C1328 File Offset: 0x000BF528
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result2;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2.Configuration.ProxyCreationEnabled = false;
							this.<>7__wrap2 = this.c.GetEnumerator();
						}
						try
						{
							TaskAwaiter<workshop_cats> awaiter;
							if (num == 0)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop_cats>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_162;
							}
							IL_94:
							if (!this.<>7__wrap2.MoveNext())
							{
								goto IL_1AF;
							}
							this.<>8__1 = new WorkshopPriceService.<>c__DisplayClass7_0();
							this.<>8__1.cc = this.<>7__wrap2.Current;
							awaiter = (from i in this.<ctx>5__2.workshop_cats
							where i.id == this.<>8__1.cc.Id
							select i).FirstOrDefaultAsync<workshop_cats>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop_cats>, WorkshopPriceService.<SaveCategoriesPosition>d__7>(ref awaiter, ref this);
								return;
							}
							IL_162:
							workshop_cats result = awaiter.GetResult();
							if (result != null)
							{
								result.parent = this.<>8__1.cc.Parent;
								result.position = this.<>8__1.cc.Position;
							}
							this.<>8__1 = null;
							goto IL_94;
						}
						finally
						{
							if (num < 0 && this.<>7__wrap2 != null)
							{
								this.<>7__wrap2.Dispose();
							}
						}
						IL_1AF:
						this.<>7__wrap2 = null;
						this.<ctx>5__2.SaveChanges();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
					result2 = true;
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

			// Token: 0x06003793 RID: 14227 RVA: 0x000C1598 File Offset: 0x000BF798
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002079 RID: 8313
			public int <>1__state;

			// Token: 0x0400207A RID: 8314
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400207B RID: 8315
			public IEnumerable<ICategory> c;

			// Token: 0x0400207C RID: 8316
			private WorkshopPriceService.<>c__DisplayClass7_0 <>8__1;

			// Token: 0x0400207D RID: 8317
			private auseceEntities <ctx>5__2;

			// Token: 0x0400207E RID: 8318
			private IEnumerator<ICategory> <>7__wrap2;

			// Token: 0x0400207F RID: 8319
			private TaskAwaiter<workshop_cats> <>u__1;
		}
	}
}
