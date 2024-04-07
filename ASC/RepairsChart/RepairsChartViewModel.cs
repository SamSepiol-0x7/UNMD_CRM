using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.Models;
using ASC.Properties;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RepairsChart
{
	// Token: 0x0200015B RID: 347
	public class RepairsChartViewModel : ChartBaseViewModel
	{
		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x000397FC File Offset: 0x000379FC
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x00039810 File Offset: 0x00037A10
		public List<SalesInfo2> ChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<ChartData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<ChartData>k__BackingField, value))
				{
					return;
				}
				this.<ChartData>k__BackingField = value;
				this.RaisePropertyChanged("ChartData");
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00039840 File Offset: 0x00037A40
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x00039854 File Offset: 0x00037A54
		public List<IDevice> Devices
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

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00039884 File Offset: 0x00037A84
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00039898 File Offset: 0x00037A98
		public List<IManufacturer> DeviceMakers
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceMakers>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<DeviceMakers>k__BackingField, value))
				{
					return;
				}
				this.<DeviceMakers>k__BackingField = value;
				this.RaisePropertyChanged("DeviceMakers");
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x000398C8 File Offset: 0x00037AC8
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x000398DC File Offset: 0x00037ADC
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

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00039908 File Offset: 0x00037B08
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0003991C File Offset: 0x00037B1C
		public int SelectedDeviceMaker
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDeviceMaker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedDeviceMaker>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1613633388;
				IL_10:
				switch ((num ^ 817807753) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<SelectedDeviceMaker>k__BackingField = value;
					num = 714909795;
					goto IL_10;
				}
				this.RaisePropertyChanged("SelectedDeviceMaker");
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00039974 File Offset: 0x00037B74
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00039988 File Offset: 0x00037B88
		public RepairsStat Stat
		{
			[CompilerGenerated]
			get
			{
				return this.<Stat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Stat>k__BackingField, value))
				{
					return;
				}
				this.<Stat>k__BackingField = value;
				this.RaisePropertyChanged("Stat");
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000399B8 File Offset: 0x00037BB8
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x000399CC File Offset: 0x00037BCC
		public int TypeInOut
		{
			get
			{
				return this._typeInOut;
			}
			set
			{
				if (this._typeInOut == value)
				{
					return;
				}
				this._typeInOut = value;
				this.RaisePropertyChanged("TypeInOut");
				this.RefreshChart(null);
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00039A00 File Offset: 0x00037C00
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00039A14 File Offset: 0x00037C14
		public Dictionary<int, string> Types
		{
			[CompilerGenerated]
			get
			{
				return this.<Types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Types>k__BackingField, value))
				{
					return;
				}
				this.<Types>k__BackingField = value;
				this.RaisePropertyChanged("Types");
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00039A44 File Offset: 0x00037C44
		public void InitCommands()
		{
			base.CloseCommand = new DelegateCommand(new Action(this.Close));
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x00039A68 File Offset: 0x00037C68
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x00039AAC File Offset: 0x00037CAC
		public IDevice SelectedDevice
		{
			get
			{
				return base.GetProperty<IDevice>(() => this.SelectedDevice);
			}
			set
			{
				if (object.Equals(this.SelectedDevice, value))
				{
					return;
				}
				base.SetProperty<IDevice>(() => this.SelectedDevice, value, new Action(this.OnDeviceChanged));
				this.RaisePropertyChanged("SelectedDevice");
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00039B18 File Offset: 0x00037D18
		private void OnDeviceChanged()
		{
			RepairsChartViewModel.<OnDeviceChanged>d__38 <OnDeviceChanged>d__;
			<OnDeviceChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnDeviceChanged>d__.<>4__this = this;
			<OnDeviceChanged>d__.<>1__state = -1;
			<OnDeviceChanged>d__.<>t__builder.Start<RepairsChartViewModel.<OnDeviceChanged>d__38>(ref <OnDeviceChanged>d__);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00039B50 File Offset: 0x00037D50
		public RepairsChartViewModel()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this.SetViewName("Report", "Repairs");
			Period period = base.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
			this._model = new ChartModel();
			this.Types = new Dictionary<int, string>
			{
				{
					0,
					"Принятые"
				},
				{
					1,
					"Выданные"
				}
			};
			this.BgInit();
			this.InitCommands();
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00039BF0 File Offset: 0x00037DF0
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			this.BgInit();
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00039C04 File Offset: 0x00037E04
		private void BgInit()
		{
			RepairsChartViewModel.<BgInit>d__41 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<RepairsChartViewModel.<BgInit>d__41>(ref <BgInit>d__);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00039BF0 File Offset: 0x00037DF0
		public override void RefreshChart(object obj)
		{
			this.BgInit();
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00039C3C File Offset: 0x00037E3C
		private void Close()
		{
			if (this.CloseAction != null)
			{
				Settings.Default.Save();
				this.CloseAction();
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00039C68 File Offset: 0x00037E68
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x00039C7C File Offset: 0x00037E7C
		public bool ExcludeZeroFromMinPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<ExcludeZeroFromMinPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ExcludeZeroFromMinPrice>k__BackingField == value)
				{
					return;
				}
				this.<ExcludeZeroFromMinPrice>k__BackingField = value;
				this.RaisePropertyChanged("ExcludeZeroFromMinPrice");
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00039BF0 File Offset: 0x00037DF0
		[Command]
		public void ExcludeZeroChanged()
		{
			this.BgInit();
		}

		// Token: 0x04000B2A RID: 2858
		protected IWorkshopService _workshopService;

		// Token: 0x04000B2B RID: 2859
		private ChartModel _model;

		// Token: 0x04000B2C RID: 2860
		[CompilerGenerated]
		private List<SalesInfo2> <ChartData>k__BackingField;

		// Token: 0x04000B2D RID: 2861
		[CompilerGenerated]
		private List<IDevice> <Devices>k__BackingField;

		// Token: 0x04000B2E RID: 2862
		[CompilerGenerated]
		private List<IManufacturer> <DeviceMakers>k__BackingField;

		// Token: 0x04000B2F RID: 2863
		[CompilerGenerated]
		private int <SelectedDeviceId>k__BackingField;

		// Token: 0x04000B30 RID: 2864
		[CompilerGenerated]
		private int <SelectedDeviceMaker>k__BackingField;

		// Token: 0x04000B31 RID: 2865
		private int _typeInOut;

		// Token: 0x04000B32 RID: 2866
		[CompilerGenerated]
		private RepairsStat <Stat>k__BackingField = new RepairsStat();

		// Token: 0x04000B33 RID: 2867
		[CompilerGenerated]
		private Dictionary<int, string> <Types>k__BackingField;

		// Token: 0x04000B34 RID: 2868
		[CompilerGenerated]
		private bool <ExcludeZeroFromMinPrice>k__BackingField;

		// Token: 0x0200015C RID: 348
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnDeviceChanged>d__38 : IAsyncStateMachine
		{
			// Token: 0x060016C6 RID: 5830 RVA: 0x00039CA8 File Offset: 0x00037EA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairsChartViewModel repairsChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					if (num != 0)
					{
						if (repairsChartViewModel.SelectedDevice == null)
						{
							goto IL_DB;
						}
						if (repairsChartViewModel.SelectedDevice.Id == 0)
						{
							repairsChartViewModel.SelectedDeviceMaker = -1;
							repairsChartViewModel.DeviceMakers = null;
							goto IL_DB;
						}
						repairsChartViewModel.SelectedDeviceMaker = -1;
						awaiter = repairsChartViewModel._workshopService.GetManufacturers(repairsChartViewModel.SelectedDevice.CompanyList).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, RepairsChartViewModel.<OnDeviceChanged>d__38>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
						this.<>1__state = -1;
					}
					IEnumerable<IManufacturer> result = awaiter.GetResult();
					repairsChartViewModel.DeviceMakers = new List<IManufacturer>(result).WithIncludeAll<IManufacturer>();
					repairsChartViewModel.SelectedDeviceMaker = 0;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_DB:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060016C7 RID: 5831 RVA: 0x00039DB4 File Offset: 0x00037FB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B35 RID: 2869
			public int <>1__state;

			// Token: 0x04000B36 RID: 2870
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B37 RID: 2871
			public RepairsChartViewModel <>4__this;

			// Token: 0x04000B38 RID: 2872
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__1;
		}

		// Token: 0x0200015D RID: 349
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__41 : IAsyncStateMachine
		{
			// Token: 0x060016C8 RID: 5832 RVA: 0x00039DD0 File Offset: 0x00037FD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairsChartViewModel repairsChartViewModel = this.<>4__this;
				try
				{
					ConfiguredTaskAwaitable<List<SalesInfo2>>.ConfiguredTaskAwaiter awaiter;
					TaskAwaiter<IEnumerable<IDevice>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(ConfiguredTaskAwaitable<List<SalesInfo2>>.ConfiguredTaskAwaiter);
							this.<>1__state = -1;
							goto IL_10B;
						}
						repairsChartViewModel.ShowWait();
						if (repairsChartViewModel.Devices != null)
						{
							goto IL_BA;
						}
						awaiter2 = repairsChartViewModel._workshopService.GetActiveDevices().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IDevice>>, RepairsChartViewModel.<BgInit>d__41>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IDevice>>);
						this.<>1__state = -1;
					}
					IEnumerable<IDevice> result = awaiter2.GetResult();
					repairsChartViewModel.Devices = new List<IDevice>(result).WithIncludeAll<IDevice>();
					IL_BA:
					IDevice selectedDevice = repairsChartViewModel.SelectedDevice;
					int device = (selectedDevice != null) ? selectedDevice.Id : 0;
					awaiter = repairsChartViewModel._model.LoadRepairsPeriodData(repairsChartViewModel.Period, repairsChartViewModel.SelectedOffice, device, repairsChartViewModel.SelectedDeviceMaker, repairsChartViewModel.TypeInOut).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<SalesInfo2>>.ConfiguredTaskAwaiter, RepairsChartViewModel.<BgInit>d__41>(ref awaiter, ref this);
						return;
					}
					IL_10B:
					List<SalesInfo2> result2 = awaiter.GetResult();
					repairsChartViewModel.ChartData = result2;
					repairsChartViewModel.Stat = ((repairsChartViewModel.TypeInOut == 0) ? repairsChartViewModel._model.LoadInStatistic(repairsChartViewModel.Period, repairsChartViewModel.SelectedDeviceId, repairsChartViewModel.SelectedDeviceMaker) : repairsChartViewModel._model.LoadOutStatistic(repairsChartViewModel.Period, repairsChartViewModel.SelectedDeviceId, repairsChartViewModel.SelectedDeviceMaker, repairsChartViewModel.ExcludeZeroFromMinPrice));
					repairsChartViewModel.HideWait();
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

			// Token: 0x060016C9 RID: 5833 RVA: 0x00039FBC File Offset: 0x000381BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B39 RID: 2873
			public int <>1__state;

			// Token: 0x04000B3A RID: 2874
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000B3B RID: 2875
			public RepairsChartViewModel <>4__this;

			// Token: 0x04000B3C RID: 2876
			private TaskAwaiter<IEnumerable<IDevice>> <>u__1;

			// Token: 0x04000B3D RID: 2877
			private ConfiguredTaskAwaitable<List<SalesInfo2>>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
