using System;

namespace ASC.Converters
{
	// Token: 0x02000BE1 RID: 3041
	public static class BytesToString
	{
		// Token: 0x060054B1 RID: 21681 RVA: 0x0016C208 File Offset: 0x0016A408
		public static string Bytes2String(long byteCount)
		{
			string[] array = new string[]
			{
				"B",
				"KB",
				"MB",
				"GB",
				"TB",
				"PB",
				"EB"
			};
			if (byteCount == 0L)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log((double)num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, (double)num2), 1);
			return ((double)Math.Sign(byteCount) * num3).ToString() + array[num2];
		}
	}
}
