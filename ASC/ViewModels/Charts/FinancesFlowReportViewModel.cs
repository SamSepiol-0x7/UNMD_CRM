using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Kassa;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200051A RID: 1306
	public class FinancesFlowReportViewModel : BaseViewModel
	{
		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x000A2E88 File Offset: 0x000A1088
		// (set) Token: 0x060030F2 RID: 12530 RVA: 0x000A2E9C File Offset: 0x000A109C
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
				int num = 1238284418;
				IL_13:
				switch ((num ^ 1272224808) % 4)
				{
				case 1:
					IL_32:
					this.<Period>k__BackingField = value;
					this.RaisePropertyChanged("Period");
					num = 531819784;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000A2EF8 File Offset: 0x000A10F8
		// (set) Token: 0x060030F4 RID: 12532 RVA: 0x000A2F3C File Offset: 0x000A113C
		public int SelectedCompany
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedCompany);
			}
			set
			{
				if (this.SelectedCompany == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedCompany, value, new Action(this.OnCompanyChanged));
				this.RaisePropertyChanged("SelectedCompany");
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x000A2FA4 File Offset: 0x000A11A4
		// (set) Token: 0x060030F6 RID: 12534 RVA: 0x000A2FE8 File Offset: 0x000A11E8
		public int SelectedOffice
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedOffice);
			}
			set
			{
				if (this.SelectedOffice == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedOffice, value, new Action(this.OnOfficeChanged));
				this.RaisePropertyChanged("SelectedOffice");
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x000A3050 File Offset: 0x000A1250
		// (set) Token: 0x060030F8 RID: 12536 RVA: 0x000A3064 File Offset: 0x000A1264
		public FinancesFlowReport Report
		{
			[CompilerGenerated]
			get
			{
				return this.<Report>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Report>k__BackingField, value))
				{
					return;
				}
				this.<Report>k__BackingField = value;
				this.RaisePropertyChanged("Report");
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000A3094 File Offset: 0x000A1294
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x000A30A8 File Offset: 0x000A12A8
		public IFinancesFlowReportItem SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1729119055;
				IL_13:
				switch ((num ^ -762545689) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<SelectedItem>k__BackingField = value;
					num = -1830105920;
					goto IL_13;
				case 2:
					return;
				}
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000A3104 File Offset: 0x000A1304
		public FinancesFlowReportViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.Period = new Period();
			this.Report = new FinancesFlowReport();
			this.Report.SetPeriod(this.Period);
			this.Report.SetCompany(this.SelectedCompany);
			this.Report.SetOffice(this.SelectedOffice);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.OnPeriodChanged));
			this.SetViewName("CashFlow");
			base.SetViewLoaded(true);
			this.Refresh();
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000A31B0 File Offset: 0x000A13B0
		private void OnCompanyChanged()
		{
			this.Report.SetCompany(this.SelectedCompany);
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000A31D0 File Offset: 0x000A13D0
		private void OnOfficeChanged()
		{
			this.Report.SetOffice(this.SelectedOffice);
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x000A31F0 File Offset: 0x000A13F0
		private void OnPeriodChanged(object sender, EventArgs e)
		{
			this.Report.SetPeriod(this.Period);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000A3210 File Offset: 0x000A1410
		[Command]
		public void Refresh()
		{
			FinancesFlowReportViewModel.<Refresh>d__23 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<FinancesFlowReportViewModel.<Refresh>d__23>(ref <Refresh>d__);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000A3248 File Offset: 0x000A1448
		[Command]
		public void ItemDoubleClick()
		{
			KassaViewModel kassaViewModel = Bootstrapper.Container.Resolve<KassaViewModel>();
			kassaViewModel.SelectedOffice = this.SelectedOffice;
			kassaViewModel.SelectedCompany = this.SelectedCompany;
			kassaViewModel.SetPeriod(this.Period);
			kassaViewModel.SelectedType = this.SelectedItem.Type;
			kassaViewModel.Refresh();
			this._navigationService.Navigate("KassaView", kassaViewModel);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000A32AC File Offset: 0x000A14AC
		public bool CanItemDoubleClick()
		{
			return this.SelectedItem != null && this.SelectedItem.Type > 0;
		}

		// Token: 0x04001C08 RID: 7176
		private INavigationService _navigationService;

		// Token: 0x04001C09 RID: 7177
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001C0A RID: 7178
		[CompilerGenerated]
		private FinancesFlowReport <Report>k__BackingField;

		// Token: 0x04001C0B RID: 7179
		[CompilerGenerated]
		private IFinancesFlowReportItem <SelectedItem>k__BackingField;

		// Token: 0x0200051B RID: 1307
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Refresh>d__23 : IAsyncStateMachine
		{
			// Token: 0x06003102 RID: 12546 RVA: 0x000A32D4 File Offset: 0x000A14D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesFlowReportViewModel financesFlowReportViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!financesFlowReportViewModel.ViewLoaded)
						{
							goto IL_9D;
						}
						financesFlowReportViewModel.ShowWait();
						awaiter = financesFlowReportViewModel.Report.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesFlowReportViewModel.<Refresh>d__23>(ref awaiter, ref this);
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
					financesFlowReportViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_9D:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003103 RID: 12547 RVA: 0x000A33A4 File Offset: 0x000A15A4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C0C RID: 7180
			public int <>1__state;

			// Token: 0x04001C0D RID: 7181
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C0E RID: 7182
			public FinancesFlowReportViewModel <>4__this;

			// Token: 0x04001C0F RID: 7183
			private TaskAwaiter <>u__1;
		}
	}
}
