using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Messages;
using ASC.Services;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000576 RID: 1398
	public class CompaniesViewModel : CollectionViewModel<ICompanyLookUp>, IOfficesViewModel, IRefreshable
	{
		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000AEB3C File Offset: 0x000ACD3C
		public string GroupHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupHeader>k__BackingField;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x000AEB50 File Offset: 0x000ACD50
		public string ListHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<ListHeader>k__BackingField;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x000AEB64 File Offset: 0x000ACD64
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x000AEBA8 File Offset: 0x000ACDA8
		public bool ShowArchive
		{
			get
			{
				return base.GetProperty<bool>(() => this.ShowArchive);
			}
			set
			{
				if (this.ShowArchive == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.ShowArchive, value, new Action(this.LoadItems));
				this.RaisePropertyChanged("ShowArchive");
			}
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x000AEC10 File Offset: 0x000ACE10
		public CompaniesViewModel(ICompanyService companyService, IWindowedDocumentService windowedDocumentService)
		{
			this._companyService = companyService;
			this._windowedDocumentService = windowedDocumentService;
			this.GroupHeader = Lang.t("Companies");
			this.ListHeader = Lang.t("ListOfCompanies");
			this.LoadItems();
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x000AEC58 File Offset: 0x000ACE58
		public void LoadItems()
		{
			CompaniesViewModel.<LoadItems>d__12 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<CompaniesViewModel.<LoadItems>d__12>(ref <LoadItems>d__);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x000AEC90 File Offset: 0x000ACE90
		[Command]
		public void ShowCreate()
		{
			CompanyEditViewModel viewModel = Bootstrapper.Container.Resolve<CompanyEditViewModel>();
			viewModel.SetParentViewModel(this);
			this._windowedDocumentService.ShowNewDocument("CompanyEditView", viewModel, null, null);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000AECC4 File Offset: 0x000ACEC4
		[Command]
		public void ShowEdit()
		{
			CompanyEditViewModel viewModel = Bootstrapper.Container.Resolve<CompanyEditViewModel>();
			viewModel.SetParentViewModel(this);
			Messenger.Default.Send(new OpenCompanyEditMessage(base.SelectedItem.Id));
			this._windowedDocumentService.ShowNewDocument("CompanyEditView", viewModel, null, null);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000AED14 File Offset: 0x000ACF14
		public bool CanShowEdit()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x000AED2C File Offset: 0x000ACF2C
		[Command]
		public void Refresh()
		{
			this.LoadItems();
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x000AED40 File Offset: 0x000ACF40
		public void DataRefresh()
		{
			this.Refresh();
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000AED54 File Offset: 0x000ACF54
		[CompilerGenerated]
		private Task<IEnumerable<ICompanyLookUp>> <LoadItems>b__12_0()
		{
			return this._companyService.GetCompaniesLookup();
		}

		// Token: 0x04001DC4 RID: 7620
		protected ICompanyService _companyService;

		// Token: 0x04001DC5 RID: 7621
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001DC6 RID: 7622
		[CompilerGenerated]
		private readonly string <GroupHeader>k__BackingField;

		// Token: 0x04001DC7 RID: 7623
		[CompilerGenerated]
		private readonly string <ListHeader>k__BackingField;

		// Token: 0x02000577 RID: 1399
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__12 : IAsyncStateMachine
		{
			// Token: 0x060033B5 RID: 13237 RVA: 0x000AED6C File Offset: 0x000ACF6C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CompaniesViewModel companiesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<ICompanyLookUp>> awaiter;
					if (num != 0)
					{
						companiesViewModel.ShowWait();
						awaiter = Task.Run<IEnumerable<ICompanyLookUp>>(() => companiesViewModel._companyService.GetCompaniesLookup()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<ICompanyLookUp>>, CompaniesViewModel.<LoadItems>d__12>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<ICompanyLookUp>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					IEnumerable<ICompanyLookUp> result = awaiter.GetResult();
					companiesViewModel.Items.Clear();
					IEnumerator<ICompanyLookUp> enumerator = result.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ICompanyLookUp companyLookUp = enumerator.Current;
							if (companiesViewModel.ShowArchive || companyLookUp.State)
							{
								companiesViewModel.Items.Add(companyLookUp);
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					companiesViewModel.HideWait();
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

			// Token: 0x060033B6 RID: 13238 RVA: 0x000AEE98 File Offset: 0x000AD098
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DC8 RID: 7624
			public int <>1__state;

			// Token: 0x04001DC9 RID: 7625
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001DCA RID: 7626
			public CompaniesViewModel <>4__this;

			// Token: 0x04001DCB RID: 7627
			private TaskAwaiter<IEnumerable<ICompanyLookUp>> <>u__1;
		}
	}
}
