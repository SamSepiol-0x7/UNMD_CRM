using System;
using ASC.RepairCard;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000440 RID: 1088
	public class RepairCartridgeFullViewModel : RepairCardViewModel
	{
		// Token: 0x06002B17 RID: 11031 RVA: 0x00088E0C File Offset: 0x0008700C
		public RepairCartridgeFullViewModel()
		{
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x00088E20 File Offset: 0x00087020
		public RepairCartridgeFullViewModel(int repairId) : base(repairId)
		{
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00023150 File Offset: 0x00021350
		public override void RefreshCommands()
		{
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00088E34 File Offset: 0x00087034
		[Command]
		public override void OpenRepairAdmin()
		{
			this._navigationService.Navigate("RepairCartridgeFullAdminView", new RepairCartridgeFullAdminViewModel(base.RepairId));
		}
	}
}
