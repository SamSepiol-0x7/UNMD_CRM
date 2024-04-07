using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Options;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x020008DB RID: 2267
	public abstract class InvoiceBase : BindableBase, ICheckFields, IInvoice, IInvoiceLookup
	{
		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060045D7 RID: 17879 RVA: 0x00111600 File Offset: 0x0010F800
		// (set) Token: 0x060045D8 RID: 17880 RVA: 0x00111614 File Offset: 0x0010F814
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
				if (this.<Id>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1181442436;
				IL_10:
				switch ((num ^ -356506822) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					this.<Id>k__BackingField = value;
					this.RaisePropertyChanged("Id");
					num = -1773180949;
					goto IL_10;
				}
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x0011166C File Offset: 0x0010F86C
		// (set) Token: 0x060045DA RID: 17882 RVA: 0x00111680 File Offset: 0x0010F880
		public string Num
		{
			[CompilerGenerated]
			get
			{
				return this.<Num>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Num>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Num>k__BackingField = value;
				this.RaisePropertyChanged("Num");
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x001116B0 File Offset: 0x0010F8B0
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x001116C4 File Offset: 0x0010F8C4
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
				if (DateTime.Equals(this.<Date>k__BackingField, value))
				{
					return;
				}
				this.<Date>k__BackingField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x001116F4 File Offset: 0x0010F8F4
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x00111708 File Offset: 0x0010F908
		public DateTime? PaidDate
		{
			[CompilerGenerated]
			get
			{
				return this.<PaidDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTime>(this.<PaidDate>k__BackingField, value))
				{
					return;
				}
				this.<PaidDate>k__BackingField = value;
				this.RaisePropertyChanged("PaidDate");
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x00111738 File Offset: 0x0010F938
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x0011174C File Offset: 0x0010F94C
		public int State
		{
			[CompilerGenerated]
			get
			{
				return this.<State>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<State>k__BackingField == value)
				{
					return;
				}
				this.<State>k__BackingField = value;
				this.RaisePropertyChanged("StateName");
				this.RaisePropertyChanged("State");
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x00111784 File Offset: 0x0010F984
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x00111798 File Offset: 0x0010F998
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

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x001117C4 File Offset: 0x0010F9C4
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x001117D8 File Offset: 0x0010F9D8
		public ObservableCollection<IInvoiceItem> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("ItemsCount");
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x00111814 File Offset: 0x0010FA14
		public int ItemsCount
		{
			get
			{
				ObservableCollection<IInvoiceItem> items = this.Items;
				if (items == null)
				{
					return 0;
				}
				return items.Count;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x00111834 File Offset: 0x0010FA34
		// (set) Token: 0x060045E7 RID: 17895 RVA: 0x00111848 File Offset: 0x0010FA48
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

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x00111878 File Offset: 0x0010FA78
		// (set) Token: 0x060045E9 RID: 17897 RVA: 0x0011188C File Offset: 0x0010FA8C
		public decimal Tax
		{
			[CompilerGenerated]
			get
			{
				return this.<Tax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Tax>k__BackingField, value))
				{
					return;
				}
				this.<Tax>k__BackingField = value;
				this.RaisePropertyChanged("Tax");
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x001118BC File Offset: 0x0010FABC
		// (set) Token: 0x060045EB RID: 17899 RVA: 0x001118D0 File Offset: 0x0010FAD0
		public decimal Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Total>k__BackingField, value))
				{
					return;
				}
				this.<Total>k__BackingField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x00111900 File Offset: 0x0010FB00
		// (set) Token: 0x060045ED RID: 17901 RVA: 0x00111914 File Offset: 0x0010FB14
		public string TotalSummStr
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalSummStr>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<TotalSummStr>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TotalSummStr>k__BackingField = value;
				this.RaisePropertyChanged("TotalSummStr");
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x00111944 File Offset: 0x0010FB44
		// (set) Token: 0x060045EF RID: 17903 RVA: 0x00111958 File Offset: 0x0010FB58
		public ISellerPaymentDetails Seller
		{
			[CompilerGenerated]
			get
			{
				return this.<Seller>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Seller>k__BackingField, value))
				{
					return;
				}
				this.<Seller>k__BackingField = value;
				this.RaisePropertyChanged("Seller");
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x00111988 File Offset: 0x0010FB88
		// (set) Token: 0x060045F1 RID: 17905 RVA: 0x0011199C File Offset: 0x0010FB9C
		public IPaymentDetails Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Customer>k__BackingField, value))
				{
					return;
				}
				this.<Customer>k__BackingField = value;
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x001119CC File Offset: 0x0010FBCC
		// (set) Token: 0x060045F3 RID: 17907 RVA: 0x001119E0 File Offset: 0x0010FBE0
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

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00111A10 File Offset: 0x0010FC10
		// (set) Token: 0x060045F5 RID: 17909 RVA: 0x00111A24 File Offset: 0x0010FC24
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

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x00111A54 File Offset: 0x0010FC54
		// (set) Token: 0x060045F7 RID: 17911 RVA: 0x00111A68 File Offset: 0x0010FC68
		public string Operator
		{
			[CompilerGenerated]
			get
			{
				return this.<Operator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Operator>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Operator>k__BackingField = value;
				this.RaisePropertyChanged("Operator");
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x00111A98 File Offset: 0x0010FC98
		public string StateName
		{
			get
			{
				return InvoiceOptions.StateNameById(this.State);
			}
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00111AB0 File Offset: 0x0010FCB0
		protected InvoiceBase()
		{
			this.Items = new ObservableCollection<IInvoiceItem>();
			this.Date = DateTime.UtcNow;
			this.Employee = new Employee
			{
				Id = Auth.User.id,
				OfficeId = Auth.User.office,
				FirstName = Auth.User.name,
				LastName = Auth.User.surname,
				Patronymic = Auth.User.patronymic
			};
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00111B34 File Offset: 0x0010FD34
		public void SetNum(string num)
		{
			if (string.IsNullOrEmpty(num))
			{
				this.Num = 1.ToString();
				return;
			}
			this.IncrementNum(num);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x0007E558 File Offset: 0x0007C758
		public virtual void SetNum()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00111B60 File Offset: 0x0010FD60
		public void IncrementNum()
		{
			this.IncrementNum(this.Num);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00111B7C File Offset: 0x0010FD7C
		private void IncrementNum(string num)
		{
			this.Num = Regex.Replace(num, "\\d+", (Match m) => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00111BBC File Offset: 0x0010FDBC
		public virtual void CalcTotal()
		{
			this.Total = this.Items.Sum((IInvoiceItem i) => i.Total);
			this.Tax = this.Items.Sum((IInvoiceItem i) => i.TaxSumm);
			this.Summ = this.Items.Sum((IInvoiceItem i) => i.SummWithoutTax);
			this.TotalSummStr = ConvertersStack.SummToString(this.Total, Auth.Config.currency);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00111C74 File Offset: 0x0010FE74
		public virtual string GetNumAndDateStr()
		{
			return string.Format("{0} № {1} {2} {3:dd.MM.yyyy}", new object[]
			{
				(string)Application.Current.TryFindResource("Invoice"),
				this.Num,
				(string)Application.Current.TryFindResource("From"),
				this.Date
			});
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x0007E558 File Offset: 0x0007C758
		public virtual Task<byte[]> GetPdf(string templateName = "")
		{
			throw new NotImplementedException();
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06004601 RID: 17921 RVA: 0x00111CD8 File Offset: 0x0010FED8
		// (set) Token: 0x06004602 RID: 17922 RVA: 0x00111CEC File Offset: 0x0010FEEC
		public bool PrintImages
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintImages>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintImages>k__BackingField == value)
				{
					return;
				}
				this.<PrintImages>k__BackingField = value;
				this.RaisePropertyChanged("PrintImages");
			}
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00111D18 File Offset: 0x0010FF18
		public void EnablePrintImages()
		{
			this.PrintImages = true;
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00111D2C File Offset: 0x0010FF2C
		public void DisablePrintImages()
		{
			this.PrintImages = false;
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x0007E558 File Offset: 0x0007C758
		public virtual Task<bool> Archive()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00111D40 File Offset: 0x0010FF40
		public virtual string CheckFields()
		{
			if (this.Seller == null)
			{
				goto IL_1A;
			}
			goto IL_AF;
			int num;
			for (;;)
			{
				IL_6C:
				switch ((num ^ 563517043) % 9)
				{
				case 1:
					num = ((this.ItemsCount < 1) ? 513655853 : 1593643311);
					continue;
				case 2:
					goto IL_AF;
				case 3:
					goto IL_BE;
				case 4:
					goto IL_C4;
				case 5:
					num = ((this.Total <= 0m) ? 1289068242 : 1673945209);
					continue;
				case 6:
					goto IL_CA;
				case 7:
					goto IL_D0;
				case 8:
					goto IL_1A;
				}
				break;
			}
			return null;
			IL_BE:
			return "SelectCustomer";
			IL_C4:
			return "AddItems";
			IL_CA:
			return "CheckSumm";
			IL_D0:
			return "SelectSeller";
			IL_1A:
			num = 890326555;
			goto IL_6C;
			IL_AF:
			num = ((this.Customer != null) ? 176010879 : 910867683);
			goto IL_6C;
		}

		// Token: 0x04002CF1 RID: 11505
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002CF2 RID: 11506
		[CompilerGenerated]
		private string <Num>k__BackingField;

		// Token: 0x04002CF3 RID: 11507
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x04002CF4 RID: 11508
		[CompilerGenerated]
		private DateTime? <PaidDate>k__BackingField;

		// Token: 0x04002CF5 RID: 11509
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x04002CF6 RID: 11510
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04002CF7 RID: 11511
		[CompilerGenerated]
		private ObservableCollection<IInvoiceItem> <Items>k__BackingField;

		// Token: 0x04002CF8 RID: 11512
		[CompilerGenerated]
		private decimal <Summ>k__BackingField;

		// Token: 0x04002CF9 RID: 11513
		[CompilerGenerated]
		private decimal <Tax>k__BackingField;

		// Token: 0x04002CFA RID: 11514
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x04002CFB RID: 11515
		[CompilerGenerated]
		private string <TotalSummStr>k__BackingField;

		// Token: 0x04002CFC RID: 11516
		[CompilerGenerated]
		private ISellerPaymentDetails <Seller>k__BackingField;

		// Token: 0x04002CFD RID: 11517
		[CompilerGenerated]
		private IPaymentDetails <Customer>k__BackingField;

		// Token: 0x04002CFE RID: 11518
		[CompilerGenerated]
		private IEmployee <Employee>k__BackingField;

		// Token: 0x04002CFF RID: 11519
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002D00 RID: 11520
		[CompilerGenerated]
		private string <Operator>k__BackingField;

		// Token: 0x04002D01 RID: 11521
		[CompilerGenerated]
		private bool <PrintImages>k__BackingField;

		// Token: 0x020008DC RID: 2268
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004607 RID: 17927 RVA: 0x00111E24 File Offset: 0x00110024
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004608 RID: 17928 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004609 RID: 17929 RVA: 0x00111E3C File Offset: 0x0011003C
			internal string <IncrementNum>b__72_0(Match m)
			{
				return (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length));
			}

			// Token: 0x0600460A RID: 17930 RVA: 0x00111E70 File Offset: 0x00110070
			internal decimal <CalcTotal>b__73_0(IInvoiceItem i)
			{
				return i.Total;
			}

			// Token: 0x0600460B RID: 17931 RVA: 0x00111E84 File Offset: 0x00110084
			internal decimal <CalcTotal>b__73_1(IInvoiceItem i)
			{
				return i.TaxSumm;
			}

			// Token: 0x0600460C RID: 17932 RVA: 0x00111E98 File Offset: 0x00110098
			internal decimal <CalcTotal>b__73_2(IInvoiceItem i)
			{
				return i.SummWithoutTax;
			}

			// Token: 0x04002D02 RID: 11522
			public static readonly InvoiceBase.<>c <>9 = new InvoiceBase.<>c();

			// Token: 0x04002D03 RID: 11523
			public static MatchEvaluator <>9__72_0;

			// Token: 0x04002D04 RID: 11524
			public static Func<IInvoiceItem, decimal> <>9__73_0;

			// Token: 0x04002D05 RID: 11525
			public static Func<IInvoiceItem, decimal> <>9__73_1;

			// Token: 0x04002D06 RID: 11526
			public static Func<IInvoiceItem, decimal> <>9__73_2;
		}
	}
}
