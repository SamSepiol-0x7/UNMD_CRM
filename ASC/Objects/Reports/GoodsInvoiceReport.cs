using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using Autofac;
using Poly;

namespace ASC.Objects.Reports
{
	// Token: 0x0200093E RID: 2366
	public class GoodsInvoiceReport : StoreDocument, IReport, IGoodsInvoiceReport
	{
		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x0011D440 File Offset: 0x0011B640
		// (set) Token: 0x0600489C RID: 18588 RVA: 0x0011D454 File Offset: 0x0011B654
		public ICompany Company
		{
			[CompilerGenerated]
			get
			{
				return this.<Company>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Company>k__BackingField, value))
				{
					return;
				}
				this.<Company>k__BackingField = value;
				this.RaisePropertyChanged("Company");
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x0011D484 File Offset: 0x0011B684
		// (set) Token: 0x0600489E RID: 18590 RVA: 0x0011D498 File Offset: 0x0011B698
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

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x0011D4C8 File Offset: 0x0011B6C8
		// (set) Token: 0x060048A0 RID: 18592 RVA: 0x0011D4DC File Offset: 0x0011B6DC
		public IOffice Office
		{
			[CompilerGenerated]
			get
			{
				return this.<Office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Office>k__BackingField, value))
				{
					return;
				}
				this.<Office>k__BackingField = value;
				this.RaisePropertyChanged("Office");
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x0011D50C File Offset: 0x0011B70C
		// (set) Token: 0x060048A2 RID: 18594 RVA: 0x0011D520 File Offset: 0x0011B720
		public stores Store
		{
			[CompilerGenerated]
			get
			{
				return this.<Store>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Store>k__BackingField, value))
				{
					return;
				}
				this.<Store>k__BackingField = value;
				this.RaisePropertyChanged("Store");
			}
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x0011D550 File Offset: 0x0011B750
		public GoodsInvoiceReport()
		{
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x0011D564 File Offset: 0x0011B764
		public GoodsInvoiceReport(StoreDocument d)
		{
			d.CopyProperties(this);
			base.SetTotal(d.Total);
			this.LoadCompany();
			this.LoadOffice();
			this.LoadEmployee();
			if (base.DealerId != null)
			{
				this.LoadCustomer();
			}
			if (base.StoreId != null)
			{
				this.LoadStore();
			}
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
		public void LoadCompany()
		{
			this.Company = CompaniesModel.GetCompany(base.CompanyId);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x0011CFF0 File Offset: 0x0011B1F0
		public void LoadEmployee()
		{
			base.Employee = UsersModel.GetEmployeeForReport(base.EmployeeId);
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x0011D5E8 File Offset: 0x0011B7E8
		public void LoadOffice()
		{
			this.Office = CompaniesModel.GetOffice(base.OfficeId);
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x0011D608 File Offset: 0x0011B808
		public void LoadCustomer()
		{
			GoodsInvoiceReport.<LoadCustomer>d__21 <LoadCustomer>d__;
			<LoadCustomer>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCustomer>d__.<>4__this = this;
			<LoadCustomer>d__.<>1__state = -1;
			<LoadCustomer>d__.<>t__builder.Start<GoodsInvoiceReport.<LoadCustomer>d__21>(ref <LoadCustomer>d__);
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x0011D640 File Offset: 0x0011B840
		public void LoadStore()
		{
			GoodsInvoiceReport.<LoadStore>d__22 <LoadStore>d__;
			<LoadStore>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadStore>d__.<>4__this = this;
			<LoadStore>d__.<>1__state = -1;
			<LoadStore>d__.<>t__builder.Start<GoodsInvoiceReport.<LoadStore>d__22>(ref <LoadStore>d__);
		}

		// Token: 0x04002E45 RID: 11845
		[CompilerGenerated]
		private ICompany <Company>k__BackingField;

		// Token: 0x04002E46 RID: 11846
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;

		// Token: 0x04002E47 RID: 11847
		[CompilerGenerated]
		private IOffice <Office>k__BackingField;

		// Token: 0x04002E48 RID: 11848
		[CompilerGenerated]
		private stores <Store>k__BackingField;

		// Token: 0x0200093F RID: 2367
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCustomer>d__21 : IAsyncStateMachine
		{
			// Token: 0x060048AA RID: 18602 RVA: 0x0011D678 File Offset: 0x0011B878
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GoodsInvoiceReport goodsInvoiceReport = this.<>4__this;
				try
				{
					TaskAwaiter<ICustomer> awaiter;
					if (num != 0)
					{
						awaiter = Bootstrapper.Container.Resolve<ICustomerService>().GetCustomerCardAsync(goodsInvoiceReport.DealerId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICustomer>, GoodsInvoiceReport.<LoadCustomer>d__21>(ref awaiter, ref this);
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
					goodsInvoiceReport.Customer = result;
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

			// Token: 0x060048AB RID: 18603 RVA: 0x0011D74C File Offset: 0x0011B94C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E49 RID: 11849
			public int <>1__state;

			// Token: 0x04002E4A RID: 11850
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002E4B RID: 11851
			public GoodsInvoiceReport <>4__this;

			// Token: 0x04002E4C RID: 11852
			private TaskAwaiter<ICustomer> <>u__1;
		}

		// Token: 0x02000940 RID: 2368
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStore>d__22 : IAsyncStateMachine
		{
			// Token: 0x060048AC RID: 18604 RVA: 0x0011D768 File Offset: 0x0011B968
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GoodsInvoiceReport goodsInvoiceReport = this.<>4__this;
				try
				{
					TaskAwaiter<stores> awaiter;
					if (num != 0)
					{
						awaiter = Bootstrapper.Container.Resolve<IStoreService>().GetStoreAsync(goodsInvoiceReport.StoreId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<stores>, GoodsInvoiceReport.<LoadStore>d__22>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<stores>);
						this.<>1__state = -1;
					}
					stores result = awaiter.GetResult();
					goodsInvoiceReport.Store = result;
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

			// Token: 0x060048AD RID: 18605 RVA: 0x0011D83C File Offset: 0x0011BA3C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E4D RID: 11853
			public int <>1__state;

			// Token: 0x04002E4E RID: 11854
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002E4F RID: 11855
			public GoodsInvoiceReport <>4__this;

			// Token: 0x04002E50 RID: 11856
			private TaskAwaiter<stores> <>u__1;
		}
	}
}
