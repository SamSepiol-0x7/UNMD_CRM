using System;

namespace ASC.Interfaces
{
	// Token: 0x02000B4C RID: 2892
	public interface ISticker
	{
		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06005132 RID: 20786
		string UID { get; }

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06005133 RID: 20787
		string int_barcode { get; }

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06005134 RID: 20788
		// (set) Token: 0x06005135 RID: 20789
		string description { get; set; }
	}
}
