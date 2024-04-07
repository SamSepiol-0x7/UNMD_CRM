using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000208 RID: 520
	public class PhotoGroup
	{
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00051F64 File Offset: 0x00050164
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x00051F78 File Offset: 0x00050178
		public string Caption
		{
			[CompilerGenerated]
			get
			{
				return this.<Caption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Caption>k__BackingField = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00051F8C File Offset: 0x0005018C
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x00051FA0 File Offset: 0x000501A0
		public PhotoSource Photos
		{
			[CompilerGenerated]
			get
			{
				return this.<Photos>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Photos>k__BackingField = value;
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000046B4 File Offset: 0x000028B4
		public PhotoGroup()
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00051FB4 File Offset: 0x000501B4
		public PhotoGroup(string caption, PhotoSource photos)
		{
			this.Caption = caption;
			this.Photos = photos;
		}

		// Token: 0x04000EA9 RID: 3753
		[CompilerGenerated]
		private string <Caption>k__BackingField;

		// Token: 0x04000EAA RID: 3754
		[CompilerGenerated]
		private PhotoSource <Photos>k__BackingField;
	}
}
