using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ASC.Models;
using ASC.ViewModels;

namespace ASC.Charts.CallConversions
{
	// Token: 0x02000299 RID: 665
	public class CallConversionsViewModel : ChartBaseViewModel
	{
		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x000654D4 File Offset: 0x000636D4
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x000654E8 File Offset: 0x000636E8
		public ObservableCollection<cdr> Calls
		{
			[CompilerGenerated]
			get
			{
				return this.<Calls>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Calls>k__BackingField, value))
				{
					return;
				}
				this.<Calls>k__BackingField = value;
				this.RaisePropertyChanged("Calls");
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x00065518 File Offset: 0x00063718
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x0006552C File Offset: 0x0006372C
		public List<CallConversions> ChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<ChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ChartData>k__BackingField, value))
				{
					return;
				}
				this.<ChartData>k__BackingField = value;
				this.RaisePropertyChanged("ChartData");
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x0006555C File Offset: 0x0006375C
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x00065570 File Offset: 0x00063770
		public cdr SelectedCall
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCall>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedCall>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1758471717;
				IL_13:
				switch ((num ^ -489199886) % 4)
				{
				case 0:
					IL_32:
					this.<SelectedCall>k__BackingField = value;
					this.RaisePropertyChanged("SelectedCall");
					num = -1449286644;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000655CC File Offset: 0x000637CC
		public CallConversionsViewModel()
		{
			base.Period = new Period(ChartBaseViewModel._localization.Now.AddDays(-7.0), ChartBaseViewModel._localization.Now);
		}

		// Token: 0x040011D3 RID: 4563
		[CompilerGenerated]
		private ObservableCollection<cdr> <Calls>k__BackingField;

		// Token: 0x040011D4 RID: 4564
		[CompilerGenerated]
		private List<CallConversions> <ChartData>k__BackingField;

		// Token: 0x040011D5 RID: 4565
		private ChartModel _model;

		// Token: 0x040011D6 RID: 4566
		[CompilerGenerated]
		private cdr <SelectedCall>k__BackingField;
	}
}
