using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000200 RID: 512
	public class ValidationResult
	{
		// Token: 0x06001BA7 RID: 7079 RVA: 0x00051B08 File Offset: 0x0004FD08
		public ValidationResult(bool isValid, string additionalInfo, string a)
		{
			this.IsValid = isValid;
			this.AdditionalInfo = additionalInfo;
			this.Checksum = a;
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00051B30 File Offset: 0x0004FD30
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00051B44 File Offset: 0x0004FD44
		public bool IsValid
		{
			[CompilerGenerated]
			get
			{
				return this.<IsValid>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<IsValid>k__BackingField = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00051B58 File Offset: 0x0004FD58
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x00051B6C File Offset: 0x0004FD6C
		public string AdditionalInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<AdditionalInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00051B80 File Offset: 0x0004FD80
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x00051B94 File Offset: 0x0004FD94
		public string Checksum
		{
			[CompilerGenerated]
			get
			{
				return this.<Checksum>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Checksum>k__BackingField = value;
			}
		}

		// Token: 0x04000E94 RID: 3732
		[CompilerGenerated]
		private bool <IsValid>k__BackingField;

		// Token: 0x04000E95 RID: 3733
		[CompilerGenerated]
		private string <AdditionalInfo>k__BackingField;

		// Token: 0x04000E96 RID: 3734
		[CompilerGenerated]
		private string <Checksum>k__BackingField;
	}
}
