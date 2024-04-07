using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Options;

namespace ASC.ItemsExport.Core
{
	// Token: 0x0200031B RID: 795
	public class ExportBase
	{
		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x0007296C File Offset: 0x00070B6C
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x00072980 File Offset: 0x00070B80
		public List<store_cats> Categories
		{
			[CompilerGenerated]
			get
			{
				return this.<Categories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Categories>k__BackingField = value;
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00072994 File Offset: 0x00070B94
		public ExportBase()
		{
			this.Categories = new List<store_cats>();
			this.warranty = new WarrantyOptions();
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000729C0 File Offset: 0x00070BC0
		public List<store_cats> GetCatsTree(store_cats cat, List<store_cats> result = null)
		{
			if (result == null)
			{
				result = new List<store_cats>();
			}
			result.Add(cat);
			if (cat.parent != null)
			{
				foreach (store_cats store_cats in this.Categories)
				{
					int id = store_cats.id;
					int? parent = cat.parent;
					if (id == parent.GetValueOrDefault() & parent != null)
					{
						this.GetCatsTree(store_cats, result);
					}
				}
			}
			return result;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00072A58 File Offset: 0x00070C58
		protected static string CleanFileName(string fileName)
		{
			return Path.GetInvalidFileNameChars().Aggregate(fileName, (string current, char c) => current.Replace(c.ToString(), string.Empty)).Replace(",", "");
		}

		// Token: 0x040013E3 RID: 5091
		protected WarrantyOptions warranty;

		// Token: 0x040013E4 RID: 5092
		[CompilerGenerated]
		private List<store_cats> <Categories>k__BackingField;

		// Token: 0x0200031C RID: 796
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600257C RID: 9596 RVA: 0x00072AA0 File Offset: 0x00070CA0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600257D RID: 9597 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600257E RID: 9598 RVA: 0x00072AB8 File Offset: 0x00070CB8
			internal string <CleanFileName>b__7_0(string current, char c)
			{
				return current.Replace(c.ToString(), string.Empty);
			}

			// Token: 0x040013E5 RID: 5093
			public static readonly ExportBase.<>c <>9 = new ExportBase.<>c();

			// Token: 0x040013E6 RID: 5094
			public static Func<string, char, string> <>9__7_0;
		}
	}
}
