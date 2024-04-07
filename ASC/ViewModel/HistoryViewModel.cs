using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.PartsRequest;
using ASC.ViewModels;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModel
{
	// Token: 0x020002BE RID: 702
	public class HistoryViewModel : BaseViewModel
	{
		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x00068FD0 File Offset: 0x000671D0
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x00068FE4 File Offset: 0x000671E4
		public ObservableCollection<logs> History
		{
			[CompilerGenerated]
			get
			{
				return this.<History>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<History>k__BackingField, value))
				{
					return;
				}
				this.<History>k__BackingField = value;
				this.RaisePropertyChanged("History");
			}
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00069014 File Offset: 0x00067214
		public HistoryViewModel()
		{
			this.SetViewName("History");
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00069040 File Offset: 0x00067240
		public HistoryViewModel(parts_request request) : this()
		{
			this._id = request.id;
			this._type = HistoryViewModel.Type.request;
			this.LoadRequestHistory();
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0006906C File Offset: 0x0006726C
		public HistoryViewModel(IStoreDocument document) : this()
		{
			this._id = document.Id;
			this._type = HistoryViewModel.Type.pn_rn;
			this.LoadRnHistory();
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00069098 File Offset: 0x00067298
		private void LoadRequestHistory()
		{
			HistoryViewModel.<LoadRequestHistory>d__10 <LoadRequestHistory>d__;
			<LoadRequestHistory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadRequestHistory>d__.<>4__this = this;
			<LoadRequestHistory>d__.<>1__state = -1;
			<LoadRequestHistory>d__.<>t__builder.Start<HistoryViewModel.<LoadRequestHistory>d__10>(ref <LoadRequestHistory>d__);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000690D0 File Offset: 0x000672D0
		private void LoadRnHistory()
		{
			HistoryViewModel.<LoadRnHistory>d__11 <LoadRnHistory>d__;
			<LoadRnHistory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadRnHistory>d__.<>4__this = this;
			<LoadRnHistory>d__.<>1__state = -1;
			<LoadRnHistory>d__.<>t__builder.Start<HistoryViewModel.<LoadRnHistory>d__11>(ref <LoadRnHistory>d__);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00069108 File Offset: 0x00067308
		[Command]
		public void Refresh()
		{
			HistoryViewModel.Type type = this._type;
			if (type == HistoryViewModel.Type.request)
			{
				this.LoadRequestHistory();
				return;
			}
			if (type != HistoryViewModel.Type.pn_rn)
			{
				return;
			}
			this.LoadRnHistory();
		}

		// Token: 0x04001273 RID: 4723
		[CompilerGenerated]
		private ObservableCollection<logs> <History>k__BackingField;

		// Token: 0x04001274 RID: 4724
		private PartsRequestModel _partsRequestModel = new PartsRequestModel();

		// Token: 0x04001275 RID: 4725
		private HistoryViewModel.Type _type;

		// Token: 0x04001276 RID: 4726
		private int _id;

		// Token: 0x020002BF RID: 703
		public enum Type
		{
			// Token: 0x04001278 RID: 4728
			request,
			// Token: 0x04001279 RID: 4729
			pn_rn,
			// Token: 0x0400127A RID: 4730
			storeItem
		}

		// Token: 0x020002C0 RID: 704
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRequestHistory>d__10 : IAsyncStateMachine
		{
			// Token: 0x06002380 RID: 9088 RVA: 0x00069134 File Offset: 0x00067334
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				HistoryViewModel historyViewModel = this.<>4__this;
				try
				{
					ConfiguredTaskAwaitable<IEnumerable<logs>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = historyViewModel._partsRequestModel.GetHistory(historyViewModel._id).ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<IEnumerable<logs>>.ConfiguredTaskAwaiter, HistoryViewModel.<LoadRequestHistory>d__10>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(ConfiguredTaskAwaitable<IEnumerable<logs>>.ConfiguredTaskAwaiter);
						this.<>1__state = -1;
					}
					IEnumerable<logs> result = awaiter.GetResult();
					historyViewModel.History = new ObservableCollection<logs>(result);
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

			// Token: 0x06002381 RID: 9089 RVA: 0x0006920C File Offset: 0x0006740C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400127B RID: 4731
			public int <>1__state;

			// Token: 0x0400127C RID: 4732
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400127D RID: 4733
			public HistoryViewModel <>4__this;

			// Token: 0x0400127E RID: 4734
			private ConfiguredTaskAwaitable<IEnumerable<logs>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020002C1 RID: 705
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRnHistory>d__11 : IAsyncStateMachine
		{
			// Token: 0x06002382 RID: 9090 RVA: 0x00069228 File Offset: 0x00067428
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				HistoryViewModel historyViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<logs>> awaiter;
					if (num != 0)
					{
						awaiter = DocumentsModel.LoadHistory(historyViewModel._id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<logs>>, HistoryViewModel.<LoadRnHistory>d__11>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<logs>>);
						this.<>1__state = -1;
					}
					List<logs> result = awaiter.GetResult();
					historyViewModel.History = new ObservableCollection<logs>(result);
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

			// Token: 0x06002383 RID: 9091 RVA: 0x000692F0 File Offset: 0x000674F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400127F RID: 4735
			public int <>1__state;

			// Token: 0x04001280 RID: 4736
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001281 RID: 4737
			public HistoryViewModel <>4__this;

			// Token: 0x04001282 RID: 4738
			private TaskAwaiter<List<logs>> <>u__1;
		}
	}
}
