using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;
using ASC.Common.Interfaces;
using ASC.Common.Phone;
using ASC.Extensions;
using ASC.Models;
using ASC.Objects.Converters;
using ASC.SimpleClasses;
using DevExpress.Mvvm;
using NLog;
using Poly;

namespace ASC.Objects
{
	// Token: 0x020008C6 RID: 2246
	public class CustomerCard : BindableBase, ICustomer, ICheckFields
	{
		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x0010CF28 File Offset: 0x0010B128
		// (set) Token: 0x06004486 RID: 17542 RVA: 0x0010CF3C File Offset: 0x0010B13C
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

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x0010CF68 File Offset: 0x0010B168
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x0010CF7C File Offset: 0x0010B17C
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

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x0010CFAC File Offset: 0x0010B1AC
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x0010CFC0 File Offset: 0x0010B1C0
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
				if (this.<State>k__BackingField == value)
				{
					return;
				}
				this.<State>k__BackingField = value;
				this.RaisePropertyChanged("IsArchive");
				this.RaisePropertyChanged("State");
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x0010CFF8 File Offset: 0x0010B1F8
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x0010D00C File Offset: 0x0010B20C
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
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("FioShortOrUrName");
				this.RaisePropertyChanged("IsUr");
				this.RaisePropertyChanged("Type");
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x0010D064 File Offset: 0x0010B264
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x0010D078 File Offset: 0x0010B278
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
				this.RaisePropertyChanged("FioShortOrUrName");
				this.RaisePropertyChanged("LastName");
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x0010D0C0 File Offset: 0x0010B2C0
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x0010D0D4 File Offset: 0x0010B2D4
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
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("FioShortOrUrName");
				this.RaisePropertyChanged("FirstName");
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x0010D124 File Offset: 0x0010B324
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x0010D138 File Offset: 0x0010B338
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
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("FioShortOrUrName");
				this.RaisePropertyChanged("Patronymic");
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x0010D188 File Offset: 0x0010B388
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x0010D19C File Offset: 0x0010B39C
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
				this.RaisePropertyChanged("IoOrUrName");
				this.RaisePropertyChanged("FioShortOrUrName");
				this.RaisePropertyChanged("UrName");
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x0010D1EC File Offset: 0x0010B3EC
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

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x0010D240 File Offset: 0x0010B440
		public virtual string IoOrUrName
		{
			get
			{
				if (this.Type != 1)
				{
					return this.FirstName + " " + this.Patronymic;
				}
				return this.UrName;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x0010D274 File Offset: 0x0010B474
		public string FioShortOrUrName
		{
			get
			{
				if (this.Type != 1)
				{
					return string.Concat(new string[]
					{
						this.LastName,
						" ",
						this.FirstName.FirstOrEmpty(true),
						" ",
						this.Patronymic.FirstOrEmpty(true)
					});
				}
				return this.UrName;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x0010D2D4 File Offset: 0x0010B4D4
		// (set) Token: 0x06004499 RID: 17561 RVA: 0x0010D2E8 File Offset: 0x0010B4E8
		public List<string> Info
		{
			[CompilerGenerated]
			get
			{
				return this.<Info>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Info>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1250307808;
				IL_13:
				switch ((num ^ -1160189709) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<Info>k__BackingField = value;
					this.RaisePropertyChanged("Info");
					num = -547984438;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x0010D344 File Offset: 0x0010B544
		// (set) Token: 0x0600449B RID: 17563 RVA: 0x0010D358 File Offset: 0x0010B558
		public ObservableCollection<IPaymentDetails> PaymentDetails
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentDetails>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentDetails>k__BackingField, value))
				{
					return;
				}
				this.<PaymentDetails>k__BackingField = value;
				this.RaisePropertyChanged("PaymentDetails");
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x0010D388 File Offset: 0x0010B588
		// (set) Token: 0x0600449D RID: 17565 RVA: 0x0010D39C File Offset: 0x0010B59C
		public ObservableCollection<Tel> Phones
		{
			[CompilerGenerated]
			get
			{
				return this.<Phones>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Phones>k__BackingField, value))
				{
					return;
				}
				this.<Phones>k__BackingField = value;
				this.RaisePropertyChanged("PhonesStr");
				this.RaisePropertyChanged("PhoneOrEmail");
				this.RaisePropertyChanged("Phones");
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x0010D3E0 File Offset: 0x0010B5E0
		// (set) Token: 0x0600449F RID: 17567 RVA: 0x0010D3F4 File Offset: 0x0010B5F4
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
				if (this.<IsBad>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1654411942;
				IL_10:
				switch ((num ^ 376190669) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<IsBad>k__BackingField = value;
					this.RaisePropertyChanged("IsBad");
					num = 1037284144;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x0010D44C File Offset: 0x0010B64C
		// (set) Token: 0x060044A1 RID: 17569 RVA: 0x0010D460 File Offset: 0x0010B660
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

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x0010D48C File Offset: 0x0010B68C
		// (set) Token: 0x060044A3 RID: 17571 RVA: 0x0010D4A0 File Offset: 0x0010B6A0
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

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x0010D4CC File Offset: 0x0010B6CC
		// (set) Token: 0x060044A5 RID: 17573 RVA: 0x0010D4E0 File Offset: 0x0010B6E0
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
				if (this.<IsDealer>k__BackingField == value)
				{
					return;
				}
				this.<IsDealer>k__BackingField = value;
				this.RaisePropertyChanged("IsDealer");
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x0010D50C File Offset: 0x0010B70C
		// (set) Token: 0x060044A7 RID: 17575 RVA: 0x0010D524 File Offset: 0x0010B724
		public bool IsUr
		{
			get
			{
				return this.Type == 1;
			}
			set
			{
				if (this.IsUr != value)
				{
					this.Type = ((!value) ? 0 : 1);
					this.RaisePropertyChanged("IsUr");
					return;
				}
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x0010D558 File Offset: 0x0010B758
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x0010D56C File Offset: 0x0010B76C
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

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x0010D598 File Offset: 0x0010B798
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x0010D5AC File Offset: 0x0010B7AC
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

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x0010D5D8 File Offset: 0x0010B7D8
		// (set) Token: 0x060044AD RID: 17581 RVA: 0x0010D5EC File Offset: 0x0010B7EC
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
				int num = 1254977666;
				IL_13:
				switch ((num ^ 1225546127) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<PhotoId>k__BackingField = value;
					this.RaisePropertyChanged("PhotoId");
					num = 1893211392;
					goto IL_13;
				}
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x0010D648 File Offset: 0x0010B848
		// (set) Token: 0x060044AF RID: 17583 RVA: 0x0010D65C File Offset: 0x0010B85C
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
				if (this.<BalanceEnabled>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1239776005;
				IL_10:
				switch ((num ^ -299181532) % 4)
				{
				case 0:
					IL_2F:
					num = -256749151;
					goto IL_10;
				case 2:
					goto IL_0B;
				case 3:
					return;
				}
				this.<BalanceEnabled>k__BackingField = value;
				this.RaisePropertyChanged("BalanceEnabled");
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x0010D6B4 File Offset: 0x0010B8B4
		// (set) Token: 0x060044B1 RID: 17585 RVA: 0x0010D6C8 File Offset: 0x0010B8C8
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

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x0010D6F4 File Offset: 0x0010B8F4
		// (set) Token: 0x060044B3 RID: 17587 RVA: 0x0010D708 File Offset: 0x0010B908
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
				this.RaisePropertyChanged("BalanceColor");
				this.RaisePropertyChanged("Balance");
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x0010D744 File Offset: 0x0010B944
		// (set) Token: 0x060044B5 RID: 17589 RVA: 0x0010D758 File Offset: 0x0010B958
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

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x0010D788 File Offset: 0x0010B988
		// (set) Token: 0x060044B7 RID: 17591 RVA: 0x0010D79C File Offset: 0x0010B99C
		public int PhoneMask
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneMask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PhoneMask>k__BackingField == value)
				{
					return;
				}
				this.<PhoneMask>k__BackingField = value;
				this.RaisePropertyChanged("PhoneMask");
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x0010D7C8 File Offset: 0x0010B9C8
		// (set) Token: 0x060044B9 RID: 17593 RVA: 0x0010D7DC File Offset: 0x0010B9DC
		public string Phone2
		{
			[CompilerGenerated]
			get
			{
				return this.<Phone2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Phone2>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Phone2>k__BackingField = value;
				this.RaisePropertyChanged("Phone2");
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x0010D80C File Offset: 0x0010BA0C
		// (set) Token: 0x060044BB RID: 17595 RVA: 0x0010D820 File Offset: 0x0010BA20
		public int Phone2Mask
		{
			[CompilerGenerated]
			get
			{
				return this.<Phone2Mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Phone2Mask>k__BackingField == value)
				{
					return;
				}
				this.<Phone2Mask>k__BackingField = value;
				this.RaisePropertyChanged("Phone2Mask");
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x060044BC RID: 17596 RVA: 0x0010D84C File Offset: 0x0010BA4C
		// (set) Token: 0x060044BD RID: 17597 RVA: 0x0010D860 File Offset: 0x0010BA60
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
				if (string.Equals(this.<Address>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Address>k__BackingField = value;
				this.RaisePropertyChanged("Address");
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x0010D890 File Offset: 0x0010BA90
		// (set) Token: 0x060044BF RID: 17599 RVA: 0x0010D8A4 File Offset: 0x0010BAA4
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
				this.RaisePropertyChanged("PhoneOrEmail");
				this.RaisePropertyChanged("Email");
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x0010D8E0 File Offset: 0x0010BAE0
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x0010D8F4 File Offset: 0x0010BAF4
		public string Memorial
		{
			[CompilerGenerated]
			get
			{
				return this.<Memorial>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Memorial>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Memorial>k__BackingField = value;
				this.RaisePropertyChanged("Memorial");
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x0010D924 File Offset: 0x0010BB24
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x0010D938 File Offset: 0x0010BB38
		public string WebPassword
		{
			[CompilerGenerated]
			get
			{
				return this.<WebPassword>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<WebPassword>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<WebPassword>k__BackingField = value;
				this.RaisePropertyChanged("WebPassword");
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x0010D968 File Offset: 0x0010BB68
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x0010D97C File Offset: 0x0010BB7C
		public int PriceCol
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceCol>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PriceCol>k__BackingField == value)
				{
					return;
				}
				this.<PriceCol>k__BackingField = value;
				this.RaisePropertyChanged("PriceCol");
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x0010D9A8 File Offset: 0x0010BBA8
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x0010D9BC File Offset: 0x0010BBBC
		public string PriceColString
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceColString>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<PriceColString>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<PriceColString>k__BackingField = value;
				this.RaisePropertyChanged("PriceColString");
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x0010D9EC File Offset: 0x0010BBEC
		// (set) Token: 0x060044C9 RID: 17609 RVA: 0x0010DA00 File Offset: 0x0010BC00
		public bool IgnoreCalls
		{
			[CompilerGenerated]
			get
			{
				return this.<IgnoreCalls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IgnoreCalls>k__BackingField == value)
				{
					return;
				}
				this.<IgnoreCalls>k__BackingField = value;
				this.RaisePropertyChanged("IgnoreCalls");
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x060044CA RID: 17610 RVA: 0x0010DA2C File Offset: 0x0010BC2C
		// (set) Token: 0x060044CB RID: 17611 RVA: 0x0010DA40 File Offset: 0x0010BC40
		public bool PreferCashless
		{
			[CompilerGenerated]
			get
			{
				return this.<PreferCashless>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PreferCashless>k__BackingField == value)
				{
					return;
				}
				this.<PreferCashless>k__BackingField = value;
				this.RaisePropertyChanged("PreferCashless");
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x0010DA6C File Offset: 0x0010BC6C
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x0010DA80 File Offset: 0x0010BC80
		public bool TakeLong
		{
			[CompilerGenerated]
			get
			{
				return this.<TakeLong>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TakeLong>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1453879461;
				IL_10:
				switch ((num ^ -1913707587) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					this.<TakeLong>k__BackingField = value;
					num = -1663483416;
					goto IL_10;
				}
				this.RaisePropertyChanged("TakeLong");
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x0010DAD8 File Offset: 0x0010BCD8
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x0010DAEC File Offset: 0x0010BCEC
		public string Notes
		{
			[CompilerGenerated]
			get
			{
				return this.<Notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Notes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Notes>k__BackingField = value;
				this.RaisePropertyChanged("Notes");
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x0010DB1C File Offset: 0x0010BD1C
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x0010DB30 File Offset: 0x0010BD30
		public string PassportNum
		{
			[CompilerGenerated]
			get
			{
				return this.<PassportNum>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<PassportNum>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<PassportNum>k__BackingField = value;
				this.RaisePropertyChanged("PassportNum");
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x0010DB60 File Offset: 0x0010BD60
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x0010DB74 File Offset: 0x0010BD74
		public string PassportOrgan
		{
			[CompilerGenerated]
			get
			{
				return this.<PassportOrgan>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<PassportOrgan>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -919042451;
				IL_14:
				switch ((num ^ -2047621886) % 4)
				{
				case 0:
					goto IL_0F;
				case 2:
					IL_33:
					this.<PassportOrgan>k__BackingField = value;
					this.RaisePropertyChanged("PassportOrgan");
					num = -554937381;
					goto IL_14;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x0010DBD0 File Offset: 0x0010BDD0
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x0010DBE4 File Offset: 0x0010BDE4
		public DateTime? PassportDate
		{
			[CompilerGenerated]
			get
			{
				return this.<PassportDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<PassportDate>k__BackingField, value))
				{
					return;
				}
				this.<PassportDate>k__BackingField = value;
				this.RaisePropertyChanged("PassportDate");
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x0010DC14 File Offset: 0x0010BE14
		// (set) Token: 0x060044D7 RID: 17623 RVA: 0x0010DC28 File Offset: 0x0010BE28
		public DateTime? Birthday
		{
			[CompilerGenerated]
			get
			{
				return this.<Birthday>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<Birthday>k__BackingField, value))
				{
					return;
				}
				this.<Birthday>k__BackingField = value;
				this.RaisePropertyChanged("Birthday");
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x0010DC58 File Offset: 0x0010BE58
		// (set) Token: 0x060044D9 RID: 17625 RVA: 0x0010DC6C File Offset: 0x0010BE6C
		public string Icq
		{
			[CompilerGenerated]
			get
			{
				return this.<Icq>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Icq>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Icq>k__BackingField = value;
				this.RaisePropertyChanged("Icq");
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x0010DC9C File Offset: 0x0010BE9C
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x0010DCB0 File Offset: 0x0010BEB0
		public string Whatsapp
		{
			[CompilerGenerated]
			get
			{
				return this.<Whatsapp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Whatsapp>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Whatsapp>k__BackingField = value;
				this.RaisePropertyChanged("Whatsapp");
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x0010DCE0 File Offset: 0x0010BEE0
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x0010DCF4 File Offset: 0x0010BEF4
		public string Site
		{
			[CompilerGenerated]
			get
			{
				return this.<Site>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Site>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Site>k__BackingField = value;
				this.RaisePropertyChanged("Site");
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x0010DD24 File Offset: 0x0010BF24
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x0010DD38 File Offset: 0x0010BF38
		public string Telegram
		{
			[CompilerGenerated]
			get
			{
				return this.<Telegram>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Telegram>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Telegram>k__BackingField = value;
				this.RaisePropertyChanged("Telegram");
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x0010DD68 File Offset: 0x0010BF68
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x0010DD7C File Offset: 0x0010BF7C
		public string Skype
		{
			[CompilerGenerated]
			get
			{
				return this.<Skype>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Skype>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Skype>k__BackingField = value;
				this.RaisePropertyChanged("Skype");
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x0010DDAC File Offset: 0x0010BFAC
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x0010DDC0 File Offset: 0x0010BFC0
		public string Viber
		{
			[CompilerGenerated]
			get
			{
				return this.<Viber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Viber>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Viber>k__BackingField = value;
				this.RaisePropertyChanged("Viber");
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x0010DDF0 File Offset: 0x0010BFF0
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x0010DE08 File Offset: 0x0010C008
		public bool IsArchive
		{
			get
			{
				return this.State == 0;
			}
			set
			{
				if (this.IsArchive != value)
				{
					this.State = ((!value) ? 1 : 0);
					this.RaisePropertyChanged("IsArchive");
					return;
				}
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x0010DE3C File Offset: 0x0010C03C
		// (set) Token: 0x060044E7 RID: 17639 RVA: 0x0010DE50 File Offset: 0x0010C050
		public string PostIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<PostIndex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<PostIndex>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<PostIndex>k__BackingField = value;
				this.RaisePropertyChanged("PostIndex");
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x0010DE80 File Offset: 0x0010C080
		// (set) Token: 0x060044E9 RID: 17641 RVA: 0x0010DE94 File Offset: 0x0010C094
		public string Inn
		{
			[CompilerGenerated]
			get
			{
				return this.<Inn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Inn>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -2066736203;
				IL_14:
				switch ((num ^ -1145832036) % 4)
				{
				case 0:
					IL_33:
					this.<Inn>k__BackingField = value;
					this.RaisePropertyChanged("Inn");
					num = -645849485;
					goto IL_14;
				case 1:
					return;
				case 2:
					goto IL_0F;
				}
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x0010DEF0 File Offset: 0x0010C0F0
		// (set) Token: 0x060044EB RID: 17643 RVA: 0x0010DF04 File Offset: 0x0010C104
		public string Ogrn
		{
			[CompilerGenerated]
			get
			{
				return this.<Ogrn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Ogrn>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Ogrn>k__BackingField = value;
				this.RaisePropertyChanged("Ogrn");
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x0010DF34 File Offset: 0x0010C134
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x0010DF48 File Offset: 0x0010C148
		public string Kpp
		{
			[CompilerGenerated]
			get
			{
				return this.<Kpp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Kpp>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Kpp>k__BackingField = value;
				this.RaisePropertyChanged("Kpp");
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x0010DF78 File Offset: 0x0010C178
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x0010DF8C File Offset: 0x0010C18C
		public IImage Photo
		{
			[CompilerGenerated]
			get
			{
				return this.<Photo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Photo>k__BackingField, value))
				{
					return;
				}
				this.<Photo>k__BackingField = value;
				this.RaisePropertyChanged("Photo");
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x0010DFBC File Offset: 0x0010C1BC
		// (set) Token: 0x060044F1 RID: 17649 RVA: 0x0010DFD0 File Offset: 0x0010C1D0
		public int? VisitSource
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitSource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<VisitSource>k__BackingField, value))
				{
					return;
				}
				this.<VisitSource>k__BackingField = value;
				this.RaisePropertyChanged("VisitSource");
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x0010E000 File Offset: 0x0010C200
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x0010E014 File Offset: 0x0010C214
		public string VisitSourceName
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitSourceName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<VisitSourceName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<VisitSourceName>k__BackingField = value;
				this.RaisePropertyChanged("VisitSourceName");
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x0010E044 File Offset: 0x0010C244
		public string PhonesStr
		{
			get
			{
				if (this.Phones == null)
				{
					return "";
				}
				List<Tel> list = (from p in this.Phones
				where p.Type != 1
				select p).ToList<Tel>();
				if (list.Any<Tel>())
				{
					string text = string.Empty;
					for (int i = 0; i < list.Count; i++)
					{
						Tel tel = list[i];
						if (!string.IsNullOrEmpty((tel != null) ? tel.Phone : null))
						{
							text += tel.Phone;
							if (!string.IsNullOrEmpty(tel.Note))
							{
								text = text + " [" + tel.Note + "]";
							}
							if (i < list.Count - 1)
							{
								text = text + "; " + Environment.NewLine;
							}
						}
					}
					return text;
				}
				return "";
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x0010E124 File Offset: 0x0010C324
		public Brush BalanceColor
		{
			get
			{
				if (!(this.Balance < 0m))
				{
					goto IL_55;
				}
				IL_21:
				int num = 1346206565;
				IL_26:
				switch ((num ^ 892184964) % 5)
				{
				case 0:
					return new SolidColorBrush(Colors.ForestGreen);
				case 2:
					return new SolidColorBrush(Colors.Red);
				case 3:
					goto IL_21;
				case 4:
					IL_55:
					num = ((!(this.Balance > 0m)) ? 1229940304 : 686477411);
					goto IL_26;
				}
				return new SolidColorBrush(Colors.Black);
			}
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x0010E1BC File Offset: 0x0010C3BC
		public CustomerCard()
		{
			this.Info = new List<string>();
			this.Photo = new AscImage();
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x0010E1F0 File Offset: 0x0010C3F0
		public CustomerCard(ICustomer c) : this()
		{
			c.CopyProperties(this);
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x0010E20C File Offset: 0x0010C40C
		public CustomerCard(IEmployee emp) : this()
		{
			this.Type = 0;
			this.FirstName = emp.FirstName;
			this.LastName = emp.LastName;
			this.Patronymic = emp.Patronymic;
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x0010E24C File Offset: 0x0010C44C
		public string CheckFields()
		{
			if (this.Type == 0 && string.IsNullOrEmpty(this.FirstName))
			{
				return "InputClientName";
			}
			if (Auth.Config.is_patronymic_required && this.Type == 0 && string.IsNullOrEmpty(this.Patronymic))
			{
				return "InputPatronymic";
			}
			if (this.Type == 1 && string.IsNullOrEmpty(this.UrName))
			{
				return "InputUrName";
			}
			return null;
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x0010E2B8 File Offset: 0x0010C4B8
		public Task<int> GetCountPurchases()
		{
			CustomerCard.<GetCountPurchases>d__229 <GetCountPurchases>d__;
			<GetCountPurchases>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<GetCountPurchases>d__.<>4__this = this;
			<GetCountPurchases>d__.<>1__state = -1;
			<GetCountPurchases>d__.<>t__builder.Start<CustomerCard.<GetCountPurchases>d__229>(ref <GetCountPurchases>d__);
			return <GetCountPurchases>d__.<>t__builder.Task;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x0010E2FC File Offset: 0x0010C4FC
		public void CountPurchases()
		{
			Task.Run<int>(new Func<Task<int>>(this.GetCountPurchases)).ContinueWith(delegate(Task<int> t)
			{
				this.PurchasesCount = t.Result;
			});
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x0010E32C File Offset: 0x0010C52C
		public void GenWebPassword()
		{
			this.WebPassword = Generators.RandomString(8, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x0010E34C File Offset: 0x0010C54C
		public void AddTelToList(string phone, int mask)
		{
			Tel tel = CustomerCard.ConstructNewTel(phone, mask);
			this.AddTelToList(tel);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x0010E368 File Offset: 0x0010C568
		public void AddTelToList(Tel tel)
		{
			this.Phones.Add(tel);
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x0010E384 File Offset: 0x0010C584
		private static Tel ConstructNewTel(string phone, int mask)
		{
			return new Tel
			{
				Phone = phone,
				PhoneClean = ASC.Common.Phone.Phone.ClearPhoneString(phone),
				Mask = mask,
				Notify = true
			};
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x0010E3B8 File Offset: 0x0010C5B8
		public bool SetMainTel()
		{
			Tel tel = CustomerCard.ConstructNewTel(this.Phone, this.PhoneMask);
			tel.IsMain = true;
			int num = this.AddTel(tel);
			if (num > 0)
			{
				this.AddTelToList(tel);
			}
			return num > 0;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x0010E3F4 File Offset: 0x0010C5F4
		public int AddTel(Tel tel)
		{
			int result;
			try
			{
				HistoryV2 historyV = new HistoryV2();
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<tel> list = (from t in auseceEntities.tel
					where t.customer == (int?)this.Id
					select t).ToList<tel>();
					tel tel2 = tel.ConvertBack(this.Id);
					if (!list.Any<tel>())
					{
						tel2.type = 1;
					}
					if (tel2.type == 1)
					{
						if (list.Any<tel>())
						{
							list.ForEach(delegate(tel t)
							{
								t.type = 0;
							});
						}
					}
					auseceEntities.tel.Add(tel2);
					auseceEntities.SaveChanges();
					historyV.AddClientCardLog("TelCreated", this.Id, tel);
					historyV.Save();
					result = tel2.id;
				}
			}
			catch (Exception value)
			{
				CustomerCard.Log.Error<Exception>(value);
				result = -1;
			}
			return result;
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x0010E570 File Offset: 0x0010C770
		public List<string> GetCleanPhones()
		{
			if (this.Phones != null)
			{
				return (from p in this.Phones
				select p.PhoneClean).ToList<string>();
			}
			return new List<string>();
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x0010E5BC File Offset: 0x0010C7BC
		public Task<IEnumerable<cdr>> GetCalls()
		{
			CustomerCard.<GetCalls>d__238 <GetCalls>d__;
			<GetCalls>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<cdr>>.Create();
			<GetCalls>d__.<>4__this = this;
			<GetCalls>d__.<>1__state = -1;
			<GetCalls>d__.<>t__builder.Start<CustomerCard.<GetCalls>d__238>(ref <GetCalls>d__);
			return <GetCalls>d__.<>t__builder.Task;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x0010E600 File Offset: 0x0010C800
		public void LoadPaymentDetais()
		{
			Task.Run<IEnumerable<PaymentDetails>>(() => ClientsModel.GetCustomerPaymentDetails(this.Id)).ContinueWith(delegate(Task<IEnumerable<PaymentDetails>> t)
			{
				this.PaymentDetails = new ObservableCollection<IPaymentDetails>(t.Result);
			});
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x0010E630 File Offset: 0x0010C830
		public void LoadCustomerInfo()
		{
			if (this.IsRegular)
			{
				this.Info.Add(Lang.t("IsRegular"));
			}
			if (this.PreferCashless)
			{
				this.Info.Add(Lang.t("Cashless"));
			}
			if (this.IsBad)
			{
				this.Info.Add(Lang.t("LabelIsBad"));
			}
			if (this.IsUr)
			{
				this.Info.Add(Lang.t("Ur"));
			}
			if (this.IsAgent)
			{
				this.Info.Add(Lang.t("Agent"));
			}
			if (this.IgnoreCalls)
			{
				this.Info.Add(Lang.t("IgnoreIncomingCalls"));
			}
			if (this.TakeLong)
			{
				this.Info.Add(Lang.t("NotTakeInTime"));
			}
			if (this.IsDealer)
			{
				this.Info.Add(Lang.t("IsDealer"));
			}
			if (this.IsArchive)
			{
				this.Info.Add(Lang.t("ArhiveClient"));
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x0010E744 File Offset: 0x0010C944
		public List<string> PhoneOrEmail
		{
			get
			{
				List<string> list = new List<string>();
				if (!string.IsNullOrEmpty(this.Email))
				{
					list.Add(this.Email);
				}
				if (this.Phones != null && this.Phones.Any<Tel>())
				{
					foreach (Tel tel in this.Phones)
					{
						list.Add("+" + tel.PhoneClean);
					}
				}
				return list;
			}
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x0010E7D8 File Offset: 0x0010C9D8
		public void LoadPhoto()
		{
			if (this.PhotoId != null)
			{
				this.Photo = MediaModel.GetImage(this.PhotoId.Value);
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x0010E810 File Offset: 0x0010CA10
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerCard()
		{
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x0010E828 File Offset: 0x0010CA28
		[CompilerGenerated]
		private void <CountPurchases>b__230_0(Task<int> t)
		{
			this.PurchasesCount = t.Result;
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x0010E844 File Offset: 0x0010CA44
		[CompilerGenerated]
		private Task<IEnumerable<PaymentDetails>> <LoadPaymentDetais>b__239_0()
		{
			return ClientsModel.GetCustomerPaymentDetails(this.Id);
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x0010E85C File Offset: 0x0010CA5C
		[CompilerGenerated]
		private void <LoadPaymentDetais>b__239_1(Task<IEnumerable<PaymentDetails>> t)
		{
			this.PaymentDetails = new ObservableCollection<IPaymentDetails>(t.Result);
		}

		// Token: 0x04002C3A RID: 11322
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04002C3B RID: 11323
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002C3C RID: 11324
		[CompilerGenerated]
		private DateTime? <Created>k__BackingField;

		// Token: 0x04002C3D RID: 11325
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x04002C3E RID: 11326
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002C3F RID: 11327
		[CompilerGenerated]
		private string <LastName>k__BackingField;

		// Token: 0x04002C40 RID: 11328
		[CompilerGenerated]
		private string <FirstName>k__BackingField;

		// Token: 0x04002C41 RID: 11329
		[CompilerGenerated]
		private string <Patronymic>k__BackingField;

		// Token: 0x04002C42 RID: 11330
		[CompilerGenerated]
		private string <UrName>k__BackingField;

		// Token: 0x04002C43 RID: 11331
		[CompilerGenerated]
		private List<string> <Info>k__BackingField;

		// Token: 0x04002C44 RID: 11332
		[CompilerGenerated]
		private ObservableCollection<IPaymentDetails> <PaymentDetails>k__BackingField;

		// Token: 0x04002C45 RID: 11333
		[CompilerGenerated]
		private ObservableCollection<Tel> <Phones>k__BackingField = new ObservableCollection<Tel>();

		// Token: 0x04002C46 RID: 11334
		[CompilerGenerated]
		private bool <IsBad>k__BackingField;

		// Token: 0x04002C47 RID: 11335
		[CompilerGenerated]
		private bool <IsRegular>k__BackingField;

		// Token: 0x04002C48 RID: 11336
		[CompilerGenerated]
		private bool <IsAgent>k__BackingField;

		// Token: 0x04002C49 RID: 11337
		[CompilerGenerated]
		private bool <IsDealer>k__BackingField;

		// Token: 0x04002C4A RID: 11338
		[CompilerGenerated]
		private int <RepairsCount>k__BackingField;

		// Token: 0x04002C4B RID: 11339
		[CompilerGenerated]
		private int <PurchasesCount>k__BackingField;

		// Token: 0x04002C4C RID: 11340
		[CompilerGenerated]
		private int? <PhotoId>k__BackingField;

		// Token: 0x04002C4D RID: 11341
		[CompilerGenerated]
		private bool <BalanceEnabled>k__BackingField;

		// Token: 0x04002C4E RID: 11342
		[CompilerGenerated]
		private bool <IsRealizator>k__BackingField;

		// Token: 0x04002C4F RID: 11343
		[CompilerGenerated]
		private decimal <Balance>k__BackingField;

		// Token: 0x04002C50 RID: 11344
		[CompilerGenerated]
		private string <Phone>k__BackingField;

		// Token: 0x04002C51 RID: 11345
		[CompilerGenerated]
		private int <PhoneMask>k__BackingField;

		// Token: 0x04002C52 RID: 11346
		[CompilerGenerated]
		private string <Phone2>k__BackingField;

		// Token: 0x04002C53 RID: 11347
		[CompilerGenerated]
		private int <Phone2Mask>k__BackingField;

		// Token: 0x04002C54 RID: 11348
		[CompilerGenerated]
		private string <Address>k__BackingField;

		// Token: 0x04002C55 RID: 11349
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x04002C56 RID: 11350
		[CompilerGenerated]
		private string <Memorial>k__BackingField;

		// Token: 0x04002C57 RID: 11351
		[CompilerGenerated]
		private string <WebPassword>k__BackingField;

		// Token: 0x04002C58 RID: 11352
		[CompilerGenerated]
		private int <PriceCol>k__BackingField;

		// Token: 0x04002C59 RID: 11353
		[CompilerGenerated]
		private string <PriceColString>k__BackingField;

		// Token: 0x04002C5A RID: 11354
		[CompilerGenerated]
		private bool <IgnoreCalls>k__BackingField;

		// Token: 0x04002C5B RID: 11355
		[CompilerGenerated]
		private bool <PreferCashless>k__BackingField;

		// Token: 0x04002C5C RID: 11356
		[CompilerGenerated]
		private bool <TakeLong>k__BackingField;

		// Token: 0x04002C5D RID: 11357
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002C5E RID: 11358
		[CompilerGenerated]
		private string <PassportNum>k__BackingField;

		// Token: 0x04002C5F RID: 11359
		[CompilerGenerated]
		private string <PassportOrgan>k__BackingField;

		// Token: 0x04002C60 RID: 11360
		[CompilerGenerated]
		private DateTime? <PassportDate>k__BackingField;

		// Token: 0x04002C61 RID: 11361
		[CompilerGenerated]
		private DateTime? <Birthday>k__BackingField;

		// Token: 0x04002C62 RID: 11362
		[CompilerGenerated]
		private string <Icq>k__BackingField;

		// Token: 0x04002C63 RID: 11363
		[CompilerGenerated]
		private string <Whatsapp>k__BackingField;

		// Token: 0x04002C64 RID: 11364
		[CompilerGenerated]
		private string <Site>k__BackingField;

		// Token: 0x04002C65 RID: 11365
		[CompilerGenerated]
		private string <Telegram>k__BackingField;

		// Token: 0x04002C66 RID: 11366
		[CompilerGenerated]
		private string <Skype>k__BackingField;

		// Token: 0x04002C67 RID: 11367
		[CompilerGenerated]
		private string <Viber>k__BackingField;

		// Token: 0x04002C68 RID: 11368
		[CompilerGenerated]
		private string <PostIndex>k__BackingField;

		// Token: 0x04002C69 RID: 11369
		[CompilerGenerated]
		private string <Inn>k__BackingField;

		// Token: 0x04002C6A RID: 11370
		[CompilerGenerated]
		private string <Ogrn>k__BackingField;

		// Token: 0x04002C6B RID: 11371
		[CompilerGenerated]
		private string <Kpp>k__BackingField;

		// Token: 0x04002C6C RID: 11372
		[CompilerGenerated]
		private IImage <Photo>k__BackingField;

		// Token: 0x04002C6D RID: 11373
		[CompilerGenerated]
		private int? <VisitSource>k__BackingField;

		// Token: 0x04002C6E RID: 11374
		[CompilerGenerated]
		private string <VisitSourceName>k__BackingField;

		// Token: 0x020008C7 RID: 2247
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600450C RID: 17676 RVA: 0x0010E87C File Offset: 0x0010CA7C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600450D RID: 17677 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600450E RID: 17678 RVA: 0x0010E894 File Offset: 0x0010CA94
			internal bool <get_PhonesStr>b__222_0(Tel p)
			{
				return p.Type != 1;
			}

			// Token: 0x0600450F RID: 17679 RVA: 0x000EE630 File Offset: 0x000EC830
			internal void <AddTel>b__236_1(tel t)
			{
				t.type = 0;
			}

			// Token: 0x06004510 RID: 17680 RVA: 0x0010E8B0 File Offset: 0x0010CAB0
			internal string <GetCleanPhones>b__237_0(Tel p)
			{
				return p.PhoneClean;
			}

			// Token: 0x06004511 RID: 17681 RVA: 0x0010E8C4 File Offset: 0x0010CAC4
			internal DateTime <GetCalls>b__238_1(cdr ph)
			{
				return ph.calldate;
			}

			// Token: 0x04002C6F RID: 11375
			public static readonly CustomerCard.<>c <>9 = new CustomerCard.<>c();

			// Token: 0x04002C70 RID: 11376
			public static Func<Tel, bool> <>9__222_0;

			// Token: 0x04002C71 RID: 11377
			public static Action<tel> <>9__236_1;

			// Token: 0x04002C72 RID: 11378
			public static Func<Tel, string> <>9__237_0;

			// Token: 0x04002C73 RID: 11379
			public static Func<cdr, DateTime> <>9__238_1;
		}

		// Token: 0x020008C8 RID: 2248
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCountPurchases>d__229 : IAsyncStateMachine
		{
			// Token: 0x06004512 RID: 17682 RVA: 0x0010E8D8 File Offset: 0x0010CAD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCard value = this.<>4__this;
				int result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<store_sales>();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.CountAsync((store_sales d) => d.docs.dealer == (int?)value.Id && d.docs.type == 2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CustomerCard.<GetCountPurchases>d__229>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004513 RID: 17683 RVA: 0x0010EAB4 File Offset: 0x0010CCB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002C74 RID: 11380
			public int <>1__state;

			// Token: 0x04002C75 RID: 11381
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002C76 RID: 11382
			public CustomerCard <>4__this;

			// Token: 0x04002C77 RID: 11383
			private GenericRepository<store_sales> <repo>5__2;

			// Token: 0x04002C78 RID: 11384
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020008C9 RID: 2249
		[CompilerGenerated]
		private sealed class <>c__DisplayClass238_0
		{
			// Token: 0x06004514 RID: 17684 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass238_0()
			{
			}

			// Token: 0x06004515 RID: 17685 RVA: 0x0010EAD0 File Offset: 0x0010CCD0
			internal bool <GetCalls>b__0(cdr pn)
			{
				return this.clean.Contains(Regex.Replace(pn.src, "[^0-9]", "")) || this.clean.Contains(Regex.Replace(pn.dst, "[^0-9]", ""));
			}

			// Token: 0x04002C79 RID: 11385
			public List<string> clean;
		}

		// Token: 0x020008CA RID: 2250
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCalls>d__238 : IAsyncStateMachine
		{
			// Token: 0x06004516 RID: 17686 RVA: 0x0010EB24 File Offset: 0x0010CD24
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomerCard customerCard = this.<>4__this;
				IEnumerable<cdr> result;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new CustomerCard.<>c__DisplayClass238_0();
						this.<>8__1.clean = customerCard.GetCleanPhones();
						this.<repo>5__2 = new GenericRepository<cdr>();
					}
					try
					{
						TaskAwaiter<IEnumerable<cdr>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync(null, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<cdr>>, CustomerCard.<GetCalls>d__238>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<cdr>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Where(new Func<cdr, bool>(this.<>8__1.<GetCalls>b__0)).OrderByDescending(new Func<cdr, DateTime>(CustomerCard.<>c.<>9.<GetCalls>b__238_1)).ToList<cdr>();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004517 RID: 17687 RVA: 0x0010EC88 File Offset: 0x0010CE88
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002C7A RID: 11386
			public int <>1__state;

			// Token: 0x04002C7B RID: 11387
			public AsyncTaskMethodBuilder<IEnumerable<cdr>> <>t__builder;

			// Token: 0x04002C7C RID: 11388
			public CustomerCard <>4__this;

			// Token: 0x04002C7D RID: 11389
			private CustomerCard.<>c__DisplayClass238_0 <>8__1;

			// Token: 0x04002C7E RID: 11390
			private GenericRepository<cdr> <repo>5__2;

			// Token: 0x04002C7F RID: 11391
			private TaskAwaiter<IEnumerable<cdr>> <>u__1;
		}
	}
}
