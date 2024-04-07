using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Options
{
	// Token: 0x0200025E RID: 606
	public class DocumentOptions : IOptions<DocumentOptions>
	{
		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0005EAD4 File Offset: 0x0005CCD4
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0005EAE8 File Offset: 0x0005CCE8
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0005EAFC File Offset: 0x0005CCFC
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0005EB10 File Offset: 0x0005CD10
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

		// Token: 0x060020E0 RID: 8416 RVA: 0x0005EB24 File Offset: 0x0005CD24
		public DocumentOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000046B4 File Offset: 0x000028B4
		public DocumentOptions()
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0005EB48 File Offset: 0x0005CD48
		public List<DocumentOptions> GetAllOptions()
		{
			return new List<DocumentOptions>
			{
				new DocumentOptions(0, Lang.t("AllDocuments")),
				new DocumentOptions(1, Lang.t("Pn")),
				new DocumentOptions(2, Lang.t("Rn")),
				new DocumentOptions(3, Lang.t("CancellationN")),
				new DocumentOptions(4, Lang.t("MoveN")),
				new DocumentOptions(5, Lang.t("Invoice")),
				new DocumentOptions(6, Lang.t("Reserve")),
				new DocumentOptions(8, Lang.t("RedemptionOfEquipment"))
			};
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x0005EC0C File Offset: 0x0005CE0C
		public string GetOptionById(int optionId)
		{
			DocumentOptions documentOptions = this.GetAllOptions().FirstOrDefault((DocumentOptions o) => o.Id == optionId);
			if (documentOptions == null)
			{
				return string.Empty;
			}
			return documentOptions.Name;
		}

		// Token: 0x040010D5 RID: 4309
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010D6 RID: 4310
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x0200025F RID: 607
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060020E4 RID: 8420 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x060020E5 RID: 8421 RVA: 0x0005EC50 File Offset: 0x0005CE50
			internal bool <GetOptionById>b__0(DocumentOptions o)
			{
				return o.Id == this.optionId;
			}

			// Token: 0x040010D7 RID: 4311
			public int optionId;
		}
	}
}
