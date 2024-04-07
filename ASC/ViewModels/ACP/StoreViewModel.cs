using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ASC.Extensions;
using ASC.Models;
using DevExpress.Xpf.Core;

namespace ASC.ViewModels.ACP
{
	// Token: 0x020005A1 RID: 1441
	public class StoreViewModel : BoxesModel, INotifyPropertyChanged
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06003548 RID: 13640 RVA: 0x000B5380 File Offset: 0x000B3580
		// (remove) Token: 0x06003549 RID: 13641 RVA: 0x000B53B8 File Offset: 0x000B35B8
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x000B53F0 File Offset: 0x000B35F0
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x000B5404 File Offset: 0x000B3604
		public ObservableCollection<stores> Stores
		{
			[CompilerGenerated]
			get
			{
				return this.<Stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Stores>k__BackingField, value))
				{
					return;
				}
				this.<Stores>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Stores);
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x000B5434 File Offset: 0x000B3634
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x000B5448 File Offset: 0x000B3648
		public List<stores> CopyFromStores
		{
			[CompilerGenerated]
			get
			{
				return this.<CopyFromStores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<CopyFromStores>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1805160384;
				IL_13:
				switch ((num ^ 425832963) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<CopyFromStores>k__BackingField = value;
					num = 1981831381;
					goto IL_13;
				case 3:
					return;
				}
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CopyFromStores);
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x000B54A4 File Offset: 0x000B36A4
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x000B54B8 File Offset: 0x000B36B8
		public stores SelectedStore
		{
			get
			{
				return this._selectedStore;
			}
			set
			{
				if (!object.Equals(this._selectedStore, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -926658410;
				IL_13:
				switch ((num ^ -2013240151) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = -361556621;
					goto IL_13;
				case 3:
					return;
				}
				this._selectedStore = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SelectedStore);
				this.SelectionChanged();
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x000B5518 File Offset: 0x000B3718
		// (set) Token: 0x06003551 RID: 13649 RVA: 0x000B552C File Offset: 0x000B372C
		public bool CanCopyCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<CanCopyCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CanCopyCategories>k__BackingField == value)
				{
					return;
				}
				this.<CanCopyCategories>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CanCopyCategories);
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x000B5558 File Offset: 0x000B3758
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x000B556C File Offset: 0x000B376C
		public int CopyStoreId
		{
			[CompilerGenerated]
			get
			{
				return this.<CopyStoreId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CopyStoreId>k__BackingField == value)
				{
					return;
				}
				this.<CopyStoreId>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CopyStoreId);
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x000B5598 File Offset: 0x000B3798
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x000B55AC File Offset: 0x000B37AC
		public ObservableCollection<boxes> Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Boxes>k__BackingField, value))
				{
					return;
				}
				this.<Boxes>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Boxes);
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x000B55DC File Offset: 0x000B37DC
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x000B55F0 File Offset: 0x000B37F0
		public boxes SelectedBox
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedBox>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedBox>k__BackingField, value))
				{
					return;
				}
				this.<SelectedBox>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SelectedBox);
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x000B5620 File Offset: 0x000B3820
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x000B5634 File Offset: 0x000B3834
		public List<int> DelBoxes
		{
			[CompilerGenerated]
			get
			{
				return this.<DelBoxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DelBoxes>k__BackingField, value))
				{
					return;
				}
				this.<DelBoxes>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DelBoxes);
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x000B5664 File Offset: 0x000B3864
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x000B5678 File Offset: 0x000B3878
		public List<int> DelAddFields
		{
			[CompilerGenerated]
			get
			{
				return this.<DelAddFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DelAddFields>k__BackingField, value))
				{
					return;
				}
				this.<DelAddFields>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DelAddFields);
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x000B56A8 File Offset: 0x000B38A8
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x000B56BC File Offset: 0x000B38BC
		public List<offices> Offices
		{
			[CompilerGenerated]
			get
			{
				return this.<Offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Offices>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1982483760;
				IL_13:
				switch ((num ^ -249862782) % 4)
				{
				case 1:
					IL_32:
					this.<Offices>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Offices);
					num = -498697714;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x000B5718 File Offset: 0x000B3918
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x000B572C File Offset: 0x000B392C
		public List<store_types> StoreTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StoreTypes>k__BackingField, value))
				{
					return;
				}
				this.<StoreTypes>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.StoreTypes);
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x000B575C File Offset: 0x000B395C
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x000B5770 File Offset: 0x000B3970
		public List<store_sub_types> StoreSubTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreSubTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<StoreSubTypes>k__BackingField, value))
				{
					return;
				}
				this.<StoreSubTypes>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.StoreSubTypes);
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x000B57A0 File Offset: 0x000B39A0
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x000B57B4 File Offset: 0x000B39B4
		public ObservableCollection<store_fields> AdditionalFields
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalFields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AdditionalFields>k__BackingField, value))
				{
					return;
				}
				this.<AdditionalFields>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AdditionalFields);
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x000B57E4 File Offset: 0x000B39E4
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x000B57F8 File Offset: 0x000B39F8
		public bool CreateStore
		{
			[CompilerGenerated]
			get
			{
				return this.<CreateStore>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<CreateStore>k__BackingField == value)
				{
					return;
				}
				this.<CreateStore>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CreateStore);
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x000B5824 File Offset: 0x000B3A24
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x000B5838 File Offset: 0x000B3A38
		public ICommand ShowNewStoreCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowNewStoreCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ShowNewStoreCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1459897515;
				IL_13:
				switch ((num ^ -428116877) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<ShowNewStoreCommand>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ShowNewStoreCommand);
					num = -1173842644;
					goto IL_13;
				case 2:
					return;
				}
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x000B5894 File Offset: 0x000B3A94
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x000B58A8 File Offset: 0x000B3AA8
		public ICommand RemoveBoxCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RemoveBoxCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RemoveBoxCommand>k__BackingField, value))
				{
					return;
				}
				this.<RemoveBoxCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.RemoveBoxCommand);
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x000B58D8 File Offset: 0x000B3AD8
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x000B58EC File Offset: 0x000B3AEC
		public ICommand CancelCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<CancelCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CancelCommand>k__BackingField, value))
				{
					return;
				}
				this.<CancelCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CancelCommand);
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x000B591C File Offset: 0x000B3B1C
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x000B5930 File Offset: 0x000B3B30
		public ICommand HideNewStoreCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<HideNewStoreCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<HideNewStoreCommand>k__BackingField, value))
				{
					return;
				}
				this.<HideNewStoreCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.HideNewStoreCommand);
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x000B5960 File Offset: 0x000B3B60
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x000B5974 File Offset: 0x000B3B74
		public ICommand CreateNewStoreCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<CreateNewStoreCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CreateNewStoreCommand>k__BackingField, value))
				{
					return;
				}
				this.<CreateNewStoreCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CreateNewStoreCommand);
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x000B59A4 File Offset: 0x000B3BA4
		// (set) Token: 0x06003571 RID: 13681 RVA: 0x000B59B8 File Offset: 0x000B3BB8
		public ICommand SaveExistStoreCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveExistStoreCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SaveExistStoreCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -893823811;
				IL_13:
				switch ((num ^ -183909982) % 4)
				{
				case 0:
					IL_32:
					this.<SaveExistStoreCommand>k__BackingField = value;
					num = -1871220669;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SaveExistStoreCommand);
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003572 RID: 13682 RVA: 0x000B5A14 File Offset: 0x000B3C14
		// (set) Token: 0x06003573 RID: 13683 RVA: 0x000B5A28 File Offset: 0x000B3C28
		public ICommand ControlLoadedCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ControlLoadedCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ControlLoadedCommand>k__BackingField, value))
				{
					return;
				}
				this.<ControlLoadedCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.ControlLoadedCommand);
			}
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000B5A58 File Offset: 0x000B3C58
		private void InitCommands()
		{
			this.ShowNewStoreCommand = new RelayCommand(new Action<object>(this.ShowNewStore));
			this.HideNewStoreCommand = new RelayCommand(new Action<object>(this.HideNewStore));
			this.CreateNewStoreCommand = new RelayCommand(new Action<object>(this.CreateNewStore));
			this.CancelCommand = new RelayCommand(new Action<object>(this.Cancel));
			this.SaveExistStoreCommand = new RelayCommand(new Action<object>(this.SaveExistStore));
			this.ControlLoadedCommand = new RelayCommand(new Action<object>(this.ControlLoaded));
			this.RemoveBoxCommand = new RelayCommand(new Action<object>(this.RemoveBox));
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x000B5B08 File Offset: 0x000B3D08
		public StoreViewModel()
		{
			this._bgInit.DoWork += this.BgInit;
			this._bgInit.RunWorkerAsync();
			this.InitCommands();
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x000B5B50 File Offset: 0x000B3D50
		private void RegisterFieldChanges()
		{
			if ((string)this._originalStoreValues["name"] != this.SelectedStore.name)
			{
				this._history.Add(28, new string[]
				{
					this.SelectedStore.name,
					(string)this._originalStoreValues["name"]
				});
			}
			if ((string)this._originalStoreValues["description"] != this.SelectedStore.description)
			{
				this._history.Add(29, new string[]
				{
					this.SelectedStore.name,
					this.SelectedStore.description,
					(string)this._originalStoreValues["description"]
				});
			}
			if ((int)this._originalStoreValues["type"] != this.SelectedStore.type)
			{
				this._history.Add(31, new string[]
				{
					this.SelectedStore.name
				});
			}
			int? num = (int?)this._originalStoreValues["office"];
			int? office = this.SelectedStore.office;
			if (!(num.GetValueOrDefault() == office.GetValueOrDefault() & num != null == (office != null)))
			{
				this._history.Add(30, new string[]
				{
					this.SelectedStore.name
				});
			}
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x000B5CD4 File Offset: 0x000B3ED4
		private void SaveExistStore(object obj)
		{
			if (this.SelectedStore == null)
			{
				return;
			}
			if (this.ChechStoreFields())
			{
				this.RegisterFieldChanges();
				if (this.SelectedStore.type == 2)
				{
					this.SelectedStore.office = null;
				}
				if (this.DelBoxes != null && this.DelBoxes.Count > 0)
				{
					using (List<int>.Enumerator enumerator = this.DelBoxes.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							int id = enumerator.Current;
							boxes boxes = this._context.boxes.FirstOrDefault((boxes bn) => bn.id == id);
							if (boxes != null)
							{
								this._context.boxes.Remove(boxes);
							}
						}
					}
					this.DelBoxes = null;
				}
				bool flag = false;
				foreach (boxes boxes2 in this.Boxes)
				{
					if (boxes2.id == 0 && !string.IsNullOrEmpty(boxes2.name))
					{
						boxes2.store_id = new int?(this.SelectedStore.id);
						this._context.boxes.Add(boxes2);
						flag = true;
					}
				}
				if (flag)
				{
					this._history.Add(33, new string[]
					{
						this.SelectedStore.name
					});
				}
				this._history.Add(27, new string[]
				{
					this.SelectedStore.name
				});
				if (base.SaveContext(false))
				{
					this._history.Save();
					this.ClearStoreFields();
					this.RefreshStores();
					DXMessageBox.Show(Lang.t("StoresAndBoxes"), Lang.t("Saved"));
				}
				return;
			}
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x000B5F1C File Offset: 0x000B411C
		private void Cancel(object obj)
		{
			this.CreateStore = false;
			this.SelectedStore = null;
			this.DelBoxes = null;
			this.RefreshStores();
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x000B5F44 File Offset: 0x000B4144
		public void RemoveBox(object obj)
		{
			if (this.SelectedBox == null)
			{
				return;
			}
			boxes boxes = this.Boxes.FirstOrDefault((boxes b) => b == this.SelectedBox);
			if (boxes != null)
			{
				if (this.DelBoxes == null)
				{
					this.DelBoxes = new List<int>();
				}
				this.DelBoxes.Add(boxes.id);
				this.Boxes.Remove(this.SelectedBox);
				return;
			}
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x000B5FAC File Offset: 0x000B41AC
		private void SelectionChanged()
		{
			if (this.SelectedStore == null)
			{
				return;
			}
			int? office = this.SelectedStore.office;
			this._context.UnchangedAll();
			if (this._context.Exists<stores>(this.SelectedStore))
			{
				this._context.Entry<stores>(this.SelectedStore).State = EntityState.Modified;
				this._originalStoreValues = this._context.Entry<stores>(this.SelectedStore).OriginalValues;
			}
			this.Offices = (from o in this._context.offices.AsNoTracking()
			where o.state == 1
			select o).ToListSafe<offices>();
			this.SelectedStore.office = office;
			this.Boxes = new ObservableCollection<boxes>(base.LoadBoxes(this.SelectedStore.id));
			this.CanCopyCategories = (this.SelectedStore.id == 0);
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x000B60D0 File Offset: 0x000B42D0
		private void BgInit(object sender, DoWorkEventArgs e)
		{
			StoreModel storeModel = new StoreModel();
			this.Stores = new ObservableCollection<stores>(this._context.stores.ToListSafe<stores>());
			this.CopyFromStores = new List<stores>(this.Stores)
			{
				new stores
				{
					id = 0,
					name = (string)Application.Current.TryFindResource("SelectStore2")
				}
			};
			if (this.StoreTypes == null)
			{
				this.StoreTypes = storeModel.LoadStoreTypes();
			}
			if (this.StoreSubTypes == null)
			{
				this.StoreSubTypes = storeModel.LoadStoreSubTypes();
			}
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x000B6164 File Offset: 0x000B4364
		private void HideNewStore(object obj)
		{
			this.CreateStore = false;
			this.CanCopyCategories = false;
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x000B6180 File Offset: 0x000B4380
		private bool ChechStoreFields()
		{
			if (string.IsNullOrEmpty(this.SelectedStore.name))
			{
				DXMessageBox.Show(Application.Current.TryFindResource("InputStoreName").ToString());
				return false;
			}
			int? office = this.SelectedStore.office;
			if (office.GetValueOrDefault() == 0 & office != null)
			{
				DXMessageBox.Show(Application.Current.TryFindResource("SelectStoreOffice").ToString());
				return false;
			}
			if (this.SelectedStore.type == 0)
			{
				DXMessageBox.Show(Application.Current.TryFindResource("SelectStoreType").ToString());
				return false;
			}
			if (this.SelectedStore.type == 1)
			{
				if (this.SelectedStore.office == null)
				{
					DXMessageBox.Show(Application.Current.TryFindResource("SelectStoreOffice").ToString());
					return false;
				}
			}
			if (this.SelectedStore.Archive && StoreModel.HaveAnyItem(this.SelectedStore.id))
			{
				DXMessageBox.Show(Application.Current.TryFindResource("StoreArchiveWarning").ToString());
				return false;
			}
			return true;
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x000B62A0 File Offset: 0x000B44A0
		private void CreateNewStore(object obj)
		{
			if (!this.ChechStoreFields())
			{
				return;
			}
			if (this.SelectedStore.type == 2)
			{
				this.SelectedStore.office = null;
			}
			this._context.stores.Add(this.SelectedStore);
			this.CreateNewBoxes();
			this._history.Add(32, new string[]
			{
				this.SelectedStore.name
			});
			if (base.SaveContext(true))
			{
				if (this.CopyStoreId > 0)
				{
					this.CopyStoreCategories(this.CopyStoreId, this.SelectedStore.id);
				}
				this.ClearStoreFields();
				this.RefreshStores();
			}
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x000B634C File Offset: 0x000B454C
		private void CopyStoreCategories(int storeId, int newStoreId)
		{
			StoreViewModel.<CopyStoreCategories>d__100 <CopyStoreCategories>d__;
			<CopyStoreCategories>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CopyStoreCategories>d__.<>4__this = this;
			<CopyStoreCategories>d__.storeId = storeId;
			<CopyStoreCategories>d__.newStoreId = newStoreId;
			<CopyStoreCategories>d__.<>1__state = -1;
			<CopyStoreCategories>d__.<>t__builder.Start<StoreViewModel.<CopyStoreCategories>d__100>(ref <CopyStoreCategories>d__);
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x000B6394 File Offset: 0x000B4594
		private void CopyChildCategories(List<KeyValuePair<int, int>> categories, int newStoreId)
		{
			if (categories.Count > 0)
			{
				StoreModel storeModel = new StoreModel();
				List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
				IEnumerable<store_cats> enumerable = storeModel.LoadStoreChildCategories((from c in categories
				select c.Key).ToList<int>());
				try
				{
					using (auseceEntities auseceEntities = new auseceEntities(true))
					{
						using (IEnumerator<store_cats> enumerator = enumerable.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								store_cats category = enumerator.Current;
								int value = (from c in categories.Where(delegate(KeyValuePair<int, int> c)
								{
									int key = c.Key;
									int? parent = category.parent;
									return key == parent.GetValueOrDefault() & parent != null;
								})
								select c.Value).FirstOrDefault<int>();
								store_cats store_cats = new store_cats
								{
									name = category.name,
									position = category.position,
									store_id = new int?(newStoreId),
									parent = new int?(value),
									enable = category.enable
								};
								auseceEntities.store_cats.Add(store_cats);
								auseceEntities.SaveChanges();
								list.Add(new KeyValuePair<int, int>(category.id, store_cats.id));
							}
						}
					}
					goto IL_171;
				}
				catch (Exception exception)
				{
					GenericModel.Log.Error(exception, "Copy child categories fail");
				}
				return;
				IL_171:
				this.CopyChildCategories(list, newStoreId);
			}
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x000B6568 File Offset: 0x000B4768
		private List<KeyValuePair<int, int>> CopyRootCategories(int newStoreId, List<store_cats> rootCategories)
		{
			List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
			List<KeyValuePair<int, int>> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					foreach (store_cats store_cats in rootCategories)
					{
						store_cats store_cats2 = new store_cats
						{
							name = store_cats.name,
							position = store_cats.position,
							store_id = new int?(newStoreId),
							parent = null,
							enable = store_cats.enable
						};
						auseceEntities.store_cats.Add(store_cats2);
						auseceEntities.SaveChanges();
						list.Add(new KeyValuePair<int, int>(store_cats.id, store_cats2.id));
					}
					result = list;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Copy root categories fail");
				result = new List<KeyValuePair<int, int>>();
			}
			return result;
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x000B667C File Offset: 0x000B487C
		private void RefreshStores()
		{
			if (!this._bgInit.IsBusy)
			{
				this._bgInit.RunWorkerAsync();
			}
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x000B66A4 File Offset: 0x000B48A4
		private void CreateNewBoxes()
		{
			bool flag = false;
			foreach (boxes boxes in this.Boxes)
			{
				if (boxes.id == 0 && !string.IsNullOrEmpty(boxes.name))
				{
					base.CreateBox(boxes, this.SelectedStore.id);
					flag = true;
				}
			}
			if (flag)
			{
				this._history.Add(33, new string[]
				{
					this.SelectedStore.name
				});
			}
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x000B673C File Offset: 0x000B493C
		private void ShowNewStore(object obj)
		{
			this.CreateStore = true;
			this.SelectedStore = new stores
			{
				sub_type = 1,
				active = true
			};
			this.Boxes = new ObservableCollection<boxes>();
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x000B6774 File Offset: 0x000B4974
		private void ClearStoreFields()
		{
			this.SelectedStore = null;
			this.Boxes = null;
			this.DelBoxes = null;
			this.CreateStore = false;
			this.AdditionalFields = new ObservableCollection<store_fields>();
			this.CopyStoreId = 0;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x000B67B0 File Offset: 0x000B49B0
		private void ControlLoaded(object obj)
		{
			this.SelectedStore = null;
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x000B67C4 File Offset: 0x000B49C4
		[CompilerGenerated]
		private bool <RemoveBox>b__94_0(boxes b)
		{
			return b == this.SelectedBox;
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x000B67DC File Offset: 0x000B49DC
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x04001EB0 RID: 7856
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001EB1 RID: 7857
		private BackgroundWorker _bgInit = new BackgroundWorker();

		// Token: 0x04001EB2 RID: 7858
		[CompilerGenerated]
		private ObservableCollection<stores> <Stores>k__BackingField;

		// Token: 0x04001EB3 RID: 7859
		[CompilerGenerated]
		private List<stores> <CopyFromStores>k__BackingField;

		// Token: 0x04001EB4 RID: 7860
		[CompilerGenerated]
		private bool <CanCopyCategories>k__BackingField;

		// Token: 0x04001EB5 RID: 7861
		[CompilerGenerated]
		private int <CopyStoreId>k__BackingField;

		// Token: 0x04001EB6 RID: 7862
		private DbPropertyValues _originalStoreValues;

		// Token: 0x04001EB7 RID: 7863
		private stores _selectedStore;

		// Token: 0x04001EB8 RID: 7864
		[CompilerGenerated]
		private ObservableCollection<boxes> <Boxes>k__BackingField;

		// Token: 0x04001EB9 RID: 7865
		[CompilerGenerated]
		private boxes <SelectedBox>k__BackingField;

		// Token: 0x04001EBA RID: 7866
		[CompilerGenerated]
		private List<int> <DelBoxes>k__BackingField;

		// Token: 0x04001EBB RID: 7867
		[CompilerGenerated]
		private List<int> <DelAddFields>k__BackingField;

		// Token: 0x04001EBC RID: 7868
		[CompilerGenerated]
		private List<offices> <Offices>k__BackingField;

		// Token: 0x04001EBD RID: 7869
		[CompilerGenerated]
		private List<store_types> <StoreTypes>k__BackingField;

		// Token: 0x04001EBE RID: 7870
		[CompilerGenerated]
		private List<store_sub_types> <StoreSubTypes>k__BackingField;

		// Token: 0x04001EBF RID: 7871
		[CompilerGenerated]
		private ObservableCollection<store_fields> <AdditionalFields>k__BackingField;

		// Token: 0x04001EC0 RID: 7872
		[CompilerGenerated]
		private bool <CreateStore>k__BackingField;

		// Token: 0x04001EC1 RID: 7873
		[CompilerGenerated]
		private ICommand <ShowNewStoreCommand>k__BackingField;

		// Token: 0x04001EC2 RID: 7874
		[CompilerGenerated]
		private ICommand <RemoveBoxCommand>k__BackingField;

		// Token: 0x04001EC3 RID: 7875
		[CompilerGenerated]
		private ICommand <CancelCommand>k__BackingField;

		// Token: 0x04001EC4 RID: 7876
		[CompilerGenerated]
		private ICommand <HideNewStoreCommand>k__BackingField;

		// Token: 0x04001EC5 RID: 7877
		[CompilerGenerated]
		private ICommand <CreateNewStoreCommand>k__BackingField;

		// Token: 0x04001EC6 RID: 7878
		[CompilerGenerated]
		private ICommand <SaveExistStoreCommand>k__BackingField;

		// Token: 0x04001EC7 RID: 7879
		[CompilerGenerated]
		private ICommand <ControlLoadedCommand>k__BackingField;

		// Token: 0x020005A2 RID: 1442
		[CompilerGenerated]
		private sealed class <>c__DisplayClass92_0
		{
			// Token: 0x06003589 RID: 13705 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass92_0()
			{
			}

			// Token: 0x04001EC8 RID: 7880
			public int id;
		}

		// Token: 0x020005A3 RID: 1443
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600358A RID: 13706 RVA: 0x000B6800 File Offset: 0x000B4A00
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600358B RID: 13707 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600358C RID: 13708 RVA: 0x000B6818 File Offset: 0x000B4A18
			internal int <CopyChildCategories>b__101_0(KeyValuePair<int, int> c)
			{
				return c.Key;
			}

			// Token: 0x0600358D RID: 13709 RVA: 0x000B682C File Offset: 0x000B4A2C
			internal int <CopyChildCategories>b__101_2(KeyValuePair<int, int> c)
			{
				return c.Value;
			}

			// Token: 0x04001EC9 RID: 7881
			public static readonly StoreViewModel.<>c <>9 = new StoreViewModel.<>c();

			// Token: 0x04001ECA RID: 7882
			public static Func<KeyValuePair<int, int>, int> <>9__101_0;

			// Token: 0x04001ECB RID: 7883
			public static Func<KeyValuePair<int, int>, int> <>9__101_2;
		}

		// Token: 0x020005A4 RID: 1444
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CopyStoreCategories>d__100 : IAsyncStateMachine
		{
			// Token: 0x0600358E RID: 13710 RVA: 0x000B6840 File Offset: 0x000B4A40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StoreViewModel storeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						awaiter = new StoreModel().LoadRootNodes(this.storeId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, StoreViewModel.<CopyStoreCategories>d__100>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
					}
					List<store_cats> result = awaiter.GetResult();
					List<KeyValuePair<int, int>> categories = storeViewModel.CopyRootCategories(this.newStoreId, result);
					storeViewModel.CopyChildCategories(categories, this.newStoreId);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600358F RID: 13711 RVA: 0x000B6920 File Offset: 0x000B4B20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001ECC RID: 7884
			public int <>1__state;

			// Token: 0x04001ECD RID: 7885
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001ECE RID: 7886
			public int storeId;

			// Token: 0x04001ECF RID: 7887
			public StoreViewModel <>4__this;

			// Token: 0x04001ED0 RID: 7888
			public int newStoreId;

			// Token: 0x04001ED1 RID: 7889
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x020005A5 RID: 1445
		[CompilerGenerated]
		private sealed class <>c__DisplayClass101_0
		{
			// Token: 0x06003590 RID: 13712 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass101_0()
			{
			}

			// Token: 0x06003591 RID: 13713 RVA: 0x000B693C File Offset: 0x000B4B3C
			internal bool <CopyChildCategories>b__1(KeyValuePair<int, int> c)
			{
				int key = c.Key;
				int? parent = this.category.parent;
				return key == parent.GetValueOrDefault() & parent != null;
			}

			// Token: 0x04001ED2 RID: 7890
			public store_cats category;
		}
	}
}
