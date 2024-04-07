using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ASC.Input
{
	// Token: 0x020001E7 RID: 487
	public class KeyPressedArgs : EventArgs
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0004EDE4 File Offset: 0x0004CFE4
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0004EDF8 File Offset: 0x0004CFF8
		public Key KeyPressed
		{
			[CompilerGenerated]
			get
			{
				return this.<KeyPressed>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<KeyPressed>k__BackingField = value;
			}
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0004EE0C File Offset: 0x0004D00C
		public KeyPressedArgs(Key key)
		{
			this.KeyPressed = key;
		}

		// Token: 0x04000E07 RID: 3591
		[CompilerGenerated]
		private Key <KeyPressed>k__BackingField;
	}
}
