using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x0200087F RID: 2175
	public class AscTask : BindableBase, ICheckFields, IAscTask
	{
		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x00102460 File Offset: 0x00100660
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x00102474 File Offset: 0x00100674
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
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x001024A0 File Offset: 0x001006A0
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x001024B4 File Offset: 0x001006B4
		public int TopEmployee
		{
			[CompilerGenerated]
			get
			{
				return this.<TopEmployee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TopEmployee>k__BackingField == value)
				{
					return;
				}
				this.<TopEmployee>k__BackingField = value;
				this.RaisePropertyChanged("TopEmployee");
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x001024E0 File Offset: 0x001006E0
		// (set) Token: 0x0600414D RID: 16717 RVA: 0x001024F4 File Offset: 0x001006F4
		public int? CreatorId
		{
			[CompilerGenerated]
			get
			{
				return this.<CreatorId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<CreatorId>k__BackingField, value))
				{
					return;
				}
				this.<CreatorId>k__BackingField = value;
				this.RaisePropertyChanged("CreatorId");
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x00102524 File Offset: 0x00100724
		// (set) Token: 0x0600414F RID: 16719 RVA: 0x00102538 File Offset: 0x00100738
		public List<int> ResponsibleUsers
		{
			[CompilerGenerated]
			get
			{
				return this.<ResponsibleUsers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ResponsibleUsers>k__BackingField, value))
				{
					return;
				}
				this.<ResponsibleUsers>k__BackingField = value;
				this.RaisePropertyChanged("ResponsibleUsers");
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06004150 RID: 16720 RVA: 0x00102568 File Offset: 0x00100768
		// (set) Token: 0x06004151 RID: 16721 RVA: 0x0010257C File Offset: 0x0010077C
		public DateTime Created
		{
			[CompilerGenerated]
			get
			{
				return this.<Created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Created>k__BackingField, value))
				{
					return;
				}
				this.<Created>k__BackingField = value;
				this.RaisePropertyChanged("Created");
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x001025AC File Offset: 0x001007AC
		// (set) Token: 0x06004153 RID: 16723 RVA: 0x001025C0 File Offset: 0x001007C0
		public DateTime Start
		{
			[CompilerGenerated]
			get
			{
				return this.<Start>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Start>k__BackingField, value))
				{
					return;
				}
				this.<Start>k__BackingField = value;
				this.RaisePropertyChanged("Start");
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x001025F0 File Offset: 0x001007F0
		// (set) Token: 0x06004155 RID: 16725 RVA: 0x00102604 File Offset: 0x00100804
		public TaskType Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Type>k__BackingField == value)
				{
					return;
				}
				this.<Type>k__BackingField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06004156 RID: 16726 RVA: 0x00102630 File Offset: 0x00100830
		// (set) Token: 0x06004157 RID: 16727 RVA: 0x00102644 File Offset: 0x00100844
		public AscTaskStatus Status
		{
			[CompilerGenerated]
			get
			{
				return this.<Status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Status>k__BackingField == value)
				{
					return;
				}
				this.<Status>k__BackingField = value;
				this.RaisePropertyChanged("Status");
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x00102670 File Offset: 0x00100870
		// (set) Token: 0x06004159 RID: 16729 RVA: 0x00102684 File Offset: 0x00100884
		public AscTaskPriority Priority
		{
			[CompilerGenerated]
			get
			{
				return this.<Priority>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Priority>k__BackingField == value)
				{
					return;
				}
				this.<Priority>k__BackingField = value;
				this.RaisePropertyChanged("Priority");
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x001026B0 File Offset: 0x001008B0
		// (set) Token: 0x0600415B RID: 16731 RVA: 0x001026C4 File Offset: 0x001008C4
		public string Subject
		{
			[CompilerGenerated]
			get
			{
				return this.<Subject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Subject>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Subject>k__BackingField = value;
				this.RaisePropertyChanged("Subject");
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x0600415C RID: 16732 RVA: 0x001026F4 File Offset: 0x001008F4
		// (set) Token: 0x0600415D RID: 16733 RVA: 0x00102708 File Offset: 0x00100908
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.<Message>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Message>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Message>k__BackingField = value;
				this.RaisePropertyChanged("Message");
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x00102738 File Offset: 0x00100938
		// (set) Token: 0x0600415F RID: 16735 RVA: 0x0010274C File Offset: 0x0010094C
		public int? RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<RepairId>k__BackingField, value))
				{
					return;
				}
				this.<RepairId>k__BackingField = value;
				this.RaisePropertyChanged("RepairId");
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x0010277C File Offset: 0x0010097C
		// (set) Token: 0x06004161 RID: 16737 RVA: 0x00102790 File Offset: 0x00100990
		public int? ItemId
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<ItemId>k__BackingField, value))
				{
					return;
				}
				this.<ItemId>k__BackingField = value;
				this.RaisePropertyChanged("ItemId");
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x001027C0 File Offset: 0x001009C0
		// (set) Token: 0x06004163 RID: 16739 RVA: 0x001027D4 File Offset: 0x001009D4
		public int? PartRequest
		{
			[CompilerGenerated]
			get
			{
				return this.<PartRequest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<PartRequest>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1571166439;
				IL_13:
				switch ((num ^ 1894019734) % 4)
				{
				case 0:
					IL_32:
					this.<PartRequest>k__BackingField = value;
					this.RaisePropertyChanged("PartRequest");
					num = 462177204;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x00102830 File Offset: 0x00100A30
		// (set) Token: 0x06004165 RID: 16741 RVA: 0x00102844 File Offset: 0x00100A44
		public int? DocumentId
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<DocumentId>k__BackingField, value))
				{
					return;
				}
				this.<DocumentId>k__BackingField = value;
				this.RaisePropertyChanged("DocumentId");
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x00102874 File Offset: 0x00100A74
		// (set) Token: 0x06004167 RID: 16743 RVA: 0x00102888 File Offset: 0x00100A88
		public int? MatchDevice
		{
			[CompilerGenerated]
			get
			{
				return this.<MatchDevice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<MatchDevice>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1262644072;
				IL_13:
				switch ((num ^ -1238252886) % 4)
				{
				case 1:
					IL_32:
					this.<MatchDevice>k__BackingField = value;
					this.RaisePropertyChanged("MatchDevice");
					num = -2089792554;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x001028E4 File Offset: 0x00100AE4
		// (set) Token: 0x06004169 RID: 16745 RVA: 0x001028F8 File Offset: 0x00100AF8
		public int? MatchMaker
		{
			[CompilerGenerated]
			get
			{
				return this.<MatchMaker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<MatchMaker>k__BackingField, value))
				{
					return;
				}
				this.<MatchMaker>k__BackingField = value;
				this.RaisePropertyChanged("MatchMaker");
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x00102928 File Offset: 0x00100B28
		// (set) Token: 0x0600416B RID: 16747 RVA: 0x0010293C File Offset: 0x00100B3C
		public string MatchText
		{
			[CompilerGenerated]
			get
			{
				return this.<MatchText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<MatchText>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MatchText>k__BackingField = value;
				this.RaisePropertyChanged("MatchText");
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x0010296C File Offset: 0x00100B6C
		// (set) Token: 0x0600416D RID: 16749 RVA: 0x00102980 File Offset: 0x00100B80
		public string Email
		{
			[CompilerGenerated]
			get
			{
				return this.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Email>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Email>k__BackingField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x001029B0 File Offset: 0x00100BB0
		// (set) Token: 0x0600416F RID: 16751 RVA: 0x001029C4 File Offset: 0x00100BC4
		public string Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Tel>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Tel>k__BackingField = value;
				this.RaisePropertyChanged("Tel");
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x001029F4 File Offset: 0x00100BF4
		// (set) Token: 0x06004171 RID: 16753 RVA: 0x00102A08 File Offset: 0x00100C08
		public int? CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<CustomerId>k__BackingField, value))
				{
					return;
				}
				this.<CustomerId>k__BackingField = value;
				this.RaisePropertyChanged("CustomerId");
			}
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00102A38 File Offset: 0x00100C38
		public AscTask()
		{
			this.ResponsibleUsers = new List<int>();
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00102A58 File Offset: 0x00100C58
		public void SetSubject(string value)
		{
			this.Subject = value;
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00102A6C File Offset: 0x00100C6C
		public void SetMessage(string value)
		{
			this.Message = this.Message + value + Environment.NewLine;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00102A90 File Offset: 0x00100C90
		public void ClearMessage()
		{
			this.Message = string.Empty;
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00102AA8 File Offset: 0x00100CA8
		public void SetEmail(string email)
		{
			this.Email = email;
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x00102ABC File Offset: 0x00100CBC
		public void SetTel(string tel)
		{
			this.Tel = tel;
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00102AD0 File Offset: 0x00100CD0
		public void AddResponsibleUser(int employeeId)
		{
			this.ResponsibleUsers.Add(employeeId);
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00102AEC File Offset: 0x00100CEC
		public void AddResponsibleUsers(IEnumerable<int> employeeIds)
		{
			foreach (int employeeId in employeeIds)
			{
				this.AddResponsibleUser(employeeId);
			}
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00102B38 File Offset: 0x00100D38
		public void SetDefaultValues()
		{
			this.Created = DateTime.UtcNow;
			this.Start = DateTime.UtcNow;
			this.Status = AscTaskStatus.Active;
			this.Priority = AscTaskPriority.Normal;
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00102B6C File Offset: 0x00100D6C
		public string CheckFields()
		{
			if (string.IsNullOrEmpty(this.Subject))
			{
				return "InputTaskSubject";
			}
			if (string.IsNullOrEmpty(this.Message))
			{
				return "InputTaskDescriptions";
			}
			if (!this.ResponsibleUsers.Any<int>())
			{
				return "InputTaskResponsibleUsers";
			}
			if (this.Type == TaskType.DeviceMatch)
			{
				if (this.MatchDevice == null)
				{
					return "SelectDevice";
				}
				if (this.MatchMaker == null)
				{
					return "SelectDeviceMaker";
				}
				if (string.IsNullOrEmpty(this.MatchText))
				{
					return "SelectDeviceModel";
				}
			}
			if (this.Start < this.Created)
			{
				return "CheckEventStartDate";
			}
			return "";
		}

		// Token: 0x04002A7C RID: 10876
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A7D RID: 10877
		[CompilerGenerated]
		private int <TopEmployee>k__BackingField;

		// Token: 0x04002A7E RID: 10878
		[CompilerGenerated]
		private int? <CreatorId>k__BackingField;

		// Token: 0x04002A7F RID: 10879
		[CompilerGenerated]
		private List<int> <ResponsibleUsers>k__BackingField;

		// Token: 0x04002A80 RID: 10880
		[CompilerGenerated]
		private DateTime <Created>k__BackingField;

		// Token: 0x04002A81 RID: 10881
		[CompilerGenerated]
		private DateTime <Start>k__BackingField;

		// Token: 0x04002A82 RID: 10882
		[CompilerGenerated]
		private TaskType <Type>k__BackingField;

		// Token: 0x04002A83 RID: 10883
		[CompilerGenerated]
		private AscTaskStatus <Status>k__BackingField;

		// Token: 0x04002A84 RID: 10884
		[CompilerGenerated]
		private AscTaskPriority <Priority>k__BackingField;

		// Token: 0x04002A85 RID: 10885
		[CompilerGenerated]
		private string <Subject>k__BackingField;

		// Token: 0x04002A86 RID: 10886
		[CompilerGenerated]
		private string <Message>k__BackingField;

		// Token: 0x04002A87 RID: 10887
		[CompilerGenerated]
		private int? <RepairId>k__BackingField;

		// Token: 0x04002A88 RID: 10888
		[CompilerGenerated]
		private int? <ItemId>k__BackingField;

		// Token: 0x04002A89 RID: 10889
		[CompilerGenerated]
		private int? <PartRequest>k__BackingField;

		// Token: 0x04002A8A RID: 10890
		[CompilerGenerated]
		private int? <DocumentId>k__BackingField;

		// Token: 0x04002A8B RID: 10891
		[CompilerGenerated]
		private int? <MatchDevice>k__BackingField;

		// Token: 0x04002A8C RID: 10892
		[CompilerGenerated]
		private int? <MatchMaker>k__BackingField;

		// Token: 0x04002A8D RID: 10893
		[CompilerGenerated]
		private string <MatchText>k__BackingField;

		// Token: 0x04002A8E RID: 10894
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x04002A8F RID: 10895
		[CompilerGenerated]
		private string <Tel>k__BackingField;

		// Token: 0x04002A90 RID: 10896
		[CompilerGenerated]
		private int? <CustomerId>k__BackingField;
	}
}
