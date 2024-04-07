using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using ASC.About;
using ASC.Charts.WithdrawFunds;
using ASC.Common.Interfaces;
using ASC.Common.SimpleClasses;
using ASC.Interfaces;
using ASC.ItemsSale;
using ASC.Models;
using ASC.Objects;
using ASC.Properties;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.Services.Concrete;
using ASC.Updater;
using ASC.ViewModel;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;

namespace ASC.WorkspaceV2
{
	// Token: 0x02000122 RID: 290
	public class WorkspaceV2ViewModel : BaseViewModel
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0002F890 File Offset: 0x0002DA90
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0002F8A4 File Offset: 0x0002DAA4
		public List<string> UserRoles
		{
			[CompilerGenerated]
			get
			{
				return this.<UserRoles>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<UserRoles>k__BackingField, value))
				{
					return;
				}
				this.<UserRoles>k__BackingField = value;
				this.RaisePropertyChanged("UserRoles");
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0002F8D4 File Offset: 0x0002DAD4
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0002F8E8 File Offset: 0x0002DAE8
		public Action CloseAction
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CloseAction>k__BackingField, value))
				{
					return;
				}
				this.<CloseAction>k__BackingField = value;
				this.RaisePropertyChanged("CloseAction");
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0002F918 File Offset: 0x0002DB18
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0002F92C File Offset: 0x0002DB2C
		public int ActiveTasks
		{
			[CompilerGenerated]
			get
			{
				return this.<ActiveTasks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ActiveTasks>k__BackingField == value)
				{
					return;
				}
				this.<ActiveTasks>k__BackingField = value;
				this.RaisePropertyChanged("ActiveTasks");
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0002F958 File Offset: 0x0002DB58
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0002F96C File Offset: 0x0002DB6C
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Title>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Title>k__BackingField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0002F99C File Offset: 0x0002DB9C
		public TimeSpan ToasterNotificationDuration
		{
			get
			{
				return TimeSpan.FromSeconds(2.0);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x0002F9CC File Offset: 0x0002DBCC
		public bool NB1Only
		{
			[CompilerGenerated]
			get
			{
				return this.<NB1Only>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<NB1Only>k__BackingField == value)
				{
					return;
				}
				this.<NB1Only>k__BackingField = value;
				this.RaisePropertyChanged("NB1Only");
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0002F9F8 File Offset: 0x0002DBF8
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x0002FA0C File Offset: 0x0002DC0C
		public ICommand OpenRkoCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenRkoCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<OpenRkoCommand>k__BackingField, value))
				{
					return;
				}
				this.<OpenRkoCommand>k__BackingField = value;
				this.RaisePropertyChanged("OpenRkoCommand");
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0002FA3C File Offset: 0x0002DC3C
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0002FA50 File Offset: 0x0002DC50
		public ICommand OpenPkoCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenPkoCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<OpenPkoCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -630757741;
				IL_13:
				switch ((num ^ -158910378) % 4)
				{
				case 0:
					IL_32:
					this.<OpenPkoCommand>k__BackingField = value;
					num = -241616072;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("OpenPkoCommand");
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0002FAAC File Offset: 0x0002DCAC
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x0002FAC0 File Offset: 0x0002DCC0
		public ICommand OpenWorksPriceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenWorksPriceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<OpenWorksPriceCommand>k__BackingField, value))
				{
					return;
				}
				this.<OpenWorksPriceCommand>k__BackingField = value;
				this.RaisePropertyChanged("OpenWorksPriceCommand");
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0002FB04 File Offset: 0x0002DD04
		public ICommand OpenItemsArrivalCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenItemsArrivalCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<OpenItemsArrivalCommand>k__BackingField, value))
				{
					return;
				}
				this.<OpenItemsArrivalCommand>k__BackingField = value;
				this.RaisePropertyChanged("OpenItemsArrivalCommand");
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0002FB34 File Offset: 0x0002DD34
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x0002FB48 File Offset: 0x0002DD48
		public ICommand SalaryCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SalaryCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SalaryCommand>k__BackingField, value))
				{
					return;
				}
				this.<SalaryCommand>k__BackingField = value;
				this.RaisePropertyChanged("SalaryCommand");
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0002FB78 File Offset: 0x0002DD78
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x0002FB8C File Offset: 0x0002DD8C
		public ICommand PriceEditorCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<PriceEditorCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PriceEditorCommand>k__BackingField, value))
				{
					return;
				}
				this.<PriceEditorCommand>k__BackingField = value;
				this.RaisePropertyChanged("PriceEditorCommand");
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0002FBBC File Offset: 0x0002DDBC
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
		public ICommand ChangeLangCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ChangeLangCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ChangeLangCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1818843052;
				IL_13:
				switch ((num ^ -1236140586) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<ChangeLangCommand>k__BackingField = value;
					this.RaisePropertyChanged("ChangeLangCommand");
					num = -1035208231;
					goto IL_13;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0002FC2C File Offset: 0x0002DE2C
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x0002FC40 File Offset: 0x0002DE40
		public ICommand CreateCustomerCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<CreateCustomerCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CreateCustomerCommand>k__BackingField, value))
				{
					return;
				}
				this.<CreateCustomerCommand>k__BackingField = value;
				this.RaisePropertyChanged("CreateCustomerCommand");
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0002FC70 File Offset: 0x0002DE70
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0002FC84 File Offset: 0x0002DE84
		public ICommand NavigateCallsChartCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateCallsChartCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateCallsChartCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateCallsChartCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateCallsChartCommand");
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0002FCB4 File Offset: 0x0002DEB4
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x0002FCC8 File Offset: 0x0002DEC8
		public ICommand NavigateCallConversionsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateCallConversionsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateCallConversionsCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateCallConversionsCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateCallConversionsCommand");
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x0002FD0C File Offset: 0x0002DF0C
		public ICommand NavigateMastersChartCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateMastersChartCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateMastersChartCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateMastersChartCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateMastersChartCommand");
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0002FD3C File Offset: 0x0002DF3C
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x0002FD50 File Offset: 0x0002DF50
		public ICommand NavigatePartsChartViewCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigatePartsChartViewCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigatePartsChartViewCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigatePartsChartViewCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigatePartsChartViewCommand");
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0002FD80 File Offset: 0x0002DF80
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0002FD94 File Offset: 0x0002DF94
		public ICommand NavigateRepairsCharCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateRepairsCharCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateRepairsCharCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateRepairsCharCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateRepairsCharCommand");
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0002FDC4 File Offset: 0x0002DFC4
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		public ICommand NavigateSalesCategoriesChartCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateSalesCategoriesChartCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateSalesCategoriesChartCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateSalesCategoriesChartCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateSalesCategoriesChartCommand");
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0002FE08 File Offset: 0x0002E008
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0002FE1C File Offset: 0x0002E01C
		public ICommand NavigateSalesChartCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateSalesChartCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateSalesChartCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateSalesChartCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateSalesChartCommand");
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0002FE4C File Offset: 0x0002E04C
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x0002FE60 File Offset: 0x0002E060
		public ICommand NavigateVisitSourceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateVisitSourceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<NavigateVisitSourceCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1904772684;
				IL_13:
				switch ((num ^ 1054957161) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<NavigateVisitSourceCommand>k__BackingField = value;
					num = 825469682;
					goto IL_13;
				}
				this.RaisePropertyChanged("NavigateVisitSourceCommand");
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0002FEBC File Offset: 0x0002E0BC
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x0002FED0 File Offset: 0x0002E0D0
		public ICommand NavigateWithdrawFundsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateWithdrawFundsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<NavigateWithdrawFundsCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1734327206;
				IL_13:
				switch ((num ^ -1915907688) % 4)
				{
				case 1:
					IL_32:
					num = -1379864524;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.<NavigateWithdrawFundsCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateWithdrawFundsCommand");
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0002FF2C File Offset: 0x0002E12C
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x0002FF40 File Offset: 0x0002E140
		public ICommand NavigateNewRepairCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateNewRepairCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<NavigateNewRepairCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 428875651;
				IL_13:
				switch ((num ^ 411834462) % 4)
				{
				case 0:
					IL_32:
					this.<NavigateNewRepairCommand>k__BackingField = value;
					num = 1591838128;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("NavigateNewRepairCommand");
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x0002FF9C File Offset: 0x0002E19C
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x0002FFB0 File Offset: 0x0002E1B0
		public ICommand NavigateItemsSaleCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateItemsSaleCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateItemsSaleCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateItemsSaleCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateItemsSaleCommand");
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0002FFE0 File Offset: 0x0002E1E0
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x0002FFF4 File Offset: 0x0002E1F4
		public ICommand NavigateDocumentsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateDocumentsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateDocumentsCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateDocumentsCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateDocumentsCommand");
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x00030024 File Offset: 0x0002E224
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x00030038 File Offset: 0x0002E238
		public ICommand NavigateExportItemsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateExportItemsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateExportItemsCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateExportItemsCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateExportItemsCommand");
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00030068 File Offset: 0x0002E268
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x0003007C File Offset: 0x0002E27C
		public ICommand NavigateStoreManagementCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<NavigateStoreManagementCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NavigateStoreManagementCommand>k__BackingField, value))
				{
					return;
				}
				this.<NavigateStoreManagementCommand>k__BackingField = value;
				this.RaisePropertyChanged("NavigateStoreManagementCommand");
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x000300AC File Offset: 0x0002E2AC
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x000300C0 File Offset: 0x0002E2C0
		public ICommand ExitCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ExitCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ExitCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -452133389;
				IL_13:
				switch ((num ^ -319863290) % 4)
				{
				case 0:
					IL_32:
					this.<ExitCommand>k__BackingField = value;
					this.RaisePropertyChanged("ExitCommand");
					num = -710257511;
					goto IL_13;
				case 1:
					return;
				case 2:
					goto IL_0E;
				}
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0003011C File Offset: 0x0002E31C
		private void InitCommands()
		{
			this.ExitCommand = new RelayCommand(new Action<object>(this.Exit));
			this.ChangeLangCommand = new RelayCommand(new Action<object>(this.ChangeLang));
			this.NavigateCallsChartCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateCallsReport();
			}, new Func<bool>(this.CanNavigateCallsChart), null);
			this.NavigateCallConversionsCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateCallConversionReport();
			}, new Func<bool>(this.CanCallConversions), null);
			this.NavigateMastersChartCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateMastersReport();
			}, new Func<bool>(this.CanViewReports), null);
			this.NavigatePartsChartViewCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateProductsReport();
			}, new Func<bool>(this.CanViewReports), null);
			this.NavigateRepairsCharCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateRepairsChart();
			}, new Func<bool>(this.CanViewReports), null);
			this.NavigateSalesCategoriesChartCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateSalesByCategoryReport();
			}, new Func<bool>(this.CanViewReports), null);
			this.NavigateSalesChartCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateProductSalesReport();
			}, new Func<bool>(this.CanViewReports), null);
			this.NavigateVisitSourceCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateVisitSourceReport();
			}, new Func<bool>(this.CanViewReports), null);
			this.NavigateWithdrawFundsCommand = new DelegateCommand(delegate()
			{
				this._navigationService.Navigate("ASC.Charts.WithdrawFunds.WithdrawFundsView", Bootstrapper.Container.Resolve<ASC.Charts.WithdrawFunds.WithdrawFundsViewModel>());
			}, new Func<bool>(this.CanViewReports), null);
			this.NavigateNewRepairCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateNewRepair();
			}, new Func<bool>(this.CanNewRepair), null);
			this.NavigateItemsSaleCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateSaleProducts();
			}, new Func<bool>(this.CanSale), null);
			this.NavigateDocumentsCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateDocuments();
			}, new Func<bool>(this.CanViewDocuments), null);
			this.NavigateExportItemsCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateProductsCatalogExport();
			}, new Func<bool>(this.CanExportItems), null);
			this.NavigateStoreManagementCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateStoreManagement();
			}, new Func<bool>(base.IsValid), null);
			this.SalaryCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateSalary();
			});
			this.OpenItemsArrivalCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateItemsArrival();
			});
			this.OpenPkoCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateIncome();
			}, new Func<bool>(this.CanCreateRkoPko), null);
			this.OpenRkoCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateOutcome();
			}, new Func<bool>(this.CanCreateRkoPko), null);
			this.PriceEditorCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateProductsMassEditor();
			}, new Func<bool>(base.IsValid), null);
			this.OpenWorksPriceCommand = new DelegateCommand(delegate()
			{
				this._navigationService.NavigateServiceWorksPrice();
			});
			this.CreateCustomerCommand = new DelegateCommand(delegate()
			{
				this._windowedDocumentService.ShowNewDocument("CustomerCreateView", Bootstrapper.Container.Resolve<AddCustomerViewModel>(), null, null);
			}, new Func<bool>(base.IsValid), null);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanNavigateCallsChart()
		{
			return false;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000304B4 File Offset: 0x0002E6B4
		private bool CanCallConversions()
		{
			return false;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000304C4 File Offset: 0x0002E6C4
		[AsyncCommand]
		public Task Loaded()
		{
			WorkspaceV2ViewModel.<Loaded>d__129 <Loaded>d__;
			<Loaded>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Loaded>d__.<>4__this = this;
			<Loaded>d__.<>1__state = -1;
			<Loaded>d__.<>t__builder.Start<WorkspaceV2ViewModel.<Loaded>d__129>(ref <Loaded>d__);
			return <Loaded>d__.<>t__builder.Task;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00030508 File Offset: 0x0002E708
		private void CountUserSessions(object state)
		{
			WorkspaceV2ViewModel.<CountUserSessions>d__130 <CountUserSessions>d__;
			<CountUserSessions>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CountUserSessions>d__.<>4__this = this;
			<CountUserSessions>d__.<>1__state = -1;
			<CountUserSessions>d__.<>t__builder.Start<WorkspaceV2ViewModel.<CountUserSessions>d__130>(ref <CountUserSessions>d__);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00030540 File Offset: 0x0002E740
		[Command]
		public void NavigateNewInvoice()
		{
			this._navigationService.NavigateCreateInvoice();
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00030558 File Offset: 0x0002E758
		public bool CanNavigateNewInvoice()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00030584 File Offset: 0x0002E784
		[Command]
		public void NavigateNewVATInvoice()
		{
			this._navigationService.NavigateCreateVATInvoice();
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00030558 File Offset: 0x0002E758
		public bool CanNavigateNewVATInvoice()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0003059C File Offset: 0x0002E79C
		[Command]
		public void NavigateNewPackingList()
		{
			this._navigationService.NavigateCreatePackingList();
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00030558 File Offset: 0x0002E758
		public bool CanNavigateNewPackingList()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x000305B4 File Offset: 0x0002E7B4
		[Command]
		public void NavigateNewWorksList()
		{
			this._navigationService.NavigateCreateWorksList();
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00030558 File Offset: 0x0002E758
		public bool CanNavigateNewWorksList()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000305CC File Offset: 0x0002E7CC
		[Command]
		public void Navigate()
		{
			this._navigationService.NavigateRepairs();
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000305E4 File Offset: 0x0002E7E4
		[Command]
		public void NavigateStoreView()
		{
			this._navigationService.NavigateToStore();
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000305FC File Offset: 0x0002E7FC
		[Command]
		public void NavigateFinancesChart()
		{
			this._navigationService.NavigateFinancesReport();
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00030614 File Offset: 0x0002E814
		public bool CanNavigateFinancesChart()
		{
			return this.CanViewReports();
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00030628 File Offset: 0x0002E828
		[Command]
		public void NavigateWorkshopStatusByUser()
		{
			this._navigationService.NavigateWorkshopStatusByUser();
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00030614 File Offset: 0x0002E814
		public bool CanNavigateWorkshopStatusByUser()
		{
			return this.CanViewReports();
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00030640 File Offset: 0x0002E840
		[Command]
		public void NavigateStatusChecksReport()
		{
			this._navigationService.NavigateStatusCheckReport();
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00030614 File Offset: 0x0002E814
		public bool CanNavigateStatusChecksReport()
		{
			return this.CanViewReports();
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00030658 File Offset: 0x0002E858
		[Command]
		public void NavigateEmployeesActivityReport()
		{
			this._navigationService.NavigateEmployeesActivityReport();
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00030614 File Offset: 0x0002E814
		public bool CanNavigateEmployeesActivityReport()
		{
			return this.CanViewReports();
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00030670 File Offset: 0x0002E870
		[Command]
		public void NavigateClients()
		{
			this._navigationService.NavigateCustomers();
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00030688 File Offset: 0x0002E888
		[Command]
		public void NavigateKassaView()
		{
			this._navigationService.NavigateKassa();
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000306A0 File Offset: 0x0002E8A0
		[Command]
		public void NavigateStocktakingView()
		{
			this._navigationService.NavigateStocktaking();
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool CanNavigateStocktakingView()
		{
			return base.IsValid();
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000306CC File Offset: 0x0002E8CC
		[Command]
		public void ItemsBuyout()
		{
			this._navigationService.NavigateItemsBuyout();
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool CanItemsBuyout()
		{
			return base.IsValid();
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x000306E4 File Offset: 0x0002E8E4
		[Command]
		public void NavigateTaskManager()
		{
			this._navigationService.NavigateTasks();
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000306FC File Offset: 0x0002E8FC
		[Command]
		public void NavigateFinancesFlowReportView()
		{
			this._navigationService.NavigateFinancesFlowReport();
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00030714 File Offset: 0x0002E914
		public bool CanNavigateFinancesFlowReportView()
		{
			return OfflineData.Instance.Employee.Can(12, 0);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00030734 File Offset: 0x0002E934
		[Command]
		public void NavigateZnamenFinancesFlowReportView()
		{
			this._navigationService.NavigateZnamenFinancesFlowReport();
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0003074C File Offset: 0x0002E94C
		public bool CanNavigateZnamenFinancesFlowReportView()
		{
			return OfflineData.Instance.Employee.Can(12, 0) && this.NB1Only;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00030778 File Offset: 0x0002E978
		[Command]
		public void NavigateWiolinReport()
		{
			this._navigationService.NavigateWiolinReport();
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0003074C File Offset: 0x0002E94C
		public bool CanNavigateWiolinReport()
		{
			return OfflineData.Instance.Employee.Can(12, 0) && this.NB1Only;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00030790 File Offset: 0x0002E990
		[Command]
		public void OpenSmses()
		{
			this._navigationService.NavigateSmsList();
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000307A8 File Offset: 0x0002E9A8
		public bool CanOpenSmses()
		{
			return OfflineData.Instance.Employee.Can(22, 0) && base.IsValid();
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000307D4 File Offset: 0x0002E9D4
		[Command]
		public void NavigateRepairStatusesView()
		{
			this._navigationService.NavigateRepairStatusesReport();
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000307EC File Offset: 0x0002E9EC
		public bool CanNavigateRepairStatusesView()
		{
			return OfflineData.Instance.Employee.Can(12, 0) && base.IsValid();
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool CanNavigateClients()
		{
			return OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00030818 File Offset: 0x0002EA18
		[Command]
		public void NavigateRequestsManager()
		{
			this._navigationService.NavigateRequestsManager();
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00030830 File Offset: 0x0002EA30
		public bool CanNavigateRequestsManager()
		{
			return OfflineData.Instance.Employee.Can(70, 0) && base.IsValid();
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0003085C File Offset: 0x0002EA5C
		public bool CanNavigateKassaView()
		{
			return OfflineData.Instance.Employee.Can(20, 0);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0003087C File Offset: 0x0002EA7C
		[Command]
		public void NavigateRepairMassEdit()
		{
			this._navigationService.NavigateRepairMassEdit();
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00030894 File Offset: 0x0002EA94
		public bool CanNavigateRepairMassEdit()
		{
			return OfflineData.Instance.Employee.Can(25, 0);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000308B4 File Offset: 0x0002EAB4
		[Command]
		public void OpenCalls()
		{
			this._navigationService.NavigateCalls();
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000308CC File Offset: 0x0002EACC
		public bool CanOpenCalls()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(24, 0);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x000308F8 File Offset: 0x0002EAF8
		private bool CanNewRepair()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(2, 0);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00030920 File Offset: 0x0002EB20
		[Command]
		public void OpenInvoice()
		{
			this._navigationService.NavigateInvoiceList();
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00030558 File Offset: 0x0002E758
		public bool CanOpenInvoice()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(65, 0);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000306B8 File Offset: 0x0002E8B8
		private bool CanExportItems()
		{
			return base.IsValid();
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x000307EC File Offset: 0x0002E9EC
		private bool CanViewReports()
		{
			return OfflineData.Instance.Employee.Can(12, 0) && base.IsValid();
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00030938 File Offset: 0x0002EB38
		private bool CanCreateRkoPko()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(16, 0);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00030964 File Offset: 0x0002EB64
		private bool CanSale()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(5, 0);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0003098C File Offset: 0x0002EB8C
		private bool CanViewDocuments()
		{
			return OfflineData.Instance.Employee.Can(15, 0);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000309AC File Offset: 0x0002EBAC
		private void RefreshCommands()
		{
			base.RaiseCanExecuteChanged(() => this.NavigateNewInvoice());
			base.RaiseCanExecuteChanged(() => this.NavigateNewVATInvoice());
			base.RaiseCanExecuteChanged(() => this.NavigateNewPackingList());
			base.RaiseCanExecuteChanged(() => this.OpenInvoice());
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x00030AA8 File Offset: 0x0002ECA8
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x00030ABC File Offset: 0x0002ECBC
		public NotificationsPanelViewModel NotificationsPanelViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<NotificationsPanelViewModel>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<NotificationsPanelViewModel>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1791693970;
				IL_13:
				switch ((num ^ -2107961832) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<NotificationsPanelViewModel>k__BackingField = value;
					this.RaisePropertyChanged("NotificationsPanelViewModel");
					num = -928107207;
					goto IL_13;
				}
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00030B18 File Offset: 0x0002ED18
		public WorkspaceV2ViewModel(ASC.Services.Abstract.INavigationService navigationService, ILicenseService licenseService, ISoundService soundService, IUserActivityService userActivityService, IToasterService toasterService, IWindowedDocumentService windowedDocumentService, IWaitIndicatorService waitIndicatorService, IAscMessageBoxService ascMessageBoxService, ITaskService taskService)
		{
			this.Title = string.Concat(new string[]
			{
				"ASC CRM [",
				OfflineData.Instance.Employee.Office.Name,
				"] [",
				OfflineData.Instance.Employee.FioShort,
				"]"
			});
			this._navigationService = navigationService;
			this._navigationService.SetParentViewModel(this);
			this._licenseService = licenseService;
			this._soundService = soundService;
			this._userActivityService = userActivityService;
			this._toasterService = toasterService;
			this._toasterService.SetParentViewModel(this);
			waitIndicatorService.SetParentViewModel(this);
			this._ascMessageBoxService = ascMessageBoxService;
			this._taskService = taskService;
			this._ascMessageBoxService.SetParentViewModel(this);
			this._windowedDocumentService = windowedDocumentService;
			this._windowedDocumentService.SetParentViewModel(this);
			this.Init();
			this._core = Core.Instance;
			this._core.Validated += this.Validated;
			this._countTasksTimer = new Timer(new TimerCallback(this.CountTasks), null, 0, 30000);
			this.InitCommands();
			Messenger.Default.Register(this, new Action<Message>(this.OnMessage));
			this.NotificationsPanelViewModel = Bootstrapper.Container.Resolve<NotificationsPanelViewModel>();
			this.NotificationsPanelViewModel.SetParentViewModel(this);
			this.NotificationsPanelViewModel.Start();
			if (OfflineData.Instance.Employee.Can(16, 0))
			{
				this.PreheatReports();
			}
			this.NB1Only = AuthModel.IsDev();
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00030CD8 File Offset: 0x0002EED8
		private void CheckLicenseExpirationDelayed(int seconds)
		{
			WorkspaceV2ViewModel.<CheckLicenseExpirationDelayed>d__188 <CheckLicenseExpirationDelayed>d__;
			<CheckLicenseExpirationDelayed>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CheckLicenseExpirationDelayed>d__.<>4__this = this;
			<CheckLicenseExpirationDelayed>d__.seconds = seconds;
			<CheckLicenseExpirationDelayed>d__.<>1__state = -1;
			<CheckLicenseExpirationDelayed>d__.<>t__builder.Start<WorkspaceV2ViewModel.<CheckLicenseExpirationDelayed>d__188>(ref <CheckLicenseExpirationDelayed>d__);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00030D18 File Offset: 0x0002EF18
		private void CheckForUpdatesDelayed(int seconds)
		{
			WorkspaceV2ViewModel.<CheckForUpdatesDelayed>d__189 <CheckForUpdatesDelayed>d__;
			<CheckForUpdatesDelayed>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CheckForUpdatesDelayed>d__.<>4__this = this;
			<CheckForUpdatesDelayed>d__.seconds = seconds;
			<CheckForUpdatesDelayed>d__.<>1__state = -1;
			<CheckForUpdatesDelayed>d__.<>t__builder.Start<WorkspaceV2ViewModel.<CheckForUpdatesDelayed>d__189>(ref <CheckForUpdatesDelayed>d__);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00030D58 File Offset: 0x0002EF58
		private void InstanceOnNewUpdate(object sender, EventArgs e)
		{
			AutoUpdater autoUpdater = sender as AutoUpdater;
			if (autoUpdater != null)
			{
				string text = autoUpdater.UpdateVersion();
				if (!string.IsNullOrEmpty(Settings.Default.SkipUpdate) && Settings.Default.SkipUpdate.Equals(text))
				{
					return;
				}
				UpdateViewModel vm = Bootstrapper.Container.Resolve<UpdateViewModel>();
				vm.SetVersion(text);
				Application.Current.Dispatcher.Invoke(delegate()
				{
					this._windowedDocumentService.ShowNewDocument("UpdateView", vm, null, null);
				});
			}
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		private void PreheatReports()
		{
			Task.Run(delegate()
			{
				Thread.Sleep(5000);
				using (List<AssemblyName>.Enumerator enumerator = typeof(ReportPrintTool).Assembly.GetReferencedAssemblies().ToList<AssemblyName>().Distinct<AssemblyName>().ToList<AssemblyName>().GetEnumerator())
				{
					for (;;)
					{
						IL_87:
						int num = (!enumerator.MoveNext()) ? 1894836746 : 1956386203;
						for (;;)
						{
							switch ((num ^ 1954795014) % 4)
							{
							case 1:
								Assembly.Load(enumerator.Current);
								num = 932452188;
								continue;
							case 2:
								goto IL_87;
							case 3:
								num = 1956386203;
								continue;
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
			});
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00030E14 File Offset: 0x0002F014
		private void TestCall()
		{
			Task.Run(delegate()
			{
				Thread.Sleep(1500);
			}).ContinueWith(delegate(Task t)
			{
				Messenger.Default.Send(new Message("71111111117", "71111111117", MessageType.InCall));
			}, TaskScheduler.Current);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00030E70 File Offset: 0x0002F070
		private void Init()
		{
			WorkspaceV2ViewModel.<Init>d__193 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<WorkspaceV2ViewModel.<Init>d__193>(ref <Init>d__);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00030EA8 File Offset: 0x0002F0A8
		private void CountTasks(object state)
		{
			WorkspaceV2ViewModel.<CountTasks>d__194 <CountTasks>d__;
			<CountTasks>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CountTasks>d__.<>4__this = this;
			<CountTasks>d__.<>1__state = -1;
			<CountTasks>d__.<>t__builder.Start<WorkspaceV2ViewModel.<CountTasks>d__194>(ref <CountTasks>d__);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00030EE0 File Offset: 0x0002F0E0
		private void Validated(object sender, EventArgs e)
		{
			try
			{
				Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(this.RefreshCommands));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00030F20 File Offset: 0x0002F120
		private void UserLogout()
		{
			Core core = this._core;
			if (core != null)
			{
				core.StopUserActivitySync();
			}
			this._userActivityService.AddActivity("Logout");
			this._userActivityService.SyncActivity();
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00030F5C File Offset: 0x0002F15C
		private void Exit(object obj)
		{
			this.CloseWorkspaceWindow();
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00030F70 File Offset: 0x0002F170
		private void ChangeLang(object obj)
		{
			this.ChangeLanguage((string)obj);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00030F8C File Offset: 0x0002F18C
		private void ChangeLanguage(string lang)
		{
			App.SelectCulture(lang);
			Settings.Default.language = lang;
			Settings.Default.Save();
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		[Command]
		public void AboutOpen()
		{
			this._windowedDocumentService.TransparentBackground();
			this._windowedDocumentService.ShowNewDocument("AboutView", Bootstrapper.Container.Resolve<AboutViewModel>(), this, null);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00030FE8 File Offset: 0x0002F1E8
		[Command]
		public void OnKeyUp(KeyEventArgs args)
		{
			try
			{
				if (args.Key == Key.F1)
				{
					this.Navigate();
				}
				if (args.Key == Key.F2)
				{
					this.NavigateStoreView();
				}
				if (args.Key == Key.F3)
				{
					if (this.CanNavigateClients())
					{
						this._navigationService.NavigateCustomers();
					}
				}
				if (args.Key == Key.F4)
				{
					if (this.CanNavigateKassaView())
					{
						this._navigationService.NavigateKassa();
					}
				}
				Key key = args.Key;
				if (args.Key == Key.F6)
				{
					this.NavigateTaskManager();
				}
				if (args.Key == Key.F7)
				{
					this.OpenSettings();
				}
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000310A4 File Offset: 0x0002F2A4
		[Command]
		public void OnPreviewTextInput(TextCompositionEventArgs args)
		{
			if (!this._listenBarCode)
			{
				return;
			}
			try
			{
				if ((DateTime.Now - this._lastKeyPress).TotalMilliseconds > 200.0)
				{
					this._barcode = string.Empty;
				}
				this._barcode += args.Text;
				this._lastKeyPress = DateTime.Now;
				if (this._barcode.Length == 12 && Barcode.IsAscCode(this._barcode))
				{
					args.Handled = true;
					TextBox textBox = args.OriginalSource as TextBox;
					if (textBox != null)
					{
						textBox.Text = textBox.Text.Replace(this._barcode.Substring(0, 11), "");
					}
					this.OpenCardByBarcode(this._barcode);
					this._barcode = string.Empty;
				}
			}
			catch (Exception ex)
			{
				this._toasterService.Error(ex.Message);
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000311A0 File Offset: 0x0002F3A0
		private static char? GetKeyText(Key key)
		{
			string text = key.ToString();
			if (text.Length == 1)
			{
				return new char?(text[0]);
			}
			if (text.StartsWith("D") && text.Length == 2)
			{
				return new char?(text[1]);
			}
			if (!text.StartsWith("NumPad"))
			{
				return null;
			}
			return new char?(text[text.Length - 1]);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00031220 File Offset: 0x0002F420
		private void OpenCardByBarcode(string code)
		{
			switch (Barcode.GetTypeFromCode(code))
			{
			case 1:
			{
				int idFromCode = Barcode.GetIdFromCode(code);
				if (idFromCode > 0)
				{
					this.Add2SalesWindowOrOpenCard(idFromCode);
					return;
				}
				break;
			}
			case 2:
			{
				int idFromCode2 = Barcode.GetIdFromCode(code);
				if (idFromCode2 > 0)
				{
					this._navigationService.NavigateRepairCard(idFromCode2);
					return;
				}
				break;
			}
			case 3:
			{
				int idFromCode3 = Barcode.GetIdFromCode(code);
				if (idFromCode3 > 0)
				{
					this._navigationService.Navigate("RepairCartridgeView", new RepairCartridgeViewModel(idFromCode3));
					return;
				}
				break;
			}
			case 4:
			{
				int idFromCode4 = Barcode.GetIdFromCode(code);
				if (idFromCode4 > 0)
				{
					this._navigationService.NavigateItemsArrivalDocument(idFromCode4);
				}
				break;
			}
			case 5:
			{
				int idFromCode5 = Barcode.GetIdFromCode(code);
				if (idFromCode5 > 0)
				{
					this._navigationService.NavigateSaleDocument(idFromCode5);
					return;
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000312D8 File Offset: 0x0002F4D8
		private void Add2SalesWindowOrOpenCard(int itemId)
		{
			ItemsSaleViewModel itemsSaleViewModel = this._navigationService.CurrentTabViewModelOrNull() as ItemsSaleViewModel;
			if (itemsSaleViewModel != null)
			{
				try
				{
					using (auseceEntities auseceEntities = new auseceEntities(true))
					{
						auseceEntities.Configuration.ProxyCreationEnabled = false;
						store_items store_items = auseceEntities.store_items.AsNoTracking().FirstOrDefault((store_items i) => i.id == itemId);
						if (store_items != null)
						{
							itemsSaleViewModel.AddItem(store_items);
						}
					}
				}
				catch (Exception)
				{
				}
				return;
			}
			this._navigationService.NavigateToStoreItem(itemId, 0);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000313DC File Offset: 0x0002F5DC
		private void OnMessage(Message message)
		{
			WorkspaceV2ViewModel.<OnMessage>d__211 <OnMessage>d__;
			<OnMessage>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnMessage>d__.<>4__this = this;
			<OnMessage>d__.message = message;
			<OnMessage>d__.<>1__state = -1;
			<OnMessage>d__.<>t__builder.Start<WorkspaceV2ViewModel.<OnMessage>d__211>(ref <OnMessage>d__);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0003141C File Offset: 0x0002F61C
		private Task CreateNotification(Message message)
		{
			WorkspaceV2ViewModel.<CreateNotification>d__212 <CreateNotification>d__;
			<CreateNotification>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateNotification>d__.<>4__this = this;
			<CreateNotification>d__.message = message;
			<CreateNotification>d__.<>1__state = -1;
			<CreateNotification>d__.<>t__builder.Start<WorkspaceV2ViewModel.<CreateNotification>d__212>(ref <CreateNotification>d__);
			return <CreateNotification>d__.<>t__builder.Task;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00031468 File Offset: 0x0002F668
		[Command]
		public void ClearAllNotifications(object obj)
		{
			MouseButtonEventArgs mouseButtonEventArgs = obj as MouseButtonEventArgs;
			if (mouseButtonEventArgs != null)
			{
				goto IL_2E;
			}
			IL_0A:
			int num = -1865974596;
			IL_0F:
			switch ((num ^ -501205863) % 4)
			{
			case 0:
				goto IL_0A;
			case 1:
				return;
			case 2:
				IL_2E:
				mouseButtonEventArgs.Handled = true;
				num = -1768381966;
				goto IL_0F;
			}
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000314B4 File Offset: 0x0002F6B4
		[Command]
		public void NavigateBoxesReport()
		{
			this._navigationService.NavigateBoxesReport();
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00030614 File Offset: 0x0002E814
		public bool CanNavigateBoxesReport()
		{
			return this.CanViewReports();
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000314CC File Offset: 0x0002F6CC
		[Command]
		public void NavigateNewCartrige()
		{
			this._navigationService.NavigateNewCartridge();
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000314E4 File Offset: 0x0002F6E4
		public bool CanNavigateNewCartrige()
		{
			return base.IsValid() && OfflineData.Instance.Employee.Can(2, 0) && Auth.Config.cartridge_enable;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00031518 File Offset: 0x0002F718
		[Command]
		public void NavigateCartrigeCards()
		{
			this._navigationService.NavigateCartridgeCardsEditor();
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanNavigateCartrigeCards()
		{
			return false;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00031530 File Offset: 0x0002F730
		[Command]
		public void OpenSettings()
		{
			this._navigationService.NavigateSettings();
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00031548 File Offset: 0x0002F748
		[Command]
		public void CheckForUpdates()
		{
			this._windowedDocumentService.ShowNewDocument("UpdateView", new UpdateViewModel(), null, null);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0003156C File Offset: 0x0002F76C
		[Command]
		public void Logout()
		{
			this.AllowShutdown = false;
			this.CloseWorkspaceWindow();
			\u206A\u206B\u200D\u202A\u206B\u202B\u202C\u200D\u206D\u206E\u200D\u200B\u202C\u202B\u200C\u200B\u200C\u202A\u202C\u202E\u200C\u206B\u200C\u200E\u206E\u200B\u200B\u202A\u200B\u202D\u200F\u202E\u206B\u206B\u202A\u202C\u200B\u200F\u202E\u202D\u202E.\u200F\u206F\u206D\u206A\u206D\u200B\u206B\u202B\u202B\u206F\u200F\u206B\u206D\u202D\u200E\u200C\u202A\u202C\u202E\u202E\u200E\u202B\u200C\u206B\u202E\u202A\u202B\u202A\u206C\u202B\u206B\u206B\u200C\u206E\u200E\u202A\u206B\u200B\u202A\u206D\u202E();
			Auth auth = Application.Current.MainWindow as Auth;
			if (auth != null)
			{
				auth.ClearPassword();
				auth.AuthModel.DefaultVisibility = true;
				auth.Show();
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000315B8 File Offset: 0x0002F7B8
		private void CloseWorkspaceWindow()
		{
			Application.Current.Windows.OfType<WorkspaceV2View>().SingleOrDefault<WorkspaceV2View>().Close();
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000315E0 File Offset: 0x0002F7E0
		[Command]
		public void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			for (;;)
			{
				IL_07:
				uint num = 2706467894U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3190501194U)) % 13U)
					{
					case 0U:
					{
						Timer countUserSessionsTimer = this._countUserSessionsTimer;
						if (countUserSessionsTimer != null)
						{
							countUserSessionsTimer.Change(-1, -1);
							num = 3347637971U;
							continue;
						}
						break;
					}
					case 1U:
						e.Cancel = false;
						num = 2385235911U;
						continue;
					case 2U:
						num = ((this.AllowShutdown ? 3248036279U : 2263762318U) ^ num2 * 2727595798U);
						continue;
					case 3U:
						base.ShowWait();
						OfflineData.Instance.Employee.Kkt.ZOrder();
						base.HideWait();
						num = (num2 * 13661398U ^ 621796735U);
						continue;
					case 4U:
						Settings.Default.Save();
						num = (num2 * 2193949519U ^ 2525113006U);
						continue;
					case 5U:
						num = (((this._ascMessageBoxService.ShowMessageBox(Lang.t("KkmzOrder") + "?", "ККТ " + Lang.t("ShiftOpened"), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) ? 1411085399U : 1994920153U) ^ num2 * 3374222036U);
						continue;
					case 6U:
						num = ((OfflineData.Instance.Employee.KktReady() ? 2942626735U : 3559958645U) ^ num2 * 1853175663U);
						continue;
					case 7U:
						base.ShowWait();
						num = (num2 * 139917682U ^ 3169974112U);
						continue;
					case 8U:
						this.UserLogout();
						num = (num2 * 2244631711U ^ 1516801274U);
						continue;
					case 9U:
					{
						bool flag = OfflineData.Instance.Employee.Kkt.IsShiftOpened();
						base.HideWait();
						num = ((flag ? 3134923384U : 2179937521U) ^ num2 * 3299809688U);
						continue;
					}
					case 10U:
						goto IL_07;
					case 12U:
						Application.Current.Shutdown();
						num = (num2 * 3961742289U ^ 3076974179U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			Timer countTasksTimer = this._countTasksTimer;
			if (countTasksTimer == null)
			{
				return;
			}
			countTasksTimer.Change(-1, -1);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00031800 File Offset: 0x0002FA00
		[CompilerGenerated]
		private void <InitCommands>b__126_0()
		{
			this._navigationService.NavigateCallsReport();
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00031818 File Offset: 0x0002FA18
		[CompilerGenerated]
		private void <InitCommands>b__126_1()
		{
			this._navigationService.NavigateCallConversionReport();
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00031830 File Offset: 0x0002FA30
		[CompilerGenerated]
		private void <InitCommands>b__126_2()
		{
			this._navigationService.NavigateMastersReport();
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00031848 File Offset: 0x0002FA48
		[CompilerGenerated]
		private void <InitCommands>b__126_3()
		{
			this._navigationService.NavigateProductsReport();
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00031860 File Offset: 0x0002FA60
		[CompilerGenerated]
		private void <InitCommands>b__126_4()
		{
			this._navigationService.NavigateRepairsChart();
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00031878 File Offset: 0x0002FA78
		[CompilerGenerated]
		private void <InitCommands>b__126_5()
		{
			this._navigationService.NavigateSalesByCategoryReport();
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00031890 File Offset: 0x0002FA90
		[CompilerGenerated]
		private void <InitCommands>b__126_6()
		{
			this._navigationService.NavigateProductSalesReport();
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000318A8 File Offset: 0x0002FAA8
		[CompilerGenerated]
		private void <InitCommands>b__126_7()
		{
			this._navigationService.NavigateVisitSourceReport();
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000318C0 File Offset: 0x0002FAC0
		[CompilerGenerated]
		private void <InitCommands>b__126_8()
		{
			this._navigationService.Navigate("ASC.Charts.WithdrawFunds.WithdrawFundsView", Bootstrapper.Container.Resolve<ASC.Charts.WithdrawFunds.WithdrawFundsViewModel>());
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000318E8 File Offset: 0x0002FAE8
		[CompilerGenerated]
		private void <InitCommands>b__126_9()
		{
			this._navigationService.NavigateNewRepair();
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00031900 File Offset: 0x0002FB00
		[CompilerGenerated]
		private void <InitCommands>b__126_10()
		{
			this._navigationService.NavigateSaleProducts();
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00031918 File Offset: 0x0002FB18
		[CompilerGenerated]
		private void <InitCommands>b__126_11()
		{
			this._navigationService.NavigateDocuments();
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00031930 File Offset: 0x0002FB30
		[CompilerGenerated]
		private void <InitCommands>b__126_12()
		{
			this._navigationService.NavigateProductsCatalogExport();
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00031948 File Offset: 0x0002FB48
		[CompilerGenerated]
		private void <InitCommands>b__126_13()
		{
			this._navigationService.NavigateStoreManagement();
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00031960 File Offset: 0x0002FB60
		[CompilerGenerated]
		private void <InitCommands>b__126_14()
		{
			this._navigationService.NavigateSalary();
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00031978 File Offset: 0x0002FB78
		[CompilerGenerated]
		private void <InitCommands>b__126_15()
		{
			this._navigationService.NavigateItemsArrival();
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00031990 File Offset: 0x0002FB90
		[CompilerGenerated]
		private void <InitCommands>b__126_16()
		{
			this._navigationService.NavigateIncome();
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000319A8 File Offset: 0x0002FBA8
		[CompilerGenerated]
		private void <InitCommands>b__126_17()
		{
			this._navigationService.NavigateOutcome();
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000319C0 File Offset: 0x0002FBC0
		[CompilerGenerated]
		private void <InitCommands>b__126_18()
		{
			this._navigationService.NavigateProductsMassEditor();
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000319D8 File Offset: 0x0002FBD8
		[CompilerGenerated]
		private void <InitCommands>b__126_19()
		{
			this._navigationService.NavigateServiceWorksPrice();
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000319F0 File Offset: 0x0002FBF0
		[CompilerGenerated]
		private void <InitCommands>b__126_20()
		{
			this._windowedDocumentService.ShowNewDocument("CustomerCreateView", Bootstrapper.Container.Resolve<AddCustomerViewModel>(), null, null);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00031A1C File Offset: 0x0002FC1C
		[CompilerGenerated]
		private void <CheckLicenseExpirationDelayed>b__188_0(Task t)
		{
			double days = this._licenseService.ExpirationDays();
			if (days < 8.0)
			{
				Application.Current.Dispatcher.Invoke(delegate()
				{
					ILicenseExpirationViewModel licenseExpirationViewModel = Bootstrapper.Container.Resolve<ILicenseExpirationViewModel>();
					licenseExpirationViewModel.SetExpireDays(Convert.ToInt32(days));
					this._windowedDocumentService.TransparentBackground();
					this._windowedDocumentService.ShowNewDocument("LicenseExpirationView", licenseExpirationViewModel, this, null);
				});
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00031A74 File Offset: 0x0002FC74
		[CompilerGenerated]
		private void <CheckForUpdatesDelayed>b__189_0(Task t)
		{
			AutoUpdater.Initialize(AuthModel.GetUpdatePath(), Assembly.GetExecutingAssembly().GetName().Version.ToString());
			AutoUpdater.Instance.NewUpdate += this.InstanceOnNewUpdate;
		}

		// Token: 0x04000A0F RID: 2575
		private readonly ASC.Services.Abstract.INavigationService _navigationService;

		// Token: 0x04000A10 RID: 2576
		private readonly ILicenseService _licenseService;

		// Token: 0x04000A11 RID: 2577
		private readonly ISoundService _soundService;

		// Token: 0x04000A12 RID: 2578
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04000A13 RID: 2579
		private readonly ITaskService _taskService;

		// Token: 0x04000A14 RID: 2580
		private readonly IUserActivityService _userActivityService;

		// Token: 0x04000A15 RID: 2581
		private readonly IToasterService _toasterService;

		// Token: 0x04000A16 RID: 2582
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000A17 RID: 2583
		private Core _core;

		// Token: 0x04000A18 RID: 2584
		private readonly ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x04000A19 RID: 2585
		[CompilerGenerated]
		private List<string> <UserRoles>k__BackingField;

		// Token: 0x04000A1A RID: 2586
		[CompilerGenerated]
		private Action <CloseAction>k__BackingField;

		// Token: 0x04000A1B RID: 2587
		private Timer _countTasksTimer;

		// Token: 0x04000A1C RID: 2588
		private Timer _countUserSessionsTimer;

		// Token: 0x04000A1D RID: 2589
		[CompilerGenerated]
		private int <ActiveTasks>k__BackingField;

		// Token: 0x04000A1E RID: 2590
		[CompilerGenerated]
		private string <Title>k__BackingField;

		// Token: 0x04000A1F RID: 2591
		[CompilerGenerated]
		private bool <NB1Only>k__BackingField;

		// Token: 0x04000A20 RID: 2592
		[CompilerGenerated]
		private ICommand <OpenRkoCommand>k__BackingField;

		// Token: 0x04000A21 RID: 2593
		[CompilerGenerated]
		private ICommand <OpenPkoCommand>k__BackingField;

		// Token: 0x04000A22 RID: 2594
		[CompilerGenerated]
		private ICommand <OpenWorksPriceCommand>k__BackingField;

		// Token: 0x04000A23 RID: 2595
		[CompilerGenerated]
		private ICommand <OpenItemsArrivalCommand>k__BackingField;

		// Token: 0x04000A24 RID: 2596
		[CompilerGenerated]
		private ICommand <SalaryCommand>k__BackingField;

		// Token: 0x04000A25 RID: 2597
		[CompilerGenerated]
		private ICommand <PriceEditorCommand>k__BackingField;

		// Token: 0x04000A26 RID: 2598
		[CompilerGenerated]
		private ICommand <ChangeLangCommand>k__BackingField;

		// Token: 0x04000A27 RID: 2599
		[CompilerGenerated]
		private ICommand <CreateCustomerCommand>k__BackingField;

		// Token: 0x04000A28 RID: 2600
		[CompilerGenerated]
		private ICommand <NavigateCallsChartCommand>k__BackingField;

		// Token: 0x04000A29 RID: 2601
		[CompilerGenerated]
		private ICommand <NavigateCallConversionsCommand>k__BackingField;

		// Token: 0x04000A2A RID: 2602
		[CompilerGenerated]
		private ICommand <NavigateMastersChartCommand>k__BackingField;

		// Token: 0x04000A2B RID: 2603
		[CompilerGenerated]
		private ICommand <NavigatePartsChartViewCommand>k__BackingField;

		// Token: 0x04000A2C RID: 2604
		[CompilerGenerated]
		private ICommand <NavigateRepairsCharCommand>k__BackingField;

		// Token: 0x04000A2D RID: 2605
		[CompilerGenerated]
		private ICommand <NavigateSalesCategoriesChartCommand>k__BackingField;

		// Token: 0x04000A2E RID: 2606
		[CompilerGenerated]
		private ICommand <NavigateSalesChartCommand>k__BackingField;

		// Token: 0x04000A2F RID: 2607
		[CompilerGenerated]
		private ICommand <NavigateVisitSourceCommand>k__BackingField;

		// Token: 0x04000A30 RID: 2608
		[CompilerGenerated]
		private ICommand <NavigateWithdrawFundsCommand>k__BackingField;

		// Token: 0x04000A31 RID: 2609
		[CompilerGenerated]
		private ICommand <NavigateNewRepairCommand>k__BackingField;

		// Token: 0x04000A32 RID: 2610
		[CompilerGenerated]
		private ICommand <NavigateItemsSaleCommand>k__BackingField;

		// Token: 0x04000A33 RID: 2611
		[CompilerGenerated]
		private ICommand <NavigateDocumentsCommand>k__BackingField;

		// Token: 0x04000A34 RID: 2612
		[CompilerGenerated]
		private ICommand <NavigateExportItemsCommand>k__BackingField;

		// Token: 0x04000A35 RID: 2613
		[CompilerGenerated]
		private ICommand <NavigateStoreManagementCommand>k__BackingField;

		// Token: 0x04000A36 RID: 2614
		[CompilerGenerated]
		private ICommand <ExitCommand>k__BackingField;

		// Token: 0x04000A37 RID: 2615
		[CompilerGenerated]
		private NotificationsPanelViewModel <NotificationsPanelViewModel>k__BackingField;

		// Token: 0x04000A38 RID: 2616
		private bool AllowShutdown = true;

		// Token: 0x04000A39 RID: 2617
		private bool _listenBarCode = true;

		// Token: 0x04000A3A RID: 2618
		private DateTime _lastKeyPress = DateTime.Now;

		// Token: 0x04000A3B RID: 2619
		private clients customer;

		// Token: 0x04000A3C RID: 2620
		private string _barcode = "";

		// Token: 0x02000123 RID: 291
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Loaded>d__129 : IAsyncStateMachine
		{
			// Token: 0x06001549 RID: 5449 RVA: 0x00031AB8 File Offset: 0x0002FCB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel workspaceV2ViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_110;
						}
						workspaceV2ViewModel._soundService.Play(SoundService.Sound.Start);
						workspaceV2ViewModel.ShowWait();
						awaiter = Task.Delay(300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkspaceV2ViewModel.<Loaded>d__129>(ref awaiter, ref this);
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
					int workspace_mode = Auth.User.workspace_mode;
					if (workspace_mode == 0)
					{
						workspaceV2ViewModel._navigationService.NavigateRepairs();
					}
					else if (workspace_mode == 1)
					{
						workspaceV2ViewModel.NavigateStoreView();
					}
					workspaceV2ViewModel.HideWait();
					awaiter = Task.Delay(5000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkspaceV2ViewModel.<Loaded>d__129>(ref awaiter, ref this);
						return;
					}
					IL_110:
					awaiter.GetResult();
					if (workspaceV2ViewModel._core.IsValid() && OfflineData.Instance.Employee.Can(1, 0))
					{
						workspaceV2ViewModel.CheckForUpdatesDelayed(120);
						workspaceV2ViewModel.CheckLicenseExpirationDelayed(35);
					}
					if (!workspaceV2ViewModel._core.IsValid())
					{
						ILicenseExpirationViewModel licenseExpirationViewModel = Bootstrapper.Container.Resolve<ILicenseExpirationViewModel>();
						licenseExpirationViewModel.SetLicenseExpired();
						workspaceV2ViewModel._windowedDocumentService.TransparentBackground();
						workspaceV2ViewModel._windowedDocumentService.ShowNewDocument("LicenseExpirationView", licenseExpirationViewModel, workspaceV2ViewModel, null);
					}
					workspaceV2ViewModel._countUserSessionsTimer = new Timer(new TimerCallback(workspaceV2ViewModel.CountUserSessions), null, 10000, 30000);
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

			// Token: 0x0600154A RID: 5450 RVA: 0x00031CB8 File Offset: 0x0002FEB8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A3D RID: 2621
			public int <>1__state;

			// Token: 0x04000A3E RID: 2622
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000A3F RID: 2623
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A40 RID: 2624
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000124 RID: 292
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountUserSessions>d__130 : IAsyncStateMachine
		{
			// Token: 0x0600154B RID: 5451 RVA: 0x00031CD4 File Offset: 0x0002FED4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel workspaceV2ViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = workspaceV2ViewModel._userActivityService.SecondSessionOpened().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, WorkspaceV2ViewModel.<CountUserSessions>d__130>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					if (awaiter.GetResult())
					{
						Application.Current.Dispatcher.Invoke(new Action(workspaceV2ViewModel.Logout));
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

			// Token: 0x0600154C RID: 5452 RVA: 0x00031DA8 File Offset: 0x0002FFA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A41 RID: 2625
			public int <>1__state;

			// Token: 0x04000A42 RID: 2626
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A43 RID: 2627
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A44 RID: 2628
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000125 RID: 293
		[CompilerGenerated]
		private sealed class <>c__DisplayClass188_0
		{
			// Token: 0x0600154D RID: 5453 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass188_0()
			{
			}

			// Token: 0x0600154E RID: 5454 RVA: 0x00031DC4 File Offset: 0x0002FFC4
			internal void <CheckLicenseExpirationDelayed>b__1()
			{
				ILicenseExpirationViewModel licenseExpirationViewModel = Bootstrapper.Container.Resolve<ILicenseExpirationViewModel>();
				licenseExpirationViewModel.SetExpireDays(Convert.ToInt32(this.days));
				this.<>4__this._windowedDocumentService.TransparentBackground();
				this.<>4__this._windowedDocumentService.ShowNewDocument("LicenseExpirationView", licenseExpirationViewModel, this.<>4__this, null);
			}

			// Token: 0x04000A45 RID: 2629
			public double days;

			// Token: 0x04000A46 RID: 2630
			public WorkspaceV2ViewModel <>4__this;
		}

		// Token: 0x02000126 RID: 294
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CheckLicenseExpirationDelayed>d__188 : IAsyncStateMachine
		{
			// Token: 0x0600154F RID: 5455 RVA: 0x00031E1C File Offset: 0x0003001C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel @object = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(TimeSpan.FromSeconds((double)this.seconds)).ContinueWith(delegate(Task t)
						{
							WorkspaceV2ViewModel.<>c__DisplayClass188_0 CS$<>8__locals1 = new WorkspaceV2ViewModel.<>c__DisplayClass188_0();
							CS$<>8__locals1.<>4__this = @object;
							CS$<>8__locals1.days = @object._licenseService.ExpirationDays();
							if (CS$<>8__locals1.days < 8.0)
							{
								Application.Current.Dispatcher.Invoke(new Action(CS$<>8__locals1.<CheckLicenseExpirationDelayed>b__1));
							}
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkspaceV2ViewModel.<CheckLicenseExpirationDelayed>d__188>(ref awaiter, ref this);
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

			// Token: 0x06001550 RID: 5456 RVA: 0x00031EEC File Offset: 0x000300EC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A47 RID: 2631
			public int <>1__state;

			// Token: 0x04000A48 RID: 2632
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A49 RID: 2633
			public int seconds;

			// Token: 0x04000A4A RID: 2634
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A4B RID: 2635
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000127 RID: 295
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CheckForUpdatesDelayed>d__189 : IAsyncStateMachine
		{
			// Token: 0x06001551 RID: 5457 RVA: 0x00031F08 File Offset: 0x00030108
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel @object = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(TimeSpan.FromSeconds((double)this.seconds)).ContinueWith(delegate(Task t)
						{
							AutoUpdater.Initialize(AuthModel.GetUpdatePath(), Assembly.GetExecutingAssembly().GetName().Version.ToString());
							AutoUpdater.Instance.NewUpdate += base.InstanceOnNewUpdate;
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkspaceV2ViewModel.<CheckForUpdatesDelayed>d__189>(ref awaiter, ref this);
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

			// Token: 0x06001552 RID: 5458 RVA: 0x00031FD8 File Offset: 0x000301D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A4C RID: 2636
			public int <>1__state;

			// Token: 0x04000A4D RID: 2637
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A4E RID: 2638
			public int seconds;

			// Token: 0x04000A4F RID: 2639
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A50 RID: 2640
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000128 RID: 296
		[CompilerGenerated]
		private sealed class <>c__DisplayClass190_0
		{
			// Token: 0x06001553 RID: 5459 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass190_0()
			{
			}

			// Token: 0x06001554 RID: 5460 RVA: 0x00031FF4 File Offset: 0x000301F4
			internal void <InstanceOnNewUpdate>b__0()
			{
				this.<>4__this._windowedDocumentService.ShowNewDocument("UpdateView", this.vm, null, null);
			}

			// Token: 0x04000A51 RID: 2641
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A52 RID: 2642
			public UpdateViewModel vm;
		}

		// Token: 0x02000129 RID: 297
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001555 RID: 5461 RVA: 0x00032020 File Offset: 0x00030220
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001556 RID: 5462 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001557 RID: 5463 RVA: 0x00032038 File Offset: 0x00030238
			internal void <PreheatReports>b__191_0()
			{
				Thread.Sleep(5000);
				using (List<AssemblyName>.Enumerator enumerator = typeof(ReportPrintTool).Assembly.GetReferencedAssemblies().ToList<AssemblyName>().Distinct<AssemblyName>().ToList<AssemblyName>().GetEnumerator())
				{
					for (;;)
					{
						IL_87:
						int num = (!enumerator.MoveNext()) ? 1894836746 : 1956386203;
						for (;;)
						{
							switch ((num ^ 1954795014) % 4)
							{
							case 1:
								Assembly.Load(enumerator.Current);
								num = 932452188;
								continue;
							case 2:
								goto IL_87;
							case 3:
								num = 1956386203;
								continue;
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
			}

			// Token: 0x06001558 RID: 5464 RVA: 0x000320F8 File Offset: 0x000302F8
			internal void <TestCall>b__192_0()
			{
				Thread.Sleep(1500);
			}

			// Token: 0x06001559 RID: 5465 RVA: 0x00032110 File Offset: 0x00030310
			internal void <TestCall>b__192_1(Task t)
			{
				Messenger.Default.Send(new Message("71111111117", "71111111117", MessageType.InCall));
			}

			// Token: 0x04000A53 RID: 2643
			public static readonly WorkspaceV2ViewModel.<>c <>9 = new WorkspaceV2ViewModel.<>c();

			// Token: 0x04000A54 RID: 2644
			public static Action <>9__191_0;

			// Token: 0x04000A55 RID: 2645
			public static Action <>9__192_0;

			// Token: 0x04000A56 RID: 2646
			public static Action<Task> <>9__192_1;
		}

		// Token: 0x0200012A RID: 298
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__193 : IAsyncStateMachine
		{
			// Token: 0x0600155A RID: 5466 RVA: 0x00032138 File Offset: 0x00030338
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel workspaceV2ViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<string>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<string>>(new Func<Task<List<string>>>(UsersModel.LoadUserRoles)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, WorkspaceV2ViewModel.<Init>d__193>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<string>>);
						this.<>1__state = -1;
					}
					List<string> result = awaiter.GetResult();
					workspaceV2ViewModel.UserRoles = result;
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

			// Token: 0x0600155B RID: 5467 RVA: 0x00032200 File Offset: 0x00030400
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A57 RID: 2647
			public int <>1__state;

			// Token: 0x04000A58 RID: 2648
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A59 RID: 2649
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A5A RID: 2650
			private TaskAwaiter<List<string>> <>u__1;
		}

		// Token: 0x0200012B RID: 299
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountTasks>d__194 : IAsyncStateMachine
		{
			// Token: 0x0600155C RID: 5468 RVA: 0x0003221C File Offset: 0x0003041C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel workspaceV2ViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						if (!workspaceV2ViewModel._serverInfo.Connected)
						{
							goto IL_AF;
						}
						awaiter = Task.Run<int>(new Func<Task<int>>(workspaceV2ViewModel._taskService.GetActiveTaskIds)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WorkspaceV2ViewModel.<CountTasks>d__194>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter.GetResult();
					workspaceV2ViewModel.ActiveTasks = result;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_AF:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600155D RID: 5469 RVA: 0x000322FC File Offset: 0x000304FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A5B RID: 2651
			public int <>1__state;

			// Token: 0x04000A5C RID: 2652
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A5D RID: 2653
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A5E RID: 2654
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		private sealed class <>c__DisplayClass210_0
		{
			// Token: 0x0600155E RID: 5470 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass210_0()
			{
			}

			// Token: 0x04000A5F RID: 2655
			public int itemId;
		}

		// Token: 0x0200012D RID: 301
		[CompilerGenerated]
		private sealed class <>c__DisplayClass211_0
		{
			// Token: 0x0600155F RID: 5471 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass211_0()
			{
			}

			// Token: 0x06001560 RID: 5472 RVA: 0x00032318 File Offset: 0x00030518
			internal void <OnMessage>b__0()
			{
				if (this.<>4__this.customer != null)
				{
					CustomerCallViewModel customerCallViewModel = Bootstrapper.Container.Resolve<CustomerCallViewModel>();
					customerCallViewModel.SetCallFrom(this.message.CallFrom);
					customerCallViewModel.SetCustomerId(this.<>4__this.customer.id);
					this.<>4__this._windowedDocumentService.ShowNewDocument("CustomerCallView", customerCallViewModel, null, null);
				}
			}

			// Token: 0x06001561 RID: 5473 RVA: 0x0003237C File Offset: 0x0003057C
			internal void <OnMessage>b__1()
			{
				this.<>4__this._windowedDocumentService.CloseActiveDocument(this.message.CallFrom);
			}

			// Token: 0x06001562 RID: 5474 RVA: 0x000323A4 File Offset: 0x000305A4
			internal bool <OnMessage>b__2(IAscNotification n)
			{
				return n.Subject.Contains(this.message.CallFrom);
			}

			// Token: 0x04000A60 RID: 2656
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A61 RID: 2657
			public Message message;
		}

		// Token: 0x0200012E RID: 302
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnMessage>d__211 : IAsyncStateMachine
		{
			// Token: 0x06001563 RID: 5475 RVA: 0x000323C8 File Offset: 0x000305C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel workspaceV2ViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_168;
						}
						this.<>8__1 = new WorkspaceV2ViewModel.<>c__DisplayClass211_0();
						this.<>8__1.<>4__this = this.<>4__this;
						this.<>8__1.message = this.message;
						if (this.<>8__1.message.MessageType != MessageType.InCall)
						{
							goto IL_16F;
						}
						workspaceV2ViewModel.customer = VoipModel.GetCusomerByPhone(this.<>8__1.message.CallFrom);
						awaiter = workspaceV2ViewModel.CreateNotification(this.<>8__1.message).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkspaceV2ViewModel.<OnMessage>d__211>(ref awaiter, ref this);
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
					if (!OfflineData.Instance.Employee.DisplayCustomerOnCall)
					{
						goto IL_16F;
					}
					awaiter = Application.Current.Dispatcher.BeginInvoke(new Action(this.<>8__1.<OnMessage>b__0), new object[0]).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkspaceV2ViewModel.<OnMessage>d__211>(ref awaiter, ref this);
						return;
					}
					IL_168:
					awaiter.GetResult();
					IL_16F:
					if (this.<>8__1.message.MessageType == MessageType.CallAnswered)
					{
						if (OfflineData.Instance.Employee.DisplayCustomerOnCall)
						{
							Application.Current.Dispatcher.BeginInvoke(new Action(this.<>8__1.<OnMessage>b__1), new object[0]);
						}
						IAscNotification ascNotification = workspaceV2ViewModel.NotificationsPanelViewModel.Items.FirstOrDefault(new Func<IAscNotification, bool>(this.<>8__1.<OnMessage>b__2));
						if (ascNotification != null)
						{
							ascNotification.MarkAsRead();
						}
					}
					if (this.<>8__1.message.MessageType == MessageType.TaskChanged)
					{
						workspaceV2ViewModel.CountTasks(null);
					}
					if (this.<>8__1.message.MessageType == MessageType.StopBarcodeListen)
					{
						workspaceV2ViewModel._listenBarCode = false;
					}
					if (this.<>8__1.message.MessageType == MessageType.StartBarcodeListen)
					{
						workspaceV2ViewModel._listenBarCode = true;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001564 RID: 5476 RVA: 0x00032664 File Offset: 0x00030864
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A62 RID: 2658
			public int <>1__state;

			// Token: 0x04000A63 RID: 2659
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000A64 RID: 2660
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A65 RID: 2661
			public Message message;

			// Token: 0x04000A66 RID: 2662
			private WorkspaceV2ViewModel.<>c__DisplayClass211_0 <>8__1;

			// Token: 0x04000A67 RID: 2663
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200012F RID: 303
		[CompilerGenerated]
		private sealed class <>c__DisplayClass212_0
		{
			// Token: 0x06001565 RID: 5477 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass212_0()
			{
			}

			// Token: 0x06001566 RID: 5478 RVA: 0x00032680 File Offset: 0x00030880
			internal void <CreateNotification>b__0()
			{
				NotificationService.CreateNotification(this.notification);
			}

			// Token: 0x04000A68 RID: 2664
			public AscNotification notification;
		}

		// Token: 0x02000130 RID: 304
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateNotification>d__212 : IAsyncStateMachine
		{
			// Token: 0x06001567 RID: 5479 RVA: 0x00032698 File Offset: 0x00030898
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorkspaceV2ViewModel workspaceV2ViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						WorkspaceV2ViewModel.<>c__DisplayClass212_0 CS$<>8__locals1 = new WorkspaceV2ViewModel.<>c__DisplayClass212_0();
						CS$<>8__locals1.notification = new AscNotification();
						CS$<>8__locals1.notification.SetEmployee(OfflineData.Instance.Employee.Id);
						AscNotification notification = CS$<>8__locals1.notification;
						string callFrom = this.message.CallFrom;
						clients customer = workspaceV2ViewModel.customer;
						string customer2 = (customer != null) ? customer.FioOrUrName : null;
						clients customer3 = workspaceV2ViewModel.customer;
						notification.InCall(callFrom, customer2, (customer3 != null) ? new int?(customer3.id) : null);
						awaiter = Task.Run(new Action(CS$<>8__locals1.<CreateNotification>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WorkspaceV2ViewModel.<CreateNotification>d__212>(ref awaiter, ref this);
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

			// Token: 0x06001568 RID: 5480 RVA: 0x000327CC File Offset: 0x000309CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A69 RID: 2665
			public int <>1__state;

			// Token: 0x04000A6A RID: 2666
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000A6B RID: 2667
			public Message message;

			// Token: 0x04000A6C RID: 2668
			public WorkspaceV2ViewModel <>4__this;

			// Token: 0x04000A6D RID: 2669
			private TaskAwaiter <>u__1;
		}
	}
}
