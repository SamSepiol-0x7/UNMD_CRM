using System;

namespace ASC.Objects
{
	// Token: 0x020008B0 RID: 2224
	public class StoreCategory : Category
	{
		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x0010A700 File Offset: 0x00108900
		// (set) Token: 0x060043D0 RID: 17360 RVA: 0x0010A720 File Offset: 0x00108920
		public override bool IsExpand
		{
			get
			{
				return Auth.User.IsStoreCategoryExpand(base.Id);
			}
			set
			{
				if (this.IsExpand != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1230800930;
				IL_10:
				switch ((num ^ -1642054181) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					Auth.User.UpdateCategoryState(base.Id, value);
					num = -1869403501;
					goto IL_10;
				}
				this.RaisePropertyChanged("IsExpand");
			}
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x0010A780 File Offset: 0x00108980
		public StoreCategory()
		{
		}
	}
}
