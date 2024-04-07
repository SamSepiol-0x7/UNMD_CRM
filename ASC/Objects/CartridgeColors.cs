using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace ASC.Objects
{
	// Token: 0x020008C1 RID: 2241
	public class CartridgeColors
	{
		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x0010CC34 File Offset: 0x0010AE34
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x0010CC48 File Offset: 0x0010AE48
		public Brush Color
		{
			[CompilerGenerated]
			get
			{
				return this.<Color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Color>k__BackingField = value;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x0010CC5C File Offset: 0x0010AE5C
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x0010CC70 File Offset: 0x0010AE70
		public int ColorId
		{
			[CompilerGenerated]
			get
			{
				return this.<ColorId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ColorId>k__BackingField = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x0010CC84 File Offset: 0x0010AE84
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x0010CC98 File Offset: 0x0010AE98
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

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x0010CCAC File Offset: 0x0010AEAC
		// (set) Token: 0x06004470 RID: 17520 RVA: 0x0010CCC0 File Offset: 0x0010AEC0
		public Brush Foreground
		{
			[CompilerGenerated]
			get
			{
				return this.<Foreground>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Foreground>k__BackingField = value;
			}
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x0010CCD4 File Offset: 0x0010AED4
		public CartridgeColors(int colorId, Brush color, string name, Brush foreground)
		{
			this.ColorId = colorId;
			this.Color = color;
			this.Name = name;
			this.Foreground = foreground;
		}

		// Token: 0x04002C2E RID: 11310
		[CompilerGenerated]
		private Brush <Color>k__BackingField;

		// Token: 0x04002C2F RID: 11311
		[CompilerGenerated]
		private int <ColorId>k__BackingField;

		// Token: 0x04002C30 RID: 11312
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002C31 RID: 11313
		[CompilerGenerated]
		private Brush <Foreground>k__BackingField;
	}
}
