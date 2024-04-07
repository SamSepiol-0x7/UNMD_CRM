using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;

namespace ASC.SimpleClasses
{
	// Token: 0x0200021C RID: 540
	public class CashOrdersLite
	{
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000538F8 File Offset: 0x00051AF8
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x0005390C File Offset: 0x00051B0C
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

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00053920 File Offset: 0x00051B20
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x00053934 File Offset: 0x00051B34
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
				this.<CompanyId>k__BackingField = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x00053948 File Offset: 0x00051B48
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0005395C File Offset: 0x00051B5C
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
				this.<OfficeId>k__BackingField = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00053970 File Offset: 0x00051B70
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x00053984 File Offset: 0x00051B84
		public string OfficeName
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficeName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OfficeName>k__BackingField = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00053998 File Offset: 0x00051B98
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x000539AC File Offset: 0x00051BAC
		public DateTime created
		{
			[CompilerGenerated]
			get
			{
				return this.<created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<created>k__BackingField = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x000539C0 File Offset: 0x00051BC0
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x000539D4 File Offset: 0x00051BD4
		public int type
		{
			[CompilerGenerated]
			get
			{
				return this.<type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<type>k__BackingField = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x000539E8 File Offset: 0x00051BE8
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x000539FC File Offset: 0x00051BFC
		public int? ClientId
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

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00053A10 File Offset: 0x00051C10
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x00053A24 File Offset: 0x00051C24
		public int? RepairId
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

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00053A38 File Offset: 0x00051C38
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x00053A4C File Offset: 0x00051C4C
		public int? DocumentId
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DocumentId>k__BackingField = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00053A60 File Offset: 0x00051C60
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x00053A74 File Offset: 0x00051C74
		public int? InvoiceId
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<InvoiceId>k__BackingField = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00053A88 File Offset: 0x00051C88
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x00053A9C File Offset: 0x00051C9C
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

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00053AB0 File Offset: 0x00051CB0
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00053AC4 File Offset: 0x00051CC4
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

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00053AD8 File Offset: 0x00051CD8
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00053AEC File Offset: 0x00051CEC
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

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00053B00 File Offset: 0x00051D00
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00053B14 File Offset: 0x00051D14
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

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00053B28 File Offset: 0x00051D28
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00053B3C File Offset: 0x00051D3C
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

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00053B50 File Offset: 0x00051D50
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x00053B64 File Offset: 0x00051D64
		public string username
		{
			[CompilerGenerated]
			get
			{
				return this.<username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<username>k__BackingField = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00053B78 File Offset: 0x00051D78
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00053B8C File Offset: 0x00051D8C
		public string UserFirstName
		{
			[CompilerGenerated]
			get
			{
				return this.<UserFirstName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserFirstName>k__BackingField = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00053BA0 File Offset: 0x00051DA0
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x00053BB4 File Offset: 0x00051DB4
		public string UserLastName
		{
			[CompilerGenerated]
			get
			{
				return this.<UserLastName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserLastName>k__BackingField = value;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00053BC8 File Offset: 0x00051DC8
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x00053BDC File Offset: 0x00051DDC
		public string UserPatronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<UserPatronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<UserPatronymic>k__BackingField = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00053BF0 File Offset: 0x00051DF0
		public string User
		{
			get
			{
				return string.Concat(new string[]
				{
					this.UserLastName,
					" ",
					this.UserFirstName,
					" ",
					this.UserPatronymic
				});
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00053BF0 File Offset: 0x00051DF0
		public string UserFio
		{
			get
			{
				return string.Concat(new string[]
				{
					this.UserLastName,
					" ",
					this.UserFirstName,
					" ",
					this.UserPatronymic
				});
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00053C34 File Offset: 0x00051E34
		public string UserFioShort
		{
			get
			{
				string text = (!string.IsNullOrEmpty(this.UserFirstName)) ? (this.UserFirstName.Substring(0, 1) + ".") : "";
				string text2 = string.IsNullOrEmpty(this.UserPatronymic) ? "" : (this.UserPatronymic.Substring(0, 1) + ".");
				return string.Concat(new string[]
				{
					this.UserLastName,
					" ",
					text,
					" ",
					text2
				});
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00053CC8 File Offset: 0x00051EC8
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x00053CDC File Offset: 0x00051EDC
		public int? ToUserId
		{
			[CompilerGenerated]
			get
			{
				return this.<ToUserId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ToUserId>k__BackingField = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00053CF0 File Offset: 0x00051EF0
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x00053D04 File Offset: 0x00051F04
		public string ToUserFirstName
		{
			[CompilerGenerated]
			get
			{
				return this.<ToUserFirstName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ToUserFirstName>k__BackingField = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00053D18 File Offset: 0x00051F18
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00053D2C File Offset: 0x00051F2C
		public string ToUserLastName
		{
			[CompilerGenerated]
			get
			{
				return this.<ToUserLastName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ToUserLastName>k__BackingField = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00053D40 File Offset: 0x00051F40
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x00053D54 File Offset: 0x00051F54
		public string ToUserPatronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<ToUserPatronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ToUserPatronymic>k__BackingField = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00053D68 File Offset: 0x00051F68
		public string ToUserFio
		{
			get
			{
				return string.Concat(new string[]
				{
					this.ToUserLastName,
					" ",
					this.ToUserFirstName,
					" ",
					this.ToUserPatronymic
				});
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00053DAC File Offset: 0x00051FAC
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00053DC0 File Offset: 0x00051FC0
		public string notes
		{
			[CompilerGenerated]
			get
			{
				return this.<notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<notes>k__BackingField = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00053DD4 File Offset: 0x00051FD4
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x00053DE8 File Offset: 0x00051FE8
		public string ToolTipText
		{
			[CompilerGenerated]
			get
			{
				return this.<ToolTipText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ToolTipText>k__BackingField = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00053DFC File Offset: 0x00051FFC
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x00053E10 File Offset: 0x00052010
		public DateTime PeriodFrom
		{
			[CompilerGenerated]
			get
			{
				return this.<PeriodFrom>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PeriodFrom>k__BackingField = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00053E24 File Offset: 0x00052024
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x00053E38 File Offset: 0x00052038
		public DateTime PeriodTo
		{
			[CompilerGenerated]
			get
			{
				return this.<PeriodTo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PeriodTo>k__BackingField = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00053E4C File Offset: 0x0005204C
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x00053E60 File Offset: 0x00052060
		public int payment_system
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_system>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_system>k__BackingField = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x00053E74 File Offset: 0x00052074
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x00053E88 File Offset: 0x00052088
		public string PaymentSystemName
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystemName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PaymentSystemName>k__BackingField = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00053E9C File Offset: 0x0005209C
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00053EB0 File Offset: 0x000520B0
		public decimal summa
		{
			[CompilerGenerated]
			get
			{
				return this.<summa>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<summa>k__BackingField = value;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x00053EC4 File Offset: 0x000520C4
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x00053ED8 File Offset: 0x000520D8
		public bool IsBackDate
		{
			[CompilerGenerated]
			get
			{
				return this.<IsBackDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsBackDate>k__BackingField = value;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00053EEC File Offset: 0x000520EC
		public decimal SummaFormated
		{
			get
			{
				return Fn.FormatSumm(this.summa);
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00053F04 File Offset: 0x00052104
		public string Client
		{
			get
			{
				if (this.ClientType != 0)
				{
					return this.ClientUrName;
				}
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

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00053D68 File Offset: 0x00051F68
		public string ToUser
		{
			get
			{
				return string.Concat(new string[]
				{
					this.ToUserLastName,
					" ",
					this.ToUserFirstName,
					" ",
					this.ToUserPatronymic
				});
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x00053F58 File Offset: 0x00052158
		public bool IsPKO
		{
			get
			{
				return this.summa > 0m;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00053F78 File Offset: 0x00052178
		public bool IsCarPayment
		{
			get
			{
				return this.payment_system == -1;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x00053F90 File Offset: 0x00052190
		public decimal? CashLess
		{
			get
			{
				if (this.payment_system != 1)
				{
					goto IL_2D;
				}
				IL_09:
				int num = -458793128;
				IL_0E:
				decimal? result;
				switch ((num ^ -1154690423) % 4)
				{
				case 0:
					IL_2D:
					result = null;
					num = -928317313;
					goto IL_0E;
				case 1:
					return new decimal?(this.summa);
				case 3:
					goto IL_09;
				}
				return result;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00053FE8 File Offset: 0x000521E8
		public decimal? Cash
		{
			get
			{
				if (this.payment_system == 0)
				{
					return new decimal?(this.summa);
				}
				return null;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x00054014 File Offset: 0x00052214
		public decimal? Card
		{
			get
			{
				if (this.payment_system != -1)
				{
					goto IL_2D;
				}
				IL_09:
				int num = 1893968060;
				IL_0E:
				decimal? result;
				switch ((num ^ 805436063) % 4)
				{
				case 0:
					goto IL_09;
				case 1:
					IL_2D:
					result = null;
					num = 1909620493;
					goto IL_0E;
				case 3:
					return new decimal?(this.summa);
				}
				return result;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0005406C File Offset: 0x0005226C
		public decimal? OtherPs
		{
			get
			{
				if (this.payment_system != 0)
				{
					if (this.payment_system != 1)
					{
						if (this.payment_system != -1)
						{
							return new decimal?(this.summa);
						}
					}
				}
				return null;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000540AC File Offset: 0x000522AC
		public ImageSource Image
		{
			get
			{
				switch (this.type)
				{
				case 1:
					this.ToolTipText = (string)Application.Current.TryFindResource("RkoFreeReason");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/information.png");
				case 2:
					this.ToolTipText = (string)Application.Current.TryFindResource("PnPayment");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/favorite_14.png");
				case 3:
					this.ToolTipText = (string)Application.Current.TryFindResource("zOrder");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/information.png");
				case 4:
					this.ToolTipText = (string)Application.Current.TryFindResource("minusClientBalance");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/user_add.png");
				case 5:
					this.ToolTipText = (string)Application.Current.TryFindResource("Advance");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/credit_card.png");
				case 6:
					this.ToolTipText = (string)Application.Current.TryFindResource("UserSalary");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/money.png");
				case 8:
					this.ToolTipText = (string)Application.Current.TryFindResource("RepairRefund");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/reload_left.png");
				case 9:
					this.ToolTipText = (string)Application.Current.TryFindResource("RnCancelled");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/reload_left.png");
				case 11:
					this.ToolTipText = (string)Application.Current.TryFindResource("pkoFreeReason");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/information.png");
				case 12:
					this.ToolTipText = (string)Application.Current.TryFindResource("partsPrePayment");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/settings_15.png");
				case 13:
					this.ToolTipText = (string)Application.Current.TryFindResource("plusClientBalance");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/user_add.png");
				case 14:
					this.ToolTipText = (string)Application.Current.TryFindResource("soldByRn");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/shopping_cart.png");
				case 15:
					this.ToolTipText = (string)Application.Current.TryFindResource("repairPayment");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/laptop.png");
				case 16:
					this.ToolTipText = (string)Application.Current.TryFindResource("PnCancelled");
					return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/reload_left.png");
				case 17:
					this.ToolTipText = (string)Application.Current.TryFindResource("InvoicePayment");
					return new DXImageGrayscaleExtension
					{
						Image = (new DXImageConverter().ConvertFrom(null, null, "ColumnsOne_16x16.png") as DXImageInfo)
					}.ProvideValue(null) as ImageSource;
				}
				this.ToolTipText = (string)Application.Current.TryFindResource("RkoFreeReason");
				return this.GetImage("pack://application:,,,/ASC;component/Resources/OrderTypes/information.png");
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00054394 File Offset: 0x00052594
		private ImageSource GetImage(string path)
		{
			return new BitmapImage(new Uri(path, UriKind.Absolute));
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x000046B4 File Offset: 0x000028B4
		public CashOrdersLite()
		{
		}

		// Token: 0x04000F0E RID: 3854
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000F0F RID: 3855
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04000F10 RID: 3856
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04000F11 RID: 3857
		[CompilerGenerated]
		private string <OfficeName>k__BackingField;

		// Token: 0x04000F12 RID: 3858
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x04000F13 RID: 3859
		[CompilerGenerated]
		private int <type>k__BackingField;

		// Token: 0x04000F14 RID: 3860
		[CompilerGenerated]
		private int? <ClientId>k__BackingField;

		// Token: 0x04000F15 RID: 3861
		[CompilerGenerated]
		private int? <RepairId>k__BackingField;

		// Token: 0x04000F16 RID: 3862
		[CompilerGenerated]
		private int? <DocumentId>k__BackingField;

		// Token: 0x04000F17 RID: 3863
		[CompilerGenerated]
		private int? <InvoiceId>k__BackingField;

		// Token: 0x04000F18 RID: 3864
		[CompilerGenerated]
		private int <ClientType>k__BackingField;

		// Token: 0x04000F19 RID: 3865
		[CompilerGenerated]
		private string <ClientLastName>k__BackingField;

		// Token: 0x04000F1A RID: 3866
		[CompilerGenerated]
		private string <ClientFirstName>k__BackingField;

		// Token: 0x04000F1B RID: 3867
		[CompilerGenerated]
		private string <ClientPatronymic>k__BackingField;

		// Token: 0x04000F1C RID: 3868
		[CompilerGenerated]
		private string <ClientUrName>k__BackingField;

		// Token: 0x04000F1D RID: 3869
		[CompilerGenerated]
		private string <username>k__BackingField;

		// Token: 0x04000F1E RID: 3870
		[CompilerGenerated]
		private string <UserFirstName>k__BackingField;

		// Token: 0x04000F1F RID: 3871
		[CompilerGenerated]
		private string <UserLastName>k__BackingField;

		// Token: 0x04000F20 RID: 3872
		[CompilerGenerated]
		private string <UserPatronymic>k__BackingField;

		// Token: 0x04000F21 RID: 3873
		[CompilerGenerated]
		private int? <ToUserId>k__BackingField;

		// Token: 0x04000F22 RID: 3874
		[CompilerGenerated]
		private string <ToUserFirstName>k__BackingField;

		// Token: 0x04000F23 RID: 3875
		[CompilerGenerated]
		private string <ToUserLastName>k__BackingField;

		// Token: 0x04000F24 RID: 3876
		[CompilerGenerated]
		private string <ToUserPatronymic>k__BackingField;

		// Token: 0x04000F25 RID: 3877
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x04000F26 RID: 3878
		[CompilerGenerated]
		private string <ToolTipText>k__BackingField;

		// Token: 0x04000F27 RID: 3879
		[CompilerGenerated]
		private DateTime <PeriodFrom>k__BackingField;

		// Token: 0x04000F28 RID: 3880
		[CompilerGenerated]
		private DateTime <PeriodTo>k__BackingField;

		// Token: 0x04000F29 RID: 3881
		[CompilerGenerated]
		private int <payment_system>k__BackingField;

		// Token: 0x04000F2A RID: 3882
		[CompilerGenerated]
		private string <PaymentSystemName>k__BackingField;

		// Token: 0x04000F2B RID: 3883
		[CompilerGenerated]
		private decimal <summa>k__BackingField;

		// Token: 0x04000F2C RID: 3884
		[CompilerGenerated]
		private bool <IsBackDate>k__BackingField;
	}
}
