using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008F5 RID: 2293
	public class Result<T> : Result, IAscResult<T>, IAscResult
	{
		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x00116068 File Offset: 0x00114268
		// (set) Token: 0x06004756 RID: 18262 RVA: 0x0011607C File Offset: 0x0011427C
		public T Object
		{
			[CompilerGenerated]
			get
			{
				return this.<Object>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Object>k__BackingField = value;
			}
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x00116090 File Offset: 0x00114290
		public Result()
		{
		}

		// Token: 0x04002DBE RID: 11710
		[CompilerGenerated]
		private T <Object>k__BackingField;
	}
}
