using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ExcelDataReader;

namespace ASC.ItemsArrival
{
	// Token: 0x020001D4 RID: 468
	public class ItemsArrivalModel : DocumentsModel
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x0004BA94 File Offset: 0x00049C94
		public List<Product> ImportFromExcel(string fileName)
		{
			List<Product> list = new List<Product>();
			using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read))
			{
				using (IExcelDataReader excelDataReader = (Path.GetExtension(fileName).ToLower() == ".xlsx") ? ExcelReaderFactory.CreateOpenXmlReader(fileStream, null) : ExcelReaderFactory.CreateBinaryReader(fileStream, null))
				{
					DataTable dataTable = excelDataReader.AsDataSet(null).Tables[0];
					int num = 99;
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (!string.IsNullOrEmpty(dataRow[0].ToString()))
						{
							Product product = ItemsModel.DefaultItem().ToStoreItem();
							if (Auth.User.xls_c1 != num)
							{
								product.Name = this.CutString(dataRow[Auth.User.xls_c1].ToString(), 254);
							}
							if (Auth.User.xls_c2 != num)
							{
								product.InCount = Convert.ToInt32(dataRow[Auth.User.xls_c2]);
							}
							if (Auth.User.xls_c3 != num)
							{
								product.Description = dataRow[Auth.User.xls_c3].ToString();
							}
							if (Auth.User.xls_c4 != num)
							{
								product.ShopDescription = dataRow[Auth.User.xls_c4].ToString();
							}
							if (Auth.User.xls_c5 != num)
							{
								product.Pn = this.CutString(dataRow[Auth.User.xls_c5].ToString(), 254);
							}
							if (Auth.User.xls_c6 != num)
							{
								product.Sn = this.CutString(dataRow[Auth.User.xls_c6].ToString(), 254);
							}
							if (Auth.User.xls_c7 != num)
							{
								product.InPrice = Convert.ToDecimal(dataRow[Auth.User.xls_c7]);
							}
							if (Auth.User.xls_c8 != num)
							{
								product.Price2 = Convert.ToDecimal(dataRow[Auth.User.xls_c8]);
							}
							if (Auth.User.xls_c9 != num)
							{
								product.Price3 = Convert.ToDecimal(dataRow[Auth.User.xls_c9]);
							}
							if (Auth.User.xls_c10 != num)
							{
								product.Price4 = Convert.ToDecimal(dataRow[Auth.User.xls_c10]);
							}
							if (Auth.User.xls_c11 != num)
							{
								product.Price5 = Convert.ToDecimal(dataRow[Auth.User.xls_c11]);
							}
							if (Auth.User.xls_c12 != num)
							{
								product.Price = Convert.ToDecimal(dataRow[Auth.User.xls_c12]);
							}
							if (Auth.User.xls_c13 != num)
							{
								product.BoxName = this.CutString(dataRow[Auth.User.xls_c13].ToString(), 254);
							}
							if (Auth.User.xls_c14 != num)
							{
								product.ShopTitle = this.CutString(dataRow[Auth.User.xls_c14].ToString(), 254);
							}
							if (Auth.User.xls_c15 != num)
							{
								product.Notes = this.CutString(dataRow[Auth.User.xls_c15].ToString(), 254);
							}
							product.CalcInSumm();
							list.Add(product);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0004BE90 File Offset: 0x0004A090
		private string CutString(string str, int length = 254)
		{
			if (str.Length > length)
			{
				str = str.Substring(0, length);
			}
			return str;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00046334 File Offset: 0x00044534
		public ItemsArrivalModel()
		{
		}
	}
}
