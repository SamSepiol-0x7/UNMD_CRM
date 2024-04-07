using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000882 RID: 2178
	public class Office : IIdName, IOffice
	{
		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x00102CB8 File Offset: 0x00100EB8
		// (set) Token: 0x06004187 RID: 16775 RVA: 0x00102CCC File Offset: 0x00100ECC
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x00102CE0 File Offset: 0x00100EE0
		// (set) Token: 0x06004189 RID: 16777 RVA: 0x00102CF4 File Offset: 0x00100EF4
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x00102D08 File Offset: 0x00100F08
		// (set) Token: 0x0600418B RID: 16779 RVA: 0x00102D1C File Offset: 0x00100F1C
		public string Address
		{
			[CompilerGenerated]
			get
			{
				return this.<Address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Address>k__BackingField = value;
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x00102D30 File Offset: 0x00100F30
		// (set) Token: 0x0600418D RID: 16781 RVA: 0x00102D44 File Offset: 0x00100F44
		public string Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Tel>k__BackingField = value;
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x00102D58 File Offset: 0x00100F58
		// (set) Token: 0x0600418F RID: 16783 RVA: 0x00102D6C File Offset: 0x00100F6C
		public string Tel2
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Tel2>k__BackingField = value;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06004190 RID: 16784 RVA: 0x00102D80 File Offset: 0x00100F80
		// (set) Token: 0x06004191 RID: 16785 RVA: 0x00102D94 File Offset: 0x00100F94
		public DateTime? Created
		{
			[CompilerGenerated]
			get
			{
				return this.<Created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Created>k__BackingField = value;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x00102DA8 File Offset: 0x00100FA8
		// (set) Token: 0x06004193 RID: 16787 RVA: 0x00102DBC File Offset: 0x00100FBC
		public bool Archive
		{
			[CompilerGenerated]
			get
			{
				return this.<Archive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Archive>k__BackingField = value;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x00102DD0 File Offset: 0x00100FD0
		// (set) Token: 0x06004195 RID: 16789 RVA: 0x00102DE4 File Offset: 0x00100FE4
		public int DefaultCompanyId
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultCompanyId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DefaultCompanyId>k__BackingField = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x00102DF8 File Offset: 0x00100FF8
		// (set) Token: 0x06004197 RID: 16791 RVA: 0x00102E0C File Offset: 0x0010100C
		public byte[] Logo
		{
			[CompilerGenerated]
			get
			{
				return this.<Logo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Logo>k__BackingField = value;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06004198 RID: 16792 RVA: 0x00102E20 File Offset: 0x00101020
		// (set) Token: 0x06004199 RID: 16793 RVA: 0x00102E34 File Offset: 0x00101034
		public int AdministratorId
		{
			[CompilerGenerated]
			get
			{
				return this.<AdministratorId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AdministratorId>k__BackingField = value;
			}
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x000046B4 File Offset: 0x000028B4
		public Office()
		{
		}

		// Token: 0x04002A97 RID: 10903
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A98 RID: 10904
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002A99 RID: 10905
		[CompilerGenerated]
		private string <Address>k__BackingField;

		// Token: 0x04002A9A RID: 10906
		[CompilerGenerated]
		private string <Tel>k__BackingField;

		// Token: 0x04002A9B RID: 10907
		[CompilerGenerated]
		private string <Tel2>k__BackingField;

		// Token: 0x04002A9C RID: 10908
		[CompilerGenerated]
		private DateTime? <Created>k__BackingField;

		// Token: 0x04002A9D RID: 10909
		[CompilerGenerated]
		private bool <Archive>k__BackingField;

		// Token: 0x04002A9E RID: 10910
		[CompilerGenerated]
		private int <DefaultCompanyId>k__BackingField;

		// Token: 0x04002A9F RID: 10911
		[CompilerGenerated]
		private byte[] <Logo>k__BackingField;

		// Token: 0x04002AA0 RID: 10912
		[CompilerGenerated]
		private int <AdministratorId>k__BackingField;
	}
}
