using System;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Interfaces;

namespace ASC.Models
{
	// Token: 0x0200095D RID: 2397
	public class InternalReserveModel : IInternalReserveModel
	{
		// Token: 0x06004931 RID: 18737 RVA: 0x00120B4C File Offset: 0x0011ED4C
		public InternalReserveModel()
		{
			this._localization = new Localization("UTC");
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x00120B70 File Offset: 0x0011ED70
		public store_int_reserve CreateReserve(store_items item, int count, decimal price, int? repairId, int? workId)
		{
			store_int_reserve reserve = new store_int_reserve
			{
				item_id = item.id,
				name = item.name,
				notes = "Выдача товара \"" + item.name + "\" сотруднику " + Auth.User.Fio,
				price = price,
				count = count,
				sn = item.SN,
				to_user = Auth.User.id,
				warranty = item.warranty,
				from_user = Auth.User.id,
				created = new DateTime?(this._localization.Now),
				state = 1,
				repair_id = repairId,
				work_id = workId
			};
			return this.SaveReserveInDb(reserve);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00120C3C File Offset: 0x0011EE3C
		private store_int_reserve SaveReserveInDb(store_int_reserve reserve)
		{
			store_int_reserve result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
				{
					try
					{
						auseceEntities.store_int_reserve.Add(reserve);
						auseceEntities.store_items.Find(new object[]
						{
							reserve.item_id
						}).reserved += reserve.count;
						auseceEntities.SaveChanges();
						dbContextTransaction.Commit();
					}
					catch (Exception)
					{
						dbContextTransaction.Rollback();
						return null;
					}
					HistoryV2 historyV = new HistoryV2();
					auseceEntities.Entry<store_int_reserve>(reserve).Reference<users>((store_int_reserve r) => r.users).Load();
					historyV.AddItemLog("GivePart2User", reserve.item_id, reserve.users.FioShort, "");
					historyV.Save();
					result = reserve;
				}
			}
			return result;
		}

		// Token: 0x04002EA6 RID: 11942
		private ILocalization _localization;

		// Token: 0x0200095E RID: 2398
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004934 RID: 18740 RVA: 0x00120D74 File Offset: 0x0011EF74
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004935 RID: 18741 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002EA7 RID: 11943
			public static readonly InternalReserveModel.<>c <>9 = new InternalReserveModel.<>c();
		}
	}
}
