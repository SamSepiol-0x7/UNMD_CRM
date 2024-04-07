using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Services.Abstract
{
	// Token: 0x020007FF RID: 2047
	public interface ITaskService
	{
		// Token: 0x06003D49 RID: 15689
		Task CancelTasks(IList<int> taskIds);

		// Token: 0x06003D4A RID: 15690
		int CreateTask(IAscTask t);

		// Token: 0x06003D4B RID: 15691
		int CreateTask(auseceEntities ctx, IAscTask t);

		// Token: 0x06003D4C RID: 15692
		Task<IAscTask> GetTask(int taskId);

		// Token: 0x06003D4D RID: 15693
		Task<IEnumerable<tasks>> GetTasks(Period period, int userId, int status, int priority, int taskType, string query, int direction);

		// Token: 0x06003D4E RID: 15694
		Task<bool> UpdateTask(IAscTask task);

		// Token: 0x06003D4F RID: 15695
		void Task4FireItems(IEnumerable<store_items> fireItems);

		// Token: 0x06003D50 RID: 15696
		void UpdateTaskState(parts_request request, int state);

		// Token: 0x06003D51 RID: 15697
		List<KeyValuePair<int, string>> LoadPriorities(bool includeAll = false);

		// Token: 0x06003D52 RID: 15698
		List<KeyValuePair<AscTaskPriority, string>> GetTaskPriorities();

		// Token: 0x06003D53 RID: 15699
		List<KeyValuePair<AscTaskStatus, string>> GetTaskStatuses();

		// Token: 0x06003D54 RID: 15700
		List<KeyValuePair<int, string>> LoadTaskStatuses(bool includeAll = false);

		// Token: 0x06003D55 RID: 15701
		List<KeyValuePair<int, string>> LoadTaskTypes(bool includeAll = false);

		// Token: 0x06003D56 RID: 15702
		Task<int> GetActiveTaskIds();

		// Token: 0x06003D57 RID: 15703
		List<KeyValuePair<AscTaskStatus, string>> GetTaskDeviceMatchStatuses(int taskAuthorId);

		// Token: 0x06003D58 RID: 15704
		void CreateNotifications(auseceEntities ctx, int user, tasks task, string text);

		// Token: 0x06003D59 RID: 15705
		void CreateNotifications(auseceEntities ctx, int user, int customerId, string text);
	}
}
