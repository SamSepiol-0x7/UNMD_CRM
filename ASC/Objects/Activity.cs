using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008C2 RID: 2242
	public class Activity : IActivity
	{
		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x0010CD04 File Offset: 0x0010AF04
		// (set) Token: 0x06004473 RID: 17523 RVA: 0x0010CD18 File Offset: 0x0010AF18
		public DateTime DateTime
		{
			[CompilerGenerated]
			get
			{
				return this.<DateTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DateTime>k__BackingField = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06004474 RID: 17524 RVA: 0x0010CD2C File Offset: 0x0010AF2C
		// (set) Token: 0x06004475 RID: 17525 RVA: 0x0010CD40 File Offset: 0x0010AF40
		public string Notes
		{
			[CompilerGenerated]
			get
			{
				return this.<Notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Notes>k__BackingField = value;
			}
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x000046B4 File Offset: 0x000028B4
		public Activity()
		{
		}

		// Token: 0x04002C32 RID: 11314
		[CompilerGenerated]
		private DateTime <DateTime>k__BackingField;

		// Token: 0x04002C33 RID: 11315
		[CompilerGenerated]
		private string <Notes>k__BackingField;
	}
}
