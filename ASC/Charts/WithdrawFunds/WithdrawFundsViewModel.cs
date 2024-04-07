using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Services.Abstract;
using ASC.ViewModels;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Charts.WithdrawFunds
{
	// Token: 0x02000284 RID: 644
	public class WithdrawFundsViewModel : BaseViewModel
	{
		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x00063420 File Offset: 0x00061620
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x00063434 File Offset: 0x00061634
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
				if (!object.Equals(this.<Period>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1146493471;
				IL_13:
				switch ((num ^ 1458957134) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<Period>k__BackingField = value;
					this.RaisePropertyChanged("Period");
					num = 327518754;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x00063490 File Offset: 0x00061690
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x000634A4 File Offset: 0x000616A4
		public ObservableCollection<cash_orders> Data
		{
			[CompilerGenerated]
			get
			{
				return this.<Data>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Data>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -323104828;
				IL_13:
				switch ((num ^ -381682375) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<Data>k__BackingField = value;
					this.RaisePropertyChanged("Data");
					num = -261171643;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x00063500 File Offset: 0x00061700
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x00063514 File Offset: 0x00061714
		public Dictionary<DateTime, int> ChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<ChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ChartData>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1459541635;
				IL_13:
				switch ((num ^ 671077366) % 4)
				{
				case 0:
					IL_32:
					this.<ChartData>k__BackingField = value;
					this.RaisePropertyChanged("ChartData");
					num = 1030480684;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x00063570 File Offset: 0x00061770
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x00063584 File Offset: 0x00061784
		public int SelectedOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedOffice>k__BackingField == value)
				{
					return;
				}
				this.<SelectedOffice>k__BackingField = value;
				this.RaisePropertyChanged("SelectedOffice");
			}
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000635B0 File Offset: 0x000617B0
		public WithdrawFundsViewModel(IReportsService reportsService)
		{
			this._reportsService = reportsService;
			this.SetViewName("WithdrawOrDepositFunds");
			this.Period = new Period(this._localization.Now.AddMonths(-1), this._localization.Now);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.Refresh));
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00063638 File Offset: 0x00061838
		private Task LoadData()
		{
			WithdrawFundsViewModel.<LoadData>d__20 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<WithdrawFundsViewModel.<LoadData>d__20>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0006367C File Offset: 0x0006187C
		public override void OnLoad()
		{
			WithdrawFundsViewModel.<OnLoad>d__21 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<WithdrawFundsViewModel.<OnLoad>d__21>(ref <OnLoad>d__);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000636B4 File Offset: 0x000618B4
		private void Refresh(object sender, EventArgs e)
		{
			WithdrawFundsViewModel.<Refresh>d__22 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<WithdrawFundsViewModel.<Refresh>d__22>(ref <Refresh>d__);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000636EC File Offset: 0x000618EC
		[AsyncCommand]
		public Task Refresh()
		{
			WithdrawFundsViewModel.<Refresh>d__23 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<WithdrawFundsViewModel.<Refresh>d__23>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00063730 File Offset: 0x00061930
		[CompilerGenerated]
		private Task<IList<cash_orders>> <LoadData>b__20_0()
		{
			return this._reportsService.LoadWithdrawFundsTableData(this.Period, this.SelectedOffice);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x00063754 File Offset: 0x00061954
		[CompilerGenerated]
		private Task<Dictionary<DateTime, int>> <LoadData>b__20_1()
		{
			return ChartModel.LoadWithdrawFundsChartData(this.Period, this.SelectedOffice);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001172 RID: 4466
		private Localization _localization = new Localization("UTC");

		// Token: 0x04001173 RID: 4467
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001174 RID: 4468
		public Action CloseAction;

		// Token: 0x04001175 RID: 4469
		private readonly IReportsService _reportsService;

		// Token: 0x04001176 RID: 4470
		[CompilerGenerated]
		private ObservableCollection<cash_orders> <Data>k__BackingField;

		// Token: 0x04001177 RID: 4471
		[CompilerGenerated]
		private Dictionary<DateTime, int> <ChartData>k__BackingField;

		// Token: 0x04001178 RID: 4472
		[CompilerGenerated]
		private int <SelectedOffice>k__BackingField;

		// Token: 0x02000285 RID: 645
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__20 : IAsyncStateMachine
		{
			// Token: 0x06002211 RID: 8721 RVA: 0x00063774 File Offset: 0x00061974
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WithdrawFundsViewModel withdrawFundsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Dictionary<DateTime, int>> awaiter;
					TaskAwaiter<IList<cash_orders>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<Dictionary<DateTime, int>>);
							this.<>1__state = -1;
							goto IL_D1;
						}
						withdrawFundsViewModel.ShowWait();
						awaiter2 = Task.Run<IList<cash_orders>>(() => withdrawFundsViewModel._reportsService.LoadWithdrawFundsTableData(base.Period, base.SelectedOffice)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<cash_orders>>, WithdrawFundsViewModel.<LoadData>d__20>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IList<cash_orders>>);
						this.<>1__state = -1;
					}
					IList<cash_orders> result = awaiter2.GetResult();
					withdrawFundsViewModel.Data = new ObservableCollection<cash_orders>(result);
					awaiter = Task.Run<Dictionary<DateTime, int>>(() => ChartModel.LoadWithdrawFundsChartData(base.Period, base.SelectedOffice)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<DateTime, int>>, WithdrawFundsViewModel.<LoadData>d__20>(ref awaiter, ref this);
						return;
					}
					IL_D1:
					Dictionary<DateTime, int> result2 = awaiter.GetResult();
					withdrawFundsViewModel.ChartData = result2;
					withdrawFundsViewModel.HideWait();
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

			// Token: 0x06002212 RID: 8722 RVA: 0x000638C8 File Offset: 0x00061AC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001179 RID: 4473
			public int <>1__state;

			// Token: 0x0400117A RID: 4474
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400117B RID: 4475
			public WithdrawFundsViewModel <>4__this;

			// Token: 0x0400117C RID: 4476
			private TaskAwaiter<IList<cash_orders>> <>u__1;

			// Token: 0x0400117D RID: 4477
			private TaskAwaiter<Dictionary<DateTime, int>> <>u__2;
		}

		// Token: 0x02000286 RID: 646
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__21 : IAsyncStateMachine
		{
			// Token: 0x06002213 RID: 8723 RVA: 0x000638E4 File Offset: 0x00061AE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WithdrawFundsViewModel withdrawFundsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = withdrawFundsViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WithdrawFundsViewModel.<OnLoad>d__21>(ref awaiter, ref this);
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
					withdrawFundsViewModel.<>n__0();
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

			// Token: 0x06002214 RID: 8724 RVA: 0x0006399C File Offset: 0x00061B9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400117E RID: 4478
			public int <>1__state;

			// Token: 0x0400117F RID: 4479
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001180 RID: 4480
			public WithdrawFundsViewModel <>4__this;

			// Token: 0x04001181 RID: 4481
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000287 RID: 647
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Refresh>d__22 : IAsyncStateMachine
		{
			// Token: 0x06002215 RID: 8725 RVA: 0x000639B8 File Offset: 0x00061BB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WithdrawFundsViewModel withdrawFundsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = withdrawFundsViewModel.Refresh().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WithdrawFundsViewModel.<Refresh>d__22>(ref awaiter, ref this);
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

			// Token: 0x06002216 RID: 8726 RVA: 0x00063A6C File Offset: 0x00061C6C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001182 RID: 4482
			public int <>1__state;

			// Token: 0x04001183 RID: 4483
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001184 RID: 4484
			public WithdrawFundsViewModel <>4__this;

			// Token: 0x04001185 RID: 4485
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000288 RID: 648
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Refresh>d__23 : IAsyncStateMachine
		{
			// Token: 0x06002217 RID: 8727 RVA: 0x00063A88 File Offset: 0x00061C88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WithdrawFundsViewModel withdrawFundsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = withdrawFundsViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WithdrawFundsViewModel.<Refresh>d__23>(ref awaiter, ref this);
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

			// Token: 0x06002218 RID: 8728 RVA: 0x00063B3C File Offset: 0x00061D3C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001186 RID: 4486
			public int <>1__state;

			// Token: 0x04001187 RID: 4487
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001188 RID: 4488
			public WithdrawFundsViewModel <>4__this;

			// Token: 0x04001189 RID: 4489
			private TaskAwaiter <>u__1;
		}
	}
}
