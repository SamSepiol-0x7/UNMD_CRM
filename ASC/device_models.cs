using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200003A RID: 58
	public class device_models
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x0000C450 File Offset: 0x0000A650
		public device_models()
		{
			this.workshop = new HashSet<workshop>();
			this.buyout = new HashSet<buyout>();
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000C47C File Offset: 0x0000A67C
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x0000C490 File Offset: 0x0000A690
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0000C4CC File Offset: 0x0000A6CC
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		public int? position
		{
			[CompilerGenerated]
			get
			{
				return this.<position>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<position>k__BackingField = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0000C508 File Offset: 0x0000A708
		public int maker
		{
			[CompilerGenerated]
			get
			{
				return this.<maker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<maker>k__BackingField = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000C51C File Offset: 0x0000A71C
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000C530 File Offset: 0x0000A730
		public int? device
		{
			[CompilerGenerated]
			get
			{
				return this.<device>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<device>k__BackingField = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0000C544 File Offset: 0x0000A744
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0000C558 File Offset: 0x0000A758
		public virtual device_makers device_makers
		{
			[CompilerGenerated]
			get
			{
				return this.<device_makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<device_makers>k__BackingField = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0000C56C File Offset: 0x0000A76C
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0000C580 File Offset: 0x0000A780
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0000C594 File Offset: 0x0000A794
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public virtual devices devices
		{
			[CompilerGenerated]
			get
			{
				return this.<devices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<devices>k__BackingField = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
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

		// Token: 0x04000274 RID: 628
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000275 RID: 629
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000276 RID: 630
		[CompilerGenerated]
		private int? <position>k__BackingField;

		// Token: 0x04000277 RID: 631
		[CompilerGenerated]
		private int <maker>k__BackingField;

		// Token: 0x04000278 RID: 632
		[CompilerGenerated]
		private int? <device>k__BackingField;

		// Token: 0x04000279 RID: 633
		[CompilerGenerated]
		private device_makers <device_makers>k__BackingField;

		// Token: 0x0400027A RID: 634
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x0400027B RID: 635
		[CompilerGenerated]
		private devices <devices>k__BackingField;

		// Token: 0x0400027C RID: 636
		[CompilerGenerated]
		private ICollection<buyout> <buyout>k__BackingField;
	}
}
