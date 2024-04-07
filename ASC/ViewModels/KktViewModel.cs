using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Extensions.KKT;
using ASC.Extensions.Pinpad;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000422 RID: 1058
	public class KktViewModel : BaseViewModel, IKktCheque
	{
		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x00085CD8 File Offset: 0x00083ED8
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x00085CEC File Offset: 0x00083EEC
		public decimal PinpadSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<PinpadSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<PinpadSumm>k__BackingField, value))
				{
					return;
				}
				this.<PinpadSumm>k__BackingField = value;
				this.RaisePropertyChanged("PinpadSumm");
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x00085D1C File Offset: 0x00083F1C
		// (set) Token: 0x06002A6D RID: 10861 RVA: 0x00085D30 File Offset: 0x00083F30
		public string ItemName
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ItemName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ItemName>k__BackingField = value;
				this.RaisePropertyChanged("ItemName");
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x00085D60 File Offset: 0x00083F60
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x00085D74 File Offset: 0x00083F74
		public int ItemCount
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ItemCount>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 2051100456;
				IL_10:
				switch ((num ^ 245405302) % 4)
				{
				case 1:
					IL_2F:
					this.<ItemCount>k__BackingField = value;
					num = 1814164278;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("ItemCount");
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x00085DCC File Offset: 0x00083FCC
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x00085DE0 File Offset: 0x00083FE0
		public decimal ItemPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<ItemPrice>k__BackingField, value))
				{
					return;
				}
				this.<ItemPrice>k__BackingField = value;
				this.RaisePropertyChanged("ItemPrice");
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x00085E10 File Offset: 0x00084010
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x00085E24 File Offset: 0x00084024
		public bool Card
		{
			[CompilerGenerated]
			get
			{
				return this.<Card>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Card>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1872955124;
				IL_10:
				switch ((num ^ 842819009) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					num = 1826712018;
					goto IL_10;
				}
				this.<Card>k__BackingField = value;
				this.RaisePropertyChanged("Card");
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x00085E7C File Offset: 0x0008407C
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x00085E90 File Offset: 0x00084090
		public string KktHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<KktHeader>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<KktHeader>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<KktHeader>k__BackingField = value;
				this.RaisePropertyChanged("KktHeader");
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x00085EC0 File Offset: 0x000840C0
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00085ED4 File Offset: 0x000840D4
		public string ShiftState
		{
			[CompilerGenerated]
			get
			{
				return this.<ShiftState>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ShiftState>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ShiftState>k__BackingField = value;
				this.RaisePropertyChanged("ShiftState");
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x00085F04 File Offset: 0x00084104
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x00085F18 File Offset: 0x00084118
		public int PaymentSign
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSign>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PaymentSign>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -70512846;
				IL_10:
				switch ((num ^ -435439967) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<PaymentSign>k__BackingField = value;
					this.RaisePropertyChanged("PaymentSign");
					num = -1463222896;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00085F70 File Offset: 0x00084170
		public KktViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.ItemCount = 1;
			string str = (string)Application.Current.TryFindResource("KKT");
			string str2 = " [";
			IKKT kkt = OfflineData.Instance.Employee.Kkt;
			this.KktHeader = str + str2 + ((kkt != null) ? kkt.Name : null) + "]";
			this.LoadPaymentItemSigns();
			this.PaymentSign = 1;
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00085FFC File Offset: 0x000841FC
		private void GetShiftState()
		{
			KktViewModel.<GetShiftState>d__35 <GetShiftState>d__;
			<GetShiftState>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GetShiftState>d__.<>4__this = this;
			<GetShiftState>d__.<>1__state = -1;
			<GetShiftState>d__.<>t__builder.Start<KktViewModel.<GetShiftState>d__35>(ref <GetShiftState>d__);
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00086034 File Offset: 0x00084234
		[Command]
		public void KktZOrder()
		{
			OfflineData.Instance.Employee.Kkt.ZOrder();
			this.GetShiftState();
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x00046F70 File Offset: 0x00045170
		public bool CanKktZOrder()
		{
			return OfflineData.Instance.Employee.KktReady();
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0008605C File Offset: 0x0008425C
		[Command]
		public void KktXOrder()
		{
			OfflineData.Instance.Employee.Kkt.XOrder();
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00046F70 File Offset: 0x00045170
		public bool CanKktXOrder()
		{
			return OfflineData.Instance.Employee.KktReady();
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00086080 File Offset: 0x00084280
		[Command]
		public void KktSettings()
		{
			OfflineData.Instance.Employee.Kkt.ShowSettings();
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x000860A4 File Offset: 0x000842A4
		public bool CanKktSettings()
		{
			return OfflineData.Instance.Employee.Can(79, 0) && OfflineData.Instance.Employee.KktReady();
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000860D8 File Offset: 0x000842D8
		private bool CheckItem()
		{
			if (string.IsNullOrEmpty(this.ItemName))
			{
				this._toasterService.Info(Lang.t("InputItemName"));
				return false;
			}
			if (this.ItemPrice <= 0m)
			{
				this._toasterService.Info(Lang.t("InputSumm"));
				return false;
			}
			if (this.ItemCount >= 1)
			{
				return true;
			}
			this._toasterService.Info("Количество не может быть меньше 1");
			return false;
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00086150 File Offset: 0x00084350
		[Command]
		public void KktSale()
		{
			if (!this.CheckItem())
			{
				return;
			}
			if (this.Card && OfflineData.Instance.Employee.PinpadReady())
			{
				IPinpadResult pinpadResult = new SBRFPinpad().Purchase(this.ItemPrice * this.ItemCount);
				if (pinpadResult.ErrorCode != 0)
				{
					this._toasterService.Error(pinpadResult.ResultText);
					return;
				}
			}
			IAscResult ascResult = OfflineData.Instance.Employee.Kkt.OpenSaleCheck();
			if (!ascResult.IsSucces || !string.IsNullOrEmpty(ascResult.Message))
			{
				this._toasterService.Error(ascResult.Message);
				return;
			}
			OfflineData.Instance.Employee.Kkt.AddItem(this.ItemCount, this.ItemPrice, this.ItemName, this.PaymentSign);
			if (OfflineData.Instance.Employee.Kkt.CloseCheck(this.ItemPrice, this.Card))
			{
				this._toasterService.Success(Lang.t("Complete"));
				return;
			}
			this._toasterService.Error("");
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00046F70 File Offset: 0x00045170
		public bool CanKktSale()
		{
			return OfflineData.Instance.Employee.KktReady();
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00086270 File Offset: 0x00084470
		[Command]
		public void PinpadZOrder()
		{
			base.ShowWait();
			SBRFPinpad sbrfpinpad = new SBRFPinpad();
			if (!sbrfpinpad.PinpadReady())
			{
				base.HideWait();
				this._toasterService.Error("Pinpad not ready");
				return;
			}
			bool flag = sbrfpinpad.ZOrder();
			base.HideWait();
			if (flag)
			{
				this._toasterService.Success(Lang.t("Complete"));
				return;
			}
			this._toasterService.Error("");
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x000862DC File Offset: 0x000844DC
		public bool CanPinpadZOrder()
		{
			return OfflineData.Instance.Employee.PinpadReady();
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000862F8 File Offset: 0x000844F8
		[Command]
		public void PinpadRefund()
		{
			if (this.PinpadSumm <= 0m)
			{
				this._toasterService.Info(Lang.t("InputSumm"));
				return;
			}
			SBRFPinpad sbrfpinpad = new SBRFPinpad();
			if (!sbrfpinpad.PinpadReady())
			{
				this._toasterService.Error("Pinpad not ready");
				return;
			}
			IPinpadResult pinpadResult = sbrfpinpad.Refund(this.PinpadSumm);
			if (pinpadResult.ErrorCode == 0)
			{
				this._toasterService.Success(Lang.t("Complete"));
				return;
			}
			this._toasterService.Error(pinpadResult.ResultText);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000862DC File Offset: 0x000844DC
		public bool CanPinpadRefund()
		{
			return OfflineData.Instance.Employee.PinpadReady();
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00086388 File Offset: 0x00084588
		[Command]
		public void CloseDocument()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x000863A0 File Offset: 0x000845A0
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x000863B4 File Offset: 0x000845B4
		public Dictionary<int, string> PaymentItemSigns
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentItemSigns>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<PaymentItemSigns>k__BackingField, value))
				{
					return;
				}
				this.<PaymentItemSigns>k__BackingField = value;
				this.RaisePropertyChanged("PaymentItemSigns");
			}
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000863E4 File Offset: 0x000845E4
		public void LoadPaymentItemSigns()
		{
			this.PaymentItemSigns = KktBase.GetPaymentItemSigns();
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000863FC File Offset: 0x000845FC
		[Command]
		public void OnLoaded()
		{
			this.GetShiftState();
		}

		// Token: 0x04001786 RID: 6022
		private readonly IToasterService _toasterService;

		// Token: 0x04001787 RID: 6023
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001788 RID: 6024
		[CompilerGenerated]
		private decimal <PinpadSumm>k__BackingField;

		// Token: 0x04001789 RID: 6025
		[CompilerGenerated]
		private string <ItemName>k__BackingField;

		// Token: 0x0400178A RID: 6026
		[CompilerGenerated]
		private int <ItemCount>k__BackingField;

		// Token: 0x0400178B RID: 6027
		[CompilerGenerated]
		private decimal <ItemPrice>k__BackingField;

		// Token: 0x0400178C RID: 6028
		[CompilerGenerated]
		private bool <Card>k__BackingField;

		// Token: 0x0400178D RID: 6029
		[CompilerGenerated]
		private string <KktHeader>k__BackingField;

		// Token: 0x0400178E RID: 6030
		[CompilerGenerated]
		private string <ShiftState>k__BackingField;

		// Token: 0x0400178F RID: 6031
		[CompilerGenerated]
		private int <PaymentSign>k__BackingField;

		// Token: 0x04001790 RID: 6032
		[CompilerGenerated]
		private Dictionary<int, string> <PaymentItemSigns>k__BackingField;

		// Token: 0x02000423 RID: 1059
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002A8E RID: 10894 RVA: 0x00086410 File Offset: 0x00084610
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002A8F RID: 10895 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002A90 RID: 10896 RVA: 0x00086428 File Offset: 0x00084628
			internal bool <GetShiftState>b__35_0()
			{
				return OfflineData.Instance.Employee.Kkt.IsShiftOpened();
			}

			// Token: 0x04001791 RID: 6033
			public static readonly KktViewModel.<>c <>9 = new KktViewModel.<>c();

			// Token: 0x04001792 RID: 6034
			public static Func<bool> <>9__35_0;
		}

		// Token: 0x02000424 RID: 1060
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetShiftState>d__35 : IAsyncStateMachine
		{
			// Token: 0x06002A91 RID: 10897 RVA: 0x0008644C File Offset: 0x0008464C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KktViewModel kktViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<bool>(new Func<bool>(KktViewModel.<>c.<>9.<GetShiftState>b__35_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, KktViewModel.<GetShiftState>d__35>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter.GetResult();
					kktViewModel.ShiftState = (result ? Lang.t("ShiftOpened") : Lang.t("ShiftClosed"));
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

			// Token: 0x06002A92 RID: 10898 RVA: 0x00086540 File Offset: 0x00084740
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001793 RID: 6035
			public int <>1__state;

			// Token: 0x04001794 RID: 6036
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001795 RID: 6037
			public KktViewModel <>4__this;

			// Token: 0x04001796 RID: 6038
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
