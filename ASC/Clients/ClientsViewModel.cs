using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.ViewModel;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using ExcelDataReader;
using Microsoft.Win32;

namespace ASC.Clients
{
	// Token: 0x020001A5 RID: 421
	public class ClientsViewModel : CollectionViewModel<ICustomer>, IReturnOnSelect, IRefreshable
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00043A0C File Offset: 0x00041C0C
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x00043A54 File Offset: 0x00041C54
		public bool ShowArhiveClients
		{
			get
			{
				return base.GetProperty<bool>(() => Settings.Default.ClShowArchive);
			}
			set
			{
				if (this.ShowArhiveClients == value)
				{
					return;
				}
				base.SetProperty<bool>(() => Settings.Default.ClShowArchive, value, new Action(this.OnShowArchiveChanged));
				this.RaisePropertyChanged("ShowArhiveClients");
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00043AC0 File Offset: 0x00041CC0
		public bool DisplayArchive
		{
			get
			{
				return this.SelectedClientType == 3;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00043AD8 File Offset: 0x00041CD8
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x00043AEC File Offset: 0x00041CEC
		public int SelectedVisitSource
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedVisitSource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedVisitSource>k__BackingField == value)
				{
					return;
				}
				this.<SelectedVisitSource>k__BackingField = value;
				this.RaisePropertyChanged("SelectedVisitSource");
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x00043B18 File Offset: 0x00041D18
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x00043B2C File Offset: 0x00041D2C
		public ObservableCollection<ICustomerType> ClientTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ClientTypes>k__BackingField, value))
				{
					return;
				}
				this.<ClientTypes>k__BackingField = value;
				this.RaisePropertyChanged("ClientTypes");
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x00043B5C File Offset: 0x00041D5C
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x00043BA0 File Offset: 0x00041DA0
		public int SelectedClientType
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedClientType);
			}
			set
			{
				if (this.SelectedClientType == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedClientType, value, new Action(this.ClientTypeChanged));
				this.RaisePropertyChanged("DisplayArchive");
				this.RaisePropertyChanged("SelectedClientType");
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00043C14 File Offset: 0x00041E14
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x00043C28 File Offset: 0x00041E28
		public bool ImportMode
		{
			[CompilerGenerated]
			get
			{
				return this.<ImportMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ImportMode>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -238842310;
				IL_10:
				switch ((num ^ -1663233741) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					this.<ImportMode>k__BackingField = value;
					this.RaisePropertyChanged("ImportMode");
					num = -12655209;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00043C80 File Offset: 0x00041E80
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00043C94 File Offset: 0x00041E94
		public bool ReturnOnSelect
		{
			[CompilerGenerated]
			get
			{
				return this.<ReturnOnSelect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReturnOnSelect>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1935517917;
				IL_10:
				switch ((num ^ -548090807) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<ReturnOnSelect>k__BackingField = value;
					this.RaisePropertyChanged("ReturnOnSelect");
					num = -464193890;
					goto IL_10;
				case 2:
					return;
				}
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00043CEC File Offset: 0x00041EEC
		private void IoC()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._customerService = Bootstrapper.Container.Resolve<ICustomerService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00043D3C File Offset: 0x00041F3C
		public ClientsViewModel()
		{
			this.IoC();
			this.SetViewName("Clients");
			this.Common();
			this.SetDefaultCustomerType();
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00043D6C File Offset: 0x00041F6C
		public ClientsViewModel(string act)
		{
			this.IoC();
			this.SetViewName("Select", "Clients");
			this._act = act;
			this.Common();
			if (act == "selectDealer")
			{
				this.SelectedClientType = 1;
				this.ReturnOnSelect = true;
				return;
			}
			if (act == "selectClient")
			{
				this.SetDefaultCustomerType();
				this.ReturnOnSelect = true;
				return;
			}
			if (!(act == "selectCompany"))
			{
				return;
			}
			this.SelectedClientType = 5;
			this.ReturnOnSelect = true;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00043DF8 File Offset: 0x00041FF8
		[Command]
		public void OnLoaded()
		{
			ClientsViewModel.<OnLoaded>d__33 <OnLoaded>d__;
			<OnLoaded>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoaded>d__.<>4__this = this;
			<OnLoaded>d__.<>1__state = -1;
			<OnLoaded>d__.<>t__builder.Start<ClientsViewModel.<OnLoaded>d__33>(ref <OnLoaded>d__);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00043E30 File Offset: 0x00042030
		private void Common()
		{
			if (!Auth.Config.clients_are_dealers && this._act == "selectDealer")
			{
				this.ClientTypes = new ObservableCollection<ICustomerType>
				{
					this._customerService.GetCustomerType(CustomerModel.Type.Dealer)
				};
				return;
			}
			this.ClientTypes = new ObservableCollection<ICustomerType>(this._customerService.GetCustomerTypes());
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00043E90 File Offset: 0x00042090
		private void OnShowArchiveChanged()
		{
			ClientsViewModel.<OnShowArchiveChanged>d__35 <OnShowArchiveChanged>d__;
			<OnShowArchiveChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnShowArchiveChanged>d__.<>4__this = this;
			<OnShowArchiveChanged>d__.<>1__state = -1;
			<OnShowArchiveChanged>d__.<>t__builder.Start<ClientsViewModel.<OnShowArchiveChanged>d__35>(ref <OnShowArchiveChanged>d__);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00043EC8 File Offset: 0x000420C8
		private void SetDefaultCustomerType()
		{
			this.SelectedClientType = (Auth.User.prefer_regular ? 0 : 3);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00043EEC File Offset: 0x000420EC
		protected override void OnSearchStringChanged(string oldValue)
		{
			ClientsViewModel.<OnSearchStringChanged>d__37 <OnSearchStringChanged>d__;
			<OnSearchStringChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnSearchStringChanged>d__.<>4__this = this;
			<OnSearchStringChanged>d__.<>1__state = -1;
			<OnSearchStringChanged>d__.<>t__builder.Start<ClientsViewModel.<OnSearchStringChanged>d__37>(ref <OnSearchStringChanged>d__);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00043F24 File Offset: 0x00042124
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as ICustomerSelect);
			if (this._parentViewModel != null)
			{
				base.SelectedItem = null;
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00043F54 File Offset: 0x00042154
		public ICustomerSelect GetParentViewModel()
		{
			return this._parentViewModel;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00043F68 File Offset: 0x00042168
		[Command]
		public void ClientsRefresh()
		{
			ClientsViewModel.<ClientsRefresh>d__40 <ClientsRefresh>d__;
			<ClientsRefresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ClientsRefresh>d__.<>4__this = this;
			<ClientsRefresh>d__.<>1__state = -1;
			<ClientsRefresh>d__.<>t__builder.Start<ClientsViewModel.<ClientsRefresh>d__40>(ref <ClientsRefresh>d__);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00043FA0 File Offset: 0x000421A0
		private void SetImportMode(bool value)
		{
			this.ImportMode = value;
			base.RaiseCanExecuteChanged(() => this.MakeImport());
			base.RaiseCanExecuteChanged(() => this.CreateCustomer());
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0004402C File Offset: 0x0004222C
		private Task LoadCustomers(string query)
		{
			ClientsViewModel.<LoadCustomers>d__42 <LoadCustomers>d__;
			<LoadCustomers>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadCustomers>d__.<>4__this = this;
			<LoadCustomers>d__.query = query;
			<LoadCustomers>d__.<>1__state = -1;
			<LoadCustomers>d__.<>t__builder.Start<ClientsViewModel.<LoadCustomers>d__42>(ref <LoadCustomers>d__);
			return <LoadCustomers>d__.<>t__builder.Task;
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00044078 File Offset: 0x00042278
		[Command]
		public void ClientDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			if (this.ReturnOnSelect)
			{
				if (this._parentViewModel != null && base.SelectedItem != null)
				{
					this._parentViewModel.SelectCustomerFromList(base.SelectedItem);
					this._navigationService.CloseCurrentTab();
					return;
				}
			}
			else
			{
				this._navigationService.NavigateToCustomerCard(base.SelectedItem.Id, null);
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000440DC File Offset: 0x000422DC
		[Command]
		public void ImportClients()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Excel  (*.XLS, *.XLSX) | *.XLS; *.XLSX"
			};
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				List<Customer> list = this.ImportCustomers(openFileDialog.FileName);
				if (!list.Any<Customer>())
				{
					this.SetImportMode(false);
					return;
				}
				this.SetImportMode(true);
				base.SetItems(list);
				this._toasterService.Info(Lang.t("CheckAndSave"));
			}
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00044158 File Offset: 0x00042358
		public bool CanImportClients()
		{
			return !this.ReturnOnSelect;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00044170 File Offset: 0x00042370
		public List<Customer> ImportCustomers(string filename)
		{
			List<Customer> list = new List<Customer>();
			try
			{
				using (FileStream fileStream = File.Open(filename, FileMode.Open, FileAccess.Read))
				{
					try
					{
						using (IExcelDataReader excelDataReader = (Path.GetExtension(filename).ToLower() == ".xlsx") ? ExcelReaderFactory.CreateOpenXmlReader(fileStream, null) : ExcelReaderFactory.CreateBinaryReader(fileStream, null))
						{
							foreach (object obj in excelDataReader.AsDataSet(null).Tables[0].Rows)
							{
								DataRow dataRow = (DataRow)obj;
								if (!string.IsNullOrEmpty(dataRow[0].ToString()))
								{
									Customer customer = new Customer
									{
										LastName = string.Empty,
										FirstName = string.Empty,
										Patronymic = string.Empty
									};
									bool flag = this.ImportIsUr(dataRow);
									customer.Type = (flag ? 1 : 0);
									if (flag && dataRow[0] != null)
									{
										customer.UrName = dataRow[0].ToString();
									}
									if (!flag && dataRow[0] != null)
									{
										this.ImportFillFio(dataRow, customer);
									}
									if (dataRow[1] != null)
									{
										string phone = dataRow[1].ToString().Replace(" ", "");
										customer.Phone = phone;
									}
									if (dataRow[2] != null)
									{
										customer.Address = dataRow[2].ToString();
									}
									if (dataRow[3] != null)
									{
										customer.Email = dataRow[3].ToString();
									}
									list.Add(customer);
								}
							}
						}
					}
					catch (Exception ex)
					{
						this._toasterService.Error(ex.Message);
					}
				}
			}
			catch (IOException ex2)
			{
				this._toasterService.Error(ex2.Message);
			}
			return list;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000443D4 File Offset: 0x000425D4
		private void ImportFillFio(DataRow row, Customer client)
		{
			string[] array = row[0].ToString().Split(new char[]
			{
				' '
			});
			if (array.Length != 0)
			{
				client.LastName = (array[0] ?? string.Empty);
			}
			if (array.Length > 1)
			{
				client.FirstName = (array[1] ?? string.Empty);
			}
			if (array.Length > 2)
			{
				client.Patronymic = (array[2] ?? string.Empty);
			}
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00044444 File Offset: 0x00042644
		private bool ImportIsUr(DataRow row)
		{
			if (row[4] != null)
			{
				if (row[4].ToString() == "Да")
				{
					return true;
				}
				if (row[4].ToString() == "1")
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00044490 File Offset: 0x00042690
		[Command]
		public void MakeImport()
		{
			ClientsViewModel.<MakeImport>d__49 <MakeImport>d__;
			<MakeImport>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<MakeImport>d__.<>4__this = this;
			<MakeImport>d__.<>1__state = -1;
			<MakeImport>d__.<>t__builder.Start<ClientsViewModel.<MakeImport>d__49>(ref <MakeImport>d__);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000444C8 File Offset: 0x000426C8
		public bool CanMakeImport()
		{
			return this.ImportMode;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000444DC File Offset: 0x000426DC
		[Command]
		public void CreateCustomer()
		{
			this._windowedDocumentService.ShowNewDocument("CustomerCreateView", Bootstrapper.Container.Resolve<AddCustomerViewModel>(), this, null);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00044508 File Offset: 0x00042708
		public bool CanCreateCustomer()
		{
			return base.IsValid() && !this.ImportMode && !this.ReturnOnSelect;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00044530 File Offset: 0x00042730
		private void ClientTypeChanged()
		{
			if (base.ViewLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1231411246;
			IL_0D:
			switch ((num ^ -2127255441) % 4)
			{
			case 1:
				return;
			case 2:
				IL_2C:
				this.ClientsRefresh();
				num = -889571913;
				goto IL_0D;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00044578 File Offset: 0x00042778
		[Command]
		public void MergeCustomers()
		{
			this._windowedDocumentService.ShowNewDocument("MergeCustomersView", new MergeCustomersViewModel(base.SelectedItems), this, null);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000445A4 File Offset: 0x000427A4
		public bool CanMergeCustomers()
		{
			return !this.ReturnOnSelect && OfflineData.Instance.Employee.Can(11, 0) && base.SelectedItems != null && base.SelectedItems.Count > 1;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000445E8 File Offset: 0x000427E8
		public override void OnSelectedItemsChanged(List<ICustomer> items)
		{
			base.RaiseCanExecuteChanged(() => this.MergeCustomers());
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00044630 File Offset: 0x00042830
		public void DataRefresh()
		{
			ClientsViewModel.<DataRefresh>d__57 <DataRefresh>d__;
			<DataRefresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DataRefresh>d__.<>4__this = this;
			<DataRefresh>d__.<>1__state = -1;
			<DataRefresh>d__.<>t__builder.Start<ClientsViewModel.<DataRefresh>d__57>(ref <DataRefresh>d__);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00044668 File Offset: 0x00042868
		[CompilerGenerated]
		private IAscResult <MakeImport>b__49_0()
		{
			return ClientsModel.CreateManyClients(base.Items);
		}

		// Token: 0x04000C93 RID: 3219
		private ICustomerSelect _parentViewModel;

		// Token: 0x04000C94 RID: 3220
		protected ICustomerService _customerService;

		// Token: 0x04000C95 RID: 3221
		private INavigationService _navigationService;

		// Token: 0x04000C96 RID: 3222
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000C97 RID: 3223
		private IToasterService _toasterService;

		// Token: 0x04000C98 RID: 3224
		[CompilerGenerated]
		private int <SelectedVisitSource>k__BackingField;

		// Token: 0x04000C99 RID: 3225
		[CompilerGenerated]
		private ObservableCollection<ICustomerType> <ClientTypes>k__BackingField;

		// Token: 0x04000C9A RID: 3226
		[CompilerGenerated]
		private bool <ImportMode>k__BackingField;

		// Token: 0x04000C9B RID: 3227
		[CompilerGenerated]
		private bool <ReturnOnSelect>k__BackingField;

		// Token: 0x04000C9C RID: 3228
		private string _act;

		// Token: 0x020001A6 RID: 422
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060018C7 RID: 6343 RVA: 0x00044680 File Offset: 0x00042880
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060018C8 RID: 6344 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04000C9D RID: 3229
			public static readonly ClientsViewModel.<>c <>9 = new ClientsViewModel.<>c();
		}

		// Token: 0x020001A7 RID: 423
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoaded>d__33 : IAsyncStateMachine
		{
			// Token: 0x060018C9 RID: 6345 RVA: 0x00044698 File Offset: 0x00042898
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ClientsViewModel clientsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						clientsViewModel.SetViewLoaded(true);
						awaiter = clientsViewModel.LoadCustomers(clientsViewModel.SearchString).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ClientsViewModel.<OnLoaded>d__33>(ref awaiter, ref this);
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

			// Token: 0x060018CA RID: 6346 RVA: 0x00044758 File Offset: 0x00042958
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000C9E RID: 3230
			public int <>1__state;

			// Token: 0x04000C9F RID: 3231
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000CA0 RID: 3232
			public ClientsViewModel <>4__this;

			// Token: 0x04000CA1 RID: 3233
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020001A8 RID: 424
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnShowArchiveChanged>d__35 : IAsyncStateMachine
		{
			// Token: 0x060018CB RID: 6347 RVA: 0x00044774 File Offset: 0x00042974
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ClientsViewModel clientsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = clientsViewModel.LoadCustomers(clientsViewModel.SearchString).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ClientsViewModel.<OnShowArchiveChanged>d__35>(ref awaiter, ref this);
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

			// Token: 0x060018CC RID: 6348 RVA: 0x0004482C File Offset: 0x00042A2C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CA2 RID: 3234
			public int <>1__state;

			// Token: 0x04000CA3 RID: 3235
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000CA4 RID: 3236
			public ClientsViewModel <>4__this;

			// Token: 0x04000CA5 RID: 3237
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020001A9 RID: 425
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnSearchStringChanged>d__37 : IAsyncStateMachine
		{
			// Token: 0x060018CD RID: 6349 RVA: 0x00044848 File Offset: 0x00042A48
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ClientsViewModel clientsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = clientsViewModel.LoadCustomers(clientsViewModel.SearchString).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ClientsViewModel.<OnSearchStringChanged>d__37>(ref awaiter, ref this);
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

			// Token: 0x060018CE RID: 6350 RVA: 0x00044900 File Offset: 0x00042B00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CA6 RID: 3238
			public int <>1__state;

			// Token: 0x04000CA7 RID: 3239
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000CA8 RID: 3240
			public ClientsViewModel <>4__this;

			// Token: 0x04000CA9 RID: 3241
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020001AA RID: 426
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ClientsRefresh>d__40 : IAsyncStateMachine
		{
			// Token: 0x060018CF RID: 6351 RVA: 0x0004491C File Offset: 0x00042B1C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ClientsViewModel clientsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = clientsViewModel.LoadCustomers(clientsViewModel.SearchString).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ClientsViewModel.<ClientsRefresh>d__40>(ref awaiter, ref this);
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

			// Token: 0x060018D0 RID: 6352 RVA: 0x000449D4 File Offset: 0x00042BD4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CAA RID: 3242
			public int <>1__state;

			// Token: 0x04000CAB RID: 3243
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000CAC RID: 3244
			public ClientsViewModel <>4__this;

			// Token: 0x04000CAD RID: 3245
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020001AB RID: 427
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x060018D1 RID: 6353 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x060018D2 RID: 6354 RVA: 0x000449F0 File Offset: 0x00042BF0
			internal Task<IEnumerable<ICustomer>> <LoadCustomers>b__0()
			{
				return this.<>4__this._customerService.GetCustomers(this.<>4__this.SelectedClientType, this.<>4__this.SelectedVisitSource, this.query, this.<>4__this.ShowArhiveClients);
			}

			// Token: 0x04000CAE RID: 3246
			public ClientsViewModel <>4__this;

			// Token: 0x04000CAF RID: 3247
			public string query;
		}

		// Token: 0x020001AC RID: 428
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCustomers>d__42 : IAsyncStateMachine
		{
			// Token: 0x060018D3 RID: 6355 RVA: 0x00044A34 File Offset: 0x00042C34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ClientsViewModel clientsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<ICustomer>> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new ClientsViewModel.<>c__DisplayClass42_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.query = this.query;
						clientsViewModel.SetImportMode(false);
						clientsViewModel.ShowWait();
						awaiter = Task.Run<IEnumerable<ICustomer>>(new Func<Task<IEnumerable<ICustomer>>>(this.<>8__1.<LoadCustomers>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<ICustomer>>, ClientsViewModel.<LoadCustomers>d__42>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<ICustomer>>);
						this.<>1__state = -1;
					}
					IEnumerable<ICustomer> result = awaiter.GetResult();
					if (clientsViewModel.SearchString == this.<>8__1.query)
					{
						clientsViewModel.SetItems(result);
					}
					clientsViewModel.HideWait();
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

			// Token: 0x060018D4 RID: 6356 RVA: 0x00044B6C File Offset: 0x00042D6C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CB0 RID: 3248
			public int <>1__state;

			// Token: 0x04000CB1 RID: 3249
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000CB2 RID: 3250
			public ClientsViewModel <>4__this;

			// Token: 0x04000CB3 RID: 3251
			public string query;

			// Token: 0x04000CB4 RID: 3252
			private ClientsViewModel.<>c__DisplayClass42_0 <>8__1;

			// Token: 0x04000CB5 RID: 3253
			private TaskAwaiter<IEnumerable<ICustomer>> <>u__1;
		}

		// Token: 0x020001AD RID: 429
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MakeImport>d__49 : IAsyncStateMachine
		{
			// Token: 0x060018D5 RID: 6357 RVA: 0x00044B88 File Offset: 0x00042D88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ClientsViewModel clientsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						if (!clientsViewModel.ImportMode || clientsViewModel.Items.Count == 0)
						{
							goto IL_F9;
						}
						clientsViewModel.ShowWait();
						awaiter = Task.Run<IAscResult>(() => ClientsModel.CreateManyClients(base.Items)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, ClientsViewModel.<MakeImport>d__49>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					clientsViewModel.HideWait();
					clientsViewModel.ShowActionResponse(result.IsSucces, "");
					if (result.IsSucces)
					{
						clientsViewModel.SetImportMode(false);
						clientsViewModel.SelectedClientType = 3;
						clientsViewModel.ClientsRefresh();
					}
					else
					{
						clientsViewModel._toasterService.Error(result.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_F9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060018D6 RID: 6358 RVA: 0x00044CB4 File Offset: 0x00042EB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CB6 RID: 3254
			public int <>1__state;

			// Token: 0x04000CB7 RID: 3255
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000CB8 RID: 3256
			public ClientsViewModel <>4__this;

			// Token: 0x04000CB9 RID: 3257
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x020001AE RID: 430
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DataRefresh>d__57 : IAsyncStateMachine
		{
			// Token: 0x060018D7 RID: 6359 RVA: 0x00044CD0 File Offset: 0x00042ED0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ClientsViewModel clientsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = clientsViewModel.LoadCustomers(clientsViewModel.SearchString).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ClientsViewModel.<DataRefresh>d__57>(ref awaiter, ref this);
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

			// Token: 0x060018D8 RID: 6360 RVA: 0x00044D88 File Offset: 0x00042F88
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CBA RID: 3258
			public int <>1__state;

			// Token: 0x04000CBB RID: 3259
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000CBC RID: 3260
			public ClientsViewModel <>4__this;

			// Token: 0x04000CBD RID: 3261
			private TaskAwaiter <>u__1;
		}
	}
}
