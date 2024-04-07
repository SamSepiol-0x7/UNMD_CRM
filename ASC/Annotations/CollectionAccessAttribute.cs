using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000F6 RID: 246
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class CollectionAccessAttribute : Attribute
	{
		// Token: 0x06001404 RID: 5124 RVA: 0x0002BF30 File Offset: 0x0002A130
		public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
		{
			this.CollectionAccessType = collectionAccessType;
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0002BF4C File Offset: 0x0002A14C
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0002BF60 File Offset: 0x0002A160
		public CollectionAccessType CollectionAccessType
		{
			[CompilerGenerated]
			get
			{
				return this.<CollectionAccessType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<CollectionAccessType>k__BackingField = value;
			}
		}

		// Token: 0x0400099A RID: 2458
		[CompilerGenerated]
		private CollectionAccessType <CollectionAccessType>k__BackingField;
	}
}
