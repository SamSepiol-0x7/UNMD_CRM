using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using DevExpress.DataProcessing;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200050A RID: 1290
	public class EmployeeHistoryViewModel : CollectionViewModel<logs>, IIsDataLoading
	{
		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000A0970 File Offset: 0x0009EB70
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x000A0984 File Offset: 0x0009EB84
		public EmployeeHistoryViewModel(IEmployeeService employeeService)
		{
			this.EmployeeService = employeeService;
			this.Period = new Period(DateTime.Now.AddMonths(-1), DateTime.Now);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x000A09E4 File Offset: 0x0009EBE4
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x000A09F8 File Offset: 0x0009EBF8
		protected void LoadData()
		{
			EmployeeHistoryViewModel.<LoadData>d__7 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<EmployeeHistoryViewModel.<LoadData>d__7>(ref <LoadData>d__);
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x000A09E4 File Offset: 0x0009EBE4
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x000A0A30 File Offset: 0x0009EC30
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x000A0A44 File Offset: 0x0009EC44
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000A0A70 File Offset: 0x0009EC70
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x000A0A84 File Offset: 0x0009EC84
		protected override void OnParameterChanged(object obj)
		{
			this.EmployeeId = (int)obj;
			this.LoadData();
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000A0AA4 File Offset: 0x0009ECA4
		[CompilerGenerated]
		private Task<List<logs>> <LoadData>b__7_0()
		{
			return this.EmployeeService.GetLogsAsync(this.Period, this.EmployeeId);
		}

		// Token: 0x04001BBD RID: 7101
		protected IEmployeeService EmployeeService;

		// Token: 0x04001BBE RID: 7102
		[CompilerGenerated]
		private readonly Period <Period>k__BackingField;

		// Token: 0x04001BBF RID: 7103
		protected int EmployeeId;

		// Token: 0x04001BC0 RID: 7104
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x0200050B RID: 1291
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__7 : IAsyncStateMachine
		{
			// Token: 0x060030B3 RID: 12467 RVA: 0x000A0AC8 File Offset: 0x0009ECC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeHistoryViewModel employeeHistoryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<logs>> awaiter;
					if (num != 0)
					{
						employeeHistoryViewModel.SetIsDataLoading(true);
						awaiter = Task.Run<List<logs>>(() => employeeHistoryViewModel.EmployeeService.GetLogsAsync(base.Period, employeeHistoryViewModel.EmployeeId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<logs>>, EmployeeHistoryViewModel.<LoadData>d__7>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<logs>>);
						this.<>1__state = -1;
					}
					List<logs> result = awaiter.GetResult();
					employeeHistoryViewModel.Items.Clear();
					employeeHistoryViewModel.Items.AddRange(result);
					employeeHistoryViewModel.SetIsDataLoading(false);
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

			// Token: 0x060030B4 RID: 12468 RVA: 0x000A0BB0 File Offset: 0x0009EDB0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001BC1 RID: 7105
			public int <>1__state;

			// Token: 0x04001BC2 RID: 7106
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001BC3 RID: 7107
			public EmployeeHistoryViewModel <>4__this;

			// Token: 0x04001BC4 RID: 7108
			private TaskAwaiter<List<logs>> <>u__1;
		}
	}
}
