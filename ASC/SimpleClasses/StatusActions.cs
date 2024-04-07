using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000214 RID: 532
	public class StatusActions
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00052FE0 File Offset: 0x000511E0
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00052FF4 File Offset: 0x000511F4
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

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00053008 File Offset: 0x00051208
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0005301C File Offset: 0x0005121C
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00053030 File Offset: 0x00051230
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00053044 File Offset: 0x00051244
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

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00053058 File Offset: 0x00051258
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x0005306C File Offset: 0x0005126C
		public string Color
		{
			[CompilerGenerated]
			get
			{
				return this.<Color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Color>k__BackingField = value;
			}
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00053080 File Offset: 0x00051280
		public StatusActions(int type, int id, string name, string color = null)
		{
			this.Type = type;
			this.Id = id;
			this.Name = name;
			this.Color = this.Color;
		}

		// Token: 0x04000EDE RID: 3806
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04000EDF RID: 3807
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04000EE0 RID: 3808
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000EE1 RID: 3809
		[CompilerGenerated]
		private string <Color>k__BackingField;

		// Token: 0x02000215 RID: 533
		public enum Types
		{
			// Token: 0x04000EE3 RID: 3811
			Action,
			// Token: 0x04000EE4 RID: 3812
			Sms
		}
	}
}
