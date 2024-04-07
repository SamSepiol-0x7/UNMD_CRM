using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using ASC.Interfaces;
using ASC.Models;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.Workspace.Repairs;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020003D1 RID: 977
	public class RepairMassEditViewModel : CollectionViewModel<RepairMassEditModel>, IRepairSelect
	{
		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x0007CD44 File Offset: 0x0007AF44
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x0007CD58 File Offset: 0x0007AF58
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
				if (!object.Equals(this.<Boxes>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -139582213;
				IL_13:
				switch ((num ^ -446575203) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<Boxes>k__BackingField = value;
					this.RaisePropertyChanged("Boxes");
					num = -306552582;
					goto IL_13;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x0007CDB4 File Offset: 0x0007AFB4
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x0007CDC8 File Offset: 0x0007AFC8
		public int? OrderInput
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderInput>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<OrderInput>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -820994500;
				IL_13:
				switch ((num ^ -85387827) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<OrderInput>k__BackingField = value;
					this.RaisePropertyChanged("OrderInput");
					num = -1745053759;
					goto IL_13;
				}
			}
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0007CE24 File Offset: 0x0007B024
		public RepairMassEditViewModel(IToasterService toasterService, INavigationService navigationService, IWorkshopService workshopService)
		{
			this._toasterService = toasterService;
			this._navigationService = navigationService;
			this._workshopService = workshopService;
			this.SetViewName(Lang.t("OrdersMassEditor"));
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0007CE68 File Offset: 0x0007B068
		[Command]
		public void AddItem()
		{
			RepairsViewModel repairsViewModel = new RepairsViewModel();
			repairsViewModel.SetViewName("Select", "Repair");
			repairsViewModel.ReturnOnSelect = true;
			this._navigationService.Navigate(typeof(RepairsView).FullName, repairsViewModel, this);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0007CEB0 File Offset: 0x0007B0B0
		[Command]
		public void RemoveItem()
		{
			base.Items.Remove(base.SelectedItem);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0007CED0 File Offset: 0x0007B0D0
		public bool CanRemoveItem()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0007CEE8 File Offset: 0x0007B0E8
		public void SelectRepairFromList(WorkshopLite repair)
		{
			RepairMassEditViewModel.<SelectRepairFromList>d__15 <SelectRepairFromList>d__;
			<SelectRepairFromList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectRepairFromList>d__.<>4__this = this;
			<SelectRepairFromList>d__.repair = repair;
			<SelectRepairFromList>d__.<>1__state = -1;
			<SelectRepairFromList>d__.<>t__builder.Start<RepairMassEditViewModel.<SelectRepairFromList>d__15>(ref <SelectRepairFromList>d__);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0007CF28 File Offset: 0x0007B128
		[AsyncCommand]
		public Task Update()
		{
			RepairMassEditViewModel.<Update>d__16 <Update>d__;
			<Update>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Update>d__.<>4__this = this;
			<Update>d__.<>1__state = -1;
			<Update>d__.<>t__builder.Start<RepairMassEditViewModel.<Update>d__16>(ref <Update>d__);
			return <Update>d__.<>t__builder.Task;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0007CF6C File Offset: 0x0007B16C
		public bool CanUpdate()
		{
			return base.AnyItems();
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0007CF80 File Offset: 0x0007B180
		public override void OnLoad()
		{
			RepairMassEditViewModel.<OnLoad>d__18 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<RepairMassEditViewModel.<OnLoad>d__18>(ref <OnLoad>d__);
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0007CFB8 File Offset: 0x0007B1B8
		[Command]
		public void OnOrderNumberInputKeyUp(KeyEventArgs e)
		{
			RepairMassEditViewModel.<OnOrderNumberInputKeyUp>d__19 <OnOrderNumberInputKeyUp>d__;
			<OnOrderNumberInputKeyUp>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnOrderNumberInputKeyUp>d__.<>4__this = this;
			<OnOrderNumberInputKeyUp>d__.<>1__state = -1;
			<OnOrderNumberInputKeyUp>d__.<>t__builder.Start<RepairMassEditViewModel.<OnOrderNumberInputKeyUp>d__19>(ref <OnOrderNumberInputKeyUp>d__);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0007CFF0 File Offset: 0x0007B1F0
		public bool CanOnOrderNumberInputKeyUp(KeyEventArgs e)
		{
			return e.Key == Key.Return && this.OrderInput != null;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0007D018 File Offset: 0x0007B218
		[Command]
		public void OnOrderNumberInputAdd()
		{
			RepairMassEditViewModel.<OnOrderNumberInputAdd>d__21 <OnOrderNumberInputAdd>d__;
			<OnOrderNumberInputAdd>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnOrderNumberInputAdd>d__.<>4__this = this;
			<OnOrderNumberInputAdd>d__.<>1__state = -1;
			<OnOrderNumberInputAdd>d__.<>t__builder.Start<RepairMassEditViewModel.<OnOrderNumberInputAdd>d__21>(ref <OnOrderNumberInputAdd>d__);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0007D050 File Offset: 0x0007B250
		public bool CanOnOrderNumberInputAdd()
		{
			return this.OrderInput != null;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0007D06C File Offset: 0x0007B26C
		protected virtual Task AddRepairToList(int repairId)
		{
			RepairMassEditViewModel.<AddRepairToList>d__23 <AddRepairToList>d__;
			<AddRepairToList>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AddRepairToList>d__.<>4__this = this;
			<AddRepairToList>d__.repairId = repairId;
			<AddRepairToList>d__.<>1__state = -1;
			<AddRepairToList>d__.<>t__builder.Start<RepairMassEditViewModel.<AddRepairToList>d__23>(ref <AddRepairToList>d__);
			return <AddRepairToList>d__.<>t__builder.Task;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04001613 RID: 5651
		private readonly IToasterService _toasterService;

		// Token: 0x04001614 RID: 5652
		private readonly INavigationService _navigationService;

		// Token: 0x04001615 RID: 5653
		private readonly IWorkshopService _workshopService;

		// Token: 0x04001616 RID: 5654
		[CompilerGenerated]
		private ObservableCollection<boxes> <Boxes>k__BackingField = new ObservableCollection<boxes>();

		// Token: 0x04001617 RID: 5655
		[CompilerGenerated]
		private int? <OrderInput>k__BackingField;

		// Token: 0x020003D2 RID: 978
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectRepairFromList>d__15 : IAsyncStateMachine
		{
			// Token: 0x06002869 RID: 10345 RVA: 0x0007D0B8 File Offset: 0x0007B2B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairMassEditViewModel repairMassEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = repairMassEditViewModel.AddRepairToList(this.repair.RepairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairMassEditViewModel.<SelectRepairFromList>d__15>(ref awaiter, ref this);
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

			// Token: 0x0600286A RID: 10346 RVA: 0x0007D178 File Offset: 0x0007B378
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001618 RID: 5656
			public int <>1__state;

			// Token: 0x04001619 RID: 5657
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400161A RID: 5658
			public RepairMassEditViewModel <>4__this;

			// Token: 0x0400161B RID: 5659
			public WorkshopLite repair;

			// Token: 0x0400161C RID: 5660
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003D3 RID: 979
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Update>d__16 : IAsyncStateMachine
		{
			// Token: 0x0600286B RID: 10347 RVA: 0x0007D194 File Offset: 0x0007B394
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairMassEditViewModel repairMassEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						repairMassEditViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = repairMassEditViewModel._workshopService.UpdateRepairs(repairMassEditViewModel.Items).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairMassEditViewModel.<Update>d__16>(ref awaiter, ref this);
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
						repairMassEditViewModel._toasterService.Success(Lang.t("Complete"));
					}
					catch (Exception ex)
					{
						repairMassEditViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							repairMassEditViewModel.HideWait();
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

			// Token: 0x0600286C RID: 10348 RVA: 0x0007D2B0 File Offset: 0x0007B4B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400161D RID: 5661
			public int <>1__state;

			// Token: 0x0400161E RID: 5662
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400161F RID: 5663
			public RepairMassEditViewModel <>4__this;

			// Token: 0x04001620 RID: 5664
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003D4 RID: 980
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600286D RID: 10349 RVA: 0x0007D2CC File Offset: 0x0007B4CC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600286E RID: 10350 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600286F RID: 10351 RVA: 0x0007D2E4 File Offset: 0x0007B4E4
			internal Task<List<boxes>> <OnLoad>b__18_0()
			{
				return RepairModel.LoadNonItemBoxes(null, false);
			}

			// Token: 0x04001621 RID: 5665
			public static readonly RepairMassEditViewModel.<>c <>9 = new RepairMassEditViewModel.<>c();

			// Token: 0x04001622 RID: 5666
			public static Func<Task<List<boxes>>> <>9__18_0;
		}

		// Token: 0x020003D5 RID: 981
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__18 : IAsyncStateMachine
		{
			// Token: 0x06002870 RID: 10352 RVA: 0x0007D300 File Offset: 0x0007B500
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairMassEditViewModel repairMassEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<boxes>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<boxes>>(new Func<Task<List<boxes>>>(RepairMassEditViewModel.<>c.<>9.<OnLoad>b__18_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<boxes>>, RepairMassEditViewModel.<OnLoad>d__18>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<boxes>>);
						this.<>1__state = -1;
					}
					List<boxes> result = awaiter.GetResult();
					repairMassEditViewModel.Boxes = new ObservableCollection<boxes>(result);
					repairMassEditViewModel.<>n__0();
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

			// Token: 0x06002871 RID: 10353 RVA: 0x0007D3E8 File Offset: 0x0007B5E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001623 RID: 5667
			public int <>1__state;

			// Token: 0x04001624 RID: 5668
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001625 RID: 5669
			public RepairMassEditViewModel <>4__this;

			// Token: 0x04001626 RID: 5670
			private TaskAwaiter<List<boxes>> <>u__1;
		}

		// Token: 0x020003D6 RID: 982
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnOrderNumberInputKeyUp>d__19 : IAsyncStateMachine
		{
			// Token: 0x06002872 RID: 10354 RVA: 0x0007D404 File Offset: 0x0007B604
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairMassEditViewModel repairMassEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = repairMassEditViewModel.AddRepairToList(repairMassEditViewModel.OrderInput.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairMassEditViewModel.<OnOrderNumberInputKeyUp>d__19>(ref awaiter, ref this);
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
					repairMassEditViewModel.OrderInput = null;
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

			// Token: 0x06002873 RID: 10355 RVA: 0x0007D4D8 File Offset: 0x0007B6D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001627 RID: 5671
			public int <>1__state;

			// Token: 0x04001628 RID: 5672
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001629 RID: 5673
			public RepairMassEditViewModel <>4__this;

			// Token: 0x0400162A RID: 5674
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003D7 RID: 983
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnOrderNumberInputAdd>d__21 : IAsyncStateMachine
		{
			// Token: 0x06002874 RID: 10356 RVA: 0x0007D4F4 File Offset: 0x0007B6F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairMassEditViewModel repairMassEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = repairMassEditViewModel.AddRepairToList(repairMassEditViewModel.OrderInput.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairMassEditViewModel.<OnOrderNumberInputAdd>d__21>(ref awaiter, ref this);
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
					repairMassEditViewModel.OrderInput = null;
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

			// Token: 0x06002875 RID: 10357 RVA: 0x0007D5C8 File Offset: 0x0007B7C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400162B RID: 5675
			public int <>1__state;

			// Token: 0x0400162C RID: 5676
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400162D RID: 5677
			public RepairMassEditViewModel <>4__this;

			// Token: 0x0400162E RID: 5678
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003D8 RID: 984
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06002876 RID: 10358 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x06002877 RID: 10359 RVA: 0x0007D5E4 File Offset: 0x0007B7E4
			internal bool <AddRepairToList>b__0(RepairMassEditModel i)
			{
				return i.Id == this.repairId;
			}

			// Token: 0x0400162F RID: 5679
			public int repairId;
		}

		// Token: 0x020003D9 RID: 985
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddRepairToList>d__23 : IAsyncStateMachine
		{
			// Token: 0x06002878 RID: 10360 RVA: 0x0007D600 File Offset: 0x0007B800
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairMassEditViewModel repairMassEditViewModel = this.<>4__this;
				try
				{
					RepairMassEditViewModel.<>c__DisplayClass23_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new RepairMassEditViewModel.<>c__DisplayClass23_0();
						CS$<>8__locals1.repairId = this.repairId;
						if (repairMassEditViewModel.Items.Any(new Func<RepairMassEditModel, bool>(CS$<>8__locals1.<AddRepairToList>b__0)))
						{
							repairMassEditViewModel._toasterService.Info(string.Format("Ремонт {0:d6} уже есть в списке", CS$<>8__locals1.repairId));
							goto IL_14E;
						}
						repairMassEditViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<RepairMassEditModel> awaiter;
						if (num != 0)
						{
							this.<>7__wrap1 = repairMassEditViewModel.Items;
							awaiter = repairMassEditViewModel._workshopService.GetMassEditModel(CS$<>8__locals1.repairId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RepairMassEditModel>, RepairMassEditViewModel.<AddRepairToList>d__23>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<RepairMassEditModel>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						RepairMassEditModel result = awaiter.GetResult();
						this.<>7__wrap1.Add(result);
						this.<>7__wrap1 = null;
					}
					catch (Exception ex)
					{
						string text = ex.Message;
						if (text == "Sequence contains no elements")
						{
							text = Lang.t("OrderNotFound");
						}
						repairMassEditViewModel._toasterService.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							repairMassEditViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_14E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002879 RID: 10361 RVA: 0x0007D7BC File Offset: 0x0007B9BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001630 RID: 5680
			public int <>1__state;

			// Token: 0x04001631 RID: 5681
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001632 RID: 5682
			public int repairId;

			// Token: 0x04001633 RID: 5683
			public RepairMassEditViewModel <>4__this;

			// Token: 0x04001634 RID: 5684
			private ObservableCollection<RepairMassEditModel> <>7__wrap1;

			// Token: 0x04001635 RID: 5685
			private TaskAwaiter<RepairMassEditModel> <>u__1;
		}
	}
}
