using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects.Converters;

namespace ASC.Objects.Reports
{
	// Token: 0x02000941 RID: 2369
	public class GoodsStickerReport
	{
		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x0011D858 File Offset: 0x0011BA58
		// (set) Token: 0x060048AF RID: 18607 RVA: 0x0011D86C File Offset: 0x0011BA6C
		public ICompany Company
		{
			[CompilerGenerated]
			get
			{
				return this.<Company>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Company>k__BackingField = value;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x060048B0 RID: 18608 RVA: 0x0011D880 File Offset: 0x0011BA80
		// (set) Token: 0x060048B1 RID: 18609 RVA: 0x0011D894 File Offset: 0x0011BA94
		public IAscConfig Config
		{
			[CompilerGenerated]
			get
			{
				return this.<Config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Config>k__BackingField = value;
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x060048B2 RID: 18610 RVA: 0x0011D8A8 File Offset: 0x0011BAA8
		// (set) Token: 0x060048B3 RID: 18611 RVA: 0x0011D8BC File Offset: 0x0011BABC
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
				this.<Goods>k__BackingField = value;
			}
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x0011D8D0 File Offset: 0x0011BAD0
		public GoodsStickerReport()
		{
			this.Goods = new ObservableCollection<ISaleItem>();
			this.Config = new AscConfig
			{
				CurrencyString = Auth.Config.CurrencyString
			};
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x0011D90C File Offset: 0x0011BB0C
		public GoodsStickerReport(StoreDocument d) : this()
		{
			foreach (ISaleItem item in d.Goods)
			{
				this.Goods.Add(item);
			}
			this.LoadCompany(d.CompanyId);
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x0011D974 File Offset: 0x0011BB74
		public GoodsStickerReport(StoreDocument d, int copies) : this()
		{
			foreach (ISaleItem saleItem in d.Goods)
			{
				int num = (copies > 0) ? copies : saleItem.Count;
				for (int i = 0; i < num; i++)
				{
					this.Goods.Add(saleItem);
				}
			}
			this.LoadCompany(d.CompanyId);
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x0011D9F4 File Offset: 0x0011BBF4
		public GoodsStickerReport(IEnumerable<store_items> d, int copies) : this()
		{
			foreach (store_items store_items in d)
			{
				int num = (copies > 0) ? copies : store_items.Available;
				for (int i = 0; i < num * store_items.BuyCount; i++)
				{
					this.Goods.Add(store_items.ToSaleItem());
				}
			}
			if (OfflineData.Instance.Employee.Office != null)
			{
				this.LoadCompany(OfflineData.Instance.Employee.Office.DefaultCompanyId);
			}
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x0011DA9C File Offset: 0x0011BC9C
		public void LoadCompany(int companyId)
		{
			this.Company = CompaniesModel.GetCompany(companyId);
		}

		// Token: 0x04002E51 RID: 11857
		[CompilerGenerated]
		private ICompany <Company>k__BackingField;

		// Token: 0x04002E52 RID: 11858
		[CompilerGenerated]
		private IAscConfig <Config>k__BackingField;

		// Token: 0x04002E53 RID: 11859
		[CompilerGenerated]
		private ObservableCollection<ISaleItem> <Goods>k__BackingField;
	}
}
