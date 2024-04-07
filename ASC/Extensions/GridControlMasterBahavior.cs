using System;
using System.Windows;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Grid;

namespace ASC.Extensions
{
	// Token: 0x02000B52 RID: 2898
	public class GridControlMasterBahavior : Behavior<GridControl>
	{
		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x0015D118 File Offset: 0x0015B318
		// (set) Token: 0x06005145 RID: 20805 RVA: 0x0015D138 File Offset: 0x0015B338
		public bool AutoExpandAllDetails
		{
			get
			{
				return (bool)base.GetValue(GridControlMasterBahavior.AutoExpandAllDetailsProperty);
			}
			set
			{
				if (this.AutoExpandAllDetails == value)
				{
					return;
				}
				base.SetValue(GridControlMasterBahavior.AutoExpandAllDetailsProperty, value);
				this.RaisePropertyChanged("AutoExpandAllDetails");
			}
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x0015D170 File Offset: 0x0015B370
		protected override void OnAttached()
		{
			base.OnAttached();
			base.AssociatedObject.ItemsSourceChanged += new ItemsSourceChangedEventHandler(this.AssociatedObject_Loaded);
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x0015D19C File Offset: 0x0015B39C
		protected override void OnDetaching()
		{
			base.AssociatedObject.ItemsSourceChanged -= new ItemsSourceChangedEventHandler(this.AssociatedObject_Loaded);
			base.OnDetaching();
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x0015D1C8 File Offset: 0x0015B3C8
		private void AssociatedObject_Loaded(object sender, RoutedEventArgs e)
		{
			if (this.AutoExpandAllDetails)
			{
				for (int i = 0; i < base.AssociatedObject.VisibleRowCount; i++)
				{
					int rowHandleByVisibleIndex = base.AssociatedObject.GetRowHandleByVisibleIndex(i);
					base.AssociatedObject.ExpandMasterRow(rowHandleByVisibleIndex, null);
				}
			}
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x0015D210 File Offset: 0x0015B410
		public GridControlMasterBahavior()
		{
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x0015D224 File Offset: 0x0015B424
		// Note: this type is marked as 'beforefieldinit'.
		static GridControlMasterBahavior()
		{
		}

		// Token: 0x0400358D RID: 13709
		public static readonly DependencyProperty AutoExpandAllDetailsProperty = DependencyProperty.Register("AutoExpandAllDetails", typeof(bool), typeof(GridControlMasterBahavior), new PropertyMetadata(false));
	}
}
