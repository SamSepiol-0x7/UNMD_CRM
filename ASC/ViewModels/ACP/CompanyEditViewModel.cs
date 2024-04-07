using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Messages;
using ASC.Models;
using ASC.Objects;
using ASC.Services;
using ASC.Services.Abstract;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000560 RID: 1376
	public class CompanyEditViewModel : PopupViewModel, IPopupViewModel
	{
		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x000ABFE8 File Offset: 0x000AA1E8
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x000ABFFC File Offset: 0x000AA1FC
		public companies Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000AC02C File Offset: 0x000AA22C
		public CompanyEditViewModel(ICompanyService companyService, IToasterService toasterService)
		{
			this._companyService = companyService;
			this._toasterService = toasterService;
			Messenger.Default.Register(this, new Action<OpenCompanyEditMessage>(this.OnOpenCompanyEdit));
			this.CompanyTypes = CompaniesModel.GetCompanyTypes();
			this.Item = new companies
			{
				type = new int?(0)
			};
			this.SetTitle();
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x000AC08C File Offset: 0x000AA28C
		// (set) Token: 0x06003311 RID: 13073 RVA: 0x000AC0A0 File Offset: 0x000AA2A0
		public List<KeyValuePair<int, string>> CompanyTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanyTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CompanyTypes>k__BackingField, value))
				{
					return;
				}
				this.<CompanyTypes>k__BackingField = value;
				this.RaisePropertyChanged("CompanyTypes");
			}
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000AC0D0 File Offset: 0x000AA2D0
		private void SetTitle()
		{
			base.Title = ((this.Item.id > 0) ? this.Item.name : Lang.t("NewFirm"));
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x000AC108 File Offset: 0x000AA308
		private void OnOpenCompanyEdit(OpenCompanyEditMessage obj)
		{
			CompanyEditViewModel.<OnOpenCompanyEdit>d__14 <OnOpenCompanyEdit>d__;
			<OnOpenCompanyEdit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnOpenCompanyEdit>d__.<>4__this = this;
			<OnOpenCompanyEdit>d__.obj = obj;
			<OnOpenCompanyEdit>d__.<>1__state = -1;
			<OnOpenCompanyEdit>d__.<>t__builder.Start<CompanyEditViewModel.<OnOpenCompanyEdit>d__14>(ref <OnOpenCompanyEdit>d__);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x000AC148 File Offset: 0x000AA348
		private void SetBuzy(bool value)
		{
			this._buzy = value;
			base.RaiseCanExecuteChanged(() => this.Create());
			base.RaiseCanExecuteChanged(() => this.Save());
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000AC1D4 File Offset: 0x000AA3D4
		[AsyncCommand]
		public Task Create()
		{
			CompanyEditViewModel.<Create>d__16 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<CompanyEditViewModel.<Create>d__16>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000AC218 File Offset: 0x000AA418
		public bool CanCreate()
		{
			return this.Item != null && this.Item.id == 0 && !this._buzy;
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000AC248 File Offset: 0x000AA448
		[AsyncCommand]
		public Task Save()
		{
			CompanyEditViewModel.<Save>d__18 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<CompanyEditViewModel.<Save>d__18>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000AC28C File Offset: 0x000AA48C
		public bool CanSave()
		{
			return this.Item != null && this.Item.id > 0 && !this._buzy;
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnLoaded()
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000AC2BC File Offset: 0x000AA4BC
		[Command]
		public void OnUnloaded()
		{
			Messenger.Default.Unregister(this, new Action<OpenCompanyEditMessage>(this.OnOpenCompanyEdit));
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000AC2E0 File Offset: 0x000AA4E0
		private bool CheckFields()
		{
			if (this.Item.accountant != null)
			{
				int? num = this.Item.accountant;
				if (!(num.GetValueOrDefault() == 0 & num != null))
				{
					if (this.Item.director != null)
					{
						num = this.Item.director;
						if (!(num.GetValueOrDefault() == 0 & num != null))
						{
							if (string.IsNullOrEmpty(this.Item.name))
							{
								this._toasterService.Info(Lang.t("InputUrName"));
								return false;
							}
							if (string.IsNullOrEmpty(this.Item.inn))
							{
								this._toasterService.Info(Lang.t("InputInn"));
								return false;
							}
							num = this.Item.type;
							if (!(num.GetValueOrDefault() == 0 & num != null) || !string.IsNullOrEmpty(this.Item.ur_address))
							{
								return true;
							}
							this._toasterService.Info(Lang.t("InputUrAddress"));
							return false;
						}
					}
					this._toasterService.Info(Lang.t("SelectDirector"));
					return false;
				}
			}
			this._toasterService.Info(Lang.t("SelectAccountant"));
			return false;
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000AC430 File Offset: 0x000AA630
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			IOfficesViewModel officesViewModel = obj as IOfficesViewModel;
			if (officesViewModel != null)
			{
				this._parentViewModel = officesViewModel;
			}
		}

		// Token: 0x04001D62 RID: 7522
		protected ICompanyService _companyService;

		// Token: 0x04001D63 RID: 7523
		private readonly IToasterService _toasterService;

		// Token: 0x04001D64 RID: 7524
		[CompilerGenerated]
		private companies <Item>k__BackingField;

		// Token: 0x04001D65 RID: 7525
		private bool _buzy;

		// Token: 0x04001D66 RID: 7526
		private IOfficesViewModel _parentViewModel;

		// Token: 0x04001D67 RID: 7527
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <CompanyTypes>k__BackingField;

		// Token: 0x02000561 RID: 1377
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnOpenCompanyEdit>d__14 : IAsyncStateMachine
		{
			// Token: 0x0600331D RID: 13085 RVA: 0x000AC458 File Offset: 0x000AA658
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CompanyEditViewModel companyEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<companies> awaiter;
					if (num != 0)
					{
						awaiter = companyEditViewModel._companyService.GetCompany(this.obj.CompanyId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<companies>, CompanyEditViewModel.<OnOpenCompanyEdit>d__14>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<companies>);
						this.<>1__state = -1;
					}
					companies result = awaiter.GetResult();
					companyEditViewModel.Item = result;
					companyEditViewModel.SetTitle();
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

			// Token: 0x0600331E RID: 13086 RVA: 0x000AC52C File Offset: 0x000AA72C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D68 RID: 7528
			public int <>1__state;

			// Token: 0x04001D69 RID: 7529
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D6A RID: 7530
			public CompanyEditViewModel <>4__this;

			// Token: 0x04001D6B RID: 7531
			public OpenCompanyEditMessage obj;

			// Token: 0x04001D6C RID: 7532
			private TaskAwaiter<companies> <>u__1;
		}

		// Token: 0x02000562 RID: 1378
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__16 : IAsyncStateMachine
		{
			// Token: 0x0600331F RID: 13087 RVA: 0x000AC548 File Offset: 0x000AA748
			void IAsyncStateMachine.MoveNext()
			{
				CompanyEditViewModel companyEditViewModel = this.<>4__this;
				try
				{
					if (companyEditViewModel.CheckFields())
					{
						bool flag;
						for (;;)
						{
							IL_7A:
							companyEditViewModel.SetBuzy(true);
							for (;;)
							{
								IL_6C:
								flag = CompaniesModel.CreateOrUpdateCompany(companyEditViewModel.Item);
								IL_67:
								while (flag)
								{
									for (;;)
									{
										OfflineData.Instance.ReloadCompanies();
										IOfficesViewModel parentViewModel = companyEditViewModel._parentViewModel;
										if (parentViewModel != null)
										{
											parentViewModel.LoadItems();
											uint num;
											switch ((num = (num * 568889755U ^ 4182222712U ^ 3806356954U)) % 8U)
											{
											case 0U:
												goto IL_6C;
											case 1U:
											case 7U:
												goto IL_83;
											case 2U:
												continue;
											case 3U:
												goto IL_67;
											case 4U:
												goto IL_86;
											case 5U:
												goto IL_7A;
											}
											goto Block_5;
										}
										goto IL_85;
									}
								}
								goto IL_86;
							}
						}
						Block_5:
						goto IL_92;
						IL_85:
						IL_86:
						companyEditViewModel.ShowActionResponse(flag, "");
						IL_92:
						companyEditViewModel.SetBuzy(false);
					}
					IL_83:;
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

			// Token: 0x06003320 RID: 13088 RVA: 0x000AC62C File Offset: 0x000AA82C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D6D RID: 7533
			public int <>1__state;

			// Token: 0x04001D6E RID: 7534
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D6F RID: 7535
			public CompanyEditViewModel <>4__this;
		}

		// Token: 0x02000563 RID: 1379
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__18 : IAsyncStateMachine
		{
			// Token: 0x06003321 RID: 13089 RVA: 0x000AC648 File Offset: 0x000AA848
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CompanyEditViewModel companyEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = companyEditViewModel.Create().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CompanyEditViewModel.<Save>d__18>(ref awaiter, ref this);
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
					IOfficesViewModel parentViewModel = companyEditViewModel._parentViewModel;
					if (parentViewModel != null)
					{
						parentViewModel.LoadItems();
					}
					companyEditViewModel.Close();
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

			// Token: 0x06003322 RID: 13090 RVA: 0x000AC714 File Offset: 0x000AA914
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D70 RID: 7536
			public int <>1__state;

			// Token: 0x04001D71 RID: 7537
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D72 RID: 7538
			public CompanyEditViewModel <>4__this;

			// Token: 0x04001D73 RID: 7539
			private TaskAwaiter <>u__1;
		}
	}
}
