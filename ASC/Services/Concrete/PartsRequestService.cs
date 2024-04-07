using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;

namespace ASC.Services.Concrete
{
	// Token: 0x02000754 RID: 1876
	public class PartsRequestService : IPartsRequestService
	{
		// Token: 0x06003B0A RID: 15114 RVA: 0x000E3DB4 File Offset: 0x000E1FB4
		public PartsRequestService(IContextFactory contextFactory, ILoggerService<IPartsRequestService> loggerService)
		{
			this._contextFactory = contextFactory;
			this._loggerService = loggerService;
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x000E3DE8 File Offset: 0x000E1FE8
		public Task<parts_request> GetRequest(int requestId)
		{
			PartsRequestService.<GetRequest>d__4 <GetRequest>d__;
			<GetRequest>d__.<>t__builder = AsyncTaskMethodBuilder<parts_request>.Create();
			<GetRequest>d__.<>4__this = this;
			<GetRequest>d__.requestId = requestId;
			<GetRequest>d__.<>1__state = -1;
			<GetRequest>d__.<>t__builder.Start<PartsRequestService.<GetRequest>d__4>(ref <GetRequest>d__);
			return <GetRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x000E3E34 File Offset: 0x000E2034
		public void ReferenceDealer(parts_request request)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(false))
				{
					auseceEntities.parts_request.Attach(request);
					auseceEntities.Entry<parts_request>(request).Reference<clients>((parts_request r) => r.clients1).Load();
				}
			}
			catch (Exception ex)
			{
				this._loggerService.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x000E3EE0 File Offset: 0x000E20E0
		public Task<List<parts_request>> GetRequests(IPeriod period, int employeeId, int selectedRequestStatus, int priority)
		{
			PartsRequestService.<GetRequests>d__6 <GetRequests>d__;
			<GetRequests>d__.<>t__builder = AsyncTaskMethodBuilder<List<parts_request>>.Create();
			<GetRequests>d__.<>4__this = this;
			<GetRequests>d__.period = period;
			<GetRequests>d__.employeeId = employeeId;
			<GetRequests>d__.selectedRequestStatus = selectedRequestStatus;
			<GetRequests>d__.priority = priority;
			<GetRequests>d__.<>1__state = -1;
			<GetRequests>d__.<>t__builder.Start<PartsRequestService.<GetRequests>d__6>(ref <GetRequests>d__);
			return <GetRequests>d__.<>t__builder.Task;
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x000E3F44 File Offset: 0x000E2144
		public Task<List<parts_request>> GetRequests(workshop repair)
		{
			PartsRequestService.<GetRequests>d__7 <GetRequests>d__;
			<GetRequests>d__.<>t__builder = AsyncTaskMethodBuilder<List<parts_request>>.Create();
			<GetRequests>d__.<>4__this = this;
			<GetRequests>d__.repair = repair;
			<GetRequests>d__.<>1__state = -1;
			<GetRequests>d__.<>t__builder.Start<PartsRequestService.<GetRequests>d__7>(ref <GetRequests>d__);
			return <GetRequests>d__.<>t__builder.Task;
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x000E3F90 File Offset: 0x000E2190
		public Task<List<parts_request>> GetRequests(int repairId)
		{
			PartsRequestService.<GetRequests>d__8 <GetRequests>d__;
			<GetRequests>d__.<>t__builder = AsyncTaskMethodBuilder<List<parts_request>>.Create();
			<GetRequests>d__.<>4__this = this;
			<GetRequests>d__.repairId = repairId;
			<GetRequests>d__.<>1__state = -1;
			<GetRequests>d__.<>t__builder.Start<PartsRequestService.<GetRequests>d__8>(ref <GetRequests>d__);
			return <GetRequests>d__.<>t__builder.Task;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x000E3FDC File Offset: 0x000E21DC
		public List<int> GetResponsibleEmployees(parts_request request)
		{
			ICollection<parts_request_employees> parts_request_employees = request.parts_request_employees;
			List<int> result;
			if (parts_request_employees != null)
			{
				if ((result = (from r in parts_request_employees
				select r.emploee).ToList<int>()) != null)
				{
					return result;
				}
			}
			result = new List<int>();
			return result;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x000E4028 File Offset: 0x000E2228
		public parts_request NewRequest()
		{
			parts_request parts_request = new parts_request
			{
				request_time = this._localization.Now,
				from_user = Auth.User.id,
				pririty = 1,
				state = 1,
				url = string.Empty,
				count = 1
			};
			this.ReferenceFromUser(parts_request);
			return parts_request;
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x000E4084 File Offset: 0x000E2284
		public parts_request NewRequest(workshop repair)
		{
			parts_request parts_request = new parts_request
			{
				request_time = this._localization.Now,
				from_user = Auth.User.id,
				pririty = 1,
				repair = new int?(repair.id),
				state = 1,
				count = 1,
				url = string.Empty
			};
			this.ReferenceFromUser(parts_request);
			return parts_request;
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x000E40F4 File Offset: 0x000E22F4
		public parts_request NewRequest(store_items item)
		{
			parts_request parts_request = new parts_request
			{
				item_name = item.name,
				request_time = this._localization.Now,
				from_user = Auth.User.id,
				pririty = 1,
				item_id = new int?(item.id),
				state = 1,
				count = item.minimum_in_stock - item.count,
				url = string.Empty
			};
			this.ReferenceFromUser(parts_request);
			return parts_request;
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x000E417C File Offset: 0x000E237C
		public void ReferenceFromUser(parts_request request)
		{
			try
			{
				using (auseceEntities auseceEntities = this._contextFactory.Create())
				{
					request.users = null;
					auseceEntities.parts_request.Attach(request);
					auseceEntities.Entry<parts_request>(request).Reference<users>((parts_request r) => r.users).Load();
				}
			}
			catch (Exception ex)
			{
				this._loggerService.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x000E4234 File Offset: 0x000E2434
		public bool CreateRequest(parts_request request, List<int> responsibleUsers)
		{
			bool result;
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = this._contextFactory.Create())
				{
					request.users = null;
					auseceEntities.parts_request.Attach(request);
					auseceEntities.Entry<parts_request>(request).State = EntityState.Added;
					auseceEntities.SaveChanges();
					foreach (int emploee in responsibleUsers)
					{
						auseceEntities.parts_request_employees.Add(new parts_request_employees
						{
							emploee = emploee,
							request = request.id
						});
					}
					auseceEntities.SaveChanges();
					historyV.AddPartsRequestLog("created", request.id, "", "");
					historyV.Save();
					if (OfflineData.Instance.Settings.InformPartRequest)
					{
						NotificationService.CreateBuyRequestNotification(responsibleUsers, request.id, request.item_name);
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				this._loggerService.Error(ex, ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x000E436C File Offset: 0x000E256C
		private void LogChanges(parts_request original, parts_request current)
		{
			try
			{
				HistoryV2 historyV = new HistoryV2();
				PartsRequestService.LogChanges(historyV, original, current);
				historyV.Save();
			}
			catch (Exception ex)
			{
				this._loggerService.Error(ex, ex.Message);
			}
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x000E43B4 File Offset: 0x000E25B4
		public static void LogChanges(HistoryV2 history, parts_request original, parts_request current)
		{
			if (original.state != current.state)
			{
				ObjectToObjectConverter objectToObjectConverter = Application.Current.Resources["StatusToTextConverter"] as ObjectToObjectConverter;
				object obj = (objectToObjectConverter != null) ? objectToObjectConverter.Convert(original.state, typeof(string), null, CultureInfo.CurrentCulture) : null;
				object obj2 = (objectToObjectConverter != null) ? objectToObjectConverter.Convert(current.state, typeof(string), null, CultureInfo.CurrentCulture) : null;
				if (obj != null && obj2 != null)
				{
					history.AddPartsRequestLog("stateChanged", original.id, obj.ToString(), obj2.ToString());
				}
			}
			if (original.plan_end_date != current.plan_end_date)
			{
				history.AddPartsRequestLog(original.id, original.plan_end_date, current.plan_end_date);
			}
			decimal? summ = original.summ;
			decimal? summ2 = current.summ;
			if (!(summ.GetValueOrDefault() == summ2.GetValueOrDefault() & summ != null == (summ2 != null)))
			{
				history.AddPartsRequestLog(original.id, original.summ, current.summ);
			}
			if (original.tracking != current.tracking)
			{
				history.AddPartsRequestLog("trackingChanged", original.id, original.tracking, current.tracking);
			}
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x000E4538 File Offset: 0x000E2738
		public Task UpdateRequest(parts_request request)
		{
			PartsRequestService.<UpdateRequest>d__17 <UpdateRequest>d__;
			<UpdateRequest>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateRequest>d__.<>4__this = this;
			<UpdateRequest>d__.request = request;
			<UpdateRequest>d__.<>1__state = -1;
			<UpdateRequest>d__.<>t__builder.Start<PartsRequestService.<UpdateRequest>d__17>(ref <UpdateRequest>d__);
			return <UpdateRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CheckFields(parts_request request, IMessageBoxService mbs)
		{
			return true;
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x000E4584 File Offset: 0x000E2784
		public Dictionary<int, string> GetPartsRequestStatuses(bool includeAll = false)
		{
			Dictionary<int, string> result;
			try
			{
				Dictionary<int, string> dictionary = new Dictionary<int, string>
				{
					{
						1,
						Lang.t("Created")
					},
					{
						4,
						Lang.t("InProgress")
					},
					{
						3,
						Lang.t("Holded")
					},
					{
						2,
						Lang.t("Complete")
					}
				};
				if (includeAll)
				{
					dictionary.Add(0, Lang.t("All"));
					dictionary.Add(-1, Lang.t("OnlyActual"));
				}
				result = dictionary;
			}
			catch (Exception e)
			{
				this._loggerService.Error(e, "Load task statuses fail");
				throw;
			}
			return result;
		}

		// Token: 0x040025E6 RID: 9702
		private readonly IContextFactory _contextFactory;

		// Token: 0x040025E7 RID: 9703
		private readonly ILoggerService<IPartsRequestService> _loggerService;

		// Token: 0x040025E8 RID: 9704
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x02000755 RID: 1877
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003B1B RID: 15131 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040025E9 RID: 9705
			public int requestId;
		}

		// Token: 0x02000756 RID: 1878
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003B1C RID: 15132 RVA: 0x000E462C File Offset: 0x000E282C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003B1D RID: 15133 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003B1E RID: 15134 RVA: 0x000E4644 File Offset: 0x000E2844
			internal int <GetResponsibleEmployees>b__9_0(parts_request_employees r)
			{
				return r.emploee;
			}

			// Token: 0x040025EA RID: 9706
			public static readonly PartsRequestService.<>c <>9 = new PartsRequestService.<>c();

			// Token: 0x040025EB RID: 9707
			public static Func<parts_request_employees, int> <>9__9_0;
		}

		// Token: 0x02000757 RID: 1879
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRequest>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003B1F RID: 15135 RVA: 0x000E4658 File Offset: 0x000E2858
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestService partsRequestService = this.<>4__this;
				parts_request result;
				try
				{
					PartsRequestService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PartsRequestService.<>c__DisplayClass4_0();
						CS$<>8__locals1.requestId = this.requestId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = partsRequestService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<parts_request> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__2.parts_request.Include((parts_request r) => r.users).Include((parts_request r) => r.clients1).Include((parts_request r) => r.parts_request_employees).FirstOrDefaultAsync((parts_request r) => r.id == CS$<>8__locals1.requestId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<parts_request>, PartsRequestService.<GetRequest>d__4>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<parts_request>);
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
					catch (Exception ex)
					{
						partsRequestService._loggerService.Error(ex, ex.Message);
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003B20 RID: 15136 RVA: 0x000E48DC File Offset: 0x000E2ADC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025EC RID: 9708
			public int <>1__state;

			// Token: 0x040025ED RID: 9709
			public AsyncTaskMethodBuilder<parts_request> <>t__builder;

			// Token: 0x040025EE RID: 9710
			public int requestId;

			// Token: 0x040025EF RID: 9711
			public PartsRequestService <>4__this;

			// Token: 0x040025F0 RID: 9712
			private auseceEntities <ctx>5__2;

			// Token: 0x040025F1 RID: 9713
			private TaskAwaiter<parts_request> <>u__1;
		}

		// Token: 0x02000758 RID: 1880
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06003B21 RID: 15137 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x040025F2 RID: 9714
			public int employeeId;

			// Token: 0x040025F3 RID: 9715
			public int selectedRequestStatus;

			// Token: 0x040025F4 RID: 9716
			public int priority;
		}

		// Token: 0x02000759 RID: 1881
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_1
		{
			// Token: 0x06003B22 RID: 15138 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_1()
			{
			}

			// Token: 0x040025F5 RID: 9717
			public DateTime from;

			// Token: 0x040025F6 RID: 9718
			public DateTime to;
		}

		// Token: 0x0200075A RID: 1882
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRequests>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003B23 RID: 15139 RVA: 0x000E48F8 File Offset: 0x000E2AF8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestService partsRequestService = this.<>4__this;
				List<parts_request> result;
				try
				{
					PartsRequestService.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PartsRequestService.<>c__DisplayClass6_0();
						CS$<>8__locals1.employeeId = this.employeeId;
						CS$<>8__locals1.selectedRequestStatus = this.selectedRequestStatus;
						CS$<>8__locals1.priority = this.priority;
					}
					try
					{
						PartsRequestService.<>c__DisplayClass6_1 CS$<>8__locals2;
						if (num != 0)
						{
							CS$<>8__locals2 = new PartsRequestService.<>c__DisplayClass6_1();
							CS$<>8__locals2.from = this.period.From.Date;
							CS$<>8__locals2.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
							this.<ctx>5__2 = partsRequestService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<List<parts_request>> awaiter;
							if (num != 0)
							{
								this.<ctx>5__2.Configuration.LazyLoadingEnabled = false;
								IQueryable<parts_request> source = from r in this.<ctx>5__2.parts_request.AsNoTracking().Include((parts_request r) => r.users).Include((parts_request r) => r.clients).Include((parts_request r) => r.clients1).Include((parts_request r) => r.store_items).Include((parts_request r) => r.parts_request_employees)
								where r.parts_request_employees.Any((parts_request_employees e) => e.emploee == Auth.User.id) && r.request_time >= CS$<>8__locals2.@from && r.request_time <= CS$<>8__locals2.to
								select r;
								if (CS$<>8__locals1.employeeId != 0)
								{
									source = from r in source
									where r.from_user == CS$<>8__locals1.employeeId
									select r;
								}
								if (CS$<>8__locals1.selectedRequestStatus > 0)
								{
									source = from r in source
									where r.state == CS$<>8__locals1.selectedRequestStatus
									select r;
								}
								if (CS$<>8__locals1.selectedRequestStatus == -1)
								{
									source = from r in source
									where r.state != 2
									select r;
								}
								if (CS$<>8__locals1.priority != 0)
								{
									source = from r in source
									where r.pririty == CS$<>8__locals1.priority
									select r;
								}
								awaiter = source.ToListAsync<parts_request>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<parts_request>>, PartsRequestService.<GetRequests>d__6>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<parts_request>>);
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
					catch (Exception ex)
					{
						partsRequestService._loggerService.Error(ex, ex.Message);
						result = new List<parts_request>();
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

			// Token: 0x06003B24 RID: 15140 RVA: 0x000E4F60 File Offset: 0x000E3160
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040025F7 RID: 9719
			public int <>1__state;

			// Token: 0x040025F8 RID: 9720
			public AsyncTaskMethodBuilder<List<parts_request>> <>t__builder;

			// Token: 0x040025F9 RID: 9721
			public int employeeId;

			// Token: 0x040025FA RID: 9722
			public int selectedRequestStatus;

			// Token: 0x040025FB RID: 9723
			public int priority;

			// Token: 0x040025FC RID: 9724
			public IPeriod period;

			// Token: 0x040025FD RID: 9725
			public PartsRequestService <>4__this;

			// Token: 0x040025FE RID: 9726
			private auseceEntities <ctx>5__2;

			// Token: 0x040025FF RID: 9727
			private TaskAwaiter<List<parts_request>> <>u__1;
		}

		// Token: 0x0200075B RID: 1883
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRequests>d__7 : IAsyncStateMachine
		{
			// Token: 0x06003B25 RID: 15141 RVA: 0x000E4F7C File Offset: 0x000E317C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestService partsRequestService = this.<>4__this;
				List<parts_request> result;
				try
				{
					TaskAwaiter<List<parts_request>> awaiter;
					if (num != 0)
					{
						awaiter = partsRequestService.GetRequests(this.repair.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<parts_request>>, PartsRequestService.<GetRequests>d__7>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<parts_request>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x06003B26 RID: 15142 RVA: 0x000E5040 File Offset: 0x000E3240
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002600 RID: 9728
			public int <>1__state;

			// Token: 0x04002601 RID: 9729
			public AsyncTaskMethodBuilder<List<parts_request>> <>t__builder;

			// Token: 0x04002602 RID: 9730
			public PartsRequestService <>4__this;

			// Token: 0x04002603 RID: 9731
			public workshop repair;

			// Token: 0x04002604 RID: 9732
			private TaskAwaiter<List<parts_request>> <>u__1;
		}

		// Token: 0x0200075C RID: 1884
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06003B27 RID: 15143 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04002605 RID: 9733
			public int repairId;
		}

		// Token: 0x0200075D RID: 1885
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetRequests>d__8 : IAsyncStateMachine
		{
			// Token: 0x06003B28 RID: 15144 RVA: 0x000E505C File Offset: 0x000E325C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestService partsRequestService = this.<>4__this;
				List<parts_request> result;
				try
				{
					PartsRequestService.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PartsRequestService.<>c__DisplayClass8_0();
						CS$<>8__locals1.repairId = this.repairId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = partsRequestService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<List<parts_request>> awaiter;
							if (num != 0)
							{
								awaiter = (from r in this.<ctx>5__2.parts_request.AsNoTracking().Include((parts_request r) => r.users)
								where r.repair == (int?)CS$<>8__locals1.repairId
								select r).ToListAsync<parts_request>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<parts_request>>, PartsRequestService.<GetRequests>d__8>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<parts_request>>);
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
					catch (Exception ex)
					{
						partsRequestService._loggerService.Error(ex, ex.Message);
						result = new List<parts_request>();
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

			// Token: 0x06003B29 RID: 15145 RVA: 0x000E527C File Offset: 0x000E347C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002606 RID: 9734
			public int <>1__state;

			// Token: 0x04002607 RID: 9735
			public AsyncTaskMethodBuilder<List<parts_request>> <>t__builder;

			// Token: 0x04002608 RID: 9736
			public int repairId;

			// Token: 0x04002609 RID: 9737
			public PartsRequestService <>4__this;

			// Token: 0x0400260A RID: 9738
			private auseceEntities <ctx>5__2;

			// Token: 0x0400260B RID: 9739
			private TaskAwaiter<List<parts_request>> <>u__1;
		}

		// Token: 0x0200075E RID: 1886
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06003B2A RID: 15146 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x0400260C RID: 9740
			public parts_request request;
		}

		// Token: 0x0200075F RID: 1887
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateRequest>d__17 : IAsyncStateMachine
		{
			// Token: 0x06003B2B RID: 15147 RVA: 0x000E5298 File Offset: 0x000E3498
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestService partsRequestService = this.<>4__this;
				try
				{
					if (num > 1)
					{
						this.<>8__1 = new PartsRequestService.<>c__DisplayClass17_0();
						this.<>8__1.request = this.request;
					}
					try
					{
						if (num > 1)
						{
							this.<ctx>5__2 = partsRequestService._contextFactory.Create();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter<parts_request> awaiter2;
							if (num != 0)
							{
								if (num == 1)
								{
									awaiter = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<int>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									goto IL_22E;
								}
								awaiter2 = this.<ctx>5__2.parts_request.SingleAsync((parts_request i) => i.id == this.<>8__1.request.id).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num3 = 0;
									num = 0;
									this.<>1__state = num3;
									this.<>u__1 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<parts_request>, PartsRequestService.<UpdateRequest>d__17>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<parts_request>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
							}
							parts_request result = awaiter2.GetResult();
							this.<original>5__3 = result;
							if (this.<original>5__3.state != this.<>8__1.request.state)
							{
								if (this.<>8__1.request.state == 2)
								{
									this.<>8__1.request.end_date = new DateTime?(Localization.GetServerUtcTime(this.<ctx>5__2));
								}
							}
							if (this.<>8__1.request.state != 2)
							{
								this.<>8__1.request.end_date = null;
							}
							partsRequestService.LogChanges(this.<original>5__3, this.<>8__1.request);
							this.<ctx>5__2.Entry<parts_request>(this.<original>5__3).CurrentValues.SetValues(this.<>8__1.request);
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PartsRequestService.<UpdateRequest>d__17>(ref awaiter, ref this);
								return;
							}
							IL_22E:
							awaiter.GetResult();
							if (this.<original>5__3.state != 1)
							{
								Bootstrapper.Container.Resolve<ITaskService>().UpdateTaskState(this.<original>5__3, 2);
							}
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
					catch (Exception ex)
					{
						partsRequestService._loggerService.Error(ex, ex.Message);
						throw;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003B2C RID: 15148 RVA: 0x000E55EC File Offset: 0x000E37EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400260D RID: 9741
			public int <>1__state;

			// Token: 0x0400260E RID: 9742
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400260F RID: 9743
			public parts_request request;

			// Token: 0x04002610 RID: 9744
			public PartsRequestService <>4__this;

			// Token: 0x04002611 RID: 9745
			private PartsRequestService.<>c__DisplayClass17_0 <>8__1;

			// Token: 0x04002612 RID: 9746
			private auseceEntities <ctx>5__2;

			// Token: 0x04002613 RID: 9747
			private parts_request <original>5__3;

			// Token: 0x04002614 RID: 9748
			private TaskAwaiter<parts_request> <>u__1;

			// Token: 0x04002615 RID: 9749
			private TaskAwaiter<int> <>u__2;
		}
	}
}
