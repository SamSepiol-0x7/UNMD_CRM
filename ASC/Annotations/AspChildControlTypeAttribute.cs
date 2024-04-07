using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x02000101 RID: 257
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class AspChildControlTypeAttribute : Attribute
	{
		// Token: 0x06001411 RID: 5137 RVA: 0x0002BFB8 File Offset: 0x0002A1B8
		public AspChildControlTypeAttribute([NotNull] string tagName, [NotNull] Type controlType)
		{
			this.TagName = tagName;
			this.ControlType = controlType;
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0002BFF0 File Offset: 0x0002A1F0
		[NotNull]
		public string TagName
		{
			[CompilerGenerated]
			get
			{
				return this.<TagName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<TagName>k__BackingField = value;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0002C004 File Offset: 0x0002A204
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0002C018 File Offset: 0x0002A218
		[NotNull]
		public Type ControlType
		{
			[CompilerGenerated]
			get
			{
				return this.<ControlType>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ControlType>k__BackingField = value;
			}
		}

		// Token: 0x040009A6 RID: 2470
		[CompilerGenerated]
		private string <TagName>k__BackingField;

		// Token: 0x040009A7 RID: 2471
		[CompilerGenerated]
		private Type <ControlType>k__BackingField;
	}
}
