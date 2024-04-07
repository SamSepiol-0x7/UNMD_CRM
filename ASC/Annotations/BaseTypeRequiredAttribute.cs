using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000D2 RID: 210
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[BaseTypeRequired(typeof(Attribute))]
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x0002B944 File Offset: 0x00029B44
		public BaseTypeRequiredAttribute([NotNull] Type baseType)
		{
			this.BaseType = baseType;
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0002B960 File Offset: 0x00029B60
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0002B974 File Offset: 0x00029B74
		[NotNull]
		public Type BaseType
		{
			[CompilerGenerated]
			get
			{
				return this.<BaseType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<BaseType>k__BackingField = value;
			}
		}

		// Token: 0x04000979 RID: 2425
		[CompilerGenerated]
		private Type <BaseType>k__BackingField;
	}
}
