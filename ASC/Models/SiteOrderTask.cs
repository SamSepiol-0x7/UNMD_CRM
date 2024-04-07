using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.Extensions.OpenCart;
using ASC.Objects;

namespace ASC.Models
{
	// Token: 0x02000962 RID: 2402
	public class SiteOrderTask : AscTask
	{
		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x00120FBC File Offset: 0x0011F1BC
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x00120FD0 File Offset: 0x0011F1D0
		public List<IProduct> Products
		{
			[CompilerGenerated]
			get
			{
				return this.<Products>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Products>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1361688851;
				IL_13:
				switch ((num ^ -408362650) % 4)
				{
				case 0:
					IL_32:
					num = -491544977;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.<Products>k__BackingField = value;
				this.RaisePropertyChanged("Products");
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x0012102C File Offset: 0x0011F22C
		// (set) Token: 0x06004956 RID: 18774 RVA: 0x00121040 File Offset: 0x0011F240
		public List<IIdName> Statuses
		{
			[CompilerGenerated]
			get
			{
				return this.<Statuses>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Statuses>k__BackingField, value))
				{
					return;
				}
				this.<Statuses>k__BackingField = value;
				this.RaisePropertyChanged("Statuses");
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x00121070 File Offset: 0x0011F270
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x00121084 File Offset: 0x0011F284
		public bool InformCustomer
		{
			[CompilerGenerated]
			get
			{
				return this.<InformCustomer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InformCustomer>k__BackingField == value)
				{
					return;
				}
				this.<InformCustomer>k__BackingField = value;
				this.RaisePropertyChanged("InformCustomer");
			}
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x001210B0 File Offset: 0x0011F2B0
		public SiteOrderTask()
		{
			this.Products = new List<IProduct>();
			this.Statuses = new List<IIdName>();
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x001210DC File Offset: 0x0011F2DC
		public SiteOrderTask(IOrder order) : this()
		{
			this._order = order;
			base.SetDefaultValues();
			if (order.Products != null)
			{
				this.Products.AddRange(order.Products);
			}
			base.Type = TaskType.SitePartsRequest;
			base.SetEmail(order.Email);
			if (!string.IsNullOrEmpty(order.Telephone))
			{
				base.SetTel(order.Telephone);
			}
			this.SetSubject();
			this.SetMessage();
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x00121150 File Offset: 0x0011F350
		private void SetMessage()
		{
			base.SetMessage(base.Subject);
			base.SetMessage(string.Concat(new string[]
			{
				Lang.t("Client"),
				": ",
				this._order.Lastname,
				" ",
				this._order.Firstname
			}));
			base.SetMessage(string.Concat(new string[]
			{
				Lang.t("Client"),
				"2: ",
				this._order.ShippingLastname,
				" ",
				this._order.ShippingFirstname
			}));
			if (!string.IsNullOrEmpty(this._order.Comment))
			{
				base.SetMessage(Lang.t("Comment") + ": " + this._order.Comment);
			}
			this._order.ShippingAddress1.Equals(this._order.ShippingAddress2);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00121250 File Offset: 0x0011F450
		private void SetSubject()
		{
			string subject = string.Format("{0} #{1} ", Lang.t("Id"), this._order.OrderId) + " [" + this._order.StoreName + "]";
			base.SetSubject(subject);
		}

		// Token: 0x04002EB9 RID: 11961
		[CompilerGenerated]
		private List<IProduct> <Products>k__BackingField;

		// Token: 0x04002EBA RID: 11962
		private IOrder _order;

		// Token: 0x04002EBB RID: 11963
		[CompilerGenerated]
		private List<IIdName> <Statuses>k__BackingField;

		// Token: 0x04002EBC RID: 11964
		[CompilerGenerated]
		private bool <InformCustomer>k__BackingField;
	}
}
