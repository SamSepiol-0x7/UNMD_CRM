using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000057 RID: 87
	public class payment_types : BindableBase, IPaymentType
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x000119CC File Offset: 0x0000FBCC
		public payment_types()
		{
			this.payment_type_users = new HashSet<payment_type_users>();
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000119F4 File Offset: 0x0000FBF4
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00011A08 File Offset: 0x0000FC08
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
				this.RaisePropertyChanged("Id");
				this.RaisePropertyChanged("id");
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00011A40 File Offset: 0x0000FC40
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00011A54 File Offset: 0x0000FC54
		public int type
		{
			[CompilerGenerated]
			get
			{
				return this.<type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<type>k__BackingField == value)
				{
					return;
				}
				this.<type>k__BackingField = value;
				this.RaisePropertyChanged("type");
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00011A80 File Offset: 0x0000FC80
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00011A94 File Offset: 0x0000FC94
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
				this.RaisePropertyChanged("Name");
				this.RaisePropertyChanged("name");
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00011AD0 File Offset: 0x0000FCD0
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		public int? client
		{
			[CompilerGenerated]
			get
			{
				return this.<client>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<client>k__BackingField, value))
				{
					return;
				}
				this.<client>k__BackingField = value;
				this.RaisePropertyChanged("ClientId");
				this.RaisePropertyChanged("client");
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00011B20 File Offset: 0x0000FD20
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00011B34 File Offset: 0x0000FD34
		public bool periodic
		{
			[CompilerGenerated]
			get
			{
				return this.<periodic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<periodic>k__BackingField == value)
				{
					return;
				}
				this.<periodic>k__BackingField = value;
				this.RaisePropertyChanged("IsRegular");
				this.RaisePropertyChanged("periodic");
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00011B6C File Offset: 0x0000FD6C
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00011B80 File Offset: 0x0000FD80
		public DateTime? pay_date
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<pay_date>k__BackingField, value))
				{
					return;
				}
				this.<pay_date>k__BackingField = value;
				this.RaisePropertyChanged("PayDate");
				this.RaisePropertyChanged("pay_date");
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00011BBC File Offset: 0x0000FDBC
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00011BD0 File Offset: 0x0000FDD0
		public decimal? def_summ
		{
			[CompilerGenerated]
			get
			{
				return this.<def_summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<def_summ>k__BackingField, value))
				{
					return;
				}
				this.<def_summ>k__BackingField = value;
				this.RaisePropertyChanged("DefaultSumm");
				this.RaisePropertyChanged("def_summ");
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00011C0C File Offset: 0x0000FE0C
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00011C20 File Offset: 0x0000FE20
		public string reason
		{
			[CompilerGenerated]
			get
			{
				return this.<reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<reason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<reason>k__BackingField = value;
				this.RaisePropertyChanged("Reason");
				this.RaisePropertyChanged("reason");
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00011C5C File Offset: 0x0000FE5C
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00011C70 File Offset: 0x0000FE70
		public bool is_archive
		{
			[CompilerGenerated]
			get
			{
				return this.<is_archive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<is_archive>k__BackingField == value)
				{
					return;
				}
				this.<is_archive>k__BackingField = value;
				this.RaisePropertyChanged("is_archive");
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00011C9C File Offset: 0x0000FE9C
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00011CB0 File Offset: 0x0000FEB0
		public DateTime? updated_at
		{
			[CompilerGenerated]
			get
			{
				return this.<updated_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<updated_at>k__BackingField, value))
				{
					return;
				}
				this.<updated_at>k__BackingField = value;
				this.RaisePropertyChanged("UpdatedAt");
				this.RaisePropertyChanged("updated_at");
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00011CEC File Offset: 0x0000FEEC
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00011D00 File Offset: 0x0000FF00
		public int? payment_system
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_system>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<payment_system>k__BackingField, value))
				{
					return;
				}
				this.<payment_system>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystem");
				this.RaisePropertyChanged("payment_system");
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00011D3C File Offset: 0x0000FF3C
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00011D50 File Offset: 0x0000FF50
		public virtual clients clients
		{
			[CompilerGenerated]
			get
			{
				return this.<clients>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<clients>k__BackingField, value))
				{
					return;
				}
				this.<clients>k__BackingField = value;
				this.RaisePropertyChanged("clients");
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00011D80 File Offset: 0x0000FF80
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00011D94 File Offset: 0x0000FF94
		public virtual ICollection<payment_type_users> payment_type_users
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_type_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<payment_type_users>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -234254603;
				IL_13:
				switch ((num ^ -1618088804) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<payment_type_users>k__BackingField = value;
					this.RaisePropertyChanged("payment_type_users");
					num = -817851038;
					goto IL_13;
				}
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00011E08 File Offset: 0x00010008
		public int Id
		{
			get
			{
				return 50 + this.id;
			}
			set
			{
				if (this.Id == value)
				{
					return;
				}
				this.id = value;
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00011E34 File Offset: 0x00010034
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00011E48 File Offset: 0x00010048
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (!string.Equals(this.Name, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1084929185;
				IL_14:
				switch ((num ^ -1072535519) % 4)
				{
				case 0:
					goto IL_0F;
				case 2:
					return;
				case 3:
					IL_33:
					this.name = value;
					num = -1746072632;
					goto IL_14;
				}
				this.RaisePropertyChanged("Name");
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00011EA4 File Offset: 0x000100A4
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00011EB8 File Offset: 0x000100B8
		public string Reason
		{
			get
			{
				return this.reason;
			}
			set
			{
				if (string.Equals(this.Reason, value, StringComparison.Ordinal))
				{
					return;
				}
				this.reason = value;
				this.RaisePropertyChanged("Reason");
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00011EE8 File Offset: 0x000100E8
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00011EFC File Offset: 0x000100FC
		public bool IsUserType
		{
			[CompilerGenerated]
			get
			{
				return this.<IsUserType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsUserType>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1717502740;
				IL_10:
				switch ((num ^ 1365695065) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					num = 945189429;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
				this.<IsUserType>k__BackingField = value;
				this.RaisePropertyChanged("IsUserType");
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00011F54 File Offset: 0x00010154
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00011F68 File Offset: 0x00010168
		public int? ClientId
		{
			get
			{
				return this.client;
			}
			set
			{
				if (Nullable.Equals<int>(this.ClientId, value))
				{
					return;
				}
				this.client = value;
				this.RaisePropertyChanged("ClientId");
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00011F98 File Offset: 0x00010198
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00011FAC File Offset: 0x000101AC
		public bool IsRegular
		{
			get
			{
				return this.periodic;
			}
			set
			{
				if (this.IsRegular != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1750383784;
				IL_10:
				switch ((num ^ -326939959) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					num = -1910060202;
					goto IL_10;
				}
				this.periodic = value;
				this.RaisePropertyChanged("IsRegular");
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00012004 File Offset: 0x00010204
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00012018 File Offset: 0x00010218
		public decimal? DefaultSumm
		{
			get
			{
				return this.def_summ;
			}
			set
			{
				if (Nullable.Equals<decimal>(this.DefaultSumm, value))
				{
					return;
				}
				this.def_summ = value;
				this.RaisePropertyChanged("DefaultSumm");
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00012048 File Offset: 0x00010248
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x0001205C File Offset: 0x0001025C
		public DateTime? PayDate
		{
			get
			{
				return this.pay_date;
			}
			set
			{
				if (Nullable.Equals<DateTime>(this.PayDate, value))
				{
					return;
				}
				this.pay_date = value;
				this.RaisePropertyChanged("PayDate");
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0001208C File Offset: 0x0001028C
		public DateTime? UpdatedAt
		{
			get
			{
				return this.updated_at;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000120A0 File Offset: 0x000102A0
		public int? PaymentSystem
		{
			get
			{
				return this.payment_system;
			}
		}

		// Token: 0x04000412 RID: 1042
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000413 RID: 1043
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x04000414 RID: 1044
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x04000415 RID: 1045
		[CompilerGenerated]
		private int? <client>k__BackingField;

		// Token: 0x04000416 RID: 1046
		[CompilerGenerated]
		private bool <periodic>k__BackingField;

		// Token: 0x04000417 RID: 1047
		[CompilerGenerated]
		private DateTime? <pay_date>k__BackingField;

		// Token: 0x04000418 RID: 1048
		[CompilerGenerated]
		private decimal? <def_summ>k__BackingField;

		// Token: 0x04000419 RID: 1049
		[CompilerGenerated]
		private string <reason>k__BackingField;

		// Token: 0x0400041A RID: 1050
		[CompilerGenerated]
		private bool <is_archive>k__BackingField;

		// Token: 0x0400041B RID: 1051
		[CompilerGenerated]
		private DateTime? <updated_at>k__BackingField;

		// Token: 0x0400041C RID: 1052
		[CompilerGenerated]
		private int? <payment_system>k__BackingField;

		// Token: 0x0400041D RID: 1053
		[CompilerGenerated]
		private clients <clients>k__BackingField;

		// Token: 0x0400041E RID: 1054
		[CompilerGenerated]
		private ICollection<payment_type_users> <payment_type_users>k__BackingField;

		// Token: 0x0400041F RID: 1055
		[CompilerGenerated]
		private bool <IsUserType>k__BackingField = true;
	}
}
