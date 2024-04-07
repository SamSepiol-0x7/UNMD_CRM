using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Models;
using ASC.Objects.Converters;

namespace ASC.Objects
{
	// Token: 0x020008C3 RID: 2243
	public class WorkshopBox : Box
	{
		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x0010CD54 File Offset: 0x0010AF54
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x0010CD68 File Offset: 0x0010AF68
		public List<RepairCard> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x0010CD98 File Offset: 0x0010AF98
		public WorkshopBox()
		{
			this.Items = new List<RepairCard>();
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x0010CDB8 File Offset: 0x0010AFB8
		public override void LoadItems()
		{
			using (GenericRepository<workshop> genericRepository = new GenericRepository<workshop>())
			{
				IEnumerable<workshop> all = genericRepository.GetAll((workshop r) => r.box == (int?)this.Id, null, "devices,device_makers,device_models");
				this.Items = (from r in all
				select r.ToRepairCard()).ToList<RepairCard>();
			}
		}

		// Token: 0x04002C34 RID: 11316
		[CompilerGenerated]
		private List<RepairCard> <Items>k__BackingField;

		// Token: 0x020008C4 RID: 2244
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600447B RID: 17531 RVA: 0x0010CE98 File Offset: 0x0010B098
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600447C RID: 17532 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600447D RID: 17533 RVA: 0x000CA4BC File Offset: 0x000C86BC
			internal RepairCard <LoadItems>b__5_1(workshop r)
			{
				return r.ToRepairCard();
			}

			// Token: 0x04002C35 RID: 11317
			public static readonly WorkshopBox.<>c <>9 = new WorkshopBox.<>c();

			// Token: 0x04002C36 RID: 11318
			public static Func<workshop, RepairCard> <>9__5_1;
		}
	}
}
