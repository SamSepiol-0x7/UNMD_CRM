using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace ASC.Options
{
	// Token: 0x02000257 RID: 599
	public class StockTakingOptions
	{
		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0005E650 File Offset: 0x0005C850
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x0005E664 File Offset: 0x0005C864
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

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0005E678 File Offset: 0x0005C878
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0005E68C File Offset: 0x0005C88C
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

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0005E6A0 File Offset: 0x0005C8A0
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0005E6B4 File Offset: 0x0005C8B4
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

		// Token: 0x060020BF RID: 8383 RVA: 0x0005E6C8 File Offset: 0x0005C8C8
		public StockTakingOptions(int id, string name, Brush color)
		{
			this.Id = id;
			this.Name = name;
			this.Color = color;
		}

		// Token: 0x040010C1 RID: 4289
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010C2 RID: 4290
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040010C3 RID: 4291
		[CompilerGenerated]
		private Brush <Color>k__BackingField;
	}
}
