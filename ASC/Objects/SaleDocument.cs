using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects.Converters;

namespace ASC.Objects
{
	// Token: 0x02000886 RID: 2182
	public class SaleDocument : StoreDocument, IStoreDocument, ISaleDocument, ICheckFields
	{
		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060041D2 RID: 16850 RVA: 0x00103590 File Offset: 0x00101790
		// (set) Token: 0x060041D3 RID: 16851 RVA: 0x001035A4 File Offset: 0x001017A4
		public ObservableCollection<store_items> Items
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

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x001035D4 File Offset: 0x001017D4
		// (set) Token: 0x060041D5 RID: 16853 RVA: 0x001035E8 File Offset: 0x001017E8
		public ICustomer Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Customer>k__BackingField, value))
				{
					return;
				}
				this.<Customer>k__BackingField = value;
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x00103618 File Offset: 0x00101818
		// (set) Token: 0x060041D7 RID: 16855 RVA: 0x0010362C File Offset: 0x0010182C
		public IInvoice Invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<Invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Invoice>k__BackingField, value))
				{
					return;
				}
				this.<Invoice>k__BackingField = value;
				this.RaisePropertyChanged("Invoice");
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x0010365C File Offset: 0x0010185C
		// (set) Token: 0x060041D9 RID: 16857 RVA: 0x00103670 File Offset: 0x00101870
		public ICashOrder CashOrder
		{
			[CompilerGenerated]
			get
			{
				return this.<CashOrder>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CashOrder>k__BackingField, value))
				{
					return;
				}
				this.<CashOrder>k__BackingField = value;
				this.RaisePropertyChanged("CashOrder");
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x001036A0 File Offset: 0x001018A0
		// (set) Token: 0x060041DB RID: 16859 RVA: 0x001036E4 File Offset: 0x001018E4
		public override int PriceOption
		{
			get
			{
				return base.GetProperty<int>(() => this.PriceOption);
			}
			set
			{
				if (this.PriceOption == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.PriceOption, value, new Action<int>(this.PriceColChanged));
				this.RaisePropertyChanged("PriceOption");
			}
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x0010374C File Offset: 0x0010194C
		public void PriceColChanged(int col)
		{
			this.SetItemsCost();
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00103760 File Offset: 0x00101960
		public IAscResult CheckSumm(decimal summ)
		{
			Result result = new Result();
			if (base.PaymentSystem != -1 && summ < base.Total)
			{
				result.Message = "InputSumm";
				return result;
			}
			result.SetSuccess();
			return result;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x001037A0 File Offset: 0x001019A0
		public SaleDocument()
		{
			this.Items = new ObservableCollection<store_items>();
			this.Items.CollectionChanged += this.ItemsOnCollectionChanged;
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x001037D8 File Offset: 0x001019D8
		private void ItemsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (base.Id == 0)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1313454533;
			IL_0D:
			switch ((num ^ 1456690928) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_08;
			case 3:
				IL_2C:
				this.SetItemsCost();
				this.CountTotal();
				num = 1708785704;
				goto IL_0D;
			}
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x00103828 File Offset: 0x00101A28
		public void LoadItems()
		{
			SaleDocument.<LoadItems>d__23 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<SaleDocument.<LoadItems>d__23>(ref <LoadItems>d__);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00103860 File Offset: 0x00101A60
		public void SetItemsCost()
		{
			using (IEnumerator<store_items> enumerator = this.Items.GetEnumerator())
			{
				IL_ED:
				while (enumerator.MoveNext())
				{
					store_items store_items;
					for (;;)
					{
						IL_A0:
						store_items = enumerator.Current;
						for (;;)
						{
							IL_78:
							switch (this.PriceOption)
							{
							case 1:
								goto IL_A9;
							case 2:
								goto IL_B7;
							case 3:
								goto IL_C5;
							case 4:
								goto IL_D3;
							case 5:
								goto IL_E1;
							default:
							{
								uint num2;
								uint num = num2 * 3197668054U ^ 2544908849U;
								for (;;)
								{
									switch ((num2 = (num ^ 2228655178U)) % 14U)
									{
									case 0U:
									case 5U:
									case 6U:
									case 12U:
										goto IL_ED;
									case 1U:
										goto IL_C5;
									case 2U:
									case 13U:
										goto IL_A0;
									case 3U:
										goto IL_D3;
									case 4U:
										goto IL_E1;
									case 7U:
										goto IL_78;
									case 8U:
										goto IL_B7;
									case 9U:
										goto IL_A9;
									case 11U:
										num = (num2 * 801672244U ^ 4028123104U);
										continue;
									}
									goto Block_3;
								}
								break;
							}
							}
						}
					}
					IL_A9:
					store_items.BuyCost = store_items.Price1Formatted;
					continue;
					Block_3:
					break;
					IL_B7:
					store_items.BuyCost = store_items.Price2Formatted;
					continue;
					IL_C5:
					store_items.BuyCost = store_items.Price3Formatted;
					continue;
					IL_D3:
					store_items.BuyCost = store_items.Price4Formatted;
					continue;
					IL_E1:
					store_items.BuyCost = store_items.Price5Formatted;
				}
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x00103980 File Offset: 0x00101B80
		public virtual double ReserveProgress
		{
			get
			{
				Localization localization = new Localization("UTC");
				if (base.ReserveDays == 0)
				{
					return 0.0;
				}
				int num = (localization.Now - base.Date).Days * 100 / base.ReserveDays;
				if (num != 0)
				{
					return (double)((num > 100) ? 100 : num);
				}
				return 1.0;
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x001039E8 File Offset: 0x00101BE8
		// (set) Token: 0x060041E4 RID: 16868 RVA: 0x001039FC File Offset: 0x00101BFC
		public bool AnonCustomer
		{
			[CompilerGenerated]
			get
			{
				return this.<AnonCustomer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AnonCustomer>k__BackingField == value)
				{
					return;
				}
				this.<AnonCustomer>k__BackingField = value;
				this.RaisePropertyChanged("AnonCustomer");
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x00103A28 File Offset: 0x00101C28
		public string EndReserve
		{
			get
			{
				if (base.ReserveDays != 0)
				{
					return base.Date.AddDays((double)base.ReserveDays).ToShortDateString();
				}
				return null;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x00103A5C File Offset: 0x00101C5C
		public bool RnCancelled
		{
			get
			{
				return base.Status == DocStates.RnCancelled;
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x00103A74 File Offset: 0x00101C74
		public bool RnCancelledInvert
		{
			get
			{
				return !this.RnCancelled;
			}
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x00103A8C File Offset: 0x00101C8C
		public void AddItem(object item)
		{
			store_items store_items = item as store_items;
			if (store_items != null)
			{
				this.Items.Add(store_items);
			}
			Product product = item as Product;
			if (product != null)
			{
				this.Items.Add(product.BackToStoreItem());
			}
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x00103ACC File Offset: 0x00101CCC
		public void RemoveItem(object item)
		{
			store_items store_items = item as store_items;
			if (store_items != null)
			{
				this.Items.Remove(store_items);
			}
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x00103AF0 File Offset: 0x00101CF0
		public bool CanRemoveItem()
		{
			return base.Status == DocStates.NotActive || base.Status == DocStates.Reserve;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x00103B10 File Offset: 0x00101D10
		public bool CanPrintPn()
		{
			return base.Id > 0 && (base.Status == DocStates.Reserve || base.Status == DocStates.RnMaked);
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x00103B3C File Offset: 0x00101D3C
		public bool CanSetCustomer()
		{
			return base.Id == 0;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00103B54 File Offset: 0x00101D54
		public bool CanMakeInvoice()
		{
			return base.InvoiceId == null && base.Status == DocStates.Reserve;
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x00103B7C File Offset: 0x00101D7C
		public bool AnyItem(int itemId)
		{
			return this.Items != null && this.Items.Any((store_items i) => i.id == itemId);
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00103BB8 File Offset: 0x00101DB8
		public bool AnyItem()
		{
			return this.Items != null && this.Items.Any<store_items>();
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x00103BDC File Offset: 0x00101DDC
		public void SetCustomer(int customerId)
		{
			SaleDocument.<SetCustomer>d__45 <SetCustomer>d__;
			<SetCustomer>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetCustomer>d__.<>4__this = this;
			<SetCustomer>d__.customerId = customerId;
			<SetCustomer>d__.<>1__state = -1;
			<SetCustomer>d__.<>t__builder.Start<SaleDocument.<SetCustomer>d__45>(ref <SetCustomer>d__);
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x00103C1C File Offset: 0x00101E1C
		public void CountTotal()
		{
			base.SetTotal(this.Items.Sum((store_items i) => i.BuyCount * i.BuyCost));
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x00103C5C File Offset: 0x00101E5C
		public void ClearCustomer()
		{
			base.DealerId = null;
			this.Customer = ClientsModel.DefaultCustomer().Client2CustomerCard();
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00103C88 File Offset: 0x00101E88
		public string CheckFields()
		{
			if (base.CompanyId == 0)
			{
				return "InputCompany";
			}
			if (!this.AnyItem())
			{
				return "SelectItems";
			}
			using (IEnumerator<store_items> enumerator = this.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					store_items store_items = enumerator.Current;
					if (store_items.BuyCost < store_items.in_price && store_items.is_realization)
					{
						return "RealizationOutLessIn";
					}
				}
				goto IL_6D;
			}
			string result;
			return result;
			IL_6D:
			return "";
		}

		// Token: 0x04002AB8 RID: 10936
		[CompilerGenerated]
		private ObservableCollection<store_items> <Items>k__BackingField;

		// Token: 0x04002AB9 RID: 10937
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;

		// Token: 0x04002ABA RID: 10938
		[CompilerGenerated]
		private IInvoice <Invoice>k__BackingField;

		// Token: 0x04002ABB RID: 10939
		[CompilerGenerated]
		private ICashOrder <CashOrder>k__BackingField;

		// Token: 0x04002ABC RID: 10940
		[CompilerGenerated]
		private bool <AnonCustomer>k__BackingField;

		// Token: 0x02000887 RID: 2183
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x060041F4 RID: 16884 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x060041F5 RID: 16885 RVA: 0x00103D18 File Offset: 0x00101F18
			internal void <LoadItems>b__0()
			{
				this.<>4__this.AddItem(this.item);
			}

			// Token: 0x04002ABD RID: 10941
			public store_items item;

			// Token: 0x04002ABE RID: 10942
			public SaleDocument <>4__this;
		}

		// Token: 0x02000888 RID: 2184
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__23 : IAsyncStateMachine
		{
			// Token: 0x060041F6 RID: 16886 RVA: 0x00103D38 File Offset: 0x00101F38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SaleDocument saleDocument = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_items>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_82;
						}
						awaiter = DocumentsModel.LoadSoldItems(saleDocument.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, SaleDocument.<LoadItems>d__23>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_items>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<store_items> result = awaiter.GetResult();
					this.<>7__wrap1 = result.GetEnumerator();
					IL_82:
					try
					{
						TaskAwaiter awaiter2;
						if (num == 1)
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_108;
						}
						IL_A8:
						if (!this.<>7__wrap1.MoveNext())
						{
							goto IL_14A;
						}
						SaleDocument.<>c__DisplayClass23_0 CS$<>8__locals1 = new SaleDocument.<>c__DisplayClass23_0();
						CS$<>8__locals1.<>4__this = saleDocument;
						CS$<>8__locals1.item = this.<>7__wrap1.Current;
						awaiter2 = Application.Current.Dispatcher.BeginInvoke(new Action(CS$<>8__locals1.<LoadItems>b__0), new object[0]).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SaleDocument.<LoadItems>d__23>(ref awaiter2, ref this);
							return;
						}
						IL_108:
						awaiter2.GetResult();
						goto IL_A8;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap1).Dispose();
						}
					}
					IL_14A:
					this.<>7__wrap1 = default(List<store_items>.Enumerator);
					saleDocument.CountTotal();
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

			// Token: 0x060041F7 RID: 16887 RVA: 0x00103F04 File Offset: 0x00102104
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002ABF RID: 10943
			public int <>1__state;

			// Token: 0x04002AC0 RID: 10944
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002AC1 RID: 10945
			public SaleDocument <>4__this;

			// Token: 0x04002AC2 RID: 10946
			private TaskAwaiter<List<store_items>> <>u__1;

			// Token: 0x04002AC3 RID: 10947
			private List<store_items>.Enumerator <>7__wrap1;

			// Token: 0x04002AC4 RID: 10948
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000889 RID: 2185
		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x060041F8 RID: 16888 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x060041F9 RID: 16889 RVA: 0x00103F20 File Offset: 0x00102120
			internal bool <AnyItem>b__0(store_items i)
			{
				return i.id == this.itemId;
			}

			// Token: 0x04002AC5 RID: 10949
			public int itemId;
		}

		// Token: 0x0200088A RID: 2186
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetCustomer>d__45 : IAsyncStateMachine
		{
			// Token: 0x060041FA RID: 16890 RVA: 0x00103F3C File Offset: 0x0010213C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SaleDocument saleDocument = this.<>4__this;
				try
				{
					TaskAwaiter<CustomerCard> awaiter;
					if (num != 0)
					{
						saleDocument.DealerId = new int?(this.customerId);
						awaiter = ClientsModel.GetCustomerCard(this.customerId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CustomerCard>, SaleDocument.<SetCustomer>d__45>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CustomerCard>);
						this.<>1__state = -1;
					}
					CustomerCard result = awaiter.GetResult();
					saleDocument.Customer = result;
					CustomerCard customerCard = saleDocument.Customer as CustomerCard;
					if (customerCard != null)
					{
						if (customerCard.PreferCashless)
						{
							saleDocument.PaymentSystem = 1;
						}
						saleDocument.SetPriceOption(customerCard.PriceCol);
					}
					saleDocument.CountTotal();
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

			// Token: 0x060041FB RID: 16891 RVA: 0x00104044 File Offset: 0x00102244
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002AC6 RID: 10950
			public int <>1__state;

			// Token: 0x04002AC7 RID: 10951
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002AC8 RID: 10952
			public SaleDocument <>4__this;

			// Token: 0x04002AC9 RID: 10953
			public int customerId;

			// Token: 0x04002ACA RID: 10954
			private TaskAwaiter<CustomerCard> <>u__1;
		}

		// Token: 0x0200088B RID: 2187
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060041FC RID: 16892 RVA: 0x00104060 File Offset: 0x00102260
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060041FD RID: 16893 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060041FE RID: 16894 RVA: 0x00104078 File Offset: 0x00102278
			internal decimal <CountTotal>b__46_0(store_items i)
			{
				return i.BuyCount * i.BuyCost;
			}

			// Token: 0x04002ACB RID: 10955
			public static readonly SaleDocument.<>c <>9 = new SaleDocument.<>c();

			// Token: 0x04002ACC RID: 10956
			public static Func<store_items, decimal> <>9__46_0;
		}
	}
}
