using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using DevExpress.Xpf.Core;

namespace ASC.Extensions
{
	// Token: 0x02000B5C RID: 2908
	public class ColorHelper : INotifyPropertyChanged
	{
		// Token: 0x06005167 RID: 20839 RVA: 0x0015E35C File Offset: 0x0015C55C
		public ColorHelper()
		{
			ThemeManager.ThemeChanged += ColorHelper.ThemeChanged;
			this.GetColors(ThemeManager.ActualApplicationThemeName);
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x0015E38C File Offset: 0x0015C58C
		public static ColorHelper Instance
		{
			get
			{
				if (ColorHelper._Instance == null)
				{
					ColorHelper._Instance = new ColorHelper();
				}
				return ColorHelper._Instance;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06005169 RID: 20841 RVA: 0x0015E3B0 File Offset: 0x0015C5B0
		// (set) Token: 0x0600516A RID: 20842 RVA: 0x0015E3C4 File Offset: 0x0015C5C4
		public Brush Background
		{
			get
			{
				return this._Background;
			}
			set
			{
				if (this._Background != value)
				{
					this._Background = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Background);
					PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
					if (propertyChanged != null)
					{
						propertyChanged(this, new PropertyChangedEventArgs("Background"));
					}
				}
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600516B RID: 20843 RVA: 0x0015E40C File Offset: 0x0015C60C
		// (set) Token: 0x0600516C RID: 20844 RVA: 0x0015E420 File Offset: 0x0015C620
		public Brush Foreground
		{
			get
			{
				return this._Foreground;
			}
			set
			{
				if (this._Foreground != value)
				{
					for (;;)
					{
						IL_6B:
						this._Foreground = value;
						for (;;)
						{
							IL_5E:
							this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Foreground);
							for (;;)
							{
								PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
								if (propertyChanged != null)
								{
									propertyChanged(this, new PropertyChangedEventArgs("Foreground"));
									uint num;
									switch ((num = (num * 2957346911U ^ 3509742957U ^ 1323429451U)) % 7U)
									{
									case 1U:
										goto IL_6B;
									case 5U:
										continue;
									case 6U:
										goto IL_5E;
									}
									goto Block_3;
								}
								goto IL_74;
							}
						}
					}
					Block_3:
					IL_74:;
				}
			}
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x0015E4A4 File Offset: 0x0015C6A4
		public static void ThemeChanged(DependencyObject sender, ThemeChangedRoutedEventArgs e)
		{
			ColorHelper.Instance.GetColors(e.ThemeName);
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x0015E4C4 File Offset: 0x0015C6C4
		private void GetColors(string name)
		{
			if (name == "DeepBlue")
			{
				this.Background = ColorHelper.DefaultThemeBackgroundColor;
				this.Foreground = ColorHelper.DefaultThemeForegroundColor;
				return;
			}
			ThemeManager.ThemeChanged -= ColorHelper.ThemeChanged;
			BackgroundPanel backgroundPanel = new BackgroundPanel();
			ThemeManager.SetThemeName(backgroundPanel, name);
			this.Background = backgroundPanel.Background;
			this.Foreground = backgroundPanel.Foreground;
			ThemeManager.ThemeChanged += ColorHelper.ThemeChanged;
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x0600516F RID: 20847 RVA: 0x0015E53C File Offset: 0x0015C73C
		// (remove) Token: 0x06005170 RID: 20848 RVA: 0x0015E574 File Offset: 0x0015C774
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x0015E5AC File Offset: 0x0015C7AC
		// Note: this type is marked as 'beforefieldinit'.
		static ColorHelper()
		{
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x0015E5EC File Offset: 0x0015C7EC
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x04003594 RID: 13716
		private static SolidColorBrush DefaultThemeBackgroundColor = new SolidColorBrush(Color.FromRgb(163, 195, 236));

		// Token: 0x04003595 RID: 13717
		private static SolidColorBrush DefaultThemeForegroundColor = new SolidColorBrush(Color.FromRgb(0, 0, 0));

		// Token: 0x04003596 RID: 13718
		private Brush _Foreground;

		// Token: 0x04003597 RID: 13719
		private Brush _Background;

		// Token: 0x04003598 RID: 13720
		private static ColorHelper _Instance;

		// Token: 0x04003599 RID: 13721
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;
	}
}
