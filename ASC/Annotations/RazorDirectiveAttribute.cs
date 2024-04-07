using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x02000109 RID: 265
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RazorDirectiveAttribute : Attribute
	{
		// Token: 0x06001427 RID: 5159 RVA: 0x0002C16C File Offset: 0x0002A36C
		public RazorDirectiveAttribute([NotNull] string directive)
		{
			this.Directive = directive;
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0002C188 File Offset: 0x0002A388
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0002C19C File Offset: 0x0002A39C
		[NotNull]
		public string Directive
		{
			[CompilerGenerated]
			get
			{
				return this.<Directive>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Directive>k__BackingField = value;
			}
		}

		// Token: 0x040009AD RID: 2477
		[CompilerGenerated]
		private string <Directive>k__BackingField;
	}
}
