using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000039 RID: 57
	public class device_makers
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x0000C320 File Offset: 0x0000A520
		public device_makers()
		{
			this.device_models = new HashSet<device_models>();
			this.workshop = new HashSet<workshop>();
			this.cartridge_cards = new HashSet<cartridge_cards>();
			this.buyout = new HashSet<buyout>();
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0000C360 File Offset: 0x0000A560
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0000C374 File Offset: 0x0000A574
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0000C388 File Offset: 0x0000A588
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0000C39C File Offset: 0x0000A59C
		public string name
		{
			[CompilerGenerated]
			get
			{
				return this.<name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<name>k__BackingField = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
		public virtual ICollection<device_models> device_models
		{
			[CompilerGenerated]
			get
			{
				return this.<device_models>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<device_models>k__BackingField = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		public virtual ICollection<workshop> workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop>k__BackingField = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000C400 File Offset: 0x0000A600
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0000C414 File Offset: 0x0000A614
		public virtual ICollection<cartridge_cards> cartridge_cards
		{
			[CompilerGenerated]
			get
			{
				return this.<cartridge_cards>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cartridge_cards>k__BackingField = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000C428 File Offset: 0x0000A628
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0000C43C File Offset: 0x0000A63C
		public virtual ICollection<buyout> buyout
		{
			[CompilerGenerated]
			get
			{
				return this.<buyout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<buyout>k__BackingField = value;
			}
		}

		// Token: 0x0400026E RID: 622
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400026F RID: 623
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000270 RID: 624
		[CompilerGenerated]
		private ICollection<device_models> <device_models>k__BackingField;

		// Token: 0x04000271 RID: 625
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x04000272 RID: 626
		[CompilerGenerated]
		private ICollection<cartridge_cards> <cartridge_cards>k__BackingField;

		// Token: 0x04000273 RID: 627
		[CompilerGenerated]
		private ICollection<buyout> <buyout>k__BackingField;
	}
}
