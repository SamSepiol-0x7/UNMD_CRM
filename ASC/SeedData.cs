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
using ASC.Options;
using ASC.Services.Abstract;
using Newtonsoft.Json;

namespace ASC
{
	// Token: 0x0200001F RID: 31
	public class SeedData : ISeedData
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00004F8C File Offset: 0x0000318C
		public SeedData(IContextFactory contextFactory, ILoggerService<SeedData> loggerService, WorkshopOptions workshopOptions)
		{
			this._contextFactory = contextFactory;
			this._loggerService = loggerService;
			this._workshopOptions = workshopOptions;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004FB4 File Offset: 0x000031B4
		public Task Seed(IList<string> executedScripts)
		{
			SeedData.<Seed>d__4 <Seed>d__;
			<Seed>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Seed>d__.<>4__this = this;
			<Seed>d__.executedScripts = executedScripts;
			<Seed>d__.<>1__state = -1;
			<Seed>d__.<>t__builder.Start<SeedData.<Seed>d__4>(ref <Seed>d__);
			return <Seed>d__.<>t__builder.Task;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005000 File Offset: 0x00003200
		private int GetAclIdByStatus(int statusId)
		{
			if (statusId == 0)
			{
				goto IL_7A;
			}
			goto IL_2A4;
			int num;
			for (;;)
			{
				IL_1F9:
				switch ((num ^ 954518157) % 35)
				{
				case 0:
					return 34;
				case 1:
					return 36;
				case 2:
					return 37;
				case 3:
					num = ((statusId == 4) ? 743914991 : 600512204);
					continue;
				case 4:
					return 27;
				case 5:
					num = ((statusId == 8) ? 527672653 : 1578556772);
					continue;
				case 6:
					return 26;
				case 7:
					num = ((statusId != 13) ? 588665449 : 71008724);
					continue;
				case 8:
					num = ((statusId != 6) ? 830957414 : 277297647);
					continue;
				case 9:
					num = ((statusId != 5) ? 1950765299 : 58026311);
					continue;
				case 10:
					return 35;
				case 11:
					num = ((statusId != 3) ? 415634306 : 1702330622);
					continue;
				case 12:
					num = ((statusId != 16) ? 182788750 : 501507575);
					continue;
				case 13:
					num = ((statusId != 10) ? 807823584 : 1165331945);
					continue;
				case 14:
					return 29;
				case 15:
					num = ((statusId == 9) ? 477928516 : 1694574523);
					continue;
				case 16:
					num = ((statusId != 12) ? 2110304260 : 156844594);
					continue;
				case 17:
					goto IL_2A4;
				case 18:
					return 34;
				case 19:
					return 64;
				case 20:
					return 32;
				case 21:
					num = ((statusId == 7) ? 489972010 : 1830253930);
					continue;
				case 22:
					return 27;
				case 23:
					return 33;
				case 24:
					num = ((statusId != 14) ? 500700345 : 533410176);
					continue;
				case 25:
					goto IL_7A;
				case 26:
					num = ((statusId != 2) ? 1413721082 : 254512172);
					continue;
				case 27:
					return 27;
				case 28:
					return 28;
				case 29:
					return 30;
				case 30:
					return 53;
				case 32:
					num = ((statusId == 15) ? 1662108881 : 755128770);
					continue;
				case 33:
					num = ((statusId != 11) ? 1838370301 : 1253567388);
					continue;
				case 34:
					return 31;
				}
				break;
			}
			return 0;
			IL_7A:
			num = 728976188;
			goto IL_1F9;
			IL_2A4:
			num = ((statusId == 1) ? 446408818 : 1333997235);
			goto IL_1F9;
		}

		// Token: 0x04000065 RID: 101
		private readonly IContextFactory _contextFactory;

		// Token: 0x04000066 RID: 102
		private readonly ILoggerService<SeedData> _loggerService;

		// Token: 0x04000067 RID: 103
		private readonly WorkshopOptions _workshopOptions;

		// Token: 0x02000020 RID: 32
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06000103 RID: 259 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04000068 RID: 104
			public int aclId;
		}

		// Token: 0x02000021 RID: 33
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000104 RID: 260 RVA: 0x000052F0 File Offset: 0x000034F0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06000105 RID: 261 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06000106 RID: 262 RVA: 0x00005308 File Offset: 0x00003508
			internal bool <Seed>b__4_0(string i)
			{
				return i.Contains("Script000294");
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00005320 File Offset: 0x00003520
			internal bool <Seed>b__4_1(string i)
			{
				return i.Contains("Script000304");
			}

			// Token: 0x04000069 RID: 105
			public static readonly SeedData.<>c <>9 = new SeedData.<>c();

			// Token: 0x0400006A RID: 106
			public static Func<string, bool> <>9__4_0;

			// Token: 0x0400006B RID: 107
			public static Func<string, bool> <>9__4_1;
		}

		// Token: 0x02000022 RID: 34
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Seed>d__4 : IAsyncStateMachine
		{
			// Token: 0x06000108 RID: 264 RVA: 0x00005338 File Offset: 0x00003538
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SeedData seedData = this.<>4__this;
				try
				{
					if (num > 3)
					{
						if (num - 4 <= 1)
						{
							goto IL_4D2;
						}
						if (!this.executedScripts.Any(new Func<string, bool>(SeedData.<>c.<>9.<Seed>b__4_0)))
						{
							goto IL_492;
						}
						this.<ctx>5__2 = seedData._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<config> awaiter;
						TaskAwaiter<int> awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<config>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
							IL_151:
							try
							{
								TaskAwaiter<List<int>> awaiter2;
								if (num == 1)
								{
									awaiter2 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<List<int>>);
									int num3 = -1;
									num = -1;
									this.<>1__state = num3;
									goto IL_178;
								}
								IL_1E6:
								while (this.<>7__wrap4.MoveNext())
								{
									this.<status>5__6 = this.<>7__wrap4.Current;
									SeedData.<>c__DisplayClass4_0 CS$<>8__locals1 = new SeedData.<>c__DisplayClass4_0();
									CS$<>8__locals1.aclId = seedData.GetAclIdByStatus(this.<status>5__6.Id);
									if (CS$<>8__locals1.aclId != 0)
									{
										awaiter2 = (from i in this.<ctx>5__2.permissions_roles
										where i.permission_id == CS$<>8__locals1.aclId
										select i.role_id).Distinct<int>().ToListAsync<int>().GetAwaiter();
										if (awaiter2.IsCompleted)
										{
											goto IL_178;
										}
										int num4 = 1;
										num = 1;
										this.<>1__state = num4;
										this.<>u__2 = awaiter2;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, SeedData.<Seed>d__4>(ref awaiter2, ref this);
										return;
									}
								}
								goto IL_30B;
								IL_178:
								List<int> result = awaiter2.GetResult();
								WorkshopOptions workshopOptions = this.<status>5__6;
								List<int> roles;
								if (!result.Any<int>())
								{
									(roles = new List<int>()).Add(1);
								}
								else
								{
									roles = new List<int>(result);
								}
								workshopOptions.Roles = roles;
								this.<status>5__6 = null;
								goto IL_1E6;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)this.<>7__wrap4).Dispose();
								}
							}
							IL_30B:
							this.<>7__wrap4 = default(List<WorkshopOptions>.Enumerator);
							awaiter = this.<ctx>5__2.config.SingleAsync((config c) => c.id == 1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 2;
								num = 2;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<config>, SeedData.<Seed>d__4>(ref awaiter, ref this);
								return;
							}
							goto IL_3C8;
						case 2:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<config>);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_3C8;
						}
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter<int>);
							int num7 = -1;
							num = -1;
							this.<>1__state = num7;
							goto IL_44B;
						}
						default:
							awaiter = this.<ctx>5__2.config.SingleAsync((config c) => c.id == 1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num8 = 0;
								num = 0;
								this.<>1__state = num8;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<config>, SeedData.<Seed>d__4>(ref awaiter, ref this);
								return;
							}
							break;
						}
						Auth.Config = awaiter.GetResult();
						this.<statuses>5__3 = seedData._workshopOptions.GetAllOptions();
						this.<>7__wrap4 = this.<statuses>5__3.GetEnumerator();
						goto IL_151;
						IL_3C8:
						config result2 = awaiter.GetResult();
						this.<config>5__4 = result2;
						this.<config>5__4.statuses = JsonConvert.SerializeObject(this.<statuses>5__3);
						awaiter3 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num9 = 3;
							num = 3;
							this.<>1__state = num9;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SeedData.<Seed>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_44B:
						awaiter3.GetResult();
						Auth.Config = this.<config>5__4;
						WorkshopOptions.RefreshConfig();
						this.<statuses>5__3 = null;
						this.<config>5__4 = null;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
					IL_492:
					if (!this.executedScripts.Any(new Func<string, bool>(SeedData.<>c.<>9.<Seed>b__4_1)))
					{
						goto IL_7F8;
					}
					this.<ctx>5__2 = seedData._contextFactory.Create();
					IL_4D2:
					try
					{
						TaskAwaiter<int> awaiter3;
						var awaiter4;
						if (num != 4)
						{
							if (num == 5)
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<int>);
								int num10 = -1;
								num = -1;
								this.<>1__state = num10;
								goto IL_7AE;
							}
							awaiter4 = (from i in this.<ctx>5__2.users
							where i.state == (int?)1
							select new
							{
								i.id,
								i.created,
								i.salary_rate
							}).ToListAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								int num11 = 4;
								num = 4;
								this.<>1__state = num11;
								this.<>u__4 = awaiter4;
								this.<>t__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
						}
						else
						{
							awaiter4 = this.<>u__4;
							this.<>u__4 = default(TaskAwaiter<List<<>f__AnonymousType0<int, DateTime?, int?>>>);
							int num12 = -1;
							num = -1;
							this.<>1__state = num12;
						}
						var result3 = awaiter4.GetResult();
						DateTime serverUtcTime = Localization.GetServerUtcTime(this.<ctx>5__2);
						var enumerator = result3.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								var <>f__AnonymousType = enumerator.Current;
								DbSet<SalaryRate> salaryRates = this.<ctx>5__2.SalaryRates;
								SalaryRate salaryRate = new SalaryRate();
								salaryRate.CreatedAt = serverUtcTime;
								DateTime? created = <>f__AnonymousType.created;
								int year = (created != null) ? created.GetValueOrDefault().Year : serverUtcTime.Year;
								created = <>f__AnonymousType.created;
								salaryRate.StartFrom = new DateTime(year, (created != null) ? created.GetValueOrDefault().Month : serverUtcTime.Month, 1);
								salaryRate.UserId = <>f__AnonymousType.id;
								salaryRate.Value = <>f__AnonymousType.salary_rate.GetValueOrDefault();
								salaryRates.Add(salaryRate);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						awaiter3 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num13 = 5;
							num = 5;
							this.<>1__state = num13;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SeedData.<Seed>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_7AE:
						awaiter3.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
					IL_7F8:;
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

			// Token: 0x06000109 RID: 265 RVA: 0x00005BE8 File Offset: 0x00003DE8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400006C RID: 108
			public int <>1__state;

			// Token: 0x0400006D RID: 109
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400006E RID: 110
			public IList<string> executedScripts;

			// Token: 0x0400006F RID: 111
			public SeedData <>4__this;

			// Token: 0x04000070 RID: 112
			private auseceEntities <ctx>5__2;

			// Token: 0x04000071 RID: 113
			private List<WorkshopOptions> <statuses>5__3;

			// Token: 0x04000072 RID: 114
			private config <config>5__4;

			// Token: 0x04000073 RID: 115
			private TaskAwaiter<config> <>u__1;

			// Token: 0x04000074 RID: 116
			private List<WorkshopOptions>.Enumerator <>7__wrap4;

			// Token: 0x04000075 RID: 117
			private WorkshopOptions <status>5__6;

			// Token: 0x04000076 RID: 118
			private TaskAwaiter<List<int>> <>u__2;

			// Token: 0x04000077 RID: 119
			private TaskAwaiter<int> <>u__3;

			// Token: 0x04000078 RID: 120
			private TaskAwaiter<List<<>f__AnonymousType0<int, DateTime?, int?>>> <>u__4;
		}
	}
}
