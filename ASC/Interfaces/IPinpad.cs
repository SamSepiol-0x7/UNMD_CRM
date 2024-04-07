using System;

namespace ASC.Interfaces
{
	// Token: 0x02000B3D RID: 2877
	public interface IPinpad
	{
		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06005100 RID: 20736
		// (set) Token: 0x06005101 RID: 20737
		int PinpadId { get; set; }

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06005102 RID: 20738
		// (set) Token: 0x06005103 RID: 20739
		int OfficeId { get; set; }

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06005104 RID: 20740
		// (set) Token: 0x06005105 RID: 20741
		double Fee { get; set; }

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06005106 RID: 20742
		// (set) Token: 0x06005107 RID: 20743
		bool FeeMode { get; set; }

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06005108 RID: 20744
		// (set) Token: 0x06005109 RID: 20745
		string Name { get; set; }

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600510A RID: 20746
		// (set) Token: 0x0600510B RID: 20747
		int? Kkt { get; set; }
	}
}
