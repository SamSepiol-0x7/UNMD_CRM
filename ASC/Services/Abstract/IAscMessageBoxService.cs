using System;
using System.Windows;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F0 RID: 2032
	public interface IAscMessageBoxService
	{
		// Token: 0x06003CC6 RID: 15558
		void ShowMessageBox(string messageBoxText);

		// Token: 0x06003CC7 RID: 15559
		void ShowMessageBox(string caption, string messageBoxText);

		// Token: 0x06003CC8 RID: 15560
		MessageBoxResult ShowMessageBox(string messageBoxText, string caption, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage);
	}
}
