using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Grid;

namespace ASC.Extensions
{
	// Token: 0x02000B64 RID: 2916
	public class GridLayoutHelper : Behavior<GridControl>
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06005196 RID: 20886 RVA: 0x0015EBB4 File Offset: 0x0015CDB4
		// (remove) Token: 0x06005197 RID: 20887 RVA: 0x0015EBF0 File Offset: 0x0015CDF0
		public event EventHandler<MyEventArgs> LayoutChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler<MyEventArgs> eventHandler = this.LayoutChanged;
				EventHandler<MyEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<MyEventArgs> value2 = (EventHandler<MyEventArgs>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<MyEventArgs>>(ref this.LayoutChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<MyEventArgs> eventHandler = this.LayoutChanged;
				EventHandler<MyEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<MyEventArgs> value2 = (EventHandler<MyEventArgs>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<MyEventArgs>>(ref this.LayoutChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x0015EC28 File Offset: 0x0015CE28
		protected GridControl Grid
		{
			get
			{
				return base.AssociatedObject;
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x0015EC3C File Offset: 0x0015CE3C
		// (set) Token: 0x0600519A RID: 20890 RVA: 0x0015EC50 File Offset: 0x0015CE50
		public bool RaiseEventsImmediately
		{
			[CompilerGenerated]
			get
			{
				return this.<RaiseEventsImmediately>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RaiseEventsImmediately>k__BackingField == value)
				{
					return;
				}
				this.<RaiseEventsImmediately>k__BackingField = value;
				this.RaisePropertyChanged("RaiseEventsImmediately");
			}
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x0015EC7C File Offset: 0x0015CE7C
		protected override void OnAttached()
		{
			base.OnAttached();
			this.SubscribeColumns(this.Grid.Columns);
			this.Grid.Columns.CollectionChanged += this.ColumnsCollectionChanged;
			this.Grid.SortInfo.CollectionChanged += this.OnSortInfoChanged;
			this.Grid.FilterChanged += this.OnGridFilterChanged;
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x0015ECF4 File Offset: 0x0015CEF4
		protected override void OnDetaching()
		{
			this.Notifiers.Clear();
			this.UnsubscribeColumns(this.Grid.Columns);
			this.Grid.Columns.CollectionChanged -= this.ColumnsCollectionChanged;
			this.Grid.SortInfo.CollectionChanged -= this.OnSortInfoChanged;
			this.Grid.FilterChanged -= this.OnGridFilterChanged;
			base.OnDetaching();
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x0015ED78 File Offset: 0x0015CF78
		protected virtual void OnGridFilterChanged(object sender, RoutedEventArgs e)
		{
			this.ProcessLayoutChanging(LayoutChangedType.FilerChanged);
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x0015ED8C File Offset: 0x0015CF8C
		protected virtual void OnSortInfoChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.ProcessLayoutChanging(LayoutChangedType.SortingChanged);
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x0015EDA0 File Offset: 0x0015CFA0
		protected virtual void ColumnsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			bool flag = false;
			List<GridColumn> list = this.Grid.Columns.Except(this.SubscribedColumns).ToList<GridColumn>();
			List<GridColumn> list2 = this.SubscribedColumns.Except(this.Grid.Columns).ToList<GridColumn>();
			if (list2.Any<GridColumn>())
			{
				flag = true;
				this.UnsubscribeColumns(list2);
			}
			if (list.Any<GridColumn>())
			{
				flag = true;
				this.SubscribeColumns(list);
			}
			if (flag)
			{
				this.ProcessLayoutChanging(LayoutChangedType.ColumnsCollection);
			}
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x0015EE14 File Offset: 0x0015D014
		protected virtual void ProcessLayoutChanging(LayoutChangedType type)
		{
			if (this.LayoutChanged == null)
			{
				return;
			}
			if (this.RaiseEventsImmediately)
			{
				this.LayoutChanged(this, new MyEventArgs
				{
					LayoutChangedTypes = new List<LayoutChangedType>
					{
						type
					}
				});
				return;
			}
			if (!this.ChangesCache.Contains(type))
			{
				this.ChangesCache.Add(type);
			}
			if (!this.IsLocked)
			{
				this.IsLocked = true;
				base.Dispatcher.BeginInvoke(new Action(delegate()
				{
					this.IsLocked = false;
					this.LayoutChanged(this, new MyEventArgs
					{
						LayoutChangedTypes = this.ChangesCache
					});
					this.ChangesCache.Clear();
				}), new object[0]);
				return;
			}
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x0015EEA0 File Offset: 0x0015D0A0
		protected virtual void SubscribeColumns(IEnumerable<GridColumn> columns)
		{
			this.SubscribedColumns.AddRange(columns);
			foreach (GridColumn column in columns)
			{
				this.Subscribe(column);
			}
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x0015EEF8 File Offset: 0x0015D0F8
		protected virtual void UnsubscribeColumns(IEnumerable<GridColumn> columns)
		{
			foreach (GridColumn gridColumn in columns)
			{
				this.SubscribedColumns.Remove(gridColumn);
				this.Unsubscribe(gridColumn);
			}
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x0015EF50 File Offset: 0x0015D150
		protected virtual void Subscribe(GridColumn column)
		{
			PropertyChangeNotifier propertyChangeNotifier = new PropertyChangeNotifier(column, BaseColumn.ActualWidthProperty);
			propertyChangeNotifier.ValueChanged += this.OnColumnWidthChanged;
			this.Notifiers.Add(propertyChangeNotifier);
			PropertyChangeNotifier propertyChangeNotifier2 = new PropertyChangeNotifier(column, BaseColumn.VisibleIndexProperty);
			propertyChangeNotifier2.ValueChanged += this.OnColumnVisibleIndexChanged;
			this.Notifiers.Add(propertyChangeNotifier2);
			PropertyChangeNotifier propertyChangeNotifier3 = new PropertyChangeNotifier(column, GridColumn.GroupIndexProperty);
			propertyChangeNotifier3.ValueChanged += this.OnColumnGroupIndexChanged;
			this.Notifiers.Add(propertyChangeNotifier3);
			PropertyChangeNotifier propertyChangeNotifier4 = new PropertyChangeNotifier(column, BaseColumn.VisibleProperty);
			propertyChangeNotifier4.ValueChanged += this.OnColumnVisibleChanged;
			this.Notifiers.Add(propertyChangeNotifier4);
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x0015F00C File Offset: 0x0015D20C
		protected virtual void Unsubscribe(GridColumn column)
		{
			using (List<PropertyChangeNotifier>.Enumerator enumerator = (from x in this.Notifiers
			where x.PropertySource == column
			select x).ToList<PropertyChangeNotifier>().GetEnumerator())
			{
				for (;;)
				{
					IL_91:
					int num = (!enumerator.MoveNext()) ? -1949035785 : -969418995;
					for (;;)
					{
						switch ((num ^ -845835866) % 4)
						{
						case 0:
							num = -969418995;
							continue;
						case 2:
							goto IL_91;
						case 3:
						{
							PropertyChangeNotifier propertyChangeNotifier = enumerator.Current;
							propertyChangeNotifier.Dispose();
							this.Notifiers.Remove(propertyChangeNotifier);
							num = -477288240;
							continue;
						}
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x0015F0D8 File Offset: 0x0015D2D8
		protected virtual void OnColumnWidthChanged(object sender, EventArgs e)
		{
			this.ProcessLayoutChanging(LayoutChangedType.ColumnWidth);
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x0015F0EC File Offset: 0x0015D2EC
		protected virtual void OnColumnVisibleIndexChanged(object sender, EventArgs e)
		{
			this.ProcessLayoutChanging(LayoutChangedType.ColumnVisibleIndex);
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x0015F100 File Offset: 0x0015D300
		protected virtual void OnColumnGroupIndexChanged(object sender, EventArgs e)
		{
			this.ProcessLayoutChanging(LayoutChangedType.ColumnGroupIndex);
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x0015F114 File Offset: 0x0015D314
		protected virtual void OnColumnVisibleChanged(object sender, EventArgs e)
		{
			this.ProcessLayoutChanging(LayoutChangedType.ColumnVisible);
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x0015F128 File Offset: 0x0015D328
		public GridLayoutHelper()
		{
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x0015F15C File Offset: 0x0015D35C
		[CompilerGenerated]
		private void <ProcessLayoutChanging>b__17_0()
		{
			this.IsLocked = false;
			this.LayoutChanged(this, new MyEventArgs
			{
				LayoutChangedTypes = this.ChangesCache
			});
			this.ChangesCache.Clear();
		}

		// Token: 0x040035A3 RID: 13731
		[CompilerGenerated]
		private EventHandler<MyEventArgs> LayoutChanged;

		// Token: 0x040035A4 RID: 13732
		private bool IsLocked;

		// Token: 0x040035A5 RID: 13733
		private readonly List<LayoutChangedType> ChangesCache = new List<LayoutChangedType>();

		// Token: 0x040035A6 RID: 13734
		private readonly List<PropertyChangeNotifier> Notifiers = new List<PropertyChangeNotifier>();

		// Token: 0x040035A7 RID: 13735
		[CompilerGenerated]
		private bool <RaiseEventsImmediately>k__BackingField;

		// Token: 0x040035A8 RID: 13736
		private List<GridColumn> SubscribedColumns = new List<GridColumn>();

		// Token: 0x02000B65 RID: 2917
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x060051AB RID: 20907 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x060051AC RID: 20908 RVA: 0x0015F198 File Offset: 0x0015D398
			internal bool <Unsubscribe>b__0(PropertyChangeNotifier x)
			{
				return x.PropertySource == this.column;
			}

			// Token: 0x040035A9 RID: 13737
			public GridColumn column;
		}
	}
}
