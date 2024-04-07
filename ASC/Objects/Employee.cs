using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.Options;
using DevExpress.Mvvm;
using NLog;

namespace ASC.Objects
{
	// Token: 0x020008CB RID: 2251
	public class Employee : BindableBase, IEmployee
	{
		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x0010ECA4 File Offset: 0x0010CEA4
		// (set) Token: 0x06004519 RID: 17689 RVA: 0x0010ECB8 File Offset: 0x0010CEB8
		public DateTime? LastLogin
		{
			[CompilerGenerated]
			get
			{
				return this.<LastLogin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<LastLogin>k__BackingField, value))
				{
					return;
				}
				this.<LastLogin>k__BackingField = value;
				this.RaisePropertyChanged("LastLogin");
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x0010ECE8 File Offset: 0x0010CEE8
		// (set) Token: 0x0600451B RID: 17691 RVA: 0x0010ECFC File Offset: 0x0010CEFC
		public DateTime? LastActivity
		{
			[CompilerGenerated]
			get
			{
				return this.<LastActivity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<LastActivity>k__BackingField, value))
				{
					return;
				}
				this.<LastActivity>k__BackingField = value;
				this.RaisePropertyChanged("LastActivity");
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x0010ED2C File Offset: 0x0010CF2C
		// (set) Token: 0x0600451D RID: 17693 RVA: 0x0010ED40 File Offset: 0x0010CF40
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
				if (this.<Id>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -383797469;
				IL_10:
				switch ((num ^ -173543595) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					this.<Id>k__BackingField = value;
					num = -1444920908;
					goto IL_10;
				}
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x0600451E RID: 17694 RVA: 0x0010ED98 File Offset: 0x0010CF98
		// (set) Token: 0x0600451F RID: 17695 RVA: 0x0010EDAC File Offset: 0x0010CFAC
		public string Login
		{
			[CompilerGenerated]
			get
			{
				return this.<Login>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Login>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Login>k__BackingField = value;
				this.RaisePropertyChanged("Login");
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x0010EDDC File Offset: 0x0010CFDC
		// (set) Token: 0x06004521 RID: 17697 RVA: 0x0010EDF0 File Offset: 0x0010CFF0
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

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x0010EE1C File Offset: 0x0010D01C
		// (set) Token: 0x06004523 RID: 17699 RVA: 0x0010EE30 File Offset: 0x0010D030
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
				this.RaisePropertyChanged("Fio");
				this.RaisePropertyChanged("FioShort");
				this.RaisePropertyChanged("FirstName");
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004524 RID: 17700 RVA: 0x0010EE78 File Offset: 0x0010D078
		// (set) Token: 0x06004525 RID: 17701 RVA: 0x0010EE8C File Offset: 0x0010D08C
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
				this.RaisePropertyChanged("Fio");
				this.RaisePropertyChanged("FioShort");
				this.RaisePropertyChanged("LastName");
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004526 RID: 17702 RVA: 0x0010EED4 File Offset: 0x0010D0D4
		// (set) Token: 0x06004527 RID: 17703 RVA: 0x0010EEE8 File Offset: 0x0010D0E8
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
				this.RaisePropertyChanged("Fio");
				this.RaisePropertyChanged("FioShort");
				this.RaisePropertyChanged("Patronymic");
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x0010EF30 File Offset: 0x0010D130
		public string Fio
		{
			get
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
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x0010EF74 File Offset: 0x0010D174
		// (set) Token: 0x0600452A RID: 17706 RVA: 0x0010EF88 File Offset: 0x0010D188
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
				int num = 760364258;
				IL_10:
				switch ((num ^ 999159709) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					num = 213525391;
					goto IL_10;
				case 3:
					return;
				}
				this.<State>k__BackingField = value;
				this.RaisePropertyChanged("State");
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x0600452B RID: 17707 RVA: 0x0010EFE0 File Offset: 0x0010D1E0
		// (set) Token: 0x0600452C RID: 17708 RVA: 0x0010EFF4 File Offset: 0x0010D1F4
		public bool TrackActivity
		{
			[CompilerGenerated]
			get
			{
				return this.<TrackActivity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TrackActivity>k__BackingField == value)
				{
					return;
				}
				this.<TrackActivity>k__BackingField = value;
				this.RaisePropertyChanged("TrackActivity");
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x0010F020 File Offset: 0x0010D220
		// (set) Token: 0x0600452E RID: 17710 RVA: 0x0010F034 File Offset: 0x0010D234
		public bool DisplayCustomerOnCall
		{
			[CompilerGenerated]
			get
			{
				return this.<DisplayCustomerOnCall>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DisplayCustomerOnCall>k__BackingField == value)
				{
					return;
				}
				this.<DisplayCustomerOnCall>k__BackingField = value;
				this.RaisePropertyChanged("DisplayCustomerOnCall");
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x0010F060 File Offset: 0x0010D260
		// (set) Token: 0x06004530 RID: 17712 RVA: 0x0010F074 File Offset: 0x0010D274
		public int? KktPassword
		{
			[CompilerGenerated]
			get
			{
				return this.<KktPassword>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<KktPassword>k__BackingField, value))
				{
					return;
				}
				this.<KktPassword>k__BackingField = value;
				this.RaisePropertyChanged("KktPassword");
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x0010F0A4 File Offset: 0x0010D2A4
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x0010F0B8 File Offset: 0x0010D2B8
		public int WorkshopDefaultOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopDefaultOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WorkshopDefaultOffice>k__BackingField == value)
				{
					return;
				}
				this.<WorkshopDefaultOffice>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopDefaultOffice");
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x0010F0E4 File Offset: 0x0010D2E4
		// (set) Token: 0x06004534 RID: 17716 RVA: 0x0010F0F8 File Offset: 0x0010D2F8
		public int? WorkshopDefaultStatus
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopDefaultStatus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<WorkshopDefaultStatus>k__BackingField, value))
				{
					return;
				}
				this.<WorkshopDefaultStatus>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopDefaultStatus");
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x0010F128 File Offset: 0x0010D328
		// (set) Token: 0x06004536 RID: 17718 RVA: 0x0010F13C File Offset: 0x0010D33C
		public int WorkshopDefDevType
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopDefDevType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WorkshopDefDevType>k__BackingField == value)
				{
					return;
				}
				this.<WorkshopDefDevType>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopDefDevType");
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x0010F168 File Offset: 0x0010D368
		// (set) Token: 0x06004538 RID: 17720 RVA: 0x0010F17C File Offset: 0x0010D37C
		public int WorkshopDefaultEmployee
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopDefaultEmployee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WorkshopDefaultEmployee>k__BackingField == value)
				{
					return;
				}
				this.<WorkshopDefaultEmployee>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopDefaultEmployee");
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x0010F1A8 File Offset: 0x0010D3A8
		// (set) Token: 0x0600453A RID: 17722 RVA: 0x0010F1BC File Offset: 0x0010D3BC
		public int StoreDefault
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreDefault>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<StoreDefault>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -913224375;
				IL_10:
				switch ((num ^ -2006158637) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<StoreDefault>k__BackingField = value;
					this.RaisePropertyChanged("StoreDefault");
					num = -385967420;
					goto IL_10;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x0010F214 File Offset: 0x0010D414
		// (set) Token: 0x0600453C RID: 17724 RVA: 0x0010F228 File Offset: 0x0010D428
		public int StoreDefaultItemState
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreDefaultItemState>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<StoreDefaultItemState>k__BackingField == value)
				{
					return;
				}
				this.<StoreDefaultItemState>k__BackingField = value;
				this.RaisePropertyChanged("StoreDefaultItemState");
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x0010F254 File Offset: 0x0010D454
		// (set) Token: 0x0600453E RID: 17726 RVA: 0x0010F268 File Offset: 0x0010D468
		public bool GroupByArticul
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupByArticul>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<GroupByArticul>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1075672300;
				IL_10:
				switch ((num ^ -1594190841) % 4)
				{
				case 0:
					IL_2F:
					this.<GroupByArticul>k__BackingField = value;
					num = -1265941042;
					goto IL_10;
				case 2:
					goto IL_0B;
				case 3:
					return;
				}
				this.RaisePropertyChanged("GroupByArticul");
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x0010F2C0 File Offset: 0x0010D4C0
		// (set) Token: 0x06004540 RID: 17728 RVA: 0x0010F2D4 File Offset: 0x0010D4D4
		public bool PreviewReports
		{
			[CompilerGenerated]
			get
			{
				return this.<PreviewReports>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PreviewReports>k__BackingField == value)
				{
					return;
				}
				this.<PreviewReports>k__BackingField = value;
				this.RaisePropertyChanged("PreviewReports");
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x0010F300 File Offset: 0x0010D500
		// (set) Token: 0x06004542 RID: 17730 RVA: 0x0010F314 File Offset: 0x0010D514
		public bool OverviewAfterSave
		{
			[CompilerGenerated]
			get
			{
				return this.<OverviewAfterSave>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OverviewAfterSave>k__BackingField == value)
				{
					return;
				}
				this.<OverviewAfterSave>k__BackingField = value;
				this.RaisePropertyChanged("OverviewAfterSave");
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x0010F340 File Offset: 0x0010D540
		// (set) Token: 0x06004544 RID: 17732 RVA: 0x0010F354 File Offset: 0x0010D554
		public int? Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<Tel>k__BackingField, value))
				{
					return;
				}
				this.<Tel>k__BackingField = value;
				this.RaisePropertyChanged("Tel");
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x0010F384 File Offset: 0x0010D584
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x0010F398 File Offset: 0x0010D598
		public IUISettings UiSettings
		{
			[CompilerGenerated]
			get
			{
				return this.<UiSettings>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UiSettings>k__BackingField, value))
				{
					return;
				}
				this.<UiSettings>k__BackingField = value;
				this.RaisePropertyChanged("UiSettings");
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x0010F3C8 File Offset: 0x0010D5C8
		// (set) Token: 0x06004548 RID: 17736 RVA: 0x0010F3DC File Offset: 0x0010D5DC
		public IKKT Kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<Kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Kkt>k__BackingField, value))
				{
					return;
				}
				this.<Kkt>k__BackingField = value;
				this.RaisePropertyChanged("Kkt");
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x0010F40C File Offset: 0x0010D60C
		// (set) Token: 0x0600454A RID: 17738 RVA: 0x0010F420 File Offset: 0x0010D620
		public IPinpad Pinpad
		{
			[CompilerGenerated]
			get
			{
				return this.<Pinpad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Pinpad>k__BackingField, value))
				{
					return;
				}
				this.<Pinpad>k__BackingField = value;
				this.RaisePropertyChanged("Pinpad");
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x0010F450 File Offset: 0x0010D650
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x0010F464 File Offset: 0x0010D664
		public IOffice Office
		{
			[CompilerGenerated]
			get
			{
				return this.<Office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Office>k__BackingField, value))
				{
					return;
				}
				this.<Office>k__BackingField = value;
				this.RaisePropertyChanged("Office");
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x0010F494 File Offset: 0x0010D694
		// (set) Token: 0x0600454E RID: 17742 RVA: 0x0010F4A8 File Offset: 0x0010D6A8
		public IList<int> Roles
		{
			[CompilerGenerated]
			get
			{
				return this.<Roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Roles>k__BackingField, value))
				{
					return;
				}
				this.<Roles>k__BackingField = value;
				this.RaisePropertyChanged("Roles");
			}
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x0010F4D8 File Offset: 0x0010D6D8
		public bool KktReady()
		{
			return this.Kkt != null;
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x0010F4F0 File Offset: 0x0010D6F0
		public bool PinpadReady()
		{
			return this.Pinpad != null;
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x0010F508 File Offset: 0x0010D708
		public string FioShort
		{
			get
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
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06004552 RID: 17746 RVA: 0x0010F558 File Offset: 0x0010D758
		// (set) Token: 0x06004553 RID: 17747 RVA: 0x0010F56C File Offset: 0x0010D76C
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
				if (string.Equals(this.<Inn>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Inn>k__BackingField = value;
				this.RaisePropertyChanged("Inn");
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x0010F59C File Offset: 0x0010D79C
		// (set) Token: 0x06004555 RID: 17749 RVA: 0x0010F5B0 File Offset: 0x0010D7B0
		public string Signature
		{
			[CompilerGenerated]
			get
			{
				return this.<Signature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Signature>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Signature>k__BackingField = value;
				this.RaisePropertyChanged("Signature");
			}
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x0010F5E0 File Offset: 0x0010D7E0
		public Employee()
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x0010F600 File Offset: 0x0010D800
		public void SetUiSettings(IUISettings s)
		{
			this.UiSettings.SetSettings(s);
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x0010F61C File Offset: 0x0010D81C
		public bool IsTrackActivity()
		{
			return this.TrackActivity;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x0010F630 File Offset: 0x0010D830
		public bool Can(WorkshopOptions status)
		{
			return status.Roles.Any((int role) => this.Roles.Contains(role));
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x0010F654 File Offset: 0x0010D854
		public bool Can(WorkshopStatus status)
		{
			WorkshopOptions workshopOptions = new WorkshopOptions().GetAllOptions().FirstOrDefault((WorkshopOptions i) => i.Id == (int)status);
			return workshopOptions != null && workshopOptions.Roles.Any((int role) => this.Roles.Contains(role));
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x0010F6B0 File Offset: 0x0010D8B0
		public bool Can(int permissionId, int uid = 0)
		{
			try
			{
				if (\u206A\u206B\u200D\u202A\u206B\u202B\u202C\u200D\u206D\u206E\u200D\u200B\u202C\u202B\u200C\u200B\u200C\u202A\u202C\u202E\u200C\u206B\u200C\u200E\u206E\u200B\u200B\u202A\u200B\u202D\u200F\u202E\u206B\u206B\u202A\u202C\u200B\u200F\u202E\u202D\u202E.\u202E\u202E\u206C\u200B\u202E\u206D\u200B\u206E\u206A\u206F\u200E\u206B\u206E\u200F\u206D\u202B\u200F\u206C\u206F\u202C\u202B\u200E\u202C\u206C\u206E\u206C\u202C\u200B\u202B\u206C\u206F\u200F\u200E\u206F\u206D\u200B\u200C\u202B\u202A\u206F\u202E != null && \u206A\u206B\u200D\u202A\u206B\u202B\u202C\u200D\u206D\u206E\u200D\u200B\u202C\u202B\u200C\u200B\u200C\u202A\u202C\u202E\u200C\u206B\u200C\u200E\u206E\u200B\u200B\u202A\u200B\u202D\u200F\u202E\u206B\u206B\u202A\u202C\u200B\u200F\u202E\u202D\u202E.\u202E\u202E\u206C\u200B\u202E\u206D\u200B\u206E\u206A\u206F\u200E\u206B\u206E\u200F\u206D\u202B\u200F\u206C\u206F\u202C\u202B\u200E\u202C\u206C\u206E\u206C\u202C\u200B\u202B\u206C\u206F\u200F\u200E\u206F\u206D\u200B\u200C\u202B\u202A\u206F\u202E.Any<\u206C\u206A\u206B\u202C\u202A\u200F\u206C\u206A\u206D\u200C\u200B\u202B\u206C\u202A\u206E\u200B\u200C\u206C\u202E\u202D\u206F\u202A\u200D\u200F\u206C\u200F\u200C\u206B\u200B\u206D\u202A\u206C\u202A\u206A\u202B\u206C\u202D\u206E\u202C\u200D\u202E>())
				{
					\u206C\u206A\u206B\u202C\u202A\u200F\u206C\u206A\u206D\u200C\u200B\u202B\u206C\u202A\u206E\u200B\u200C\u206C\u202E\u202D\u206F\u202A\u200D\u200F\u206C\u200F\u200C\u206B\u200B\u206D\u202A\u206C\u202A\u206A\u202B\u206C\u202D\u206E\u202C\u200D\u202E u206C_u206A_u206B_u202C_u202A_u200F_u206C_u206A_u206D_u200C_u200B_u202B_u206C_u202A_u206E_u200B_u200C_u206C_u202E_u202D_u206F_u202A_u200D_u200F_u206C_u200F_u200C_u206B_u200B_u206D_u202A_u206C_u202A_u206A_u202B_u206C_u202D_u206E_u202C_u200D_u202E = \u206A\u206B\u200D\u202A\u206B\u202B\u202C\u200D\u206D\u206E\u200D\u200B\u202C\u202B\u200C\u200B\u200C\u202A\u202C\u202E\u200C\u206B\u200C\u200E\u206E\u200B\u200B\u202A\u200B\u202D\u200F\u202E\u206B\u206B\u202A\u202C\u200B\u200F\u202E\u202D\u202E.\u202E\u202E\u206C\u200B\u202E\u206D\u200B\u206E\u206A\u206F\u200E\u206B\u206E\u200F\u206D\u202B\u200F\u206C\u206F\u202C\u202B\u200E\u202C\u206C\u206E\u206C\u202C\u200B\u202B\u206C\u206F\u200F\u200E\u206F\u206D\u200B\u200C\u202B\u202A\u206F\u202E.FirstOrDefault((\u206C\u206A\u206B\u202C\u202A\u200F\u206C\u206A\u206D\u200C\u200B\u202B\u206C\u202A\u206E\u200B\u200C\u206C\u202E\u202D\u206F\u202A\u200D\u200F\u206C\u200F\u200C\u206B\u200B\u206D\u202A\u206C\u202A\u206A\u202B\u206C\u202D\u206E\u202C\u200D\u202E p) => p != null && p.\u206B\u206F\u200F\u206C\u200D\u200D\u200B\u202A\u200C\u202C\u206C\u206A\u200E\u200C\u200C\u200C\u200B\u202D\u200B\u202A\u206F\u206B\u202C\u200C\u206D\u206A\u206B\u206E\u206D\u200C\u200F\u206D\u200E\u200D\u206F\u206A\u202A\u206D\u202D\u200F\u202E == permissionId);
					if (u206C_u206A_u206B_u202C_u202A_u200F_u206C_u206A_u206D_u200C_u200B_u202B_u206C_u202A_u206E_u200B_u200C_u206C_u202E_u202D_u206F_u202A_u200D_u200F_u206C_u200F_u200C_u206B_u200B_u206D_u202A_u206C_u202A_u206A_u202B_u206C_u202D_u206E_u202C_u200D_u202E != null)
					{
						return u206C_u206A_u206B_u202C_u202A_u200F_u206C_u206A_u206D_u200C_u200B_u202B_u206C_u202A_u206E_u200B_u200C_u206C_u202E_u202D_u206F_u202A_u200D_u200F_u206C_u200F_u200C_u206B_u200B_u206D_u202A_u206C_u202A_u206A_u202B_u206C_u202D_u206E_u202C_u200D_u202E.\u200E\u202A\u206B\u200C\u200F\u202C\u206D\u200E\u206D\u202A\u206B\u206A\u206C\u202B\u202C\u206E\u200C\u200E\u206F\u200E\u206E\u206B\u206C\u202D\u206F\u202D\u206E\u200E\u202C\u206E\u206E\u202B\u206F\u206B\u200C\u206D\u202B\u206F\u206D\u202D\u202E;
					}
				}
			}
			catch (Exception exception)
			{
				Employee.Log.Error(exception, "Permissions cache error");
			}
			bool result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				try
				{
					int userId = (uid == 0) ? this.Id : uid;
					bool flag = (from pr in auseceEntities.permissions_roles
					join ru in auseceEntities.roles_users on pr.role_id equals ru.role_id
					where ru.user_id == userId && pr.permission_id == permissionId
					select pr).FirstOrDefault<permissions_roles>() != null;
					if (\u206A\u206B\u200D\u202A\u206B\u202B\u202C\u200D\u206D\u206E\u200D\u200B\u202C\u202B\u200C\u200B\u200C\u202A\u202C\u202E\u200C\u206B\u200C\u200E\u206E\u200B\u200B\u202A\u200B\u202D\u200F\u202E\u206B\u206B\u202A\u202C\u200B\u200F\u202E\u202D\u202E.\u202E\u202E\u206C\u200B\u202E\u206D\u200B\u206E\u206A\u206F\u200E\u206B\u206E\u200F\u206D\u202B\u200F\u206C\u206F\u202C\u202B\u200E\u202C\u206C\u206E\u206C\u202C\u200B\u202B\u206C\u206F\u200F\u200E\u206F\u206D\u200B\u200C\u202B\u202A\u206F\u202E != null)
					{
						\u206A\u206B\u200D\u202A\u206B\u202B\u202C\u200D\u206D\u206E\u200D\u200B\u202C\u202B\u200C\u200B\u200C\u202A\u202C\u202E\u200C\u206B\u200C\u200E\u206E\u200B\u200B\u202A\u200B\u202D\u200F\u202E\u206B\u206B\u202A\u202C\u200B\u200F\u202E\u202D\u202E.\u202E\u202E\u206C\u200B\u202E\u206D\u200B\u206E\u206A\u206F\u200E\u206B\u206E\u200F\u206D\u202B\u200F\u206C\u206F\u202C\u202B\u200E\u202C\u206C\u206E\u206C\u202C\u200B\u202B\u206C\u206F\u200F\u200E\u206F\u206D\u200B\u200C\u202B\u202A\u206F\u202E.Add(new \u206C\u206A\u206B\u202C\u202A\u200F\u206C\u206A\u206D\u200C\u200B\u202B\u206C\u202A\u206E\u200B\u200C\u206C\u202E\u202D\u206F\u202A\u200D\u200F\u206C\u200F\u200C\u206B\u200B\u206D\u202A\u206C\u202A\u206A\u202B\u206C\u202D\u206E\u202C\u200D\u202E(permissionId, flag));
					}
					result = flag;
				}
				catch (Exception ex)
				{
					\u206A\u206B\u200D\u202A\u206B\u202B\u202C\u200D\u206D\u206E\u200D\u200B\u202C\u202B\u200C\u200B\u200C\u202A\u202C\u202E\u200C\u206B\u200C\u200E\u206E\u200B\u200B\u202A\u200B\u202D\u200F\u202E\u206B\u206B\u202A\u202C\u200B\u200F\u202E\u202D\u202E.\u200F\u206F\u206D\u206A\u206D\u200B\u206B\u202B\u202B\u206F\u200F\u206B\u206D\u202D\u200E\u200C\u202A\u202C\u202E\u202E\u200E\u202B\u200C\u206B\u202E\u202A\u202B\u202A\u206C\u202B\u206B\u206B\u200C\u206E\u200E\u202A\u206B\u200B\u202A\u206D\u202E();
					ILogger log = Employee.Log;
					string str = "Permissions load error ";
					Exception ex2 = ex;
					log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0010FA54 File Offset: 0x0010DC54
		public Task<bool> RestoreUiDefaults()
		{
			Employee.<RestoreUiDefaults>d__129 <RestoreUiDefaults>d__;
			<RestoreUiDefaults>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<RestoreUiDefaults>d__.<>4__this = this;
			<RestoreUiDefaults>d__.<>1__state = -1;
			<RestoreUiDefaults>d__.<>t__builder.Start<Employee.<RestoreUiDefaults>d__129>(ref <RestoreUiDefaults>d__);
			return <RestoreUiDefaults>d__.<>t__builder.Task;
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x0010FA98 File Offset: 0x0010DC98
		public bool SaveUiSettings(IUISettings settings)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					users users = auseceEntities.users.Find(new object[]
					{
						this.Id
					});
					users.row_color = settings.RowColor;
					users.ge_highlight_color = settings.GeHighlightColor;
					users.issued_color = settings.IssuedRowColor;
					users.fontsize = settings.FontSize;
					users.rowheight = settings.RowHeight;
					auseceEntities.SaveChanges();
					this.SetUiSettings(settings);
				}
				return true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x0010FB48 File Offset: 0x0010DD48
		// Note: this type is marked as 'beforefieldinit'.
		static Employee()
		{
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x0010FB60 File Offset: 0x0010DD60
		[CompilerGenerated]
		private bool <Can>b__126_0(int role)
		{
			return this.Roles.Contains(role);
		}

		// Token: 0x04002C80 RID: 11392
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04002C81 RID: 11393
		[CompilerGenerated]
		private DateTime? <LastLogin>k__BackingField;

		// Token: 0x04002C82 RID: 11394
		[CompilerGenerated]
		private DateTime? <LastActivity>k__BackingField;

		// Token: 0x04002C83 RID: 11395
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002C84 RID: 11396
		[CompilerGenerated]
		private string <Login>k__BackingField;

		// Token: 0x04002C85 RID: 11397
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04002C86 RID: 11398
		[CompilerGenerated]
		private string <FirstName>k__BackingField;

		// Token: 0x04002C87 RID: 11399
		[CompilerGenerated]
		private string <LastName>k__BackingField;

		// Token: 0x04002C88 RID: 11400
		[CompilerGenerated]
		private string <Patronymic>k__BackingField;

		// Token: 0x04002C89 RID: 11401
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x04002C8A RID: 11402
		[CompilerGenerated]
		private bool <TrackActivity>k__BackingField;

		// Token: 0x04002C8B RID: 11403
		[CompilerGenerated]
		private bool <DisplayCustomerOnCall>k__BackingField;

		// Token: 0x04002C8C RID: 11404
		[CompilerGenerated]
		private int? <KktPassword>k__BackingField;

		// Token: 0x04002C8D RID: 11405
		[CompilerGenerated]
		private int <WorkshopDefaultOffice>k__BackingField;

		// Token: 0x04002C8E RID: 11406
		[CompilerGenerated]
		private int? <WorkshopDefaultStatus>k__BackingField;

		// Token: 0x04002C8F RID: 11407
		[CompilerGenerated]
		private int <WorkshopDefDevType>k__BackingField;

		// Token: 0x04002C90 RID: 11408
		[CompilerGenerated]
		private int <WorkshopDefaultEmployee>k__BackingField;

		// Token: 0x04002C91 RID: 11409
		[CompilerGenerated]
		private int <StoreDefault>k__BackingField;

		// Token: 0x04002C92 RID: 11410
		[CompilerGenerated]
		private int <StoreDefaultItemState>k__BackingField;

		// Token: 0x04002C93 RID: 11411
		[CompilerGenerated]
		private bool <GroupByArticul>k__BackingField;

		// Token: 0x04002C94 RID: 11412
		[CompilerGenerated]
		private bool <PreviewReports>k__BackingField;

		// Token: 0x04002C95 RID: 11413
		[CompilerGenerated]
		private bool <OverviewAfterSave>k__BackingField;

		// Token: 0x04002C96 RID: 11414
		[CompilerGenerated]
		private int? <Tel>k__BackingField;

		// Token: 0x04002C97 RID: 11415
		[CompilerGenerated]
		private IUISettings <UiSettings>k__BackingField;

		// Token: 0x04002C98 RID: 11416
		[CompilerGenerated]
		private IKKT <Kkt>k__BackingField;

		// Token: 0x04002C99 RID: 11417
		[CompilerGenerated]
		private IPinpad <Pinpad>k__BackingField;

		// Token: 0x04002C9A RID: 11418
		[CompilerGenerated]
		private IOffice <Office>k__BackingField;

		// Token: 0x04002C9B RID: 11419
		[CompilerGenerated]
		private IList<int> <Roles>k__BackingField = new List<int>();

		// Token: 0x04002C9C RID: 11420
		[CompilerGenerated]
		private string <Inn>k__BackingField;

		// Token: 0x04002C9D RID: 11421
		[CompilerGenerated]
		private string <Signature>k__BackingField;

		// Token: 0x020008CC RID: 2252
		[CompilerGenerated]
		private sealed class <>c__DisplayClass127_0
		{
			// Token: 0x06004560 RID: 17760 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass127_0()
			{
			}

			// Token: 0x06004561 RID: 17761 RVA: 0x0010FB7C File Offset: 0x0010DD7C
			internal bool <Can>b__0(WorkshopOptions i)
			{
				return i.Id == (int)this.status;
			}

			// Token: 0x06004562 RID: 17762 RVA: 0x0010FB98 File Offset: 0x0010DD98
			internal bool <Can>b__1(int role)
			{
				return this.<>4__this.Roles.Contains(role);
			}

			// Token: 0x04002C9E RID: 11422
			public WorkshopStatus status;

			// Token: 0x04002C9F RID: 11423
			public Employee <>4__this;
		}

		// Token: 0x020008CD RID: 2253
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_0
		{
			// Token: 0x06004563 RID: 17763 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass128_0()
			{
			}

			// Token: 0x06004564 RID: 17764 RVA: 0x0010FBB8 File Offset: 0x0010DDB8
			internal bool <Can>b__0(\u206C\u206A\u206B\u202C\u202A\u200F\u206C\u206A\u206D\u200C\u200B\u202B\u206C\u202A\u206E\u200B\u200C\u206C\u202E\u202D\u206F\u202A\u200D\u200F\u206C\u200F\u200C\u206B\u200B\u206D\u202A\u206C\u202A\u206A\u202B\u206C\u202D\u206E\u202C\u200D\u202E p)
			{
				return p != null && p.\u206B\u206F\u200F\u206C\u200D\u200D\u200B\u202A\u200C\u202C\u206C\u206A\u200E\u200C\u200C\u200C\u200B\u202D\u200B\u202A\u206F\u206B\u202C\u200C\u206D\u206A\u206B\u206E\u206D\u200C\u200F\u206D\u200E\u200D\u206F\u206A\u202A\u206D\u202D\u200F\u202E == this.permissionId;
			}

			// Token: 0x04002CA0 RID: 11424
			public int permissionId;
		}

		// Token: 0x020008CE RID: 2254
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_1
		{
			// Token: 0x06004565 RID: 17765 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass128_1()
			{
			}

			// Token: 0x04002CA1 RID: 11425
			public int userId;

			// Token: 0x04002CA2 RID: 11426
			public Employee.<>c__DisplayClass128_0 CS$<>8__locals1;
		}

		// Token: 0x020008CF RID: 2255
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004566 RID: 17766 RVA: 0x0010FBD8 File Offset: 0x0010DDD8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004567 RID: 17767 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002CA3 RID: 11427
			public static readonly Employee.<>c <>9 = new Employee.<>c();
		}

		// Token: 0x020008D0 RID: 2256
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RestoreUiDefaults>d__129 : IAsyncStateMachine
		{
			// Token: 0x06004568 RID: 17768 RVA: 0x0010FBF0 File Offset: 0x0010DDF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Employee employee = this.<>4__this;
				bool result2;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<users> awaiter;
							if (num != 0)
							{
								this.<settings>5__3 = new UiSettings
								{
									RowColor = "#FF008EA4",
									GeHighlightColor = "#FFFFDD70",
									FontSize = 13,
									RowHeight = 30,
									IssuedRowColor = "#00000000"
								};
								awaiter = this.<ctx>5__2.users.FindAsync(new object[]
								{
									employee.Id
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<users>, Employee.<RestoreUiDefaults>d__129>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<users>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							users result = awaiter.GetResult();
							result.row_color = this.<settings>5__3.RowColor;
							result.fontsize = this.<settings>5__3.FontSize;
							result.rowheight = this.<settings>5__3.RowHeight;
							this.<ctx>5__2.SaveChanges();
							employee.SetUiSettings(this.<settings>5__3);
							this.<settings>5__3 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
						this.<ctx>5__2 = null;
					}
					catch (Exception)
					{
						result2 = false;
						goto IL_170;
					}
					result2 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_170:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004569 RID: 17769 RVA: 0x0010FDD0 File Offset: 0x0010DFD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002CA4 RID: 11428
			public int <>1__state;

			// Token: 0x04002CA5 RID: 11429
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002CA6 RID: 11430
			public Employee <>4__this;

			// Token: 0x04002CA7 RID: 11431
			private auseceEntities <ctx>5__2;

			// Token: 0x04002CA8 RID: 11432
			private UiSettings <settings>5__3;

			// Token: 0x04002CA9 RID: 11433
			private TaskAwaiter<users> <>u__1;
		}
	}
}
