using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x0200089B RID: 2203
	public class Company : IIdName, ICompany
	{
		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x00106DB4 File Offset: 0x00104FB4
		// (set) Token: 0x06004332 RID: 17202 RVA: 0x00106DC8 File Offset: 0x00104FC8
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x00106DDC File Offset: 0x00104FDC
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x00106DF0 File Offset: 0x00104FF0
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x00106E04 File Offset: 0x00105004
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x00106E18 File Offset: 0x00105018
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.<Description>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Description>k__BackingField = value;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x00106E2C File Offset: 0x0010502C
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x00106E40 File Offset: 0x00105040
		public string Site
		{
			[CompilerGenerated]
			get
			{
				return this.<Site>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Site>k__BackingField = value;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x00106E54 File Offset: 0x00105054
		// (set) Token: 0x0600433A RID: 17210 RVA: 0x00106E68 File Offset: 0x00105068
		public string Email
		{
			[CompilerGenerated]
			get
			{
				return this.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Email>k__BackingField = value;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x00106E7C File Offset: 0x0010507C
		// (set) Token: 0x0600433C RID: 17212 RVA: 0x00106E90 File Offset: 0x00105090
		public bool IsArchive
		{
			[CompilerGenerated]
			get
			{
				return this.<IsArchive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsArchive>k__BackingField = value;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x00106EA4 File Offset: 0x001050A4
		// (set) Token: 0x0600433E RID: 17214 RVA: 0x00106EB8 File Offset: 0x001050B8
		public IEmployee Accountant
		{
			[CompilerGenerated]
			get
			{
				return this.<Accountant>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Accountant>k__BackingField = value;
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x00106ECC File Offset: 0x001050CC
		// (set) Token: 0x06004340 RID: 17216 RVA: 0x00106EE0 File Offset: 0x001050E0
		public string Inn
		{
			[CompilerGenerated]
			get
			{
				return this.<Inn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Inn>k__BackingField = value;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06004341 RID: 17217 RVA: 0x00106EF4 File Offset: 0x001050F4
		// (set) Token: 0x06004342 RID: 17218 RVA: 0x00106F08 File Offset: 0x00105108
		public string Kpp
		{
			[CompilerGenerated]
			get
			{
				return this.<Kpp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Kpp>k__BackingField = value;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x00106F1C File Offset: 0x0010511C
		// (set) Token: 0x06004344 RID: 17220 RVA: 0x00106F30 File Offset: 0x00105130
		public string Ogrn
		{
			[CompilerGenerated]
			get
			{
				return this.<Ogrn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ogrn>k__BackingField = value;
			}
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x000046B4 File Offset: 0x000028B4
		public Company()
		{
		}

		// Token: 0x04002B55 RID: 11093
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002B56 RID: 11094
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002B57 RID: 11095
		[CompilerGenerated]
		private string <Description>k__BackingField;

		// Token: 0x04002B58 RID: 11096
		[CompilerGenerated]
		private string <Site>k__BackingField;

		// Token: 0x04002B59 RID: 11097
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x04002B5A RID: 11098
		[CompilerGenerated]
		private bool <IsArchive>k__BackingField;

		// Token: 0x04002B5B RID: 11099
		[CompilerGenerated]
		private IEmployee <Accountant>k__BackingField;

		// Token: 0x04002B5C RID: 11100
		[CompilerGenerated]
		private string <Inn>k__BackingField;

		// Token: 0x04002B5D RID: 11101
		[CompilerGenerated]
		private string <Kpp>k__BackingField;

		// Token: 0x04002B5E RID: 11102
		[CompilerGenerated]
		private string <Ogrn>k__BackingField;
	}
}
