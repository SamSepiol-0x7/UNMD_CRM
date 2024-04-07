using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ASC.Common.Interfaces;
using ASC.Options;

namespace ASC.SimpleClasses
{
	// Token: 0x0200021F RID: 543
	public class DocsList : INotifyPropertyChanged
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06001D11 RID: 7441 RVA: 0x00054774 File Offset: 0x00052974
		// (remove) Token: 0x06001D12 RID: 7442 RVA: 0x000547AC File Offset: 0x000529AC
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x000547E8 File Offset: 0x000529E8
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x000547FC File Offset: 0x000529FC
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
				if (this.<id>k__BackingField == value)
				{
					return;
				}
				this.<id>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.id);
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00054828 File Offset: 0x00052A28
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0005483C File Offset: 0x00052A3C
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
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.OfficeId);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00054868 File Offset: 0x00052A68
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0005487C File Offset: 0x00052A7C
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
				if (DateTime.Equals(this.<created>k__BackingField, value))
				{
					return;
				}
				this.<created>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.created);
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x000548AC File Offset: 0x00052AAC
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x000548C0 File Offset: 0x00052AC0
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
				if (string.Equals(this.<username>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<username>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.username);
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x000548F0 File Offset: 0x00052AF0
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x00054904 File Offset: 0x00052B04
		public int? state
		{
			[CompilerGenerated]
			get
			{
				return this.<state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<state>k__BackingField, value))
				{
					return;
				}
				this.<state>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.state);
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00054934 File Offset: 0x00052B34
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x00054948 File Offset: 0x00052B48
		public string FirstName
		{
			[CompilerGenerated]
			get
			{
				return this.<FirstName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<FirstName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<FirstName>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.User);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.FirstName);
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00054984 File Offset: 0x00052B84
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x00054998 File Offset: 0x00052B98
		public string LastName
		{
			[CompilerGenerated]
			get
			{
				return this.<LastName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<LastName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<LastName>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.User);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.LastName);
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x000549D4 File Offset: 0x00052BD4
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x000549E8 File Offset: 0x00052BE8
		public string Patronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<Patronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Patronymic>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Patronymic>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.User);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Patronymic);
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00054A24 File Offset: 0x00052C24
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x00054A38 File Offset: 0x00052C38
		public decimal total
		{
			[CompilerGenerated]
			get
			{
				return this.<total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<total>k__BackingField, value))
				{
					return;
				}
				this.<total>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.TotalFormatted);
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.total);
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00054A74 File Offset: 0x00052C74
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x00054A88 File Offset: 0x00052C88
		public string Office
		{
			[CompilerGenerated]
			get
			{
				return this.<Office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Office>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Office>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Office);
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00054AB8 File Offset: 0x00052CB8
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00054ACC File Offset: 0x00052CCC
		public int? dealer
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<dealer>k__BackingField, value))
				{
					return;
				}
				this.<dealer>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.dealer);
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00054AFC File Offset: 0x00052CFC
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x00054B10 File Offset: 0x00052D10
		public int? OrderId
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!Nullable.Equals<int>(this.<OrderId>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -2112777253;
				IL_13:
				switch ((num ^ -1944315602) % 4)
				{
				case 0:
					IL_32:
					this.<OrderId>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.OrderId);
					num = -2595744;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00054B6C File Offset: 0x00052D6C
		public virtual string Type
		{
			get
			{
				return this._documentOptions.GetOptionById(this.type);
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00054B8C File Offset: 0x00052D8C
		public decimal TotalFormatted
		{
			get
			{
				if (!Auth.Config.classic_kassa)
				{
					return decimal.ToInt32(this.total);
				}
				return Math.Round(this.total, 2);
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00054BC4 File Offset: 0x00052DC4
		public string User
		{
			get
			{
				return string.Concat(new string[]
				{
					this.LastName,
					" ",
					this.FirstName,
					" ",
					this.Patronymic
				});
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00054C08 File Offset: 0x00052E08
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00054C1C File Offset: 0x00052E1C
		public ICustomer Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Customer>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1994934063;
				IL_13:
				switch ((num ^ -311746821) % 4)
				{
				case 1:
					IL_32:
					this.<Customer>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Customer);
					num = -826043129;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00054C78 File Offset: 0x00052E78
		public DocsList()
		{
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00054C98 File Offset: 0x00052E98
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x04000F45 RID: 3909
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000F46 RID: 3910
		private DocumentOptions _documentOptions = new DocumentOptions();

		// Token: 0x04000F47 RID: 3911
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000F48 RID: 3912
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x04000F49 RID: 3913
		[CompilerGenerated]
		private DateTime <created>k__BackingField;

		// Token: 0x04000F4A RID: 3914
		[CompilerGenerated]
		private string <username>k__BackingField;

		// Token: 0x04000F4B RID: 3915
		[CompilerGenerated]
		private int? <state>k__BackingField;

		// Token: 0x04000F4C RID: 3916
		public int office;

		// Token: 0x04000F4D RID: 3917
		[CompilerGenerated]
		private string <FirstName>k__BackingField;

		// Token: 0x04000F4E RID: 3918
		[CompilerGenerated]
		private string <LastName>k__BackingField;

		// Token: 0x04000F4F RID: 3919
		[CompilerGenerated]
		private string <Patronymic>k__BackingField;

		// Token: 0x04000F50 RID: 3920
		public int type;

		// Token: 0x04000F51 RID: 3921
		[CompilerGenerated]
		private decimal <total>k__BackingField;

		// Token: 0x04000F52 RID: 3922
		[CompilerGenerated]
		private string <Office>k__BackingField;

		// Token: 0x04000F53 RID: 3923
		[CompilerGenerated]
		private int? <dealer>k__BackingField;

		// Token: 0x04000F54 RID: 3924
		[CompilerGenerated]
		private int? <OrderId>k__BackingField;

		// Token: 0x04000F55 RID: 3925
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;
	}
}
