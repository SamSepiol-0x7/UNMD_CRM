using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.Models
{
	// Token: 0x02000945 RID: 2373
	public class PreviousRepair
	{
		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x0011DF18 File Offset: 0x0011C118
		// (set) Token: 0x060048D4 RID: 18644 RVA: 0x0011DF2C File Offset: 0x0011C12C
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

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x0011DF40 File Offset: 0x0011C140
		// (set) Token: 0x060048D6 RID: 18646 RVA: 0x0011DF54 File Offset: 0x0011C154
		public int TypeId
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TypeId>k__BackingField = value;
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x0011DF68 File Offset: 0x0011C168
		// (set) Token: 0x060048D8 RID: 18648 RVA: 0x0011DF7C File Offset: 0x0011C17C
		public int MakerId
		{
			[CompilerGenerated]
			get
			{
				return this.<MakerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MakerId>k__BackingField = value;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x0011DF90 File Offset: 0x0011C190
		// (set) Token: 0x060048DA RID: 18650 RVA: 0x0011DFA4 File Offset: 0x0011C1A4
		public int? ModelId
		{
			[CompilerGenerated]
			get
			{
				return this.<ModelId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ModelId>k__BackingField = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x0011DFB8 File Offset: 0x0011C1B8
		// (set) Token: 0x060048DC RID: 18652 RVA: 0x0011DFCC File Offset: 0x0011C1CC
		public string ModelName
		{
			[CompilerGenerated]
			get
			{
				return this.<ModelName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ModelName>k__BackingField = value;
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x0011DFE0 File Offset: 0x0011C1E0
		// (set) Token: 0x060048DE RID: 18654 RVA: 0x0011DFF4 File Offset: 0x0011C1F4
		public int CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomerId>k__BackingField = value;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x0011E008 File Offset: 0x0011C208
		// (set) Token: 0x060048E0 RID: 18656 RVA: 0x0011E01C File Offset: 0x0011C21C
		public string SerialNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<SerialNumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x0011E030 File Offset: 0x0011C230
		// (set) Token: 0x060048E2 RID: 18658 RVA: 0x0011E044 File Offset: 0x0011C244
		public ICollection<field_values> AdditionalFields
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AdditionalFields>k__BackingField = value;
			}
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x000046B4 File Offset: 0x000028B4
		public PreviousRepair()
		{
		}

		// Token: 0x04002E5D RID: 11869
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002E5E RID: 11870
		[CompilerGenerated]
		private int <TypeId>k__BackingField;

		// Token: 0x04002E5F RID: 11871
		[CompilerGenerated]
		private int <MakerId>k__BackingField;

		// Token: 0x04002E60 RID: 11872
		[CompilerGenerated]
		private int? <ModelId>k__BackingField;

		// Token: 0x04002E61 RID: 11873
		[CompilerGenerated]
		private string <ModelName>k__BackingField;

		// Token: 0x04002E62 RID: 11874
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x04002E63 RID: 11875
		[CompilerGenerated]
		private string <SerialNumber>k__BackingField;

		// Token: 0x04002E64 RID: 11876
		[CompilerGenerated]
		private ICollection<field_values> <AdditionalFields>k__BackingField;
	}
}
