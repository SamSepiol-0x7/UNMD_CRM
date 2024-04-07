using System;

namespace ASC.Interfaces
{
	// Token: 0x02000B3E RID: 2878
	public interface IPinpadResult
	{
		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600510C RID: 20748
		// (set) Token: 0x0600510D RID: 20749
		int PinpadId { get; set; }

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x0600510E RID: 20750
		// (set) Token: 0x0600510F RID: 20751
		int ErrorCode { get; set; }

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06005110 RID: 20752
		// (set) Token: 0x06005111 RID: 20753
		decimal Amount { get; set; }

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06005112 RID: 20754
		// (set) Token: 0x06005113 RID: 20755
		string Cheque { get; set; }

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06005114 RID: 20756
		// (set) Token: 0x06005115 RID: 20757
		string TermNum { get; set; }

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06005116 RID: 20758
		// (set) Token: 0x06005117 RID: 20759
		string ClientCard { get; set; }

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06005118 RID: 20760
		// (set) Token: 0x06005119 RID: 20761
		string ClientExpiryDate { get; set; }

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600511A RID: 20762
		// (set) Token: 0x0600511B RID: 20763
		string AuthCode { get; set; }

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600511C RID: 20764
		// (set) Token: 0x0600511D RID: 20765
		string CardName { get; set; }

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600511E RID: 20766
		string ResultText { get; }
	}
}
