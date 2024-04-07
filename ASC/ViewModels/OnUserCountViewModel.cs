using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.PartsRequest;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200040B RID: 1035
	public class OnUserCountViewModel : BaseViewModel
	{
		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x00083484 File Offset: 0x00081684
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x00083498 File Offset: 0x00081698
		public store_int_reserve Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Item>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -2040914719;
				IL_13:
				switch ((num ^ -811507385) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<Item>k__BackingField = value;
					this.RaisePropertyChanged("Item");
					num = -1578703734;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x000834F4 File Offset: 0x000816F4
		// (set) Token: 0x060029C8 RID: 10696 RVA: 0x00083538 File Offset: 0x00081738
		public int Quantity
		{
			get
			{
				return base.GetProperty<int>(() => this.Quantity);
			}
			set
			{
				if (this.Quantity != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1281825267;
				IL_10:
				switch ((num ^ -1660050280) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					base.SetProperty<int>(() => this.Quantity, value, new Action(this.QuantityChanged));
					this.RaisePropertyChanged("Quantity");
					num = -535509993;
					goto IL_10;
				}
			}
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000835CC File Offset: 0x000817CC
		public OnUserCountViewModel()
		{
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000835F0 File Offset: 0x000817F0
		public OnUserCountViewModel(StoreViewModel storeViewModel, store_int_reserve item) : this()
		{
			this._storeViewModel = storeViewModel;
			this.Item = item;
			this.Quantity = item.count;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00083620 File Offset: 0x00081820
		private void QuantityChanged()
		{
			base.RaiseCanExecuteChanged(() => this.Save());
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00083668 File Offset: 0x00081868
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00083680 File Offset: 0x00081880
		[Command]
		public void Save()
		{
			OnUserCountViewModel.<Save>d__13 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<OnUserCountViewModel.<Save>d__13>(ref <Save>d__);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000836B8 File Offset: 0x000818B8
		public bool CanSave()
		{
			return this.Quantity > 0 && this.Quantity <= this.Item.count;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000836E8 File Offset: 0x000818E8
		[CompilerGenerated]
		private IAscResult<store_int_reserve> <Save>b__13_0()
		{
			return PartsRequestModel.AllocateRequest(this.Item, this.Quantity);
		}

		// Token: 0x04001727 RID: 5927
		private StoreViewModel _storeViewModel;

		// Token: 0x04001728 RID: 5928
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001729 RID: 5929
		[CompilerGenerated]
		private store_int_reserve <Item>k__BackingField;

		// Token: 0x0200040C RID: 1036
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__13 : IAsyncStateMachine
		{
			// Token: 0x060029D0 RID: 10704 RVA: 0x00083708 File Offset: 0x00081908
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OnUserCountViewModel onUserCountViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult<store_int_reserve>> awaiter;
					if (num != 0)
					{
						for (;;)
						{
							IL_9F:
							this.<vm>5__2 = onUserCountViewModel._storeViewModel.GetParentViewModelMyItemSelect();
							if (onUserCountViewModel.Quantity != onUserCountViewModel.Item.count)
							{
								goto IL_D4;
							}
							for (;;)
							{
								IMyItemSelect myItemSelect = this.<vm>5__2;
								if (myItemSelect != null)
								{
									myItemSelect.AddProductFromEmployeeCart(onUserCountViewModel.Item, onUserCountViewModel.Item.count);
									uint num2;
									switch ((num2 = (num2 * 3685893851U ^ 2191734027U ^ 2425771729U)) % 16U)
									{
									case 1U:
										goto IL_165;
									case 2U:
										goto IL_133;
									case 3U:
										goto IL_117;
									case 4U:
										goto IL_112;
									case 5U:
										continue;
									case 6U:
										goto IL_D4;
									case 7U:
										goto IL_F4;
									case 9U:
										goto IL_143;
									case 10U:
										goto IL_13B;
									case 12U:
									case 15U:
										goto IL_9F;
									case 13U:
										goto IL_C9;
									case 14U:
										goto IL_16D;
									}
									goto Block_5;
								}
								goto IL_C8;
							}
						}
						Block_5:
						goto IL_16B;
						IL_C8:
						IL_C9:
						onUserCountViewModel.Close();
						goto IL_16B;
						IL_D4:
						awaiter = Task.Run<IAscResult<store_int_reserve>>(() => PartsRequestModel.AllocateRequest(base.Item, base.Quantity)).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_133;
						}
						IL_F4:
						this.<>1__state = 0;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult<store_int_reserve>>, OnUserCountViewModel.<Save>d__13>(ref awaiter, ref this);
						IL_112:
						return;
					}
					IL_117:
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<IAscResult<store_int_reserve>>);
					this.<>1__state = -1;
					IL_133:
					IAscResult<store_int_reserve> result = awaiter.GetResult();
					IL_13B:
					if (!result.IsSucces)
					{
						goto IL_16D;
					}
					IL_143:
					IMyItemSelect myItemSelect2 = this.<vm>5__2;
					if (myItemSelect2 != null)
					{
						myItemSelect2.AddProductFromEmployeeCart(result.Object, result.Object.count);
					}
					IL_165:
					onUserCountViewModel.Close();
					IL_16B:
					goto IL_1A0;
					IL_16D:
					onUserCountViewModel.ShowActionResponse(result.IsSucces, "");
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<vm>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1A0:
				this.<>1__state = -2;
				this.<vm>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060029D1 RID: 10705 RVA: 0x000838EC File Offset: 0x00081AEC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400172A RID: 5930
			public int <>1__state;

			// Token: 0x0400172B RID: 5931
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400172C RID: 5932
			public OnUserCountViewModel <>4__this;

			// Token: 0x0400172D RID: 5933
			private IMyItemSelect <vm>5__2;

			// Token: 0x0400172E RID: 5934
			private TaskAwaiter<IAscResult<store_int_reserve>> <>u__1;
		}
	}
}
