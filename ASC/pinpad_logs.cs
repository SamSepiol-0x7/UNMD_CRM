using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200005C RID: 92
	public class pinpad_logs
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00012498 File Offset: 0x00010698
		public pinpad_logs()
		{
			this.cash_orders = new HashSet<cash_orders>();
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x000124B8 File Offset: 0x000106B8
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x000124CC File Offset: 0x000106CC
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000124E0 File Offset: 0x000106E0
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x000124F4 File Offset: 0x000106F4
		public int pinpad
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad>k__BackingField = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00012508 File Offset: 0x00010708
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x0001251C File Offset: 0x0001071C
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

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00012530 File Offset: 0x00010730
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00012544 File Offset: 0x00010744
		public decimal amount
		{
			[CompilerGenerated]
			get
			{
				return this.<amount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<amount>k__BackingField = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00012558 File Offset: 0x00010758
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x0001256C File Offset: 0x0001076C
		public string TermNum
		{
			[CompilerGenerated]
			get
			{
				return this.<TermNum>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TermNum>k__BackingField = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00012580 File Offset: 0x00010780
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00012594 File Offset: 0x00010794
		public string ClientCard
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientCard>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientCard>k__BackingField = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000125A8 File Offset: 0x000107A8
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x000125BC File Offset: 0x000107BC
		public string ClientExpiryDate
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientExpiryDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientExpiryDate>k__BackingField = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x000125D0 File Offset: 0x000107D0
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x000125E4 File Offset: 0x000107E4
		public string AuthCode
		{
			[CompilerGenerated]
			get
			{
				return this.<AuthCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AuthCode>k__BackingField = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000125F8 File Offset: 0x000107F8
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x0001260C File Offset: 0x0001080C
		public string CardName
		{
			[CompilerGenerated]
			get
			{
				return this.<CardName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CardName>k__BackingField = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00012620 File Offset: 0x00010820
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00012634 File Offset: 0x00010834
		public virtual ICollection<cash_orders> cash_orders
		{
			[CompilerGenerated]
			get
			{
				return this.<cash_orders>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cash_orders>k__BackingField = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00012648 File Offset: 0x00010848
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0001265C File Offset: 0x0001085C
		public virtual pinpad pinpad1
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad1>k__BackingField = value;
			}
		}

		// Token: 0x04000437 RID: 1079
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000438 RID: 1080
		[CompilerGenerated]
		private int <pinpad>k__BackingField;

		// Token: 0x04000439 RID: 1081
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x0400043A RID: 1082
		[CompilerGenerated]
		private decimal <amount>k__BackingField;

		// Token: 0x0400043B RID: 1083
		[CompilerGenerated]
		private string <TermNum>k__BackingField;

		// Token: 0x0400043C RID: 1084
		[CompilerGenerated]
		private string <ClientCard>k__BackingField;

		// Token: 0x0400043D RID: 1085
		[CompilerGenerated]
		private string <ClientExpiryDate>k__BackingField;

		// Token: 0x0400043E RID: 1086
		[CompilerGenerated]
		private string <AuthCode>k__BackingField;

		// Token: 0x0400043F RID: 1087
		[CompilerGenerated]
		private string <CardName>k__BackingField;

		// Token: 0x04000440 RID: 1088
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x04000441 RID: 1089
		[CompilerGenerated]
		private pinpad <pinpad1>k__BackingField;
	}
}
