using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using Atol.Drivers10.Fptr;
using Autofac;

namespace ASC.Extensions.KKT
{
	// Token: 0x02000BA7 RID: 2983
	public class AtolKkt : KktBase, IKKT
	{
		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x060053A2 RID: 21410 RVA: 0x00165E3C File Offset: 0x0016403C
		// (set) Token: 0x060053A3 RID: 21411 RVA: 0x00165E50 File Offset: 0x00164050
		public int? OfficeId
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

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x00165E64 File Offset: 0x00164064
		// (set) Token: 0x060053A5 RID: 21413 RVA: 0x00165E78 File Offset: 0x00164078
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

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x00165E8C File Offset: 0x0016408C
		// (set) Token: 0x060053A7 RID: 21415 RVA: 0x00165EA0 File Offset: 0x001640A0
		public string Ip
		{
			[CompilerGenerated]
			get
			{
				return this.<Ip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ip>k__BackingField = value;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x00165EB4 File Offset: 0x001640B4
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x00165EC8 File Offset: 0x001640C8
		public int? Port
		{
			[CompilerGenerated]
			get
			{
				return this.<Port>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Port>k__BackingField = value;
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x060053AA RID: 21418 RVA: 0x00165EDC File Offset: 0x001640DC
		// (set) Token: 0x060053AB RID: 21419 RVA: 0x00165EF0 File Offset: 0x001640F0
		public int TaxType
		{
			[CompilerGenerated]
			get
			{
				return this.<TaxType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TaxType>k__BackingField = value;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x00165F04 File Offset: 0x00164104
		// (set) Token: 0x060053AD RID: 21421 RVA: 0x00165F18 File Offset: 0x00164118
		public int Tax
		{
			[CompilerGenerated]
			get
			{
				return this.<Tax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Tax>k__BackingField = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x00165F2C File Offset: 0x0016412C
		// (set) Token: 0x060053AF RID: 21423 RVA: 0x00165F40 File Offset: 0x00164140
		public bool RSimple
		{
			[CompilerGenerated]
			get
			{
				return this.<RSimple>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RSimple>k__BackingField = value;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x060053B0 RID: 21424 RVA: 0x00165F54 File Offset: 0x00164154
		// (set) Token: 0x060053B1 RID: 21425 RVA: 0x00165F68 File Offset: 0x00164168
		public bool SSimple
		{
			[CompilerGenerated]
			get
			{
				return this.<SSimple>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SSimple>k__BackingField = value;
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x060053B2 RID: 21426 RVA: 0x00165F7C File Offset: 0x0016417C
		// (set) Token: 0x060053B3 RID: 21427 RVA: 0x00165F90 File Offset: 0x00164190
		public string Footer
		{
			[CompilerGenerated]
			get
			{
				return this.<Footer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Footer>k__BackingField = value;
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x00165FA4 File Offset: 0x001641A4
		// (set) Token: 0x060053B5 RID: 21429 RVA: 0x00165FB8 File Offset: 0x001641B8
		public string OperatorFio
		{
			[CompilerGenerated]
			get
			{
				return this.<OperatorFio>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OperatorFio>k__BackingField = value;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x060053B6 RID: 21430 RVA: 0x00165FCC File Offset: 0x001641CC
		// (set) Token: 0x060053B7 RID: 21431 RVA: 0x00165FE0 File Offset: 0x001641E0
		public string OperatorInn
		{
			[CompilerGenerated]
			get
			{
				return this.<OperatorInn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OperatorInn>k__BackingField = value;
			}
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00165FF4 File Offset: 0x001641F4
		public void InitDriver()
		{
			try
			{
				this._fptr = new Fptr();
			}
			catch (Exception ex)
			{
				KktBase.Log.Error(ex, ex.Message);
			}
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00166034 File Offset: 0x00164234
		public void ShowSettings()
		{
			this._fptr.showProperties(0, (IntPtr)0);
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00166054 File Offset: 0x00164254
		public void AddItem(int quantity, decimal price, string name, int paymentItemSign)
		{
			this._fptr.setParam(65631, name);
			this._fptr.setParam(65632, (double)price);
			this._fptr.setParam(65633, (double)quantity);
			this._fptr.setParam(65569, (double)this.Tax);
			this._fptr.setParam(1212, (double)paymentItemSign);
			this._fptr.registration();
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x001660D4 File Offset: 0x001642D4
		public IAscResult OpenSaleCheck()
		{
			Result result = new Result();
			this.OpenConnection();
			this.OperatorLogin();
			if (!string.IsNullOrEmpty(this._emailOrTel))
			{
				this.SetEmailOrTel(this._emailOrTel);
			}
			try
			{
				this.OpenCheck(false);
				result.SetSuccess();
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00166140 File Offset: 0x00164340
		public void OpenSaleReturn()
		{
			this.OpenConnection();
			this.OperatorLogin();
			if (!string.IsNullOrEmpty(this._emailOrTel))
			{
				this.SetEmailOrTel(this._emailOrTel);
			}
			this.OpenCheck(true);
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0016617C File Offset: 0x0016437C
		public void OpenCheck(bool isReturn = false)
		{
			int num = (!isReturn) ? 1 : 2;
			this._fptr.setParam(65545, (double)num);
			this._fptr.openReceipt();
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x001661B0 File Offset: 0x001643B0
		private void OperatorLogin()
		{
			this._fptr.setParam(1021, "Кассир " + this.OperatorFio);
			this._fptr.setParam(1203, this.OperatorInn);
			this._fptr.operatorLogin();
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00166200 File Offset: 0x00164400
		public bool OpenConnection()
		{
			if (!this._fptr.isOpened())
			{
				this._fptr.open();
			}
			return this._fptr.isOpened();
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00166234 File Offset: 0x00164434
		private void SetTotal(decimal summ)
		{
			this._fptr.setParam(65613, (double)summ);
			this._fptr.receiptTotal();
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x00166264 File Offset: 0x00164464
		private void Payment(decimal summ)
		{
			int num = (!this._cardPayment) ? 0 : 1;
			this._fptr.setParam(65564, (double)num);
			this._fptr.setParam(65565, (double)summ);
			this._fptr.payment();
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x001662B4 File Offset: 0x001644B4
		public bool CloseCheck(decimal summ, bool card)
		{
			this._cardPayment = card;
			this.SetTotal(summ);
			this.Payment(summ);
			this._fptr.closeReceipt();
			this._fptr.cut();
			if (this._fptr.checkDocumentClosed() >= 0)
			{
				this.CloseConnection();
				return true;
			}
			return false;
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00166308 File Offset: 0x00164508
		private void SetEmailOrTel(string emailOrTel)
		{
			this._fptr.setParam(65572, true);
			this._fptr.setParam(1008, emailOrTel);
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00166338 File Offset: 0x00164538
		public Task<IAscResult> RepairCheck(int repairId, int cashOrderId, string customerEmail)
		{
			AtolKkt.<RepairCheck>d__59 <RepairCheck>d__;
			<RepairCheck>d__.<>t__builder = AsyncTaskMethodBuilder<IAscResult>.Create();
			<RepairCheck>d__.<>4__this = this;
			<RepairCheck>d__.repairId = repairId;
			<RepairCheck>d__.cashOrderId = cashOrderId;
			<RepairCheck>d__.customerEmail = customerEmail;
			<RepairCheck>d__.<>1__state = -1;
			<RepairCheck>d__.<>t__builder.Start<AtolKkt.<RepairCheck>d__59>(ref <RepairCheck>d__);
			return <RepairCheck>d__.<>t__builder.Task;
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00166394 File Offset: 0x00164594
		private void CancellCheckIfDocumentNotClosed()
		{
			if (!this.DocumentClosed())
			{
				this._fptr.cancelReceipt();
			}
			this.CloseConnection();
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x001663BC File Offset: 0x001645BC
		private bool DocumentClosed()
		{
			return this._fptr.getParamBool(65644);
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x001663DC File Offset: 0x001645DC
		public IAscResult RepairCheck(IEnumerable<ICartridgeCard> cartridges, IEnumerable<int> cashOrderIds, string customerEmail, int paymentS)
		{
			this._emailOrTel = customerEmail;
			Result result = new Result();
			this.OpenSaleCheck();
			decimal num = 0m;
			foreach (ICartridgeCard cartridgeCard in cartridges)
			{
				CartridgeEx cartridgeEx = cartridgeCard as CartridgeEx;
				if (cartridgeEx != null)
				{
					decimal total = cartridgeEx.Total;
					string name = string.Concat(new string[]
					{
						Lang.t("Repair"),
						" ",
						cartridgeEx.MakerName,
						" ",
						cartridgeEx.Name
					});
					this.AddItem(1, total, name, base.OrderPaymentItemSign);
					num += total;
				}
			}
			if (this.CloseCheck(num, paymentS == -1))
			{
				result.SetSuccess();
				if (this.DocumentPrinted())
				{
					uint fiscalDocumentNumber = this.GetFiscalDocumentNumber();
					if (fiscalDocumentNumber <= 0U || !cashOrderIds.Any<int>())
					{
						return result;
					}
					using (IEnumerator<int> enumerator2 = cashOrderIds.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							int orderId = enumerator2.Current;
							KktBase.SetOrderFiscalDocumentNumber(orderId, fiscalDocumentNumber, base.OrderPaymentItemSign);
						}
						return result;
					}
				}
				if (this._fptr.continuePrint() < 0)
				{
					result.Message = "Не удалось напечатать документ (Ошибка \"" + this._fptr.errorDescription() + "\"). Устраните неполадку и повторите.";
				}
			}
			else
			{
				result.Message = this.GetResultDescription();
				this.CancellCheckIfDocumentNotClosed();
			}
			return result;
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x0016655C File Offset: 0x0016475C
		public IAscResult SaleCheck(IItemsDocument document)
		{
			this._emailOrTel = document.CustomerEmail;
			Result result = new Result();
			this.OpenSaleCheck();
			decimal num = 0m;
			List<store_sales> result2 = DocumentsModel.LoadSales(document.Id).Result;
			if (this.SSimple)
			{
				using (List<store_sales>.Enumerator enumerator = result2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						store_sales store_sales = enumerator.Current;
						this.AddItem(store_sales.count, store_sales.price, base.ConstructSaleItemName(store_sales), base.ProductPaymentItemSign);
						num += store_sales.PriceSumm;
					}
					goto IL_F1;
				}
			}
			foreach (store_sales store_sales2 in result2)
			{
				this.AddItem(store_sales2.count, store_sales2.price, store_sales2.name, base.ProductPaymentItemSign);
				num += store_sales2.PriceSumm;
			}
			IL_F1:
			if (this.CloseCheck(num, document.PaymentSystem == -1))
			{
				result.SetSuccess();
				this.CheckIfPrintedAndGetFiscalDocumentNumber(result, document.CashOrderId, base.ProductPaymentItemSign);
			}
			else
			{
				result.Message = this.GetResultDescription();
				this.CancellCheckIfDocumentNotClosed();
			}
			return result;
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x001666B8 File Offset: 0x001648B8
		public IAscResult PkoCheck(ICashOrder order)
		{
			this._emailOrTel = order.CustomerEmail;
			Result result = new Result();
			decimal num = order.Summ;
			if (order.CardFee > 0m)
			{
				num += order.CardFee;
			}
			this.OpenSaleCheck();
			this.AddItem(1, num, order.Reason, order.PaymentItemSign ?? 1);
			if (!this.CloseCheck(num, order.PaymentSystem == -1))
			{
				result.Message = this.GetResultDescription();
				this.CancellCheckIfDocumentNotClosed();
			}
			else
			{
				result.SetSuccess();
				this.CheckIfPrintedAndGetFiscalDocumentNumber(result, order.Id, order.PaymentItemSign ?? 1);
			}
			return result;
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x00166780 File Offset: 0x00164980
		public IAscResult PkoCheckReturn(ICashOrder order)
		{
			this._emailOrTel = order.CustomerEmail;
			Result result = new Result();
			decimal num = Math.Abs(order.Summ);
			if (order.CardFee > 0m)
			{
				num += order.CardFee;
			}
			this.OpenSaleReturn();
			this.AddItem(1, num, order.Reason, order.PaymentItemSign ?? 1);
			if (!this.CloseCheck(num, order.PaymentSystem == -1))
			{
				result.Message = this.GetResultDescription();
				this.CancellCheckIfDocumentNotClosed();
			}
			else
			{
				result.SetSuccess();
				this.CheckIfPrintedAndGetFiscalDocumentNumber(result, order.Id, order.PaymentItemSign ?? 1);
			}
			return result;
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x0016684C File Offset: 0x00164A4C
		private void CheckIfPrintedAndGetFiscalDocumentNumber(Result result, int cashOrderId, int orderPaymentItemSign)
		{
			if (this.DocumentPrinted())
			{
				uint fiscalDocumentNumber = this.GetFiscalDocumentNumber();
				if (fiscalDocumentNumber > 0U && cashOrderId > 0)
				{
					KktBase.SetOrderFiscalDocumentNumber(cashOrderId, fiscalDocumentNumber, orderPaymentItemSign);
					return;
				}
			}
			else if (this._fptr.continuePrint() < 0)
			{
				result.Message = "Не удалось напечатать документ (Ошибка \"" + this._fptr.errorDescription() + "\"). Устраните неполадку и повторите.";
			}
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x001668A8 File Offset: 0x00164AA8
		public uint GetFiscalDocumentNumber()
		{
			this._fptr.setParam(65622, 5U);
			this._fptr.fnQueryData();
			return this._fptr.getParamInt(65598);
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x001668E4 File Offset: 0x00164AE4
		public void PrintString(string value)
		{
			this._fptr.setParam(65536, value);
			this._fptr.printText();
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x00166910 File Offset: 0x00164B10
		public bool DocumentPrinted()
		{
			return this._fptr.getParamBool(65709);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00166930 File Offset: 0x00164B30
		public void ZOrder()
		{
			this.OpenConnection();
			this.OperatorLogin();
			this._fptr.setParam(65546, 0U);
			this._fptr.report();
			this._fptr.checkDocumentClosed();
			this.CloseConnection();
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x0016697C File Offset: 0x00164B7C
		public void XOrder()
		{
			this.OpenConnection();
			this.OperatorLogin();
			this._fptr.setParam(65546, 1U);
			this._fptr.report();
			this.CloseConnection();
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x001669BC File Offset: 0x00164BBC
		public string GetKktSn()
		{
			this.OpenConnection();
			this._fptr.setParam(65587, 0U);
			this._fptr.queryData();
			string paramString = this._fptr.getParamString(65559);
			this.CloseConnection();
			return paramString;
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00166A04 File Offset: 0x00164C04
		public int? GetKktResult()
		{
			Fptr fptr = this._fptr;
			if (fptr == null)
			{
				return null;
			}
			return new int?(fptr.errorCode());
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x00166A30 File Offset: 0x00164C30
		public string GetResultDescription()
		{
			Fptr fptr = this._fptr;
			if (fptr == null)
			{
				return null;
			}
			return fptr.errorDescription();
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00166A50 File Offset: 0x00164C50
		public void CloseConnection()
		{
			this._fptr.close();
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x00166A6C File Offset: 0x00164C6C
		public bool IsShiftOpened()
		{
			this.OpenConnection();
			this._fptr.setParam(65587, 14U);
			this._fptr.queryData();
			int paramInt = (int)this._fptr.getParamInt(65592);
			this.CloseConnection();
			return paramInt != 0;
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x00166AB8 File Offset: 0x00164CB8
		public AtolKkt()
		{
		}

		// Token: 0x0400370A RID: 14090
		private Fptr _fptr;

		// Token: 0x0400370B RID: 14091
		[CompilerGenerated]
		private int? <OfficeId>k__BackingField;

		// Token: 0x0400370C RID: 14092
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x0400370D RID: 14093
		[CompilerGenerated]
		private string <Ip>k__BackingField;

		// Token: 0x0400370E RID: 14094
		[CompilerGenerated]
		private int? <Port>k__BackingField;

		// Token: 0x0400370F RID: 14095
		[CompilerGenerated]
		private int <TaxType>k__BackingField;

		// Token: 0x04003710 RID: 14096
		[CompilerGenerated]
		private int <Tax>k__BackingField;

		// Token: 0x04003711 RID: 14097
		[CompilerGenerated]
		private bool <RSimple>k__BackingField;

		// Token: 0x04003712 RID: 14098
		[CompilerGenerated]
		private bool <SSimple>k__BackingField;

		// Token: 0x04003713 RID: 14099
		[CompilerGenerated]
		private string <Footer>k__BackingField;

		// Token: 0x04003714 RID: 14100
		[CompilerGenerated]
		private string <OperatorFio>k__BackingField;

		// Token: 0x04003715 RID: 14101
		[CompilerGenerated]
		private string <OperatorInn>k__BackingField;

		// Token: 0x04003716 RID: 14102
		private bool _cardPayment;

		// Token: 0x04003717 RID: 14103
		private string _emailOrTel;

		// Token: 0x02000BA8 RID: 2984
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RepairCheck>d__59 : IAsyncStateMachine
		{
			// Token: 0x060053D7 RID: 21463 RVA: 0x00166ACC File Offset: 0x00164CCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AtolKkt atolKkt = this.<>4__this;
				IAscResult result4;
				try
				{
					TaskAwaiter<RepairPaymentInfo> awaiter;
					TaskAwaiter<decimal> awaiter2;
					TaskAwaiter<string> awaiter3;
					TaskAwaiter<List<works>> awaiter4;
					TaskAwaiter<List<store_int_reserve>> awaiter5;
					switch (num)
					{
					case 0:
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<RepairPaymentInfo>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
						break;
					}
					case 1:
					{
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
						goto IL_184;
					}
					case 2:
					{
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<string>);
						int num4 = -1;
						num = -1;
						this.<>1__state = num4;
						goto IL_21A;
					}
					case 3:
					{
						awaiter4 = this.<>u__4;
						this.<>u__4 = default(TaskAwaiter<List<works>>);
						int num5 = -1;
						num = -1;
						this.<>1__state = num5;
						goto IL_29E;
					}
					case 4:
					{
						awaiter5 = this.<>u__5;
						this.<>u__5 = default(TaskAwaiter<List<store_int_reserve>>);
						int num6 = -1;
						num = -1;
						this.<>1__state = num6;
						goto IL_373;
					}
					default:
						atolKkt._emailOrTel = this.customerEmail;
						this.<result>5__2 = new Result();
						atolKkt.OpenSaleCheck();
						this.<total>5__3 = 0m;
						awaiter = Bootstrapper.Container.Resolve<IWorkshopService>().GetRepairPaymentInfo(this.repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 0;
							num = 0;
							this.<>1__state = num7;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RepairPaymentInfo>, AtolKkt.<RepairCheck>d__59>(ref awaiter, ref this);
							return;
						}
						break;
					}
					RepairPaymentInfo result = awaiter.GetResult();
					this.<repair>5__4 = result;
					if (!atolKkt.RSimple && !(this.<repair>5__4.PrepaidAmount > 0m))
					{
						awaiter4 = RepairModel.LoadWorks(this.repairId).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							int num8 = 3;
							num = 3;
							this.<>1__state = num8;
							this.<>u__4 = awaiter4;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<works>>, AtolKkt.<RepairCheck>d__59>(ref awaiter4, ref this);
							return;
						}
						goto IL_29E;
					}
					else
					{
						awaiter2 = RepairModel.GetRepairCostTotal(this.repairId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num9 = 1;
							num = 1;
							this.<>1__state = num9;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, AtolKkt.<RepairCheck>d__59>(ref awaiter2, ref this);
							return;
						}
					}
					IL_184:
					decimal result2 = awaiter2.GetResult();
					this.<total>5__3 = result2;
					this.<total>5__3 -= this.<repair>5__4.PrepaidAmount;
					this.<>7__wrap4 = this.<total>5__3;
					awaiter3 = atolKkt.ConstructKkmReason(this.repairId).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						int num10 = 2;
						num = 2;
						this.<>1__state = num10;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, AtolKkt.<RepairCheck>d__59>(ref awaiter3, ref this);
						return;
					}
					IL_21A:
					string result3 = awaiter3.GetResult();
					atolKkt.AddItem(1, this.<>7__wrap4, result3, atolKkt.OrderPaymentItemSign);
					if (this.<repair>5__4.PrepaidAmount > 0m)
					{
						atolKkt.PrintString(string.Format("{0}: {1:N2}", Lang.t("AlreadyPayed"), this.<repair>5__4.PrepaidAmount));
						goto IL_3E8;
					}
					goto IL_3E8;
					IL_29E:
					List<works>.Enumerator enumerator = awaiter4.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							works works = enumerator.Current;
							this.<total>5__3 += works.price;
							atolKkt.AddItem(1, works.price, works.name, atolKkt.OrderPaymentItemSign);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					if (Auth.Config.parts_included)
					{
						goto IL_3E8;
					}
					awaiter5 = RepairModel.LoadParts(this.repairId).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						int num11 = 4;
						num = 4;
						this.<>1__state = num11;
						this.<>u__5 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_int_reserve>>, AtolKkt.<RepairCheck>d__59>(ref awaiter5, ref this);
						return;
					}
					IL_373:
					List<store_int_reserve>.Enumerator enumerator2 = awaiter5.GetResult().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							store_int_reserve store_int_reserve = enumerator2.Current;
							this.<total>5__3 += store_int_reserve.Summ;
							atolKkt.AddItem(store_int_reserve.count, store_int_reserve.price, store_int_reserve.store_items.name, atolKkt.OrderPaymentItemSign);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator2).Dispose();
						}
					}
					IL_3E8:
					if (atolKkt.CloseCheck(this.<total>5__3, this.<repair>5__4.PaymentSystemId == -1))
					{
						this.<result>5__2.SetSuccess();
						this.<result>5__2.AddId(this.cashOrderId);
						atolKkt.CheckIfPrintedAndGetFiscalDocumentNumber(this.<result>5__2, this.cashOrderId, atolKkt.OrderPaymentItemSign);
					}
					else
					{
						this.<result>5__2.Message = atolKkt.GetResultDescription();
						atolKkt.CancellCheckIfDocumentNotClosed();
					}
					result4 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<repair>5__4 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<repair>5__4 = null;
				this.<>t__builder.SetResult(result4);
			}

			// Token: 0x060053D8 RID: 21464 RVA: 0x00166FC8 File Offset: 0x001651C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003718 RID: 14104
			public int <>1__state;

			// Token: 0x04003719 RID: 14105
			public AsyncTaskMethodBuilder<IAscResult> <>t__builder;

			// Token: 0x0400371A RID: 14106
			public AtolKkt <>4__this;

			// Token: 0x0400371B RID: 14107
			public string customerEmail;

			// Token: 0x0400371C RID: 14108
			public int repairId;

			// Token: 0x0400371D RID: 14109
			public int cashOrderId;

			// Token: 0x0400371E RID: 14110
			private Result <result>5__2;

			// Token: 0x0400371F RID: 14111
			private decimal <total>5__3;

			// Token: 0x04003720 RID: 14112
			private RepairPaymentInfo <repair>5__4;

			// Token: 0x04003721 RID: 14113
			private TaskAwaiter<RepairPaymentInfo> <>u__1;

			// Token: 0x04003722 RID: 14114
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x04003723 RID: 14115
			private decimal <>7__wrap4;

			// Token: 0x04003724 RID: 14116
			private TaskAwaiter<string> <>u__3;

			// Token: 0x04003725 RID: 14117
			private TaskAwaiter<List<works>> <>u__4;

			// Token: 0x04003726 RID: 14118
			private TaskAwaiter<List<store_int_reserve>> <>u__5;
		}
	}
}
