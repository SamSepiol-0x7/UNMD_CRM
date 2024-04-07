using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.DataProcessing;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Charts.VisitSource
{
	// Token: 0x0200027C RID: 636
	public class VisitSourceViewModel : ChartBaseViewModel
	{
		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x00062AE4 File Offset: 0x00060CE4
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00062AF8 File Offset: 0x00060CF8
		public List<IVisitSourceChartItem> VisitChart
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitChart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<VisitChart>k__BackingField, value))
				{
					return;
				}
				this.<VisitChart>k__BackingField = value;
				this.RaisePropertyChanged("VisitChart");
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00062B28 File Offset: 0x00060D28
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00062B3C File Offset: 0x00060D3C
		public List<IIdName> Devices
		{
			[CompilerGenerated]
			get
			{
				return this.<Devices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Devices>k__BackingField, value))
				{
					return;
				}
				this.<Devices>k__BackingField = value;
				this.RaisePropertyChanged("Devices");
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00062B6C File Offset: 0x00060D6C
		public ObservableCollection<ICustomer> ChartDetails
		{
			[CompilerGenerated]
			get
			{
				return this.<ChartDetails>k__BackingField;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00062B80 File Offset: 0x00060D80
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x00062B94 File Offset: 0x00060D94
		public int SelectedDeviceId
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDeviceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedDeviceId>k__BackingField == value)
				{
					return;
				}
				this.<SelectedDeviceId>k__BackingField = value;
				this.RaisePropertyChanged("SelectedDeviceId");
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00062BC0 File Offset: 0x00060DC0
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x00062BD4 File Offset: 0x00060DD4
		public ICustomer SelectedItem
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
				int num = -2040361340;
				IL_13:
				switch ((num ^ -1987663731) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<SelectedItem>k__BackingField = value;
					this.RaisePropertyChanged("SelectedItem");
					num = -615279414;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x00062C30 File Offset: 0x00060E30
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x00062C44 File Offset: 0x00060E44
		public ObservableCollection<IVisitSourceChartItem> SelectedVisitSources
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedVisitSources>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedVisitSources>k__BackingField, value))
				{
					return;
				}
				this.<SelectedVisitSources>k__BackingField = value;
				this.RaisePropertyChanged("SelectedVisitSources");
			}
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00062C74 File Offset: 0x00060E74
		public VisitSourceViewModel()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.SetViewName("VisitSources");
			this._model = new ChartModel();
			base.Period = new Period();
			Period period = base.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
			this.ChartDetails = new ObservableCollection<ICustomer>();
			this.SelectedVisitSources = new ObservableCollection<IVisitSourceChartItem>();
			this.SelectedVisitSources.CollectionChanged += this.SelectedItems_CollectionChanged;
			this.BgInit();
			this.LoadData();
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00062D28 File Offset: 0x00060F28
		private void SelectedItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			VisitSourceViewModel.<SelectedItems_CollectionChanged>d__27 <SelectedItems_CollectionChanged>d__;
			<SelectedItems_CollectionChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectedItems_CollectionChanged>d__.<>4__this = this;
			<SelectedItems_CollectionChanged>d__.<>1__state = -1;
			<SelectedItems_CollectionChanged>d__.<>t__builder.Start<VisitSourceViewModel.<SelectedItems_CollectionChanged>d__27>(ref <SelectedItems_CollectionChanged>d__);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00062D60 File Offset: 0x00060F60
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00062D74 File Offset: 0x00060F74
		private void LoadData()
		{
			VisitSourceViewModel.<LoadData>d__29 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<VisitSourceViewModel.<LoadData>d__29>(ref <LoadData>d__);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00062DAC File Offset: 0x00060FAC
		private Task LoadChartDetails()
		{
			VisitSourceViewModel.<LoadChartDetails>d__30 <LoadChartDetails>d__;
			<LoadChartDetails>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadChartDetails>d__.<>4__this = this;
			<LoadChartDetails>d__.<>1__state = -1;
			<LoadChartDetails>d__.<>t__builder.Start<VisitSourceViewModel.<LoadChartDetails>d__30>(ref <LoadChartDetails>d__);
			return <LoadChartDetails>d__.<>t__builder.Task;
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00062DF0 File Offset: 0x00060FF0
		private List<int> GetSelectedIds()
		{
			return (from s in this.SelectedVisitSources
			select s.Id).ToList<int>();
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00062D60 File Offset: 0x00060F60
		public override void RefreshChart(object obj)
		{
			this.LoadData();
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00062E2C File Offset: 0x0006102C
		private void BgInit()
		{
			VisitSourceViewModel.<BgInit>d__33 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<VisitSourceViewModel.<BgInit>d__33>(ref <BgInit>d__);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00062E64 File Offset: 0x00061064
		[Command]
		public void ItemDoubleClick()
		{
			this._navigationService.NavigateToCustomerCard(this.SelectedItem.Id, null);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00062E88 File Offset: 0x00061088
		public bool CanItemDoubleClick()
		{
			return this.SelectedItem != null;
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00062EA0 File Offset: 0x000610A0
		[CompilerGenerated]
		private Task<List<IVisitSourceChartItem>> <LoadData>b__29_0()
		{
			return this._model.LoadVisitChartData(base.Period, base.SelectedOffice, this.SelectedDeviceId);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00062ECC File Offset: 0x000610CC
		[CompilerGenerated]
		private Task<List<CustomerCard>> <LoadChartDetails>b__30_0()
		{
			return this._model.LoadVisitChartDataDetails(base.Period, base.SelectedOffice, this.SelectedDeviceId, this.GetSelectedIds());
		}

		// Token: 0x04001151 RID: 4433
		private readonly IWorkshopService _workshopService;

		// Token: 0x04001152 RID: 4434
		private readonly ChartModel _model;

		// Token: 0x04001153 RID: 4435
		private readonly INavigationService _navigationService;

		// Token: 0x04001154 RID: 4436
		[CompilerGenerated]
		private List<IVisitSourceChartItem> <VisitChart>k__BackingField;

		// Token: 0x04001155 RID: 4437
		[CompilerGenerated]
		private List<IIdName> <Devices>k__BackingField;

		// Token: 0x04001156 RID: 4438
		[CompilerGenerated]
		private readonly ObservableCollection<ICustomer> <ChartDetails>k__BackingField;

		// Token: 0x04001157 RID: 4439
		[CompilerGenerated]
		private int <SelectedDeviceId>k__BackingField;

		// Token: 0x04001158 RID: 4440
		[CompilerGenerated]
		private ICustomer <SelectedItem>k__BackingField;

		// Token: 0x04001159 RID: 4441
		[CompilerGenerated]
		private ObservableCollection<IVisitSourceChartItem> <SelectedVisitSources>k__BackingField;

		// Token: 0x0200027D RID: 637
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectedItems_CollectionChanged>d__27 : IAsyncStateMachine
		{
			// Token: 0x060021EC RID: 8684 RVA: 0x00062EFC File Offset: 0x000610FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VisitSourceViewModel visitSourceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						visitSourceViewModel.ShowWait();
						awaiter = visitSourceViewModel.LoadChartDetails().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, VisitSourceViewModel.<SelectedItems_CollectionChanged>d__27>(ref awaiter, ref this);
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
					visitSourceViewModel.HideWait();
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

			// Token: 0x060021ED RID: 8685 RVA: 0x00062FBC File Offset: 0x000611BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400115A RID: 4442
			public int <>1__state;

			// Token: 0x0400115B RID: 4443
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400115C RID: 4444
			public VisitSourceViewModel <>4__this;

			// Token: 0x0400115D RID: 4445
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200027E RID: 638
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__29 : IAsyncStateMachine
		{
			// Token: 0x060021EE RID: 8686 RVA: 0x00062FD8 File Offset: 0x000611D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VisitSourceViewModel visitSourceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<List<IVisitSourceChartItem>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_BE;
						}
						visitSourceViewModel.ShowWait();
						awaiter2 = Task.Run<List<IVisitSourceChartItem>>(() => visitSourceViewModel._model.LoadVisitChartData(base.Period, base.SelectedOffice, base.SelectedDeviceId)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IVisitSourceChartItem>>, VisitSourceViewModel.<LoadData>d__29>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<IVisitSourceChartItem>>);
						this.<>1__state = -1;
					}
					List<IVisitSourceChartItem> result = awaiter2.GetResult();
					visitSourceViewModel.VisitChart = result;
					awaiter = visitSourceViewModel.LoadChartDetails().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, VisitSourceViewModel.<LoadData>d__29>(ref awaiter, ref this);
						return;
					}
					IL_BE:
					awaiter.GetResult();
					visitSourceViewModel.HideWait();
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

			// Token: 0x060021EF RID: 8687 RVA: 0x00063110 File Offset: 0x00061310
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400115E RID: 4446
			public int <>1__state;

			// Token: 0x0400115F RID: 4447
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001160 RID: 4448
			public VisitSourceViewModel <>4__this;

			// Token: 0x04001161 RID: 4449
			private TaskAwaiter<List<IVisitSourceChartItem>> <>u__1;

			// Token: 0x04001162 RID: 4450
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200027F RID: 639
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadChartDetails>d__30 : IAsyncStateMachine
		{
			// Token: 0x060021F0 RID: 8688 RVA: 0x0006312C File Offset: 0x0006132C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VisitSourceViewModel visitSourceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<CustomerCard>> awaiter;
					if (num != 0)
					{
						visitSourceViewModel.ChartDetails.Clear();
						this.<>7__wrap1 = visitSourceViewModel.ChartDetails;
						awaiter = Task.Run<List<CustomerCard>>(() => visitSourceViewModel._model.LoadVisitChartDataDetails(base.Period, base.SelectedOffice, base.SelectedDeviceId, base.GetSelectedIds())).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<CustomerCard>>, VisitSourceViewModel.<LoadChartDetails>d__30>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<CustomerCard>>);
						this.<>1__state = -1;
					}
					List<CustomerCard> result = awaiter.GetResult();
					this.<>7__wrap1.AddRange(result);
					this.<>7__wrap1 = null;
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

			// Token: 0x060021F1 RID: 8689 RVA: 0x00063218 File Offset: 0x00061418
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001163 RID: 4451
			public int <>1__state;

			// Token: 0x04001164 RID: 4452
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001165 RID: 4453
			public VisitSourceViewModel <>4__this;

			// Token: 0x04001166 RID: 4454
			private IList<ICustomer> <>7__wrap1;

			// Token: 0x04001167 RID: 4455
			private TaskAwaiter<List<CustomerCard>> <>u__1;
		}

		// Token: 0x02000280 RID: 640
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060021F2 RID: 8690 RVA: 0x00063234 File Offset: 0x00061434
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060021F3 RID: 8691 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060021F4 RID: 8692 RVA: 0x0006324C File Offset: 0x0006144C
			internal int <GetSelectedIds>b__31_0(IVisitSourceChartItem s)
			{
				return s.Id;
			}

			// Token: 0x04001168 RID: 4456
			public static readonly VisitSourceViewModel.<>c <>9 = new VisitSourceViewModel.<>c();

			// Token: 0x04001169 RID: 4457
			public static Func<IVisitSourceChartItem, int> <>9__31_0;
		}

		// Token: 0x02000281 RID: 641
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__33 : IAsyncStateMachine
		{
			// Token: 0x060021F5 RID: 8693 RVA: 0x00063260 File Offset: 0x00061460
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VisitSourceViewModel visitSourceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IDevice>> awaiter;
					if (num != 0)
					{
						awaiter = visitSourceViewModel._workshopService.GetActiveDevices().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, VisitSourceViewModel.<BgInit>d__33>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
					}
					IEnumerable<IDevice> result = awaiter.GetResult();
					visitSourceViewModel.Devices = new List<IIdName>(result).WithIncludeAll<IIdName>();
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

			// Token: 0x060021F6 RID: 8694 RVA: 0x0006332C File Offset: 0x0006152C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400116A RID: 4458
			public int <>1__state;

			// Token: 0x0400116B RID: 4459
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400116C RID: 4460
			public VisitSourceViewModel <>4__this;

			// Token: 0x0400116D RID: 4461
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;
		}
	}
}
