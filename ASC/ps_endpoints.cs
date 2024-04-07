using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000060 RID: 96
	public class ps_endpoints
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x00012ADC File Offset: 0x00010CDC
		public ps_endpoints()
		{
			this.users = new HashSet<users>();
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00012AFC File Offset: 0x00010CFC
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00012B10 File Offset: 0x00010D10
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
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00012B24 File Offset: 0x00010D24
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00012B38 File Offset: 0x00010D38
		public string transport
		{
			[CompilerGenerated]
			get
			{
				return this.<transport>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<transport>k__BackingField = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00012B4C File Offset: 0x00010D4C
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00012B60 File Offset: 0x00010D60
		public string aors
		{
			[CompilerGenerated]
			get
			{
				return this.<aors>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<aors>k__BackingField = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00012B74 File Offset: 0x00010D74
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00012B88 File Offset: 0x00010D88
		public string auth
		{
			[CompilerGenerated]
			get
			{
				return this.<auth>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<auth>k__BackingField = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00012B9C File Offset: 0x00010D9C
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00012BB0 File Offset: 0x00010DB0
		public string context
		{
			[CompilerGenerated]
			get
			{
				return this.<context>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<context>k__BackingField = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00012BC4 File Offset: 0x00010DC4
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00012BD8 File Offset: 0x00010DD8
		public string disallow
		{
			[CompilerGenerated]
			get
			{
				return this.<disallow>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<disallow>k__BackingField = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00012BEC File Offset: 0x00010DEC
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00012C00 File Offset: 0x00010E00
		public string allow
		{
			[CompilerGenerated]
			get
			{
				return this.<allow>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<allow>k__BackingField = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00012C14 File Offset: 0x00010E14
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00012C28 File Offset: 0x00010E28
		public string direct_media
		{
			[CompilerGenerated]
			get
			{
				return this.<direct_media>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<direct_media>k__BackingField = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00012C3C File Offset: 0x00010E3C
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x00012C50 File Offset: 0x00010E50
		public string connected_line_method
		{
			[CompilerGenerated]
			get
			{
				return this.<connected_line_method>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<connected_line_method>k__BackingField = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00012C64 File Offset: 0x00010E64
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00012C78 File Offset: 0x00010E78
		public string direct_media_method
		{
			[CompilerGenerated]
			get
			{
				return this.<direct_media_method>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<direct_media_method>k__BackingField = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00012C8C File Offset: 0x00010E8C
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00012CA0 File Offset: 0x00010EA0
		public string direct_media_glare_mitigation
		{
			[CompilerGenerated]
			get
			{
				return this.<direct_media_glare_mitigation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<direct_media_glare_mitigation>k__BackingField = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00012CB4 File Offset: 0x00010EB4
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00012CC8 File Offset: 0x00010EC8
		public string disable_direct_media_on_nat
		{
			[CompilerGenerated]
			get
			{
				return this.<disable_direct_media_on_nat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<disable_direct_media_on_nat>k__BackingField = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00012CDC File Offset: 0x00010EDC
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00012CF0 File Offset: 0x00010EF0
		public string dtmf_mode
		{
			[CompilerGenerated]
			get
			{
				return this.<dtmf_mode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtmf_mode>k__BackingField = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00012D04 File Offset: 0x00010F04
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00012D18 File Offset: 0x00010F18
		public string external_media_address
		{
			[CompilerGenerated]
			get
			{
				return this.<external_media_address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<external_media_address>k__BackingField = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00012D2C File Offset: 0x00010F2C
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00012D40 File Offset: 0x00010F40
		public string force_rport
		{
			[CompilerGenerated]
			get
			{
				return this.<force_rport>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<force_rport>k__BackingField = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00012D54 File Offset: 0x00010F54
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00012D68 File Offset: 0x00010F68
		public string ice_support
		{
			[CompilerGenerated]
			get
			{
				return this.<ice_support>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ice_support>k__BackingField = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00012D7C File Offset: 0x00010F7C
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00012D90 File Offset: 0x00010F90
		public string identify_by
		{
			[CompilerGenerated]
			get
			{
				return this.<identify_by>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<identify_by>k__BackingField = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00012DA4 File Offset: 0x00010FA4
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00012DB8 File Offset: 0x00010FB8
		public string mailboxes
		{
			[CompilerGenerated]
			get
			{
				return this.<mailboxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<mailboxes>k__BackingField = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00012DCC File Offset: 0x00010FCC
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00012DE0 File Offset: 0x00010FE0
		public string moh_suggest
		{
			[CompilerGenerated]
			get
			{
				return this.<moh_suggest>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<moh_suggest>k__BackingField = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00012DF4 File Offset: 0x00010FF4
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00012E08 File Offset: 0x00011008
		public string outbound_auth
		{
			[CompilerGenerated]
			get
			{
				return this.<outbound_auth>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<outbound_auth>k__BackingField = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00012E1C File Offset: 0x0001101C
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00012E30 File Offset: 0x00011030
		public string outbound_proxy
		{
			[CompilerGenerated]
			get
			{
				return this.<outbound_proxy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<outbound_proxy>k__BackingField = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00012E44 File Offset: 0x00011044
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00012E58 File Offset: 0x00011058
		public string rewrite_contact
		{
			[CompilerGenerated]
			get
			{
				return this.<rewrite_contact>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rewrite_contact>k__BackingField = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00012E6C File Offset: 0x0001106C
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00012E80 File Offset: 0x00011080
		public string rtp_ipv6
		{
			[CompilerGenerated]
			get
			{
				return this.<rtp_ipv6>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rtp_ipv6>k__BackingField = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00012E94 File Offset: 0x00011094
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00012EA8 File Offset: 0x000110A8
		public string rtp_symmetric
		{
			[CompilerGenerated]
			get
			{
				return this.<rtp_symmetric>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rtp_symmetric>k__BackingField = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00012EBC File Offset: 0x000110BC
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00012ED0 File Offset: 0x000110D0
		public string send_diversion
		{
			[CompilerGenerated]
			get
			{
				return this.<send_diversion>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<send_diversion>k__BackingField = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00012EE4 File Offset: 0x000110E4
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00012EF8 File Offset: 0x000110F8
		public string send_pai
		{
			[CompilerGenerated]
			get
			{
				return this.<send_pai>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<send_pai>k__BackingField = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00012F0C File Offset: 0x0001110C
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00012F20 File Offset: 0x00011120
		public string send_rpid
		{
			[CompilerGenerated]
			get
			{
				return this.<send_rpid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<send_rpid>k__BackingField = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00012F34 File Offset: 0x00011134
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00012F48 File Offset: 0x00011148
		public int? timers_min_se
		{
			[CompilerGenerated]
			get
			{
				return this.<timers_min_se>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<timers_min_se>k__BackingField = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00012F5C File Offset: 0x0001115C
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00012F70 File Offset: 0x00011170
		public string timers
		{
			[CompilerGenerated]
			get
			{
				return this.<timers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<timers>k__BackingField = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00012F84 File Offset: 0x00011184
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00012F98 File Offset: 0x00011198
		public int? timers_sess_expires
		{
			[CompilerGenerated]
			get
			{
				return this.<timers_sess_expires>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<timers_sess_expires>k__BackingField = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00012FAC File Offset: 0x000111AC
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00012FC0 File Offset: 0x000111C0
		public string callerid
		{
			[CompilerGenerated]
			get
			{
				return this.<callerid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<callerid>k__BackingField = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00012FD4 File Offset: 0x000111D4
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00012FE8 File Offset: 0x000111E8
		public string callerid_privacy
		{
			[CompilerGenerated]
			get
			{
				return this.<callerid_privacy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<callerid_privacy>k__BackingField = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00012FFC File Offset: 0x000111FC
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00013010 File Offset: 0x00011210
		public string callerid_tag
		{
			[CompilerGenerated]
			get
			{
				return this.<callerid_tag>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<callerid_tag>k__BackingField = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00013024 File Offset: 0x00011224
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00013038 File Offset: 0x00011238
		public string C100rel
		{
			[CompilerGenerated]
			get
			{
				return this.<C100rel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<C100rel>k__BackingField = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0001304C File Offset: 0x0001124C
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00013060 File Offset: 0x00011260
		public string aggregate_mwi
		{
			[CompilerGenerated]
			get
			{
				return this.<aggregate_mwi>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<aggregate_mwi>k__BackingField = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00013074 File Offset: 0x00011274
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00013088 File Offset: 0x00011288
		public string trust_id_inbound
		{
			[CompilerGenerated]
			get
			{
				return this.<trust_id_inbound>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<trust_id_inbound>k__BackingField = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0001309C File Offset: 0x0001129C
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000130B0 File Offset: 0x000112B0
		public string trust_id_outbound
		{
			[CompilerGenerated]
			get
			{
				return this.<trust_id_outbound>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<trust_id_outbound>k__BackingField = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000130C4 File Offset: 0x000112C4
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x000130D8 File Offset: 0x000112D8
		public string use_ptime
		{
			[CompilerGenerated]
			get
			{
				return this.<use_ptime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<use_ptime>k__BackingField = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000130EC File Offset: 0x000112EC
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00013100 File Offset: 0x00011300
		public string use_avpf
		{
			[CompilerGenerated]
			get
			{
				return this.<use_avpf>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<use_avpf>k__BackingField = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00013114 File Offset: 0x00011314
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x00013128 File Offset: 0x00011328
		public string media_encryption
		{
			[CompilerGenerated]
			get
			{
				return this.<media_encryption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<media_encryption>k__BackingField = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0001313C File Offset: 0x0001133C
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x00013150 File Offset: 0x00011350
		public string inband_progress
		{
			[CompilerGenerated]
			get
			{
				return this.<inband_progress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<inband_progress>k__BackingField = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00013164 File Offset: 0x00011364
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x00013178 File Offset: 0x00011378
		public string call_group
		{
			[CompilerGenerated]
			get
			{
				return this.<call_group>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<call_group>k__BackingField = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0001318C File Offset: 0x0001138C
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000131A0 File Offset: 0x000113A0
		public string pickup_group
		{
			[CompilerGenerated]
			get
			{
				return this.<pickup_group>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pickup_group>k__BackingField = value;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x000131B4 File Offset: 0x000113B4
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x000131C8 File Offset: 0x000113C8
		public string named_call_group
		{
			[CompilerGenerated]
			get
			{
				return this.<named_call_group>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<named_call_group>k__BackingField = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x000131DC File Offset: 0x000113DC
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x000131F0 File Offset: 0x000113F0
		public string named_pickup_group
		{
			[CompilerGenerated]
			get
			{
				return this.<named_pickup_group>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<named_pickup_group>k__BackingField = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00013204 File Offset: 0x00011404
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00013218 File Offset: 0x00011418
		public int? device_state_busy_at
		{
			[CompilerGenerated]
			get
			{
				return this.<device_state_busy_at>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<device_state_busy_at>k__BackingField = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0001322C File Offset: 0x0001142C
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00013240 File Offset: 0x00011440
		public string fax_detect
		{
			[CompilerGenerated]
			get
			{
				return this.<fax_detect>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fax_detect>k__BackingField = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00013254 File Offset: 0x00011454
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00013268 File Offset: 0x00011468
		public string t38_udptl
		{
			[CompilerGenerated]
			get
			{
				return this.<t38_udptl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<t38_udptl>k__BackingField = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0001327C File Offset: 0x0001147C
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00013290 File Offset: 0x00011490
		public string t38_udptl_ec
		{
			[CompilerGenerated]
			get
			{
				return this.<t38_udptl_ec>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<t38_udptl_ec>k__BackingField = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000132A4 File Offset: 0x000114A4
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x000132B8 File Offset: 0x000114B8
		public int? t38_udptl_maxdatagram
		{
			[CompilerGenerated]
			get
			{
				return this.<t38_udptl_maxdatagram>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<t38_udptl_maxdatagram>k__BackingField = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x000132CC File Offset: 0x000114CC
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x000132E0 File Offset: 0x000114E0
		public string t38_udptl_nat
		{
			[CompilerGenerated]
			get
			{
				return this.<t38_udptl_nat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<t38_udptl_nat>k__BackingField = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x000132F4 File Offset: 0x000114F4
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00013308 File Offset: 0x00011508
		public string t38_udptl_ipv6
		{
			[CompilerGenerated]
			get
			{
				return this.<t38_udptl_ipv6>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<t38_udptl_ipv6>k__BackingField = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0001331C File Offset: 0x0001151C
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00013330 File Offset: 0x00011530
		public string tone_zone
		{
			[CompilerGenerated]
			get
			{
				return this.<tone_zone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tone_zone>k__BackingField = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00013344 File Offset: 0x00011544
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x00013358 File Offset: 0x00011558
		public string language
		{
			[CompilerGenerated]
			get
			{
				return this.<language>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<language>k__BackingField = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0001336C File Offset: 0x0001156C
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00013380 File Offset: 0x00011580
		public string one_touch_recording
		{
			[CompilerGenerated]
			get
			{
				return this.<one_touch_recording>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<one_touch_recording>k__BackingField = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00013394 File Offset: 0x00011594
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x000133A8 File Offset: 0x000115A8
		public string record_on_feature
		{
			[CompilerGenerated]
			get
			{
				return this.<record_on_feature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<record_on_feature>k__BackingField = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x000133BC File Offset: 0x000115BC
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000133D0 File Offset: 0x000115D0
		public string record_off_feature
		{
			[CompilerGenerated]
			get
			{
				return this.<record_off_feature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<record_off_feature>k__BackingField = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000133E4 File Offset: 0x000115E4
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000133F8 File Offset: 0x000115F8
		public string rtp_engine
		{
			[CompilerGenerated]
			get
			{
				return this.<rtp_engine>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rtp_engine>k__BackingField = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0001340C File Offset: 0x0001160C
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00013420 File Offset: 0x00011620
		public string allow_transfer
		{
			[CompilerGenerated]
			get
			{
				return this.<allow_transfer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<allow_transfer>k__BackingField = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00013434 File Offset: 0x00011634
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00013448 File Offset: 0x00011648
		public string allow_subscribe
		{
			[CompilerGenerated]
			get
			{
				return this.<allow_subscribe>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<allow_subscribe>k__BackingField = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0001345C File Offset: 0x0001165C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00013470 File Offset: 0x00011670
		public string sdp_owner
		{
			[CompilerGenerated]
			get
			{
				return this.<sdp_owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sdp_owner>k__BackingField = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00013484 File Offset: 0x00011684
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00013498 File Offset: 0x00011698
		public string sdp_session
		{
			[CompilerGenerated]
			get
			{
				return this.<sdp_session>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sdp_session>k__BackingField = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000134AC File Offset: 0x000116AC
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000134C0 File Offset: 0x000116C0
		public string tos_audio
		{
			[CompilerGenerated]
			get
			{
				return this.<tos_audio>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tos_audio>k__BackingField = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000134D4 File Offset: 0x000116D4
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000134E8 File Offset: 0x000116E8
		public string tos_video
		{
			[CompilerGenerated]
			get
			{
				return this.<tos_video>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tos_video>k__BackingField = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000134FC File Offset: 0x000116FC
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00013510 File Offset: 0x00011710
		public int? sub_min_expiry
		{
			[CompilerGenerated]
			get
			{
				return this.<sub_min_expiry>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sub_min_expiry>k__BackingField = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00013524 File Offset: 0x00011724
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00013538 File Offset: 0x00011738
		public string from_domain
		{
			[CompilerGenerated]
			get
			{
				return this.<from_domain>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<from_domain>k__BackingField = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0001354C File Offset: 0x0001174C
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00013560 File Offset: 0x00011760
		public string from_user
		{
			[CompilerGenerated]
			get
			{
				return this.<from_user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<from_user>k__BackingField = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00013574 File Offset: 0x00011774
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00013588 File Offset: 0x00011788
		public string mwi_from_user
		{
			[CompilerGenerated]
			get
			{
				return this.<mwi_from_user>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<mwi_from_user>k__BackingField = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0001359C File Offset: 0x0001179C
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x000135B0 File Offset: 0x000117B0
		public string dtls_verify
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_verify>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_verify>k__BackingField = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000135C4 File Offset: 0x000117C4
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x000135D8 File Offset: 0x000117D8
		public string dtls_rekey
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_rekey>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_rekey>k__BackingField = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000135EC File Offset: 0x000117EC
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00013600 File Offset: 0x00011800
		public string dtls_cert_file
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_cert_file>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_cert_file>k__BackingField = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00013614 File Offset: 0x00011814
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00013628 File Offset: 0x00011828
		public string dtls_private_key
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_private_key>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_private_key>k__BackingField = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0001363C File Offset: 0x0001183C
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00013650 File Offset: 0x00011850
		public string dtls_cipher
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_cipher>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_cipher>k__BackingField = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00013664 File Offset: 0x00011864
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00013678 File Offset: 0x00011878
		public string dtls_ca_file
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_ca_file>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_ca_file>k__BackingField = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0001368C File Offset: 0x0001188C
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x000136A0 File Offset: 0x000118A0
		public string dtls_ca_path
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_ca_path>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_ca_path>k__BackingField = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000136B4 File Offset: 0x000118B4
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x000136C8 File Offset: 0x000118C8
		public string dtls_setup
		{
			[CompilerGenerated]
			get
			{
				return this.<dtls_setup>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dtls_setup>k__BackingField = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x000136DC File Offset: 0x000118DC
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x000136F0 File Offset: 0x000118F0
		public string srtp_tag_32
		{
			[CompilerGenerated]
			get
			{
				return this.<srtp_tag_32>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<srtp_tag_32>k__BackingField = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00013704 File Offset: 0x00011904
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00013718 File Offset: 0x00011918
		public string media_address
		{
			[CompilerGenerated]
			get
			{
				return this.<media_address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<media_address>k__BackingField = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0001372C File Offset: 0x0001192C
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00013740 File Offset: 0x00011940
		public string redirect_method
		{
			[CompilerGenerated]
			get
			{
				return this.<redirect_method>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<redirect_method>k__BackingField = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00013754 File Offset: 0x00011954
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00013768 File Offset: 0x00011968
		public string set_var
		{
			[CompilerGenerated]
			get
			{
				return this.<set_var>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<set_var>k__BackingField = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0001377C File Offset: 0x0001197C
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00013790 File Offset: 0x00011990
		public int? cos_audio
		{
			[CompilerGenerated]
			get
			{
				return this.<cos_audio>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cos_audio>k__BackingField = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000137A4 File Offset: 0x000119A4
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x000137B8 File Offset: 0x000119B8
		public int? cos_video
		{
			[CompilerGenerated]
			get
			{
				return this.<cos_video>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cos_video>k__BackingField = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000137CC File Offset: 0x000119CC
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x000137E0 File Offset: 0x000119E0
		public string message_context
		{
			[CompilerGenerated]
			get
			{
				return this.<message_context>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<message_context>k__BackingField = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000137F4 File Offset: 0x000119F4
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x00013808 File Offset: 0x00011A08
		public string force_avp
		{
			[CompilerGenerated]
			get
			{
				return this.<force_avp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<force_avp>k__BackingField = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0001381C File Offset: 0x00011A1C
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x00013830 File Offset: 0x00011A30
		public string media_use_received_transport
		{
			[CompilerGenerated]
			get
			{
				return this.<media_use_received_transport>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<media_use_received_transport>k__BackingField = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00013844 File Offset: 0x00011A44
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00013858 File Offset: 0x00011A58
		public string accountcode
		{
			[CompilerGenerated]
			get
			{
				return this.<accountcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<accountcode>k__BackingField = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0001386C File Offset: 0x00011A6C
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00013880 File Offset: 0x00011A80
		public string user_eq_phone
		{
			[CompilerGenerated]
			get
			{
				return this.<user_eq_phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<user_eq_phone>k__BackingField = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00013894 File Offset: 0x00011A94
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x000138A8 File Offset: 0x00011AA8
		public string moh_passthrough
		{
			[CompilerGenerated]
			get
			{
				return this.<moh_passthrough>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<moh_passthrough>k__BackingField = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x000138BC File Offset: 0x00011ABC
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x000138D0 File Offset: 0x00011AD0
		public string media_encryption_optimistic
		{
			[CompilerGenerated]
			get
			{
				return this.<media_encryption_optimistic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<media_encryption_optimistic>k__BackingField = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x000138E4 File Offset: 0x00011AE4
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x000138F8 File Offset: 0x00011AF8
		public string rpid_immediate
		{
			[CompilerGenerated]
			get
			{
				return this.<rpid_immediate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rpid_immediate>k__BackingField = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0001390C File Offset: 0x00011B0C
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00013920 File Offset: 0x00011B20
		public string g726_non_standard
		{
			[CompilerGenerated]
			get
			{
				return this.<g726_non_standard>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<g726_non_standard>k__BackingField = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00013934 File Offset: 0x00011B34
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00013948 File Offset: 0x00011B48
		public int? rtp_keepalive
		{
			[CompilerGenerated]
			get
			{
				return this.<rtp_keepalive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rtp_keepalive>k__BackingField = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0001395C File Offset: 0x00011B5C
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00013970 File Offset: 0x00011B70
		public int? rtp_timeout
		{
			[CompilerGenerated]
			get
			{
				return this.<rtp_timeout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rtp_timeout>k__BackingField = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00013984 File Offset: 0x00011B84
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00013998 File Offset: 0x00011B98
		public int? rtp_timeout_hold
		{
			[CompilerGenerated]
			get
			{
				return this.<rtp_timeout_hold>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rtp_timeout_hold>k__BackingField = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000139AC File Offset: 0x00011BAC
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x000139C0 File Offset: 0x00011BC0
		public string bind_rtp_to_media_address
		{
			[CompilerGenerated]
			get
			{
				return this.<bind_rtp_to_media_address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<bind_rtp_to_media_address>k__BackingField = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000139D4 File Offset: 0x00011BD4
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x000139E8 File Offset: 0x00011BE8
		public string voicemail_extension
		{
			[CompilerGenerated]
			get
			{
				return this.<voicemail_extension>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<voicemail_extension>k__BackingField = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000139FC File Offset: 0x00011BFC
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00013A10 File Offset: 0x00011C10
		public int? mwi_subscribe_replaces_unsolicited
		{
			[CompilerGenerated]
			get
			{
				return this.<mwi_subscribe_replaces_unsolicited>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<mwi_subscribe_replaces_unsolicited>k__BackingField = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00013A24 File Offset: 0x00011C24
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00013A38 File Offset: 0x00011C38
		public string deny
		{
			[CompilerGenerated]
			get
			{
				return this.<deny>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<deny>k__BackingField = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00013A4C File Offset: 0x00011C4C
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00013A60 File Offset: 0x00011C60
		public string permit
		{
			[CompilerGenerated]
			get
			{
				return this.<permit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<permit>k__BackingField = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00013A74 File Offset: 0x00011C74
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00013A88 File Offset: 0x00011C88
		public string acl
		{
			[CompilerGenerated]
			get
			{
				return this.<acl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<acl>k__BackingField = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00013A9C File Offset: 0x00011C9C
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00013AB0 File Offset: 0x00011CB0
		public string contact_deny
		{
			[CompilerGenerated]
			get
			{
				return this.<contact_deny>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<contact_deny>k__BackingField = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00013AC4 File Offset: 0x00011CC4
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00013AD8 File Offset: 0x00011CD8
		public string contact_permit
		{
			[CompilerGenerated]
			get
			{
				return this.<contact_permit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<contact_permit>k__BackingField = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00013AEC File Offset: 0x00011CEC
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00013B00 File Offset: 0x00011D00
		public string contact_acl
		{
			[CompilerGenerated]
			get
			{
				return this.<contact_acl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<contact_acl>k__BackingField = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00013B14 File Offset: 0x00011D14
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00013B28 File Offset: 0x00011D28
		public string subscribe_context
		{
			[CompilerGenerated]
			get
			{
				return this.<subscribe_context>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<subscribe_context>k__BackingField = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00013B3C File Offset: 0x00011D3C
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00013B50 File Offset: 0x00011D50
		public int? fax_detect_timeout
		{
			[CompilerGenerated]
			get
			{
				return this.<fax_detect_timeout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fax_detect_timeout>k__BackingField = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00013B64 File Offset: 0x00011D64
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00013B78 File Offset: 0x00011D78
		public virtual ICollection<users> users
		{
			[CompilerGenerated]
			get
			{
				return this.<users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<users>k__BackingField = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00013B8C File Offset: 0x00011D8C
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00013BC8 File Offset: 0x00011DC8
		public List<object> AllowList
		{
			get
			{
				if (this.allow != null)
				{
					return new List<object>(this.allow.Split(new char[]
					{
						','
					}).ToList<string>());
				}
				return new List<object>();
			}
			set
			{
				if (value == null)
				{
					this.allow = null;
					return;
				}
				this.allow = string.Join(",", value.ToArray());
			}
		}

		// Token: 0x0400045B RID: 1115
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x0400045C RID: 1116
		[CompilerGenerated]
		private string <transport>k__BackingField;

		// Token: 0x0400045D RID: 1117
		[CompilerGenerated]
		private string <aors>k__BackingField;

		// Token: 0x0400045E RID: 1118
		[CompilerGenerated]
		private string <auth>k__BackingField;

		// Token: 0x0400045F RID: 1119
		[CompilerGenerated]
		private string <context>k__BackingField;

		// Token: 0x04000460 RID: 1120
		[CompilerGenerated]
		private string <disallow>k__BackingField;

		// Token: 0x04000461 RID: 1121
		[CompilerGenerated]
		private string <allow>k__BackingField;

		// Token: 0x04000462 RID: 1122
		[CompilerGenerated]
		private string <direct_media>k__BackingField;

		// Token: 0x04000463 RID: 1123
		[CompilerGenerated]
		private string <connected_line_method>k__BackingField;

		// Token: 0x04000464 RID: 1124
		[CompilerGenerated]
		private string <direct_media_method>k__BackingField;

		// Token: 0x04000465 RID: 1125
		[CompilerGenerated]
		private string <direct_media_glare_mitigation>k__BackingField;

		// Token: 0x04000466 RID: 1126
		[CompilerGenerated]
		private string <disable_direct_media_on_nat>k__BackingField;

		// Token: 0x04000467 RID: 1127
		[CompilerGenerated]
		private string <dtmf_mode>k__BackingField;

		// Token: 0x04000468 RID: 1128
		[CompilerGenerated]
		private string <external_media_address>k__BackingField;

		// Token: 0x04000469 RID: 1129
		[CompilerGenerated]
		private string <force_rport>k__BackingField;

		// Token: 0x0400046A RID: 1130
		[CompilerGenerated]
		private string <ice_support>k__BackingField;

		// Token: 0x0400046B RID: 1131
		[CompilerGenerated]
		private string <identify_by>k__BackingField;

		// Token: 0x0400046C RID: 1132
		[CompilerGenerated]
		private string <mailboxes>k__BackingField;

		// Token: 0x0400046D RID: 1133
		[CompilerGenerated]
		private string <moh_suggest>k__BackingField;

		// Token: 0x0400046E RID: 1134
		[CompilerGenerated]
		private string <outbound_auth>k__BackingField;

		// Token: 0x0400046F RID: 1135
		[CompilerGenerated]
		private string <outbound_proxy>k__BackingField;

		// Token: 0x04000470 RID: 1136
		[CompilerGenerated]
		private string <rewrite_contact>k__BackingField;

		// Token: 0x04000471 RID: 1137
		[CompilerGenerated]
		private string <rtp_ipv6>k__BackingField;

		// Token: 0x04000472 RID: 1138
		[CompilerGenerated]
		private string <rtp_symmetric>k__BackingField;

		// Token: 0x04000473 RID: 1139
		[CompilerGenerated]
		private string <send_diversion>k__BackingField;

		// Token: 0x04000474 RID: 1140
		[CompilerGenerated]
		private string <send_pai>k__BackingField;

		// Token: 0x04000475 RID: 1141
		[CompilerGenerated]
		private string <send_rpid>k__BackingField;

		// Token: 0x04000476 RID: 1142
		[CompilerGenerated]
		private int? <timers_min_se>k__BackingField;

		// Token: 0x04000477 RID: 1143
		[CompilerGenerated]
		private string <timers>k__BackingField;

		// Token: 0x04000478 RID: 1144
		[CompilerGenerated]
		private int? <timers_sess_expires>k__BackingField;

		// Token: 0x04000479 RID: 1145
		[CompilerGenerated]
		private string <callerid>k__BackingField;

		// Token: 0x0400047A RID: 1146
		[CompilerGenerated]
		private string <callerid_privacy>k__BackingField;

		// Token: 0x0400047B RID: 1147
		[CompilerGenerated]
		private string <callerid_tag>k__BackingField;

		// Token: 0x0400047C RID: 1148
		[CompilerGenerated]
		private string <C100rel>k__BackingField;

		// Token: 0x0400047D RID: 1149
		[CompilerGenerated]
		private string <aggregate_mwi>k__BackingField;

		// Token: 0x0400047E RID: 1150
		[CompilerGenerated]
		private string <trust_id_inbound>k__BackingField;

		// Token: 0x0400047F RID: 1151
		[CompilerGenerated]
		private string <trust_id_outbound>k__BackingField;

		// Token: 0x04000480 RID: 1152
		[CompilerGenerated]
		private string <use_ptime>k__BackingField;

		// Token: 0x04000481 RID: 1153
		[CompilerGenerated]
		private string <use_avpf>k__BackingField;

		// Token: 0x04000482 RID: 1154
		[CompilerGenerated]
		private string <media_encryption>k__BackingField;

		// Token: 0x04000483 RID: 1155
		[CompilerGenerated]
		private string <inband_progress>k__BackingField;

		// Token: 0x04000484 RID: 1156
		[CompilerGenerated]
		private string <call_group>k__BackingField;

		// Token: 0x04000485 RID: 1157
		[CompilerGenerated]
		private string <pickup_group>k__BackingField;

		// Token: 0x04000486 RID: 1158
		[CompilerGenerated]
		private string <named_call_group>k__BackingField;

		// Token: 0x04000487 RID: 1159
		[CompilerGenerated]
		private string <named_pickup_group>k__BackingField;

		// Token: 0x04000488 RID: 1160
		[CompilerGenerated]
		private int? <device_state_busy_at>k__BackingField;

		// Token: 0x04000489 RID: 1161
		[CompilerGenerated]
		private string <fax_detect>k__BackingField;

		// Token: 0x0400048A RID: 1162
		[CompilerGenerated]
		private string <t38_udptl>k__BackingField;

		// Token: 0x0400048B RID: 1163
		[CompilerGenerated]
		private string <t38_udptl_ec>k__BackingField;

		// Token: 0x0400048C RID: 1164
		[CompilerGenerated]
		private int? <t38_udptl_maxdatagram>k__BackingField;

		// Token: 0x0400048D RID: 1165
		[CompilerGenerated]
		private string <t38_udptl_nat>k__BackingField;

		// Token: 0x0400048E RID: 1166
		[CompilerGenerated]
		private string <t38_udptl_ipv6>k__BackingField;

		// Token: 0x0400048F RID: 1167
		[CompilerGenerated]
		private string <tone_zone>k__BackingField;

		// Token: 0x04000490 RID: 1168
		[CompilerGenerated]
		private string <language>k__BackingField;

		// Token: 0x04000491 RID: 1169
		[CompilerGenerated]
		private string <one_touch_recording>k__BackingField;

		// Token: 0x04000492 RID: 1170
		[CompilerGenerated]
		private string <record_on_feature>k__BackingField;

		// Token: 0x04000493 RID: 1171
		[CompilerGenerated]
		private string <record_off_feature>k__BackingField;

		// Token: 0x04000494 RID: 1172
		[CompilerGenerated]
		private string <rtp_engine>k__BackingField;

		// Token: 0x04000495 RID: 1173
		[CompilerGenerated]
		private string <allow_transfer>k__BackingField;

		// Token: 0x04000496 RID: 1174
		[CompilerGenerated]
		private string <allow_subscribe>k__BackingField;

		// Token: 0x04000497 RID: 1175
		[CompilerGenerated]
		private string <sdp_owner>k__BackingField;

		// Token: 0x04000498 RID: 1176
		[CompilerGenerated]
		private string <sdp_session>k__BackingField;

		// Token: 0x04000499 RID: 1177
		[CompilerGenerated]
		private string <tos_audio>k__BackingField;

		// Token: 0x0400049A RID: 1178
		[CompilerGenerated]
		private string <tos_video>k__BackingField;

		// Token: 0x0400049B RID: 1179
		[CompilerGenerated]
		private int? <sub_min_expiry>k__BackingField;

		// Token: 0x0400049C RID: 1180
		[CompilerGenerated]
		private string <from_domain>k__BackingField;

		// Token: 0x0400049D RID: 1181
		[CompilerGenerated]
		private string <from_user>k__BackingField;

		// Token: 0x0400049E RID: 1182
		[CompilerGenerated]
		private string <mwi_from_user>k__BackingField;

		// Token: 0x0400049F RID: 1183
		[CompilerGenerated]
		private string <dtls_verify>k__BackingField;

		// Token: 0x040004A0 RID: 1184
		[CompilerGenerated]
		private string <dtls_rekey>k__BackingField;

		// Token: 0x040004A1 RID: 1185
		[CompilerGenerated]
		private string <dtls_cert_file>k__BackingField;

		// Token: 0x040004A2 RID: 1186
		[CompilerGenerated]
		private string <dtls_private_key>k__BackingField;

		// Token: 0x040004A3 RID: 1187
		[CompilerGenerated]
		private string <dtls_cipher>k__BackingField;

		// Token: 0x040004A4 RID: 1188
		[CompilerGenerated]
		private string <dtls_ca_file>k__BackingField;

		// Token: 0x040004A5 RID: 1189
		[CompilerGenerated]
		private string <dtls_ca_path>k__BackingField;

		// Token: 0x040004A6 RID: 1190
		[CompilerGenerated]
		private string <dtls_setup>k__BackingField;

		// Token: 0x040004A7 RID: 1191
		[CompilerGenerated]
		private string <srtp_tag_32>k__BackingField;

		// Token: 0x040004A8 RID: 1192
		[CompilerGenerated]
		private string <media_address>k__BackingField;

		// Token: 0x040004A9 RID: 1193
		[CompilerGenerated]
		private string <redirect_method>k__BackingField;

		// Token: 0x040004AA RID: 1194
		[CompilerGenerated]
		private string <set_var>k__BackingField;

		// Token: 0x040004AB RID: 1195
		[CompilerGenerated]
		private int? <cos_audio>k__BackingField;

		// Token: 0x040004AC RID: 1196
		[CompilerGenerated]
		private int? <cos_video>k__BackingField;

		// Token: 0x040004AD RID: 1197
		[CompilerGenerated]
		private string <message_context>k__BackingField;

		// Token: 0x040004AE RID: 1198
		[CompilerGenerated]
		private string <force_avp>k__BackingField;

		// Token: 0x040004AF RID: 1199
		[CompilerGenerated]
		private string <media_use_received_transport>k__BackingField;

		// Token: 0x040004B0 RID: 1200
		[CompilerGenerated]
		private string <accountcode>k__BackingField;

		// Token: 0x040004B1 RID: 1201
		[CompilerGenerated]
		private string <user_eq_phone>k__BackingField;

		// Token: 0x040004B2 RID: 1202
		[CompilerGenerated]
		private string <moh_passthrough>k__BackingField;

		// Token: 0x040004B3 RID: 1203
		[CompilerGenerated]
		private string <media_encryption_optimistic>k__BackingField;

		// Token: 0x040004B4 RID: 1204
		[CompilerGenerated]
		private string <rpid_immediate>k__BackingField;

		// Token: 0x040004B5 RID: 1205
		[CompilerGenerated]
		private string <g726_non_standard>k__BackingField;

		// Token: 0x040004B6 RID: 1206
		[CompilerGenerated]
		private int? <rtp_keepalive>k__BackingField;

		// Token: 0x040004B7 RID: 1207
		[CompilerGenerated]
		private int? <rtp_timeout>k__BackingField;

		// Token: 0x040004B8 RID: 1208
		[CompilerGenerated]
		private int? <rtp_timeout_hold>k__BackingField;

		// Token: 0x040004B9 RID: 1209
		[CompilerGenerated]
		private string <bind_rtp_to_media_address>k__BackingField;

		// Token: 0x040004BA RID: 1210
		[CompilerGenerated]
		private string <voicemail_extension>k__BackingField;

		// Token: 0x040004BB RID: 1211
		[CompilerGenerated]
		private int? <mwi_subscribe_replaces_unsolicited>k__BackingField;

		// Token: 0x040004BC RID: 1212
		[CompilerGenerated]
		private string <deny>k__BackingField;

		// Token: 0x040004BD RID: 1213
		[CompilerGenerated]
		private string <permit>k__BackingField;

		// Token: 0x040004BE RID: 1214
		[CompilerGenerated]
		private string <acl>k__BackingField;

		// Token: 0x040004BF RID: 1215
		[CompilerGenerated]
		private string <contact_deny>k__BackingField;

		// Token: 0x040004C0 RID: 1216
		[CompilerGenerated]
		private string <contact_permit>k__BackingField;

		// Token: 0x040004C1 RID: 1217
		[CompilerGenerated]
		private string <contact_acl>k__BackingField;

		// Token: 0x040004C2 RID: 1218
		[CompilerGenerated]
		private string <subscribe_context>k__BackingField;

		// Token: 0x040004C3 RID: 1219
		[CompilerGenerated]
		private int? <fax_detect_timeout>k__BackingField;

		// Token: 0x040004C4 RID: 1220
		[CompilerGenerated]
		private ICollection<users> <users>k__BackingField;
	}
}
