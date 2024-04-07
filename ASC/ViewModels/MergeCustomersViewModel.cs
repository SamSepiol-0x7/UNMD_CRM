using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200042B RID: 1067
	public class MergeCustomersViewModel : CollectionViewModel<ICustomer>
	{
		// Token: 0x06002AAE RID: 10926 RVA: 0x00086BF0 File Offset: 0x00084DF0
		public MergeCustomersViewModel()
		{
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x00086C14 File Offset: 0x00084E14
		public MergeCustomersViewModel(IEnumerable<ICustomer> items) : this()
		{
			base.SetItems(items);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00086C30 File Offset: 0x00084E30
		[Command]
		public void Merge()
		{
			MergeCustomersViewModel.<Merge>d__3 <Merge>d__;
			<Merge>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Merge>d__.<>4__this = this;
			<Merge>d__.<>1__state = -1;
			<Merge>d__.<>t__builder.Start<MergeCustomersViewModel.<Merge>d__3>(ref <Merge>d__);
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x00086C68 File Offset: 0x00084E68
		public bool CanMerge()
		{
			return base.SelectedItem != null && base.SelectedItem.Id > 0;
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x00086C90 File Offset: 0x00084E90
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x00086CA8 File Offset: 0x00084EA8
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00086CC8 File Offset: 0x00084EC8
		[CompilerGenerated]
		private IAscResult <Merge>b__3_0()
		{
			return ClientsModel.MergeCustomers(base.Items, base.SelectedItem.Id);
		}

		// Token: 0x040017AC RID: 6060
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040017AD RID: 6061
		private IRefreshable _parentViewModel;

		// Token: 0x0200042C RID: 1068
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Merge>d__3 : IAsyncStateMachine
		{
			// Token: 0x06002AB5 RID: 10933 RVA: 0x00086CEC File Offset: 0x00084EEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MergeCustomersViewModel mergeCustomersViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						mergeCustomersViewModel.ShowWait();
						awaiter = Task.Run<IAscResult>(() => ClientsModel.MergeCustomers(base.Items, base.SelectedItem.Id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, MergeCustomersViewModel.<Merge>d__3>(ref awaiter, ref this);
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
					mergeCustomersViewModel.HideWait();
					mergeCustomersViewModel.ShowActionResponse(result.IsSucces, "");
					if (result.IsSucces)
					{
						mergeCustomersViewModel.Close();
						IRefreshable parentViewModel = mergeCustomersViewModel._parentViewModel;
						if (parentViewModel != null)
						{
							parentViewModel.DataRefresh();
						}
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

			// Token: 0x06002AB6 RID: 10934 RVA: 0x00086DEC File Offset: 0x00084FEC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017AE RID: 6062
			public int <>1__state;

			// Token: 0x040017AF RID: 6063
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017B0 RID: 6064
			public MergeCustomersViewModel <>4__this;

			// Token: 0x040017B1 RID: 6065
			private TaskAwaiter<IAscResult> <>u__1;
		}
	}
}
