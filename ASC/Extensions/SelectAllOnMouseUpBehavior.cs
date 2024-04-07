using System;
using System.Windows.Input;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Editors;

namespace ASC.Extensions
{
	// Token: 0x02000B56 RID: 2902
	public class SelectAllOnMouseUpBehavior : Behavior<TextEdit>
	{
		// Token: 0x06005152 RID: 20818 RVA: 0x0015D3A0 File Offset: 0x0015B5A0
		protected override void OnAttached()
		{
			base.OnAttached();
			base.AssociatedObject.PreviewMouseLeftButtonUp += this.AssociatedObjectOnMouseUp;
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x0015D3CC File Offset: 0x0015B5CC
		private void AssociatedObjectOnMouseUp(object sender, MouseButtonEventArgs e)
		{
			object editValue = base.AssociatedObject.EditValue;
			if (editValue is decimal)
			{
				decimal d = (decimal)editValue;
				if (d == 0m)
				{
					base.AssociatedObject.SelectAll();
				}
			}
			if (base.AssociatedObject.EditValue != null)
			{
				string text = base.AssociatedObject.EditValue as string;
				if (text == null || !string.IsNullOrEmpty(text))
				{
					return;
				}
			}
			if (base.AssociatedObject.MaskType == MaskType.Simple)
			{
				base.AssociatedObject.SelectAll();
			}
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x0015D450 File Offset: 0x0015B650
		protected override void OnDetaching()
		{
			base.AssociatedObject.PreviewMouseLeftButtonUp -= this.AssociatedObjectOnMouseUp;
			base.OnDetaching();
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00022EC4 File Offset: 0x000210C4
		public SelectAllOnMouseUpBehavior()
		{
		}
	}
}
