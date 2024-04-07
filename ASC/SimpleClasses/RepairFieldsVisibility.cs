using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ASC.SimpleClasses
{
	// Token: 0x0200020C RID: 524
	public class RepairFieldsVisibility
	{
		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00052450 File Offset: 0x00050650
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x00052464 File Offset: 0x00050664
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

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00052478 File Offset: 0x00050678
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0005248C File Offset: 0x0005068C
		public bool Visible
		{
			[CompilerGenerated]
			get
			{
				return this.<Visible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Visible>k__BackingField = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x000524A0 File Offset: 0x000506A0
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x000524B4 File Offset: 0x000506B4
		[JsonIgnore]
		public List<RepairFieldsVisibility> Visibility
		{
			[CompilerGenerated]
			get
			{
				return this.<Visibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Visibility>k__BackingField = value;
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000046B4 File Offset: 0x000028B4
		public RepairFieldsVisibility()
		{
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000524C8 File Offset: 0x000506C8
		public RepairFieldsVisibility(string name, bool isVisible)
		{
			this.Name = name;
			this.Visible = isVisible;
		}

		// Token: 0x04000EB6 RID: 3766
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000EB7 RID: 3767
		[CompilerGenerated]
		private bool <Visible>k__BackingField;

		// Token: 0x04000EB8 RID: 3768
		[CompilerGenerated]
		private List<RepairFieldsVisibility> <Visibility>k__BackingField;
	}
}
