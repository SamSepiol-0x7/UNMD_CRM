using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Objects;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004D3 RID: 1235
	public class CustomerSalesViewModel : CollectionViewModel<Product>
	{
		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x0009BFA0 File Offset: 0x0009A1A0
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x0009BFB4 File Offset: 0x0009A1B4
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x0009BFE4 File Offset: 0x0009A1E4
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x0009BFF8 File Offset: 0x0009A1F8
		public List<ItemUnits> Units
		{
			[CompilerGenerated]
			get
			{
				return this.<Units>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Units>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -283938904;
				IL_13:
				switch ((num ^ -472922247) % 4)
				{
				case 0:
					IL_32:
					this.<Units>k__BackingField = value;
					this.RaisePropertyChanged("Units");
					num = -343345761;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x0009C054 File Offset: 0x0009A254
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x0009C068 File Offset: 0x0009A268
		public int SelectedPaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedPaymentSystem>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -2102354440;
				IL_10:
				switch ((num ^ -481980838) % 4)
				{
				case 1:
					IL_2F:
					this.<SelectedPaymentSystem>k__BackingField = value;
					num = -411802790;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("SelectedPaymentSystem");
			}
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x0009C0C0 File Offset: 0x0009A2C0
		public CustomerSalesViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._storeService = Bootstrapper.Container.Resolve<IStoreService>();
			this.SelectedPaymentSystem = -100;
			this.Period = new Period();
			this.Units = this._storeService.GetUnits();
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x0009C128 File Offset: 0x0009A328
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as CustomerCardViewModel);
			CustomerCardViewModel parentViewModel2 = this._parentViewModel;
			if (((parentViewModel2 != null) ? parentViewModel2.Customer : null) != null)
			{
				this._customerId = this._parentViewModel.Customer.Id;
				this.LoadData();
			}
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x0009C178 File Offset: 0x0009A378
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x0009C18C File Offset: 0x0009A38C
		[Command]
		public void RowDoubleClick()
		{
			if (base.SelectedItem != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -1112893111;
			IL_0D:
			switch ((num ^ -1253124685) % 4)
			{
			case 1:
				IL_2C:
				this._navigationService.Navigate("ItemCardView", new ItemCardViewModel(base.SelectedItem.Id, 0));
				num = -2059628857;
				goto IL_0D;
			case 2:
				return;
			case 3:
				goto IL_08;
			}
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x0009C1F0 File Offset: 0x0009A3F0
		public void LoadData()
		{
			CustomerSalesViewModel.<LoadData>d__21 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<CustomerSalesViewModel.<LoadData>d__21>(ref <LoadData>d__);
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x0009C228 File Offset: 0x0009A428
		private Task<List<Product>> GetDealerSales(int dealerId, IPeriod period, int paymentSystem)
		{
			CustomerSalesViewModel.<GetDealerSales>d__22 <GetDealerSales>d__;
			<GetDealerSales>d__.<>t__builder = AsyncTaskMethodBuilder<List<Product>>.Create();
			<GetDealerSales>d__.dealerId = dealerId;
			<GetDealerSales>d__.period = period;
			<GetDealerSales>d__.paymentSystem = paymentSystem;
			<GetDealerSales>d__.<>1__state = -1;
			<GetDealerSales>d__.<>t__builder.Start<CustomerSalesViewModel.<GetDealerSales>d__22>(ref <GetDealerSales>d__);
			return <GetDealerSales>d__.<>t__builder.Task;
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x0009C27C File Offset: 0x0009A47C
		[CompilerGenerated]
		private Task<List<Product>> <LoadData>b__21_0()
		{
			return this.GetDealerSales(this._customerId, this.Period, this.SelectedPaymentSystem);
		}

		// Token: 0x04001AE5 RID: 6885
		private readonly INavigationService _navigationService;

		// Token: 0x04001AE6 RID: 6886
		private readonly IToasterService _toasterService;

		// Token: 0x04001AE7 RID: 6887
		private readonly IStoreService _storeService;

		// Token: 0x04001AE8 RID: 6888
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001AE9 RID: 6889
		private int _customerId;

		// Token: 0x04001AEA RID: 6890
		[CompilerGenerated]
		private List<ItemUnits> <Units>k__BackingField;

		// Token: 0x04001AEB RID: 6891
		[CompilerGenerated]
		private int <SelectedPaymentSystem>k__BackingField;

		// Token: 0x04001AEC RID: 6892
		private CustomerCardViewModel _parentViewModel;

		// Token: 0x020004D4 RID: 1236
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__21 : IAsyncStateMachine
		{
			// Token: 0x06002F9C RID: 12188 RVA: 0x0009C2A4 File Offset: 0x0009A4A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerSalesViewModel customerSalesViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (customerSalesViewModel._customerId == 0)
						{
							goto IL_D3;
						}
						customerSalesViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<List<Product>> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<List<Product>>(() => base.GetDealerSales(customerSalesViewModel._customerId, base.Period, base.SelectedPaymentSystem)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Product>>, CustomerSalesViewModel.<LoadData>d__21>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<Product>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<Product> result = awaiter.GetResult();
						customerSalesViewModel.SetItems(result);
					}
					catch (Exception ex)
					{
						customerSalesViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							customerSalesViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_D3:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002F9D RID: 12189 RVA: 0x0009C3C0 File Offset: 0x0009A5C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AED RID: 6893
			public int <>1__state;

			// Token: 0x04001AEE RID: 6894
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001AEF RID: 6895
			public CustomerSalesViewModel <>4__this;

			// Token: 0x04001AF0 RID: 6896
			private TaskAwaiter<List<Product>> <>u__1;
		}

		// Token: 0x020004D5 RID: 1237
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06002F9E RID: 12190 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x04001AF1 RID: 6897
			public int dealerId;

			// Token: 0x04001AF2 RID: 6898
			public DateTime from;

			// Token: 0x04001AF3 RID: 6899
			public DateTime to;

			// Token: 0x04001AF4 RID: 6900
			public int paymentSystem;
		}

		// Token: 0x020004D6 RID: 1238
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002F9F RID: 12191 RVA: 0x0009C3DC File Offset: 0x0009A5DC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002FA0 RID: 12192 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002FA1 RID: 12193 RVA: 0x0009C3F4 File Offset: 0x0009A5F4
			internal IOrderedQueryable<store_items> <GetDealerSales>b__22_3(IQueryable<store_items> i)
			{
				return from o in i
				orderby o.docs.id
				select o;
			}

			// Token: 0x06002FA2 RID: 12194 RVA: 0x0009C454 File Offset: 0x0009A654
			internal Product <GetDealerSales>b__22_0(store_items i)
			{
				return i.ToStoreItem();
			}

			// Token: 0x04001AF5 RID: 6901
			public static readonly CustomerSalesViewModel.<>c <>9 = new CustomerSalesViewModel.<>c();

			// Token: 0x04001AF6 RID: 6902
			public static Func<IQueryable<store_items>, IOrderedQueryable<store_items>> <>9__22_3;

			// Token: 0x04001AF7 RID: 6903
			public static Func<store_items, Product> <>9__22_0;
		}

		// Token: 0x020004D7 RID: 1239
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDealerSales>d__22 : IAsyncStateMachine
		{
			// Token: 0x06002FA3 RID: 12195 RVA: 0x0009C468 File Offset: 0x0009A668
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<Product> result2;
				try
				{
					CustomerSalesViewModel.<>c__DisplayClass22_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CustomerSalesViewModel.<>c__DisplayClass22_0();
						CS$<>8__locals1.dealerId = this.dealerId;
						CS$<>8__locals1.paymentSystem = this.paymentSystem;
						CS$<>8__locals1.from = this.period.From.Date;
						CS$<>8__locals1.to = this.period.To.Date.AddDays(1.0).AddSeconds(-1.0);
						this.<repo>5__2 = new GenericRepository<store_items>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_items>> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							List<KeyValuePair<bool, Expression<Func<store_items, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<store_items, bool>>>>
							{
								new KeyValuePair<bool, Expression<Func<store_items, bool>>>(true, (store_items i) => i.dealer == CS$<>8__locals1.dealerId && i.docs.type == 1 && i.docs.order_id != null && i.docs.created >= CS$<>8__locals1.from && i.docs.created <= CS$<>8__locals1.to && i.docs.total > 0m && !i.docs.is_realization),
								new KeyValuePair<bool, Expression<Func<store_items, bool>>>(CS$<>8__locals1.paymentSystem != -100, (store_items i) => i.docs.payment_system == CS$<>8__locals1.paymentSystem)
							};
							awaiter = this.<repo>5__2.GetAllAsync(filterList, new Func<IQueryable<store_items>, IOrderedQueryable<store_items>>(CustomerSalesViewModel.<>c.<>9.<GetDealerSales>b__22_3), "docs", false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, CustomerSalesViewModel.<GetDealerSales>d__22>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						IEnumerable<store_items> result = awaiter.GetResult();
						IEnumerator<store_items> enumerator = result.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								store_items store_items = enumerator.Current;
								if (store_items.docs != null)
								{
									store_items.created = new DateTime?(store_items.docs.created);
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						result2 = result.Select(new Func<store_items, Product>(CustomerSalesViewModel.<>c.<>9.<GetDealerSales>b__22_0)).ToList<Product>();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06002FA4 RID: 12196 RVA: 0x0009C994 File Offset: 0x0009AB94
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AF8 RID: 6904
			public int <>1__state;

			// Token: 0x04001AF9 RID: 6905
			public AsyncTaskMethodBuilder<List<Product>> <>t__builder;

			// Token: 0x04001AFA RID: 6906
			public int dealerId;

			// Token: 0x04001AFB RID: 6907
			public int paymentSystem;

			// Token: 0x04001AFC RID: 6908
			public IPeriod period;

			// Token: 0x04001AFD RID: 6909
			private GenericRepository<store_items> <repo>5__2;

			// Token: 0x04001AFE RID: 6910
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}
	}
}
