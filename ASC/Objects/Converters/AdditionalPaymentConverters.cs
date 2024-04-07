using System;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000914 RID: 2324
	public static class AdditionalPaymentConverters
	{
		// Token: 0x06004804 RID: 18436 RVA: 0x00118CC4 File Offset: 0x00116EC4
		public static additional_payments ConvertBack(this IAdditionalPayment p)
		{
			return new additional_payments
			{
				id = p.Id,
				name = p.Reason,
				payment_date = p.Date,
				user = p.User,
				to_user = p.Employee,
				price = p.Summ
			};
		}
	}
}
