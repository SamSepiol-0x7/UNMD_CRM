using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000D0 RID: 208
	[AttributeUsage(AttributeTargets.All)]
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		// Token: 0x060013A4 RID: 5028 RVA: 0x0002B8EC File Offset: 0x00029AEC
		public LocalizationRequiredAttribute() : this(true)
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0002B900 File Offset: 0x00029B00
		public LocalizationRequiredAttribute(bool required)
		{
			this.Required = required;
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0002B91C File Offset: 0x00029B1C
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0002B930 File Offset: 0x00029B30
		public bool Required
		{
			[CompilerGenerated]
			get
			{
				return this.<Required>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Required>k__BackingField = value;
			}
		}

		// Token: 0x04000978 RID: 2424
		[CompilerGenerated]
		private bool <Required>k__BackingField;
	}
}
