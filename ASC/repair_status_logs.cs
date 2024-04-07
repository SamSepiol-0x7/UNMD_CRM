using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000019 RID: 25
	public class repair_status_logs
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004920 File Offset: 0x00002B20
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00004934 File Offset: 0x00002B34
		public long Id
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004948 File Offset: 0x00002B48
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000495C File Offset: 0x00002B5C
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004970 File Offset: 0x00002B70
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00004984 File Offset: 0x00002B84
		public int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RepairId>k__BackingField = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004998 File Offset: 0x00002B98
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000049AC File Offset: 0x00002BAC
		public int StatusId
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<StatusId>k__BackingField = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000049C0 File Offset: 0x00002BC0
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000049D4 File Offset: 0x00002BD4
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

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000049E8 File Offset: 0x00002BE8
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000049FC File Offset: 0x00002BFC
		public int? ManagerId
		{
			[CompilerGenerated]
			get
			{
				return this.<ManagerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ManagerId>k__BackingField = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00004A10 File Offset: 0x00002C10
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00004A24 File Offset: 0x00002C24
		public int? MasterId
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MasterId>k__BackingField = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00004A38 File Offset: 0x00002C38
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00004A4C File Offset: 0x00002C4C
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004A60 File Offset: 0x00002C60
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00004A74 File Offset: 0x00002C74
		public virtual users Manager
		{
			[CompilerGenerated]
			get
			{
				return this.<Manager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Manager>k__BackingField = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004A88 File Offset: 0x00002C88
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00004A9C File Offset: 0x00002C9C
		public virtual users Master
		{
			[CompilerGenerated]
			get
			{
				return this.<Master>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Master>k__BackingField = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004AB0 File Offset: 0x00002CB0
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public virtual workshop Repair
		{
			[CompilerGenerated]
			get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Repair>k__BackingField = value;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000046B4 File Offset: 0x000028B4
		public repair_status_logs()
		{
		}

		// Token: 0x04000040 RID: 64
		[CompilerGenerated]
		private long <Id>k__BackingField;

		// Token: 0x04000041 RID: 65
		[CompilerGenerated]
		private DateTime <CreatedAt>k__BackingField;

		// Token: 0x04000042 RID: 66
		[CompilerGenerated]
		private int <RepairId>k__BackingField;

		// Token: 0x04000043 RID: 67
		[CompilerGenerated]
		private int <StatusId>k__BackingField;

		// Token: 0x04000044 RID: 68
		[CompilerGenerated]
		private int <UserId>k__BackingField;

		// Token: 0x04000045 RID: 69
		[CompilerGenerated]
		private int? <ManagerId>k__BackingField;

		// Token: 0x04000046 RID: 70
		[CompilerGenerated]
		private int? <MasterId>k__BackingField;

		// Token: 0x04000047 RID: 71
		[CompilerGenerated]
		private users <User>k__BackingField;

		// Token: 0x04000048 RID: 72
		[CompilerGenerated]
		private users <Manager>k__BackingField;

		// Token: 0x04000049 RID: 73
		[CompilerGenerated]
		private users <Master>k__BackingField;

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		private workshop <Repair>k__BackingField;
	}
}
