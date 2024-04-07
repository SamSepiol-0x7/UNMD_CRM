using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000090 RID: 144
	public class w_lists
	{
		// Token: 0x06001217 RID: 4631 RVA: 0x00021B8C File Offset: 0x0001FD8C
		public w_lists()
		{
			this.invoice_items = new HashSet<invoice_items>();
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00021BAC File Offset: 0x0001FDAC
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x00021BC0 File Offset: 0x0001FDC0
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

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00021BD4 File Offset: 0x0001FDD4
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x00021BE8 File Offset: 0x0001FDE8
		public string num
		{
			[CompilerGenerated]
			get
			{
				return this.<num>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<num>k__BackingField = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00021BFC File Offset: 0x0001FDFC
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x00021C10 File Offset: 0x0001FE10
		public DateTime created
		{
			[CompilerGenerated]
			get
			{
				return this.<created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<created>k__BackingField = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00021C24 File Offset: 0x0001FE24
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x00021C38 File Offset: 0x0001FE38
		public int? invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice>k__BackingField = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00021C4C File Offset: 0x0001FE4C
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x00021C60 File Offset: 0x0001FE60
		public int user
		{
			[CompilerGenerated]
			get
			{
				return this.<user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<user>k__BackingField = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00021C74 File Offset: 0x0001FE74
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x00021C88 File Offset: 0x0001FE88
		public int seller
		{
			[CompilerGenerated]
			get
			{
				return this.<seller>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<seller>k__BackingField = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00021C9C File Offset: 0x0001FE9C
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x00021CB0 File Offset: 0x0001FEB0
		public int customer
		{
			[CompilerGenerated]
			get
			{
				return this.<customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<customer>k__BackingField = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x00021CC4 File Offset: 0x0001FEC4
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x00021CD8 File Offset: 0x0001FED8
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

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00021CEC File Offset: 0x0001FEEC
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x00021D00 File Offset: 0x0001FF00
		public decimal tax
		{
			[CompilerGenerated]
			get
			{
				return this.<tax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tax>k__BackingField = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x00021D14 File Offset: 0x0001FF14
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x00021D28 File Offset: 0x0001FF28
		public decimal summ
		{
			[CompilerGenerated]
			get
			{
				return this.<summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<summ>k__BackingField = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00021D3C File Offset: 0x0001FF3C
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00021D50 File Offset: 0x0001FF50
		public decimal total
		{
			[CompilerGenerated]
			get
			{
				return this.<total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<total>k__BackingField = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00021D64 File Offset: 0x0001FF64
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x00021D78 File Offset: 0x0001FF78
		public string notes
		{
			[CompilerGenerated]
			get
			{
				return this.<notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<notes>k__BackingField = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00021D8C File Offset: 0x0001FF8C
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00021DA0 File Offset: 0x0001FFA0
		public string reason
		{
			[CompilerGenerated]
			get
			{
				return this.<reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<reason>k__BackingField = value;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00021DB4 File Offset: 0x0001FFB4
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		public virtual banks banks
		{
			[CompilerGenerated]
			get
			{
				return this.<banks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<banks>k__BackingField = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00021DDC File Offset: 0x0001FFDC
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x00021DF0 File Offset: 0x0001FFF0
		public virtual banks banks1
		{
			[CompilerGenerated]
			get
			{
				return this.<banks1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<banks1>k__BackingField = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00021E04 File Offset: 0x00020004
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x00021E18 File Offset: 0x00020018
		public virtual invoice invoice1
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice1>k__BackingField = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00021E2C File Offset: 0x0002002C
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x00021E40 File Offset: 0x00020040
		public virtual ICollection<invoice_items> invoice_items
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice_items>k__BackingField = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00021E54 File Offset: 0x00020054
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x00021E68 File Offset: 0x00020068
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

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00021E7C File Offset: 0x0002007C
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x00021E90 File Offset: 0x00020090
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

		// Token: 0x0400088A RID: 2186
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400088B RID: 2187
		[CompilerGenerated]
		private string <num>k__BackingField;

		// Token: 0x0400088C RID: 2188
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x0400088D RID: 2189
		[CompilerGenerated]
		private int? <invoice>k__BackingField;

		// Token: 0x0400088E RID: 2190
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x0400088F RID: 2191
		[CompilerGenerated]
		private int <seller>k__BackingField;

		// Token: 0x04000890 RID: 2192
		[CompilerGenerated]
		private int <customer>k__BackingField;

		// Token: 0x04000891 RID: 2193
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x04000892 RID: 2194
		[CompilerGenerated]
		private decimal <tax>k__BackingField;

		// Token: 0x04000893 RID: 2195
		[CompilerGenerated]
		private decimal <summ>k__BackingField;

		// Token: 0x04000894 RID: 2196
		[CompilerGenerated]
		private decimal <total>k__BackingField;

		// Token: 0x04000895 RID: 2197
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000896 RID: 2198
		[CompilerGenerated]
		private string <reason>k__BackingField;

		// Token: 0x04000897 RID: 2199
		[CompilerGenerated]
		private banks <banks>k__BackingField;

		// Token: 0x04000898 RID: 2200
		[CompilerGenerated]
		private banks <banks1>k__BackingField;

		// Token: 0x04000899 RID: 2201
		[CompilerGenerated]
		private invoice <invoice1>k__BackingField;

		// Token: 0x0400089A RID: 2202
		[CompilerGenerated]
		private ICollection<invoice_items> <invoice_items>k__BackingField;

		// Token: 0x0400089B RID: 2203
		[CompilerGenerated]
		private offices <offices>k__BackingField;

		// Token: 0x0400089C RID: 2204
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
