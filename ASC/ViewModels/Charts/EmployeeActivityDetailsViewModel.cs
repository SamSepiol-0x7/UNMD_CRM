using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Objects;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000506 RID: 1286
	public class EmployeeActivityDetailsViewModel : PopupViewModel
	{
		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x000A0304 File Offset: 0x0009E504
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x000A0318 File Offset: 0x0009E518
		public ObservableCollection<IEmployyeActivity> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x000A0348 File Offset: 0x0009E548
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x000A035C File Offset: 0x0009E55C
		public Employee Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Employee>k__BackingField, value))
				{
					return;
				}
				this.<Employee>k__BackingField = value;
				this.RaisePropertyChanged("Employee");
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x000A038C File Offset: 0x0009E58C
		// (set) Token: 0x0600309D RID: 12445 RVA: 0x000A03A0 File Offset: 0x0009E5A0
		public int EmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<EmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<EmployeeId>k__BackingField == value)
				{
					return;
				}
				this.<EmployeeId>k__BackingField = value;
				this.RaisePropertyChanged("EmployeeId");
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x000A03CC File Offset: 0x0009E5CC
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x000A03E0 File Offset: 0x0009E5E0
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x000A0410 File Offset: 0x0009E610
		public EmployeeActivityDetailsViewModel(Employee employee)
		{
			this.Employee = employee;
			this.EmployeeId = this.Employee.Id;
			this.Period = new Period();
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.PeriodChanged));
			this.LoadItems(this.Period, this.Employee.Id);
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x000A0484 File Offset: 0x0009E684
		private void PeriodChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x000A0498 File Offset: 0x0009E698
		private void LoadItems(IPeriod period, int employeeId)
		{
			EmployeeActivityDetailsViewModel.<LoadItems>d__18 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.period = period;
			<LoadItems>d__.employeeId = employeeId;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<EmployeeActivityDetailsViewModel.<LoadItems>d__18>(ref <LoadItems>d__);
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x000A04E0 File Offset: 0x0009E6E0
		[Command]
		public void Refresh()
		{
			this.LoadItems(this.Period, this.Employee.Id);
		}

		// Token: 0x04001BAE RID: 7086
		[CompilerGenerated]
		private ObservableCollection<IEmployyeActivity> <Items>k__BackingField;

		// Token: 0x04001BAF RID: 7087
		[CompilerGenerated]
		private Employee <Employee>k__BackingField;

		// Token: 0x04001BB0 RID: 7088
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;

		// Token: 0x04001BB1 RID: 7089
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x02000507 RID: 1287
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x060030A4 RID: 12452 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x04001BB2 RID: 7090
			public int employeeId;

			// Token: 0x04001BB3 RID: 7091
			public DateTime from;

			// Token: 0x04001BB4 RID: 7092
			public DateTime to;
		}

		// Token: 0x02000508 RID: 1288
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060030A5 RID: 12453 RVA: 0x000A0504 File Offset: 0x0009E704
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060030A6 RID: 12454 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04001BB5 RID: 7093
			public static readonly EmployeeActivityDetailsViewModel.<>c <>9 = new EmployeeActivityDetailsViewModel.<>c();
		}

		// Token: 0x02000509 RID: 1289
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__18 : IAsyncStateMachine
		{
			// Token: 0x060030A7 RID: 12455 RVA: 0x000A051C File Offset: 0x0009E71C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeActivityDetailsViewModel employeeActivityDetailsViewModel = this.<>4__this;
				try
				{
					EmployeeActivityDetailsViewModel.<>c__DisplayClass18_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new EmployeeActivityDetailsViewModel.<>c__DisplayClass18_0();
						CS$<>8__locals1.employeeId = this.employeeId;
						employeeActivityDetailsViewModel.ShowWait();
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<List<users_activity>> awaiter;
						if (num != 0)
						{
							awaiter = (from a in this.<ctx>5__2.users_activity
							where a.user_id == CS$<>8__locals1.employeeId
							where a.datetime_ >= CS$<>8__locals1.@from && a.datetime_ <= CS$<>8__locals1.to
							where a.notes == "Logout" || a.notes == "Выполнен вход в систему"
							select a).ToListAsync<users_activity>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users_activity>>, EmployeeActivityDetailsViewModel.<LoadItems>d__18>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<users_activity>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<users_activity> result = awaiter.GetResult();
						List<IEmployyeActivity> list = new List<IEmployyeActivity>();
						List<users_activity>.Enumerator enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								users_activity users_activity = enumerator.Current;
								EmployyeActivity employyeActivity = new EmployyeActivity
								{
									Ip = users_activity.address,
									Date = Localization.ToLocalTimeZone(users_activity.datetime_),
									Version = users_activity.app_version,
									MachineName = users_activity.machine_name
								};
								if (users_activity.notes == "Logout")
								{
									employyeActivity.Text = Lang.t("Exit");
								}
								if (users_activity.notes == "Выполнен вход в систему")
								{
									employyeActivity.Text = Lang.t("UserLogin");
								}
								list.Add(employyeActivity);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						employeeActivityDetailsViewModel.Items = new ObservableCollection<IEmployyeActivity>(list);
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
					employeeActivityDetailsViewModel.HideWait();
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

			// Token: 0x060030A8 RID: 12456 RVA: 0x000A0954 File Offset: 0x0009EB54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BB6 RID: 7094
			public int <>1__state;

			// Token: 0x04001BB7 RID: 7095
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001BB8 RID: 7096
			public int employeeId;

			// Token: 0x04001BB9 RID: 7097
			public EmployeeActivityDetailsViewModel <>4__this;

			// Token: 0x04001BBA RID: 7098
			public IPeriod period;

			// Token: 0x04001BBB RID: 7099
			private auseceEntities <ctx>5__2;

			// Token: 0x04001BBC RID: 7100
			private TaskAwaiter<List<users_activity>> <>u__1;
		}
	}
}
