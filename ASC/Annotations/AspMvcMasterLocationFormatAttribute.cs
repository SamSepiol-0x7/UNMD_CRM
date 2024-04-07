using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000E2 RID: 226
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcMasterLocationFormatAttribute : Attribute
	{
		// Token: 0x060013DC RID: 5084 RVA: 0x0002BD10 File Offset: 0x00029F10
		public AspMvcMasterLocationFormatAttribute(string format)
		{
			this.Format = format;
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0002BD2C File Offset: 0x00029F2C
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x0002BD40 File Offset: 0x00029F40
		public string Format
		{
			[CompilerGenerated]
			get
			{
				return this.<Format>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Format>k__BackingField = value;
			}
		}

		// Token: 0x04000992 RID: 2450
		[CompilerGenerated]
		private string <Format>k__BackingField;
	}
}
