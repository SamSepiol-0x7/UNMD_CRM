using System;
using System.Collections.Generic;

namespace ASC.Extensions
{
	// Token: 0x02000B58 RID: 2904
	public static class Transliteration
	{
		// Token: 0x06005156 RID: 20822 RVA: 0x0015D47C File Offset: 0x0015B67C
		public static string Front(string text)
		{
			return Transliteration.Front(text, TransliterationType.ISO);
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x0015D490 File Offset: 0x0015B690
		public static string Front(string text, TransliterationType type)
		{
			string text2 = text;
			foreach (KeyValuePair<string, string> keyValuePair in Transliteration.GetDictionaryByType(type))
			{
				text2 = text2.Replace(keyValuePair.Key, keyValuePair.Value);
			}
			return text2;
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x0015D4F8 File Offset: 0x0015B6F8
		public static string Back(string text)
		{
			return Transliteration.Back(text, TransliterationType.ISO);
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x0015D50C File Offset: 0x0015B70C
		public static string Back(string text, TransliterationType type)
		{
			string text2 = text;
			foreach (KeyValuePair<string, string> keyValuePair in Transliteration.GetDictionaryByType(type))
			{
				text2 = text2.Replace(keyValuePair.Value, keyValuePair.Key);
			}
			return text2;
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x0015D574 File Offset: 0x0015B774
		private static Dictionary<string, string> GetDictionaryByType(TransliterationType type)
		{
			Dictionary<string, string> result = Transliteration.iso;
			if (type == TransliterationType.Gost)
			{
				result = Transliteration.gost;
			}
			return result;
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x0015D594 File Offset: 0x0015B794
		static Transliteration()
		{
			Transliteration.gost.Add("Є", "EH");
			Transliteration.gost.Add("І", "I");
			Transliteration.gost.Add("і", "i");
			Transliteration.gost.Add("№", "#");
			Transliteration.gost.Add("є", "eh");
			Transliteration.gost.Add("А", "A");
			Transliteration.gost.Add("Б", "B");
			Transliteration.gost.Add("В", "V");
			Transliteration.gost.Add("Г", "G");
			Transliteration.gost.Add("Д", "D");
			Transliteration.gost.Add("Е", "E");
			Transliteration.gost.Add("Ё", "JO");
			Transliteration.gost.Add("Ж", "ZH");
			Transliteration.gost.Add("З", "Z");
			Transliteration.gost.Add("И", "I");
			Transliteration.gost.Add("Й", "JJ");
			Transliteration.gost.Add("К", "K");
			Transliteration.gost.Add("Л", "L");
			Transliteration.gost.Add("М", "M");
			Transliteration.gost.Add("Н", "N");
			Transliteration.gost.Add("О", "O");
			Transliteration.gost.Add("П", "P");
			Transliteration.gost.Add("Р", "R");
			Transliteration.gost.Add("С", "S");
			Transliteration.gost.Add("Т", "T");
			Transliteration.gost.Add("У", "U");
			Transliteration.gost.Add("Ф", "F");
			Transliteration.gost.Add("Х", "KH");
			Transliteration.gost.Add("Ц", "C");
			Transliteration.gost.Add("Ч", "CH");
			Transliteration.gost.Add("Ш", "SH");
			Transliteration.gost.Add("Щ", "SHH");
			Transliteration.gost.Add("Ъ", "'");
			Transliteration.gost.Add("Ы", "Y");
			Transliteration.gost.Add("Ь", "");
			Transliteration.gost.Add("Э", "EH");
			Transliteration.gost.Add("Ю", "YU");
			Transliteration.gost.Add("Я", "YA");
			Transliteration.gost.Add("а", "a");
			Transliteration.gost.Add("б", "b");
			Transliteration.gost.Add("в", "v");
			Transliteration.gost.Add("г", "g");
			Transliteration.gost.Add("д", "d");
			Transliteration.gost.Add("е", "e");
			Transliteration.gost.Add("ё", "jo");
			Transliteration.gost.Add("ж", "zh");
			Transliteration.gost.Add("з", "z");
			Transliteration.gost.Add("и", "i");
			Transliteration.gost.Add("й", "jj");
			Transliteration.gost.Add("к", "k");
			Transliteration.gost.Add("л", "l");
			Transliteration.gost.Add("м", "m");
			Transliteration.gost.Add("н", "n");
			Transliteration.gost.Add("о", "o");
			Transliteration.gost.Add("п", "p");
			Transliteration.gost.Add("р", "r");
			Transliteration.gost.Add("с", "s");
			Transliteration.gost.Add("т", "t");
			Transliteration.gost.Add("у", "u");
			Transliteration.gost.Add("ф", "f");
			Transliteration.gost.Add("х", "kh");
			Transliteration.gost.Add("ц", "c");
			Transliteration.gost.Add("ч", "ch");
			Transliteration.gost.Add("ш", "sh");
			Transliteration.gost.Add("щ", "shh");
			Transliteration.gost.Add("ъ", "");
			Transliteration.gost.Add("ы", "y");
			Transliteration.gost.Add("ь", "");
			Transliteration.gost.Add("э", "eh");
			Transliteration.gost.Add("ю", "yu");
			Transliteration.gost.Add("я", "ya");
			Transliteration.gost.Add("«", "");
			Transliteration.gost.Add("»", "");
			Transliteration.gost.Add("—", "-");
			Transliteration.iso.Add("Є", "YE");
			Transliteration.iso.Add("І", "I");
			Transliteration.iso.Add("Ѓ", "G");
			Transliteration.iso.Add("і", "i");
			Transliteration.iso.Add("№", "#");
			Transliteration.iso.Add("є", "ye");
			Transliteration.iso.Add("ѓ", "g");
			Transliteration.iso.Add("А", "A");
			Transliteration.iso.Add("Б", "B");
			Transliteration.iso.Add("В", "V");
			Transliteration.iso.Add("Г", "G");
			Transliteration.iso.Add("Д", "D");
			Transliteration.iso.Add("Е", "E");
			Transliteration.iso.Add("Ё", "YO");
			Transliteration.iso.Add("Ж", "ZH");
			Transliteration.iso.Add("З", "Z");
			Transliteration.iso.Add("И", "I");
			Transliteration.iso.Add("Й", "J");
			Transliteration.iso.Add("К", "K");
			Transliteration.iso.Add("Л", "L");
			Transliteration.iso.Add("М", "M");
			Transliteration.iso.Add("Н", "N");
			Transliteration.iso.Add("О", "O");
			Transliteration.iso.Add("П", "P");
			Transliteration.iso.Add("Р", "R");
			Transliteration.iso.Add("С", "S");
			Transliteration.iso.Add("Т", "T");
			Transliteration.iso.Add("У", "U");
			Transliteration.iso.Add("Ф", "F");
			Transliteration.iso.Add("Х", "X");
			Transliteration.iso.Add("Ц", "C");
			Transliteration.iso.Add("Ч", "CH");
			Transliteration.iso.Add("Ш", "SH");
			Transliteration.iso.Add("Щ", "SHH");
			Transliteration.iso.Add("Ъ", "'");
			Transliteration.iso.Add("Ы", "Y");
			Transliteration.iso.Add("Ь", "");
			Transliteration.iso.Add("Э", "E");
			Transliteration.iso.Add("Ю", "YU");
			Transliteration.iso.Add("Я", "YA");
			Transliteration.iso.Add("а", "a");
			Transliteration.iso.Add("б", "b");
			Transliteration.iso.Add("в", "v");
			Transliteration.iso.Add("г", "g");
			Transliteration.iso.Add("д", "d");
			Transliteration.iso.Add("е", "e");
			Transliteration.iso.Add("ё", "yo");
			Transliteration.iso.Add("ж", "zh");
			Transliteration.iso.Add("з", "z");
			Transliteration.iso.Add("и", "i");
			Transliteration.iso.Add("й", "j");
			Transliteration.iso.Add("к", "k");
			Transliteration.iso.Add("л", "l");
			Transliteration.iso.Add("м", "m");
			Transliteration.iso.Add("н", "n");
			Transliteration.iso.Add("о", "o");
			Transliteration.iso.Add("п", "p");
			Transliteration.iso.Add("р", "r");
			Transliteration.iso.Add("с", "s");
			Transliteration.iso.Add("т", "t");
			Transliteration.iso.Add("у", "u");
			Transliteration.iso.Add("ф", "f");
			Transliteration.iso.Add("х", "x");
			Transliteration.iso.Add("ц", "c");
			Transliteration.iso.Add("ч", "ch");
			Transliteration.iso.Add("ш", "sh");
			Transliteration.iso.Add("щ", "shh");
			Transliteration.iso.Add("ъ", "");
			Transliteration.iso.Add("ы", "y");
			Transliteration.iso.Add("ь", "");
			Transliteration.iso.Add("э", "e");
			Transliteration.iso.Add("ю", "yu");
			Transliteration.iso.Add("я", "ya");
			Transliteration.iso.Add("«", "");
			Transliteration.iso.Add("»", "");
			Transliteration.iso.Add("—", "-");
			Transliteration.iso.Add(" ", "_");
		}

		// Token: 0x04003591 RID: 13713
		private static Dictionary<string, string> gost = new Dictionary<string, string>();

		// Token: 0x04003592 RID: 13714
		private static Dictionary<string, string> iso = new Dictionary<string, string>();
	}
}
