using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace ASC.ViewModels
{
	// Token: 0x020004B5 RID: 1205
	public class ChartBaseViewModel : BaseViewModel
	{
		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00098EA8 File Offset: 0x000970A8
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x00098EBC File Offset: 0x000970BC
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x00098EEC File Offset: 0x000970EC
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x00098F00 File Offset: 0x00097100
		public int SelectedOffice
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedOffice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedOffice>k__BackingField == value)
				{
					return;
				}
				this.<SelectedOffice>k__BackingField = value;
				this.RaisePropertyChanged("SelectedOffice");
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x00098F2C File Offset: 0x0009712C
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00098F40 File Offset: 0x00097140
		public DelegateCommand CloseCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<CloseCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 761564983;
				IL_13:
				switch ((num ^ 1758685318) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<CloseCommand>k__BackingField = value;
					this.RaisePropertyChanged("CloseCommand");
					num = 1911851789;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x00098F9C File Offset: 0x0009719C
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x00098FB0 File Offset: 0x000971B0
		public ICommand RefreshCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RefreshCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RefreshCommand>k__BackingField, value))
				{
					return;
				}
				this.<RefreshCommand>k__BackingField = value;
				this.RaisePropertyChanged("RefreshCommand");
			}
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00098FE0 File Offset: 0x000971E0
		public ChartBaseViewModel()
		{
			this.Period = new Period(ChartBaseViewModel._localization.Now.AddDays(-30.0), ChartBaseViewModel._localization.Now);
			this.RefreshCommand = new RelayCommand(new Action<object>(this.RefreshChart));
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00023150 File Offset: 0x00021350
		public virtual void RefreshChart(object obj)
		{
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x0009903C File Offset: 0x0009723C
		// Note: this type is marked as 'beforefieldinit'.
		static ChartBaseViewModel()
		{
		}

		// Token: 0x04001A55 RID: 6741
		public Action CloseAction;

		// Token: 0x04001A56 RID: 6742
		public static Localization _localization = new Localization("UTC");

		// Token: 0x04001A57 RID: 6743
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001A58 RID: 6744
		[CompilerGenerated]
		private int <SelectedOffice>k__BackingField;

		// Token: 0x04001A59 RID: 6745
		[CompilerGenerated]
		private DelegateCommand <CloseCommand>k__BackingField;

		// Token: 0x04001A5A RID: 6746
		[CompilerGenerated]
		private ICommand <RefreshCommand>k__BackingField;
	}
}
