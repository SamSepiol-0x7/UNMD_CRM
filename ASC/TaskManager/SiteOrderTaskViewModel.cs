using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.Extensions.OpenCart;
using ASC.Extensions.OpenCart.Models;
using ASC.Interfaces;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Services;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Newtonsoft.Json;

namespace ASC.TaskManager
{
	// Token: 0x020002C5 RID: 709
	public class SiteOrderTaskViewModel : EmployeeTaskViewModel
	{
		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000695E8 File Offset: 0x000677E8
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x000695FC File Offset: 0x000677FC
		public IOrder SiteOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<SiteOrder>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<SiteOrder>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -656699197;
				IL_13:
				switch ((num ^ -432239091) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					num = -1437191444;
					goto IL_13;
				}
				this.<SiteOrder>k__BackingField = value;
				this.RaisePropertyChanged("SiteOrder");
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x00069658 File Offset: 0x00067858
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x0006966C File Offset: 0x0006786C
		public SiteOrderProductsViewModel SiteOrderProductsViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<SiteOrderProductsViewModel>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<SiteOrderProductsViewModel>k__BackingField, value))
				{
					return;
				}
				this.<SiteOrderProductsViewModel>k__BackingField = value;
				this.RaisePropertyChanged("SiteOrderProductsViewModel");
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0006969C File Offset: 0x0006789C
		protected SiteOrderTaskViewModel()
		{
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x000696B0 File Offset: 0x000678B0
		public static SiteOrderTaskViewModel Create(int taskId)
		{
			return ViewModelSource.Create<SiteOrderTaskViewModel>(() => new SiteOrderTaskViewModel(taskId));
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00069718 File Offset: 0x00067918
		protected SiteOrderTaskViewModel(int taskId) : base(taskId)
		{
			this._hookService = Bootstrapper.Container.Resolve<IHookService>();
			this._customerService = Bootstrapper.Container.Resolve<ICustomerService>();
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0006974C File Offset: 0x0006794C
		private void LoadSiteOrder()
		{
			SiteOrderTaskViewModel.<LoadSiteOrder>d__14 <LoadSiteOrder>d__;
			<LoadSiteOrder>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadSiteOrder>d__.<>4__this = this;
			<LoadSiteOrder>d__.<>1__state = -1;
			<LoadSiteOrder>d__.<>t__builder.Start<SiteOrderTaskViewModel.<LoadSiteOrder>d__14>(ref <LoadSiteOrder>d__);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00069784 File Offset: 0x00067984
		[Command]
		public void NavigateCustomerCard()
		{
			this._navigationService.NavigateToCustomerCard(this._customerId, null);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x000697A4 File Offset: 0x000679A4
		public bool CanNavigateCustomerCard()
		{
			return this._customerId > 0 && base.ViewLoaded;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000697C4 File Offset: 0x000679C4
		public void SetDocument(IStoreDocument document)
		{
			base.Task.DocumentId = new int?(document.Id);
			this.Save();
			base.RaiseCanExecuteChanged(() => this.ReserveItems());
			base.RaiseCanExecuteChanged(() => this.NavigateDocument());
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00069864 File Offset: 0x00067A64
		[Command]
		public void ReserveItems()
		{
			SiteOrderTaskViewModel.<ReserveItems>d__18 <ReserveItems>d__;
			<ReserveItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ReserveItems>d__.<>4__this = this;
			<ReserveItems>d__.<>1__state = -1;
			<ReserveItems>d__.<>t__builder.Start<SiteOrderTaskViewModel.<ReserveItems>d__18>(ref <ReserveItems>d__);
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0006989C File Offset: 0x00067A9C
		public bool CanReserveItems()
		{
			return base.Task != null && base.ViewLoaded && base.Task.DocumentId == null && base.Task.Type == TaskType.SitePartsRequest && this.SiteOrder != null && this.SiteOrder.Products.Any<IProduct>();
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000698F8 File Offset: 0x00067AF8
		[Command]
		public void NavigateDocument()
		{
			this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(base.Task.DocumentId.Value));
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00069930 File Offset: 0x00067B30
		public bool CanNavigateDocument()
		{
			if (base.Task != null)
			{
				int? documentId = base.Task.DocumentId;
				return documentId.GetValueOrDefault() > 0 & documentId != null;
			}
			return false;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00069968 File Offset: 0x00067B68
		[Command]
		public override void Save()
		{
			SiteOrderTaskViewModel.<Save>d__22 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<SiteOrderTaskViewModel.<Save>d__22>(ref <Save>d__);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000699A0 File Offset: 0x00067BA0
		public override void OnLoaded()
		{
			base.OnLoaded();
			this.LoadSiteOrder();
			base.SetViewLoaded(true);
			base.RaiseCanExecuteChanged(() => this.NavigateCustomerCard());
			base.RaiseCanExecuteChanged(() => this.ReserveItems());
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00069A38 File Offset: 0x00067C38
		[Command]
		public void OpenSiteOrder()
		{
			this._toasterService.Info("Coming soon...");
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00069A58 File Offset: 0x00067C58
		public bool CanOpenSiteOrder()
		{
			return this.SiteOrder != null && !string.IsNullOrEmpty(Auth.Config.online_store_api);
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00069A84 File Offset: 0x00067C84
		[CompilerGenerated]
		private Task<bool> <Save>b__22_0()
		{
			return this._taskService.UpdateTask(base.Task);
		}

		// Token: 0x0400128A RID: 4746
		protected IHookService _hookService;

		// Token: 0x0400128B RID: 4747
		protected ICustomerService _customerService;

		// Token: 0x0400128C RID: 4748
		[CompilerGenerated]
		private IOrder <SiteOrder>k__BackingField;

		// Token: 0x0400128D RID: 4749
		[CompilerGenerated]
		private SiteOrderProductsViewModel <SiteOrderProductsViewModel>k__BackingField;

		// Token: 0x0400128E RID: 4750
		private int _customerId;

		// Token: 0x020002C6 RID: 710
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060023A1 RID: 9121 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0400128F RID: 4751
			public int taskId;
		}

		// Token: 0x020002C7 RID: 711
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSiteOrder>d__14 : IAsyncStateMachine
		{
			// Token: 0x060023A2 RID: 9122 RVA: 0x00069AA4 File Offset: 0x00067CA4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SiteOrderTaskViewModel siteOrderTaskViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<clients> awaiter;
					TaskAwaiter<IHook> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<clients>);
							this.<>1__state = -1;
							goto IL_E3;
						}
						awaiter2 = siteOrderTaskViewModel._hookService.GetFirstHookByTaskId(siteOrderTaskViewModel.TaskId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IHook>, SiteOrderTaskViewModel.<LoadSiteOrder>d__14>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IHook>);
						this.<>1__state = -1;
					}
					IHook result = awaiter2.GetResult();
					if (result == null)
					{
						goto IL_187;
					}
					siteOrderTaskViewModel.SiteOrder = JsonConvert.DeserializeObject<Order>(result.Prm);
					if (siteOrderTaskViewModel.SiteOrder == null)
					{
						siteOrderTaskViewModel._toasterService.Error("");
						goto IL_1A2;
					}
					awaiter = siteOrderTaskViewModel._customerService.GetByEmail(siteOrderTaskViewModel.SiteOrder.Email).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<clients>, SiteOrderTaskViewModel.<LoadSiteOrder>d__14>(ref awaiter, ref this);
						return;
					}
					IL_E3:
					clients result2 = awaiter.GetResult();
					siteOrderTaskViewModel._customerId = result2.id;
					siteOrderTaskViewModel.RaiseCanExecuteChanged(() => siteOrderTaskViewModel.NavigateCustomerCard());
					siteOrderTaskViewModel.SiteOrderProductsViewModel = new SiteOrderProductsViewModel(siteOrderTaskViewModel.SiteOrder);
					siteOrderTaskViewModel.SiteOrderProductsViewModel.SetParentViewModel(siteOrderTaskViewModel);
					IL_187:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1A2:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060023A3 RID: 9123 RVA: 0x00069C84 File Offset: 0x00067E84
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001290 RID: 4752
			public int <>1__state;

			// Token: 0x04001291 RID: 4753
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001292 RID: 4754
			public SiteOrderTaskViewModel <>4__this;

			// Token: 0x04001293 RID: 4755
			private TaskAwaiter<IHook> <>u__1;

			// Token: 0x04001294 RID: 4756
			private TaskAwaiter<clients> <>u__2;
		}

		// Token: 0x020002C8 RID: 712
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060023A4 RID: 9124 RVA: 0x00069CA0 File Offset: 0x00067EA0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060023A5 RID: 9125 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060023A6 RID: 9126 RVA: 0x00069CB8 File Offset: 0x00067EB8
			internal bool <ReserveItems>b__18_0(IProduct p)
			{
				return p.Sku != null;
			}

			// Token: 0x060023A7 RID: 9127 RVA: 0x00069CD4 File Offset: 0x00067ED4
			internal int <ReserveItems>b__18_1(IProduct p)
			{
				return p.Sku.Value;
			}

			// Token: 0x04001295 RID: 4757
			public static readonly SiteOrderTaskViewModel.<>c <>9 = new SiteOrderTaskViewModel.<>c();

			// Token: 0x04001296 RID: 4758
			public static Func<IProduct, bool> <>9__18_0;

			// Token: 0x04001297 RID: 4759
			public static Func<IProduct, int> <>9__18_1;
		}

		// Token: 0x020002C9 RID: 713
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ReserveItems>d__18 : IAsyncStateMachine
		{
			// Token: 0x060023A8 RID: 9128 RVA: 0x00069CF0 File Offset: 0x00067EF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SiteOrderTaskViewModel siteOrderTaskViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<store_items>> awaiter;
					if (num != 0)
					{
						siteOrderTaskViewModel.ShowWait();
						awaiter = ItemsModel.LoadItems(siteOrderTaskViewModel.SiteOrder.Products.Where(new Func<IProduct, bool>(SiteOrderTaskViewModel.<>c.<>9.<ReserveItems>b__18_0)).Select(new Func<IProduct, int>(SiteOrderTaskViewModel.<>c.<>9.<ReserveItems>b__18_1)).ToList<int>()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, SiteOrderTaskViewModel.<ReserveItems>d__18>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
						this.<>1__state = -1;
					}
					IEnumerable<store_items> result = awaiter.GetResult();
					siteOrderTaskViewModel.HideWait();
					if (!result.Any<store_items>())
					{
						siteOrderTaskViewModel._toasterService.Error("No items found in database");
					}
					else
					{
						ItemsSaleViewModel itemsSaleViewModel = new ItemsSaleViewModel(result, true);
						if (siteOrderTaskViewModel._customerId > 0)
						{
							itemsSaleViewModel.SetCustomer(siteOrderTaskViewModel._customerId);
						}
						siteOrderTaskViewModel._navigationService.Navigate("ItemsSaleView", itemsSaleViewModel, siteOrderTaskViewModel);
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

			// Token: 0x060023A9 RID: 9129 RVA: 0x00069E68 File Offset: 0x00068068
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001298 RID: 4760
			public int <>1__state;

			// Token: 0x04001299 RID: 4761
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400129A RID: 4762
			public SiteOrderTaskViewModel <>4__this;

			// Token: 0x0400129B RID: 4763
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x020002CA RID: 714
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__22 : IAsyncStateMachine
		{
			// Token: 0x060023AA RID: 9130 RVA: 0x00069E84 File Offset: 0x00068084
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SiteOrderTaskViewModel siteOrderTaskViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						siteOrderTaskViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = System.Threading.Tasks.Task.Run<bool>(() => siteOrderTaskViewModel._taskService.UpdateTask(base.Task)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, SiteOrderTaskViewModel.<Save>d__22>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						siteOrderTaskViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							siteOrderTaskViewModel.HideWait();
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

			// Token: 0x060023AB RID: 9131 RVA: 0x00069F8C File Offset: 0x0006818C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400129C RID: 4764
			public int <>1__state;

			// Token: 0x0400129D RID: 4765
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400129E RID: 4766
			public SiteOrderTaskViewModel <>4__this;

			// Token: 0x0400129F RID: 4767
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
