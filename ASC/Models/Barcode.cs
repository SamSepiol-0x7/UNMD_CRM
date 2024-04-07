using System;

namespace ASC.Models
{
	// Token: 0x020009E1 RID: 2529
	public class Barcode
	{
		// Token: 0x06004B8F RID: 19343 RVA: 0x000046B4 File Offset: 0x000028B4
		public Barcode()
		{
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x00133980 File Offset: 0x00131B80
		public Barcode(Barcode.Types type)
		{
			this.Type = (int)type;
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x0013399C File Offset: 0x00131B9C
		public string GenerateCode(int itemId)
		{
			string text = string.Format("{0:D8}", itemId);
			return string.Format("{0}{1}{2}{3}", new object[]
			{
				"01",
				this.Type,
				text,
				"2"
			});
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x001339EC File Offset: 0x00131BEC
		public static int GetTypeFromCode(string code)
		{
			int result;
			if (int.TryParse(code.Substring(2, 1), out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x00133A10 File Offset: 0x00131C10
		public static int GetIdFromCode(string code)
		{
			int result;
			if (int.TryParse(code.Substring(code.Length - 9, 8), out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x00133A3C File Offset: 0x00131C3C
		public static bool IsAscCode(string code)
		{
			if (code.Length < 12)
			{
				return false;
			}
			string b = code.Substring(0, 2);
			string b2 = code.Substring(code.Length - 1, 1);
			return "01" == b && "2" == b2;
		}

		// Token: 0x040030B5 RID: 12469
		private const string _prefix = "01";

		// Token: 0x040030B6 RID: 12470
		private const string _lastDigit = "2";

		// Token: 0x040030B7 RID: 12471
		public int Type;

		// Token: 0x040030B8 RID: 12472
		public const int BarcodeLength = 12;

		// Token: 0x020009E2 RID: 2530
		public enum Types
		{
			// Token: 0x040030BA RID: 12474
			StoreItem = 1,
			// Token: 0x040030BB RID: 12475
			Repair,
			// Token: 0x040030BC RID: 12476
			Cartridge,
			// Token: 0x040030BD RID: 12477
			ArrivalDoc,
			// Token: 0x040030BE RID: 12478
			SaleDoc,
			// Token: 0x040030BF RID: 12479
			InternalRelocation
		}
	}
}
