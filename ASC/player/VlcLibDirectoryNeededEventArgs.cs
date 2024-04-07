using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ASC.Player
{
	// Token: 0x02000249 RID: 585
	public sealed class VlcLibDirectoryNeededEventArgs : EventArgs
	{
		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x0005D2FC File Offset: 0x0005B4FC
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x0005D310 File Offset: 0x0005B510
		public DirectoryInfo VlcLibDirectory
		{
			[CompilerGenerated]
			get
			{
				return this.<VlcLibDirectory>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<VlcLibDirectory>k__BackingField = value;
			}
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0005D324 File Offset: 0x0005B524
		public VlcLibDirectoryNeededEventArgs()
		{
		}

		// Token: 0x04001098 RID: 4248
		[CompilerGenerated]
		private DirectoryInfo <VlcLibDirectory>k__BackingField;
	}
}
