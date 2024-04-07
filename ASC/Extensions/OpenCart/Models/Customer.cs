using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ASC.Extensions.OpenCart.Models
{
	// Token: 0x02000BA0 RID: 2976
	public class Customer
	{
		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x00164890 File Offset: 0x00162A90
		// (set) Token: 0x060052AD RID: 21165 RVA: 0x001648A4 File Offset: 0x00162AA4
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

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060052AE RID: 21166 RVA: 0x001648B8 File Offset: 0x00162AB8
		// (set) Token: 0x060052AF RID: 21167 RVA: 0x001648CC File Offset: 0x00162ACC
		[JsonProperty("customer_group_id")]
		public int CustomerGroupId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerGroupId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomerGroupId>k__BackingField = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060052B0 RID: 21168 RVA: 0x001648E0 File Offset: 0x00162AE0
		// (set) Token: 0x060052B1 RID: 21169 RVA: 0x001648F4 File Offset: 0x00162AF4
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

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060052B2 RID: 21170 RVA: 0x00164908 File Offset: 0x00162B08
		// (set) Token: 0x060052B3 RID: 21171 RVA: 0x0016491C File Offset: 0x00162B1C
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

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060052B4 RID: 21172 RVA: 0x00164930 File Offset: 0x00162B30
		// (set) Token: 0x060052B5 RID: 21173 RVA: 0x00164944 File Offset: 0x00162B44
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

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060052B6 RID: 21174 RVA: 0x00164958 File Offset: 0x00162B58
		// (set) Token: 0x060052B7 RID: 21175 RVA: 0x0016496C File Offset: 0x00162B6C
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

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060052B8 RID: 21176 RVA: 0x00164980 File Offset: 0x00162B80
		// (set) Token: 0x060052B9 RID: 21177 RVA: 0x00164994 File Offset: 0x00162B94
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

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x001649A8 File Offset: 0x00162BA8
		// (set) Token: 0x060052BB RID: 21179 RVA: 0x001649BC File Offset: 0x00162BBC
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

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060052BC RID: 21180 RVA: 0x001649D0 File Offset: 0x00162BD0
		// (set) Token: 0x060052BD RID: 21181 RVA: 0x001649E4 File Offset: 0x00162BE4
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

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060052BE RID: 21182 RVA: 0x001649F8 File Offset: 0x00162BF8
		// (set) Token: 0x060052BF RID: 21183 RVA: 0x00164A0C File Offset: 0x00162C0C
		[JsonProperty("password")]
		public string Password
		{
			[CompilerGenerated]
			get
			{
				return this.<Password>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Password>k__BackingField = value;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060052C0 RID: 21184 RVA: 0x00164A20 File Offset: 0x00162C20
		// (set) Token: 0x060052C1 RID: 21185 RVA: 0x00164A34 File Offset: 0x00162C34
		[JsonProperty("salt")]
		public string Salt
		{
			[CompilerGenerated]
			get
			{
				return this.<Salt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Salt>k__BackingField = value;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060052C2 RID: 21186 RVA: 0x00164A48 File Offset: 0x00162C48
		// (set) Token: 0x060052C3 RID: 21187 RVA: 0x00164A5C File Offset: 0x00162C5C
		[JsonProperty("cart")]
		public object Cart
		{
			[CompilerGenerated]
			get
			{
				return this.<Cart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Cart>k__BackingField = value;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060052C4 RID: 21188 RVA: 0x00164A70 File Offset: 0x00162C70
		// (set) Token: 0x060052C5 RID: 21189 RVA: 0x00164A84 File Offset: 0x00162C84
		[JsonProperty("wishlist")]
		public object Wishlist
		{
			[CompilerGenerated]
			get
			{
				return this.<Wishlist>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Wishlist>k__BackingField = value;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060052C6 RID: 21190 RVA: 0x00164A98 File Offset: 0x00162C98
		// (set) Token: 0x060052C7 RID: 21191 RVA: 0x00164AAC File Offset: 0x00162CAC
		[JsonProperty("newsletter")]
		public int Newsletter
		{
			[CompilerGenerated]
			get
			{
				return this.<Newsletter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Newsletter>k__BackingField = value;
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x00164AC0 File Offset: 0x00162CC0
		// (set) Token: 0x060052C9 RID: 21193 RVA: 0x00164AD4 File Offset: 0x00162CD4
		[JsonProperty("address_id")]
		public int AddressId
		{
			[CompilerGenerated]
			get
			{
				return this.<AddressId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<AddressId>k__BackingField = value;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060052CA RID: 21194 RVA: 0x00164AE8 File Offset: 0x00162CE8
		// (set) Token: 0x060052CB RID: 21195 RVA: 0x00164AFC File Offset: 0x00162CFC
		[JsonProperty("custom_field")]
		public string CustomField
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

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x00164B10 File Offset: 0x00162D10
		// (set) Token: 0x060052CD RID: 21197 RVA: 0x00164B24 File Offset: 0x00162D24
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

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x060052CE RID: 21198 RVA: 0x00164B38 File Offset: 0x00162D38
		// (set) Token: 0x060052CF RID: 21199 RVA: 0x00164B4C File Offset: 0x00162D4C
		[JsonProperty("status")]
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
				this.<Status>k__BackingField = value;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x060052D0 RID: 21200 RVA: 0x00164B60 File Offset: 0x00162D60
		// (set) Token: 0x060052D1 RID: 21201 RVA: 0x00164B74 File Offset: 0x00162D74
		[JsonProperty("approved")]
		public int Approved
		{
			[CompilerGenerated]
			get
			{
				return this.<Approved>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Approved>k__BackingField = value;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x060052D2 RID: 21202 RVA: 0x00164B88 File Offset: 0x00162D88
		// (set) Token: 0x060052D3 RID: 21203 RVA: 0x00164B9C File Offset: 0x00162D9C
		[JsonProperty("safe")]
		public int Safe
		{
			[CompilerGenerated]
			get
			{
				return this.<Safe>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Safe>k__BackingField = value;
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x00164BB0 File Offset: 0x00162DB0
		// (set) Token: 0x060052D5 RID: 21205 RVA: 0x00164BC4 File Offset: 0x00162DC4
		[JsonProperty("token")]
		public string Token
		{
			[CompilerGenerated]
			get
			{
				return this.<Token>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Token>k__BackingField = value;
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x00164BD8 File Offset: 0x00162DD8
		// (set) Token: 0x060052D7 RID: 21207 RVA: 0x00164BEC File Offset: 0x00162DEC
		[JsonProperty("code")]
		public string Code
		{
			[CompilerGenerated]
			get
			{
				return this.<Code>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Code>k__BackingField = value;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x00164C00 File Offset: 0x00162E00
		// (set) Token: 0x060052D9 RID: 21209 RVA: 0x00164C14 File Offset: 0x00162E14
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

		// Token: 0x060052DA RID: 21210 RVA: 0x000046B4 File Offset: 0x000028B4
		public Customer()
		{
		}

		// Token: 0x04003690 RID: 13968
		[CompilerGenerated]
		private int <CustomerId>k__BackingField;

		// Token: 0x04003691 RID: 13969
		[CompilerGenerated]
		private int <CustomerGroupId>k__BackingField;

		// Token: 0x04003692 RID: 13970
		[CompilerGenerated]
		private int <StoreId>k__BackingField;

		// Token: 0x04003693 RID: 13971
		[CompilerGenerated]
		private int <LanguageId>k__BackingField;

		// Token: 0x04003694 RID: 13972
		[CompilerGenerated]
		private string <Firstname>k__BackingField;

		// Token: 0x04003695 RID: 13973
		[CompilerGenerated]
		private string <Lastname>k__BackingField;

		// Token: 0x04003696 RID: 13974
		[CompilerGenerated]
		private string <Email>k__BackingField;

		// Token: 0x04003697 RID: 13975
		[CompilerGenerated]
		private string <Telephone>k__BackingField;

		// Token: 0x04003698 RID: 13976
		[CompilerGenerated]
		private string <Fax>k__BackingField;

		// Token: 0x04003699 RID: 13977
		[CompilerGenerated]
		private string <Password>k__BackingField;

		// Token: 0x0400369A RID: 13978
		[CompilerGenerated]
		private string <Salt>k__BackingField;

		// Token: 0x0400369B RID: 13979
		[CompilerGenerated]
		private object <Cart>k__BackingField;

		// Token: 0x0400369C RID: 13980
		[CompilerGenerated]
		private object <Wishlist>k__BackingField;

		// Token: 0x0400369D RID: 13981
		[CompilerGenerated]
		private int <Newsletter>k__BackingField;

		// Token: 0x0400369E RID: 13982
		[CompilerGenerated]
		private int <AddressId>k__BackingField;

		// Token: 0x0400369F RID: 13983
		[CompilerGenerated]
		private string <CustomField>k__BackingField;

		// Token: 0x040036A0 RID: 13984
		[CompilerGenerated]
		private string <Ip>k__BackingField;

		// Token: 0x040036A1 RID: 13985
		[CompilerGenerated]
		private int <Status>k__BackingField;

		// Token: 0x040036A2 RID: 13986
		[CompilerGenerated]
		private int <Approved>k__BackingField;

		// Token: 0x040036A3 RID: 13987
		[CompilerGenerated]
		private int <Safe>k__BackingField;

		// Token: 0x040036A4 RID: 13988
		[CompilerGenerated]
		private string <Token>k__BackingField;

		// Token: 0x040036A5 RID: 13989
		[CompilerGenerated]
		private string <Code>k__BackingField;

		// Token: 0x040036A6 RID: 13990
		[CompilerGenerated]
		private DateTime <DateAdded>k__BackingField;
	}
}
