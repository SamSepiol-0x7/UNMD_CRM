using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using DevExpress.Xpf.WindowsUI.Navigation;

namespace ASC.ViewModels.CustomerCard
{
	// Token: 0x020004DD RID: 1245
	public class CustomerCollectionViewModel<T> : CollectionViewModel<T>, INavigationAware, IIsDataLoading where T : class
	{
		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002FB8 RID: 12216 RVA: 0x0009D0C8 File Offset: 0x0009B2C8
		// (set) Token: 0x06002FB9 RID: 12217 RVA: 0x0009D0DC File Offset: 0x0009B2DC
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x0009D10C File Offset: 0x0009B30C
		// (set) Token: 0x06002FBB RID: 12219 RVA: 0x0009D120 File Offset: 0x0009B320
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x0009D14C File Offset: 0x0009B34C
		protected virtual void LoadData()
		{
			this.SetIsDataLoading(true);
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x0009D160 File Offset: 0x0009B360
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x0009D174 File Offset: 0x0009B374
		public void NavigatedTo(NavigationEventArgs e)
		{
			this.Customer = (ICustomer)e.Parameter;
			this.Period = ((this.Customer.Created == null) ? new Period() : new Period(this.Customer.Created.Value, DateTime.UtcNow));
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.RefreshEventHandler));
			this.LoadData();
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0009D200 File Offset: 0x0009B400
		private void RefreshEventHandler(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatingFrom(NavigatingEventArgs e)
		{
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00023150 File Offset: 0x00021350
		public void NavigatedFrom(NavigationEventArgs e)
		{
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x0009D214 File Offset: 0x0009B414
		public CustomerCollectionViewModel()
		{
		}

		// Token: 0x04001B13 RID: 6931
		protected ICustomer Customer;

		// Token: 0x04001B14 RID: 6932
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001B15 RID: 6933
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;
	}
}
