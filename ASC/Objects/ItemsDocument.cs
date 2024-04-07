using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000881 RID: 2177
	public class ItemsDocument : IItemsDocument
	{
		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x00102C18 File Offset: 0x00100E18
		// (set) Token: 0x0600417E RID: 16766 RVA: 0x00102C2C File Offset: 0x00100E2C
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
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x00102C40 File Offset: 0x00100E40
		// (set) Token: 0x06004180 RID: 16768 RVA: 0x00102C54 File Offset: 0x00100E54
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
				this.<PaymentSystem>k__BackingField = value;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x00102C68 File Offset: 0x00100E68
		// (set) Token: 0x06004182 RID: 16770 RVA: 0x00102C7C File Offset: 0x00100E7C
		public string CustomerEmail
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerEmail>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomerEmail>k__BackingField = value;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x00102C90 File Offset: 0x00100E90
		// (set) Token: 0x06004184 RID: 16772 RVA: 0x00102CA4 File Offset: 0x00100EA4
		public int CashOrderId
		{
			[CompilerGenerated]
			get
			{
				return this.<CashOrderId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CashOrderId>k__BackingField = value;
			}
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x000046B4 File Offset: 0x000028B4
		public ItemsDocument()
		{
		}

		// Token: 0x04002A93 RID: 10899
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A94 RID: 10900
		[CompilerGenerated]
		private int <PaymentSystem>k__BackingField;

		// Token: 0x04002A95 RID: 10901
		[CompilerGenerated]
		private string <CustomerEmail>k__BackingField;

		// Token: 0x04002A96 RID: 10902
		[CompilerGenerated]
		private int <CashOrderId>k__BackingField;
	}
}
