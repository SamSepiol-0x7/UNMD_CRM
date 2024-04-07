using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Threading;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.LookUp;

namespace ASC.ViewModels
{
	// Token: 0x020003E9 RID: 1001
	public class CustomerSearchViewModel : CollectionViewModel<ICustomer>, ICustomerSearchViewModel
	{
		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x0007E8E0 File Offset: 0x0007CAE0
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x0007E8F4 File Offset: 0x0007CAF4
		public new List<ICustomer> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0007E924 File Offset: 0x0007CB24
		public CustomerSearchViewModel(ICustomerService customerService)
		{
			this._customerService = customerService;
			this.Items = new List<ICustomer>();
			this._searchTimer = new DispatcherTimer
			{
				IsEnabled = false,
				Interval = TimeSpan.FromMilliseconds(300.0)
			};
			this._searchTimer.Tick += this.OnSearchTimerTick;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x0007E988 File Offset: 0x0007CB88
		public ICustomer GetSelected()
		{
			return base.SelectedItem;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x0007E99C File Offset: 0x0007CB9C
		public void SetSelected(int customerId)
		{
			CustomerSearchViewModel.<SetSelected>d__10 <SetSelected>d__;
			<SetSelected>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetSelected>d__.<>4__this = this;
			<SetSelected>d__.customerId = customerId;
			<SetSelected>d__.<>1__state = -1;
			<SetSelected>d__.<>t__builder.Start<CustomerSearchViewModel.<SetSelected>d__10>(ref <SetSelected>d__);
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0007E9DC File Offset: 0x0007CBDC
		public void SetSelected(ICustomer customer)
		{
			this.Items.Clear();
			this.Items.Add(customer);
			base.SelectedItem = customer;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0007EA08 File Offset: 0x0007CC08
		private void OnSearchTimerTick(object sender, EventArgs e)
		{
			this._searchTimer.Stop();
			this.Search(this._query);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0007EA2C File Offset: 0x0007CC2C
		private void Search(string query)
		{
			CustomerSearchViewModel.<Search>d__13 <Search>d__;
			<Search>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Search>d__.<>4__this = this;
			<Search>d__.query = query;
			<Search>d__.<>1__state = -1;
			<Search>d__.<>t__builder.Start<CustomerSearchViewModel.<Search>d__13>(ref <Search>d__);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0007EA6C File Offset: 0x0007CC6C
		[Command]
		public void OnItemNameKeyUp(LookUpEdit lue)
		{
			if (base.SelectedItem != null)
			{
				return;
			}
			if (this._gridControl == null)
			{
				this._gridControl = lue.GetGridControl();
			}
			if (this._gridControl != null)
			{
				this._gridControl.ShowLoadingPanel = true;
			}
			this._query = lue.AutoSearchText;
			this._searchTimer.Stop();
			this._searchTimer.Start();
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0003927C File Offset: 0x0003747C
		[Command]
		public void AllowProperty(AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}

		// Token: 0x04001668 RID: 5736
		protected ICustomerService _customerService;

		// Token: 0x04001669 RID: 5737
		private GridControl _gridControl;

		// Token: 0x0400166A RID: 5738
		private string _query;

		// Token: 0x0400166B RID: 5739
		private DispatcherTimer _searchTimer;

		// Token: 0x0400166C RID: 5740
		[CompilerGenerated]
		private List<ICustomer> <Items>k__BackingField;

		// Token: 0x020003EA RID: 1002
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetSelected>d__10 : IAsyncStateMachine
		{
			// Token: 0x060028CC RID: 10444 RVA: 0x0007EACC File Offset: 0x0007CCCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerSearchViewModel customerSearchViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<ICustomer> awaiter;
					if (num != 0)
					{
						awaiter = customerSearchViewModel._customerService.GetCustomerCardAsync(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICustomer>, CustomerSearchViewModel.<SetSelected>d__10>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<ICustomer>);
						this.<>1__state = -1;
					}
					ICustomer result = awaiter.GetResult();
					customerSearchViewModel.SetSelected(result);
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

			// Token: 0x060028CD RID: 10445 RVA: 0x0007EB94 File Offset: 0x0007CD94
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400166D RID: 5741
			public int <>1__state;

			// Token: 0x0400166E RID: 5742
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400166F RID: 5743
			public CustomerSearchViewModel <>4__this;

			// Token: 0x04001670 RID: 5744
			public int customerId;

			// Token: 0x04001671 RID: 5745
			private TaskAwaiter<ICustomer> <>u__1;
		}

		// Token: 0x020003EB RID: 1003
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x060028CE RID: 10446 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x060028CF RID: 10447 RVA: 0x0007EBB0 File Offset: 0x0007CDB0
			internal Task<IEnumerable<ICustomer>> <Search>b__1()
			{
				return this.<>4__this._customerService.GetCustomers(-1, 0, this.query, false);
			}

			// Token: 0x04001672 RID: 5746
			public CustomerSearchViewModel <>4__this;

			// Token: 0x04001673 RID: 5747
			public string query;
		}

		// Token: 0x020003EC RID: 1004
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Search>d__13 : IAsyncStateMachine
		{
			// Token: 0x060028D0 RID: 10448 RVA: 0x0007EBD8 File Offset: 0x0007CDD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerSearchViewModel customerSearchViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<ICustomer>> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new CustomerSearchViewModel.<>c__DisplayClass13_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.query = this.query;
						awaiter = Task.Run<IEnumerable<ICustomer>>(new Func<Task<IEnumerable<ICustomer>>>(this.<>8__1.<Search>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<ICustomer>>, CustomerSearchViewModel.<Search>d__13>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<ICustomer>>);
						this.<>1__state = -1;
					}
					IEnumerable<ICustomer> result = awaiter.GetResult();
					if (this.<>8__1.query == customerSearchViewModel._query)
					{
						customerSearchViewModel.Items.Clear();
						customerSearchViewModel.Items.AddRange(result);
						customerSearchViewModel.RaisePropertyChanged<List<ICustomer>>(() => customerSearchViewModel.Items);
						if (customerSearchViewModel._gridControl != null)
						{
							customerSearchViewModel._gridControl.ShowLoadingPanel = false;
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

			// Token: 0x060028D1 RID: 10449 RVA: 0x0007ED60 File Offset: 0x0007CF60
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001674 RID: 5748
			public int <>1__state;

			// Token: 0x04001675 RID: 5749
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001676 RID: 5750
			public CustomerSearchViewModel <>4__this;

			// Token: 0x04001677 RID: 5751
			public string query;

			// Token: 0x04001678 RID: 5752
			private CustomerSearchViewModel.<>c__DisplayClass13_0 <>8__1;

			// Token: 0x04001679 RID: 5753
			private TaskAwaiter<IEnumerable<ICustomer>> <>u__1;
		}
	}
}
