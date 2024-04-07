using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200052D RID: 1325
	public class DashboardViewModel : BaseViewModel
	{
		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x000A503C File Offset: 0x000A323C
		// (set) Token: 0x0600315F RID: 12639 RVA: 0x000A5050 File Offset: 0x000A3250
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

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x000A5080 File Offset: 0x000A3280
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x000A5094 File Offset: 0x000A3294
		public DashboardReport Report
		{
			[CompilerGenerated]
			get
			{
				return this.<Report>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Report>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1479580506;
				IL_13:
				switch ((num ^ 897352159) % 4)
				{
				case 0:
					IL_32:
					num = 1444219625;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
				this.<Report>k__BackingField = value;
				this.RaisePropertyChanged("Report");
			}
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000A50F0 File Offset: 0x000A32F0
		public DashboardViewModel()
		{
			this.Period = new Period();
			this.LoadData();
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x000A5114 File Offset: 0x000A3314
		private void LoadData()
		{
			DashboardViewModel.<LoadData>d__9 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<DashboardViewModel.<LoadData>d__9>(ref <LoadData>d__);
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000A514C File Offset: 0x000A334C
		public DashboardReport GetDashboardReport(IPeriod period)
		{
			DashboardReport dashboardReport = new DashboardReport();
			dashboardReport.InCashReport.SetReportName("Приходы");
			dashboardReport.InCashReport.SetDetails(new List<DashboardReportItem>
			{
				new DashboardReportItem("Ремонты", 1100m),
				new DashboardReportItem("Продажи", 2800m),
				new DashboardReportItem("Прочие", 700m)
			});
			dashboardReport.OutCashReport.SetReportName("Расходы");
			dashboardReport.OutCashReport.SetDetails(new List<DashboardReportItem>
			{
				new DashboardReportItem("ПКО без привязки", -18100m),
				new DashboardReportItem("За покупку деталей", -23100m),
				new DashboardReportItem("Прочие", -700m)
			});
			dashboardReport.InPaymentSystems.SetReportName("Приходы по способу оплаты");
			dashboardReport.InPaymentSystems.SetDetails(new List<DashboardReportItem>
			{
				new DashboardReportItem("Наличные", 6100m),
				new DashboardReportItem("Безнал", 800m),
				new DashboardReportItem("Прочие", 50m)
			});
			dashboardReport.OutPaymentSystems.SetReportName("Расходы по способу оплаты");
			dashboardReport.OutPaymentSystems.SetDetails(new List<DashboardReportItem>
			{
				new DashboardReportItem("Наличные", -4900m),
				new DashboardReportItem("Безнал", -800m),
				new DashboardReportItem("Прочие", -7100m)
			});
			return dashboardReport;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x000A5314 File Offset: 0x000A3514
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000A5328 File Offset: 0x000A3528
		[CompilerGenerated]
		private DashboardReport <LoadData>b__9_0()
		{
			return this.GetDashboardReport(this.Period);
		}

		// Token: 0x04001C5A RID: 7258
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001C5B RID: 7259
		[CompilerGenerated]
		private DashboardReport <Report>k__BackingField;

		// Token: 0x0200052E RID: 1326
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__9 : IAsyncStateMachine
		{
			// Token: 0x06003167 RID: 12647 RVA: 0x000A5344 File Offset: 0x000A3544
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DashboardViewModel dashboardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<DashboardReport> awaiter;
					if (num != 0)
					{
						dashboardViewModel.ShowWait();
						awaiter = Task.Run<DashboardReport>(() => base.GetDashboardReport(base.Period)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DashboardReport>, DashboardViewModel.<LoadData>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<DashboardReport>);
						this.<>1__state = -1;
					}
					DashboardReport result = awaiter.GetResult();
					dashboardViewModel.Report = result;
					dashboardViewModel.HideWait();
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

			// Token: 0x06003168 RID: 12648 RVA: 0x000A5418 File Offset: 0x000A3618
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C5C RID: 7260
			public int <>1__state;

			// Token: 0x04001C5D RID: 7261
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C5E RID: 7262
			public DashboardViewModel <>4__this;

			// Token: 0x04001C5F RID: 7263
			private TaskAwaiter<DashboardReport> <>u__1;
		}
	}
}
