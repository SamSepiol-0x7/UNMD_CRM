using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.SimpleClasses;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x020008D1 RID: 2257
	public class EmployeeRepairsReport : BindableBase, IEmployeeRepairsReport, IRepairsReport
	{
		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x0010FDEC File Offset: 0x0010DFEC
		// (set) Token: 0x0600456B RID: 17771 RVA: 0x0010FE00 File Offset: 0x0010E000
		public ObservableCollection<IRepairCardForReport> Repairs
		{
			[CompilerGenerated]
			get
			{
				return this.<Repairs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Repairs>k__BackingField, value))
				{
					return;
				}
				this.<Repairs>k__BackingField = value;
				this.RaisePropertyChanged("Repairs");
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x0010FE30 File Offset: 0x0010E030
		// (set) Token: 0x0600456D RID: 17773 RVA: 0x0010FE44 File Offset: 0x0010E044
		public ObservableCollection<IChartData> Chart
		{
			[CompilerGenerated]
			get
			{
				return this.<Chart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Chart>k__BackingField, value))
				{
					return;
				}
				this.<Chart>k__BackingField = value;
				this.RaisePropertyChanged("Chart");
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x0010FE74 File Offset: 0x0010E074
		// (set) Token: 0x0600456F RID: 17775 RVA: 0x0010FE88 File Offset: 0x0010E088
		public Dictionary<string, int> Pie
		{
			[CompilerGenerated]
			get
			{
				return this.<Pie>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Pie>k__BackingField, value))
				{
					return;
				}
				this.<Pie>k__BackingField = value;
				this.RaisePropertyChanged("Pie");
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x0010FEB8 File Offset: 0x0010E0B8
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x0010FECC File Offset: 0x0010E0CC
		public int Warranty
		{
			[CompilerGenerated]
			get
			{
				return this.<Warranty>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Warranty>k__BackingField == value)
				{
					return;
				}
				this.<Warranty>k__BackingField = value;
				this.RaisePropertyChanged("Warranty");
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x0010FEF8 File Offset: 0x0010E0F8
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x0010FF0C File Offset: 0x0010E10C
		public int Normal
		{
			[CompilerGenerated]
			get
			{
				return this.<Normal>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Normal>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 432752857;
				IL_10:
				switch ((num ^ 741501138) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					num = 1330817844;
					goto IL_10;
				case 3:
					return;
				}
				this.<Normal>k__BackingField = value;
				this.RaisePropertyChanged("Normal");
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x0010FF64 File Offset: 0x0010E164
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x0010FF78 File Offset: 0x0010E178
		public int WithoutRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<WithoutRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<WithoutRepair>k__BackingField == value)
				{
					return;
				}
				this.<WithoutRepair>k__BackingField = value;
				this.RaisePropertyChanged("WithoutRepair");
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x0010FFA4 File Offset: 0x0010E1A4
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x0010FFB8 File Offset: 0x0010E1B8
		public decimal MinPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<MinPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<MinPrice>k__BackingField, value))
				{
					return;
				}
				this.<MinPrice>k__BackingField = value;
				this.RaisePropertyChanged("MinPrice");
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x0010FFE8 File Offset: 0x0010E1E8
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x0010FFFC File Offset: 0x0010E1FC
		public decimal MaxPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<MaxPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<MaxPrice>k__BackingField, value))
				{
					return;
				}
				this.<MaxPrice>k__BackingField = value;
				this.RaisePropertyChanged("MaxPrice");
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x0011002C File Offset: 0x0010E22C
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x00110040 File Offset: 0x0010E240
		public decimal AveragePrice
		{
			[CompilerGenerated]
			get
			{
				return this.<AveragePrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<AveragePrice>k__BackingField, value))
				{
					return;
				}
				this.<AveragePrice>k__BackingField = value;
				this.RaisePropertyChanged("AveragePrice");
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x00110070 File Offset: 0x0010E270
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x00110084 File Offset: 0x0010E284
		public decimal AverageWorksPrice
		{
			[CompilerGenerated]
			get
			{
				return this.<AverageWorksPrice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<AverageWorksPrice>k__BackingField, value))
				{
					return;
				}
				this.<AverageWorksPrice>k__BackingField = value;
				this.RaisePropertyChanged("AverageWorksPrice");
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x001100B4 File Offset: 0x0010E2B4
		// (set) Token: 0x0600457F RID: 17791 RVA: 0x001100C8 File Offset: 0x0010E2C8
		public decimal SalaryAverageCheque
		{
			[CompilerGenerated]
			get
			{
				return this.<SalaryAverageCheque>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<SalaryAverageCheque>k__BackingField, value))
				{
					return;
				}
				this.<SalaryAverageCheque>k__BackingField = value;
				this.RaisePropertyChanged("SalaryAverageCheque");
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x001100F8 File Offset: 0x0010E2F8
		// (set) Token: 0x06004581 RID: 17793 RVA: 0x0011010C File Offset: 0x0010E30C
		public int Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Total>k__BackingField == value)
				{
					return;
				}
				this.<Total>k__BackingField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x00110138 File Offset: 0x0010E338
		// (set) Token: 0x06004583 RID: 17795 RVA: 0x0011014C File Offset: 0x0010E34C
		public double RepairsPerDay
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairsPerDay>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RepairsPerDay>k__BackingField == value)
				{
					return;
				}
				this.<RepairsPerDay>k__BackingField = value;
				this.RaisePropertyChanged("RepairsPerDay");
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x0011017C File Offset: 0x0010E37C
		// (set) Token: 0x06004585 RID: 17797 RVA: 0x00110190 File Offset: 0x0010E390
		public double AverageRepairTime
		{
			[CompilerGenerated]
			get
			{
				return this.<AverageRepairTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AverageRepairTime>k__BackingField == value)
				{
					return;
				}
				this.<AverageRepairTime>k__BackingField = value;
				this.RaisePropertyChanged("AverageRepairTime");
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06004586 RID: 17798 RVA: 0x001101C0 File Offset: 0x0010E3C0
		// (set) Token: 0x06004587 RID: 17799 RVA: 0x00110204 File Offset: 0x0010E404
		public bool ExcludeZeroFromMinPrice
		{
			get
			{
				return base.GetProperty<bool>(() => this.ExcludeZeroFromMinPrice);
			}
			set
			{
				if (this.ExcludeZeroFromMinPrice == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.ExcludeZeroFromMinPrice, value, new Action(this.RecalcAveragePrices));
				this.RaisePropertyChanged("ExcludeZeroFromMinPrice");
			}
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x0011026C File Offset: 0x0010E46C
		public EmployeeRepairsReport()
		{
			this.Repairs = new ObservableCollection<IRepairCardForReport>();
			this.ExcludeZeroFromMinPrice = true;
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x00110294 File Offset: 0x0010E494
		public Task LoadData(IPeriod period, int officeId, int employeeId, int deviceId, int state)
		{
			EmployeeRepairsReport.<LoadData>d__61 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.period = period;
			<LoadData>d__.officeId = officeId;
			<LoadData>d__.employeeId = employeeId;
			<LoadData>d__.deviceId = deviceId;
			<LoadData>d__.state = state;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<EmployeeRepairsReport.<LoadData>d__61>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00110304 File Offset: 0x0010E504
		private void CalcAverageTime()
		{
			double num = this.Repairs.Sum((IRepairCardForReport r) => r.InRepairDays);
			this.AverageRepairTime = Math.Round(num / (double)this.Repairs.Count, 2);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00110358 File Offset: 0x0010E558
		private void CountPerDay(IPeriod period)
		{
			double num = Math.Abs((period.To - period.From).TotalDays);
			if (num < 1.0)
			{
				num = 1.0;
			}
			this.RepairsPerDay = Math.Round((double)this.Repairs.Count / num, 2);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x001103B4 File Offset: 0x0010E5B4
		private List<IRepairCardForReport> GetEmployeeRepairs(int employeeId = 0)
		{
			if (employeeId == 0)
			{
				return (from r in this.Repairs
				where r.OutDate != null
				select r).ToList<IRepairCardForReport>();
			}
			return this.Repairs.Where(delegate(IRepairCardForReport r)
			{
				if (r.OutDate == null)
				{
					return false;
				}
				int? masterId = r.MasterId;
				int employeeId2 = employeeId;
				return masterId.GetValueOrDefault() == employeeId2 & masterId != null;
			}).ToList<IRepairCardForReport>();
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00110424 File Offset: 0x0010E624
		public void BuildChart(int employeeId = 0)
		{
			List<IRepairCardForReport> employeeRepairs = this.GetEmployeeRepairs(employeeId);
			if (!employeeRepairs.Any<IRepairCardForReport>())
			{
				this.Chart = null;
				return;
			}
			if (employeeId == 0)
			{
				this.Chart = new ObservableCollection<IChartData>(from r in employeeRepairs
				select new ChartData
				{
					SeriesDataMember = r.MasterFio,
					ArgumentDataMember = r.OutDate.Value,
					ValueDataMember = r.RealRepairCost
				});
				return;
			}
			List<ChartData> list = new List<ChartData>();
			foreach (IRepairCardForReport item in employeeRepairs.Where(EmployeeRepairsReport.IssuedWarranty()).ToList<IRepairCardForReport>())
			{
				this.AddChartItem(Lang.t("Warranty"), list, item);
			}
			foreach (IRepairCardForReport item2 in employeeRepairs.Where(EmployeeRepairsReport.IssuedNotWarranty()).ToList<IRepairCardForReport>())
			{
				this.AddChartItem(Lang.t("Repaired"), list, item2);
			}
			foreach (IRepairCardForReport item3 in employeeRepairs.Where(EmployeeRepairsReport.IssuedWithoutRepair()).ToList<IRepairCardForReport>())
			{
				this.AddChartItem(Lang.t("NotRepaired"), list, item3);
			}
			this.Chart = new ObservableCollection<IChartData>(list);
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add(Lang.t("Warranty"), this.Chart.Count((IChartData c) => c.SeriesDataMember == Lang.t("Warranty")));
			dictionary.Add(Lang.t("NotRepaired"), this.Chart.Count((IChartData c) => c.SeriesDataMember == Lang.t("NotRepaired")));
			dictionary.Add(Lang.t("Repaired"), this.Chart.Count((IChartData c) => c.SeriesDataMember == Lang.t("Repaired")));
			this.Pie = dictionary;
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x0011065C File Offset: 0x0010E85C
		private void AddChartItem(string name, List<ChartData> result, IRepairCardForReport item)
		{
			result.Add(new ChartData
			{
				SeriesDataMember = name,
				ArgumentDataMember = item.OutDate.Value,
				ValueDataMember = 1m
			});
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x0011069C File Offset: 0x0010E89C
		public void CountTotal()
		{
			ObservableCollection<IRepairCardForReport> repairs = this.Repairs;
			this.Total = ((repairs != null) ? repairs.Count : 0);
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x001106C4 File Offset: 0x0010E8C4
		public void CountWarranty()
		{
			this.Warranty = this.Repairs.Count(EmployeeRepairsReport.IssuedWarranty());
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x001106E8 File Offset: 0x0010E8E8
		private static Func<IRepairCardForReport, bool> IssuedWarranty()
		{
			return (IRepairCardForReport r) => r.Status == 8 && r.IsWarranty;
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x00110714 File Offset: 0x0010E914
		public void CountNormal()
		{
			this.Normal = this.Repairs.Count(EmployeeRepairsReport.IssuedNotWarranty());
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00110738 File Offset: 0x0010E938
		public void CountWithoutRepair()
		{
			this.WithoutRepair = this.Repairs.Count(EmployeeRepairsReport.IssuedWithoutRepair());
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x0011075C File Offset: 0x0010E95C
		private static Func<IRepairCardForReport, bool> IssuedWithoutRepair()
		{
			return (IRepairCardForReport r) => r.Status == 12;
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00110788 File Offset: 0x0010E988
		public void CalcMinPrice()
		{
			if (this.Repairs.Any<IRepairCardForReport>())
			{
				goto IL_50;
			}
			IL_1C:
			int num = 2047439641;
			IL_21:
			switch ((num ^ 987327010) % 5)
			{
			case 0:
				this.MinPrice = Fn.FormatSumm((from r in this.Repairs
				where r.RealRepairCost > 0m
				select r.RealRepairCost).DefaultIfEmpty<decimal>().Min());
				return;
			case 1:
				return;
			case 2:
				IL_50:
				num = ((!this.ExcludeZeroFromMinPrice) ? 542371671 : 2124121640);
				goto IL_21;
			case 3:
				goto IL_1C;
			}
			this.MinPrice = Fn.FormatSumm((from r in this.Repairs
			select r.RealRepairCost).DefaultIfEmpty<decimal>().Min());
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00110894 File Offset: 0x0010EA94
		private void RecalcAveragePrices()
		{
			this.CalcMinPrice();
			this.CalcAveragePrice();
			this.CalcAverageWorksPrice();
			this.CalcSalaryAverage();
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x001108BC File Offset: 0x0010EABC
		public void CalcMaxPrice()
		{
			if (!this.Repairs.Any<IRepairCardForReport>())
			{
				goto IL_70;
			}
			IL_0D:
			this.MaxPrice = Fn.FormatSumm((from r in this.Repairs
			select r.RealRepairCost).DefaultIfEmpty<decimal>().Max());
			int num = 1721401342;
			IL_51:
			switch ((num ^ 25591660) % 4)
			{
			case 0:
				goto IL_0D;
			case 1:
				return;
			case 3:
				IL_70:
				num = 60188585;
				goto IL_51;
			}
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00110944 File Offset: 0x0010EB44
		public void CalcAveragePrice()
		{
			if (!this.Repairs.Any<IRepairCardForReport>())
			{
				goto IL_89;
			}
			goto IL_C4;
			int num;
			for (;;)
			{
				IL_8E:
				switch ((num ^ -648575213) % 6)
				{
				case 0:
					goto IL_89;
				case 1:
					goto IL_C4;
				case 3:
					return;
				case 4:
					return;
				case 5:
					this.AveragePrice = Fn.FormatSumm((from r in this.Repairs
					where r.RealRepairCost > 0m
					select r.RealRepairCost).DefaultIfEmpty<decimal>().Average());
					num = -835005921;
					continue;
				}
				break;
			}
			this.AveragePrice = Fn.FormatSumm((from r in this.Repairs
			select r.RealRepairCost).DefaultIfEmpty<decimal>().Average());
			return;
			IL_89:
			num = -1713192484;
			goto IL_8E;
			IL_C4:
			num = ((!this.ExcludeZeroFromMinPrice) ? -1177134053 : -946245512);
			goto IL_8E;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00110A64 File Offset: 0x0010EC64
		public void CalcSalaryAverage()
		{
			if (!this.Repairs.Any<IRepairCardForReport>())
			{
				goto IL_D5;
			}
			goto IL_114;
			int num;
			for (;;)
			{
				IL_DA:
				switch ((num ^ -233656146) % 7)
				{
				case 0:
					goto IL_D5;
				case 1:
					this.SalaryAverageCheque = Fn.FormatSumm((from r in this.Repairs
					select r.MasterPart).DefaultIfEmpty<decimal>().Average());
					num = -87217645;
					continue;
				case 2:
					goto IL_114;
				case 3:
					this.SalaryAverageCheque = Fn.FormatSumm((from r in this.Repairs
					where r.MasterPart > 0m
					select r.MasterPart).DefaultIfEmpty<decimal>().Average());
					num = -1941865090;
					continue;
				case 4:
					return;
				case 5:
					return;
				}
				break;
			}
			return;
			IL_D5:
			num = -1440743353;
			goto IL_DA;
			IL_114:
			num = ((!this.ExcludeZeroFromMinPrice) ? -360484112 : -1499781386);
			goto IL_DA;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00110B94 File Offset: 0x0010ED94
		public void CalcAverageWorksPrice()
		{
			if (!this.Repairs.Any<IRepairCardForReport>())
			{
				goto IL_8C;
			}
			goto IL_111;
			int num;
			for (;;)
			{
				IL_D7:
				switch ((num ^ -921548858) % 7)
				{
				case 0:
					goto IL_111;
				case 1:
					this.AverageWorksPrice = Fn.FormatSumm((from r in this.Repairs
					select r.WorksCost).DefaultIfEmpty<decimal>().Average());
					num = -800533305;
					continue;
				case 2:
					goto IL_8C;
				case 4:
					return;
				case 5:
					return;
				case 6:
					this.AverageWorksPrice = Fn.FormatSumm((from r in this.Repairs
					where r.WorksCost > 0m
					select r.WorksCost).DefaultIfEmpty<decimal>().Average());
					num = -1507740643;
					continue;
				}
				break;
			}
			return;
			IL_8C:
			num = -432117010;
			goto IL_D7;
			IL_111:
			num = ((!this.ExcludeZeroFromMinPrice) ? -1347815826 : -71927258);
			goto IL_D7;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00110CC4 File Offset: 0x0010EEC4
		private static Func<IRepairCardForReport, bool> IssuedNotWarranty()
		{
			return (IRepairCardForReport r) => r.Status == 8 && !r.IsWarranty;
		}

		// Token: 0x04002CAA RID: 11434
		[CompilerGenerated]
		private ObservableCollection<IRepairCardForReport> <Repairs>k__BackingField;

		// Token: 0x04002CAB RID: 11435
		[CompilerGenerated]
		private ObservableCollection<IChartData> <Chart>k__BackingField;

		// Token: 0x04002CAC RID: 11436
		[CompilerGenerated]
		private Dictionary<string, int> <Pie>k__BackingField;

		// Token: 0x04002CAD RID: 11437
		[CompilerGenerated]
		private int <Warranty>k__BackingField;

		// Token: 0x04002CAE RID: 11438
		[CompilerGenerated]
		private int <Normal>k__BackingField;

		// Token: 0x04002CAF RID: 11439
		[CompilerGenerated]
		private int <WithoutRepair>k__BackingField;

		// Token: 0x04002CB0 RID: 11440
		[CompilerGenerated]
		private decimal <MinPrice>k__BackingField;

		// Token: 0x04002CB1 RID: 11441
		[CompilerGenerated]
		private decimal <MaxPrice>k__BackingField;

		// Token: 0x04002CB2 RID: 11442
		[CompilerGenerated]
		private decimal <AveragePrice>k__BackingField;

		// Token: 0x04002CB3 RID: 11443
		[CompilerGenerated]
		private decimal <AverageWorksPrice>k__BackingField;

		// Token: 0x04002CB4 RID: 11444
		[CompilerGenerated]
		private decimal <SalaryAverageCheque>k__BackingField;

		// Token: 0x04002CB5 RID: 11445
		[CompilerGenerated]
		private int <Total>k__BackingField;

		// Token: 0x04002CB6 RID: 11446
		[CompilerGenerated]
		private double <RepairsPerDay>k__BackingField;

		// Token: 0x04002CB7 RID: 11447
		[CompilerGenerated]
		private double <AverageRepairTime>k__BackingField;

		// Token: 0x04002CB8 RID: 11448
		private int _employeeId;

		// Token: 0x020008D2 RID: 2258
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__61 : IAsyncStateMachine
		{
			// Token: 0x0600459C RID: 17820 RVA: 0x00110CF0 File Offset: 0x0010EEF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeeRepairsReport employeeRepairsReport = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IRepairCardForReport>> awaiter;
					if (num != 0)
					{
						employeeRepairsReport._employeeId = this.employeeId;
						awaiter = ChartModel.LoadEmployeeRepairs(this.period, this.officeId, this.employeeId, this.deviceId, this.state).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IRepairCardForReport>>, EmployeeRepairsReport.<LoadData>d__61>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IRepairCardForReport>>);
						this.<>1__state = -1;
					}
					IEnumerable<IRepairCardForReport> result = awaiter.GetResult();
					employeeRepairsReport.Repairs = new ObservableCollection<IRepairCardForReport>(result);
					if (employeeRepairsReport.Repairs != null)
					{
						employeeRepairsReport.CalcAverageTime();
						employeeRepairsReport.CountPerDay(this.period);
						employeeRepairsReport.CountNormal();
						employeeRepairsReport.CountTotal();
						employeeRepairsReport.CountWarranty();
						employeeRepairsReport.CountWithoutRepair();
						employeeRepairsReport.CalcAveragePrice();
						employeeRepairsReport.CalcSalaryAverage();
						employeeRepairsReport.CalcAverageWorksPrice();
						employeeRepairsReport.CalcMinPrice();
						employeeRepairsReport.CalcMaxPrice();
						employeeRepairsReport.BuildChart(this.employeeId);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600459D RID: 17821 RVA: 0x00110E3C File Offset: 0x0010F03C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002CB9 RID: 11449
			public int <>1__state;

			// Token: 0x04002CBA RID: 11450
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002CBB RID: 11451
			public EmployeeRepairsReport <>4__this;

			// Token: 0x04002CBC RID: 11452
			public int employeeId;

			// Token: 0x04002CBD RID: 11453
			public IPeriod period;

			// Token: 0x04002CBE RID: 11454
			public int officeId;

			// Token: 0x04002CBF RID: 11455
			public int deviceId;

			// Token: 0x04002CC0 RID: 11456
			public int state;

			// Token: 0x04002CC1 RID: 11457
			private TaskAwaiter<IEnumerable<IRepairCardForReport>> <>u__1;
		}

		// Token: 0x020008D3 RID: 2259
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600459E RID: 17822 RVA: 0x00110E58 File Offset: 0x0010F058
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600459F RID: 17823 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060045A0 RID: 17824 RVA: 0x00110E70 File Offset: 0x0010F070
			internal double <CalcAverageTime>b__62_0(IRepairCardForReport r)
			{
				return r.InRepairDays;
			}

			// Token: 0x060045A1 RID: 17825 RVA: 0x00110E84 File Offset: 0x0010F084
			internal bool <GetEmployeeRepairs>b__64_0(IRepairCardForReport r)
			{
				return r.OutDate != null;
			}

			// Token: 0x060045A2 RID: 17826 RVA: 0x00110EA0 File Offset: 0x0010F0A0
			internal ChartData <BuildChart>b__65_0(IRepairCardForReport r)
			{
				return new ChartData
				{
					SeriesDataMember = r.MasterFio,
					ArgumentDataMember = r.OutDate.Value,
					ValueDataMember = r.RealRepairCost
				};
			}

			// Token: 0x060045A3 RID: 17827 RVA: 0x00110EE0 File Offset: 0x0010F0E0
			internal bool <BuildChart>b__65_1(IChartData c)
			{
				return c.SeriesDataMember == Lang.t("Warranty");
			}

			// Token: 0x060045A4 RID: 17828 RVA: 0x00110F04 File Offset: 0x0010F104
			internal bool <BuildChart>b__65_2(IChartData c)
			{
				return c.SeriesDataMember == Lang.t("NotRepaired");
			}

			// Token: 0x060045A5 RID: 17829 RVA: 0x00110F28 File Offset: 0x0010F128
			internal bool <BuildChart>b__65_3(IChartData c)
			{
				return c.SeriesDataMember == Lang.t("Repaired");
			}

			// Token: 0x060045A6 RID: 17830 RVA: 0x00110F4C File Offset: 0x0010F14C
			internal bool <IssuedWarranty>b__69_0(IRepairCardForReport r)
			{
				return r.Status == 8 && r.IsWarranty;
			}

			// Token: 0x060045A7 RID: 17831 RVA: 0x00110F6C File Offset: 0x0010F16C
			internal bool <IssuedWithoutRepair>b__72_0(IRepairCardForReport r)
			{
				return r.Status == 12;
			}

			// Token: 0x060045A8 RID: 17832 RVA: 0x00110F84 File Offset: 0x0010F184
			internal bool <CalcMinPrice>b__73_0(IRepairCardForReport r)
			{
				return r.RealRepairCost > 0m;
			}

			// Token: 0x060045A9 RID: 17833 RVA: 0x00110FA4 File Offset: 0x0010F1A4
			internal decimal <CalcMinPrice>b__73_1(IRepairCardForReport r)
			{
				return r.RealRepairCost;
			}

			// Token: 0x060045AA RID: 17834 RVA: 0x00110FA4 File Offset: 0x0010F1A4
			internal decimal <CalcMinPrice>b__73_2(IRepairCardForReport r)
			{
				return r.RealRepairCost;
			}

			// Token: 0x060045AB RID: 17835 RVA: 0x00110FA4 File Offset: 0x0010F1A4
			internal decimal <CalcMaxPrice>b__75_0(IRepairCardForReport r)
			{
				return r.RealRepairCost;
			}

			// Token: 0x060045AC RID: 17836 RVA: 0x00110F84 File Offset: 0x0010F184
			internal bool <CalcAveragePrice>b__76_0(IRepairCardForReport r)
			{
				return r.RealRepairCost > 0m;
			}

			// Token: 0x060045AD RID: 17837 RVA: 0x00110FA4 File Offset: 0x0010F1A4
			internal decimal <CalcAveragePrice>b__76_1(IRepairCardForReport r)
			{
				return r.RealRepairCost;
			}

			// Token: 0x060045AE RID: 17838 RVA: 0x00110FA4 File Offset: 0x0010F1A4
			internal decimal <CalcAveragePrice>b__76_2(IRepairCardForReport r)
			{
				return r.RealRepairCost;
			}

			// Token: 0x060045AF RID: 17839 RVA: 0x00110FB8 File Offset: 0x0010F1B8
			internal bool <CalcSalaryAverage>b__77_0(IRepairCardForReport r)
			{
				return r.MasterPart > 0m;
			}

			// Token: 0x060045B0 RID: 17840 RVA: 0x00110FD8 File Offset: 0x0010F1D8
			internal decimal <CalcSalaryAverage>b__77_1(IRepairCardForReport r)
			{
				return r.MasterPart;
			}

			// Token: 0x060045B1 RID: 17841 RVA: 0x00110FD8 File Offset: 0x0010F1D8
			internal decimal <CalcSalaryAverage>b__77_2(IRepairCardForReport r)
			{
				return r.MasterPart;
			}

			// Token: 0x060045B2 RID: 17842 RVA: 0x00110FEC File Offset: 0x0010F1EC
			internal bool <CalcAverageWorksPrice>b__78_0(IRepairCardForReport r)
			{
				return r.WorksCost > 0m;
			}

			// Token: 0x060045B3 RID: 17843 RVA: 0x0011100C File Offset: 0x0010F20C
			internal decimal <CalcAverageWorksPrice>b__78_1(IRepairCardForReport r)
			{
				return r.WorksCost;
			}

			// Token: 0x060045B4 RID: 17844 RVA: 0x0011100C File Offset: 0x0010F20C
			internal decimal <CalcAverageWorksPrice>b__78_2(IRepairCardForReport r)
			{
				return r.WorksCost;
			}

			// Token: 0x060045B5 RID: 17845 RVA: 0x00111020 File Offset: 0x0010F220
			internal bool <IssuedNotWarranty>b__79_0(IRepairCardForReport r)
			{
				return r.Status == 8 && !r.IsWarranty;
			}

			// Token: 0x04002CC2 RID: 11458
			public static readonly EmployeeRepairsReport.<>c <>9 = new EmployeeRepairsReport.<>c();

			// Token: 0x04002CC3 RID: 11459
			public static Func<IRepairCardForReport, double> <>9__62_0;

			// Token: 0x04002CC4 RID: 11460
			public static Func<IRepairCardForReport, bool> <>9__64_0;

			// Token: 0x04002CC5 RID: 11461
			public static Func<IRepairCardForReport, ChartData> <>9__65_0;

			// Token: 0x04002CC6 RID: 11462
			public static Func<IChartData, bool> <>9__65_1;

			// Token: 0x04002CC7 RID: 11463
			public static Func<IChartData, bool> <>9__65_2;

			// Token: 0x04002CC8 RID: 11464
			public static Func<IChartData, bool> <>9__65_3;

			// Token: 0x04002CC9 RID: 11465
			public static Func<IRepairCardForReport, bool> <>9__69_0;

			// Token: 0x04002CCA RID: 11466
			public static Func<IRepairCardForReport, bool> <>9__72_0;

			// Token: 0x04002CCB RID: 11467
			public static Func<IRepairCardForReport, bool> <>9__73_0;

			// Token: 0x04002CCC RID: 11468
			public static Func<IRepairCardForReport, decimal> <>9__73_1;

			// Token: 0x04002CCD RID: 11469
			public static Func<IRepairCardForReport, decimal> <>9__73_2;

			// Token: 0x04002CCE RID: 11470
			public static Func<IRepairCardForReport, decimal> <>9__75_0;

			// Token: 0x04002CCF RID: 11471
			public static Func<IRepairCardForReport, bool> <>9__76_0;

			// Token: 0x04002CD0 RID: 11472
			public static Func<IRepairCardForReport, decimal> <>9__76_1;

			// Token: 0x04002CD1 RID: 11473
			public static Func<IRepairCardForReport, decimal> <>9__76_2;

			// Token: 0x04002CD2 RID: 11474
			public static Func<IRepairCardForReport, bool> <>9__77_0;

			// Token: 0x04002CD3 RID: 11475
			public static Func<IRepairCardForReport, decimal> <>9__77_1;

			// Token: 0x04002CD4 RID: 11476
			public static Func<IRepairCardForReport, decimal> <>9__77_2;

			// Token: 0x04002CD5 RID: 11477
			public static Func<IRepairCardForReport, bool> <>9__78_0;

			// Token: 0x04002CD6 RID: 11478
			public static Func<IRepairCardForReport, decimal> <>9__78_1;

			// Token: 0x04002CD7 RID: 11479
			public static Func<IRepairCardForReport, decimal> <>9__78_2;

			// Token: 0x04002CD8 RID: 11480
			public static Func<IRepairCardForReport, bool> <>9__79_0;
		}

		// Token: 0x020008D4 RID: 2260
		[CompilerGenerated]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x060045B6 RID: 17846 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x060045B7 RID: 17847 RVA: 0x00111044 File Offset: 0x0010F244
			internal bool <GetEmployeeRepairs>b__1(IRepairCardForReport r)
			{
				if (r.OutDate == null)
				{
					return false;
				}
				int? masterId = r.MasterId;
				int num = this.employeeId;
				return masterId.GetValueOrDefault() == num & masterId != null;
			}

			// Token: 0x04002CD9 RID: 11481
			public int employeeId;
		}
	}
}
