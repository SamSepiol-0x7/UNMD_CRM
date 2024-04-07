using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects.Converters;
using Autofac;
using Poly;

namespace ASC.Objects.Reports
{
	// Token: 0x0200093A RID: 2362
	public class GoodsMoveReport : StoreDocument
	{
		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x0011CC48 File Offset: 0x0011AE48
		// (set) Token: 0x06004874 RID: 18548 RVA: 0x0011CC5C File Offset: 0x0011AE5C
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

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x0011CC8C File Offset: 0x0011AE8C
		// (set) Token: 0x06004876 RID: 18550 RVA: 0x0011CCA0 File Offset: 0x0011AEA0
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

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06004877 RID: 18551 RVA: 0x0011CCD0 File Offset: 0x0011AED0
		// (set) Token: 0x06004878 RID: 18552 RVA: 0x0011CCE4 File Offset: 0x0011AEE4
		public IOffice DestinationOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<DestinationOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<DestinationOffice>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -877040626;
				IL_13:
				switch ((num ^ -298012293) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<DestinationOffice>k__BackingField = value;
					num = -1037331993;
					goto IL_13;
				}
				this.RaisePropertyChanged("DestinationOffice");
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x0011CD40 File Offset: 0x0011AF40
		// (set) Token: 0x0600487A RID: 18554 RVA: 0x0011CD54 File Offset: 0x0011AF54
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

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x0011CD84 File Offset: 0x0011AF84
		// (set) Token: 0x0600487C RID: 18556 RVA: 0x0011CD98 File Offset: 0x0011AF98
		public stores DestinationStore
		{
			[CompilerGenerated]
			get
			{
				return this.<DestinationStore>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DestinationStore>k__BackingField, value))
				{
					return;
				}
				this.<DestinationStore>k__BackingField = value;
				this.RaisePropertyChanged("DestinationStore");
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x0011CDC8 File Offset: 0x0011AFC8
		// (set) Token: 0x0600487E RID: 18558 RVA: 0x0011CDDC File Offset: 0x0011AFDC
		public int? ToStoreId
		{
			[CompilerGenerated]
			get
			{
				return this.<ToStoreId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<ToStoreId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -53620794;
				IL_13:
				switch ((num ^ -96356843) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					num = -1995118012;
					goto IL_13;
				case 3:
					return;
				}
				this.<ToStoreId>k__BackingField = value;
				this.RaisePropertyChanged("ToStoreId");
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x0011CE38 File Offset: 0x0011B038
		// (set) Token: 0x06004880 RID: 18560 RVA: 0x0011CE4C File Offset: 0x0011B04C
		public bool DestinationPay
		{
			[CompilerGenerated]
			get
			{
				return this.<DestinationPay>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DestinationPay>k__BackingField == value)
				{
					return;
				}
				this.<DestinationPay>k__BackingField = value;
				this.RaisePropertyChanged("DestinationPay");
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x0011CE78 File Offset: 0x0011B078
		// (set) Token: 0x06004882 RID: 18562 RVA: 0x0011CE8C File Offset: 0x0011B08C
		public string DeliveryManager
		{
			[CompilerGenerated]
			get
			{
				return this.<DeliveryManager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DeliveryManager>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DeliveryManager>k__BackingField = value;
				this.RaisePropertyChanged("DeliveryManager");
			}
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x0011CEBC File Offset: 0x0011B0BC
		public GoodsMoveReport()
		{
			this._storeService = Bootstrapper.Container.Resolve<IStoreService>();
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x0011CEE0 File Offset: 0x0011B0E0
		public GoodsMoveReport(IStoreDocument d) : this()
		{
			d.CopyProperties(this);
			base.SetTotal(d.Total);
			this.LoadCompany();
			this.LoadOffice();
			this.LoadEmployee();
			GoodsMoveDocument goodsMoveDocument = d as GoodsMoveDocument;
			if (goodsMoveDocument != null)
			{
				base.Goods.Clear();
				foreach (store_items store_items in goodsMoveDocument.Items)
				{
					store_items.price2 = store_items.BuyCost;
					store_items.in_count = store_items.BuyCount;
					base.AddItem(store_items.ToSaleItem());
				}
			}
			int? num = base.StoreId;
			if (num.GetValueOrDefault() > 0 & num != null)
			{
				this.LoadFromStore();
			}
			num = this.ToStoreId;
			if (num.GetValueOrDefault() > 0 & num != null)
			{
				this.LoadToStore();
			}
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x0011CFD0 File Offset: 0x0011B1D0
		public void LoadCompany()
		{
			this.Company = CompaniesModel.GetCompany(base.CompanyId);
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x0011CFF0 File Offset: 0x0011B1F0
		public void LoadEmployee()
		{
			base.Employee = UsersModel.GetEmployeeForReport(base.EmployeeId);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x0011D010 File Offset: 0x0011B210
		public void LoadOffice()
		{
			this.Office = CompaniesModel.GetOffice(base.OfficeId);
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x0011D030 File Offset: 0x0011B230
		private void LoadFromStore()
		{
			GoodsMoveReport.<LoadFromStore>d__38 <LoadFromStore>d__;
			<LoadFromStore>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadFromStore>d__.<>4__this = this;
			<LoadFromStore>d__.<>1__state = -1;
			<LoadFromStore>d__.<>t__builder.Start<GoodsMoveReport.<LoadFromStore>d__38>(ref <LoadFromStore>d__);
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x0011D068 File Offset: 0x0011B268
		public void LoadToStore()
		{
			GoodsMoveReport.<LoadToStore>d__39 <LoadToStore>d__;
			<LoadToStore>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadToStore>d__.<>4__this = this;
			<LoadToStore>d__.<>1__state = -1;
			<LoadToStore>d__.<>t__builder.Start<GoodsMoveReport.<LoadToStore>d__39>(ref <LoadToStore>d__);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x0011D0A0 File Offset: 0x0011B2A0
		private void LoadToOffice(int officeId)
		{
			this.DestinationOffice = CompaniesModel.GetOffice(officeId);
		}

		// Token: 0x04002E31 RID: 11825
		private IStoreService _storeService;

		// Token: 0x04002E32 RID: 11826
		[CompilerGenerated]
		private ICompany <Company>k__BackingField;

		// Token: 0x04002E33 RID: 11827
		[CompilerGenerated]
		private IOffice <Office>k__BackingField;

		// Token: 0x04002E34 RID: 11828
		[CompilerGenerated]
		private IOffice <DestinationOffice>k__BackingField;

		// Token: 0x04002E35 RID: 11829
		[CompilerGenerated]
		private stores <Store>k__BackingField;

		// Token: 0x04002E36 RID: 11830
		[CompilerGenerated]
		private stores <DestinationStore>k__BackingField;

		// Token: 0x04002E37 RID: 11831
		[CompilerGenerated]
		private int? <ToStoreId>k__BackingField;

		// Token: 0x04002E38 RID: 11832
		[CompilerGenerated]
		private bool <DestinationPay>k__BackingField;

		// Token: 0x04002E39 RID: 11833
		[CompilerGenerated]
		private string <DeliveryManager>k__BackingField;

		// Token: 0x0200093B RID: 2363
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadFromStore>d__38 : IAsyncStateMachine
		{
			// Token: 0x0600488B RID: 18571 RVA: 0x0011D0BC File Offset: 0x0011B2BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GoodsMoveReport goodsMoveReport = this.<>4__this;
				try
				{
					TaskAwaiter<stores> awaiter;
					if (num != 0)
					{
						awaiter = goodsMoveReport._storeService.GetStoreAsync(goodsMoveReport.StoreId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<stores>, GoodsMoveReport.<LoadFromStore>d__38>(ref awaiter, ref this);
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
					goodsMoveReport.Store = result;
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

			// Token: 0x0600488C RID: 18572 RVA: 0x0011D18C File Offset: 0x0011B38C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E3A RID: 11834
			public int <>1__state;

			// Token: 0x04002E3B RID: 11835
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002E3C RID: 11836
			public GoodsMoveReport <>4__this;

			// Token: 0x04002E3D RID: 11837
			private TaskAwaiter<stores> <>u__1;
		}

		// Token: 0x0200093C RID: 2364
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadToStore>d__39 : IAsyncStateMachine
		{
			// Token: 0x0600488D RID: 18573 RVA: 0x0011D1A8 File Offset: 0x0011B3A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				GoodsMoveReport goodsMoveReport = this.<>4__this;
				try
				{
					TaskAwaiter<stores> awaiter;
					if (num != 0)
					{
						awaiter = goodsMoveReport._storeService.GetStoreAsync(goodsMoveReport.ToStoreId.Value).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<stores>, GoodsMoveReport.<LoadToStore>d__39>(ref awaiter, ref this);
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
					goodsMoveReport.DestinationStore = result;
					int? office = goodsMoveReport.DestinationStore.office;
					if (office.GetValueOrDefault() > 0 & office != null)
					{
						goodsMoveReport.LoadToOffice(goodsMoveReport.DestinationStore.office.Value);
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

			// Token: 0x0600488E RID: 18574 RVA: 0x0011D2B8 File Offset: 0x0011B4B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E3E RID: 11838
			public int <>1__state;

			// Token: 0x04002E3F RID: 11839
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002E40 RID: 11840
			public GoodsMoveReport <>4__this;

			// Token: 0x04002E41 RID: 11841
			private TaskAwaiter<stores> <>u__1;
		}
	}
}
