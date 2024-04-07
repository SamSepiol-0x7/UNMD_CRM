using System;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000026 RID: 38
	public class additional_payments : BindableBase
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000069CC File Offset: 0x00004BCC
		// (set) Token: 0x0600016E RID: 366 RVA: 0x000069E0 File Offset: 0x00004BE0
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<id>k__BackingField == value)
				{
					return;
				}
				this.<id>k__BackingField = value;
				this.RaisePropertyChanged("id");
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00006A0C File Offset: 0x00004C0C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00006A20 File Offset: 0x00004C20
		public string name
		{
			[CompilerGenerated]
			get
			{
				return this.<name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<name>k__BackingField = value;
				this.RaisePropertyChanged("name");
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006A50 File Offset: 0x00004C50
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00006A64 File Offset: 0x00004C64
		public DateTime payment_date
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<payment_date>k__BackingField, value))
				{
					return;
				}
				this.<payment_date>k__BackingField = value;
				this.RaisePropertyChanged("payment_date");
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00006A94 File Offset: 0x00004C94
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00006AA8 File Offset: 0x00004CA8
		public int user
		{
			[CompilerGenerated]
			get
			{
				return this.<user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<user>k__BackingField == value)
				{
					return;
				}
				this.<user>k__BackingField = value;
				this.RaisePropertyChanged("user");
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00006AD4 File Offset: 0x00004CD4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00006AE8 File Offset: 0x00004CE8
		public int to_user
		{
			[CompilerGenerated]
			get
			{
				return this.<to_user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<to_user>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1324756033;
				IL_10:
				switch ((num ^ 1656281102) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<to_user>k__BackingField = value;
					num = 974368363;
					goto IL_10;
				case 3:
					return;
				}
				this.RaisePropertyChanged("to_user");
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00006B40 File Offset: 0x00004D40
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00006B54 File Offset: 0x00004D54
		public decimal price
		{
			[CompilerGenerated]
			get
			{
				return this.<price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<price>k__BackingField, value))
				{
					return;
				}
				this.<price>k__BackingField = value;
				this.RaisePropertyChanged("price");
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00006B84 File Offset: 0x00004D84
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00006B98 File Offset: 0x00004D98
		public virtual users users
		{
			[CompilerGenerated]
			get
			{
				return this.<users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<users>k__BackingField, value))
				{
					return;
				}
				this.<users>k__BackingField = value;
				this.RaisePropertyChanged("UserFio");
				this.RaisePropertyChanged("users");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00006BD4 File Offset: 0x00004DD4
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00006BE8 File Offset: 0x00004DE8
		public virtual users users1
		{
			[CompilerGenerated]
			get
			{
				return this.<users1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<users1>k__BackingField, value))
				{
					return;
				}
				this.<users1>k__BackingField = value;
				this.RaisePropertyChanged("users1");
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00006C18 File Offset: 0x00004E18
		public virtual string UserFio
		{
			get
			{
				string[] array = new string[5];
				int num = 0;
				users users = this.users;
				array[num] = ((users != null) ? users.surname : null);
				array[1] = " ";
				int num2 = 2;
				users users2 = this.users;
				array[num2] = ((users2 != null) ? users2.name : null);
				array[3] = " ";
				int num3 = 4;
				users users3 = this.users;
				array[num3] = ((users3 != null) ? users3.patronymic : null);
				return string.Concat(array);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000069B8 File Offset: 0x00004BB8
		public additional_payments()
		{
		}

		// Token: 0x040000A8 RID: 168
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040000A9 RID: 169
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x040000AA RID: 170
		[CompilerGenerated]
		private DateTime <payment_date>k__BackingField;

		// Token: 0x040000AB RID: 171
		[CompilerGenerated]
		private int <user>k__BackingField;

		// Token: 0x040000AC RID: 172
		[CompilerGenerated]
		private int <to_user>k__BackingField;

		// Token: 0x040000AD RID: 173
		[CompilerGenerated]
		private decimal <price>k__BackingField;

		// Token: 0x040000AE RID: 174
		[CompilerGenerated]
		private users <users>k__BackingField;

		// Token: 0x040000AF RID: 175
		[CompilerGenerated]
		private users <users1>k__BackingField;
	}
}
