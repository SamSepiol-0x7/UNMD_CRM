using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008F9 RID: 2297
	public class Toner : IToner
	{
		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x00116774 File Offset: 0x00114974
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x00116788 File Offset: 0x00114988
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

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x0011679C File Offset: 0x0011499C
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x001167B0 File Offset: 0x001149B0
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

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x001167C4 File Offset: 0x001149C4
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x001167D8 File Offset: 0x001149D8
		public DateTime Created
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

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x001167EC File Offset: 0x001149EC
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x00116800 File Offset: 0x00114A00
		public int EmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<EmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<EmployeeId>k__BackingField = value;
			}
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x000046B4 File Offset: 0x000028B4
		public Toner()
		{
		}

		// Token: 0x04002DD6 RID: 11734
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002DD7 RID: 11735
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002DD8 RID: 11736
		[CompilerGenerated]
		private DateTime <Created>k__BackingField;

		// Token: 0x04002DD9 RID: 11737
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;
	}
}
