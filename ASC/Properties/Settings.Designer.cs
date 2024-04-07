using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ASC.Properties
{
	// Token: 0x02000237 RID: 567
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
	public sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00058900 File Offset: 0x00056B00
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00058914 File Offset: 0x00056B14
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00058934 File Offset: 0x00056B34
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("127.0.0.1")]
		public string dbHost
		{
			get
			{
				return (string)this["dbHost"];
			}
			set
			{
				this["dbHost"] = value;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00058950 File Offset: 0x00056B50
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00058970 File Offset: 0x00056B70
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("3306")]
		public uint dbPort
		{
			get
			{
				return (uint)this["dbPort"];
			}
			set
			{
				this["dbPort"] = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00058990 File Offset: 0x00056B90
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x000589B0 File Offset: 0x00056BB0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("ausece")]
		public string dbName
		{
			get
			{
				return (string)this["dbName"];
			}
			set
			{
				this["dbName"] = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x000589CC File Offset: 0x00056BCC
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x000589EC File Offset: 0x00056BEC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string lastLogin
		{
			get
			{
				return (string)this["lastLogin"];
			}
			set
			{
				this["lastLogin"] = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00058A08 File Offset: 0x00056C08
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x00058A28 File Offset: 0x00056C28
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int StoreLastCat
		{
			get
			{
				return (int)this["StoreLastCat"];
			}
			set
			{
				this["StoreLastCat"] = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00058A48 File Offset: 0x00056C48
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00058A68 File Offset: 0x00056C68
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double WorkspaceTop
		{
			get
			{
				return (double)this["WorkspaceTop"];
			}
			set
			{
				this["WorkspaceTop"] = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00058A88 File Offset: 0x00056C88
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00058AA8 File Offset: 0x00056CA8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double WorkspaceLeft
		{
			get
			{
				return (double)this["WorkspaceLeft"];
			}
			set
			{
				this["WorkspaceLeft"] = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00058AC8 File Offset: 0x00056CC8
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00058AE8 File Offset: 0x00056CE8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("900")]
		public double WorkspaceWidth
		{
			get
			{
				return (double)this["WorkspaceWidth"];
			}
			set
			{
				this["WorkspaceWidth"] = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x00058B08 File Offset: 0x00056D08
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00058B28 File Offset: 0x00056D28
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("600")]
		public double WorkspaceHeight
		{
			get
			{
				return (double)this["WorkspaceHeight"];
			}
			set
			{
				this["WorkspaceHeight"] = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00058B48 File Offset: 0x00056D48
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00058B68 File Offset: 0x00056D68
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		public WindowState WorkspaceState
		{
			get
			{
				return (WindowState)this["WorkspaceState"];
			}
			set
			{
				this["WorkspaceState"] = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x00058B88 File Offset: 0x00056D88
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00058BA8 File Offset: 0x00056DA8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ACPDisplayArhiveUsers
		{
			get
			{
				return (bool)this["ACPDisplayArhiveUsers"];
			}
			set
			{
				this["ACPDisplayArhiveUsers"] = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00058BC8 File Offset: 0x00056DC8
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00058BE8 File Offset: 0x00056DE8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("ru-Ru")]
		public string language
		{
			get
			{
				return (string)this["language"];
			}
			set
			{
				this["language"] = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00058C04 File Offset: 0x00056E04
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x00058C24 File Offset: 0x00056E24
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PreviewTop
		{
			get
			{
				return (double)this["PreviewTop"];
			}
			set
			{
				this["PreviewTop"] = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00058C44 File Offset: 0x00056E44
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x00058C64 File Offset: 0x00056E64
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PreviewLeft
		{
			get
			{
				return (double)this["PreviewLeft"];
			}
			set
			{
				this["PreviewLeft"] = value;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x00058C84 File Offset: 0x00056E84
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x00058CA4 File Offset: 0x00056EA4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("800")]
		public double PreviewWidth
		{
			get
			{
				return (double)this["PreviewWidth"];
			}
			set
			{
				this["PreviewWidth"] = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x00058CC4 File Offset: 0x00056EC4
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x00058CE4 File Offset: 0x00056EE4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("600")]
		public double PreviewHeight
		{
			get
			{
				return (double)this["PreviewHeight"];
			}
			set
			{
				this["PreviewHeight"] = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x00058D04 File Offset: 0x00056F04
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00058D24 File Offset: 0x00056F24
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool PreviewMaximized
		{
			get
			{
				return (bool)this["PreviewMaximized"];
			}
			set
			{
				this["PreviewMaximized"] = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00058D44 File Offset: 0x00056F44
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00058D64 File Offset: 0x00056F64
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string LastCamera
		{
			get
			{
				return (string)this["LastCamera"];
			}
			set
			{
				this["LastCamera"] = value;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00058D80 File Offset: 0x00056F80
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x00058DA0 File Offset: 0x00056FA0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool LastCameraSet
		{
			get
			{
				return (bool)this["LastCameraSet"];
			}
			set
			{
				this["LastCameraSet"] = value;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00058DC0 File Offset: 0x00056FC0
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00058DE0 File Offset: 0x00056FE0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double LookLeft
		{
			get
			{
				return (double)this["LookLeft"];
			}
			set
			{
				this["LookLeft"] = value;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00058E00 File Offset: 0x00057000
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00058E20 File Offset: 0x00057020
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double LookTop
		{
			get
			{
				return (double)this["LookTop"];
			}
			set
			{
				this["LookTop"] = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00058E40 File Offset: 0x00057040
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00058E60 File Offset: 0x00057060
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string WorkspaceBackground
		{
			get
			{
				return (string)this["WorkspaceBackground"];
			}
			set
			{
				this["WorkspaceBackground"] = value;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00058E7C File Offset: 0x0005707C
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x00058E9C File Offset: 0x0005709C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int LastCompany
		{
			get
			{
				return (int)this["LastCompany"];
			}
			set
			{
				this["LastCompany"] = value;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x00058EBC File Offset: 0x000570BC
		// (set) Token: 0x06001EFC RID: 7932 RVA: 0x00058EDC File Offset: 0x000570DC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double koLeft
		{
			get
			{
				return (double)this["koLeft"];
			}
			set
			{
				this["koLeft"] = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x00058EFC File Offset: 0x000570FC
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x00058F1C File Offset: 0x0005711C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double koTop
		{
			get
			{
				return (double)this["koTop"];
			}
			set
			{
				this["koTop"] = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00058F3C File Offset: 0x0005713C
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00058F5C File Offset: 0x0005715C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PhotoAddTop
		{
			get
			{
				return (double)this["PhotoAddTop"];
			}
			set
			{
				this["PhotoAddTop"] = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x00058F7C File Offset: 0x0005717C
		// (set) Token: 0x06001F02 RID: 7938 RVA: 0x00058F9C File Offset: 0x0005719C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PhotoAddLeft
		{
			get
			{
				return (double)this["PhotoAddLeft"];
			}
			set
			{
				this["PhotoAddLeft"] = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x00058FBC File Offset: 0x000571BC
		// (set) Token: 0x06001F04 RID: 7940 RVA: 0x00058FDC File Offset: 0x000571DC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("800")]
		public double PhotoAddWidth
		{
			get
			{
				return (double)this["PhotoAddWidth"];
			}
			set
			{
				this["PhotoAddWidth"] = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x00058FFC File Offset: 0x000571FC
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x0005901C File Offset: 0x0005721C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("400")]
		public double PhotoAddHeight
		{
			get
			{
				return (double)this["PhotoAddHeight"];
			}
			set
			{
				this["PhotoAddHeight"] = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x0005903C File Offset: 0x0005723C
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x0005905C File Offset: 0x0005725C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("200")]
		public double StoreCatsWidth
		{
			get
			{
				return (double)this["StoreCatsWidth"];
			}
			set
			{
				this["StoreCatsWidth"] = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0005907C File Offset: 0x0005727C
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x0005909C File Offset: 0x0005729C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("60*")]
		public string StoreArticulHeight
		{
			get
			{
				return (string)this["StoreArticulHeight"];
			}
			set
			{
				this["StoreArticulHeight"] = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x000590B8 File Offset: 0x000572B8
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x000590D8 File Offset: 0x000572D8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("40*")]
		public string StoreDetailHeight
		{
			get
			{
				return (string)this["StoreDetailHeight"];
			}
			set
			{
				this["StoreDetailHeight"] = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000590F4 File Offset: 0x000572F4
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x00059114 File Offset: 0x00057314
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		public WindowState PhotoAddState
		{
			get
			{
				return (WindowState)this["PhotoAddState"];
			}
			set
			{
				this["PhotoAddState"] = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00059134 File Offset: 0x00057334
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x00059154 File Offset: 0x00057354
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double ArticulTop
		{
			get
			{
				return (double)this["ArticulTop"];
			}
			set
			{
				this["ArticulTop"] = value;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x00059174 File Offset: 0x00057374
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x00059194 File Offset: 0x00057394
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double ArticulLeft
		{
			get
			{
				return (double)this["ArticulLeft"];
			}
			set
			{
				this["ArticulLeft"] = value;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x000591B4 File Offset: 0x000573B4
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x000591D4 File Offset: 0x000573D4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("600")]
		public double ArticulWidth
		{
			get
			{
				return (double)this["ArticulWidth"];
			}
			set
			{
				this["ArticulWidth"] = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x000591F4 File Offset: 0x000573F4
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x00059214 File Offset: 0x00057414
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("400")]
		public double ArticulHeight
		{
			get
			{
				return (double)this["ArticulHeight"];
			}
			set
			{
				this["ArticulHeight"] = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00059234 File Offset: 0x00057434
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x00059254 File Offset: 0x00057454
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		public WindowState ArticulState
		{
			get
			{
				return (WindowState)this["ArticulState"];
			}
			set
			{
				this["ArticulState"] = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x00059274 File Offset: 0x00057474
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x00059294 File Offset: 0x00057494
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int ExportLastStore
		{
			get
			{
				return (int)this["ExportLastStore"];
			}
			set
			{
				this["ExportLastStore"] = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000592B4 File Offset: 0x000574B4
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x000592D4 File Offset: 0x000574D4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int StoreLastStore
		{
			get
			{
				return (int)this["StoreLastStore"];
			}
			set
			{
				this["StoreLastStore"] = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000592F4 File Offset: 0x000574F4
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00059314 File Offset: 0x00057514
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int WebCamCurrentResolution
		{
			get
			{
				return (int)this["WebCamCurrentResolution"];
			}
			set
			{
				this["WebCamCurrentResolution"] = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00059334 File Offset: 0x00057534
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00059354 File Offset: 0x00057554
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double RealizPayTop
		{
			get
			{
				return (double)this["RealizPayTop"];
			}
			set
			{
				this["RealizPayTop"] = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00059374 File Offset: 0x00057574
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x00059394 File Offset: 0x00057594
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double RealizPayLeft
		{
			get
			{
				return (double)this["RealizPayLeft"];
			}
			set
			{
				this["RealizPayLeft"] = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x000593B4 File Offset: 0x000575B4
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x000593D4 File Offset: 0x000575D4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("600")]
		public double RealizPayHeight
		{
			get
			{
				return (double)this["RealizPayHeight"];
			}
			set
			{
				this["RealizPayHeight"] = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x000593F4 File Offset: 0x000575F4
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00059414 File Offset: 0x00057614
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("800")]
		public double RealizPayWidth
		{
			get
			{
				return (double)this["RealizPayWidth"];
			}
			set
			{
				this["RealizPayWidth"] = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00059434 File Offset: 0x00057634
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x00059454 File Offset: 0x00057654
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		public WindowState RealizPayState
		{
			get
			{
				return (WindowState)this["RealizPayState"];
			}
			set
			{
				this["RealizPayState"] = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00059474 File Offset: 0x00057674
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00059494 File Offset: 0x00057694
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int RpLastUserFilter
		{
			get
			{
				return (int)this["RpLastUserFilter"];
			}
			set
			{
				this["RpLastUserFilter"] = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x000594B4 File Offset: 0x000576B4
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x000594D4 File Offset: 0x000576D4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool SettingsUpgradeRequired
		{
			get
			{
				return (bool)this["SettingsUpgradeRequired"];
			}
			set
			{
				this["SettingsUpgradeRequired"] = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x000594F4 File Offset: 0x000576F4
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x00059514 File Offset: 0x00057714
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool OnlyMyOrders
		{
			get
			{
				return (bool)this["OnlyMyOrders"];
			}
			set
			{
				this["OnlyMyOrders"] = value;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00059534 File Offset: 0x00057734
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x00059554 File Offset: 0x00057754
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Office2013DarkGray")]
		public string Theme
		{
			get
			{
				return (string)this["Theme"];
			}
			set
			{
				this["Theme"] = value;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x00059570 File Offset: 0x00057770
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x00059590 File Offset: 0x00057790
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int NewRepairLastCompany
		{
			get
			{
				return (int)this["NewRepairLastCompany"];
			}
			set
			{
				this["NewRepairLastCompany"] = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x000595B0 File Offset: 0x000577B0
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x000595D0 File Offset: 0x000577D0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string BackupPath
		{
			get
			{
				return (string)this["BackupPath"];
			}
			set
			{
				this["BackupPath"] = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000595EC File Offset: 0x000577EC
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x0005960C File Offset: 0x0005780C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PriceEditorTop
		{
			get
			{
				return (double)this["PriceEditorTop"];
			}
			set
			{
				this["PriceEditorTop"] = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x0005962C File Offset: 0x0005782C
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x0005964C File Offset: 0x0005784C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PriceEditorLeft
		{
			get
			{
				return (double)this["PriceEditorLeft"];
			}
			set
			{
				this["PriceEditorLeft"] = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0005966C File Offset: 0x0005786C
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0005968C File Offset: 0x0005788C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1100")]
		public double PriceEditorWidth
		{
			get
			{
				return (double)this["PriceEditorWidth"];
			}
			set
			{
				this["PriceEditorWidth"] = value;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x000596AC File Offset: 0x000578AC
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x000596CC File Offset: 0x000578CC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("600")]
		public double PriceEditorHeight
		{
			get
			{
				return (double)this["PriceEditorHeight"];
			}
			set
			{
				this["PriceEditorHeight"] = value;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x000596EC File Offset: 0x000578EC
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x0005970C File Offset: 0x0005790C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		public WindowState PriceEditorState
		{
			get
			{
				return (WindowState)this["PriceEditorState"];
			}
			set
			{
				this["PriceEditorState"] = value;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0005972C File Offset: 0x0005792C
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x0005974C File Offset: 0x0005794C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double TMTop
		{
			get
			{
				return (double)this["TMTop"];
			}
			set
			{
				this["TMTop"] = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0005976C File Offset: 0x0005796C
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x0005978C File Offset: 0x0005798C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double TMLeft
		{
			get
			{
				return (double)this["TMLeft"];
			}
			set
			{
				this["TMLeft"] = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x000597AC File Offset: 0x000579AC
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x000597CC File Offset: 0x000579CC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("800")]
		public double TMWidth
		{
			get
			{
				return (double)this["TMWidth"];
			}
			set
			{
				this["TMWidth"] = value;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x000597EC File Offset: 0x000579EC
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0005980C File Offset: 0x00057A0C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("600")]
		public double TMHeight
		{
			get
			{
				return (double)this["TMHeight"];
			}
			set
			{
				this["TMHeight"] = value;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0005982C File Offset: 0x00057A2C
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x0005984C File Offset: 0x00057A4C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		public WindowState TMState
		{
			get
			{
				return (WindowState)this["TMState"];
			}
			set
			{
				this["TMState"] = value;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0005986C File Offset: 0x00057A6C
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x0005988C File Offset: 0x00057A8C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PlayerTop
		{
			get
			{
				return (double)this["PlayerTop"];
			}
			set
			{
				this["PlayerTop"] = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000598AC File Offset: 0x00057AAC
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x000598CC File Offset: 0x00057ACC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double PlayerLeft
		{
			get
			{
				return (double)this["PlayerLeft"];
			}
			set
			{
				this["PlayerLeft"] = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x000598EC File Offset: 0x00057AEC
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x0005990C File Offset: 0x00057B0C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("300")]
		public double PlayerWidth
		{
			get
			{
				return (double)this["PlayerWidth"];
			}
			set
			{
				this["PlayerWidth"] = value;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x0005992C File Offset: 0x00057B2C
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x0005994C File Offset: 0x00057B4C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("300")]
		public double PlayerHeight
		{
			get
			{
				return (double)this["PlayerHeight"];
			}
			set
			{
				this["PlayerHeight"] = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0005996C File Offset: 0x00057B6C
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x0005998C File Offset: 0x00057B8C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludePn
		{
			get
			{
				return (bool)this["IncludePn"];
			}
			set
			{
				this["IncludePn"] = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x000599AC File Offset: 0x00057BAC
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x000599CC File Offset: 0x00057BCC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludeDescription
		{
			get
			{
				return (bool)this["IncludeDescription"];
			}
			set
			{
				this["IncludeDescription"] = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x000599EC File Offset: 0x00057BEC
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00059A0C File Offset: 0x00057C0C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludePrice
		{
			get
			{
				return (bool)this["IncludePrice"];
			}
			set
			{
				this["IncludePrice"] = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00059A2C File Offset: 0x00057C2C
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00059A4C File Offset: 0x00057C4C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludePrice4Sc
		{
			get
			{
				return (bool)this["IncludePrice4Sc"];
			}
			set
			{
				this["IncludePrice4Sc"] = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00059A6C File Offset: 0x00057C6C
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00059A8C File Offset: 0x00057C8C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludePriceOpt
		{
			get
			{
				return (bool)this["IncludePriceOpt"];
			}
			set
			{
				this["IncludePriceOpt"] = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00059AAC File Offset: 0x00057CAC
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00059ACC File Offset: 0x00057CCC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludePriceOpt2
		{
			get
			{
				return (bool)this["IncludePriceOpt2"];
			}
			set
			{
				this["IncludePriceOpt2"] = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00059AEC File Offset: 0x00057CEC
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00059B0C File Offset: 0x00057D0C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludePriceOpt3
		{
			get
			{
				return (bool)this["IncludePriceOpt3"];
			}
			set
			{
				this["IncludePriceOpt3"] = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00059B2C File Offset: 0x00057D2C
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00059B4C File Offset: 0x00057D4C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IncludePhoto
		{
			get
			{
				return (bool)this["IncludePhoto"];
			}
			set
			{
				this["IncludePhoto"] = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00059B6C File Offset: 0x00057D6C
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00059B8C File Offset: 0x00057D8C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string LastSticker
		{
			get
			{
				return (string)this["LastSticker"];
			}
			set
			{
				this["LastSticker"] = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x00059BA8 File Offset: 0x00057DA8
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x00059BC8 File Offset: 0x00057DC8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool UserFieldsSearch
		{
			get
			{
				return (bool)this["UserFieldsSearch"];
			}
			set
			{
				this["UserFieldsSearch"] = value;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00059BE8 File Offset: 0x00057DE8
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x00059C08 File Offset: 0x00057E08
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string CategoriesState
		{
			get
			{
				return (string)this["CategoriesState"];
			}
			set
			{
				this["CategoriesState"] = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00059C24 File Offset: 0x00057E24
		// (set) Token: 0x06001F68 RID: 8040 RVA: 0x00059C44 File Offset: 0x00057E44
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool OnlyInMyOffice
		{
			get
			{
				return (bool)this["OnlyInMyOffice"];
			}
			set
			{
				this["OnlyInMyOffice"] = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00059C64 File Offset: 0x00057E64
		// (set) Token: 0x06001F6A RID: 8042 RVA: 0x00059C84 File Offset: 0x00057E84
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("120")]
		public GridLength RcardRow3
		{
			get
			{
				return (GridLength)this["RcardRow3"];
			}
			set
			{
				this["RcardRow3"] = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00059CA4 File Offset: 0x00057EA4
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x00059CC4 File Offset: 0x00057EC4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("90")]
		public GridLength RcardRow1
		{
			get
			{
				return (GridLength)this["RcardRow1"];
			}
			set
			{
				this["RcardRow1"] = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00059CE4 File Offset: 0x00057EE4
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00059D04 File Offset: 0x00057F04
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Arial")]
		public string FontFamily
		{
			get
			{
				return (string)this["FontFamily"];
			}
			set
			{
				this["FontFamily"] = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00059D20 File Offset: 0x00057F20
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x00059D40 File Offset: 0x00057F40
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string RpFilter
		{
			get
			{
				return (string)this["RpFilter"];
			}
			set
			{
				this["RpFilter"] = value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00059D5C File Offset: 0x00057F5C
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00059D7C File Offset: 0x00057F7C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ClShowArchive
		{
			get
			{
				return (bool)this["ClShowArchive"];
			}
			set
			{
				this["ClShowArchive"] = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00059D9C File Offset: 0x00057F9C
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00059DBC File Offset: 0x00057FBC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string DocsPrinter
		{
			get
			{
				return (string)this["DocsPrinter"];
			}
			set
			{
				this["DocsPrinter"] = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x00059DD8 File Offset: 0x00057FD8
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x00059DF8 File Offset: 0x00057FF8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string StickersPrinter
		{
			get
			{
				return (string)this["StickersPrinter"];
			}
			set
			{
				this["StickersPrinter"] = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00059E14 File Offset: 0x00058014
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x00059E34 File Offset: 0x00058034
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool TasksVisible
		{
			get
			{
				return (bool)this["TasksVisible"];
			}
			set
			{
				this["TasksVisible"] = value;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x00059E54 File Offset: 0x00058054
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x00059E74 File Offset: 0x00058074
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool StockTakingPhotoVis
		{
			get
			{
				return (bool)this["StockTakingPhotoVis"];
			}
			set
			{
				this["StockTakingPhotoVis"] = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x00059E94 File Offset: 0x00058094
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x00059EB4 File Offset: 0x000580B4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool NewRepLeftPanel
		{
			get
			{
				return (bool)this["NewRepLeftPanel"];
			}
			set
			{
				this["NewRepLeftPanel"] = value;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00059ED4 File Offset: 0x000580D4
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00059EF4 File Offset: 0x000580F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool KassaSidebarExpanded
		{
			get
			{
				return (bool)this["KassaSidebarExpanded"];
			}
			set
			{
				this["KassaSidebarExpanded"] = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00059F14 File Offset: 0x00058114
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x00059F34 File Offset: 0x00058134
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool DocsSidebarExpanded
		{
			get
			{
				return (bool)this["DocsSidebarExpanded"];
			}
			set
			{
				this["DocsSidebarExpanded"] = value;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00059F54 File Offset: 0x00058154
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x00059F74 File Offset: 0x00058174
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool CartridgesOnly
		{
			get
			{
				return (bool)this["CartridgesOnly"];
			}
			set
			{
				this["CartridgesOnly"] = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00059F94 File Offset: 0x00058194
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00059FB4 File Offset: 0x000581B4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool ArrivalSidebarExpanded
		{
			get
			{
				return (bool)this["ArrivalSidebarExpanded"];
			}
			set
			{
				this["ArrivalSidebarExpanded"] = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00059FD4 File Offset: 0x000581D4
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x00059FF4 File Offset: 0x000581F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool StoreSidebarExpanded
		{
			get
			{
				return (bool)this["StoreSidebarExpanded"];
			}
			set
			{
				this["StoreSidebarExpanded"] = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0005A014 File Offset: 0x00058214
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x0005A034 File Offset: 0x00058234
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int IgnoreAfter
		{
			get
			{
				return (int)this["IgnoreAfter"];
			}
			set
			{
				this["IgnoreAfter"] = value;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0005A054 File Offset: 0x00058254
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x0005A074 File Offset: 0x00058274
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double TasksPanelLeft
		{
			get
			{
				return (double)this["TasksPanelLeft"];
			}
			set
			{
				this["TasksPanelLeft"] = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0005A094 File Offset: 0x00058294
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x0005A0B4 File Offset: 0x000582B4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("140")]
		public double TasksPanelTop
		{
			get
			{
				return (double)this["TasksPanelTop"];
			}
			set
			{
				this["TasksPanelTop"] = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0005A0D4 File Offset: 0x000582D4
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x0005A0F4 File Offset: 0x000582F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("9")]
		public int StoreLastOption
		{
			get
			{
				return (int)this["StoreLastOption"];
			}
			set
			{
				this["StoreLastOption"] = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0005A114 File Offset: 0x00058314
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0005A134 File Offset: 0x00058334
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ExportPath
		{
			get
			{
				return (string)this["ExportPath"];
			}
			set
			{
				this["ExportPath"] = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0005A150 File Offset: 0x00058350
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0005A170 File Offset: 0x00058370
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("http://site.com")]
		public string PathOfImages
		{
			get
			{
				return (string)this["PathOfImages"];
			}
			set
			{
				this["PathOfImages"] = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0005A18C File Offset: 0x0005838C
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0005A1AC File Offset: 0x000583AC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool ExportSidebarExpanded
		{
			get
			{
				return (bool)this["ExportSidebarExpanded"];
			}
			set
			{
				this["ExportSidebarExpanded"] = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0005A1CC File Offset: 0x000583CC
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0005A1EC File Offset: 0x000583EC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool SearchArticul
		{
			get
			{
				return (bool)this["SearchArticul"];
			}
			set
			{
				this["SearchArticul"] = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0005A20C File Offset: 0x0005840C
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0005A22C File Offset: 0x0005842C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string StickerVariant
		{
			get
			{
				return (string)this["StickerVariant"];
			}
			set
			{
				this["StickerVariant"] = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0005A248 File Offset: 0x00058448
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0005A268 File Offset: 0x00058468
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int ExportProductAvailability
		{
			get
			{
				return (int)this["ExportProductAvailability"];
			}
			set
			{
				this["ExportProductAvailability"] = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0005A288 File Offset: 0x00058488
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0005A2A8 File Offset: 0x000584A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string SkipUpdate
		{
			get
			{
				return (string)this["SkipUpdate"];
			}
			set
			{
				this["SkipUpdate"] = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0005A2C4 File Offset: 0x000584C4
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0005A2E4 File Offset: 0x000584E4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string PriceWorkCategoriesState
		{
			get
			{
				return (string)this["PriceWorkCategoriesState"];
			}
			set
			{
				this["PriceWorkCategoriesState"] = value;
			}
		}

		// Token: 0x04001020 RID: 4128
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
