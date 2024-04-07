using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace ASC.ViewModels
{
	// Token: 0x02000421 RID: 1057
	public class CollectionViewModel<T> : BaseViewModel, IDisposable where T : class
	{
		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x00085908 File Offset: 0x00083B08
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x0008591C File Offset: 0x00083B1C
		public ObservableCollection<T> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0008594C File Offset: 0x00083B4C
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x00085994 File Offset: 0x00083B94
		public List<T> SelectedItems
		{
			get
			{
				return base.GetProperty<List<T>>(() => this.SelectedItems);
			}
			set
			{
				if (object.Equals(this.SelectedItems, value))
				{
					return;
				}
				base.SetProperty<List<T>>(() => this.SelectedItems, value, new Action<List<T>>(this.OnSelectedItemsChanged));
				this.RaisePropertyChanged("SelectedItems");
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x00085A04 File Offset: 0x00083C04
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x00085A4C File Offset: 0x00083C4C
		public T SelectedItem
		{
			get
			{
				return base.GetProperty<T>(() => this.SelectedItem);
			}
			set
			{
				if (object.Equals(this.SelectedItem, value))
				{
					return;
				}
				base.SetProperty<T>(() => this.SelectedItem, value, new Action<T>(this.OnSelectedItemChanged));
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00085AC8 File Offset: 0x00083CC8
		public CollectionViewModel()
		{
			this.Items = new ObservableCollection<T>();
			this.SelectedItems = new List<T>();
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00085AF4 File Offset: 0x00083CF4
		public virtual void OnSelectedItemChanged(T obj)
		{
			if (this.SelectedItemChanged != null)
			{
				this.SelectedItemChanged.BeginInvoke(this, obj, null, null);
			}
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00023150 File Offset: 0x00021350
		public virtual void OnSelectedItemsChanged(List<T> obj)
		{
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00085B1C File Offset: 0x00083D1C
		public bool AnyItems()
		{
			return this.Items != null && this.Items.Count > 0;
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00085B44 File Offset: 0x00083D44
		public void ClearSelected()
		{
			this.SelectedItem = default(T);
			List<T> selectedItems = this.SelectedItems;
			if (selectedItems == null)
			{
				return;
			}
			selectedItems.Clear();
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00085B70 File Offset: 0x00083D70
		public void Dispose()
		{
			ObservableCollection<T> items = this.Items;
			if (items != null)
			{
				items.Clear();
				goto IL_42;
			}
			IL_13:
			this.SelectedItem = default(T);
			int num = 502355595;
			IL_27:
			switch ((num ^ 1050094850) % 3)
			{
			case 0:
				IL_42:
				num = 716356071;
				goto IL_27;
			case 2:
				goto IL_13;
			}
			List<T> selectedItems = this.SelectedItems;
			if (selectedItems == null)
			{
				return;
			}
			selectedItems.Clear();
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00085BD8 File Offset: 0x00083DD8
		public void SetItems(IEnumerable<T> items)
		{
			this.Items = new ObservableCollection<T>(items);
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x00085BF4 File Offset: 0x00083DF4
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x00085C3C File Offset: 0x00083E3C
		public string SearchString
		{
			get
			{
				return base.GetProperty<string>(() => this.SearchString);
			}
			set
			{
				if (!string.Equals(this.SearchString, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1931903576;
				IL_14:
				switch ((num ^ -1031937811) % 4)
				{
				case 0:
					IL_33:
					base.SetProperty<string>(() => this.SearchString, value, new Action<string>(this.OnSearchStringChanged));
					num = -820798737;
					goto IL_14;
				case 1:
					return;
				case 3:
					goto IL_0F;
				}
				this.RaisePropertyChanged("SearchString");
			}
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00023150 File Offset: 0x00021350
		protected virtual void OnSearchStringChanged(string oldValue)
		{
		}

		// Token: 0x04001784 RID: 6020
		[CompilerGenerated]
		private ObservableCollection<T> <Items>k__BackingField;

		// Token: 0x04001785 RID: 6021
		public EventHandler<T> SelectedItemChanged;
	}
}
