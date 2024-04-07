using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000037 RID: 55
	public class dealer_payments
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x0000BF50 File Offset: 0x0000A150
		public dealer_payments()
		{
			this.store_sales = new HashSet<store_sales>();
			this.balance = new HashSet<balance>();
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0000BF7C File Offset: 0x0000A17C
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0000BF90 File Offset: 0x0000A190
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		public DateTime payment_date
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_date>k__BackingField = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
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

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000C008 File Offset: 0x0000A208
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

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0000C01C File Offset: 0x0000A21C
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0000C030 File Offset: 0x0000A230
		public int dealer_id
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dealer_id>k__BackingField = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0000C044 File Offset: 0x0000A244
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0000C058 File Offset: 0x0000A258
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0000C06C File Offset: 0x0000A26C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x0000C080 File Offset: 0x0000A280
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000C094 File Offset: 0x0000A294
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		public virtual ICollection<store_sales> store_sales
		{
			[CompilerGenerated]
			get
			{
				return this.<store_sales>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_sales>k__BackingField = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public virtual ICollection<balance> balance
		{
			[CompilerGenerated]
			get
			{
				return this.<balance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<balance>k__BackingField = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
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

		// Token: 0x04000258 RID: 600
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000259 RID: 601
		[CompilerGenerated]
		private DateTime <payment_date>k__BackingField;

		// Token: 0x0400025A RID: 602
		[CompilerGenerated]
		private int <user_id>k__BackingField;

		// Token: 0x0400025B RID: 603
		[CompilerGenerated]
		private int <state>k__BackingField;

		// Token: 0x0400025C RID: 604
		[CompilerGenerated]
		private int <dealer_id>k__BackingField;

		// Token: 0x0400025D RID: 605
		[CompilerGenerated]
		private decimal <summ>k__BackingField;

		// Token: 0x0400025E RID: 606
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x0400025F RID: 607
		[CompilerGenerated]
		private ICollection<store_sales> <store_sales>k__BackingField;

		// Token: 0x04000260 RID: 608
		[CompilerGenerated]
		private ICollection<balance> <balance>k__BackingField;

		// Token: 0x04000261 RID: 609
		[CompilerGenerated]
		private users <users>k__BackingField;
	}
}
