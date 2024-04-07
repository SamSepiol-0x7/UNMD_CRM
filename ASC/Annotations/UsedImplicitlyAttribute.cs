using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000D3 RID: 211
	[AttributeUsage(AttributeTargets.All)]
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x060013AC RID: 5036 RVA: 0x0002B988 File Offset: 0x00029B88
		public UsedImplicitlyAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0002B9B8 File Offset: 0x00029BB8
		public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0002B9D0 File Offset: 0x00029BD0
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0002B9F4 File Offset: 0x00029BF4
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0002BA08 File Offset: 0x00029C08
		public ImplicitUseKindFlags UseKindFlags
		{
			[CompilerGenerated]
			get
			{
				return this.<UseKindFlags>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<UseKindFlags>k__BackingField = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0002BA1C File Offset: 0x00029C1C
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0002BA30 File Offset: 0x00029C30
		public ImplicitUseTargetFlags TargetFlags
		{
			[CompilerGenerated]
			get
			{
				return this.<TargetFlags>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<TargetFlags>k__BackingField = value;
			}
		}

		// Token: 0x0400097A RID: 2426
		[CompilerGenerated]
		private ImplicitUseKindFlags <UseKindFlags>k__BackingField;

		// Token: 0x0400097B RID: 2427
		[CompilerGenerated]
		private ImplicitUseTargetFlags <TargetFlags>k__BackingField;
	}
}
