using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModel
{
	// Token: 0x020002BB RID: 699
	public class MasterChangeViewModel : RepairChangeCommonViewModel
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x00068BDC File Offset: 0x00066DDC
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x00068BF0 File Offset: 0x00066DF0
		public List<UserMaster> Users
		{
			[CompilerGenerated]
			get
			{
				return this.<Users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Users>k__BackingField, value))
				{
					return;
				}
				this.<Users>k__BackingField = value;
				this.RaisePropertyChanged("Users");
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x00068C20 File Offset: 0x00066E20
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x00068C34 File Offset: 0x00066E34
		public int Selected
		{
			[CompilerGenerated]
			get
			{
				return this.<Selected>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Selected>k__BackingField == value)
				{
					return;
				}
				this.<Selected>k__BackingField = value;
				this.RaisePropertyChanged("Selected");
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00068C60 File Offset: 0x00066E60
		public MasterChangeViewModel()
		{
			this.BgInit();
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00068C7C File Offset: 0x00066E7C
		public MasterChangeViewModel(workshop repair) : this()
		{
			base.Repair = repair;
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00068C98 File Offset: 0x00066E98
		private void BgInit()
		{
			this.Users = new List<UserMaster>(UsersModel.LoadMasters(false));
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00068CB8 File Offset: 0x00066EB8
		[AsyncCommand]
		public Task Assign()
		{
			MasterChangeViewModel.<Assign>d__11 <Assign>d__;
			<Assign>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Assign>d__.<>4__this = this;
			<Assign>d__.<>1__state = -1;
			<Assign>d__.<>t__builder.Start<MasterChangeViewModel.<Assign>d__11>(ref <Assign>d__);
			return <Assign>d__.<>t__builder.Task;
		}

		// Token: 0x0400126B RID: 4715
		[CompilerGenerated]
		private List<UserMaster> <Users>k__BackingField;

		// Token: 0x0400126C RID: 4716
		[CompilerGenerated]
		private int <Selected>k__BackingField;

		// Token: 0x020002BC RID: 700
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Assign>d__11 : IAsyncStateMachine
		{
			// Token: 0x0600236D RID: 9069 RVA: 0x00068CFC File Offset: 0x00066EFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MasterChangeViewModel masterChangeViewModel = this.<>4__this;
				try
				{
					if (num == 0 || masterChangeViewModel.Repair != null)
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = masterChangeViewModel._workshopService.ChangeMaster(masterChangeViewModel.Repair.id, masterChangeViewModel.Repair.master).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MasterChangeViewModel.<Assign>d__11>(ref awaiter, ref this);
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
							IRefreshable parentViewModel = masterChangeViewModel.ParentViewModel;
							if (parentViewModel != null)
							{
								parentViewModel.DataRefresh();
							}
							masterChangeViewModel._toasterService.Success(Lang.t("Saved"));
							masterChangeViewModel.Close();
						}
						catch (Exception ex)
						{
							masterChangeViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x0600236E RID: 9070 RVA: 0x00068E30 File Offset: 0x00067030
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400126D RID: 4717
			public int <>1__state;

			// Token: 0x0400126E RID: 4718
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400126F RID: 4719
			public MasterChangeViewModel <>4__this;

			// Token: 0x04001270 RID: 4720
			private TaskAwaiter <>u__1;
		}
	}
}
