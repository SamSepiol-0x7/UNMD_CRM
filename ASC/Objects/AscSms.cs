using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x0200087E RID: 2174
	public class AscSms : IAscSms
	{
		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x00102348 File Offset: 0x00100548
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x0010235C File Offset: 0x0010055C
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

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x00102370 File Offset: 0x00100570
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x00102384 File Offset: 0x00100584
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x00102398 File Offset: 0x00100598
		// (set) Token: 0x0600413E RID: 16702 RVA: 0x001023AC File Offset: 0x001005AC
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
				this.<Date>k__BackingField = value;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x001023C0 File Offset: 0x001005C0
		// (set) Token: 0x06004140 RID: 16704 RVA: 0x001023D4 File Offset: 0x001005D4
		public string Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Tel>k__BackingField = value;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x001023E8 File Offset: 0x001005E8
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x001023FC File Offset: 0x001005FC
		public int? CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomerId>k__BackingField = value;
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x00102410 File Offset: 0x00100610
		// (set) Token: 0x06004144 RID: 16708 RVA: 0x00102424 File Offset: 0x00100624
		public string Modem
		{
			[CompilerGenerated]
			get
			{
				return this.<Modem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Modem>k__BackingField = value;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x00102438 File Offset: 0x00100638
		// (set) Token: 0x06004146 RID: 16710 RVA: 0x0010244C File Offset: 0x0010064C
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
				this.<Customer>k__BackingField = value;
			}
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x000046B4 File Offset: 0x000028B4
		public AscSms()
		{
		}

		// Token: 0x04002A75 RID: 10869
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A76 RID: 10870
		[CompilerGenerated]
		private string <Text>k__BackingField;

		// Token: 0x04002A77 RID: 10871
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x04002A78 RID: 10872
		[CompilerGenerated]
		private string <Tel>k__BackingField;

		// Token: 0x04002A79 RID: 10873
		[CompilerGenerated]
		private int? <CustomerId>k__BackingField;

		// Token: 0x04002A7A RID: 10874
		[CompilerGenerated]
		private string <Modem>k__BackingField;

		// Token: 0x04002A7B RID: 10875
		[CompilerGenerated]
		private ICustomer <Customer>k__BackingField;
	}
}
