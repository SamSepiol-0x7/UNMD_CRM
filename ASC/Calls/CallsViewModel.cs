using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ASC.Charts.CallsChart;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects.VoIP;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Player;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Data;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;

namespace ASC.Calls
{
	// Token: 0x0200029B RID: 667
	public class CallsViewModel : CollectionViewModel<IAscCDR>
	{
		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x00065688 File Offset: 0x00063888
		// (set) Token: 0x06002298 RID: 8856 RVA: 0x0006569C File Offset: 0x0006389C
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x000656CC File Offset: 0x000638CC
		// (set) Token: 0x0600229A RID: 8858 RVA: 0x000656E0 File Offset: 0x000638E0
		public int TotalInCalls
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalInCalls>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (this.<TotalInCalls>k__BackingField == value)
				{
					return;
				}
				this.<TotalInCalls>k__BackingField = value;
				this.RaisePropertyChanged("TotalInCalls");
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x0006570C File Offset: 0x0006390C
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x00065720 File Offset: 0x00063920
		public int TotalOutCalls
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalOutCalls>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (this.<TotalOutCalls>k__BackingField == value)
				{
					return;
				}
				this.<TotalOutCalls>k__BackingField = value;
				this.RaisePropertyChanged("TotalOutCalls");
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x0006574C File Offset: 0x0006394C
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x00065760 File Offset: 0x00063960
		public Dictionary<int, string> Types
		{
			[CompilerGenerated]
			get
			{
				return this.<Types>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<Types>k__BackingField, value))
				{
					return;
				}
				this.<Types>k__BackingField = value;
				this.RaisePropertyChanged("Types");
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00065790 File Offset: 0x00063990
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x000657D4 File Offset: 0x000639D4
		public int SelectedType
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedType);
			}
			set
			{
				if (this.SelectedType == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedType, value, new Action(this.OnTypeChanged));
				this.RaisePropertyChanged("SelectedType");
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0006583C File Offset: 0x00063A3C
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x00065850 File Offset: 0x00063A50
		public ICommand ClosingCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ClosingCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ClosingCommand>k__BackingField, value))
				{
					return;
				}
				this.<ClosingCommand>k__BackingField = value;
				this.RaisePropertyChanged("ClosingCommand");
			}
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00065880 File Offset: 0x00063A80
		private void InitCommands()
		{
			this.ClosingCommand = new RelayCommand(new Action<object>(this.Closing));
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000658A4 File Offset: 0x00063AA4
		public CallsViewModel()
		{
			this.CallService = Bootstrapper.Container.Resolve<ICallService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._customerService = Bootstrapper.Container.Resolve<ICustomerService>();
			this.SetViewName("Calls");
			this.Period = new Period(CallsViewModel.Localization.NowDate, CallsViewModel.Localization.NowDate);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.Refresh));
			this.Types = this.CallService.GetDirections();
			this.InitCommands();
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00065978 File Offset: 0x00063B78
		public override void OnLoad()
		{
			base.OnLoad();
			base.SetViewLoaded(true);
			this.BgInit();
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00065998 File Offset: 0x00063B98
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem.Customer == null)
			{
				goto IL_31;
			}
			IL_0D:
			int num = -143225048;
			IL_12:
			switch ((num ^ -1409634693) % 4)
			{
			case 0:
				goto IL_0D;
			case 1:
			{
				IL_31:
				string customerTelFromSelectedItem = this.GetCustomerTelFromSelectedItem();
				this._windowedDocumentService.ShowNewDocument("NewCustomerCallView", new NewCustomerCallViewModel(customerTelFromSelectedItem), null, null);
				num = -1728499527;
				goto IL_12;
			}
			case 3:
				this.NavigateToCustomerCard(base.SelectedItem.Customer.Id);
				return;
			}
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00065A14 File Offset: 0x00063C14
		private string GetCustomerTelFromSelectedItem()
		{
			if (!base.SelectedItem.IsIncoming)
			{
				return base.SelectedItem.Destination;
			}
			return base.SelectedItem.Src;
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00065A48 File Offset: 0x00063C48
		private void NavigateToCustomerCard(int customerId)
		{
			this._navigationService.NavigateToCustomerCard(customerId, null);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool CanItemDoubleClick()
		{
			return OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000407D8 File Offset: 0x0003E9D8
		private void Closing(object obj)
		{
			Settings.Default.Save();
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00065A64 File Offset: 0x00063C64
		[Command]
		public void OpenReport()
		{
			this._navigationService.Navigate("CallsChartView", new CallsChartViewModel());
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanOpenReport()
		{
			return false;
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00065A88 File Offset: 0x00063C88
		[Command]
		public void CustomSummary(GridCustomSummaryEventArgs e)
		{
			GridSummaryItem gridSummaryItem = e.Item as GridSummaryItem;
			if (gridSummaryItem != null && e.IsTotalSummary)
			{
				if (e.SummaryProcess == CustomSummaryProcess.Start && gridSummaryItem.FieldName == "Duration")
				{
					this._durationTotal = 0;
				}
				if (e.SummaryProcess == CustomSummaryProcess.Calculate)
				{
					if (e.FieldValue == null)
					{
						return;
					}
					int num;
					int.TryParse(e.FieldValue.ToString(), out num);
					if (gridSummaryItem.FieldName == "Duration" && num >= 0)
					{
						this._durationTotal += num;
					}
				}
				if (e.SummaryProcess == CustomSummaryProcess.Finalize)
				{
					if (this.isSummaryFistRun)
					{
						this.isSummaryFistRun = false;
						e.Source.UpdateTotalSummary();
					}
					TimeSpan timeSpan = TimeSpan.FromSeconds((double)this._durationTotal);
					e.TotalValue = string.Format("{0:d2}:{1:d2}:{2:d2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
				}
			}
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00065B84 File Offset: 0x00063D84
		[Command]
		public void Play(IAscCDR record)
		{
			CallsViewModel.<Play>d__42 <Play>d__;
			<Play>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Play>d__.<>4__this = this;
			<Play>d__.record = record;
			<Play>d__.<>1__state = -1;
			<Play>d__.<>t__builder.Start<CallsViewModel.<Play>d__42>(ref <Play>d__);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00065BC4 File Offset: 0x00063DC4
		[Command]
		public void Refresh()
		{
			this.BgInit();
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00065BD8 File Offset: 0x00063DD8
		private void Refresh(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00065BD8 File Offset: 0x00063DD8
		private void OnTypeChanged()
		{
			this.Refresh();
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00065BEC File Offset: 0x00063DEC
		public virtual void BgInit()
		{
			CallsViewModel.<BgInit>d__46 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<CallsViewModel.<BgInit>d__46>(ref <BgInit>d__);
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00065C24 File Offset: 0x00063E24
		private void CalcTotalInCalls()
		{
			this.TotalInCalls = base.Items.Count((IAscCDR i) => i.IsIncoming);
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00065C64 File Offset: 0x00063E64
		private void CalcTotalOutCalls()
		{
			this.TotalOutCalls = base.Items.Count((IAscCDR i) => !i.IsIncoming);
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00065CA4 File Offset: 0x00063EA4
		// Note: this type is marked as 'beforefieldinit'.
		static CallsViewModel()
		{
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00065CC0 File Offset: 0x00063EC0
		[CompilerGenerated]
		private Task<IEnumerable<IAscCDR>> <BgInit>b__46_1()
		{
			return Core.Instance.VoIP.GetCdr(this.Period, (CallType)this.SelectedType);
		}

		// Token: 0x040011DA RID: 4570
		private readonly INavigationService _navigationService;

		// Token: 0x040011DB RID: 4571
		protected IToasterService _toasterService;

		// Token: 0x040011DC RID: 4572
		protected ICallService CallService;

		// Token: 0x040011DD RID: 4573
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040011DE RID: 4574
		private readonly ICustomerService _customerService;

		// Token: 0x040011DF RID: 4575
		private static readonly Localization Localization = new Localization("UTC");

		// Token: 0x040011E0 RID: 4576
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x040011E1 RID: 4577
		[CompilerGenerated]
		private int <TotalInCalls>k__BackingField;

		// Token: 0x040011E2 RID: 4578
		[CompilerGenerated]
		private int <TotalOutCalls>k__BackingField;

		// Token: 0x040011E3 RID: 4579
		[CompilerGenerated]
		private Dictionary<int, string> <Types>k__BackingField;

		// Token: 0x040011E4 RID: 4580
		[CompilerGenerated]
		private ICommand <ClosingCommand>k__BackingField;

		// Token: 0x040011E5 RID: 4581
		private bool isSummaryFistRun = true;

		// Token: 0x040011E6 RID: 4582
		private int _durationTotal;

		// Token: 0x0200029C RID: 668
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x060022B7 RID: 8887 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x060022B8 RID: 8888 RVA: 0x00065CE8 File Offset: 0x00063EE8
			internal Task<RecordRequest> <Play>b__0()
			{
				return Core.Instance.VoIP.RecordRequest(this.record);
			}

			// Token: 0x040011E7 RID: 4583
			public IAscCDR record;
		}

		// Token: 0x0200029D RID: 669
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Play>d__42 : IAsyncStateMachine
		{
			// Token: 0x060022B9 RID: 8889 RVA: 0x00065D0C File Offset: 0x00063F0C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CallsViewModel callsViewModel = this.<>4__this;
				try
				{
					CallsViewModel.<>c__DisplayClass42_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CallsViewModel.<>c__DisplayClass42_0();
						CS$<>8__locals1.record = this.record;
						if (CS$<>8__locals1.record == null)
						{
							goto IL_F7;
						}
						callsViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<RecordRequest> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<RecordRequest>(new Func<Task<RecordRequest>>(CS$<>8__locals1.<Play>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RecordRequest>, CallsViewModel.<Play>d__42>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<RecordRequest>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						PlayerView playerView = new PlayerView(awaiter.GetResult().Link);
						playerView.Show();
						playerView.Play();
					}
					catch (Exception ex)
					{
						callsViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							callsViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_F7:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060022BA RID: 8890 RVA: 0x00065E4C File Offset: 0x0006404C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040011E8 RID: 4584
			public int <>1__state;

			// Token: 0x040011E9 RID: 4585
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040011EA RID: 4586
			public IAscCDR record;

			// Token: 0x040011EB RID: 4587
			public CallsViewModel <>4__this;

			// Token: 0x040011EC RID: 4588
			private TaskAwaiter<RecordRequest> <>u__1;
		}

		// Token: 0x0200029E RID: 670
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060022BB RID: 8891 RVA: 0x00065E68 File Offset: 0x00064068
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060022BC RID: 8892 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060022BD RID: 8893 RVA: 0x00065E80 File Offset: 0x00064080
			internal bool <BgInit>b__46_0(Employee i)
			{
				return i.Tel != null;
			}

			// Token: 0x060022BE RID: 8894 RVA: 0x00065E9C File Offset: 0x0006409C
			internal bool <CalcTotalInCalls>b__47_0(IAscCDR i)
			{
				return i.IsIncoming;
			}

			// Token: 0x060022BF RID: 8895 RVA: 0x00065EB0 File Offset: 0x000640B0
			internal bool <CalcTotalOutCalls>b__48_0(IAscCDR i)
			{
				return !i.IsIncoming;
			}

			// Token: 0x040011ED RID: 4589
			public static readonly CallsViewModel.<>c <>9 = new CallsViewModel.<>c();

			// Token: 0x040011EE RID: 4590
			public static Func<Employee, bool> <>9__46_0;

			// Token: 0x040011EF RID: 4591
			public static Func<IAscCDR, bool> <>9__47_0;

			// Token: 0x040011F0 RID: 4592
			public static Func<IAscCDR, bool> <>9__48_0;
		}

		// Token: 0x0200029F RID: 671
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__46 : IAsyncStateMachine
		{
			// Token: 0x060022C0 RID: 8896 RVA: 0x00065EC8 File Offset: 0x000640C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CallsViewModel callsViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						if (!callsViewModel.ViewLoaded)
						{
							goto IL_1EE;
						}
						callsViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<IEnumerable<IAscCDR>> awaiter;
						TaskAwaiter<List<clients>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<IEnumerable<IAscCDR>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_116;
							}
							awaiter2 = callsViewModel._customerService.GetCustomersAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<clients>>, CallsViewModel.<BgInit>d__46>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<clients>>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						List<clients> result = awaiter2.GetResult();
						this.<customers>5__2 = result;
						this.<employees>5__3 = OfflineData.Instance.ActiveUsers.Where(new Func<Employee, bool>(CallsViewModel.<>c.<>9.<BgInit>b__46_0)).ToList<Employee>();
						awaiter = Task.Run<IEnumerable<IAscCDR>>(() => Core.Instance.VoIP.GetCdr(base.Period, (CallType)base.SelectedType)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscCDR>>, CallsViewModel.<BgInit>d__46>(ref awaiter, ref this);
							return;
						}
						IL_116:
						IEnumerable<IAscCDR> result2 = awaiter.GetResult();
						IEnumerator<IAscCDR> enumerator = result2.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								IAscCDR ascCDR = enumerator.Current;
								((AscCDR)ascCDR).TryIdentityCustomer(this.<customers>5__2);
								((AscCDR)ascCDR).TryIdentityEmployee(this.<employees>5__3);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						callsViewModel.SetItems(result2);
						callsViewModel.CalcTotalInCalls();
						callsViewModel.CalcTotalOutCalls();
						this.<customers>5__2 = null;
						this.<employees>5__3 = null;
					}
					catch (Exception ex)
					{
						callsViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							callsViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1EE:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060022C1 RID: 8897 RVA: 0x0006613C File Offset: 0x0006433C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040011F1 RID: 4593
			public int <>1__state;

			// Token: 0x040011F2 RID: 4594
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040011F3 RID: 4595
			public CallsViewModel <>4__this;

			// Token: 0x040011F4 RID: 4596
			private List<clients> <customers>5__2;

			// Token: 0x040011F5 RID: 4597
			private List<Employee> <employees>5__3;

			// Token: 0x040011F6 RID: 4598
			private TaskAwaiter<List<clients>> <>u__1;

			// Token: 0x040011F7 RID: 4599
			private TaskAwaiter<IEnumerable<IAscCDR>> <>u__2;
		}
	}
}
