using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Models;
using ASC.Objects.Reports;
using DevExpress.Mvvm;
using DevExpress.XtraReports.UI;

namespace ASC.Objects
{
	// Token: 0x0200088E RID: 2190
	public class StoreDocument : BindableBase, IStoreDocument
	{
		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x0600424C RID: 16972 RVA: 0x00104708 File Offset: 0x00102908
		// (set) Token: 0x0600424D RID: 16973 RVA: 0x0010471C File Offset: 0x0010291C
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
				this.RaisePropertyChanged("Barcode");
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x00104754 File Offset: 0x00102954
		// (set) Token: 0x0600424F RID: 16975 RVA: 0x00104768 File Offset: 0x00102968
		public DocType Type
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
				this.RaisePropertyChanged("Barcode");
				this.RaisePropertyChanged("Type");
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x001047A0 File Offset: 0x001029A0
		public string Barcode
		{
			get
			{
				Barcode.Types? types = this.DocType2BarcodeType(this.Type);
				if (types != null)
				{
					return new Barcode(types.Value).GenerateCode(this.Id);
				}
				return "";
			}
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x001047E0 File Offset: 0x001029E0
		private Barcode.Types? DocType2BarcodeType(DocType input)
		{
			if (input != DocType.PrihodnayaNakladnaya)
			{
				if (input != DocType.BuyOut)
				{
					if (input == DocType.RashodnayaNakladnaya)
					{
						return new Barcode.Types?(ASC.Models.Barcode.Types.SaleDoc);
					}
					if (input == DocType.InternalRelocation)
					{
						return new Barcode.Types?(ASC.Models.Barcode.Types.InternalRelocation);
					}
					return null;
				}
			}
			return new Barcode.Types?(ASC.Models.Barcode.Types.ArrivalDoc);
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x00104820 File Offset: 0x00102A20
		// (set) Token: 0x06004253 RID: 16979 RVA: 0x00104834 File Offset: 0x00102A34
		public DocStates Status
		{
			[CompilerGenerated]
			get
			{
				return this.<Status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Status>k__BackingField == value)
				{
					return;
				}
				this.<Status>k__BackingField = value;
				this.RaisePropertyChanged("Status");
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x00104860 File Offset: 0x00102A60
		// (set) Token: 0x06004255 RID: 16981 RVA: 0x00104874 File Offset: 0x00102A74
		public int PaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PaymentSystem>k__BackingField == value)
				{
					return;
				}
				this.<PaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystem");
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x001048A0 File Offset: 0x00102AA0
		// (set) Token: 0x06004257 RID: 16983 RVA: 0x001048B4 File Offset: 0x00102AB4
		public int? StoreId
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<StoreId>k__BackingField, value))
				{
					return;
				}
				this.<StoreId>k__BackingField = value;
				this.RaisePropertyChanged("StoreId");
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x001048E4 File Offset: 0x00102AE4
		// (set) Token: 0x06004259 RID: 16985 RVA: 0x001048F8 File Offset: 0x00102AF8
		public int EmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<EmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EmployeeId>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 980933090;
				IL_10:
				switch ((num ^ 2067052743) % 4)
				{
				case 0:
					IL_2F:
					num = 1727866681;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
				this.<EmployeeId>k__BackingField = value;
				this.RaisePropertyChanged("EmployeeId");
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x00104950 File Offset: 0x00102B50
		// (set) Token: 0x0600425B RID: 16987 RVA: 0x00104964 File Offset: 0x00102B64
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

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x00104990 File Offset: 0x00102B90
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x001049A4 File Offset: 0x00102BA4
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

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x001049D0 File Offset: 0x00102BD0
		// (set) Token: 0x0600425F RID: 16991 RVA: 0x001049E4 File Offset: 0x00102BE4
		public int? DealerId
		{
			[CompilerGenerated]
			get
			{
				return this.<DealerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<DealerId>k__BackingField, value))
				{
					return;
				}
				this.<DealerId>k__BackingField = value;
				this.RaisePropertyChanged("DealerId");
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x00104A14 File Offset: 0x00102C14
		// (set) Token: 0x06004261 RID: 16993 RVA: 0x00104A28 File Offset: 0x00102C28
		public virtual int PriceOption
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PriceOption>k__BackingField == value)
				{
					return;
				}
				this.<PriceOption>k__BackingField = value;
				this.RaisePropertyChanged("PriceOption");
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06004262 RID: 16994 RVA: 0x00104A54 File Offset: 0x00102C54
		// (set) Token: 0x06004263 RID: 16995 RVA: 0x00104A68 File Offset: 0x00102C68
		public int ReturnPercent
		{
			[CompilerGenerated]
			get
			{
				return this.<ReturnPercent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReturnPercent>k__BackingField == value)
				{
					return;
				}
				this.<ReturnPercent>k__BackingField = value;
				this.RaisePropertyChanged("ReturnPercent");
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x00104A94 File Offset: 0x00102C94
		// (set) Token: 0x06004265 RID: 16997 RVA: 0x00104AA8 File Offset: 0x00102CA8
		public int ReserveDays
		{
			[CompilerGenerated]
			get
			{
				return this.<ReserveDays>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ReserveDays>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 103257086;
				IL_10:
				switch ((num ^ 775466860) % 4)
				{
				case 1:
					IL_2F:
					this.<ReserveDays>k__BackingField = value;
					num = 1477077156;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("ReserveDays");
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x00104B00 File Offset: 0x00102D00
		// (set) Token: 0x06004267 RID: 16999 RVA: 0x00104B14 File Offset: 0x00102D14
		public decimal? CurrencyRate
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrencyRate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<decimal>(this.<CurrencyRate>k__BackingField, value))
				{
					return;
				}
				this.<CurrencyRate>k__BackingField = value;
				this.RaisePropertyChanged("CurrencyRate");
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x00104B44 File Offset: 0x00102D44
		// (set) Token: 0x06004269 RID: 17001 RVA: 0x00104B58 File Offset: 0x00102D58
		public decimal Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<Total>k__BackingField, value))
				{
					return;
				}
				this.<Total>k__BackingField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x00104B88 File Offset: 0x00102D88
		// (set) Token: 0x0600426B RID: 17003 RVA: 0x00104B9C File Offset: 0x00102D9C
		public string TotalString
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalString>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<TotalString>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TotalString>k__BackingField = value;
				this.RaisePropertyChanged("TotalString");
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600426C RID: 17004 RVA: 0x00104BCC File Offset: 0x00102DCC
		// (set) Token: 0x0600426D RID: 17005 RVA: 0x00104BE0 File Offset: 0x00102DE0
		public DateTime Date
		{
			[CompilerGenerated]
			get
			{
				return this.<Date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!DateTime.Equals(this.<Date>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 630666002;
				IL_13:
				switch ((num ^ 984543513) % 4)
				{
				case 0:
					IL_32:
					this.<Date>k__BackingField = value;
					num = 729100324;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.RaisePropertyChanged("Date");
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x00104C3C File Offset: 0x00102E3C
		// (set) Token: 0x0600426F RID: 17007 RVA: 0x00104C50 File Offset: 0x00102E50
		public string Reason
		{
			[CompilerGenerated]
			get
			{
				return this.<Reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Reason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Reason>k__BackingField = value;
				this.RaisePropertyChanged("Reason");
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x00104C80 File Offset: 0x00102E80
		// (set) Token: 0x06004271 RID: 17009 RVA: 0x00104C94 File Offset: 0x00102E94
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

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x00104CC4 File Offset: 0x00102EC4
		// (set) Token: 0x06004273 RID: 17011 RVA: 0x00104CD8 File Offset: 0x00102ED8
		public string Track
		{
			[CompilerGenerated]
			get
			{
				return this.<Track>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Track>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Track>k__BackingField = value;
				this.RaisePropertyChanged("Track");
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x00104D08 File Offset: 0x00102F08
		// (set) Token: 0x06004275 RID: 17013 RVA: 0x00104D1C File Offset: 0x00102F1C
		public int? CashOrderId
		{
			[CompilerGenerated]
			get
			{
				return this.<CashOrderId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<CashOrderId>k__BackingField, value))
				{
					return;
				}
				this.<CashOrderId>k__BackingField = value;
				this.RaisePropertyChanged("CashOrderId");
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x00104D4C File Offset: 0x00102F4C
		// (set) Token: 0x06004277 RID: 17015 RVA: 0x00104D60 File Offset: 0x00102F60
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
				if (Nullable.Equals<int>(this.<InvoiceId>k__BackingField, value))
				{
					return;
				}
				this.<InvoiceId>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceId");
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x00104D90 File Offset: 0x00102F90
		// (set) Token: 0x06004279 RID: 17017 RVA: 0x00104DA4 File Offset: 0x00102FA4
		public IEmployee Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Employee>k__BackingField, value))
				{
					return;
				}
				this.<Employee>k__BackingField = value;
				this.RaisePropertyChanged("Employee");
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x0600427A RID: 17018 RVA: 0x00104DD4 File Offset: 0x00102FD4
		// (set) Token: 0x0600427B RID: 17019 RVA: 0x00104DE8 File Offset: 0x00102FE8
		[Obsolete("Dont use this!!")]
		public bool WorksIncluded
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksIncluded>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WorksIncluded>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -2013613357;
				IL_10:
				switch ((num ^ -660506218) % 4)
				{
				case 0:
					IL_2F:
					this.<WorksIncluded>k__BackingField = value;
					num = -1302747756;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
				this.RaisePropertyChanged("WorksIncluded");
			}
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00104E40 File Offset: 0x00103040
		public void SetTotal(decimal total)
		{
			this.Total = total;
			this.TotalString = ConvertersStack.SummToString(total, Auth.Config.currency);
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00104E6C File Offset: 0x0010306C
		public void SetStatus(DocStates status)
		{
			this.Status = status;
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x0600427E RID: 17022 RVA: 0x00104E80 File Offset: 0x00103080
		// (set) Token: 0x0600427F RID: 17023 RVA: 0x00104E94 File Offset: 0x00103094
		public ObservableCollection<ISaleItem> Goods
		{
			[CompilerGenerated]
			get
			{
				return this.<Goods>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Goods>k__BackingField, value))
				{
					return;
				}
				this.<Goods>k__BackingField = value;
				this.RaisePropertyChanged("Goods");
			}
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00104EC4 File Offset: 0x001030C4
		public StoreDocument()
		{
			this.Goods = new ObservableCollection<ISaleItem>();
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x00104EE4 File Offset: 0x001030E4
		public void AddItem(ISaleItem g)
		{
			this.Goods.Add(g);
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00104F00 File Offset: 0x00103100
		public void SetTrack(string track)
		{
			this.Track = track.Truncate(45, "...");
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00104F20 File Offset: 0x00103120
		public void SetPriceOption(int value)
		{
			this.PriceOption = value;
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x00104F34 File Offset: 0x00103134
		public XtraReport CreateStickers(string variant, int copies, bool oneStickerPerRow)
		{
			XtraReport xtraReport = new XtraReport();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					doc_templates doc_templates = auseceEntities.doc_templates.FirstOrDefault((doc_templates t) => t.name == variant);
					if (doc_templates == null)
					{
						return xtraReport;
					}
					string @string = Encoding.UTF8.GetString(doc_templates.data);
					xtraReport.Tag = doc_templates.id;
					xtraReport.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
					GoodsStickerReport item = oneStickerPerRow ? new GoodsStickerReport(this) : new GoodsStickerReport(this, copies);
					xtraReport.DataSource = new List<GoodsStickerReport>
					{
						item
					};
					xtraReport.CreateDocument();
				}
			}
			catch (Exception)
			{
			}
			return xtraReport;
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x00105060 File Offset: 0x00103260
		public static XtraReport CreateStickers(IEnumerable<store_items> items, string variant, int copies)
		{
			XtraReport xtraReport = new XtraReport();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					doc_templates doc_templates = auseceEntities.doc_templates.FirstOrDefault((doc_templates t) => t.name == variant);
					if (doc_templates == null)
					{
						return xtraReport;
					}
					string @string = Encoding.UTF8.GetString(doc_templates.data);
					xtraReport.Tag = doc_templates.id;
					xtraReport.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
					xtraReport.DataSource = new List<GoodsStickerReport>
					{
						new GoodsStickerReport(items, copies)
					};
					xtraReport.CreateDocument();
				}
			}
			catch (Exception)
			{
			}
			return xtraReport;
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x0010517C File Offset: 0x0010337C
		public XtraReport CreateReport(string name, bool includeDescriptionInName = false)
		{
			XtraReport xtraReport = new XtraReport();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					doc_templates doc_templates = auseceEntities.doc_templates.FirstOrDefault((doc_templates t) => t.name == name);
					if (doc_templates == null)
					{
						return xtraReport;
					}
					string @string = Encoding.UTF8.GetString(doc_templates.data);
					xtraReport.Tag = doc_templates.id;
					xtraReport.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
					if (includeDescriptionInName)
					{
						foreach (ISaleItem saleItem in this.Goods)
						{
							saleItem.Name = saleItem.Name + " " + saleItem.Description;
						}
					}
					xtraReport.DataSource = new List<GoodsInvoiceReport>
					{
						new GoodsInvoiceReport(this)
					};
					xtraReport.CreateDocument();
				}
			}
			catch (Exception)
			{
			}
			return xtraReport;
		}

		// Token: 0x04002AF0 RID: 10992
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002AF1 RID: 10993
		[CompilerGenerated]
		private DocType <Type>k__BackingField;

		// Token: 0x04002AF2 RID: 10994
		[CompilerGenerated]
		private DocStates <Status>k__BackingField;

		// Token: 0x04002AF3 RID: 10995
		[CompilerGenerated]
		private int <PaymentSystem>k__BackingField;

		// Token: 0x04002AF4 RID: 10996
		[CompilerGenerated]
		private int? <StoreId>k__BackingField;

		// Token: 0x04002AF5 RID: 10997
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;

		// Token: 0x04002AF6 RID: 10998
		[CompilerGenerated]
		private int <CompanyId>k__BackingField;

		// Token: 0x04002AF7 RID: 10999
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04002AF8 RID: 11000
		[CompilerGenerated]
		private int? <DealerId>k__BackingField;

		// Token: 0x04002AF9 RID: 11001
		[CompilerGenerated]
		private int <PriceOption>k__BackingField;

		// Token: 0x04002AFA RID: 11002
		[CompilerGenerated]
		private int <ReturnPercent>k__BackingField;

		// Token: 0x04002AFB RID: 11003
		[CompilerGenerated]
		private int <ReserveDays>k__BackingField;

		// Token: 0x04002AFC RID: 11004
		[CompilerGenerated]
		private decimal? <CurrencyRate>k__BackingField;

		// Token: 0x04002AFD RID: 11005
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x04002AFE RID: 11006
		[CompilerGenerated]
		private string <TotalString>k__BackingField;

		// Token: 0x04002AFF RID: 11007
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x04002B00 RID: 11008
		[CompilerGenerated]
		private string <Reason>k__BackingField;

		// Token: 0x04002B01 RID: 11009
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002B02 RID: 11010
		[CompilerGenerated]
		private string <Track>k__BackingField;

		// Token: 0x04002B03 RID: 11011
		[CompilerGenerated]
		private int? <CashOrderId>k__BackingField;

		// Token: 0x04002B04 RID: 11012
		[CompilerGenerated]
		private int? <InvoiceId>k__BackingField;

		// Token: 0x04002B05 RID: 11013
		[CompilerGenerated]
		private IEmployee <Employee>k__BackingField;

		// Token: 0x04002B06 RID: 11014
		[CompilerGenerated]
		private bool <WorksIncluded>k__BackingField;

		// Token: 0x04002B07 RID: 11015
		[CompilerGenerated]
		private ObservableCollection<ISaleItem> <Goods>k__BackingField;

		// Token: 0x0200088F RID: 2191
		[CompilerGenerated]
		private sealed class <>c__DisplayClass105_0
		{
			// Token: 0x06004287 RID: 17031 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass105_0()
			{
			}

			// Token: 0x04002B08 RID: 11016
			public string variant;
		}

		// Token: 0x02000890 RID: 2192
		[CompilerGenerated]
		private sealed class <>c__DisplayClass106_0
		{
			// Token: 0x06004288 RID: 17032 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass106_0()
			{
			}

			// Token: 0x04002B09 RID: 11017
			public string variant;
		}

		// Token: 0x02000891 RID: 2193
		[CompilerGenerated]
		private sealed class <>c__DisplayClass107_0
		{
			// Token: 0x06004289 RID: 17033 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass107_0()
			{
			}

			// Token: 0x04002B0A RID: 11018
			public string name;
		}
	}
}
