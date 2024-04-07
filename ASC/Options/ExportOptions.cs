using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Interfaces;
using ASC.Models;

namespace ASC.Options
{
	// Token: 0x02000259 RID: 601
	public class ExportOptions : GenericModel, IOptions<ExportOptions>
	{
		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0005E7B8 File Offset: 0x0005C9B8
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0005E7CC File Offset: 0x0005C9CC
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

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0005E7E0 File Offset: 0x0005C9E0
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
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

		// Token: 0x060020CB RID: 8395 RVA: 0x0005E808 File Offset: 0x0005CA08
		public ExportOptions()
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x0005E81C File Offset: 0x0005CA1C
		public ExportOptions(int id, int group, string name)
		{
			this.Id = id;
			this.Name = name;
			this.GroupId = group;
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0005E844 File Offset: 0x0005CA44
		public List<ExportOptions> GetAllOptions()
		{
			return new List<ExportOptions>
			{
				new ExportOptions(0, 1, Lang.t("No")),
				new ExportOptions(1, 0, Lang.t("IShopTitle")),
				new ExportOptions(2, 0, Lang.t("ItemName")),
				new ExportOptions(20, 2, Lang.t("Сonstructor")),
				new ExportOptions(10, 1, Lang.t("IShopDescriptionNoDots")),
				new ExportOptions(11, 1, Lang.t("ItemName")),
				new ExportOptions(12, 1, Lang.t("Description")),
				new ExportOptions(13, 1, Lang.t("PN")),
				new ExportOptions(14, 1, Lang.t("Notes"))
			};
		}

		// Token: 0x040010C6 RID: 4294
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010C7 RID: 4295
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040010C8 RID: 4296
		public int GroupId;

		// Token: 0x0200025A RID: 602
		public enum Group
		{
			// Token: 0x040010CA RID: 4298
			title,
			// Token: 0x040010CB RID: 4299
			content,
			// Token: 0x040010CC RID: 4300
			special
		}
	}
}
