using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.Interfaces;

namespace ASC.Options
{
	// Token: 0x02000260 RID: 608
	public class ImportOptions : IOptions<ImportOptions>
	{
		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0005EC6C File Offset: 0x0005CE6C
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0005EC80 File Offset: 0x0005CE80
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

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x0005EC94 File Offset: 0x0005CE94
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0005ECA8 File Offset: 0x0005CEA8
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

		// Token: 0x060020EA RID: 8426 RVA: 0x0005ECBC File Offset: 0x0005CEBC
		public ImportOptions()
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0005ECD8 File Offset: 0x0005CED8
		public ImportOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0005ED04 File Offset: 0x0005CF04
		public List<ImportOptions> GetAllOptions()
		{
			List<ImportOptions> list = new List<ImportOptions>
			{
				new ImportOptions(this.magicNumber, (string)Application.Current.TryFindResource("No"))
			};
			string[] array = new string[]
			{
				"A",
				"B",
				"C",
				"D",
				"E",
				"F",
				"G",
				"H",
				"I",
				"J",
				"K",
				"L",
				"M",
				"N",
				"O"
			};
			int num = 0;
			foreach (string str in array)
			{
				list.Add(new ImportOptions(num, (string)Application.Current.TryFindResource("Column") + " " + str));
				num++;
			}
			return list;
		}

		// Token: 0x040010D8 RID: 4312
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010D9 RID: 4313
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040010DA RID: 4314
		private int magicNumber = 99;
	}
}
