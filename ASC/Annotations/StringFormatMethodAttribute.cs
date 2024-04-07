using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000CB RID: 203
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
	public sealed class StringFormatMethodAttribute : Attribute
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x0002B794 File Offset: 0x00029994
		public StringFormatMethodAttribute([NotNull] string formatParameterName)
		{
			this.FormatParameterName = formatParameterName;
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0002B7B0 File Offset: 0x000299B0
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x0002B7C4 File Offset: 0x000299C4
		[NotNull]
		public string FormatParameterName
		{
			[CompilerGenerated]
			get
			{
				return this.<FormatParameterName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<FormatParameterName>k__BackingField = value;
			}
		}

		// Token: 0x04000973 RID: 2419
		[CompilerGenerated]
		private string <FormatParameterName>k__BackingField;
	}
}
