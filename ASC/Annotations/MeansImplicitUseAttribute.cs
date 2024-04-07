using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000D4 RID: 212
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x060013B4 RID: 5044 RVA: 0x0002BA44 File Offset: 0x00029C44
		public MeansImplicitUseAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0002BA5C File Offset: 0x00029C5C
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0002BA74 File Offset: 0x00029C74
		public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0002BA8C File Offset: 0x00029C8C
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0002BAB0 File Offset: 0x00029CB0
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x0002BAC4 File Offset: 0x00029CC4
		[UsedImplicitly]
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

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0002BAD8 File Offset: 0x00029CD8
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x0002BAEC File Offset: 0x00029CEC
		[UsedImplicitly]
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

		// Token: 0x0400097C RID: 2428
		[CompilerGenerated]
		private ImplicitUseKindFlags <UseKindFlags>k__BackingField;

		// Token: 0x0400097D RID: 2429
		[CompilerGenerated]
		private ImplicitUseTargetFlags <TargetFlags>k__BackingField;
	}
}
