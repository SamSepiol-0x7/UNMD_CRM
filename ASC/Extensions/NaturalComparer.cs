using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace ASC.Extensions
{
	// Token: 0x02000B71 RID: 2929
	public class NaturalComparer : IComparer<string>, IComparer
	{
		// Token: 0x060051EA RID: 20970 RVA: 0x0015FFAC File Offset: 0x0015E1AC
		public NaturalComparer(NaturalComparerOptions NaturalComparerOptions)
		{
			this.mNaturalComparerOptions = NaturalComparerOptions;
			this.mParser1 = new NaturalComparer.StringParser(this);
			this.mParser2 = new NaturalComparer.StringParser(this);
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x0015FFE0 File Offset: 0x0015E1E0
		public NaturalComparer() : this(NaturalComparerOptions.None)
		{
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x0015FFF4 File Offset: 0x0015E1F4
		int IComparer<string>.Compare(string string1, string string2)
		{
			this.mParser1.Init(string1);
			this.mParser2.Init(string2);
			int num;
			for (;;)
			{
				if (!(this.mParser1.TokenType == NaturalComparer.TokenType.Numerical & this.mParser2.TokenType == NaturalComparer.TokenType.Numerical))
				{
					num = string.Compare(this.mParser1.StringValue, this.mParser2.StringValue);
				}
				else
				{
					num = decimal.Compare(this.mParser1.NumericalValue, this.mParser2.NumericalValue);
				}
				if (num != 0)
				{
					break;
				}
				this.mParser1.NextToken();
				this.mParser2.NextToken();
				if (this.mParser1.TokenType == NaturalComparer.TokenType.Nothing & this.mParser2.TokenType == NaturalComparer.TokenType.Nothing)
				{
					return 0;
				}
			}
			return num;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x001600B8 File Offset: 0x0015E2B8
		private static int RomanLetterValue(char c)
		{
			if (c <= 'D')
			{
				if (c == 'C')
				{
					return 100;
				}
				if (c == 'D')
				{
					return 500;
				}
			}
			else
			{
				switch (c)
				{
				case 'I':
					return 1;
				case 'J':
				case 'K':
					break;
				case 'L':
					return 50;
				case 'M':
					return 1000;
				default:
					if (c == 'V')
					{
						return 5;
					}
					if (c == 'X')
					{
						return 10;
					}
					break;
				}
			}
			return 0;
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x0016011C File Offset: 0x0015E31C
		public int RomanValue(string string1)
		{
			this.mParser1.Init(string1);
			if (this.mParser1.TokenType != NaturalComparer.TokenType.Numerical)
			{
				return 0;
			}
			return (int)this.mParser1.NumericalValue;
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00160158 File Offset: 0x0015E358
		int IComparer.Compare(object x, object y)
		{
			return ((IComparer<string>)this).Compare((string)x, (string)y);
		}

		// Token: 0x040035BB RID: 13755
		private NaturalComparer.StringParser mParser1;

		// Token: 0x040035BC RID: 13756
		private NaturalComparer.StringParser mParser2;

		// Token: 0x040035BD RID: 13757
		private NaturalComparerOptions mNaturalComparerOptions;

		// Token: 0x02000B72 RID: 2930
		private enum TokenType
		{
			// Token: 0x040035BF RID: 13759
			Nothing,
			// Token: 0x040035C0 RID: 13760
			Numerical,
			// Token: 0x040035C1 RID: 13761
			String
		}

		// Token: 0x02000B73 RID: 2931
		private class StringParser
		{
			// Token: 0x060051F0 RID: 20976 RVA: 0x00160178 File Offset: 0x0015E378
			public StringParser(NaturalComparer naturalComparer)
			{
				this.mNaturalComparer = naturalComparer;
			}

			// Token: 0x060051F1 RID: 20977 RVA: 0x00160194 File Offset: 0x0015E394
			public void Init(string source)
			{
				if (source == null)
				{
					source = string.Empty;
				}
				this.mSource = source;
				this.mLen = source.Length;
				this.mIdx = -1;
				this.mNumericalValue = 0m;
				this.NextChar();
				this.NextToken();
			}

			// Token: 0x170014FE RID: 5374
			// (get) Token: 0x060051F2 RID: 20978 RVA: 0x001601E0 File Offset: 0x0015E3E0
			public NaturalComparer.TokenType TokenType
			{
				get
				{
					return this.mTokenType;
				}
			}

			// Token: 0x170014FF RID: 5375
			// (get) Token: 0x060051F3 RID: 20979 RVA: 0x001601F4 File Offset: 0x0015E3F4
			public decimal NumericalValue
			{
				get
				{
					if (this.mTokenType == NaturalComparer.TokenType.Numerical)
					{
						return this.mNumericalValue;
					}
					throw new NaturalComparerException("Internal Error: NumericalValue called on a non numerical value.");
				}
			}

			// Token: 0x17001500 RID: 5376
			// (get) Token: 0x060051F4 RID: 20980 RVA: 0x00160220 File Offset: 0x0015E420
			public string StringValue
			{
				get
				{
					return this.mStringValue;
				}
			}

			// Token: 0x060051F5 RID: 20981 RVA: 0x00160234 File Offset: 0x0015E434
			public void NextToken()
			{
				while (this.mCurChar != '\0')
				{
					if (char.IsDigit(this.mCurChar))
					{
						this.ParseNumericalValue();
						return;
					}
					if (char.IsLetter(this.mCurChar))
					{
						this.ParseString();
						return;
					}
					this.NextChar();
				}
				this.mTokenType = NaturalComparer.TokenType.Nothing;
				this.mStringValue = null;
			}

			// Token: 0x060051F6 RID: 20982 RVA: 0x00160288 File Offset: 0x0015E488
			private void NextChar()
			{
				this.mIdx++;
				if (this.mIdx < this.mLen)
				{
					goto IL_40;
				}
				IL_1C:
				int num = -266607093;
				IL_21:
				switch ((num ^ -836763923) % 4)
				{
				case 0:
					goto IL_1C;
				case 2:
					this.mCurChar = '\0';
					return;
				case 3:
					IL_40:
					this.mCurChar = this.mSource[this.mIdx];
					num = -605209332;
					goto IL_21;
				}
			}

			// Token: 0x060051F7 RID: 20983 RVA: 0x001602FC File Offset: 0x0015E4FC
			private void ParseNumericalValue()
			{
				int num = this.mIdx;
				char c = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
				char c2 = NumberFormatInfo.CurrentInfo.NumberGroupSeparator[0];
				do
				{
					this.NextChar();
					if (this.mCurChar == c)
					{
						goto Block_3;
					}
				}
				while (char.IsDigit(this.mCurChar) || this.mCurChar == c2);
				goto IL_75;
				Block_3:
				for (;;)
				{
					this.NextChar();
					if (!char.IsDigit(this.mCurChar))
					{
						if (this.mCurChar != c2)
						{
							break;
						}
					}
				}
				IL_75:
				this.mStringValue = this.mSource.Substring(num, this.mIdx - num);
				if (!decimal.TryParse(this.mStringValue, out this.mNumericalValue))
				{
					this.mTokenType = NaturalComparer.TokenType.String;
					return;
				}
				this.mTokenType = NaturalComparer.TokenType.Numerical;
			}

			// Token: 0x060051F8 RID: 20984 RVA: 0x001603BC File Offset: 0x0015E5BC
			private void ParseString()
			{
				int num = this.mIdx;
				bool flag = (this.mNaturalComparer.mNaturalComparerOptions & NaturalComparerOptions.RomanNumbers) > NaturalComparerOptions.None;
				int num2 = 0;
				int num3 = int.MaxValue;
				int num4 = 0;
				do
				{
					if (flag)
					{
						int num5 = NaturalComparer.RomanLetterValue(this.mCurChar);
						if (num5 <= 0)
						{
							flag = false;
						}
						else
						{
							bool flag2 = false;
							if (num5 == 1)
							{
								goto IL_77;
							}
							if (num5 == 10)
							{
								goto IL_77;
							}
							if (num5 == 100)
							{
								goto IL_77;
							}
							this.NextChar();
							IL_C1:
							if (flag2)
							{
								goto IL_2E;
							}
							if (num5 > num3)
							{
								flag = false;
								goto IL_2E;
							}
							num2 += num5;
							if (num3 != num5)
							{
								num3 = num5;
								num4 = 1;
								goto IL_2E;
							}
							num4++;
							if (num5 > 10)
							{
								if (num5 != 50)
								{
									if (num5 == 100)
									{
										goto IL_12A;
									}
									if (num5 != 500)
									{
										goto IL_2E;
									}
								}
							}
							else
							{
								if (num5 == 1)
								{
									goto IL_12A;
								}
								if (num5 != 5)
								{
									if (num5 == 10)
									{
										goto IL_12A;
									}
									goto IL_2E;
								}
							}
							if (num4 > 1)
							{
								flag = false;
								goto IL_2E;
							}
							goto IL_2E;
							IL_12A:
							if (num4 > 4)
							{
								flag = false;
								goto IL_2E;
							}
							goto IL_2E;
							IL_77:
							this.NextChar();
							int num6 = NaturalComparer.RomanLetterValue(this.mCurChar);
							if (!(num6 == num5 * 10 | num6 == num5 * 5))
							{
								goto IL_C1;
							}
							flag2 = true;
							if (num6 <= num3)
							{
								num2 += num6 - num5;
								this.NextChar();
								num3 = num5 / 10;
								num4 = 0;
								goto IL_C1;
							}
							flag = false;
							goto IL_C1;
						}
					}
					else
					{
						this.NextChar();
					}
					IL_2E:;
				}
				while (char.IsLetter(this.mCurChar));
				this.mStringValue = this.mSource.Substring(num, this.mIdx - num);
				if (flag)
				{
					this.mNumericalValue = num2;
					this.mTokenType = NaturalComparer.TokenType.Numerical;
					return;
				}
				this.mTokenType = NaturalComparer.TokenType.String;
			}

			// Token: 0x040035C2 RID: 13762
			private NaturalComparer.TokenType mTokenType;

			// Token: 0x040035C3 RID: 13763
			private string mStringValue;

			// Token: 0x040035C4 RID: 13764
			private decimal mNumericalValue;

			// Token: 0x040035C5 RID: 13765
			private int mIdx;

			// Token: 0x040035C6 RID: 13766
			private string mSource;

			// Token: 0x040035C7 RID: 13767
			private int mLen;

			// Token: 0x040035C8 RID: 13768
			private char mCurChar;

			// Token: 0x040035C9 RID: 13769
			private NaturalComparer mNaturalComparer;
		}
	}
}
