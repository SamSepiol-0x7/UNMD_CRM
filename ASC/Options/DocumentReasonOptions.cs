using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Options
{
	// Token: 0x02000258 RID: 600
	public class DocumentReasonOptions : IOptions<DocumentReasonOptions>
	{
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0005E6F0 File Offset: 0x0005C8F0
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0005E704 File Offset: 0x0005C904
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

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0005E718 File Offset: 0x0005C918
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x0005E72C File Offset: 0x0005C92C
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

		// Token: 0x060020C4 RID: 8388 RVA: 0x0005E740 File Offset: 0x0005C940
		public DocumentReasonOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000046B4 File Offset: 0x000028B4
		public DocumentReasonOptions()
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x0005E764 File Offset: 0x0005C964
		public List<DocumentReasonOptions> GetAllOptions()
		{
			return new List<DocumentReasonOptions>
			{
				new DocumentReasonOptions(0, Lang.t("RKO")),
				new DocumentReasonOptions(1, Lang.t("Realization")),
				new DocumentReasonOptions(1, Lang.t("ManualReason"))
			};
		}

		// Token: 0x040010C4 RID: 4292
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010C5 RID: 4293
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
