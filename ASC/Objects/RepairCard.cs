using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects.Reports;
using ASC.Options;
using DevExpress.Mvvm;
using DevExpress.XtraReports.UI;

namespace ASC.Objects
{
	// Token: 0x020008E8 RID: 2280
	public class RepairCard : BindableBase, IRepairCard, IRepair
	{
		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x00113654 File Offset: 0x00111854
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x00113668 File Offset: 0x00111868
		public ICustomer Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Customer>k__BackingField, value))
				{
					return;
				}
				this.<Customer>k__BackingField = value;
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x00113698 File Offset: 0x00111898
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x001136AC File Offset: 0x001118AC
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

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x001136D8 File Offset: 0x001118D8
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x001136EC File Offset: 0x001118EC
		public DateTime InDateTime
		{
			[CompilerGenerated]
			get
			{
				return this.<InDateTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<InDateTime>k__BackingField, value))
				{
					return;
				}
				this.<InDateTime>k__BackingField = value;
				this.RaisePropertyChanged("InRepairDays");
				this.RaisePropertyChanged("InDateTime");
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x00113728 File Offset: 0x00111928
		// (set) Token: 0x0600468D RID: 18061 RVA: 0x0011373C File Offset: 0x0011193C
		public int Status
		{
			[CompilerGenerated]
			get
			{
				return this.<Status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Status>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -806462505;
				IL_10:
				switch ((num ^ -1562478018) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					num = -25824386;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
				this.<Status>k__BackingField = value;
				this.RaisePropertyChanged("Status");
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x00113794 File Offset: 0x00111994
		// (set) Token: 0x0600468F RID: 18063 RVA: 0x001137A8 File Offset: 0x001119A8
		public int? DeviceType
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<DeviceType>k__BackingField, value))
				{
					return;
				}
				this.<DeviceType>k__BackingField = value;
				this.RaisePropertyChanged("DeviceType");
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x001137D8 File Offset: 0x001119D8
		// (set) Token: 0x06004691 RID: 18065 RVA: 0x001137EC File Offset: 0x001119EC
		public int? DeviceMaker
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceMaker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<DeviceMaker>k__BackingField, value))
				{
					return;
				}
				this.<DeviceMaker>k__BackingField = value;
				this.RaisePropertyChanged("DeviceMaker");
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x0011381C File Offset: 0x00111A1C
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x00113830 File Offset: 0x00111A30
		public string DeviceModel
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DeviceModel>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DeviceModel>k__BackingField = value;
				this.RaisePropertyChanged("DeviceModel");
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x00113860 File Offset: 0x00111A60
		// (set) Token: 0x06004695 RID: 18069 RVA: 0x00113874 File Offset: 0x00111A74
		public string FullDeviceName
		{
			[CompilerGenerated]
			get
			{
				return this.<FullDeviceName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<FullDeviceName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<FullDeviceName>k__BackingField = value;
				this.RaisePropertyChanged("FullDeviceName");
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x001138A4 File Offset: 0x00111AA4
		// (set) Token: 0x06004697 RID: 18071 RVA: 0x001138B8 File Offset: 0x00111AB8
		public string SerialNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<SerialNumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SerialNumber>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SerialNumber>k__BackingField = value;
				this.RaisePropertyChanged("SerialNumber");
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x001138E8 File Offset: 0x00111AE8
		// (set) Token: 0x06004699 RID: 18073 RVA: 0x001138FC File Offset: 0x00111AFC
		public string BarCode
		{
			[CompilerGenerated]
			get
			{
				return this.<BarCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<BarCode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<BarCode>k__BackingField = value;
				this.RaisePropertyChanged("BarCode");
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x0011392C File Offset: 0x00111B2C
		// (set) Token: 0x0600469B RID: 18075 RVA: 0x00113940 File Offset: 0x00111B40
		public string ExtNotes
		{
			[CompilerGenerated]
			get
			{
				return this.<ExtNotes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ExtNotes>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ExtNotes>k__BackingField = value;
				this.RaisePropertyChanged("ExtNotes");
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x00113970 File Offset: 0x00111B70
		// (set) Token: 0x0600469D RID: 18077 RVA: 0x00113984 File Offset: 0x00111B84
		public int? PrepaidType
		{
			[CompilerGenerated]
			get
			{
				return this.<PrepaidType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<PrepaidType>k__BackingField, value))
				{
					return;
				}
				this.<PrepaidType>k__BackingField = value;
				this.RaisePropertyChanged("PrepaidTypeStr");
				this.RaisePropertyChanged("PrepaidType");
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x001139C0 File Offset: 0x00111BC0
		// (set) Token: 0x0600469F RID: 18079 RVA: 0x001139D4 File Offset: 0x00111BD4
		public decimal? PrepaidSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<PrepaidSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<PrepaidSumm>k__BackingField, value))
				{
					return;
				}
				this.<PrepaidSumm>k__BackingField = value;
				this.RaisePropertyChanged("PrepaidSumm");
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x00113A04 File Offset: 0x00111C04
		// (set) Token: 0x060046A1 RID: 18081 RVA: 0x00113A18 File Offset: 0x00111C18
		public decimal? PreAgreedSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<PreAgreedSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<PreAgreedSumm>k__BackingField, value))
				{
					return;
				}
				this.<PreAgreedSumm>k__BackingField = value;
				this.RaisePropertyChanged("PreAgreedSumm");
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x00113A48 File Offset: 0x00111C48
		// (set) Token: 0x060046A3 RID: 18083 RVA: 0x00113A5C File Offset: 0x00111C5C
		public decimal RealRepairCost
		{
			[CompilerGenerated]
			get
			{
				return this.<RealRepairCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<RealRepairCost>k__BackingField, value))
				{
					return;
				}
				this.<RealRepairCost>k__BackingField = value;
				this.RaisePropertyChanged("RealRepairCostStr");
				this.RaisePropertyChanged("RealRepairCost");
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x00113A98 File Offset: 0x00111C98
		// (set) Token: 0x060046A5 RID: 18085 RVA: 0x00113AAC File Offset: 0x00111CAC
		public int? PreviousRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<PreviousRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<PreviousRepair>k__BackingField, value))
				{
					return;
				}
				this.<PreviousRepair>k__BackingField = value;
				this.RaisePropertyChanged("PreviousRepair");
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x00113ADC File Offset: 0x00111CDC
		// (set) Token: 0x060046A7 RID: 18087 RVA: 0x00113AF0 File Offset: 0x00111CF0
		public bool IsPrepaid
		{
			[CompilerGenerated]
			get
			{
				return this.<IsPrepaid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsPrepaid>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1957401164;
				IL_10:
				switch ((num ^ 1447338717) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 3:
					IL_2F:
					this.<IsPrepaid>k__BackingField = value;
					this.RaisePropertyChanged("IsPrepaid");
					num = 694525139;
					goto IL_10;
				}
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x00113B48 File Offset: 0x00111D48
		// (set) Token: 0x060046A9 RID: 18089 RVA: 0x00113B5C File Offset: 0x00111D5C
		public bool IsPreAgreed
		{
			[CompilerGenerated]
			get
			{
				return this.<IsPreAgreed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsPreAgreed>k__BackingField == value)
				{
					return;
				}
				this.<IsPreAgreed>k__BackingField = value;
				this.RaisePropertyChanged("IsPreAgreed");
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x00113B88 File Offset: 0x00111D88
		// (set) Token: 0x060046AB RID: 18091 RVA: 0x00113B9C File Offset: 0x00111D9C
		public bool IsWarranty
		{
			[CompilerGenerated]
			get
			{
				return this.<IsWarranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsWarranty>k__BackingField == value)
				{
					return;
				}
				this.<IsWarranty>k__BackingField = value;
				this.RaisePropertyChanged("IsWarranty");
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x00113BC8 File Offset: 0x00111DC8
		// (set) Token: 0x060046AD RID: 18093 RVA: 0x00113BDC File Offset: 0x00111DDC
		public bool IsRepeat
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRepeat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRepeat>k__BackingField == value)
				{
					return;
				}
				this.<IsRepeat>k__BackingField = value;
				this.RaisePropertyChanged("IsRepeat");
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x00113C08 File Offset: 0x00111E08
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x00113C1C File Offset: 0x00111E1C
		public bool CanFormat
		{
			[CompilerGenerated]
			get
			{
				return this.<CanFormat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CanFormat>k__BackingField == value)
				{
					return;
				}
				this.<CanFormat>k__BackingField = value;
				this.RaisePropertyChanged("CanFormat");
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x00113C48 File Offset: 0x00111E48
		// (set) Token: 0x060046B1 RID: 18097 RVA: 0x00113C5C File Offset: 0x00111E5C
		public bool ExpressRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<ExpressRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ExpressRepair>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 1352459962;
				IL_10:
				switch ((num ^ 1719766976) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					this.<ExpressRepair>k__BackingField = value;
					this.RaisePropertyChanged("ExpressRepair");
					num = 2116076925;
					goto IL_10;
				}
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x00113CB4 File Offset: 0x00111EB4
		// (set) Token: 0x060046B3 RID: 18099 RVA: 0x00113CC8 File Offset: 0x00111EC8
		public bool ThirdPartySc
		{
			[CompilerGenerated]
			get
			{
				return this.<ThirdPartySc>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ThirdPartySc>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 490219050;
				IL_10:
				switch ((num ^ 1452546849) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<ThirdPartySc>k__BackingField = value;
					this.RaisePropertyChanged("ThirdPartySc");
					num = 880370740;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x00113D20 File Offset: 0x00111F20
		// (set) Token: 0x060046B5 RID: 18101 RVA: 0x00113D34 File Offset: 0x00111F34
		public bool IsQuickRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<IsQuickRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsQuickRepair>k__BackingField == value)
				{
					return;
				}
				this.<IsQuickRepair>k__BackingField = value;
				this.RaisePropertyChanged("IsQuickRepair");
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x00113D60 File Offset: 0x00111F60
		// (set) Token: 0x060046B7 RID: 18103 RVA: 0x00113D74 File Offset: 0x00111F74
		public int CompanyId
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanyId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CompanyId>k__BackingField == value)
				{
					return;
				}
				this.<CompanyId>k__BackingField = value;
				this.RaisePropertyChanged("CompanyId");
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00113DA0 File Offset: 0x00111FA0
		// (set) Token: 0x060046B9 RID: 18105 RVA: 0x00113DB4 File Offset: 0x00111FB4
		public int OfficeId
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OfficeId>k__BackingField == value)
				{
					return;
				}
				this.<OfficeId>k__BackingField = value;
				this.RaisePropertyChanged("OfficeId");
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x00113DE0 File Offset: 0x00111FE0
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x00113DF4 File Offset: 0x00111FF4
		public int? MasterId
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<MasterId>k__BackingField, value))
				{
					return;
				}
				this.<MasterId>k__BackingField = value;
				this.RaisePropertyChanged("MasterId");
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x00113E24 File Offset: 0x00112024
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x00113E38 File Offset: 0x00112038
		public int ManagerId
		{
			[CompilerGenerated]
			get
			{
				return this.<ManagerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ManagerId>k__BackingField == value)
				{
					return;
				}
				this.<ManagerId>k__BackingField = value;
				this.RaisePropertyChanged("ManagerId");
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x00113E64 File Offset: 0x00112064
		// (set) Token: 0x060046BF RID: 18111 RVA: 0x00113E78 File Offset: 0x00112078
		public int? BoxId
		{
			[CompilerGenerated]
			get
			{
				return this.<BoxId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<BoxId>k__BackingField, value))
				{
					return;
				}
				this.<BoxId>k__BackingField = value;
				this.RaisePropertyChanged("BoxId");
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x00113EA8 File Offset: 0x001120A8
		// (set) Token: 0x060046C1 RID: 18113 RVA: 0x00113EBC File Offset: 0x001120BC
		public ObservableCollection<IWorkPartObject> WorksAndParts
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksAndParts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WorksAndParts>k__BackingField, value))
				{
					return;
				}
				this.<WorksAndParts>k__BackingField = value;
				this.RaisePropertyChanged("WorksAndParts");
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x00113EEC File Offset: 0x001120EC
		// (set) Token: 0x060046C3 RID: 18115 RVA: 0x00113F00 File Offset: 0x00112100
		public List<IAttribute> UserFields
		{
			[CompilerGenerated]
			get
			{
				return this.<UserFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UserFields>k__BackingField, value))
				{
					return;
				}
				this.<UserFields>k__BackingField = value;
				this.RaisePropertyChanged("UserFields");
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x00113F30 File Offset: 0x00112130
		// (set) Token: 0x060046C5 RID: 18117 RVA: 0x00113F44 File Offset: 0x00112144
		public Color Color
		{
			[CompilerGenerated]
			get
			{
				return this.<Color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Color>k__BackingField == value)
				{
					return;
				}
				this.<Color>k__BackingField = value;
				this.RaisePropertyChanged("Color");
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x060046C6 RID: 18118 RVA: 0x00113F74 File Offset: 0x00112174
		// (set) Token: 0x060046C7 RID: 18119 RVA: 0x00113F88 File Offset: 0x00112188
		public Color StatusColor
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<StatusColor>k__BackingField == value)
				{
					return;
				}
				this.<StatusColor>k__BackingField = value;
				this.RaisePropertyChanged("StatusColorHtml");
				this.RaisePropertyChanged("StatusColor");
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x00113FC4 File Offset: 0x001121C4
		// (set) Token: 0x060046C9 RID: 18121 RVA: 0x00113FD8 File Offset: 0x001121D8
		public int InformStatus
		{
			[CompilerGenerated]
			get
			{
				return this.<InformStatus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformStatus>k__BackingField == value)
				{
					return;
				}
				this.<InformStatus>k__BackingField = value;
				this.RaisePropertyChanged("InformStatus");
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x00114004 File Offset: 0x00112204
		// (set) Token: 0x060046CB RID: 18123 RVA: 0x00114018 File Offset: 0x00112218
		public string Fault
		{
			[CompilerGenerated]
			get
			{
				return this.<Fault>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Fault>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Fault>k__BackingField = value;
				this.RaisePropertyChanged("Fault");
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x00114048 File Offset: 0x00112248
		// (set) Token: 0x060046CD RID: 18125 RVA: 0x0011405C File Offset: 0x0011225C
		public string Complect
		{
			[CompilerGenerated]
			get
			{
				return this.<Complect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Complect>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Complect>k__BackingField = value;
				this.RaisePropertyChanged("Complect");
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x0011408C File Offset: 0x0011228C
		// (set) Token: 0x060046CF RID: 18127 RVA: 0x001140A0 File Offset: 0x001122A0
		public string Look
		{
			[CompilerGenerated]
			get
			{
				return this.<Look>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Look>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Look>k__BackingField = value;
				this.RaisePropertyChanged("Look");
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x060046D0 RID: 18128 RVA: 0x001140D0 File Offset: 0x001122D0
		// (set) Token: 0x060046D1 RID: 18129 RVA: 0x001140E4 File Offset: 0x001122E4
		public string DiagnosticResult
		{
			[CompilerGenerated]
			get
			{
				return this.<DiagnosticResult>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DiagnosticResult>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DiagnosticResult>k__BackingField = value;
				this.RaisePropertyChanged("DiagnosticResult");
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x00114114 File Offset: 0x00112314
		// (set) Token: 0x060046D3 RID: 18131 RVA: 0x00114128 File Offset: 0x00112328
		public string RejectReason
		{
			[CompilerGenerated]
			get
			{
				return this.<RejectReason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<RejectReason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<RejectReason>k__BackingField = value;
				this.RaisePropertyChanged("RejectReason");
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x060046D4 RID: 18132 RVA: 0x00114158 File Offset: 0x00112358
		// (set) Token: 0x060046D5 RID: 18133 RVA: 0x0011416C File Offset: 0x0011236C
		public decimal RepairCost
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!decimal.Equals(this.<RepairCost>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1991702886;
				IL_13:
				switch ((num ^ 471959496) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					num = 275968193;
					goto IL_13;
				}
				this.<RepairCost>k__BackingField = value;
				this.RaisePropertyChanged("RepairCost");
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x001141C8 File Offset: 0x001123C8
		// (set) Token: 0x060046D7 RID: 18135 RVA: 0x001141DC File Offset: 0x001123DC
		public DateTime? OutDate
		{
			[CompilerGenerated]
			get
			{
				return this.<OutDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<OutDate>k__BackingField, value))
				{
					return;
				}
				this.<OutDate>k__BackingField = value;
				this.RaisePropertyChanged("InRepairDays");
				this.RaisePropertyChanged("OutDate");
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x00114218 File Offset: 0x00112418
		// (set) Token: 0x060046D9 RID: 18137 RVA: 0x0011422C File Offset: 0x0011242C
		public DateTime LastSave
		{
			[CompilerGenerated]
			get
			{
				return this.<LastSave>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<LastSave>k__BackingField, value))
				{
					return;
				}
				this.<LastSave>k__BackingField = value;
				this.RaisePropertyChanged("LastSave");
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x0011425C File Offset: 0x0011245C
		// (set) Token: 0x060046DB RID: 18139 RVA: 0x00114270 File Offset: 0x00112470
		public DateTime LastStatusChange
		{
			[CompilerGenerated]
			get
			{
				return this.<LastStatusChange>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<LastStatusChange>k__BackingField, value))
				{
					return;
				}
				this.<LastStatusChange>k__BackingField = value;
				this.RaisePropertyChanged("LastStatusChange");
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x001142A0 File Offset: 0x001124A0
		// (set) Token: 0x060046DD RID: 18141 RVA: 0x001142B4 File Offset: 0x001124B4
		public string BoxName
		{
			[CompilerGenerated]
			get
			{
				return this.<BoxName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<BoxName>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1440769378;
				IL_14:
				switch ((num ^ -641615741) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					return;
				case 3:
					IL_33:
					this.<BoxName>k__BackingField = value;
					num = -1913027939;
					goto IL_14;
				}
				this.RaisePropertyChanged("BoxName");
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x00114310 File Offset: 0x00112510
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x00114324 File Offset: 0x00112524
		public string StatusName
		{
			[CompilerGenerated]
			get
			{
				return this.<StatusName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<StatusName>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1799611032;
				IL_14:
				switch ((num ^ 1993254879) % 4)
				{
				case 0:
					goto IL_0F;
				case 2:
					IL_33:
					this.<StatusName>k__BackingField = value;
					this.RaisePropertyChanged("StatusName");
					num = 1629318218;
					goto IL_14;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x00114380 File Offset: 0x00112580
		public string StatusColorHtml
		{
			get
			{
				return ColorTranslator.ToHtml(this.StatusColor);
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060046E1 RID: 18145 RVA: 0x00114398 File Offset: 0x00112598
		public string RealRepairCostStr
		{
			get
			{
				return ConvertersStack.SummToString(this.RealRepairCost, Auth.Config.currency);
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x001143BC File Offset: 0x001125BC
		public double InRepairDays
		{
			get
			{
				Localization localization = new Localization("UTC");
				double result;
				try
				{
					DateTime? dateTime;
					double num = Math.Ceiling((((this.OutDate != null) ? dateTime.GetValueOrDefault().Date : localization.NowDate) - this.InDateTime.Date).TotalDays);
					result = ((num < 0.0) ? 0.0 : num);
				}
				catch (Exception)
				{
					result = 0.0;
				}
				return result;
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x060046E3 RID: 18147 RVA: 0x0011445C File Offset: 0x0011265C
		public string PrepaidTypeStr
		{
			get
			{
				int? prepaidType = this.PrepaidType;
				if (prepaidType != null)
				{
					for (;;)
					{
						IL_89:
						int valueOrDefault = prepaidType.GetValueOrDefault();
						for (;;)
						{
							IL_6B:
							switch (valueOrDefault)
							{
							case 1:
								goto IL_93;
							case 2:
								goto IL_9E;
							case 3:
								goto IL_A9;
							case 4:
								goto IL_B4;
							case 5:
								goto IL_BF;
							default:
							{
								uint num2;
								uint num = num2 * 3606941771U ^ 1997923455U;
								for (;;)
								{
									switch ((num2 = (num ^ 1380784601U)) % 10U)
									{
									case 0U:
										goto IL_BF;
									case 1U:
									case 8U:
										goto IL_89;
									case 2U:
										goto IL_93;
									case 3U:
										goto IL_6B;
									case 4U:
										goto IL_9E;
									case 5U:
										num = (num2 * 408373941U ^ 1700224700U);
										continue;
									case 7U:
										goto IL_B4;
									case 9U:
										goto IL_A9;
									}
									goto Block_2;
								}
								break;
							}
							}
						}
					}
					Block_2:
					goto IL_CA;
					IL_93:
					return Lang.t("FullPrepaid");
					IL_9E:
					return Lang.t("PartsPrepaid");
					IL_A9:
					return Lang.t("PartsPartPrepaid");
					IL_B4:
					return Lang.t("WorksPartPreaid");
					IL_BF:
					return Lang.t("DiagnosticPrepaid");
				}
				IL_CA:
				return string.Empty;
			}
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00114538 File Offset: 0x00112738
		public void SetStatusColor()
		{
			WorkshopOptions option = new WorkshopOptions().GetOption(this.Status);
			if (string.IsNullOrEmpty((option != null) ? option.Color : null))
			{
				return;
			}
			if (option.Color.Contains("#00000000"))
			{
				this.StatusColor = Color.Transparent;
				return;
			}
			Color statusColor = ColorTranslator.FromHtml(option.Color);
			this.StatusColor = statusColor;
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x0007E558 File Offset: 0x0007C758
		public void AddWork(IWorkPartObject work)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x0007E558 File Offset: 0x0007C758
		public void AddPart(IWorkPartObject part)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x0007E558 File Offset: 0x0007C758
		public void RemoveWork(IWorkPartObject work)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x0007E558 File Offset: 0x0007C758
		public void RemovePart(IWorkPartObject part)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x0011459C File Offset: 0x0011279C
		public Task<XtraReport> CreateReport(string name, int stickersCopy = 1)
		{
			RepairCard.<CreateReport>d__193 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.<>4__this = this;
			<CreateReport>d__.name = name;
			<CreateReport>d__.stickersCopy = stickersCopy;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<RepairCard.<CreateReport>d__193>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x001145F0 File Offset: 0x001127F0
		public Task<XtraReport> CreateLostReport(string document, string docNum)
		{
			RepairCard.<CreateLostReport>d__194 <CreateLostReport>d__;
			<CreateLostReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateLostReport>d__.<>4__this = this;
			<CreateLostReport>d__.document = document;
			<CreateLostReport>d__.docNum = docNum;
			<CreateLostReport>d__.<>1__state = -1;
			<CreateLostReport>d__.<>t__builder.Start<RepairCard.<CreateLostReport>d__194>(ref <CreateLostReport>d__);
			return <CreateLostReport>d__.<>t__builder.Task;
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x000069B8 File Offset: 0x00004BB8
		public RepairCard()
		{
		}

		// Token: 0x04002D50 RID: 11600
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;

		// Token: 0x04002D51 RID: 11601
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002D52 RID: 11602
		[CompilerGenerated]
		private DateTime <InDateTime>k__BackingField;

		// Token: 0x04002D53 RID: 11603
		[CompilerGenerated]
		private int <Status>k__BackingField;

		// Token: 0x04002D54 RID: 11604
		[CompilerGenerated]
		private int? <DeviceType>k__BackingField;

		// Token: 0x04002D55 RID: 11605
		[CompilerGenerated]
		private int? <DeviceMaker>k__BackingField;

		// Token: 0x04002D56 RID: 11606
		[CompilerGenerated]
		private string <DeviceModel>k__BackingField;

		// Token: 0x04002D57 RID: 11607
		[CompilerGenerated]
		private string <FullDeviceName>k__BackingField;

		// Token: 0x04002D58 RID: 11608
		[CompilerGenerated]
		private string <SerialNumber>k__BackingField;

		// Token: 0x04002D59 RID: 11609
		[CompilerGenerated]
		private string <BarCode>k__BackingField;

		// Token: 0x04002D5A RID: 11610
		[CompilerGenerated]
		private string <ExtNotes>k__BackingField;

		// Token: 0x04002D5B RID: 11611
		[CompilerGenerated]
		private int? <PrepaidType>k__BackingField;

		// Token: 0x04002D5C RID: 11612
		[CompilerGenerated]
		private decimal? <PrepaidSumm>k__BackingField;

		// Token: 0x04002D5D RID: 11613
		[CompilerGenerated]
		private decimal? <PreAgreedSumm>k__BackingField;

		// Token: 0x04002D5E RID: 11614
		[CompilerGenerated]
		private decimal <RealRepairCost>k__BackingField;

		// Token: 0x04002D5F RID: 11615
		[CompilerGenerated]
		private int? <PreviousRepair>k__BackingField;

		// Token: 0x04002D60 RID: 11616
		[CompilerGenerated]
		private bool <IsPrepaid>k__BackingField;

		// Token: 0x04002D61 RID: 11617
		[CompilerGenerated]
		private bool <IsPreAgreed>k__BackingField;

		// Token: 0x04002D62 RID: 11618
		[CompilerGenerated]
		private bool <IsWarranty>k__BackingField;

		// Token: 0x04002D63 RID: 11619
		[CompilerGenerated]
		private bool <IsRepeat>k__BackingField;

		// Token: 0x04002D64 RID: 11620
		[CompilerGenerated]
		private bool <CanFormat>k__BackingField;

		// Token: 0x04002D65 RID: 11621
		[CompilerGenerated]
		private bool <ExpressRepair>k__BackingField;

		// Token: 0x04002D66 RID: 11622
		[CompilerGenerated]
		private bool <ThirdPartySc>k__BackingField;

		// Token: 0x04002D67 RID: 11623
		[CompilerGenerated]
		private bool <IsQuickRepair>k__BackingField;

		// Token: 0x04002D68 RID: 11624
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04002D69 RID: 11625
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04002D6A RID: 11626
		[CompilerGenerated]
		private int? <MasterId>k__BackingField;

		// Token: 0x04002D6B RID: 11627
		[CompilerGenerated]
		private int <ManagerId>k__BackingField;

		// Token: 0x04002D6C RID: 11628
		[CompilerGenerated]
		private int? <BoxId>k__BackingField;

		// Token: 0x04002D6D RID: 11629
		[CompilerGenerated]
		private ObservableCollection<IWorkPartObject> <WorksAndParts>k__BackingField;

		// Token: 0x04002D6E RID: 11630
		[CompilerGenerated]
		private List<IAttribute> <UserFields>k__BackingField;

		// Token: 0x04002D6F RID: 11631
		[CompilerGenerated]
		private Color <Color>k__BackingField;

		// Token: 0x04002D70 RID: 11632
		[CompilerGenerated]
		private Color <StatusColor>k__BackingField;

		// Token: 0x04002D71 RID: 11633
		[CompilerGenerated]
		private int <InformStatus>k__BackingField;

		// Token: 0x04002D72 RID: 11634
		[CompilerGenerated]
		private string <Fault>k__BackingField;

		// Token: 0x04002D73 RID: 11635
		[CompilerGenerated]
		private string <Complect>k__BackingField;

		// Token: 0x04002D74 RID: 11636
		[CompilerGenerated]
		private string <Look>k__BackingField;

		// Token: 0x04002D75 RID: 11637
		[CompilerGenerated]
		private string <DiagnosticResult>k__BackingField;

		// Token: 0x04002D76 RID: 11638
		[CompilerGenerated]
		private string <RejectReason>k__BackingField;

		// Token: 0x04002D77 RID: 11639
		[CompilerGenerated]
		private decimal <RepairCost>k__BackingField;

		// Token: 0x04002D78 RID: 11640
		[CompilerGenerated]
		private DateTime? <OutDate>k__BackingField;

		// Token: 0x04002D79 RID: 11641
		[CompilerGenerated]
		private DateTime <LastSave>k__BackingField;

		// Token: 0x04002D7A RID: 11642
		[CompilerGenerated]
		private DateTime <LastStatusChange>k__BackingField;

		// Token: 0x04002D7B RID: 11643
		[CompilerGenerated]
		private string <BoxName>k__BackingField;

		// Token: 0x04002D7C RID: 11644
		[CompilerGenerated]
		private string <StatusName>k__BackingField;

		// Token: 0x020008E9 RID: 2281
		[CompilerGenerated]
		private sealed class <>c__DisplayClass193_0
		{
			// Token: 0x060046EC RID: 18156 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass193_0()
			{
			}

			// Token: 0x04002D7D RID: 11645
			public string name;
		}

		// Token: 0x020008EA RID: 2282
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__193 : IAsyncStateMachine
		{
			// Token: 0x060046ED RID: 18157 RVA: 0x00114644 File Offset: 0x00112844
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCard repairCard = this.<>4__this;
				XtraReport result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new RepairCard.<>c__DisplayClass193_0();
						this.<>8__1.name = this.name;
						this.<report>5__2 = new XtraReport();
					}
					try
					{
						if (num != 0)
						{
							this.<history>5__3 = new HistoryV2();
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<doc_templates> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__4.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == this.<>8__1.name).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, RepairCard.<CreateReport>d__193>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<doc_templates>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							doc_templates result = awaiter.GetResult();
							if (result == null)
							{
								result2 = this.<report>5__2;
								goto IL_269;
							}
							string @string = Encoding.UTF8.GetString(result.data);
							this.<report>5__2.Tag = result.id;
							this.<report>5__2.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
							RepairReport item = new RepairReport(repairCard);
							List<RepairReport> list = new List<RepairReport>
							{
								item
							};
							if (this.<>8__1.name == "rep_label")
							{
								for (int i = 1; i < this.stickersCopy; i++)
								{
									list.Add(item);
								}
							}
							this.<report>5__2.DataSource = list;
							this.<history>5__3.AddRepairLog("print_" + this.<>8__1.name, repairCard.Id, null, null, null, null, null, null);
							this.<report>5__2.CreateDocument();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
						this.<ctx>5__4 = null;
						this.<history>5__3.Save();
						this.<history>5__3 = null;
					}
					catch (Exception)
					{
					}
					result2 = this.<report>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_269:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060046EE RID: 18158 RVA: 0x00114928 File Offset: 0x00112B28
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002D7E RID: 11646
			public int <>1__state;

			// Token: 0x04002D7F RID: 11647
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x04002D80 RID: 11648
			public string name;

			// Token: 0x04002D81 RID: 11649
			public RepairCard <>4__this;

			// Token: 0x04002D82 RID: 11650
			private RepairCard.<>c__DisplayClass193_0 <>8__1;

			// Token: 0x04002D83 RID: 11651
			public int stickersCopy;

			// Token: 0x04002D84 RID: 11652
			private XtraReport <report>5__2;

			// Token: 0x04002D85 RID: 11653
			private HistoryV2 <history>5__3;

			// Token: 0x04002D86 RID: 11654
			private auseceEntities <ctx>5__4;

			// Token: 0x04002D87 RID: 11655
			private TaskAwaiter<doc_templates> <>u__1;
		}

		// Token: 0x020008EB RID: 2283
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060046EF RID: 18159 RVA: 0x00114944 File Offset: 0x00112B44
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060046F0 RID: 18160 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002D88 RID: 11656
			public static readonly RepairCard.<>c <>9 = new RepairCard.<>c();
		}

		// Token: 0x020008EC RID: 2284
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateLostReport>d__194 : IAsyncStateMachine
		{
			// Token: 0x060046F1 RID: 18161 RVA: 0x0011495C File Offset: 0x00112B5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCard repairCard = this.<>4__this;
				XtraReport result2;
				try
				{
					if (num != 0)
					{
						this.<report>5__2 = new XtraReport();
					}
					try
					{
						if (num != 0)
						{
							this.<history>5__3 = new HistoryV2();
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<doc_templates> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__4.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == "lost").GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, RepairCard.<CreateLostReport>d__194>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<doc_templates>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							doc_templates result = awaiter.GetResult();
							if (result == null)
							{
								result2 = this.<report>5__2;
								goto IL_22D;
							}
							string @string = Encoding.UTF8.GetString(result.data);
							this.<report>5__2.Tag = result.id;
							this.<report>5__2.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
							RepairLostDocReport repairLostDocReport = new RepairLostDocReport(repairCard);
							repairLostDocReport.SetDocumentName(this.document);
							repairLostDocReport.SetDocumentNumber(this.docNum);
							this.<report>5__2.DataSource = new List<RepairLostDocReport>
							{
								repairLostDocReport
							};
							this.<history>5__3.AddRepairLog("print_lost", repairCard.Id, null, null, null, null, null, new string[]
							{
								repairLostDocReport.Customer.FioOrUrName,
								this.document,
								this.document
							});
							this.<report>5__2.CreateDocument();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
						this.<ctx>5__4 = null;
						this.<history>5__3.Save();
						this.<history>5__3 = null;
					}
					catch (Exception)
					{
					}
					result2 = this.<report>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_22D:
				this.<>1__state = -2;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060046F2 RID: 18162 RVA: 0x00114C00 File Offset: 0x00112E00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002D89 RID: 11657
			public int <>1__state;

			// Token: 0x04002D8A RID: 11658
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x04002D8B RID: 11659
			public RepairCard <>4__this;

			// Token: 0x04002D8C RID: 11660
			public string document;

			// Token: 0x04002D8D RID: 11661
			public string docNum;

			// Token: 0x04002D8E RID: 11662
			private XtraReport <report>5__2;

			// Token: 0x04002D8F RID: 11663
			private HistoryV2 <history>5__3;

			// Token: 0x04002D90 RID: 11664
			private auseceEntities <ctx>5__4;

			// Token: 0x04002D91 RID: 11665
			private TaskAwaiter<doc_templates> <>u__1;
		}
	}
}
