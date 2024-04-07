using System;
using System.Runtime.CompilerServices;
using ASC.Objects;
using DevExpress.Mvvm;

namespace ASC.SimpleClasses
{
	// Token: 0x0200020A RID: 522
	public class PrintOptions : BindableBase
	{
		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0005217C File Offset: 0x0005037C
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x00052190 File Offset: 0x00050390
		public bool PrintWarrantyDocument
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintWarrantyDocument>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintWarrantyDocument>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1219007023;
				IL_10:
				switch ((num ^ -2138824730) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<PrintWarrantyDocument>k__BackingField = value;
					this.RaisePropertyChanged("PrintWarrantyDocument");
					num = -219806277;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000521E8 File Offset: 0x000503E8
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x000521FC File Offset: 0x000503FC
		public bool PrintWorksDocument
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintWorksDocument>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintWorksDocument>k__BackingField == value)
				{
					return;
				}
				this.<PrintWorksDocument>k__BackingField = value;
				this.RaisePropertyChanged("PrintWorksDocument");
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00052228 File Offset: 0x00050428
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x0005223C File Offset: 0x0005043C
		public bool PrintDiagnosticDocument
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintDiagnosticDocument>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintDiagnosticDocument>k__BackingField == value)
				{
					return;
				}
				this.<PrintDiagnosticDocument>k__BackingField = value;
				this.RaisePropertyChanged("PrintDiagnosticDocument");
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00052268 File Offset: 0x00050468
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0005227C File Offset: 0x0005047C
		public bool PrintCheck
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintCheck>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintCheck>k__BackingField == value)
				{
					return;
				}
				this.<PrintCheck>k__BackingField = value;
				this.RaisePropertyChanged("PrintCheck");
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x000522A8 File Offset: 0x000504A8
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x000522BC File Offset: 0x000504BC
		public bool PrintRejectDocument
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintRejectDocument>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PrintRejectDocument>k__BackingField == value)
				{
					return;
				}
				this.<PrintRejectDocument>k__BackingField = value;
				this.RaisePropertyChanged("PrintRejectDocument");
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000522E8 File Offset: 0x000504E8
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x000522FC File Offset: 0x000504FC
		public bool CanPrintCheck
		{
			[CompilerGenerated]
			get
			{
				return this.<CanPrintCheck>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CanPrintCheck>k__BackingField == value)
				{
					return;
				}
				this.<CanPrintCheck>k__BackingField = value;
				this.RaisePropertyChanged("CanPrintCheck");
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00052328 File Offset: 0x00050528
		public PrintOptions()
		{
			this.PrintWarrantyDocument = Auth.Config.print_warranty;
			this.PrintWorksDocument = Auth.Config.print_works;
			this.PrintDiagnosticDocument = Auth.Config.print_diagnostic;
			this.PrintRejectDocument = Auth.Config.print_reject;
			this.CanPrintCheck = OfflineData.Instance.Employee.KktReady();
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00052390 File Offset: 0x00050590
		public bool IfAnyRepairOkDocumentPrint()
		{
			return this.PrintDiagnosticDocument || this.PrintWorksDocument || this.PrintWarrantyDocument;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000523B8 File Offset: 0x000505B8
		public bool IfAnyRepairRejectDocumentPrint()
		{
			return this.PrintDiagnosticDocument || this.PrintWorksDocument || this.PrintRejectDocument;
		}

		// Token: 0x04000EAE RID: 3758
		[CompilerGenerated]
		private bool <PrintWarrantyDocument>k__BackingField;

		// Token: 0x04000EAF RID: 3759
		[CompilerGenerated]
		private bool <PrintWorksDocument>k__BackingField;

		// Token: 0x04000EB0 RID: 3760
		[CompilerGenerated]
		private bool <PrintDiagnosticDocument>k__BackingField;

		// Token: 0x04000EB1 RID: 3761
		[CompilerGenerated]
		private bool <PrintCheck>k__BackingField;

		// Token: 0x04000EB2 RID: 3762
		[CompilerGenerated]
		private bool <PrintRejectDocument>k__BackingField;

		// Token: 0x04000EB3 RID: 3763
		[CompilerGenerated]
		private bool <CanPrintCheck>k__BackingField;
	}
}
