using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ASC.Options
{
	// Token: 0x02000256 RID: 598
	public class PhoneOptions
	{
		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0005E55C File Offset: 0x0005C75C
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x0005E570 File Offset: 0x0005C770
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0005E584 File Offset: 0x0005C784
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x0005E598 File Offset: 0x0005C798
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
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0005E5AC File Offset: 0x0005C7AC
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x0005E5C0 File Offset: 0x0005C7C0
		public string Mask
		{
			[CompilerGenerated]
			get
			{
				return this.<Mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Mask>k__BackingField = value;
			}
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000046B4 File Offset: 0x000028B4
		public PhoneOptions()
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x0005E5D4 File Offset: 0x0005C7D4
		public PhoneOptions(int id, string name, string mask)
		{
			this.Id = id;
			this.Name = name;
			this.Mask = mask;
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0005E5FC File Offset: 0x0005C7FC
		public List<PhoneOptions> GetAllOptions()
		{
			return new List<PhoneOptions>
			{
				new PhoneOptions(1, Lang.t("MobilePhone"), Auth.Config.phone_mask1),
				new PhoneOptions(2, Lang.t("CityPhone"), Auth.Config.phone_mask2)
			};
		}

		// Token: 0x040010BE RID: 4286
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010BF RID: 4287
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040010C0 RID: 4288
		[CompilerGenerated]
		private string <Mask>k__BackingField;
	}
}
