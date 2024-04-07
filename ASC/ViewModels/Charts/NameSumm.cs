using System;
using System.Runtime.CompilerServices;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200051C RID: 1308
	public class NameSumm
	{
		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000A33C0 File Offset: 0x000A15C0
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x000A33D4 File Offset: 0x000A15D4
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x000A33E8 File Offset: 0x000A15E8
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x000A33FC File Offset: 0x000A15FC
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

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x000A3410 File Offset: 0x000A1610
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x000A3424 File Offset: 0x000A1624
		public decimal Summ
		{
			[CompilerGenerated]
			get
			{
				return this.<Summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Summ>k__BackingField = value;
			}
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x000046B4 File Offset: 0x000028B4
		public NameSumm()
		{
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x000A3438 File Offset: 0x000A1638
		public NameSumm(string name, decimal summ)
		{
			this.Name = name;
			this.Summ = summ;
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000A345C File Offset: 0x000A165C
		public void SetId(int id)
		{
			this.Id = id;
		}

		// Token: 0x04001C10 RID: 7184
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04001C11 RID: 7185
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04001C12 RID: 7186
		[CompilerGenerated]
		private decimal <Summ>k__BackingField;
	}
}
