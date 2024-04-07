using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Kassa;
using ASC.Services.Abstract;
using Autofac;
using Autofac.Features.AttributeFilters;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200052B RID: 1323
	public class ZnamenFinancesFlowReportViewModel : BaseViewModel
	{
		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x000A4B30 File Offset: 0x000A2D30
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x000A4B44 File Offset: 0x000A2D44
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

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000A4B74 File Offset: 0x000A2D74
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x000A4BB8 File Offset: 0x000A2DB8
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

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x000A4C20 File Offset: 0x000A2E20
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x000A4C64 File Offset: 0x000A2E64
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

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x000A4CCC File Offset: 0x000A2ECC
		// (set) Token: 0x06003152 RID: 12626 RVA: 0x000A4CE0 File Offset: 0x000A2EE0
		public IFinancesFlowReport Report
		{
			[CompilerGenerated]
			get
			{
				return this.<Report>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Report>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1058312676;
				IL_13:
				switch ((num ^ -1161869029) % 4)
				{
				case 0:
					IL_32:
					this.<Report>k__BackingField = value;
					this.RaisePropertyChanged("Report");
					num = -848198722;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x000A4D3C File Offset: 0x000A2F3C
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x000A4D50 File Offset: 0x000A2F50
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
				if (object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItem>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000A4D80 File Offset: 0x000A2F80
		public ZnamenFinancesFlowReportViewModel([KeyFilter("Znamen")] IFinancesFlowReport flowReport)
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.Period = new Period();
			this.Report = flowReport;
			this.Report.SetPeriod(this.Period);
			this.Report.SetCompany(this.SelectedCompany);
			this.Report.SetOffice(this.SelectedOffice);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.OnPeriodChanged));
			this.SetViewName("Report", "CashFlow");
			base.SetViewLoaded(true);
			this.Refresh();
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000A4E2C File Offset: 0x000A302C
		private void OnCompanyChanged()
		{
			this.Report.SetCompany(this.SelectedCompany);
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000A4E4C File Offset: 0x000A304C
		private void OnOfficeChanged()
		{
			this.Report.SetOffice(this.SelectedOffice);
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000A4E6C File Offset: 0x000A306C
		private void OnPeriodChanged(object sender, EventArgs e)
		{
			this.Report.SetPeriod(this.Period);
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000A4E8C File Offset: 0x000A308C
		[Command]
		public void Refresh()
		{
			ZnamenFinancesFlowReportViewModel.<Refresh>d__23 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<ZnamenFinancesFlowReportViewModel.<Refresh>d__23>(ref <Refresh>d__);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000A4EC4 File Offset: 0x000A30C4
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

		// Token: 0x0600315B RID: 12635 RVA: 0x000A4F28 File Offset: 0x000A3128
		public bool CanItemDoubleClick()
		{
			return this.SelectedItem != null && this.SelectedItem.Type > 0;
		}

		// Token: 0x04001C52 RID: 7250
		private INavigationService _navigationService;

		// Token: 0x04001C53 RID: 7251
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001C54 RID: 7252
		[CompilerGenerated]
		private IFinancesFlowReport <Report>k__BackingField;

		// Token: 0x04001C55 RID: 7253
		[CompilerGenerated]
		private IFinancesFlowReportItem <SelectedItem>k__BackingField;

		// Token: 0x0200052C RID: 1324
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Refresh>d__23 : IAsyncStateMachine
		{
			// Token: 0x0600315C RID: 12636 RVA: 0x000A4F50 File Offset: 0x000A3150
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ZnamenFinancesFlowReportViewModel znamenFinancesFlowReportViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!znamenFinancesFlowReportViewModel.ViewLoaded)
						{
							goto IL_9D;
						}
						znamenFinancesFlowReportViewModel.ShowWait();
						awaiter = znamenFinancesFlowReportViewModel.Report.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ZnamenFinancesFlowReportViewModel.<Refresh>d__23>(ref awaiter, ref this);
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
					znamenFinancesFlowReportViewModel.HideWait();
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

			// Token: 0x0600315D RID: 12637 RVA: 0x000A5020 File Offset: 0x000A3220
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C56 RID: 7254
			public int <>1__state;

			// Token: 0x04001C57 RID: 7255
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C58 RID: 7256
			public ZnamenFinancesFlowReportViewModel <>4__this;

			// Token: 0x04001C59 RID: 7257
			private TaskAwaiter <>u__1;
		}
	}
}
