using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x02000867 RID: 2151
	public class Customer : BindableBase, ICustomer, ICheckFields
	{
		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x000FEBD4 File Offset: 0x000FCDD4
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x000FEBE8 File Offset: 0x000FCDE8
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

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x000FEC14 File Offset: 0x000FCE14
		// (set) Token: 0x06003FAA RID: 16298 RVA: 0x000FEC28 File Offset: 0x000FCE28
		public DateTime? Created
		{
			[CompilerGenerated]
			get
			{
				return this.<Created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<Created>k__BackingField, value))
				{
					return;
				}
				this.<Created>k__BackingField = value;
				this.RaisePropertyChanged("Created");
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x000FEC58 File Offset: 0x000FCE58
		// (set) Token: 0x06003FAC RID: 16300 RVA: 0x000FEC6C File Offset: 0x000FCE6C
		public int State
		{
			[CompilerGenerated]
			get
			{
				return this.<State>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<State>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -937996239;
				IL_10:
				switch ((num ^ -2122638596) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					this.<State>k__BackingField = value;
					this.RaisePropertyChanged("State");
					num = -119392424;
					goto IL_10;
				}
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06003FAD RID: 16301 RVA: 0x000FECC4 File Offset: 0x000FCEC4
		// (set) Token: 0x06003FAE RID: 16302 RVA: 0x000FECD8 File Offset: 0x000FCED8
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
				if (this.<Type>k__BackingField == value)
				{
					return;
				}
				this.<Type>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("Type");
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x000FED10 File Offset: 0x000FCF10
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x000FED24 File Offset: 0x000FCF24
		public string LastName
		{
			[CompilerGenerated]
			get
			{
				return this.<LastName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<LastName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<LastName>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("LastName");
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x000FED60 File Offset: 0x000FCF60
		// (set) Token: 0x06003FB2 RID: 16306 RVA: 0x000FED74 File Offset: 0x000FCF74
		public string FirstName
		{
			[CompilerGenerated]
			get
			{
				return this.<FirstName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<FirstName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<FirstName>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("FirstName");
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06003FB3 RID: 16307 RVA: 0x000FEDB0 File Offset: 0x000FCFB0
		// (set) Token: 0x06003FB4 RID: 16308 RVA: 0x000FEDC4 File Offset: 0x000FCFC4
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
				if (string.Equals(this.<Patronymic>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Patronymic>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("Patronymic");
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06003FB5 RID: 16309 RVA: 0x000FEE00 File Offset: 0x000FD000
		// (set) Token: 0x06003FB6 RID: 16310 RVA: 0x000FEE14 File Offset: 0x000FD014
		public string UrName
		{
			[CompilerGenerated]
			get
			{
				return this.<UrName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<UrName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<UrName>k__BackingField = value;
				this.RaisePropertyChanged("FioOrUrName");
				this.RaisePropertyChanged("UrName");
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06003FB7 RID: 16311 RVA: 0x000FEE50 File Offset: 0x000FD050
		// (set) Token: 0x06003FB8 RID: 16312 RVA: 0x000FEE64 File Offset: 0x000FD064
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
				if (string.Equals(this.<Phone>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Phone>k__BackingField = value;
				this.RaisePropertyChanged("Phone");
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x000FEE94 File Offset: 0x000FD094
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
						this.FirstName,
						" ",
						this.Patronymic
					});
				}
				return this.UrName;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06003FBA RID: 16314 RVA: 0x000FEEE8 File Offset: 0x000FD0E8
		// (set) Token: 0x06003FBB RID: 16315 RVA: 0x000FEEFC File Offset: 0x000FD0FC
		public bool IsBad
		{
			[CompilerGenerated]
			get
			{
				return this.<IsBad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsBad>k__BackingField == value)
				{
					return;
				}
				this.<IsBad>k__BackingField = value;
				this.RaisePropertyChanged("IsBad");
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06003FBC RID: 16316 RVA: 0x000FEF28 File Offset: 0x000FD128
		// (set) Token: 0x06003FBD RID: 16317 RVA: 0x000FEF3C File Offset: 0x000FD13C
		public bool IsRegular
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRegular>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRegular>k__BackingField == value)
				{
					return;
				}
				this.<IsRegular>k__BackingField = value;
				this.RaisePropertyChanged("IsRegular");
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06003FBE RID: 16318 RVA: 0x000FEF68 File Offset: 0x000FD168
		// (set) Token: 0x06003FBF RID: 16319 RVA: 0x000FEF7C File Offset: 0x000FD17C
		public bool IsAgent
		{
			[CompilerGenerated]
			get
			{
				return this.<IsAgent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsAgent>k__BackingField == value)
				{
					return;
				}
				this.<IsAgent>k__BackingField = value;
				this.RaisePropertyChanged("IsAgent");
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x000FEFA8 File Offset: 0x000FD1A8
		// (set) Token: 0x06003FC1 RID: 16321 RVA: 0x000FEFBC File Offset: 0x000FD1BC
		public int RepairsCount
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairsCount>k__BackingField == value)
				{
					return;
				}
				this.<RepairsCount>k__BackingField = value;
				this.RaisePropertyChanged("RepairsCount");
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06003FC2 RID: 16322 RVA: 0x000FEFE8 File Offset: 0x000FD1E8
		// (set) Token: 0x06003FC3 RID: 16323 RVA: 0x000FEFFC File Offset: 0x000FD1FC
		public int PurchasesCount
		{
			[CompilerGenerated]
			get
			{
				return this.<PurchasesCount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PurchasesCount>k__BackingField == value)
				{
					return;
				}
				this.<PurchasesCount>k__BackingField = value;
				this.RaisePropertyChanged("PurchasesCount");
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x000FF028 File Offset: 0x000FD228
		// (set) Token: 0x06003FC5 RID: 16325 RVA: 0x000FF03C File Offset: 0x000FD23C
		public int? PhotoId
		{
			[CompilerGenerated]
			get
			{
				return this.<PhotoId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<PhotoId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 800830686;
				IL_13:
				switch ((num ^ 759691771) % 4)
				{
				case 0:
					IL_32:
					this.<PhotoId>k__BackingField = value;
					this.RaisePropertyChanged("PhotoId");
					num = 206844241;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x000FF098 File Offset: 0x000FD298
		// (set) Token: 0x06003FC7 RID: 16327 RVA: 0x000FF0AC File Offset: 0x000FD2AC
		public bool BalanceEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.<BalanceEnabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<BalanceEnabled>k__BackingField == value)
				{
					return;
				}
				this.<BalanceEnabled>k__BackingField = value;
				this.RaisePropertyChanged("BalanceEnabled");
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06003FC8 RID: 16328 RVA: 0x000FF0D8 File Offset: 0x000FD2D8
		// (set) Token: 0x06003FC9 RID: 16329 RVA: 0x000FF0EC File Offset: 0x000FD2EC
		public decimal Balance
		{
			[CompilerGenerated]
			get
			{
				return this.<Balance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Balance>k__BackingField, value))
				{
					return;
				}
				this.<Balance>k__BackingField = value;
				this.RaisePropertyChanged("Balance");
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x000FF11C File Offset: 0x000FD31C
		// (set) Token: 0x06003FCB RID: 16331 RVA: 0x000FF130 File Offset: 0x000FD330
		public string Address
		{
			[CompilerGenerated]
			get
			{
				return this.<Address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Address>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1227533918;
				IL_14:
				switch ((num ^ -729326941) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0F;
				case 3:
					IL_33:
					this.<Address>k__BackingField = value;
					this.RaisePropertyChanged("Address");
					num = -655376445;
					goto IL_14;
				}
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x000FF18C File Offset: 0x000FD38C
		// (set) Token: 0x06003FCD RID: 16333 RVA: 0x000FF1A0 File Offset: 0x000FD3A0
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

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x000FF1D0 File Offset: 0x000FD3D0
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x000FF1E4 File Offset: 0x000FD3E4
		public bool IsDealer
		{
			[CompilerGenerated]
			get
			{
				return this.<IsDealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsDealer>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1145732522;
				IL_10:
				switch ((num ^ -1953828095) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<IsDealer>k__BackingField = value;
					this.RaisePropertyChanged("IsDealer");
					num = -1034353805;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x000FF23C File Offset: 0x000FD43C
		// (set) Token: 0x06003FD1 RID: 16337 RVA: 0x000FF250 File Offset: 0x000FD450
		public bool IsRealizator
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRealizator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRealizator>k__BackingField == value)
				{
					return;
				}
				this.<IsRealizator>k__BackingField = value;
				this.RaisePropertyChanged("IsRealizator");
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x000FF27C File Offset: 0x000FD47C
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x000FF290 File Offset: 0x000FD490
		public ICollection<Itel> PhoneList
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PhoneList>k__BackingField, value))
				{
					return;
				}
				this.<PhoneList>k__BackingField = value;
				this.RaisePropertyChanged("PhoneList");
			}
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x0007E558 File Offset: 0x0007C758
		public string CheckFields()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x000069B8 File Offset: 0x00004BB8
		public Customer()
		{
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x000FF2C0 File Offset: 0x000FD4C0
		public Customer(IEmployee emp)
		{
			this.Type = 0;
			this.FirstName = emp.FirstName;
			this.LastName = emp.LastName;
			this.Patronymic = emp.Patronymic;
		}

		// Token: 0x040029D5 RID: 10709
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040029D6 RID: 10710
		[CompilerGenerated]
		private DateTime? <Created>k__BackingField;

		// Token: 0x040029D7 RID: 10711
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x040029D8 RID: 10712
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x040029D9 RID: 10713
		[CompilerGenerated]
		private string <LastName>k__BackingField;

		// Token: 0x040029DA RID: 10714
		[CompilerGenerated]
		private string <FirstName>k__BackingField;

		// Token: 0x040029DB RID: 10715
		[CompilerGenerated]
		private string <Patronymic>k__BackingField;

		// Token: 0x040029DC RID: 10716
		[CompilerGenerated]
		private string <UrName>k__BackingField;

		// Token: 0x040029DD RID: 10717
		[CompilerGenerated]
		private string <Phone>k__BackingField;

		// Token: 0x040029DE RID: 10718
		[CompilerGenerated]
		private bool <IsBad>k__BackingField;

		// Token: 0x040029DF RID: 10719
		[CompilerGenerated]
		private bool <IsRegular>k__BackingField;

		// Token: 0x040029E0 RID: 10720
		[CompilerGenerated]
		private bool <IsAgent>k__BackingField;

		// Token: 0x040029E1 RID: 10721
		[CompilerGenerated]
		private int <RepairsCount>k__BackingField;

		// Token: 0x040029E2 RID: 10722
		[CompilerGenerated]
		private int <PurchasesCount>k__BackingField;

		// Token: 0x040029E3 RID: 10723
		[CompilerGenerated]
		private int? <PhotoId>k__BackingField;

		// Token: 0x040029E4 RID: 10724
		[CompilerGenerated]
		private bool <BalanceEnabled>k__BackingField;

		// Token: 0x040029E5 RID: 10725
		[CompilerGenerated]
		private decimal <Balance>k__BackingField;

		// Token: 0x040029E6 RID: 10726
		[CompilerGenerated]
		private string <Address>k__BackingField;

		// Token: 0x040029E7 RID: 10727
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x040029E8 RID: 10728
		[CompilerGenerated]
		private bool <IsDealer>k__BackingField;

		// Token: 0x040029E9 RID: 10729
		[CompilerGenerated]
		private bool <IsRealizator>k__BackingField;

		// Token: 0x040029EA RID: 10730
		[CompilerGenerated]
		private ICollection<Itel> <PhoneList>k__BackingField;
	}
}
