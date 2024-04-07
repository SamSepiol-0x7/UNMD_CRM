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
	// Token: 0x0200056F RID: 1391
	public class ProductAttributesListViewModel : AdditionalFieldsListViewModel
	{
		// Token: 0x06003370 RID: 13168 RVA: 0x000ADC4C File Offset: 0x000ABE4C
		public ProductAttributesListViewModel(IWindowedDocumentService windowedDocumentService, IAdditionalFieldsService additionalFieldsService) : base(windowedDocumentService, additionalFieldsService)
		{
			base.Label = Lang.t("ProductAttributes");
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000ADC74 File Offset: 0x000ABE74
		public override void LoadItems()
		{
			ProductAttributesListViewModel.<LoadItems>d__1 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<ProductAttributesListViewModel.<LoadItems>d__1>(ref <LoadItems>d__);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000ADCAC File Offset: 0x000ABEAC
		[Command]
		public override void ShowCreateItem()
		{
			AdditionalFieldEditViewModel additionalFieldEditViewModel = Bootstrapper.Container.Resolve<AdditionalFieldEditViewModel>();
			additionalFieldEditViewModel.SetParentViewModel(this);
			additionalFieldEditViewModel.SetType(AttributeType.ProductAttribute);
			this._windowedDocumentService.ShowNewDocument("AdditionalFieldEditView", additionalFieldEditViewModel, null, null);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x000ADCE8 File Offset: 0x000ABEE8
		[Command]
		public override void ShowItemEdit()
		{
			AdditionalFieldEditViewModel additionalFieldEditViewModel = Bootstrapper.Container.Resolve<AdditionalFieldEditViewModel>();
			additionalFieldEditViewModel.SetParentViewModel(this);
			additionalFieldEditViewModel.SetItem(base.SelectedItem);
			additionalFieldEditViewModel.SetType(AttributeType.ProductAttribute);
			this._windowedDocumentService.ShowNewDocument("AdditionalFieldEditView", additionalFieldEditViewModel, null, null);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000ADD30 File Offset: 0x000ABF30
		[CompilerGenerated]
		private Task<List<fields>> <LoadItems>b__1_0()
		{
			return this.AdditionalFieldsService.GetAdditionalFields(new bool?(true), base.ShowArchiveFields);
		}

		// Token: 0x02000570 RID: 1392
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__1 : IAsyncStateMachine
		{
			// Token: 0x06003375 RID: 13173 RVA: 0x000ADD54 File Offset: 0x000ABF54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ProductAttributesListViewModel productAttributesListViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<fields>>(() => productAttributesListViewModel.AdditionalFieldsService.GetAdditionalFields(new bool?(true), base.ShowArchiveFields)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, ProductAttributesListViewModel.<LoadItems>d__1>(ref awaiter, ref this);
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
					productAttributesListViewModel.SetItems(result);
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

			// Token: 0x06003376 RID: 13174 RVA: 0x000ADE1C File Offset: 0x000AC01C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DA7 RID: 7591
			public int <>1__state;

			// Token: 0x04001DA8 RID: 7592
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001DA9 RID: 7593
			public ProductAttributesListViewModel <>4__this;

			// Token: 0x04001DAA RID: 7594
			private TaskAwaiter<List<fields>> <>u__1;
		}
	}
}
