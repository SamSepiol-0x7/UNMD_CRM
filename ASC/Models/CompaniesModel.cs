using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using NLog;

namespace ASC.Models
{
	// Token: 0x020009F1 RID: 2545
	public class CompaniesModel
	{
		// Token: 0x06004BCB RID: 19403 RVA: 0x00136244 File Offset: 0x00134444
		public static Task<List<Company>> LoadCompanies()
		{
			CompaniesModel.<LoadCompanies>d__1 <LoadCompanies>d__;
			<LoadCompanies>d__.<>t__builder = AsyncTaskMethodBuilder<List<Company>>.Create();
			<LoadCompanies>d__.<>1__state = -1;
			<LoadCompanies>d__.<>t__builder.Start<CompaniesModel.<LoadCompanies>d__1>(ref <LoadCompanies>d__);
			return <LoadCompanies>d__.<>t__builder.Task;
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x00136280 File Offset: 0x00134480
		public static Company GetCompany(int companyId)
		{
			Company result;
			using (GenericRepository<companies> genericRepository = new GenericRepository<companies>())
			{
				genericRepository.AsNoTracking();
				result = genericRepository.GetFirstOrDefault((companies c) => c.id == companyId, "users1").ToCompany();
			}
			return result;
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x00136334 File Offset: 0x00134534
		public static Task<List<companies>> LoadCompaniesAllFields(bool showArchive = false, string includeProperties = null)
		{
			CompaniesModel.<LoadCompaniesAllFields>d__3 <LoadCompaniesAllFields>d__;
			<LoadCompaniesAllFields>d__.<>t__builder = AsyncTaskMethodBuilder<List<companies>>.Create();
			<LoadCompaniesAllFields>d__.showArchive = showArchive;
			<LoadCompaniesAllFields>d__.includeProperties = includeProperties;
			<LoadCompaniesAllFields>d__.<>1__state = -1;
			<LoadCompaniesAllFields>d__.<>t__builder.Start<CompaniesModel.<LoadCompaniesAllFields>d__3>(ref <LoadCompaniesAllFields>d__);
			return <LoadCompaniesAllFields>d__.<>t__builder.Task;
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x00136380 File Offset: 0x00134580
		public static Task<companies> LoadCompany(int companyId)
		{
			CompaniesModel.<LoadCompany>d__4 <LoadCompany>d__;
			<LoadCompany>d__.<>t__builder = AsyncTaskMethodBuilder<companies>.Create();
			<LoadCompany>d__.companyId = companyId;
			<LoadCompany>d__.<>1__state = -1;
			<LoadCompany>d__.<>t__builder.Start<CompaniesModel.<LoadCompany>d__4>(ref <LoadCompany>d__);
			return <LoadCompany>d__.<>t__builder.Task;
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x001363C4 File Offset: 0x001345C4
		public static IOffice GetOffice(int officeId)
		{
			IOffice result;
			using (GenericRepository<offices> genericRepository = new GenericRepository<offices>())
			{
				genericRepository.AsNoTracking();
				result = genericRepository.GetFirstOrDefault((offices c) => c.id == officeId, "").ToOffice();
			}
			return result;
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00136478 File Offset: 0x00134678
		public static bool CreateOrUpdateCompany(companies company)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					if (company.id == 0)
					{
						company.status = true;
						auseceEntities.companies.Add(company);
					}
					else
					{
						companies entity = auseceEntities.companies.Find(new object[]
						{
							company.id
						});
						auseceEntities.Entry<companies>(entity).CurrentValues.SetValues(company);
					}
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception ex)
			{
				CompaniesModel.Log.Error(ex, ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00136524 File Offset: 0x00134724
		public static Task<IEnumerable<SellerPaymentDetails>> GetCompanyPaymentDetails(int? companyId = null)
		{
			CompaniesModel.<GetCompanyPaymentDetails>d__7 <GetCompanyPaymentDetails>d__;
			<GetCompanyPaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<SellerPaymentDetails>>.Create();
			<GetCompanyPaymentDetails>d__.companyId = companyId;
			<GetCompanyPaymentDetails>d__.<>1__state = -1;
			<GetCompanyPaymentDetails>d__.<>t__builder.Start<CompaniesModel.<GetCompanyPaymentDetails>d__7>(ref <GetCompanyPaymentDetails>d__);
			return <GetCompanyPaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00136568 File Offset: 0x00134768
		public static List<KeyValuePair<int, string>> GetCompanyTypes()
		{
			return new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(0, Lang.t("Ooo")),
				new KeyValuePair<int, string>(1, Lang.t("Ipred")),
				new KeyValuePair<int, string>(2, Lang.t("Ppred"))
			};
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x000046B4 File Offset: 0x000028B4
		public CompaniesModel()
		{
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x001365BC File Offset: 0x001347BC
		// Note: this type is marked as 'beforefieldinit'.
		static CompaniesModel()
		{
		}

		// Token: 0x040030E1 RID: 12513
		public static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x020009F2 RID: 2546
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004BD5 RID: 19413 RVA: 0x001365D4 File Offset: 0x001347D4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004BD6 RID: 19414 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004BD7 RID: 19415 RVA: 0x001365EC File Offset: 0x001347EC
			internal IOrderedQueryable<companies> <LoadCompaniesAllFields>b__3_0(IQueryable<companies> c)
			{
				return from d in c
				orderby d.name
				select d;
			}

			// Token: 0x06004BD8 RID: 19416 RVA: 0x001365EC File Offset: 0x001347EC
			internal IOrderedQueryable<companies> <LoadCompaniesAllFields>b__3_3(IQueryable<companies> c)
			{
				return from d in c
				orderby d.name
				select d;
			}

			// Token: 0x06004BD9 RID: 19417 RVA: 0x00136638 File Offset: 0x00134838
			internal SellerPaymentDetails <GetCompanyPaymentDetails>b__7_0(banks b)
			{
				return b.BankToSellerPaymentDetails();
			}

			// Token: 0x040030E2 RID: 12514
			public static readonly CompaniesModel.<>c <>9 = new CompaniesModel.<>c();

			// Token: 0x040030E3 RID: 12515
			public static Func<IQueryable<companies>, IOrderedQueryable<companies>> <>9__3_0;

			// Token: 0x040030E4 RID: 12516
			public static Func<IQueryable<companies>, IOrderedQueryable<companies>> <>9__3_3;

			// Token: 0x040030E5 RID: 12517
			public static Func<banks, SellerPaymentDetails> <>9__7_0;
		}

		// Token: 0x020009F3 RID: 2547
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCompanies>d__1 : IAsyncStateMachine
		{
			// Token: 0x06004BDA RID: 19418 RVA: 0x0013664C File Offset: 0x0013484C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<Company> result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(false);
						}
						try
						{
							TaskAwaiter<List<Company>> awaiter;
							if (num != 0)
							{
								awaiter = (from c in this.<ctx>5__2.companies.AsNoTracking()
								where c.status
								select c).Select(CompanyConverters.CompaniesSelector()).ToListAsync<Company>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Company>>, CompaniesModel.<LoadCompanies>d__1>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<Company>>);
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
						CompaniesModel.Log.Error(exception, "Load companies fail");
						result = new List<Company>();
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

			// Token: 0x06004BDB RID: 19419 RVA: 0x001367B4 File Offset: 0x001349B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040030E6 RID: 12518
			public int <>1__state;

			// Token: 0x040030E7 RID: 12519
			public AsyncTaskMethodBuilder<List<Company>> <>t__builder;

			// Token: 0x040030E8 RID: 12520
			private auseceEntities <ctx>5__2;

			// Token: 0x040030E9 RID: 12521
			private TaskAwaiter<List<Company>> <>u__1;
		}

		// Token: 0x020009F4 RID: 2548
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06004BDC RID: 19420 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x040030EA RID: 12522
			public int companyId;
		}

		// Token: 0x020009F5 RID: 2549
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCompaniesAllFields>d__3 : IAsyncStateMachine
		{
			// Token: 0x06004BDD RID: 19421 RVA: 0x001367D0 File Offset: 0x001349D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<companies> result;
				try
				{
					if (num > 1)
					{
						this.<repo>5__2 = new GenericRepository<companies>();
					}
					try
					{
						TaskAwaiter<IEnumerable<companies>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<IEnumerable<companies>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
							}
							else if (this.showArchive)
							{
								awaiter = this.<repo>5__2.GetAllAsync(null, new Func<IQueryable<companies>, IOrderedQueryable<companies>>(CompaniesModel.<>c.<>9.<LoadCompaniesAllFields>b__3_0), this.includeProperties).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<companies>>, CompaniesModel.<LoadCompaniesAllFields>d__3>(ref awaiter, ref this);
									return;
								}
								goto IL_173;
							}
							else
							{
								awaiter = this.<repo>5__2.GetAllAsync((companies c) => c.status, new Func<IQueryable<companies>, IOrderedQueryable<companies>>(CompaniesModel.<>c.<>9.<LoadCompaniesAllFields>b__3_3), this.includeProperties).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num4 = 1;
									num = 1;
									this.<>1__state = num4;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<companies>>, CompaniesModel.<LoadCompaniesAllFields>d__3>(ref awaiter, ref this);
									return;
								}
							}
							result = new List<companies>(awaiter.GetResult());
							goto IL_1B3;
						}
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<companies>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						IL_173:
						result = new List<companies>(awaiter.GetResult());
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
				IL_1B3:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004BDE RID: 19422 RVA: 0x001369D8 File Offset: 0x00134BD8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040030EB RID: 12523
			public int <>1__state;

			// Token: 0x040030EC RID: 12524
			public AsyncTaskMethodBuilder<List<companies>> <>t__builder;

			// Token: 0x040030ED RID: 12525
			public bool showArchive;

			// Token: 0x040030EE RID: 12526
			public string includeProperties;

			// Token: 0x040030EF RID: 12527
			private GenericRepository<companies> <repo>5__2;

			// Token: 0x040030F0 RID: 12528
			private TaskAwaiter<IEnumerable<companies>> <>u__1;
		}

		// Token: 0x020009F6 RID: 2550
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004BDF RID: 19423 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040030F1 RID: 12529
			public int companyId;
		}

		// Token: 0x020009F7 RID: 2551
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCompany>d__4 : IAsyncStateMachine
		{
			// Token: 0x06004BE0 RID: 19424 RVA: 0x001369F4 File Offset: 0x00134BF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				companies result;
				try
				{
					CompaniesModel.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CompaniesModel.<>c__DisplayClass4_0();
						CS$<>8__locals1.companyId = this.companyId;
						this.<repo>5__2 = new GenericRepository<companies>();
					}
					try
					{
						TaskAwaiter<companies> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((companies c) => c.id == CS$<>8__locals1.companyId, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<companies>, CompaniesModel.<LoadCompany>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<companies>);
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

			// Token: 0x06004BE1 RID: 19425 RVA: 0x00136B70 File Offset: 0x00134D70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040030F2 RID: 12530
			public int <>1__state;

			// Token: 0x040030F3 RID: 12531
			public AsyncTaskMethodBuilder<companies> <>t__builder;

			// Token: 0x040030F4 RID: 12532
			public int companyId;

			// Token: 0x040030F5 RID: 12533
			private GenericRepository<companies> <repo>5__2;

			// Token: 0x040030F6 RID: 12534
			private TaskAwaiter<companies> <>u__1;
		}

		// Token: 0x020009F8 RID: 2552
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004BE2 RID: 19426 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040030F7 RID: 12535
			public int officeId;
		}

		// Token: 0x020009F9 RID: 2553
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004BE3 RID: 19427 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x040030F8 RID: 12536
			public int? companyId;
		}

		// Token: 0x020009FA RID: 2554
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCompanyPaymentDetails>d__7 : IAsyncStateMachine
		{
			// Token: 0x06004BE4 RID: 19428 RVA: 0x00136B8C File Offset: 0x00134D8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<SellerPaymentDetails> result;
				try
				{
					CompaniesModel.<>c__DisplayClass7_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new CompaniesModel.<>c__DisplayClass7_0();
						CS$<>8__locals1.companyId = this.companyId;
						this.<repo>5__2 = new GenericRepository<banks>();
					}
					try
					{
						TaskAwaiter<IEnumerable<banks>> awaiter;
						List<banks> list;
						if (num != 0)
						{
							if (num != 1)
							{
								if (CS$<>8__locals1.companyId == null)
								{
									awaiter = this.<repo>5__2.GetAllAsync((banks b) => b.company != null && !b.archive && b.companies.status, null, "companies").GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num2 = 0;
										num = 0;
										this.<>1__state = num2;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<banks>>, CompaniesModel.<GetCompanyPaymentDetails>d__7>(ref awaiter, ref this);
										return;
									}
									goto IL_24B;
								}
								else
								{
									awaiter = this.<repo>5__2.GetAllAsync((banks b) => b.company == CS$<>8__locals1.companyId && !b.archive, null, "companies").GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num3 = 1;
										num = 1;
										this.<>1__state = num3;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<banks>>, CompaniesModel.<GetCompanyPaymentDetails>d__7>(ref awaiter, ref this);
										return;
									}
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<IEnumerable<banks>>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							list = new List<banks>(awaiter.GetResult());
							goto IL_259;
						}
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<banks>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						IL_24B:
						list = new List<banks>(awaiter.GetResult());
						IL_259:
						List<banks> source = list;
						if (source.Any<banks>())
						{
							result = source.Select(new Func<banks, SellerPaymentDetails>(CompaniesModel.<>c.<>9.<GetCompanyPaymentDetails>b__7_0)).ToList<SellerPaymentDetails>();
						}
						else
						{
							result = new List<SellerPaymentDetails>();
						}
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

			// Token: 0x06004BE5 RID: 19429 RVA: 0x00136EAC File Offset: 0x001350AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040030F9 RID: 12537
			public int <>1__state;

			// Token: 0x040030FA RID: 12538
			public AsyncTaskMethodBuilder<IEnumerable<SellerPaymentDetails>> <>t__builder;

			// Token: 0x040030FB RID: 12539
			public int? companyId;

			// Token: 0x040030FC RID: 12540
			private GenericRepository<banks> <repo>5__2;

			// Token: 0x040030FD RID: 12541
			private TaskAwaiter<IEnumerable<banks>> <>u__1;
		}
	}
}
