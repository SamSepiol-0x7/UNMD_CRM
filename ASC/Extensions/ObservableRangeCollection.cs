using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ASC.Extensions
{
	// Token: 0x02000B7B RID: 2939
	public class ObservableRangeCollection<T> : ObservableCollection<T>
	{
		// Token: 0x0600520D RID: 21005 RVA: 0x001608A8 File Offset: 0x0015EAA8
		public void AddRange(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			foreach (T item in collection)
			{
				base.Items.Add(item);
			}
			this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x00160910 File Offset: 0x0015EB10
		public void RemoveRange(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			foreach (T item in collection)
			{
				base.Items.Remove(item);
			}
			this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x0016097C File Offset: 0x0015EB7C
		public void Replace(T item)
		{
			this.ReplaceRange(new T[]
			{
				item
			});
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x001609A0 File Offset: 0x0015EBA0
		public void ReplaceRange(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			base.Items.Clear();
			foreach (T item in collection)
			{
				base.Items.Add(item);
			}
			this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00160A14 File Offset: 0x0015EC14
		public ObservableRangeCollection()
		{
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00160A28 File Offset: 0x0015EC28
		public ObservableRangeCollection(IEnumerable<T> collection) : base(collection)
		{
		}
	}
}
