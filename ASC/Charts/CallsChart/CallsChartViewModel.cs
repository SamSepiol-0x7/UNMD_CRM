using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using ASC.Models;
using ASC.Options;
using ASC.Properties;
using ASC.ViewModels;
using DevExpress.Mvvm;

namespace ASC.Charts.CallsChart
{
	// Token: 0x02000278 RID: 632
	public class CallsChartViewModel : ChartBaseViewModel
	{
		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x00061D5C File Offset: 0x0005FF5C
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x00061D70 File Offset: 0x0005FF70
		public Dictionary<string, int> ChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<ChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ChartData>k__BackingField, value))
				{
					return;
				}
				this.<ChartData>k__BackingField = value;
				this.RaisePropertyChanged("ChartData");
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x00061DA0 File Offset: 0x0005FFA0
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x00061DB4 File Offset: 0x0005FFB4
		public Dictionary<int, string> ClientTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ClientTypes>k__BackingField, value))
				{
					return;
				}
				this.<ClientTypes>k__BackingField = value;
				this.RaisePropertyChanged("ClientTypes");
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x00061DE4 File Offset: 0x0005FFE4
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x00061DF8 File Offset: 0x0005FFF8
		public int TotalCalls
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalCalls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalCalls>k__BackingField == value)
				{
					return;
				}
				this.<TotalCalls>k__BackingField = value;
				this.RaisePropertyChanged("TotalCalls");
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x00061E24 File Offset: 0x00060024
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x00061E38 File Offset: 0x00060038
		public int TotalInCalls
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalInCalls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalInCalls>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1237992184;
				IL_10:
				switch ((num ^ -475345509) % 4)
				{
				case 0:
					IL_2F:
					this.<TotalInCalls>k__BackingField = value;
					this.RaisePropertyChanged("TotalInCalls");
					num = -1134342246;
					goto IL_10;
				case 2:
					goto IL_0B;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00061E90 File Offset: 0x00060090
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x00061EA4 File Offset: 0x000600A4
		public int TotalOutCalls
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalOutCalls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalOutCalls>k__BackingField == value)
				{
					return;
				}
				this.<TotalOutCalls>k__BackingField = value;
				this.RaisePropertyChanged("TotalOutCalls");
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00061ED0 File Offset: 0x000600D0
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00061EE4 File Offset: 0x000600E4
		public int InCallsNoAnswer
		{
			[CompilerGenerated]
			get
			{
				return this.<InCallsNoAnswer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InCallsNoAnswer>k__BackingField == value)
				{
					return;
				}
				this.<InCallsNoAnswer>k__BackingField = value;
				this.RaisePropertyChanged("InCallsNoAnswer");
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00061F10 File Offset: 0x00060110
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x00061F24 File Offset: 0x00060124
		public string TotalCallsLenght
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalCallsLenght>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<TotalCallsLenght>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TotalCallsLenght>k__BackingField = value;
				this.RaisePropertyChanged("TotalCallsLenght");
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00061F54 File Offset: 0x00060154
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00061F68 File Offset: 0x00060168
		public string AverageDuration
		{
			[CompilerGenerated]
			get
			{
				return this.<AverageDuration>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<AverageDuration>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1205517970;
				IL_14:
				switch ((num ^ 99181433) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					this.<AverageDuration>k__BackingField = value;
					num = 989587635;
					goto IL_14;
				case 3:
					return;
				}
				this.RaisePropertyChanged("AverageDuration");
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x00061FC4 File Offset: 0x000601C4
		public Visibility IoVisibility
		{
			get
			{
				if (this.SelectedOption != 1)
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x00061FE0 File Offset: 0x000601E0
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x00061FF4 File Offset: 0x000601F4
		public List<CallsOptions> Optionses
		{
			[CompilerGenerated]
			get
			{
				return this.<Optionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Optionses>k__BackingField, value))
				{
					return;
				}
				this.<Optionses>k__BackingField = value;
				this.RaisePropertyChanged("Optionses");
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00062024 File Offset: 0x00060224
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x00062038 File Offset: 0x00060238
		public List<users> Users
		{
			[CompilerGenerated]
			get
			{
				return this.<Users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Users>k__BackingField, value))
				{
					return;
				}
				this.<Users>k__BackingField = value;
				this.RaisePropertyChanged("Users");
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00062068 File Offset: 0x00060268
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x0006207C File Offset: 0x0006027C
		public List<voip_ext_devices> VoipExtDeviceses
		{
			[CompilerGenerated]
			get
			{
				return this.<VoipExtDeviceses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<VoipExtDeviceses>k__BackingField, value))
				{
					return;
				}
				this.<VoipExtDeviceses>k__BackingField = value;
				this.RaisePropertyChanged("VoipExtDeviceses");
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x000620AC File Offset: 0x000602AC
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x000620C0 File Offset: 0x000602C0
		public voip_ext_devices SelectedExtDevice
		{
			get
			{
				return this._selectedExtDevice;
			}
			set
			{
				if (object.Equals(this._selectedExtDevice, value))
				{
					return;
				}
				this._selectedExtDevice = value;
				this.RaisePropertyChanged("SelectedExtDevice");
				this.RefreshChart(null);
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000620F8 File Offset: 0x000602F8
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0006210C File Offset: 0x0006030C
		public users SelectedUser
		{
			get
			{
				return this._selectedUser;
			}
			set
			{
				if (object.Equals(this._selectedUser, value))
				{
					return;
				}
				this._selectedUser = value;
				this.RaisePropertyChanged("SelectedUser");
				this.RefreshChart(null);
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00062144 File Offset: 0x00060344
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x00062158 File Offset: 0x00060358
		public int SelectedOption
		{
			get
			{
				return this._selectedOption;
			}
			set
			{
				if (this._selectedOption == value)
				{
					return;
				}
				this._selectedOption = value;
				this.RaisePropertyChanged("IoVisibility");
				this.RaisePropertyChanged("SelectedOption");
				this.RefreshChart(null);
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00062198 File Offset: 0x00060398
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x000621AC File Offset: 0x000603AC
		public int CallClientType
		{
			[CompilerGenerated]
			get
			{
				return this.<CallClientType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CallClientType>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 311293349;
				IL_10:
				switch ((num ^ 1648185504) % 4)
				{
				case 0:
					IL_2F:
					this.<CallClientType>k__BackingField = value;
					this.RaisePropertyChanged("CallClientType");
					num = 734074631;
					goto IL_10;
				case 1:
					return;
				case 2:
					goto IL_0B;
				}
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x00062204 File Offset: 0x00060404
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x00062218 File Offset: 0x00060418
		public DelegateCommand WindowClosingCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<WindowClosingCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WindowClosingCommand>k__BackingField, value))
				{
					return;
				}
				this.<WindowClosingCommand>k__BackingField = value;
				this.RaisePropertyChanged("WindowClosingCommand");
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00062248 File Offset: 0x00060448
		private void InitCommands()
		{
			base.CloseCommand = new DelegateCommand(new Action(this.Close));
			this.WindowClosingCommand = new DelegateCommand(new Action(this.Closing));
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00062284 File Offset: 0x00060484
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00062298 File Offset: 0x00060498
		private ChartModel Model
		{
			[CompilerGenerated]
			get
			{
				return this.<Model>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Model>k__BackingField, value))
				{
					return;
				}
				this.<Model>k__BackingField = value;
				this.RaisePropertyChanged("Model");
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000622C8 File Offset: 0x000604C8
		public CallsChartViewModel()
		{
			this.SetViewName("CallsChartTitle");
			Period period = base.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
			this.ClientTypes = new Dictionary<int, string>
			{
				{
					0,
					Lang.t("All")
				},
				{
					1,
					Lang.t("New")
				},
				{
					2,
					Lang.t("FromDatabase")
				}
			};
			this.InitCommands();
			this.Optionses = this.CallsOptions.GetAllOptions();
			this.BgInit();
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00062388 File Offset: 0x00060588
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			this.BgInit();
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000407D8 File Offset: 0x0003E9D8
		private void Closing()
		{
			Settings.Default.Save();
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0006239C File Offset: 0x0006059C
		private void Close()
		{
			this.CloseAction();
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000623B4 File Offset: 0x000605B4
		private void BgInit()
		{
			CallsChartViewModel.<BgInit>d__76 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<CallsChartViewModel.<BgInit>d__76>(ref <BgInit>d__);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00062388 File Offset: 0x00060588
		public override void RefreshChart(object obj)
		{
			this.BgInit();
		}

		// Token: 0x04001130 RID: 4400
		[CompilerGenerated]
		private Dictionary<string, int> <ChartData>k__BackingField;

		// Token: 0x04001131 RID: 4401
		[CompilerGenerated]
		private Dictionary<int, string> <ClientTypes>k__BackingField;

		// Token: 0x04001132 RID: 4402
		[CompilerGenerated]
		private int <TotalCalls>k__BackingField;

		// Token: 0x04001133 RID: 4403
		[CompilerGenerated]
		private int <TotalInCalls>k__BackingField;

		// Token: 0x04001134 RID: 4404
		[CompilerGenerated]
		private int <TotalOutCalls>k__BackingField;

		// Token: 0x04001135 RID: 4405
		[CompilerGenerated]
		private int <InCallsNoAnswer>k__BackingField;

		// Token: 0x04001136 RID: 4406
		[CompilerGenerated]
		private string <TotalCallsLenght>k__BackingField;

		// Token: 0x04001137 RID: 4407
		[CompilerGenerated]
		private string <AverageDuration>k__BackingField;

		// Token: 0x04001138 RID: 4408
		public CallsOptions CallsOptions = new CallsOptions();

		// Token: 0x04001139 RID: 4409
		[CompilerGenerated]
		private List<CallsOptions> <Optionses>k__BackingField;

		// Token: 0x0400113A RID: 4410
		[CompilerGenerated]
		private List<users> <Users>k__BackingField;

		// Token: 0x0400113B RID: 4411
		[CompilerGenerated]
		private List<voip_ext_devices> <VoipExtDeviceses>k__BackingField;

		// Token: 0x0400113C RID: 4412
		[CompilerGenerated]
		private int <CallClientType>k__BackingField;

		// Token: 0x0400113D RID: 4413
		private int _selectedOption = 1;

		// Token: 0x0400113E RID: 4414
		private users _selectedUser;

		// Token: 0x0400113F RID: 4415
		private voip_ext_devices _selectedExtDevice;

		// Token: 0x04001140 RID: 4416
		[CompilerGenerated]
		private DelegateCommand <WindowClosingCommand>k__BackingField;

		// Token: 0x04001141 RID: 4417
		[CompilerGenerated]
		private ChartModel <Model>k__BackingField = new ChartModel();

		// Token: 0x02000279 RID: 633
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060021C5 RID: 8645 RVA: 0x000623EC File Offset: 0x000605EC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060021C6 RID: 8646 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060021C7 RID: 8647 RVA: 0x00062404 File Offset: 0x00060604
			internal int <BgInit>b__76_0(KeyValuePair<string, int> i)
			{
				return i.Value;
			}

			// Token: 0x04001142 RID: 4418
			public static readonly CallsChartViewModel.<>c <>9 = new CallsChartViewModel.<>c();

			// Token: 0x04001143 RID: 4419
			public static Func<KeyValuePair<string, int>, int> <>9__76_0;
		}

		// Token: 0x0200027A RID: 634
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__76 : IAsyncStateMachine
		{
			// Token: 0x060021C8 RID: 8648 RVA: 0x00062418 File Offset: 0x00060618
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CallsChartViewModel callsChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Dictionary<string, int>> awaiter;
					if (num != 0)
					{
						if (callsChartViewModel.VoipExtDeviceses == null)
						{
							callsChartViewModel.VoipExtDeviceses = callsChartViewModel.Model.LoadVoipExtDevices();
						}
						if (callsChartViewModel.Users == null)
						{
							callsChartViewModel.Users = callsChartViewModel.Model.LoadUsers();
						}
						if (callsChartViewModel.SelectedOption == 1)
						{
							callsChartViewModel.TotalInCalls = callsChartViewModel.Model.CountCalls(callsChartViewModel.Period, callsChartViewModel.SelectedUser, callsChartViewModel.SelectedExtDevice, callsChartViewModel.CallClientType, true);
							callsChartViewModel.TotalOutCalls = callsChartViewModel.Model.CountCalls(callsChartViewModel.Period, callsChartViewModel.SelectedUser, callsChartViewModel.SelectedExtDevice, callsChartViewModel.CallClientType, false);
						}
						bool? incoming = null;
						if (callsChartViewModel.SelectedOption == 2)
						{
							incoming = new bool?(true);
						}
						if (callsChartViewModel.SelectedOption == 3)
						{
							incoming = new bool?(false);
						}
						TimeSpan timeSpan = callsChartViewModel.Model.CountTotalTimeLength(callsChartViewModel.Period, callsChartViewModel.SelectedUser, callsChartViewModel.SelectedExtDevice, callsChartViewModel.CallClientType, incoming);
						callsChartViewModel.TotalCallsLenght = string.Format("{0:00}d {1:00}:{2:00}:{3:00}", new object[]
						{
							timeSpan.Days,
							timeSpan.Hours,
							timeSpan.Minutes,
							timeSpan.Seconds
						});
						awaiter = callsChartViewModel.Model.LoadCallsPeriodData(callsChartViewModel.SelectedOption, callsChartViewModel.Period, callsChartViewModel.SelectedUser, callsChartViewModel.SelectedExtDevice, callsChartViewModel.CallClientType).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, int>>, CallsChartViewModel.<BgInit>d__76>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Dictionary<string, int>>);
						this.<>1__state = -1;
					}
					Dictionary<string, int> result = awaiter.GetResult();
					callsChartViewModel.ChartData = result;
					callsChartViewModel.TotalCalls = callsChartViewModel.ChartData.DefaultIfEmpty<KeyValuePair<string, int>>().Sum(new Func<KeyValuePair<string, int>, int>(CallsChartViewModel.<>c.<>9.<BgInit>b__76_0));
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

			// Token: 0x060021C9 RID: 8649 RVA: 0x00062674 File Offset: 0x00060874
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001144 RID: 4420
			public int <>1__state;

			// Token: 0x04001145 RID: 4421
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001146 RID: 4422
			public CallsChartViewModel <>4__this;

			// Token: 0x04001147 RID: 4423
			private TaskAwaiter<Dictionary<string, int>> <>u__1;
		}
	}
}
