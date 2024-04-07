using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Integration;
using Vlc.DotNet.Forms;

namespace ASC.Player
{
	// Token: 0x02000248 RID: 584
	public class VlcControl : WindowsFormsHost
	{
		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x0005D2A8 File Offset: 0x0005B4A8
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x0005D2BC File Offset: 0x0005B4BC
		public VlcControl MediaPlayer
		{
			[CompilerGenerated]
			get
			{
				return this.<MediaPlayer>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<MediaPlayer>k__BackingField = value;
			}
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
		public VlcControl()
		{
			this.MediaPlayer = new VlcControl();
			base.Child = this.MediaPlayer;
		}

		// Token: 0x04001097 RID: 4247
		[CompilerGenerated]
		private VlcControl <MediaPlayer>k__BackingField;
	}
}
