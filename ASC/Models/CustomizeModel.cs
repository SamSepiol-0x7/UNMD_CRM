using System;
using System.Collections.Generic;

namespace ASC.Models
{
	// Token: 0x02000964 RID: 2404
	public class CustomizeModel
	{
		// Token: 0x06004960 RID: 18784 RVA: 0x001213A0 File Offset: 0x0011F5A0
		public static List<KeyValuePair<string, string>> GetAnimationTypes()
		{
			return new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("None", Lang.t("No")),
				new KeyValuePair<string, string>("Fade", Lang.t("Fade")),
				new KeyValuePair<string, string>("SlideHorizontal", Lang.t("SlideHorizontal")),
				new KeyValuePair<string, string>("SlideVertical", Lang.t("SlideVertical"))
			};
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x000046B4 File Offset: 0x000028B4
		public CustomizeModel()
		{
		}
	}
}
