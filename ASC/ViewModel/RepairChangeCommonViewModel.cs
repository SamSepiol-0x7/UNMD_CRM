using System;
using System.Runtime.CompilerServices;
using ASC.Interfaces;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Editors;

namespace ASC.ViewModel
{
	// Token: 0x020002AF RID: 687
	public class RepairChangeCommonViewModel : ViewModelBase
	{
		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x00067650 File Offset: 0x00065850
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x00067664 File Offset: 0x00065864
		public workshop Repair
		{
			[CompilerGenerated]
			get
			{
				return this.<Repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Repair>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1462448331;
				IL_13:
				switch ((num ^ -627073720) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					num = -399001426;
					goto IL_13;
				}
				this.<Repair>k__BackingField = value;
				this.RaisePropertyChanged("Repair");
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x000676C0 File Offset: 0x000658C0
		public RepairChangeCommonViewModel()
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00067704 File Offset: 0x00065904
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			this.ParentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00067720 File Offset: 0x00065920
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00067738 File Offset: 0x00065938
		[Command]
		public void ComboBoxClick(object sender)
		{
			ComboBoxEdit comboBoxEdit = sender as ComboBoxEdit;
			if (comboBoxEdit != null)
			{
				comboBoxEdit.IsPopupOpen = true;
			}
		}

		// Token: 0x04001232 RID: 4658
		[CompilerGenerated]
		private workshop <Repair>k__BackingField;

		// Token: 0x04001233 RID: 4659
		public IRefreshable ParentViewModel;

		// Token: 0x04001234 RID: 4660
		protected readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001235 RID: 4661
		protected readonly IToasterService _toasterService;

		// Token: 0x04001236 RID: 4662
		protected readonly IWorkshopService _workshopService;
	}
}
