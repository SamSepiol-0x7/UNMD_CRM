using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;
using Poly;

namespace ASC.Objects
{
	// Token: 0x020008B1 RID: 2225
	public class UiSettings : BindableBase, IUISettings
	{
		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060043D2 RID: 17362 RVA: 0x0010A794 File Offset: 0x00108994
		// (set) Token: 0x060043D3 RID: 17363 RVA: 0x0010A7A8 File Offset: 0x001089A8
		public int FontSize
		{
			[CompilerGenerated]
			get
			{
				return this.<FontSize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FontSize>k__BackingField == value)
				{
					return;
				}
				this.<FontSize>k__BackingField = value;
				this.RaisePropertyChanged("FontSize");
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060043D4 RID: 17364 RVA: 0x0010A7D4 File Offset: 0x001089D4
		// (set) Token: 0x060043D5 RID: 17365 RVA: 0x0010A7E8 File Offset: 0x001089E8
		public int RowHeight
		{
			[CompilerGenerated]
			get
			{
				return this.<RowHeight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RowHeight>k__BackingField == value)
				{
					return;
				}
				this.<RowHeight>k__BackingField = value;
				this.RaisePropertyChanged("RowHeight");
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060043D6 RID: 17366 RVA: 0x0010A814 File Offset: 0x00108A14
		// (set) Token: 0x060043D7 RID: 17367 RVA: 0x0010A828 File Offset: 0x00108A28
		public string RowColor
		{
			[CompilerGenerated]
			get
			{
				return this.<RowColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<RowColor>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1542019319;
				IL_14:
				switch ((num ^ -774978020) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0F;
				case 3:
					IL_33:
					this.<RowColor>k__BackingField = value;
					num = -2005655188;
					goto IL_14;
				}
				this.RaisePropertyChanged("RowColor");
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x060043D8 RID: 17368 RVA: 0x0010A884 File Offset: 0x00108A84
		// (set) Token: 0x060043D9 RID: 17369 RVA: 0x0010A898 File Offset: 0x00108A98
		public string GeHighlightColor
		{
			[CompilerGenerated]
			get
			{
				return this.<GeHighlightColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<GeHighlightColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<GeHighlightColor>k__BackingField = value;
				this.RaisePropertyChanged("GeHighlightColor");
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x0010A8C8 File Offset: 0x00108AC8
		// (set) Token: 0x060043DB RID: 17371 RVA: 0x0010A8DC File Offset: 0x00108ADC
		public string IssuedRowColor
		{
			[CompilerGenerated]
			get
			{
				return this.<IssuedRowColor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<IssuedRowColor>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<IssuedRowColor>k__BackingField = value;
				this.RaisePropertyChanged("IssuedRowColor");
			}
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x0010A90C File Offset: 0x00108B0C
		public void SetSettings(IUISettings settings)
		{
			this.FontSize = settings.FontSize;
			this.RowHeight = settings.RowHeight;
			this.RowColor = settings.RowColor;
			this.IssuedRowColor = settings.IssuedRowColor;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x000069B8 File Offset: 0x00004BB8
		public UiSettings()
		{
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x0010A94C File Offset: 0x00108B4C
		public UiSettings(IEmployee e)
		{
			e.UiSettings.CopyProperties(this);
		}

		// Token: 0x04002BD6 RID: 11222
		[CompilerGenerated]
		private int <FontSize>k__BackingField;

		// Token: 0x04002BD7 RID: 11223
		[CompilerGenerated]
		private int <RowHeight>k__BackingField;

		// Token: 0x04002BD8 RID: 11224
		[CompilerGenerated]
		private string <RowColor>k__BackingField;

		// Token: 0x04002BD9 RID: 11225
		[CompilerGenerated]
		private string <GeHighlightColor>k__BackingField;

		// Token: 0x04002BDA RID: 11226
		[CompilerGenerated]
		private string <IssuedRowColor>k__BackingField;
	}
}
