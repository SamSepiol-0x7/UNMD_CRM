using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ASC.Models;
using DevExpress.Mvvm;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200053D RID: 1341
	public class SalesCategoriesChartViewModel : ChartBaseViewModel
	{
		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x000A6C28 File Offset: 0x000A4E28
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x000A6C3C File Offset: 0x000A4E3C
		public List<SalesInfo2> ChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<ChartData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<ChartData>k__BackingField, value))
				{
					return;
				}
				this.<ChartData>k__BackingField = value;
				this.RaisePropertyChanged("ChartData");
			}
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000A6C6C File Offset: 0x000A4E6C
		public SalesCategoriesChartViewModel()
		{
			this.SetViewName("CategoriesSaleReport");
			this._model = new ChartModel();
			this._bgInit.DoWork += this.BgInitOnDoWork;
			this._bgInit.RunWorkerCompleted += this.BgInitOnRunWorkerCompleted;
			this._bgInit.RunWorkerAsync();
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000A6CDC File Offset: 0x000A4EDC
		private void BgInitOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.InitCommands();
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000A6CF0 File Offset: 0x000A4EF0
		private void BgInitOnDoWork(object sender, DoWorkEventArgs e)
		{
			this.ChartData = new List<SalesInfo2>(this._model.LoadSaleCategoriesChartData(base.Period));
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000A6D1C File Offset: 0x000A4F1C
		private void InitCommands()
		{
			base.RefreshCommand = new DelegateCommand(new Action(this.Refresh));
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000A6D40 File Offset: 0x000A4F40
		private void Refresh()
		{
			if (!this._bgInit.IsBusy)
			{
				this._bgInit.RunWorkerAsync();
			}
		}

		// Token: 0x04001CA0 RID: 7328
		private ChartModel _model;

		// Token: 0x04001CA1 RID: 7329
		private BackgroundWorker _bgInit = new BackgroundWorker();

		// Token: 0x04001CA2 RID: 7330
		[CompilerGenerated]
		private List<SalesInfo2> <ChartData>k__BackingField;
	}
}
