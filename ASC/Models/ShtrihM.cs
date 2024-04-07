using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Extensions.KKT;
using ASC.Objects;
using DrvFRLib;

namespace ASC.Models
{
	// Token: 0x02000987 RID: 2439
	public class ShtrihM : KktBase, IKKT
	{
		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x00125A3C File Offset: 0x00123C3C
		// (set) Token: 0x060049E9 RID: 18921 RVA: 0x00125A50 File Offset: 0x00123C50
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

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x00125A64 File Offset: 0x00123C64
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x00125A78 File Offset: 0x00123C78
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

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x00125A8C File Offset: 0x00123C8C
		// (set) Token: 0x060049ED RID: 18925 RVA: 0x00125AA0 File Offset: 0x00123CA0
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

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060049EE RID: 18926 RVA: 0x00125AB4 File Offset: 0x00123CB4
		// (set) Token: 0x060049EF RID: 18927 RVA: 0x00125AC8 File Offset: 0x00123CC8
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

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060049F0 RID: 18928 RVA: 0x00125ADC File Offset: 0x00123CDC
		// (set) Token: 0x060049F1 RID: 18929 RVA: 0x00125AF0 File Offset: 0x00123CF0
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

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x060049F2 RID: 18930 RVA: 0x00125B04 File Offset: 0x00123D04
		// (set) Token: 0x060049F3 RID: 18931 RVA: 0x00125B18 File Offset: 0x00123D18
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

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x060049F4 RID: 18932 RVA: 0x00125B2C File Offset: 0x00123D2C
		// (set) Token: 0x060049F5 RID: 18933 RVA: 0x00125B40 File Offset: 0x00123D40
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

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x00125B54 File Offset: 0x00123D54
		// (set) Token: 0x060049F7 RID: 18935 RVA: 0x00125B68 File Offset: 0x00123D68
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060049F8 RID: 18936 RVA: 0x00125B7C File Offset: 0x00123D7C
		// (set) Token: 0x060049F9 RID: 18937 RVA: 0x00125B90 File Offset: 0x00123D90
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

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060049FA RID: 18938 RVA: 0x00125BA4 File Offset: 0x00123DA4
		// (set) Token: 0x060049FB RID: 18939 RVA: 0x00125BB8 File Offset: 0x00123DB8
		public int OperatorPassword
		{
			[CompilerGenerated]
			get
			{
				return this.<OperatorPassword>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OperatorPassword>k__BackingField = value;
			}
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00125BCC File Offset: 0x00123DCC
		public ShtrihM()
		{
			this.InitDriver();
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00125BE8 File Offset: 0x00123DE8
		public void InitDriver()
		{
			try
			{
				this._driver = (DrvFR)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("E187099F-8C5C-4723-8866-D8DBB6353ADE")));
			}
			catch (Exception exception)
			{
				KktBase.Log.Error(exception, "Init ShtrihM driver fail");
			}
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00125C3C File Offset: 0x00123E3C
		public void AddItem(int quantity, decimal price, string name, int paymentItemSign)
		{
			if (name.Length > 64)
			{
				name = name.Substring(0, 64);
			}
			try
			{
				this._driver.Price = price;
				this._driver.Quantity = (double)quantity;
				this._driver.Department = 1;
				this._driver.Tax1 = this.Tax;
				this._driver.PaymentTypeSign = 4;
				this._driver.PaymentItemSign = paymentItemSign;
				this._driver.StringForPrinting = name;
				this._driver.FNOperation();
			}
			catch (Exception exception)
			{
				KktBase.Log.Error(exception, "ShtrihM add item to check fail");
			}
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x00125CEC File Offset: 0x00123EEC
		public IAscResult OpenSaleCheck()
		{
			Result result = new Result();
			try
			{
				if (!this.OpenConnection())
				{
					result.Message = this.GetResultDescription();
					return result;
				}
				this._driver.Password = this.OperatorPassword;
				this._driver.CheckType = 1;
				if (this._driver.ResultCode == 0)
				{
					result.SetSuccess();
				}
				else
				{
					result.Message = this.GetResultDescription();
				}
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00125D7C File Offset: 0x00123F7C
		public bool CloseCheck(decimal summ, bool card)
		{
			bool result;
			try
			{
				this._driver.Password = this.OperatorPassword;
				this._driver.Summ1 = (card ? 0m : summ);
				this._driver.Summ2 = (card ? summ : 0m);
				this._driver.Summ3 = 0m;
				this._driver.Summ4 = 0m;
				this._driver.DiscountOnCheck = 0.0;
				this._driver.TaxType = this.TaxType;
				this._driver.Tax1 = this.Tax;
				this._driver.StringForPrinting = this.Footer;
				this._driver.FNCloseCheckEx();
				bool flag = this._driver.ResultCode == 0;
				this.CloseConnection();
				result = flag;
			}
			catch (Exception exception)
			{
				KktBase.Log.Error(exception, "Close ShtrihM check fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x00125E78 File Offset: 0x00124078
		public Task<IAscResult> RepairCheck(int repairId, int cashOrderId, string customerEmail)
		{
			ShtrihM.<RepairCheck>d__46 <RepairCheck>d__;
			<RepairCheck>d__.<>t__builder = AsyncTaskMethodBuilder<IAscResult>.Create();
			<RepairCheck>d__.<>4__this = this;
			<RepairCheck>d__.repairId = repairId;
			<RepairCheck>d__.cashOrderId = cashOrderId;
			<RepairCheck>d__.customerEmail = customerEmail;
			<RepairCheck>d__.<>1__state = -1;
			<RepairCheck>d__.<>t__builder.Start<ShtrihM.<RepairCheck>d__46>(ref <RepairCheck>d__);
			return <RepairCheck>d__.<>t__builder.Task;
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00125ED4 File Offset: 0x001240D4
		public IAscResult RepairCheck(IEnumerable<ICartridgeCard> cartridges, IEnumerable<int> cashOrderIds, string customerEmail, int paymentS)
		{
			Result result = new Result();
			IAscResult ascResult = this.OpenSaleCheck();
			if (!ascResult.IsSucces)
			{
				return ascResult;
			}
			if (!string.IsNullOrEmpty(customerEmail))
			{
				this.SetCustomerEmail(customerEmail);
			}
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
			result.Message = this.GetResultDescription();
			return result;
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00126028 File Offset: 0x00124228
		public IAscResult SaleCheck(IItemsDocument document)
		{
			Result result = new Result();
			IAscResult ascResult = this.OpenSaleCheck();
			if (!ascResult.IsSucces)
			{
				return ascResult;
			}
			if (!string.IsNullOrEmpty(document.CustomerEmail))
			{
				this.SetCustomerEmail(document.CustomerEmail);
			}
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
					goto IL_10B;
				}
			}
			foreach (store_sales store_sales2 in result2)
			{
				this.AddItem(store_sales2.count, store_sales2.price, store_sales2.name, base.ProductPaymentItemSign);
				num += store_sales2.PriceSumm;
			}
			IL_10B:
			if (this.CloseCheck(num, document.PaymentSystem == -1))
			{
				result.SetSuccess();
				this.CheckIfPrintedAndGetFiscalDocumentNumber(result, document.CashOrderId, base.ProductPaymentItemSign);
			}
			else
			{
				result.Message = this.GetResultDescription();
			}
			return result;
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00126198 File Offset: 0x00124398
		public bool SetCustomerEmail(string customerEmail)
		{
			bool result;
			try
			{
				this._driver.CustomerEmail = customerEmail;
				this._driver.FNSendCustomerEmail();
				result = (this._driver.ResultCode == 0);
			}
			catch (Exception exception)
			{
				KktBase.Log.Error(exception, "ShtrihM open check fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x001261F4 File Offset: 0x001243F4
		public IAscResult PkoCheck(ICashOrder order)
		{
			Result result = new Result();
			decimal num = order.Summ;
			if (order.CardFee > 0m)
			{
				num += order.CardFee;
			}
			IAscResult ascResult = this.OpenSaleCheck();
			if (ascResult.IsSucces)
			{
				if (!string.IsNullOrEmpty(order.CustomerEmail))
				{
					this.SetCustomerEmail(order.CustomerEmail);
				}
				this.AddItem(1, num, order.Reason, order.PaymentItemSign ?? 1);
				if (!this.CloseCheck(num, order.PaymentSystem == -1))
				{
					result.Message = this.GetResultDescription();
				}
				else
				{
					result.SetSuccess();
					this.CheckIfPrintedAndGetFiscalDocumentNumber(result, order.Id, order.PaymentItemSign ?? 1);
				}
				return result;
			}
			return ascResult;
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x001262D4 File Offset: 0x001244D4
		public IAscResult PkoCheckReturn(ICashOrder order)
		{
			string customerEmail = order.CustomerEmail;
			Result result = new Result();
			decimal num = Math.Abs(order.Summ);
			if (order.CardFee > 0m)
			{
				num += order.CardFee;
			}
			IAscResult ascResult = this.OpenSaleReturn();
			if (ascResult.IsSucces)
			{
				this.AddItem(1, num, order.Reason, order.PaymentItemSign ?? 1);
				if (this.CloseCheck(num, order.PaymentSystem == -1))
				{
					result.SetSuccess();
					this.CheckIfPrintedAndGetFiscalDocumentNumber(result, order.Id, order.PaymentItemSign ?? 1);
				}
				else
				{
					result.Message = this.GetResultDescription();
				}
				return result;
			}
			return ascResult;
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x001263A0 File Offset: 0x001245A0
		private void CheckIfPrintedAndGetFiscalDocumentNumber(Result result, int cashOrderId, int paymentItemSign)
		{
			uint fiscalDocumentNumber = this.GetFiscalDocumentNumber();
			if (fiscalDocumentNumber > 0U && cashOrderId > 0)
			{
				KktBase.SetOrderFiscalDocumentNumber(cashOrderId, fiscalDocumentNumber, paymentItemSign);
			}
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x001263C4 File Offset: 0x001245C4
		public uint GetFiscalDocumentNumber()
		{
			return (uint)this._driver.DocumentNumber;
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x001263DC File Offset: 0x001245DC
		private IAscResult OpenSaleReturn()
		{
			Result result = new Result();
			try
			{
				if (!this.OpenConnection())
				{
					result.Message = this.GetResultDescription();
					return result;
				}
				this._driver.Password = this.OperatorPassword;
				this._driver.CheckType = 2;
				if (this._driver.ResultCode != 0)
				{
					result.Message = this.GetResultDescription();
				}
				else
				{
					result.SetSuccess();
				}
			}
			catch (Exception ex)
			{
				result.Message = ex.Message;
			}
			return result;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x0012646C File Offset: 0x0012466C
		public void PrintString(string value)
		{
			this.OpenConnection();
			this._driver.StringForPrinting = value;
			this._driver.PrintString();
			this.CloseConnection();
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x001264A0 File Offset: 0x001246A0
		public void ZOrder()
		{
			this.OpenConnection();
			DrvFR driver = this._driver;
			if (driver != null)
			{
				driver.PrintReportWithCleaning();
				goto IL_41;
			}
			IL_1B:
			this.CloseConnection();
			int num = 1966013381;
			IL_26:
			switch ((num ^ 1650504357) % 3)
			{
			case 1:
				goto IL_1B;
			case 2:
				IL_41:
				num = 1870738936;
				goto IL_26;
			}
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x001264F8 File Offset: 0x001246F8
		public void XOrder()
		{
			this.OpenConnection();
			DrvFR driver = this._driver;
			if (driver != null)
			{
				driver.PrintReportWithoutCleaning();
				goto IL_41;
			}
			IL_1B:
			this.CloseConnection();
			int num = -688448485;
			IL_26:
			switch ((num ^ -1563705276) % 3)
			{
			case 0:
				IL_41:
				num = -76543190;
				goto IL_26;
			case 1:
				goto IL_1B;
			}
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x00126550 File Offset: 0x00124750
		public string GetKktSn()
		{
			string result;
			try
			{
				this.OpenConnection();
				this._driver.ReadSerialNumber();
				string serialNumber = this._driver.SerialNumber;
				this.CloseConnection();
				result = serialNumber;
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x001265A0 File Offset: 0x001247A0
		public int? GetKktResult()
		{
			DrvFR driver = this._driver;
			if (driver == null)
			{
				return null;
			}
			return new int?(driver.ResultCode);
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x001265CC File Offset: 0x001247CC
		public string GetResultDescription()
		{
			DrvFR driver = this._driver;
			if (driver == null)
			{
				return null;
			}
			return driver.ResultCodeDescription;
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x001265EC File Offset: 0x001247EC
		public bool OpenConnection()
		{
			this._driver.Connect();
			return this._driver.Connected;
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00126610 File Offset: 0x00124810
		public void CloseConnection()
		{
			this._driver.Disconnect();
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x0012662C File Offset: 0x0012482C
		public void ShowSettings()
		{
			this._driver.ShowProperties();
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x00126648 File Offset: 0x00124848
		public static Dictionary<int, string> GetTaxTypes()
		{
			return new Dictionary<int, string>
			{
				{
					1,
					"ОСНО"
				},
				{
					2,
					"УСН доход"
				},
				{
					4,
					"УСН доход минус расход"
				},
				{
					8,
					"ЕНВД"
				},
				{
					16,
					"ЕСХН"
				},
				{
					32,
					"Патентная система налогообложения"
				}
			};
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x001266A4 File Offset: 0x001248A4
		public bool IsShiftOpened()
		{
			this.OpenConnection();
			this._driver.FNGetStatus();
			bool result = this._driver.FNSessionState == 1;
			this.CloseConnection();
			return result;
		}

		// Token: 0x04002F30 RID: 12080
		[CompilerGenerated]
		private int? <OfficeId>k__BackingField;

		// Token: 0x04002F31 RID: 12081
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002F32 RID: 12082
		[CompilerGenerated]
		private string <Ip>k__BackingField;

		// Token: 0x04002F33 RID: 12083
		[CompilerGenerated]
		private int? <Port>k__BackingField;

		// Token: 0x04002F34 RID: 12084
		[CompilerGenerated]
		private int <TaxType>k__BackingField;

		// Token: 0x04002F35 RID: 12085
		[CompilerGenerated]
		private int <Tax>k__BackingField;

		// Token: 0x04002F36 RID: 12086
		[CompilerGenerated]
		private bool <RSimple>k__BackingField;

		// Token: 0x04002F37 RID: 12087
		[CompilerGenerated]
		private bool <SSimple>k__BackingField;

		// Token: 0x04002F38 RID: 12088
		[CompilerGenerated]
		private string <Footer>k__BackingField;

		// Token: 0x04002F39 RID: 12089
		[CompilerGenerated]
		private int <OperatorPassword>k__BackingField;

		// Token: 0x04002F3A RID: 12090
		private DrvFR _driver;

		// Token: 0x02000988 RID: 2440
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RepairCheck>d__46 : IAsyncStateMachine
		{
			// Token: 0x06004A15 RID: 18965 RVA: 0x001266D8 File Offset: 0x001248D8
			void IAsyncStateMachine.MoveNext()
			{
				/*
An exception occurred when decompiling this method (06004A15)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ASC.Models.ShtrihM/<RepairCheck>d__46::MoveNext()

 ---> System.Exception: Inconsistent stack size at IL_45F
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06004A16 RID: 18966 RVA: 0x00126C04 File Offset: 0x00124E04
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F3B RID: 12091
			public int <>1__state;

			// Token: 0x04002F3C RID: 12092
			public AsyncTaskMethodBuilder<IAscResult> <>t__builder;

			// Token: 0x04002F3D RID: 12093
			public ShtrihM <>4__this;

			// Token: 0x04002F3E RID: 12094
			public string customerEmail;

			// Token: 0x04002F3F RID: 12095
			public int repairId;

			// Token: 0x04002F40 RID: 12096
			public int cashOrderId;

			// Token: 0x04002F41 RID: 12097
			private Result <result>5__2;

			// Token: 0x04002F42 RID: 12098
			private decimal <total>5__3;

			// Token: 0x04002F43 RID: 12099
			private RepairPaymentInfo <repair>5__4;

			// Token: 0x04002F44 RID: 12100
			private TaskAwaiter<RepairPaymentInfo> <>u__1;

			// Token: 0x04002F45 RID: 12101
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x04002F46 RID: 12102
			private decimal <>7__wrap4;

			// Token: 0x04002F47 RID: 12103
			private TaskAwaiter<string> <>u__3;

			// Token: 0x04002F48 RID: 12104
			private TaskAwaiter<List<works>> <>u__4;

			// Token: 0x04002F49 RID: 12105
			private TaskAwaiter<List<store_int_reserve>> <>u__5;
		}
	}
}
