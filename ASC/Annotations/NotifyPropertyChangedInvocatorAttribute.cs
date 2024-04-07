using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000CE RID: 206
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
	{
		// Token: 0x0600139A RID: 5018 RVA: 0x0002B780 File Offset: 0x00029980
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0002B81C File Offset: 0x00029A1C
		public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0002B838 File Offset: 0x00029A38
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x0002B84C File Offset: 0x00029A4C
		[CanBeNull]
		public string ParameterName
		{
			[CompilerGenerated]
			get
			{
				return this.<ParameterName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ParameterName>k__BackingField = value;
			}
		}

		// Token: 0x04000975 RID: 2421
		[CompilerGenerated]
		private string <ParameterName>k__BackingField;
	}
}
