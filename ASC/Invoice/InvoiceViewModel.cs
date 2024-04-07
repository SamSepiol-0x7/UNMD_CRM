using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.Invoice
{
	// Token: 0x02000AF7 RID: 2807
	internal class InvoiceViewModel : BaseViewModel, IReturnOnSelect, IIsDataLoading
	{
		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x001577E8 File Offset: 0x001559E8
		// (set) Token: 0x06004F50 RID: 20304 RVA: 0x001577FC File Offset: 0x001559FC
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06004F51 RID: 20305 RVA: 0x0015782C File Offset: 0x00155A2C
		// (set) Token: 0x06004F52 RID: 20306 RVA: 0x00157840 File Offset: 0x00155A40
		public ObservableCollection<IInvoice> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x00157870 File Offset: 0x00155A70
		// (set) Token: 0x06004F54 RID: 20308 RVA: 0x00157884 File Offset: 0x00155A84
		public IInvoice SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1192358239;
				IL_13:
				switch ((num ^ 969632862) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<SelectedItem>k__BackingField = value;
					this.RaisePropertyChanged("SelectedItem");
					num = 807303450;
					goto IL_13;
				}
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x001578E0 File Offset: 0x00155AE0
		// (set) Token: 0x06004F56 RID: 20310 RVA: 0x001578F4 File Offset: 0x00155AF4
		public int SelectedOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedOffice>k__BackingField == value)
				{
					return;
				}
				this.<SelectedOffice>k__BackingField = value;
				this.RaisePropertyChanged("SelectedOffice");
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06004F57 RID: 20311 RVA: 0x00157920 File Offset: 0x00155B20
		// (set) Token: 0x06004F58 RID: 20312 RVA: 0x00157934 File Offset: 0x00155B34
		public List<IIdName> InvoiceStates
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceStates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<InvoiceStates>k__BackingField, value))
				{
					return;
				}
				this.<InvoiceStates>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceStates");
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06004F59 RID: 20313 RVA: 0x00157964 File Offset: 0x00155B64
		// (set) Token: 0x06004F5A RID: 20314 RVA: 0x00157978 File Offset: 0x00155B78
		public int SelectedInvoiceOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedInvoiceOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedInvoiceOption>k__BackingField == value)
				{
					return;
				}
				this.<SelectedInvoiceOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedInvoiceOption");
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x001579A4 File Offset: 0x00155BA4
		// (set) Token: 0x06004F5C RID: 20316 RVA: 0x001579B8 File Offset: 0x00155BB8
		public List<KeyValuePair<int, string>> DocTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<DocTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DocTypes>k__BackingField, value))
				{
					return;
				}
				this.<DocTypes>k__BackingField = value;
				this.RaisePropertyChanged("DocTypes");
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x001579E8 File Offset: 0x00155BE8
		// (set) Token: 0x06004F5E RID: 20318 RVA: 0x001579FC File Offset: 0x00155BFC
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
				if (this.<ReturnOnSelect>k__BackingField == value)
				{
					return;
				}
				this.<ReturnOnSelect>k__BackingField = value;
				this.RaisePropertyChanged("ReturnOnSelect");
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x00157A28 File Offset: 0x00155C28
		// (set) Token: 0x06004F60 RID: 20320 RVA: 0x00157A3C File Offset: 0x00155C3C
		public string Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				if (string.Equals(this._filter, value, StringComparison.Ordinal))
				{
					return;
				}
				this._filter = value;
				this.RaisePropertyChanged("Filter");
				this.LoadDocuments();
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06004F61 RID: 20321 RVA: 0x00157A74 File Offset: 0x00155C74
		// (set) Token: 0x06004F62 RID: 20322 RVA: 0x00157AB8 File Offset: 0x00155CB8
		public int SelectedDocType
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedDocType);
			}
			set
			{
				if (this.SelectedDocType == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedDocType, value, new Action(this.OnTypeChanged));
				this.RaisePropertyChanged("InvoiceStatesVisible");
				this.RaisePropertyChanged("SelectedDocType");
			}
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00157B2C File Offset: 0x00155D2C
		private void OnTypeChanged()
		{
			base.RaisePropertyChanged<bool>(() => this.InvoiceStatesVisible);
			if (base.ViewLoaded)
			{
				this.LoadDocuments();
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00157B7C File Offset: 0x00155D7C
		public bool InvoiceStatesVisible
		{
			get
			{
				return this.SelectedDocType == 0;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06004F65 RID: 20325 RVA: 0x00157B94 File Offset: 0x00155D94
		// (set) Token: 0x06004F66 RID: 20326 RVA: 0x00157BA8 File Offset: 0x00155DA8
		public ICommand RefreshCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RefreshCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RefreshCommand>k__BackingField, value))
				{
					return;
				}
				this.<RefreshCommand>k__BackingField = value;
				this.RaisePropertyChanged("RefreshCommand");
			}
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x00157BD8 File Offset: 0x00155DD8
		private void InitCommands()
		{
			this.RefreshCommand = new RelayCommand(new Action<object>(this.Refresh));
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00157BFC File Offset: 0x00155DFC
		public InvoiceViewModel()
		{
			this._invoiceModel = Bootstrapper.Container.Resolve<IInvoiceModel>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this.SetViewName("Invoices");
			this.InvoiceStates = new List<IIdName>(this._invoiceModel.GetStates(true));
			this.Period = new Period(this._localization.Now.AddDays(-30.0), this._localization.Now);
			this.DocTypes = new List<KeyValuePair<int, string>>(this._invoiceModel.GetDocTypes());
			this.InitCommands();
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00157CB0 File Offset: 0x00155EB0
		public InvoiceViewModel(bool returnOnSelect) : this()
		{
			this.SetViewName("Select", "Invoice");
			this.ReturnOnSelect = returnOnSelect;
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00157CDC File Offset: 0x00155EDC
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IInvoiceSelect);
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x00157CFC File Offset: 0x00155EFC
		protected virtual void LoadDocuments()
		{
			InvoiceViewModel.<LoadDocuments>d__54 <LoadDocuments>d__;
			<LoadDocuments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDocuments>d__.<>4__this = this;
			<LoadDocuments>d__.<>1__state = -1;
			<LoadDocuments>d__.<>t__builder.Start<InvoiceViewModel.<LoadDocuments>d__54>(ref <LoadDocuments>d__);
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x00157D34 File Offset: 0x00155F34
		public override void OnLoad()
		{
			base.SetViewLoaded(true);
			this.LoadDocuments();
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00157D50 File Offset: 0x00155F50
		private void Refresh(object obj)
		{
			this.LoadDocuments();
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00157D64 File Offset: 0x00155F64
		[Command]
		public void InvoiceDoubleClick(object obj)
		{
			InvoiceViewModel.<InvoiceDoubleClick>d__57 <InvoiceDoubleClick>d__;
			<InvoiceDoubleClick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InvoiceDoubleClick>d__.<>4__this = this;
			<InvoiceDoubleClick>d__.<>1__state = -1;
			<InvoiceDoubleClick>d__.<>t__builder.Start<InvoiceViewModel.<InvoiceDoubleClick>d__57>(ref <InvoiceDoubleClick>d__);
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00157D9C File Offset: 0x00155F9C
		[Command]
		public void Create()
		{
			this._navigationService.Navigate("NewInvoiceView", Bootstrapper.Container.Resolve<NewInvoiceViewModel>());
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x00157DC4 File Offset: 0x00155FC4
		[Command]
		public void ShowNewVATInvoice()
		{
			this._navigationService.Navigate("NewVATInvoiceView", new NewVATInvoiceViewModel());
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x00157DE8 File Offset: 0x00155FE8
		[Command]
		public void ShowNewPackingList()
		{
			this._navigationService.Navigate("PackingListView", Bootstrapper.Container.Resolve<PackingListViewModel>());
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x00157E10 File Offset: 0x00156010
		[Command]
		public void ShowNewAct()
		{
			this._navigationService.Navigate("WorksListView", Bootstrapper.Container.Resolve<WorksListViewModel>());
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x00157E38 File Offset: 0x00156038
		// (set) Token: 0x06004F74 RID: 20340 RVA: 0x00157E4C File Offset: 0x0015604C
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x00157E78 File Offset: 0x00156078
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x00157E8C File Offset: 0x0015608C
		[Command]
		public void OpenCustomerCard()
		{
			this._navigationService.NavigateToCustomerCard(this.SelectedItem.Customer.CustomerId, this);
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x00157EB8 File Offset: 0x001560B8
		public bool CanOpenCustomerCard()
		{
			return this.SelectedItem != null && OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x00157EE0 File Offset: 0x001560E0
		[CompilerGenerated]
		private Task<IEnumerable<IInvoice>> <LoadDocuments>b__54_0()
		{
			return this._invoiceModel.GetInvoices(this.Period, this.SelectedOffice, this.SelectedInvoiceOption, (InvoiceModel.DocType)this.SelectedDocType, this.Filter);
		}

		// Token: 0x040034B1 RID: 13489
		private readonly IInvoiceModel _invoiceModel;

		// Token: 0x040034B2 RID: 13490
		private readonly INavigationService _navigationService;

		// Token: 0x040034B3 RID: 13491
		private IInvoiceSelect _parentViewModel;

		// Token: 0x040034B4 RID: 13492
		private Localization _localization = new Localization("UTC");

		// Token: 0x040034B5 RID: 13493
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x040034B6 RID: 13494
		[CompilerGenerated]
		private ObservableCollection<IInvoice> <Items>k__BackingField;

		// Token: 0x040034B7 RID: 13495
		[CompilerGenerated]
		private IInvoice <SelectedItem>k__BackingField;

		// Token: 0x040034B8 RID: 13496
		[CompilerGenerated]
		private int <SelectedOffice>k__BackingField;

		// Token: 0x040034B9 RID: 13497
		[CompilerGenerated]
		private List<IIdName> <InvoiceStates>k__BackingField;

		// Token: 0x040034BA RID: 13498
		[CompilerGenerated]
		private int <SelectedInvoiceOption>k__BackingField;

		// Token: 0x040034BB RID: 13499
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <DocTypes>k__BackingField;

		// Token: 0x040034BC RID: 13500
		[CompilerGenerated]
		private bool <ReturnOnSelect>k__BackingField;

		// Token: 0x040034BD RID: 13501
		private string _filter;

		// Token: 0x040034BE RID: 13502
		[CompilerGenerated]
		private ICommand <RefreshCommand>k__BackingField;

		// Token: 0x040034BF RID: 13503
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x02000AF8 RID: 2808
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocuments>d__54 : IAsyncStateMachine
		{
			// Token: 0x06004F79 RID: 20345 RVA: 0x00157F18 File Offset: 0x00156118
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceViewModel invoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IInvoice>> awaiter;
					if (num != 0)
					{
						invoiceViewModel.SetIsDataLoading(true);
						awaiter = Task.Run<IEnumerable<IInvoice>>(() => invoiceViewModel._invoiceModel.GetInvoices(base.Period, base.SelectedOffice, base.SelectedInvoiceOption, (InvoiceModel.DocType)base.SelectedDocType, base.Filter)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IInvoice>>, InvoiceViewModel.<LoadDocuments>d__54>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IInvoice>>);
						this.<>1__state = -1;
					}
					IEnumerable<IInvoice> result = awaiter.GetResult();
					invoiceViewModel.Items = new ObservableCollection<IInvoice>(result);
					invoiceViewModel.SetIsDataLoading(false);
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

			// Token: 0x06004F7A RID: 20346 RVA: 0x00157FF4 File Offset: 0x001561F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034C0 RID: 13504
			public int <>1__state;

			// Token: 0x040034C1 RID: 13505
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034C2 RID: 13506
			public InvoiceViewModel <>4__this;

			// Token: 0x040034C3 RID: 13507
			private TaskAwaiter<IEnumerable<IInvoice>> <>u__1;
		}

		// Token: 0x02000AF9 RID: 2809
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <InvoiceDoubleClick>d__57 : IAsyncStateMachine
		{
			// Token: 0x06004F7B RID: 20347 RVA: 0x00158010 File Offset: 0x00156210
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceViewModel invoiceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (invoiceViewModel.SelectedItem == null)
						{
							goto IL_1AB;
						}
						if (!invoiceViewModel.ReturnOnSelect)
						{
							if (invoiceViewModel.SelectedItem is IVATInvoice)
							{
								NewVATInvoiceViewModel newVATInvoiceViewModel = Bootstrapper.Container.Resolve<NewVATInvoiceViewModel>();
								newVATInvoiceViewModel.SetDocumentIdToLoad(invoiceViewModel.SelectedItem.Id);
								invoiceViewModel._navigationService.Navigate("NewVATInvoiceView", newVATInvoiceViewModel);
								goto IL_1AB;
							}
							if (invoiceViewModel.SelectedItem is IPackingList)
							{
								PackingListViewModel packingListViewModel = Bootstrapper.Container.Resolve<PackingListViewModel>();
								packingListViewModel.SetDocumentIdToLoad(invoiceViewModel.SelectedItem.Id);
								invoiceViewModel._navigationService.Navigate("PackingListView", packingListViewModel);
								goto IL_1AB;
							}
							if (!(invoiceViewModel.SelectedItem is IWorksList))
							{
								if (invoiceViewModel.SelectedItem != null)
								{
									invoiceViewModel._navigationService.NavigateInvoice(invoiceViewModel.SelectedItem.Id);
								}
								goto IL_1AB;
							}
							WorksListViewModel worksListViewModel = Bootstrapper.Container.Resolve<WorksListViewModel>();
							worksListViewModel.SetDocumentIdToLoad(invoiceViewModel.SelectedItem.Id);
							invoiceViewModel._navigationService.Navigate("WorksListView", worksListViewModel);
							goto IL_1AB;
						}
						else
						{
							if (invoiceViewModel._parentViewModel == null)
							{
								goto IL_185;
							}
							awaiter = invoiceViewModel._parentViewModel.SelectInvoice(invoiceViewModel.SelectedItem.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceViewModel.<InvoiceDoubleClick>d__57>(ref awaiter, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					IL_185:
					invoiceViewModel._navigationService.CloseCurrentTab();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1AB:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004F7C RID: 20348 RVA: 0x001581F8 File Offset: 0x001563F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034C4 RID: 13508
			public int <>1__state;

			// Token: 0x040034C5 RID: 13509
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034C6 RID: 13510
			public InvoiceViewModel <>4__this;

			// Token: 0x040034C7 RID: 13511
			private TaskAwaiter <>u__1;
		}
	}
}
