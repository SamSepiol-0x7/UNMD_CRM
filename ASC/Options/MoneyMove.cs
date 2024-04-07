using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.SimpleClasses;
using DevExpress.Mvvm;

namespace ASC.Options
{
	// Token: 0x02000250 RID: 592
	public class MoneyMove : BindableBase, ICheckFields
	{
		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0005D6D4 File Offset: 0x0005B8D4
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x0005D6E8 File Offset: 0x0005B8E8
		public List<IdNameClass> Offices
		{
			[CompilerGenerated]
			get
			{
				return this.<Offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Offices>k__BackingField, value))
				{
					return;
				}
				this.<Offices>k__BackingField = value;
				this.RaisePropertyChanged("Offices");
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0005D718 File Offset: 0x0005B918
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x0005D72C File Offset: 0x0005B92C
		public List<PaymentOptions> PaymentSystems
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystems>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentSystems>k__BackingField, value))
				{
					return;
				}
				this.<PaymentSystems>k__BackingField = value;
				this.RaisePropertyChanged("PaymentSystems");
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0005D75C File Offset: 0x0005B95C
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x0005D770 File Offset: 0x0005B970
		public int SourceCompany
		{
			[CompilerGenerated]
			get
			{
				return this.<SourceCompany>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SourceCompany>k__BackingField == value)
				{
					return;
				}
				this.<SourceCompany>k__BackingField = value;
				this.RaisePropertyChanged("SourceCompany");
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0005D79C File Offset: 0x0005B99C
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x0005D7B0 File Offset: 0x0005B9B0
		public int DestinationCompany
		{
			[CompilerGenerated]
			get
			{
				return this.<DestinationCompany>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DestinationCompany>k__BackingField == value)
				{
					return;
				}
				this.<DestinationCompany>k__BackingField = value;
				this.RaisePropertyChanged("DestinationCompany");
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0005D7DC File Offset: 0x0005B9DC
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x0005D7F0 File Offset: 0x0005B9F0
		public int SourceOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<SourceOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SourceOffice>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 627693795;
				IL_10:
				switch ((num ^ 1196291242) % 4)
				{
				case 0:
					IL_2F:
					this.<SourceOffice>k__BackingField = value;
					num = 1982228641;
					goto IL_10;
				case 1:
					return;
				case 2:
					goto IL_0B;
				}
				this.RaisePropertyChanged("SourceOffice");
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0005D848 File Offset: 0x0005BA48
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x0005D85C File Offset: 0x0005BA5C
		public int DestinationOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<DestinationOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DestinationOffice>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 315554649;
				IL_10:
				switch ((num ^ 976722928) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					return;
				case 2:
					IL_2F:
					this.<DestinationOffice>k__BackingField = value;
					this.RaisePropertyChanged("DestinationOffice");
					num = 1394549579;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0005D8B4 File Offset: 0x0005BAB4
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x0005D8C8 File Offset: 0x0005BAC8
		public int SourcePaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<SourcePaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SourcePaymentSystem>k__BackingField == value)
				{
					return;
				}
				this.<SourcePaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("SourcePaymentSystem");
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0005D908 File Offset: 0x0005BB08
		public int DestinationPaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<DestinationPaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DestinationPaymentSystem>k__BackingField == value)
				{
					return;
				}
				this.<DestinationPaymentSystem>k__BackingField = value;
				this.RaisePropertyChanged("DestinationPaymentSystem");
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0005D934 File Offset: 0x0005BB34
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0005D948 File Offset: 0x0005BB48
		public decimal Summ
		{
			[CompilerGenerated]
			get
			{
				return this.<Summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Summ>k__BackingField, value))
				{
					return;
				}
				this.<Summ>k__BackingField = value;
				this.RaisePropertyChanged("Summ");
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0005D978 File Offset: 0x0005BB78
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0005D98C File Offset: 0x0005BB8C
		public decimal Fee
		{
			[CompilerGenerated]
			get
			{
				return this.<Fee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Fee>k__BackingField, value))
				{
					return;
				}
				this.<Fee>k__BackingField = value;
				this.RaisePropertyChanged("Fee");
			}
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0005D9BC File Offset: 0x0005BBBC
		public MoneyMove()
		{
			PaymentOptions paymentOptions = new PaymentOptions();
			this.PaymentSystems = paymentOptions.GetAllOptions();
			this.Init();
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x0005D9E8 File Offset: 0x0005BBE8
		public void Init()
		{
			this.Offices = OfficesModel.LoadOffices(false);
			this.SourceCompany = OfflineData.Instance.GetSelectedCompany();
			this.DestinationCompany = OfflineData.Instance.GetSelectedCompany();
			if (this.Offices.Count == 1)
			{
				IdNameClass idNameClass = this.Offices.FirstOrDefault<IdNameClass>();
				if (idNameClass != null)
				{
					this.SourceOffice = idNameClass.Id;
					this.DestinationOffice = idNameClass.Id;
				}
			}
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0005DA58 File Offset: 0x0005BC58
		public string CheckFields()
		{
			if (this.SourceOffice == 0 || this.DestinationOffice == 0)
			{
				return "SelectOffice";
			}
			if (this.SourceCompany == 0 || this.DestinationCompany == 0)
			{
				return "SelectCompany";
			}
			if (this.Summ <= 0m)
			{
				return "InputSumm";
			}
			if (this.SourceOffice == this.DestinationOffice)
			{
				if (this.SourceCompany == this.DestinationCompany)
				{
					if (this.SourcePaymentSystem == this.DestinationPaymentSystem)
					{
						return "ItemError";
					}
				}
			}
			if (!(this.Fee > this.Summ))
			{
				return "";
			}
			return "FeeError";
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x0005DB04 File Offset: 0x0005BD04
		public Result Move()
		{
			Result result = new Result();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					DateTime serverUtcTime = Localization.GetServerUtcTime(auseceEntities);
					cash_orders cash_orders = new cash_orders
					{
						company = this.SourceCompany,
						user = OfflineData.Instance.Employee.Id,
						office = this.SourceOffice,
						created = serverUtcTime,
						type = 18,
						summa = -this.Summ,
						payment_system = this.SourcePaymentSystem,
						summa_str = ConvertersStack.SummToString(this.Summ, Auth.Config.currency),
						is_backdate = false,
						notes = this.Reason()
					};
					cash_orders cash_orders2 = new cash_orders
					{
						company = this.DestinationCompany,
						office = this.DestinationOffice,
						user = OfflineData.Instance.Employee.Id,
						created = serverUtcTime,
						type = 18,
						summa = this.Summ - this.Fee,
						payment_system = this.DestinationPaymentSystem,
						summa_str = ConvertersStack.SummToString(this.Summ, Auth.Config.currency),
						is_backdate = false,
						notes = this.Reason()
					};
					auseceEntities.cash_orders.Add(cash_orders);
					auseceEntities.cash_orders.Add(cash_orders2);
					auseceEntities.SaveChanges();
					result.AddId(cash_orders.id);
					result.AddId(cash_orders2.id);
					result.IsSucces = true;
				}
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0005DCDC File Offset: 0x0005BEDC
		private string Reason()
		{
			string shortName = Auth.CurrencyModel.SelectedCurrency.ShortName;
			return string.Format(Lang.t("Reason18"), new object[]
			{
				this.Summ,
				shortName,
				this.SourceOfficeName(),
				this.SourcePaymentSystemName(),
				this.DestinationOfficeName(),
				this.DestinationPaymentSystemName(),
				this.Fee,
				shortName
			});
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0005DD58 File Offset: 0x0005BF58
		private string SourceOfficeName()
		{
			IdNameClass idNameClass = this.Offices.FirstOrDefault((IdNameClass o) => o.Id == this.SourceOffice);
			if (idNameClass == null)
			{
				return null;
			}
			return idNameClass.Name;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x0005DD88 File Offset: 0x0005BF88
		private string DestinationOfficeName()
		{
			IdNameClass idNameClass = this.Offices.FirstOrDefault((IdNameClass o) => o.Id == this.DestinationOffice);
			if (idNameClass == null)
			{
				return null;
			}
			return idNameClass.Name;
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0005DDB8 File Offset: 0x0005BFB8
		private string SourcePaymentSystemName()
		{
			PaymentOptions paymentOptions = this.PaymentSystems.FirstOrDefault((PaymentOptions o) => o.Id == this.SourcePaymentSystem);
			if (paymentOptions == null)
			{
				return null;
			}
			return paymentOptions.Name;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0005DDE8 File Offset: 0x0005BFE8
		private string DestinationPaymentSystemName()
		{
			PaymentOptions paymentOptions = this.PaymentSystems.FirstOrDefault((PaymentOptions o) => o.Id == this.DestinationPaymentSystem);
			if (paymentOptions == null)
			{
				return null;
			}
			return paymentOptions.Name;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0005DE18 File Offset: 0x0005C018
		[CompilerGenerated]
		private bool <SourceOfficeName>b__45_0(IdNameClass o)
		{
			return o.Id == this.SourceOffice;
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0005DE34 File Offset: 0x0005C034
		[CompilerGenerated]
		private bool <DestinationOfficeName>b__46_0(IdNameClass o)
		{
			return o.Id == this.DestinationOffice;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0005DE50 File Offset: 0x0005C050
		[CompilerGenerated]
		private bool <SourcePaymentSystemName>b__47_0(PaymentOptions o)
		{
			return o.Id == this.SourcePaymentSystem;
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x0005DE6C File Offset: 0x0005C06C
		[CompilerGenerated]
		private bool <DestinationPaymentSystemName>b__48_0(PaymentOptions o)
		{
			return o.Id == this.DestinationPaymentSystem;
		}

		// Token: 0x040010A3 RID: 4259
		[CompilerGenerated]
		private List<IdNameClass> <Offices>k__BackingField;

		// Token: 0x040010A4 RID: 4260
		[CompilerGenerated]
		private List<PaymentOptions> <PaymentSystems>k__BackingField;

		// Token: 0x040010A5 RID: 4261
		[CompilerGenerated]
		private int <SourceCompany>k__BackingField;

		// Token: 0x040010A6 RID: 4262
		[CompilerGenerated]
		private int <DestinationCompany>k__BackingField;

		// Token: 0x040010A7 RID: 4263
		[CompilerGenerated]
		private int <SourceOffice>k__BackingField;

		// Token: 0x040010A8 RID: 4264
		[CompilerGenerated]
		private int <DestinationOffice>k__BackingField;

		// Token: 0x040010A9 RID: 4265
		[CompilerGenerated]
		private int <SourcePaymentSystem>k__BackingField;

		// Token: 0x040010AA RID: 4266
		[CompilerGenerated]
		private int <DestinationPaymentSystem>k__BackingField;

		// Token: 0x040010AB RID: 4267
		[CompilerGenerated]
		private decimal <Summ>k__BackingField;

		// Token: 0x040010AC RID: 4268
		[CompilerGenerated]
		private decimal <Fee>k__BackingField;
	}
}
