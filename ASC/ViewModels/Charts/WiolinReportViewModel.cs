using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Salary;
using ASC.SimpleClasses;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200051D RID: 1309
	public class WiolinReportViewModel : BaseViewModel, IIsDataLoading
	{
		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x000A3470 File Offset: 0x000A1670
		// (set) Token: 0x0600310E RID: 12558 RVA: 0x000A3484 File Offset: 0x000A1684
		public DateTime Period
		{
			get
			{
				return this._period;
			}
			set
			{
				if (DateTime.Equals(this._period, value))
				{
					return;
				}
				this._period = value;
				this.RaisePropertyChanged("Period");
				DateTime from = new DateTime(value.Year, value.Month, 1);
				DateTime to = from.AddMonths(1).AddDays(-1.0).AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
				this.SelectedPeriod = new Period(from, to);
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x000A3524 File Offset: 0x000A1724
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x000A3538 File Offset: 0x000A1738
		public List<payment_systems> PaymentSystems
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystems>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<PaymentSystems>k__BackingField, value))
				{
					return;
				}
				this.<PaymentSystems>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystems");
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x000A3568 File Offset: 0x000A1768
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x000A357C File Offset: 0x000A177C
		public List<users> Employees
		{
			[CompilerGenerated]
			get
			{
				return this.<Employees>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Employees>k__BackingField, value))
				{
					return;
				}
				this.<Employees>k__BackingField = value;
				this.RaisePropertyChanged("Employees");
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x000A35AC File Offset: 0x000A17AC
		// (set) Token: 0x06003114 RID: 12564 RVA: 0x000A35C0 File Offset: 0x000A17C0
		public List<object> SelectedPaymentSystems
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPaymentSystems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedPaymentSystems>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 630086004;
				IL_13:
				switch ((num ^ 701465829) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<SelectedPaymentSystems>k__BackingField = value;
					this.RaisePropertyChanged("SelectedPaymentSystems");
					num = 267115633;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x000A361C File Offset: 0x000A181C
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x000A3630 File Offset: 0x000A1830
		public List<object> SelectedEmployees
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedEmployees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedEmployees>k__BackingField, value))
				{
					return;
				}
				this.<SelectedEmployees>k__BackingField = value;
				this.RaisePropertyChanged("SelectedEmployees");
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x000A3660 File Offset: 0x000A1860
		public ObservableCollection<NameSumm> Advances
		{
			[CompilerGenerated]
			get
			{
				return this.<Advances>k__BackingField;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x000A3674 File Offset: 0x000A1874
		public ObservableCollection<NameSumm> Balances
		{
			[CompilerGenerated]
			get
			{
				return this.<Balances>k__BackingField;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x000A3688 File Offset: 0x000A1888
		public ObservableCollection<NameSumm> Profites
		{
			[CompilerGenerated]
			get
			{
				return this.<Profites>k__BackingField;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x000A369C File Offset: 0x000A189C
		public ObservableCollection<NameSumm> ProfitesResult
		{
			[CompilerGenerated]
			get
			{
				return this.<ProfitesResult>k__BackingField;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x000A36B0 File Offset: 0x000A18B0
		public ObservableCollection<NameSumm> ProfitesResultSub
		{
			[CompilerGenerated]
			get
			{
				return this.<ProfitesResultSub>k__BackingField;
			}
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000A36C4 File Offset: 0x000A18C4
		public WiolinReportViewModel(IPaymentSystemService paymentSystemService, IEmployeeService employeeService, ICashOrderService cashOrderService)
		{
			this.SetViewName("Report");
			this.PaymentSystemService = paymentSystemService;
			this.EmployeeService = employeeService;
			this.CashOrderService = cashOrderService;
			this._model = new SalaryModel();
			this.Period = DateTime.UtcNow;
			this.Advances = new ObservableCollection<NameSumm>();
			this.Balances = new ObservableCollection<NameSumm>();
			this.Profites = new ObservableCollection<NameSumm>();
			this.ProfitesResult = new ObservableCollection<NameSumm>();
			this.ProfitesResultSub = new ObservableCollection<NameSumm>();
			this.Init();
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x000A374C File Offset: 0x000A194C
		protected void Init()
		{
			WiolinReportViewModel.<Init>d__41 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<WiolinReportViewModel.<Init>d__41>(ref <Init>d__);
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x000A3784 File Offset: 0x000A1984
		public override void OnLoad()
		{
			base.OnLoad();
			this.LoadData();
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000A37A0 File Offset: 0x000A19A0
		protected virtual void LoadData()
		{
			WiolinReportViewModel.<LoadData>d__43 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<WiolinReportViewModel.<LoadData>d__43>(ref <LoadData>d__);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000A37D8 File Offset: 0x000A19D8
		private decimal GetBalanceById(int paymentSystemId)
		{
			return (from b in this.Balances
			where b.Id == paymentSystemId
			select b.Summ).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000A3838 File Offset: 0x000A1A38
		private void ClearData()
		{
			this.Advances.Clear();
			this.Balances.Clear();
			this.Profites.Clear();
			this.ProfitesResult.Clear();
			this.ProfitesResultSub.Clear();
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000A387C File Offset: 0x000A1A7C
		protected virtual decimal GetEmployeeAdvance(int employeeId)
		{
			return (from a in this.Advances
			where a.Id == employeeId
			select a.Summ).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000A38DC File Offset: 0x000A1ADC
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000A38F0 File Offset: 0x000A1AF0
		public bool CanRefresh()
		{
			return !this.IsLoadingData;
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000A3908 File Offset: 0x000A1B08
		private users GetEmployeeById(int employeeId)
		{
			return this.Employees.FirstOrDefault((users e) => e.id == employeeId);
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000A393C File Offset: 0x000A1B3C
		private payment_systems GetPaymentSystemById(int paymentSystemId)
		{
			return this.PaymentSystems.FirstOrDefault((payment_systems e) => e.system_id == paymentSystemId);
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x000A3970 File Offset: 0x000A1B70
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x000A3984 File Offset: 0x000A1B84
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x000A39B0 File Offset: 0x000A1BB0
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
			base.RaiseCanExecuteChanged(() => this.Refresh());
		}

		// Token: 0x04001C13 RID: 7187
		protected IPaymentSystemService PaymentSystemService;

		// Token: 0x04001C14 RID: 7188
		protected IEmployeeService EmployeeService;

		// Token: 0x04001C15 RID: 7189
		protected ICashOrderService CashOrderService;

		// Token: 0x04001C16 RID: 7190
		private SalaryModel _model;

		// Token: 0x04001C17 RID: 7191
		private DateTime _period;

		// Token: 0x04001C18 RID: 7192
		private IPeriod SelectedPeriod;

		// Token: 0x04001C19 RID: 7193
		[CompilerGenerated]
		private List<payment_systems> <PaymentSystems>k__BackingField;

		// Token: 0x04001C1A RID: 7194
		[CompilerGenerated]
		private List<users> <Employees>k__BackingField;

		// Token: 0x04001C1B RID: 7195
		[CompilerGenerated]
		private List<object> <SelectedPaymentSystems>k__BackingField;

		// Token: 0x04001C1C RID: 7196
		[CompilerGenerated]
		private List<object> <SelectedEmployees>k__BackingField;

		// Token: 0x04001C1D RID: 7197
		[CompilerGenerated]
		private readonly ObservableCollection<NameSumm> <Advances>k__BackingField;

		// Token: 0x04001C1E RID: 7198
		[CompilerGenerated]
		private readonly ObservableCollection<NameSumm> <Balances>k__BackingField;

		// Token: 0x04001C1F RID: 7199
		[CompilerGenerated]
		private readonly ObservableCollection<NameSumm> <Profites>k__BackingField;

		// Token: 0x04001C20 RID: 7200
		[CompilerGenerated]
		private readonly ObservableCollection<NameSumm> <ProfitesResult>k__BackingField;

		// Token: 0x04001C21 RID: 7201
		[CompilerGenerated]
		private readonly ObservableCollection<NameSumm> <ProfitesResultSub>k__BackingField;

		// Token: 0x04001C22 RID: 7202
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x0200051E RID: 1310
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__41 : IAsyncStateMachine
		{
			// Token: 0x0600312A RID: 12586 RVA: 0x000A3A00 File Offset: 0x000A1C00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WiolinReportViewModel wiolinReportViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<users>> awaiter;
					TaskAwaiter<List<payment_systems>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<users>>);
							this.<>1__state = -1;
							goto IL_E9;
						}
						awaiter2 = wiolinReportViewModel.PaymentSystemService.GetPaymentSystems().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<payment_systems>>, WiolinReportViewModel.<Init>d__41>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<payment_systems>>);
						this.<>1__state = -1;
					}
					List<payment_systems> result = awaiter2.GetResult();
					wiolinReportViewModel.PaymentSystems = result;
					wiolinReportViewModel.SelectedPaymentSystems = new List<object>
					{
						0,
						2,
						3
					};
					awaiter = wiolinReportViewModel.EmployeeService.GetEmployees().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, WiolinReportViewModel.<Init>d__41>(ref awaiter, ref this);
						return;
					}
					IL_E9:
					List<users> result2 = awaiter.GetResult();
					wiolinReportViewModel.Employees = result2;
					wiolinReportViewModel.SelectedEmployees = new List<object>
					{
						19,
						20
					};
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

			// Token: 0x0600312B RID: 12587 RVA: 0x000A3B98 File Offset: 0x000A1D98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C23 RID: 7203
			public int <>1__state;

			// Token: 0x04001C24 RID: 7204
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C25 RID: 7205
			public WiolinReportViewModel <>4__this;

			// Token: 0x04001C26 RID: 7206
			private TaskAwaiter<List<payment_systems>> <>u__1;

			// Token: 0x04001C27 RID: 7207
			private TaskAwaiter<List<users>> <>u__2;
		}

		// Token: 0x0200051F RID: 1311
		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x0600312C RID: 12588 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x0600312D RID: 12589 RVA: 0x000A3BB4 File Offset: 0x000A1DB4
			internal UserSalaryReport <LoadData>b__1()
			{
				SalaryModel model = this.<>4__this._model;
				users user = this.employee;
				IPeriod selectedPeriod = this.<>4__this.SelectedPeriod;
				int? salary_rate = this.employee.salary_rate;
				return model.LoadUserReport(user, selectedPeriod, (salary_rate != null) ? new decimal?(salary_rate.GetValueOrDefault()) : null);
			}

			// Token: 0x04001C28 RID: 7208
			public users employee;

			// Token: 0x04001C29 RID: 7209
			public WiolinReportViewModel <>4__this;
		}

		// Token: 0x02000520 RID: 1312
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600312E RID: 12590 RVA: 0x000A3C14 File Offset: 0x000A1E14
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600312F RID: 12591 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003130 RID: 12592 RVA: 0x000A3C2C File Offset: 0x000A1E2C
			internal decimal <LoadData>b__43_2(cash_orders o)
			{
				return o.summa;
			}

			// Token: 0x06003131 RID: 12593 RVA: 0x000A3C40 File Offset: 0x000A1E40
			internal decimal <LoadData>b__43_0(NameSumm b)
			{
				return b.Summ;
			}

			// Token: 0x06003132 RID: 12594 RVA: 0x000A3C40 File Offset: 0x000A1E40
			internal decimal <GetBalanceById>b__44_1(NameSumm b)
			{
				return b.Summ;
			}

			// Token: 0x06003133 RID: 12595 RVA: 0x000A3C40 File Offset: 0x000A1E40
			internal decimal <GetEmployeeAdvance>b__46_1(NameSumm a)
			{
				return a.Summ;
			}

			// Token: 0x04001C2A RID: 7210
			public static readonly WiolinReportViewModel.<>c <>9 = new WiolinReportViewModel.<>c();

			// Token: 0x04001C2B RID: 7211
			public static Func<cash_orders, decimal> <>9__43_2;

			// Token: 0x04001C2C RID: 7212
			public static Func<NameSumm, decimal> <>9__43_0;

			// Token: 0x04001C2D RID: 7213
			public static Func<NameSumm, decimal> <>9__44_1;

			// Token: 0x04001C2E RID: 7214
			public static Func<NameSumm, decimal> <>9__46_1;
		}

		// Token: 0x02000521 RID: 1313
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__43 : IAsyncStateMachine
		{
			// Token: 0x06003134 RID: 12596 RVA: 0x000A3C54 File Offset: 0x000A1E54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WiolinReportViewModel wiolinReportViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_1BA;
						}
						if (wiolinReportViewModel.SelectedEmployees.Count == 0)
						{
							goto IL_48F;
						}
						wiolinReportViewModel.SetIsDataLoading(true);
						wiolinReportViewModel.ClearData();
						this.<totalAdvance>5__2 = 0m;
						this.<>7__wrap2 = wiolinReportViewModel.SelectedEmployees.GetEnumerator();
					}
					try
					{
						TaskAwaiter<UserSalaryReport> awaiter;
						if (num == 0)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<UserSalaryReport>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							goto IL_E7;
						}
						IL_77:
						if (!this.<>7__wrap2.MoveNext())
						{
							goto IL_19D;
						}
						object obj = this.<>7__wrap2.Current;
						this.<>8__1 = new WiolinReportViewModel.<>c__DisplayClass43_0();
						this.<>8__1.<>4__this = wiolinReportViewModel;
						this.<>8__1.employee = wiolinReportViewModel.GetEmployeeById((int)obj);
						awaiter = Task.Run<UserSalaryReport>(new Func<UserSalaryReport>(this.<>8__1.<LoadData>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.<>1__state = num3;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UserSalaryReport>, WiolinReportViewModel.<LoadData>d__43>(ref awaiter, ref this);
							return;
						}
						IL_E7:
						UserSalaryReport result = awaiter.GetResult();
						decimal num4 = result.Advance + result.AlreadyPayed;
						NameSumm nameSumm = new NameSumm(this.<>8__1.employee.FioShort, num4);
						nameSumm.SetId(this.<>8__1.employee.id);
						wiolinReportViewModel.Advances.Add(nameSumm);
						this.<totalAdvance>5__2 += num4;
						this.<>8__1 = null;
						goto IL_77;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap2).Dispose();
						}
					}
					IL_19D:
					this.<>7__wrap2 = default(List<object>.Enumerator);
					this.<>7__wrap2 = wiolinReportViewModel.SelectedPaymentSystems.GetEnumerator();
					IL_1BA:
					try
					{
						if (num != 1)
						{
							goto IL_252;
						}
						TaskAwaiter<List<cash_orders>> awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<cash_orders>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						IL_1E1:
						List<cash_orders> result2 = awaiter2.GetResult();
						NameSumm nameSumm2 = new NameSumm(this.<paymentSystem>5__4.name, result2.Select(new Func<cash_orders, decimal>(WiolinReportViewModel.<>c.<>9.<LoadData>b__43_2)).DefaultIfEmpty<decimal>().Sum());
						nameSumm2.SetId(this.<paymentSystem>5__4.system_id);
						wiolinReportViewModel.Balances.Add(nameSumm2);
						this.<paymentSystem>5__4 = null;
						IL_252:
						if (this.<>7__wrap2.MoveNext())
						{
							object obj2 = this.<>7__wrap2.Current;
							this.<paymentSystem>5__4 = wiolinReportViewModel.GetPaymentSystemById((int)obj2);
							awaiter2 = wiolinReportViewModel.CashOrderService.GetCashOrders(wiolinReportViewModel.SelectedPeriod, (int)obj2).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<cash_orders>>, WiolinReportViewModel.<LoadData>d__43>(ref awaiter2, ref this);
								return;
							}
							goto IL_1E1;
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap2).Dispose();
						}
					}
					this.<>7__wrap2 = default(List<object>.Enumerator);
					decimal num7 = wiolinReportViewModel.Balances.Select(new Func<NameSumm, decimal>(WiolinReportViewModel.<>c.<>9.<LoadData>b__43_0)).DefaultIfEmpty<decimal>().Sum() + this.<totalAdvance>5__2;
					wiolinReportViewModel.Profites.Add(new NameSumm("Сумма чистой прибыли", num7));
					List<object>.Enumerator enumerator = wiolinReportViewModel.SelectedEmployees.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj3 = enumerator.Current;
							users employeeById = wiolinReportViewModel.GetEmployeeById((int)obj3);
							decimal num8 = num7 / wiolinReportViewModel.SelectedEmployees.Count;
							wiolinReportViewModel.Profites.Add(new NameSumm(employeeById.FioShort, num8));
							decimal num9 = num8 - wiolinReportViewModel.GetEmployeeAdvance(employeeById.id);
							NameSumm nameSumm3 = new NameSumm(employeeById.FioShort, num9);
							nameSumm3.SetId(employeeById.id);
							wiolinReportViewModel.ProfitesResult.Add(nameSumm3);
							if (nameSumm3.Id == 19)
							{
								decimal summ = num9 - wiolinReportViewModel.GetBalanceById(2);
								wiolinReportViewModel.ProfitesResultSub.Add(new NameSumm(employeeById.FioShort, summ));
							}
							if (nameSumm3.Id == 20)
							{
								decimal summ2 = num9 - wiolinReportViewModel.GetBalanceById(3);
								wiolinReportViewModel.ProfitesResultSub.Add(new NameSumm(employeeById.FioShort, summ2));
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
					wiolinReportViewModel.SetIsDataLoading(false);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_48F:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003135 RID: 12597 RVA: 0x000A4168 File Offset: 0x000A2368
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C2F RID: 7215
			public int <>1__state;

			// Token: 0x04001C30 RID: 7216
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C31 RID: 7217
			public WiolinReportViewModel <>4__this;

			// Token: 0x04001C32 RID: 7218
			private WiolinReportViewModel.<>c__DisplayClass43_0 <>8__1;

			// Token: 0x04001C33 RID: 7219
			private decimal <totalAdvance>5__2;

			// Token: 0x04001C34 RID: 7220
			private List<object>.Enumerator <>7__wrap2;

			// Token: 0x04001C35 RID: 7221
			private TaskAwaiter<UserSalaryReport> <>u__1;

			// Token: 0x04001C36 RID: 7222
			private payment_systems <paymentSystem>5__4;

			// Token: 0x04001C37 RID: 7223
			private TaskAwaiter<List<cash_orders>> <>u__2;
		}

		// Token: 0x02000522 RID: 1314
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06003136 RID: 12598 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x06003137 RID: 12599 RVA: 0x000A4184 File Offset: 0x000A2384
			internal bool <GetBalanceById>b__0(NameSumm b)
			{
				return b.Id == this.paymentSystemId;
			}

			// Token: 0x04001C38 RID: 7224
			public int paymentSystemId;
		}

		// Token: 0x02000523 RID: 1315
		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x06003138 RID: 12600 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x06003139 RID: 12601 RVA: 0x000A41A0 File Offset: 0x000A23A0
			internal bool <GetEmployeeAdvance>b__0(NameSumm a)
			{
				return a.Id == this.employeeId;
			}

			// Token: 0x04001C39 RID: 7225
			public int employeeId;
		}

		// Token: 0x02000524 RID: 1316
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x0600313A RID: 12602 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x0600313B RID: 12603 RVA: 0x000A41BC File Offset: 0x000A23BC
			internal bool <GetEmployeeById>b__0(users e)
			{
				return e.id == this.employeeId;
			}

			// Token: 0x04001C3A RID: 7226
			public int employeeId;
		}

		// Token: 0x02000525 RID: 1317
		[CompilerGenerated]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x0600313C RID: 12604 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0600313D RID: 12605 RVA: 0x000A41D8 File Offset: 0x000A23D8
			internal bool <GetPaymentSystemById>b__0(payment_systems e)
			{
				return e.system_id == this.paymentSystemId;
			}

			// Token: 0x04001C3B RID: 7227
			public int paymentSystemId;
		}
	}
}
