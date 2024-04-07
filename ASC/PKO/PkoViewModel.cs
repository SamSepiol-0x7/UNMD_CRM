using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Clients;
using ASC.Common.Enum;
using ASC.Common.Interfaces;
using ASC.Documents;
using ASC.Extensions.KKT;
using ASC.Extensions.Pinpad;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.RKO;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using ASC.Workspace.Repairs;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Editors;
using DevExpress.XtraReports.UI;

namespace ASC.PKO
{
	// Token: 0x02000172 RID: 370
	public class PkoViewModel : BaseViewModel, IBaseViewModel, IKoViewModel, IKktCheque, IRepairSelect, IDocumentSelect, ICustomerSelect
	{
		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0003C024 File Offset: 0x0003A224
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0003C038 File Offset: 0x0003A238
		public CashInOrder Order
		{
			[CompilerGenerated]
			get
			{
				return this.<Order>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Order>k__BackingField, value))
				{
					return;
				}
				this.<Order>k__BackingField = value;
				this.RaisePropertyChanged("IsEditable");
				this.RaisePropertyChanged("IsEditableInvert");
				this.RaisePropertyChanged("DisableSelectCompany");
				this.RaisePropertyChanged("Order");
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0003C088 File Offset: 0x0003A288
		public bool IsEditable
		{
			get
			{
				return this.Order != null && this.Order.Id == 0;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
		public bool IsEditableInvert
		{
			get
			{
				return !this.IsEditable;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x0003C0C8 File Offset: 0x0003A2C8
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x0003C0DC File Offset: 0x0003A2DC
		public List<OrderOptions> PkoOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<PkoOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<PkoOptionses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1982352693;
				IL_13:
				switch ((num ^ -387688358) % 4)
				{
				case 0:
					IL_32:
					this.<PkoOptionses>k__BackingField = value;
					this.RaisePropertyChanged("PkoOptionses");
					num = -1461746639;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0003C138 File Offset: 0x0003A338
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0003C14C File Offset: 0x0003A34C
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0003C17C File Offset: 0x0003A37C
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x0003C190 File Offset: 0x0003A390
		public bool SendChequeToEmail
		{
			[CompilerGenerated]
			get
			{
				return this.<SendChequeToEmail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SendChequeToEmail>k__BackingField == value)
				{
					return;
				}
				this.<SendChequeToEmail>k__BackingField = value;
				this.RaisePropertyChanged("SendChequeToEmail");
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0003C1BC File Offset: 0x0003A3BC
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x0003C1D0 File Offset: 0x0003A3D0
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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0003C1FC File Offset: 0x0003A3FC
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x0003C210 File Offset: 0x0003A410
		private bool PrintOrderNeeded
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintOrderNeeded>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintOrderNeeded>k__BackingField == value)
				{
					return;
				}
				this.<PrintOrderNeeded>k__BackingField = value;
				this.RaisePropertyChanged("PrintOrderNeeded");
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0003C23C File Offset: 0x0003A43C
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0003C250 File Offset: 0x0003A450
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
				if (this.<PrintKktCheque>k__BackingField == value)
				{
					return;
				}
				this.<PrintKktCheque>k__BackingField = value;
				this.RaisePropertyChanged("PrintKktCheque");
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x0003C27C File Offset: 0x0003A47C
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x0003C290 File Offset: 0x0003A490
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

		// Token: 0x0600175A RID: 5978 RVA: 0x0003C2BC File Offset: 0x0003A4BC
		private void IoC()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		public PkoViewModel()
		{
			this.IoC();
			this.SetViewName("PKO");
			this.PkoOptionses = OrderOptions.GetPKO(false);
			this.LoadPaymentItemSigns();
			this.Order = new CashInOrder();
			this.Order.SetCompany(OfflineData.Instance.GetSelectedCompany());
			this.Order.SetOffice(OfflineData.Instance.Employee.OfficeId);
			this.Order.SetEmployee(OfflineData.Instance.Employee.Id);
			this.Order.PaymentItemSign = new int?(1);
			this.PaymentSystemChanged();
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0003C3AC File Offset: 0x0003A5AC
		public PkoViewModel(int id)
		{
			this.IoC();
			this.SetViewName("PKO", id);
			this.cashOrderId = id;
			this.PkoOptionses = OrderOptions.GetPKO(true);
			this.LoadPaymentItemSigns();
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0003C3F8 File Offset: 0x0003A5F8
		private Task LoadOrder(int orderId)
		{
			PkoViewModel.<LoadOrder>d__44 <LoadOrder>d__;
			<LoadOrder>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadOrder>d__.<>4__this = this;
			<LoadOrder>d__.orderId = orderId;
			<LoadOrder>d__.<>1__state = -1;
			<LoadOrder>d__.<>t__builder.Start<PkoViewModel.<LoadOrder>d__44>(ref <LoadOrder>d__);
			return <LoadOrder>d__.<>t__builder.Task;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0003C444 File Offset: 0x0003A644
		public PkoViewModel(workshop repair, Kassa.Types type, bool returnOnCreate = false, bool refreshParent = false) : this()
		{
			this.IoC();
			this.SetReturnOnCreate(returnOnCreate);
			this._refreshParent = refreshParent;
			this.ReasonAutocomplete = true;
			this.Order.FillByRepair(repair, type);
			this.RefreshCommands();
			this.PrintOrderNeeded = false;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0003C490 File Offset: 0x0003A690
		public void LoadPaymentItemSigns()
		{
			this.PaymentItemSigns = KktBase.GetPaymentItemSigns();
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0003C4A8 File Offset: 0x0003A6A8
		private void SetReturnOnCreate(bool value)
		{
			this._returnOnCreate = value;
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0003C4BC File Offset: 0x0003A6BC
		[Command]
		public void PaymentSystemChanged()
		{
			this.PrintKktChequeVisible = (this.Order != null && this.Order.Id == 0 && (this.Order.PaymentSystem == 0 || this.Order.PaymentSystem == -1));
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0003C508 File Offset: 0x0003A708
		[Command]
		public void SelectDocument()
		{
			if (!this.Order.IsNew())
			{
				goto IL_31;
			}
			IL_0D:
			int num = -798728788;
			IL_12:
			switch ((num ^ -563659061) % 4)
			{
			case 0:
				goto IL_0D;
			case 2:
				IL_31:
				this.OpenDocument();
				num = -1757554662;
				goto IL_12;
			case 3:
				this.SelectDoc();
				return;
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0003C55C File Offset: 0x0003A75C
		private void OpenDocument()
		{
			if (this.Order.RepairId != null)
			{
				this._navigationService.NavigateRepairCard(this.Order.RepairId.Value);
				return;
			}
			if (this.Order.DocumentId == null)
			{
				if (this.Order.InvoiceId != null)
				{
					this._navigationService.NavigateInvoice(this.Order.InvoiceId.Value);
				}
				return;
			}
			this._navigationService.NavigateSaleDocument(this.Order.DocumentId.Value);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0003C604 File Offset: 0x0003A804
		private void SelectDoc()
		{
			int type = this.Order.Type;
			for (;;)
			{
				switch (type)
				{
				case 12:
					goto IL_71;
				case 13:
					return;
				case 14:
					goto IL_8B;
				case 15:
					goto IL_A3;
				default:
				{
					uint num;
					switch ((num = (num * 810847133U ^ 4078548449U ^ 92890950U)) % 10U)
					{
					case 0U:
						return;
					case 1U:
						return;
					case 2U:
						return;
					case 3U:
						return;
					case 4U:
					case 6U:
						continue;
					case 5U:
						goto IL_A3;
					case 7U:
						goto IL_71;
					case 8U:
						goto IL_8B;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			return;
			IL_71:
			this._navigationService.Navigate("RepairsView", new RepairsViewModel(WorkshopStatus.AllStatuses), this);
			return;
			IL_8B:
			this._navigationService.Navigate("DocumentsView", new DocumentsViewModel(2), this);
			return;
			IL_A3:
			this._navigationService.Navigate("RepairsView", new RepairsViewModel(WorkshopStatus.Ready2Issue), this);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0003C6CC File Offset: 0x0003A8CC
		public void SetOrderType(Kassa.Types type)
		{
			this.Order.Type = (int)type;
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x0003C6E8 File Offset: 0x0003A8E8
		public bool DisableSelectCompany
		{
			get
			{
				return this.Order != null && (this.Order.RepairId != null || this.Order.Id != 0);
			}
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0003C724 File Offset: 0x0003A924
		public void SelectRepairFromList(WorkshopLite repair)
		{
			if (repair != null)
			{
				goto IL_27;
			}
			IL_03:
			int num = 1660566082;
			IL_08:
			switch ((num ^ 165047283) % 4)
			{
			case 0:
				IL_27:
				this.Order.FillByRepair(repair.RepairId);
				num = 1896503200;
				goto IL_08;
			case 1:
				return;
			case 2:
				goto IL_03;
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0003C774 File Offset: 0x0003A974
		public void SelectDoc(DocsList document)
		{
			if (document == null)
			{
				return;
			}
			if (document.OrderId != null)
			{
				this._toasterService.Error(Lang.t("DocumentAlreadyPko"));
				return;
			}
			this.Order.FillByDoc(document);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		[Command]
		public void PrintOrder(object obj)
		{
			if (this.Order != null && this.Order.Id != 0)
			{
				this.PrintOrder();
				return;
			}
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0003C7E4 File Offset: 0x0003A9E4
		[Command]
		public void OrderParamChanged(object obj)
		{
			if (this.Order.Id == 0 && this.ReasonAutocomplete)
			{
				this.Order.AutocompleteReason();
			}
			EditValueChangedEventArgs editValueChangedEventArgs = obj as EditValueChangedEventArgs;
			if (editValueChangedEventArgs != null && editValueChangedEventArgs.OldValue != null && editValueChangedEventArgs.OldValue != editValueChangedEventArgs.NewValue && this.Order.Id == 0)
			{
				this.Order.RepairId = null;
				this.Order.SetCustomer(null);
				this.Order.Customer = null;
				this.Order.DocumentId = null;
			}
			this.RefreshCommands();
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0003C088 File Offset: 0x0003A288
		public bool CanOrderParamChanged(object obj)
		{
			return this.Order != null && this.Order.Id == 0;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0003C88C File Offset: 0x0003AA8C
		private void RefreshCommands()
		{
			base.RaiseCanExecuteChanged(() => this.MakeOrder());
			base.RaiseCanExecuteChanged(() => this.SelectPayer());
			base.RaisePropertyChanged<bool>(() => this.DisableSelectCompany);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0003C944 File Offset: 0x0003AB44
		[AsyncCommand]
		public Task MakeOrder()
		{
			PkoViewModel.<MakeOrder>d__63 <MakeOrder>d__;
			<MakeOrder>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MakeOrder>d__.<>4__this = this;
			<MakeOrder>d__.<>1__state = -1;
			<MakeOrder>d__.<>t__builder.Start<PkoViewModel.<MakeOrder>d__63>(ref <MakeOrder>d__);
			return <MakeOrder>d__.<>t__builder.Task;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0003C988 File Offset: 0x0003AB88
		private void PrintOrder()
		{
			base.ShowWait();
			Task.Run<XtraReport>(() => this.Order.CreateReport()).ContinueWith(delegate(Task<XtraReport> t)
			{
				base.HideWait();
				this._reportPrintService.PrintPreview(t.Result, PrinterModel.Printer.Documents);
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0003C088 File Offset: 0x0003A288
		public bool CanMakeOrder()
		{
			return this.Order != null && this.Order.Id == 0;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0003C9C4 File Offset: 0x0003ABC4
		[Command]
		public void OpenPayer()
		{
			if (this.Order.CustomerId != null)
			{
				this._navigationService.NavigateToCustomerCard(this.Order.CustomerId.Value, null);
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0003CA08 File Offset: 0x0003AC08
		public bool CanOpenPayer()
		{
			return this.Order != null && this.Order.Id != 0 && this.Order.CustomerId != null;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0003CA40 File Offset: 0x0003AC40
		[Command]
		public void SelectPayer()
		{
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectClient"), this);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0003CA68 File Offset: 0x0003AC68
		public bool CanSelectPayer()
		{
			return this.Order != null && this.Order.Id == 0 && (this.Order.Type != 12 || this.Order.Type != 14);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0003CAB0 File Offset: 0x0003ACB0
		public void SelectCustomerFromList(ICustomer customer)
		{
			if (customer != null)
			{
				goto IL_27;
			}
			IL_03:
			int num = 1307443331;
			IL_08:
			switch ((num ^ 2008446686) % 4)
			{
			case 0:
				IL_27:
				this.Order.SetCustomer(new int?(customer.Id));
				num = 643030017;
				goto IL_08;
			case 1:
				return;
			case 2:
				goto IL_03;
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0003CB04 File Offset: 0x0003AD04
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			if (parentViewModel is ICashOrderSelect)
			{
				this._parentViewModel = parentViewModel;
				return;
			}
			if (!(parentViewModel is IRefreshable))
			{
				return;
			}
			this._parentViewModel = parentViewModel;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0003CB38 File Offset: 0x0003AD38
		[Command]
		public void SendChequeChanged()
		{
			if (!this.SendChequeToEmail)
			{
				this.Order.CustomerEmail = "";
			}
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0003CB60 File Offset: 0x0003AD60
		[Command]
		public void UpdatePaymentSystem()
		{
			PkoViewModel.<UpdatePaymentSystem>d__73 <UpdatePaymentSystem>d__;
			<UpdatePaymentSystem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdatePaymentSystem>d__.<>4__this = this;
			<UpdatePaymentSystem>d__.<>1__state = -1;
			<UpdatePaymentSystem>d__.<>t__builder.Start<PkoViewModel.<UpdatePaymentSystem>d__73>(ref <UpdatePaymentSystem>d__);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0003CB98 File Offset: 0x0003AD98
		public bool CanUpdatePaymentSystem()
		{
			return this.Order != null && this.Order.Id > 0 && OfflineData.Instance.Employee.Can(16, 0);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0003CBD0 File Offset: 0x0003ADD0
		[Command]
		public void RefundRko()
		{
			RkoViewModel rkoViewModel = new RkoViewModel
			{
				ReasonAutocomplete = true
			};
			rkoViewModel.LoadRkoOptions(true);
			rkoViewModel.SetCompany(this.Order.CompanyId);
			rkoViewModel.SetPrintKktCheque(true);
			rkoViewModel.SetPaymentSystem((PaymentOptions.Systems)this.Order.PaymentSystem);
			rkoViewModel.SetSumm(this.Order.Summ);
			rkoViewModel.SetCustomer(this.Order.Customer);
			rkoViewModel.SetType(Kassa.Types.RefundRko);
			rkoViewModel.Autocomplete();
			rkoViewModel.SetCanSelectPaymentType(false);
			this._navigationService.Navigate("RkoView", rkoViewModel);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0003CC64 File Offset: 0x0003AE64
		public bool CanRefundRko()
		{
			return OfflineData.Instance.Employee.Can(16, 0) && this.Order != null && this.Order.Id > 0 && this.CashOrCardPayment();
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0003CCA4 File Offset: 0x0003AEA4
		private bool CashOrCardPayment()
		{
			return this.Order.PaymentSystem == 0 || this.Order.PaymentSystem == -1;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		public override void OnLoad()
		{
			PkoViewModel.<OnLoad>d__78 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<PkoViewModel.<OnLoad>d__78>(ref <OnLoad>d__);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0003CD08 File Offset: 0x0003AF08
		[CompilerGenerated]
		private IAscResult <MakeOrder>b__63_0()
		{
			return KassaModel.CreateCashOrder(this.Order, true);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0003CD24 File Offset: 0x0003AF24
		[CompilerGenerated]
		private Task<XtraReport> <PrintOrder>b__64_0()
		{
			return this.Order.CreateReport();
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0003CD3C File Offset: 0x0003AF3C
		[CompilerGenerated]
		private void <PrintOrder>b__64_1(Task<XtraReport> t)
		{
			base.HideWait();
			this._reportPrintService.PrintPreview(t.Result, PrinterModel.Printer.Documents);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0003CD64 File Offset: 0x0003AF64
		[CompilerGenerated]
		private IAscResult <UpdatePaymentSystem>b__73_0()
		{
			return KassaModel.UpdateOrderPaymentSystem(this.Order.Id, this.Order.PaymentSystem);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04000B93 RID: 2963
		private object _parentViewModel;

		// Token: 0x04000B94 RID: 2964
		private INavigationService _navigationService;

		// Token: 0x04000B95 RID: 2965
		private IToasterService _toasterService;

		// Token: 0x04000B96 RID: 2966
		[CompilerGenerated]
		private CashInOrder <Order>k__BackingField;

		// Token: 0x04000B97 RID: 2967
		private int cashOrderId;

		// Token: 0x04000B98 RID: 2968
		private bool _returnOnCreate;

		// Token: 0x04000B99 RID: 2969
		[CompilerGenerated]
		private List<OrderOptions> <PkoOptionses>k__BackingField;

		// Token: 0x04000B9A RID: 2970
		[CompilerGenerated]
		private Dictionary<int, string> <PaymentItemSigns>k__BackingField;

		// Token: 0x04000B9B RID: 2971
		[CompilerGenerated]
		private bool <SendChequeToEmail>k__BackingField;

		// Token: 0x04000B9C RID: 2972
		[CompilerGenerated]
		private bool <ReasonAutocomplete>k__BackingField = true;

		// Token: 0x04000B9D RID: 2973
		[CompilerGenerated]
		private bool <PrintOrderNeeded>k__BackingField = true;

		// Token: 0x04000B9E RID: 2974
		[CompilerGenerated]
		private bool <PrintKktCheque>k__BackingField;

		// Token: 0x04000B9F RID: 2975
		[CompilerGenerated]
		private bool <PrintKktChequeVisible>k__BackingField;

		// Token: 0x04000BA0 RID: 2976
		private bool _refreshParent;

		// Token: 0x04000BA1 RID: 2977
		private IReportPrintService _reportPrintService;

		// Token: 0x02000173 RID: 371
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06001782 RID: 6018 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x06001783 RID: 6019 RVA: 0x0003CD8C File Offset: 0x0003AF8C
			internal Task<CashInOrder> <LoadOrder>b__0()
			{
				return this.kassaService.GetCashInOrderAsync(this.orderId);
			}

			// Token: 0x04000BA2 RID: 2978
			public IKassaService kassaService;

			// Token: 0x04000BA3 RID: 2979
			public int orderId;
		}

		// Token: 0x02000174 RID: 372
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadOrder>d__44 : IAsyncStateMachine
		{
			// Token: 0x06001784 RID: 6020 RVA: 0x0003CDAC File Offset: 0x0003AFAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PkoViewModel pkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<CashInOrder> awaiter;
					if (num != 0)
					{
						PkoViewModel.<>c__DisplayClass44_0 CS$<>8__locals1 = new PkoViewModel.<>c__DisplayClass44_0();
						CS$<>8__locals1.orderId = this.orderId;
						pkoViewModel.ShowWait();
						CS$<>8__locals1.kassaService = Bootstrapper.Container.Resolve<IKassaService>();
						awaiter = Task.Run<CashInOrder>(new Func<Task<CashInOrder>>(CS$<>8__locals1.<LoadOrder>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CashInOrder>, PkoViewModel.<LoadOrder>d__44>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CashInOrder>);
						this.<>1__state = -1;
					}
					CashInOrder result = awaiter.GetResult();
					pkoViewModel.Order = result;
					pkoViewModel.RefreshCommands();
					pkoViewModel.HideWait();
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

			// Token: 0x06001785 RID: 6021 RVA: 0x0003CEA8 File Offset: 0x0003B0A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BA4 RID: 2980
			public int <>1__state;

			// Token: 0x04000BA5 RID: 2981
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000BA6 RID: 2982
			public int orderId;

			// Token: 0x04000BA7 RID: 2983
			public PkoViewModel <>4__this;

			// Token: 0x04000BA8 RID: 2984
			private TaskAwaiter<CashInOrder> <>u__1;
		}

		// Token: 0x02000175 RID: 373
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeOrder>d__63 : IAsyncStateMachine
		{
			// Token: 0x06001786 RID: 6022 RVA: 0x0003CEC4 File Offset: 0x0003B0C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PkoViewModel pkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<IAscResult> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_2DF;
						}
						if (!pkoViewModel.CheckFields(pkoViewModel.Order))
						{
							goto IL_330;
						}
						pkoViewModel.Order.SetSummaString();
						if (pkoViewModel.Order.PaymentSystem == -1)
						{
							if (OfflineData.Instance.Employee.PinpadReady())
							{
								IPinpadResult pinpadResult = new SBRFPinpad().Purchase(pkoViewModel.Order.Summ);
								if (pinpadResult.ErrorCode != 0)
								{
									pkoViewModel._toasterService.Error(pinpadResult.ResultText);
									goto IL_330;
								}
								pkoViewModel.Order.PinpadId = pinpadResult.PinpadId;
								pkoViewModel.Order.Amount = pinpadResult.Amount;
								pkoViewModel.Order.TermNum = pinpadResult.TermNum;
								pkoViewModel.Order.ClientCard = pinpadResult.ClientCard;
								pkoViewModel.Order.ClientExpiryDate = pinpadResult.ClientExpiryDate;
								pkoViewModel.Order.AuthCode = pinpadResult.AuthCode;
								pkoViewModel.Order.CardName = pinpadResult.CardName;
							}
						}
						pkoViewModel.ShowWait();
						awaiter2 = Task.Run<IAscResult>(() => KassaModel.CreateCashOrder(base.Order, true)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PkoViewModel.<MakeOrder>d__63>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter2.GetResult();
					pkoViewModel.HideWait();
					if (!result.IsSucces)
					{
						pkoViewModel._toasterService.Error(result.Message);
						goto IL_330;
					}
					pkoViewModel._toasterService.Success(Lang.t("Saved"));
					pkoViewModel.Order.Id = result.Id;
					pkoViewModel._navigationService.SetTabHeader("PKO", pkoViewModel.Order.Id);
					if (pkoViewModel.PrintKktCheque && OfflineData.Instance.Employee.KktReady())
					{
						IAscResult ascResult = OfflineData.Instance.Employee.Kkt.PkoCheck(pkoViewModel.Order);
						if (!ascResult.IsSucces || !string.IsNullOrEmpty(ascResult.Message))
						{
							pkoViewModel._toasterService.Error(ascResult.Message);
						}
					}
					if (pkoViewModel._returnOnCreate)
					{
						ICashOrderSelect cashOrderSelect = pkoViewModel._parentViewModel as ICashOrderSelect;
						if (cashOrderSelect != null)
						{
							cashOrderSelect.SelectCashOrder(pkoViewModel.Order);
							cashOrderSelect.DataRefresh();
							pkoViewModel._navigationService.CloseCurrentTab();
							goto IL_330;
						}
					}
					if (pkoViewModel._refreshParent)
					{
						IRefreshable refreshable = pkoViewModel._parentViewModel as IRefreshable;
						if (refreshable != null)
						{
							refreshable.DataRefresh();
						}
					}
					awaiter = pkoViewModel.LoadOrder(result.Id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PkoViewModel.<MakeOrder>d__63>(ref awaiter, ref this);
						return;
					}
					IL_2DF:
					awaiter.GetResult();
					if (pkoViewModel.PrintOrderNeeded)
					{
						pkoViewModel.PrintOrder();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_330:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001787 RID: 6023 RVA: 0x0003D230 File Offset: 0x0003B430
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BA9 RID: 2985
			public int <>1__state;

			// Token: 0x04000BAA RID: 2986
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000BAB RID: 2987
			public PkoViewModel <>4__this;

			// Token: 0x04000BAC RID: 2988
			private TaskAwaiter<IAscResult> <>u__1;

			// Token: 0x04000BAD RID: 2989
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000176 RID: 374
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdatePaymentSystem>d__73 : IAsyncStateMachine
		{
			// Token: 0x06001788 RID: 6024 RVA: 0x0003D24C File Offset: 0x0003B44C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PkoViewModel pkoViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						pkoViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<IAscResult> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<IAscResult>(() => KassaModel.UpdateOrderPaymentSystem(base.Order.Id, base.Order.PaymentSystem)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PkoViewModel.<UpdatePaymentSystem>d__73>(ref awaiter, ref this);
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
						pkoViewModel._toasterService.Success("");
					}
					catch (Exception ex)
					{
						pkoViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							pkoViewModel.HideWait();
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

			// Token: 0x06001789 RID: 6025 RVA: 0x0003D364 File Offset: 0x0003B564
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BAE RID: 2990
			public int <>1__state;

			// Token: 0x04000BAF RID: 2991
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000BB0 RID: 2992
			public PkoViewModel <>4__this;

			// Token: 0x04000BB1 RID: 2993
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x02000177 RID: 375
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__78 : IAsyncStateMachine
		{
			// Token: 0x0600178A RID: 6026 RVA: 0x0003D380 File Offset: 0x0003B580
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PkoViewModel pkoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						pkoViewModel.<>n__0();
						if (pkoViewModel.cashOrderId <= 0 || pkoViewModel.Order != null)
						{
							goto IL_86;
						}
						awaiter = pkoViewModel.LoadOrder(pkoViewModel.cashOrderId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PkoViewModel.<OnLoad>d__78>(ref awaiter, ref this);
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
					IL_86:;
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

			// Token: 0x0600178B RID: 6027 RVA: 0x0003D450 File Offset: 0x0003B650
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BB2 RID: 2994
			public int <>1__state;

			// Token: 0x04000BB3 RID: 2995
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000BB4 RID: 2996
			public PkoViewModel <>4__this;

			// Token: 0x04000BB5 RID: 2997
			private TaskAwaiter <>u__1;
		}
	}
}
