using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using Newtonsoft.Json;

namespace ASC.SimpleClasses
{
	// Token: 0x0200022B RID: 555
	public class WorkshopLite
	{
		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000568B8 File Offset: 0x00054AB8
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x000568CC File Offset: 0x00054ACC
		public Employee LockEmployee
		{
			[CompilerGenerated]
			get
			{
				return this.<LockEmployee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LockEmployee>k__BackingField = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x000568E0 File Offset: 0x00054AE0
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x000568F4 File Offset: 0x00054AF4
		public int? VendorId
		{
			[CompilerGenerated]
			get
			{
				return this.<VendorId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<VendorId>k__BackingField = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00056908 File Offset: 0x00054B08
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x0005691C File Offset: 0x00054B1C
		public Employee MasterEmployee
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterEmployee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MasterEmployee>k__BackingField = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00056930 File Offset: 0x00054B30
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00056944 File Offset: 0x00054B44
		public Employee CurrentManagerEmployee
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentManagerEmployee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrentManagerEmployee>k__BackingField = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00056958 File Offset: 0x00054B58
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x0005696C File Offset: 0x00054B6C
		public int ClientId
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientId>k__BackingField = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00056980 File Offset: 0x00054B80
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00056994 File Offset: 0x00054B94
		public string ClientFirstName
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientFirstName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientFirstName>k__BackingField = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x000569A8 File Offset: 0x00054BA8
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x000569BC File Offset: 0x00054BBC
		public string ClientLastName
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientLastName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientLastName>k__BackingField = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000569D0 File Offset: 0x00054BD0
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x000569E4 File Offset: 0x00054BE4
		public string ClientPatronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientPatronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientPatronymic>k__BackingField = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000569F8 File Offset: 0x00054BF8
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00056A0C File Offset: 0x00054C0C
		public string ClientUrName
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientUrName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientUrName>k__BackingField = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00056A20 File Offset: 0x00054C20
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00056A34 File Offset: 0x00054C34
		public int ClientType
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientType>k__BackingField = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00056A48 File Offset: 0x00054C48
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00056A5C File Offset: 0x00054C5C
		public int ClientRepairs
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientRepairs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientRepairs>k__BackingField = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00056A70 File Offset: 0x00054C70
		public bool IsNewClient
		{
			get
			{
				return this.ClientRepairs < 2;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00056A88 File Offset: 0x00054C88
		public string ClientFio
		{
			get
			{
				return string.Concat(new string[]
				{
					this.ClientLastName,
					" ",
					this.ClientFirstName,
					" ",
					this.ClientPatronymic
				});
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00056ACC File Offset: 0x00054CCC
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00056AE0 File Offset: 0x00054CE0
		public string ClientPhone
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientPhone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientPhone>k__BackingField = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00056AF4 File Offset: 0x00054CF4
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00056B08 File Offset: 0x00054D08
		public int? LockUserId
		{
			[CompilerGenerated]
			get
			{
				return this.<LockUserId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LockUserId>k__BackingField = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00056B1C File Offset: 0x00054D1C
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00056B30 File Offset: 0x00054D30
		public DateTime? LockTime
		{
			[CompilerGenerated]
			get
			{
				return this.<LockTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LockTime>k__BackingField = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00056B44 File Offset: 0x00054D44
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00056B58 File Offset: 0x00054D58
		public int RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RepairId>k__BackingField = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00056B6C File Offset: 0x00054D6C
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x00056B80 File Offset: 0x00054D80
		public int InformedStatus
		{
			[CompilerGenerated]
			get
			{
				return this.<InformedStatus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InformedStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00056B94 File Offset: 0x00054D94
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00056BA8 File Offset: 0x00054DA8
		public string DeviceOverview
		{
			[CompilerGenerated]
			get
			{
				return this.<DeviceOverview>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DeviceOverview>k__BackingField = value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00056BBC File Offset: 0x00054DBC
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x00056BD0 File Offset: 0x00054DD0
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
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00056BE4 File Offset: 0x00054DE4
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x00056BF8 File Offset: 0x00054DF8
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
				this.<Fault>k__BackingField = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00056C0C File Offset: 0x00054E0C
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x00056C20 File Offset: 0x00054E20
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
				this.<State>k__BackingField = value;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00056C34 File Offset: 0x00054E34
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x00056C48 File Offset: 0x00054E48
		public int CurrentManager
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentManager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrentManager>k__BackingField = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00056C5C File Offset: 0x00054E5C
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x00056C70 File Offset: 0x00054E70
		public int? CartridgeId
		{
			[CompilerGenerated]
			get
			{
				return this.<CartridgeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CartridgeId>k__BackingField = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00056C84 File Offset: 0x00054E84
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x00056C98 File Offset: 0x00054E98
		public int Manager
		{
			[CompilerGenerated]
			get
			{
				return this.<Manager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Manager>k__BackingField = value;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00056CAC File Offset: 0x00054EAC
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x00056CC0 File Offset: 0x00054EC0
		public int? Master
		{
			[CompilerGenerated]
			get
			{
				return this.<Master>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Master>k__BackingField = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00056CD4 File Offset: 0x00054ED4
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x00056CE8 File Offset: 0x00054EE8
		public int Office
		{
			[CompilerGenerated]
			get
			{
				return this.<Office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Office>k__BackingField = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00056CFC File Offset: 0x00054EFC
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x00056D10 File Offset: 0x00054F10
		public DateTime InDate
		{
			[CompilerGenerated]
			get
			{
				return this.<InDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InDate>k__BackingField = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00056D24 File Offset: 0x00054F24
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x00056D38 File Offset: 0x00054F38
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
				this.<OutDate>k__BackingField = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00056D4C File Offset: 0x00054F4C
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00056D60 File Offset: 0x00054F60
		public DateTime? LastStatusChanged
		{
			[CompilerGenerated]
			get
			{
				return this.<LastStatusChanged>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LastStatusChanged>k__BackingField = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x00056D74 File Offset: 0x00054F74
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x00056D88 File Offset: 0x00054F88
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
				this.<RepairCost>k__BackingField = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00056D9C File Offset: 0x00054F9C
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x00056DB0 File Offset: 0x00054FB0
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
				this.<RealRepairCost>k__BackingField = value;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00056DC4 File Offset: 0x00054FC4
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00056DD8 File Offset: 0x00054FD8
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
				this.<BoxName>k__BackingField = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00056DEC File Offset: 0x00054FEC
		public string OfficeAndRepairId
		{
			get
			{
				return string.Format("{0:D3}-{1:D6}", this.Office, this.RepairId);
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x00056E1C File Offset: 0x0005501C
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x00056E30 File Offset: 0x00055030
		public IEnumerable<field_values> UserFields
		{
			[CompilerGenerated]
			get
			{
				return this.<UserFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserFields>k__BackingField = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x00056E44 File Offset: 0x00055044
		public decimal ShowRepairCost
		{
			get
			{
				if (!(this.RealRepairCost == 0m))
				{
					return this.RealRepairCost;
				}
				return this.RepairCost;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00056E70 File Offset: 0x00055070
		public decimal? ShowRepairCostFormatted
		{
			get
			{
				decimal? num2;
				try
				{
					decimal? num;
					if (!(this.ShowRepairCost == 0m))
					{
						num = new decimal?(Auth.Config.classic_kassa ? Math.Round(this.ShowRepairCost, 2) : decimal.ToInt32(this.ShowRepairCost));
					}
					else
					{
						num2 = null;
						num = num2;
					}
					num2 = num;
				}
				catch (Exception)
				{
					num2 = new decimal?(0m);
				}
				return num2;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x00056EF0 File Offset: 0x000550F0
		public virtual string FioOrUrName
		{
			get
			{
				if (this.ClientType != 1)
				{
					return this.ClientFio;
				}
				return this.ClientUrName;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00056F14 File Offset: 0x00055114
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00056F84 File Offset: 0x00055184
		public string Color
		{
			get
			{
				if (this.IsQuery && Auth.User.issued_color != "#00000000")
				{
					if (this.State != 8)
					{
						if (this.State != 12 && this.State != 16)
						{
							goto IL_48;
						}
					}
					return Auth.User.issued_color;
				}
				IL_48:
				if (string.IsNullOrEmpty(this._color))
				{
					return "#00000000";
				}
				return this._color;
			}
			set
			{
				this._color = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00056F98 File Offset: 0x00055198
		public string StateColor
		{
			get
			{
				WorkshopOptions option = new WorkshopOptions().GetOption(this.State);
				if (string.IsNullOrEmpty((option != null) ? option.Color : null))
				{
					return "#00000000";
				}
				return option.Color;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00056FD8 File Offset: 0x000551D8
		public bool IsStateColored
		{
			get
			{
				return !string.IsNullOrEmpty(this.StateColor) && this.Color != "#00000000";
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00057004 File Offset: 0x00055204
		public bool IsColored
		{
			get
			{
				return !string.IsNullOrEmpty(this.Color) && this.Color != "#00000000";
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x00057030 File Offset: 0x00055230
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x00057044 File Offset: 0x00055244
		public string OrderMoving
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderMoving>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderMoving>k__BackingField = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00057058 File Offset: 0x00055258
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x0005706C File Offset: 0x0005526C
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
				this.<IsWarranty>k__BackingField = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x00057080 File Offset: 0x00055280
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x00057094 File Offset: 0x00055294
		public bool? IsExpress
		{
			[CompilerGenerated]
			get
			{
				return this.<IsExpress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsExpress>k__BackingField = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x000570A8 File Offset: 0x000552A8
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x000570BC File Offset: 0x000552BC
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
				this.<IsRegular>k__BackingField = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x000570D0 File Offset: 0x000552D0
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x000570E4 File Offset: 0x000552E4
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
				this.<IsAgent>k__BackingField = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x000570F8 File Offset: 0x000552F8
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x0005710C File Offset: 0x0005530C
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
				this.<IsBad>k__BackingField = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00057120 File Offset: 0x00055320
		public virtual DateTime InDateTime
		{
			get
			{
				return Localization.ToLocalTimeZone(this.InDate);
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00057138 File Offset: 0x00055338
		public virtual double RepairProgress
		{
			get
			{
				DateTime d = this.OutDate ?? this._localization.Now;
				return (double)(100 * (d - this.InDateTime).Days) / WorkshopOptions.GetTotalRepairDays();
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00057188 File Offset: 0x00055388
		public double LastStatusProgress
		{
			get
			{
				double num = WorkshopOptions.GetTermsByState(this.State);
				if (Math.Round(num, 1) < 0.1)
				{
					num = 0.1;
				}
				double totalDays = ((this.OutDate ?? this._localization.Now) - this.LastStatusChanged.Value).TotalDays;
				return 100.0 * totalDays / num;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0005720C File Offset: 0x0005540C
		public double InRepairDays
		{
			get
			{
				double result;
				try
				{
					DateTime? dateTime;
					double num = Math.Ceiling((((this.OutDate != null) ? dateTime.GetValueOrDefault().Date : this._localization.NowDate) - this.InDate.Date).TotalDays);
					result = ((num < 0.0) ? 0.0 : num);
				}
				catch (Exception)
				{
					result = 0.0;
				}
				return result;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x000572A4 File Offset: 0x000554A4
		public bool ShowProgress
		{
			get
			{
				return this.State != 8 || this.State != 12;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x000572CC File Offset: 0x000554CC
		public bool IsOrderMoving
		{
			get
			{
				return !string.IsNullOrEmpty(this.OrderMoving);
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x000572E8 File Offset: 0x000554E8
		public string OfficesList
		{
			get
			{
				if (string.IsNullOrEmpty(this.OrderMoving))
				{
					return string.Empty;
				}
				string result;
				try
				{
					List<int> list = JsonConvert.DeserializeObject<List<int>>(this.OrderMoving);
					if (list == null)
					{
						result = string.Empty;
					}
					else
					{
						List<string> officeNamesById = new OfficesModel().GetOfficeNamesById(list);
						result = string.Join(" > ", officeNamesById);
					}
				}
				catch (Exception)
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x00057354 File Offset: 0x00055554
		public Visibility OrderMovingVisibility
		{
			get
			{
				if (!this.IsOrderMoving)
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x0005736C File Offset: 0x0005556C
		public Visibility BadVisibility
		{
			get
			{
				if (!this.IsBad)
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x00057384 File Offset: 0x00055584
		public Visibility AgentVisibility
		{
			get
			{
				if (!this.IsAgent)
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x0005739C File Offset: 0x0005559C
		public Visibility WarrantyVisibility
		{
			get
			{
				if (!this.IsWarranty)
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x000573B4 File Offset: 0x000555B4
		public Visibility RegularVisibility
		{
			get
			{
				if (!this.IsRegular)
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x000573CC File Offset: 0x000555CC
		public Visibility ExpressVisibility
		{
			get
			{
				if (this.IsExpress == null)
				{
					return Visibility.Collapsed;
				}
				if (!this.IsExpress.Value)
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00057400 File Offset: 0x00055600
		public string InRepairDaysString
		{
			get
			{
				string result;
				try
				{
					result = string.Format("{0} {1}", this.InRepairDays, WorkshopLite.GetDeclension(Convert.ToInt32(this.InRepairDays), (string)Application.Current.TryFindResource("Day"), (string)Application.Current.TryFindResource("DayNominativ"), (string)Application.Current.TryFindResource("DayGenetiv")));
				}
				catch (Exception)
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0005748C File Offset: 0x0005568C
		public static string GetDeclension(int number, string nominativ, string genetiv, string plural)
		{
			number %= 100;
			if (number >= 11 && number <= 19)
			{
				return plural;
			}
			int num = number % 10;
			if (num == 1)
			{
				return nominativ;
			}
			if (num - 2 <= 2)
			{
				return genetiv;
			}
			return plural;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x000574C0 File Offset: 0x000556C0
		public WorkshopLite()
		{
		}

		// Token: 0x04000FB9 RID: 4025
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x04000FBA RID: 4026
		private string _color;

		// Token: 0x04000FBB RID: 4027
		[CompilerGenerated]
		private Employee <LockEmployee>k__BackingField;

		// Token: 0x04000FBC RID: 4028
		[CompilerGenerated]
		private int? <VendorId>k__BackingField;

		// Token: 0x04000FBD RID: 4029
		[CompilerGenerated]
		private Employee <MasterEmployee>k__BackingField;

		// Token: 0x04000FBE RID: 4030
		[CompilerGenerated]
		private Employee <CurrentManagerEmployee>k__BackingField;

		// Token: 0x04000FBF RID: 4031
		[CompilerGenerated]
		private int <ClientId>k__BackingField;

		// Token: 0x04000FC0 RID: 4032
		[CompilerGenerated]
		private string <ClientFirstName>k__BackingField;

		// Token: 0x04000FC1 RID: 4033
		[CompilerGenerated]
		private string <ClientLastName>k__BackingField;

		// Token: 0x04000FC2 RID: 4034
		[CompilerGenerated]
		private string <ClientPatronymic>k__BackingField;

		// Token: 0x04000FC3 RID: 4035
		[CompilerGenerated]
		private string <ClientUrName>k__BackingField;

		// Token: 0x04000FC4 RID: 4036
		[CompilerGenerated]
		private int <ClientType>k__BackingField;

		// Token: 0x04000FC5 RID: 4037
		[CompilerGenerated]
		private int <ClientRepairs>k__BackingField;

		// Token: 0x04000FC6 RID: 4038
		[CompilerGenerated]
		private string <ClientPhone>k__BackingField;

		// Token: 0x04000FC7 RID: 4039
		[CompilerGenerated]
		private int? <LockUserId>k__BackingField;

		// Token: 0x04000FC8 RID: 4040
		[CompilerGenerated]
		private DateTime? <LockTime>k__BackingField;

		// Token: 0x04000FC9 RID: 4041
		[CompilerGenerated]
		private int <RepairId>k__BackingField;

		// Token: 0x04000FCA RID: 4042
		[CompilerGenerated]
		private int <InformedStatus>k__BackingField;

		// Token: 0x04000FCB RID: 4043
		[CompilerGenerated]
		private string <DeviceOverview>k__BackingField;

		// Token: 0x04000FCC RID: 4044
		[CompilerGenerated]
		private string <SerialNumber>k__BackingField;

		// Token: 0x04000FCD RID: 4045
		[CompilerGenerated]
		private string <Fault>k__BackingField;

		// Token: 0x04000FCE RID: 4046
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x04000FCF RID: 4047
		[CompilerGenerated]
		private int <CurrentManager>k__BackingField;

		// Token: 0x04000FD0 RID: 4048
		[CompilerGenerated]
		private int? <CartridgeId>k__BackingField;

		// Token: 0x04000FD1 RID: 4049
		[CompilerGenerated]
		private int <Manager>k__BackingField;

		// Token: 0x04000FD2 RID: 4050
		[CompilerGenerated]
		private int? <Master>k__BackingField;

		// Token: 0x04000FD3 RID: 4051
		[CompilerGenerated]
		private int <Office>k__BackingField;

		// Token: 0x04000FD4 RID: 4052
		[CompilerGenerated]
		private DateTime <InDate>k__BackingField;

		// Token: 0x04000FD5 RID: 4053
		[CompilerGenerated]
		private DateTime? <OutDate>k__BackingField;

		// Token: 0x04000FD6 RID: 4054
		[CompilerGenerated]
		private DateTime? <LastStatusChanged>k__BackingField;

		// Token: 0x04000FD7 RID: 4055
		[CompilerGenerated]
		private decimal <RepairCost>k__BackingField;

		// Token: 0x04000FD8 RID: 4056
		[CompilerGenerated]
		private decimal <RealRepairCost>k__BackingField;

		// Token: 0x04000FD9 RID: 4057
		[CompilerGenerated]
		private string <BoxName>k__BackingField;

		// Token: 0x04000FDA RID: 4058
		[CompilerGenerated]
		private IEnumerable<field_values> <UserFields>k__BackingField;

		// Token: 0x04000FDB RID: 4059
		[CompilerGenerated]
		private string <OrderMoving>k__BackingField;

		// Token: 0x04000FDC RID: 4060
		[CompilerGenerated]
		private bool <IsWarranty>k__BackingField;

		// Token: 0x04000FDD RID: 4061
		[CompilerGenerated]
		private bool? <IsExpress>k__BackingField;

		// Token: 0x04000FDE RID: 4062
		[CompilerGenerated]
		private bool <IsRegular>k__BackingField;

		// Token: 0x04000FDF RID: 4063
		[CompilerGenerated]
		private bool <IsAgent>k__BackingField;

		// Token: 0x04000FE0 RID: 4064
		[CompilerGenerated]
		private bool <IsBad>k__BackingField;

		// Token: 0x04000FE1 RID: 4065
		public bool IsQuery;
	}
}
