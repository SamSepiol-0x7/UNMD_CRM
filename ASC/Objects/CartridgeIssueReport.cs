using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Objects;
using DevExpress.DataAccess.ObjectBinding;

namespace ASC.Objects
{
	// Token: 0x02000894 RID: 2196
	[HighlightedClass]
	public class CartridgeIssueReport : BaseCartridgeReport
	{
		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x001056B0 File Offset: 0x001038B0
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x001056C4 File Offset: 0x001038C4
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

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x001056D8 File Offset: 0x001038D8
		// (set) Token: 0x060042B6 RID: 17078 RVA: 0x001056EC File Offset: 0x001038EC
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

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060042B7 RID: 17079 RVA: 0x00105700 File Offset: 0x00103900
		// (set) Token: 0x060042B8 RID: 17080 RVA: 0x00105714 File Offset: 0x00103914
		public List<CartridgeEx> Cartridges
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

		// Token: 0x060042B9 RID: 17081 RVA: 0x00105728 File Offset: 0x00103928
		public CartridgeIssueReport()
		{
			Localization localization = new Localization("UTC");
			base.Date = localization.Now;
			this.Cartridges = new List<CartridgeEx>();
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00105760 File Offset: 0x00103960
		public override void ConstrunctNum()
		{
			int num = this.Cartridges.Min((CartridgeEx c) => c.Id);
			int count = this.Cartridges.Count;
			if (count == 1)
			{
				base.Num = string.Format("{0:d6}", num);
				return;
			}
			base.Num = string.Format("{0:d6}/{1}", num, count);
		}

		// Token: 0x04002B20 RID: 11040
		[CompilerGenerated]
		private companies <Company>k__BackingField;

		// Token: 0x04002B21 RID: 11041
		[CompilerGenerated]
		private offices <Office>k__BackingField;

		// Token: 0x04002B22 RID: 11042
		[CompilerGenerated]
		private List<CartridgeEx> <Cartridges>k__BackingField;

		// Token: 0x02000895 RID: 2197
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060042BB RID: 17083 RVA: 0x001057DC File Offset: 0x001039DC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060042BC RID: 17084 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060042BD RID: 17085 RVA: 0x0007933C File Offset: 0x0007753C
			internal int <ConstrunctNum>b__13_0(CartridgeEx c)
			{
				return c.Id;
			}

			// Token: 0x04002B23 RID: 11043
			public static readonly CartridgeIssueReport.<>c <>9 = new CartridgeIssueReport.<>c();

			// Token: 0x04002B24 RID: 11044
			public static Func<CartridgeEx, int> <>9__13_0;
		}
	}
}
