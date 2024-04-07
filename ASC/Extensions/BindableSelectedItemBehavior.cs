using System;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Mvvm.UI.Interactivity;

namespace ASC.Extensions
{
	// Token: 0x02000B5A RID: 2906
	public class BindableSelectedItemBehavior : Behavior<TreeView>
	{
		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600515D RID: 20829 RVA: 0x0015E1B4 File Offset: 0x0015C3B4
		// (set) Token: 0x0600515E RID: 20830 RVA: 0x0015E1CC File Offset: 0x0015C3CC
		public object SelectedItem
		{
			get
			{
				return base.GetValue(BindableSelectedItemBehavior.SelectedItemProperty);
			}
			set
			{
				if (object.Equals(this.SelectedItem, value))
				{
					return;
				}
				base.SetValue(BindableSelectedItemBehavior.SelectedItemProperty, value);
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x0015E200 File Offset: 0x0015C400
		private static void OnSelectedItemChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			TreeViewItem treeViewItem = e.NewValue as TreeViewItem;
			if (treeViewItem != null)
			{
				treeViewItem.SetValue(TreeViewItem.IsSelectedProperty, true);
			}
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x0015E230 File Offset: 0x0015C430
		protected override void OnAttached()
		{
			base.OnAttached();
			base.AssociatedObject.SelectedItemChanged += this.OnTreeViewSelectedItemChanged;
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x0015E25C File Offset: 0x0015C45C
		protected override void OnDetaching()
		{
			base.OnDetaching();
			if (base.AssociatedObject != null)
			{
				base.AssociatedObject.SelectedItemChanged -= this.OnTreeViewSelectedItemChanged;
			}
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x0015E290 File Offset: 0x0015C490
		private void OnTreeViewSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
		{
			this.SelectedItem = e.NewValue;
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x0015E2AC File Offset: 0x0015C4AC
		public BindableSelectedItemBehavior()
		{
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x0015E2C0 File Offset: 0x0015C4C0
		// Note: this type is marked as 'beforefieldinit'.
		static BindableSelectedItemBehavior()
		{
		}

		// Token: 0x04003593 RID: 13715
		public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register("SelectedItem", typeof(object), typeof(BindableSelectedItemBehavior), new UIPropertyMetadata(null, new PropertyChangedCallback(BindableSelectedItemBehavior.OnSelectedItemChanged)));
	}
}
