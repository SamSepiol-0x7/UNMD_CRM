using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.ItemsExport.Models
{
	// Token: 0x02000319 RID: 793
	public class ExportProducts
	{
		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000728EC File Offset: 0x00070AEC
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x00072900 File Offset: 0x00070B00
		public List<Product> Products
		{
			[CompilerGenerated]
			get
			{
				return this.<Products>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Products>k__BackingField = value;
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00072914 File Offset: 0x00070B14
		public ExportProducts()
		{
			this.Products = new List<Product>();
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00072934 File Offset: 0x00070B34
		public void Add(Product p)
		{
			this.Products.Add(p);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00072950 File Offset: 0x00070B50
		public void Remove(Product p)
		{
			this.Products.Remove(p);
		}

		// Token: 0x040013DF RID: 5087
		[CompilerGenerated]
		private List<Product> <Products>k__BackingField;
	}
}
