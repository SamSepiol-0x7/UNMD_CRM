using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x0200021E RID: 542
	public class ClientIdPhones
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x000546A8 File Offset: 0x000528A8
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x000546BC File Offset: 0x000528BC
		public int ClientId
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientId>k__BackingField = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x000546D0 File Offset: 0x000528D0
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x000546E4 File Offset: 0x000528E4
		public string Phone
		{
			[CompilerGenerated]
			get
			{
				return this.<Phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Phone>k__BackingField = value;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x000546F8 File Offset: 0x000528F8
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0005470C File Offset: 0x0005290C
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

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00054720 File Offset: 0x00052920
		public string FioOrUrName
		{
			get
			{
				if (this.Type != 1)
				{
					return string.Concat(new string[]
					{
						this.LastName,
						" ",
						this.Name,
						" ",
						this.Patronymic
					});
				}
				return this.UrName;
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000046B4 File Offset: 0x000028B4
		public ClientIdPhones()
		{
		}

		// Token: 0x04000F3E RID: 3902
		[CompilerGenerated]
		private int <ClientId>k__BackingField;

		// Token: 0x04000F3F RID: 3903
		[CompilerGenerated]
		private string <Phone>k__BackingField;

		// Token: 0x04000F40 RID: 3904
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04000F41 RID: 3905
		public string UrName;

		// Token: 0x04000F42 RID: 3906
		public string LastName;

		// Token: 0x04000F43 RID: 3907
		public string Name;

		// Token: 0x04000F44 RID: 3908
		public string Patronymic;
	}
}
