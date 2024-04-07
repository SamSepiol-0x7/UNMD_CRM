using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Interfaces;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.ViewModels;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RepairCard.Admin
{
	// Token: 0x0200084E RID: 2126
	public class OrderCancellationViewModel : PopupViewModel
	{
		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x000FBDF4 File Offset: 0x000F9FF4
		// (set) Token: 0x06003EF2 RID: 16114 RVA: 0x000FBE08 File Offset: 0x000FA008
		public bool AdminRefund
		{
			[CompilerGenerated]
			get
			{
				return this.<AdminRefund>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AdminRefund>k__BackingField == value)
				{
					return;
				}
				this.<AdminRefund>k__BackingField = value;
				this.RaisePropertyChanged("AdminRefund");
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06003EF3 RID: 16115 RVA: 0x000FBE34 File Offset: 0x000FA034
		// (set) Token: 0x06003EF4 RID: 16116 RVA: 0x000FBE48 File Offset: 0x000FA048
		public int NextStatus
		{
			[CompilerGenerated]
			get
			{
				return this.<NextStatus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NextStatus>k__BackingField == value)
				{
					return;
				}
				this.<NextStatus>k__BackingField = value;
				this.RaisePropertyChanged("NextStatus");
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x000FBE74 File Offset: 0x000FA074
		// (set) Token: 0x06003EF6 RID: 16118 RVA: 0x000FBE88 File Offset: 0x000FA088
		public int PaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PaymentSystem>k__BackingField == value)
				{
					return;
				}
				this.<PaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystem");
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x000FBEB4 File Offset: 0x000FA0B4
		// (set) Token: 0x06003EF8 RID: 16120 RVA: 0x000FBEC8 File Offset: 0x000FA0C8
		public List<WorkshopOptions> Statuses
		{
			[CompilerGenerated]
			get
			{
				return this.<Statuses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Statuses>k__BackingField, value))
				{
					return;
				}
				this.<Statuses>k__BackingField = value;
				this.RaisePropertyChanged("Statuses");
			}
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x000FBEF8 File Offset: 0x000FA0F8
		public OrderCancellationViewModel(IOrderService orderService, IRepairModel repairModel, IToasterService toasterService, IAscMessageBoxService ascMessageBoxService, IAdditionalPaymentsService additionalPaymentsService, IWorkshopStatusService workshopStatusService)
		{
			this._orderService = orderService;
			this._repairModel = repairModel;
			this._toasterService = toasterService;
			this._ascMessageBoxService = ascMessageBoxService;
			this._additionalPaymentsService = additionalPaymentsService;
			this._workshopStatusService = workshopStatusService;
			this.LoadStatuses();
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x000FBF40 File Offset: 0x000FA140
		public void SetRepairId(int value)
		{
			this._repairId = value;
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x000FBF54 File Offset: 0x000FA154
		public void SetCurrentStatus(int value)
		{
			this._currentStatus = value;
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x000FBF68 File Offset: 0x000FA168
		private void LoadStatuses()
		{
			List<WorkshopOptions> allOptions = new WorkshopOptions().GetAllOptions();
			List<int> removeIds = new List<int>
			{
				8,
				12,
				16
			};
			this.Statuses = (from i in allOptions
			where !removeIds.Contains(i.Id)
			select i).ToList<WorkshopOptions>();
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x000FBFC8 File Offset: 0x000FA1C8
		private string ConstructWarningMessage()
		{
			if (!this.AdminRefund)
			{
				return " " + Lang.t("WithoutRefund");
			}
			return " " + Lang.t("WithRefund");
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x000FC008 File Offset: 0x000FA208
		[AsyncCommand]
		public Task Save()
		{
			OrderCancellationViewModel.<Save>d__30 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<OrderCancellationViewModel.<Save>d__30>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x000FC04C File Offset: 0x000FA24C
		public bool CanSave()
		{
			return this.NextStatus != 0;
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x000FC064 File Offset: 0x000FA264
		private bool RefundMoney()
		{
			return this.AdminRefund && (this._currentStatus == 8 || this._currentStatus == 16);
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x000FC090 File Offset: 0x000FA290
		protected override void OnParentViewModelChanged(object obj)
		{
			this._parentViewModel = (obj as IRefreshable);
		}

		// Token: 0x04002959 RID: 10585
		private IRefreshable _parentViewModel;

		// Token: 0x0400295A RID: 10586
		[CompilerGenerated]
		private bool <AdminRefund>k__BackingField;

		// Token: 0x0400295B RID: 10587
		[CompilerGenerated]
		private int <NextStatus>k__BackingField;

		// Token: 0x0400295C RID: 10588
		[CompilerGenerated]
		private int <PaymentSystem>k__BackingField;

		// Token: 0x0400295D RID: 10589
		private int _repairId;

		// Token: 0x0400295E RID: 10590
		private int _currentStatus;

		// Token: 0x0400295F RID: 10591
		private readonly IOrderService _orderService;

		// Token: 0x04002960 RID: 10592
		private readonly IRepairModel _repairModel;

		// Token: 0x04002961 RID: 10593
		private readonly IToasterService _toasterService;

		// Token: 0x04002962 RID: 10594
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04002963 RID: 10595
		private readonly IAdditionalPaymentsService _additionalPaymentsService;

		// Token: 0x04002964 RID: 10596
		private readonly IWorkshopStatusService _workshopStatusService;

		// Token: 0x04002965 RID: 10597
		[CompilerGenerated]
		private List<WorkshopOptions> <Statuses>k__BackingField;

		// Token: 0x0200084F RID: 2127
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06003F02 RID: 16130 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06003F03 RID: 16131 RVA: 0x000FC0AC File Offset: 0x000FA2AC
			internal bool <LoadStatuses>b__0(WorkshopOptions i)
			{
				return !this.removeIds.Contains(i.Id);
			}

			// Token: 0x04002966 RID: 10598
			public List<int> removeIds;
		}

		// Token: 0x02000850 RID: 2128
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__30 : IAsyncStateMachine
		{
			// Token: 0x06003F04 RID: 16132 RVA: 0x000FC0D0 File Offset: 0x000FA2D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OrderCancellationViewModel orderCancellationViewModel = this.<>4__this;
				try
				{
					if (num > 5)
					{
						if (orderCancellationViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("CancelOut") + orderCancellationViewModel.ConstructWarningMessage(), Lang.t("CancelOut"), MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
						{
							goto IL_43C;
						}
						orderCancellationViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<DateTime?> awaiter;
						TaskAwaiter<IList<additional_payments>> awaiter2;
						TaskAwaiter awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<DateTime?>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IList<additional_payments>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_1AE;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_295;
						}
						case 3:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.<>1__state = num5;
							goto IL_312;
						}
						case 4:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num6 = -1;
							num = -1;
							this.<>1__state = num6;
							goto IL_381;
						}
						case 5:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num7 = -1;
							num = -1;
							this.<>1__state = num7;
							goto IL_3EA;
						}
						default:
							awaiter = orderCancellationViewModel._orderService.GetDateOfIssue(orderCancellationViewModel._repairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num8 = 0;
								num = 0;
								this.<>1__state = num8;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DateTime?>, OrderCancellationViewModel.<Save>d__30>(ref awaiter, ref this);
								return;
							}
							break;
						}
						DateTime? result = awaiter.GetResult();
						if (result == null || result.Value.Year != DateTime.Now.Year || DateTime.Now.Month <= result.Value.Month)
						{
							goto IL_233;
						}
						orderCancellationViewModel.HideWait();
						if (orderCancellationViewModel._ascMessageBoxService.ShowMessageBox("Устройтво выдано в предыдущем расчетном периоде. Списать средства с мастера?", Lang.t("CancelOut"), MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
						{
							goto IL_22D;
						}
						awaiter2 = orderCancellationViewModel._additionalPaymentsService.ClearEmployeesProfit(orderCancellationViewModel._repairId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num9 = 1;
							num = 1;
							this.<>1__state = num9;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<additional_payments>>, OrderCancellationViewModel.<Save>d__30>(ref awaiter2, ref this);
							return;
						}
						IL_1AE:
						IEnumerator<additional_payments> enumerator = awaiter2.GetResult().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								additional_payments additional_payments = enumerator.Current;
								orderCancellationViewModel._ascMessageBoxService.ShowMessageBox(string.Format("С сотрудника {0} списано {1:N2} {2}", additional_payments.users1.FioShort, Math.Abs(additional_payments.price), Auth.CurrencyModel.SelectedCurrency.ShortName), "Списание средств с мастера", MessageBoxButton.OK, MessageBoxImage.Asterisk);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						IL_22D:
						orderCancellationViewModel.ShowWait();
						IL_233:
						awaiter3 = orderCancellationViewModel._repairModel.RestoreIntReserve(orderCancellationViewModel._repairId).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num10 = 2;
							num = 2;
							this.<>1__state = num10;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OrderCancellationViewModel.<Save>d__30>(ref awaiter3, ref this);
							return;
						}
						IL_295:
						awaiter3.GetResult();
						if (!orderCancellationViewModel.RefundMoney())
						{
							goto IL_319;
						}
						awaiter3 = orderCancellationViewModel._orderService.CancellOrder(orderCancellationViewModel._repairId, orderCancellationViewModel.NextStatus, orderCancellationViewModel.PaymentSystem).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num11 = 3;
							num = 3;
							this.<>1__state = num11;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OrderCancellationViewModel.<Save>d__30>(ref awaiter3, ref this);
							return;
						}
						IL_312:
						awaiter3.GetResult();
						IL_319:
						awaiter3 = orderCancellationViewModel._workshopStatusService.AdminUpdateStatus(orderCancellationViewModel._repairId, orderCancellationViewModel.NextStatus).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num12 = 4;
							num = 4;
							this.<>1__state = num12;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OrderCancellationViewModel.<Save>d__30>(ref awaiter3, ref this);
							return;
						}
						IL_381:
						awaiter3.GetResult();
						awaiter3 = orderCancellationViewModel._orderService.DeleteWorkshopIssuedData(orderCancellationViewModel._repairId).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num13 = 5;
							num = 5;
							this.<>1__state = num13;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OrderCancellationViewModel.<Save>d__30>(ref awaiter3, ref this);
							return;
						}
						IL_3EA:
						awaiter3.GetResult();
						orderCancellationViewModel._toasterService.Success(Lang.t("Saved"));
						orderCancellationViewModel._parentViewModel.DataRefresh();
						orderCancellationViewModel.ClosePopup();
					}
					catch (Exception ex)
					{
						orderCancellationViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							orderCancellationViewModel.HideWait();
						}
					}
					IL_43C:;
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

			// Token: 0x06003F05 RID: 16133 RVA: 0x000FC5AC File Offset: 0x000FA7AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002967 RID: 10599
			public int <>1__state;

			// Token: 0x04002968 RID: 10600
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002969 RID: 10601
			public OrderCancellationViewModel <>4__this;

			// Token: 0x0400296A RID: 10602
			private TaskAwaiter<DateTime?> <>u__1;

			// Token: 0x0400296B RID: 10603
			private TaskAwaiter<IList<additional_payments>> <>u__2;

			// Token: 0x0400296C RID: 10604
			private TaskAwaiter <>u__3;
		}
	}
}
