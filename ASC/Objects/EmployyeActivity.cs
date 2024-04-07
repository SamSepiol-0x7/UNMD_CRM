using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000869 RID: 2153
	public class EmployyeActivity : IEmployyeActivity
	{
		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x000FF580 File Offset: 0x000FD780
		// (set) Token: 0x06003FEC RID: 16364 RVA: 0x000FF594 File Offset: 0x000FD794
		public string Ip
		{
			[CompilerGenerated]
			get
			{
				return this.<Ip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ip>k__BackingField = value;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x000FF5A8 File Offset: 0x000FD7A8
		// (set) Token: 0x06003FEE RID: 16366 RVA: 0x000FF5BC File Offset: 0x000FD7BC
		public DateTime Date
		{
			[CompilerGenerated]
			get
			{
				return this.<Date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Date>k__BackingField = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06003FEF RID: 16367 RVA: 0x000FF5D0 File Offset: 0x000FD7D0
		// (set) Token: 0x06003FF0 RID: 16368 RVA: 0x000FF5E4 File Offset: 0x000FD7E4
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x000FF5F8 File Offset: 0x000FD7F8
		// (set) Token: 0x06003FF2 RID: 16370 RVA: 0x000FF60C File Offset: 0x000FD80C
		public string Version
		{
			[CompilerGenerated]
			get
			{
				return this.<Version>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x000FF620 File Offset: 0x000FD820
		// (set) Token: 0x06003FF4 RID: 16372 RVA: 0x000FF634 File Offset: 0x000FD834
		public string MachineName
		{
			[CompilerGenerated]
			get
			{
				return this.<MachineName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MachineName>k__BackingField = value;
			}
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x000046B4 File Offset: 0x000028B4
		public EmployyeActivity()
		{
		}

		// Token: 0x040029F4 RID: 10740
		[CompilerGenerated]
		private string <Ip>k__BackingField;

		// Token: 0x040029F5 RID: 10741
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x040029F6 RID: 10742
		[CompilerGenerated]
		private string <Text>k__BackingField;

		// Token: 0x040029F7 RID: 10743
		[CompilerGenerated]
		private string <Version>k__BackingField;

		// Token: 0x040029F8 RID: 10744
		[CompilerGenerated]
		private string <MachineName>k__BackingField;
	}
}
