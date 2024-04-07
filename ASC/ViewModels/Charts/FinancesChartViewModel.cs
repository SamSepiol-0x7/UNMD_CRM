using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Options;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x02000535 RID: 1333
	public class FinancesChartViewModel : BaseViewModel
	{
		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x000A5C98 File Offset: 0x000A3E98
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x000A5CAC File Offset: 0x000A3EAC
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
				int num = 206206941;
				IL_13:
				switch ((num ^ 1872153059) % 4)
				{
				case 1:
					IL_32:
					this.<Period>k__BackingField = value;
					num = 825961223;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000A5D08 File Offset: 0x000A3F08
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x000A5D1C File Offset: 0x000A3F1C
		public List<IPaymentType> TypesList
		{
			[CompilerGenerated]
			get
			{
				return this.<TypesList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TypesList>k__BackingField, value))
				{
					return;
				}
				this.<TypesList>k__BackingField = value;
				this.RaisePropertyChanged("TypesList");
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x000A5D4C File Offset: 0x000A3F4C
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x000A5D60 File Offset: 0x000A3F60
		public ObservableCollection<IChartData> Chart
		{
			[CompilerGenerated]
			get
			{
				return this.<Chart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Chart>k__BackingField, value))
				{
					return;
				}
				this.<Chart>k__BackingField = value;
				this.RaisePropertyChanged("Chart");
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x000A5D90 File Offset: 0x000A3F90
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x000A5DA4 File Offset: 0x000A3FA4
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

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000A5DD0 File Offset: 0x000A3FD0
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x000A5DE4 File Offset: 0x000A3FE4
		public int SelectedPaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedPaymentSystem>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -547789783;
				IL_10:
				switch ((num ^ -908503068) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					this.<SelectedPaymentSystem>k__BackingField = value;
					num = -600803488;
					goto IL_10;
				}
				this.RaisePropertyChanged("SelectedPaymentSystem");
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000A5E3C File Offset: 0x000A403C
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x000A5E50 File Offset: 0x000A4050
		public int SelectedType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedType");
			}
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000A5E7C File Offset: 0x000A407C
		public FinancesChartViewModel()
		{
			this.SetViewName("Report", "Finances");
			this.SelectedPaymentSystem = -100;
			this.Period = new Period();
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
			OrderOptions orderOptions = new OrderOptions();
			this.TypesList = orderOptions.GetOptions4Kassa();
			this.LoadData();
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000A5EF4 File Offset: 0x000A40F4
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000A5F08 File Offset: 0x000A4108
		public void LoadData()
		{
			FinancesChartViewModel.<LoadData>d__26 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<FinancesChartViewModel.<LoadData>d__26>(ref <LoadData>d__);
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x000A5EF4 File Offset: 0x000A40F4
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000A5F40 File Offset: 0x000A4140
		[CompilerGenerated]
		private Task<List<IChartData>> <LoadData>b__26_0()
		{
			return ChartModel.GetFinancesChart(this.Period, this.SelectedOffice, this.SelectedPaymentSystem, this.SelectedType);
		}

		// Token: 0x04001C77 RID: 7287
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001C78 RID: 7288
		[CompilerGenerated]
		private List<IPaymentType> <TypesList>k__BackingField;

		// Token: 0x04001C79 RID: 7289
		[CompilerGenerated]
		private ObservableCollection<IChartData> <Chart>k__BackingField;

		// Token: 0x04001C7A RID: 7290
		[CompilerGenerated]
		private int <SelectedOffice>k__BackingField;

		// Token: 0x04001C7B RID: 7291
		[CompilerGenerated]
		private int <SelectedPaymentSystem>k__BackingField;

		// Token: 0x04001C7C RID: 7292
		[CompilerGenerated]
		private int <SelectedType>k__BackingField;

		// Token: 0x02000536 RID: 1334
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__26 : IAsyncStateMachine
		{
			// Token: 0x060031B0 RID: 12720 RVA: 0x000A5F6C File Offset: 0x000A416C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesChartViewModel financesChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<IChartData>> awaiter;
					if (num != 0)
					{
						financesChartViewModel.ShowWait();
						awaiter = Task.Run<List<IChartData>>(() => ChartModel.GetFinancesChart(base.Period, base.SelectedOffice, base.SelectedPaymentSystem, base.SelectedType)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IChartData>>, FinancesChartViewModel.<LoadData>d__26>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<IChartData>>);
						this.<>1__state = -1;
					}
					List<IChartData> result = awaiter.GetResult();
					financesChartViewModel.Chart = new ObservableCollection<IChartData>(result);
					financesChartViewModel.HideWait();
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

			// Token: 0x060031B1 RID: 12721 RVA: 0x000A6044 File Offset: 0x000A4244
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C7D RID: 7293
			public int <>1__state;

			// Token: 0x04001C7E RID: 7294
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C7F RID: 7295
			public FinancesChartViewModel <>4__this;

			// Token: 0x04001C80 RID: 7296
			private TaskAwaiter<List<IChartData>> <>u__1;
		}
	}
}
