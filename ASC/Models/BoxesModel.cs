using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Extensions;

namespace ASC.Models
{
	// Token: 0x0200096B RID: 2411
	public class BoxesModel : GenericModel
	{
		// Token: 0x06004985 RID: 18821 RVA: 0x001224B0 File Offset: 0x001206B0
		public List<boxes> LoadBoxes(int storeId)
		{
			List<boxes> result;
			try
			{
				result = (from b in this._context.boxes
				where b.store_id == (int?)storeId
				orderby b.name
				select b).ToList<boxes>().OrderBy((boxes b) => b.name, new NaturalComparer()).ToList<boxes>();
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load boxes in acp fail");
				result = new List<boxes>();
			}
			return result;
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x001225E4 File Offset: 0x001207E4
		public void CreateBox(boxes box, int storeId)
		{
			box.store_id = new int?(storeId);
			this._context.boxes.Add(box);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x0005E808 File Offset: 0x0005CA08
		public BoxesModel()
		{
		}

		// Token: 0x0200096C RID: 2412
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06004988 RID: 18824 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x04002ED0 RID: 11984
			public int storeId;
		}

		// Token: 0x0200096D RID: 2413
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004989 RID: 18825 RVA: 0x00122610 File Offset: 0x00120810
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600498A RID: 18826 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600498B RID: 18827 RVA: 0x000D14F8 File Offset: 0x000CF6F8
			internal string <LoadBoxes>b__0_2(boxes b)
			{
				return b.name;
			}

			// Token: 0x04002ED1 RID: 11985
			public static readonly BoxesModel.<>c <>9 = new BoxesModel.<>c();

			// Token: 0x04002ED2 RID: 11986
			public static Func<boxes, string> <>9__0_2;
		}
	}
}
