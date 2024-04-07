using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000038 RID: 56
	public class devices
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x0000C10C File Offset: 0x0000A30C
		public devices()
		{
			this.workshop = new HashSet<workshop>();
			this.device_models = new HashSet<device_models>();
			this.buyout = new HashSet<buyout>();
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0000C140 File Offset: 0x0000A340
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x0000C154 File Offset: 0x0000A354
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

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0000C168 File Offset: 0x0000A368
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x0000C17C File Offset: 0x0000A37C
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

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0000C190 File Offset: 0x0000A390
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		public bool? enable
		{
			[CompilerGenerated]
			get
			{
				return this.<enable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<enable>k__BackingField = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		public string fault_list
		{
			[CompilerGenerated]
			get
			{
				return this.<fault_list>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fault_list>k__BackingField = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0000C208 File Offset: 0x0000A408
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x0000C21C File Offset: 0x0000A41C
		public string look_list
		{
			[CompilerGenerated]
			get
			{
				return this.<look_list>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<look_list>k__BackingField = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000C230 File Offset: 0x0000A430
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x0000C244 File Offset: 0x0000A444
		public string complect_list
		{
			[CompilerGenerated]
			get
			{
				return this.<complect_list>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<complect_list>k__BackingField = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000C258 File Offset: 0x0000A458
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0000C26C File Offset: 0x0000A46C
		public string company_list
		{
			[CompilerGenerated]
			get
			{
				return this.<company_list>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<company_list>k__BackingField = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0000C280 File Offset: 0x0000A480
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0000C294 File Offset: 0x0000A494
		public bool refill
		{
			[CompilerGenerated]
			get
			{
				return this.<refill>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<refill>k__BackingField = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0000C2BC File Offset: 0x0000A4BC
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0000C30C File Offset: 0x0000A50C
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

		// Token: 0x04000262 RID: 610
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000263 RID: 611
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000264 RID: 612
		[CompilerGenerated]
		private int? <position>k__BackingField;

		// Token: 0x04000265 RID: 613
		[CompilerGenerated]
		private bool? <enable>k__BackingField;

		// Token: 0x04000266 RID: 614
		[CompilerGenerated]
		private string <fault_list>k__BackingField;

		// Token: 0x04000267 RID: 615
		[CompilerGenerated]
		private string <look_list>k__BackingField;

		// Token: 0x04000268 RID: 616
		[CompilerGenerated]
		private string <complect_list>k__BackingField;

		// Token: 0x04000269 RID: 617
		[CompilerGenerated]
		private string <company_list>k__BackingField;

		// Token: 0x0400026A RID: 618
		[CompilerGenerated]
		private bool <refill>k__BackingField;

		// Token: 0x0400026B RID: 619
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x0400026C RID: 620
		[CompilerGenerated]
		private ICollection<device_models> <device_models>k__BackingField;

		// Token: 0x0400026D RID: 621
		[CompilerGenerated]
		private ICollection<buyout> <buyout>k__BackingField;
	}
}
