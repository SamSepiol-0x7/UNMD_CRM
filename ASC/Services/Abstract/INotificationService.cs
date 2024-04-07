using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x020007F3 RID: 2035
	public interface INotificationService
	{
		// Token: 0x06003D10 RID: 15632
		Task<int> CountEmployeeNotificationsAsync(int employeeId);

		// Token: 0x06003D11 RID: 15633
		Task<IEnumerable<IAscNotification>> GetEmployeeNotifications(int employeeId, int limit);

		// Token: 0x06003D12 RID: 15634
		Task MarkAllAsRead(int employeeId);

		// Token: 0x06003D13 RID: 15635
		Task MarkAsRead(int notificationId);
	}
}
