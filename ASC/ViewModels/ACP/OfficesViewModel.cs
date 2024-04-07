using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000597 RID: 1431
	public class OfficesViewModel : CollectionViewModel<IOfficeLookup>, IOfficesViewModel, IRefreshable
	{
		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x000B3BB0 File Offset: 0x000B1DB0
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x000B3BF4 File Offset: 0x000B1DF4
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

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x000B3C5C File Offset: 0x000B1E5C
		public string GroupHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupHeader>k__BackingField;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x000B3C70 File Offset: 0x000B1E70
		public string ListHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<ListHeader>k__BackingField;
			}
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x000B3C84 File Offset: 0x000B1E84
		public OfficesViewModel(IOfficeService officeService, IWindowedDocumentService windowedDocumentService, IToasterService toasterService)
		{
			this._officeService = officeService;
			this._windowedDocumentService = windowedDocumentService;
			this._toasterService = toasterService;
			this.GroupHeader = Lang.t("Offices");
			this.ListHeader = Lang.t("OfficesList");
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		[Command]
		public void ShowCreate()
		{
			IPopupViewModel viewModel = Bootstrapper.Container.ResolveNamed("OfficeEditViewModel");
			this._windowedDocumentService.ShowNewDocument("OfficeEditView", viewModel, this, null);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000B3CFC File Offset: 0x000B1EFC
		public bool CanShowCreate()
		{
			return OfflineData.Instance.Employee.Can(1, 0);
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000B3D1C File Offset: 0x000B1F1C
		[Command]
		public void ShowEdit()
		{
			IPopupViewModel viewModel = Bootstrapper.Container.ResolveNamed("OfficeEditViewModel");
			this._windowedDocumentService.ShowNewDocument("OfficeEditView", viewModel, this, base.SelectedItem.Id);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x000B3D5C File Offset: 0x000B1F5C
		public bool CanShowEdit()
		{
			return base.SelectedItem != null && OfflineData.Instance.Employee.Can(1, 0);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x000B3D84 File Offset: 0x000B1F84
		public override void OnLoad()
		{
			base.OnLoad();
			this.LoadItems();
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x000B3DA0 File Offset: 0x000B1FA0
		[Command]
		public void Refresh()
		{
			this.LoadItems();
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000B3DB4 File Offset: 0x000B1FB4
		public void LoadItems()
		{
			OfficesViewModel.<LoadItems>d__19 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<OfficesViewModel.<LoadItems>d__19>(ref <LoadItems>d__);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000B3DA0 File Offset: 0x000B1FA0
		public void DataRefresh()
		{
			this.LoadItems();
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x000B3DEC File Offset: 0x000B1FEC
		[CompilerGenerated]
		private Task<IEnumerable<IOfficeLookup>> <LoadItems>b__19_0()
		{
			return this._officeService.GetOfficesLookupAsync();
		}

		// Token: 0x04001E7B RID: 7803
		protected IOfficeService _officeService;

		// Token: 0x04001E7C RID: 7804
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001E7D RID: 7805
		private IToasterService _toasterService;

		// Token: 0x04001E7E RID: 7806
		[CompilerGenerated]
		private readonly string <GroupHeader>k__BackingField;

		// Token: 0x04001E7F RID: 7807
		[CompilerGenerated]
		private readonly string <ListHeader>k__BackingField;

		// Token: 0x02000598 RID: 1432
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__19 : IAsyncStateMachine
		{
			// Token: 0x060034E7 RID: 13543 RVA: 0x000B3E04 File Offset: 0x000B2004
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficesViewModel officesViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						officesViewModel.Items.Clear();
					}
					try
					{
						TaskAwaiter<IEnumerable<IOfficeLookup>> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<IEnumerable<IOfficeLookup>>(() => officesViewModel._officeService.GetOfficesLookupAsync()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IOfficeLookup>>, OfficesViewModel.<LoadItems>d__19>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<IOfficeLookup>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						IEnumerator<IOfficeLookup> enumerator = awaiter.GetResult().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								IOfficeLookup officeLookup = enumerator.Current;
								if (officesViewModel.ShowArchive || officeLookup.State != 0)
								{
									officesViewModel.Items.Add(officeLookup);
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
					}
					catch (Exception ex)
					{
						officesViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x060034E8 RID: 13544 RVA: 0x000B3F4C File Offset: 0x000B214C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E80 RID: 7808
			public int <>1__state;

			// Token: 0x04001E81 RID: 7809
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E82 RID: 7810
			public OfficesViewModel <>4__this;

			// Token: 0x04001E83 RID: 7811
			private TaskAwaiter<IEnumerable<IOfficeLookup>> <>u__1;
		}
	}
}
