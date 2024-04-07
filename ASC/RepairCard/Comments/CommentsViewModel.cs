using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using ASC.Objects;
using ASC.RequestsManager;
using ASC.Services.Abstract;
using ASC.Services.Concrete;
using ASC.TaskManager;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RepairCard.Comments
{
	// Token: 0x02000825 RID: 2085
	public class CommentsViewModel : BaseViewModel
	{
		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x000F7A94 File Offset: 0x000F5C94
		// (set) Token: 0x06003E2D RID: 15917 RVA: 0x000F7AA8 File Offset: 0x000F5CA8
		public ObservableCollection<comments> Comments
		{
			[CompilerGenerated]
			get
			{
				return this.<Comments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Comments>k__BackingField, value))
				{
					return;
				}
				this.<Comments>k__BackingField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06003E2E RID: 15918 RVA: 0x000F7AD8 File Offset: 0x000F5CD8
		// (set) Token: 0x06003E2F RID: 15919 RVA: 0x000F7AEC File Offset: 0x000F5CEC
		public string Comment
		{
			[CompilerGenerated]
			get
			{
				return this.<Comment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Comment>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Comment>k__BackingField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x000F7B1C File Offset: 0x000F5D1C
		public CommentsViewModel()
		{
			this._commentsService = Bootstrapper.Container.Resolve<IIntCommentsService>();
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x000F7B40 File Offset: 0x000F5D40
		private void LoadComments()
		{
			CommentsViewModel.<LoadComments>d__13 <LoadComments>d__;
			<LoadComments>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadComments>d__.<>4__this = this;
			<LoadComments>d__.<>1__state = -1;
			<LoadComments>d__.<>t__builder.Start<CommentsViewModel.<LoadComments>d__13>(ref <LoadComments>d__);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x000F7B78 File Offset: 0x000F5D78
		[Command]
		public void AddIntComment(KeyEventArgs e)
		{
			CommentsViewModel.<AddIntComment>d__14 <AddIntComment>d__;
			<AddIntComment>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddIntComment>d__.<>4__this = this;
			<AddIntComment>d__.e = e;
			<AddIntComment>d__.<>1__state = -1;
			<AddIntComment>d__.<>t__builder.Start<CommentsViewModel.<AddIntComment>d__14>(ref <AddIntComment>d__);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x000F7BB8 File Offset: 0x000F5DB8
		[Command]
		public void CommentDoubleClick(object obj)
		{
			comments comments = obj as comments;
			if (comments == null)
			{
				return;
			}
			Clipboard.SetText(comments.text);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x000F7BDC File Offset: 0x000F5DDC
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			RepairCardViewModel repairCardViewModel = parentViewModel as RepairCardViewModel;
			if (repairCardViewModel != null)
			{
				this._repairCardViewModel = repairCardViewModel;
			}
			RequestCardViewModel requestCardViewModel = parentViewModel as RequestCardViewModel;
			if (requestCardViewModel != null)
			{
				this._requestCardViewModel = requestCardViewModel;
			}
			EmployeeTaskViewModel employeeTaskViewModel = parentViewModel as EmployeeTaskViewModel;
			if (employeeTaskViewModel != null)
			{
				this._employeeTaskViewModel = employeeTaskViewModel;
			}
			this.LoadComments();
		}

		// Token: 0x040028A4 RID: 10404
		private readonly IIntCommentsService _commentsService;

		// Token: 0x040028A5 RID: 10405
		private RepairCardViewModel _repairCardViewModel;

		// Token: 0x040028A6 RID: 10406
		private RequestCardViewModel _requestCardViewModel;

		// Token: 0x040028A7 RID: 10407
		private EmployeeTaskViewModel _employeeTaskViewModel;

		// Token: 0x040028A8 RID: 10408
		[CompilerGenerated]
		private ObservableCollection<comments> <Comments>k__BackingField;

		// Token: 0x040028A9 RID: 10409
		[CompilerGenerated]
		private string <Comment>k__BackingField;

		// Token: 0x02000826 RID: 2086
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadComments>d__13 : IAsyncStateMachine
		{
			// Token: 0x06003E35 RID: 15925 RVA: 0x000F7C2C File Offset: 0x000F5E2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CommentsViewModel commentsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<comments>> awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<comments>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<comments>>);
						this.<>1__state = -1;
						goto IL_111;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<comments>>);
						this.<>1__state = -1;
						goto IL_18E;
					default:
						if (commentsViewModel._repairCardViewModel == null)
						{
							goto IL_A0;
						}
						awaiter = commentsViewModel._commentsService.GetRepairComments(commentsViewModel._repairCardViewModel.RepairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<comments>>, CommentsViewModel.<LoadComments>d__13>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<comments> result = awaiter.GetResult();
					commentsViewModel.Comments = new ObservableCollection<comments>(result);
					IL_A0:
					if (commentsViewModel._requestCardViewModel == null)
					{
						goto IL_125;
					}
					awaiter = commentsViewModel._commentsService.GetRequestComments(commentsViewModel._requestCardViewModel.Request.id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<comments>>, CommentsViewModel.<LoadComments>d__13>(ref awaiter, ref this);
						return;
					}
					IL_111:
					result = awaiter.GetResult();
					commentsViewModel.Comments = new ObservableCollection<comments>(result);
					IL_125:
					if (commentsViewModel._employeeTaskViewModel == null)
					{
						goto IL_1A2;
					}
					awaiter = commentsViewModel._commentsService.GetTaskComments(commentsViewModel._employeeTaskViewModel.TaskId).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<comments>>, CommentsViewModel.<LoadComments>d__13>(ref awaiter, ref this);
						return;
					}
					IL_18E:
					result = awaiter.GetResult();
					commentsViewModel.Comments = new ObservableCollection<comments>(result);
					IL_1A2:;
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

			// Token: 0x06003E36 RID: 15926 RVA: 0x000F7E28 File Offset: 0x000F6028
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028AA RID: 10410
			public int <>1__state;

			// Token: 0x040028AB RID: 10411
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040028AC RID: 10412
			public CommentsViewModel <>4__this;

			// Token: 0x040028AD RID: 10413
			private TaskAwaiter<List<comments>> <>u__1;
		}

		// Token: 0x02000827 RID: 2087
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddIntComment>d__14 : IAsyncStateMachine
		{
			// Token: 0x06003E37 RID: 15927 RVA: 0x000F7E44 File Offset: 0x000F6044
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CommentsViewModel commentsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_18B;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_201;
					default:
						if (string.IsNullOrEmpty(commentsViewModel.Comment))
						{
							goto IL_23E;
						}
						if (this.e.Key != Key.Return || Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl) || Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
						{
							goto IL_225;
						}
						if (commentsViewModel._repairCardViewModel == null)
						{
							goto IL_119;
						}
						awaiter = commentsViewModel._commentsService.CreateRepairComment(commentsViewModel._repairCardViewModel.RepairId, commentsViewModel.Comment).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CommentsViewModel.<AddIntComment>d__14>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (OfflineData.Instance.Settings.InformComment)
					{
						NotificationService.CreateNotification(commentsViewModel._repairCardViewModel.Repair, commentsViewModel.Comment);
					}
					IL_119:
					if (commentsViewModel._requestCardViewModel == null)
					{
						goto IL_192;
					}
					awaiter = commentsViewModel._commentsService.CreatePartRequestComment(commentsViewModel._requestCardViewModel.RequestId, commentsViewModel.Comment).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CommentsViewModel.<AddIntComment>d__14>(ref awaiter, ref this);
						return;
					}
					IL_18B:
					awaiter.GetResult();
					IL_192:
					if (commentsViewModel._employeeTaskViewModel == null)
					{
						goto IL_208;
					}
					awaiter = commentsViewModel._commentsService.CreateTaskComment(commentsViewModel._employeeTaskViewModel.TaskId, commentsViewModel.Comment).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CommentsViewModel.<AddIntComment>d__14>(ref awaiter, ref this);
						return;
					}
					IL_201:
					awaiter.GetResult();
					IL_208:
					commentsViewModel.Comment = string.Empty;
					commentsViewModel.LoadComments();
					this.e.Handled = true;
					IL_225:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_23E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003E38 RID: 15928 RVA: 0x000F80C0 File Offset: 0x000F62C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040028AE RID: 10414
			public int <>1__state;

			// Token: 0x040028AF RID: 10415
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040028B0 RID: 10416
			public CommentsViewModel <>4__this;

			// Token: 0x040028B1 RID: 10417
			public KeyEventArgs e;

			// Token: 0x040028B2 RID: 10418
			private TaskAwaiter <>u__1;
		}
	}
}
