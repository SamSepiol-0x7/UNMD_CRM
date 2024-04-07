using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x0200002A RID: 42
	public class auseceEntities : DbContext
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00006DE8 File Offset: 0x00004FE8
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			throw new UnintentionalCodeFirstException();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00006DFC File Offset: 0x00004FFC
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00006E10 File Offset: 0x00005010
		public virtual DbSet<alembic_version> alembic_version
		{
			[CompilerGenerated]
			get
			{
				return this.<alembic_version>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<alembic_version>k__BackingField = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00006E24 File Offset: 0x00005024
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00006E38 File Offset: 0x00005038
		public virtual DbSet<banks> banks
		{
			[CompilerGenerated]
			get
			{
				return this.<banks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<banks>k__BackingField = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00006E4C File Offset: 0x0000504C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00006E60 File Offset: 0x00005060
		public virtual DbSet<currency> currency
		{
			[CompilerGenerated]
			get
			{
				return this.<currency>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<currency>k__BackingField = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00006E74 File Offset: 0x00005074
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00006E88 File Offset: 0x00005088
		public virtual DbSet<device_makers> device_makers
		{
			[CompilerGenerated]
			get
			{
				return this.<device_makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<device_makers>k__BackingField = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00006EB0 File Offset: 0x000050B0
		public virtual DbSet<device_models> device_models
		{
			[CompilerGenerated]
			get
			{
				return this.<device_models>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<device_models>k__BackingField = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00006EC4 File Offset: 0x000050C4
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00006ED8 File Offset: 0x000050D8
		public virtual DbSet<iaxfriends> iaxfriends
		{
			[CompilerGenerated]
			get
			{
				return this.<iaxfriends>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<iaxfriends>k__BackingField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00006EEC File Offset: 0x000050EC
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00006F00 File Offset: 0x00005100
		public virtual DbSet<in_sms> in_sms
		{
			[CompilerGenerated]
			get
			{
				return this.<in_sms>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<in_sms>k__BackingField = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00006F14 File Offset: 0x00005114
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00006F28 File Offset: 0x00005128
		public virtual DbSet<items_state> items_state
		{
			[CompilerGenerated]
			get
			{
				return this.<items_state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<items_state>k__BackingField = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00006F3C File Offset: 0x0000513C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00006F50 File Offset: 0x00005150
		public virtual DbSet<meetme> meetme
		{
			[CompilerGenerated]
			get
			{
				return this.<meetme>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<meetme>k__BackingField = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00006F64 File Offset: 0x00005164
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00006F78 File Offset: 0x00005178
		public virtual DbSet<musiconhold> musiconhold
		{
			[CompilerGenerated]
			get
			{
				return this.<musiconhold>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<musiconhold>k__BackingField = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00006F8C File Offset: 0x0000518C
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00006FA0 File Offset: 0x000051A0
		public virtual DbSet<order_items> order_items
		{
			[CompilerGenerated]
			get
			{
				return this.<order_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<order_items>k__BackingField = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00006FB4 File Offset: 0x000051B4
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00006FC8 File Offset: 0x000051C8
		public virtual DbSet<permissions> permissions
		{
			[CompilerGenerated]
			get
			{
				return this.<permissions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<permissions>k__BackingField = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00006FDC File Offset: 0x000051DC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00006FF0 File Offset: 0x000051F0
		public virtual DbSet<permissions_roles> permissions_roles
		{
			[CompilerGenerated]
			get
			{
				return this.<permissions_roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<permissions_roles>k__BackingField = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00007004 File Offset: 0x00005204
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00007018 File Offset: 0x00005218
		public virtual DbSet<ps_aors> ps_aors
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_aors>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_aors>k__BackingField = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000702C File Offset: 0x0000522C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00007040 File Offset: 0x00005240
		public virtual DbSet<ps_auths> ps_auths
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_auths>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_auths>k__BackingField = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00007054 File Offset: 0x00005254
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00007068 File Offset: 0x00005268
		public virtual DbSet<ps_endpoints> ps_endpoints
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_endpoints>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_endpoints>k__BackingField = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000707C File Offset: 0x0000527C
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00007090 File Offset: 0x00005290
		public virtual DbSet<queues> queues
		{
			[CompilerGenerated]
			get
			{
				return this.<queues>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<queues>k__BackingField = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000070A4 File Offset: 0x000052A4
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000070B8 File Offset: 0x000052B8
		public virtual DbSet<roles> roles
		{
			[CompilerGenerated]
			get
			{
				return this.<roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<roles>k__BackingField = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000070CC File Offset: 0x000052CC
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000070E0 File Offset: 0x000052E0
		public virtual DbSet<roles_users> roles_users
		{
			[CompilerGenerated]
			get
			{
				return this.<roles_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<roles_users>k__BackingField = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000070F4 File Offset: 0x000052F4
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00007108 File Offset: 0x00005308
		public virtual DbSet<sippeers> sippeers
		{
			[CompilerGenerated]
			get
			{
				return this.<sippeers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sippeers>k__BackingField = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000711C File Offset: 0x0000531C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00007130 File Offset: 0x00005330
		public virtual DbSet<sipusers> sipusers
		{
			[CompilerGenerated]
			get
			{
				return this.<sipusers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sipusers>k__BackingField = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00007144 File Offset: 0x00005344
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00007158 File Offset: 0x00005358
		public virtual DbSet<store_cats> store_cats
		{
			[CompilerGenerated]
			get
			{
				return this.<store_cats>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_cats>k__BackingField = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000716C File Offset: 0x0000536C
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00007180 File Offset: 0x00005380
		public virtual DbSet<store_sub_types> store_sub_types
		{
			[CompilerGenerated]
			get
			{
				return this.<store_sub_types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_sub_types>k__BackingField = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00007194 File Offset: 0x00005394
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x000071A8 File Offset: 0x000053A8
		public virtual DbSet<store_types> store_types
		{
			[CompilerGenerated]
			get
			{
				return this.<store_types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_types>k__BackingField = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000071BC File Offset: 0x000053BC
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x000071D0 File Offset: 0x000053D0
		public virtual DbSet<stores> stores
		{
			[CompilerGenerated]
			get
			{
				return this.<stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<stores>k__BackingField = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000071E4 File Offset: 0x000053E4
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x000071F8 File Offset: 0x000053F8
		public virtual DbSet<visit_sources> visit_sources
		{
			[CompilerGenerated]
			get
			{
				return this.<visit_sources>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<visit_sources>k__BackingField = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000720C File Offset: 0x0000540C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00007220 File Offset: 0x00005420
		public virtual DbSet<voicemail> voicemail
		{
			[CompilerGenerated]
			get
			{
				return this.<voicemail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<voicemail>k__BackingField = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00007234 File Offset: 0x00005434
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00007248 File Offset: 0x00005448
		public virtual DbSet<workshop_cats> workshop_cats
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_cats>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_cats>k__BackingField = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000725C File Offset: 0x0000545C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00007270 File Offset: 0x00005470
		public virtual DbSet<workshop_parts> workshop_parts
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_parts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_parts>k__BackingField = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00007284 File Offset: 0x00005484
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00007298 File Offset: 0x00005498
		public virtual DbSet<workshop_price> workshop_price
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_price>k__BackingField = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000072AC File Offset: 0x000054AC
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000072C0 File Offset: 0x000054C0
		public virtual DbSet<cdr> cdr
		{
			[CompilerGenerated]
			get
			{
				return this.<cdr>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cdr>k__BackingField = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000072D4 File Offset: 0x000054D4
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x000072E8 File Offset: 0x000054E8
		public virtual DbSet<ps_globals> ps_globals
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_globals>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_globals>k__BackingField = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000072FC File Offset: 0x000054FC
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00007310 File Offset: 0x00005510
		public virtual DbSet<ps_subscription_persistence> ps_subscription_persistence
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_subscription_persistence>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_subscription_persistence>k__BackingField = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00007324 File Offset: 0x00005524
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00007338 File Offset: 0x00005538
		public virtual DbSet<ps_systems> ps_systems
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_systems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_systems>k__BackingField = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000734C File Offset: 0x0000554C
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00007360 File Offset: 0x00005560
		public virtual DbSet<ps_transports> ps_transports
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_transports>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_transports>k__BackingField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00007374 File Offset: 0x00005574
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00007388 File Offset: 0x00005588
		public virtual DbSet<queue_rules> queue_rules
		{
			[CompilerGenerated]
			get
			{
				return this.<queue_rules>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<queue_rules>k__BackingField = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000739C File Offset: 0x0000559C
		// (set) Token: 0x060001DE RID: 478 RVA: 0x000073B0 File Offset: 0x000055B0
		public virtual DbSet<workshop> workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop>k__BackingField = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000073C4 File Offset: 0x000055C4
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000073D8 File Offset: 0x000055D8
		public virtual DbSet<devices> devices
		{
			[CompilerGenerated]
			get
			{
				return this.<devices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<devices>k__BackingField = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000073EC File Offset: 0x000055EC
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00007400 File Offset: 0x00005600
		public virtual DbSet<store_sales> store_sales
		{
			[CompilerGenerated]
			get
			{
				return this.<store_sales>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_sales>k__BackingField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00007414 File Offset: 0x00005614
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00007428 File Offset: 0x00005628
		public virtual DbSet<voip_ext_devices> voip_ext_devices
		{
			[CompilerGenerated]
			get
			{
				return this.<voip_ext_devices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<voip_ext_devices>k__BackingField = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000743C File Offset: 0x0000563C
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00007450 File Offset: 0x00005650
		public virtual DbSet<store_items> store_items
		{
			[CompilerGenerated]
			get
			{
				return this.<store_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_items>k__BackingField = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00007464 File Offset: 0x00005664
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00007478 File Offset: 0x00005678
		public virtual DbSet<docs> docs
		{
			[CompilerGenerated]
			get
			{
				return this.<docs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<docs>k__BackingField = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000748C File Offset: 0x0000568C
		// (set) Token: 0x060001EA RID: 490 RVA: 0x000074A0 File Offset: 0x000056A0
		public virtual DbSet<export_cat_match> export_cat_match
		{
			[CompilerGenerated]
			get
			{
				return this.<export_cat_match>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<export_cat_match>k__BackingField = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000074B4 File Offset: 0x000056B4
		// (set) Token: 0x060001EC RID: 492 RVA: 0x000074C8 File Offset: 0x000056C8
		public virtual DbSet<export_items> export_items
		{
			[CompilerGenerated]
			get
			{
				return this.<export_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<export_items>k__BackingField = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000074DC File Offset: 0x000056DC
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000074F0 File Offset: 0x000056F0
		public virtual DbSet<users_activity> users_activity
		{
			[CompilerGenerated]
			get
			{
				return this.<users_activity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<users_activity>k__BackingField = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00007504 File Offset: 0x00005704
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00007518 File Offset: 0x00005718
		public virtual DbSet<works> works
		{
			[CompilerGenerated]
			get
			{
				return this.<works>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<works>k__BackingField = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000752C File Offset: 0x0000572C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00007540 File Offset: 0x00005740
		public virtual DbSet<additional_payments> additional_payments
		{
			[CompilerGenerated]
			get
			{
				return this.<additional_payments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<additional_payments>k__BackingField = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00007554 File Offset: 0x00005754
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00007568 File Offset: 0x00005768
		public virtual DbSet<salary> salary
		{
			[CompilerGenerated]
			get
			{
				return this.<salary>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<salary>k__BackingField = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000757C File Offset: 0x0000577C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00007590 File Offset: 0x00005790
		public virtual DbSet<schemaversions> schemaversions
		{
			[CompilerGenerated]
			get
			{
				return this.<schemaversions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<schemaversions>k__BackingField = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000075A4 File Offset: 0x000057A4
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000075B8 File Offset: 0x000057B8
		public virtual DbSet<clients> clients
		{
			[CompilerGenerated]
			get
			{
				return this.<clients>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<clients>k__BackingField = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000075CC File Offset: 0x000057CC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000075E0 File Offset: 0x000057E0
		public virtual DbSet<sms_templates> sms_templates
		{
			[CompilerGenerated]
			get
			{
				return this.<sms_templates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sms_templates>k__BackingField = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000075F4 File Offset: 0x000057F4
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00007608 File Offset: 0x00005808
		public virtual DbSet<doc_templates> doc_templates
		{
			[CompilerGenerated]
			get
			{
				return this.<doc_templates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<doc_templates>k__BackingField = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000761C File Offset: 0x0000581C
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00007630 File Offset: 0x00005830
		public virtual DbSet<offices> offices
		{
			[CompilerGenerated]
			get
			{
				return this.<offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<offices>k__BackingField = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00007644 File Offset: 0x00005844
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00007658 File Offset: 0x00005858
		public virtual DbSet<balance> balance
		{
			[CompilerGenerated]
			get
			{
				return this.<balance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<balance>k__BackingField = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000766C File Offset: 0x0000586C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00007680 File Offset: 0x00005880
		public virtual DbSet<logs> logs
		{
			[CompilerGenerated]
			get
			{
				return this.<logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<logs>k__BackingField = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00007694 File Offset: 0x00005894
		// (set) Token: 0x06000204 RID: 516 RVA: 0x000076A8 File Offset: 0x000058A8
		public virtual DbSet<store_int_reserve> store_int_reserve
		{
			[CompilerGenerated]
			get
			{
				return this.<store_int_reserve>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_int_reserve>k__BackingField = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000076BC File Offset: 0x000058BC
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000076D0 File Offset: 0x000058D0
		public virtual DbSet<media_info> media_info
		{
			[CompilerGenerated]
			get
			{
				return this.<media_info>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<media_info>k__BackingField = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000076E4 File Offset: 0x000058E4
		// (set) Token: 0x06000208 RID: 520 RVA: 0x000076F8 File Offset: 0x000058F8
		public virtual DbSet<payment_systems> payment_systems
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_systems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_systems>k__BackingField = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000770C File Offset: 0x0000590C
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00007720 File Offset: 0x00005920
		public virtual DbSet<cash_orders> cash_orders
		{
			[CompilerGenerated]
			get
			{
				return this.<cash_orders>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cash_orders>k__BackingField = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00007734 File Offset: 0x00005934
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00007748 File Offset: 0x00005948
		public virtual DbSet<dealer_payments> dealer_payments
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer_payments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dealer_payments>k__BackingField = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000775C File Offset: 0x0000595C
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00007770 File Offset: 0x00005970
		public virtual DbSet<config> config
		{
			[CompilerGenerated]
			get
			{
				return this.<config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<config>k__BackingField = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00007784 File Offset: 0x00005984
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00007798 File Offset: 0x00005998
		public virtual DbSet<users> users
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000077AC File Offset: 0x000059AC
		// (set) Token: 0x06000212 RID: 530 RVA: 0x000077C0 File Offset: 0x000059C0
		public virtual DbSet<ps_domain_aliases> ps_domain_aliases
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_domain_aliases>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_domain_aliases>k__BackingField = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000077D4 File Offset: 0x000059D4
		// (set) Token: 0x06000214 RID: 532 RVA: 0x000077E8 File Offset: 0x000059E8
		public virtual DbSet<ps_endpoint_id_ips> ps_endpoint_id_ips
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_endpoint_id_ips>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_endpoint_id_ips>k__BackingField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000077FC File Offset: 0x000059FC
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00007810 File Offset: 0x00005A10
		public virtual DbSet<ps_registrations> ps_registrations
		{
			[CompilerGenerated]
			get
			{
				return this.<ps_registrations>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ps_registrations>k__BackingField = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00007824 File Offset: 0x00005A24
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00007838 File Offset: 0x00005A38
		public virtual DbSet<queue_members> queue_members
		{
			[CompilerGenerated]
			get
			{
				return this.<queue_members>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<queue_members>k__BackingField = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000784C File Offset: 0x00005A4C
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00007860 File Offset: 0x00005A60
		public virtual DbSet<extensions> extensions
		{
			[CompilerGenerated]
			get
			{
				return this.<extensions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<extensions>k__BackingField = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00007874 File Offset: 0x00005A74
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00007888 File Offset: 0x00005A88
		public virtual DbSet<field_values> field_values
		{
			[CompilerGenerated]
			get
			{
				return this.<field_values>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<field_values>k__BackingField = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000789C File Offset: 0x00005A9C
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000078B0 File Offset: 0x00005AB0
		public virtual DbSet<fields> fields
		{
			[CompilerGenerated]
			get
			{
				return this.<fields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fields>k__BackingField = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000078C4 File Offset: 0x00005AC4
		// (set) Token: 0x06000220 RID: 544 RVA: 0x000078D8 File Offset: 0x00005AD8
		public virtual DbSet<tasks> tasks
		{
			[CompilerGenerated]
			get
			{
				return this.<tasks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tasks>k__BackingField = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000078EC File Offset: 0x00005AEC
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00007900 File Offset: 0x00005B00
		public virtual DbSet<payment_type_users> payment_type_users
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_type_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_type_users>k__BackingField = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00007914 File Offset: 0x00005B14
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00007928 File Offset: 0x00005B28
		public virtual DbSet<payment_types> payment_types
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_types>k__BackingField = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000793C File Offset: 0x00005B3C
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00007950 File Offset: 0x00005B50
		public virtual DbSet<companies> companies
		{
			[CompilerGenerated]
			get
			{
				return this.<companies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<companies>k__BackingField = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00007964 File Offset: 0x00005B64
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00007978 File Offset: 0x00005B78
		public virtual DbSet<store_fields> store_fields
		{
			[CompilerGenerated]
			get
			{
				return this.<store_fields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_fields>k__BackingField = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000798C File Offset: 0x00005B8C
		// (set) Token: 0x0600022A RID: 554 RVA: 0x000079A0 File Offset: 0x00005BA0
		public virtual DbSet<parts_request> parts_request
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<parts_request>k__BackingField = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000079B4 File Offset: 0x00005BB4
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000079C8 File Offset: 0x00005BC8
		public virtual DbSet<parts_request_employees> parts_request_employees
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request_employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<parts_request_employees>k__BackingField = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000079DC File Offset: 0x00005BDC
		// (set) Token: 0x0600022E RID: 558 RVA: 0x000079F0 File Offset: 0x00005BF0
		public virtual DbSet<task_employees> task_employees
		{
			[CompilerGenerated]
			get
			{
				return this.<task_employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<task_employees>k__BackingField = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00007A04 File Offset: 0x00005C04
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00007A18 File Offset: 0x00005C18
		public virtual DbSet<comments> comments
		{
			[CompilerGenerated]
			get
			{
				return this.<comments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<comments>k__BackingField = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00007A2C File Offset: 0x00005C2C
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00007A40 File Offset: 0x00005C40
		public virtual DbSet<images> images
		{
			[CompilerGenerated]
			get
			{
				return this.<images>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<images>k__BackingField = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00007A54 File Offset: 0x00005C54
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00007A68 File Offset: 0x00005C68
		public virtual DbSet<boxes> boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<boxes>k__BackingField = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00007A7C File Offset: 0x00005C7C
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00007A90 File Offset: 0x00005C90
		public virtual DbSet<out_sms> out_sms
		{
			[CompilerGenerated]
			get
			{
				return this.<out_sms>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<out_sms>k__BackingField = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00007AA4 File Offset: 0x00005CA4
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public virtual DbSet<tel> tel
		{
			[CompilerGenerated]
			get
			{
				return this.<tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tel>k__BackingField = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00007ACC File Offset: 0x00005CCC
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00007AE0 File Offset: 0x00005CE0
		public virtual DbSet<invoice> invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice>k__BackingField = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007AF4 File Offset: 0x00005CF4
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00007B08 File Offset: 0x00005D08
		public virtual DbSet<vat_invoice> vat_invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<vat_invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vat_invoice>k__BackingField = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00007B1C File Offset: 0x00005D1C
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00007B30 File Offset: 0x00005D30
		public virtual DbSet<invoice_items> invoice_items
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice_items>k__BackingField = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00007B44 File Offset: 0x00005D44
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00007B58 File Offset: 0x00005D58
		public virtual DbSet<p_lists> p_lists
		{
			[CompilerGenerated]
			get
			{
				return this.<p_lists>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<p_lists>k__BackingField = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00007B6C File Offset: 0x00005D6C
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00007B80 File Offset: 0x00005D80
		public virtual DbSet<w_lists> w_lists
		{
			[CompilerGenerated]
			get
			{
				return this.<w_lists>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<w_lists>k__BackingField = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00007B94 File Offset: 0x00005D94
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00007BA8 File Offset: 0x00005DA8
		public virtual DbSet<cartridge_cards> cartridge_cards
		{
			[CompilerGenerated]
			get
			{
				return this.<cartridge_cards>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cartridge_cards>k__BackingField = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007BBC File Offset: 0x00005DBC
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00007BD0 File Offset: 0x00005DD0
		public virtual DbSet<materials> materials
		{
			[CompilerGenerated]
			get
			{
				return this.<materials>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<materials>k__BackingField = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00007BE4 File Offset: 0x00005DE4
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00007BF8 File Offset: 0x00005DF8
		public virtual DbSet<c_workshop> c_workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<c_workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<c_workshop>k__BackingField = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00007C0C File Offset: 0x00005E0C
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00007C20 File Offset: 0x00005E20
		public virtual DbSet<kkt> kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt>k__BackingField = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00007C34 File Offset: 0x00005E34
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00007C48 File Offset: 0x00005E48
		public virtual DbSet<pinpad> pinpad
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad>k__BackingField = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00007C5C File Offset: 0x00005E5C
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00007C70 File Offset: 0x00005E70
		public virtual DbSet<pinpad_logs> pinpad_logs
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad_logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad_logs>k__BackingField = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00007C84 File Offset: 0x00005E84
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00007C98 File Offset: 0x00005E98
		public virtual DbSet<kkt_employee> kkt_employee
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt_employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt_employee>k__BackingField = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00007CAC File Offset: 0x00005EAC
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00007CC0 File Offset: 0x00005EC0
		public virtual DbSet<notifications> notifications
		{
			[CompilerGenerated]
			get
			{
				return this.<notifications>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<notifications>k__BackingField = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00007CD4 File Offset: 0x00005ED4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public virtual DbSet<api_failed_logins> api_failed_logins
		{
			[CompilerGenerated]
			get
			{
				return this.<api_failed_logins>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<api_failed_logins>k__BackingField = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00007CFC File Offset: 0x00005EFC
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00007D10 File Offset: 0x00005F10
		public virtual DbSet<api_status_checks> api_status_checks
		{
			[CompilerGenerated]
			get
			{
				return this.<api_status_checks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<api_status_checks>k__BackingField = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00007D24 File Offset: 0x00005F24
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00007D38 File Offset: 0x00005F38
		public virtual DbSet<hooks> hooks
		{
			[CompilerGenerated]
			get
			{
				return this.<hooks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<hooks>k__BackingField = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00007D4C File Offset: 0x00005F4C
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00007D60 File Offset: 0x00005F60
		public virtual DbSet<vendors> vendors
		{
			[CompilerGenerated]
			get
			{
				return this.<vendors>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vendors>k__BackingField = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00007D74 File Offset: 0x00005F74
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00007D88 File Offset: 0x00005F88
		public virtual DbSet<buyout> buyout
		{
			[CompilerGenerated]
			get
			{
				return this.<buyout>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<buyout>k__BackingField = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00007D9C File Offset: 0x00005F9C
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00007DB0 File Offset: 0x00005FB0
		public virtual DbSet<workshop_issued> workshop_issued
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_issued>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_issued>k__BackingField = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00007DC4 File Offset: 0x00005FC4
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00007DD8 File Offset: 0x00005FD8
		public virtual DbSet<settings> settings
		{
			[CompilerGenerated]
			get
			{
				return this.<settings>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<settings>k__BackingField = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00007DEC File Offset: 0x00005FEC
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00007E00 File Offset: 0x00006000
		public virtual DbSet<repair_status_logs> repair_status_logs
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_status_logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<repair_status_logs>k__BackingField = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00007E14 File Offset: 0x00006014
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00007E28 File Offset: 0x00006028
		public virtual DbSet<SalaryRate> SalaryRates
		{
			[CompilerGenerated]
			get
			{
				return this.<SalaryRates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SalaryRates>k__BackingField = value;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00007E3C File Offset: 0x0000603C
		public virtual int add_User(string p_Name, string p_Passw, string p_DBName)
		{
			ObjectParameter objectParameter = (p_Name == null) ? new ObjectParameter("p_Name", typeof(string)) : new ObjectParameter("p_Name", p_Name);
			ObjectParameter objectParameter2 = (p_Passw != null) ? new ObjectParameter("p_Passw", p_Passw) : new ObjectParameter("p_Passw", typeof(string));
			ObjectParameter objectParameter3 = (p_DBName != null) ? new ObjectParameter("p_DBName", p_DBName) : new ObjectParameter("p_DBName", typeof(string));
			return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_User", new ObjectParameter[]
			{
				objectParameter,
				objectParameter2,
				objectParameter3
			});
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00007EDC File Offset: 0x000060DC
		public virtual int change_Password(string p_Name, string p_Passw)
		{
			ObjectParameter objectParameter = (p_Name == null) ? new ObjectParameter("p_Name", typeof(string)) : new ObjectParameter("p_Name", p_Name);
			ObjectParameter objectParameter2 = (p_Passw != null) ? new ObjectParameter("p_Passw", p_Passw) : new ObjectParameter("p_Passw", typeof(string));
			return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("change_Password", new ObjectParameter[]
			{
				objectParameter,
				objectParameter2
			});
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00007F54 File Offset: 0x00006154
		public virtual int delete_User(string p_Name)
		{
			if (p_Name == null)
			{
				goto IL_45;
			}
			ObjectParameter objectParameter = new ObjectParameter("p_Name", p_Name);
			IL_24:
			ObjectParameter objectParameter2 = objectParameter;
			int num = -539869954;
			IL_2A:
			switch ((num ^ -1724326074) % 3)
			{
			case 0:
				IL_45:
				num = -613451763;
				goto IL_2A;
			case 2:
				objectParameter = new ObjectParameter("p_Name", typeof(string));
				goto IL_24;
			}
			return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_User", new ObjectParameter[]
			{
				objectParameter2
			});
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007FC8 File Offset: 0x000061C8
		public virtual ObjectResult<int?> getCatChildrens(int? categoryId)
		{
			ObjectParameter objectParameter = (categoryId != null) ? new ObjectParameter("categoryId", categoryId) : new ObjectParameter("categoryId", typeof(int));
			return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<int?>("getCatChildrens", new ObjectParameter[]
			{
				objectParameter
			});
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00008020 File Offset: 0x00006220
		public auseceEntities(bool proxyCreate = true) : base("name=auseceEntities")
		{
			base.Database.Connection.ConnectionString = Auth.CnnString;
			base.Configuration.ProxyCreationEnabled = proxyCreate;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000805C File Offset: 0x0000625C
		public bool Exists<T>(T entity) where T : class
		{
			return this.Set<T>().Local.Any((T e) => e == entity);
		}

		// Token: 0x040000B9 RID: 185
		[CompilerGenerated]
		private DbSet<alembic_version> <alembic_version>k__BackingField;

		// Token: 0x040000BA RID: 186
		[CompilerGenerated]
		private DbSet<banks> <banks>k__BackingField;

		// Token: 0x040000BB RID: 187
		[CompilerGenerated]
		private DbSet<currency> <currency>k__BackingField;

		// Token: 0x040000BC RID: 188
		[CompilerGenerated]
		private DbSet<device_makers> <device_makers>k__BackingField;

		// Token: 0x040000BD RID: 189
		[CompilerGenerated]
		private DbSet<device_models> <device_models>k__BackingField;

		// Token: 0x040000BE RID: 190
		[CompilerGenerated]
		private DbSet<iaxfriends> <iaxfriends>k__BackingField;

		// Token: 0x040000BF RID: 191
		[CompilerGenerated]
		private DbSet<in_sms> <in_sms>k__BackingField;

		// Token: 0x040000C0 RID: 192
		[CompilerGenerated]
		private DbSet<items_state> <items_state>k__BackingField;

		// Token: 0x040000C1 RID: 193
		[CompilerGenerated]
		private DbSet<meetme> <meetme>k__BackingField;

		// Token: 0x040000C2 RID: 194
		[CompilerGenerated]
		private DbSet<musiconhold> <musiconhold>k__BackingField;

		// Token: 0x040000C3 RID: 195
		[CompilerGenerated]
		private DbSet<order_items> <order_items>k__BackingField;

		// Token: 0x040000C4 RID: 196
		[CompilerGenerated]
		private DbSet<permissions> <permissions>k__BackingField;

		// Token: 0x040000C5 RID: 197
		[CompilerGenerated]
		private DbSet<permissions_roles> <permissions_roles>k__BackingField;

		// Token: 0x040000C6 RID: 198
		[CompilerGenerated]
		private DbSet<ps_aors> <ps_aors>k__BackingField;

		// Token: 0x040000C7 RID: 199
		[CompilerGenerated]
		private DbSet<ps_auths> <ps_auths>k__BackingField;

		// Token: 0x040000C8 RID: 200
		[CompilerGenerated]
		private DbSet<ps_endpoints> <ps_endpoints>k__BackingField;

		// Token: 0x040000C9 RID: 201
		[CompilerGenerated]
		private DbSet<queues> <queues>k__BackingField;

		// Token: 0x040000CA RID: 202
		[CompilerGenerated]
		private DbSet<roles> <roles>k__BackingField;

		// Token: 0x040000CB RID: 203
		[CompilerGenerated]
		private DbSet<roles_users> <roles_users>k__BackingField;

		// Token: 0x040000CC RID: 204
		[CompilerGenerated]
		private DbSet<sippeers> <sippeers>k__BackingField;

		// Token: 0x040000CD RID: 205
		[CompilerGenerated]
		private DbSet<sipusers> <sipusers>k__BackingField;

		// Token: 0x040000CE RID: 206
		[CompilerGenerated]
		private DbSet<store_cats> <store_cats>k__BackingField;

		// Token: 0x040000CF RID: 207
		[CompilerGenerated]
		private DbSet<store_sub_types> <store_sub_types>k__BackingField;

		// Token: 0x040000D0 RID: 208
		[CompilerGenerated]
		private DbSet<store_types> <store_types>k__BackingField;

		// Token: 0x040000D1 RID: 209
		[CompilerGenerated]
		private DbSet<stores> <stores>k__BackingField;

		// Token: 0x040000D2 RID: 210
		[CompilerGenerated]
		private DbSet<visit_sources> <visit_sources>k__BackingField;

		// Token: 0x040000D3 RID: 211
		[CompilerGenerated]
		private DbSet<voicemail> <voicemail>k__BackingField;

		// Token: 0x040000D4 RID: 212
		[CompilerGenerated]
		private DbSet<workshop_cats> <workshop_cats>k__BackingField;

		// Token: 0x040000D5 RID: 213
		[CompilerGenerated]
		private DbSet<workshop_parts> <workshop_parts>k__BackingField;

		// Token: 0x040000D6 RID: 214
		[CompilerGenerated]
		private DbSet<workshop_price> <workshop_price>k__BackingField;

		// Token: 0x040000D7 RID: 215
		[CompilerGenerated]
		private DbSet<cdr> <cdr>k__BackingField;

		// Token: 0x040000D8 RID: 216
		[CompilerGenerated]
		private DbSet<ps_globals> <ps_globals>k__BackingField;

		// Token: 0x040000D9 RID: 217
		[CompilerGenerated]
		private DbSet<ps_subscription_persistence> <ps_subscription_persistence>k__BackingField;

		// Token: 0x040000DA RID: 218
		[CompilerGenerated]
		private DbSet<ps_systems> <ps_systems>k__BackingField;

		// Token: 0x040000DB RID: 219
		[CompilerGenerated]
		private DbSet<ps_transports> <ps_transports>k__BackingField;

		// Token: 0x040000DC RID: 220
		[CompilerGenerated]
		private DbSet<queue_rules> <queue_rules>k__BackingField;

		// Token: 0x040000DD RID: 221
		[CompilerGenerated]
		private DbSet<workshop> <workshop>k__BackingField;

		// Token: 0x040000DE RID: 222
		[CompilerGenerated]
		private DbSet<devices> <devices>k__BackingField;

		// Token: 0x040000DF RID: 223
		[CompilerGenerated]
		private DbSet<store_sales> <store_sales>k__BackingField;

		// Token: 0x040000E0 RID: 224
		[CompilerGenerated]
		private DbSet<voip_ext_devices> <voip_ext_devices>k__BackingField;

		// Token: 0x040000E1 RID: 225
		[CompilerGenerated]
		private DbSet<store_items> <store_items>k__BackingField;

		// Token: 0x040000E2 RID: 226
		[CompilerGenerated]
		private DbSet<docs> <docs>k__BackingField;

		// Token: 0x040000E3 RID: 227
		[CompilerGenerated]
		private DbSet<export_cat_match> <export_cat_match>k__BackingField;

		// Token: 0x040000E4 RID: 228
		[CompilerGenerated]
		private DbSet<export_items> <export_items>k__BackingField;

		// Token: 0x040000E5 RID: 229
		[CompilerGenerated]
		private DbSet<users_activity> <users_activity>k__BackingField;

		// Token: 0x040000E6 RID: 230
		[CompilerGenerated]
		private DbSet<works> <works>k__BackingField;

		// Token: 0x040000E7 RID: 231
		[CompilerGenerated]
		private DbSet<additional_payments> <additional_payments>k__BackingField;

		// Token: 0x040000E8 RID: 232
		[CompilerGenerated]
		private DbSet<salary> <salary>k__BackingField;

		// Token: 0x040000E9 RID: 233
		[CompilerGenerated]
		private DbSet<schemaversions> <schemaversions>k__BackingField;

		// Token: 0x040000EA RID: 234
		[CompilerGenerated]
		private DbSet<clients> <clients>k__BackingField;

		// Token: 0x040000EB RID: 235
		[CompilerGenerated]
		private DbSet<sms_templates> <sms_templates>k__BackingField;

		// Token: 0x040000EC RID: 236
		[CompilerGenerated]
		private DbSet<doc_templates> <doc_templates>k__BackingField;

		// Token: 0x040000ED RID: 237
		[CompilerGenerated]
		private DbSet<offices> <offices>k__BackingField;

		// Token: 0x040000EE RID: 238
		[CompilerGenerated]
		private DbSet<balance> <balance>k__BackingField;

		// Token: 0x040000EF RID: 239
		[CompilerGenerated]
		private DbSet<logs> <logs>k__BackingField;

		// Token: 0x040000F0 RID: 240
		[CompilerGenerated]
		private DbSet<store_int_reserve> <store_int_reserve>k__BackingField;

		// Token: 0x040000F1 RID: 241
		[CompilerGenerated]
		private DbSet<media_info> <media_info>k__BackingField;

		// Token: 0x040000F2 RID: 242
		[CompilerGenerated]
		private DbSet<payment_systems> <payment_systems>k__BackingField;

		// Token: 0x040000F3 RID: 243
		[CompilerGenerated]
		private DbSet<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x040000F4 RID: 244
		[CompilerGenerated]
		private DbSet<dealer_payments> <dealer_payments>k__BackingField;

		// Token: 0x040000F5 RID: 245
		[CompilerGenerated]
		private DbSet<config> <config>k__BackingField;

		// Token: 0x040000F6 RID: 246
		[CompilerGenerated]
		private DbSet<users> <users>k__BackingField;

		// Token: 0x040000F7 RID: 247
		[CompilerGenerated]
		private DbSet<ps_domain_aliases> <ps_domain_aliases>k__BackingField;

		// Token: 0x040000F8 RID: 248
		[CompilerGenerated]
		private DbSet<ps_endpoint_id_ips> <ps_endpoint_id_ips>k__BackingField;

		// Token: 0x040000F9 RID: 249
		[CompilerGenerated]
		private DbSet<ps_registrations> <ps_registrations>k__BackingField;

		// Token: 0x040000FA RID: 250
		[CompilerGenerated]
		private DbSet<queue_members> <queue_members>k__BackingField;

		// Token: 0x040000FB RID: 251
		[CompilerGenerated]
		private DbSet<extensions> <extensions>k__BackingField;

		// Token: 0x040000FC RID: 252
		[CompilerGenerated]
		private DbSet<field_values> <field_values>k__BackingField;

		// Token: 0x040000FD RID: 253
		[CompilerGenerated]
		private DbSet<fields> <fields>k__BackingField;

		// Token: 0x040000FE RID: 254
		[CompilerGenerated]
		private DbSet<tasks> <tasks>k__BackingField;

		// Token: 0x040000FF RID: 255
		[CompilerGenerated]
		private DbSet<payment_type_users> <payment_type_users>k__BackingField;

		// Token: 0x04000100 RID: 256
		[CompilerGenerated]
		private DbSet<payment_types> <payment_types>k__BackingField;

		// Token: 0x04000101 RID: 257
		[CompilerGenerated]
		private DbSet<companies> <companies>k__BackingField;

		// Token: 0x04000102 RID: 258
		[CompilerGenerated]
		private DbSet<store_fields> <store_fields>k__BackingField;

		// Token: 0x04000103 RID: 259
		[CompilerGenerated]
		private DbSet<parts_request> <parts_request>k__BackingField;

		// Token: 0x04000104 RID: 260
		[CompilerGenerated]
		private DbSet<parts_request_employees> <parts_request_employees>k__BackingField;

		// Token: 0x04000105 RID: 261
		[CompilerGenerated]
		private DbSet<task_employees> <task_employees>k__BackingField;

		// Token: 0x04000106 RID: 262
		[CompilerGenerated]
		private DbSet<comments> <comments>k__BackingField;

		// Token: 0x04000107 RID: 263
		[CompilerGenerated]
		private DbSet<images> <images>k__BackingField;

		// Token: 0x04000108 RID: 264
		[CompilerGenerated]
		private DbSet<boxes> <boxes>k__BackingField;

		// Token: 0x04000109 RID: 265
		[CompilerGenerated]
		private DbSet<out_sms> <out_sms>k__BackingField;

		// Token: 0x0400010A RID: 266
		[CompilerGenerated]
		private DbSet<tel> <tel>k__BackingField;

		// Token: 0x0400010B RID: 267
		[CompilerGenerated]
		private DbSet<invoice> <invoice>k__BackingField;

		// Token: 0x0400010C RID: 268
		[CompilerGenerated]
		private DbSet<vat_invoice> <vat_invoice>k__BackingField;

		// Token: 0x0400010D RID: 269
		[CompilerGenerated]
		private DbSet<invoice_items> <invoice_items>k__BackingField;

		// Token: 0x0400010E RID: 270
		[CompilerGenerated]
		private DbSet<p_lists> <p_lists>k__BackingField;

		// Token: 0x0400010F RID: 271
		[CompilerGenerated]
		private DbSet<w_lists> <w_lists>k__BackingField;

		// Token: 0x04000110 RID: 272
		[CompilerGenerated]
		private DbSet<cartridge_cards> <cartridge_cards>k__BackingField;

		// Token: 0x04000111 RID: 273
		[CompilerGenerated]
		private DbSet<materials> <materials>k__BackingField;

		// Token: 0x04000112 RID: 274
		[CompilerGenerated]
		private DbSet<c_workshop> <c_workshop>k__BackingField;

		// Token: 0x04000113 RID: 275
		[CompilerGenerated]
		private DbSet<kkt> <kkt>k__BackingField;

		// Token: 0x04000114 RID: 276
		[CompilerGenerated]
		private DbSet<pinpad> <pinpad>k__BackingField;

		// Token: 0x04000115 RID: 277
		[CompilerGenerated]
		private DbSet<pinpad_logs> <pinpad_logs>k__BackingField;

		// Token: 0x04000116 RID: 278
		[CompilerGenerated]
		private DbSet<kkt_employee> <kkt_employee>k__BackingField;

		// Token: 0x04000117 RID: 279
		[CompilerGenerated]
		private DbSet<notifications> <notifications>k__BackingField;

		// Token: 0x04000118 RID: 280
		[CompilerGenerated]
		private DbSet<api_failed_logins> <api_failed_logins>k__BackingField;

		// Token: 0x04000119 RID: 281
		[CompilerGenerated]
		private DbSet<api_status_checks> <api_status_checks>k__BackingField;

		// Token: 0x0400011A RID: 282
		[CompilerGenerated]
		private DbSet<hooks> <hooks>k__BackingField;

		// Token: 0x0400011B RID: 283
		[CompilerGenerated]
		private DbSet<vendors> <vendors>k__BackingField;

		// Token: 0x0400011C RID: 284
		[CompilerGenerated]
		private DbSet<buyout> <buyout>k__BackingField;

		// Token: 0x0400011D RID: 285
		[CompilerGenerated]
		private DbSet<workshop_issued> <workshop_issued>k__BackingField;

		// Token: 0x0400011E RID: 286
		[CompilerGenerated]
		private DbSet<settings> <settings>k__BackingField;

		// Token: 0x0400011F RID: 287
		[CompilerGenerated]
		private DbSet<repair_status_logs> <repair_status_logs>k__BackingField;

		// Token: 0x04000120 RID: 288
		[CompilerGenerated]
		private DbSet<SalaryRate> <SalaryRates>k__BackingField;

		// Token: 0x0200002B RID: 43
		[CompilerGenerated]
		private sealed class <>c__DisplayClass422_0<T> where T : class
		{
			// Token: 0x0600026B RID: 619 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass422_0()
			{
			}

			// Token: 0x0600026C RID: 620 RVA: 0x00008094 File Offset: 0x00006294
			internal bool <Exists>b__0(T e)
			{
				return e == this.entity;
			}

			// Token: 0x04000121 RID: 289
			public T entity;
		}
	}
}
