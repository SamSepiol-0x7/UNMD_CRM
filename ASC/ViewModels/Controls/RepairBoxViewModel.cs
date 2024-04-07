using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Controls
{
	// Token: 0x020004F3 RID: 1267
	public class RepairBoxViewModel : BaseViewModel
	{
		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x0009EB3C File Offset: 0x0009CD3C
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x0009EB50 File Offset: 0x0009CD50
		private int _repairId
		{
			[CompilerGenerated]
			get
			{
				return this.<_repairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<_repairId>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1420173469;
				IL_10:
				switch ((num ^ 1052330994) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<_repairId>k__BackingField = value;
					this.RaisePropertyChanged("_repairId");
					num = 564035799;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x0009EBA8 File Offset: 0x0009CDA8
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x0009EBBC File Offset: 0x0009CDBC
		private int _officeId
		{
			[CompilerGenerated]
			get
			{
				return this.<_officeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<_officeId>k__BackingField == value)
				{
					return;
				}
				this.<_officeId>k__BackingField = value;
				this.RaisePropertyChanged("_officeId");
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x0009EBE8 File Offset: 0x0009CDE8
		// (set) Token: 0x06003038 RID: 12344 RVA: 0x0009EBFC File Offset: 0x0009CDFC
		private int? _originalValue
		{
			[CompilerGenerated]
			get
			{
				return this.<_originalValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<_originalValue>k__BackingField, value))
				{
					return;
				}
				this.<_originalValue>k__BackingField = value;
				this.RaisePropertyChanged("_originalValue");
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x0009EC2C File Offset: 0x0009CE2C
		// (set) Token: 0x0600303A RID: 12346 RVA: 0x0009EC70 File Offset: 0x0009CE70
		public int? Value
		{
			get
			{
				return base.GetProperty<int?>(() => this.Value);
			}
			set
			{
				if (Nullable.Equals<int>(this.Value, value))
				{
					return;
				}
				base.SetProperty<int?>(() => this.Value, value, new Action(this.OnValueChange));
				this.RaisePropertyChanged("Value");
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x0009ECDC File Offset: 0x0009CEDC
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x0009ECF0 File Offset: 0x0009CEF0
		public ObservableCollection<boxes> Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Boxes>k__BackingField, value))
				{
					return;
				}
				this.<Boxes>k__BackingField = value;
				this.RaisePropertyChanged("Boxes");
			}
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0009ED20 File Offset: 0x0009CF20
		public RepairBoxViewModel(IToasterService toasterService, IWorkshopService workshopService)
		{
			this._toasterService = toasterService;
			this._workshopService = workshopService;
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0009ED4C File Offset: 0x0009CF4C
		private void OnValueChange()
		{
			base.RaiseCanExecuteChanged(() => this.RemoveFromBox());
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x0009ED94 File Offset: 0x0009CF94
		[Command]
		public void UpdateBox()
		{
			RepairBoxViewModel.<UpdateBox>d__23 <UpdateBox>d__;
			<UpdateBox>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateBox>d__.<>4__this = this;
			<UpdateBox>d__.<>1__state = -1;
			<UpdateBox>d__.<>t__builder.Start<RepairBoxViewModel.<UpdateBox>d__23>(ref <UpdateBox>d__);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0009EDCC File Offset: 0x0009CFCC
		public bool CanUpdateBox()
		{
			int? originalValue = this._originalValue;
			int? value = this.Value;
			return !(originalValue.GetValueOrDefault() == value.GetValueOrDefault() & originalValue != null == (value != null)) && this.IsUnlockedAndSameOffice();
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0009EE14 File Offset: 0x0009D014
		private bool CurrentUserInOffice(int officeId)
		{
			return Auth.User.office == officeId;
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0009EE30 File Offset: 0x0009D030
		public bool IsUnlockedAndSameOffice()
		{
			return this.CurrentUserInOffice(this._officeId) || OfflineData.Instance.Employee.Can(74, 0);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0009EE64 File Offset: 0x0009D064
		private Task Update(int repairId, int? boxId)
		{
			RepairBoxViewModel.<Update>d__27 <Update>d__;
			<Update>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Update>d__.<>4__this = this;
			<Update>d__.repairId = repairId;
			<Update>d__.boxId = boxId;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<RepairBoxViewModel.<Update>d__27>(ref <Update>d__);
			return <Update>d__.<>t__builder.Task;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0009EEB8 File Offset: 0x0009D0B8
		[AsyncCommand]
		public Task RemoveFromBox()
		{
			RepairBoxViewModel.<RemoveFromBox>d__28 <RemoveFromBox>d__;
			<RemoveFromBox>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemoveFromBox>d__.<>4__this = this;
			<RemoveFromBox>d__.<>1__state = -1;
			<RemoveFromBox>d__.<>t__builder.Start<RepairBoxViewModel.<RemoveFromBox>d__28>(ref <RemoveFromBox>d__);
			return <RemoveFromBox>d__.<>t__builder.Task;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0009EEFC File Offset: 0x0009D0FC
		public bool CanRemoveFromBox()
		{
			return this.Value != null;
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0009EF18 File Offset: 0x0009D118
		protected override void OnParameterChanged(object parameter)
		{
			RepairBoxViewModel.<OnParameterChanged>d__30 <OnParameterChanged>d__;
			<OnParameterChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnParameterChanged>d__.<>4__this = this;
			<OnParameterChanged>d__.parameter = parameter;
			<OnParameterChanged>d__.<>1__state = -1;
			<OnParameterChanged>d__.<>t__builder.Start<RepairBoxViewModel.<OnParameterChanged>d__30>(ref <OnParameterChanged>d__);
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x0009EF58 File Offset: 0x0009D158
		private void InitValue(int? boxId)
		{
			this._originalValue = boxId;
			this.Value = boxId;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0009EF74 File Offset: 0x0009D174
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0(object parameter)
		{
			base.OnParameterChanged(parameter);
		}

		// Token: 0x04001B60 RID: 7008
		private readonly IToasterService _toasterService;

		// Token: 0x04001B61 RID: 7009
		private readonly IWorkshopService _workshopService;

		// Token: 0x04001B62 RID: 7010
		[CompilerGenerated]
		private int <_repairId>k__BackingField;

		// Token: 0x04001B63 RID: 7011
		[CompilerGenerated]
		private int <_officeId>k__BackingField;

		// Token: 0x04001B64 RID: 7012
		[CompilerGenerated]
		private int? <_originalValue>k__BackingField;

		// Token: 0x04001B65 RID: 7013
		[CompilerGenerated]
		private ObservableCollection<boxes> <Boxes>k__BackingField = new ObservableCollection<boxes>();

		// Token: 0x020004F4 RID: 1268
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateBox>d__23 : IAsyncStateMachine
		{
			// Token: 0x06003049 RID: 12361 RVA: 0x0009EF88 File Offset: 0x0009D188
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairBoxViewModel repairBoxViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = repairBoxViewModel.Update(repairBoxViewModel._repairId, repairBoxViewModel.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairBoxViewModel.<UpdateBox>d__23>(ref awaiter, ref this);
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

			// Token: 0x0600304A RID: 12362 RVA: 0x0009F048 File Offset: 0x0009D248
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B66 RID: 7014
			public int <>1__state;

			// Token: 0x04001B67 RID: 7015
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B68 RID: 7016
			public RepairBoxViewModel <>4__this;

			// Token: 0x04001B69 RID: 7017
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004F5 RID: 1269
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x0600304B RID: 12363 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x0600304C RID: 12364 RVA: 0x0009F064 File Offset: 0x0009D264
			internal Task <Update>b__0()
			{
				Func<Task> function;
				if ((function = this.<>9__1) == null)
				{
					function = (this.<>9__1 = (() => this.<>4__this._workshopService.SaveBox(this.repairId, this.boxId)));
				}
				return Task.Run(function);
			}

			// Token: 0x0600304D RID: 12365 RVA: 0x0009F098 File Offset: 0x0009D298
			internal Task <Update>b__1()
			{
				return this.<>4__this._workshopService.SaveBox(this.repairId, this.boxId);
			}

			// Token: 0x04001B6A RID: 7018
			public RepairBoxViewModel <>4__this;

			// Token: 0x04001B6B RID: 7019
			public int repairId;

			// Token: 0x04001B6C RID: 7020
			public int? boxId;

			// Token: 0x04001B6D RID: 7021
			public Func<Task> <>9__1;
		}

		// Token: 0x020004F6 RID: 1270
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Update>d__27 : IAsyncStateMachine
		{
			// Token: 0x0600304E RID: 12366 RVA: 0x0009F0C4 File Offset: 0x0009D2C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairBoxViewModel repairBoxViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new RepairBoxViewModel.<>c__DisplayClass27_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.repairId = this.repairId;
						this.<>8__1.boxId = this.boxId;
						repairBoxViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Run(new Func<Task>(this.<>8__1.<Update>b__0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairBoxViewModel.<Update>d__27>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						repairBoxViewModel._originalValue = this.<>8__1.boxId;
						repairBoxViewModel._toasterService.Success(Lang.t("BoxSaved"));
					}
					catch (Exception ex)
					{
						repairBoxViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairBoxViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600304F RID: 12367 RVA: 0x0009F268 File Offset: 0x0009D468
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B6E RID: 7022
			public int <>1__state;

			// Token: 0x04001B6F RID: 7023
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001B70 RID: 7024
			public RepairBoxViewModel <>4__this;

			// Token: 0x04001B71 RID: 7025
			public int repairId;

			// Token: 0x04001B72 RID: 7026
			public int? boxId;

			// Token: 0x04001B73 RID: 7027
			private RepairBoxViewModel.<>c__DisplayClass27_0 <>8__1;

			// Token: 0x04001B74 RID: 7028
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004F7 RID: 1271
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveFromBox>d__28 : IAsyncStateMachine
		{
			// Token: 0x06003050 RID: 12368 RVA: 0x0009F284 File Offset: 0x0009D484
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairBoxViewModel repairBoxViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						repairBoxViewModel.Value = null;
						awaiter = repairBoxViewModel.Update(repairBoxViewModel._repairId, repairBoxViewModel.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairBoxViewModel.<RemoveFromBox>d__28>(ref awaiter, ref this);
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

			// Token: 0x06003051 RID: 12369 RVA: 0x0009F354 File Offset: 0x0009D554
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B75 RID: 7029
			public int <>1__state;

			// Token: 0x04001B76 RID: 7030
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001B77 RID: 7031
			public RepairBoxViewModel <>4__this;

			// Token: 0x04001B78 RID: 7032
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020004F8 RID: 1272
		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x06003052 RID: 12370 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x06003053 RID: 12371 RVA: 0x0009F370 File Offset: 0x0009D570
			internal Task<List<boxes>> <OnParameterChanged>b__0()
			{
				return RepairModel.LoadNonItemBoxes(this.repair.box, false);
			}

			// Token: 0x04001B79 RID: 7033
			public workshop repair;
		}

		// Token: 0x020004F9 RID: 1273
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnParameterChanged>d__30 : IAsyncStateMachine
		{
			// Token: 0x06003054 RID: 12372 RVA: 0x0009F390 File Offset: 0x0009D590
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairBoxViewModel repairBoxViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<boxes>> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new RepairBoxViewModel.<>c__DisplayClass30_0();
						repairBoxViewModel.<>n__0(this.parameter);
						this.<>8__1.repair = (this.parameter as workshop);
						if (this.<>8__1.repair == null || this.<>8__1.repair.id <= 0)
						{
							goto IL_160;
						}
						repairBoxViewModel._repairId = this.<>8__1.repair.id;
						repairBoxViewModel._officeId = this.<>8__1.repair.office;
						if (repairBoxViewModel.Boxes.Any<boxes>())
						{
							goto IL_14A;
						}
						awaiter = Task.Run<List<boxes>>(new Func<Task<List<boxes>>>(this.<>8__1.<OnParameterChanged>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, RepairBoxViewModel.<OnParameterChanged>d__30>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<boxes>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<boxes>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							boxes item = enumerator.Current;
							repairBoxViewModel.Boxes.Add(item);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					IL_14A:
					repairBoxViewModel.InitValue(this.<>8__1.repair.box);
					IL_160:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003055 RID: 12373 RVA: 0x0009F570 File Offset: 0x0009D770
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B7A RID: 7034
			public int <>1__state;

			// Token: 0x04001B7B RID: 7035
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001B7C RID: 7036
			public RepairBoxViewModel <>4__this;

			// Token: 0x04001B7D RID: 7037
			public object parameter;

			// Token: 0x04001B7E RID: 7038
			private RepairBoxViewModel.<>c__DisplayClass30_0 <>8__1;

			// Token: 0x04001B7F RID: 7039
			private TaskAwaiter<List<boxes>> <>u__1;
		}
	}
}
