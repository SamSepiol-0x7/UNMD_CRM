using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.ItemsArrival;
using ASC.ItemsSale;
using ASC.Objects;
using ASC.Options;
using ASC.PKO;
using ASC.RKO;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Data;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;

namespace ASC.Kassa
{
	// Token: 0x02000AE8 RID: 2792
	public class KassaViewModel : CollectionViewModel<CashOrdersLite>
	{
		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06004EFB RID: 20219 RVA: 0x00156404 File Offset: 0x00154604
		// (set) Token: 0x06004EFC RID: 20220 RVA: 0x00156418 File Offset: 0x00154618
		public bool OfficesVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficesVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<OfficesVisible>k__BackingField == value)
				{
					return;
				}
				this.<OfficesVisible>k__BackingField = value;
				this.RaisePropertyChanged("OfficesVisible");
			}
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x00156444 File Offset: 0x00154644
		private void RaiseFilterChanged()
		{
			if (this.FilterChangedHandler != null)
			{
				this.FilterChangedHandler(this, null);
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06004EFE RID: 20222 RVA: 0x00156468 File Offset: 0x00154668
		// (set) Token: 0x06004EFF RID: 20223 RVA: 0x0015647C File Offset: 0x0015467C
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06004F00 RID: 20224 RVA: 0x001564AC File Offset: 0x001546AC
		// (set) Token: 0x06004F01 RID: 20225 RVA: 0x001564C0 File Offset: 0x001546C0
		public List<IPaymentType> TypesList
		{
			[CompilerGenerated]
			get
			{
				return this.<TypesList>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<TypesList>k__BackingField, value))
				{
					return;
				}
				this.<TypesList>k__BackingField = value;
				this.RaisePropertyChanged("TypesList");
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x001564F0 File Offset: 0x001546F0
		// (set) Token: 0x06004F03 RID: 20227 RVA: 0x00156504 File Offset: 0x00154704
		public bool KkmOptEnable
		{
			[CompilerGenerated]
			get
			{
				return this.<KkmOptEnable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<KkmOptEnable>k__BackingField == value)
				{
					return;
				}
				this.<KkmOptEnable>k__BackingField = value;
				this.RaisePropertyChanged("KkmOptEnable");
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06004F04 RID: 20228 RVA: 0x00156530 File Offset: 0x00154730
		// (set) Token: 0x06004F05 RID: 20229 RVA: 0x00156544 File Offset: 0x00154744
		public int SelectedPaymentSystem
		{
			get
			{
				return this._selectedPaymentSystem;
			}
			set
			{
				if (this._selectedPaymentSystem == value)
				{
					return;
				}
				this._selectedPaymentSystem = value;
				this.RaisePropertyChanged("SelectedPaymentSystem");
				this.Refresh();
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06004F06 RID: 20230 RVA: 0x00156578 File Offset: 0x00154778
		// (set) Token: 0x06004F07 RID: 20231 RVA: 0x0015658C File Offset: 0x0015478C
		public int SelectedType
		{
			get
			{
				return this._selectedType;
			}
			set
			{
				if (this._selectedType == value)
				{
					return;
				}
				this._selectedType = value;
				this.RaisePropertyChanged("SelectedType");
				this.Refresh();
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x001565C0 File Offset: 0x001547C0
		// (set) Token: 0x06004F09 RID: 20233 RVA: 0x001565D4 File Offset: 0x001547D4
		public int SelectedOffice
		{
			get
			{
				return this._selectedOffice;
			}
			set
			{
				if (this._selectedOffice == value)
				{
					return;
				}
				this._selectedOffice = value;
				this.RaisePropertyChanged("SelectedOffice");
				this.Refresh();
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x00156608 File Offset: 0x00154808
		// (set) Token: 0x06004F0B RID: 20235 RVA: 0x0015661C File Offset: 0x0015481C
		public int SelectedCompany
		{
			get
			{
				return this._selectedCompany;
			}
			set
			{
				if (this._selectedCompany == value)
				{
					return;
				}
				this._selectedCompany = value;
				this.RaisePropertyChanged("SelectedCompany");
				this.Refresh();
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x00156650 File Offset: 0x00154850
		// (set) Token: 0x06004F0D RID: 20237 RVA: 0x00156664 File Offset: 0x00154864
		public bool CompaniesVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<CompaniesVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<CompaniesVisible>k__BackingField == value)
				{
					return;
				}
				this.<CompaniesVisible>k__BackingField = value;
				this.RaisePropertyChanged("CompaniesVisible");
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06004F0E RID: 20238 RVA: 0x00156690 File Offset: 0x00154890
		public bool CanViewAllKasses
		{
			get
			{
				return OfflineData.Instance.Employee.Can(54, 0);
			}
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x001566B0 File Offset: 0x001548B0
		public override void OnSelectedItemChanged(CashOrdersLite item)
		{
			this.RefreshContextMenuCommands();
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x001566C4 File Offset: 0x001548C4
		public KassaViewModel(IKassaService kassaService, INavigationService navigationService, IWindowedDocumentService windowedDocumentService)
		{
			this._kassaService = kassaService;
			this._navigationService = navigationService;
			this._windowedDocumentService = windowedDocumentService;
			this.SetViewName("Finances");
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x00156738 File Offset: 0x00154938
		public void SetSelectedOffice(int officeId)
		{
			this.SelectedOffice = officeId;
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x0015674C File Offset: 0x0015494C
		private void Refresh(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x00156760 File Offset: 0x00154960
		private Task Init()
		{
			KassaViewModel.<Init>d__48 <Init>d__;
			<Init>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<KassaViewModel.<Init>d__48>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x001567A4 File Offset: 0x001549A4
		[Command]
		public void CustomSummary(GridCustomSummaryEventArgs e)
		{
			GridSummaryItemEx gridSummaryItemEx = e.Item as GridSummaryItemEx;
			if (gridSummaryItemEx != null)
			{
				if (gridSummaryItemEx.FieldName != "Cash" && gridSummaryItemEx.FieldName != "CashLess" && gridSummaryItemEx.FieldName != "OtherPS" && gridSummaryItemEx.FieldName != "Card")
				{
					return;
				}
				if (e.IsTotalSummary)
				{
					if (e.SummaryProcess == CustomSummaryProcess.Start)
					{
						if (gridSummaryItemEx.Name == "PKO")
						{
							this._pkoSummary = 0m;
						}
						if (gridSummaryItemEx.Name == "RKO")
						{
							this._rkoSummary = 0m;
						}
						if (gridSummaryItemEx.Name == "PKOOtherPS")
						{
							this._pkoOtherPSSummary = 0m;
						}
						if (gridSummaryItemEx.Name == "RKOOtherPS")
						{
							this._rkoOtherPSSummary = 0m;
						}
						if (gridSummaryItemEx.Name == "PKOCashLess")
						{
							this._pkoCashLessSummary = 0m;
						}
						if (gridSummaryItemEx.Name == "RKOCashLess")
						{
							this._rkoCashLessSummary = 0m;
						}
						if (gridSummaryItemEx.Name == "PKOCard")
						{
							this._pkoCardSummary = 0m;
						}
						if (gridSummaryItemEx.Name == "RKOCard")
						{
							this._rkoCardSummary = 0m;
						}
					}
					if (e.SummaryProcess == CustomSummaryProcess.Calculate)
					{
						if (e.FieldValue == null)
						{
							return;
						}
						decimal num;
						decimal.TryParse(e.FieldValue.ToString(), out num);
						if (gridSummaryItemEx.Name == "PKO" && num >= 0m)
						{
							this._pkoSummary += num;
						}
						if (gridSummaryItemEx.Name == "RKO" && num <= 0m)
						{
							this._rkoSummary += num;
						}
						if (gridSummaryItemEx.Name == "PKOOtherPS" && num >= 0m)
						{
							this._pkoOtherPSSummary += num;
						}
						if (gridSummaryItemEx.Name == "RKOOtherPS" && num <= 0m)
						{
							this._rkoOtherPSSummary += num;
						}
						if (gridSummaryItemEx.Name == "PKOCashLess" && num >= 0m)
						{
							this._pkoCashLessSummary += num;
						}
						if (gridSummaryItemEx.Name == "RKOCashLess" && num <= 0m)
						{
							this._rkoCashLessSummary += num;
						}
						if (gridSummaryItemEx.Name == "PKOCard" && num >= 0m)
						{
							this._pkoCardSummary += num;
						}
						if (gridSummaryItemEx.Name == "RKOCard" && num <= 0m)
						{
							this._rkoCardSummary += num;
						}
					}
					if (e.SummaryProcess == CustomSummaryProcess.Finalize)
					{
						if (this.isSummaryFistRun)
						{
							this.isSummaryFistRun = false;
							e.Source.UpdateTotalSummary();
						}
						e.TotalValue = this.GetTotalValue(gridSummaryItemEx.Name);
					}
				}
			}
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x00156B00 File Offset: 0x00154D00
		private decimal GetTotalValue(string name)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
			if (num > 2498955257U)
			{
				if (num > 2536397727U)
				{
					if (num != 4014679561U)
					{
						if (num == 4222464054U)
						{
							if (name == "RKOOtherPS")
							{
								return this._rkoOtherPSSummary;
							}
						}
					}
					else if (name == "RKOCard")
					{
						return this._rkoCardSummary;
					}
				}
				else if (num == 2527675896U)
				{
					if (name == "PKOOtherPS")
					{
						return this._pkoOtherPSSummary;
					}
				}
				else if (num == 2536397727U)
				{
					if (name == "PKOCashLess")
					{
						return this._pkoCashLessSummary;
					}
				}
			}
			else if (num > 2398174095U)
			{
				if (num != 2416085755U)
				{
					if (num == 2498955257U)
					{
						if (name == "PKO")
						{
							return this._pkoSummary;
						}
					}
				}
				else if (name == "PKOCard")
				{
					return this._pkoCardSummary;
				}
			}
			else if (num != 987863997U)
			{
				if (num == 2398174095U && name == "RKO")
				{
					return this._rkoSummary;
				}
			}
			else if (name == "RKOCashLess")
			{
				return this._rkoCashLessSummary;
			}
			return 0m;
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x00156C2C File Offset: 0x00154E2C
		protected override void OnSearchStringChanged(string oldValue)
		{
			KassaViewModel.<OnSearchStringChanged>d__60 <OnSearchStringChanged>d__;
			<OnSearchStringChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnSearchStringChanged>d__.<>4__this = this;
			<OnSearchStringChanged>d__.<>1__state = -1;
			<OnSearchStringChanged>d__.<>t__builder.Start<KassaViewModel.<OnSearchStringChanged>d__60>(ref <OnSearchStringChanged>d__);
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x00156C64 File Offset: 0x00154E64
		[Command]
		public void Refresh()
		{
			KassaViewModel.<Refresh>d__61 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<KassaViewModel.<Refresh>d__61>(ref <Refresh>d__);
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00156C9C File Offset: 0x00154E9C
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem.IsPKO)
			{
				this._navigationService.Navigate("PkoView", new PkoViewModel(base.SelectedItem.id));
				return;
			}
			this._navigationService.Navigate("RkoView", new RkoViewModel(base.SelectedItem.id));
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x0009DBDC File Offset: 0x0009BDDC
		public bool CanItemDoubleClick()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x00156CF8 File Offset: 0x00154EF8
		[Command]
		public void MoneyMove()
		{
			this._windowedDocumentService.ShowNewDocument("MoneyMoveView", Bootstrapper.Container.Resolve<MoneyMoveViewModel>(), this, null);
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x00156D24 File Offset: 0x00154F24
		public bool CanMoneyMove()
		{
			return OfflineData.Instance.Employee.Can(16, 0) && base.IsValid();
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00156D50 File Offset: 0x00154F50
		[Command]
		public void ShowKkt()
		{
			this._windowedDocumentService.ShowNewDocument("KktView", new KktViewModel(), null, null);
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00156D74 File Offset: 0x00154F74
		public bool CanShowKkt()
		{
			return Core.Instance.IsValid() && (OfflineData.Instance.Employee.KktReady() || OfflineData.Instance.Employee.PinpadReady());
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00156DB4 File Offset: 0x00154FB4
		private void RefreshContextMenuCommands()
		{
			base.RaiseCanExecuteChanged(() => this.OpenCustomerCard());
			base.RaiseCanExecuteChanged(() => this.OpenRepairCard());
			base.RaiseCanExecuteChanged(() => this.OpenDocument());
			base.RaiseCanExecuteChanged(() => this.OpenInvoice());
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00156EB0 File Offset: 0x001550B0
		[Command]
		public void OpenCustomerCard()
		{
			this._navigationService.NavigateToCustomerCard(base.SelectedItem.ClientId.Value, null);
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x00156EDC File Offset: 0x001550DC
		public bool CanOpenCustomerCard()
		{
			CashOrdersLite selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.ClientId != null;
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x00156F04 File Offset: 0x00155104
		[Command]
		public void OpenRepairCard()
		{
			this._navigationService.NavigateRepairCard(base.SelectedItem.RepairId.Value);
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00156F30 File Offset: 0x00155130
		public bool CanOpenRepairCard()
		{
			CashOrdersLite selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.RepairId != null;
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00156F58 File Offset: 0x00155158
		[Command]
		public void OpenDocument()
		{
			if (!(base.SelectedItem.summa > 0m))
			{
				if (base.SelectedItem.type != 9)
				{
					this._navigationService.Navigate("InItems", new ItemsArrivalViewModel(base.SelectedItem.DocumentId.Value));
					return;
				}
			}
			this._navigationService.Navigate("ItemsSaleView", new ItemsSaleViewModel(base.SelectedItem.DocumentId.Value));
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00156FE0 File Offset: 0x001551E0
		public bool CanOpenDocument()
		{
			CashOrdersLite selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.DocumentId != null;
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00157008 File Offset: 0x00155208
		[Command]
		public void OpenInvoice()
		{
			this._navigationService.NavigateInvoice(base.SelectedItem.InvoiceId.Value);
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x00157034 File Offset: 0x00155234
		public bool CanOpenInvoice()
		{
			CashOrdersLite selectedItem = base.SelectedItem;
			return selectedItem != null && selectedItem.InvoiceId != null;
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0015705C File Offset: 0x0015525C
		public override void OnUnload()
		{
			base.OnUnload();
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Remove(period.RefreshEventHandler, new EventHandler(this.Refresh));
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00157098 File Offset: 0x00155298
		public override void OnLoad()
		{
			KassaViewModel.<OnLoad>d__78 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<KassaViewModel.<OnLoad>d__78>(ref <OnLoad>d__);
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x001570D0 File Offset: 0x001552D0
		protected virtual void SetOfficesVisible()
		{
			this.OfficesVisible = (OfflineData.Instance.CountOffices() > 1);
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x001570F0 File Offset: 0x001552F0
		private void SetCompaniesVisible()
		{
			this.CompaniesVisible = (OfflineData.Instance.CountCompanies() > 1);
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00157110 File Offset: 0x00155310
		public void SetPeriod(Period period)
		{
			this.Period = period;
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x00157124 File Offset: 0x00155324
		// Note: this type is marked as 'beforefieldinit'.
		static KassaViewModel()
		{
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x00157140 File Offset: 0x00155340
		[CompilerGenerated]
		private Task<List<CashOrdersLite>> <Init>b__48_0()
		{
			return this._kassaService.LoadOrdersAsync(this.SelectedCompany, this.SelectedOffice, this.Period, this.SelectedType, this.SelectedPaymentSystem, base.SearchString);
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x04003483 RID: 13443
		private readonly IKassaService _kassaService;

		// Token: 0x04003484 RID: 13444
		private readonly INavigationService _navigationService;

		// Token: 0x04003485 RID: 13445
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04003486 RID: 13446
		private int _selectedType;

		// Token: 0x04003487 RID: 13447
		private int _selectedOffice;

		// Token: 0x04003488 RID: 13448
		private int _selectedPaymentSystem = -100;

		// Token: 0x04003489 RID: 13449
		private int _selectedCompany;

		// Token: 0x0400348A RID: 13450
		private static readonly Localization _localization = new Localization("UTC");

		// Token: 0x0400348B RID: 13451
		[CompilerGenerated]
		private bool <OfficesVisible>k__BackingField;

		// Token: 0x0400348C RID: 13452
		public EventHandler FilterChangedHandler;

		// Token: 0x0400348D RID: 13453
		[CompilerGenerated]
		private Period <Period>k__BackingField = new Period(KassaViewModel._localization.Now.Date, KassaViewModel._localization.Now.Date);

		// Token: 0x0400348E RID: 13454
		[CompilerGenerated]
		private List<IPaymentType> <TypesList>k__BackingField;

		// Token: 0x0400348F RID: 13455
		[CompilerGenerated]
		private bool <KkmOptEnable>k__BackingField;

		// Token: 0x04003490 RID: 13456
		[CompilerGenerated]
		private bool <CompaniesVisible>k__BackingField;

		// Token: 0x04003491 RID: 13457
		private decimal _pkoSummary;

		// Token: 0x04003492 RID: 13458
		private decimal _rkoSummary;

		// Token: 0x04003493 RID: 13459
		private decimal _pkoOtherPSSummary;

		// Token: 0x04003494 RID: 13460
		private decimal _rkoOtherPSSummary;

		// Token: 0x04003495 RID: 13461
		private decimal _pkoCashLessSummary;

		// Token: 0x04003496 RID: 13462
		private decimal _rkoCashLessSummary;

		// Token: 0x04003497 RID: 13463
		private decimal _pkoCardSummary;

		// Token: 0x04003498 RID: 13464
		private decimal _rkoCardSummary;

		// Token: 0x04003499 RID: 13465
		private bool isSummaryFistRun = true;

		// Token: 0x02000AE9 RID: 2793
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__48 : IAsyncStateMachine
		{
			// Token: 0x06004F2F RID: 20271 RVA: 0x0015717C File Offset: 0x0015537C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaViewModel kassaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<CashOrdersLite>> awaiter;
					if (num != 0)
					{
						kassaViewModel.ShowWait();
						awaiter = Task.Run<List<CashOrdersLite>>(() => kassaViewModel._kassaService.LoadOrdersAsync(base.SelectedCompany, base.SelectedOffice, base.Period, base.SelectedType, base.SelectedPaymentSystem, base.SearchString)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<CashOrdersLite>>, KassaViewModel.<Init>d__48>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<CashOrdersLite>>);
						this.<>1__state = -1;
					}
					List<CashOrdersLite> result = awaiter.GetResult();
					kassaViewModel.SetItems(result);
					kassaViewModel.HideWait();
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

			// Token: 0x06004F30 RID: 20272 RVA: 0x00157250 File Offset: 0x00155450
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400349A RID: 13466
			public int <>1__state;

			// Token: 0x0400349B RID: 13467
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400349C RID: 13468
			public KassaViewModel <>4__this;

			// Token: 0x0400349D RID: 13469
			private TaskAwaiter<List<CashOrdersLite>> <>u__1;
		}

		// Token: 0x02000AEA RID: 2794
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnSearchStringChanged>d__60 : IAsyncStateMachine
		{
			// Token: 0x06004F31 RID: 20273 RVA: 0x0015726C File Offset: 0x0015546C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaViewModel kassaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = kassaViewModel.Init().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaViewModel.<OnSearchStringChanged>d__60>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
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

			// Token: 0x06004F32 RID: 20274 RVA: 0x00157320 File Offset: 0x00155520
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400349E RID: 13470
			public int <>1__state;

			// Token: 0x0400349F RID: 13471
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034A0 RID: 13472
			public KassaViewModel <>4__this;

			// Token: 0x040034A1 RID: 13473
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000AEB RID: 2795
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Refresh>d__61 : IAsyncStateMachine
		{
			// Token: 0x06004F33 RID: 20275 RVA: 0x0015733C File Offset: 0x0015553C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaViewModel kassaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = kassaViewModel.Init().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaViewModel.<Refresh>d__61>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					kassaViewModel.RaiseFilterChanged();
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

			// Token: 0x06004F34 RID: 20276 RVA: 0x001573F4 File Offset: 0x001555F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034A2 RID: 13474
			public int <>1__state;

			// Token: 0x040034A3 RID: 13475
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034A4 RID: 13476
			public KassaViewModel <>4__this;

			// Token: 0x040034A5 RID: 13477
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000AEC RID: 2796
		[CompilerGenerated]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x06004F35 RID: 20277 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass78_0()
			{
			}

			// Token: 0x06004F36 RID: 20278 RVA: 0x00157410 File Offset: 0x00155610
			internal List<IPaymentType> <OnLoad>b__0()
			{
				return this.oo.GetOptions4Kassa();
			}

			// Token: 0x040034A6 RID: 13478
			public OrderOptions oo;
		}

		// Token: 0x02000AED RID: 2797
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__78 : IAsyncStateMachine
		{
			// Token: 0x06004F37 RID: 20279 RVA: 0x00157428 File Offset: 0x00155628
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaViewModel kassaViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<List<IPaymentType>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_129;
						}
						kassaViewModel.<>n__0();
						if (kassaViewModel.TypesList != null)
						{
							goto IL_C8;
						}
						awaiter2 = Task.Run<List<IPaymentType>>(new Func<List<IPaymentType>>(new KassaViewModel.<>c__DisplayClass78_0
						{
							oo = new OrderOptions()
						}.<OnLoad>b__0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<IPaymentType>>, KassaViewModel.<OnLoad>d__78>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<IPaymentType>>);
						this.<>1__state = -1;
					}
					List<IPaymentType> result = awaiter2.GetResult();
					kassaViewModel.TypesList = result;
					IL_C8:
					kassaViewModel.SetCompaniesVisible();
					kassaViewModel.SetOfficesVisible();
					if (!kassaViewModel.CanViewAllKasses)
					{
						kassaViewModel.SetSelectedOffice(Auth.User.office);
					}
					Period period = kassaViewModel.Period;
					period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(kassaViewModel.Refresh));
					awaiter = kassaViewModel.Init().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaViewModel.<OnLoad>d__78>(ref awaiter, ref this);
						return;
					}
					IL_129:
					awaiter.GetResult();
					kassaViewModel.KkmOptEnable = OfflineData.Instance.Employee.KktReady();
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

			// Token: 0x06004F38 RID: 20280 RVA: 0x001575E8 File Offset: 0x001557E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040034A7 RID: 13479
			public int <>1__state;

			// Token: 0x040034A8 RID: 13480
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040034A9 RID: 13481
			public KassaViewModel <>4__this;

			// Token: 0x040034AA RID: 13482
			private TaskAwaiter<List<IPaymentType>> <>u__1;

			// Token: 0x040034AB RID: 13483
			private TaskAwaiter <>u__2;
		}
	}
}
