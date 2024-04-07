using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Models;

namespace ASC.Services.Abstract
{
	// Token: 0x020007FE RID: 2046
	public interface ISettingsService
	{
		// Token: 0x06003D42 RID: 15682
		Task<KeyValuePair<string, string>> GetSettingsAsync(string name);

		// Token: 0x06003D43 RID: 15683
		Task<Dictionary<string, string>> GetSettingsAsync(string[] names);

		// Token: 0x06003D44 RID: 15684
		Task<SettingsModel> GetSettingsAsync();

		// Token: 0x06003D45 RID: 15685
		Task UpdateSettingsAsync(string name, string value);

		// Token: 0x06003D46 RID: 15686
		Task UpdateSettingsAsync(Dictionary<SettingsName, string> settings);

		// Token: 0x06003D47 RID: 15687
		KeyValuePair<string, string> GetSettings(string name);

		// Token: 0x06003D48 RID: 15688
		Dictionary<string, string> GetSettings(string[] names);
	}
}
