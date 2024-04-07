using System;

namespace ASC.Annotations
{
	// Token: 0x020000D5 RID: 213
	[Flags]
	public enum ImplicitUseKindFlags
	{
		// Token: 0x0400097F RID: 2431
		Default = 7,
		// Token: 0x04000980 RID: 2432
		Access = 1,
		// Token: 0x04000981 RID: 2433
		Assign = 2,
		// Token: 0x04000982 RID: 2434
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x04000983 RID: 2435
		InstantiatedNoFixedConstructorSignature = 8
	}
}
