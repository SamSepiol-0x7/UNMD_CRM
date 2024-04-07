using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.SimpleClasses;
using ASC.Models;
using ASC.NewRepair;
using ASC.Objects;
using ASC.Options;
using ASC.RepairCard.WorksAndParts;
using ASC.SimpleClasses;
using DevExpress.Data.TreeList;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.TreeList;

namespace ASC.ViewModels
{
	// Token: 0x0200044D RID: 1101
	public class WpExpressViewModel : WpViewModel
	{
		// Token: 0x06002B79 RID: 11129 RVA: 0x0008A484 File Offset: 0x00088684
		public WpExpressViewModel()
		{
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x0008A498 File Offset: 0x00088698
		public WpExpressViewModel(workshop repair)
		{
			base.Repair = repair;
			base.ExpressMode = true;
			base.WarrantyOptionses = WarrantyOptions.GetAll();
			base.Items.Clear();
			base.Items.CollectionChanged += this.WorkPartsOnCollectionChanged;
			base.CanMasterChange = true;
			base.CountTotal();
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x0008A4F4 File Offset: 0x000886F4
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			this._parentViewModel = (parentViewModel as NewRepairViewModel);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x0008A510 File Offset: 0x00088710
		public override void WorkPartsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			base.CountTotal();
			if (this._parentViewModel != null)
			{
				this._parentViewModel.WpPartObjects = base.Items;
				this._parentViewModel.TotalAmount = Fn.FormatSumm(base.TotalRepairCost);
			}
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x0008A554 File Offset: 0x00088754
		public override void AddWorksFromPrice(workshop_price selectedItem)
		{
			if (selectedItem == null)
			{
				return;
			}
			WorkPartObject workPartObject = new WorkPartObject(base.RepairId, RepairItem.Types.Work, selectedItem.name, 1, selectedItem.price1)
			{
				WorkPriceId = new int?(selectedItem.id),
				Warranty = selectedItem.warranty.GetValueOrDefault(),
				EmployeeId = OfflineData.Instance.Employee.Id
			};
			workPartObject.GenerateRandomId();
			base.Items.Add(workPartObject);
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x0008A5CC File Offset: 0x000887CC
		[AsyncCommand]
		public override Task AddWork(object obj)
		{
			WpExpressViewModel.<AddWork>d__6 <AddWork>d__;
			<AddWork>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AddWork>d__.<>4__this = this;
			<AddWork>d__.<>1__state = -1;
			<AddWork>d__.<>t__builder.Start<WpExpressViewModel.<AddWork>d__6>(ref <AddWork>d__);
			return <AddWork>d__.<>t__builder.Task;
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x0008A610 File Offset: 0x00088810
		public override bool CanAddWork(object obj)
		{
			return base.ExpressMode;
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x0008A610 File Offset: 0x00088810
		public override bool CanAddPriceWork()
		{
			return base.ExpressMode;
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0008A624 File Offset: 0x00088824
		[AsyncCommand]
		public override Task ExpandAllNodes(TreeListNodeChangedEventArgs e)
		{
			WpExpressViewModel.<ExpandAllNodes>d__9 <ExpandAllNodes>d__;
			<ExpandAllNodes>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExpandAllNodes>d__.<>4__this = this;
			<ExpandAllNodes>d__.e = e;
			<ExpandAllNodes>d__.<>1__state = -1;
			<ExpandAllNodes>d__.<>t__builder.Start<WpExpressViewModel.<ExpandAllNodes>d__9>(ref <ExpandAllNodes>d__);
			return <ExpandAllNodes>d__.<>t__builder.Task;
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x0008A670 File Offset: 0x00088870
		[Command]
		public override void ShowingEditor(TreeListShowingEditorEventArgs e)
		{
			if (((WorkPartObject)e.Node.Content).Type == 2)
			{
				TreeListColumn treeListColumn = e.Column as TreeListColumn;
				if (treeListColumn == null)
				{
					e.Cancel = true;
					return;
				}
				if (base.ExpressMode && (treeListColumn.FieldName == "WarrantyCol" || treeListColumn.FieldName == "Employee"))
				{
					return;
				}
				if (treeListColumn.FieldName == "WarrantyCol")
				{
					return;
				}
				e.Cancel = true;
			}
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x0008A6F8 File Offset: 0x000888F8
		public override void AddProductFromEmployeeCart(store_int_reserve selectedItem, int count = 1)
		{
			if (selectedItem == null)
			{
				goto IL_12;
			}
			goto IL_6F;
			int num;
			WorkPartObject item;
			for (;;)
			{
				IL_3C:
				switch ((num ^ -1945708563) % 6)
				{
				case 0:
					item = base.Reserve2Wpo(selectedItem, base.SelectedItem.Id, base.RepairId, "");
					num = -249526476;
					continue;
				case 2:
					goto IL_6F;
				case 3:
					return;
				case 4:
					goto IL_12;
				case 5:
					return;
				}
				break;
			}
			base.Items.Add(item);
			return;
			IL_12:
			num = -367960536;
			goto IL_3C;
			IL_6F:
			num = ((!base.ItemsCostBiggerWorkCost(selectedItem.Summ)) ? -1402733989 : -943506084);
			goto IL_3C;
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x0008A794 File Offset: 0x00088994
		public override void AddProductDirectFromStore(store_items directItem, int count = 1, [Optional] decimal price = 0m)
		{
			if (directItem == null || !OfflineData.Instance.Employee.Can(69, 0))
			{
				return;
			}
			int? num = StoreModel.OfficeIdByStoreId(directItem.store);
			int office = Auth.User.office;
			if (!(num.GetValueOrDefault() == office & num != null))
			{
				this._toasterService.Error(Lang.t("ItemInForeignOffice"));
				return;
			}
			decimal itemSumm = directItem.price * count;
			if (!base.Repair.is_warranty && !base.Repair.is_repeat && base.ItemsCostBiggerWorkCost(itemSumm))
			{
				return;
			}
			if (price == 0m && !base.Repair.is_warranty && !base.Repair.is_repeat)
			{
				price = directItem.price;
			}
			store_int_reserve store_int_reserve = base.NewReserve(directItem, count, price);
			if (!base.ItemsCostBiggerWorkCost(price))
			{
				store_int_reserve.work_id = new int?(base.SelectedItem.Id);
				WorkPartObject workPartObject = base.Reserve2Wpo(store_int_reserve, base.SelectedItem.Id, base.RepairId, directItem.name);
				workPartObject.EmployeeId = base.SelectedItem.EmployeeId;
				workPartObject.DirectItem = true;
				workPartObject.Id = -directItem.id;
				base.Items.Add(workPartObject);
				base.CountTotal();
				return;
			}
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0008A8E8 File Offset: 0x00088AE8
		[AsyncCommand]
		public override Task RemoveItem()
		{
			WpExpressViewModel.<RemoveItem>d__13 <RemoveItem>d__;
			<RemoveItem>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemoveItem>d__.<>4__this = this;
			<RemoveItem>d__.<>1__state = -1;
			<RemoveItem>d__.<>t__builder.Start<WpExpressViewModel.<RemoveItem>d__13>(ref <RemoveItem>d__);
			return <RemoveItem>d__.<>t__builder.Task;
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x0008A610 File Offset: 0x00088810
		public override bool CanRemoveItem()
		{
			return base.ExpressMode;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public override void ItemDoubleClick()
		{
		}

		// Token: 0x0400183D RID: 6205
		private NewRepairViewModel _parentViewModel;

		// Token: 0x0200044E RID: 1102
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddWork>d__6 : IAsyncStateMachine
		{
			// Token: 0x06002B88 RID: 11144 RVA: 0x0008A92C File Offset: 0x00088B2C
			void IAsyncStateMachine.MoveNext()
			{
				WpExpressViewModel wpExpressViewModel = this.<>4__this;
				try
				{
					WorkPartObject workPartObject = new WorkPartObject(wpExpressViewModel.RepairId, RepairItem.Types.Work, "", 1, 0m)
					{
						Warranty = Auth.Config.default_works_warranty,
						EmployeeId = OfflineData.Instance.Employee.Id
					};
					workPartObject.GenerateRandomId();
					wpExpressViewModel.Items.Add(workPartObject);
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

			// Token: 0x06002B89 RID: 11145 RVA: 0x0008A9CC File Offset: 0x00088BCC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400183E RID: 6206
			public int <>1__state;

			// Token: 0x0400183F RID: 6207
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001840 RID: 6208
			public WpExpressViewModel <>4__this;
		}

		// Token: 0x0200044F RID: 1103
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExpandAllNodes>d__9 : IAsyncStateMachine
		{
			// Token: 0x06002B8A RID: 11146 RVA: 0x0008A9E8 File Offset: 0x00088BE8
			void IAsyncStateMachine.MoveNext()
			{
				WpExpressViewModel wpExpressViewModel = this.<>4__this;
				try
				{
					if (this.e.ChangeType == NodeChangeType.Add)
					{
						TreeListNode parentNode = this.e.Node.ParentNode;
						if (parentNode != null)
						{
							parentNode.ExpandAll();
						}
					}
					if (this.e.ChangeType == NodeChangeType.Content)
					{
						wpExpressViewModel.CountTotal();
						if (wpExpressViewModel._parentViewModel != null)
						{
							wpExpressViewModel._parentViewModel.WpPartObjects = wpExpressViewModel.Items;
							wpExpressViewModel._parentViewModel.TotalAmount = Fn.FormatSumm(wpExpressViewModel.TotalRepairCost);
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

			// Token: 0x06002B8B RID: 11147 RVA: 0x0008AAA4 File Offset: 0x00088CA4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001841 RID: 6209
			public int <>1__state;

			// Token: 0x04001842 RID: 6210
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001843 RID: 6211
			public TreeListNodeChangedEventArgs e;

			// Token: 0x04001844 RID: 6212
			public WpExpressViewModel <>4__this;
		}

		// Token: 0x02000450 RID: 1104
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveItem>d__13 : IAsyncStateMachine
		{
			// Token: 0x06002B8C RID: 11148 RVA: 0x0008AAC0 File Offset: 0x00088CC0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WpExpressViewModel wpExpressViewModel = this.<>4__this;
				try
				{
					if (wpExpressViewModel.SelectedItem != null)
					{
						if (wpExpressViewModel.SelectedItem.Type == 1)
						{
							IEnumerator<WorkPartObject> enumerator = wpExpressViewModel.GetWorkParts(wpExpressViewModel.SelectedItem.Id).GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									WorkPartObject item = enumerator.Current;
									wpExpressViewModel.Items.Remove(item);
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
						}
						wpExpressViewModel.Items.Remove(wpExpressViewModel.SelectedItem);
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

			// Token: 0x06002B8D RID: 11149 RVA: 0x0008AB98 File Offset: 0x00088D98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001845 RID: 6213
			public int <>1__state;

			// Token: 0x04001846 RID: 6214
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001847 RID: 6215
			public WpExpressViewModel <>4__this;
		}
	}
}
