using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Models;
using DevExpress.DataAccess.ObjectBinding;
using Poly;

namespace ASC.Objects.Reports
{
	// Token: 0x0200093D RID: 2365
	[HighlightedClass]
	public class CashOrderReport : CashInOrder, IReport
	{
		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x0600488F RID: 18575 RVA: 0x0011D2D4 File Offset: 0x0011B4D4
		// (set) Token: 0x06004890 RID: 18576 RVA: 0x0011D2E8 File Offset: 0x0011B4E8
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

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x0011D318 File Offset: 0x0011B518
		// (set) Token: 0x06004892 RID: 18578 RVA: 0x0011D32C File Offset: 0x0011B52C
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

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x0011D35C File Offset: 0x0011B55C
		// (set) Token: 0x06004894 RID: 18580 RVA: 0x0011D370 File Offset: 0x0011B570
		public IEmployee Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Employee>k__BackingField, value))
				{
					return;
				}
				this.<Employee>k__BackingField = value;
				this.RaisePropertyChanged("Employee");
			}
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x0011D3A0 File Offset: 0x0011B5A0
		public CashOrderReport()
		{
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x0011D3B4 File Offset: 0x0011B5B4
		public CashOrderReport(CashInOrder order)
		{
			order.CopyProperties(this);
			this.LoadCompany();
			this.LoadOffice();
			this.LoadEmployee();
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x0011D3B4 File Offset: 0x0011B5B4
		public CashOrderReport(CashOutOrder order)
		{
			order.CopyProperties(this);
			this.LoadCompany();
			this.LoadOffice();
			this.LoadEmployee();
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x0011D3E0 File Offset: 0x0011B5E0
		public void LoadCompany()
		{
			this.Company = CompaniesModel.GetCompany(base.CompanyId);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x0011D400 File Offset: 0x0011B600
		public void LoadOffice()
		{
			this.Office = CompaniesModel.GetOffice(base.OfficeId);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x0011D420 File Offset: 0x0011B620
		public void LoadEmployee()
		{
			this.Employee = UsersModel.GetEmployeeForReport(base.EmployeeId);
		}

		// Token: 0x04002E42 RID: 11842
		[CompilerGenerated]
		private ICompany <Company>k__BackingField;

		// Token: 0x04002E43 RID: 11843
		[CompilerGenerated]
		private IOffice <Office>k__BackingField;

		// Token: 0x04002E44 RID: 11844
		[CompilerGenerated]
		private IEmployee <Employee>k__BackingField;
	}
}
