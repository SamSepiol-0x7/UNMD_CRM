using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ASC.SimpleClasses
{
	// Token: 0x020001FC RID: 508
	public class ExtensionActions
	{
		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00051748 File Offset: 0x0004F948
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0005175C File Offset: 0x0004F95C
		public int ActionId
		{
			[CompilerGenerated]
			get
			{
				return this.<ActionId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ActionId>k__BackingField = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x00051770 File Offset: 0x0004F970
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x00051784 File Offset: 0x0004F984
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

		// Token: 0x06001B98 RID: 7064 RVA: 0x000046B4 File Offset: 0x000028B4
		public ExtensionActions()
		{
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00051798 File Offset: 0x0004F998
		public ExtensionActions(int actionId)
		{
			this.ActionId = actionId;
			this.Name = this.GetNameById(actionId);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000517C0 File Offset: 0x0004F9C0
		public string GetNameById(int actionId)
		{
			switch (actionId)
			{
			case 2:
				return (string)Application.Current.TryFindResource("StartRecordCall");
			case 3:
				return (string)Application.Current.TryFindResource("PlayRecord");
			case 4:
				return (string)Application.Current.TryFindResource("SendToQueue");
			case 5:
				return (string)Application.Current.TryFindResource("SendToIntNumber");
			case 6:
				return (string)Application.Current.TryFindResource("HangUp");
			case 7:
				return "NoOp";
			case 8:
				return (string)Application.Current.TryFindResource("SaveSms");
			case 9:
				return (string)Application.Current.TryFindResource("SendToTrunk");
			case 10:
				return (string)Application.Current.TryFindResource("SendToDongle");
			case 12:
				return (string)Application.Current.TryFindResource("GotoIfTime");
			}
			return "";
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000518D0 File Offset: 0x0004FAD0
		public List<ExtensionActions> GetActions()
		{
			return new List<ExtensionActions>
			{
				new ExtensionActions
				{
					ActionId = 3,
					Name = this.GetNameById(3)
				},
				new ExtensionActions
				{
					ActionId = 4,
					Name = this.GetNameById(4)
				},
				new ExtensionActions
				{
					ActionId = 5,
					Name = this.GetNameById(5)
				},
				new ExtensionActions
				{
					ActionId = 2,
					Name = this.GetNameById(2)
				},
				new ExtensionActions
				{
					ActionId = 9,
					Name = this.GetNameById(9)
				},
				new ExtensionActions
				{
					ActionId = 8,
					Name = this.GetNameById(8)
				},
				new ExtensionActions
				{
					ActionId = 6,
					Name = this.GetNameById(6)
				},
				new ExtensionActions
				{
					ActionId = 10,
					Name = this.GetNameById(10)
				},
				new ExtensionActions
				{
					ActionId = 12,
					Name = this.GetNameById(12)
				}
			};
		}

		// Token: 0x04000E81 RID: 3713
		[CompilerGenerated]
		private int <ActionId>k__BackingField;

		// Token: 0x04000E82 RID: 3714
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x020001FD RID: 509
		public enum Actions
		{
			// Token: 0x04000E84 RID: 3716
			PrepareRecordCall = 1,
			// Token: 0x04000E85 RID: 3717
			RecordCall,
			// Token: 0x04000E86 RID: 3718
			PlayFile,
			// Token: 0x04000E87 RID: 3719
			SendToQueue,
			// Token: 0x04000E88 RID: 3720
			SendToIntNumber,
			// Token: 0x04000E89 RID: 3721
			HangUp,
			// Token: 0x04000E8A RID: 3722
			NoOp,
			// Token: 0x04000E8B RID: 3723
			SaveSms,
			// Token: 0x04000E8C RID: 3724
			SendToTrunk,
			// Token: 0x04000E8D RID: 3725
			SendToDongle,
			// Token: 0x04000E8E RID: 3726
			Answer,
			// Token: 0x04000E8F RID: 3727
			GotoIfTime
		}
	}
}
