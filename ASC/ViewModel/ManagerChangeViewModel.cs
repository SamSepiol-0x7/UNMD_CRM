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
	// Token: 0x020002A7 RID: 679
	public class ManagerChangeViewModel : RepairChangeCommonViewModel
	{
		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x00066AB0 File Offset: 0x00064CB0
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x00066AC4 File Offset: 0x00064CC4
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

		// Token: 0x060022F7 RID: 8951 RVA: 0x00066AF4 File Offset: 0x00064CF4
		public ManagerChangeViewModel()
		{
			this.BgInit();
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00066B10 File Offset: 0x00064D10
		public ManagerChangeViewModel(workshop repair) : this()
		{
			base.Repair = repair;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00066B2C File Offset: 0x00064D2C
		private void BgInit()
		{
			this.Users = UsersModel.LoadManagers(false);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00066B48 File Offset: 0x00064D48
		[AsyncCommand]
		public Task Assign()
		{
			ManagerChangeViewModel.<Assign>d__7 <Assign>d__;
			<Assign>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Assign>d__.<>4__this = this;
			<Assign>d__.<>1__state = -1;
			<Assign>d__.<>t__builder.Start<ManagerChangeViewModel.<Assign>d__7>(ref <Assign>d__);
			return <Assign>d__.<>t__builder.Task;
		}

		// Token: 0x04001215 RID: 4629
		[CompilerGenerated]
		private List<UserMaster> <Users>k__BackingField;

		// Token: 0x020002A8 RID: 680
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Assign>d__7 : IAsyncStateMachine
		{
			// Token: 0x060022FB RID: 8955 RVA: 0x00066B8C File Offset: 0x00064D8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ManagerChangeViewModel managerChangeViewModel = this.<>4__this;
				try
				{
					if (num == 0 || managerChangeViewModel.Repair != null)
					{
						try
						{
							if (num != 0)
							{
								goto IL_88;
							}
							goto IL_CB;
							TaskAwaiter awaiter;
							for (;;)
							{
								IL_A8:
								awaiter.GetResult();
								for (;;)
								{
									IRefreshable parentViewModel = managerChangeViewModel.ParentViewModel;
									if (parentViewModel != null)
									{
										parentViewModel.DataRefresh();
										uint num2;
										switch ((num2 = (num2 * 3821677989U ^ 2446865926U ^ 2449603898U)) % 11U)
										{
										case 0U:
											goto IL_A8;
										case 1U:
											continue;
										case 2U:
											goto IL_B4;
										case 4U:
											goto IL_F5;
										case 5U:
											goto IL_DD;
										case 6U:
											goto IL_CB;
										case 7U:
											goto IL_D4;
										case 8U:
										case 10U:
											goto IL_88;
										case 9U:
											goto IL_E4;
										}
										goto Block_9;
									}
									goto IL_F4;
								}
							}
							Block_9:
							goto IL_110;
							IL_F4:
							IL_F5:
							managerChangeViewModel._toasterService.Success(Lang.t("Saved"));
							managerChangeViewModel.Close();
							IL_110:
							goto IL_126;
							IL_88:
							awaiter = managerChangeViewModel._workshopService.ChangeManager(managerChangeViewModel.Repair).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_A8;
							}
							goto IL_D4;
							IL_B4:
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_A8;
							IL_CB:
							awaiter = this.<>u__1;
							goto IL_B4;
							IL_D4:
							this.<>1__state = 0;
							IL_DD:
							this.<>u__1 = awaiter;
							IL_E4:
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ManagerChangeViewModel.<Assign>d__7>(ref awaiter, ref this);
							return;
						}
						catch (Exception ex)
						{
							managerChangeViewModel._toasterService.Error(ex.Message);
						}
						IL_126:;
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

			// Token: 0x060022FC RID: 8956 RVA: 0x00066D24 File Offset: 0x00064F24
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001216 RID: 4630
			public int <>1__state;

			// Token: 0x04001217 RID: 4631
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001218 RID: 4632
			public ManagerChangeViewModel <>4__this;

			// Token: 0x04001219 RID: 4633
			private TaskAwaiter <>u__1;
		}
	}
}
