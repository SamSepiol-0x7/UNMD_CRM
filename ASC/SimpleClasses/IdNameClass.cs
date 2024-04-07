using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.SimpleClasses
{
	// Token: 0x02000203 RID: 515
	public class IdNameClass : IIdName
	{
		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00051CDC File Offset: 0x0004FEDC
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x00051CF0 File Offset: 0x0004FEF0
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

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00051D04 File Offset: 0x0004FF04
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x00051D18 File Offset: 0x0004FF18
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

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000046B4 File Offset: 0x000028B4
		public IdNameClass()
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00051D2C File Offset: 0x0004FF2C
		public IdNameClass(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x04000E9E RID: 3742
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04000E9F RID: 3743
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
