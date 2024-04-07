using System;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;

namespace ASC
{
	// Token: 0x02000025 RID: 37
	public class field_values : BindableBase
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000067A0 File Offset: 0x000049A0
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000067B4 File Offset: 0x000049B4
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<id>k__BackingField == value)
				{
					return;
				}
				this.<id>k__BackingField = value;
				this.RaisePropertyChanged("id");
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000067E0 File Offset: 0x000049E0
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000067F4 File Offset: 0x000049F4
		public int field_id
		{
			[CompilerGenerated]
			get
			{
				return this.<field_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<field_id>k__BackingField == value)
				{
					return;
				}
				this.<field_id>k__BackingField = value;
				this.RaisePropertyChanged("field_id");
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00006820 File Offset: 0x00004A20
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00006834 File Offset: 0x00004A34
		public int? repair_id
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<repair_id>k__BackingField, value))
				{
					return;
				}
				this.<repair_id>k__BackingField = value;
				this.RaisePropertyChanged("repair_id");
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00006864 File Offset: 0x00004A64
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00006878 File Offset: 0x00004A78
		public string value
		{
			[CompilerGenerated]
			get
			{
				return this.<value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<value>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<value>k__BackingField = value;
				this.RaisePropertyChanged("value");
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000068A8 File Offset: 0x00004AA8
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000068BC File Offset: 0x00004ABC
		public int? item_id
		{
			[CompilerGenerated]
			get
			{
				return this.<item_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<item_id>k__BackingField, value))
				{
					return;
				}
				this.<item_id>k__BackingField = value;
				this.RaisePropertyChanged("item_id");
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00006900 File Offset: 0x00004B00
		public virtual workshop workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<workshop>k__BackingField, value))
				{
					return;
				}
				this.<workshop>k__BackingField = value;
				this.RaisePropertyChanged("workshop");
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00006930 File Offset: 0x00004B30
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00006944 File Offset: 0x00004B44
		public virtual fields fields
		{
			[CompilerGenerated]
			get
			{
				return this.<fields>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<fields>k__BackingField, value))
				{
					return;
				}
				this.<fields>k__BackingField = value;
				this.RaisePropertyChanged("fields");
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00006974 File Offset: 0x00004B74
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00006988 File Offset: 0x00004B88
		public virtual store_items store_items
		{
			[CompilerGenerated]
			get
			{
				return this.<store_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<store_items>k__BackingField, value))
				{
					return;
				}
				this.<store_items>k__BackingField = value;
				this.RaisePropertyChanged("store_items");
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000069B8 File Offset: 0x00004BB8
		public field_values()
		{
		}

		// Token: 0x040000A0 RID: 160
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040000A1 RID: 161
		[CompilerGenerated]
		private int <field_id>k__BackingField;

		// Token: 0x040000A2 RID: 162
		[CompilerGenerated]
		private int? <repair_id>k__BackingField;

		// Token: 0x040000A3 RID: 163
		[CompilerGenerated]
		private string <value>k__BackingField;

		// Token: 0x040000A4 RID: 164
		[CompilerGenerated]
		private int? <item_id>k__BackingField;

		// Token: 0x040000A5 RID: 165
		[CompilerGenerated]
		private workshop <workshop>k__BackingField;

		// Token: 0x040000A6 RID: 166
		[CompilerGenerated]
		private fields <fields>k__BackingField;

		// Token: 0x040000A7 RID: 167
		[CompilerGenerated]
		private store_items <store_items>k__BackingField;
	}
}
