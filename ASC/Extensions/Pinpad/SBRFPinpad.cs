using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Interfaces;
using ASC.Objects;
using DevExpress.XtraReports.UI;
using SBRFPinpad;

namespace ASC.Extensions.Pinpad
{
	// Token: 0x02000B99 RID: 2969
	public sealed class SBRFPinpad : SBRFPinpad, IPinpad
	{
		// Token: 0x06005281 RID: 21121
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int _controlfp(int newControl, int mask);

		// Token: 0x06005282 RID: 21122 RVA: 0x001638C0 File Offset: 0x00161AC0
		public SBRFPinpad()
		{
			this.PinpadId = OfflineData.Instance.Employee.Pinpad.PinpadId;
			this.Kkt = OfflineData.Instance.Employee.Pinpad.Kkt;
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x00163908 File Offset: 0x00161B08
		public IPinpadResult Purchase(decimal summ)
		{
			PinpadResult pinpadResult = new PinpadResult();
			base.Clear();
			this.SetAmount(summ);
			pinpadResult.ErrorCode = this.Purchase();
			if (pinpadResult.ErrorCode == 0)
			{
				pinpadResult.PinpadId = this.PinpadId;
				pinpadResult.Amount = summ;
				pinpadResult.Cheque = this.GetCheque();
				pinpadResult.TermNum = this.GetTermNum();
				pinpadResult.ClientCard = this.GetClientCard();
				pinpadResult.ClientExpiryDate = this.GetClientExpiryDate();
				pinpadResult.AuthCode = this.GetAuthCode();
				pinpadResult.CardName = this.GetCardName();
				base.Clear();
				if (this.Kkt != null)
				{
					this.PrintSlipDocument(pinpadResult.Cheque, 4);
				}
			}
			SBRFPinpad._controlfp(589855, 1048575);
			return pinpadResult;
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x001639CC File Offset: 0x00161BCC
		private void PrintSlipDocument(string cheque, int footerRows)
		{
			string text = cheque.Replace("~S", "");
			int? kkt = this.Kkt;
			if (!(kkt.GetValueOrDefault() == -1 & kkt != null))
			{
				string[] array = text.Split(new char[]
				{
					'\r',
					'\n'
				});
				OfflineData.Instance.Employee.Kkt.OpenConnection();
				foreach (string value in array)
				{
					if (!string.IsNullOrEmpty(value))
					{
						OfflineData.Instance.Employee.Kkt.PrintString(value);
					}
				}
				for (int j = 0; j < footerRows; j++)
				{
					OfflineData.Instance.Employee.Kkt.PrintString("");
				}
				OfflineData.Instance.Employee.Kkt.CloseConnection();
				return;
			}
			SlipReport slipReport = new SlipReport();
			slipReport.SetSlip(cheque);
			XtraReport xtraReport = new XtraReport();
			xtraReport.DataSource = new List<SlipReport>
			{
				slipReport
			};
			xtraReport.ShowPreview();
			xtraReport.PrintDialog();
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x00163ADC File Offset: 0x00161CDC
		public IPinpadResult Refund(decimal amount)
		{
			PinpadResult pinpadResult = new PinpadResult();
			base.Clear();
			this.SetAmount(amount);
			pinpadResult.ErrorCode = this.Refund();
			if (pinpadResult.ErrorCode == 0)
			{
				pinpadResult.PinpadId = this.PinpadId;
				pinpadResult.Amount = amount;
				pinpadResult.Cheque = this.GetCheque();
				pinpadResult.TermNum = this.GetTermNum();
				pinpadResult.ClientCard = this.GetClientCard();
				pinpadResult.ClientExpiryDate = this.GetClientExpiryDate();
				pinpadResult.AuthCode = this.GetAuthCode();
				pinpadResult.CardName = this.GetCardName();
				base.Clear();
				if (this.Kkt != null)
				{
					this.PrintSlipDocument(pinpadResult.Cheque, 4);
				}
			}
			SBRFPinpad._controlfp(589855, 1048575);
			return pinpadResult;
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00163BA0 File Offset: 0x00161DA0
		public override bool PinpadReady()
		{
			bool result = base.PinpadReady();
			base.Clear();
			SBRFPinpad._controlfp(589855, 1048575);
			return result;
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x00163BCC File Offset: 0x00161DCC
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x00163BE0 File Offset: 0x00161DE0
		public int PinpadId
		{
			[CompilerGenerated]
			get
			{
				return this.<PinpadId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PinpadId>k__BackingField = value;
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x00163BF4 File Offset: 0x00161DF4
		// (set) Token: 0x0600528A RID: 21130 RVA: 0x00163C08 File Offset: 0x00161E08
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
				this.<OfficeId>k__BackingField = value;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x00163C1C File Offset: 0x00161E1C
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x00163C30 File Offset: 0x00161E30
		public double Fee
		{
			[CompilerGenerated]
			get
			{
				return this.<Fee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Fee>k__BackingField = value;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x00163C44 File Offset: 0x00161E44
		// (set) Token: 0x0600528E RID: 21134 RVA: 0x00163C58 File Offset: 0x00161E58
		public bool FeeMode
		{
			[CompilerGenerated]
			get
			{
				return this.<FeeMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<FeeMode>k__BackingField = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x00163C6C File Offset: 0x00161E6C
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x00163C80 File Offset: 0x00161E80
		public string Name
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

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x00163C94 File Offset: 0x00161E94
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x00163CA8 File Offset: 0x00161EA8
		public int? Kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<Kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Kkt>k__BackingField = value;
			}
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00163CBC File Offset: 0x00161EBC
		public bool ZOrder()
		{
			base.Clear();
			int num = this.ZReport();
			if (this.Kkt != null && num == 0)
			{
				string cheque = this.GetCheque();
				this.PrintSlipDocument(cheque, 4);
			}
			SBRFPinpad._controlfp(589855, 1048575);
			return num == 0;
		}

		// Token: 0x04003671 RID: 13937
		private const int _RC_NEAR = 0;

		// Token: 0x04003672 RID: 13938
		private const int _PC_53 = 65536;

		// Token: 0x04003673 RID: 13939
		private const int _EM_INVALID = 16;

		// Token: 0x04003674 RID: 13940
		private const int _EM_UNDERFLOW = 2;

		// Token: 0x04003675 RID: 13941
		private const int _EM_ZERODIVIDE = 8;

		// Token: 0x04003676 RID: 13942
		private const int _EM_OVERFLOW = 4;

		// Token: 0x04003677 RID: 13943
		private const int _EM_INEXACT = 1;

		// Token: 0x04003678 RID: 13944
		private const int _EM_DENORMAL = 524288;

		// Token: 0x04003679 RID: 13945
		private const int _CW_DEFAULT = 589855;

		// Token: 0x0400367A RID: 13946
		[CompilerGenerated]
		private int <PinpadId>k__BackingField;

		// Token: 0x0400367B RID: 13947
		[CompilerGenerated]
		private int <OfficeId>k__BackingField;

		// Token: 0x0400367C RID: 13948
		[CompilerGenerated]
		private double <Fee>k__BackingField;

		// Token: 0x0400367D RID: 13949
		[CompilerGenerated]
		private bool <FeeMode>k__BackingField;

		// Token: 0x0400367E RID: 13950
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x0400367F RID: 13951
		[CompilerGenerated]
		private int? <Kkt>k__BackingField;
	}
}
