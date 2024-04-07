using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x0200086D RID: 2157
	public class Hook : IHook
	{
		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x000FF7F4 File Offset: 0x000FD9F4
		// (set) Token: 0x06004009 RID: 16393 RVA: 0x000FF808 File Offset: 0x000FDA08
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

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x0600400A RID: 16394 RVA: 0x000FF81C File Offset: 0x000FDA1C
		// (set) Token: 0x0600400B RID: 16395 RVA: 0x000FF830 File Offset: 0x000FDA30
		public int HookId
		{
			[CompilerGenerated]
			get
			{
				return this.<HookId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<HookId>k__BackingField = value;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x0600400C RID: 16396 RVA: 0x000FF844 File Offset: 0x000FDA44
		// (set) Token: 0x0600400D RID: 16397 RVA: 0x000FF858 File Offset: 0x000FDA58
		public int Status
		{
			[CompilerGenerated]
			get
			{
				return this.<Status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Status>k__BackingField = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600400E RID: 16398 RVA: 0x000FF86C File Offset: 0x000FDA6C
		// (set) Token: 0x0600400F RID: 16399 RVA: 0x000FF880 File Offset: 0x000FDA80
		public DateTime? CreatedAt
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06004010 RID: 16400 RVA: 0x000FF894 File Offset: 0x000FDA94
		// (set) Token: 0x06004011 RID: 16401 RVA: 0x000FF8A8 File Offset: 0x000FDAA8
		public DateTime? UpdatedAt
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdatedAt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UpdatedAt>k__BackingField = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06004012 RID: 16402 RVA: 0x000FF8BC File Offset: 0x000FDABC
		// (set) Token: 0x06004013 RID: 16403 RVA: 0x000FF8D0 File Offset: 0x000FDAD0
		public string Event
		{
			[CompilerGenerated]
			get
			{
				return this.<Event>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Event>k__BackingField = value;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06004014 RID: 16404 RVA: 0x000FF8E4 File Offset: 0x000FDAE4
		// (set) Token: 0x06004015 RID: 16405 RVA: 0x000FF8F8 File Offset: 0x000FDAF8
		public int? p0
		{
			[CompilerGenerated]
			get
			{
				return this.<p0>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<p0>k__BackingField = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x000FF90C File Offset: 0x000FDB0C
		// (set) Token: 0x06004017 RID: 16407 RVA: 0x000FF920 File Offset: 0x000FDB20
		public string Prm
		{
			[CompilerGenerated]
			get
			{
				return this.<Prm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Prm>k__BackingField = value;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x000FF934 File Offset: 0x000FDB34
		// (set) Token: 0x06004019 RID: 16409 RVA: 0x000FF948 File Offset: 0x000FDB48
		public int? TaskId
		{
			[CompilerGenerated]
			get
			{
				return this.<TaskId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TaskId>k__BackingField = value;
			}
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x000046B4 File Offset: 0x000028B4
		public Hook()
		{
		}

		// Token: 0x04002A00 RID: 10752
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A01 RID: 10753
		[CompilerGenerated]
		private int <HookId>k__BackingField;

		// Token: 0x04002A02 RID: 10754
		[CompilerGenerated]
		private int <Status>k__BackingField;

		// Token: 0x04002A03 RID: 10755
		[CompilerGenerated]
		private DateTime? <CreatedAt>k__BackingField;

		// Token: 0x04002A04 RID: 10756
		[CompilerGenerated]
		private DateTime? <UpdatedAt>k__BackingField;

		// Token: 0x04002A05 RID: 10757
		[CompilerGenerated]
		private string <Event>k__BackingField;

		// Token: 0x04002A06 RID: 10758
		[CompilerGenerated]
		private int? <p0>k__BackingField;

		// Token: 0x04002A07 RID: 10759
		[CompilerGenerated]
		private string <Prm>k__BackingField;

		// Token: 0x04002A08 RID: 10760
		[CompilerGenerated]
		private int? <TaskId>k__BackingField;
	}
}
