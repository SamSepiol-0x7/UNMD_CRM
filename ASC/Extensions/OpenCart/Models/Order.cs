using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.Extensions.OpenCart;
using ASC.Converters;
using Newtonsoft.Json;

namespace ASC.Extensions.OpenCart.Models
{
	// Token: 0x02000BA1 RID: 2977
	public class Order : IOrder
	{
		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x060052DB RID: 21211 RVA: 0x00164C28 File Offset: 0x00162E28
		// (set) Token: 0x060052DC RID: 21212 RVA: 0x00164C3C File Offset: 0x00162E3C
		[JsonProperty("order_id")]
		public int OrderId
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderId>k__BackingField = value;
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x060052DD RID: 21213 RVA: 0x00164C50 File Offset: 0x00162E50
		// (set) Token: 0x060052DE RID: 21214 RVA: 0x00164C64 File Offset: 0x00162E64
		[JsonProperty("track_no")]
		public string TrackNo
		{
			[CompilerGenerated]
			get
			{
				return this.<TrackNo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TrackNo>k__BackingField = value;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x060052DF RID: 21215 RVA: 0x00164C78 File Offset: 0x00162E78
		// (set) Token: 0x060052E0 RID: 21216 RVA: 0x00164C8C File Offset: 0x00162E8C
		[JsonProperty("invoice_no")]
		public int InvoiceNo
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceNo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InvoiceNo>k__BackingField = value;
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x060052E1 RID: 21217 RVA: 0x00164CA0 File Offset: 0x00162EA0
		// (set) Token: 0x060052E2 RID: 21218 RVA: 0x00164CB4 File Offset: 0x00162EB4
		[JsonProperty("invoice_prefix")]
		public string InvoicePrefix
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoicePrefix>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InvoicePrefix>k__BackingField = value;
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x060052E3 RID: 21219 RVA: 0x00164CC8 File Offset: 0x00162EC8
		// (set) Token: 0x060052E4 RID: 21220 RVA: 0x00164CDC File Offset: 0x00162EDC
		[JsonProperty("store_id")]
		public int StoreId
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<StoreId>k__BackingField = value;
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x060052E5 RID: 21221 RVA: 0x00164CF0 File Offset: 0x00162EF0
		// (set) Token: 0x060052E6 RID: 21222 RVA: 0x00164D04 File Offset: 0x00162F04
		[JsonProperty("store_name")]
		public string StoreName
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<StoreName>k__BackingField = value;
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x060052E7 RID: 21223 RVA: 0x00164D18 File Offset: 0x00162F18
		// (set) Token: 0x060052E8 RID: 21224 RVA: 0x00164D2C File Offset: 0x00162F2C
		[JsonProperty("store_url")]
		public Uri StoreUrl
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreUrl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<StoreUrl>k__BackingField = value;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x060052E9 RID: 21225 RVA: 0x00164D40 File Offset: 0x00162F40
		// (set) Token: 0x060052EA RID: 21226 RVA: 0x00164D54 File Offset: 0x00162F54
		[JsonProperty("customer_id")]
		public int CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomerId>k__BackingField = value;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x060052EB RID: 21227 RVA: 0x00164D68 File Offset: 0x00162F68
		// (set) Token: 0x060052EC RID: 21228 RVA: 0x00164D7C File Offset: 0x00162F7C
		[JsonProperty("firstname")]
		public string Firstname
		{
			[CompilerGenerated]
			get
			{
				return this.<Firstname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Firstname>k__BackingField = value;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x00164D90 File Offset: 0x00162F90
		// (set) Token: 0x060052EE RID: 21230 RVA: 0x00164DA4 File Offset: 0x00162FA4
		[JsonProperty("lastname")]
		public string Lastname
		{
			[CompilerGenerated]
			get
			{
				return this.<Lastname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Lastname>k__BackingField = value;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x060052EF RID: 21231 RVA: 0x00164DB8 File Offset: 0x00162FB8
		// (set) Token: 0x060052F0 RID: 21232 RVA: 0x00164DCC File Offset: 0x00162FCC
		[JsonProperty("email")]
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
				this.<Email>k__BackingField = value;
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060052F1 RID: 21233 RVA: 0x00164DE0 File Offset: 0x00162FE0
		// (set) Token: 0x060052F2 RID: 21234 RVA: 0x00164DF4 File Offset: 0x00162FF4
		[JsonProperty("telephone")]
		public string Telephone
		{
			[CompilerGenerated]
			get
			{
				return this.<Telephone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Telephone>k__BackingField = value;
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x060052F3 RID: 21235 RVA: 0x00164E08 File Offset: 0x00163008
		// (set) Token: 0x060052F4 RID: 21236 RVA: 0x00164E1C File Offset: 0x0016301C
		[JsonProperty("fax")]
		public string Fax
		{
			[CompilerGenerated]
			get
			{
				return this.<Fax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Fax>k__BackingField = value;
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x060052F5 RID: 21237 RVA: 0x00164E30 File Offset: 0x00163030
		// (set) Token: 0x060052F6 RID: 21238 RVA: 0x00164E44 File Offset: 0x00163044
		[JsonProperty("custom_field")]
		public object[] CustomField
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomField>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomField>k__BackingField = value;
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x060052F7 RID: 21239 RVA: 0x00164E58 File Offset: 0x00163058
		// (set) Token: 0x060052F8 RID: 21240 RVA: 0x00164E6C File Offset: 0x0016306C
		[JsonProperty("payment_firstname")]
		public string PaymentFirstname
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentFirstname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentFirstname>k__BackingField = value;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x060052F9 RID: 21241 RVA: 0x00164E80 File Offset: 0x00163080
		// (set) Token: 0x060052FA RID: 21242 RVA: 0x00164E94 File Offset: 0x00163094
		[JsonProperty("payment_lastname")]
		public string PaymentLastname
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentLastname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentLastname>k__BackingField = value;
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060052FB RID: 21243 RVA: 0x00164EA8 File Offset: 0x001630A8
		// (set) Token: 0x060052FC RID: 21244 RVA: 0x00164EBC File Offset: 0x001630BC
		[JsonProperty("payment_company")]
		public string PaymentCompany
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentCompany>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentCompany>k__BackingField = value;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x060052FD RID: 21245 RVA: 0x00164ED0 File Offset: 0x001630D0
		// (set) Token: 0x060052FE RID: 21246 RVA: 0x00164EE4 File Offset: 0x001630E4
		[JsonProperty("payment_address_1")]
		public string PaymentAddress1
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentAddress1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentAddress1>k__BackingField = value;
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x060052FF RID: 21247 RVA: 0x00164EF8 File Offset: 0x001630F8
		// (set) Token: 0x06005300 RID: 21248 RVA: 0x00164F0C File Offset: 0x0016310C
		[JsonProperty("payment_address_2")]
		public string PaymentAddress2
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentAddress2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentAddress2>k__BackingField = value;
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06005301 RID: 21249 RVA: 0x00164F20 File Offset: 0x00163120
		// (set) Token: 0x06005302 RID: 21250 RVA: 0x00164F34 File Offset: 0x00163134
		[JsonProperty("payment_postcode")]
		public string PaymentPostcode
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentPostcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentPostcode>k__BackingField = value;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x00164F48 File Offset: 0x00163148
		// (set) Token: 0x06005304 RID: 21252 RVA: 0x00164F5C File Offset: 0x0016315C
		[JsonProperty("payment_city")]
		public string PaymentCity
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentCity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentCity>k__BackingField = value;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x00164F70 File Offset: 0x00163170
		// (set) Token: 0x06005306 RID: 21254 RVA: 0x00164F84 File Offset: 0x00163184
		[JsonProperty("payment_zone_id")]
		public int PaymentZoneId
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentZoneId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentZoneId>k__BackingField = value;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06005307 RID: 21255 RVA: 0x00164F98 File Offset: 0x00163198
		// (set) Token: 0x06005308 RID: 21256 RVA: 0x00164FAC File Offset: 0x001631AC
		[JsonProperty("payment_zone")]
		public string PaymentZone
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentZone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentZone>k__BackingField = value;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06005309 RID: 21257 RVA: 0x00164FC0 File Offset: 0x001631C0
		// (set) Token: 0x0600530A RID: 21258 RVA: 0x00164FD4 File Offset: 0x001631D4
		[JsonProperty("payment_zone_code")]
		public string PaymentZoneCode
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentZoneCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentZoneCode>k__BackingField = value;
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x0600530B RID: 21259 RVA: 0x00164FE8 File Offset: 0x001631E8
		// (set) Token: 0x0600530C RID: 21260 RVA: 0x00164FFC File Offset: 0x001631FC
		[JsonProperty("payment_country_id")]
		public int PaymentCountryId
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentCountryId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentCountryId>k__BackingField = value;
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x00165010 File Offset: 0x00163210
		// (set) Token: 0x0600530E RID: 21262 RVA: 0x00165024 File Offset: 0x00163224
		[JsonProperty("payment_country")]
		public string PaymentCountry
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentCountry>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentCountry>k__BackingField = value;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x00165038 File Offset: 0x00163238
		// (set) Token: 0x06005310 RID: 21264 RVA: 0x0016504C File Offset: 0x0016324C
		[JsonProperty("payment_iso_code_2")]
		public string PaymentIsoCode2
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentIsoCode2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentIsoCode2>k__BackingField = value;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06005311 RID: 21265 RVA: 0x00165060 File Offset: 0x00163260
		// (set) Token: 0x06005312 RID: 21266 RVA: 0x00165074 File Offset: 0x00163274
		[JsonProperty("payment_iso_code_3")]
		public string PaymentIsoCode3
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentIsoCode3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentIsoCode3>k__BackingField = value;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x00165088 File Offset: 0x00163288
		// (set) Token: 0x06005314 RID: 21268 RVA: 0x0016509C File Offset: 0x0016329C
		[JsonProperty("payment_address_format")]
		public string PaymentAddressFormat
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentAddressFormat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentAddressFormat>k__BackingField = value;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x001650B0 File Offset: 0x001632B0
		// (set) Token: 0x06005316 RID: 21270 RVA: 0x001650C4 File Offset: 0x001632C4
		[JsonProperty("payment_custom_field")]
		public object[] PaymentCustomField
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentCustomField>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentCustomField>k__BackingField = value;
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06005317 RID: 21271 RVA: 0x001650D8 File Offset: 0x001632D8
		// (set) Token: 0x06005318 RID: 21272 RVA: 0x001650EC File Offset: 0x001632EC
		[JsonProperty("payment_method")]
		public string PaymentMethod
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentMethod>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentMethod>k__BackingField = value;
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x00165100 File Offset: 0x00163300
		// (set) Token: 0x0600531A RID: 21274 RVA: 0x00165114 File Offset: 0x00163314
		[JsonProperty("payment_code")]
		public string PaymentCode
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentCode>k__BackingField = value;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x00165128 File Offset: 0x00163328
		// (set) Token: 0x0600531C RID: 21276 RVA: 0x0016513C File Offset: 0x0016333C
		[JsonProperty("shipping_firstname")]
		public string ShippingFirstname
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingFirstname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingFirstname>k__BackingField = value;
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x0600531D RID: 21277 RVA: 0x00165150 File Offset: 0x00163350
		// (set) Token: 0x0600531E RID: 21278 RVA: 0x00165164 File Offset: 0x00163364
		[JsonProperty("shipping_lastname")]
		public string ShippingLastname
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingLastname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingLastname>k__BackingField = value;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x0600531F RID: 21279 RVA: 0x00165178 File Offset: 0x00163378
		public string ShippingFullname
		{
			get
			{
				return this.ShippingLastname + " " + this.ShippingFirstname;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x0016519C File Offset: 0x0016339C
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x001651B0 File Offset: 0x001633B0
		[JsonProperty("shipping_company")]
		public string ShippingCompany
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingCompany>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingCompany>k__BackingField = value;
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x001651C4 File Offset: 0x001633C4
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x001651D8 File Offset: 0x001633D8
		[JsonProperty("shipping_address_1")]
		public string ShippingAddress1
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingAddress1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingAddress1>k__BackingField = value;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x001651EC File Offset: 0x001633EC
		// (set) Token: 0x06005325 RID: 21285 RVA: 0x00165200 File Offset: 0x00163400
		[JsonProperty("shipping_address_2")]
		public string ShippingAddress2
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingAddress2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingAddress2>k__BackingField = value;
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06005326 RID: 21286 RVA: 0x00165214 File Offset: 0x00163414
		// (set) Token: 0x06005327 RID: 21287 RVA: 0x00165228 File Offset: 0x00163428
		[JsonProperty("shipping_postcode")]
		public string ShippingPostcode
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingPostcode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingPostcode>k__BackingField = value;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x0016523C File Offset: 0x0016343C
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x00165250 File Offset: 0x00163450
		[JsonProperty("shipping_city")]
		public string ShippingCity
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingCity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingCity>k__BackingField = value;
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x00165264 File Offset: 0x00163464
		// (set) Token: 0x0600532B RID: 21291 RVA: 0x00165278 File Offset: 0x00163478
		[JsonProperty("shipping_zone_id")]
		public int ShippingZoneId
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingZoneId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingZoneId>k__BackingField = value;
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x0600532C RID: 21292 RVA: 0x0016528C File Offset: 0x0016348C
		// (set) Token: 0x0600532D RID: 21293 RVA: 0x001652A0 File Offset: 0x001634A0
		[JsonProperty("shipping_zone")]
		public string ShippingZone
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingZone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingZone>k__BackingField = value;
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x001652B4 File Offset: 0x001634B4
		// (set) Token: 0x0600532F RID: 21295 RVA: 0x001652C8 File Offset: 0x001634C8
		[JsonProperty("shipping_zone_code")]
		public string ShippingZoneCode
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingZoneCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingZoneCode>k__BackingField = value;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x001652DC File Offset: 0x001634DC
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x001652F0 File Offset: 0x001634F0
		[JsonProperty("shipping_country_id")]
		public int ShippingCountryId
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingCountryId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingCountryId>k__BackingField = value;
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x00165304 File Offset: 0x00163504
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x00165318 File Offset: 0x00163518
		[JsonProperty("shipping_country")]
		public string ShippingCountry
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingCountry>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingCountry>k__BackingField = value;
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06005334 RID: 21300 RVA: 0x0016532C File Offset: 0x0016352C
		// (set) Token: 0x06005335 RID: 21301 RVA: 0x00165340 File Offset: 0x00163540
		[JsonProperty("shipping_iso_code_2")]
		public string ShippingIsoCode2
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingIsoCode2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingIsoCode2>k__BackingField = value;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06005336 RID: 21302 RVA: 0x00165354 File Offset: 0x00163554
		// (set) Token: 0x06005337 RID: 21303 RVA: 0x00165368 File Offset: 0x00163568
		[JsonProperty("shipping_iso_code_3")]
		public string ShippingIsoCode3
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingIsoCode3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingIsoCode3>k__BackingField = value;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x0016537C File Offset: 0x0016357C
		// (set) Token: 0x06005339 RID: 21305 RVA: 0x00165390 File Offset: 0x00163590
		[JsonProperty("shipping_address_format")]
		public string ShippingAddressFormat
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingAddressFormat>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingAddressFormat>k__BackingField = value;
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600533A RID: 21306 RVA: 0x001653A4 File Offset: 0x001635A4
		// (set) Token: 0x0600533B RID: 21307 RVA: 0x001653B8 File Offset: 0x001635B8
		[JsonProperty("shipping_custom_field")]
		public object[] ShippingCustomField
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingCustomField>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingCustomField>k__BackingField = value;
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x001653CC File Offset: 0x001635CC
		// (set) Token: 0x0600533D RID: 21309 RVA: 0x001653E0 File Offset: 0x001635E0
		[JsonProperty("shipping_method")]
		public string ShippingMethod
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingMethod>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingMethod>k__BackingField = value;
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x001653F4 File Offset: 0x001635F4
		// (set) Token: 0x0600533F RID: 21311 RVA: 0x00165408 File Offset: 0x00163608
		[JsonProperty("shipping_code")]
		public string ShippingCode
		{
			[CompilerGenerated]
			get
			{
				return this.<ShippingCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShippingCode>k__BackingField = value;
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x0016541C File Offset: 0x0016361C
		// (set) Token: 0x06005341 RID: 21313 RVA: 0x00165430 File Offset: 0x00163630
		[JsonProperty("comment")]
		public string Comment
		{
			[CompilerGenerated]
			get
			{
				return this.<Comment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Comment>k__BackingField = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06005342 RID: 21314 RVA: 0x00165444 File Offset: 0x00163644
		// (set) Token: 0x06005343 RID: 21315 RVA: 0x00165458 File Offset: 0x00163658
		[JsonProperty("total")]
		public string Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Total>k__BackingField = value;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x0016546C File Offset: 0x0016366C
		// (set) Token: 0x06005345 RID: 21317 RVA: 0x00165480 File Offset: 0x00163680
		[JsonProperty("order_status_id")]
		public int OrderStatusId
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderStatusId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderStatusId>k__BackingField = value;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x00165494 File Offset: 0x00163694
		// (set) Token: 0x06005347 RID: 21319 RVA: 0x001654A8 File Offset: 0x001636A8
		[JsonProperty("order_status")]
		public string OrderStatus
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderStatus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderStatus>k__BackingField = value;
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x001654BC File Offset: 0x001636BC
		// (set) Token: 0x06005349 RID: 21321 RVA: 0x001654D0 File Offset: 0x001636D0
		[JsonProperty("affiliate_id")]
		public int AffiliateId
		{
			[CompilerGenerated]
			get
			{
				return this.<AffiliateId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AffiliateId>k__BackingField = value;
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x001654E4 File Offset: 0x001636E4
		// (set) Token: 0x0600534B RID: 21323 RVA: 0x001654F8 File Offset: 0x001636F8
		[JsonProperty("commission")]
		public string Commission
		{
			[CompilerGenerated]
			get
			{
				return this.<Commission>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Commission>k__BackingField = value;
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x0016550C File Offset: 0x0016370C
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x00165520 File Offset: 0x00163720
		[JsonProperty("language_id")]
		public int LanguageId
		{
			[CompilerGenerated]
			get
			{
				return this.<LanguageId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LanguageId>k__BackingField = value;
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x00165534 File Offset: 0x00163734
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x00165548 File Offset: 0x00163748
		[JsonProperty("language_code")]
		public string LanguageCode
		{
			[CompilerGenerated]
			get
			{
				return this.<LanguageCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LanguageCode>k__BackingField = value;
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x0016555C File Offset: 0x0016375C
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x00165570 File Offset: 0x00163770
		[JsonProperty("currency_id")]
		public int CurrencyId
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrencyId>k__BackingField = value;
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x00165584 File Offset: 0x00163784
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x00165598 File Offset: 0x00163798
		[JsonProperty("currency_code")]
		public string CurrencyCode
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrencyCode>k__BackingField = value;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x001655AC File Offset: 0x001637AC
		// (set) Token: 0x06005355 RID: 21333 RVA: 0x001655C0 File Offset: 0x001637C0
		[JsonProperty("currency_value")]
		public string CurrencyValue
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CurrencyValue>k__BackingField = value;
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x001655D4 File Offset: 0x001637D4
		// (set) Token: 0x06005357 RID: 21335 RVA: 0x001655E8 File Offset: 0x001637E8
		[JsonProperty("ip")]
		public string Ip
		{
			[CompilerGenerated]
			get
			{
				return this.<Ip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ip>k__BackingField = value;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x001655FC File Offset: 0x001637FC
		// (set) Token: 0x06005359 RID: 21337 RVA: 0x00165610 File Offset: 0x00163810
		[JsonProperty("forwarded_ip")]
		public string ForwardedIp
		{
			[CompilerGenerated]
			get
			{
				return this.<ForwardedIp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ForwardedIp>k__BackingField = value;
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x0600535A RID: 21338 RVA: 0x00165624 File Offset: 0x00163824
		// (set) Token: 0x0600535B RID: 21339 RVA: 0x00165638 File Offset: 0x00163838
		[JsonProperty("user_agent")]
		public string UserAgent
		{
			[CompilerGenerated]
			get
			{
				return this.<UserAgent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserAgent>k__BackingField = value;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x0600535C RID: 21340 RVA: 0x0016564C File Offset: 0x0016384C
		// (set) Token: 0x0600535D RID: 21341 RVA: 0x00165660 File Offset: 0x00163860
		[JsonProperty("accept_language")]
		public string AcceptLanguage
		{
			[CompilerGenerated]
			get
			{
				return this.<AcceptLanguage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AcceptLanguage>k__BackingField = value;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x00165674 File Offset: 0x00163874
		// (set) Token: 0x0600535F RID: 21343 RVA: 0x00165688 File Offset: 0x00163888
		[JsonProperty("date_added")]
		public DateTime DateAdded
		{
			[CompilerGenerated]
			get
			{
				return this.<DateAdded>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DateAdded>k__BackingField = value;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x0016569C File Offset: 0x0016389C
		// (set) Token: 0x06005361 RID: 21345 RVA: 0x001656B0 File Offset: 0x001638B0
		[JsonProperty("date_modified")]
		public DateTime DateModified
		{
			[CompilerGenerated]
			get
			{
				return this.<DateModified>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DateModified>k__BackingField = value;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x001656C4 File Offset: 0x001638C4
		// (set) Token: 0x06005363 RID: 21347 RVA: 0x001656D8 File Offset: 0x001638D8
		[JsonProperty("products")]
		[JsonConverter(typeof(ListConverter<IProduct, Product>))]
		public IList<IProduct> Products
		{
			[CompilerGenerated]
			get
			{
				return this.<Products>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Products>k__BackingField = value;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06005364 RID: 21348 RVA: 0x001656EC File Offset: 0x001638EC
		// (set) Token: 0x06005365 RID: 21349 RVA: 0x00165700 File Offset: 0x00163900
		[JsonProperty("totals")]
		[JsonConverter(typeof(ListConverter<ITotal, Total>))]
		public IList<ITotal> Totals
		{
			[CompilerGenerated]
			get
			{
				return this.<Totals>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Totals>k__BackingField = value;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06005366 RID: 21350 RVA: 0x00165714 File Offset: 0x00163914
		// (set) Token: 0x06005367 RID: 21351 RVA: 0x00165728 File Offset: 0x00163928
		[JsonProperty("order_statuses")]
		[JsonConverter(typeof(ListConverter<IIdName, OrderStatus>))]
		public IList<IIdName> Statuses
		{
			[CompilerGenerated]
			get
			{
				return this.<Statuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Statuses>k__BackingField = value;
			}
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x000046B4 File Offset: 0x000028B4
		public Order()
		{
		}

		// Token: 0x040036A7 RID: 13991
		[CompilerGenerated]
		private int <OrderId>k__BackingField;

		// Token: 0x040036A8 RID: 13992
		[CompilerGenerated]
		private string <TrackNo>k__BackingField;

		// Token: 0x040036A9 RID: 13993
		[CompilerGenerated]
		private int <InvoiceNo>k__BackingField;

		// Token: 0x040036AA RID: 13994
		[CompilerGenerated]
		private string <InvoicePrefix>k__BackingField;

		// Token: 0x040036AB RID: 13995
		[CompilerGenerated]
		private int <StoreId>k__BackingField;

		// Token: 0x040036AC RID: 13996
		[CompilerGenerated]
		private string <StoreName>k__BackingField;

		// Token: 0x040036AD RID: 13997
		[CompilerGenerated]
		private Uri <StoreUrl>k__BackingField;

		// Token: 0x040036AE RID: 13998
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x040036AF RID: 13999
		[CompilerGenerated]
		private string <Firstname>k__BackingField;

		// Token: 0x040036B0 RID: 14000
		[CompilerGenerated]
		private string <Lastname>k__BackingField;

		// Token: 0x040036B1 RID: 14001
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x040036B2 RID: 14002
		[CompilerGenerated]
		private string <Telephone>k__BackingField;

		// Token: 0x040036B3 RID: 14003
		[CompilerGenerated]
		private string <Fax>k__BackingField;

		// Token: 0x040036B4 RID: 14004
		[CompilerGenerated]
		private object[] <CustomField>k__BackingField;

		// Token: 0x040036B5 RID: 14005
		[CompilerGenerated]
		private string <PaymentFirstname>k__BackingField;

		// Token: 0x040036B6 RID: 14006
		[CompilerGenerated]
		private string <PaymentLastname>k__BackingField;

		// Token: 0x040036B7 RID: 14007
		[CompilerGenerated]
		private string <PaymentCompany>k__BackingField;

		// Token: 0x040036B8 RID: 14008
		[CompilerGenerated]
		private string <PaymentAddress1>k__BackingField;

		// Token: 0x040036B9 RID: 14009
		[CompilerGenerated]
		private string <PaymentAddress2>k__BackingField;

		// Token: 0x040036BA RID: 14010
		[CompilerGenerated]
		private string <PaymentPostcode>k__BackingField;

		// Token: 0x040036BB RID: 14011
		[CompilerGenerated]
		private string <PaymentCity>k__BackingField;

		// Token: 0x040036BC RID: 14012
		[CompilerGenerated]
		private int <PaymentZoneId>k__BackingField;

		// Token: 0x040036BD RID: 14013
		[CompilerGenerated]
		private string <PaymentZone>k__BackingField;

		// Token: 0x040036BE RID: 14014
		[CompilerGenerated]
		private string <PaymentZoneCode>k__BackingField;

		// Token: 0x040036BF RID: 14015
		[CompilerGenerated]
		private int <PaymentCountryId>k__BackingField;

		// Token: 0x040036C0 RID: 14016
		[CompilerGenerated]
		private string <PaymentCountry>k__BackingField;

		// Token: 0x040036C1 RID: 14017
		[CompilerGenerated]
		private string <PaymentIsoCode2>k__BackingField;

		// Token: 0x040036C2 RID: 14018
		[CompilerGenerated]
		private string <PaymentIsoCode3>k__BackingField;

		// Token: 0x040036C3 RID: 14019
		[CompilerGenerated]
		private string <PaymentAddressFormat>k__BackingField;

		// Token: 0x040036C4 RID: 14020
		[CompilerGenerated]
		private object[] <PaymentCustomField>k__BackingField;

		// Token: 0x040036C5 RID: 14021
		[CompilerGenerated]
		private string <PaymentMethod>k__BackingField;

		// Token: 0x040036C6 RID: 14022
		[CompilerGenerated]
		private string <PaymentCode>k__BackingField;

		// Token: 0x040036C7 RID: 14023
		[CompilerGenerated]
		private string <ShippingFirstname>k__BackingField;

		// Token: 0x040036C8 RID: 14024
		[CompilerGenerated]
		private string <ShippingLastname>k__BackingField;

		// Token: 0x040036C9 RID: 14025
		[CompilerGenerated]
		private string <ShippingCompany>k__BackingField;

		// Token: 0x040036CA RID: 14026
		[CompilerGenerated]
		private string <ShippingAddress1>k__BackingField;

		// Token: 0x040036CB RID: 14027
		[CompilerGenerated]
		private string <ShippingAddress2>k__BackingField;

		// Token: 0x040036CC RID: 14028
		[CompilerGenerated]
		private string <ShippingPostcode>k__BackingField;

		// Token: 0x040036CD RID: 14029
		[CompilerGenerated]
		private string <ShippingCity>k__BackingField;

		// Token: 0x040036CE RID: 14030
		[CompilerGenerated]
		private int <ShippingZoneId>k__BackingField;

		// Token: 0x040036CF RID: 14031
		[CompilerGenerated]
		private string <ShippingZone>k__BackingField;

		// Token: 0x040036D0 RID: 14032
		[CompilerGenerated]
		private string <ShippingZoneCode>k__BackingField;

		// Token: 0x040036D1 RID: 14033
		[CompilerGenerated]
		private int <ShippingCountryId>k__BackingField;

		// Token: 0x040036D2 RID: 14034
		[CompilerGenerated]
		private string <ShippingCountry>k__BackingField;

		// Token: 0x040036D3 RID: 14035
		[CompilerGenerated]
		private string <ShippingIsoCode2>k__BackingField;

		// Token: 0x040036D4 RID: 14036
		[CompilerGenerated]
		private string <ShippingIsoCode3>k__BackingField;

		// Token: 0x040036D5 RID: 14037
		[CompilerGenerated]
		private string <ShippingAddressFormat>k__BackingField;

		// Token: 0x040036D6 RID: 14038
		[CompilerGenerated]
		private object[] <ShippingCustomField>k__BackingField;

		// Token: 0x040036D7 RID: 14039
		[CompilerGenerated]
		private string <ShippingMethod>k__BackingField;

		// Token: 0x040036D8 RID: 14040
		[CompilerGenerated]
		private string <ShippingCode>k__BackingField;

		// Token: 0x040036D9 RID: 14041
		[CompilerGenerated]
		private string <Comment>k__BackingField;

		// Token: 0x040036DA RID: 14042
		[CompilerGenerated]
		private string <Total>k__BackingField;

		// Token: 0x040036DB RID: 14043
		[CompilerGenerated]
		private int <OrderStatusId>k__BackingField;

		// Token: 0x040036DC RID: 14044
		[CompilerGenerated]
		private string <OrderStatus>k__BackingField;

		// Token: 0x040036DD RID: 14045
		[CompilerGenerated]
		private int <AffiliateId>k__BackingField;

		// Token: 0x040036DE RID: 14046
		[CompilerGenerated]
		private string <Commission>k__BackingField;

		// Token: 0x040036DF RID: 14047
		[CompilerGenerated]
		private int <LanguageId>k__BackingField;

		// Token: 0x040036E0 RID: 14048
		[CompilerGenerated]
		private string <LanguageCode>k__BackingField;

		// Token: 0x040036E1 RID: 14049
		[CompilerGenerated]
		private int <CurrencyId>k__BackingField;

		// Token: 0x040036E2 RID: 14050
		[CompilerGenerated]
		private string <CurrencyCode>k__BackingField;

		// Token: 0x040036E3 RID: 14051
		[CompilerGenerated]
		private string <CurrencyValue>k__BackingField;

		// Token: 0x040036E4 RID: 14052
		[CompilerGenerated]
		private string <Ip>k__BackingField;

		// Token: 0x040036E5 RID: 14053
		[CompilerGenerated]
		private string <ForwardedIp>k__BackingField;

		// Token: 0x040036E6 RID: 14054
		[CompilerGenerated]
		private string <UserAgent>k__BackingField;

		// Token: 0x040036E7 RID: 14055
		[CompilerGenerated]
		private string <AcceptLanguage>k__BackingField;

		// Token: 0x040036E8 RID: 14056
		[CompilerGenerated]
		private DateTime <DateAdded>k__BackingField;

		// Token: 0x040036E9 RID: 14057
		[CompilerGenerated]
		private DateTime <DateModified>k__BackingField;

		// Token: 0x040036EA RID: 14058
		[CompilerGenerated]
		private IList<IProduct> <Products>k__BackingField;

		// Token: 0x040036EB RID: 14059
		[CompilerGenerated]
		private IList<ITotal> <Totals>k__BackingField;

		// Token: 0x040036EC RID: 14060
		[CompilerGenerated]
		private IList<IIdName> <Statuses>k__BackingField;
	}
}
