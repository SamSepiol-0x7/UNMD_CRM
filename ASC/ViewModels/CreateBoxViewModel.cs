using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services;
using ASC.ViewModels.ItemCard;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020003E5 RID: 997
	public class CreateBoxViewModel : PopupViewModel, IPopupViewModel
	{
		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x0007E4B4 File Offset: 0x0007C6B4
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x0007E4C8 File Offset: 0x0007C6C8
		public IStoreBox Box
		{
			[CompilerGenerated]
			get
			{
				return this.<Box>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Box>k__BackingField, value))
				{
					return;
				}
				this.<Box>k__BackingField = value;
				this.RaisePropertyChanged("Box");
			}
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0007E4F8 File Offset: 0x0007C6F8
		public CreateBoxViewModel()
		{
			this._boxService = Bootstrapper.Container.Resolve<IBoxService>();
			this.Box = new StoreBox();
			base.SetTitle(Lang.t("NewBox"));
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0007E538 File Offset: 0x0007C738
		public void SetStore(int storeId)
		{
			this.Box.StoreId = new int?(storeId);
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0007E558 File Offset: 0x0007C758
		public Task Save()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0007E56C File Offset: 0x0007C76C
		[AsyncCommand]
		public Task Create()
		{
			CreateBoxViewModel.<Create>d__9 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<CreateBoxViewModel.<Create>d__9>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x0007E5B0 File Offset: 0x0007C7B0
		private Task SetBoxOnParent()
		{
			CreateBoxViewModel.<SetBoxOnParent>d__10 <SetBoxOnParent>d__;
			<SetBoxOnParent>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetBoxOnParent>d__.<>4__this = this;
			<SetBoxOnParent>d__.<>1__state = -1;
			<SetBoxOnParent>d__.<>t__builder.Start<CreateBoxViewModel.<SetBoxOnParent>d__10>(ref <SetBoxOnParent>d__);
			return <SetBoxOnParent>d__.<>t__builder.Task;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanCreate()
		{
			return true;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0007E604 File Offset: 0x0007C804
		protected override void OnParentViewModelChanged(object obj)
		{
			this._parentViewModel = obj;
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnLoaded()
		{
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x00023150 File Offset: 0x00021350
		public void OnUnloaded()
		{
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0007E558 File Offset: 0x0007C758
		public bool CanSave()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04001659 RID: 5721
		protected IBoxService _boxService;

		// Token: 0x0400165A RID: 5722
		[CompilerGenerated]
		private IStoreBox <Box>k__BackingField;

		// Token: 0x0400165B RID: 5723
		private object _parentViewModel;

		// Token: 0x020003E6 RID: 998
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__9 : IAsyncStateMachine
		{
			// Token: 0x060028BC RID: 10428 RVA: 0x0007E618 File Offset: 0x0007C818
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CreateBoxViewModel createBoxViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<int> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_110;
						}
						if (!createBoxViewModel.CheckFields(createBoxViewModel.Box))
						{
							goto IL_13E;
						}
						createBoxViewModel.ShowWait();
						this.<>7__wrap1 = createBoxViewModel.Box;
						awaiter2 = createBoxViewModel._boxService.CreateBoxAsync(createBoxViewModel.Box).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CreateBoxViewModel.<Create>d__9>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter2.GetResult();
					this.<>7__wrap1.Id = result;
					this.<>7__wrap1 = null;
					awaiter = createBoxViewModel.SetBoxOnParent().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CreateBoxViewModel.<Create>d__9>(ref awaiter, ref this);
						return;
					}
					IL_110:
					awaiter.GetResult();
					createBoxViewModel.HideWait();
					createBoxViewModel.Close();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_13E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060028BD RID: 10429 RVA: 0x0007E794 File Offset: 0x0007C994
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400165C RID: 5724
			public int <>1__state;

			// Token: 0x0400165D RID: 5725
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400165E RID: 5726
			public CreateBoxViewModel <>4__this;

			// Token: 0x0400165F RID: 5727
			private IStoreBox <>7__wrap1;

			// Token: 0x04001660 RID: 5728
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04001661 RID: 5729
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020003E7 RID: 999
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060028BE RID: 10430 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x060028BF RID: 10431 RVA: 0x0007E7B0 File Offset: 0x0007C9B0
			internal void <SetBoxOnParent>b__0()
			{
				this.vm.SetBox(this.<>4__this.Box);
			}

			// Token: 0x04001662 RID: 5730
			public ProductEditViewModel vm;

			// Token: 0x04001663 RID: 5731
			public CreateBoxViewModel <>4__this;
		}

		// Token: 0x020003E8 RID: 1000
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetBoxOnParent>d__10 : IAsyncStateMachine
		{
			// Token: 0x060028C0 RID: 10432 RVA: 0x0007E7D4 File Offset: 0x0007C9D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CreateBoxViewModel createBoxViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						CreateBoxViewModel.<>c__DisplayClass10_0 CS$<>8__locals1 = new CreateBoxViewModel.<>c__DisplayClass10_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						object parentViewModel = createBoxViewModel._parentViewModel;
						CS$<>8__locals1.vm = (parentViewModel as ProductEditViewModel);
						if (CS$<>8__locals1.vm == null)
						{
							goto IL_A4;
						}
						awaiter = Task.Run(new Action(CS$<>8__locals1.<SetBoxOnParent>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CreateBoxViewModel.<SetBoxOnParent>d__10>(ref awaiter, ref this);
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
					IL_A4:;
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

			// Token: 0x060028C1 RID: 10433 RVA: 0x0007E8C4 File Offset: 0x0007CAC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001664 RID: 5732
			public int <>1__state;

			// Token: 0x04001665 RID: 5733
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001666 RID: 5734
			public CreateBoxViewModel <>4__this;

			// Token: 0x04001667 RID: 5735
			private TaskAwaiter <>u__1;
		}
	}
}
