using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x02000866 RID: 2150
	public class Box : BindableBase, ICheckFields, IBox
	{
		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x000FE938 File Offset: 0x000FCB38
		// (set) Token: 0x06003F98 RID: 16280 RVA: 0x000FE94C File Offset: 0x000FCB4C
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

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x000FE978 File Offset: 0x000FCB78
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x000FE98C File Offset: 0x000FCB8C
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

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x000FE9BC File Offset: 0x000FCBBC
		// (set) Token: 0x06003F9C RID: 16284 RVA: 0x000FE9D0 File Offset: 0x000FCBD0
		public int Places
		{
			[CompilerGenerated]
			get
			{
				return this.<Places>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Places>k__BackingField == value)
				{
					return;
				}
				this.<Places>k__BackingField = value;
				this.RaisePropertyChanged("Status");
				this.RaisePropertyChanged("PlacesF");
				this.RaisePropertyChanged("Places");
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x000FEA14 File Offset: 0x000FCC14
		// (set) Token: 0x06003F9E RID: 16286 RVA: 0x000FEA28 File Offset: 0x000FCC28
		public int Used
		{
			[CompilerGenerated]
			get
			{
				return this.<Used>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Used>k__BackingField == value)
				{
					return;
				}
				this.<Used>k__BackingField = value;
				this.RaisePropertyChanged("Status");
				this.RaisePropertyChanged("Used");
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06003F9F RID: 16287 RVA: 0x000FEA60 File Offset: 0x000FCC60
		// (set) Token: 0x06003FA0 RID: 16288 RVA: 0x000FEA7C File Offset: 0x000FCC7C
		public string Color
		{
			get
			{
				return this._color ?? "#00000000";
			}
			set
			{
				if (string.Equals(this._color, value, StringComparison.Ordinal))
				{
					return;
				}
				this._color = value;
				this.RaisePropertyChanged("Color");
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06003FA1 RID: 16289 RVA: 0x000FEAAC File Offset: 0x000FCCAC
		public int Status
		{
			get
			{
				if (this.Used == 0)
				{
					return 3;
				}
				if (this.Used >= this.Places && this.Places != 0)
				{
					return 1;
				}
				if (this.Used < this.Places || this.Places == 0)
				{
					return 2;
				}
				return -1;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x000FEAF4 File Offset: 0x000FCCF4
		public string PlacesF
		{
			get
			{
				if (this.Places != 0)
				{
					return string.Format("{0}", this.Places);
				}
				return Lang.t("NotLimited") ?? "";
			}
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x0007E558 File Offset: 0x0007C758
		public virtual void LoadItems()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x000FEB34 File Offset: 0x000FCD34
		public bool SaveColor()
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.boxes.Find(new object[]
					{
						this.Id
					}).color = this.Color;
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x000FEBAC File Offset: 0x000FCDAC
		public virtual string CheckFields()
		{
			if (string.IsNullOrEmpty(this.Name))
			{
				return "NameTooShort";
			}
			return "";
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000069B8 File Offset: 0x00004BB8
		public Box()
		{
		}

		// Token: 0x040029D0 RID: 10704
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040029D1 RID: 10705
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040029D2 RID: 10706
		[CompilerGenerated]
		private int <Places>k__BackingField;

		// Token: 0x040029D3 RID: 10707
		[CompilerGenerated]
		private int <Used>k__BackingField;

		// Token: 0x040029D4 RID: 10708
		private string _color;
	}
}
