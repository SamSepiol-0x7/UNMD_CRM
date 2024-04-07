using System;

namespace ASC.ViewModels
{
	// Token: 0x0200045E RID: 1118
	public interface IBaseViewModel
	{
		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002C14 RID: 11284
		// (set) Token: 0x06002C15 RID: 11285
		string ViewName { get; set; }

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002C16 RID: 11286
		// (set) Token: 0x06002C17 RID: 11287
		string TabId { get; set; }

		// Token: 0x06002C18 RID: 11288
		void OnLoad();

		// Token: 0x06002C19 RID: 11289
		void OnUnload();
	}
}
