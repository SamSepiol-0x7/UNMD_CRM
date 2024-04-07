using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Objects;
using DevExpress.DataAccess.ObjectBinding;

namespace ASC.Objects
{
	// Token: 0x02000896 RID: 2198
	[HighlightedClass]
	public class CartridgeReport : BaseCartridgeReport
	{
		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x001057F4 File Offset: 0x001039F4
		// (set) Token: 0x060042BF RID: 17087 RVA: 0x00105808 File Offset: 0x00103A08
		public companies Company
		{
			[CompilerGenerated]
			get
			{
				return this.<Company>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Company>k__BackingField = value;
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x060042C0 RID: 17088 RVA: 0x0010581C File Offset: 0x00103A1C
		// (set) Token: 0x060042C1 RID: 17089 RVA: 0x00105830 File Offset: 0x00103A30
		public offices Office
		{
			[CompilerGenerated]
			get
			{
				return this.<Office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Office>k__BackingField = value;
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x060042C2 RID: 17090 RVA: 0x00105844 File Offset: 0x00103A44
		// (set) Token: 0x060042C3 RID: 17091 RVA: 0x00105858 File Offset: 0x00103A58
		public List<Cartridge> Cartridges
		{
			[CompilerGenerated]
			get
			{
				return this.<Cartridges>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Cartridges>k__BackingField = value;
			}
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0010586C File Offset: 0x00103A6C
		public CartridgeReport()
		{
			Localization localization = new Localization("UTC");
			base.Date = localization.Now;
			this.Cartridges = new List<Cartridge>();
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x001058A4 File Offset: 0x00103AA4
		public override void ConstrunctNum()
		{
			int num = this.Cartridges.Min((Cartridge c) => c.Id);
			int count = this.Cartridges.Count;
			if (count == 1)
			{
				base.Num = string.Format("{0:d6}", num);
				return;
			}
			base.Num = string.Format("{0:d6}/{1}", num, count);
		}

		// Token: 0x04002B25 RID: 11045
		[CompilerGenerated]
		private companies <Company>k__BackingField;

		// Token: 0x04002B26 RID: 11046
		[CompilerGenerated]
		private offices <Office>k__BackingField;

		// Token: 0x04002B27 RID: 11047
		[CompilerGenerated]
		private List<Cartridge> <Cartridges>k__BackingField;

		// Token: 0x02000897 RID: 2199
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060042C6 RID: 17094 RVA: 0x00105920 File Offset: 0x00103B20
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060042C7 RID: 17095 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060042C8 RID: 17096 RVA: 0x0007933C File Offset: 0x0007753C
			internal int <ConstrunctNum>b__13_0(Cartridge c)
			{
				return c.Id;
			}

			// Token: 0x04002B28 RID: 11048
			public static readonly CartridgeReport.<>c <>9 = new CartridgeReport.<>c();

			// Token: 0x04002B29 RID: 11049
			public static Func<Cartridge, int> <>9__13_0;
		}
	}
}
