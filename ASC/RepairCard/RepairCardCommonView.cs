using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Objects.VoIP;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.RepairCard.Admin;
using ASC.RepairCard.History;
using ASC.RepairCard.Media;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RepairCard
{
	// Token: 0x0200080D RID: 2061
	public class RepairCardCommonView : BaseViewModel
	{
		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x000F4D6C File Offset: 0x000F2F6C
		// (set) Token: 0x06003D8B RID: 15755 RVA: 0x000F4D80 File Offset: 0x000F2F80
		public int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairId>k__BackingField == value)
				{
					return;
				}
				this.<RepairId>k__BackingField = value;
				this.RaisePropertyChanged("RepairId");
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06003D8C RID: 15756 RVA: 0x000F4DAC File Offset: 0x000F2FAC
		// (set) Token: 0x06003D8D RID: 15757 RVA: 0x000F4DC0 File Offset: 0x000F2FC0
		public workshop Repair
		{
			[CompilerGenerated]
			get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repair>k__BackingField, value))
				{
					return;
				}
				this.<Repair>k__BackingField = value;
				this.RaisePropertyChanged("Repair");
			}
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x000F4DF0 File Offset: 0x000F2FF0
		public RepairCardCommonView()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x000F4E30 File Offset: 0x000F3030
		public bool CanUnlock
		{
			get
			{
				return this.CanUnlockCard();
			}
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x000F4E44 File Offset: 0x000F3044
		public void InitLockCard(int repairId)
		{
			this.LockCardModel = new LockCardModel(repairId);
			LockCardModel lockCardModel = this.LockCardModel;
			lockCardModel.CloseCard = (EventHandler)Delegate.Combine(lockCardModel.CloseCard, new EventHandler(this.CloseCard));
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x000F4E84 File Offset: 0x000F3084
		private void CloseCard(object sender, EventArgs e)
		{
			this._navigationService.CloseTabByName(base.ViewName);
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00030894 File Offset: 0x0002EA94
		public bool CanUnlockCard()
		{
			return OfflineData.Instance.Employee.Can(25, 0);
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x000F4EA4 File Offset: 0x000F30A4
		[Command]
		public virtual void OpenRepairCommon()
		{
			this._navigationService.NavigateRepairCard(this.RepairId);
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x000F4EC4 File Offset: 0x000F30C4
		[Command]
		public virtual void OpenRepairAdmin()
		{
			this._navigationService.Navigate("AdminView", new AdminViewModel(this.RepairId));
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00030894 File Offset: 0x0002EA94
		public bool CanOpenRepairAdmin()
		{
			return OfflineData.Instance.Employee.Can(25, 0);
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x000F4EEC File Offset: 0x000F30EC
		[Command]
		public void OpenRepairHistory()
		{
			this._navigationService.Navigate("RepairHistoryView", new RepairHistoryViewModel(this.Repair));
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x000F4F14 File Offset: 0x000F3114
		public bool CanOpenRepairHistory()
		{
			return OfflineData.Instance.Employee.Can(78, 0);
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x000F4F34 File Offset: 0x000F3134
		[Command]
		public void OpenMedia()
		{
			this._navigationService.Navigate("ASC.RepairCard.Media.MediaView", new MediaViewModel(this.RepairId, this.Repair));
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool CanOpenMedia()
		{
			return base.IsValid();
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x000F4F64 File Offset: 0x000F3164
		[Command]
		public void CallClient()
		{
			RepairCardCommonView.<CallClient>d__25 <CallClient>d__;
			<CallClient>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CallClient>d__.<>4__this = this;
			<CallClient>d__.<>1__state = -1;
			<CallClient>d__.<>t__builder.Start<RepairCardCommonView.<CallClient>d__25>(ref <CallClient>d__);
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x0006A994 File Offset: 0x00068B94
		public bool CanCallClient()
		{
			return Core.Instance.CanCall();
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x000F4F9C File Offset: 0x000F319C
		[Command]
		public void OpenClientCard()
		{
			this._navigationService.NavigateToCustomerCard(this.Repair.client, null);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool CanOpenClientCard()
		{
			return OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x0003098C File Offset: 0x0002EB8C
		public bool CanOpenDocuments()
		{
			return OfflineData.Instance.Employee.Can(15, 0);
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x000F4FC0 File Offset: 0x000F31C0
		[Command]
		public void CopyDeviceInfo()
		{
			if (this.Repair != null)
			{
				Clipboard.SetText(this.Repair.Title);
			}
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x000F4FE8 File Offset: 0x000F31E8
		[Command]
		public void CopyAllDeviceInfo()
		{
			if (this.Repair == null)
			{
				return;
			}
			Clipboard.SetText(string.Format("{0}: {1:D6} {2} {3}: {4}", new object[]
			{
				Lang.t("OrderNumber"),
				this.Repair.id,
				this.Repair.Title,
				Lang.t("SerialNumber"),
				this.Repair.serial_number
			}));
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x000F505C File Offset: 0x000F325C
		[Command]
		public void PrintDocumentLoss()
		{
			if (this.Repair == null)
			{
				return;
			}
			new DocumentLoss(this.Repair.id).Show();
		}

		// Token: 0x0400283F RID: 10303
		protected IWorkshopService _workshopService;

		// Token: 0x04002840 RID: 10304
		protected INavigationService _navigationService;

		// Token: 0x04002841 RID: 10305
		public RepairModel _RepairModel = new RepairModel();

		// Token: 0x04002842 RID: 10306
		[CompilerGenerated]
		private int <RepairId>k__BackingField;

		// Token: 0x04002843 RID: 10307
		[CompilerGenerated]
		private workshop <Repair>k__BackingField;

		// Token: 0x04002844 RID: 10308
		public LockCardModel LockCardModel;

		// Token: 0x0200080E RID: 2062
		[CompilerGenerated]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x06003DA2 RID: 15778 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x06003DA3 RID: 15779 RVA: 0x000F5088 File Offset: 0x000F3288
			internal Task<Callback> <CallClient>b__1()
			{
				return Core.Instance.VoIP.Callback(OfflineData.Instance.Employee.Tel.ToString(), this.phone.PhoneClean);
			}

			// Token: 0x04002845 RID: 10309
			public Tel phone;
		}

		// Token: 0x0200080F RID: 2063
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003DA4 RID: 15780 RVA: 0x000F50CC File Offset: 0x000F32CC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003DA5 RID: 15781 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003DA6 RID: 15782 RVA: 0x0008C41C File Offset: 0x0008A61C
			internal bool <CallClient>b__25_0(Tel p)
			{
				return p.Type == 1;
			}

			// Token: 0x04002846 RID: 10310
			public static readonly RepairCardCommonView.<>c <>9 = new RepairCardCommonView.<>c();

			// Token: 0x04002847 RID: 10311
			public static Func<Tel, bool> <>9__25_0;
		}

		// Token: 0x02000810 RID: 2064
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CallClient>d__25 : IAsyncStateMachine
		{
			// Token: 0x06003DA7 RID: 15783 RVA: 0x000F50E4 File Offset: 0x000F32E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardCommonView repairCardCommonView = this.<>4__this;
				try
				{
					if (num > 1)
					{
						this.<toasterService>5__2 = Bootstrapper.Container.Resolve<IToasterService>();
						repairCardCommonView.ShowWait();
					}
					try
					{
						TaskAwaiter<Callback> awaiter;
						TaskAwaiter<CustomerCard> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<Callback>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_154;
							}
							this.<>8__1 = new RepairCardCommonView.<>c__DisplayClass25_0();
							awaiter2 = ClientsModel.GetCustomerCard(repairCardCommonView.Repair.client).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, RepairCardCommonView.<CallClient>d__25>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<CustomerCard>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						CustomerCard result = awaiter2.GetResult();
						this.<>8__1.phone = result.Phones.FirstOrDefault(new Func<Tel, bool>(RepairCardCommonView.<>c.<>9.<CallClient>b__25_0));
						if (this.<>8__1.phone == null || string.IsNullOrEmpty(this.<>8__1.phone.PhoneClean))
						{
							this.<toasterService>5__2.Info("Tel not found");
							goto IL_15C;
						}
						awaiter = Task.Run<Callback>(new Func<Task<Callback>>(this.<>8__1.<CallClient>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Callback>, RepairCardCommonView.<CallClient>d__25>(ref awaiter, ref this);
							return;
						}
						IL_154:
						awaiter.GetResult();
						IL_15C:
						this.<>8__1 = null;
					}
					catch (Exception ex)
					{
						this.<toasterService>5__2.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairCardCommonView.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<toasterService>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<toasterService>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003DA8 RID: 15784 RVA: 0x000F5324 File Offset: 0x000F3524
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002848 RID: 10312
			public int <>1__state;

			// Token: 0x04002849 RID: 10313
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400284A RID: 10314
			public RepairCardCommonView <>4__this;

			// Token: 0x0400284B RID: 10315
			private RepairCardCommonView.<>c__DisplayClass25_0 <>8__1;

			// Token: 0x0400284C RID: 10316
			private IToasterService <toasterService>5__2;

			// Token: 0x0400284D RID: 10317
			private TaskAwaiter<CustomerCard> <>u__1;

			// Token: 0x0400284E RID: 10318
			private TaskAwaiter<Callback> <>u__2;
		}
	}
}
