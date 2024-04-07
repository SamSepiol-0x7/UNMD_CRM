using System;
using System.Windows.Input;
using DevExpress.Xpf.Editors;

namespace ASC.Extensions
{
	// Token: 0x02000B50 RID: 2896
	public class ComboBoxEditSmart : ComboBoxEdit
	{
		// Token: 0x06005141 RID: 20801 RVA: 0x0015D0C4 File Offset: 0x0015B2C4
		public ComboBoxEditSmart()
		{
			base.PreviewMouseLeftButtonDown += this.OnPreviewMouseLeftButtonDown;
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x00067738 File Offset: 0x00065938
		private void OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			ComboBoxEdit comboBoxEdit = sender as ComboBoxEdit;
			if (comboBoxEdit != null)
			{
				comboBoxEdit.IsPopupOpen = true;
			}
		}
	}
}
