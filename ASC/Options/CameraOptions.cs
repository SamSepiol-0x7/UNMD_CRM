using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.Options
{
	// Token: 0x0200024A RID: 586
	public class CameraOptions
	{
		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0005D338 File Offset: 0x0005B538
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x0005D34C File Offset: 0x0005B54C
		public int ProtocolId
		{
			[CompilerGenerated]
			get
			{
				return this.<ProtocolId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ProtocolId>k__BackingField = value;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0005D360 File Offset: 0x0005B560
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x0005D374 File Offset: 0x0005B574
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0005D388 File Offset: 0x0005B588
		public CameraOptions(int id, string name)
		{
			this.ProtocolId = id;
			this.Name = name;
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000046B4 File Offset: 0x000028B4
		public CameraOptions()
		{
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0005D3AC File Offset: 0x0005B5AC
		public static List<CameraOptions> GetAllOptions()
		{
			return new List<CameraOptions>
			{
				new CameraOptions(1, "RTSP"),
				new CameraOptions(2, "USB local")
			};
		}

		// Token: 0x04001099 RID: 4249
		[CompilerGenerated]
		private int <ProtocolId>k__BackingField;

		// Token: 0x0400109A RID: 4250
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
