using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.PKO;
using ASC.RKO;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RepairCard.History
{
	// Token: 0x02000849 RID: 2121
	public class RepairHistoryViewModel : RepairCardCommonView
	{
		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x000FB960 File Offset: 0x000F9B60
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x000FB974 File Offset: 0x000F9B74
		public ObservableCollection<logs> History
		{
			[CompilerGenerated]
			get
			{
				return this.<History>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<History>k__BackingField, value))
				{
					return;
				}
				this.<History>k__BackingField = value;
				this.RaisePropertyChanged("History");
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x000FB9A4 File Offset: 0x000F9BA4
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x000FB9B8 File Offset: 0x000F9BB8
		public ObservableCollection<cash_orders> RepairOrders
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairOrders>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RepairOrders>k__BackingField, value))
				{
					return;
				}
				this.<RepairOrders>k__BackingField = value;
				this.RaisePropertyChanged("RepairOrders");
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x000FB9E8 File Offset: 0x000F9BE8
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x000FB9FC File Offset: 0x000F9BFC
		public cash_orders SelectedCashOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCashOrder>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedCashOrder>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 415005155;
				IL_13:
				switch ((num ^ 401964010) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<SelectedCashOrder>k__BackingField = value;
					this.RaisePropertyChanged("SelectedCashOrder");
					num = 1632542608;
					goto IL_13;
				}
			}
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x000FBA58 File Offset: 0x000F9C58
		public RepairHistoryViewModel()
		{
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x000FBA6C File Offset: 0x000F9C6C
		public RepairHistoryViewModel(workshop repair)
		{
			if (repair == null)
			{
				return;
			}
			base.SetViewName("Repair", "History", repair.id);
			base.Repair = repair;
			base.InitLockCard(repair.id);
			base.RepairId = repair.id;
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x000FBAB8 File Offset: 0x000F9CB8
		[Command]
		public void CashOrderDoubleClick()
		{
			if (this.SelectedCashOrder.type <= 10)
			{
				this._navigationService.Navigate("RkoView", new RkoViewModel(this.SelectedCashOrder.id));
				return;
			}
			this._navigationService.Navigate("PkoView", new PkoViewModel(this.SelectedCashOrder.id));
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x000FBB18 File Offset: 0x000F9D18
		public bool CanCashOrderDoubleClick()
		{
			return this.SelectedCashOrder != null;
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x000FBB30 File Offset: 0x000F9D30
		public override void OnLoad()
		{
			RepairHistoryViewModel.<OnLoad>d__16 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<RepairHistoryViewModel.<OnLoad>d__16>(ref <OnLoad>d__);
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x000FBB68 File Offset: 0x000F9D68
		[CompilerGenerated]
		private Task<IEnumerable<logs>> <OnLoad>b__16_0()
		{
			return RepairModel.GetRepairLogs(base.RepairId);
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x000FBB80 File Offset: 0x000F9D80
		[CompilerGenerated]
		private Task<IEnumerable<cash_orders>> <OnLoad>b__16_1()
		{
			return RepairModel.GetRepairCashOrders(base.RepairId);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x0400294F RID: 10575
		[CompilerGenerated]
		private ObservableCollection<logs> <History>k__BackingField;

		// Token: 0x04002950 RID: 10576
		[CompilerGenerated]
		private ObservableCollection<cash_orders> <RepairOrders>k__BackingField;

		// Token: 0x04002951 RID: 10577
		[CompilerGenerated]
		private cash_orders <SelectedCashOrder>k__BackingField;

		// Token: 0x0200084A RID: 2122
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__16 : IAsyncStateMachine
		{
			// Token: 0x06003EE8 RID: 16104 RVA: 0x000FBB98 File Offset: 0x000F9D98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairHistoryViewModel repairHistoryViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<cash_orders>> awaiter;
					TaskAwaiter<IEnumerable<logs>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IEnumerable<cash_orders>>);
							this.<>1__state = -1;
							goto IL_F8;
						}
						repairHistoryViewModel.<>n__0();
						repairHistoryViewModel.ShowWait();
						awaiter2 = Task.Run<IEnumerable<logs>>(() => RepairModel.GetRepairLogs(base.RepairId)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<logs>>, RepairHistoryViewModel.<OnLoad>d__16>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<logs>>);
						this.<>1__state = -1;
					}
					IEnumerable<logs> result = awaiter2.GetResult();
					repairHistoryViewModel.History = new ObservableCollection<logs>(result);
					awaiter = Task.Run<IEnumerable<cash_orders>>(() => RepairModel.GetRepairCashOrders(base.RepairId)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<cash_orders>>, RepairHistoryViewModel.<OnLoad>d__16>(ref awaiter, ref this);
						return;
					}
					IL_F8:
					IEnumerable<cash_orders> result2 = awaiter.GetResult();
					repairHistoryViewModel.RepairOrders = new ObservableCollection<cash_orders>(result2);
					repairHistoryViewModel.HideWait();
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

			// Token: 0x06003EE9 RID: 16105 RVA: 0x000FBD04 File Offset: 0x000F9F04
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002952 RID: 10578
			public int <>1__state;

			// Token: 0x04002953 RID: 10579
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002954 RID: 10580
			public RepairHistoryViewModel <>4__this;

			// Token: 0x04002955 RID: 10581
			private TaskAwaiter<IEnumerable<logs>> <>u__1;

			// Token: 0x04002956 RID: 10582
			private TaskAwaiter<IEnumerable<cash_orders>> <>u__2;
		}
	}
}
