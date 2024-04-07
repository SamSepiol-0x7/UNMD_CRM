using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModel;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Editors;

namespace ASC.Invoice
{
	// Token: 0x02000AFA RID: 2810
	public class InvoiceBaseViewModel : BaseViewModel, IInvoiceItemAdd, IRefreshable, ICustomerSelect
	{
		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x00158214 File Offset: 0x00156414
		// (set) Token: 0x06004F7E RID: 20350 RVA: 0x00158228 File Offset: 0x00156428
		public IInvoice Document
		{
			[CompilerGenerated]
			get
			{
				return this.<Document>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (!object.Equals(this.<Document>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1461791967;
				IL_13:
				switch ((num ^ -220250734) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<Document>k__BackingField = value;
					this.RaisePropertyChanged("Document");
					num = -791177636;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06004F7F RID: 20351 RVA: 0x00158284 File Offset: 0x00156484
		// (set) Token: 0x06004F80 RID: 20352 RVA: 0x00158298 File Offset: 0x00156498
		public IInvoiceItem SelectedItem
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

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06004F81 RID: 20353 RVA: 0x001582C8 File Offset: 0x001564C8
		// (set) Token: 0x06004F82 RID: 20354 RVA: 0x001582DC File Offset: 0x001564DC
		public int CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CustomerId>k__BackingField == value)
				{
					return;
				}
				this.<CustomerId>k__BackingField = value;
				this.RaisePropertyChanged("CustomerId");
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06004F83 RID: 20355 RVA: 0x00158308 File Offset: 0x00156508
		// (set) Token: 0x06004F84 RID: 20356 RVA: 0x0015831C File Offset: 0x0015651C
		public List<SellerPaymentDetails> CompanyPaymentDetails
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanyPaymentDetails>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<CompanyPaymentDetails>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1040674357;
				IL_13:
				switch ((num ^ -1384478336) % 4)
				{
				case 0:
					IL_32:
					this.<CompanyPaymentDetails>k__BackingField = value;
					this.RaisePropertyChanged("CompanyPaymentDetails");
					num = -1253447163;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06004F85 RID: 20357 RVA: 0x00158378 File Offset: 0x00156578
		// (set) Token: 0x06004F86 RID: 20358 RVA: 0x0015838C File Offset: 0x0015658C
		public List<PaymentDetails> CustomerPaymentDetails
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerPaymentDetails>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CustomerPaymentDetails>k__BackingField, value))
				{
					return;
				}
				this.<CustomerPaymentDetails>k__BackingField = value;
				this.RaisePropertyChanged("CustomerPaymentDetails");
			}
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x001583BC File Offset: 0x001565BC
		public InvoiceBaseViewModel()
		{
			this.InvoiceStrategy = Bootstrapper.Container.Resolve<IInvoiceStrategy>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x00158420 File Offset: 0x00156620
		public Task LoadExistDocument(int documentId)
		{
			InvoiceBaseViewModel.<LoadExistDocument>d__27 <LoadExistDocument>d__;
			<LoadExistDocument>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadExistDocument>d__.<>4__this = this;
			<LoadExistDocument>d__.documentId = documentId;
			<LoadExistDocument>d__.<>1__state = -1;
			<LoadExistDocument>d__.<>t__builder.Start<InvoiceBaseViewModel.<LoadExistDocument>d__27>(ref <LoadExistDocument>d__);
			return <LoadExistDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x0015846C File Offset: 0x0015666C
		public virtual Task LoadDocument(int id)
		{
			InvoiceBaseViewModel.<LoadDocument>d__28 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<InvoiceBaseViewModel.<LoadDocument>d__28>(ref <LoadDocument>d__);
			return <LoadDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x001584B0 File Offset: 0x001566B0
		public virtual void SendEmail()
		{
			IInvoice document = this.Document;
			if (document == null)
			{
				return;
			}
			document.EnablePrintImages();
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x001584D0 File Offset: 0x001566D0
		public bool CanSendEmail()
		{
			if (this.Document != null && this.Document.Id > 0)
			{
				IPaymentDetails customer = this.Document.Customer;
				return !string.IsNullOrEmpty((customer != null) ? customer.Email : null);
			}
			return false;
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x00158514 File Offset: 0x00156714
		public void SelectCustomerFromList(ICustomer customer)
		{
			InvoiceBaseViewModel.<SelectCustomerFromList>d__31 <SelectCustomerFromList>d__;
			<SelectCustomerFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectCustomerFromList>d__.<>4__this = this;
			<SelectCustomerFromList>d__.customer = customer;
			<SelectCustomerFromList>d__.<>1__state = -1;
			<SelectCustomerFromList>d__.<>t__builder.Start<InvoiceBaseViewModel.<SelectCustomerFromList>d__31>(ref <SelectCustomerFromList>d__);
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x00158554 File Offset: 0x00156754
		public void DataRefresh()
		{
			InvoiceBaseViewModel.<DataRefresh>d__32 <DataRefresh>d__;
			<DataRefresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DataRefresh>d__.<>4__this = this;
			<DataRefresh>d__.<>1__state = -1;
			<DataRefresh>d__.<>t__builder.Start<InvoiceBaseViewModel.<DataRefresh>d__32>(ref <DataRefresh>d__);
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x0015858C File Offset: 0x0015678C
		public Task LoadCustomerPaymentDetails()
		{
			InvoiceBaseViewModel.<LoadCustomerPaymentDetails>d__33 <LoadCustomerPaymentDetails>d__;
			<LoadCustomerPaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadCustomerPaymentDetails>d__.<>4__this = this;
			<LoadCustomerPaymentDetails>d__.<>1__state = -1;
			<LoadCustomerPaymentDetails>d__.<>t__builder.Start<InvoiceBaseViewModel.<LoadCustomerPaymentDetails>d__33>(ref <LoadCustomerPaymentDetails>d__);
			return <LoadCustomerPaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x001585D0 File Offset: 0x001567D0
		// (set) Token: 0x06004F90 RID: 20368 RVA: 0x001585E4 File Offset: 0x001567E4
		public bool PaymentDetailsNotFound
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentDetailsNotFound>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PaymentDetailsNotFound>k__BackingField == value)
				{
					return;
				}
				this.<PaymentDetailsNotFound>k__BackingField = value;
				this.RaisePropertyChanged("PaymentDetailsNotFound");
			}
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x00158610 File Offset: 0x00156810
		public void SetCustomerPaymentDetails(int paymentDetailsId)
		{
			IPaymentDetails customer = null;
			if (this.CustomerPaymentDetails != null)
			{
				customer = ((paymentDetailsId > 0) ? this.CustomerPaymentDetails.FirstOrDefault((PaymentDetails d) => d.Id == paymentDetailsId) : this.CustomerPaymentDetails.FirstOrDefault<PaymentDetails>());
			}
			this.Document.Customer = customer;
			this.PaymentDetailsNotFound = (this.CustomerId > 0 && (this.CustomerPaymentDetails == null || !this.CustomerPaymentDetails.Any<PaymentDetails>()));
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x0015869C File Offset: 0x0015689C
		public Task LoadCompanyPaymentDetails()
		{
			InvoiceBaseViewModel.<LoadCompanyPaymentDetails>d__39 <LoadCompanyPaymentDetails>d__;
			<LoadCompanyPaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadCompanyPaymentDetails>d__.<>4__this = this;
			<LoadCompanyPaymentDetails>d__.<>1__state = -1;
			<LoadCompanyPaymentDetails>d__.<>t__builder.Start<InvoiceBaseViewModel.<LoadCompanyPaymentDetails>d__39>(ref <LoadCompanyPaymentDetails>d__);
			return <LoadCompanyPaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x001586E0 File Offset: 0x001568E0
		public void SetSeller()
		{
			IInvoice document = this.Document;
			if (((document != null) ? document.Seller : null) != null)
			{
				for (;;)
				{
					IL_5F:
					int num = 1724896371;
					for (;;)
					{
						switch ((num ^ 1020080887) % 3)
						{
						case 1:
						{
							IInvoice document2 = this.Document;
							List<SellerPaymentDetails> companyPaymentDetails = this.CompanyPaymentDetails;
							document2.Seller = ((companyPaymentDetails != null) ? companyPaymentDetails.FirstOrDefault((SellerPaymentDetails d) => d.Id == this.Document.Seller.Id) : null);
							num = 1393642501;
							continue;
						}
						case 2:
							goto IL_5F;
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x00158754 File Offset: 0x00156954
		public void InvoiceItemAdd(IInvoiceItem item)
		{
			if (!this.Document.Items.Any((IInvoiceItem i) => i.Name == item.Name))
			{
				this.Document.Items.Add(item);
				this.Document.CalcTotal();
				return;
			}
			this.Document.CalcTotal();
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x001587BC File Offset: 0x001569BC
		[Command]
		public void SelectCustomer()
		{
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectCompany"), this);
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x001587E4 File Offset: 0x001569E4
		public bool IsNewInvoice()
		{
			return this.Document != null && this.Document.Id == 0;
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x0015880C File Offset: 0x00156A0C
		public bool CanSelectCustomer()
		{
			return this.IsNewInvoice();
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x00158820 File Offset: 0x00156A20
		[Command]
		public void ShowAddPaymentDetails()
		{
			if (this.CustomerId != 0)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1803379555;
			IL_0D:
			switch ((num ^ 803610794) % 4)
			{
			case 1:
				return;
			case 2:
				IL_2C:
				this._windowedDocumentService.ShowNewDocument("PaymentDetailsView", new PaymentDetailsViewModel(this.CustomerId), this, null);
				num = 965910094;
				goto IL_0D;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x0015880C File Offset: 0x00156A0C
		public bool CanShowAddPaymentDetails()
		{
			return this.IsNewInvoice();
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x00158880 File Offset: 0x00156A80
		[Command]
		public void ShowEditPaymentDetails()
		{
			if (this.Document.Customer != null)
			{
				goto IL_31;
			}
			IL_0D:
			int num = 1000972549;
			IL_12:
			switch ((num ^ 1776273204) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_0D;
			case 3:
				IL_31:
				this._windowedDocumentService.ShowNewDocument("PaymentDetailsView", new PaymentDetailsViewModel(this.Document.Customer), this, null);
				num = 415398376;
				goto IL_12;
			}
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x0015880C File Offset: 0x00156A0C
		public bool CanShowEditPaymentDetail()
		{
			return this.IsNewInvoice();
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x001588E8 File Offset: 0x00156AE8
		[Command]
		public void SellerChanged()
		{
			try
			{
				this.Document.SetNum();
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x00158928 File Offset: 0x00156B28
		public bool CanSellerChanged()
		{
			return this.IsNewInvoice() && this.Document.Seller != null;
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00158950 File Offset: 0x00156B50
		[Command]
		public void IncrementInvoiceId()
		{
			this.Document.IncrementNum();
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00158968 File Offset: 0x00156B68
		public bool CanIncrementInvoiceId()
		{
			return this.IsNewInvoice() && this.Document.Seller != null && this.Document.Seller.Id > 0;
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x001589A0 File Offset: 0x00156BA0
		[Command]
		public void AddItem()
		{
			this._windowedDocumentService.ShowNewDocument("InvoiceItemView", new InvoiceItemViewModel(), this, null);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x001589C4 File Offset: 0x00156BC4
		public bool CanAddItem()
		{
			return this.IsNewInvoice() && base.IsValid();
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x001589E4 File Offset: 0x00156BE4
		[Command]
		public void ItemDoubleClick()
		{
			if (this.SelectedItem == null)
			{
				return;
			}
			this._windowedDocumentService.ShowNewDocument("InvoiceItemView", new InvoiceItemViewModel(this.SelectedItem), this, null);
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00158A18 File Offset: 0x00156C18
		public bool CanItemDoubleClick()
		{
			return this.Document != null && this.Document.State != 2;
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x00158A40 File Offset: 0x00156C40
		public bool CanCreateDocument()
		{
			return this.IsNewInvoice() && OfflineData.Instance.Employee.Can(65, 0) && base.IsValid();
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00158A74 File Offset: 0x00156C74
		public virtual void Print()
		{
			IInvoice document = this.Document;
			if (document == null)
			{
				return;
			}
			document.DisablePrintImages();
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x00158A94 File Offset: 0x00156C94
		[Command]
		public void NavigateRepairCard()
		{
			if (this.SelectedItem != null && this.SelectedItem.RepairId != null)
			{
				this._navigationService.NavigateRepairCard(this.SelectedItem.RepairId.Value);
				return;
			}
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00158AE0 File Offset: 0x00156CE0
		[Command]
		public void NavigateRn()
		{
			if (this.SelectedItem != null && this.SelectedItem.DocumentId != null)
			{
				this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(this.SelectedItem.DocumentId.Value));
				return;
			}
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00158B34 File Offset: 0x00156D34
		public override void OnLoad()
		{
			InvoiceBaseViewModel.<OnLoad>d__61 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<InvoiceBaseViewModel.<OnLoad>d__61>(ref <OnLoad>d__);
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x00158B6C File Offset: 0x00156D6C
		public void SetDocumentIdToLoad(int documentId)
		{
			this._documentId = documentId;
			this.SetViewName("Loading");
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00158B8C File Offset: 0x00156D8C
		private string GetDocumentTypeResourceName()
		{
			string result;
			if (this.Document is VATInvoice)
			{
				result = "VatInvoice";
			}
			else if (!(this.Document is PackingList))
			{
				if (this.Document is WorksList)
				{
					result = "PrintWorks";
				}
				else
				{
					result = "Invoice";
				}
			}
			else
			{
				result = "PackingList";
			}
			return result;
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00158BE8 File Offset: 0x00156DE8
		[Command]
		public void CustomerPopupClosed(ClosePopupEventArgs e)
		{
			InvoiceBaseViewModel.<CustomerPopupClosed>d__64 <CustomerPopupClosed>d__;
			<CustomerPopupClosed>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CustomerPopupClosed>d__.<>4__this = this;
			<CustomerPopupClosed>d__.e = e;
			<CustomerPopupClosed>d__.<>1__state = -1;
			<CustomerPopupClosed>d__.<>t__builder.Start<InvoiceBaseViewModel.<CustomerPopupClosed>d__64>(ref <CustomerPopupClosed>d__);
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x0007E558 File Offset: 0x0007C758
		protected virtual Task UpdateCustomer()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00158C28 File Offset: 0x00156E28
		[CompilerGenerated]
		private Task<IEnumerable<PaymentDetails>> <LoadCustomerPaymentDetails>b__33_0()
		{
			return ClientsModel.GetCustomerPaymentDetails(this.CustomerId);
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x00158C40 File Offset: 0x00156E40
		[CompilerGenerated]
		private bool <SetSeller>b__40_0(SellerPaymentDetails d)
		{
			return d.Id == this.Document.Seller.Id;
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x040034C8 RID: 13512
		protected readonly IInvoiceStrategy InvoiceStrategy;

		// Token: 0x040034C9 RID: 13513
		protected readonly INavigationService _navigationService;

		// Token: 0x040034CA RID: 13514
		protected readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040034CB RID: 13515
		protected readonly IToasterService _toasterService;

		// Token: 0x040034CC RID: 13516
		protected readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x040034CD RID: 13517
		protected int _documentId;

		// Token: 0x040034CE RID: 13518
		[CompilerGenerated]
		private IInvoice <Document>k__BackingField;

		// Token: 0x040034CF RID: 13519
		[CompilerGenerated]
		private IInvoiceItem <SelectedItem>k__BackingField;

		// Token: 0x040034D0 RID: 13520
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x040034D1 RID: 13521
		[CompilerGenerated]
		private List<SellerPaymentDetails> <CompanyPaymentDetails>k__BackingField;

		// Token: 0x040034D2 RID: 13522
		[CompilerGenerated]
		private List<PaymentDetails> <CustomerPaymentDetails>k__BackingField;

		// Token: 0x040034D3 RID: 13523
		[CompilerGenerated]
		private bool <PaymentDetailsNotFound>k__BackingField;

		// Token: 0x02000AFB RID: 2811
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadExistDocument>d__27 : IAsyncStateMachine
		{
			// Token: 0x06004FB0 RID: 20400 RVA: 0x00158C68 File Offset: 0x00156E68
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_C5;
						}
						invoiceBaseViewModel.ShowWait();
						awaiter = invoiceBaseViewModel.LoadDocument(this.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<LoadExistDocument>d__27>(ref awaiter, ref this);
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
					invoiceBaseViewModel.CustomerId = invoiceBaseViewModel.Document.Customer.CustomerId;
					awaiter = invoiceBaseViewModel.LoadCustomerPaymentDetails().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<LoadExistDocument>d__27>(ref awaiter, ref this);
						return;
					}
					IL_C5:
					awaiter.GetResult();
					invoiceBaseViewModel.HideWait();
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

			// Token: 0x06004FB1 RID: 20401 RVA: 0x00158DA4 File Offset: 0x00156FA4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034D4 RID: 13524
			public int <>1__state;

			// Token: 0x040034D5 RID: 13525
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040034D6 RID: 13526
			public InvoiceBaseViewModel <>4__this;

			// Token: 0x040034D7 RID: 13527
			public int documentId;

			// Token: 0x040034D8 RID: 13528
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000AFC RID: 2812
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__28 : IAsyncStateMachine
		{
			// Token: 0x06004FB2 RID: 20402 RVA: 0x00158DC0 File Offset: 0x00156FC0
			void IAsyncStateMachine.MoveNext()
			{
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					invoiceBaseViewModel.SetSeller();
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

			// Token: 0x06004FB3 RID: 20403 RVA: 0x00158E18 File Offset: 0x00157018
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034D9 RID: 13529
			public int <>1__state;

			// Token: 0x040034DA RID: 13530
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040034DB RID: 13531
			public InvoiceBaseViewModel <>4__this;
		}

		// Token: 0x02000AFD RID: 2813
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectCustomerFromList>d__31 : IAsyncStateMachine
		{
			// Token: 0x06004FB4 RID: 20404 RVA: 0x00158E34 File Offset: 0x00157034
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						invoiceBaseViewModel.CustomerId = this.customer.Id;
						awaiter = invoiceBaseViewModel.LoadCustomerPaymentDetails().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<SelectCustomerFromList>d__31>(ref awaiter, ref this);
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

			// Token: 0x06004FB5 RID: 20405 RVA: 0x00158EF8 File Offset: 0x001570F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034DC RID: 13532
			public int <>1__state;

			// Token: 0x040034DD RID: 13533
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034DE RID: 13534
			public InvoiceBaseViewModel <>4__this;

			// Token: 0x040034DF RID: 13535
			public ICustomer customer;

			// Token: 0x040034E0 RID: 13536
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000AFE RID: 2814
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DataRefresh>d__32 : IAsyncStateMachine
		{
			// Token: 0x06004FB6 RID: 20406 RVA: 0x00158F14 File Offset: 0x00157114
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.<id>5__2 = 0;
						if (invoiceBaseViewModel.Document.Customer != null)
						{
							this.<id>5__2 = invoiceBaseViewModel.Document.Customer.Id;
						}
						awaiter = invoiceBaseViewModel.LoadCustomerPaymentDetails().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<DataRefresh>d__32>(ref awaiter, ref this);
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
					if (this.<id>5__2 != 0)
					{
						invoiceBaseViewModel.SetCustomerPaymentDetails(this.<id>5__2);
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

			// Token: 0x06004FB7 RID: 20407 RVA: 0x00159004 File Offset: 0x00157204
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034E1 RID: 13537
			public int <>1__state;

			// Token: 0x040034E2 RID: 13538
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034E3 RID: 13539
			public InvoiceBaseViewModel <>4__this;

			// Token: 0x040034E4 RID: 13540
			private int <id>5__2;

			// Token: 0x040034E5 RID: 13541
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000AFF RID: 2815
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCustomerPaymentDetails>d__33 : IAsyncStateMachine
		{
			// Token: 0x06004FB8 RID: 20408 RVA: 0x00159020 File Offset: 0x00157220
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<PaymentDetails>> awaiter;
					if (num != 0)
					{
						IPaymentDetails customer = invoiceBaseViewModel.Document.Customer;
						this.<paymentDetailsId>5__2 = ((customer != null) ? customer.Id : 0);
						awaiter = Task.Run<IEnumerable<PaymentDetails>>(() => ClientsModel.GetCustomerPaymentDetails(base.CustomerId)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<PaymentDetails>>, InvoiceBaseViewModel.<LoadCustomerPaymentDetails>d__33>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<PaymentDetails>>);
						this.<>1__state = -1;
					}
					IEnumerable<PaymentDetails> result = awaiter.GetResult();
					invoiceBaseViewModel.CustomerPaymentDetails = new List<PaymentDetails>(result);
					invoiceBaseViewModel.SetCustomerPaymentDetails(this.<paymentDetailsId>5__2);
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

			// Token: 0x06004FB9 RID: 20409 RVA: 0x00159118 File Offset: 0x00157318
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034E6 RID: 13542
			public int <>1__state;

			// Token: 0x040034E7 RID: 13543
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040034E8 RID: 13544
			public InvoiceBaseViewModel <>4__this;

			// Token: 0x040034E9 RID: 13545
			private int <paymentDetailsId>5__2;

			// Token: 0x040034EA RID: 13546
			private TaskAwaiter<IEnumerable<PaymentDetails>> <>u__1;
		}

		// Token: 0x02000B00 RID: 2816
		[CompilerGenerated]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x06004FBA RID: 20410 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x06004FBB RID: 20411 RVA: 0x00159134 File Offset: 0x00157334
			internal bool <SetCustomerPaymentDetails>b__0(PaymentDetails d)
			{
				return d.Id == this.paymentDetailsId;
			}

			// Token: 0x040034EB RID: 13547
			public int paymentDetailsId;
		}

		// Token: 0x02000B01 RID: 2817
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004FBC RID: 20412 RVA: 0x00159150 File Offset: 0x00157350
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004FBD RID: 20413 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004FBE RID: 20414 RVA: 0x00159168 File Offset: 0x00157368
			internal Task<IEnumerable<SellerPaymentDetails>> <LoadCompanyPaymentDetails>b__39_0()
			{
				return CompaniesModel.GetCompanyPaymentDetails(null);
			}

			// Token: 0x040034EC RID: 13548
			public static readonly InvoiceBaseViewModel.<>c <>9 = new InvoiceBaseViewModel.<>c();

			// Token: 0x040034ED RID: 13549
			public static Func<Task<IEnumerable<SellerPaymentDetails>>> <>9__39_0;
		}

		// Token: 0x02000B02 RID: 2818
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCompanyPaymentDetails>d__39 : IAsyncStateMachine
		{
			// Token: 0x06004FBF RID: 20415 RVA: 0x00159184 File Offset: 0x00157384
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<SellerPaymentDetails>> awaiter;
					if (num != 0)
					{
						if (invoiceBaseViewModel.CompanyPaymentDetails != null)
						{
							goto IL_9F;
						}
						awaiter = Task.Run<IEnumerable<SellerPaymentDetails>>(new Func<Task<IEnumerable<SellerPaymentDetails>>>(InvoiceBaseViewModel.<>c.<>9.<LoadCompanyPaymentDetails>b__39_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<SellerPaymentDetails>>, InvoiceBaseViewModel.<LoadCompanyPaymentDetails>d__39>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<SellerPaymentDetails>>);
						this.<>1__state = -1;
					}
					IEnumerable<SellerPaymentDetails> result = awaiter.GetResult();
					invoiceBaseViewModel.CompanyPaymentDetails = new List<SellerPaymentDetails>(result);
					IL_9F:;
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

			// Token: 0x06004FC0 RID: 20416 RVA: 0x00159270 File Offset: 0x00157470
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034EE RID: 13550
			public int <>1__state;

			// Token: 0x040034EF RID: 13551
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040034F0 RID: 13552
			public InvoiceBaseViewModel <>4__this;

			// Token: 0x040034F1 RID: 13553
			private TaskAwaiter<IEnumerable<SellerPaymentDetails>> <>u__1;
		}

		// Token: 0x02000B03 RID: 2819
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06004FC1 RID: 20417 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x06004FC2 RID: 20418 RVA: 0x0015928C File Offset: 0x0015748C
			internal bool <InvoiceItemAdd>b__0(IInvoiceItem i)
			{
				return i.Name == this.item.Name;
			}

			// Token: 0x040034F2 RID: 13554
			public IInvoiceItem item;
		}

		// Token: 0x02000B04 RID: 2820
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__61 : IAsyncStateMachine
		{
			// Token: 0x06004FC3 RID: 20419 RVA: 0x001592B0 File Offset: 0x001574B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						goto IL_163;
					}
					goto IL_1DE;
					for (;;)
					{
						IL_18C:
						if (invoiceBaseViewModel.Document != null)
						{
							goto IL_105;
						}
						IL_136:
						while (invoiceBaseViewModel.Document != null)
						{
							IL_F3:
							while (invoiceBaseViewModel.Document.Id == 0)
							{
								IL_DE:
								while (invoiceBaseViewModel.Document.Seller != null)
								{
									for (;;)
									{
										IInvoice document = invoiceBaseViewModel.Document;
										if (document != null)
										{
											document.SetNum();
											uint num2;
											switch ((num2 = (num2 * 3702621786U ^ 341711057U ^ 709628724U)) % 36U)
											{
											case 0U:
												goto IL_143;
											case 1U:
												goto IL_112;
											case 3U:
												goto IL_247;
											case 4U:
												goto IL_261;
											case 5U:
												goto IL_241;
											case 6U:
												goto IL_234;
											case 7U:
												goto IL_136;
											case 8U:
												goto IL_27D;
											case 9U:
												goto IL_199;
											case 10U:
												goto IL_203;
											case 11U:
												goto IL_169;
											case 12U:
												continue;
											case 13U:
												goto IL_F3;
											case 14U:
												goto IL_105;
											case 15U:
												goto IL_21F;
											case 16U:
												goto IL_1C1;
											case 17U:
												goto IL_1F3;
											case 18U:
												goto IL_185;
											case 19U:
												goto IL_211;
											case 20U:
												goto IL_216;
											case 21U:
												goto IL_1DE;
											case 22U:
												goto IL_1B5;
											case 23U:
												goto IL_1A4;
											case 24U:
												goto IL_DE;
											case 25U:
												goto IL_226;
											case 26U:
												goto IL_17C;
											case 27U:
												goto IL_24F;
											case 28U:
												goto IL_1D3;
											case 29U:
												goto IL_239;
											case 31U:
											case 34U:
												goto IL_163;
											case 32U:
												goto IL_120;
											case 33U:
												goto IL_18C;
											case 35U:
												goto IL_1CA;
											}
											goto Block_5;
										}
										goto IL_238;
									}
								}
								break;
							}
							break;
						}
						goto Block_8;
						IL_105:
						if (invoiceBaseViewModel.Document.Id != 0)
						{
							goto IL_136;
						}
						IL_112:
						if (invoiceBaseViewModel.CompanyPaymentDetails.Count != 1)
						{
							goto IL_136;
						}
						IL_120:
						invoiceBaseViewModel.Document.Seller = invoiceBaseViewModel.CompanyPaymentDetails.FirstOrDefault<SellerPaymentDetails>();
						goto IL_136;
					}
					Block_5:
					goto IL_284;
					Block_8:
					IL_238:
					IL_239:
					if (invoiceBaseViewModel._documentId != 0)
					{
						goto IL_247;
					}
					IL_241:
					invoiceBaseViewModel.SetSeller();
					IL_247:
					if (invoiceBaseViewModel.Document == null)
					{
						goto IL_27D;
					}
					IL_24F:
					if (string.IsNullOrEmpty(invoiceBaseViewModel.Document.Num))
					{
						goto IL_27D;
					}
					IL_261:
					invoiceBaseViewModel._navigationService.SetTabHeader(invoiceBaseViewModel.GetDocumentTypeResourceName(), invoiceBaseViewModel.Document.Num);
					IL_27D:
					invoiceBaseViewModel.SetViewLoaded(true);
					IL_284:
					goto IL_29D;
					IL_143:
					TaskAwaiter awaiter = invoiceBaseViewModel.LoadExistDocument(invoiceBaseViewModel._documentId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						goto IL_1F3;
					}
					goto IL_185;
					IL_163:
					if (num != 1)
					{
						goto IL_1A4;
					}
					IL_169:
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter);
					IL_17C:
					int num3 = -1;
					num = -1;
					this.<>1__state = num3;
					IL_185:
					awaiter.GetResult();
					goto IL_18C;
					IL_199:
					if (invoiceBaseViewModel._documentId > 0)
					{
						goto IL_143;
					}
					goto IL_18C;
					IL_1A4:
					invoiceBaseViewModel.<>n__0();
					if (invoiceBaseViewModel.ViewLoaded)
					{
						goto IL_236;
					}
					IL_1B5:
					awaiter = invoiceBaseViewModel.LoadCompanyPaymentDetails().GetAwaiter();
					IL_1C1:
					if (!awaiter.IsCompleted)
					{
						goto IL_216;
					}
					IL_1CA:
					awaiter.GetResult();
					goto IL_199;
					IL_1D3:
					int num4 = -1;
					num = -1;
					this.<>1__state = num4;
					goto IL_1CA;
					IL_1DE:
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter);
					goto IL_1D3;
					IL_1F3:
					this.<>1__state = 1;
					this.<>u__1 = awaiter;
					IL_203:
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<OnLoad>d__61>(ref awaiter, ref this);
					IL_211:
					return;
					IL_216:
					this.<>1__state = 0;
					IL_21F:
					this.<>u__1 = awaiter;
					IL_226:
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<OnLoad>d__61>(ref awaiter, ref this);
					IL_234:
					return;
					IL_236:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_29D:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004FC4 RID: 20420 RVA: 0x0015958C File Offset: 0x0015778C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034F3 RID: 13555
			public int <>1__state;

			// Token: 0x040034F4 RID: 13556
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034F5 RID: 13557
			public InvoiceBaseViewModel <>4__this;

			// Token: 0x040034F6 RID: 13558
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000B05 RID: 2821
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CustomerPopupClosed>d__64 : IAsyncStateMachine
		{
			// Token: 0x06004FC5 RID: 20421 RVA: 0x001595A8 File Offset: 0x001577A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceBaseViewModel invoiceBaseViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							if (this.e.CloseMode == PopupCloseMode.Normal)
							{
								if (invoiceBaseViewModel.Document.State == 1)
								{
									if (invoiceBaseViewModel._ascMessageBoxService.ShowMessageBox("Обновить реквизиты?", "Реквизиты изменены", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
									{
										awaiter = invoiceBaseViewModel.LoadExistDocument(invoiceBaseViewModel._documentId).GetAwaiter();
										if (awaiter.IsCompleted)
										{
											goto IL_8F;
										}
										this.<>1__state = 1;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<CustomerPopupClosed>d__64>(ref awaiter, ref this);
										return;
									}
									else
									{
										awaiter = invoiceBaseViewModel.UpdateCustomer().GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											this.<>1__state = 0;
											this.<>u__1 = awaiter;
											this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceBaseViewModel.<CustomerPopupClosed>d__64>(ref awaiter, ref this);
											return;
										}
										goto IL_10E;
									}
								}
							}
							goto IL_12E;
						}
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						IL_8F:
						awaiter.GetResult();
						goto IL_115;
					}
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter);
					this.<>1__state = -1;
					IL_10E:
					awaiter.GetResult();
					IL_115:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_12E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004FC6 RID: 20422 RVA: 0x00159714 File Offset: 0x00157914
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034F7 RID: 13559
			public int <>1__state;

			// Token: 0x040034F8 RID: 13560
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034F9 RID: 13561
			public ClosePopupEventArgs e;

			// Token: 0x040034FA RID: 13562
			public InvoiceBaseViewModel <>4__this;

			// Token: 0x040034FB RID: 13563
			private TaskAwaiter <>u__1;
		}
	}
}
