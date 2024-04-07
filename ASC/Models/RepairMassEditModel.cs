using System;
using System.Runtime.CompilerServices;

namespace ASC.Models
{
	// Token: 0x02000947 RID: 2375
	public class RepairMassEditModel
	{
		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x0011E0D0 File Offset: 0x0011C2D0
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x0011E0E4 File Offset: 0x0011C2E4
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

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x0011E0F8 File Offset: 0x0011C2F8
		// (set) Token: 0x060048EE RID: 18670 RVA: 0x0011E10C File Offset: 0x0011C30C
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Title>k__BackingField = value;
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x0011E120 File Offset: 0x0011C320
		// (set) Token: 0x060048F0 RID: 18672 RVA: 0x0011E134 File Offset: 0x0011C334
		public int? BoxId
		{
			[CompilerGenerated]
			get
			{
				return this.<BoxId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BoxId>k__BackingField = value;
			}
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x000046B4 File Offset: 0x000028B4
		public RepairMassEditModel()
		{
		}

		// Token: 0x04002E68 RID: 11880
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002E69 RID: 11881
		[CompilerGenerated]
		private string <Title>k__BackingField;

		// Token: 0x04002E6A RID: 11882
		[CompilerGenerated]
		private int? <BoxId>k__BackingField;
	}
}
