using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Extensions.KKT;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000586 RID: 1414
	public class FinancesViewModel : BaseViewModel
	{
		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x000B1344 File Offset: 0x000AF544
		// (set) Token: 0x0600344B RID: 13387 RVA: 0x000B1358 File Offset: 0x000AF558
		public config Config
		{
			[CompilerGenerated]
			get
			{
				return this.<Config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Config>k__BackingField, value))
				{
					return;
				}
				this.<Config>k__BackingField = value;
				this.RaisePropertyChanged("Config");
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x000B1388 File Offset: 0x000AF588
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x000B139C File Offset: 0x000AF59C
		public ObservableCollection<payment_systems> PaymentSystems
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentSystems>k__BackingField, value))
				{
					return;
				}
				this.<PaymentSystems>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystems");
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x000B13CC File Offset: 0x000AF5CC
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x000B13E0 File Offset: 0x000AF5E0
		public ObservableCollection<payment_types> PaymentTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentTypes>k__BackingField, value))
				{
					return;
				}
				this.<PaymentTypes>k__BackingField = value;
				this.RaisePropertyChanged("PaymentTypes");
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x000B1410 File Offset: 0x000AF610
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x000B1424 File Offset: 0x000AF624
		public List<KeyValuePair<int, string>> ExchangeRateSource
		{
			[CompilerGenerated]
			get
			{
				return this.<ExchangeRateSource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ExchangeRateSource>k__BackingField, value))
				{
					return;
				}
				this.<ExchangeRateSource>k__BackingField = value;
				this.RaisePropertyChanged("ExchangeRateSource");
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x000B1454 File Offset: 0x000AF654
		// (set) Token: 0x06003453 RID: 13395 RVA: 0x000B1468 File Offset: 0x000AF668
		public List<KkmProtocolOptions> KkmProtocolOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<KkmProtocolOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<KkmProtocolOptionses>k__BackingField, value))
				{
					return;
				}
				this.<KkmProtocolOptionses>k__BackingField = value;
				this.RaisePropertyChanged("KkmProtocolOptionses");
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x000B1498 File Offset: 0x000AF698
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x000B14AC File Offset: 0x000AF6AC
		public List<kkt> Kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<Kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Kkt>k__BackingField, value))
				{
					return;
				}
				this.<Kkt>k__BackingField = value;
				this.RaisePropertyChanged("PinpadPrinters");
				this.RaisePropertyChanged("Kkt");
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x000B14E8 File Offset: 0x000AF6E8
		// (set) Token: 0x06003457 RID: 13399 RVA: 0x000B14FC File Offset: 0x000AF6FC
		public List<pinpad> Pinpads
		{
			[CompilerGenerated]
			get
			{
				return this.<Pinpads>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Pinpads>k__BackingField, value))
				{
					return;
				}
				this.<Pinpads>k__BackingField = value;
				this.RaisePropertyChanged("Pinpads");
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06003458 RID: 13400 RVA: 0x000B152C File Offset: 0x000AF72C
		// (set) Token: 0x06003459 RID: 13401 RVA: 0x000B1540 File Offset: 0x000AF740
		public kkt SelectedKkt
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedKkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedKkt>k__BackingField, value))
				{
					return;
				}
				this.<SelectedKkt>k__BackingField = value;
				this.RaisePropertyChanged("SelectedKkt");
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x000B1570 File Offset: 0x000AF770
		// (set) Token: 0x0600345B RID: 13403 RVA: 0x000B1584 File Offset: 0x000AF784
		public pinpad SelectedPinpad
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPinpad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedPinpad>k__BackingField, value))
				{
					return;
				}
				this.<SelectedPinpad>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPinpad");
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x000B15B4 File Offset: 0x000AF7B4
		// (set) Token: 0x0600345D RID: 13405 RVA: 0x000B15C8 File Offset: 0x000AF7C8
		public payment_systems SelectedPaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedPaymentSystem>k__BackingField, value))
				{
					return;
				}
				this.<SelectedPaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPaymentSystem");
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x000B15F8 File Offset: 0x000AF7F8
		// (set) Token: 0x0600345F RID: 13407 RVA: 0x000B160C File Offset: 0x000AF80C
		public bool ShowArchivePaymentSystems
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowArchivePaymentSystems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowArchivePaymentSystems>k__BackingField == value)
				{
					return;
				}
				this.<ShowArchivePaymentSystems>k__BackingField = value;
				this.RaisePropertyChanged("ShowArchivePaymentSystems");
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x000B1638 File Offset: 0x000AF838
		// (set) Token: 0x06003461 RID: 13409 RVA: 0x000B164C File Offset: 0x000AF84C
		public Currency SelectedCurrency
		{
			get
			{
				return this._selectedCurrency;
			}
			set
			{
				if (object.Equals(this._selectedCurrency, value))
				{
					return;
				}
				this._selectedCurrency = value;
				this.RaisePropertyChanged("SelectedCurrency");
				this.LoadExchangeSources();
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x000B1680 File Offset: 0x000AF880
		// (set) Token: 0x06003463 RID: 13411 RVA: 0x000B1694 File Offset: 0x000AF894
		public payment_types SelectedPaymentType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPaymentType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedPaymentType>k__BackingField, value))
				{
					return;
				}
				this.<SelectedPaymentType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPaymentType");
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x000B16C4 File Offset: 0x000AF8C4
		// (set) Token: 0x06003465 RID: 13413 RVA: 0x000B16D8 File Offset: 0x000AF8D8
		public ICommand SaveCommonCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveCommonCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SaveCommonCommand>k__BackingField, value))
				{
					return;
				}
				this.<SaveCommonCommand>k__BackingField = value;
				this.RaisePropertyChanged("SaveCommonCommand");
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06003466 RID: 13414 RVA: 0x000B1708 File Offset: 0x000AF908
		// (set) Token: 0x06003467 RID: 13415 RVA: 0x000B171C File Offset: 0x000AF91C
		public ICommand LoadedCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<LoadedCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<LoadedCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -102981266;
				IL_13:
				switch ((num ^ -172095625) % 4)
				{
				case 0:
					IL_32:
					num = -1566818884;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
				this.<LoadedCommand>k__BackingField = value;
				this.RaisePropertyChanged("LoadedCommand");
			}
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x000B1778 File Offset: 0x000AF978
		private void InitCommands()
		{
			this.SaveCommonCommand = new RelayCommand(new Action<object>(this.SaveCommon));
			this.LoadedCommand = new RelayCommand(new Action<object>(this.Loaded));
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x000B17B4 File Offset: 0x000AF9B4
		public FinancesViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.BgLoad();
			this.LoadExchangeSources();
			this.KkmProtocolOptionses = new KkmProtocolOptions().GetAllOptions();
			this.TaxTypes = ShtrihM.GetTaxTypes();
			this.InitCommands();
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x000B182C File Offset: 0x000AFA2C
		private void BgLoad()
		{
			FinancesViewModel.<BgLoad>d__65 <BgLoad>d__;
			<BgLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgLoad>d__.<>4__this = this;
			<BgLoad>d__.<>1__state = -1;
			<BgLoad>d__.<>t__builder.Start<FinancesViewModel.<BgLoad>d__65>(ref <BgLoad>d__);
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x000B1864 File Offset: 0x000AFA64
		private Task LoadPaymentTypes()
		{
			FinancesViewModel.<LoadPaymentTypes>d__66 <LoadPaymentTypes>d__;
			<LoadPaymentTypes>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadPaymentTypes>d__.<>4__this = this;
			<LoadPaymentTypes>d__.<>1__state = -1;
			<LoadPaymentTypes>d__.<>t__builder.Start<FinancesViewModel.<LoadPaymentTypes>d__66>(ref <LoadPaymentTypes>d__);
			return <LoadPaymentTypes>d__.<>t__builder.Task;
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x000B18A8 File Offset: 0x000AFAA8
		private Task LoadPaymentSystems()
		{
			FinancesViewModel.<LoadPaymentSystems>d__67 <LoadPaymentSystems>d__;
			<LoadPaymentSystems>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadPaymentSystems>d__.<>4__this = this;
			<LoadPaymentSystems>d__.<>1__state = -1;
			<LoadPaymentSystems>d__.<>t__builder.Start<FinancesViewModel.<LoadPaymentSystems>d__67>(ref <LoadPaymentSystems>d__);
			return <LoadPaymentSystems>d__.<>t__builder.Task;
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x000B18EC File Offset: 0x000AFAEC
		private Task LoadKkts()
		{
			FinancesViewModel.<LoadKkts>d__68 <LoadKkts>d__;
			<LoadKkts>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadKkts>d__.<>4__this = this;
			<LoadKkts>d__.<>1__state = -1;
			<LoadKkts>d__.<>t__builder.Start<FinancesViewModel.<LoadKkts>d__68>(ref <LoadKkts>d__);
			return <LoadKkts>d__.<>t__builder.Task;
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x000B1930 File Offset: 0x000AFB30
		private Task LoadPinpads()
		{
			FinancesViewModel.<LoadPinpads>d__69 <LoadPinpads>d__;
			<LoadPinpads>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadPinpads>d__.<>4__this = this;
			<LoadPinpads>d__.<>1__state = -1;
			<LoadPinpads>d__.<>t__builder.Start<FinancesViewModel.<LoadPinpads>d__69>(ref <LoadPinpads>d__);
			return <LoadPinpads>d__.<>t__builder.Task;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x000B1974 File Offset: 0x000AFB74
		private void LoadExchangeSources()
		{
			List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
			if (this.Config.currency != null && this.Config.currency == "RUB")
			{
				list.Add(new KeyValuePair<int, string>(2, "ЦБ РФ"));
			}
			if (this.Config.currency != null && this.Config.currency == "UAH")
			{
				list.Add(new KeyValuePair<int, string>(3, "ПриватБанк"));
			}
			this.ExchangeRateSource = list;
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x000B19F8 File Offset: 0x000AFBF8
		private void Loaded(object obj)
		{
			this.LoadExchangeSources();
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x000B1A0C File Offset: 0x000AFC0C
		[Command]
		public void AddPaymentSystem()
		{
			if (this.PaymentSystems == null)
			{
				return;
			}
			payment_systems payment_systems = this._orderOptions.AddPaymentSystem(this.PaymentSystems);
			if (payment_systems != null)
			{
				this.PaymentSystems.Add(payment_systems);
				return;
			}
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool CanAddPaymentSystem()
		{
			return base.IsValid();
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000B1A44 File Offset: 0x000AFC44
		[Command]
		public void RefreshKkt()
		{
			FinancesViewModel.<RefreshKkt>d__74 <RefreshKkt>d__;
			<RefreshKkt>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshKkt>d__.<>4__this = this;
			<RefreshKkt>d__.<>1__state = -1;
			<RefreshKkt>d__.<>t__builder.Start<FinancesViewModel.<RefreshKkt>d__74>(ref <RefreshKkt>d__);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x000B1A7C File Offset: 0x000AFC7C
		[Command]
		public void ShowCreateKkt()
		{
			this.SelectedKkt = new kkt
			{
				name = "KKT",
				office = new int?(OfflineData.Instance.Employee.OfficeId),
				protocol = 0,
				tax_type = 3,
				tax = 0,
				r_simple = true,
				s_simple = true,
				r_tpl = (string)Application.Current.TryFindResource("DefaultRTpl"),
				s_tpl = (string)Application.Current.TryFindResource("DefaultSTpl"),
				footer = "==================",
				order_payment_item_sign = 4,
				product_payment_item_sign = 1
			};
			this._windowedDocumentService.ShowNewDocument("KktEditView", this, null, null);
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x000B1B3C File Offset: 0x000AFD3C
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x000B1B50 File Offset: 0x000AFD50
		public Dictionary<int, string> TaxTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<TaxTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<TaxTypes>k__BackingField, value))
				{
					return;
				}
				this.<TaxTypes>k__BackingField = value;
				this.RaisePropertyChanged("TaxTypes");
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x000B1B80 File Offset: 0x000AFD80
		// (set) Token: 0x06003478 RID: 13432 RVA: 0x000B1B94 File Offset: 0x000AFD94
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

		// Token: 0x06003479 RID: 13433 RVA: 0x000B1BC4 File Offset: 0x000AFDC4
		private void LoadPaymentItemSigns()
		{
			this.PaymentItemSigns = KktBase.GetPaymentItemSigns();
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x000B1BDC File Offset: 0x000AFDDC
		private bool CheckKktFields()
		{
			if (string.IsNullOrEmpty(this.SelectedKkt.name))
			{
				this._toasterService.Info(Lang.t("InputName"));
				return false;
			}
			if (this.SelectedKkt.r_simple && string.IsNullOrEmpty(this.SelectedKkt.r_tpl))
			{
				this._toasterService.Info(Lang.t("TemplateWarning"));
				return false;
			}
			if (this.SelectedKkt.s_simple && string.IsNullOrEmpty(this.SelectedKkt.s_tpl))
			{
				this._toasterService.Info(Lang.t("TemplateWarning"));
				return false;
			}
			if (this.SelectedKkt.office == null)
			{
				this._toasterService.Info(Lang.t("SelectOffice"));
				return false;
			}
			return true;
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x000B1CAC File Offset: 0x000AFEAC
		[Command]
		public void SaveKkt()
		{
			FinancesViewModel.<SaveKkt>d__86 <SaveKkt>d__;
			<SaveKkt>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveKkt>d__.<>4__this = this;
			<SaveKkt>d__.<>1__state = -1;
			<SaveKkt>d__.<>t__builder.Start<FinancesViewModel.<SaveKkt>d__86>(ref <SaveKkt>d__);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x000B1CE4 File Offset: 0x000AFEE4
		private void ReloadUser()
		{
			Task.Run(delegate()
			{
				UsersModel.ReloadCurrentUser();
			});
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000B1D18 File Offset: 0x000AFF18
		[Command]
		public void DeleteKkt()
		{
			FinancesViewModel.<DeleteKkt>d__88 <DeleteKkt>d__;
			<DeleteKkt>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DeleteKkt>d__.<>4__this = this;
			<DeleteKkt>d__.<>1__state = -1;
			<DeleteKkt>d__.<>t__builder.Start<FinancesViewModel.<DeleteKkt>d__88>(ref <DeleteKkt>d__);
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000B1D50 File Offset: 0x000AFF50
		[Command]
		public void ShowKktEdit()
		{
			if (this.SelectedKkt != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 509960373;
			IL_0D:
			switch ((num ^ 1901868844) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_08;
			case 3:
				IL_2C:
				this._windowedDocumentService.ShowNewDocument("KktEditView", this, null, null);
				num = 266715908;
				goto IL_0D;
			}
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x000B1DA4 File Offset: 0x000AFFA4
		[Command]
		public void CloseDocument()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x000B1DBC File Offset: 0x000AFFBC
		[Command]
		public void ShowPsEdit()
		{
			if (this.SelectedPaymentSystem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 209854990;
			IL_0D:
			switch ((num ^ 901986315) % 4)
			{
			case 0:
				IL_2C:
				this._windowedDocumentService.ShowNewDocument("PaymentSystemEditView", this, null, null);
				num = 1153764116;
				goto IL_0D;
			case 1:
				return;
			case 2:
				goto IL_08;
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000B1E10 File Offset: 0x000B0010
		[Command]
		public void RefreshPs()
		{
			FinancesViewModel.<RefreshPs>d__92 <RefreshPs>d__;
			<RefreshPs>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshPs>d__.<>4__this = this;
			<RefreshPs>d__.<>1__state = -1;
			<RefreshPs>d__.<>t__builder.Start<FinancesViewModel.<RefreshPs>d__92>(ref <RefreshPs>d__);
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x000B1E48 File Offset: 0x000B0048
		[Command]
		public void ShowCreatePs()
		{
			this.SelectedPaymentSystem = new payment_systems
			{
				is_enable = true
			};
			this._windowedDocumentService.ShowNewDocument("PaymentSystemEditView", this, null, null);
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x000B1E7C File Offset: 0x000B007C
		[Command]
		public void SavePaymentSystem()
		{
			FinancesViewModel.<SavePaymentSystem>d__94 <SavePaymentSystem>d__;
			<SavePaymentSystem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SavePaymentSystem>d__.<>4__this = this;
			<SavePaymentSystem>d__.<>1__state = -1;
			<SavePaymentSystem>d__.<>t__builder.Start<FinancesViewModel.<SavePaymentSystem>d__94>(ref <SavePaymentSystem>d__);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x000B1EB4 File Offset: 0x000B00B4
		private bool CheckPaymentSystem()
		{
			if (string.IsNullOrEmpty(this.SelectedPaymentSystem.name))
			{
				this._toasterService.Info(Lang.t("InputName"));
				return false;
			}
			if (!string.IsNullOrEmpty(this.SelectedPaymentSystem.system_data))
			{
				return true;
			}
			this._toasterService.Info(Lang.t("InputDataField"));
			return false;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x000B1F14 File Offset: 0x000B0114
		private void SaveCommon(object obj)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					config config = auseceEntities.config.Find(new object[]
					{
						1
					});
					if (config == null)
					{
						return;
					}
					auseceEntities.Entry<config>(config).CurrentValues.SetValues(this.Config);
					auseceEntities.SaveChanges();
				}
				this._orderOptions.UpdatePaymentSystems(this.PaymentSystems);
				Auth.CurrencyModel.RefreshRate();
				base.ShowActionResponse(true, "");
			}
			catch (Exception)
			{
				base.ShowActionResponse(false, "");
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x000B1FC8 File Offset: 0x000B01C8
		public List<IIdName> PinpadPrinters
		{
			get
			{
				List<IIdName> list = new List<IIdName>();
				using (List<kkt>.Enumerator enumerator = this.Kkt.GetEnumerator())
				{
					for (;;)
					{
						IL_78:
						int num = (!enumerator.MoveNext()) ? 1771125035 : 833926717;
						for (;;)
						{
							switch ((num ^ 794684370) % 4)
							{
							case 0:
								num = 833926717;
								continue;
							case 2:
								goto IL_78;
							case 3:
							{
								kkt kkt = enumerator.Current;
								list.Add(new IdNameClass(kkt.id, kkt.name));
								num = 2105366272;
								continue;
							}
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
				list.Add(new IdNameClass(-1, Lang.t("Printer")));
				return list;
			}
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000B2090 File Offset: 0x000B0290
		[Command]
		public void ShowPinpadEdit()
		{
			if (this.SelectedPinpad == null)
			{
				return;
			}
			this._windowedDocumentService.ShowNewDocument("PinpadEditView", this, null, null);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x000B20BC File Offset: 0x000B02BC
		[Command]
		public void RefreshPinpads()
		{
			FinancesViewModel.<RefreshPinpads>d__100 <RefreshPinpads>d__;
			<RefreshPinpads>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshPinpads>d__.<>4__this = this;
			<RefreshPinpads>d__.<>1__state = -1;
			<RefreshPinpads>d__.<>t__builder.Start<FinancesViewModel.<RefreshPinpads>d__100>(ref <RefreshPinpads>d__);
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x000B20F4 File Offset: 0x000B02F4
		[Command]
		public void ShowCreatePinpad()
		{
			this.SelectedPinpad = new pinpad
			{
				office = OfflineData.Instance.Employee.OfficeId,
				fee = 0.0,
				fee_mode = false
			};
			this._windowedDocumentService.ShowNewDocument("PinpadEditView", this, null, null);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x000B214C File Offset: 0x000B034C
		[Command]
		public void SavePinpad()
		{
			FinancesViewModel.<SavePinpad>d__102 <SavePinpad>d__;
			<SavePinpad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SavePinpad>d__.<>4__this = this;
			<SavePinpad>d__.<>1__state = -1;
			<SavePinpad>d__.<>t__builder.Start<FinancesViewModel.<SavePinpad>d__102>(ref <SavePinpad>d__);
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x000B2184 File Offset: 0x000B0384
		[Command]
		public void ShowCreatePaymentType()
		{
			this._windowedDocumentService.ShowNewDocument("PaymentTypeEditView", new PaymentTypeEditViewModel(), null, null);
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000B21A8 File Offset: 0x000B03A8
		[Command]
		public void ShowEditPaymentType()
		{
			this._windowedDocumentService.ShowNewDocument("PaymentTypeEditView", new PaymentTypeEditViewModel(this.SelectedPaymentType), null, null);
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x000B21D4 File Offset: 0x000B03D4
		public bool CanShowEditPaymentType()
		{
			return this.SelectedPaymentType != null;
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x000B21EC File Offset: 0x000B03EC
		[Command]
		public void RefreshPaymentTypes()
		{
			FinancesViewModel.<RefreshPaymentTypes>d__106 <RefreshPaymentTypes>d__;
			<RefreshPaymentTypes>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RefreshPaymentTypes>d__.<>4__this = this;
			<RefreshPaymentTypes>d__.<>1__state = -1;
			<RefreshPaymentTypes>d__.<>t__builder.Start<FinancesViewModel.<RefreshPaymentTypes>d__106>(ref <RefreshPaymentTypes>d__);
		}

		// Token: 0x04001E14 RID: 7700
		private readonly IToasterService _toasterService;

		// Token: 0x04001E15 RID: 7701
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001E16 RID: 7702
		private OrderOptions _orderOptions = new OrderOptions();

		// Token: 0x04001E17 RID: 7703
		[CompilerGenerated]
		private config <Config>k__BackingField = Auth.Config;

		// Token: 0x04001E18 RID: 7704
		[CompilerGenerated]
		private ObservableCollection<payment_systems> <PaymentSystems>k__BackingField;

		// Token: 0x04001E19 RID: 7705
		[CompilerGenerated]
		private ObservableCollection<payment_types> <PaymentTypes>k__BackingField;

		// Token: 0x04001E1A RID: 7706
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <ExchangeRateSource>k__BackingField;

		// Token: 0x04001E1B RID: 7707
		[CompilerGenerated]
		private List<KkmProtocolOptions> <KkmProtocolOptionses>k__BackingField;

		// Token: 0x04001E1C RID: 7708
		[CompilerGenerated]
		private List<kkt> <Kkt>k__BackingField;

		// Token: 0x04001E1D RID: 7709
		[CompilerGenerated]
		private List<pinpad> <Pinpads>k__BackingField;

		// Token: 0x04001E1E RID: 7710
		[CompilerGenerated]
		private kkt <SelectedKkt>k__BackingField;

		// Token: 0x04001E1F RID: 7711
		[CompilerGenerated]
		private pinpad <SelectedPinpad>k__BackingField;

		// Token: 0x04001E20 RID: 7712
		[CompilerGenerated]
		private payment_systems <SelectedPaymentSystem>k__BackingField;

		// Token: 0x04001E21 RID: 7713
		private Currency _selectedCurrency;

		// Token: 0x04001E22 RID: 7714
		[CompilerGenerated]
		private bool <ShowArchivePaymentSystems>k__BackingField;

		// Token: 0x04001E23 RID: 7715
		[CompilerGenerated]
		private payment_types <SelectedPaymentType>k__BackingField;

		// Token: 0x04001E24 RID: 7716
		[CompilerGenerated]
		private ICommand <SaveCommonCommand>k__BackingField;

		// Token: 0x04001E25 RID: 7717
		[CompilerGenerated]
		private ICommand <LoadedCommand>k__BackingField;

		// Token: 0x04001E26 RID: 7718
		[CompilerGenerated]
		private Dictionary<int, string> <TaxTypes>k__BackingField;

		// Token: 0x04001E27 RID: 7719
		[CompilerGenerated]
		private Dictionary<int, string> <PaymentItemSigns>k__BackingField;

		// Token: 0x02000587 RID: 1415
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgLoad>d__65 : IAsyncStateMachine
		{
			// Token: 0x0600348F RID: 13455 RVA: 0x000B2224 File Offset: 0x000B0424
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_D3;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_12E;
					case 3:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_186;
					default:
						awaiter = financesViewModel.LoadPaymentSystems().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<BgLoad>d__65>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = financesViewModel.LoadPaymentTypes().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<BgLoad>d__65>(ref awaiter, ref this);
						return;
					}
					IL_D3:
					awaiter.GetResult();
					awaiter = financesViewModel.LoadKkts().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<BgLoad>d__65>(ref awaiter, ref this);
						return;
					}
					IL_12E:
					awaiter.GetResult();
					awaiter = financesViewModel.LoadPinpads().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<BgLoad>d__65>(ref awaiter, ref this);
						return;
					}
					IL_186:
					awaiter.GetResult();
					financesViewModel.LoadPaymentItemSigns();
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

			// Token: 0x06003490 RID: 13456 RVA: 0x000B240C File Offset: 0x000B060C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E28 RID: 7720
			public int <>1__state;

			// Token: 0x04001E29 RID: 7721
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E2A RID: 7722
			public FinancesViewModel <>4__this;

			// Token: 0x04001E2B RID: 7723
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000588 RID: 1416
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPaymentTypes>d__66 : IAsyncStateMachine
		{
			// Token: 0x06003491 RID: 13457 RVA: 0x000B2428 File Offset: 0x000B0628
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<payment_types>> awaiter;
					if (num != 0)
					{
						awaiter = financesViewModel._orderOptions.LoadUserPaymentTypes().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<payment_types>>, FinancesViewModel.<LoadPaymentTypes>d__66>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<payment_types>>);
						this.<>1__state = -1;
					}
					List<payment_types> result = awaiter.GetResult();
					financesViewModel.PaymentTypes = new ObservableCollection<payment_types>(result);
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

			// Token: 0x06003492 RID: 13458 RVA: 0x000B24F0 File Offset: 0x000B06F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E2C RID: 7724
			public int <>1__state;

			// Token: 0x04001E2D RID: 7725
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001E2E RID: 7726
			public FinancesViewModel <>4__this;

			// Token: 0x04001E2F RID: 7727
			private TaskAwaiter<List<payment_types>> <>u__1;
		}

		// Token: 0x02000589 RID: 1417
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPaymentSystems>d__67 : IAsyncStateMachine
		{
			// Token: 0x06003493 RID: 13459 RVA: 0x000B250C File Offset: 0x000B070C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<payment_systems>> awaiter;
					if (num != 0)
					{
						awaiter = KassaModel.LoadPaymentSystems(financesViewModel.ShowArchivePaymentSystems).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<payment_systems>>, FinancesViewModel.<LoadPaymentSystems>d__67>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<payment_systems>>);
						this.<>1__state = -1;
					}
					IEnumerable<payment_systems> result = awaiter.GetResult();
					financesViewModel.PaymentSystems = new ObservableCollection<payment_systems>(result);
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

			// Token: 0x06003494 RID: 13460 RVA: 0x000B25D4 File Offset: 0x000B07D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E30 RID: 7728
			public int <>1__state;

			// Token: 0x04001E31 RID: 7729
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001E32 RID: 7730
			public FinancesViewModel <>4__this;

			// Token: 0x04001E33 RID: 7731
			private TaskAwaiter<IEnumerable<payment_systems>> <>u__1;
		}

		// Token: 0x0200058A RID: 1418
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadKkts>d__68 : IAsyncStateMachine
		{
			// Token: 0x06003495 RID: 13461 RVA: 0x000B25F0 File Offset: 0x000B07F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<kkt>> awaiter;
					if (num != 0)
					{
						awaiter = KassaModel.GetAllKkt().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<kkt>>, FinancesViewModel.<LoadKkts>d__68>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<kkt>>);
						this.<>1__state = -1;
					}
					IEnumerable<kkt> result = awaiter.GetResult();
					financesViewModel.Kkt = new List<kkt>(result);
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

			// Token: 0x06003496 RID: 13462 RVA: 0x000B26B0 File Offset: 0x000B08B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E34 RID: 7732
			public int <>1__state;

			// Token: 0x04001E35 RID: 7733
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001E36 RID: 7734
			public FinancesViewModel <>4__this;

			// Token: 0x04001E37 RID: 7735
			private TaskAwaiter<IEnumerable<kkt>> <>u__1;
		}

		// Token: 0x0200058B RID: 1419
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPinpads>d__69 : IAsyncStateMachine
		{
			// Token: 0x06003497 RID: 13463 RVA: 0x000B26CC File Offset: 0x000B08CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<pinpad>> awaiter;
					if (num != 0)
					{
						awaiter = KassaModel.GetAllPinpads().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<pinpad>>, FinancesViewModel.<LoadPinpads>d__69>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<pinpad>>);
						this.<>1__state = -1;
					}
					IEnumerable<pinpad> result = awaiter.GetResult();
					financesViewModel.Pinpads = new List<pinpad>(result);
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

			// Token: 0x06003498 RID: 13464 RVA: 0x000B278C File Offset: 0x000B098C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E38 RID: 7736
			public int <>1__state;

			// Token: 0x04001E39 RID: 7737
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001E3A RID: 7738
			public FinancesViewModel <>4__this;

			// Token: 0x04001E3B RID: 7739
			private TaskAwaiter<IEnumerable<pinpad>> <>u__1;
		}

		// Token: 0x0200058C RID: 1420
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshKkt>d__74 : IAsyncStateMachine
		{
			// Token: 0x06003499 RID: 13465 RVA: 0x000B27A8 File Offset: 0x000B09A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = financesViewModel.LoadKkts().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<RefreshKkt>d__74>(ref awaiter, ref this);
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

			// Token: 0x0600349A RID: 13466 RVA: 0x000B285C File Offset: 0x000B0A5C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E3C RID: 7740
			public int <>1__state;

			// Token: 0x04001E3D RID: 7741
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E3E RID: 7742
			public FinancesViewModel <>4__this;

			// Token: 0x04001E3F RID: 7743
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200058D RID: 1421
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveKkt>d__86 : IAsyncStateMachine
		{
			// Token: 0x0600349B RID: 13467 RVA: 0x000B2878 File Offset: 0x000B0A78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						goto IL_109;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_186;
					default:
						if (financesViewModel.SelectedKkt == null)
						{
							goto IL_1BF;
						}
						if (!financesViewModel.CheckKktFields())
						{
							goto IL_1BF;
						}
						if (financesViewModel.SelectedKkt.id != 0)
						{
							awaiter = KassaModel.UpdateKkt(financesViewModel.SelectedKkt).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, FinancesViewModel.<SaveKkt>d__86>(ref awaiter, ref this);
								return;
							}
							goto IL_109;
						}
						else
						{
							awaiter = KassaModel.CreateKkt(financesViewModel.SelectedKkt).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, FinancesViewModel.<SaveKkt>d__86>(ref awaiter, ref this);
								return;
							}
						}
						break;
					}
					bool result = awaiter.GetResult();
					goto IL_111;
					IL_109:
					result = awaiter.GetResult();
					IL_111:
					this.<result>5__2 = result;
					if (!this.<result>5__2)
					{
						goto IL_193;
					}
					financesViewModel._windowedDocumentService.CloseActiveDocument();
					financesViewModel.SelectedKkt = null;
					awaiter2 = financesViewModel.LoadKkts().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<SaveKkt>d__86>(ref awaiter2, ref this);
						return;
					}
					IL_186:
					awaiter2.GetResult();
					financesViewModel.ReloadUser();
					IL_193:
					financesViewModel.ShowActionResponse(this.<result>5__2, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1BF:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600349C RID: 13468 RVA: 0x000B2A74 File Offset: 0x000B0C74
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E40 RID: 7744
			public int <>1__state;

			// Token: 0x04001E41 RID: 7745
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E42 RID: 7746
			public FinancesViewModel <>4__this;

			// Token: 0x04001E43 RID: 7747
			private bool <result>5__2;

			// Token: 0x04001E44 RID: 7748
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04001E45 RID: 7749
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200058E RID: 1422
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600349D RID: 13469 RVA: 0x000B2A90 File Offset: 0x000B0C90
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600349E RID: 13470 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600349F RID: 13471 RVA: 0x000B2AA8 File Offset: 0x000B0CA8
			internal void <ReloadUser>b__87_0()
			{
				UsersModel.ReloadCurrentUser();
			}

			// Token: 0x04001E46 RID: 7750
			public static readonly FinancesViewModel.<>c <>9 = new FinancesViewModel.<>c();

			// Token: 0x04001E47 RID: 7751
			public static Action <>9__87_0;
		}

		// Token: 0x0200058F RID: 1423
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeleteKkt>d__88 : IAsyncStateMachine
		{
			// Token: 0x060034A0 RID: 13472 RVA: 0x000B2ABC File Offset: 0x000B0CBC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<bool> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_D9;
						}
						if (financesViewModel.SelectedKkt == null)
						{
							goto IL_12F;
						}
						awaiter2 = KassaModel.DeleteKkt(financesViewModel.SelectedKkt).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, FinancesViewModel.<DeleteKkt>d__88>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter2.GetResult();
					this.<result>5__2 = result;
					if (!this.<result>5__2)
					{
						goto IL_103;
					}
					financesViewModel._windowedDocumentService.CloseActiveDocument();
					financesViewModel.SelectedKkt = null;
					awaiter = financesViewModel.LoadKkts().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<DeleteKkt>d__88>(ref awaiter, ref this);
						return;
					}
					IL_D9:
					awaiter.GetResult();
					IL_103:
					financesViewModel.ShowActionResponse(this.<result>5__2, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_12F:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060034A1 RID: 13473 RVA: 0x000B2C28 File Offset: 0x000B0E28
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E48 RID: 7752
			public int <>1__state;

			// Token: 0x04001E49 RID: 7753
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E4A RID: 7754
			public FinancesViewModel <>4__this;

			// Token: 0x04001E4B RID: 7755
			private bool <result>5__2;

			// Token: 0x04001E4C RID: 7756
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04001E4D RID: 7757
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000590 RID: 1424
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshPs>d__92 : IAsyncStateMachine
		{
			// Token: 0x060034A2 RID: 13474 RVA: 0x000B2C44 File Offset: 0x000B0E44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = financesViewModel.LoadPaymentSystems().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<RefreshPs>d__92>(ref awaiter, ref this);
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

			// Token: 0x060034A3 RID: 13475 RVA: 0x000B2CF8 File Offset: 0x000B0EF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E4E RID: 7758
			public int <>1__state;

			// Token: 0x04001E4F RID: 7759
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E50 RID: 7760
			public FinancesViewModel <>4__this;

			// Token: 0x04001E51 RID: 7761
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000591 RID: 1425
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SavePaymentSystem>d__94 : IAsyncStateMachine
		{
			// Token: 0x060034A4 RID: 13476 RVA: 0x000B2D14 File Offset: 0x000B0F14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						goto IL_FD;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_17A;
					default:
						if (!financesViewModel.CheckPaymentSystem())
						{
							goto IL_1B7;
						}
						this.<result>5__2 = false;
						if (financesViewModel.SelectedPaymentSystem.id == 0)
						{
							awaiter = KassaModel.CreatePaymentSystem(financesViewModel.SelectedPaymentSystem).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, FinancesViewModel.<SavePaymentSystem>d__94>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = KassaModel.UpdatePaymentSystem(financesViewModel.SelectedPaymentSystem).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, FinancesViewModel.<SavePaymentSystem>d__94>(ref awaiter, ref this);
								return;
							}
							goto IL_FD;
						}
						break;
					}
					bool result = awaiter.GetResult();
					goto IL_105;
					IL_FD:
					result = awaiter.GetResult();
					IL_105:
					this.<result>5__2 = result;
					if (!this.<result>5__2)
					{
						goto IL_18B;
					}
					financesViewModel._windowedDocumentService.CloseActiveDocument();
					financesViewModel.SelectedPaymentSystem = null;
					awaiter2 = financesViewModel.LoadPaymentSystems().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<SavePaymentSystem>d__94>(ref awaiter2, ref this);
						return;
					}
					IL_17A:
					awaiter2.GetResult();
					OfflineData.Instance.ReloadPaymentSystems();
					IL_18B:
					financesViewModel.ShowActionResponse(this.<result>5__2, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1B7:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060034A5 RID: 13477 RVA: 0x000B2F08 File Offset: 0x000B1108
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E52 RID: 7762
			public int <>1__state;

			// Token: 0x04001E53 RID: 7763
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E54 RID: 7764
			public FinancesViewModel <>4__this;

			// Token: 0x04001E55 RID: 7765
			private bool <result>5__2;

			// Token: 0x04001E56 RID: 7766
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04001E57 RID: 7767
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000592 RID: 1426
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshPinpads>d__100 : IAsyncStateMachine
		{
			// Token: 0x060034A6 RID: 13478 RVA: 0x000B2F24 File Offset: 0x000B1124
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = financesViewModel.LoadPinpads().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<RefreshPinpads>d__100>(ref awaiter, ref this);
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

			// Token: 0x060034A7 RID: 13479 RVA: 0x000B2FD8 File Offset: 0x000B11D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E58 RID: 7768
			public int <>1__state;

			// Token: 0x04001E59 RID: 7769
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E5A RID: 7770
			public FinancesViewModel <>4__this;

			// Token: 0x04001E5B RID: 7771
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000593 RID: 1427
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SavePinpad>d__102 : IAsyncStateMachine
		{
			// Token: 0x060034A8 RID: 13480 RVA: 0x000B2FF4 File Offset: 0x000B11F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						goto IL_123;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1A0;
					default:
						if (string.IsNullOrEmpty(financesViewModel.SelectedPinpad.name))
						{
							financesViewModel._toasterService.Info(Lang.t("InputName"));
							goto IL_1D9;
						}
						this.<result>5__2 = false;
						if (financesViewModel.SelectedPinpad.id == 0)
						{
							awaiter = KassaModel.CreatePinpad(financesViewModel.SelectedPinpad).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, FinancesViewModel.<SavePinpad>d__102>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = KassaModel.UpdatePinpad(financesViewModel.SelectedPinpad).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 1;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, FinancesViewModel.<SavePinpad>d__102>(ref awaiter, ref this);
								return;
							}
							goto IL_123;
						}
						break;
					}
					bool result = awaiter.GetResult();
					this.<result>5__2 = result;
					goto IL_132;
					IL_123:
					result = awaiter.GetResult();
					this.<result>5__2 = result;
					IL_132:
					if (!this.<result>5__2)
					{
						goto IL_1AD;
					}
					financesViewModel._windowedDocumentService.CloseActiveDocument();
					financesViewModel.SelectedPinpad = null;
					awaiter2 = financesViewModel.LoadPinpads().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<SavePinpad>d__102>(ref awaiter2, ref this);
						return;
					}
					IL_1A0:
					awaiter2.GetResult();
					financesViewModel.ReloadUser();
					IL_1AD:
					financesViewModel.ShowActionResponse(this.<result>5__2, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1D9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060034A9 RID: 13481 RVA: 0x000B320C File Offset: 0x000B140C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E5C RID: 7772
			public int <>1__state;

			// Token: 0x04001E5D RID: 7773
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E5E RID: 7774
			public FinancesViewModel <>4__this;

			// Token: 0x04001E5F RID: 7775
			private bool <result>5__2;

			// Token: 0x04001E60 RID: 7776
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04001E61 RID: 7777
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000594 RID: 1428
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RefreshPaymentTypes>d__106 : IAsyncStateMachine
		{
			// Token: 0x060034AA RID: 13482 RVA: 0x000B3228 File Offset: 0x000B1428
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				FinancesViewModel financesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = financesViewModel.LoadPaymentTypes().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FinancesViewModel.<RefreshPaymentTypes>d__106>(ref awaiter, ref this);
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

			// Token: 0x060034AB RID: 13483 RVA: 0x000B32DC File Offset: 0x000B14DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E62 RID: 7778
			public int <>1__state;

			// Token: 0x04001E63 RID: 7779
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E64 RID: 7780
			public FinancesViewModel <>4__this;

			// Token: 0x04001E65 RID: 7781
			private TaskAwaiter <>u__1;
		}
	}
}
