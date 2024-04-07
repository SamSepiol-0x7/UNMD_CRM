using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000567 RID: 1383
	public class OfficeEditViewModel : PopupViewModel, IPopupViewModel
	{
		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x000ACF94 File Offset: 0x000AB194
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x000ACFA8 File Offset: 0x000AB1A8
		public offices Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("IsArchive");
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x000ACFE4 File Offset: 0x000AB1E4
		// (set) Token: 0x06003344 RID: 13124 RVA: 0x000AD00C File Offset: 0x000AB20C
		public bool IsArchive
		{
			get
			{
				return this.Item != null && this.Item.state == 0;
			}
			set
			{
				if (this.IsArchive == value)
				{
					return;
				}
				if (this.Item != null)
				{
					this.Item.state = (value ? 0 : 1);
				}
				this.RaisePropertyChanged("IsArchive");
			}
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x000AD04C File Offset: 0x000AB24C
		public OfficeEditViewModel(IOfficeService officeService, IToasterService toasterService)
		{
			this._officeService = officeService;
			this._toasterService = toasterService;
			this.Item = new offices
			{
				state = 1,
				card_payment = false,
				paint_repairs = true,
				use_boxes = true
			};
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x000AD094 File Offset: 0x000AB294
		protected override void OnParameterChanged(object prm)
		{
			OfficeEditViewModel.<OnParameterChanged>d__11 <OnParameterChanged>d__;
			<OnParameterChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnParameterChanged>d__.<>4__this = this;
			<OnParameterChanged>d__.prm = prm;
			<OnParameterChanged>d__.<>1__state = -1;
			<OnParameterChanged>d__.<>t__builder.Start<OfficeEditViewModel.<OnParameterChanged>d__11>(ref <OnParameterChanged>d__);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000AD0D4 File Offset: 0x000AB2D4
		public override void OnLoad()
		{
			this.SetTitle();
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000AD0E8 File Offset: 0x000AB2E8
		private void SetTitle()
		{
			base.Title = ((this.Item.id > 0) ? this.Item.name : Lang.t("NewOffice"));
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x000AD120 File Offset: 0x000AB320
		[AsyncCommand]
		public Task Save()
		{
			OfficeEditViewModel.<Save>d__14 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<OfficeEditViewModel.<Save>d__14>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000AD164 File Offset: 0x000AB364
		public bool CanSave()
		{
			return this.Item != null && this.Item.id > 0;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000AD18C File Offset: 0x000AB38C
		[AsyncCommand]
		public Task Create()
		{
			OfficeEditViewModel.<Create>d__16 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<OfficeEditViewModel.<Create>d__16>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000AD1D0 File Offset: 0x000AB3D0
		public bool CanCreate()
		{
			return this.Item != null && this.Item.id == 0;
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000AD1F8 File Offset: 0x000AB3F8
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			IOfficesViewModel officesViewModel = obj as IOfficesViewModel;
			if (officesViewModel != null)
			{
				this._parentViewModel = officesViewModel;
			}
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000AD220 File Offset: 0x000AB420
		private bool CheckFields()
		{
			string text = this._officeService.CheckFields(this.Item);
			if (string.IsNullOrEmpty(text))
			{
				return true;
			}
			this._toasterService.Info(Lang.t(text));
			return false;
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000AD25C File Offset: 0x000AB45C
		[CompilerGenerated]
		private Task <Save>b__14_0()
		{
			return this._officeService.UpdateOfficeAsync(this.Item);
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x000AD27C File Offset: 0x000AB47C
		[CompilerGenerated]
		private Task<int> <Create>b__16_0()
		{
			return this._officeService.CreateOfficeAsync(this.Item);
		}

		// Token: 0x04001D86 RID: 7558
		private IOfficesViewModel _parentViewModel;

		// Token: 0x04001D87 RID: 7559
		protected IOfficeService _officeService;

		// Token: 0x04001D88 RID: 7560
		private readonly IToasterService _toasterService;

		// Token: 0x04001D89 RID: 7561
		[CompilerGenerated]
		private offices <Item>k__BackingField;

		// Token: 0x02000568 RID: 1384
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnParameterChanged>d__11 : IAsyncStateMachine
		{
			// Token: 0x06003351 RID: 13137 RVA: 0x000AD29C File Offset: 0x000AB49C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficeEditViewModel officeEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<offices> awaiter;
					if (num != 0)
					{
						if (!(this.prm is int))
						{
							goto IL_93;
						}
						int officeId = (int)this.prm;
						awaiter = officeEditViewModel._officeService.GetOfficeAsync(officeId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<offices>, OfficeEditViewModel.<OnParameterChanged>d__11>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<offices>);
						this.<>1__state = -1;
					}
					offices result = awaiter.GetResult();
					officeEditViewModel.Item = result;
					IL_93:;
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

			// Token: 0x06003352 RID: 13138 RVA: 0x000AD37C File Offset: 0x000AB57C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D8A RID: 7562
			public int <>1__state;

			// Token: 0x04001D8B RID: 7563
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D8C RID: 7564
			public object prm;

			// Token: 0x04001D8D RID: 7565
			public OfficeEditViewModel <>4__this;

			// Token: 0x04001D8E RID: 7566
			private TaskAwaiter<offices> <>u__1;
		}

		// Token: 0x02000569 RID: 1385
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__14 : IAsyncStateMachine
		{
			// Token: 0x06003353 RID: 13139 RVA: 0x000AD398 File Offset: 0x000AB598
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficeEditViewModel officeEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!officeEditViewModel.CheckFields())
						{
							goto IL_161;
						}
						officeEditViewModel.ShowWait();
					}
					try
					{
						try
						{
							if (num != 0)
							{
								goto IL_B5;
							}
							goto IL_DE;
							TaskAwaiter awaiter;
							for (;;)
							{
								IL_D5:
								awaiter.GetResult();
								for (;;)
								{
									IL_91:
									officeEditViewModel._toasterService.Success(Lang.t("Saved"));
									OfflineData.Instance.ReloadOffices();
									for (;;)
									{
										IOfficesViewModel parentViewModel = officeEditViewModel._parentViewModel;
										if (parentViewModel != null)
										{
											parentViewModel.LoadItems();
											uint num2;
											switch ((num2 = (num2 * 599980752U ^ 430667159U ^ 2035070969U)) % 11U)
											{
											case 0U:
												goto IL_91;
											case 1U:
												goto IL_CC;
											case 2U:
												goto IL_D5;
											case 3U:
											case 9U:
												goto IL_B5;
											case 4U:
												goto IL_11D;
											case 5U:
												continue;
											case 7U:
												goto IL_DE;
											case 8U:
												goto IL_10C;
											case 10U:
												goto IL_FC;
											}
											goto Block_10;
										}
										goto IL_11C;
									}
								}
							}
							Block_10:
							goto IL_123;
							IL_11C:
							IL_11D:
							officeEditViewModel.Close();
							IL_123:
							goto IL_139;
							IL_B5:
							awaiter = Task.Run(() => officeEditViewModel._officeService.UpdateOfficeAsync(base.Item)).GetAwaiter();
							IL_CC:
							if (awaiter.IsCompleted)
							{
								goto IL_D5;
							}
							goto IL_FC;
							IL_DE:
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_D5;
							IL_FC:
							int num4 = 0;
							num = 0;
							this.<>1__state = num4;
							this.<>u__1 = awaiter;
							IL_10C:
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OfficeEditViewModel.<Save>d__14>(ref awaiter, ref this);
							return;
						}
						catch (Exception ex)
						{
							officeEditViewModel._toasterService.Error(ex.Message);
						}
						IL_139:;
					}
					finally
					{
						if (num < 0)
						{
							officeEditViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_161:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003354 RID: 13140 RVA: 0x000AD568 File Offset: 0x000AB768
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D8F RID: 7567
			public int <>1__state;

			// Token: 0x04001D90 RID: 7568
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D91 RID: 7569
			public OfficeEditViewModel <>4__this;

			// Token: 0x04001D92 RID: 7570
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200056A RID: 1386
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__16 : IAsyncStateMachine
		{
			// Token: 0x06003355 RID: 13141 RVA: 0x000AD584 File Offset: 0x000AB784
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficeEditViewModel officeEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!officeEditViewModel.CheckFields())
						{
							goto IL_124;
						}
						officeEditViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							this.<>7__wrap1 = officeEditViewModel.Item;
							awaiter = Task.Run<int>(() => officeEditViewModel._officeService.CreateOfficeAsync(base.Item)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, OfficeEditViewModel.<Create>d__16>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						int result = awaiter.GetResult();
						this.<>7__wrap1.id = result;
						this.<>7__wrap1 = null;
						officeEditViewModel._toasterService.Success(Lang.t("Saved"));
						officeEditViewModel.SetTitle();
						OfflineData.Instance.ReloadOffices();
						IOfficesViewModel parentViewModel = officeEditViewModel._parentViewModel;
						if (parentViewModel != null)
						{
							parentViewModel.LoadItems();
						}
					}
					catch (Exception ex)
					{
						officeEditViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							officeEditViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_124:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003356 RID: 13142 RVA: 0x000AD6F0 File Offset: 0x000AB8F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D93 RID: 7571
			public int <>1__state;

			// Token: 0x04001D94 RID: 7572
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001D95 RID: 7573
			public OfficeEditViewModel <>4__this;

			// Token: 0x04001D96 RID: 7574
			private offices <>7__wrap1;

			// Token: 0x04001D97 RID: 7575
			private TaskAwaiter<int> <>u__1;
		}
	}
}
