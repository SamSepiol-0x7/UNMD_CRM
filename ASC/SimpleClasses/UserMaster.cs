using System;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000226 RID: 550
	public class UserMaster
	{
		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00055D60 File Offset: 0x00053F60
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x00055D74 File Offset: 0x00053F74
		public int RoleId
		{
			[CompilerGenerated]
			get
			{
				return this.<RoleId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RoleId>k__BackingField = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00055D88 File Offset: 0x00053F88
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x00055D9C File Offset: 0x00053F9C
		public int Uid
		{
			[CompilerGenerated]
			get
			{
				return this.<Uid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Uid>k__BackingField = value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00055DB0 File Offset: 0x00053FB0
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x00055DC4 File Offset: 0x00053FC4
		public string Username
		{
			[CompilerGenerated]
			get
			{
				return this.<Username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Username>k__BackingField = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00055DD8 File Offset: 0x00053FD8
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00055DEC File Offset: 0x00053FEC
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

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00055E00 File Offset: 0x00054000
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00055E14 File Offset: 0x00054014
		public string Surname
		{
			[CompilerGenerated]
			get
			{
				return this.<Surname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Surname>k__BackingField = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00055E28 File Offset: 0x00054028
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00055E3C File Offset: 0x0005403C
		public string Patronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<Patronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Patronymic>k__BackingField = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00055E50 File Offset: 0x00054050
		public string Fio
		{
			get
			{
				return string.Concat(new string[]
				{
					this.Surname,
					" ",
					this.Name,
					" ",
					this.Patronymic
				});
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00055E94 File Offset: 0x00054094
		public string FioShort
		{
			get
			{
				if (!string.IsNullOrEmpty(this.Name))
				{
					goto IL_59;
				}
				string text = "";
				IL_2B:
				string text2 = text;
				string text3;
				if (string.IsNullOrEmpty(this.Patronymic))
				{
					text3 = "";
					goto IL_7E;
				}
				int num = 485398258;
				IL_3E:
				switch ((num ^ 870786840) % 3)
				{
				case 0:
					IL_59:
					num = 1364916249;
					goto IL_3E;
				case 1:
					text = this.Name.Substring(0, 1) + ".";
					goto IL_2B;
				}
				text3 = this.Patronymic.Substring(0, 1) + ".";
				IL_7E:
				string text4 = text3;
				return string.Concat(new string[]
				{
					this.Surname,
					" ",
					text2,
					" ",
					text4
				});
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000046B4 File Offset: 0x000028B4
		public UserMaster()
		{
		}

		// Token: 0x04000F8C RID: 3980
		[CompilerGenerated]
		private int <RoleId>k__BackingField;

		// Token: 0x04000F8D RID: 3981
		[CompilerGenerated]
		private int <Uid>k__BackingField;

		// Token: 0x04000F8E RID: 3982
		[CompilerGenerated]
		private string <Username>k__BackingField;

		// Token: 0x04000F8F RID: 3983
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04000F90 RID: 3984
		[CompilerGenerated]
		private string <Surname>k__BackingField;

		// Token: 0x04000F91 RID: 3985
		[CompilerGenerated]
		private string <Patronymic>k__BackingField;
	}
}
