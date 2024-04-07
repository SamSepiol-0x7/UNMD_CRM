using System;
using System.Xml;

namespace ASC
{
	// Token: 0x02000098 RID: 152
	public class CBRF
	{
		// Token: 0x06001268 RID: 4712 RVA: 0x00022860 File Offset: 0x00020A60
		public decimal GetRate(string from, string to)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(this.baseUrl);
			while (xmlTextReader.ReadToFollowing("Valute"))
			{
				if (!(xmlTextReader.GetAttribute("ID") != "R01235"))
				{
					xmlTextReader.ReadToDescendant("Value");
					xmlTextReader.Read();
					double num;
					return (decimal)(double.TryParse(xmlTextReader.Value, out num) ? num : 0.0);
				}
			}
			return 0m;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000228D8 File Offset: 0x00020AD8
		public CBRF()
		{
		}

		// Token: 0x040008B6 RID: 2230
		private string baseUrl = "https://www.cbr.ru/scripts/XML_daily.asp";
	}
}
