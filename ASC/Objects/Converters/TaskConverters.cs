using System;
using System.Linq;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000921 RID: 2337
	public static class TaskConverters
	{
		// Token: 0x06004820 RID: 18464 RVA: 0x00119C90 File Offset: 0x00117E90
		public static IAscTask ToAscTask(this tasks t)
		{
			if (t == null)
			{
				return null;
			}
			AscTask ascTask = new AscTask
			{
				Id = t.idt,
				TopEmployee = t.top_user,
				CreatorId = t.task_author,
				Created = t.created,
				Start = t.start_datetime,
				Type = (TaskType)t.type,
				Status = (AscTaskStatus)t.state,
				Priority = (AscTaskPriority)t.priority,
				Subject = t.title,
				Message = t.text,
				RepairId = t.repair_id,
				ItemId = t.item_id,
				PartRequest = t.part_request,
				MatchDevice = t.m_device,
				MatchMaker = t.m_maker,
				MatchText = t.m_match,
				Email = t.email,
				Tel = t.phone,
				DocumentId = t.doc_id
			};
			if (t.task_employees != null && t.task_employees.Any<task_employees>())
			{
				foreach (task_employees task_employees in t.task_employees)
				{
					ascTask.AddResponsibleUser(task_employees.employee);
				}
			}
			return ascTask;
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x00119DE8 File Offset: 0x00117FE8
		public static tasks BackToTask(this IAscTask t)
		{
			return new tasks
			{
				top_user = t.TopEmployee,
				task_author = t.CreatorId,
				created = t.Created,
				start_datetime = t.Start,
				type = (int)t.Type,
				state = (int)t.Status,
				priority = (int)t.Priority,
				title = t.Subject,
				text = t.Message,
				repair_id = t.RepairId,
				item_id = t.ItemId,
				part_request = t.PartRequest,
				m_device = t.MatchDevice,
				m_maker = t.MatchMaker,
				m_match = t.MatchText,
				email = t.Email,
				phone = t.Tel,
				doc_id = t.DocumentId
			};
		}
	}
}
