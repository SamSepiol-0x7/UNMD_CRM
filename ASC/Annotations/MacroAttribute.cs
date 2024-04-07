using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000DE RID: 222
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
	public sealed class MacroAttribute : Attribute
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0002BBCC File Offset: 0x00029DCC
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x0002BBE0 File Offset: 0x00029DE0
		public string Expression
		{
			[CompilerGenerated]
			get
			{
				return this.<Expression>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Expression>k__BackingField = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0002BBF4 File Offset: 0x00029DF4
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x0002BC08 File Offset: 0x00029E08
		public int Editable
		{
			[CompilerGenerated]
			get
			{
				return this.<Editable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Editable>k__BackingField = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0002BC1C File Offset: 0x00029E1C
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0002BC30 File Offset: 0x00029E30
		public string Target
		{
			[CompilerGenerated]
			get
			{
				return this.<Target>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Target>k__BackingField = value;
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0002B780 File Offset: 0x00029980
		public MacroAttribute()
		{
		}

		// Token: 0x0400098C RID: 2444
		[CompilerGenerated]
		private string <Expression>k__BackingField;

		// Token: 0x0400098D RID: 2445
		[CompilerGenerated]
		private int <Editable>k__BackingField;

		// Token: 0x0400098E RID: 2446
		[CompilerGenerated]
		private string <Target>k__BackingField;
	}
}
