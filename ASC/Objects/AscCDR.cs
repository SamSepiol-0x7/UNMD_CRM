using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Common.Phone;
using ASC.Objects.Converters;

namespace ASC.Objects
{
	// Token: 0x02000862 RID: 2146
	public class AscCDR : IAscCDR
	{
		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x000FE408 File Offset: 0x000FC608
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x000FE41C File Offset: 0x000FC61C
		public string CallId
		{
			[CompilerGenerated]
			get
			{
				return this.<CallId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CallId>k__BackingField = value;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x000FE430 File Offset: 0x000FC630
		// (set) Token: 0x06003F6D RID: 16237 RVA: 0x000FE444 File Offset: 0x000FC644
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
				this.<Start>k__BackingField = value;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x000FE458 File Offset: 0x000FC658
		// (set) Token: 0x06003F6F RID: 16239 RVA: 0x000FE46C File Offset: 0x000FC66C
		public int Duration
		{
			[CompilerGenerated]
			get
			{
				return this.<Duration>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Duration>k__BackingField = value;
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x000FE480 File Offset: 0x000FC680
		// (set) Token: 0x06003F71 RID: 16241 RVA: 0x000FE494 File Offset: 0x000FC694
		public bool IsIncoming
		{
			[CompilerGenerated]
			get
			{
				return this.<IsIncoming>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsIncoming>k__BackingField = value;
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06003F72 RID: 16242 RVA: 0x000FE4A8 File Offset: 0x000FC6A8
		// (set) Token: 0x06003F73 RID: 16243 RVA: 0x000FE4BC File Offset: 0x000FC6BC
		public bool IsRecorded
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRecorded>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsRecorded>k__BackingField = value;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x000FE4D0 File Offset: 0x000FC6D0
		// (set) Token: 0x06003F75 RID: 16245 RVA: 0x000FE4E4 File Offset: 0x000FC6E4
		public string Src
		{
			[CompilerGenerated]
			get
			{
				return this.<Src>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Src>k__BackingField = value;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x000FE4F8 File Offset: 0x000FC6F8
		public string SrcText
		{
			get
			{
				if (this.IsIncoming)
				{
					if (this.Customer != null)
					{
						return this.TwoLineText(this.Customer.FioOrUrName, this.Src);
					}
					return this.Src;
				}
				else
				{
					if (this.Employee == null)
					{
						return this.Src;
					}
					return this.TwoLineText(this.Employee.FioShort, this.Src);
				}
			}
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x000FE55C File Offset: 0x000FC75C
		private string TwoLineText(string line1, string line2)
		{
			return string.Concat(new string[]
			{
				line1,
				Environment.NewLine,
				"[",
				line2,
				"]"
			});
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x000FE594 File Offset: 0x000FC794
		public string DstText
		{
			get
			{
				if (this.IsIncoming)
				{
					if (this.Employee != null)
					{
						return this.TwoLineText(this.Employee.FioShort, this.Destination);
					}
					return this.Destination;
				}
				else
				{
					if (this.Customer != null)
					{
						return this.TwoLineText(this.Customer.FioOrUrName, this.Destination);
					}
					return this.Destination;
				}
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x000FE5F8 File Offset: 0x000FC7F8
		// (set) Token: 0x06003F7A RID: 16250 RVA: 0x000FE60C File Offset: 0x000FC80C
		public string Destination
		{
			[CompilerGenerated]
			get
			{
				return this.<Destination>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Destination>k__BackingField = value;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06003F7B RID: 16251 RVA: 0x000FE620 File Offset: 0x000FC820
		// (set) Token: 0x06003F7C RID: 16252 RVA: 0x000FE634 File Offset: 0x000FC834
		public string Disposition
		{
			[CompilerGenerated]
			get
			{
				return this.<Disposition>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Disposition>k__BackingField = value;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x000FE648 File Offset: 0x000FC848
		// (set) Token: 0x06003F7E RID: 16254 RVA: 0x000FE65C File Offset: 0x000FC85C
		public ICustomer Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Customer>k__BackingField = value;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x000FE670 File Offset: 0x000FC870
		// (set) Token: 0x06003F80 RID: 16256 RVA: 0x000FE684 File Offset: 0x000FC884
		public string Record
		{
			[CompilerGenerated]
			get
			{
				return this.<Record>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Record>k__BackingField = value;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x000FE698 File Offset: 0x000FC898
		// (set) Token: 0x06003F82 RID: 16258 RVA: 0x000FE6AC File Offset: 0x000FC8AC
		public IEmployee Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.<Employee>k__BackingField = value;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x000FE6C0 File Offset: 0x000FC8C0
		public string Direction
		{
			get
			{
				if (!this.IsIncoming)
				{
					return Lang.t("OutCall");
				}
				return Lang.t("InCall");
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x000FE6EC File Offset: 0x000FC8EC
		public string DurationText
		{
			get
			{
				TimeSpan value = TimeSpan.FromSeconds((double)this.Duration);
				return DateTime.Today.Add(value).ToString("mm:ss");
			}
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x000FE724 File Offset: 0x000FC924
		public void TryIdentityCustomer(IEnumerable<clients> customers)
		{
			string tel;
			Func<tel, bool> <>9__1;
			for (;;)
			{
				IL_7E:
				int num = -1641929046;
				for (;;)
				{
					switch ((num ^ -2117858044) % 4)
					{
					case 0:
						goto IL_7E;
					case 2:
					{
						tel = (this.IsIncoming ? Phone.ClearPhoneString(this.Src) : Phone.ClearPhoneString(this.Destination));
						clients clients = customers.FirstOrDefault(delegate(clients cu)
						{
							IEnumerable<tel> tel = cu.tel;
							Func<tel, bool> predicate;
							if ((predicate = <>9__1) == null)
							{
								predicate = (<>9__1 = ((tel t) => t.phone_clean.Equals(tel)));
							}
							return tel.Any(predicate);
						});
						num = -653933677;
						continue;
					}
					case 3:
					{
						clients clients;
						this.Customer = ((clients == null) ? null : clients.Client2Customer());
						num = -2111743335;
						continue;
					}
					}
					return;
				}
			}
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x000FE7B8 File Offset: 0x000FC9B8
		public void TryIdentityEmployee(IEnumerable<IEmployee> employees)
		{
			string tel = this.IsIncoming ? this.Destination : this.Src;
			this.Employee = employees.FirstOrDefault((IEmployee i) => i.Tel.ToString() == tel);
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x000046B4 File Offset: 0x000028B4
		public AscCDR()
		{
		}

		// Token: 0x040029BE RID: 10686
		[CompilerGenerated]
		private string <CallId>k__BackingField;

		// Token: 0x040029BF RID: 10687
		[CompilerGenerated]
		private DateTime <Start>k__BackingField;

		// Token: 0x040029C0 RID: 10688
		[CompilerGenerated]
		private int <Duration>k__BackingField;

		// Token: 0x040029C1 RID: 10689
		[CompilerGenerated]
		private bool <IsIncoming>k__BackingField;

		// Token: 0x040029C2 RID: 10690
		[CompilerGenerated]
		private bool <IsRecorded>k__BackingField;

		// Token: 0x040029C3 RID: 10691
		[CompilerGenerated]
		private string <Src>k__BackingField;

		// Token: 0x040029C4 RID: 10692
		[CompilerGenerated]
		private string <Destination>k__BackingField;

		// Token: 0x040029C5 RID: 10693
		[CompilerGenerated]
		private string <Disposition>k__BackingField;

		// Token: 0x040029C6 RID: 10694
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;

		// Token: 0x040029C7 RID: 10695
		[CompilerGenerated]
		private string <Record>k__BackingField;

		// Token: 0x040029C8 RID: 10696
		[CompilerGenerated]
		private IEmployee <Employee>k__BackingField;

		// Token: 0x02000863 RID: 2147
		[CompilerGenerated]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06003F88 RID: 16264 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x06003F89 RID: 16265 RVA: 0x000FE800 File Offset: 0x000FCA00
			internal bool <TryIdentityCustomer>b__0(clients cu)
			{
				IEnumerable<tel> source = cu.tel;
				Func<tel, bool> predicate;
				if ((predicate = this.<>9__1) == null)
				{
					predicate = (this.<>9__1 = ((tel t) => t.phone_clean.Equals(this.tel)));
				}
				return source.Any(predicate);
			}

			// Token: 0x06003F8A RID: 16266 RVA: 0x000FE838 File Offset: 0x000FCA38
			internal bool <TryIdentityCustomer>b__1(tel t)
			{
				return t.phone_clean.Equals(this.tel);
			}

			// Token: 0x040029C9 RID: 10697
			public string tel;

			// Token: 0x040029CA RID: 10698
			public Func<tel, bool> <>9__1;
		}

		// Token: 0x02000864 RID: 2148
		[CompilerGenerated]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x06003F8B RID: 16267 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x06003F8C RID: 16268 RVA: 0x000FE858 File Offset: 0x000FCA58
			internal bool <TryIdentityEmployee>b__0(IEmployee i)
			{
				return i.Tel.ToString() == this.tel;
			}

			// Token: 0x040029CB RID: 10699
			public string tel;
		}
	}
}
