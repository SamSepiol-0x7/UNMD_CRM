using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;
using NLog;

namespace ASC
{
	// Token: 0x020000A3 RID: 163
	public class Currency : BindableBase, ICurrency
	{
		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000240D4 File Offset: 0x000222D4
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x000240E8 File Offset: 0x000222E8
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1598689005;
				IL_14:
				switch ((num ^ 533419584) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					return;
				case 2:
					IL_33:
					this.<Name>k__BackingField = value;
					this.RaisePropertyChanged("Name");
					num = 1681158299;
					goto IL_14;
				}
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00024144 File Offset: 0x00022344
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x00024158 File Offset: 0x00022358
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
				if (string.Equals(this.<Code>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Code>k__BackingField = value;
				this.RaisePropertyChanged("Code");
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00024188 File Offset: 0x00022388
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0002419C File Offset: 0x0002239C
		public string NumCode
		{
			[CompilerGenerated]
			get
			{
				return this.<NumCode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NumCode>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NumCode>k__BackingField = value;
				this.RaisePropertyChanged("NumCode");
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x000241CC File Offset: 0x000223CC
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x000241E0 File Offset: 0x000223E0
		public string ShortName
		{
			[CompilerGenerated]
			get
			{
				return this.<ShortName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<ShortName>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -2130797875;
				IL_14:
				switch ((num ^ -1113674080) % 4)
				{
				case 0:
					IL_33:
					this.<ShortName>k__BackingField = value;
					this.RaisePropertyChanged("ShortName");
					num = -363277006;
					goto IL_14;
				case 1:
					return;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0002423C File Offset: 0x0002243C
		public List<Currency> Currencies
		{
			[CompilerGenerated]
			get
			{
				return this.<Currencies>k__BackingField;
			}
		} = new List<Currency>();

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00024250 File Offset: 0x00022450
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00024264 File Offset: 0x00022464
		public decimal Rate
		{
			[CompilerGenerated]
			get
			{
				return this.<Rate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Rate>k__BackingField, value))
				{
					return;
				}
				this.<Rate>k__BackingField = value;
				this.RaisePropertyChanged("Rate");
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00024294 File Offset: 0x00022494
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x000242A8 File Offset: 0x000224A8
		public Currency SelectedCurrency
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCurrency>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedCurrency>k__BackingField, value))
				{
					return;
				}
				this.<SelectedCurrency>k__BackingField = value;
				this.RaisePropertyChanged("SelectedCurrency");
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x000242D8 File Offset: 0x000224D8
		public Currency()
		{
			this.Currencies.Add(new Currency("Российский рубль", "RUB", "руб.", "643"));
			this.Currencies.Add(new Currency("Доллар США", "USD", "$", "840"));
			this.Currencies.Add(new Currency("Гривна", "UAH", "грн.", "980"));
			this.Currencies.Add(new Currency("Белорусский рубль", "BYN", "руб.", "933"));
			this.Currencies.Add(new Currency("Новый израильский шекель", "ILS", "₪", "376"));
			this.Currencies.Add(new Currency("Молдавский лей", "MDL", "lei", "498"));
			this.Currencies.Add(new Currency("Злотый", "PLN", "zł", "985"));
			this.Currencies.Add(new Currency("Юань", "CNY", "¥", "156"));
			this.Currencies.Add(new Currency("Болгарский лев", "BGN", "лв", "975"));
			this.Currencies.Add(new Currency("Узбекский сум", "UZS", "сўм", "928"));
			this.Currencies.Add(new Currency("Тенге", "KZT", "тңг", "398"));
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00024484 File Offset: 0x00022684
		public Currency GetCurrencyInfo(string code)
		{
			return this.Currencies.FirstOrDefault((Currency c) => c.Code == code);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000244B8 File Offset: 0x000226B8
		public Currency(string code) : this()
		{
			this._currentCurrency = code;
			this.RefreshRate();
			this.SelectedCurrency = this.Currencies.FirstOrDefault((Currency c) => c.Code == code);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00024508 File Offset: 0x00022708
		public Currency(string name, string code, string shortName, string numCode)
		{
			this.Name = name;
			this.Code = code;
			this.ShortName = shortName;
			this.NumCode = numCode;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00024544 File Offset: 0x00022744
		public void RefreshRate()
		{
			if (string.IsNullOrEmpty(this._currentCurrency))
			{
				return;
			}
			this.Rate = this.GetRate("USD", this._currentCurrency);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00024578 File Offset: 0x00022778
		public decimal GetRate(string from, string to)
		{
			if (!Auth.Config.exchange_type)
			{
				decimal result;
				try
				{
					auseceEntities auseceEntities = new auseceEntities(true);
					try
					{
						currency currency = auseceEntities.currency.FirstOrDefault((currency c) => c.from == from && c.to == to && c.created == DateTime.Today);
						decimal num3;
						for (;;)
						{
							IL_344:
							uint num = 4128206455U;
							for (;;)
							{
								uint num2;
								switch ((num2 = (num ^ 3871681337U)) % 18U)
								{
								case 0U:
									this.AddRateToDb(from, to, num3);
									num = (num2 * 3604022649U ^ 3269087381U);
									continue;
								case 1U:
									switch (Auth.Config.exchange_source)
									{
									case 1:
										goto IL_21F;
									case 2:
										goto IL_16A;
									case 3:
										goto IL_1EC;
									default:
										num = (num2 * 3679889043U ^ 2832664641U);
										continue;
									}
									break;
								case 2U:
									num = (((currency != null) ? 1816687200U : 846361262U) ^ num2 * 1191507313U);
									continue;
								case 3U:
									num = (num2 * 697733844U ^ 3025855825U);
									continue;
								case 4U:
									result = 0m;
									num = 3441670885U;
									continue;
								case 5U:
									goto IL_21F;
								case 6U:
									goto IL_34B;
								case 7U:
									num3 = 0m;
									num = 4087962570U;
									continue;
								case 8U:
									goto IL_1EC;
								case 9U:
									this.AddRateToDb(from, to, num3);
									num = (num2 * 455648141U ^ 1100733472U);
									continue;
								case 10U:
									goto IL_344;
								case 11U:
									num = (((Auth.Config.currency == "UAH") ? 1181759832U : 811054551U) ^ num2 * 1732791640U);
									continue;
								case 12U:
									goto IL_16A;
								case 13U:
									num = (num2 * 244603598U ^ 1672460001U);
									continue;
								case 15U:
									num = (((!(currency.rate != 0m)) ? 779423689U : 1577275789U) ^ num2 * 2572344767U);
									continue;
								case 16U:
									goto IL_358;
								case 17U:
									goto IL_360;
								}
								goto Block_10;
								IL_16A:
								num3 = new CBRF().GetRate(from, to);
								num = 2337466456U;
								continue;
								IL_1EC:
								num3 = new PB().GetRate(from, to);
								num = 4127899621U;
								continue;
								IL_21F:
								num = ((!(Auth.Config.currency == "RUB")) ? 3197059816U : 3425544607U);
							}
						}
						Block_10:
						goto IL_353;
						IL_34B:
						result = num3;
						IL_353:
						return result;
						IL_358:
						return num3;
						IL_360:
						result = currency.rate;
					}
					finally
					{
						if (auseceEntities != null)
						{
							for (;;)
							{
								IL_3A4:
								uint num4 = 3024676787U;
								for (;;)
								{
									uint num2;
									switch ((num2 = (num4 ^ 3871681337U)) % 3U)
									{
									case 0U:
										goto IL_3A4;
									case 1U:
										((IDisposable)auseceEntities).Dispose();
										num4 = (num2 * 3844024182U ^ 1505824107U);
										continue;
									}
									goto Block_13;
								}
							}
							Block_13:;
						}
					}
				}
				catch (Exception exception)
				{
					for (;;)
					{
						IL_40A:
						uint num5 = 2484507256U;
						for (;;)
						{
							uint num2;
							switch ((num2 = (num5 ^ 3871681337U)) % 4U)
							{
							case 1U:
								LogManager.GetCurrentClassLogger().Error(exception, "Get currency rate error");
								num5 = (num2 * 3341609864U ^ 828648498U);
								continue;
							case 2U:
								goto IL_40A;
							case 3U:
								result = 0m;
								num5 = (num2 * 3948192437U ^ 8811118U);
								continue;
							}
							goto Block_15;
						}
					}
					Block_15:;
				}
				return result;
			}
			return (decimal)Auth.Config.exchange_rate;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000249E0 File Offset: 0x00022BE0
		public decimal LastRecordCurrencyRate()
		{
			decimal result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from c in auseceEntities.currency
					orderby c.id descending
					select c.rate).FirstOrDefault<decimal>();
				}
			}
			catch (Exception exception)
			{
				LogManager.GetCurrentClassLogger().Error(exception, "Get currency rate from DB error");
				result = 0m;
			}
			return result;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00024AC0 File Offset: 0x00022CC0
		public void AddRateToDb(string from, string to, decimal rate)
		{
			currency entity = new currency
			{
				created = DateTime.Today,
				from = from,
				to = to,
				rate = rate
			};
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.currency.Add(entity);
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				LogManager.GetCurrentClassLogger().Error(exception, "Add exchange rate to db fail ");
			}
		}

		// Token: 0x040008EA RID: 2282
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040008EB RID: 2283
		[CompilerGenerated]
		private string <Code>k__BackingField;

		// Token: 0x040008EC RID: 2284
		[CompilerGenerated]
		private string <NumCode>k__BackingField;

		// Token: 0x040008ED RID: 2285
		[CompilerGenerated]
		private string <ShortName>k__BackingField;

		// Token: 0x040008EE RID: 2286
		[CompilerGenerated]
		private readonly List<Currency> <Currencies>k__BackingField;

		// Token: 0x040008EF RID: 2287
		[CompilerGenerated]
		private decimal <Rate>k__BackingField;

		// Token: 0x040008F0 RID: 2288
		[CompilerGenerated]
		private Currency <SelectedCurrency>k__BackingField;

		// Token: 0x040008F1 RID: 2289
		private string _currentCurrency;

		// Token: 0x020000A4 RID: 164
		[CompilerGenerated]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x060012B4 RID: 4788 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x060012B5 RID: 4789 RVA: 0x00024B4C File Offset: 0x00022D4C
			internal bool <GetCurrencyInfo>b__0(Currency c)
			{
				return c.Code == this.code;
			}

			// Token: 0x040008F2 RID: 2290
			public string code;
		}

		// Token: 0x020000A5 RID: 165
		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x060012B6 RID: 4790 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x060012B7 RID: 4791 RVA: 0x00024B6C File Offset: 0x00022D6C
			internal bool <.ctor>b__0(Currency c)
			{
				return c.Code == this.code;
			}

			// Token: 0x040008F3 RID: 2291
			public string code;
		}

		// Token: 0x020000A6 RID: 166
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x060012B8 RID: 4792 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x040008F4 RID: 2292
			public string from;

			// Token: 0x040008F5 RID: 2293
			public string to;
		}

		// Token: 0x020000A7 RID: 167
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060012B9 RID: 4793 RVA: 0x00024B8C File Offset: 0x00022D8C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060012BA RID: 4794 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x040008F6 RID: 2294
			public static readonly Currency.<>c <>9 = new Currency.<>c();
		}
	}
}
