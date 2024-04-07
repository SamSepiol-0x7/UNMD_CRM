using System;
using System.Windows.Input;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Editors;

namespace ASC
{
	// Token: 0x0200009C RID: 156
	public class TabOnEnterBehavior : Behavior<TextEdit>
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x00022E44 File Offset: 0x00021044
		protected override void OnAttached()
		{
			base.AssociatedObject.PreviewKeyDown += this.AssociatedObject_PreviewKeyDown;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00022E68 File Offset: 0x00021068
		private void AssociatedObject_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next)
				{
					Wrapped = true
				};
				base.AssociatedObject.MoveFocus(request);
				e.Handled = true;
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00022EA0 File Offset: 0x000210A0
		protected override void OnDetaching()
		{
			base.AssociatedObject.PreviewKeyDown -= this.AssociatedObject_PreviewKeyDown;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00022EC4 File Offset: 0x000210C4
		public TabOnEnterBehavior()
		{
		}
	}
}
