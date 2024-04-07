using System;
using System.Runtime.CompilerServices;
using DevExpress.DataAccess.ObjectBinding;

namespace ASC.Objects
{
	// Token: 0x02000870 RID: 2160
	[HighlightedClass]
	public class SlipReport
	{
		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06004023 RID: 16419 RVA: 0x000FFA30 File Offset: 0x000FDC30
		public DateTime? DateTime
		{
			[CompilerGenerated]
			get
			{
				return this.<DateTime>k__BackingField;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x000FFA44 File Offset: 0x000FDC44
		// (set) Token: 0x06004025 RID: 16421 RVA: 0x000FFA58 File Offset: 0x000FDC58
		public string Slip
		{
			[CompilerGenerated]
			get
			{
				return this.<Slip>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Slip>k__BackingField = value;
			}
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x000FFA6C File Offset: 0x000FDC6C
		public SlipReport()
		{
			this.DateTime = new DateTime?(System.DateTime.Now);
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x000FFA90 File Offset: 0x000FDC90
		public void SetSlip(string slip)
		{
			this.Slip = slip;
		}

		// Token: 0x04002A0B RID: 10763
		[CompilerGenerated]
		private readonly DateTime? <DateTime>k__BackingField;

		// Token: 0x04002A0C RID: 10764
		[CompilerGenerated]
		private string <Slip>k__BackingField;
	}
}
