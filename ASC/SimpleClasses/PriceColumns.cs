using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ASC.SimpleClasses
{
	// Token: 0x02000209 RID: 521
	public class PriceColumns
	{
		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00051FD8 File Offset: 0x000501D8
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x00051FEC File Offset: 0x000501EC
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

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00052000 File Offset: 0x00050200
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x00052014 File Offset: 0x00050214
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

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00052028 File Offset: 0x00050228
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x0005203C File Offset: 0x0005023C
		public bool IsEnable
		{
			[CompilerGenerated]
			get
			{
				return this.<IsEnable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsEnable>k__BackingField = value;
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x000046B4 File Offset: 0x000028B4
		public PriceColumns()
		{
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00052050 File Offset: 0x00050250
		public PriceColumns(int id, string name, bool isEnable)
		{
			this.Id = id;
			this.Name = name;
			this.IsEnable = isEnable;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00052078 File Offset: 0x00050278
		public static List<PriceColumns> GetPriceColumns()
		{
			return new List<PriceColumns>
			{
				new PriceColumns(1, (string)Application.Current.TryFindResource("PriceForSc"), Auth.Config.it_vis_price_for_sc),
				new PriceColumns(2, (string)Application.Current.TryFindResource("PriceForSale"), Auth.Config.it_vis_rozn),
				new PriceColumns(3, ((string)Application.Current.TryFindResource("PriceOpt")) ?? "", Auth.Config.it_vis_opt),
				new PriceColumns(4, (string)Application.Current.TryFindResource("PriceOpt") + " 2", Auth.Config.it_vis_opt2),
				new PriceColumns(5, (string)Application.Current.TryFindResource("PriceOpt") + " 3", Auth.Config.it_vis_opt3)
			};
		}

		// Token: 0x04000EAB RID: 3755
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04000EAC RID: 3756
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000EAD RID: 3757
		[CompilerGenerated]
		private bool <IsEnable>k__BackingField;
	}
}
