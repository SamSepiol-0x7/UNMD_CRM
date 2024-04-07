using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x02000108 RID: 264
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RazorInjectionAttribute : Attribute
	{
		// Token: 0x06001422 RID: 5154 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
		{
			this.Type = type;
			this.FieldName = fieldName;
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0002C11C File Offset: 0x0002A31C
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x0002C130 File Offset: 0x0002A330
		[NotNull]
		public string Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0002C144 File Offset: 0x0002A344
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0002C158 File Offset: 0x0002A358
		[NotNull]
		public string FieldName
		{
			[CompilerGenerated]
			get
			{
				return this.<FieldName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<FieldName>k__BackingField = value;
			}
		}

		// Token: 0x040009AB RID: 2475
		[CompilerGenerated]
		private string <Type>k__BackingField;

		// Token: 0x040009AC RID: 2476
		[CompilerGenerated]
		private string <FieldName>k__BackingField;
	}
}
