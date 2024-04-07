using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200004D RID: 77
	public class media_info
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0000FE28 File Offset: 0x0000E028
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0000FE3C File Offset: 0x0000E03C
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0000FE50 File Offset: 0x0000E050
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x0000FE64 File Offset: 0x0000E064
		public int state
		{
			[CompilerGenerated]
			get
			{
				return this.<state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<state>k__BackingField = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0000FE78 File Offset: 0x0000E078
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x0000FE8C File Offset: 0x0000E08C
		public int? client_id
		{
			[CompilerGenerated]
			get
			{
				return this.<client_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<client_id>k__BackingField = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
		public int? repair_id
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<repair_id>k__BackingField = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		public int? sale_id
		{
			[CompilerGenerated]
			get
			{
				return this.<sale_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sale_id>k__BackingField = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x0000FF04 File Offset: 0x0000E104
		public DateTime record_start
		{
			[CompilerGenerated]
			get
			{
				return this.<record_start>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<record_start>k__BackingField = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0000FF18 File Offset: 0x0000E118
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x0000FF2C File Offset: 0x0000E12C
		public DateTime? record_end
		{
			[CompilerGenerated]
			get
			{
				return this.<record_end>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<record_end>k__BackingField = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0000FF40 File Offset: 0x0000E140
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x0000FF54 File Offset: 0x0000E154
		public string file
		{
			[CompilerGenerated]
			get
			{
				return this.<file>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<file>k__BackingField = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x0000FF68 File Offset: 0x0000E168
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x0000FF7C File Offset: 0x0000E17C
		public int user_id
		{
			[CompilerGenerated]
			get
			{
				return this.<user_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<user_id>k__BackingField = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0000FF90 File Offset: 0x0000E190
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		public virtual clients clients
		{
			[CompilerGenerated]
			get
			{
				return this.<clients>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<clients>k__BackingField = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x0000FFCC File Offset: 0x0000E1CC
		public virtual docs docs
		{
			[CompilerGenerated]
			get
			{
				return this.<docs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<docs>k__BackingField = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0000FFE0 File Offset: 0x0000E1E0
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
		public virtual workshop workshop
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

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00010008 File Offset: 0x0000E208
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x0001001C File Offset: 0x0000E21C
		public virtual users users
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

		// Token: 0x06000779 RID: 1913 RVA: 0x000046B4 File Offset: 0x000028B4
		public media_info()
		{
		}

		// Token: 0x04000386 RID: 902
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000387 RID: 903
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x04000388 RID: 904
		[CompilerGenerated]
		private int? <client_id>k__BackingField;

		// Token: 0x04000389 RID: 905
		[CompilerGenerated]
		private int? <repair_id>k__BackingField;

		// Token: 0x0400038A RID: 906
		[CompilerGenerated]
		private int? <sale_id>k__BackingField;

		// Token: 0x0400038B RID: 907
		[CompilerGenerated]
		private DateTime <record_start>k__BackingField;

		// Token: 0x0400038C RID: 908
		[CompilerGenerated]
		private DateTime? <record_end>k__BackingField;

		// Token: 0x0400038D RID: 909
		[CompilerGenerated]
		private string <file>k__BackingField;

		// Token: 0x0400038E RID: 910
		[CompilerGenerated]
		private int <user_id>k__BackingField;

		// Token: 0x0400038F RID: 911
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x04000390 RID: 912
		[CompilerGenerated]
		private docs <docs>k__BackingField;

		// Token: 0x04000391 RID: 913
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
