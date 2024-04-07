using System;
using ASC.Common.Interfaces.VoIP;
using ASC.Interfaces;
using ASC.Objects;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200045C RID: 1116
	public class ACPV2ViewModel : MenuViewModel
	{
		// Token: 0x06002C05 RID: 11269 RVA: 0x0008C94C File Offset: 0x0008AB4C
		public ACPV2ViewModel()
		{
			this.SetViewName("Settings");
			this.InitMenu();
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0008C970 File Offset: 0x0008AB70
		public sealed override void InitMenu()
		{
			base.InitMenu();
			base.ShowWait();
			base.AddMenuItem("PersonalSettings", "CustomizeView", "ColorMixer_32x32.png");
			if (OfflineData.Instance.Employee.Can(1, 0))
			{
				base.AddMenuItem("General", "SettingsView", "Technology_32x32.png");
				base.AddMenuItem("Firm", "StructView", "Project_32x32.png");
				base.AddMenuItem("Employees", "EmployeesView", "BOEmployee_32x32.png");
				base.AddMenuItem("Roles", "RolesView", "BOPermission_32x32.png");
				base.AddMenuItem("StoresAndBoxes", "ASC.View.ACP.StoreView", "BOOrder_32x32.png");
				base.AddMenuItem("Finances", "FinancesView", "Currency_32x32.png");
				base.AddMenuItem("DeviceCatalogEditor", "DeviceCatalogView", "FunctionsMore_32x32.png");
				base.AddMenuItem("RepairStatuses", "StatusesView", "GreenYellowRed_32x32.png");
				base.AddMenuItem("FieldsAndVisitSources", "VisitSourcesView", "");
				base.AddMenuItem("DocumentForms", "ReportsView", "BOReport2_32x32.png");
				base.AddMenuItem("Notify", "NotifyView", "Send_32x32.png");
				base.AddMenuItem("Backup", "BackupView", "Database_32x32.png");
				if (Auth.Config.vw_enable && base.IsValid())
				{
					base.AddMenuItem("VendorWarranty", "VendorWarrantyListView", "BOCountry_32x32.png");
				}
				VoIPClient? voip = OfflineData.Instance.Settings.Voip;
				if (voip.GetValueOrDefault() == VoIPClient.AsteriskRealtime & voip != null)
				{
					base.AddMenuItem("VoIp", "VoIPView", "");
				}
			}
			base.SelectFirstMenuItem();
			base.HideWait();
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x0008CB20 File Offset: 0x0008AD20
		public override void MenuItemChanged()
		{
			this._childViewModel = null;
			base.RaiseCanExecuteChanged(() => this.Save());
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x0008CB70 File Offset: 0x0008AD70
		public void SetChildViewModel(ICVMActions cvm)
		{
			this._childViewModel = cvm;
			base.RaiseCanExecuteChanged(() => this.Save());
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0008CBC0 File Offset: 0x0008ADC0
		[Command]
		public void Save()
		{
			ICVMActions childViewModel = this._childViewModel;
			if (childViewModel != null)
			{
				childViewModel.Save();
			}
			this.InitMenu();
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x0008CBE4 File Offset: 0x0008ADE4
		public bool CanSave()
		{
			return this._childViewModel != null && this._childViewModel.CanSave();
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x0008CC08 File Offset: 0x0008AE08
		[Command]
		public void Refresh()
		{
			ICVMActions childViewModel = this._childViewModel;
			if (childViewModel == null)
			{
				return;
			}
			childViewModel.Refresh();
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x0008CC28 File Offset: 0x0008AE28
		public bool CanRefresh()
		{
			return this._childViewModel != null && this._childViewModel.CanRefresh();
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0008CC4C File Offset: 0x0008AE4C
		public override void OnViewLoaded()
		{
			base.RaiseCanExecuteChanged(() => this.Save());
		}

		// Token: 0x04001888 RID: 6280
		private ICVMActions _childViewModel;
	}
}
