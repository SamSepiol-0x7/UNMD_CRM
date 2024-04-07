using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200053E RID: 1342
	public class SalesChartViewModel : ChartBaseViewModel
	{
		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x000A6D68 File Offset: 0x000A4F68
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x000A6D7C File Offset: 0x000A4F7C
		public List<SalesInfo2> ChartData
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

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x060031EF RID: 12783 RVA: 0x000A6DAC File Offset: 0x000A4FAC
		// (set) Token: 0x060031F0 RID: 12784 RVA: 0x000A6DC0 File Offset: 0x000A4FC0
		public List<UserMaster> Managers
		{
			[CompilerGenerated]
			get
			{
				return this.<Managers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Managers>k__BackingField, value))
				{
					return;
				}
				this.<Managers>k__BackingField = value;
				this.RaisePropertyChanged("Managers");
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x000A6DF0 File Offset: 0x000A4FF0
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x000A6E04 File Offset: 0x000A5004
		public int SelectedUser
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedUser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedUser>k__BackingField == value)
				{
					return;
				}
				this.<SelectedUser>k__BackingField = value;
				this.RaisePropertyChanged("SelectedUser");
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x000A6E30 File Offset: 0x000A5030
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x000A6E44 File Offset: 0x000A5044
		public ObservableCollection<SalesReportDto> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Items>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1063637230;
				IL_13:
				switch ((num ^ 448524639) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<Items>k__BackingField = value;
					this.RaisePropertyChanged("Items");
					num = 931477981;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000A6EA0 File Offset: 0x000A50A0
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x000A6EB4 File Offset: 0x000A50B4
		public SalesReportDto SelectedItem
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

		// Token: 0x060031F7 RID: 12791 RVA: 0x000A6EE4 File Offset: 0x000A50E4
		public SalesChartViewModel(INavigationService navigationService)
		{
			this._navigationService = navigationService;
			this.SetViewName("Sales");
			Period period = base.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
			this._model = new ChartModel();
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000A6F3C File Offset: 0x000A513C
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			SalesChartViewModel.<RefreshEventHandler>d__23 <RefreshEventHandler>d__;
			<RefreshEventHandler>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshEventHandler>d__.<>4__this = this;
			<RefreshEventHandler>d__.<>1__state = -1;
			<RefreshEventHandler>d__.<>t__builder.Start<SalesChartViewModel.<RefreshEventHandler>d__23>(ref <RefreshEventHandler>d__);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x000A6F74 File Offset: 0x000A5174
		private Task LoadData()
		{
			SalesChartViewModel.<LoadData>d__24 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<SalesChartViewModel.<LoadData>d__24>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x000A6FB8 File Offset: 0x000A51B8
		[Command]
		public void ItemDoubleClick()
		{
			if (this.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1926048876;
			IL_0D:
			switch ((num ^ 1786747217) % 4)
			{
			case 0:
				IL_2C:
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this.SelectedItem.DocumentId));
				num = 623291043;
				goto IL_0D;
			case 1:
				return;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x000A701C File Offset: 0x000A521C
		public override void RefreshChart(object obj)
		{
			SalesChartViewModel.<RefreshChart>d__26 <RefreshChart>d__;
			<RefreshChart>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshChart>d__.<>4__this = this;
			<RefreshChart>d__.<>1__state = -1;
			<RefreshChart>d__.<>t__builder.Start<SalesChartViewModel.<RefreshChart>d__26>(ref <RefreshChart>d__);
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x000A7054 File Offset: 0x000A5254
		public override void OnLoad()
		{
			SalesChartViewModel.<OnLoad>d__27 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<SalesChartViewModel.<OnLoad>d__27>(ref <OnLoad>d__);
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x000A708C File Offset: 0x000A528C
		[CompilerGenerated]
		private Task<List<SalesInfo2>> <LoadData>b__24_1()
		{
			return this._model.LoadSalesChartData(base.Period, base.SelectedOffice, this.SelectedUser);
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x000A70B8 File Offset: 0x000A52B8
		[CompilerGenerated]
		private IEnumerable<SalesReportDto> <LoadData>b__24_2()
		{
			return this._model.LoadSalesInPeriod(base.Period, base.SelectedOffice, this.SelectedUser);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001CA3 RID: 7331
		private ChartModel _model;

		// Token: 0x04001CA4 RID: 7332
		private INavigationService _navigationService;

		// Token: 0x04001CA5 RID: 7333
		[CompilerGenerated]
		private List<SalesInfo2> <ChartData>k__BackingField;

		// Token: 0x04001CA6 RID: 7334
		[CompilerGenerated]
		private List<UserMaster> <Managers>k__BackingField;

		// Token: 0x04001CA7 RID: 7335
		[CompilerGenerated]
		private int <SelectedUser>k__BackingField;

		// Token: 0x04001CA8 RID: 7336
		[CompilerGenerated]
		private ObservableCollection<SalesReportDto> <Items>k__BackingField;

		// Token: 0x04001CA9 RID: 7337
		[CompilerGenerated]
		private SalesReportDto <SelectedItem>k__BackingField;

		// Token: 0x0200053F RID: 1343
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshEventHandler>d__23 : IAsyncStateMachine
		{
			// Token: 0x06003200 RID: 12800 RVA: 0x000A70E4 File Offset: 0x000A52E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SalesChartViewModel salesChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = salesChartViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SalesChartViewModel.<RefreshEventHandler>d__23>(ref awaiter, ref this);
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

			// Token: 0x06003201 RID: 12801 RVA: 0x000A7198 File Offset: 0x000A5398
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CAA RID: 7338
			public int <>1__state;

			// Token: 0x04001CAB RID: 7339
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001CAC RID: 7340
			public SalesChartViewModel <>4__this;

			// Token: 0x04001CAD RID: 7341
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000540 RID: 1344
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003202 RID: 12802 RVA: 0x000A71B4 File Offset: 0x000A53B4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003203 RID: 12803 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003204 RID: 12804 RVA: 0x000A71CC File Offset: 0x000A53CC
			internal List<UserMaster> <LoadData>b__24_0()
			{
				return UsersModel.LoadManagers(true);
			}

			// Token: 0x04001CAE RID: 7342
			public static readonly SalesChartViewModel.<>c <>9 = new SalesChartViewModel.<>c();

			// Token: 0x04001CAF RID: 7343
			public static Func<List<UserMaster>> <>9__24_0;
		}

		// Token: 0x02000541 RID: 1345
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__24 : IAsyncStateMachine
		{
			// Token: 0x06003205 RID: 12805 RVA: 0x000A71E0 File Offset: 0x000A53E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SalesChartViewModel salesChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<UserMaster>> awaiter;
					TaskAwaiter<List<SalesInfo2>> awaiter2;
					TaskAwaiter<IEnumerable<SalesReportDto>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<UserMaster>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<List<SalesInfo2>>);
						this.<>1__state = -1;
						goto IL_119;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<IEnumerable<SalesReportDto>>);
						this.<>1__state = -1;
						goto IL_189;
					default:
						salesChartViewModel.ShowWait();
						if (salesChartViewModel.Managers != null)
						{
							goto IL_B7;
						}
						awaiter = Task.Run<List<UserMaster>>(new Func<List<UserMaster>>(SalesChartViewModel.<>c.<>9.<LoadData>b__24_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<UserMaster>>, SalesChartViewModel.<LoadData>d__24>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<UserMaster> result = awaiter.GetResult();
					salesChartViewModel.Managers = new List<UserMaster>(result);
					IL_B7:
					awaiter2 = Task.Run<List<SalesInfo2>>(() => salesChartViewModel._model.LoadSalesChartData(base.Period, base.SelectedOffice, base.SelectedUser)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<SalesInfo2>>, SalesChartViewModel.<LoadData>d__24>(ref awaiter2, ref this);
						return;
					}
					IL_119:
					List<SalesInfo2> result2 = awaiter2.GetResult();
					salesChartViewModel.ChartData = result2;
					awaiter3 = Task.Run<IEnumerable<SalesReportDto>>(() => salesChartViewModel._model.LoadSalesInPeriod(base.Period, base.SelectedOffice, base.SelectedUser)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<SalesReportDto>>, SalesChartViewModel.<LoadData>d__24>(ref awaiter3, ref this);
						return;
					}
					IL_189:
					IEnumerable<SalesReportDto> result3 = awaiter3.GetResult();
					salesChartViewModel.Items = new ObservableCollection<SalesReportDto>(result3);
					salesChartViewModel.HideWait();
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

			// Token: 0x06003206 RID: 12806 RVA: 0x000A73DC File Offset: 0x000A55DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CB0 RID: 7344
			public int <>1__state;

			// Token: 0x04001CB1 RID: 7345
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001CB2 RID: 7346
			public SalesChartViewModel <>4__this;

			// Token: 0x04001CB3 RID: 7347
			private TaskAwaiter<List<UserMaster>> <>u__1;

			// Token: 0x04001CB4 RID: 7348
			private TaskAwaiter<List<SalesInfo2>> <>u__2;

			// Token: 0x04001CB5 RID: 7349
			private TaskAwaiter<IEnumerable<SalesReportDto>> <>u__3;
		}

		// Token: 0x02000542 RID: 1346
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshChart>d__26 : IAsyncStateMachine
		{
			// Token: 0x06003207 RID: 12807 RVA: 0x000A73F8 File Offset: 0x000A55F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SalesChartViewModel salesChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = salesChartViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SalesChartViewModel.<RefreshChart>d__26>(ref awaiter, ref this);
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

			// Token: 0x06003208 RID: 12808 RVA: 0x000A74AC File Offset: 0x000A56AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CB6 RID: 7350
			public int <>1__state;

			// Token: 0x04001CB7 RID: 7351
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001CB8 RID: 7352
			public SalesChartViewModel <>4__this;

			// Token: 0x04001CB9 RID: 7353
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000543 RID: 1347
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__27 : IAsyncStateMachine
		{
			// Token: 0x06003209 RID: 12809 RVA: 0x000A74C8 File Offset: 0x000A56C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SalesChartViewModel salesChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						salesChartViewModel.<>n__0();
						awaiter = salesChartViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SalesChartViewModel.<OnLoad>d__27>(ref awaiter, ref this);
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

			// Token: 0x0600320A RID: 12810 RVA: 0x000A7580 File Offset: 0x000A5780
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CBA RID: 7354
			public int <>1__state;

			// Token: 0x04001CBB RID: 7355
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001CBC RID: 7356
			public SalesChartViewModel <>4__this;

			// Token: 0x04001CBD RID: 7357
			private TaskAwaiter <>u__1;
		}
	}
}
