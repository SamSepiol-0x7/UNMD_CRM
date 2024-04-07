using System;
using System.Runtime.CompilerServices;
using ASC.Common;
using ASC.Common.Interfaces;
using ASC.Common.SimpleClasses;
using ASC.Options;

namespace ASC.Objects
{
	// Token: 0x02000875 RID: 2165
	public class WorkPartObject : IWorkPartObject, IIdName
	{
		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060040AA RID: 16554 RVA: 0x00100EFC File Offset: 0x000FF0FC
		// (set) Token: 0x060040AB RID: 16555 RVA: 0x00100F10 File Offset: 0x000FF110
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

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x00100F24 File Offset: 0x000FF124
		// (set) Token: 0x060040AD RID: 16557 RVA: 0x00100F38 File Offset: 0x000FF138
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060040AE RID: 16558 RVA: 0x00100F4C File Offset: 0x000FF14C
		// (set) Token: 0x060040AF RID: 16559 RVA: 0x00100F60 File Offset: 0x000FF160
		public virtual string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x00100F74 File Offset: 0x000FF174
		// (set) Token: 0x060040B1 RID: 16561 RVA: 0x00100F88 File Offset: 0x000FF188
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Count>k__BackingField = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x00100F9C File Offset: 0x000FF19C
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x00100FB0 File Offset: 0x000FF1B0
		public virtual decimal Price
		{
			[CompilerGenerated]
			get
			{
				return this.<Price>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Price>k__BackingField = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x00100FC4 File Offset: 0x000FF1C4
		public decimal Summ
		{
			get
			{
				return this.Count * this.Price;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x00100FE8 File Offset: 0x000FF1E8
		// (set) Token: 0x060040B6 RID: 16566 RVA: 0x00100FFC File Offset: 0x000FF1FC
		public int Warranty
		{
			[CompilerGenerated]
			get
			{
				return this.<Warranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Warranty>k__BackingField = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x00101010 File Offset: 0x000FF210
		public string WarrantyStr
		{
			get
			{
				return WarrantyOptions.DaysToName(this.Warranty);
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x00101028 File Offset: 0x000FF228
		// (set) Token: 0x060040B9 RID: 16569 RVA: 0x0010103C File Offset: 0x000FF23C
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
				this.<EmployeeId>k__BackingField = value;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x00101050 File Offset: 0x000FF250
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x00101064 File Offset: 0x000FF264
		public string SerialNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<SerialNumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x00101078 File Offset: 0x000FF278
		// (set) Token: 0x060040BD RID: 16573 RVA: 0x0010108C File Offset: 0x000FF28C
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
				this.<Notes>k__BackingField = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x001010A0 File Offset: 0x000FF2A0
		public bool CanAddPart
		{
			get
			{
				return this.Type == 1;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x001010B8 File Offset: 0x000FF2B8
		// (set) Token: 0x060040C0 RID: 16576 RVA: 0x001010CC File Offset: 0x000FF2CC
		public int RepairId
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

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060040C1 RID: 16577 RVA: 0x001010E0 File Offset: 0x000FF2E0
		// (set) Token: 0x060040C2 RID: 16578 RVA: 0x001010F4 File Offset: 0x000FF2F4
		public int? WorkPriceId
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkPriceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<WorkPriceId>k__BackingField = value;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060040C3 RID: 16579 RVA: 0x00101108 File Offset: 0x000FF308
		// (set) Token: 0x060040C4 RID: 16580 RVA: 0x0010111C File Offset: 0x000FF31C
		public int? WorkId
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<WorkId>k__BackingField = value;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x00101130 File Offset: 0x000FF330
		// (set) Token: 0x060040C6 RID: 16582 RVA: 0x00101144 File Offset: 0x000FF344
		public int? ItemId
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ItemId>k__BackingField = value;
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x00101158 File Offset: 0x000FF358
		// (set) Token: 0x060040C8 RID: 16584 RVA: 0x0010116C File Offset: 0x000FF36C
		public bool DirectItem
		{
			[CompilerGenerated]
			get
			{
				return this.<DirectItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DirectItem>k__BackingField = value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x00101180 File Offset: 0x000FF380
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x00101194 File Offset: 0x000FF394
		public int MasterPercent
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterPercent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<MasterPercent>k__BackingField = value;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x001011A8 File Offset: 0x000FF3A8
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x001011BC File Offset: 0x000FF3BC
		public IEmployee Repairman
		{
			[CompilerGenerated]
			get
			{
				return this.<Repairman>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Repairman>k__BackingField = value;
			}
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x000046B4 File Offset: 0x000028B4
		public WorkPartObject()
		{
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x001011D0 File Offset: 0x000FF3D0
		public WorkPartObject(int repairId)
		{
			this.RepairId = repairId;
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x001011EC File Offset: 0x000FF3EC
		public WorkPartObject(int repairId, RepairItem.Types type, string name, int count, decimal price) : this(repairId)
		{
			this.Type = (int)type;
			this.Name = name;
			this.Count = count;
			this.Price = price;
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00101220 File Offset: 0x000FF420
		public void GenerateRandomId()
		{
			int id;
			int.TryParse(Generators.RandomString(6, "0123456789"), out id);
			this.Id = id;
		}

		// Token: 0x04002A42 RID: 10818
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A43 RID: 10819
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002A44 RID: 10820
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002A45 RID: 10821
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x04002A46 RID: 10822
		[CompilerGenerated]
		private decimal <Price>k__BackingField;

		// Token: 0x04002A47 RID: 10823
		[CompilerGenerated]
		private int <Warranty>k__BackingField;

		// Token: 0x04002A48 RID: 10824
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;

		// Token: 0x04002A49 RID: 10825
		[CompilerGenerated]
		private string <SerialNumber>k__BackingField;

		// Token: 0x04002A4A RID: 10826
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002A4B RID: 10827
		[CompilerGenerated]
		private int <RepairId>k__BackingField;

		// Token: 0x04002A4C RID: 10828
		[CompilerGenerated]
		private int? <WorkPriceId>k__BackingField;

		// Token: 0x04002A4D RID: 10829
		[CompilerGenerated]
		private int? <WorkId>k__BackingField;

		// Token: 0x04002A4E RID: 10830
		[CompilerGenerated]
		private int? <ItemId>k__BackingField;

		// Token: 0x04002A4F RID: 10831
		[CompilerGenerated]
		private bool <DirectItem>k__BackingField;

		// Token: 0x04002A50 RID: 10832
		[CompilerGenerated]
		private int <MasterPercent>k__BackingField;

		// Token: 0x04002A51 RID: 10833
		[CompilerGenerated]
		private IEmployee <Repairman>k__BackingField;
	}
}
