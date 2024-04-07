using System;
using System.Runtime.CompilerServices;
using ASC.Objects;
using ASC.Voip.Megafon.Core;

namespace ASC.Extensions.Megafon
{
	// Token: 0x02000BC0 RID: 3008
	public class MegafonApiOptions : IMegafonApiOptions
	{
		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x00169DEC File Offset: 0x00167FEC
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x00169E00 File Offset: 0x00168000
		public string PbxEndpoint
		{
			[CompilerGenerated]
			get
			{
				return this.<PbxEndpoint>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PbxEndpoint>k__BackingField = value;
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x00169E14 File Offset: 0x00168014
		// (set) Token: 0x06005444 RID: 21572 RVA: 0x00169E28 File Offset: 0x00168028
		public string ApiToken
		{
			[CompilerGenerated]
			get
			{
				return this.<ApiToken>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ApiToken>k__BackingField = value;
			}
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00169E3C File Offset: 0x0016803C
		public MegafonApiOptions()
		{
			this.ApiToken = OfflineData.Instance.Settings.VoipKey;
			this.PbxEndpoint = OfflineData.Instance.Settings.VoipEndpoint;
		}

		// Token: 0x040037A4 RID: 14244
		[CompilerGenerated]
		private string <PbxEndpoint>k__BackingField;

		// Token: 0x040037A5 RID: 14245
		[CompilerGenerated]
		private string <ApiToken>k__BackingField;
	}
}
