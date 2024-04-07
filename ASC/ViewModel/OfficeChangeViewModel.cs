using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModel
{
	// Token: 0x020002C2 RID: 706
	public class OfficeChangeViewModel : RepairChangeCommonViewModel
	{
		// Token: 0x06002384 RID: 9092 RVA: 0x0006930C File Offset: 0x0006750C
		public OfficeChangeViewModel()
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00069320 File Offset: 0x00067520
		public OfficeChangeViewModel(workshop repair) : this()
		{
			base.Repair = repair;
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0006933C File Offset: 0x0006753C
		[AsyncCommand]
		public Task Move()
		{
			OfficeChangeViewModel.<Move>d__2 <Move>d__;
			<Move>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Move>d__.<>4__this = this;
			<Move>d__.<>1__state = -1;
			<Move>d__.<>t__builder.Start<OfficeChangeViewModel.<Move>d__2>(ref <Move>d__);
			return <Move>d__.<>t__builder.Task;
		}

		// Token: 0x020002C3 RID: 707
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Move>d__2 : IAsyncStateMachine
		{
			// Token: 0x06002387 RID: 9095 RVA: 0x00069380 File Offset: 0x00067580
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfficeChangeViewModel officeChangeViewModel = this.<>4__this;
				try
				{
					if (num == 0 || officeChangeViewModel.Repair != null)
					{
						try
						{
							if (num != 0)
							{
								goto IL_90;
							}
							goto IL_BC;
							TaskAwaiter awaiter;
							for (;;)
							{
								IL_B0:
								awaiter.GetResult();
								for (;;)
								{
									IRefreshable parentViewModel = officeChangeViewModel.ParentViewModel;
									if (parentViewModel != null)
									{
										parentViewModel.DataRefresh();
										uint num2;
										switch ((num2 = (num2 * 3572368903U ^ 3289921193U ^ 1629758933U)) % 13U)
										{
										case 0U:
											goto IL_E3;
										case 1U:
											goto IL_110;
										case 2U:
										case 10U:
											goto IL_90;
										case 3U:
											goto IL_FB;
										case 4U:
											goto IL_F8;
										case 5U:
											goto IL_A7;
										case 6U:
											goto IL_DA;
										case 7U:
											continue;
										case 8U:
											goto IL_BC;
										case 9U:
											goto IL_EA;
										case 11U:
											goto IL_B0;
										}
										goto Block_9;
									}
									goto IL_FA;
								}
							}
							Block_9:
							goto IL_116;
							IL_FA:
							IL_FB:
							officeChangeViewModel._toasterService.Success(Lang.t("Saved"));
							IL_110:
							officeChangeViewModel.Close();
							IL_116:
							goto IL_12C;
							IL_90:
							awaiter = officeChangeViewModel._workshopService.ChangeOffice(officeChangeViewModel.Repair).GetAwaiter();
							IL_A7:
							if (awaiter.IsCompleted)
							{
								goto IL_B0;
							}
							goto IL_DA;
							IL_BC:
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_B0;
							IL_DA:
							this.<>1__state = 0;
							IL_E3:
							this.<>u__1 = awaiter;
							IL_EA:
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, OfficeChangeViewModel.<Move>d__2>(ref awaiter, ref this);
							IL_F8:
							return;
						}
						catch (Exception ex)
						{
							officeChangeViewModel._toasterService.Error(ex.Message);
						}
						IL_12C:;
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

			// Token: 0x06002388 RID: 9096 RVA: 0x0006951C File Offset: 0x0006771C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001283 RID: 4739
			public int <>1__state;

			// Token: 0x04001284 RID: 4740
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001285 RID: 4741
			public OfficeChangeViewModel <>4__this;

			// Token: 0x04001286 RID: 4742
			private TaskAwaiter <>u__1;
		}
	}
}
