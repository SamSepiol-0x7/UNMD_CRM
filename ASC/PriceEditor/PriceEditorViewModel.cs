using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;

namespace ASC.PriceEditor
{
	// Token: 0x02000239 RID: 569
	public class PriceEditorViewModel : CollectionViewModel<store_items>
	{
		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0005A408 File Offset: 0x00058608
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0005A41C File Offset: 0x0005861C
		public List<stores> Stores
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
				this.RaisePropertyChanged("Stores");
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0005A44C File Offset: 0x0005864C
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0005A460 File Offset: 0x00058660
		public List<items_state> ItemStatesWithAll
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemStatesWithAll>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemStatesWithAll>k__BackingField, value))
				{
					return;
				}
				this.<ItemStatesWithAll>k__BackingField = value;
				this.RaisePropertyChanged("ItemStatesWithAll");
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0005A490 File Offset: 0x00058690
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x0005A4A4 File Offset: 0x000586A4
		public List<items_state> ItemStates
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemStates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemStates>k__BackingField, value))
				{
					return;
				}
				this.<ItemStates>k__BackingField = value;
				this.RaisePropertyChanged("ItemStates");
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0005A4D4 File Offset: 0x000586D4
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0005A4E8 File Offset: 0x000586E8
		public List<store_cats> StoreCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<StoreCategories>k__BackingField, value))
				{
					return;
				}
				this.<StoreCategories>k__BackingField = value;
				this.RaisePropertyChanged("StoreCategories");
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0005A518 File Offset: 0x00058718
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x0005A52C File Offset: 0x0005872C
		public List<store_cats> ItemCategories
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemCategories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemCategories>k__BackingField, value))
				{
					return;
				}
				this.<ItemCategories>k__BackingField = value;
				this.RaisePropertyChanged("ItemCategories");
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0005A55C File Offset: 0x0005875C
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x0005A570 File Offset: 0x00058770
		public List<ItemsOptions> ItemsOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemsOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemsOptionses>k__BackingField, value))
				{
					return;
				}
				this.<ItemsOptionses>k__BackingField = value;
				this.RaisePropertyChanged("ItemsOptionses");
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0005A5A0 File Offset: 0x000587A0
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0005A5B4 File Offset: 0x000587B4
		public List<fields> Attributes
		{
			[CompilerGenerated]
			get
			{
				return this.<Attributes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Attributes>k__BackingField, value))
				{
					return;
				}
				this.<Attributes>k__BackingField = value;
				this.RaisePropertyChanged("Attributes");
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0005A5E4 File Offset: 0x000587E4
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x0005A5F8 File Offset: 0x000587F8
		public fields SelectedAttribute
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedAttribute>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedAttribute>k__BackingField, value))
				{
					return;
				}
				this.<SelectedAttribute>k__BackingField = value;
				this.RaisePropertyChanged("SelectedAttribute");
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0005A628 File Offset: 0x00058828
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0005A63C File Offset: 0x0005883C
		public string AttributeValue
		{
			[CompilerGenerated]
			get
			{
				return this.<AttributeValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<AttributeValue>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AttributeValue>k__BackingField = value;
				this.RaisePropertyChanged("AttributeValue");
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0005A66C File Offset: 0x0005886C
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0005A680 File Offset: 0x00058880
		public decimal PriceValue
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceValue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<PriceValue>k__BackingField, value))
				{
					return;
				}
				this.<PriceValue>k__BackingField = value;
				this.RaisePropertyChanged("PriceValue");
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0005A6B0 File Offset: 0x000588B0
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0005A6C4 File Offset: 0x000588C4
		public List<KeyValuePair<int, string>> PriceMode
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PriceMode>k__BackingField, value))
				{
					return;
				}
				this.<PriceMode>k__BackingField = value;
				this.RaisePropertyChanged("PriceMode");
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0005A6F4 File Offset: 0x000588F4
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0005A708 File Offset: 0x00058908
		public int SelectedPriceMode
		{
			get
			{
				return this._selectedPriceMode;
			}
			set
			{
				if (this._selectedPriceMode == value)
				{
					return;
				}
				this._selectedPriceMode = value;
				this.RaisePropertyChanged("SecondPriceColumnVisible");
				this.RaisePropertyChanged("SecondPriceColumnVisibleInv");
				this.RaisePropertyChanged("SelectedPriceMode");
				base.RaisePropertyChanged<bool>(() => this.SecondPriceColumnVisible);
				base.RaisePropertyChanged<bool>(() => this.SecondPriceColumnVisibleInv);
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0005A7B4 File Offset: 0x000589B4
		public bool SecondPriceColumnVisible
		{
			get
			{
				return this.SelectedPriceMode == 4;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0005A7CC File Offset: 0x000589CC
		public bool SecondPriceColumnVisibleInv
		{
			get
			{
				return !this.SecondPriceColumnVisible;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0005A7E4 File Offset: 0x000589E4
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0005A7F8 File Offset: 0x000589F8
		public List<KeyValuePair<int, string>> PriceColumns
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceColumns>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<PriceColumns>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1828012726;
				IL_13:
				switch ((num ^ -1449101819) % 4)
				{
				case 0:
					IL_32:
					this.<PriceColumns>k__BackingField = value;
					this.RaisePropertyChanged("PriceColumns");
					num = -2018913436;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0005A854 File Offset: 0x00058A54
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0005A868 File Offset: 0x00058A68
		public int SelectedPriceColumn
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedPriceColumn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedPriceColumn>k__BackingField == value)
				{
					return;
				}
				this.<SelectedPriceColumn>k__BackingField = value;
				this.RaisePropertyChanged("SelectedPriceColumn");
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0005A894 File Offset: 0x00058A94
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0005A8A8 File Offset: 0x00058AA8
		public int SelectedSecondPriceColumn
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedSecondPriceColumn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedSecondPriceColumn>k__BackingField == value)
				{
					return;
				}
				this.<SelectedSecondPriceColumn>k__BackingField = value;
				this.RaisePropertyChanged("SelectedSecondPriceColumn");
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0005A8D4 File Offset: 0x00058AD4
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		public int SelectedItemsBox
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItemsBox>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedItemsBox>k__BackingField == value)
				{
					return;
				}
				this.<SelectedItemsBox>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItemsBox");
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0005A914 File Offset: 0x00058B14
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x0005A928 File Offset: 0x00058B28
		public int SelectedItemsState
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItemsState>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedItemsState>k__BackingField == value)
				{
					return;
				}
				this.<SelectedItemsState>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItemsState");
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0005A954 File Offset: 0x00058B54
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0005A968 File Offset: 0x00058B68
		public List<boxes> Boxes
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
				this.RaisePropertyChanged("Boxes");
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0005A998 File Offset: 0x00058B98
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0005A9AC File Offset: 0x00058BAC
		public string ItemShopDescription
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemShopDescription>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<ItemShopDescription>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 493801356;
				IL_14:
				switch ((num ^ 1146694803) % 4)
				{
				case 0:
					goto IL_0F;
				case 2:
					IL_33:
					num = 1630109182;
					goto IL_14;
				case 3:
					return;
				}
				this.<ItemShopDescription>k__BackingField = value;
				this.RaisePropertyChanged("ItemShopDescription");
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0005AA08 File Offset: 0x00058C08
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0005AA1C File Offset: 0x00058C1C
		public bool SearchInDescription
		{
			[CompilerGenerated]
			get
			{
				return this.<SearchInDescription>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SearchInDescription>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -698749113;
				IL_10:
				switch ((num ^ -1289938403) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					return;
				case 3:
					IL_2F:
					num = -297407568;
					goto IL_10;
				}
				this.<SearchInDescription>k__BackingField = value;
				this.RaisePropertyChanged("SearchInDescription");
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0005AA74 File Offset: 0x00058C74
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0005AA88 File Offset: 0x00058C88
		public bool SelectAll
		{
			get
			{
				return this._selectAll;
			}
			set
			{
				if (this._selectAll == value)
				{
					return;
				}
				this._selectAll = value;
				this.RaisePropertyChanged("SelectAll");
				if (base.Items != null)
				{
					foreach (store_items store_items in base.Items)
					{
						store_items.Selected = value;
					}
				}
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0005AAFC File Offset: 0x00058CFC
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0005AB10 File Offset: 0x00058D10
		public stores SelectedStore
		{
			get
			{
				return this._selectedStore;
			}
			set
			{
				if (object.Equals(this._selectedStore, value))
				{
					return;
				}
				this._selectedStore = value;
				this.RaisePropertyChanged("SelectedStore");
				this.LoadStoreCategories_();
				this.LoadStoreBoxes();
				base.Items.Clear();
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0005AB58 File Offset: 0x00058D58
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0005AB6C File Offset: 0x00058D6C
		public string Query
		{
			[CompilerGenerated]
			get
			{
				return this.<Query>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Query>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -972873981;
				IL_14:
				switch ((num ^ -1232993740) % 4)
				{
				case 0:
					IL_33:
					this.<Query>k__BackingField = value;
					this.RaisePropertyChanged("Query");
					num = -224542627;
					goto IL_14;
				case 2:
					goto IL_0F;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0005ABC8 File Offset: 0x00058DC8
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0005ABDC File Offset: 0x00058DDC
		public int SelectedStoreCategory
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStoreCategory>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedStoreCategory>k__BackingField == value)
				{
					return;
				}
				this.<SelectedStoreCategory>k__BackingField = value;
				this.RaisePropertyChanged("SelectedStoreCategory");
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0005AC08 File Offset: 0x00058E08
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x0005AC1C File Offset: 0x00058E1C
		public int SelectedItemsCategory
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItemsCategory>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedItemsCategory>k__BackingField == value)
				{
					return;
				}
				this.<SelectedItemsCategory>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItemsCategory");
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0005AC48 File Offset: 0x00058E48
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x0005AC5C File Offset: 0x00058E5C
		public int SelectedState
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedState>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedState>k__BackingField == value)
				{
					return;
				}
				this.<SelectedState>k__BackingField = value;
				this.RaisePropertyChanged("SelectedState");
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0005AC88 File Offset: 0x00058E88
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x0005AC9C File Offset: 0x00058E9C
		public int SelectedItemOption
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItemOption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedItemOption>k__BackingField == value)
				{
					return;
				}
				this.<SelectedItemOption>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItemOption");
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0005ACC8 File Offset: 0x00058EC8
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x0005ACDC File Offset: 0x00058EDC
		public ICommand RefreshCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RefreshCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RefreshCommand>k__BackingField, value))
				{
					return;
				}
				this.<RefreshCommand>k__BackingField = value;
				this.RaisePropertyChanged("RefreshCommand");
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0005AD0C File Offset: 0x00058F0C
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x0005AD20 File Offset: 0x00058F20
		public RelayCommand SaveCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SaveCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2052838263;
				IL_13:
				switch ((num ^ 504549126) % 4)
				{
				case 0:
					IL_32:
					this.<SaveCommand>k__BackingField = value;
					num = 1580897292;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("SaveCommand");
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0005AD7C File Offset: 0x00058F7C
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x0005AD90 File Offset: 0x00058F90
		public ICommand ApplyPriceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ApplyPriceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ApplyPriceCommand>k__BackingField, value))
				{
					return;
				}
				this.<ApplyPriceCommand>k__BackingField = value;
				this.RaisePropertyChanged("ApplyPriceCommand");
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0005ADC0 File Offset: 0x00058FC0
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0005ADD4 File Offset: 0x00058FD4
		public ICommand ApplyCategoryCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ApplyCategoryCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ApplyCategoryCommand>k__BackingField, value))
				{
					return;
				}
				this.<ApplyCategoryCommand>k__BackingField = value;
				this.RaisePropertyChanged("ApplyCategoryCommand");
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0005AE04 File Offset: 0x00059004
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0005AE18 File Offset: 0x00059018
		public ICommand ApplyBoxCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ApplyBoxCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ApplyBoxCommand>k__BackingField, value))
				{
					return;
				}
				this.<ApplyBoxCommand>k__BackingField = value;
				this.RaisePropertyChanged("ApplyBoxCommand");
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0005AE48 File Offset: 0x00059048
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x0005AE5C File Offset: 0x0005905C
		public ICommand ApplyShopDescriptionCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ApplyShopDescriptionCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ApplyShopDescriptionCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1343432116;
				IL_13:
				switch ((num ^ 1581971037) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<ApplyShopDescriptionCommand>k__BackingField = value;
					this.RaisePropertyChanged("ApplyShopDescriptionCommand");
					num = 1717588999;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0005AEB8 File Offset: 0x000590B8
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x0005AECC File Offset: 0x000590CC
		public ICommand ApplyStateCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ApplyStateCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ApplyStateCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 279105648;
				IL_13:
				switch ((num ^ 900436893) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<ApplyStateCommand>k__BackingField = value;
					this.RaisePropertyChanged("ApplyStateCommand");
					num = 788652694;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0005AF28 File Offset: 0x00059128
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x0005AF3C File Offset: 0x0005913C
		public ICommand RollBackCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RollBackCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<RollBackCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2088423388;
				IL_13:
				switch ((num ^ 1901326347) % 4)
				{
				case 0:
					IL_32:
					this.<RollBackCommand>k__BackingField = value;
					this.RaisePropertyChanged("RollBackCommand");
					num = 549232346;
					goto IL_13;
				case 2:
					goto IL_0E;
				case 3:
					return;
				}
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0005AF98 File Offset: 0x00059198
		private void InitCommands()
		{
			this.RefreshCommand = new RelayCommand(new Action<object>(this.Refresh));
			this.SaveCommand = new RelayCommand(new Action<object>(this.Save));
			this.ApplyPriceCommand = new RelayCommand(new Action<object>(this.ApplyPrice));
			this.ApplyCategoryCommand = new RelayCommand(new Action<object>(this.ApplyCategory));
			this.RollBackCommand = new RelayCommand(new Action<object>(this.RollBackClick));
			this.ApplyBoxCommand = new RelayCommand(new Action<object>(this.ApplyBox));
			this.ApplyShopDescriptionCommand = new RelayCommand(new Action<object>(this.ApplyShopDescription));
			this.ApplyStateCommand = new RelayCommand(new Action<object>(this.ApplyState));
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0005B060 File Offset: 0x00059260
		public PriceEditorViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._additionalFieldsService = Bootstrapper.Container.Resolve<IAdditionalFieldsService>();
			this._priceEditorService = Bootstrapper.Container.Resolve<IPriceEditorService>();
			this.SetViewName("GroupItemsEditor");
			this.PriceMode = new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(1, Lang.t("Set")),
				new KeyValuePair<int, string>(2, "+"),
				new KeyValuePair<int, string>(3, "-"),
				new KeyValuePair<int, string>(4, Lang.t("FromColumn"))
			};
			this.PriceColumns = new List<KeyValuePair<int, string>>();
			if (Auth.Config.it_vis_price_for_sc)
			{
				this.PriceColumns.Add(new KeyValuePair<int, string>(1, Lang.t("PriceForSc")));
			}
			if (Auth.Config.it_vis_rozn)
			{
				this.PriceColumns.Add(new KeyValuePair<int, string>(2, Lang.t("PriceForSale")));
			}
			if (Auth.Config.it_vis_opt)
			{
				this.PriceColumns.Add(new KeyValuePair<int, string>(3, Lang.t("PriceOpt")));
			}
			this.LoadStores();
			List<stores> stores = this.Stores;
			stores selectedStore;
			if (stores == null)
			{
				selectedStore = null;
			}
			else
			{
				selectedStore = stores.FirstOrDefault((stores s) => s.id == OfflineData.Instance.Employee.StoreDefault);
			}
			this.SelectedStore = selectedStore;
			this.LoadItemStates();
			List<items_state> list = new List<items_state>(this.ItemStatesWithAll);
			list.RemoveAt(0);
			this.ItemStates = list;
			this.ItemsOptionses = StoreModel.LoadItemsOptionses();
			this.LoadAttributes();
			this.InitCommands();
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0005B234 File Offset: 0x00059434
		private void LoadAttributes()
		{
			PriceEditorViewModel.<LoadAttributes>d__152 <LoadAttributes>d__;
			<LoadAttributes>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadAttributes>d__.<>4__this = this;
			<LoadAttributes>d__.<>1__state = -1;
			<LoadAttributes>d__.<>t__builder.Start<PriceEditorViewModel.<LoadAttributes>d__152>(ref <LoadAttributes>d__);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0005B26C File Offset: 0x0005946C
		private void LoadItemStates()
		{
			PriceEditorViewModel.<LoadItemStates>d__153 <LoadItemStates>d__;
			<LoadItemStates>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItemStates>d__.<>4__this = this;
			<LoadItemStates>d__.<>1__state = -1;
			<LoadItemStates>d__.<>t__builder.Start<PriceEditorViewModel.<LoadItemStates>d__153>(ref <LoadItemStates>d__);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0005B2A4 File Offset: 0x000594A4
		private void LoadStores()
		{
			PriceEditorViewModel.<LoadStores>d__154 <LoadStores>d__;
			<LoadStores>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadStores>d__.<>4__this = this;
			<LoadStores>d__.<>1__state = -1;
			<LoadStores>d__.<>t__builder.Start<PriceEditorViewModel.<LoadStores>d__154>(ref <LoadStores>d__);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0005B2DC File Offset: 0x000594DC
		private void BgLoadItems()
		{
			PriceEditorViewModel.<BgLoadItems>d__155 <BgLoadItems>d__;
			<BgLoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgLoadItems>d__.<>4__this = this;
			<BgLoadItems>d__.<>1__state = -1;
			<BgLoadItems>d__.<>t__builder.Start<PriceEditorViewModel.<BgLoadItems>d__155>(ref <BgLoadItems>d__);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0005B314 File Offset: 0x00059514
		private bool CheckSearchFields()
		{
			if (this.SelectedStore == null)
			{
				this._toasterService.Info(Lang.t("SelectStore2"));
				return false;
			}
			return true;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0005B344 File Offset: 0x00059544
		private void Refresh(object obj)
		{
			if (!this.CheckSearchFields())
			{
				return;
			}
			this.BgLoadItems();
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0005B360 File Offset: 0x00059560
		private void LoadStoreCategories_()
		{
			PriceEditorViewModel.<LoadStoreCategories_>d__158 <LoadStoreCategories_>d__;
			<LoadStoreCategories_>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadStoreCategories_>d__.<>4__this = this;
			<LoadStoreCategories_>d__.<>1__state = -1;
			<LoadStoreCategories_>d__.<>t__builder.Start<PriceEditorViewModel.<LoadStoreCategories_>d__158>(ref <LoadStoreCategories_>d__);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0005B398 File Offset: 0x00059598
		private void Save(object obj)
		{
			PriceEditorViewModel.<Save>d__159 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<PriceEditorViewModel.<Save>d__159>(ref <Save>d__);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0005B3D0 File Offset: 0x000595D0
		private void ApplyPrice(object obj)
		{
			if (!base.Items.Any((store_items i) => i.Selected))
			{
				this._toasterService.Info(Lang.t("SelectItem"));
				return;
			}
			base.SelectedItem = null;
			foreach (store_items store_items in from i in base.Items
			where i.Selected
			select i)
			{
				switch (this.SelectedPriceColumn)
				{
				case 1:
					if (this.SelectedPriceMode == 1)
					{
						store_items.price = this.PriceValue;
					}
					if (this.SelectedPriceMode == 2)
					{
						store_items.price += this.PriceValue;
					}
					if (this.SelectedPriceMode == 3)
					{
						if (store_items.price - this.PriceValue > 0m)
						{
							store_items.price -= this.PriceValue;
						}
					}
					if (this.SelectedPriceMode == 4)
					{
						this.SetCol2Col1(store_items, this.SelectedSecondPriceColumn);
					}
					break;
				case 2:
					if (this.SelectedPriceMode == 1)
					{
						store_items.price2 = this.PriceValue;
					}
					if (this.SelectedPriceMode == 2)
					{
						store_items.price2 += this.PriceValue;
					}
					if (this.SelectedPriceMode == 3)
					{
						if (store_items.price2 - this.PriceValue > 0m)
						{
							store_items.price2 -= this.PriceValue;
						}
					}
					if (this.SelectedPriceMode == 4)
					{
						this.SetCol2Col2(store_items, this.SelectedSecondPriceColumn);
					}
					break;
				case 3:
					if (this.SelectedPriceMode == 1)
					{
						store_items.price3 = this.PriceValue;
					}
					if (this.SelectedPriceMode == 2)
					{
						store_items.price3 += this.PriceValue;
					}
					if (this.SelectedPriceMode == 3)
					{
						if (store_items.price3 - this.PriceValue > 0m)
						{
							store_items.price3 -= this.PriceValue;
						}
					}
					if (this.SelectedPriceMode == 4)
					{
						this.SetCol2Col3(store_items, this.SelectedSecondPriceColumn);
					}
					break;
				}
			}
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0005B670 File Offset: 0x00059870
		private void SetCol2Col1(store_items item, int fromCol)
		{
			switch (fromCol)
			{
			case 1:
				item.price = item.price;
				return;
			case 2:
				item.price = item.price2;
				return;
			case 3:
				item.price = item.price3;
				return;
			default:
				return;
			}
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0005B6B8 File Offset: 0x000598B8
		private void SetCol2Col2(store_items item, int fromCol)
		{
			int num;
			switch (fromCol)
			{
			case 1:
				IL_6E:
				item.price2 = item.price;
				return;
			case 2:
				IL_16:
				item.price2 = item.price2;
				num = -45475611;
				goto IL_2E;
			case 3:
				IL_59:
				item.price2 = item.price3;
				num = -283159923;
				goto IL_2E;
			}
			IL_29:
			num = -1950322718;
			IL_2E:
			switch ((num ^ -1033419106) % 7)
			{
			case 0:
				goto IL_29;
			case 1:
				return;
			case 2:
				return;
			case 3:
				goto IL_6E;
			case 4:
				goto IL_59;
			case 5:
				goto IL_16;
			}
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0005B740 File Offset: 0x00059940
		private void SetCol2Col3(store_items item, int fromCol)
		{
			int num;
			switch (fromCol)
			{
			case 1:
				IL_1B:
				item.price3 = item.price;
				num = 251026193;
				break;
			case 2:
				IL_57:
				item.price3 = item.price2;
				num = 413916841;
				break;
			case 3:
				IL_6D:
				item.price3 = item.price3;
				return;
			default:
				IL_14:
				num = 1475940145;
				break;
			}
			switch ((num ^ 1350023892) % 7)
			{
			case 0:
				return;
			case 1:
				return;
			case 2:
				goto IL_1B;
			case 3:
				goto IL_14;
			case 4:
				goto IL_57;
			case 5:
				return;
			case 6:
				goto IL_6D;
			default:
				goto IL_6D;
			}
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0005B7C8 File Offset: 0x000599C8
		private void LoadStoreBoxes()
		{
			if (this.SelectedStore != null && this.SelectedStore.id != 0)
			{
				Boxes boxes = new Boxes(this.SelectedStore.id);
				this.Boxes = boxes.Boxeses;
				return;
			}
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0005B808 File Offset: 0x00059A08
		private void RollBackClick(object obj)
		{
			this._priceEditorService.RejectChanges(base.Items);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0005B828 File Offset: 0x00059A28
		private void ApplyBox(object obj)
		{
			if (this.SelectedItemsBox == 0)
			{
				this._toasterService.Info(Lang.t("SelectBox"));
				return;
			}
			foreach (store_items store_items in from i in base.Items
			where i.Selected
			select i)
			{
				store_items.box = new int?(this.SelectedItemsBox);
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0005B8C0 File Offset: 0x00059AC0
		private void ApplyShopDescription(object obj)
		{
			foreach (store_items store_items in from i in base.Items
			where i.Selected
			select i)
			{
				store_items.shop_description = this.ItemShopDescription;
			}
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0005B938 File Offset: 0x00059B38
		private void ApplyCategory(object obj)
		{
			if (this.SelectedItemsCategory == 0)
			{
				this._toasterService.Info(Lang.t("InputCategory"));
				return;
			}
			foreach (store_items store_items in from i in base.Items
			where i.Selected
			select i)
			{
				store_items.category = this.SelectedItemsCategory;
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0005B9CC File Offset: 0x00059BCC
		private void ApplyState(object obj)
		{
			if (this.SelectedItemsState == 0)
			{
				this._toasterService.Info(Lang.t("SelectState"));
				return;
			}
			foreach (store_items store_items in from i in base.Items
			where i.Selected
			select i)
			{
				store_items.state = this.SelectedItemsState;
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0005BA60 File Offset: 0x00059C60
		[Command]
		public void RowDoubleClick(MouseButtonEventArgs e)
		{
			TableView tableView = e.Source as TableView;
			if (tableView != null)
			{
				GridControl gridControl = tableView.Parent as GridControl;
				TableViewHitInfo tableViewHitInfo = ((TableView)gridControl.View).CalcHitInfo(e.OriginalSource as DependencyObject);
				if (tableViewHitInfo.HitTest == TableViewHitTest.RowCell)
				{
					if (tableViewHitInfo.Column.Name == "UID")
					{
						store_items store_items = gridControl.GetRow(tableViewHitInfo.RowHandle) as store_items;
						if (store_items != null)
						{
							this._navigationService.NavigateToStoreItem(store_items.id, 0);
						}
					}
				}
				if (tableViewHitInfo.HitTest == TableViewHitTest.RowCell)
				{
					if (tableViewHitInfo.Column.Name.Contains("usercol_"))
					{
						store_items store_items2 = gridControl.GetRow(tableViewHitInfo.RowHandle) as store_items;
						if (store_items2 != null)
						{
							int id;
							int.TryParse(tableViewHitInfo.Column.Name.Replace("usercol_", ""), out id);
							this._windowedDocumentService.ShowNewDocument("AttributeValueEditView", new AttributeValueEditViewModel(store_items2, id), null, null);
						}
					}
				}
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0005BB68 File Offset: 0x00059D68
		[Command]
		public void NavigateItemCard()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(base.SelectedItem.id, 0);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00050258 File Offset: 0x0004E458
		public bool CanNavigateItemCard()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0005BB98 File Offset: 0x00059D98
		[Command]
		public void CellValueChanged(CellValueChangedEventArgs e)
		{
			PriceEditorViewModel.<CellValueChanged>d__173 <CellValueChanged>d__;
			<CellValueChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CellValueChanged>d__.<>4__this = this;
			<CellValueChanged>d__.e = e;
			<CellValueChanged>d__.<>1__state = -1;
			<CellValueChanged>d__.<>t__builder.Start<PriceEditorViewModel.<CellValueChanged>d__173>(ref <CellValueChanged>d__);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0005BBD8 File Offset: 0x00059DD8
		[Command]
		public void ResetHighlight()
		{
			PriceEditorViewModel.<ResetHighlight>d__174 <ResetHighlight>d__;
			<ResetHighlight>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ResetHighlight>d__.<>4__this = this;
			<ResetHighlight>d__.<>1__state = -1;
			<ResetHighlight>d__.<>t__builder.Start<PriceEditorViewModel.<ResetHighlight>d__174>(ref <ResetHighlight>d__);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0005BC10 File Offset: 0x00059E10
		public bool CanResetHighlight()
		{
			return base.SelectedItem != null && base.SelectedItem.ge_highlight;
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0005BC34 File Offset: 0x00059E34
		[Command]
		public void GroupHighlightReset()
		{
			PriceEditorViewModel.<GroupHighlightReset>d__176 <GroupHighlightReset>d__;
			<GroupHighlightReset>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GroupHighlightReset>d__.<>4__this = this;
			<GroupHighlightReset>d__.<>1__state = -1;
			<GroupHighlightReset>d__.<>t__builder.Start<PriceEditorViewModel.<GroupHighlightReset>d__176>(ref <GroupHighlightReset>d__);
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0005BC6C File Offset: 0x00059E6C
		public bool CanGroupHighlightReset()
		{
			if (base.Items != null)
			{
				return base.Items.Any((store_items i) => i.Selected && i.ge_highlight);
			}
			return false;
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0005BCB0 File Offset: 0x00059EB0
		[Command]
		public void ApplyAttribute()
		{
			foreach (store_items store_items in this.GetProductsWithAttributes())
			{
				field_values field_values = store_items.field_values.FirstOrDefault((field_values f) => f.field_id == this.SelectedAttribute.id);
				if (field_values == null)
				{
					field_values item = new field_values
					{
						field_id = this.SelectedAttribute.id,
						value = this.AttributeValue,
						item_id = new int?(store_items.id)
					};
					store_items.field_values.Add(item);
				}
				else
				{
					field_values.value = this.AttributeValue;
				}
				store_items.Attributes = new ObservableCollection<field_values>(store_items.field_values);
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0005BD80 File Offset: 0x00059F80
		public bool CanApplyAttribute()
		{
			return base.Items.Any((store_items i) => i.Selected) && this.SelectedAttribute != null;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0005BDC4 File Offset: 0x00059FC4
		private List<store_items> GetProductsWithAttributes()
		{
			return (from i in base.Items
			where i.Selected && i.field_values != null
			select i).ToList<store_items>();
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0005BE00 File Offset: 0x0005A000
		[CompilerGenerated]
		private Task<List<store_items>> <BgLoadItems>b__155_1()
		{
			return this._priceEditorService.LoadItems4Edit(this.SelectedStore.id, this.SelectedItemOption, this.SelectedStoreCategory, this.SelectedState, this.Query, this.SearchInDescription);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0005BE44 File Offset: 0x0005A044
		[CompilerGenerated]
		private Task <Save>b__159_0()
		{
			return this._priceEditorService.LogChanges(base.Items);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0005BE64 File Offset: 0x0005A064
		[CompilerGenerated]
		private bool <Save>b__159_1()
		{
			return this._priceEditorService.SaveContext();
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0005BE7C File Offset: 0x0005A07C
		[CompilerGenerated]
		private IAscResult <ResetHighlight>b__174_1()
		{
			return this._priceEditorService.SetHighlight(base.SelectedItem.id, false);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0005BEA0 File Offset: 0x0005A0A0
		[CompilerGenerated]
		private bool <ApplyAttribute>b__178_0(field_values f)
		{
			return f.field_id == this.SelectedAttribute.id;
		}

		// Token: 0x04001028 RID: 4136
		private readonly IPriceEditorService _priceEditorService;

		// Token: 0x04001029 RID: 4137
		private StoreModel _storeModel = new StoreModel();

		// Token: 0x0400102A RID: 4138
		private stores _selectedStore;

		// Token: 0x0400102B RID: 4139
		private bool _selectAll;

		// Token: 0x0400102C RID: 4140
		private int _selectedPriceMode = 1;

		// Token: 0x0400102D RID: 4141
		private readonly INavigationService _navigationService;

		// Token: 0x0400102E RID: 4142
		private readonly IToasterService _toasterService;

		// Token: 0x0400102F RID: 4143
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001030 RID: 4144
		private readonly IAdditionalFieldsService _additionalFieldsService;

		// Token: 0x04001031 RID: 4145
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x04001032 RID: 4146
		[CompilerGenerated]
		private List<items_state> <ItemStatesWithAll>k__BackingField;

		// Token: 0x04001033 RID: 4147
		[CompilerGenerated]
		private List<items_state> <ItemStates>k__BackingField;

		// Token: 0x04001034 RID: 4148
		[CompilerGenerated]
		private List<store_cats> <StoreCategories>k__BackingField;

		// Token: 0x04001035 RID: 4149
		[CompilerGenerated]
		private List<store_cats> <ItemCategories>k__BackingField;

		// Token: 0x04001036 RID: 4150
		[CompilerGenerated]
		private List<ItemsOptions> <ItemsOptionses>k__BackingField;

		// Token: 0x04001037 RID: 4151
		[CompilerGenerated]
		private List<fields> <Attributes>k__BackingField;

		// Token: 0x04001038 RID: 4152
		[CompilerGenerated]
		private fields <SelectedAttribute>k__BackingField;

		// Token: 0x04001039 RID: 4153
		[CompilerGenerated]
		private string <AttributeValue>k__BackingField;

		// Token: 0x0400103A RID: 4154
		[CompilerGenerated]
		private decimal <PriceValue>k__BackingField;

		// Token: 0x0400103B RID: 4155
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <PriceMode>k__BackingField;

		// Token: 0x0400103C RID: 4156
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <PriceColumns>k__BackingField;

		// Token: 0x0400103D RID: 4157
		[CompilerGenerated]
		private int <SelectedPriceColumn>k__BackingField;

		// Token: 0x0400103E RID: 4158
		[CompilerGenerated]
		private int <SelectedSecondPriceColumn>k__BackingField;

		// Token: 0x0400103F RID: 4159
		[CompilerGenerated]
		private int <SelectedItemsBox>k__BackingField;

		// Token: 0x04001040 RID: 4160
		[CompilerGenerated]
		private int <SelectedItemsState>k__BackingField;

		// Token: 0x04001041 RID: 4161
		[CompilerGenerated]
		private List<boxes> <Boxes>k__BackingField;

		// Token: 0x04001042 RID: 4162
		[CompilerGenerated]
		private string <ItemShopDescription>k__BackingField;

		// Token: 0x04001043 RID: 4163
		[CompilerGenerated]
		private bool <SearchInDescription>k__BackingField;

		// Token: 0x04001044 RID: 4164
		[CompilerGenerated]
		private string <Query>k__BackingField;

		// Token: 0x04001045 RID: 4165
		[CompilerGenerated]
		private int <SelectedStoreCategory>k__BackingField;

		// Token: 0x04001046 RID: 4166
		[CompilerGenerated]
		private int <SelectedItemsCategory>k__BackingField;

		// Token: 0x04001047 RID: 4167
		[CompilerGenerated]
		private int <SelectedState>k__BackingField;

		// Token: 0x04001048 RID: 4168
		[CompilerGenerated]
		private int <SelectedItemOption>k__BackingField = 2;

		// Token: 0x04001049 RID: 4169
		[CompilerGenerated]
		private ICommand <RefreshCommand>k__BackingField;

		// Token: 0x0400104A RID: 4170
		[CompilerGenerated]
		private RelayCommand <SaveCommand>k__BackingField;

		// Token: 0x0400104B RID: 4171
		[CompilerGenerated]
		private ICommand <ApplyPriceCommand>k__BackingField;

		// Token: 0x0400104C RID: 4172
		[CompilerGenerated]
		private ICommand <ApplyCategoryCommand>k__BackingField;

		// Token: 0x0400104D RID: 4173
		[CompilerGenerated]
		private ICommand <ApplyBoxCommand>k__BackingField;

		// Token: 0x0400104E RID: 4174
		[CompilerGenerated]
		private ICommand <ApplyShopDescriptionCommand>k__BackingField;

		// Token: 0x0400104F RID: 4175
		[CompilerGenerated]
		private ICommand <ApplyStateCommand>k__BackingField;

		// Token: 0x04001050 RID: 4176
		[CompilerGenerated]
		private ICommand <RollBackCommand>k__BackingField;

		// Token: 0x0200023A RID: 570
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002011 RID: 8209 RVA: 0x0005BEC0 File Offset: 0x0005A0C0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002012 RID: 8210 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002013 RID: 8211 RVA: 0x0004DAA4 File Offset: 0x0004BCA4
			internal bool <.ctor>b__151_0(stores s)
			{
				return s.id == OfflineData.Instance.Employee.StoreDefault;
			}

			// Token: 0x06002014 RID: 8212 RVA: 0x0005BED8 File Offset: 0x0005A0D8
			internal bool <ApplyPrice>b__160_0(store_items i)
			{
				return i.Selected;
			}

			// Token: 0x06002015 RID: 8213 RVA: 0x0005BED8 File Offset: 0x0005A0D8
			internal bool <ApplyPrice>b__160_1(store_items i)
			{
				return i.Selected;
			}

			// Token: 0x06002016 RID: 8214 RVA: 0x0005BED8 File Offset: 0x0005A0D8
			internal bool <ApplyBox>b__166_0(store_items i)
			{
				return i.Selected;
			}

			// Token: 0x06002017 RID: 8215 RVA: 0x0005BED8 File Offset: 0x0005A0D8
			internal bool <ApplyShopDescription>b__167_0(store_items i)
			{
				return i.Selected;
			}

			// Token: 0x06002018 RID: 8216 RVA: 0x0005BED8 File Offset: 0x0005A0D8
			internal bool <ApplyCategory>b__168_0(store_items i)
			{
				return i.Selected;
			}

			// Token: 0x06002019 RID: 8217 RVA: 0x0005BED8 File Offset: 0x0005A0D8
			internal bool <ApplyState>b__169_0(store_items i)
			{
				return i.Selected;
			}

			// Token: 0x0600201A RID: 8218 RVA: 0x0005BEEC File Offset: 0x0005A0EC
			internal bool <GroupHighlightReset>b__176_0(store_items i)
			{
				return i.Selected && i.ge_highlight;
			}

			// Token: 0x0600201B RID: 8219 RVA: 0x000503B4 File Offset: 0x0004E5B4
			internal int <GroupHighlightReset>b__176_1(store_items i)
			{
				return i.id;
			}

			// Token: 0x0600201C RID: 8220 RVA: 0x0005BEEC File Offset: 0x0005A0EC
			internal bool <CanGroupHighlightReset>b__177_0(store_items i)
			{
				return i.Selected && i.ge_highlight;
			}

			// Token: 0x0600201D RID: 8221 RVA: 0x0005BED8 File Offset: 0x0005A0D8
			internal bool <CanApplyAttribute>b__179_0(store_items i)
			{
				return i.Selected;
			}

			// Token: 0x0600201E RID: 8222 RVA: 0x0005BF0C File Offset: 0x0005A10C
			internal bool <GetProductsWithAttributes>b__180_0(store_items i)
			{
				return i.Selected && i.field_values != null;
			}

			// Token: 0x04001051 RID: 4177
			public static readonly PriceEditorViewModel.<>c <>9 = new PriceEditorViewModel.<>c();

			// Token: 0x04001052 RID: 4178
			public static Func<stores, bool> <>9__151_0;

			// Token: 0x04001053 RID: 4179
			public static Func<store_items, bool> <>9__160_0;

			// Token: 0x04001054 RID: 4180
			public static Func<store_items, bool> <>9__160_1;

			// Token: 0x04001055 RID: 4181
			public static Func<store_items, bool> <>9__166_0;

			// Token: 0x04001056 RID: 4182
			public static Func<store_items, bool> <>9__167_0;

			// Token: 0x04001057 RID: 4183
			public static Func<store_items, bool> <>9__168_0;

			// Token: 0x04001058 RID: 4184
			public static Func<store_items, bool> <>9__169_0;

			// Token: 0x04001059 RID: 4185
			public static Func<store_items, bool> <>9__176_0;

			// Token: 0x0400105A RID: 4186
			public static Func<store_items, int> <>9__176_1;

			// Token: 0x0400105B RID: 4187
			public static Func<store_items, bool> <>9__177_0;

			// Token: 0x0400105C RID: 4188
			public static Func<store_items, bool> <>9__179_0;

			// Token: 0x0400105D RID: 4189
			public static Func<store_items, bool> <>9__180_0;
		}

		// Token: 0x0200023B RID: 571
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadAttributes>d__152 : IAsyncStateMachine
		{
			// Token: 0x0600201F RID: 8223 RVA: 0x0005BF2C File Offset: 0x0005A12C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<fields>> awaiter;
					if (num != 0)
					{
						awaiter = priceEditorViewModel._additionalFieldsService.GetAdditionalFields(new bool?(true), false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<fields>>, PriceEditorViewModel.<LoadAttributes>d__152>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<fields>>);
						this.<>1__state = -1;
					}
					List<fields> result = awaiter.GetResult();
					priceEditorViewModel.Attributes = result;
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

			// Token: 0x06002020 RID: 8224 RVA: 0x0005BFF4 File Offset: 0x0005A1F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400105E RID: 4190
			public int <>1__state;

			// Token: 0x0400105F RID: 4191
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001060 RID: 4192
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001061 RID: 4193
			private TaskAwaiter<List<fields>> <>u__1;
		}

		// Token: 0x0200023C RID: 572
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItemStates>d__153 : IAsyncStateMachine
		{
			// Token: 0x06002021 RID: 8225 RVA: 0x0005C010 File Offset: 0x0005A210
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<items_state>> awaiter;
					if (num != 0)
					{
						awaiter = ItemsModel.LoadItemStates(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, PriceEditorViewModel.<LoadItemStates>d__153>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<items_state>>);
						this.<>1__state = -1;
					}
					List<items_state> result = awaiter.GetResult();
					priceEditorViewModel.ItemStatesWithAll = new List<items_state>(result);
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

			// Token: 0x06002022 RID: 8226 RVA: 0x0005C0D4 File Offset: 0x0005A2D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001062 RID: 4194
			public int <>1__state;

			// Token: 0x04001063 RID: 4195
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001064 RID: 4196
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001065 RID: 4197
			private TaskAwaiter<List<items_state>> <>u__1;
		}

		// Token: 0x0200023D RID: 573
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStores>d__154 : IAsyncStateMachine
		{
			// Token: 0x06002023 RID: 8227 RVA: 0x0005C0F0 File Offset: 0x0005A2F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<stores>> awaiter;
					if (num != 0)
					{
						awaiter = StoreModel.LoadStores(false, false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, PriceEditorViewModel.<LoadStores>d__154>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<stores>>);
						this.<>1__state = -1;
					}
					List<stores> result = awaiter.GetResult();
					priceEditorViewModel.Stores = result;
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

			// Token: 0x06002024 RID: 8228 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001066 RID: 4198
			public int <>1__state;

			// Token: 0x04001067 RID: 4199
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001068 RID: 4200
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001069 RID: 4201
			private TaskAwaiter<List<stores>> <>u__1;
		}

		// Token: 0x0200023E RID: 574
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgLoadItems>d__155 : IAsyncStateMachine
		{
			// Token: 0x06002025 RID: 8229 RVA: 0x0005C1CC File Offset: 0x0005A3CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_items>> awaiter;
					if (num != 0)
					{
						priceEditorViewModel.ShowWait();
						awaiter = Task.Run<List<store_items>>(() => priceEditorViewModel._priceEditorService.LoadItems4Edit(base.SelectedStore.id, base.SelectedItemOption, base.SelectedStoreCategory, base.SelectedState, base.Query, base.SearchInDescription)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, PriceEditorViewModel.<BgLoadItems>d__155>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_items>>);
						this.<>1__state = -1;
					}
					List<store_items> result = awaiter.GetResult();
					priceEditorViewModel.SetItems(result);
					priceEditorViewModel.HideWait();
					priceEditorViewModel.RaiseCanExecuteChanged(() => priceEditorViewModel.GroupHighlightReset());
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

			// Token: 0x06002026 RID: 8230 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400106A RID: 4202
			public int <>1__state;

			// Token: 0x0400106B RID: 4203
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400106C RID: 4204
			public PriceEditorViewModel <>4__this;

			// Token: 0x0400106D RID: 4205
			private TaskAwaiter<List<store_items>> <>u__1;
		}

		// Token: 0x0200023F RID: 575
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadStoreCategories_>d__158 : IAsyncStateMachine
		{
			// Token: 0x06002027 RID: 8231 RVA: 0x0005C2FC File Offset: 0x0005A4FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						if (priceEditorViewModel.SelectedStore == null || priceEditorViewModel.SelectedStore.id == 0)
						{
							goto IL_D7;
						}
						awaiter = priceEditorViewModel._storeModel.LoadStoreCategories(priceEditorViewModel.SelectedStore.id, true, false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, PriceEditorViewModel.<LoadStoreCategories_>d__158>(ref awaiter, ref this);
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
					priceEditorViewModel.StoreCategories = new List<store_cats>(result);
					List<store_cats> list = new List<store_cats>(priceEditorViewModel.StoreCategories);
					list.RemoveAt(0);
					priceEditorViewModel.ItemCategories = list;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_D7:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002028 RID: 8232 RVA: 0x0005C404 File Offset: 0x0005A604
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400106E RID: 4206
			public int <>1__state;

			// Token: 0x0400106F RID: 4207
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001070 RID: 4208
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001071 RID: 4209
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x02000240 RID: 576
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__159 : IAsyncStateMachine
		{
			// Token: 0x06002029 RID: 8233 RVA: 0x0005C420 File Offset: 0x0005A620
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<bool> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						goto IL_EE;
					case 2:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_16E;
					default:
						priceEditorViewModel.ShowWait();
						awaiter = Task.Run(() => priceEditorViewModel._priceEditorService.LogChanges(base.Items)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PriceEditorViewModel.<Save>d__159>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter2 = Task.Run<bool>(() => priceEditorViewModel._priceEditorService.SaveContext()).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, PriceEditorViewModel.<Save>d__159>(ref awaiter2, ref this);
						return;
					}
					IL_EE:
					bool result = awaiter2.GetResult();
					this.<result>5__2 = result;
					priceEditorViewModel.HideWait();
					if (!this.<result>5__2)
					{
						priceEditorViewModel._priceEditorService.ResetHistory();
						goto IL_175;
					}
					awaiter = priceEditorViewModel._priceEditorService.SaveHistory().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PriceEditorViewModel.<Save>d__159>(ref awaiter, ref this);
						return;
					}
					IL_16E:
					awaiter.GetResult();
					IL_175:
					priceEditorViewModel.ShowActionResponse(this.<result>5__2, "");
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

			// Token: 0x0600202A RID: 8234 RVA: 0x0005C600 File Offset: 0x0005A800
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001072 RID: 4210
			public int <>1__state;

			// Token: 0x04001073 RID: 4211
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001074 RID: 4212
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001075 RID: 4213
			private bool <result>5__2;

			// Token: 0x04001076 RID: 4214
			private TaskAwaiter <>u__1;

			// Token: 0x04001077 RID: 4215
			private TaskAwaiter<bool> <>u__2;
		}

		// Token: 0x02000241 RID: 577
		[CompilerGenerated]
		private sealed class <>c__DisplayClass173_0
		{
			// Token: 0x0600202B RID: 8235 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass173_0()
			{
			}

			// Token: 0x0600202C RID: 8236 RVA: 0x0005C61C File Offset: 0x0005A81C
			internal IAscResult <CellValueChanged>b__1()
			{
				return this.<>4__this._priceEditorService.SetHighlight(this.item.id, true);
			}

			// Token: 0x04001078 RID: 4216
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001079 RID: 4217
			public store_items item;
		}

		// Token: 0x02000242 RID: 578
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CellValueChanged>d__173 : IAsyncStateMachine
		{
			// Token: 0x0600202D RID: 8237 RVA: 0x0005C648 File Offset: 0x0005A848
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new PriceEditorViewModel.<>c__DisplayClass173_0();
						this.<>8__1.<>4__this = this.<>4__this;
						if (this.e.Column.Name == "Select")
						{
							goto IL_189;
						}
						object row = this.e.Row;
						this.<>8__1.item = (row as store_items);
						if (this.<>8__1.item == null)
						{
							goto IL_167;
						}
						if (this.<>8__1.item.ge_highlight)
						{
							goto IL_189;
						}
						awaiter = Task.Run<IAscResult>(new Func<IAscResult>(this.<>8__1.<CellValueChanged>b__1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PriceEditorViewModel.<CellValueChanged>d__173>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					if (!result.IsSucces)
					{
						priceEditorViewModel.ShowActionResponse(false, result.Message);
					}
					else
					{
						this.<>8__1.item.ge_highlight = true;
						priceEditorViewModel.RaiseCanExecuteChanged(() => priceEditorViewModel.GroupHighlightReset());
					}
					IL_167:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_189:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600202E RID: 8238 RVA: 0x0005C814 File Offset: 0x0005AA14
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400107A RID: 4218
			public int <>1__state;

			// Token: 0x0400107B RID: 4219
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400107C RID: 4220
			public PriceEditorViewModel <>4__this;

			// Token: 0x0400107D RID: 4221
			public CellValueChangedEventArgs e;

			// Token: 0x0400107E RID: 4222
			private PriceEditorViewModel.<>c__DisplayClass173_0 <>8__1;

			// Token: 0x0400107F RID: 4223
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x02000243 RID: 579
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ResetHighlight>d__174 : IAsyncStateMachine
		{
			// Token: 0x0600202F RID: 8239 RVA: 0x0005C830 File Offset: 0x0005AA30
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<IAscResult>(() => priceEditorViewModel._priceEditorService.SetHighlight(base.SelectedItem.id, false)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PriceEditorViewModel.<ResetHighlight>d__174>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						this.<>1__state = -1;
					}
					IAscResult result = awaiter.GetResult();
					if (result.IsSucces)
					{
						priceEditorViewModel.SelectedItem.ge_highlight = false;
						priceEditorViewModel.RaiseCanExecuteChanged(() => priceEditorViewModel.GroupHighlightReset());
					}
					else
					{
						priceEditorViewModel.ShowActionResponse(false, result.Message);
					}
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

			// Token: 0x06002030 RID: 8240 RVA: 0x0005C954 File Offset: 0x0005AB54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001080 RID: 4224
			public int <>1__state;

			// Token: 0x04001081 RID: 4225
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001082 RID: 4226
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001083 RID: 4227
			private TaskAwaiter<IAscResult> <>u__1;
		}

		// Token: 0x02000244 RID: 580
		[CompilerGenerated]
		private sealed class <>c__DisplayClass176_0
		{
			// Token: 0x06002031 RID: 8241 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass176_0()
			{
			}

			// Token: 0x06002032 RID: 8242 RVA: 0x0005C970 File Offset: 0x0005AB70
			internal IAscResult <GroupHighlightReset>b__3()
			{
				return this.<>4__this._priceEditorService.SetHighlight(this.itemIds, false);
			}

			// Token: 0x06002033 RID: 8243 RVA: 0x0005C994 File Offset: 0x0005AB94
			internal bool <GroupHighlightReset>b__4(store_items i)
			{
				return this.itemIds.Contains(i.id);
			}

			// Token: 0x04001084 RID: 4228
			public PriceEditorViewModel <>4__this;

			// Token: 0x04001085 RID: 4229
			public List<int> itemIds;

			// Token: 0x04001086 RID: 4230
			public Func<store_items, bool> <>9__4;
		}

		// Token: 0x02000245 RID: 581
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GroupHighlightReset>d__176 : IAsyncStateMachine
		{
			// Token: 0x06002034 RID: 8244 RVA: 0x0005C9B4 File Offset: 0x0005ABB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PriceEditorViewModel priceEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IAscResult> awaiter;
					if (num != 0)
					{
						this.<>8__1 = new PriceEditorViewModel.<>c__DisplayClass176_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.itemIds = priceEditorViewModel.Items.Where(new Func<store_items, bool>(PriceEditorViewModel.<>c.<>9.<GroupHighlightReset>b__176_0)).Select(new Func<store_items, int>(PriceEditorViewModel.<>c.<>9.<GroupHighlightReset>b__176_1)).ToList<int>();
						awaiter = Task.Run<IAscResult>(new Func<IAscResult>(this.<>8__1.<GroupHighlightReset>b__3)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, PriceEditorViewModel.<GroupHighlightReset>d__176>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IAscResult>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					IAscResult result = awaiter.GetResult();
					if (result.IsSucces)
					{
						IEnumerable<store_items> items = priceEditorViewModel.Items;
						Func<store_items, bool> predicate;
						if ((predicate = this.<>8__1.<>9__4) == null)
						{
							predicate = (this.<>8__1.<>9__4 = new Func<store_items, bool>(this.<>8__1.<GroupHighlightReset>b__4));
						}
						List<store_items>.Enumerator enumerator = items.Where(predicate).ToList<store_items>().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								store_items store_items = enumerator.Current;
								store_items.ge_highlight = false;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						priceEditorViewModel.RaiseCanExecuteChanged(() => priceEditorViewModel.GroupHighlightReset());
					}
					else
					{
						priceEditorViewModel.ShowActionResponse(false, result.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002035 RID: 8245 RVA: 0x0005CBF4 File Offset: 0x0005ADF4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001087 RID: 4231
			public int <>1__state;

			// Token: 0x04001088 RID: 4232
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001089 RID: 4233
			public PriceEditorViewModel <>4__this;

			// Token: 0x0400108A RID: 4234
			private PriceEditorViewModel.<>c__DisplayClass176_0 <>8__1;

			// Token: 0x0400108B RID: 4235
			private TaskAwaiter<IAscResult> <>u__1;
		}
	}
}
