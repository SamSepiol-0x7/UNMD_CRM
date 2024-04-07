using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Windows;
using DevExpress.Xpf.Diagram;

namespace ASC.Extensions
{
	// Token: 0x02000B61 RID: 2913
	public class DiagramOrgChartBehaviorEx : DiagramOrgChartBehavior
	{
		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x0015E7F8 File Offset: 0x0015C9F8
		// (set) Token: 0x06005183 RID: 20867 RVA: 0x0015E818 File Offset: 0x0015CA18
		public List<object> SelectedObjects
		{
			get
			{
				return (List<object>)base.GetValue(DiagramOrgChartBehaviorEx.SelectedObjectsProperty);
			}
			set
			{
				if (object.Equals(this.SelectedObjects, value))
				{
					return;
				}
				base.SetValue(DiagramOrgChartBehaviorEx.SelectedObjectsProperty, value);
				this.RaisePropertyChanged("SelectedObjects");
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x0015E84C File Offset: 0x0015CA4C
		// (set) Token: 0x06005185 RID: 20869 RVA: 0x0015E864 File Offset: 0x0015CA64
		public object PrimarySelection
		{
			get
			{
				return base.GetValue(DiagramOrgChartBehaviorEx.PrimarySelectionProperty);
			}
			set
			{
				if (object.Equals(this.PrimarySelection, value))
				{
					return;
				}
				base.SetValue(DiagramOrgChartBehaviorEx.PrimarySelectionProperty, value);
				this.RaisePropertyChanged("PrimarySelection");
			}
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x0015E898 File Offset: 0x0015CA98
		protected override void OnAttached()
		{
			base.OnAttached();
			base.AssociatedObject.SelectionChanged += this.AssociatedObject_SelectionChanged;
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x0015E8C4 File Offset: 0x0015CAC4
		private void AssociatedObject_SelectionChanged(object sender, DiagramSelectionChangedEventArgs e)
		{
			this.UpdateSelectedItems();
			this.UpdatePrimarySelection();
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x0015E8E0 File Offset: 0x0015CAE0
		private void UpdateSelectedItems()
		{
			List<object> list = new List<object>();
			foreach (DiagramItem diagramItem in base.AssociatedObject.SelectedItems)
			{
				DiagramContentItem diagramContentItem = diagramItem as DiagramContentItem;
				if (diagramContentItem != null)
				{
					list.Add(diagramContentItem.Content);
				}
			}
			this.SelectedObjects = list;
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x0015E950 File Offset: 0x0015CB50
		private void UpdatePrimarySelection()
		{
			DiagramContainer diagramContainer = base.AssociatedObject.PrimarySelection as DiagramContainer;
			if (diagramContainer != null)
			{
				this.PrimarySelection = diagramContainer.DataContext;
			}
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x0015E980 File Offset: 0x0015CB80
		public DiagramOrgChartBehaviorEx()
		{
			try
			{
				DiagramDataBindingBehaviorBase.ItemsSourceProperty.OverrideMetadata(typeof(DiagramOrgChartBehaviorEx), new FrameworkPropertyMetadata(null, delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
				{
					((DiagramOrgChartBehaviorEx)d).OnItemsSourceChanged(e.OldValue, e.NewValue);
				}));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x0015E9E4 File Offset: 0x0015CBE4
		private void OnItemsSourceChanged(object oldValue, object newValue)
		{
			INotifyCollectionChanged notifyCollectionChanged = oldValue as INotifyCollectionChanged;
			INotifyCollectionChanged notifyCollectionChanged2 = newValue as INotifyCollectionChanged;
			if (notifyCollectionChanged2 != null)
			{
				notifyCollectionChanged2.CollectionChanged += this.OnCollectionChanged;
			}
			if (notifyCollectionChanged != null)
			{
				notifyCollectionChanged.CollectionChanged -= this.OnCollectionChanged;
			}
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x0015EA2C File Offset: 0x0015CC2C
		private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.OnAttached();
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x0015EA40 File Offset: 0x0015CC40
		// Note: this type is marked as 'beforefieldinit'.
		static DiagramOrgChartBehaviorEx()
		{
		}

		// Token: 0x0400359F RID: 13727
		public static readonly DependencyProperty SelectedObjectsProperty = DependencyProperty.Register("SelectedObjects", typeof(List<object>), typeof(DiagramOrgChartBehaviorEx), null);

		// Token: 0x040035A0 RID: 13728
		public static readonly DependencyProperty PrimarySelectionProperty = DependencyProperty.Register("PrimarySelection", typeof(object), typeof(DiagramOrgChartBehaviorEx), null);

		// Token: 0x02000B62 RID: 2914
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600518E RID: 20878 RVA: 0x0015EA98 File Offset: 0x0015CC98
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600518F RID: 20879 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005190 RID: 20880 RVA: 0x0015EAB0 File Offset: 0x0015CCB0
			internal void <.ctor>b__12_0(DependencyObject d, DependencyPropertyChangedEventArgs e)
			{
				((DiagramOrgChartBehaviorEx)d).OnItemsSourceChanged(e.OldValue, e.NewValue);
			}

			// Token: 0x040035A1 RID: 13729
			public static readonly DiagramOrgChartBehaviorEx.<>c <>9 = new DiagramOrgChartBehaviorEx.<>c();

			// Token: 0x040035A2 RID: 13730
			public static PropertyChangedCallback <>9__12_0;
		}
	}
}
