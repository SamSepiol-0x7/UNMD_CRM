using System;
using System.Runtime.CompilerServices;

namespace ASC.Objects.Reports
{
	// Token: 0x02000942 RID: 2370
	public class RepairLostDocReport : RepairReport
	{
		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x060048B9 RID: 18617 RVA: 0x0011DAB8 File Offset: 0x0011BCB8
		// (set) Token: 0x060048BA RID: 18618 RVA: 0x0011DACC File Offset: 0x0011BCCC
		public string DocumentName
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<DocumentName>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 703579927;
				IL_14:
				switch ((num ^ 2014037140) % 4)
				{
				case 0:
					IL_33:
					this.<DocumentName>k__BackingField = value;
					num = 1577731237;
					goto IL_14;
				case 2:
					goto IL_0F;
				case 3:
					return;
				}
				this.RaisePropertyChanged("DocumentName");
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x0011DB28 File Offset: 0x0011BD28
		// (set) Token: 0x060048BC RID: 18620 RVA: 0x0011DB3C File Offset: 0x0011BD3C
		public string DocumentNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentNumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DocumentNumber>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DocumentNumber>k__BackingField = value;
				this.RaisePropertyChanged("DocumentNumber");
			}
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x0011DB6C File Offset: 0x0011BD6C
		public RepairLostDocReport()
		{
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x0011DB80 File Offset: 0x0011BD80
		public RepairLostDocReport(RepairCard c) : base(c)
		{
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x0011DB94 File Offset: 0x0011BD94
		public void SetDocumentName(string name)
		{
			this.DocumentName = name;
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x0011DBA8 File Offset: 0x0011BDA8
		public void SetDocumentNumber(string number)
		{
			this.DocumentNumber = number;
		}

		// Token: 0x04002E54 RID: 11860
		[CompilerGenerated]
		private string <DocumentName>k__BackingField;

		// Token: 0x04002E55 RID: 11861
		[CompilerGenerated]
		private string <DocumentNumber>k__BackingField;
	}
}
