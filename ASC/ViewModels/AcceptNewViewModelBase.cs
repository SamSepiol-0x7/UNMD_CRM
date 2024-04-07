using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000451 RID: 1105
	public class AcceptNewViewModelBase : BaseViewModel
	{
		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x0008ABB4 File Offset: 0x00088DB4
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x0008ABC8 File Offset: 0x00088DC8
		public bool OfficesVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficesVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OfficesVisible>k__BackingField == value)
				{
					return;
				}
				this.<OfficesVisible>k__BackingField = value;
				this.RaisePropertyChanged("OfficesVisible");
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x0008ABF4 File Offset: 0x00088DF4
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x0008AC08 File Offset: 0x00088E08
		public CustomerCard Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Customer>k__BackingField, value))
				{
					return;
				}
				this.<Customer>k__BackingField = value;
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x0008AC38 File Offset: 0x00088E38
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x0008AC4C File Offset: 0x00088E4C
		public ObservableCollection<ClientAndDevices> ClientsMatch
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientsMatch>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ClientsMatch>k__BackingField, value))
				{
					return;
				}
				this.<ClientsMatch>k__BackingField = value;
				this.RaisePropertyChanged("ClientsMatch");
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x0008AC7C File Offset: 0x00088E7C
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x0008AC90 File Offset: 0x00088E90
		public List<StockTakingOptions> CustomerInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerInfo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CustomerInfo>k__BackingField, value))
				{
					return;
				}
				this.<CustomerInfo>k__BackingField = value;
				this.RaisePropertyChanged("CustomerInfoVisibility");
				this.RaisePropertyChanged("CustomerInfo");
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x0008ACCC File Offset: 0x00088ECC
		public bool CustomerInfoVisibility
		{
			get
			{
				return this.CustomerInfo != null && this.CustomerInfo.Count > 0;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002B97 RID: 11159 RVA: 0x0008ACF4 File Offset: 0x00088EF4
		// (set) Token: 0x06002B98 RID: 11160 RVA: 0x0008AD08 File Offset: 0x00088F08
		public bool IsMatchClientVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<IsMatchClientVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsMatchClientVisible>k__BackingField == value)
				{
					return;
				}
				this.<IsMatchClientVisible>k__BackingField = value;
				this.RaisePropertyChanged("IsMatchClientVisible");
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x0008AD34 File Offset: 0x00088F34
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x0008AD48 File Offset: 0x00088F48
		public ObservableCollection<IManufacturer> Makers
		{
			[CompilerGenerated]
			get
			{
				return this.<Makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Makers>k__BackingField, value))
				{
					return;
				}
				this.<Makers>k__BackingField = value;
				this.RaisePropertyChanged("Makers");
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x0008AD78 File Offset: 0x00088F78
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x0008AD8C File Offset: 0x00088F8C
		public List<UserMaster> Masters
		{
			[CompilerGenerated]
			get
			{
				return this.<Masters>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Masters>k__BackingField, value))
				{
					return;
				}
				this.<Masters>k__BackingField = value;
				this.RaisePropertyChanged("Masters");
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x0008ADBC File Offset: 0x00088FBC
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x0008ADD0 File Offset: 0x00088FD0
		public List<PhoneOptions> PhoneOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PhoneOptions>k__BackingField, value))
				{
					return;
				}
				this.<PhoneOptions>k__BackingField = value;
				this.RaisePropertyChanged("PhoneOptions");
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x0008AE00 File Offset: 0x00089000
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x0008AE14 File Offset: 0x00089014
		public int RepairsCount
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairsCount>k__BackingField == value)
				{
					return;
				}
				this.<RepairsCount>k__BackingField = value;
				this.RaisePropertyChanged("RepairsCount");
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x0008AE40 File Offset: 0x00089040
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x0008AE54 File Offset: 0x00089054
		public int PurchasesCount
		{
			[CompilerGenerated]
			get
			{
				return this.<PurchasesCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PurchasesCount>k__BackingField == value)
				{
					return;
				}
				this.<PurchasesCount>k__BackingField = value;
				this.RaisePropertyChanged("PurchasesCount");
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x0008AE80 File Offset: 0x00089080
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x0008AE94 File Offset: 0x00089094
		public ClientAndDevices SelectedMatch
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedMatch>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedMatch>k__BackingField, value))
				{
					return;
				}
				this.<SelectedMatch>k__BackingField = value;
				this.RaisePropertyChanged("SelectedMatch");
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x0008AEC4 File Offset: 0x000890C4
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x0008AED8 File Offset: 0x000890D8
		public bool OpenClietcCardBtnVis
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenClietcCardBtnVis>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OpenClietcCardBtnVis>k__BackingField == value)
				{
					return;
				}
				this.<OpenClietcCardBtnVis>k__BackingField = value;
				this.RaisePropertyChanged("OpenClietcCardBtnVis");
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x0008AF04 File Offset: 0x00089104
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x0008AF18 File Offset: 0x00089118
		public List<boxes> Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Boxes>k__BackingField, value))
				{
					return;
				}
				this.<Boxes>k__BackingField = value;
				this.RaisePropertyChanged("Boxes");
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x0008AF48 File Offset: 0x00089148
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x0008AF5C File Offset: 0x0008915C
		public bool CompaniesVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<CompaniesVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CompaniesVisible>k__BackingField == value)
				{
					return;
				}
				this.<CompaniesVisible>k__BackingField = value;
				this.RaisePropertyChanged("CompaniesVisible");
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x0008AF88 File Offset: 0x00089188
		public bool ShowBoxes
		{
			get
			{
				return Auth.User.offices1.use_boxes;
			}
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x0008AFA4 File Offset: 0x000891A4
		public AcceptNewViewModelBase()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this.EnableSearch = true;
			this.SetCustomer(ClientsModel.DefaultCustomer().Client2CustomerCard());
			this.ClientsMatch = new ObservableCollection<ClientAndDevices>();
			this.CompaniesVisible = (OfflineData.Instance.CountCompanies() > 1);
			this.OfficesVisible = (OfflineData.Instance.CountOffices() > 1);
			this.Init();
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x0008B038 File Offset: 0x00089238
		public void Init()
		{
			AcceptNewViewModelBase.<Init>d__65 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<AcceptNewViewModelBase.<Init>d__65>(ref <Init>d__);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00023150 File Offset: 0x00021350
		public virtual void EndInit()
		{
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0008B070 File Offset: 0x00089270
		protected void SetCustomer(CustomerCard customer)
		{
			this.Customer = customer;
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0008B084 File Offset: 0x00089284
		protected Task SetCustomer(int customerId)
		{
			AcceptNewViewModelBase.<SetCustomer>d__68 <SetCustomer>d__;
			<SetCustomer>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetCustomer>d__.<>4__this = this;
			<SetCustomer>d__.customerId = customerId;
			<SetCustomer>d__.<>1__state = -1;
			<SetCustomer>d__.<>t__builder.Start<AcceptNewViewModelBase.<SetCustomer>d__68>(ref <SetCustomer>d__);
			return <SetCustomer>d__.<>t__builder.Task;
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0008B0D0 File Offset: 0x000892D0
		[Command]
		public void ClientMatchClick()
		{
			if (this.SelectedMatch == null)
			{
				return;
			}
			this.EnableSearch = false;
			base.ShowWait();
			Task.Run<CustomerCard>(() => ClientsModel.GetCustomerCard(this.SelectedMatch.ClientId)).ContinueWith(delegate(Task<CustomerCard> t)
			{
				this.SetCustomer(t.Result);
				base.HideWait();
				this.AfterClientSelect();
				this.EnableSearch = true;
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x0008B11C File Offset: 0x0008931C
		public void SwithEnableSearch()
		{
			this.EnableSearch = !this.EnableSearch;
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x0008B138 File Offset: 0x00089338
		[Command]
		public void SelectCustomer()
		{
			this.ClearClientStat();
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectClient"), this);
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public virtual bool CanSelectCustomer()
		{
			return true;
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x0008B168 File Offset: 0x00089368
		public void DisplayCustomerNotes()
		{
			string text = "";
			int num = 1;
			if (!string.IsNullOrEmpty(this.Customer.Notes))
			{
				text = text + num.ToString() + ". " + this.Customer.Notes;
				num++;
			}
			if (this.Customer.BalanceEnabled && this.Customer.Balance < 0m)
			{
				text += string.Format("{0}. {1} {2:N0}", num, Lang.t("Label10"), this.Customer.Balance);
				num++;
			}
			if (!string.IsNullOrEmpty(text))
			{
				this._ascMessageBoxService.ShowMessageBox(text, Lang.t("Attention"), MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x0008B22C File Offset: 0x0008942C
		public void CountCustomerStat()
		{
			AcceptNewViewModelBase.<CountCustomerStat>d__74 <CountCustomerStat>d__;
			<CountCustomerStat>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CountCustomerStat>d__.<>4__this = this;
			<CountCustomerStat>d__.<>1__state = -1;
			<CountCustomerStat>d__.<>t__builder.Start<AcceptNewViewModelBase.<CountCustomerStat>d__74>(ref <CountCustomerStat>d__);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x0008B264 File Offset: 0x00089464
		public void ClearClientStat()
		{
			this.RepairsCount = 0;
			this.PurchasesCount = 0;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0008B280 File Offset: 0x00089480
		[Command]
		public void UnsetClient()
		{
			this.ClientsMatch = null;
			this.ClearClientStat();
			this.OpenClietcCardBtnVis = false;
			this.SetCustomer(ClientsModel.DefaultCustomer().Client2CustomerCard());
			this.CustomerInfo = new List<StockTakingOptions>();
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x0008B2BC File Offset: 0x000894BC
		[Command]
		public void SearchClientMatch()
		{
			if (!this.EnableSearch)
			{
				return;
			}
			if (this.Customer == null)
			{
				this.SetCustomer(ClientsModel.DefaultCustomer().Client2CustomerCard());
			}
			if (this.Customer.Type == 0 && (this.Customer.LastName == null || this.Customer.LastName.Length < 3) && (this.Customer.FirstName == null || this.Customer.FirstName.Length < 3) && (string.IsNullOrEmpty(this.Customer.Phone) || this.Customer.Phone.Length < 6))
			{
				this.ClientsMatch = new ObservableCollection<ClientAndDevices>();
				this.HideClientMatch();
				return;
			}
			if (this.Customer.Type == 1 && (this.Customer.UrName == null || this.Customer.UrName.Length < 3) && (string.IsNullOrEmpty(this.Customer.Phone) || this.Customer.Phone.Length < 6))
			{
				this.ClientsMatch = new ObservableCollection<ClientAndDevices>();
				this.HideClientMatch();
				return;
			}
			base.ShowWait();
			Task.Run<List<ClientAndDevices>>(() => RepairModel.SearchClientMatchV2(this.Customer.Customer2Client())).ContinueWith(delegate(Task<List<ClientAndDevices>> t)
			{
				this.ClientsMatch = new ObservableCollection<ClientAndDevices>(t.Result);
				this.IsMatchClientVisible = (this.ClientsMatch.Count > 0);
				base.HideWait();
			});
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public virtual bool CanSearchClientMatch()
		{
			return true;
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x0008B3FC File Offset: 0x000895FC
		public void HideMatchShowOpenCard()
		{
			this.HideClientMatch();
			this.OpenClietcCardBtnVis = true;
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x0008B418 File Offset: 0x00089618
		[Command]
		public void HideClientMatch()
		{
			this.IsMatchClientVisible = false;
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x0008B42C File Offset: 0x0008962C
		public void GetCustomerInfo()
		{
			List<StockTakingOptions> list = new List<StockTakingOptions>
			{
				new StockTakingOptions(0, Lang.t("Repairs2") + ": " + this.RepairsCount.ToString(), new SolidColorBrush(Colors.Black)),
				new StockTakingOptions(1, Lang.t("Label92") + ": " + this.PurchasesCount.ToString(), new SolidColorBrush(Colors.Black))
			};
			if (this.Customer.BalanceEnabled)
			{
				list.Add(new StockTakingOptions(2, Lang.t("Label10") + ": " + Fn.FormatSumm(this.Customer.Balance).ToString(), new SolidColorBrush(Colors.Black)));
			}
			if (this.Customer.IsRegular)
			{
				list.Add(new StockTakingOptions(3, Lang.t("IsRegular"), new SolidColorBrush(Colors.Green)));
			}
			if (this.Customer.PreferCashless)
			{
				list.Add(new StockTakingOptions(4, Lang.t("Cashless"), new SolidColorBrush(Colors.DarkBlue)));
			}
			if (this.Customer.IsBad)
			{
				list.Add(new StockTakingOptions(5, Lang.t("LabelIsBad"), new SolidColorBrush(Colors.Red)));
			}
			this.CustomerInfo = list;
			base.RaisePropertyChanged<bool>(() => this.CustomerInfoVisibility);
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x0008B5C4 File Offset: 0x000897C4
		[Command]
		public void OpenClientCard(object obj)
		{
			if (obj != null)
			{
				int valueOrDefault = (obj as int?).GetValueOrDefault();
				if (valueOrDefault != 0)
				{
					this._navigationService.NavigateToCustomerCard(valueOrDefault, this);
					return;
				}
			}
			if (this.SelectedMatch == null)
			{
				return;
			}
			this._navigationService.NavigateToCustomerCard(this.SelectedMatch.ClientId, this);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x0008B61C File Offset: 0x0008981C
		public virtual void AfterClientSelect()
		{
			this.CountCustomerStat();
			this.OpenClietcCardBtnVis = true;
			this.DisplayCustomerNotes();
			this.IsMatchClientVisible = false;
			this.GetCustomerInfo();
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x0008B64C File Offset: 0x0008984C
		public virtual void UseClientData()
		{
			this.DisplayCustomerNotes();
			this.CountCustomerStat();
			this.GetCustomerInfo();
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x0008B66C File Offset: 0x0008986C
		[CompilerGenerated]
		private Task<CustomerCard> <ClientMatchClick>b__69_0()
		{
			return ClientsModel.GetCustomerCard(this.SelectedMatch.ClientId);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x0008B68C File Offset: 0x0008988C
		[CompilerGenerated]
		private void <ClientMatchClick>b__69_1(Task<CustomerCard> t)
		{
			this.SetCustomer(t.Result);
			base.HideWait();
			this.AfterClientSelect();
			this.EnableSearch = true;
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x0008B6B8 File Offset: 0x000898B8
		[CompilerGenerated]
		private Task<List<ClientAndDevices>> <SearchClientMatch>b__77_0()
		{
			return RepairModel.SearchClientMatchV2(this.Customer.Customer2Client());
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x0008B6D8 File Offset: 0x000898D8
		[CompilerGenerated]
		private void <SearchClientMatch>b__77_1(Task<List<ClientAndDevices>> t)
		{
			this.ClientsMatch = new ObservableCollection<ClientAndDevices>(t.Result);
			this.IsMatchClientVisible = (this.ClientsMatch.Count > 0);
			base.HideWait();
		}

		// Token: 0x04001848 RID: 6216
		protected readonly IWorkshopService _workshopService;

		// Token: 0x04001849 RID: 6217
		protected readonly INavigationService _navigationService;

		// Token: 0x0400184A RID: 6218
		protected readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x0400184B RID: 6219
		[CompilerGenerated]
		private bool <OfficesVisible>k__BackingField;

		// Token: 0x0400184C RID: 6220
		[CompilerGenerated]
		private CustomerCard <Customer>k__BackingField;

		// Token: 0x0400184D RID: 6221
		[CompilerGenerated]
		private ObservableCollection<ClientAndDevices> <ClientsMatch>k__BackingField;

		// Token: 0x0400184E RID: 6222
		[CompilerGenerated]
		private List<StockTakingOptions> <CustomerInfo>k__BackingField;

		// Token: 0x0400184F RID: 6223
		[CompilerGenerated]
		private bool <IsMatchClientVisible>k__BackingField;

		// Token: 0x04001850 RID: 6224
		[CompilerGenerated]
		private ObservableCollection<IManufacturer> <Makers>k__BackingField;

		// Token: 0x04001851 RID: 6225
		[CompilerGenerated]
		private List<UserMaster> <Masters>k__BackingField;

		// Token: 0x04001852 RID: 6226
		[CompilerGenerated]
		private List<PhoneOptions> <PhoneOptions>k__BackingField;

		// Token: 0x04001853 RID: 6227
		[CompilerGenerated]
		private int <RepairsCount>k__BackingField;

		// Token: 0x04001854 RID: 6228
		[CompilerGenerated]
		private int <PurchasesCount>k__BackingField;

		// Token: 0x04001855 RID: 6229
		[CompilerGenerated]
		private ClientAndDevices <SelectedMatch>k__BackingField;

		// Token: 0x04001856 RID: 6230
		[CompilerGenerated]
		private bool <OpenClietcCardBtnVis>k__BackingField;

		// Token: 0x04001857 RID: 6231
		public bool EnableSearch;

		// Token: 0x04001858 RID: 6232
		[CompilerGenerated]
		private List<boxes> <Boxes>k__BackingField;

		// Token: 0x04001859 RID: 6233
		[CompilerGenerated]
		private bool <CompaniesVisible>k__BackingField;

		// Token: 0x02000452 RID: 1106
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__65 : IAsyncStateMachine
		{
			// Token: 0x06002BC5 RID: 11205 RVA: 0x0008B710 File Offset: 0x00089910
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AcceptNewViewModelBase acceptNewViewModelBase = this.<>4__this;
				try
				{
					TaskAwaiter<List<boxes>> awaiter;
					if (num != 0)
					{
						if (!acceptNewViewModelBase.ShowBoxes)
						{
							goto IL_83;
						}
						awaiter = RepairModel.LoadNonItemBoxes(null, false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, AcceptNewViewModelBase.<Init>d__65>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<boxes>>);
						this.<>1__state = -1;
					}
					List<boxes> result = awaiter.GetResult();
					acceptNewViewModelBase.Boxes = result;
					IL_83:
					acceptNewViewModelBase.EndInit();
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

			// Token: 0x06002BC6 RID: 11206 RVA: 0x0008B7E4 File Offset: 0x000899E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400185A RID: 6234
			public int <>1__state;

			// Token: 0x0400185B RID: 6235
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400185C RID: 6236
			public AcceptNewViewModelBase <>4__this;

			// Token: 0x0400185D RID: 6237
			private TaskAwaiter<List<boxes>> <>u__1;
		}

		// Token: 0x02000453 RID: 1107
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetCustomer>d__68 : IAsyncStateMachine
		{
			// Token: 0x06002BC7 RID: 11207 RVA: 0x0008B800 File Offset: 0x00089A00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AcceptNewViewModelBase acceptNewViewModelBase = this.<>4__this;
				try
				{
					TaskAwaiter<clients> awaiter;
					if (num != 0)
					{
						awaiter = Bootstrapper.Container.Resolve<ICustomerService>().GetCustomerAsync(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<clients>, AcceptNewViewModelBase.<SetCustomer>d__68>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<clients>);
						this.<>1__state = -1;
					}
					clients result = awaiter.GetResult();
					acceptNewViewModelBase.SetCustomer(result.Client2CustomerCard());
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

			// Token: 0x06002BC8 RID: 11208 RVA: 0x0008B8D0 File Offset: 0x00089AD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400185E RID: 6238
			public int <>1__state;

			// Token: 0x0400185F RID: 6239
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001860 RID: 6240
			public int customerId;

			// Token: 0x04001861 RID: 6241
			public AcceptNewViewModelBase <>4__this;

			// Token: 0x04001862 RID: 6242
			private TaskAwaiter<clients> <>u__1;
		}

		// Token: 0x02000454 RID: 1108
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountCustomerStat>d__74 : IAsyncStateMachine
		{
			// Token: 0x06002BC9 RID: 11209 RVA: 0x0008B8EC File Offset: 0x00089AEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AcceptNewViewModelBase acceptNewViewModelBase = this.<>4__this;
				try
				{
					if (num > 1)
					{
						this.<customerService>5__2 = Bootstrapper.Container.Resolve<ICustomerService>();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								this.<>1__state = -1;
								goto IL_E0;
							}
							awaiter = this.<customerService>5__2.CountRepairs(acceptNewViewModelBase.Customer.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AcceptNewViewModelBase.<CountCustomerStat>d__74>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							this.<>1__state = -1;
						}
						int result = awaiter.GetResult();
						acceptNewViewModelBase.RepairsCount = result;
						awaiter = this.<customerService>5__2.CountPurchases(acceptNewViewModelBase.Customer.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, AcceptNewViewModelBase.<CountCustomerStat>d__74>(ref awaiter, ref this);
							return;
						}
						IL_E0:
						result = awaiter.GetResult();
						acceptNewViewModelBase.PurchasesCount = result;
					}
					catch (Exception ex)
					{
						acceptNewViewModelBase._ascMessageBoxService.ShowMessageBox("Get customer repairs/purchases count error: " + ex.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<customerService>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<customerService>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002BCA RID: 11210 RVA: 0x0008BA9C File Offset: 0x00089C9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001863 RID: 6243
			public int <>1__state;

			// Token: 0x04001864 RID: 6244
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001865 RID: 6245
			public AcceptNewViewModelBase <>4__this;

			// Token: 0x04001866 RID: 6246
			private ICustomerService <customerService>5__2;

			// Token: 0x04001867 RID: 6247
			private TaskAwaiter<int> <>u__1;
		}
	}
}
