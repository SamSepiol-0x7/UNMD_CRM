using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x02000868 RID: 2152
	public class Device : BindableBase, IDevice, IIdName
	{
		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x000FF300 File Offset: 0x000FD500
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x000FF314 File Offset: 0x000FD514
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

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x000FF340 File Offset: 0x000FD540
		// (set) Token: 0x06003FDA RID: 16346 RVA: 0x000FF354 File Offset: 0x000FD554
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

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06003FDB RID: 16347 RVA: 0x000FF384 File Offset: 0x000FD584
		// (set) Token: 0x06003FDC RID: 16348 RVA: 0x000FF398 File Offset: 0x000FD598
		public int? Position
		{
			[CompilerGenerated]
			get
			{
				return this.<Position>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<Position>k__BackingField, value))
				{
					return;
				}
				this.<Position>k__BackingField = value;
				this.RaisePropertyChanged("Position");
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x000FF3C8 File Offset: 0x000FD5C8
		// (set) Token: 0x06003FDE RID: 16350 RVA: 0x000FF3DC File Offset: 0x000FD5DC
		public bool? Enable
		{
			[CompilerGenerated]
			get
			{
				return this.<Enable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<bool>(this.<Enable>k__BackingField, value))
				{
					return;
				}
				this.<Enable>k__BackingField = value;
				this.RaisePropertyChanged("Enable");
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06003FDF RID: 16351 RVA: 0x000FF40C File Offset: 0x000FD60C
		// (set) Token: 0x06003FE0 RID: 16352 RVA: 0x000FF420 File Offset: 0x000FD620
		public string FaultList
		{
			[CompilerGenerated]
			get
			{
				return this.<FaultList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<FaultList>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<FaultList>k__BackingField = value;
				this.RaisePropertyChanged("FaultList");
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06003FE1 RID: 16353 RVA: 0x000FF450 File Offset: 0x000FD650
		// (set) Token: 0x06003FE2 RID: 16354 RVA: 0x000FF464 File Offset: 0x000FD664
		public string LookList
		{
			[CompilerGenerated]
			get
			{
				return this.<LookList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<LookList>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<LookList>k__BackingField = value;
				this.RaisePropertyChanged("LookList");
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06003FE3 RID: 16355 RVA: 0x000FF494 File Offset: 0x000FD694
		// (set) Token: 0x06003FE4 RID: 16356 RVA: 0x000FF4A8 File Offset: 0x000FD6A8
		public string ComplectList
		{
			[CompilerGenerated]
			get
			{
				return this.<ComplectList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ComplectList>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ComplectList>k__BackingField = value;
				this.RaisePropertyChanged("ComplectList");
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x000FF4D8 File Offset: 0x000FD6D8
		// (set) Token: 0x06003FE6 RID: 16358 RVA: 0x000FF4EC File Offset: 0x000FD6EC
		public string CompanyList
		{
			[CompilerGenerated]
			get
			{
				return this.<CompanyList>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CompanyList>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CompanyList>k__BackingField = value;
				this.RaisePropertyChanged("CompanyList");
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x000FF51C File Offset: 0x000FD71C
		// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x000FF530 File Offset: 0x000FD730
		public bool Refill
		{
			[CompilerGenerated]
			get
			{
				return this.<Refill>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Refill>k__BackingField == value)
				{
					return;
				}
				this.<Refill>k__BackingField = value;
				this.RaisePropertyChanged("Refill");
			}
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x000069B8 File Offset: 0x00004BB8
		public Device()
		{
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x000FF55C File Offset: 0x000FD75C
		public Device(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x040029EB RID: 10731
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040029EC RID: 10732
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040029ED RID: 10733
		[CompilerGenerated]
		private int? <Position>k__BackingField;

		// Token: 0x040029EE RID: 10734
		[CompilerGenerated]
		private bool? <Enable>k__BackingField;

		// Token: 0x040029EF RID: 10735
		[CompilerGenerated]
		private string <FaultList>k__BackingField;

		// Token: 0x040029F0 RID: 10736
		[CompilerGenerated]
		private string <LookList>k__BackingField;

		// Token: 0x040029F1 RID: 10737
		[CompilerGenerated]
		private string <ComplectList>k__BackingField;

		// Token: 0x040029F2 RID: 10738
		[CompilerGenerated]
		private string <CompanyList>k__BackingField;

		// Token: 0x040029F3 RID: 10739
		[CompilerGenerated]
		private bool <Refill>k__BackingField;
	}
}
