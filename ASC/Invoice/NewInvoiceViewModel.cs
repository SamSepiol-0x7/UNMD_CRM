using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.Invoice
{
	// Token: 0x02000B08 RID: 2824
	internal sealed class NewInvoiceViewModel : InvoiceBaseViewModel
	{
		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x0015986C File Offset: 0x00157A6C
		// (set) Token: 0x06004FCE RID: 20430 RVA: 0x00159880 File Offset: 0x00157A80
		public Dictionary<ASC.Common.Models.InvoiceModel.InvoicePrintTypes, string> InvoicePrintTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoicePrintTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<InvoicePrintTypes>k__BackingField, value))
				{
					return;
				}
				this.<InvoicePrintTypes>k__BackingField = value;
				this.RaisePropertyChanged("InvoicePrintTypes");
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x001598B0 File Offset: 0x00157AB0
		// (set) Token: 0x06004FD0 RID: 20432 RVA: 0x001598C4 File Offset: 0x00157AC4
		public Dictionary<ASC.Common.Models.InvoiceModel.VatInvoiceType, string> VatInvoicePrintTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<VatInvoicePrintTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<VatInvoicePrintTypes>k__BackingField, value))
				{
					return;
				}
				this.<VatInvoicePrintTypes>k__BackingField = value;
				this.RaisePropertyChanged("VatInvoicePrintTypes");
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x001598F4 File Offset: 0x00157AF4
		// (set) Token: 0x06004FD2 RID: 20434 RVA: 0x00159908 File Offset: 0x00157B08
		public Dictionary<ASC.Common.Models.InvoiceModel.PackingListPrintTypes, string> PackingListPrintTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<PackingListPrintTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<PackingListPrintTypes>k__BackingField, value))
				{
					return;
				}
				this.<PackingListPrintTypes>k__BackingField = value;
				this.RaisePropertyChanged("PackingListPrintTypes");
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x00159938 File Offset: 0x00157B38
		// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x0015994C File Offset: 0x00157B4C
		public Dictionary<ASC.Common.Models.InvoiceModel.WorksListPrintTypes, string> WorksListPrintTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksListPrintTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<WorksListPrintTypes>k__BackingField, value))
				{
					return;
				}
				this.<WorksListPrintTypes>k__BackingField = value;
				this.RaisePropertyChanged("WorksListPrintTypes");
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x0015997C File Offset: 0x00157B7C
		// (set) Token: 0x06004FD6 RID: 20438 RVA: 0x00159990 File Offset: 0x00157B90
		public ASC.Common.Models.InvoiceModel.InvoicePrintTypes SelectedInvoicePrintType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedInvoicePrintType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedInvoicePrintType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedInvoicePrintType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedInvoicePrintType");
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x001599BC File Offset: 0x00157BBC
		// (set) Token: 0x06004FD8 RID: 20440 RVA: 0x001599D0 File Offset: 0x00157BD0
		public ASC.Common.Models.InvoiceModel.VatInvoiceType SelectedVatInvoicePrintType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedVatInvoicePrintType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedVatInvoicePrintType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedVatInvoicePrintType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedVatInvoicePrintType");
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x001599FC File Offset: 0x00157BFC
		// (set) Token: 0x06004FDA RID: 20442 RVA: 0x00159A10 File Offset: 0x00157C10
		public ASC.Common.Models.InvoiceModel.PackingListPrintTypes SelectedPackingListPrintType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPackingListPrintType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedPackingListPrintType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedPackingListPrintType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPackingListPrintType");
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x00159A3C File Offset: 0x00157C3C
		// (set) Token: 0x06004FDC RID: 20444 RVA: 0x00159A50 File Offset: 0x00157C50
		public ASC.Common.Models.InvoiceModel.WorksListPrintTypes SelectedWorksListPrintType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedWorksListPrintType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedWorksListPrintType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedWorksListPrintType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedWorksListPrintType");
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x00159A7C File Offset: 0x00157C7C
		// (set) Token: 0x06004FDE RID: 20446 RVA: 0x00159A90 File Offset: 0x00157C90
		public int InvoiceCopies
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceCopies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InvoiceCopies>k__BackingField == value)
				{
					return;
				}
				this.<InvoiceCopies>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceCopies");
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x00159ABC File Offset: 0x00157CBC
		// (set) Token: 0x06004FE0 RID: 20448 RVA: 0x00159AD0 File Offset: 0x00157CD0
		public int VatInvoiceCopies
		{
			[CompilerGenerated]
			get
			{
				return this.<VatInvoiceCopies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<VatInvoiceCopies>k__BackingField == value)
				{
					return;
				}
				this.<VatInvoiceCopies>k__BackingField = value;
				this.RaisePropertyChanged("VatInvoiceCopies");
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x00159AFC File Offset: 0x00157CFC
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x00159B10 File Offset: 0x00157D10
		public int PackingListCopies
		{
			[CompilerGenerated]
			get
			{
				return this.<PackingListCopies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PackingListCopies>k__BackingField == value)
				{
					return;
				}
				this.<PackingListCopies>k__BackingField = value;
				this.RaisePropertyChanged("PackingListCopies");
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x00159B3C File Offset: 0x00157D3C
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x00159B50 File Offset: 0x00157D50
		public int WorksListCopies
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksListCopies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WorksListCopies>k__BackingField == value)
				{
					return;
				}
				this.<WorksListCopies>k__BackingField = value;
				this.RaisePropertyChanged("WorksListCopies");
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x00159B7C File Offset: 0x00157D7C
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x00159B90 File Offset: 0x00157D90
		public bool PrintInvoice
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintInvoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintInvoice>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -877097201;
				IL_10:
				switch ((num ^ -1946526972) % 4)
				{
				case 0:
					IL_2F:
					this.<PrintInvoice>k__BackingField = value;
					this.RaisePropertyChanged("PrintInvoice");
					num = -2056748471;
					goto IL_10;
				case 2:
					goto IL_0B;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x00159BE8 File Offset: 0x00157DE8
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x00159BFC File Offset: 0x00157DFC
		public bool PrintVatInvoice
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintVatInvoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintVatInvoice>k__BackingField == value)
				{
					return;
				}
				this.<PrintVatInvoice>k__BackingField = value;
				this.RaisePropertyChanged("PrintVatInvoice");
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x00159C28 File Offset: 0x00157E28
		// (set) Token: 0x06004FEA RID: 20458 RVA: 0x00159C3C File Offset: 0x00157E3C
		public bool PrintPacking
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintPacking>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintPacking>k__BackingField == value)
				{
					return;
				}
				this.<PrintPacking>k__BackingField = value;
				this.RaisePropertyChanged("PrintPacking");
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x00159C68 File Offset: 0x00157E68
		// (set) Token: 0x06004FEC RID: 20460 RVA: 0x00159C7C File Offset: 0x00157E7C
		public bool PrintWorks
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintWorks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintWorks>k__BackingField == value)
				{
					return;
				}
				this.<PrintWorks>k__BackingField = value;
				this.RaisePropertyChanged("PrintWorks");
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x00159CA8 File Offset: 0x00157EA8
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x00159CBC File Offset: 0x00157EBC
		public IVATInvoice VATInvoice
		{
			[CompilerGenerated]
			get
			{
				return this.<VATInvoice>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<VATInvoice>k__BackingField, value))
				{
					return;
				}
				this.<VATInvoice>k__BackingField = value;
				this.RaisePropertyChanged("VATInvoice");
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x00159CEC File Offset: 0x00157EEC
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x00159D00 File Offset: 0x00157F00
		public IPackingList PackingList
		{
			[CompilerGenerated]
			get
			{
				return this.<PackingList>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<PackingList>k__BackingField, value))
				{
					return;
				}
				this.<PackingList>k__BackingField = value;
				this.RaisePropertyChanged("PackingList");
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x00159D30 File Offset: 0x00157F30
		// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x00159D44 File Offset: 0x00157F44
		public IWorksList WorksList
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksList>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<WorksList>k__BackingField, value))
				{
					return;
				}
				this.<WorksList>k__BackingField = value;
				this.RaisePropertyChanged("WorksList");
			}
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00159D74 File Offset: 0x00157F74
		private void IoC()
		{
			this._invoiceModel = Bootstrapper.Container.Resolve<IInvoiceModel>();
			this._invoiceService = Bootstrapper.Container.Resolve<IInvoiceService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00159DB4 File Offset: 0x00157FB4
		public NewInvoiceViewModel(IInvoiceModel invoiceModel, IInvoiceService invoiceService, IAscMessageBoxService ascMessageBoxService)
		{
			this._invoiceModel = invoiceModel;
			this._invoiceService = invoiceService;
			this._ascMessageBoxService = ascMessageBoxService;
			base.Document = this.InvoiceStrategy.Create(typeof(Invoice));
			this.SetViewName("NewInvoice");
			this.CreateChildDocuments();
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00159E2C File Offset: 0x0015802C
		public NewInvoiceViewModel(IEnumerable<workshop> repairs, int customerId)
		{
			this.IoC();
			this.SetViewName("NewInvoice");
			base.Document = this.InvoiceStrategy.Create(typeof(Invoice));
			base.SelectCustomerFromList(new Customer
			{
				Id = customerId
			});
			this.CreateChildDocuments();
			foreach (workshop workshop in repairs)
			{
				this.AddItem(this.ConstructName(workshop), 1, workshop.real_repair_cost, new int?(workshop.id));
			}
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00159EFC File Offset: 0x001580FC
		private string ConstructName(workshop repair)
		{
			string result;
			try
			{
				string text = (repair.cartridge != null) ? repair.c_workshop.cartridge_cards.name : repair.device_models.name;
				result = string.Concat(new string[]
				{
					Lang.t("Repair"),
					" ",
					repair.device_makers.name,
					" ",
					text
				});
			}
			catch (Exception)
			{
				result = Lang.t("Repair") + " ";
			}
			return result;
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x00159FA0 File Offset: 0x001581A0
		public NewInvoiceViewModel(DocsList doc)
		{
			this.IoC();
			base.CustomerId = doc.dealer.Value;
			base.Document = this.InvoiceStrategy.Create(typeof(Invoice));
			this.SetViewName("NewInvoice");
			this.CreateChildDocuments();
			this.FillInvoiceFromDoc(doc.id);
			base.Document.CalcTotal();
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x0015A034 File Offset: 0x00158234
		public NewInvoiceViewModel(IStoreDocument doc)
		{
			this.IoC();
			base.CustomerId = doc.DealerId.Value;
			base.Document = this.InvoiceStrategy.Create(typeof(Invoice));
			this.SetViewName("NewInvoice");
			this.CreateChildDocuments();
			this.FillInvoiceFromDoc(doc.Id);
			base.Document.CalcTotal();
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x0015A0C8 File Offset: 0x001582C8
		private void CreateChildDocuments()
		{
			this.VATInvoice = new VATInvoice(Auth.CurrencyModel.SelectedCurrency);
			this.PackingList = new PackingList();
			this.WorksList = new WorksList();
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x0015A100 File Offset: 0x00158300
		private void FillInvoiceFromDoc(int documentId)
		{
			NewInvoiceViewModel.<FillInvoiceFromDoc>d__86 <FillInvoiceFromDoc>d__;
			<FillInvoiceFromDoc>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FillInvoiceFromDoc>d__.<>4__this = this;
			<FillInvoiceFromDoc>d__.documentId = documentId;
			<FillInvoiceFromDoc>d__.<>1__state = -1;
			<FillInvoiceFromDoc>d__.<>t__builder.Start<NewInvoiceViewModel.<FillInvoiceFromDoc>d__86>(ref <FillInvoiceFromDoc>d__);
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x0015A140 File Offset: 0x00158340
		private void LoadChildDocuments()
		{
			NewInvoiceViewModel.<LoadChildDocuments>d__87 <LoadChildDocuments>d__;
			<LoadChildDocuments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadChildDocuments>d__.<>4__this = this;
			<LoadChildDocuments>d__.<>1__state = -1;
			<LoadChildDocuments>d__.<>t__builder.Start<NewInvoiceViewModel.<LoadChildDocuments>d__87>(ref <LoadChildDocuments>d__);
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x0015A178 File Offset: 0x00158378
		[Command]
		public void CreateDocument()
		{
			NewInvoiceViewModel.<CreateDocument>d__88 <CreateDocument>d__;
			<CreateDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateDocument>d__.<>4__this = this;
			<CreateDocument>d__.<>1__state = -1;
			<CreateDocument>d__.<>t__builder.Start<NewInvoiceViewModel.<CreateDocument>d__88>(ref <CreateDocument>d__);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x0015A1B0 File Offset: 0x001583B0
		[Command]
		public void ShowCreateDocument()
		{
			if (!base.CheckFields(base.Document))
			{
				return;
			}
			this.GetPrintTypes();
			this.VATInvoice.FillFromInvoice(base.Document);
			this.VATInvoice.SetNum();
			this.PackingList.FillFromInvoice(base.Document);
			this.PackingList.SetNum();
			this.WorksList.FillFromInvoice(base.Document);
			this.WorksList.SetNum();
			this._windowedDocumentService.ShowNewDocument("InvoicePreviewView", this, null, null);
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x0015A23C File Offset: 0x0015843C
		private void GetPrintTypes()
		{
			this.InvoicePrintTypes = this._invoiceModel.GetInvoicePrintTypes();
			this.VatInvoicePrintTypes = this._invoiceModel.GetVatInvoiceTypes();
			this.PackingListPrintTypes = this._invoiceModel.GetPackingListPrintTypes();
			this.WorksListPrintTypes = this._invoiceModel.GetWorksListPrintTypes();
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x0015A290 File Offset: 0x00158490
		[Command]
		public void ShowPrint()
		{
			this.GetPrintTypes();
			this._windowedDocumentService.ShowNewDocument("InvoicePreviewView", this, null, null);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x0015A2B8 File Offset: 0x001584B8
		[Command]
		public override void Print()
		{
			NewInvoiceViewModel.<Print>d__92 <Print>d__;
			<Print>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Print>d__.<>4__this = this;
			<Print>d__.<>1__state = -1;
			<Print>d__.<>t__builder.Start<NewInvoiceViewModel.<Print>d__92>(ref <Print>d__);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x0015A2F0 File Offset: 0x001584F0
		[Command]
		public void Preview()
		{
			if (this.VATInvoice != null && this.VATInvoice.Id == 0)
			{
				this.VATInvoice.FillFromInvoice(base.Document);
			}
			if (this.PackingList != null && this.PackingList.Id == 0)
			{
				this.PackingList.FillFromInvoice(base.Document);
			}
			if (this.WorksList != null && this.WorksList.Id == 0)
			{
				this.WorksList.FillFromInvoice(base.Document);
			}
			this.Print();
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x0015A378 File Offset: 0x00158578
		private Task AddPages(XtraReport report, IInvoice invoice, int copies, string templateName)
		{
			NewInvoiceViewModel.<AddPages>d__94 <AddPages>d__;
			<AddPages>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AddPages>d__.report = report;
			<AddPages>d__.invoice = invoice;
			<AddPages>d__.copies = copies;
			<AddPages>d__.templateName = templateName;
			<AddPages>d__.<>1__state = -1;
			<AddPages>d__.<>t__builder.Start<NewInvoiceViewModel.<AddPages>d__94>(ref <AddPages>d__);
			return <AddPages>d__.<>t__builder.Task;
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x0015A3D4 File Offset: 0x001585D4
		public override Task LoadDocument(int id)
		{
			NewInvoiceViewModel.<LoadDocument>d__95 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.id = id;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<NewInvoiceViewModel.<LoadDocument>d__95>(ref <LoadDocument>d__);
			return <LoadDocument>d__.<>t__builder.Task;
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x0015A420 File Offset: 0x00158620
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x0015A438 File Offset: 0x00158638
		[Command]
		public void InvoicePaid()
		{
			NewInvoiceViewModel.<InvoicePaid>d__97 <InvoicePaid>d__;
			<InvoicePaid>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InvoicePaid>d__.<>4__this = this;
			<InvoicePaid>d__.<>1__state = -1;
			<InvoicePaid>d__.<>t__builder.Start<NewInvoiceViewModel.<InvoicePaid>d__97>(ref <InvoicePaid>d__);
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x0015A470 File Offset: 0x00158670
		public bool CanInvoicePaid()
		{
			return OfflineData.Instance.Employee.Can(65, 0) && base.Document != null && base.Document.Id > 0 && base.Document.State == 1;
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x0015A4B8 File Offset: 0x001586B8
		[AsyncCommand]
		public Task ArchiveInvoice()
		{
			NewInvoiceViewModel.<ArchiveInvoice>d__99 <ArchiveInvoice>d__;
			<ArchiveInvoice>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ArchiveInvoice>d__.<>4__this = this;
			<ArchiveInvoice>d__.<>1__state = -1;
			<ArchiveInvoice>d__.<>t__builder.Start<NewInvoiceViewModel.<ArchiveInvoice>d__99>(ref <ArchiveInvoice>d__);
			return <ArchiveInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x0015A4FC File Offset: 0x001586FC
		public bool CanArchiveInvoice()
		{
			return this.CanInvoicePaid();
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x0015A510 File Offset: 0x00158710
		[Command]
		public void IncrementVATInvoiceNum()
		{
			this.VATInvoice.IncrementNum();
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x0015A528 File Offset: 0x00158728
		public bool CanIncrementVATInvoiceNum()
		{
			return this.VATInvoice != null;
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x0015A540 File Offset: 0x00158740
		[Command]
		public void IncrementPackingListNum()
		{
			IPackingList packingList = this.PackingList;
			if (packingList == null)
			{
				return;
			}
			packingList.IncrementNum();
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x0015A560 File Offset: 0x00158760
		[Command]
		public void IncrementWorksListNum()
		{
			IWorksList worksList = this.WorksList;
			if (worksList == null)
			{
				return;
			}
			worksList.IncrementNum();
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x0015A580 File Offset: 0x00158780
		[Command]
		public override void SendEmail()
		{
			NewInvoiceViewModel.<SendEmail>d__105 <SendEmail>d__;
			<SendEmail>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendEmail>d__.<>4__this = this;
			<SendEmail>d__.<>1__state = -1;
			<SendEmail>d__.<>t__builder.Start<NewInvoiceViewModel.<SendEmail>d__105>(ref <SendEmail>d__);
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x0015A5B8 File Offset: 0x001587B8
		public void AddItem(string itemName, int count, decimal amount, int? repairId)
		{
			InvoiceItem invoiceItem = new InvoiceItem
			{
				Name = itemName,
				Count = (double)count,
				Units = this._invoiceModel.GetUnits().FirstOrDefault<string>(),
				Price = amount,
				RepairId = repairId
			};
			invoiceItem.Calculate();
			base.Document.Items.Add(invoiceItem);
			base.Document.CalcTotal();
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x0015A624 File Offset: 0x00158824
		protected override Task UpdateCustomer()
		{
			NewInvoiceViewModel.<UpdateCustomer>d__107 <UpdateCustomer>d__;
			<UpdateCustomer>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateCustomer>d__.<>4__this = this;
			<UpdateCustomer>d__.<>1__state = -1;
			<UpdateCustomer>d__.<>t__builder.Start<NewInvoiceViewModel.<UpdateCustomer>d__107>(ref <UpdateCustomer>d__);
			return <UpdateCustomer>d__.<>t__builder.Task;
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x0015A668 File Offset: 0x00158868
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.Print();
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x0015A67C File Offset: 0x0015887C
		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__1(int id)
		{
			return base.LoadDocument(id);
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x0015A690 File Offset: 0x00158890
		[CompilerGenerated]
		private Task<bool> <ArchiveInvoice>b__99_0()
		{
			return base.Document.Archive();
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x0015A6A8 File Offset: 0x001588A8
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__2()
		{
			base.SendEmail();
		}

		// Token: 0x04003500 RID: 13568
		private IInvoiceModel _invoiceModel;

		// Token: 0x04003501 RID: 13569
		private IInvoiceService _invoiceService;

		// Token: 0x04003502 RID: 13570
		private new IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04003503 RID: 13571
		[CompilerGenerated]
		private Dictionary<ASC.Common.Models.InvoiceModel.InvoicePrintTypes, string> <InvoicePrintTypes>k__BackingField;

		// Token: 0x04003504 RID: 13572
		[CompilerGenerated]
		private Dictionary<ASC.Common.Models.InvoiceModel.VatInvoiceType, string> <VatInvoicePrintTypes>k__BackingField;

		// Token: 0x04003505 RID: 13573
		[CompilerGenerated]
		private Dictionary<ASC.Common.Models.InvoiceModel.PackingListPrintTypes, string> <PackingListPrintTypes>k__BackingField;

		// Token: 0x04003506 RID: 13574
		[CompilerGenerated]
		private Dictionary<ASC.Common.Models.InvoiceModel.WorksListPrintTypes, string> <WorksListPrintTypes>k__BackingField;

		// Token: 0x04003507 RID: 13575
		[CompilerGenerated]
		private ASC.Common.Models.InvoiceModel.InvoicePrintTypes <SelectedInvoicePrintType>k__BackingField;

		// Token: 0x04003508 RID: 13576
		[CompilerGenerated]
		private ASC.Common.Models.InvoiceModel.VatInvoiceType <SelectedVatInvoicePrintType>k__BackingField;

		// Token: 0x04003509 RID: 13577
		[CompilerGenerated]
		private ASC.Common.Models.InvoiceModel.PackingListPrintTypes <SelectedPackingListPrintType>k__BackingField;

		// Token: 0x0400350A RID: 13578
		[CompilerGenerated]
		private ASC.Common.Models.InvoiceModel.WorksListPrintTypes <SelectedWorksListPrintType>k__BackingField;

		// Token: 0x0400350B RID: 13579
		[CompilerGenerated]
		private int <InvoiceCopies>k__BackingField = 1;

		// Token: 0x0400350C RID: 13580
		[CompilerGenerated]
		private int <VatInvoiceCopies>k__BackingField = 1;

		// Token: 0x0400350D RID: 13581
		[CompilerGenerated]
		private int <PackingListCopies>k__BackingField = 1;

		// Token: 0x0400350E RID: 13582
		[CompilerGenerated]
		private int <WorksListCopies>k__BackingField = 1;

		// Token: 0x0400350F RID: 13583
		[CompilerGenerated]
		private bool <PrintInvoice>k__BackingField = true;

		// Token: 0x04003510 RID: 13584
		[CompilerGenerated]
		private bool <PrintVatInvoice>k__BackingField;

		// Token: 0x04003511 RID: 13585
		[CompilerGenerated]
		private bool <PrintPacking>k__BackingField;

		// Token: 0x04003512 RID: 13586
		[CompilerGenerated]
		private bool <PrintWorks>k__BackingField;

		// Token: 0x04003513 RID: 13587
		[CompilerGenerated]
		private IVATInvoice <VATInvoice>k__BackingField;

		// Token: 0x04003514 RID: 13588
		[CompilerGenerated]
		private IPackingList <PackingList>k__BackingField;

		// Token: 0x04003515 RID: 13589
		[CompilerGenerated]
		private IWorksList <WorksList>k__BackingField;

		// Token: 0x02000B09 RID: 2825
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <FillInvoiceFromDoc>d__86 : IAsyncStateMachine
		{
			// Token: 0x06005014 RID: 20500 RVA: 0x0015A6BC File Offset: 0x001588BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_sales>> awaiter;
					if (num != 0)
					{
						awaiter = ASC.Models.DocumentsModel.LoadSales(this.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, NewInvoiceViewModel.<FillInvoiceFromDoc>d__86>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_sales>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<store_sales>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							store_sales store_sales = enumerator.Current;
							InvoiceItem invoiceItem = new InvoiceItem
							{
								Name = store_sales.name,
								Count = (double)store_sales.count,
								Units = newInvoiceViewModel._invoiceModel.GetUnits().FirstOrDefault<string>(),
								Price = store_sales.price,
								DocumentId = new int?(this.documentId)
							};
							invoiceItem.Calculate();
							newInvoiceViewModel.Document.Items.Add(invoiceItem);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
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

			// Token: 0x06005015 RID: 20501 RVA: 0x0015A840 File Offset: 0x00158A40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003516 RID: 13590
			public int <>1__state;

			// Token: 0x04003517 RID: 13591
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003518 RID: 13592
			public int documentId;

			// Token: 0x04003519 RID: 13593
			public NewInvoiceViewModel <>4__this;

			// Token: 0x0400351A RID: 13594
			private TaskAwaiter<List<store_sales>> <>u__1;
		}

		// Token: 0x02000B0A RID: 2826
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadChildDocuments>d__87 : IAsyncStateMachine
		{
			// Token: 0x06005016 RID: 20502 RVA: 0x0015A85C File Offset: 0x00158A5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<VATInvoice> awaiter;
					TaskAwaiter<PackingList> awaiter2;
					TaskAwaiter<WorksList> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<VATInvoice>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<PackingList>);
						this.<>1__state = -1;
						goto IL_100;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<WorksList>);
						this.<>1__state = -1;
						goto IL_179;
					default:
						if (newInvoiceViewModel.Document == null)
						{
							goto IL_1B4;
						}
						awaiter = ASC.Models.InvoiceModel.GetVATInvoice(newInvoiceViewModel.Document).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<VATInvoice>, NewInvoiceViewModel.<LoadChildDocuments>d__87>(ref awaiter, ref this);
							return;
						}
						break;
					}
					VATInvoice result = awaiter.GetResult();
					newInvoiceViewModel.VATInvoice = result;
					newInvoiceViewModel.PrintVatInvoice = (newInvoiceViewModel.VATInvoice != null);
					awaiter2 = ASC.Models.InvoiceModel.GetPackingList(newInvoiceViewModel.Document).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PackingList>, NewInvoiceViewModel.<LoadChildDocuments>d__87>(ref awaiter2, ref this);
						return;
					}
					IL_100:
					PackingList result2 = awaiter2.GetResult();
					newInvoiceViewModel.PackingList = result2;
					newInvoiceViewModel.PrintPacking = (newInvoiceViewModel.PackingList != null);
					awaiter3 = ASC.Models.InvoiceModel.GetWorksList(newInvoiceViewModel.Document).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WorksList>, NewInvoiceViewModel.<LoadChildDocuments>d__87>(ref awaiter3, ref this);
						return;
					}
					IL_179:
					WorksList result3 = awaiter3.GetResult();
					newInvoiceViewModel.WorksList = result3;
					newInvoiceViewModel.PrintWorks = (newInvoiceViewModel.WorksList != null);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1B4:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06005017 RID: 20503 RVA: 0x0015AA4C File Offset: 0x00158C4C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400351B RID: 13595
			public int <>1__state;

			// Token: 0x0400351C RID: 13596
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400351D RID: 13597
			public NewInvoiceViewModel <>4__this;

			// Token: 0x0400351E RID: 13598
			private TaskAwaiter<VATInvoice> <>u__1;

			// Token: 0x0400351F RID: 13599
			private TaskAwaiter<PackingList> <>u__2;

			// Token: 0x04003520 RID: 13600
			private TaskAwaiter<WorksList> <>u__3;
		}

		// Token: 0x02000B0B RID: 2827
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateDocument>d__88 : IAsyncStateMachine
		{
			// Token: 0x06005018 RID: 20504 RVA: 0x0015AA68 File Offset: 0x00158C68
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!newInvoiceViewModel.CheckFields(newInvoiceViewModel.Document))
						{
							goto IL_1A2;
						}
						newInvoiceViewModel.Document.Id = ASC.Models.InvoiceModel.CreateInvoice(newInvoiceViewModel.Document);
						newInvoiceViewModel.VATInvoice.FillFromInvoice(newInvoiceViewModel.Document);
						newInvoiceViewModel.PackingList.FillFromInvoice(newInvoiceViewModel.Document);
						newInvoiceViewModel.WorksList.FillFromInvoice(newInvoiceViewModel.Document);
						if (newInvoiceViewModel.PrintVatInvoice)
						{
							newInvoiceViewModel.VATInvoice.Id = ASC.Models.InvoiceModel.CreateVATInvoice(newInvoiceViewModel.VATInvoice);
						}
						if (newInvoiceViewModel.PrintPacking)
						{
							newInvoiceViewModel.PackingList.Id = ASC.Models.InvoiceModel.CreatePackingList(newInvoiceViewModel.PackingList);
						}
						if (newInvoiceViewModel.PrintWorks)
						{
							IAscResult ascResult = newInvoiceViewModel._invoiceService.CreateWorksList(newInvoiceViewModel.WorksList);
							newInvoiceViewModel.WorksList.Id = ascResult.Id;
						}
						bool flag = newInvoiceViewModel.Document.Id > 0;
						newInvoiceViewModel._navigationService.SetTabHeader("Invoice", newInvoiceViewModel.Document.Num);
						if (!flag)
						{
							newInvoiceViewModel._toasterService.Error("");
							goto IL_187;
						}
						awaiter = newInvoiceViewModel.LoadExistDocument(newInvoiceViewModel.Document.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<CreateDocument>d__88>(ref awaiter, ref this);
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
					newInvoiceViewModel._toasterService.Success("");
					IL_187:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1A2:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06005019 RID: 20505 RVA: 0x0015AC48 File Offset: 0x00158E48
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003521 RID: 13601
			public int <>1__state;

			// Token: 0x04003522 RID: 13602
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003523 RID: 13603
			public NewInvoiceViewModel <>4__this;

			// Token: 0x04003524 RID: 13604
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000B0C RID: 2828
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Print>d__92 : IAsyncStateMachine
		{
			// Token: 0x0600501A RID: 20506 RVA: 0x0015AC64 File Offset: 0x00158E64
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_128;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1B8;
					case 3:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_248;
					case 4:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2C5;
					default:
						newInvoiceViewModel.<>n__0();
						this.<invoiceTemplateName>5__2 = string.Format("invoice{0}", (int)newInvoiceViewModel.SelectedInvoicePrintType);
						awaiter = ReportPrintModel.CreateReport(this.<invoiceTemplateName>5__2, newInvoiceViewModel.Document).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewInvoiceViewModel.<Print>d__92>(ref awaiter, ref this);
							return;
						}
						break;
					}
					XtraReport result = awaiter.GetResult();
					this.<report>5__3 = result;
					awaiter2 = newInvoiceViewModel.AddPages(this.<report>5__3, newInvoiceViewModel.Document, newInvoiceViewModel.InvoiceCopies - 1, this.<invoiceTemplateName>5__2).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<Print>d__92>(ref awaiter2, ref this);
						return;
					}
					IL_128:
					awaiter2.GetResult();
					if (!newInvoiceViewModel.PrintVatInvoice)
					{
						goto IL_1BF;
					}
					awaiter2 = newInvoiceViewModel.AddPages(this.<report>5__3, newInvoiceViewModel.VATInvoice, newInvoiceViewModel.VatInvoiceCopies, string.Format("vatinvoice{0}", (int)newInvoiceViewModel.SelectedVatInvoicePrintType)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<Print>d__92>(ref awaiter2, ref this);
						return;
					}
					IL_1B8:
					awaiter2.GetResult();
					IL_1BF:
					if (!newInvoiceViewModel.PrintPacking)
					{
						goto IL_24F;
					}
					awaiter2 = newInvoiceViewModel.AddPages(this.<report>5__3, newInvoiceViewModel.PackingList, newInvoiceViewModel.PackingListCopies, string.Format("p_list{0}", (int)newInvoiceViewModel.SelectedPackingListPrintType)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<Print>d__92>(ref awaiter2, ref this);
						return;
					}
					IL_248:
					awaiter2.GetResult();
					IL_24F:
					if (!newInvoiceViewModel.PrintWorks)
					{
						goto IL_2CC;
					}
					awaiter2 = newInvoiceViewModel.AddPages(this.<report>5__3, newInvoiceViewModel.WorksList, newInvoiceViewModel.WorksListCopies, "w_list0").GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<Print>d__92>(ref awaiter2, ref this);
						return;
					}
					IL_2C5:
					awaiter2.GetResult();
					IL_2CC:
					XtraReport xtraReport = this.<report>5__3;
					if (xtraReport != null)
					{
						xtraReport.ShowRibbonPreview();
					}
					XtraReport xtraReport2 = this.<report>5__3;
					if (xtraReport2 != null)
					{
						xtraReport2.PrintDialog();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<invoiceTemplateName>5__2 = null;
					this.<report>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<invoiceTemplateName>5__2 = null;
				this.<report>5__3 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600501B RID: 20507 RVA: 0x0015AFC8 File Offset: 0x001591C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003525 RID: 13605
			public int <>1__state;

			// Token: 0x04003526 RID: 13606
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003527 RID: 13607
			public NewInvoiceViewModel <>4__this;

			// Token: 0x04003528 RID: 13608
			private string <invoiceTemplateName>5__2;

			// Token: 0x04003529 RID: 13609
			private XtraReport <report>5__3;

			// Token: 0x0400352A RID: 13610
			private TaskAwaiter<XtraReport> <>u__1;

			// Token: 0x0400352B RID: 13611
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000B0D RID: 2829
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddPages>d__94 : IAsyncStateMachine
		{
			// Token: 0x0600501C RID: 20508 RVA: 0x0015AFE4 File Offset: 0x001591E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num == 0)
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
						goto IL_5F;
					}
					this.<i>5__2 = 0;
					IL_31:
					if (this.<i>5__2 >= this.copies)
					{
						goto IL_CA;
					}
					awaiter = ReportPrintModel.CreateReport(this.templateName, this.invoice).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 0;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, NewInvoiceViewModel.<AddPages>d__94>(ref awaiter, ref this);
						return;
					}
					IL_5F:
					XtraReport result = awaiter.GetResult();
					this.report.Pages.AddRange(result.Pages);
					int num2 = this.<i>5__2;
					this.<i>5__2 = num2 + 1;
					goto IL_31;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_CA:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600501D RID: 20509 RVA: 0x0015B0E0 File Offset: 0x001592E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400352C RID: 13612
			public int <>1__state;

			// Token: 0x0400352D RID: 13613
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400352E RID: 13614
			public string templateName;

			// Token: 0x0400352F RID: 13615
			public IInvoice invoice;

			// Token: 0x04003530 RID: 13616
			public XtraReport report;

			// Token: 0x04003531 RID: 13617
			public int copies;

			// Token: 0x04003532 RID: 13618
			private int <i>5__2;

			// Token: 0x04003533 RID: 13619
			private TaskAwaiter<XtraReport> <>u__1;
		}

		// Token: 0x02000B0E RID: 2830
		[CompilerGenerated]
		private sealed class <>c__DisplayClass95_0
		{
			// Token: 0x0600501E RID: 20510 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass95_0()
			{
			}

			// Token: 0x0600501F RID: 20511 RVA: 0x0015B0FC File Offset: 0x001592FC
			internal Task<Invoice> <LoadDocument>b__2()
			{
				return this.<>4__this._invoiceService.GetInvoice(this.id);
			}

			// Token: 0x04003534 RID: 13620
			public NewInvoiceViewModel <>4__this;

			// Token: 0x04003535 RID: 13621
			public int id;
		}

		// Token: 0x02000B0F RID: 2831
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__95 : IAsyncStateMachine
		{
			// Token: 0x06005020 RID: 20512 RVA: 0x0015B120 File Offset: 0x00159320
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<Invoice> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_198;
						}
						this.<>8__1 = new NewInvoiceViewModel.<>c__DisplayClass95_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.id = this.id;
						awaiter2 = Task.Run<Invoice>(new Func<Task<Invoice>>(this.<>8__1.<LoadDocument>b__2)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Invoice>, NewInvoiceViewModel.<LoadDocument>d__95>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Invoice>);
						this.<>1__state = -1;
					}
					Invoice result = awaiter2.GetResult();
					newInvoiceViewModel.Document = result;
					newInvoiceViewModel.RaiseCanExecuteChanged(() => newInvoiceViewModel.InvoicePaid());
					newInvoiceViewModel.RaiseCanExecuteChanged(() => newInvoiceViewModel.ArchiveInvoice());
					newInvoiceViewModel.LoadChildDocuments();
					awaiter = newInvoiceViewModel.<>n__1(this.<>8__1.id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<LoadDocument>d__95>(ref awaiter, ref this);
						return;
					}
					IL_198:
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

			// Token: 0x06005021 RID: 20513 RVA: 0x0015B324 File Offset: 0x00159524
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003536 RID: 13622
			public int <>1__state;

			// Token: 0x04003537 RID: 13623
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003538 RID: 13624
			public NewInvoiceViewModel <>4__this;

			// Token: 0x04003539 RID: 13625
			public int id;

			// Token: 0x0400353A RID: 13626
			private NewInvoiceViewModel.<>c__DisplayClass95_0 <>8__1;

			// Token: 0x0400353B RID: 13627
			private TaskAwaiter<Invoice> <>u__1;

			// Token: 0x0400353C RID: 13628
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000B10 RID: 2832
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <InvoicePaid>d__97 : IAsyncStateMachine
		{
			// Token: 0x06005022 RID: 20514 RVA: 0x0015B340 File Offset: 0x00159540
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					KassaModel kassaModel;
					if (num > 1)
					{
						if (newInvoiceViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("ConfirmInvoicePaid"), Lang.t("InvoicePaid"), MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
						{
							goto IL_152;
						}
						newInvoiceViewModel.ShowWait();
						kassaModel = new KassaModel();
					}
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<int> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_111;
							}
							awaiter2 = kassaModel.MakePko(newInvoiceViewModel.Document).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NewInvoiceViewModel.<InvoicePaid>d__97>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult();
						awaiter = newInvoiceViewModel.LoadExistDocument(newInvoiceViewModel.Document.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<InvoicePaid>d__97>(ref awaiter, ref this);
							return;
						}
						IL_111:
						awaiter.GetResult();
						newInvoiceViewModel._toasterService.Success(Lang.t("Complete"));
					}
					catch (Exception ex)
					{
						newInvoiceViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							newInvoiceViewModel.HideWait();
						}
					}
					IL_152:;
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

			// Token: 0x06005023 RID: 20515 RVA: 0x0015B51C File Offset: 0x0015971C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400353D RID: 13629
			public int <>1__state;

			// Token: 0x0400353E RID: 13630
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400353F RID: 13631
			public NewInvoiceViewModel <>4__this;

			// Token: 0x04003540 RID: 13632
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04003541 RID: 13633
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000B11 RID: 2833
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ArchiveInvoice>d__99 : IAsyncStateMachine
		{
			// Token: 0x06005024 RID: 20516 RVA: 0x0015B538 File Offset: 0x00159738
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						if (newInvoiceViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("InvoiceArchiveNote"), Lang.t("ArchiveConfirm"), MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
						{
							goto IL_151;
						}
						newInvoiceViewModel.ShowWait();
					}
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
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_F0;
							}
							awaiter2 = Task.Run<bool>(() => base.Document.Archive()).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, NewInvoiceViewModel.<ArchiveInvoice>d__99>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult();
						awaiter = newInvoiceViewModel.LoadExistDocument(newInvoiceViewModel.Document.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<ArchiveInvoice>d__99>(ref awaiter, ref this);
							return;
						}
						IL_F0:
						awaiter.GetResult();
						newInvoiceViewModel._toasterService.Success(Lang.t("Success"));
					}
					catch (Exception ex)
					{
						newInvoiceViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							newInvoiceViewModel.HideWait();
						}
					}
					IL_151:;
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

			// Token: 0x06005025 RID: 20517 RVA: 0x0015B710 File Offset: 0x00159910
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003542 RID: 13634
			public int <>1__state;

			// Token: 0x04003543 RID: 13635
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003544 RID: 13636
			public NewInvoiceViewModel <>4__this;

			// Token: 0x04003545 RID: 13637
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x04003546 RID: 13638
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000B12 RID: 2834
		[CompilerGenerated]
		private sealed class <>c__DisplayClass105_0
		{
			// Token: 0x06005026 RID: 20518 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass105_0()
			{
			}

			// Token: 0x06005027 RID: 20519 RVA: 0x0015B72C File Offset: 0x0015992C
			internal EmailViewModel <SendEmail>b__0()
			{
				return new EmailViewModel(this.docs, this.<>4__this.Document.Customer.Email);
			}

			// Token: 0x04003547 RID: 13639
			public List<KeyValuePair<IInvoice, string>> docs;

			// Token: 0x04003548 RID: 13640
			public NewInvoiceViewModel <>4__this;
		}

		// Token: 0x02000B13 RID: 2835
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendEmail>d__105 : IAsyncStateMachine
		{
			// Token: 0x06005028 RID: 20520 RVA: 0x0015B75C File Offset: 0x0015995C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<EmailViewModel> awaiter;
					if (num != 0)
					{
						NewInvoiceViewModel.<>c__DisplayClass105_0 CS$<>8__locals1;
						for (;;)
						{
							IL_233:
							CS$<>8__locals1 = new NewInvoiceViewModel.<>c__DisplayClass105_0();
							for (;;)
							{
								IL_225:
								CS$<>8__locals1.<>4__this = this.<>4__this;
								for (;;)
								{
									IL_21D:
									newInvoiceViewModel.<>n__2();
									for (;;)
									{
										IL_213:
										if (!newInvoiceViewModel.PrintInvoice)
										{
											goto IL_1EC;
										}
										IL_204:
										while (newInvoiceViewModel.Document.Customer != null)
										{
											for (;;)
											{
												IL_1DF:
												CS$<>8__locals1.docs = new List<KeyValuePair<IInvoice, string>>();
												for (;;)
												{
													IL_1D5:
													if (newInvoiceViewModel.PrintInvoice)
													{
														goto IL_1A8;
													}
													for (;;)
													{
														IL_19B:
														if (!newInvoiceViewModel.PrintVatInvoice)
														{
															goto IL_149;
														}
														goto IL_19;
														IL_6B:
														uint num3;
														uint num2;
														switch ((num2 = (num3 ^ 2896423299U)) % 35U)
														{
														case 0U:
															goto IL_2D9;
														case 1U:
															goto IL_240;
														case 2U:
															goto IL_1EC;
														case 3U:
															goto IL_2C9;
														case 4U:
															goto IL_4C;
														case 5U:
															goto IL_2F6;
														case 6U:
															goto IL_204;
														case 7U:
															goto IL_2B8;
														case 8U:
															goto IL_1A8;
														case 9U:
															goto IL_2AF;
														case 10U:
															goto IL_1FC;
														case 11U:
														case 32U:
															goto IL_233;
														case 13U:
															goto IL_21D;
														case 14U:
															goto IL_149;
														case 15U:
															goto IL_2D7;
														case 16U:
															goto IL_286;
														case 17U:
															goto IL_25B;
														case 18U:
															goto IL_213;
														case 19U:
															continue;
														case 20U:
															goto IL_2ED;
														case 21U:
															goto IL_2B;
														case 22U:
															goto IL_10E;
														case 24U:
															goto IL_1DF;
														case 25U:
															goto IL_156;
														case 26U:
															goto IL_1F4;
														case 27U:
															goto IL_1D5;
														case 28U:
															goto IL_225;
														case 29U:
															goto IL_304;
														case 30U:
															goto IL_2E1;
														case 31U:
														{
															IL_19:
															IVATInvoice vatinvoice = newInvoiceViewModel.VATInvoice;
															if (vatinvoice == null)
															{
																goto IL_156;
															}
															vatinvoice.EnablePrintImages();
															num3 = (num2 * 1099771809U ^ 2655393386U);
															goto IL_6B;
														}
														case 34U:
															goto IL_139;
														}
														goto Block_7;
														IL_2B:
														IWorksList worksList = newInvoiceViewModel.WorksList;
														if (worksList != null)
														{
															worksList.EnablePrintImages();
															num3 = (num2 * 3496059889U ^ 2568271923U);
															goto IL_6B;
														}
														goto IL_25A;
														IL_4C:
														IPackingList packingList = newInvoiceViewModel.PackingList;
														if (packingList != null)
														{
															packingList.EnablePrintImages();
															num3 = (num2 * 188954247U ^ 3412611778U);
															goto IL_6B;
														}
														goto IL_10E;
														IL_149:
														if (newInvoiceViewModel.PrintPacking)
														{
															goto IL_4C;
														}
														goto IL_139;
														IL_156:
														CS$<>8__locals1.docs.Add(new KeyValuePair<IInvoice, string>(newInvoiceViewModel.VATInvoice, string.Format("vatinvoice{0}", (int)newInvoiceViewModel.SelectedVatInvoicePrintType)));
														goto IL_149;
														IL_139:
														if (newInvoiceViewModel.PrintWorks)
														{
															goto IL_2B;
														}
														goto IL_286;
														IL_10E:
														CS$<>8__locals1.docs.Add(new KeyValuePair<IInvoice, string>(newInvoiceViewModel.PackingList, string.Format("p_list{0}", (int)newInvoiceViewModel.SelectedPackingListPrintType)));
														goto IL_139;
													}
													IL_1A8:
													CS$<>8__locals1.docs.Add(new KeyValuePair<IInvoice, string>(newInvoiceViewModel.Document, string.Format("invoice{0}", (int)newInvoiceViewModel.SelectedInvoicePrintType)));
													goto IL_19B;
												}
											}
										}
										goto Block_12;
										IL_1EC:
										if (newInvoiceViewModel.PrintVatInvoice)
										{
											goto IL_204;
										}
										IL_1F4:
										if (newInvoiceViewModel.PrintPacking)
										{
											goto IL_204;
										}
										IL_1FC:
										if (newInvoiceViewModel.PrintWorks)
										{
											goto IL_204;
										}
										goto IL_240;
									}
								}
							}
						}
						Block_7:
						Block_12:
						goto IL_332;
						IL_240:
						newInvoiceViewModel._toasterService.Info(Lang.t("SelectItem"));
						goto IL_332;
						IL_25A:
						IL_25B:
						CS$<>8__locals1.docs.Add(new KeyValuePair<IInvoice, string>(newInvoiceViewModel.WorksList, string.Format("w_list{0}", (int)newInvoiceViewModel.SelectedWorksListPrintType)));
						IL_286:
						newInvoiceViewModel._windowedDocumentService.CloseActiveDocument();
						newInvoiceViewModel.ShowWait();
						awaiter = Task.Run<EmailViewModel>(new Func<EmailViewModel>(CS$<>8__locals1.<SendEmail>b__0)).GetAwaiter();
						IL_2AF:
						if (awaiter.IsCompleted)
						{
							goto IL_2F6;
						}
						IL_2B8:
						this.<>1__state = 0;
						this.<>u__1 = awaiter;
						IL_2C9:
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<EmailViewModel>, NewInvoiceViewModel.<SendEmail>d__105>(ref awaiter, ref this);
						IL_2D7:
						return;
					}
					IL_2D9:
					awaiter = this.<>u__1;
					IL_2E1:
					this.<>u__1 = default(TaskAwaiter<EmailViewModel>);
					IL_2ED:
					this.<>1__state = -1;
					IL_2F6:
					EmailViewModel result = awaiter.GetResult();
					newInvoiceViewModel.HideWait();
					IL_304:
					newInvoiceViewModel._windowedDocumentService.ShowNewDocument("EmailView", result, null, null);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_332:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06005029 RID: 20521 RVA: 0x0015BACC File Offset: 0x00159CCC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003549 RID: 13641
			public int <>1__state;

			// Token: 0x0400354A RID: 13642
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400354B RID: 13643
			public NewInvoiceViewModel <>4__this;

			// Token: 0x0400354C RID: 13644
			private TaskAwaiter<EmailViewModel> <>u__1;
		}

		// Token: 0x02000B14 RID: 2836
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateCustomer>d__107 : IAsyncStateMachine
		{
			// Token: 0x0600502A RID: 20522 RVA: 0x0015BAE8 File Offset: 0x00159CE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NewInvoiceViewModel newInvoiceViewModel = this.<>4__this;
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
							goto IL_114;
						}
						IInvoice document = newInvoiceViewModel.Document;
						if (((document != null) ? document.Customer : null) == null)
						{
							goto IL_134;
						}
						newInvoiceViewModel.ShowWait();
						awaiter = newInvoiceViewModel._invoiceService.UpdateInvoiceCustomer(newInvoiceViewModel.Document.Id, newInvoiceViewModel.Document.Customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<UpdateCustomer>d__107>(ref awaiter, ref this);
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
					newInvoiceViewModel.HideWait();
					awaiter = newInvoiceViewModel.LoadExistDocument(newInvoiceViewModel._documentId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NewInvoiceViewModel.<UpdateCustomer>d__107>(ref awaiter, ref this);
						return;
					}
					IL_114:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_134:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600502B RID: 20523 RVA: 0x0015BC58 File Offset: 0x00159E58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400354D RID: 13645
			public int <>1__state;

			// Token: 0x0400354E RID: 13646
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400354F RID: 13647
			public NewInvoiceViewModel <>4__this;

			// Token: 0x04003550 RID: 13648
			private TaskAwaiter <>u__1;
		}
	}
}
