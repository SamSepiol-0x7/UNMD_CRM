using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000572 RID: 1394
	public class AdditionalFieldsListViewModel : CollectionViewModel<fields>
	{
		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x0600337B RID: 13179 RVA: 0x000ADEF0 File Offset: 0x000AC0F0
		// (set) Token: 0x0600337C RID: 13180 RVA: 0x000ADF04 File Offset: 0x000AC104
		public string Label
		{
			[CompilerGenerated]
			get
			{
				return this.<Label>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (!string.Equals(this.<Label>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1448102016;
				IL_14:
				switch ((num ^ 81952961) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					return;
				case 2:
					IL_33:
					this.<Label>k__BackingField = value;
					num = 313357490;
					goto IL_14;
				}
				this.RaisePropertyChanged("Label");
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x0600337D RID: 13181 RVA: 0x000ADF60 File Offset: 0x000AC160
		// (set) Token: 0x0600337E RID: 13182 RVA: 0x000ADF74 File Offset: 0x000AC174
		public bool ShowArchiveFields
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowArchiveFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowArchiveFields>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -349149559;
				IL_10:
				switch ((num ^ -1490606884) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					this.<ShowArchiveFields>k__BackingField = value;
					this.RaisePropertyChanged("ShowArchiveFields");
					num = -1009527108;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x000ADFCC File Offset: 0x000AC1CC
		public AdditionalFieldsListViewModel(IWindowedDocumentService windowedDocumentService, IAdditionalFieldsService additionalFieldsService)
		{
			this._windowedDocumentService = windowedDocumentService;
			this.AdditionalFieldsService = additionalFieldsService;
			this.Label = Lang.t("AdditionalFields");
			this.LoadItems();
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x000AE004 File Offset: 0x000AC204
		public virtual void LoadItems()
		{
			AdditionalFieldsListViewModel.<LoadItems>d__11 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<AdditionalFieldsListViewModel.<LoadItems>d__11>(ref <LoadItems>d__);
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x000AE03C File Offset: 0x000AC23C
		[Command]
		public virtual void ShowCreateItem()
		{
			AdditionalFieldEditViewModel additionalFieldEditViewModel = Bootstrapper.Container.Resolve<AdditionalFieldEditViewModel>();
			additionalFieldEditViewModel.SetParentViewModel(this);
			additionalFieldEditViewModel.SetType(AttributeType.OrderAttribute);
			this._windowedDocumentService.ShowNewDocument("AdditionalFieldEditView", additionalFieldEditViewModel, null, null);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x000AE078 File Offset: 0x000AC278
		[Command]
		public virtual void ShowItemEdit()
		{
			AdditionalFieldEditViewModel additionalFieldEditViewModel = Bootstrapper.Container.Resolve<AdditionalFieldEditViewModel>();
			additionalFieldEditViewModel.SetParentViewModel(this);
			additionalFieldEditViewModel.SetItem(base.SelectedItem);
			additionalFieldEditViewModel.SetType(AttributeType.OrderAttribute);
			this._windowedDocumentService.ShowNewDocument("AdditionalFieldEditView", additionalFieldEditViewModel, null, null);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000AE0C0 File Offset: 0x000AC2C0
		public bool CanShowItemEdit()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000AE0D8 File Offset: 0x000AC2D8
		[Command]
		public virtual void RefreshItems()
		{
			this.LoadItems();
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x000AE0EC File Offset: 0x000AC2EC
		[CompilerGenerated]
		private Task<List<fields>> <LoadItems>b__11_0()
		{
			return this.AdditionalFieldsService.GetAdditionalFields(new bool?(false), this.ShowArchiveFields);
		}

		// Token: 0x04001DAE RID: 7598
		protected readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001DAF RID: 7599
		protected readonly IAdditionalFieldsService AdditionalFieldsService;

		// Token: 0x04001DB0 RID: 7600
		[CompilerGenerated]
		private string <Label>k__BackingField;

		// Token: 0x04001DB1 RID: 7601
		[CompilerGenerated]
		private bool <ShowArchiveFields>k__BackingField;

		// Token: 0x02000573 RID: 1395
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__11 : IAsyncStateMachine
		{
			// Token: 0x06003386 RID: 13190 RVA: 0x000AE110 File Offset: 0x000AC310
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AdditionalFieldsListViewModel additionalFieldsListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<fields>>(() => additionalFieldsListViewModel.AdditionalFieldsService.GetAdditionalFields(new bool?(false), base.ShowArchiveFields)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, AdditionalFieldsListViewModel.<LoadItems>d__11>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<fields>>);
						this.<>1__state = -1;
					}
					List<fields> result = awaiter.GetResult();
					additionalFieldsListViewModel.SetItems(result);
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

			// Token: 0x06003387 RID: 13191 RVA: 0x000AE1D8 File Offset: 0x000AC3D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DB2 RID: 7602
			public int <>1__state;

			// Token: 0x04001DB3 RID: 7603
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001DB4 RID: 7604
			public AdditionalFieldsListViewModel <>4__this;

			// Token: 0x04001DB5 RID: 7605
			private TaskAwaiter<List<fields>> <>u__1;
		}
	}
}
