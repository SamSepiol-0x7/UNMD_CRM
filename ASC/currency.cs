using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000035 RID: 53
	public class currency
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0000BD28 File Offset: 0x00009F28
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x0000BD3C File Offset: 0x00009F3C
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000BD50 File Offset: 0x00009F50
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000BD64 File Offset: 0x00009F64
		public string from
		{
			[CompilerGenerated]
			get
			{
				return this.<from>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<from>k__BackingField = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0000BD78 File Offset: 0x00009F78
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x0000BD8C File Offset: 0x00009F8C
		public string to
		{
			[CompilerGenerated]
			get
			{
				return this.<to>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<to>k__BackingField = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0000BDA0 File Offset: 0x00009FA0
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		public decimal rate
		{
			[CompilerGenerated]
			get
			{
				return this.<rate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rate>k__BackingField = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x0000BDDC File Offset: 0x00009FDC
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

		// Token: 0x060004D4 RID: 1236 RVA: 0x000046B4 File Offset: 0x000028B4
		public currency()
		{
		}

		// Token: 0x0400024B RID: 587
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400024C RID: 588
		[CompilerGenerated]
		private string <from>k__BackingField;

		// Token: 0x0400024D RID: 589
		[CompilerGenerated]
		private string <to>k__BackingField;

		// Token: 0x0400024E RID: 590
		[CompilerGenerated]
		private decimal <rate>k__BackingField;

		// Token: 0x0400024F RID: 591
		[CompilerGenerated]
		private DateTime <created>k__BackingField;
	}
}
