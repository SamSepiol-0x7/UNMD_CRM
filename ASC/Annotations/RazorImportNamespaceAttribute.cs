using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x02000107 RID: 263
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RazorImportNamespaceAttribute : Attribute
	{
		// Token: 0x0600141F RID: 5151 RVA: 0x0002C0B4 File Offset: 0x0002A2B4
		public RazorImportNamespaceAttribute([NotNull] string name)
		{
			this.Name = name;
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
		[NotNull]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x040009AA RID: 2474
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
