using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.SimpleClasses;

namespace ASC.Services
{
	// Token: 0x020005EE RID: 1518
	public interface IReportTemplateService
	{
		// Token: 0x06003746 RID: 14150
		Task<int> Create(doc_templates template);

		// Token: 0x06003747 RID: 14151
		Task<List<DocumentTemplateInfo>> GetAllAsync();

		// Token: 0x06003748 RID: 14152
		Task<doc_templates> GetByIdAsync(int templateId);

		// Token: 0x06003749 RID: 14153
		Task<doc_templates> GetByNameAsync(string templateName);

		// Token: 0x0600374A RID: 14154
		Task UpdateTemplateDescription(int templateId, string description);
	}
}
