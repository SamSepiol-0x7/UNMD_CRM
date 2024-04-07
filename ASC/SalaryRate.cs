using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200001A RID: 26
	public class SalaryRate
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004AD8 File Offset: 0x00002CD8
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00004AEC File Offset: 0x00002CEC
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00004B00 File Offset: 0x00002D00
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00004B14 File Offset: 0x00002D14
		public DateTime CreatedAt
		{
			[CompilerGenerated]
			get
			{
				return this.<CreatedAt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CreatedAt>k__BackingField = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00004B28 File Offset: 0x00002D28
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00004B3C File Offset: 0x00002D3C
		public DateTime StartFrom
		{
			[CompilerGenerated]
			get
			{
				return this.<StartFrom>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<StartFrom>k__BackingField = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004B50 File Offset: 0x00002D50
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00004B64 File Offset: 0x00002D64
		public int UserId
		{
			[CompilerGenerated]
			get
			{
				return this.<UserId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserId>k__BackingField = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004B78 File Offset: 0x00002D78
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00004B8C File Offset: 0x00002D8C
		public int Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00004BA0 File Offset: 0x00002DA0
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public virtual users User
		{
			[CompilerGenerated]
			get
			{
				return this.<User>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<User>k__BackingField = value;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000046B4 File Offset: 0x000028B4
		public SalaryRate()
		{
		}

		// Token: 0x0400004B RID: 75
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x0400004C RID: 76
		[CompilerGenerated]
		private DateTime <CreatedAt>k__BackingField;

		// Token: 0x0400004D RID: 77
		[CompilerGenerated]
		private DateTime <StartFrom>k__BackingField;

		// Token: 0x0400004E RID: 78
		[CompilerGenerated]
		private int <UserId>k__BackingField;

		// Token: 0x0400004F RID: 79
		[CompilerGenerated]
		private int <Value>k__BackingField;

		// Token: 0x04000050 RID: 80
		[CompilerGenerated]
		private users <User>k__BackingField;
	}
}
