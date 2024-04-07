using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000029 RID: 41
	public class api_status_checks
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00006D20 File Offset: 0x00004F20
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00006D34 File Offset: 0x00004F34
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00006D48 File Offset: 0x00004F48
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00006D5C File Offset: 0x00004F5C
		public long repair
		{
			[CompilerGenerated]
			get
			{
				return this.<repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<repair>k__BackingField = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00006D70 File Offset: 0x00004F70
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00006D84 File Offset: 0x00004F84
		public long? ip_address
		{
			[CompilerGenerated]
			get
			{
				return this.<ip_address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ip_address>k__BackingField = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00006D98 File Offset: 0x00004F98
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00006DAC File Offset: 0x00004FAC
		public string user_agent
		{
			[CompilerGenerated]
			get
			{
				return this.<user_agent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<user_agent>k__BackingField = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00006DC0 File Offset: 0x00004FC0
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00006DD4 File Offset: 0x00004FD4
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

		// Token: 0x06000193 RID: 403 RVA: 0x000046B4 File Offset: 0x000028B4
		public api_status_checks()
		{
		}

		// Token: 0x040000B4 RID: 180
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040000B5 RID: 181
		[CompilerGenerated]
		private long <repair>k__BackingField;

		// Token: 0x040000B6 RID: 182
		[CompilerGenerated]
		private long? <ip_address>k__BackingField;

		// Token: 0x040000B7 RID: 183
		[CompilerGenerated]
		private string <user_agent>k__BackingField;

		// Token: 0x040000B8 RID: 184
		[CompilerGenerated]
		private DateTime <created>k__BackingField;
	}
}
