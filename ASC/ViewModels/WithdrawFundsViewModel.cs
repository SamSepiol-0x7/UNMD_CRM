using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020003DD RID: 989
	public class WithdrawFundsViewModel : PopupViewModel
	{
		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x0007DB7C File Offset: 0x0007BD7C
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x0007DB90 File Offset: 0x0007BD90
		public int WithdrawOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<WithdrawOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WithdrawOffice>k__BackingField == value)
				{
					return;
				}
				this.<WithdrawOffice>k__BackingField = value;
				this.RaisePropertyChanged("WithdrawOffice");
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x0007DBBC File Offset: 0x0007BDBC
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x0007DBD0 File Offset: 0x0007BDD0
		public Dictionary<int, string> WithdrawModeSource
		{
			[CompilerGenerated]
			get
			{
				return this.<WithdrawModeSource>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<WithdrawModeSource>k__BackingField, value))
				{
					return;
				}
				this.<WithdrawModeSource>k__BackingField = value;
				this.RaisePropertyChanged("WithdrawModeSource");
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x0007DC00 File Offset: 0x0007BE00
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x0007DC14 File Offset: 0x0007BE14
		public int WithdrawMode
		{
			[CompilerGenerated]
			get
			{
				return this.<WithdrawMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WithdrawMode>k__BackingField == value)
				{
					return;
				}
				this.<WithdrawMode>k__BackingField = value;
				this.RaisePropertyChanged("WithdrawMode");
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x0007DC40 File Offset: 0x0007BE40
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x0007DC54 File Offset: 0x0007BE54
		public decimal WithdrawSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<WithdrawSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<WithdrawSumm>k__BackingField, value))
				{
					return;
				}
				this.<WithdrawSumm>k__BackingField = value;
				this.RaisePropertyChanged("WithdrawSumm");
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0007DC84 File Offset: 0x0007BE84
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x0007DC98 File Offset: 0x0007BE98
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

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0007DCC4 File Offset: 0x0007BEC4
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x0007DCD8 File Offset: 0x0007BED8
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
				if (this.<SelectedPaymentSystem>k__BackingField == value)
				{
					return;
				}
				this.<SelectedPaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPaymentSystem");
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x0007DD04 File Offset: 0x0007BF04
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x0007DD18 File Offset: 0x0007BF18
		public ObservableCollection<PaymentOptions> PaymentOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOptions>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<PaymentOptions>k__BackingField, value))
				{
					return;
				}
				this.<PaymentOptions>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOptions");
			}
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0007DD48 File Offset: 0x0007BF48
		public WithdrawFundsViewModel(IKassa kassaModel, IToasterService toasterService)
		{
			this._kassaModel = kassaModel;
			this._toasterService = toasterService;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0007DD74 File Offset: 0x0007BF74
		private bool CheckWithdrawFields()
		{
			if (this.WithdrawOffice == 0)
			{
				this._toasterService.Info(Lang.t("SelectOffice"));
				return false;
			}
			if (this.WithdrawSumm == 0m)
			{
				this._toasterService.Info(Lang.t("ItemError"));
				return false;
			}
			if (this.SelectedUser != 0)
			{
				return true;
			}
			this._toasterService.Info(Lang.t("SelectRkoRecepient"));
			return false;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x0007DDEC File Offset: 0x0007BFEC
		[Command]
		public void WithdrawFunds()
		{
			WithdrawFundsViewModel.<WithdrawFunds>d__33 <WithdrawFunds>d__;
			<WithdrawFunds>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<WithdrawFunds>d__.<>4__this = this;
			<WithdrawFunds>d__.<>1__state = -1;
			<WithdrawFunds>d__.<>t__builder.Start<WithdrawFundsViewModel.<WithdrawFunds>d__33>(ref <WithdrawFunds>d__);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00078C54 File Offset: 0x00076E54
		[Command]
		public void CloseDocument()
		{
			base.ClosePopup();
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0007DE24 File Offset: 0x0007C024
		public override void OnLoad()
		{
			base.OnLoad();
			this.WithdrawModeSource = this._kassaModel.GetWithdrawModes();
			this.WithdrawOffice = OfflineData.Instance.Employee.OfficeId;
			if (!this.PaymentOptions.Any<PaymentOptions>())
			{
				List<int> paymentSystemIds = new List<int>
				{
					0,
					1,
					-1
				};
				IEnumerable<PaymentOptions> collection = from i in OfflineData.Instance.PaymentOptionses
				where paymentSystemIds.Contains(i.Id)
				select i;
				this.PaymentOptions = new ObservableCollection<PaymentOptions>(collection);
			}
			this.SelectedPaymentSystem = 0;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0007DEC0 File Offset: 0x0007C0C0
		protected override void OnParentViewModelChanged(object obj)
		{
			this._parentViewModel = (obj as IRefreshable);
		}

		// Token: 0x0400163D RID: 5693
		private readonly IKassa _kassaModel;

		// Token: 0x0400163E RID: 5694
		private readonly IToasterService _toasterService;

		// Token: 0x0400163F RID: 5695
		private IRefreshable _parentViewModel;

		// Token: 0x04001640 RID: 5696
		[CompilerGenerated]
		private int <WithdrawOffice>k__BackingField;

		// Token: 0x04001641 RID: 5697
		[CompilerGenerated]
		private Dictionary<int, string> <WithdrawModeSource>k__BackingField;

		// Token: 0x04001642 RID: 5698
		[CompilerGenerated]
		private int <WithdrawMode>k__BackingField;

		// Token: 0x04001643 RID: 5699
		[CompilerGenerated]
		private decimal <WithdrawSumm>k__BackingField;

		// Token: 0x04001644 RID: 5700
		[CompilerGenerated]
		private int <SelectedUser>k__BackingField;

		// Token: 0x04001645 RID: 5701
		[CompilerGenerated]
		private int <SelectedPaymentSystem>k__BackingField;

		// Token: 0x04001646 RID: 5702
		[CompilerGenerated]
		private ObservableCollection<PaymentOptions> <PaymentOptions>k__BackingField = new ObservableCollection<PaymentOptions>();

		// Token: 0x020003DE RID: 990
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600289C RID: 10396 RVA: 0x0007DEDC File Offset: 0x0007C0DC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600289D RID: 10397 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600289E RID: 10398 RVA: 0x0007DEF4 File Offset: 0x0007C0F4
			internal bool <WithdrawFunds>b__33_0(offices o)
			{
				return o.id != 0;
			}

			// Token: 0x04001647 RID: 5703
			public static readonly WithdrawFundsViewModel.<>c <>9 = new WithdrawFundsViewModel.<>c();

			// Token: 0x04001648 RID: 5704
			public static Func<offices, bool> <>9__33_0;
		}

		// Token: 0x020003DF RID: 991
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <WithdrawFunds>d__33 : IAsyncStateMachine
		{
			// Token: 0x0600289F RID: 10399 RVA: 0x0007DF0C File Offset: 0x0007C10C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WithdrawFundsViewModel withdrawFundsViewModel = this.<>4__this;
				try
				{
					decimal summa;
					if (num != 0)
					{
						if (OfflineData.Instance.CountOffices() == 1)
						{
							offices offices = OfflineData.Instance.Offices.FirstOrDefault(new Func<offices, bool>(WithdrawFundsViewModel.<>c.<>9.<WithdrawFunds>b__33_0));
							if (offices != null)
							{
								withdrawFundsViewModel.WithdrawOffice = offices.id;
							}
						}
						if (!withdrawFundsViewModel.CheckWithdrawFields())
						{
							goto IL_181;
						}
						decimal num2 = Math.Abs(withdrawFundsViewModel.WithdrawSumm);
						summa = ((withdrawFundsViewModel.WithdrawMode == 0) ? num2 : (-num2));
						withdrawFundsViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = withdrawFundsViewModel._kassaModel.Widthraw(withdrawFundsViewModel.WithdrawOffice, withdrawFundsViewModel.SelectedUser, withdrawFundsViewModel.SelectedPaymentSystem, summa).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WithdrawFundsViewModel.<WithdrawFunds>d__33>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter.GetResult();
						withdrawFundsViewModel._toasterService.Success("");
						IRefreshable parentViewModel = withdrawFundsViewModel._parentViewModel;
						if (parentViewModel != null)
						{
							parentViewModel.DataRefresh();
						}
						withdrawFundsViewModel.WithdrawSumm = 0m;
						withdrawFundsViewModel.ClosePopup();
					}
					catch (Exception ex)
					{
						withdrawFundsViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							withdrawFundsViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_181:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060028A0 RID: 10400 RVA: 0x0007E0FC File Offset: 0x0007C2FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001649 RID: 5705
			public int <>1__state;

			// Token: 0x0400164A RID: 5706
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400164B RID: 5707
			public WithdrawFundsViewModel <>4__this;

			// Token: 0x0400164C RID: 5708
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003E0 RID: 992
		[CompilerGenerated]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x060028A1 RID: 10401 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x060028A2 RID: 10402 RVA: 0x0007E118 File Offset: 0x0007C318
			internal bool <OnLoad>b__0(PaymentOptions i)
			{
				return this.paymentSystemIds.Contains(i.Id);
			}

			// Token: 0x0400164D RID: 5709
			public List<int> paymentSystemIds;
		}
	}
}
