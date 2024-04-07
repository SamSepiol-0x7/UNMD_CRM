using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModel
{
	// Token: 0x020002B0 RID: 688
	public class SmsListViewModel : BaseViewModel
	{
		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x00067758 File Offset: 0x00065958
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x0006776C File Offset: 0x0006596C
		public ObservableCollection<IAscSms> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0006779C File Offset: 0x0006599C
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x000677B0 File Offset: 0x000659B0
		public IAscSms SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItem>k__BackingField = value;
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x000677E0 File Offset: 0x000659E0
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x000677F4 File Offset: 0x000659F4
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

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x00067824 File Offset: 0x00065A24
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x00067838 File Offset: 0x00065A38
		public Dictionary<int, string> Direction
		{
			[CompilerGenerated]
			get
			{
				return this.<Direction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Direction>k__BackingField, value))
				{
					return;
				}
				this.<Direction>k__BackingField = value;
				this.RaisePropertyChanged("Direction");
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x00067868 File Offset: 0x00065A68
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x0006787C File Offset: 0x00065A7C
		public int SelectedDirection
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDirection>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedDirection>k__BackingField == value)
				{
					return;
				}
				this.<SelectedDirection>k__BackingField = value;
				this.RaisePropertyChanged("SelectedDirection");
			}
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x000678A8 File Offset: 0x00065AA8
		public SmsListViewModel()
		{
			this.SmsService = Bootstrapper.Container.Resolve<ISmsService>();
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			ILocalization localization = Bootstrapper.Container.Resolve<ILocalization>();
			this.SetViewName("Sms");
			this.Direction = this.SmsService.GetDirections();
			this.Period = new Period(localization.Now.Date.AddMonths(-1), localization.Now.Date);
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.PeriodChanged));
			this.LoadData();
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00067960 File Offset: 0x00065B60
		private void PeriodChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00067974 File Offset: 0x00065B74
		private void LoadData()
		{
			base.ShowWait();
			Task.Run<IEnumerable<IAscSms>>(() => this.SmsService.LoadSmses(this.Period, (SmsDirection)this.SelectedDirection)).ContinueWith(delegate(Task<IEnumerable<IAscSms>> t)
			{
				this.Items = new ObservableCollection<IAscSms>(t.Result);
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00067960 File Offset: 0x00065B60
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x000679B0 File Offset: 0x00065BB0
		[Command]
		public void ItemDoubleClick()
		{
			IAscSms selectedItem = this.SelectedItem;
			if (selectedItem == null || selectedItem.CustomerId == null)
			{
				return;
			}
			this._navigationService.NavigateToCustomerCard(this.SelectedItem.CustomerId.Value, null);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x000679FC File Offset: 0x00065BFC
		[CompilerGenerated]
		private Task<IEnumerable<IAscSms>> <LoadData>b__24_0()
		{
			return this.SmsService.LoadSmses(this.Period, (SmsDirection)this.SelectedDirection);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00067A20 File Offset: 0x00065C20
		[CompilerGenerated]
		private void <LoadData>b__24_1(Task<IEnumerable<IAscSms>> t)
		{
			this.Items = new ObservableCollection<IAscSms>(t.Result);
			base.HideWait();
		}

		// Token: 0x04001237 RID: 4663
		protected ISmsService SmsService;

		// Token: 0x04001238 RID: 4664
		private readonly INavigationService _navigationService;

		// Token: 0x04001239 RID: 4665
		[CompilerGenerated]
		private ObservableCollection<IAscSms> <Items>k__BackingField;

		// Token: 0x0400123A RID: 4666
		[CompilerGenerated]
		private IAscSms <SelectedItem>k__BackingField;

		// Token: 0x0400123B RID: 4667
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x0400123C RID: 4668
		[CompilerGenerated]
		private Dictionary<int, string> <Direction>k__BackingField;

		// Token: 0x0400123D RID: 4669
		[CompilerGenerated]
		private int <SelectedDirection>k__BackingField;
	}
}
