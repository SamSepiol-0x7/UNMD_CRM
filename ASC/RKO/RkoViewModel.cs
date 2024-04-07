using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Documents;
using ASC.Interfaces;
using ASC.ItemsArrival;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.Properties;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.RKO
{
	// Token: 0x02000135 RID: 309
	public class RkoViewModel : BaseViewModel, IBaseViewModel, IKoViewModel, IDocumentSelect, ICustomerSelect
	{
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x00033074 File Offset: 0x00031274
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x00033088 File Offset: 0x00031288
		public List<IPaymentType> RkoOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<RkoOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RkoOptionses>k__BackingField, value))
				{
					return;
				}
				this.<RkoOptionses>k__BackingField = value;
				this.RaisePropertyChanged("RkoOptionses");
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x000330B8 File Offset: 0x000312B8
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x000330CC File Offset: 0x000312CC
		public ICustomer Agent
		{
			[CompilerGenerated]
			get
			{
				return this.<Agent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Agent>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1409174149;
				IL_13:
				switch ((num ^ -57589912) % 4)
				{
				case 0:
					IL_32:
					num = -1410008439;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.<Agent>k__BackingField = value;
				this.RaisePropertyChanged("Agent");
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00033128 File Offset: 0x00031328
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x00033140 File Offset: 0x00031340
		public cash_orders Order
		{
			get
			{
				return this._kassaModel.Order;
			}
			set
			{
				if (object.Equals(this.Order, value))
				{
					return;
				}
				this._kassaModel.Order = value;
				this.RaisePropertyChanged("IsEditable");
				this.RaisePropertyChanged("IsEditableInvert");
				this.RaisePropertyChanged("Order");
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0003318C File Offset: 0x0003138C
		public bool IsEditable
		{
			get
			{
				return this.Order != null && this.Order.id == 0;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x000331B4 File Offset: 0x000313B4
		public bool IsEditableInvert
		{
			get
			{
				return this.Order != null && this.Order.id != 0 && this.Order.type != 3;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000331EC File Offset: 0x000313EC
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x00033200 File Offset: 0x00031400
		public IPaymentType SelectedPaymentType
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

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00033230 File Offset: 0x00031430
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00033244 File Offset: 0x00031444
		public string DocumentTypeName
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentTypeName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DocumentTypeName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DocumentTypeName>k__BackingField = value;
				this.RaisePropertyChanged("DocumentTypeName");
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00033274 File Offset: 0x00031474
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00033288 File Offset: 0x00031488
		public bool ReasonAutocomplete
		{
			[CompilerGenerated]
			get
			{
				return this.<ReasonAutocomplete>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReasonAutocomplete>k__BackingField == value)
				{
					return;
				}
				this.<ReasonAutocomplete>k__BackingField = value;
				this.RaisePropertyChanged("ReasonAutocomplete");
			}
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000332B4 File Offset: 0x000314B4
		private void IoC()
		{
			this._kassaModel = Bootstrapper.Container.Resolve<KassaModel>();
			this._kassaService = Bootstrapper.Container.Resolve<IKassaService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00033314 File Offset: 0x00031514
		public RkoViewModel()
		{
			this.IoC();
			this.SetViewName("RKO");
			this.LoadRkoOptions(false);
			this._kassaModel.NewCashOrder();
			this.SelectLastCompany();
			this.SetCanSelectPaymentType(true);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00033360 File Offset: 0x00031560
		public RkoViewModel(int orderId)
		{
			this.cashOrderId = orderId;
			this.IoC();
			this.SetViewName("RKO", orderId);
			this.LoadRkoOptions(true);
			this.SetCanSelectPaymentType(false);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000333A4 File Offset: 0x000315A4
		public void LoadRkoOptions(bool full)
		{
			OrderOptions orderOptions = new OrderOptions();
			for (;;)
			{
				IL_3F:
				int num = -259350313;
				for (;;)
				{
					switch ((num ^ -1211870505) % 3)
					{
					case 0:
						goto IL_3F;
					case 1:
						this.RkoOptionses = (full ? orderOptions.GetRkoFull() : orderOptions.GetRKO());
						num = -1238068824;
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000333F8 File Offset: 0x000315F8
		private Task LoadOrder(int orderId)
		{
			RkoViewModel.<LoadOrder>d__38 <LoadOrder>d__;
			<LoadOrder>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadOrder>d__.<>4__this = this;
			<LoadOrder>d__.orderId = orderId;
			<LoadOrder>d__.<>1__state = -1;
			<LoadOrder>d__.<>t__builder.Start<RkoViewModel.<LoadOrder>d__38>(ref <LoadOrder>d__);
			return <LoadOrder>d__.<>t__builder.Task;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00033444 File Offset: 0x00031644
		private Task LoadAgent(int id)
		{
			RkoViewModel.<LoadAgent>d__39 <LoadAgent>d__;
			<LoadAgent>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadAgent>d__.<>4__this = this;
			<LoadAgent>d__.id = id;
			<LoadAgent>d__.<>1__state = -1;
			<LoadAgent>d__.<>t__builder.Start<RkoViewModel.<LoadAgent>d__39>(ref <LoadAgent>d__);
			return <LoadAgent>d__.<>t__builder.Task;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00033490 File Offset: 0x00031690
		private void SetRunning()
		{
			this._running = true;
			base.RaiseCanExecuteChanged(() => this.SaveOrder());
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000334E0 File Offset: 0x000316E0
		private void SetNotRunning()
		{
			this._running = false;
			base.RaiseCanExecuteChanged(() => this.SaveOrder());
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00033530 File Offset: 0x00031730
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x00033544 File Offset: 0x00031744
		public bool AgentBalanceVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<AgentBalanceVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AgentBalanceVisible>k__BackingField == value)
				{
					return;
				}
				this.<AgentBalanceVisible>k__BackingField = value;
				this.RaisePropertyChanged("AgentBalanceVisible");
			}
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00033570 File Offset: 0x00031770
		[Command]
		public void TypeChanged()
		{
			RkoViewModel.<TypeChanged>d__46 <TypeChanged>d__;
			<TypeChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<TypeChanged>d__.<>4__this = this;
			<TypeChanged>d__.<>1__state = -1;
			<TypeChanged>d__.<>t__builder.Start<RkoViewModel.<TypeChanged>d__46>(ref <TypeChanged>d__);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0003318C File Offset: 0x0003138C
		public bool CanTypeChanged()
		{
			return this.Order != null && this.Order.id == 0;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000335A8 File Offset: 0x000317A8
		[Command]
		public void OpenDocument()
		{
			if (this._kassaModel.Order.document != null)
			{
				int? document = this._kassaModel.Order.document;
				if (!(document.GetValueOrDefault() == 0 & document != null))
				{
					if (this.Order.type == 9)
					{
						this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this._kassaModel.Order.document.Value));
						return;
					}
					this._navigationService.Navigate("InItems", new ItemsArrivalViewModel(this._kassaModel.Order.document.Value));
				}
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00033664 File Offset: 0x00031864
		public bool CanOpenDocument()
		{
			cash_orders order = this.Order;
			if (order != null && order.id > 0)
			{
				int? document = this.Order.document;
				return document.GetValueOrDefault() > 0 & document != null;
			}
			return false;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000336A8 File Offset: 0x000318A8
		private void SelectLastCompany()
		{
			if (Settings.Default.LastCompany <= 0)
			{
				return;
			}
			this._kassaModel.SetOrderCompany(Settings.Default.LastCompany);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000336D8 File Offset: 0x000318D8
		[Command]
		public void PrintOrder()
		{
			RkoViewModel.<PrintOrder>d__51 <PrintOrder>d__;
			<PrintOrder>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintOrder>d__.<>4__this = this;
			<PrintOrder>d__.<>1__state = -1;
			<PrintOrder>d__.<>t__builder.Start<RkoViewModel.<PrintOrder>d__51>(ref <PrintOrder>d__);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00033710 File Offset: 0x00031910
		[Command]
		public void SelectAgent()
		{
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectClient"), this);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00033738 File Offset: 0x00031938
		public bool CanSelectAgent()
		{
			if (this.Order == null)
			{
				return false;
			}
			if (this._kassaModel.Order.id == 0 && this._kassaModel.Order.type != 2)
			{
				if (this._kassaModel.Order.type > 50)
				{
					IPaymentType selectedPaymentType = this.SelectedPaymentType;
					if (selectedPaymentType != null && selectedPaymentType.ClientId != null)
					{
						this.SelectAgentVisible = false;
						return false;
					}
				}
				this.SelectAgentVisible = true;
				return true;
			}
			this.SelectAgentVisible = false;
			return false;
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x000337C0 File Offset: 0x000319C0
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x000337D4 File Offset: 0x000319D4
		public bool NavigateAgentVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateAgentVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NavigateAgentVisible>k__BackingField == value)
				{
					return;
				}
				this.<NavigateAgentVisible>k__BackingField = value;
				this.RaisePropertyChanged("NavigateAgentVisible");
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x00033800 File Offset: 0x00031A00
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x00033814 File Offset: 0x00031A14
		public bool SelectAgentVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectAgentVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectAgentVisible>k__BackingField == value)
				{
					return;
				}
				this.<SelectAgentVisible>k__BackingField = value;
				this.RaisePropertyChanged("SelectAgentVisible");
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00033840 File Offset: 0x00031A40
		[Command]
		public void NavigateAgent()
		{
			this._navigationService.NavigateToCustomerCard(this.Order.client.Value, null);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0003386C File Offset: 0x00031A6C
		public bool CanNavigateAgent()
		{
			this.NavigateAgentVisible = (this.Order != null && this.Order.id > 0 && this.Order.client != null);
			return this.NavigateAgentVisible;
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000338B4 File Offset: 0x00031AB4
		public void SelectCustomerFromList(ICustomer customer)
		{
			if (this._kassaModel.Order.type == 4 && !customer.BalanceEnabled)
			{
				this._toasterService.Error(Lang.t("WrongClientBalanceOff"));
				return;
			}
			this.SetCustomer(customer);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000338FC File Offset: 0x00031AFC
		public void SetCustomer(ICustomer customer)
		{
			this.Agent = new CustomerCard(customer);
			this._kassaModel.SetOrderClient(customer.Id);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00033928 File Offset: 0x00031B28
		public void SetType(Kassa.Types t)
		{
			this.Order.type = (int)t;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00033944 File Offset: 0x00031B44
		public void SetCompany(int companyId)
		{
			this.Order.company = companyId;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00033960 File Offset: 0x00031B60
		[Command]
		public void SelectDocument()
		{
			this._navigationService.Navigate("DocumentsView", new DocumentsViewModel(1), this);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00033984 File Offset: 0x00031B84
		public bool CanSelectDocument()
		{
			cash_orders order = this.Order;
			return order != null && order.id == 0;
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000339A8 File Offset: 0x00031BA8
		public void SelectDoc(DocsList document)
		{
			if (document == null)
			{
				return;
			}
			if (!this.AlreadyPayed(document))
			{
				if (document.Customer != null)
				{
					this.Agent = new CustomerCard(document.Customer);
				}
				this._kassaModel.FillOrderFromDoc(document);
				this.DocumentTypeName = document.Type;
				this._kassaModel.Autocomplete(true);
				return;
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00033A00 File Offset: 0x00031C00
		private bool AlreadyPayed(DocsList document)
		{
			int? state = document.state;
			if (state.GetValueOrDefault() == 2 & state != null)
			{
				this._toasterService.Error(Lang.t("DocumentAlreadyPayed"));
				return true;
			}
			return false;
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00033A40 File Offset: 0x00031C40
		[Command]
		public void SaveOrder()
		{
			if (!this.CheckFields())
			{
				return;
			}
			this.SetRunning();
			this._kassaModel.MakeRko();
			this.SetNotRunning();
			base.RaiseCanExecuteChanged(() => this.NavigateAgent());
			this._navigationService.SetTabHeader("RKO", this.Order.id);
			if (Auth.Config.qs_print_rko && this.Order.type != 3)
			{
				this.PrintOrder();
			}
			if (this.Order.type == 20)
			{
				if (this.PrintKktCheque)
				{
					IAscResult ascResult = OfflineData.Instance.Employee.Kkt.PkoCheckReturn(this.Order.ToCashOutOrder());
					if (ascResult.IsSucces)
					{
						this._toasterService.Success(Lang.t("Complete"));
						return;
					}
					this._toasterService.Error(ascResult.Message);
				}
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00033B4C File Offset: 0x00031D4C
		public bool CanSaveOrder()
		{
			return OfflineData.Instance.Employee.Can(16, 0) && !this._running;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00033B78 File Offset: 0x00031D78
		private bool CheckFields()
		{
			if (this._kassaModel.Order.type == 0)
			{
				this._toasterService.Info(Lang.t("SelectRkoType"));
				return false;
			}
			if (this._kassaModel.Order.summa == 0m)
			{
				this._toasterService.Info(Lang.t("InputSumm"));
				return false;
			}
			if (this._kassaModel.Order.company == 0)
			{
				this._toasterService.Info(Lang.t("InputCompany"));
				return false;
			}
			if (string.IsNullOrEmpty(this._kassaModel.Order.notes))
			{
				this._toasterService.Info(Lang.t("InputReason"));
				return false;
			}
			if (this._kassaModel.Order.type == 2)
			{
				int? num = this._kassaModel.Order.document;
				if ((num.GetValueOrDefault() == 0 & num != null) || this._kassaModel.Order.document == null)
				{
					this._toasterService.Info(Lang.t("RkoSelectDocument"));
					return false;
				}
			}
			if (this._kassaModel.Order.type != 3)
			{
				int? num = this._kassaModel.Order.client;
				if ((num.GetValueOrDefault() == 0 & num != null) || this._kassaModel.Order.client == null)
				{
					this._toasterService.Info(Lang.t("SelectRkoRecepient"));
					return false;
				}
			}
			return true;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00033D10 File Offset: 0x00031F10
		public void ChangeCompany()
		{
			Settings.Default.LastCompany = this._kassaModel.Order.company;
			Settings.Default.Save();
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00033D44 File Offset: 0x00031F44
		public void Autocomplete()
		{
			if (this.SelectedPaymentType != null)
			{
				this._kassaModel.Autocomplete(this.ReasonAutocomplete, this.SelectedPaymentType);
				return;
			}
			this._kassaModel.Autocomplete(this.ReasonAutocomplete);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00033D84 File Offset: 0x00031F84
		[Command]
		public void SummChanged()
		{
			if (this._running)
			{
				return;
			}
			this.Autocomplete();
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00033DA0 File Offset: 0x00031FA0
		public bool CanSummChanged()
		{
			return this.CanTypeChanged();
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00033DB4 File Offset: 0x00031FB4
		[Command]
		public void CompanyChanged()
		{
			this.ChangeCompany();
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00033DC8 File Offset: 0x00031FC8
		public bool CanCompanyChanged()
		{
			return this.Order != null;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00033DE0 File Offset: 0x00031FE0
		[Command]
		public void UpdatePaymentSystem()
		{
			RkoViewModel.<UpdatePaymentSystem>d__81 <UpdatePaymentSystem>d__;
			<UpdatePaymentSystem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdatePaymentSystem>d__.<>4__this = this;
			<UpdatePaymentSystem>d__.<>1__state = -1;
			<UpdatePaymentSystem>d__.<>t__builder.Start<RkoViewModel.<UpdatePaymentSystem>d__81>(ref <UpdatePaymentSystem>d__);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00033E18 File Offset: 0x00032018
		public bool CanUpdatePaymentSystem()
		{
			return this.Order != null && this.Order.id > 0 && OfflineData.Instance.Employee.Can(16, 0);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00033E50 File Offset: 0x00032050
		public void SetSumm(decimal value)
		{
			this.Order.summa = value;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00033E6C File Offset: 0x0003206C
		public void SetPaymentSystem(PaymentOptions.Systems system)
		{
			this.Order.payment_system = (int)system;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00033E88 File Offset: 0x00032088
		public void SetPrintKktCheque(bool value)
		{
			if (OfflineData.Instance.Employee.KktReady())
			{
				this.PrintKktChequeVisible = true;
				this.PrintKktCheque = value;
				return;
			}
			this.PrintKktCheque = false;
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00033EBC File Offset: 0x000320BC
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x00033ED0 File Offset: 0x000320D0
		public bool PrintKktChequeVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintKktChequeVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintKktChequeVisible>k__BackingField == value)
				{
					return;
				}
				this.<PrintKktChequeVisible>k__BackingField = value;
				this.RaisePropertyChanged("PrintKktChequeVisible");
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00033EFC File Offset: 0x000320FC
		// (set) Token: 0x060015CC RID: 5580 RVA: 0x00033F10 File Offset: 0x00032110
		public bool PrintKktCheque
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintKktCheque>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintKktCheque>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1035560834;
				IL_10:
				switch ((num ^ 580776967) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					this.<PrintKktCheque>k__BackingField = value;
					this.RaisePropertyChanged("PrintKktCheque");
					num = 1618882348;
					goto IL_10;
				}
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00033F68 File Offset: 0x00032168
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x00033F7C File Offset: 0x0003217C
		public bool CanSelectPaymentType
		{
			[CompilerGenerated]
			get
			{
				return this.<CanSelectPaymentType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CanSelectPaymentType>k__BackingField == value)
				{
					return;
				}
				this.<CanSelectPaymentType>k__BackingField = value;
				this.RaisePropertyChanged("CanSelectPaymentType");
			}
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00033FA8 File Offset: 0x000321A8
		public void SetCanSelectPaymentType(bool value)
		{
			this.CanSelectPaymentType = value;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00033FBC File Offset: 0x000321BC
		public override void OnLoad()
		{
			RkoViewModel.<OnLoad>d__99 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<RkoViewModel.<OnLoad>d__99>(ref <OnLoad>d__);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00033928 File Offset: 0x00031B28
		public void SetOrderType(Kassa.Types type)
		{
			this.Order.type = (int)type;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00033FF4 File Offset: 0x000321F4
		[CompilerGenerated]
		private IAscResult <UpdatePaymentSystem>b__81_0()
		{
			return KassaModel.UpdateOrderPaymentSystem(this.Order.id, this.Order.payment_system);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04000A7F RID: 2687
		private KassaModel _kassaModel;

		// Token: 0x04000A80 RID: 2688
		private bool _running;

		// Token: 0x04000A81 RID: 2689
		private IKassaService _kassaService;

		// Token: 0x04000A82 RID: 2690
		private INavigationService _navigationService;

		// Token: 0x04000A83 RID: 2691
		[CompilerGenerated]
		private List<IPaymentType> <RkoOptionses>k__BackingField;

		// Token: 0x04000A84 RID: 2692
		[CompilerGenerated]
		private ICustomer <Agent>k__BackingField;

		// Token: 0x04000A85 RID: 2693
		[CompilerGenerated]
		private IPaymentType <SelectedPaymentType>k__BackingField;

		// Token: 0x04000A86 RID: 2694
		[CompilerGenerated]
		private string <DocumentTypeName>k__BackingField;

		// Token: 0x04000A87 RID: 2695
		[CompilerGenerated]
		private bool <ReasonAutocomplete>k__BackingField = true;

		// Token: 0x04000A88 RID: 2696
		private int cashOrderId;

		// Token: 0x04000A89 RID: 2697
		private IToasterService _toasterService;

		// Token: 0x04000A8A RID: 2698
		private IReportPrintService _reportPrintService;

		// Token: 0x04000A8B RID: 2699
		[CompilerGenerated]
		private bool <AgentBalanceVisible>k__BackingField;

		// Token: 0x04000A8C RID: 2700
		[CompilerGenerated]
		private bool <NavigateAgentVisible>k__BackingField;

		// Token: 0x04000A8D RID: 2701
		[CompilerGenerated]
		private bool <SelectAgentVisible>k__BackingField;

		// Token: 0x04000A8E RID: 2702
		[CompilerGenerated]
		private bool <PrintKktChequeVisible>k__BackingField;

		// Token: 0x04000A8F RID: 2703
		[CompilerGenerated]
		private bool <PrintKktCheque>k__BackingField;

		// Token: 0x04000A90 RID: 2704
		[CompilerGenerated]
		private bool <CanSelectPaymentType>k__BackingField;

		// Token: 0x02000136 RID: 310
		[CompilerGenerated]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x060015D4 RID: 5588 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x060015D5 RID: 5589 RVA: 0x00034030 File Offset: 0x00032230
			internal Task<cash_orders> <LoadOrder>b__0()
			{
				return this.<>4__this._kassaService.GetCashOrderAsync(this.orderId);
			}

			// Token: 0x060015D6 RID: 5590 RVA: 0x00034054 File Offset: 0x00032254
			internal Employee <LoadOrder>b__1()
			{
				return UsersModel.GetEmployeeForReport(this.<>4__this.Order.to_user.Value);
			}

			// Token: 0x04000A91 RID: 2705
			public RkoViewModel <>4__this;

			// Token: 0x04000A92 RID: 2706
			public int orderId;
		}

		// Token: 0x02000137 RID: 311
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadOrder>d__38 : IAsyncStateMachine
		{
			// Token: 0x060015D7 RID: 5591 RVA: 0x00034080 File Offset: 0x00032280
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RkoViewModel rkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<cash_orders> awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter<Employee> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<cash_orders>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_174;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<Employee>);
						this.<>1__state = -1;
						goto IL_1F5;
					default:
						this.<>8__1 = new RkoViewModel.<>c__DisplayClass38_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.orderId = this.orderId;
						rkoViewModel.ShowWait();
						awaiter = Task.Run<cash_orders>(new Func<Task<cash_orders>>(this.<>8__1.<LoadOrder>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cash_orders>, RkoViewModel.<LoadOrder>d__38>(ref awaiter, ref this);
							return;
						}
						break;
					}
					cash_orders result = awaiter.GetResult();
					rkoViewModel.Order = result;
					if (rkoViewModel._kassaModel.Order.docs != null)
					{
						rkoViewModel.DocumentTypeName = rkoViewModel._kassaModel.Order.docs.Type;
					}
					if (rkoViewModel.Order.client == null)
					{
						goto IL_17B;
					}
					awaiter2 = rkoViewModel.LoadAgent(rkoViewModel.Order.client.Value).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RkoViewModel.<LoadOrder>d__38>(ref awaiter2, ref this);
						return;
					}
					IL_174:
					awaiter2.GetResult();
					IL_17B:
					if (rkoViewModel.Order.to_user == null)
					{
						goto IL_20B;
					}
					awaiter3 = Task.Run<Employee>(new Func<Employee>(this.<>8__1.<LoadOrder>b__1)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Employee>, RkoViewModel.<LoadOrder>d__38>(ref awaiter3, ref this);
						return;
					}
					IL_1F5:
					Employee result2 = awaiter3.GetResult();
					rkoViewModel.Agent = new CustomerCard(result2);
					IL_20B:
					rkoViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060015D8 RID: 5592 RVA: 0x000342F8 File Offset: 0x000324F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A93 RID: 2707
			public int <>1__state;

			// Token: 0x04000A94 RID: 2708
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000A95 RID: 2709
			public RkoViewModel <>4__this;

			// Token: 0x04000A96 RID: 2710
			public int orderId;

			// Token: 0x04000A97 RID: 2711
			private RkoViewModel.<>c__DisplayClass38_0 <>8__1;

			// Token: 0x04000A98 RID: 2712
			private TaskAwaiter<cash_orders> <>u__1;

			// Token: 0x04000A99 RID: 2713
			private TaskAwaiter <>u__2;

			// Token: 0x04000A9A RID: 2714
			private TaskAwaiter<Employee> <>u__3;
		}

		// Token: 0x02000138 RID: 312
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadAgent>d__39 : IAsyncStateMachine
		{
			// Token: 0x060015D9 RID: 5593 RVA: 0x00034314 File Offset: 0x00032514
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RkoViewModel rkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<ICustomer> awaiter;
					if (num != 0)
					{
						awaiter = Bootstrapper.Container.Resolve<ICustomerService>().GetCustomerCardAsync(this.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICustomer>, RkoViewModel.<LoadAgent>d__39>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<ICustomer>);
						this.<>1__state = -1;
					}
					ICustomer result = awaiter.GetResult();
					rkoViewModel.Agent = result;
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

			// Token: 0x060015DA RID: 5594 RVA: 0x000343E0 File Offset: 0x000325E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A9B RID: 2715
			public int <>1__state;

			// Token: 0x04000A9C RID: 2716
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000A9D RID: 2717
			public int id;

			// Token: 0x04000A9E RID: 2718
			public RkoViewModel <>4__this;

			// Token: 0x04000A9F RID: 2719
			private TaskAwaiter<ICustomer> <>u__1;
		}

		// Token: 0x02000139 RID: 313
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <TypeChanged>d__46 : IAsyncStateMachine
		{
			// Token: 0x060015DB RID: 5595 RVA: 0x000343FC File Offset: 0x000325FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RkoViewModel rkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						rkoViewModel.Autocomplete();
						rkoViewModel.AgentBalanceVisible = (rkoViewModel.SelectedPaymentType != null && rkoViewModel.SelectedPaymentType.Id == 4);
						if (rkoViewModel.SelectedPaymentType == null)
						{
							goto IL_213;
						}
						if (rkoViewModel.SelectedPaymentType.Id == 3)
						{
							rkoViewModel.Order.payment_system = 0;
							rkoViewModel.Order.client = null;
						}
						if (!rkoViewModel.SelectedPaymentType.IsUserType)
						{
							goto IL_1BD;
						}
						if (rkoViewModel.SelectedPaymentType.ClientId == null)
						{
							goto IL_12D;
						}
						rkoViewModel._kassaModel.SetOrderClient(rkoViewModel.SelectedPaymentType.ClientId.Value);
						awaiter = rkoViewModel.LoadAgent(rkoViewModel.SelectedPaymentType.ClientId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RkoViewModel.<TypeChanged>d__46>(ref awaiter, ref this);
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
					IL_12D:
					if (rkoViewModel.SelectedPaymentType.DefaultSumm != null)
					{
						rkoViewModel.Order.summa = rkoViewModel.SelectedPaymentType.DefaultSumm.Value;
					}
					if (!string.IsNullOrEmpty(rkoViewModel.SelectedPaymentType.Reason))
					{
						rkoViewModel.Order.notes = rkoViewModel.SelectedPaymentType.Reason;
					}
					if (rkoViewModel.SelectedPaymentType.PaymentSystem != null)
					{
						rkoViewModel.Order.payment_system = rkoViewModel.SelectedPaymentType.PaymentSystem.Value;
					}
					IL_1BD:
					rkoViewModel.RaiseCanExecuteChanged(() => rkoViewModel.SelectAgent());
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_213:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060015DC RID: 5596 RVA: 0x0003464C File Offset: 0x0003284C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000AA0 RID: 2720
			public int <>1__state;

			// Token: 0x04000AA1 RID: 2721
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000AA2 RID: 2722
			public RkoViewModel <>4__this;

			// Token: 0x04000AA3 RID: 2723
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200013A RID: 314
		[CompilerGenerated]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x060015DD RID: 5597 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x060015DE RID: 5598 RVA: 0x00034668 File Offset: 0x00032868
			internal Task<CashOutOrder> <PrintOrder>b__2()
			{
				return KassaModel.GetCashOutOrder(this.<>4__this.Order.id);
			}

			// Token: 0x060015DF RID: 5599 RVA: 0x0003468C File Offset: 0x0003288C
			internal Task<XtraReport> <PrintOrder>b__0()
			{
				return this.order.CreateReport();
			}

			// Token: 0x060015E0 RID: 5600 RVA: 0x000346A4 File Offset: 0x000328A4
			internal void <PrintOrder>b__1(Task<XtraReport> t)
			{
				this.<>4__this.HideWait();
				this.<>4__this._reportPrintService.PrintPreview(t.Result, PrinterModel.Printer.Documents);
			}

			// Token: 0x04000AA4 RID: 2724
			public RkoViewModel <>4__this;

			// Token: 0x04000AA5 RID: 2725
			public CashOutOrder order;
		}

		// Token: 0x0200013B RID: 315
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintOrder>d__51 : IAsyncStateMachine
		{
			// Token: 0x060015E1 RID: 5601 RVA: 0x000346D4 File Offset: 0x000328D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RkoViewModel rkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<CashOutOrder> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_136;
						}
						this.<>8__1 = new RkoViewModel.<>c__DisplayClass51_0();
						this.<>8__1.<>4__this = this.<>4__this;
						rkoViewModel.ShowWait();
						awaiter2 = Task.Run<CashOutOrder>(new Func<Task<CashOutOrder>>(this.<>8__1.<PrintOrder>b__2)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CashOutOrder>, RkoViewModel.<PrintOrder>d__51>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CashOutOrder>);
						this.<>1__state = -1;
					}
					CashOutOrder result = awaiter2.GetResult();
					this.<>8__1.order = result;
					awaiter = Task.Run<XtraReport>(new Func<Task<XtraReport>>(this.<>8__1.<PrintOrder>b__0)).ContinueWith(new Action<Task<XtraReport>>(this.<>8__1.<PrintOrder>b__1), TaskScheduler.FromCurrentSynchronizationContext()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RkoViewModel.<PrintOrder>d__51>(ref awaiter, ref this);
						return;
					}
					IL_136:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060015E2 RID: 5602 RVA: 0x00034878 File Offset: 0x00032A78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000AA6 RID: 2726
			public int <>1__state;

			// Token: 0x04000AA7 RID: 2727
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000AA8 RID: 2728
			public RkoViewModel <>4__this;

			// Token: 0x04000AA9 RID: 2729
			private RkoViewModel.<>c__DisplayClass51_0 <>8__1;

			// Token: 0x04000AAA RID: 2730
			private TaskAwaiter<CashOutOrder> <>u__1;

			// Token: 0x04000AAB RID: 2731
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200013C RID: 316
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdatePaymentSystem>d__81 : IAsyncStateMachine
		{
			// Token: 0x060015E3 RID: 5603 RVA: 0x00034894 File Offset: 0x00032A94
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RkoViewModel rkoViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						rkoViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<IAscResult> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<IAscResult>(() => KassaModel.UpdateOrderPaymentSystem(base.Order.id, base.Order.payment_system)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, RkoViewModel.<UpdatePaymentSystem>d__81>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IAscResult>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						rkoViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						rkoViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							rkoViewModel.HideWait();
						}
					}
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

			// Token: 0x060015E4 RID: 5604 RVA: 0x000349B4 File Offset: 0x00032BB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000AAC RID: 2732
			public int <>1__state;

			// Token: 0x04000AAD RID: 2733
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000AAE RID: 2734
			public RkoViewModel <>4__this;

			// Token: 0x04000AAF RID: 2735
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x0200013D RID: 317
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__99 : IAsyncStateMachine
		{
			// Token: 0x060015E5 RID: 5605 RVA: 0x000349D0 File Offset: 0x00032BD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RkoViewModel rkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						rkoViewModel.<>n__0();
						if (rkoViewModel.cashOrderId <= 0 || (rkoViewModel.Order != null && rkoViewModel.Order.id != 0))
						{
							goto IL_93;
						}
						awaiter = rkoViewModel.LoadOrder(rkoViewModel.cashOrderId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RkoViewModel.<OnLoad>d__99>(ref awaiter, ref this);
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
					IL_93:;
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

			// Token: 0x060015E6 RID: 5606 RVA: 0x00034AAC File Offset: 0x00032CAC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000AB0 RID: 2736
			public int <>1__state;

			// Token: 0x04000AB1 RID: 2737
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000AB2 RID: 2738
			public RkoViewModel <>4__this;

			// Token: 0x04000AB3 RID: 2739
			private TaskAwaiter <>u__1;
		}
	}
}
