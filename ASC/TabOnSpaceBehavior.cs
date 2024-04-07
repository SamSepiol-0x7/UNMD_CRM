using System;
using System.Windows.Input;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Editors;

namespace ASC
{
	// Token: 0x020000B5 RID: 181
	public class TabOnSpaceBehavior : Behavior<TextEdit>
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x00029AF8 File Offset: 0x00027CF8
		protected override void OnAttached()
		{
			base.AssociatedObject.PreviewKeyDown += this.AssociatedObject_PreviewKeyDown;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00029B1C File Offset: 0x00027D1C
		private void AssociatedObject_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Space)
			{
				TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next)
				{
					Wrapped = true
				};
				base.AssociatedObject.MoveFocus(request);
				e.Handled = true;
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00029B58 File Offset: 0x00027D58
		protected override void OnDetaching()
		{
			base.AssociatedObject.PreviewKeyDown -= this.AssociatedObject_PreviewKeyDown;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00022EC4 File Offset: 0x000210C4
		public TabOnSpaceBehavior()
		{
		}
	}
}
