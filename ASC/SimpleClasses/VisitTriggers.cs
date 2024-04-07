using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000218 RID: 536
	public class VisitTriggers
	{
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00053380 File Offset: 0x00051580
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x00053394 File Offset: 0x00051594
		public int? Id
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

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x000533A8 File Offset: 0x000515A8
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x000533BC File Offset: 0x000515BC
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

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x000533D0 File Offset: 0x000515D0
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x000533E4 File Offset: 0x000515E4
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
		} = true;

		// Token: 0x06001C63 RID: 7267 RVA: 0x000533F8 File Offset: 0x000515F8
		public VisitTriggers()
		{
		}

		// Token: 0x04000EEE RID: 3822
		[CompilerGenerated]
		private int? <Id>k__BackingField;

		// Token: 0x04000EEF RID: 3823
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000EF0 RID: 3824
		[CompilerGenerated]
		private bool <Enable>k__BackingField;

		// Token: 0x02000219 RID: 537
		public enum Triggers
		{
			// Token: 0x04000EF2 RID: 3826
			WasInService = 1,
			// Token: 0x04000EF3 RID: 3827
			IsRegular,
			// Token: 0x04000EF4 RID: 3828
			ExistClient,
			// Token: 0x04000EF5 RID: 3829
			WarrantyRepair
		}
	}
}
