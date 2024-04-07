using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Options
{
	// Token: 0x0200024E RID: 590
	public class InvoiceOptions : IIdName
	{
		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0005D590 File Offset: 0x0005B790
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x0005D5A4 File Offset: 0x0005B7A4
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0005D5B8 File Offset: 0x0005B7B8
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x0005D5CC File Offset: 0x0005B7CC
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

		// Token: 0x06002079 RID: 8313 RVA: 0x000046B4 File Offset: 0x000028B4
		public InvoiceOptions()
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0005D5E0 File Offset: 0x0005B7E0
		public InvoiceOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x0005D604 File Offset: 0x0005B804
		[Obsolete]
		public static List<InvoiceOptions> GetStates(bool includeAll = false)
		{
			List<InvoiceOptions> list = new List<InvoiceOptions>
			{
				new InvoiceOptions(1, Lang.t("InvoiceIssued")),
				new InvoiceOptions(2, Lang.t("InvoicePaid")),
				new InvoiceOptions(3, Lang.t("Arhive"))
			};
			if (includeAll)
			{
				list.Insert(0, new InvoiceOptions(0, Lang.t("All")));
			}
			return list;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0005D674 File Offset: 0x0005B874
		public static string StateNameById(int stateId)
		{
			InvoiceOptions invoiceOptions = InvoiceOptions.GetStates(false).FirstOrDefault((InvoiceOptions s) => s.Id == stateId);
			if (invoiceOptions == null)
			{
				return "";
			}
			return invoiceOptions.Name;
		}

		// Token: 0x040010A0 RID: 4256
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010A1 RID: 4257
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x0200024F RID: 591
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600207D RID: 8317 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0600207E RID: 8318 RVA: 0x0005D6B8 File Offset: 0x0005B8B8
			internal bool <StateNameById>b__0(InvoiceOptions s)
			{
				return s.Id == this.stateId;
			}

			// Token: 0x040010A2 RID: 4258
			public int stateId;
		}
	}
}
