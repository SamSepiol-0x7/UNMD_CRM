using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Models;
using DevExpress.DataAccess.ObjectBinding;
using Poly;

namespace ASC.Objects.Reports
{
	// Token: 0x02000943 RID: 2371
	[HighlightedClass]
	public class RepairReport : RepairCard, IReport, IRepairReport
	{
		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x060048C1 RID: 18625 RVA: 0x0011DBBC File Offset: 0x0011BDBC
		// (set) Token: 0x060048C2 RID: 18626 RVA: 0x0011DBD0 File Offset: 0x0011BDD0
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

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x0011DC00 File Offset: 0x0011BE00
		// (set) Token: 0x060048C4 RID: 18628 RVA: 0x0011DC14 File Offset: 0x0011BE14
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

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x0011DC44 File Offset: 0x0011BE44
		// (set) Token: 0x060048C6 RID: 18630 RVA: 0x0011DC58 File Offset: 0x0011BE58
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

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x0011DC88 File Offset: 0x0011BE88
		// (set) Token: 0x060048C8 RID: 18632 RVA: 0x0011DC9C File Offset: 0x0011BE9C
		public IAscConfig Config
		{
			[CompilerGenerated]
			get
			{
				return this.<Config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Config>k__BackingField, value))
				{
					return;
				}
				this.<Config>k__BackingField = value;
				this.RaisePropertyChanged("Config");
			}
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x001158A4 File Offset: 0x00113AA4
		public RepairReport()
		{
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0011DCCC File Offset: 0x0011BECC
		public RepairReport(RepairCard c)
		{
			c.CopyProperties(this);
			this.RemoveUnprintableUserFields();
			this.LoadCompany();
			this.LoadOffice();
			this.LoadEmployee();
			if (Auth.Config.parts_included && base.WorksAndParts != null)
			{
				foreach (IWorkPartObject item in (from w in base.WorksAndParts
				where w.Type == 2
				select w).ToList<IWorkPartObject>())
				{
					base.WorksAndParts.Remove(item);
				}
			}
			this.Config = new AscConfig
			{
				CurrencyString = Auth.Config.CurrencyString
			};
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x0011DDA4 File Offset: 0x0011BFA4
		private void RemoveUnprintableUserFields()
		{
			try
			{
				using (List<IAttribute>.Enumerator enumerator = (from f in base.UserFields
				where !f.Printable
				select f).ToList<IAttribute>().GetEnumerator())
				{
					for (;;)
					{
						IL_91:
						int num = enumerator.MoveNext() ? 1957148600 : 1860505103;
						for (;;)
						{
							switch ((num ^ 1333263685) % 4)
							{
							case 0:
								num = 1957148600;
								continue;
							case 1:
							{
								IAttribute item = enumerator.Current;
								base.UserFields.Remove(item);
								num = 1589176514;
								continue;
							}
							case 3:
								goto IL_91;
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x0011DE80 File Offset: 0x0011C080
		public void LoadOffice()
		{
			this.Office = CompaniesModel.GetOffice(base.OfficeId);
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x0011DEA0 File Offset: 0x0011C0A0
		public void LoadCompany()
		{
			this.Company = CompaniesModel.GetCompany(base.CompanyId);
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x0011DEC0 File Offset: 0x0011C0C0
		public void LoadEmployee()
		{
			this.Employee = UsersModel.GetEmployeeForReport(OfflineData.Instance.Employee.Id);
		}

		// Token: 0x04002E56 RID: 11862
		[CompilerGenerated]
		private ICompany <Company>k__BackingField;

		// Token: 0x04002E57 RID: 11863
		[CompilerGenerated]
		private IOffice <Office>k__BackingField;

		// Token: 0x04002E58 RID: 11864
		[CompilerGenerated]
		private IEmployee <Employee>k__BackingField;

		// Token: 0x04002E59 RID: 11865
		[CompilerGenerated]
		private IAscConfig <Config>k__BackingField;

		// Token: 0x02000944 RID: 2372
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060048CF RID: 18639 RVA: 0x0011DEE8 File Offset: 0x0011C0E8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060048D0 RID: 18640 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060048D1 RID: 18641 RVA: 0x001158E4 File Offset: 0x00113AE4
			internal bool <.ctor>b__17_0(IWorkPartObject w)
			{
				return w.Type == 2;
			}

			// Token: 0x060048D2 RID: 18642 RVA: 0x0011DF00 File Offset: 0x0011C100
			internal bool <RemoveUnprintableUserFields>b__18_0(IAttribute f)
			{
				return !f.Printable;
			}

			// Token: 0x04002E5A RID: 11866
			public static readonly RepairReport.<>c <>9 = new RepairReport.<>c();

			// Token: 0x04002E5B RID: 11867
			public static Func<IWorkPartObject, bool> <>9__17_0;

			// Token: 0x04002E5C RID: 11868
			public static Func<IAttribute, bool> <>9__18_0;
		}
	}
}
