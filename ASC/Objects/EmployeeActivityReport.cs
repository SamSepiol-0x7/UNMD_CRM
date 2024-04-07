using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x0200087C RID: 2172
	public class EmployeeActivityReport : BindableBase
	{
		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x0010209C File Offset: 0x0010029C
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x001020B0 File Offset: 0x001002B0
		public Employee Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Employee>k__BackingField, value))
				{
					return;
				}
				this.<Employee>k__BackingField = value;
				this.RaisePropertyChanged("Employee");
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x001020E0 File Offset: 0x001002E0
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x001020F4 File Offset: 0x001002F4
		public bool IsOnline
		{
			[CompilerGenerated]
			get
			{
				return this.<IsOnline>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsOnline>k__BackingField == value)
				{
					return;
				}
				this.<IsOnline>k__BackingField = value;
				this.RaisePropertyChanged("IsOnline");
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x00102120 File Offset: 0x00100320
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x00102134 File Offset: 0x00100334
		public string Ip
		{
			[CompilerGenerated]
			get
			{
				return this.<Ip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Ip>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Ip>k__BackingField = value;
				this.RaisePropertyChanged("Ip");
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x00102164 File Offset: 0x00100364
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x00102178 File Offset: 0x00100378
		public List<UsersActivity> Activity
		{
			[CompilerGenerated]
			get
			{
				return this.<Activity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Activity>k__BackingField, value))
				{
					return;
				}
				this.<Activity>k__BackingField = value;
				this.RaisePropertyChanged("Activity");
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x001021A8 File Offset: 0x001003A8
		// (set) Token: 0x06004133 RID: 16691 RVA: 0x001021BC File Offset: 0x001003BC
		public List<int> ActivityCount
		{
			[CompilerGenerated]
			get
			{
				return this.<ActivityCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ActivityCount>k__BackingField, value))
				{
					return;
				}
				this.<ActivityCount>k__BackingField = value;
				this.RaisePropertyChanged("ActivityCount");
			}
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x001021EC File Offset: 0x001003EC
		public EmployeeActivityReport()
		{
			this.Activity = new List<UsersActivity>();
			this.ActivityCount = new List<int>();
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00102218 File Offset: 0x00100418
		public void SetActivity(IPeriod period, List<UsersActivity> value)
		{
			this.Activity = value;
			using (IEnumerator<DateTime> enumerator = period.EachDay().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DateTime dateTime = enumerator.Current;
					int item = value.Count((UsersActivity a) => a.DateTime.Date == dateTime.Date);
					this.ActivityCount.Add(item);
				}
			}
			UsersActivity usersActivity = value.LastOrDefault<UsersActivity>();
			if (usersActivity != null)
			{
				this.Ip = usersActivity.Ip;
			}
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x001022A8 File Offset: 0x001004A8
		public void SetIsOnline(DateTime now)
		{
			if ((this.Employee.LastActivity != null && (now - this.Employee.LastActivity.Value).TotalSeconds <= 60.0) || this.Employee.Id == OfflineData.Instance.Employee.Id)
			{
				this.IsOnline = true;
			}
		}

		// Token: 0x04002A6F RID: 10863
		[CompilerGenerated]
		private Employee <Employee>k__BackingField;

		// Token: 0x04002A70 RID: 10864
		[CompilerGenerated]
		private bool <IsOnline>k__BackingField;

		// Token: 0x04002A71 RID: 10865
		[CompilerGenerated]
		private string <Ip>k__BackingField;

		// Token: 0x04002A72 RID: 10866
		[CompilerGenerated]
		private List<UsersActivity> <Activity>k__BackingField;

		// Token: 0x04002A73 RID: 10867
		[CompilerGenerated]
		private List<int> <ActivityCount>k__BackingField;

		// Token: 0x0200087D RID: 2173
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06004137 RID: 16695 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06004138 RID: 16696 RVA: 0x0010231C File Offset: 0x0010051C
			internal bool <SetActivity>b__0(UsersActivity a)
			{
				return a.DateTime.Date == this.dateTime.Date;
			}

			// Token: 0x04002A74 RID: 10868
			public DateTime dateTime;
		}
	}
}
