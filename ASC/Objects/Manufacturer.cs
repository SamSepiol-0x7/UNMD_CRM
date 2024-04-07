using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x0200086E RID: 2158
	public class Manufacturer : BindableBase, IManufacturer, IIdName
	{
		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x000FF95C File Offset: 0x000FDB5C
		// (set) Token: 0x0600401C RID: 16412 RVA: 0x000FF970 File Offset: 0x000FDB70
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.RaisePropertyChanged("Id");
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x000FF99C File Offset: 0x000FDB9C
		// (set) Token: 0x0600401E RID: 16414 RVA: 0x000FF9B0 File Offset: 0x000FDBB0
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x000069B8 File Offset: 0x00004BB8
		public Manufacturer()
		{
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x000FF9E0 File Offset: 0x000FDBE0
		public Manufacturer(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x04002A09 RID: 10761
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A0A RID: 10762
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
