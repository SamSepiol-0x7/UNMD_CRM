using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.ViewModels;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Charts
{
	// Token: 0x02000276 RID: 630
	public class CommonChartViewModel : ViewModelBase, IBaseViewModel
	{
		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x0006174C File Offset: 0x0005F94C
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x00061760 File Offset: 0x0005F960
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00061790 File Offset: 0x0005F990
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x000617A4 File Offset: 0x0005F9A4
		public Dictionary<string, int> CallsChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<CallsChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CallsChartData>k__BackingField, value))
				{
					return;
				}
				this.<CallsChartData>k__BackingField = value;
				this.RaisePropertyChanged("CallsChartData");
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000617D4 File Offset: 0x0005F9D4
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x000617E8 File Offset: 0x0005F9E8
		public List<SalesInfo2> RepairsChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RepairsChartData>k__BackingField, value))
				{
					return;
				}
				this.<RepairsChartData>k__BackingField = value;
				this.RaisePropertyChanged("RepairsChartData");
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x00061818 File Offset: 0x0005FA18
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x0006182C File Offset: 0x0005FA2C
		public List<SalesInfo2> SalesChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<SalesChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SalesChartData>k__BackingField, value))
				{
					return;
				}
				this.<SalesChartData>k__BackingField = value;
				this.RaisePropertyChanged("SalesChartData");
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x0006185C File Offset: 0x0005FA5C
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00061870 File Offset: 0x0005FA70
		public List<IVisitSourceChartItem> VisitChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<VisitChartData>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1129162913;
				IL_13:
				switch ((num ^ 1043435948) % 4)
				{
				case 0:
					IL_32:
					this.<VisitChartData>k__BackingField = value;
					num = 1733774059;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.RaisePropertyChanged("VisitChartData");
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000618CC File Offset: 0x0005FACC
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x000618E0 File Offset: 0x0005FAE0
		public string ViewName
		{
			[CompilerGenerated]
			get
			{
				return this.<ViewName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ViewName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ViewName>k__BackingField = value;
				this.RaisePropertyChanged("ViewName");
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x00061910 File Offset: 0x0005FB10
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x00061924 File Offset: 0x0005FB24
		public string TabId
		{
			[CompilerGenerated]
			get
			{
				return this.<TabId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<TabId>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TabId>k__BackingField = value;
				this.RaisePropertyChanged("TabId");
			}
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00061954 File Offset: 0x0005FB54
		public CommonChartViewModel()
		{
			this.ViewName = "Сводка";
			this._waitIndicatorService = base.ServiceContainer.GetService<ISplashScreenService>("WaitIndicatorService", ServiceSearchMode.PreferLocal);
			this.Period = new Period(this._localization.Now.AddMonths(-1), this._localization.Now);
			this.LoadChartData();
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000619D4 File Offset: 0x0005FBD4
		private void LoadChartData()
		{
			CommonChartViewModel.<LoadChartData>d__32 <LoadChartData>d__;
			<LoadChartData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadChartData>d__.<>4__this = this;
			<LoadChartData>d__.<>1__state = -1;
			<LoadChartData>d__.<>t__builder.Start<CommonChartViewModel.<LoadChartData>d__32>(ref <LoadChartData>d__);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00061A0C File Offset: 0x0005FC0C
		[Command]
		public void Refresh()
		{
			this.LoadChartData();
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnLoad()
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnUnload()
		{
		}

		// Token: 0x04001120 RID: 4384
		private ChartModel _chartModel = new ChartModel();

		// Token: 0x04001121 RID: 4385
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001122 RID: 4386
		private Localization _localization = new Localization("UTC");

		// Token: 0x04001123 RID: 4387
		private ISplashScreenService _waitIndicatorService;

		// Token: 0x04001124 RID: 4388
		[CompilerGenerated]
		private Dictionary<string, int> <CallsChartData>k__BackingField;

		// Token: 0x04001125 RID: 4389
		[CompilerGenerated]
		private List<SalesInfo2> <RepairsChartData>k__BackingField;

		// Token: 0x04001126 RID: 4390
		[CompilerGenerated]
		private List<SalesInfo2> <SalesChartData>k__BackingField;

		// Token: 0x04001127 RID: 4391
		[CompilerGenerated]
		private List<IVisitSourceChartItem> <VisitChartData>k__BackingField;

		// Token: 0x04001128 RID: 4392
		[CompilerGenerated]
		private string <ViewName>k__BackingField;

		// Token: 0x04001129 RID: 4393
		[CompilerGenerated]
		private string <TabId>k__BackingField;

		// Token: 0x02000277 RID: 631
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadChartData>d__32 : IAsyncStateMachine
		{
			// Token: 0x06002199 RID: 8601 RVA: 0x00061A20 File Offset: 0x0005FC20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CommonChartViewModel commonChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Dictionary<string, int>> awaiter;
					switch (num)
					{
					case 0:
						break;
					case 1:
						goto IL_1A1;
					case 2:
						goto IL_216;
					case 3:
						goto IL_288;
					default:
						for (;;)
						{
							ISplashScreenService waitIndicatorService = commonChartViewModel._waitIndicatorService;
							if (waitIndicatorService != null)
							{
								waitIndicatorService.ShowSplashScreen();
								uint num2;
								switch ((num2 = (num2 * 453786939U ^ 3650029189U ^ 3365517581U)) % 35U)
								{
								case 0U:
									goto IL_140;
								case 1U:
									goto IL_203;
								case 2U:
									goto IL_151;
								case 3U:
									goto IL_10A;
								case 4U:
									goto IL_17D;
								case 5U:
									goto IL_18E;
								case 6U:
								case 34U:
									continue;
								case 7U:
									goto IL_288;
								case 8U:
									goto IL_1F2;
								case 9U:
									goto IL_12D;
								case 10U:
									goto IL_134;
								case 11U:
									goto IL_2AE;
								case 12U:
									goto IL_1FB;
								case 13U:
									goto IL_267;
								case 14U:
									goto IL_216;
								case 15U:
									goto IL_2A5;
								case 16U:
									goto IL_1A1;
								case 17U:
									goto IL_21E;
								case 18U:
									goto IL_E6;
								case 19U:
									goto IL_290;
								case 20U:
									goto IL_29C;
								case 21U:
									goto IL_113;
								case 23U:
									goto IL_1CF;
								case 24U:
									goto IL_1B5;
								case 25U:
									goto IL_1BE;
								case 26U:
									goto IL_149;
								case 27U:
									goto IL_1E9;
								case 28U:
									goto IL_233;
								case 29U:
									goto IL_286;
								case 30U:
									goto IL_1C7;
								case 31U:
									goto IL_270;
								case 32U:
									goto IL_244;
								case 33U:
									goto IL_211;
								}
								break;
							}
							goto IL_E5;
						}
						goto IL_2C7;
						IL_E5:
						IL_E6:
						awaiter = commonChartViewModel._chartModel.LoadCallsPeriodData(0, commonChartViewModel.Period, null, null, 0).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_149;
						}
						IL_10A:
						this.<>1__state = 0;
						IL_113:
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, int>>, CommonChartViewModel.<LoadChartData>d__32>(ref awaiter, ref this);
						return;
					}
					IL_12D:
					awaiter = this.<>u__1;
					IL_134:
					this.<>u__1 = default(TaskAwaiter<Dictionary<string, int>>);
					IL_140:
					this.<>1__state = -1;
					IL_149:
					Dictionary<string, int> result = awaiter.GetResult();
					IL_151:
					commonChartViewModel.CallsChartData = result;
					TaskAwaiter<List<SalesInfo2>> awaiter2 = commonChartViewModel._chartModel.LoadRepairsPeriodData(commonChartViewModel.Period, 0, 0, 0, 0).GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						goto IL_1BE;
					}
					IL_17D:
					this.<>1__state = 1;
					this.<>u__2 = awaiter2;
					IL_18E:
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<SalesInfo2>>, CommonChartViewModel.<LoadChartData>d__32>(ref awaiter2, ref this);
					return;
					IL_1A1:
					awaiter2 = this.<>u__2;
					this.<>u__2 = default(TaskAwaiter<List<SalesInfo2>>);
					IL_1B5:
					this.<>1__state = -1;
					IL_1BE:
					List<SalesInfo2> result2 = awaiter2.GetResult();
					IL_1C7:
					commonChartViewModel.RepairsChartData = result2;
					IL_1CF:
					awaiter2 = commonChartViewModel._chartModel.LoadSalesChartData(commonChartViewModel.Period, 0, 0).GetAwaiter();
					IL_1E9:
					if (awaiter2.IsCompleted)
					{
						goto IL_233;
					}
					IL_1F2:
					this.<>1__state = 2;
					IL_1FB:
					this.<>u__2 = awaiter2;
					IL_203:
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<SalesInfo2>>, CommonChartViewModel.<LoadChartData>d__32>(ref awaiter2, ref this);
					IL_211:
					return;
					IL_216:
					awaiter2 = this.<>u__2;
					IL_21E:
					this.<>u__2 = default(TaskAwaiter<List<SalesInfo2>>);
					this.<>1__state = -1;
					IL_233:
					result2 = awaiter2.GetResult();
					commonChartViewModel.SalesChartData = result2;
					IL_244:
					TaskAwaiter<List<IVisitSourceChartItem>> awaiter3 = commonChartViewModel._chartModel.LoadVisitChartData(commonChartViewModel.Period, 0, 0).GetAwaiter();
					if (awaiter3.IsCompleted)
					{
						goto IL_2A5;
					}
					IL_267:
					this.<>1__state = 3;
					IL_270:
					this.<>u__3 = awaiter3;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IVisitSourceChartItem>>, CommonChartViewModel.<LoadChartData>d__32>(ref awaiter3, ref this);
					IL_286:
					return;
					IL_288:
					awaiter3 = this.<>u__3;
					IL_290:
					this.<>u__3 = default(TaskAwaiter<List<IVisitSourceChartItem>>);
					IL_29C:
					this.<>1__state = -1;
					IL_2A5:
					List<IVisitSourceChartItem> result3 = awaiter3.GetResult();
					IL_2AE:
					commonChartViewModel.VisitChartData = result3;
					ISplashScreenService waitIndicatorService2 = commonChartViewModel._waitIndicatorService;
					if (waitIndicatorService2 != null)
					{
						waitIndicatorService2.HideSplashScreen();
					}
					IL_2C7:;
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

			// Token: 0x0600219A RID: 8602 RVA: 0x00061D40 File Offset: 0x0005FF40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400112A RID: 4394
			public int <>1__state;

			// Token: 0x0400112B RID: 4395
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400112C RID: 4396
			public CommonChartViewModel <>4__this;

			// Token: 0x0400112D RID: 4397
			private TaskAwaiter<Dictionary<string, int>> <>u__1;

			// Token: 0x0400112E RID: 4398
			private TaskAwaiter<List<SalesInfo2>> <>u__2;

			// Token: 0x0400112F RID: 4399
			private TaskAwaiter<List<IVisitSourceChartItem>> <>u__3;
		}
	}
}
