using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Common.Models;

namespace ASC.SimpleClasses
{
	// Token: 0x020001FA RID: 506
	public class ClientTypes : ICustomerType
	{
		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0005160C File Offset: 0x0004F80C
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x00051620 File Offset: 0x0004F820
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x00051634 File Offset: 0x0004F834
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x00051648 File Offset: 0x0004F848
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x0005165C File Offset: 0x0004F85C
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x00051670 File Offset: 0x0004F870
		public bool Enable
		{
			[CompilerGenerated]
			get
			{
				return this.<Enable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Enable>k__BackingField = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00051684 File Offset: 0x0004F884
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x00051698 File Offset: 0x0004F898
		public int EntitiesCount
		{
			[CompilerGenerated]
			get
			{
				return this.<EntitiesCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<EntitiesCount>k__BackingField = value;
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000046B4 File Offset: 0x000028B4
		public ClientTypes()
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000516AC File Offset: 0x0004F8AC
		public ClientTypes(CustomerModel.Type type, string name)
		{
			this.Id = (int)type;
			this.Name = name;
		}

		// Token: 0x04000E7A RID: 3706
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04000E7B RID: 3707
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000E7C RID: 3708
		[CompilerGenerated]
		private bool <Enable>k__BackingField;

		// Token: 0x04000E7D RID: 3709
		[CompilerGenerated]
		private int <EntitiesCount>k__BackingField;
	}
}
