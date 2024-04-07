using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.PartsRequest;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.ItemsCancellation
{
	// Token: 0x020001CB RID: 459
	public class ItemsCancellationViewModel : BaseViewModel, IItemsSelect
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0004A370 File Offset: 0x00048570
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0004A384 File Offset: 0x00048584
		public ObservableCollection<store_items> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Items>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1635414716;
				IL_13:
				switch ((num ^ -1180293705) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<Items>k__BackingField = value;
					this.RaisePropertyChanged("Items");
					num = -259768010;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0004A3E0 File Offset: 0x000485E0
		public bool CanEdit
		{
			get
			{
				return this.CanSubstract();
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x0004A3F4 File Offset: 0x000485F4
		public bool CanEditInvert
		{
			get
			{
				return !this.CanEdit;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0004A40C File Offset: 0x0004860C
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x0004A420 File Offset: 0x00048620
		public int TotalItems
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalItems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalItems>k__BackingField == value)
				{
					return;
				}
				this.<TotalItems>k__BackingField = value;
				this.RaisePropertyChanged("TotalItems");
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x0004A44C File Offset: 0x0004864C
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x0004A460 File Offset: 0x00048660
		public List<CancellationOptions> CancellationOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<CancellationOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<CancellationOptionses>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1484940715;
				IL_13:
				switch ((num ^ -1575693970) % 4)
				{
				case 0:
					IL_32:
					this.<CancellationOptionses>k__BackingField = value;
					this.RaisePropertyChanged("CancellationOptionses");
					num = -1904644445;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x0004A4BC File Offset: 0x000486BC
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x0004A4D0 File Offset: 0x000486D0
		public int SelectedOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedOption>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1138167421;
				IL_10:
				switch ((num ^ -1502573447) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					this.<SelectedOption>k__BackingField = value;
					num = -1531395128;
					goto IL_10;
				}
				this.RaisePropertyChanged("SelectedOption");
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x0004A528 File Offset: 0x00048728
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x0004A53C File Offset: 0x0004873C
		public string CancellationText
		{
			[CompilerGenerated]
			get
			{
				return this.<CancellationText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CancellationText>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CancellationText>k__BackingField = value;
				this.RaisePropertyChanged("CancellationText");
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0004A56C File Offset: 0x0004876C
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0004A580 File Offset: 0x00048780
		public decimal TotalSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TotalSumm>k__BackingField, value))
				{
					return;
				}
				this.<TotalSumm>k__BackingField = value;
				this.RaisePropertyChanged("TotalSumm");
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0004A5B0 File Offset: 0x000487B0
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x0004A5C4 File Offset: 0x000487C4
		public docs Document
		{
			[CompilerGenerated]
			get
			{
				return this.<Document>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Document>k__BackingField, value))
				{
					return;
				}
				this.<Document>k__BackingField = value;
				this.RaisePropertyChanged("CanEdit");
				this.RaisePropertyChanged("CanEditInvert");
				this.RaisePropertyChanged("Document");
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0004A608 File Offset: 0x00048808
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x0004A61C File Offset: 0x0004881C
		public bool IsEditable
		{
			[CompilerGenerated]
			get
			{
				return this.<IsEditable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsEditable>k__BackingField == value)
				{
					return;
				}
				this.<IsEditable>k__BackingField = value;
				this.RaisePropertyChanged("IsEditable");
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0004A648 File Offset: 0x00048848
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x0004A65C File Offset: 0x0004885C
		public decimal CurrencyRate
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyRate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<CurrencyRate>k__BackingField, value))
				{
					return;
				}
				this.<CurrencyRate>k__BackingField = value;
				this.RaisePropertyChanged("CurrencyRate");
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0004A68C File Offset: 0x0004888C
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0004A6A0 File Offset: 0x000488A0
		public bool PrintRn
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintRn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintRn>k__BackingField == value)
				{
					return;
				}
				this.<PrintRn>k__BackingField = value;
				this.RaisePropertyChanged("PrintRn");
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0004A6CC File Offset: 0x000488CC
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0004A6E0 File Offset: 0x000488E0
		public List<companies> Companieses
		{
			[CompilerGenerated]
			get
			{
				return this.<Companieses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Companieses>k__BackingField, value))
				{
					return;
				}
				this.<Companieses>k__BackingField = value;
				this.RaisePropertyChanged("Companieses");
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0004A710 File Offset: 0x00048910
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x0004A724 File Offset: 0x00048924
		public store_items SelecteItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelecteItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelecteItem>k__BackingField, value))
				{
					return;
				}
				this.<SelecteItem>k__BackingField = value;
				this.RaisePropertyChanged("SelecteItem");
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0004A754 File Offset: 0x00048954
		public ItemsCancellationViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
			this.Items = new ObservableCollection<store_items>();
			this.Items.CollectionChanged += this.ItemsOnCollectionChanged;
			this.SetViewName("ItemsCancellation");
			this.LoadCancellationOptions();
			this.Document = new docs(true)
			{
				id = 0,
				type = 3
			};
			this.LoadCompanies_();
			if (this.Companieses.Count == 1)
			{
				companies companies = this.Companieses.FirstOrDefault<companies>();
				if (companies != null)
				{
					this.Document.company = companies.id;
				}
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0004A85C File Offset: 0x00048A5C
		public ItemsCancellationViewModel(int documentId) : this()
		{
			this.SetViewName("CancellationN", documentId);
			this.LoadDocument(documentId);
			this.LoadItems(documentId);
			this.CountTotal();
			this.LoadCancellationReason();
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0004A898 File Offset: 0x00048A98
		public ItemsCancellationViewModel(List<int> ids) : this()
		{
			foreach (int itemId in ids)
			{
				this.AddItem2List(itemId);
			}
			this.CountTotal();
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0004A8F4 File Offset: 0x00048AF4
		public ItemsCancellationViewModel(store_int_reserve reserve) : this()
		{
			this._reserve = reserve;
			this.AddItem2List(reserve);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0004A918 File Offset: 0x00048B18
		private void AddItem2List(int itemId)
		{
			ItemsCancellationViewModel.<AddItem2List>d__63 <AddItem2List>d__;
			<AddItem2List>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddItem2List>d__.<>4__this = this;
			<AddItem2List>d__.itemId = itemId;
			<AddItem2List>d__.<>1__state = -1;
			<AddItem2List>d__.<>t__builder.Start<ItemsCancellationViewModel.<AddItem2List>d__63>(ref <AddItem2List>d__);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0004A958 File Offset: 0x00048B58
		private void AddItem2List(store_int_reserve reserve)
		{
			ItemsCancellationViewModel.<AddItem2List>d__64 <AddItem2List>d__;
			<AddItem2List>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddItem2List>d__.<>4__this = this;
			<AddItem2List>d__.reserve = reserve;
			<AddItem2List>d__.<>1__state = -1;
			<AddItem2List>d__.<>t__builder.Start<ItemsCancellationViewModel.<AddItem2List>d__64>(ref <AddItem2List>d__);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0004A998 File Offset: 0x00048B98
		private void LoadCancellationReason()
		{
			CancellationOptions cancellationOptions = this.CancellationOptionses.FirstOrDefault((CancellationOptions o) => o.Name == this.Document.reason);
			if (cancellationOptions == null)
			{
				this.SelectedOption = 3;
				this.CancellationText = this.Document.reason;
				return;
			}
			this.SelectedOption = cancellationOptions.Id;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		private void LoadDocument(int documentId)
		{
			ItemsCancellationViewModel.<LoadDocument>d__66 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.documentId = documentId;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<ItemsCancellationViewModel.<LoadDocument>d__66>(ref <LoadDocument>d__);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0004AA28 File Offset: 0x00048C28
		private void LoadItems(int documentId)
		{
			ItemsCancellationViewModel.<LoadItems>d__67 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.documentId = documentId;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<ItemsCancellationViewModel.<LoadItems>d__67>(ref <LoadItems>d__);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0004AA68 File Offset: 0x00048C68
		private void LoadCompanies_()
		{
			ItemsCancellationViewModel.<LoadCompanies_>d__68 <LoadCompanies_>d__;
			<LoadCompanies_>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCompanies_>d__.<>4__this = this;
			<LoadCompanies_>d__.<>1__state = -1;
			<LoadCompanies_>d__.<>t__builder.Start<ItemsCancellationViewModel.<LoadCompanies_>d__68>(ref <LoadCompanies_>d__);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0004AAA0 File Offset: 0x00048CA0
		private void LoadCancellationOptions()
		{
			CancellationOptions cancellationOptions = new CancellationOptions();
			this.CancellationOptionses = cancellationOptions.GetAllOptions();
			this.Items.CollectionChanged += this.ItemsChanged;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0004AAD8 File Offset: 0x00048CD8
		private void ItemsChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.CountTotal();
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0004AAEC File Offset: 0x00048CEC
		private void CountTotal()
		{
			if (this.Items != null)
			{
				goto IL_0B;
			}
			goto IL_AE;
			int num;
			for (;;)
			{
				IL_8B:
				switch ((num ^ -289867141) % 5)
				{
				case 0:
					goto IL_AE;
				case 2:
					this.TotalSumm = (from i in this.Items
					select i.BuyCount * i.in_price).DefaultIfEmpty<decimal>().Sum();
					num = -1412141065;
					continue;
				case 3:
					goto IL_0B;
				case 4:
					return;
				}
				break;
			}
			return;
			IL_0B:
			this.TotalItems = (from i in this.Items
			select i.BuyCount).DefaultIfEmpty<int>().Sum();
			num = -742540610;
			goto IL_8B;
			IL_AE:
			num = -66501718;
			goto IL_8B;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0004ABB0 File Offset: 0x00048DB0
		private void PrintDocument()
		{
			ItemsCancellationViewModel.<PrintDocument>d__72 <PrintDocument>d__;
			<PrintDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintDocument>d__.<>4__this = this;
			<PrintDocument>d__.<>1__state = -1;
			<PrintDocument>d__.<>t__builder.Start<ItemsCancellationViewModel.<PrintDocument>d__72>(ref <PrintDocument>d__);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0004ABE8 File Offset: 0x00048DE8
		private decimal CountInPriceSumm()
		{
			return (from i in this.Items
			select i.BuyCount * i.in_price).DefaultIfEmpty<decimal>().Sum();
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0004AC2C File Offset: 0x00048E2C
		private string GetReason()
		{
			if (this.SelectedOption != 3)
			{
				goto IL_4C;
			}
			IL_18:
			int num = -804063199;
			IL_1D:
			CancellationOptions cancellationOptions;
			switch ((num ^ -1584195299) % 5)
			{
			case 0:
				return "";
			case 1:
				IL_4C:
				cancellationOptions = this.CancellationOptionses.FirstOrDefault((CancellationOptions o) => o.Id == this.SelectedOption);
				num = ((cancellationOptions == null) ? -1010500580 : -126051441);
				goto IL_1D;
			case 2:
				return this.CancellationText;
			case 3:
				goto IL_18;
			}
			return cancellationOptions.Name;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0004ACB8 File Offset: 0x00048EB8
		private bool CheckFields()
		{
			if (this.Document.company <= 0)
			{
				this._toasterService.Info(Lang.t("InputCompany"));
				return false;
			}
			if (this.SelectedOption == 0)
			{
				this._toasterService.Info(Lang.t("SelectCancellation"));
				return false;
			}
			if (this.SelectedOption == 3)
			{
				if (string.IsNullOrEmpty(this.CancellationText))
				{
					this._toasterService.Info(Lang.t("InputCancellation"));
					return false;
				}
			}
			if (this.Items == null || !this.Items.Any<store_items>())
			{
				this._toasterService.Info(Lang.t("SelectItems"));
				return false;
			}
			if (this.Items.Any((store_items item) => item.Available <= 0) && this._reserve == null)
			{
				this._toasterService.Info(Lang.t("ItemSubstractWarning"));
				return false;
			}
			if (this.Items.Any((store_items item) => item.BuyCount > item.Available) && this._reserve == null)
			{
				this._toasterService.Info(Lang.t("ItemSubstractWarning"));
				return false;
			}
			return true;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0004AE04 File Offset: 0x00049004
		[Command]
		public void Substract()
		{
			if (!this.CheckFields())
			{
				return;
			}
			this.Document.reason = this.GetReason();
			this.Document.currency_rate = new decimal?(this.CurrencyRate);
			this.Document.dealer = null;
			this.Document.total = this.CountInPriceSumm();
			if (this._reserve != null)
			{
				new PartsRequestModel().CancellReserve(this._reserve, PartsRequestModel.State.Archive);
			}
			if (!this._documentsModel.CreateDocument(this.Document, this.Items))
			{
				return;
			}
			this.IsEditable = false;
			if (this.PrintRn)
			{
				this.PrintDocument();
			}
			this.LoadItems(this.Document.id);
			base.RaiseCanExecuteChanged(() => this.Substract());
			base.RaisePropertyChanged<bool>(() => this.CanEditInvert);
			1554252861;
			base.ShowActionResponse(true, Lang.t("Complete"));
			IRefreshable parentViewModel = this._parentViewModel;
			if (parentViewModel == null)
			{
				return;
			}
			parentViewModel.DataRefresh();
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0004AF5C File Offset: 0x0004915C
		public bool CanSubstract()
		{
			return this.Document != null && this.Document.id == 0 && OfflineData.Instance.Employee.Can(9, 0);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0004AF94 File Offset: 0x00049194
		[Command]
		public void PrintRnClick()
		{
			this.PrintDocument();
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0004AFA8 File Offset: 0x000491A8
		[Command]
		public void ItemDoubleClick(object obj)
		{
			if (this.SelecteItem == null)
			{
				goto IL_17;
			}
			goto IL_6D;
			int num;
			for (;;)
			{
				IL_3A:
				switch ((num ^ -1078442014) % 6)
				{
				case 0:
					this._navigationService.NavigateToStoreItem(this.SelecteItem.id, 0);
					num = -959153482;
					continue;
				case 1:
					return;
				case 3:
					goto IL_6D;
				case 4:
					goto IL_17;
				case 5:
					return;
				}
				break;
			}
			return;
			IL_17:
			num = -1501123171;
			goto IL_3A;
			IL_6D:
			num = ((this.Document.id != 0) ? -912464364 : -1720669635);
			goto IL_3A;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0004AAD8 File Offset: 0x00048CD8
		[Command]
		public void Refresh()
		{
			this.CountTotal();
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0004B034 File Offset: 0x00049234
		[Command]
		public void Close()
		{
			this.Items.Clear();
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0004B058 File Offset: 0x00049258
		public void AddItemsFromStore(List<Product> items, Product selectedItem)
		{
			if (items.Count > 0)
			{
				foreach (Product i in items)
				{
					this.Items.Add(i.BackToStoreItem());
				}
				return;
			}
			if (selectedItem != null)
			{
				this.Items.Add(selectedItem.BackToStoreItem());
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0004B0D0 File Offset: 0x000492D0
		private void ItemsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Remove)
			{
				using (IEnumerator enumerator = e.OldItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						((store_items)obj).PropertyChanged -= this.EntityViewModelPropertyChanged;
					}
					return;
				}
			}
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				foreach (object obj2 in e.NewItems)
				{
					((store_items)obj2).PropertyChanged += this.EntityViewModelPropertyChanged;
				}
			}
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0004AAD8 File Offset: 0x00048CD8
		public void EntityViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			this.CountTotal();
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0004B198 File Offset: 0x00049398
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0004B1B8 File Offset: 0x000493B8
		[CompilerGenerated]
		private bool <LoadCancellationReason>b__65_0(CancellationOptions o)
		{
			return o.Name == this.Document.reason;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0004B1DC File Offset: 0x000493DC
		[CompilerGenerated]
		private bool <GetReason>b__74_0(CancellationOptions o)
		{
			return o.Id == this.SelectedOption;
		}

		// Token: 0x04000D60 RID: 3424
		private readonly DocumentsModel _documentsModel = new DocumentsModel();

		// Token: 0x04000D61 RID: 3425
		private IRefreshable _parentViewModel;

		// Token: 0x04000D62 RID: 3426
		[CompilerGenerated]
		private ObservableCollection<store_items> <Items>k__BackingField;

		// Token: 0x04000D63 RID: 3427
		[CompilerGenerated]
		private int <TotalItems>k__BackingField;

		// Token: 0x04000D64 RID: 3428
		[CompilerGenerated]
		private List<CancellationOptions> <CancellationOptionses>k__BackingField;

		// Token: 0x04000D65 RID: 3429
		[CompilerGenerated]
		private int <SelectedOption>k__BackingField;

		// Token: 0x04000D66 RID: 3430
		[CompilerGenerated]
		private string <CancellationText>k__BackingField;

		// Token: 0x04000D67 RID: 3431
		[CompilerGenerated]
		private decimal <TotalSumm>k__BackingField;

		// Token: 0x04000D68 RID: 3432
		[CompilerGenerated]
		private docs <Document>k__BackingField;

		// Token: 0x04000D69 RID: 3433
		[CompilerGenerated]
		private bool <IsEditable>k__BackingField = true;

		// Token: 0x04000D6A RID: 3434
		[CompilerGenerated]
		private decimal <CurrencyRate>k__BackingField = Auth.CurrencyModel.Rate;

		// Token: 0x04000D6B RID: 3435
		[CompilerGenerated]
		private bool <PrintRn>k__BackingField = Auth.Config.qs_print_rn;

		// Token: 0x04000D6C RID: 3436
		[CompilerGenerated]
		private List<companies> <Companieses>k__BackingField;

		// Token: 0x04000D6D RID: 3437
		[CompilerGenerated]
		private store_items <SelecteItem>k__BackingField;

		// Token: 0x04000D6E RID: 3438
		private store_int_reserve _reserve;

		// Token: 0x04000D6F RID: 3439
		private readonly INavigationService _navigationService;

		// Token: 0x04000D70 RID: 3440
		private readonly IToasterService _toasterService;

		// Token: 0x04000D71 RID: 3441
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000D72 RID: 3442
		private readonly IReportPrintService _reportPrintService;

		// Token: 0x020001CC RID: 460
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddItem2List>d__63 : IAsyncStateMachine
		{
			// Token: 0x06001A0C RID: 6668 RVA: 0x0004B1F8 File Offset: 0x000493F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsCancellationViewModel itemsCancellationViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_items> awaiter;
					if (num != 0)
					{
						awaiter = itemsCancellationViewModel._documentsModel.LoadItem(this.itemId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ItemsCancellationViewModel.<AddItem2List>d__63>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_items>);
						this.<>1__state = -1;
					}
					store_items result = awaiter.GetResult();
					if (result != null)
					{
						itemsCancellationViewModel.Items.Add(result);
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

			// Token: 0x06001A0D RID: 6669 RVA: 0x0004B2CC File Offset: 0x000494CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D73 RID: 3443
			public int <>1__state;

			// Token: 0x04000D74 RID: 3444
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D75 RID: 3445
			public ItemsCancellationViewModel <>4__this;

			// Token: 0x04000D76 RID: 3446
			public int itemId;

			// Token: 0x04000D77 RID: 3447
			private TaskAwaiter<store_items> <>u__1;
		}

		// Token: 0x020001CD RID: 461
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddItem2List>d__64 : IAsyncStateMachine
		{
			// Token: 0x06001A0E RID: 6670 RVA: 0x0004B2E8 File Offset: 0x000494E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsCancellationViewModel itemsCancellationViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<store_items> awaiter;
					if (num != 0)
					{
						awaiter = itemsCancellationViewModel._documentsModel.LoadItem(this.reserve.item_id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ItemsCancellationViewModel.<AddItem2List>d__64>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<store_items>);
						this.<>1__state = -1;
					}
					store_items result = awaiter.GetResult();
					if (result != null)
					{
						result.BuyCount = this.reserve.count;
						itemsCancellationViewModel.Items.Add(result);
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

			// Token: 0x06001A0F RID: 6671 RVA: 0x0004B3D0 File Offset: 0x000495D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D78 RID: 3448
			public int <>1__state;

			// Token: 0x04000D79 RID: 3449
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D7A RID: 3450
			public ItemsCancellationViewModel <>4__this;

			// Token: 0x04000D7B RID: 3451
			public store_int_reserve reserve;

			// Token: 0x04000D7C RID: 3452
			private TaskAwaiter<store_items> <>u__1;
		}

		// Token: 0x020001CE RID: 462
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__66 : IAsyncStateMachine
		{
			// Token: 0x06001A10 RID: 6672 RVA: 0x0004B3EC File Offset: 0x000495EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsCancellationViewModel itemsCancellationViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<docs> awaiter;
					if (num != 0)
					{
						awaiter = itemsCancellationViewModel._documentsModel.LoadDocument(this.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<docs>, ItemsCancellationViewModel.<LoadDocument>d__66>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<docs>);
						this.<>1__state = -1;
					}
					docs result = awaiter.GetResult();
					itemsCancellationViewModel.Document = result;
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

			// Token: 0x06001A11 RID: 6673 RVA: 0x0004B4B4 File Offset: 0x000496B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D7D RID: 3453
			public int <>1__state;

			// Token: 0x04000D7E RID: 3454
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D7F RID: 3455
			public ItemsCancellationViewModel <>4__this;

			// Token: 0x04000D80 RID: 3456
			public int documentId;

			// Token: 0x04000D81 RID: 3457
			private TaskAwaiter<docs> <>u__1;
		}

		// Token: 0x020001CF RID: 463
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__67 : IAsyncStateMachine
		{
			// Token: 0x06001A12 RID: 6674 RVA: 0x0004B4D0 File Offset: 0x000496D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsCancellationViewModel itemsCancellationViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_sales>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_A7;
						}
						itemsCancellationViewModel.Items = new ObservableCollection<store_items>();
						itemsCancellationViewModel.Items.CollectionChanged += itemsCancellationViewModel.ItemsOnCollectionChanged;
						awaiter = DocumentsModel.LoadSales(this.documentId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_sales>>, ItemsCancellationViewModel.<LoadItems>d__67>(ref awaiter, ref this);
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
					List<store_sales> result = awaiter.GetResult();
					this.<>7__wrap1 = result.GetEnumerator();
					IL_A7:
					try
					{
						TaskAwaiter<store_items> awaiter2;
						if (num == 1)
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<store_items>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_149;
						}
						IL_105:
						if (!this.<>7__wrap1.MoveNext())
						{
							goto IL_194;
						}
						this.<item>5__3 = this.<>7__wrap1.Current;
						awaiter2 = itemsCancellationViewModel._documentsModel.LoadItem(this.<item>5__3.item_id).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_items>, ItemsCancellationViewModel.<LoadItems>d__67>(ref awaiter2, ref this);
							return;
						}
						IL_149:
						store_items result2 = awaiter2.GetResult();
						if (result2 == null)
						{
							goto IL_105;
						}
						result2.BuyCount = this.<item>5__3.count;
						result2.in_price = this.<item>5__3.in_price;
						itemsCancellationViewModel.Items.Add(result2);
						this.<item>5__3 = null;
						goto IL_105;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap1).Dispose();
						}
					}
					IL_194:
					this.<>7__wrap1 = default(List<store_sales>.Enumerator);
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

			// Token: 0x06001A13 RID: 6675 RVA: 0x0004B6E0 File Offset: 0x000498E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D82 RID: 3458
			public int <>1__state;

			// Token: 0x04000D83 RID: 3459
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D84 RID: 3460
			public ItemsCancellationViewModel <>4__this;

			// Token: 0x04000D85 RID: 3461
			public int documentId;

			// Token: 0x04000D86 RID: 3462
			private TaskAwaiter<List<store_sales>> <>u__1;

			// Token: 0x04000D87 RID: 3463
			private List<store_sales>.Enumerator <>7__wrap1;

			// Token: 0x04000D88 RID: 3464
			private store_sales <item>5__3;

			// Token: 0x04000D89 RID: 3465
			private TaskAwaiter<store_items> <>u__2;
		}

		// Token: 0x020001D0 RID: 464
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCompanies_>d__68 : IAsyncStateMachine
		{
			// Token: 0x06001A14 RID: 6676 RVA: 0x0004B6FC File Offset: 0x000498FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsCancellationViewModel itemsCancellationViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<companies>> awaiter;
					if (num != 0)
					{
						awaiter = CompaniesModel.LoadCompaniesAllFields(false, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<companies>>, ItemsCancellationViewModel.<LoadCompanies_>d__68>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<companies>>);
						this.<>1__state = -1;
					}
					List<companies> result = awaiter.GetResult();
					itemsCancellationViewModel.Companieses = result;
					if (itemsCancellationViewModel.Companieses != null)
					{
						if (itemsCancellationViewModel.Companieses.Count == 1)
						{
							itemsCancellationViewModel.Document.company = itemsCancellationViewModel.Companieses.First<companies>().id;
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

			// Token: 0x06001A15 RID: 6677 RVA: 0x0004B7F0 File Offset: 0x000499F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D8A RID: 3466
			public int <>1__state;

			// Token: 0x04000D8B RID: 3467
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D8C RID: 3468
			public ItemsCancellationViewModel <>4__this;

			// Token: 0x04000D8D RID: 3469
			private TaskAwaiter<List<companies>> <>u__1;
		}

		// Token: 0x020001D1 RID: 465
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001A16 RID: 6678 RVA: 0x0004B80C File Offset: 0x00049A0C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001A17 RID: 6679 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001A18 RID: 6680 RVA: 0x0004B824 File Offset: 0x00049A24
			internal int <CountTotal>b__71_0(store_items i)
			{
				return i.BuyCount;
			}

			// Token: 0x06001A19 RID: 6681 RVA: 0x0004B838 File Offset: 0x00049A38
			internal decimal <CountTotal>b__71_1(store_items i)
			{
				return i.BuyCount * i.in_price;
			}

			// Token: 0x06001A1A RID: 6682 RVA: 0x0004B838 File Offset: 0x00049A38
			internal decimal <CountInPriceSumm>b__73_0(store_items i)
			{
				return i.BuyCount * i.in_price;
			}

			// Token: 0x06001A1B RID: 6683 RVA: 0x0004B85C File Offset: 0x00049A5C
			internal bool <CheckFields>b__75_0(store_items item)
			{
				return item.Available <= 0;
			}

			// Token: 0x06001A1C RID: 6684 RVA: 0x0004B878 File Offset: 0x00049A78
			internal bool <CheckFields>b__75_1(store_items item)
			{
				return item.BuyCount > item.Available;
			}

			// Token: 0x04000D8E RID: 3470
			public static readonly ItemsCancellationViewModel.<>c <>9 = new ItemsCancellationViewModel.<>c();

			// Token: 0x04000D8F RID: 3471
			public static Func<store_items, int> <>9__71_0;

			// Token: 0x04000D90 RID: 3472
			public static Func<store_items, decimal> <>9__71_1;

			// Token: 0x04000D91 RID: 3473
			public static Func<store_items, decimal> <>9__73_0;

			// Token: 0x04000D92 RID: 3474
			public static Func<store_items, bool> <>9__75_0;

			// Token: 0x04000D93 RID: 3475
			public static Func<store_items, bool> <>9__75_1;
		}

		// Token: 0x020001D2 RID: 466
		[CompilerGenerated]
		private sealed class <>c__DisplayClass72_0
		{
			// Token: 0x06001A1D RID: 6685 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass72_0()
			{
			}

			// Token: 0x06001A1E RID: 6686 RVA: 0x0004B894 File Offset: 0x00049A94
			internal Task<StoreDocument> <PrintDocument>b__0()
			{
				return DocumentsModel.GetDocument(this.<>4__this.Document.id);
			}

			// Token: 0x06001A1F RID: 6687 RVA: 0x0004B8B8 File Offset: 0x00049AB8
			internal XtraReport <PrintDocument>b__1()
			{
				return this.doc.CreateReport("rn", false);
			}

			// Token: 0x04000D94 RID: 3476
			public ItemsCancellationViewModel <>4__this;

			// Token: 0x04000D95 RID: 3477
			public StoreDocument doc;
		}

		// Token: 0x020001D3 RID: 467
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintDocument>d__72 : IAsyncStateMachine
		{
			// Token: 0x06001A20 RID: 6688 RVA: 0x0004B8D8 File Offset: 0x00049AD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ItemsCancellationViewModel itemsCancellationViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					TaskAwaiter<StoreDocument> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							this.<>1__state = -1;
							goto IL_FD;
						}
						this.<>8__1 = new ItemsCancellationViewModel.<>c__DisplayClass72_0();
						this.<>8__1.<>4__this = this.<>4__this;
						itemsCancellationViewModel.ShowWait();
						awaiter2 = Task.Run<StoreDocument>(new Func<Task<StoreDocument>>(this.<>8__1.<PrintDocument>b__0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<StoreDocument>, ItemsCancellationViewModel.<PrintDocument>d__72>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<StoreDocument>);
						this.<>1__state = -1;
					}
					StoreDocument result = awaiter2.GetResult();
					this.<>8__1.doc = result;
					awaiter = Task.Run<XtraReport>(new Func<XtraReport>(this.<>8__1.<PrintDocument>b__1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, ItemsCancellationViewModel.<PrintDocument>d__72>(ref awaiter, ref this);
						return;
					}
					IL_FD:
					XtraReport result2 = awaiter.GetResult();
					itemsCancellationViewModel.HideWait();
					itemsCancellationViewModel._reportPrintService.PrintPreview(result2, PrinterModel.Printer.Documents);
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

			// Token: 0x06001A21 RID: 6689 RVA: 0x0004BA78 File Offset: 0x00049C78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D96 RID: 3478
			public int <>1__state;

			// Token: 0x04000D97 RID: 3479
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000D98 RID: 3480
			public ItemsCancellationViewModel <>4__this;

			// Token: 0x04000D99 RID: 3481
			private ItemsCancellationViewModel.<>c__DisplayClass72_0 <>8__1;

			// Token: 0x04000D9A RID: 3482
			private TaskAwaiter<StoreDocument> <>u__1;

			// Token: 0x04000D9B RID: 3483
			private TaskAwaiter<XtraReport> <>u__2;
		}
	}
}
