using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200005B RID: 91
	public class pinpad
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x000122DC File Offset: 0x000104DC
		public pinpad()
		{
			this.users = new HashSet<users>();
			this.pinpad_logs = new HashSet<pinpad_logs>();
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00012308 File Offset: 0x00010508
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0001231C File Offset: 0x0001051C
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00012330 File Offset: 0x00010530
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00012344 File Offset: 0x00010544
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

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00012358 File Offset: 0x00010558
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0001236C File Offset: 0x0001056C
		public int? kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt>k__BackingField = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00012380 File Offset: 0x00010580
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00012394 File Offset: 0x00010594
		public int? printer
		{
			[CompilerGenerated]
			get
			{
				return this.<printer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<printer>k__BackingField = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000123A8 File Offset: 0x000105A8
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000123BC File Offset: 0x000105BC
		public int office
		{
			[CompilerGenerated]
			get
			{
				return this.<office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<office>k__BackingField = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x000123D0 File Offset: 0x000105D0
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x000123E4 File Offset: 0x000105E4
		public double fee
		{
			[CompilerGenerated]
			get
			{
				return this.<fee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fee>k__BackingField = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000123F8 File Offset: 0x000105F8
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0001240C File Offset: 0x0001060C
		public bool fee_mode
		{
			[CompilerGenerated]
			get
			{
				return this.<fee_mode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fee_mode>k__BackingField = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00012420 File Offset: 0x00010620
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00012434 File Offset: 0x00010634
		public virtual ICollection<users> users
		{
			[CompilerGenerated]
			get
			{
				return this.<users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<users>k__BackingField = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00012448 File Offset: 0x00010648
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x0001245C File Offset: 0x0001065C
		public virtual offices offices
		{
			[CompilerGenerated]
			get
			{
				return this.<offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<offices>k__BackingField = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00012470 File Offset: 0x00010670
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00012484 File Offset: 0x00010684
		public virtual ICollection<pinpad_logs> pinpad_logs
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad_logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad_logs>k__BackingField = value;
			}
		}

		// Token: 0x0400042D RID: 1069
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400042E RID: 1070
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400042F RID: 1071
		[CompilerGenerated]
		private int? <kkt>k__BackingField;

		// Token: 0x04000430 RID: 1072
		[CompilerGenerated]
		private int? <printer>k__BackingField;

		// Token: 0x04000431 RID: 1073
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x04000432 RID: 1074
		[CompilerGenerated]
		private double <fee>k__BackingField;

		// Token: 0x04000433 RID: 1075
		[CompilerGenerated]
		private bool <fee_mode>k__BackingField;

		// Token: 0x04000434 RID: 1076
		[CompilerGenerated]
		private ICollection<users> <users>k__BackingField;

		// Token: 0x04000435 RID: 1077
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x04000436 RID: 1078
		[CompilerGenerated]
		private ICollection<pinpad_logs> <pinpad_logs>k__BackingField;
	}
}
