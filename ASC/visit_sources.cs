using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000085 RID: 133
	public class visit_sources
	{
		// Token: 0x06001053 RID: 4179 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		public visit_sources()
		{
			this.clients = new HashSet<clients>();
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0001DE0C File Offset: 0x0001C00C
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x0001DE20 File Offset: 0x0001C020
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

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x0001DE34 File Offset: 0x0001C034
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x0001DE48 File Offset: 0x0001C048
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

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0001DE5C File Offset: 0x0001C05C
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x0001DE70 File Offset: 0x0001C070
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

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x0001DE84 File Offset: 0x0001C084
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x0001DE98 File Offset: 0x0001C098
		public bool? enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<enabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<enabled>k__BackingField = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0001DEAC File Offset: 0x0001C0AC
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		public int? fire_on
		{
			[CompilerGenerated]
			get
			{
				return this.<fire_on>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fire_on>k__BackingField = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0001DED4 File Offset: 0x0001C0D4
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
		public virtual ICollection<clients> clients
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

		// Token: 0x040007B3 RID: 1971
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040007B4 RID: 1972
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x040007B5 RID: 1973
		[CompilerGenerated]
		private int? <position>k__BackingField;

		// Token: 0x040007B6 RID: 1974
		[CompilerGenerated]
		private bool? <enabled>k__BackingField;

		// Token: 0x040007B7 RID: 1975
		[CompilerGenerated]
		private int? <fire_on>k__BackingField;

		// Token: 0x040007B8 RID: 1976
		[CompilerGenerated]
		private ICollection<clients> <clients>k__BackingField;
	}
}
