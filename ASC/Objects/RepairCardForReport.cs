using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008ED RID: 2285
	public class RepairCardForReport : RepairCard, IRepairCard, IRepairCardForReport, IRepair
	{
		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x00114C1C File Offset: 0x00112E1C
		// (set) Token: 0x060046F4 RID: 18164 RVA: 0x00114C30 File Offset: 0x00112E30
		public decimal WorksCost
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<WorksCost>k__BackingField, value))
				{
					return;
				}
				this.<WorksCost>k__BackingField = value;
				this.RaisePropertyChanged("WorksCost");
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x00114C60 File Offset: 0x00112E60
		// (set) Token: 0x060046F6 RID: 18166 RVA: 0x00114C74 File Offset: 0x00112E74
		public decimal AllWorksCost
		{
			[CompilerGenerated]
			get
			{
				return this.<AllWorksCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<AllWorksCost>k__BackingField, value))
				{
					return;
				}
				this.<AllWorksCost>k__BackingField = value;
				this.RaisePropertyChanged("AllWorksCost");
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x00114CA4 File Offset: 0x00112EA4
		// (set) Token: 0x060046F8 RID: 18168 RVA: 0x00114CB8 File Offset: 0x00112EB8
		public decimal PartsCost
		{
			[CompilerGenerated]
			get
			{
				return this.<PartsCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<PartsCost>k__BackingField, value))
				{
					return;
				}
				this.<PartsCost>k__BackingField = value;
				this.RaisePropertyChanged("PartsCost");
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x00114CE8 File Offset: 0x00112EE8
		// (set) Token: 0x060046FA RID: 18170 RVA: 0x00114CFC File Offset: 0x00112EFC
		public decimal AllPartsCost
		{
			[CompilerGenerated]
			get
			{
				return this.<AllPartsCost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!decimal.Equals(this.<AllPartsCost>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 413183700;
				IL_13:
				switch ((num ^ 1932281677) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<AllPartsCost>k__BackingField = value;
					num = 144707541;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("AllPartsCost");
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x00114D58 File Offset: 0x00112F58
		// (set) Token: 0x060046FC RID: 18172 RVA: 0x00114D6C File Offset: 0x00112F6C
		public decimal AllPartsInSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<AllPartsInSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<AllPartsInSumm>k__BackingField, value))
				{
					return;
				}
				this.<AllPartsInSumm>k__BackingField = value;
				this.RaisePropertyChanged("AllPartsInSumm");
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x00114D9C File Offset: 0x00112F9C
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x00114DB0 File Offset: 0x00112FB0
		public decimal MasterPart
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterPart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<MasterPart>k__BackingField, value))
				{
					return;
				}
				this.<MasterPart>k__BackingField = value;
				this.RaisePropertyChanged("MasterPart");
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x00114DE0 File Offset: 0x00112FE0
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x00114DF4 File Offset: 0x00112FF4
		public decimal AllMastersPart
		{
			[CompilerGenerated]
			get
			{
				return this.<AllMastersPart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<AllMastersPart>k__BackingField, value))
				{
					return;
				}
				this.<AllMastersPart>k__BackingField = value;
				this.RaisePropertyChanged("AllMastersPart");
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x00114E24 File Offset: 0x00113024
		// (set) Token: 0x06004702 RID: 18178 RVA: 0x00114E38 File Offset: 0x00113038
		public decimal ManagerPart
		{
			[CompilerGenerated]
			get
			{
				return this.<ManagerPart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<ManagerPart>k__BackingField, value))
				{
					return;
				}
				this.<ManagerPart>k__BackingField = value;
				this.RaisePropertyChanged("ManagerPart");
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x00114E68 File Offset: 0x00113068
		// (set) Token: 0x06004704 RID: 18180 RVA: 0x00114E7C File Offset: 0x0011307C
		public decimal ManagerGoodsPart
		{
			[CompilerGenerated]
			get
			{
				return this.<ManagerGoodsPart>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<ManagerGoodsPart>k__BackingField, value))
				{
					return;
				}
				this.<ManagerGoodsPart>k__BackingField = value;
				this.RaisePropertyChanged("ManagerGoodsPart");
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06004705 RID: 18181 RVA: 0x00114EAC File Offset: 0x001130AC
		// (set) Token: 0x06004706 RID: 18182 RVA: 0x00114EC0 File Offset: 0x001130C0
		public decimal Profit
		{
			[CompilerGenerated]
			get
			{
				return this.<Profit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Profit>k__BackingField, value))
				{
					return;
				}
				this.<Profit>k__BackingField = value;
				this.RaisePropertyChanged("Profit");
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x00114EF0 File Offset: 0x001130F0
		// (set) Token: 0x06004708 RID: 18184 RVA: 0x00114F04 File Offset: 0x00113104
		public decimal GoodsProfit
		{
			[CompilerGenerated]
			get
			{
				return this.<GoodsProfit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<GoodsProfit>k__BackingField, value))
				{
					return;
				}
				this.<GoodsProfit>k__BackingField = value;
				this.RaisePropertyChanged("GoodsProfit");
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x00114F34 File Offset: 0x00113134
		// (set) Token: 0x0600470A RID: 18186 RVA: 0x00114F48 File Offset: 0x00113148
		public decimal TotalProfit
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalProfit>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<TotalProfit>k__BackingField, value))
				{
					return;
				}
				this.<TotalProfit>k__BackingField = value;
				this.RaisePropertyChanged("TotalProfit");
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x00114F78 File Offset: 0x00113178
		// (set) Token: 0x0600470C RID: 18188 RVA: 0x00114F8C File Offset: 0x0011318C
		public string MasterFio
		{
			[CompilerGenerated]
			get
			{
				return this.<MasterFio>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<MasterFio>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MasterFio>k__BackingField = value;
				this.RaisePropertyChanged("MasterFio");
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x00114FBC File Offset: 0x001131BC
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x00114FD0 File Offset: 0x001131D0
		public int? CustomerVisitSource
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerVisitSource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<CustomerVisitSource>k__BackingField, value))
				{
					return;
				}
				this.<CustomerVisitSource>k__BackingField = value;
				this.RaisePropertyChanged("CustomerVisitSource");
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x00115000 File Offset: 0x00113200
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x00115014 File Offset: 0x00113214
		public string Masters
		{
			[CompilerGenerated]
			get
			{
				return this.<Masters>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Masters>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 362083712;
				IL_14:
				switch ((num ^ 1718068050) % 4)
				{
				case 1:
					IL_33:
					this.<Masters>k__BackingField = value;
					this.RaisePropertyChanged("Masters");
					num = 1170798930;
					goto IL_14;
				case 2:
					return;
				case 3:
					goto IL_0F;
				}
			}
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00115070 File Offset: 0x00113270
		public void CalcProfit()
		{
			this.Profit = base.RealRepairCost - this.AllPartsCost - this.AllMastersPart - this.ManagerPart;
			this.GoodsProfit = this.AllPartsCost - this.AllPartsInSumm;
			this.TotalProfit = this.Profit + this.GoodsProfit;
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x001150D8 File Offset: 0x001132D8
		public void CalcWorksCost(int employeeId = 0)
		{
			List<IWorkPartObject> employeeWorks = this.GetEmployeeWorks(employeeId);
			if (!employeeWorks.Any<IWorkPartObject>())
			{
				return;
			}
			if (Auth.Config.parts_included && this.HaveAnyPart())
			{
				foreach (IWorkPartObject workPartObject in employeeWorks)
				{
					List<IWorkPartObject> partsByWork = this.GetPartsByWork(workPartObject.Id);
					if (!partsByWork.Any<IWorkPartObject>())
					{
						this.WorksCost += workPartObject.Summ;
					}
					else
					{
						this.WorksCost += workPartObject.Summ - partsByWork.Sum((IWorkPartObject p) => p.Summ);
					}
				}
				return;
			}
			foreach (IWorkPartObject workPartObject2 in employeeWorks)
			{
				this.WorksCost += workPartObject2.Summ;
			}
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00115210 File Offset: 0x00113410
		public void CalcAllWorksSumm()
		{
			List<IWorkPartObject> employeeWorks = this.GetEmployeeWorks(0);
			if (!employeeWorks.Any<IWorkPartObject>())
			{
				return;
			}
			if (!Auth.Config.parts_included || !this.HaveAnyPart())
			{
				foreach (IWorkPartObject workPartObject in employeeWorks)
				{
					this.AllWorksCost += workPartObject.Summ;
				}
				return;
			}
			foreach (IWorkPartObject workPartObject2 in employeeWorks)
			{
				List<IWorkPartObject> partsByWork = this.GetPartsByWork(workPartObject2.Id);
				if (!partsByWork.Any<IWorkPartObject>())
				{
					this.WorksCost += workPartObject2.Summ;
				}
				else
				{
					this.AllWorksCost += workPartObject2.Summ - partsByWork.Sum((IWorkPartObject p) => p.Summ);
				}
			}
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00115344 File Offset: 0x00113544
		public void CalcPartsSumm(int employeeId = 0)
		{
			if (!this.HaveAnyPart())
			{
				return;
			}
			foreach (IWorkPartObject workPartObject in this.GetParts(employeeId))
			{
				this.PartsCost += workPartObject.Summ;
			}
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x001153B4 File Offset: 0x001135B4
		public void CalcMasterPart(int employeeId = 0)
		{
			if (!base.WorksAndParts.Any<IWorkPartObject>())
			{
				return;
			}
			List<IWorkPartObject> employeeWorks = this.GetEmployeeWorks(employeeId);
			if (!employeeWorks.Any<IWorkPartObject>())
			{
				return;
			}
			if (Auth.Config.parts_included && this.HaveAnyPart())
			{
				foreach (IWorkPartObject workPartObject in employeeWorks)
				{
					List<IWorkPartObject> partsByWork = this.GetPartsByWork(workPartObject.Id);
					if (!partsByWork.Any<IWorkPartObject>())
					{
						this.AddMasterPart(workPartObject);
					}
					else
					{
						decimal summ = workPartObject.Summ - partsByWork.Sum((IWorkPartObject p) => p.Summ);
						this.MasterPart += this.GetPart(summ, workPartObject.MasterPercent);
					}
				}
				return;
			}
			foreach (IWorkPartObject work in employeeWorks)
			{
				this.AddMasterPart(work);
			}
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x001154EC File Offset: 0x001136EC
		public void CallAllMastersPart()
		{
			if (Auth.Config.parts_included && this.HaveAnyPart())
			{
				this.CallAllMastersPartPartsIncluded();
				return;
			}
			this.CalcAllMastersPartSimple();
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x0011551C File Offset: 0x0011371C
		private void CallAllMastersPartPartsIncluded()
		{
			foreach (IWorkPartObject workPartObject in this.GetEmployeeWorks(0))
			{
				List<IWorkPartObject> partsByWork = this.GetPartsByWork(workPartObject.Id);
				if (!partsByWork.Any<IWorkPartObject>())
				{
					this.AddAllMastersPart(workPartObject);
				}
				else
				{
					decimal summ = workPartObject.Summ - partsByWork.Sum((IWorkPartObject p) => p.Summ);
					this.AllMastersPart += this.GetPart(summ, workPartObject.MasterPercent);
				}
			}
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x001155D8 File Offset: 0x001137D8
		private void CalcAllMastersPartSimple()
		{
			foreach (IWorkPartObject work in this.GetEmployeeWorks(0))
			{
				this.AddAllMastersPart(work);
			}
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00115630 File Offset: 0x00113830
		private void AddMasterPart(IWorkPartObject work)
		{
			this.MasterPart += this.GetPart(work.Summ, work.MasterPercent);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00115660 File Offset: 0x00113860
		private void AddAllMastersPart(IWorkPartObject work)
		{
			this.AllMastersPart += this.GetPart(work.Summ, work.MasterPercent);
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00115690 File Offset: 0x00113890
		private decimal GetPart(decimal summ, int percent)
		{
			return summ / 100m * percent;
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x001156B8 File Offset: 0x001138B8
		public void FillMastersFio()
		{
			List<IWorkPartObject> employeeWorks = this.GetEmployeeWorks(0);
			if (!employeeWorks.Any<IWorkPartObject>())
			{
				return;
			}
			foreach (IWorkPartObject workPartObject in employeeWorks)
			{
				IEmployee repairman = ((WorkPartObject)workPartObject).Repairman;
				if (repairman != null)
				{
					string fioShort = repairman.FioShort;
					if (string.IsNullOrEmpty(this.Masters) || !this.Masters.Contains(fioShort))
					{
						this.Masters = this.Masters + fioShort + " ";
					}
				}
			}
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00115758 File Offset: 0x00113958
		private bool HaveAnyPart()
		{
			return base.WorksAndParts.Any((IWorkPartObject w) => w.Type == 2);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x00115790 File Offset: 0x00113990
		private List<IWorkPartObject> GetEmployeeWorks(int employeeId = 0)
		{
			IEnumerable<IWorkPartObject> source = from w in base.WorksAndParts
			where w.Type == 1
			select w;
			if (employeeId == 0)
			{
				return source.ToList<IWorkPartObject>();
			}
			return (from w in source
			where w.EmployeeId == employeeId
			select w).ToList<IWorkPartObject>();
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x001157FC File Offset: 0x001139FC
		private List<IWorkPartObject> GetPartsByWork(int workId)
		{
			return base.WorksAndParts.Where(delegate(IWorkPartObject p)
			{
				int? workId2 = p.WorkId;
				int workId3 = workId;
				return workId2.GetValueOrDefault() == workId3 & workId2 != null;
			}).ToList<IWorkPartObject>();
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00115834 File Offset: 0x00113A34
		private List<IWorkPartObject> GetParts(int employeeId = 0)
		{
			if (employeeId == 0)
			{
				return (from p in base.WorksAndParts
				where p.Type == 2
				select p).ToList<IWorkPartObject>();
			}
			return (from p in base.WorksAndParts
			where p.Type == 2 && p.EmployeeId == employeeId
			select p).ToList<IWorkPartObject>();
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x001158A4 File Offset: 0x00113AA4
		public RepairCardForReport()
		{
		}

		// Token: 0x04002D92 RID: 11666
		[CompilerGenerated]
		private decimal <WorksCost>k__BackingField;

		// Token: 0x04002D93 RID: 11667
		[CompilerGenerated]
		private decimal <AllWorksCost>k__BackingField;

		// Token: 0x04002D94 RID: 11668
		[CompilerGenerated]
		private decimal <PartsCost>k__BackingField;

		// Token: 0x04002D95 RID: 11669
		[CompilerGenerated]
		private decimal <AllPartsCost>k__BackingField;

		// Token: 0x04002D96 RID: 11670
		[CompilerGenerated]
		private decimal <AllPartsInSumm>k__BackingField;

		// Token: 0x04002D97 RID: 11671
		[CompilerGenerated]
		private decimal <MasterPart>k__BackingField;

		// Token: 0x04002D98 RID: 11672
		[CompilerGenerated]
		private decimal <AllMastersPart>k__BackingField;

		// Token: 0x04002D99 RID: 11673
		[CompilerGenerated]
		private decimal <ManagerPart>k__BackingField;

		// Token: 0x04002D9A RID: 11674
		[CompilerGenerated]
		private decimal <ManagerGoodsPart>k__BackingField;

		// Token: 0x04002D9B RID: 11675
		[CompilerGenerated]
		private decimal <Profit>k__BackingField;

		// Token: 0x04002D9C RID: 11676
		[CompilerGenerated]
		private decimal <GoodsProfit>k__BackingField;

		// Token: 0x04002D9D RID: 11677
		[CompilerGenerated]
		private decimal <TotalProfit>k__BackingField;

		// Token: 0x04002D9E RID: 11678
		[CompilerGenerated]
		private string <MasterFio>k__BackingField;

		// Token: 0x04002D9F RID: 11679
		[CompilerGenerated]
		private int? <CustomerVisitSource>k__BackingField;

		// Token: 0x04002DA0 RID: 11680
		[CompilerGenerated]
		private string <Masters>k__BackingField;

		// Token: 0x020008EE RID: 2286
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004722 RID: 18210 RVA: 0x001158B8 File Offset: 0x00113AB8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004723 RID: 18211 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004724 RID: 18212 RVA: 0x001158D0 File Offset: 0x00113AD0
			internal decimal <CalcWorksCost>b__61_0(IWorkPartObject p)
			{
				return p.Summ;
			}

			// Token: 0x06004725 RID: 18213 RVA: 0x001158D0 File Offset: 0x00113AD0
			internal decimal <CalcAllWorksSumm>b__62_0(IWorkPartObject p)
			{
				return p.Summ;
			}

			// Token: 0x06004726 RID: 18214 RVA: 0x001158D0 File Offset: 0x00113AD0
			internal decimal <CalcMasterPart>b__64_0(IWorkPartObject p)
			{
				return p.Summ;
			}

			// Token: 0x06004727 RID: 18215 RVA: 0x001158D0 File Offset: 0x00113AD0
			internal decimal <CallAllMastersPartPartsIncluded>b__66_0(IWorkPartObject p)
			{
				return p.Summ;
			}

			// Token: 0x06004728 RID: 18216 RVA: 0x001158E4 File Offset: 0x00113AE4
			internal bool <HaveAnyPart>b__72_0(IWorkPartObject w)
			{
				return w.Type == 2;
			}

			// Token: 0x06004729 RID: 18217 RVA: 0x001158FC File Offset: 0x00113AFC
			internal bool <GetEmployeeWorks>b__73_0(IWorkPartObject w)
			{
				return w.Type == 1;
			}

			// Token: 0x0600472A RID: 18218 RVA: 0x001158E4 File Offset: 0x00113AE4
			internal bool <GetParts>b__75_0(IWorkPartObject p)
			{
				return p.Type == 2;
			}

			// Token: 0x04002DA1 RID: 11681
			public static readonly RepairCardForReport.<>c <>9 = new RepairCardForReport.<>c();

			// Token: 0x04002DA2 RID: 11682
			public static Func<IWorkPartObject, decimal> <>9__61_0;

			// Token: 0x04002DA3 RID: 11683
			public static Func<IWorkPartObject, decimal> <>9__62_0;

			// Token: 0x04002DA4 RID: 11684
			public static Func<IWorkPartObject, decimal> <>9__64_0;

			// Token: 0x04002DA5 RID: 11685
			public static Func<IWorkPartObject, decimal> <>9__66_0;

			// Token: 0x04002DA6 RID: 11686
			public static Func<IWorkPartObject, bool> <>9__72_0;

			// Token: 0x04002DA7 RID: 11687
			public static Func<IWorkPartObject, bool> <>9__73_0;

			// Token: 0x04002DA8 RID: 11688
			public static Func<IWorkPartObject, bool> <>9__75_0;
		}

		// Token: 0x020008EF RID: 2287
		[CompilerGenerated]
		private sealed class <>c__DisplayClass73_0
		{
			// Token: 0x0600472B RID: 18219 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass73_0()
			{
			}

			// Token: 0x0600472C RID: 18220 RVA: 0x00115914 File Offset: 0x00113B14
			internal bool <GetEmployeeWorks>b__1(IWorkPartObject w)
			{
				return w.EmployeeId == this.employeeId;
			}

			// Token: 0x04002DA9 RID: 11689
			public int employeeId;
		}

		// Token: 0x020008F0 RID: 2288
		[CompilerGenerated]
		private sealed class <>c__DisplayClass74_0
		{
			// Token: 0x0600472D RID: 18221 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass74_0()
			{
			}

			// Token: 0x0600472E RID: 18222 RVA: 0x00115930 File Offset: 0x00113B30
			internal bool <GetPartsByWork>b__0(IWorkPartObject p)
			{
				int? num = p.WorkId;
				int num2 = this.workId;
				return num.GetValueOrDefault() == num2 & num != null;
			}

			// Token: 0x04002DAA RID: 11690
			public int workId;
		}

		// Token: 0x020008F1 RID: 2289
		[CompilerGenerated]
		private sealed class <>c__DisplayClass75_0
		{
			// Token: 0x0600472F RID: 18223 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass75_0()
			{
			}

			// Token: 0x06004730 RID: 18224 RVA: 0x00115960 File Offset: 0x00113B60
			internal bool <GetParts>b__1(IWorkPartObject p)
			{
				return p.Type == 2 && p.EmployeeId == this.employeeId;
			}

			// Token: 0x04002DAB RID: 11691
			public int employeeId;
		}
	}
}
