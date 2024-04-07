using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000865 RID: 2149
	public class AscImage : IDisposable, IImage
	{
		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x000FE884 File Offset: 0x000FCA84
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x000FE898 File Offset: 0x000FCA98
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
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x000FE8AC File Offset: 0x000FCAAC
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x000FE8C0 File Offset: 0x000FCAC0
		public DateTime? Created
		{
			[CompilerGenerated]
			get
			{
				return this.<Created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Created>k__BackingField = value;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06003F91 RID: 16273 RVA: 0x000FE8D4 File Offset: 0x000FCAD4
		// (set) Token: 0x06003F92 RID: 16274 RVA: 0x000FE8E8 File Offset: 0x000FCAE8
		public byte[] Image
		{
			[CompilerGenerated]
			get
			{
				return this.<Image>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Image>k__BackingField = value;
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06003F93 RID: 16275 RVA: 0x000FE8FC File Offset: 0x000FCAFC
		// (set) Token: 0x06003F94 RID: 16276 RVA: 0x000FE910 File Offset: 0x000FCB10
		public int? StoreItemId
		{
			[CompilerGenerated]
			get
			{
				return this.<StoreItemId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<StoreItemId>k__BackingField = value;
			}
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000FE924 File Offset: 0x000FCB24
		public void Dispose()
		{
			this.Image = null;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x000046B4 File Offset: 0x000028B4
		public AscImage()
		{
		}

		// Token: 0x040029CC RID: 10700
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040029CD RID: 10701
		[CompilerGenerated]
		private DateTime? <Created>k__BackingField;

		// Token: 0x040029CE RID: 10702
		[CompilerGenerated]
		private byte[] <Image>k__BackingField;

		// Token: 0x040029CF RID: 10703
		[CompilerGenerated]
		private int? <StoreItemId>k__BackingField;
	}
}
