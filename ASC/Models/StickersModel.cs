using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000A71 RID: 2673
	public class StickersModel : ItemsModel
	{
		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06004D6F RID: 19823 RVA: 0x00145610 File Offset: 0x00143810
		// (set) Token: 0x06004D70 RID: 19824 RVA: 0x00145624 File Offset: 0x00143824
		public List<KeyValuePair<string, string>> Variants
		{
			[CompilerGenerated]
			get
			{
				return this.<Variants>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Variants>k__BackingField = value;
			}
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00145638 File Offset: 0x00143838
		public StickersModel()
		{
			List<KeyValuePair<string, string>> list = this.LoadStickerList();
			list.AddRange(this.LoadPriceList());
			this.Variants = list;
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00145668 File Offset: 0x00143868
		public List<KeyValuePair<string, string>> LoadStickerList()
		{
			List<KeyValuePair<string, string>> result;
			try
			{
				result = StickersModel.KeyValuePairs("sticker");
			}
			catch (Exception exception)
			{
				StickersModel.Log.Error(exception, "Load stickers template list fail");
				result = new List<KeyValuePair<string, string>>();
			}
			return result;
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x001456AC File Offset: 0x001438AC
		public List<KeyValuePair<string, string>> LoadPriceList()
		{
			List<KeyValuePair<string, string>> result;
			try
			{
				result = StickersModel.KeyValuePairs("price");
			}
			catch (Exception exception)
			{
				StickersModel.Log.Error(exception, "Load price tempalte list fail");
				result = new List<KeyValuePair<string, string>>();
			}
			return result;
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x001456F0 File Offset: 0x001438F0
		private static List<KeyValuePair<string, string>> KeyValuePairs(string name)
		{
			List<KeyValuePair<string, string>> result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				result = (from o in (from t in auseceEntities.doc_templates
				where t.name.Contains(name) && t.name.Length <= 8
				select t into o
				select new
				{
					o.name,
					o.description
				}).AsEnumerable()
				select new KeyValuePair<string, string>(o.name, o.description)).ToList<KeyValuePair<string, string>>();
			}
			return result;
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x001458E0 File Offset: 0x00143AE0
		// Note: this type is marked as 'beforefieldinit'.
		static StickersModel()
		{
		}

		// Token: 0x040032E0 RID: 13024
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x040032E1 RID: 13025
		[CompilerGenerated]
		private List<KeyValuePair<string, string>> <Variants>k__BackingField;

		// Token: 0x02000A72 RID: 2674
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004D76 RID: 19830 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x040032E2 RID: 13026
			public string name;
		}

		// Token: 0x02000A73 RID: 2675
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004D77 RID: 19831 RVA: 0x001458F8 File Offset: 0x00143AF8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004D78 RID: 19832 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004D79 RID: 19833 RVA: 0x00145910 File Offset: 0x00143B10
			internal KeyValuePair<string, string> <KeyValuePairs>b__8_2(<>f__AnonymousType17<string, string> o)
			{
				return new KeyValuePair<string, string>(o.name, o.description);
			}

			// Token: 0x040032E3 RID: 13027
			public static readonly StickersModel.<>c <>9 = new StickersModel.<>c();

			// Token: 0x040032E4 RID: 13028
			public static Func<<>f__AnonymousType17<string, string>, KeyValuePair<string, string>> <>9__8_2;
		}
	}
}
