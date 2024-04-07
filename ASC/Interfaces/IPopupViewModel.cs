using System;
using System.Threading.Tasks;

namespace ASC.Interfaces
{
	// Token: 0x02000B37 RID: 2871
	public interface IPopupViewModel
	{
		// Token: 0x060050D4 RID: 20692
		Task Save();

		// Token: 0x060050D5 RID: 20693
		Task Create();

		// Token: 0x060050D6 RID: 20694
		void Close();

		// Token: 0x060050D7 RID: 20695
		void OnLoad();

		// Token: 0x060050D8 RID: 20696
		bool CanSave();
	}
}
