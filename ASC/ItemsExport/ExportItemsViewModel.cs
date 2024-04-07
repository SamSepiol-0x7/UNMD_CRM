using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASC.Interfaces;
using ASC.Models;
using ASC.Options;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ItemsExport
{
	// Token: 0x02000310 RID: 784
	public class ExportItemsViewModel : CollectionViewModel<store_items>
	{
		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x00070B88 File Offset: 0x0006ED88
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x00070BCC File Offset: 0x0006EDCC
		public string PathOfImages
		{
			get
			{
				return base.GetProperty<string>(() => this.PathOfImages);
			}
			set
			{
				if (string.Equals(this.PathOfImages, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.PathOfImages, value, new Action(this.OnPathOfImagesChanged));
				this.RaisePropertyChanged("PathOfImages");
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x00070C38 File Offset: 0x0006EE38
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x00070C4C File Offset: 0x0006EE4C
		public bool SyncInProgress
		{
			[CompilerGenerated]
			get
			{
				return this.<SyncInProgress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SyncInProgress>k__BackingField == value)
				{
					return;
				}
				this.<SyncInProgress>k__BackingField = value;
				this.RaisePropertyChanged("SyncInProgress");
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x00070C78 File Offset: 0x0006EE78
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x00070C8C File Offset: 0x0006EE8C
		public double SyncProgress
		{
			[CompilerGenerated]
			get
			{
				return this.<SyncProgress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SyncProgress>k__BackingField == value)
				{
					return;
				}
				this.<SyncProgress>k__BackingField = value;
				this.RaisePropertyChanged("SyncProgress");
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x00070CBC File Offset: 0x0006EEBC
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x00070CD0 File Offset: 0x0006EED0
		public List<store_cats> Categories
		{
			[CompilerGenerated]
			get
			{
				return this.<Categories>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Categories>k__BackingField, value))
				{
					return;
				}
				this.<Categories>k__BackingField = value;
				this.RaisePropertyChanged("Categories");
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x00070D00 File Offset: 0x0006EF00
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x00070D14 File Offset: 0x0006EF14
		public List<stores> Stores
		{
			[CompilerGenerated]
			get
			{
				return this.<Stores>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Stores>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1806444524;
				IL_13:
				switch ((num ^ 1961730017) % 4)
				{
				case 0:
					IL_32:
					this.<Stores>k__BackingField = value;
					num = 768663143;
					goto IL_13;
				case 1:
					return;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("Stores");
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x00070D70 File Offset: 0x0006EF70
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x00070D84 File Offset: 0x0006EF84
		public Dictionary<int, string> Formats
		{
			[CompilerGenerated]
			get
			{
				return this.<Formats>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Formats>k__BackingField, value))
				{
					return;
				}
				this.<Formats>k__BackingField = value;
				this.RaisePropertyChanged("Formats");
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x00070DB4 File Offset: 0x0006EFB4
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x00070DF8 File Offset: 0x0006EFF8
		public bool ExportImages
		{
			get
			{
				return base.GetProperty<bool>(() => this.ExportImages);
			}
			set
			{
				if (this.ExportImages == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.ExportImages, value, new Action(this.OnExportImagesChanged));
				this.RaisePropertyChanged("ExportImages");
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x00070E60 File Offset: 0x0006F060
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x00070EA4 File Offset: 0x0006F0A4
		public string Query
		{
			get
			{
				return base.GetProperty<string>(() => this.Query);
			}
			set
			{
				if (string.Equals(this.Query, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.Query, value, new Action(this.OnQueryChanged));
				this.RaisePropertyChanged("Query");
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x00070F10 File Offset: 0x0006F110
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00070F24 File Offset: 0x0006F124
		public List<items_state> States
		{
			[CompilerGenerated]
			get
			{
				return this.<States>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<States>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -516849443;
				IL_13:
				switch ((num ^ -1365017096) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<States>k__BackingField = value;
					num = -57923130;
					goto IL_13;
				}
				this.RaisePropertyChanged("States");
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x00070F80 File Offset: 0x0006F180
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x00070F94 File Offset: 0x0006F194
		public List<ItemsOptions> ItemsOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<ItemsOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ItemsOptionses>k__BackingField, value))
				{
					return;
				}
				this.<ItemsOptionses>k__BackingField = value;
				this.RaisePropertyChanged("ItemsOptionses");
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x00070FC4 File Offset: 0x0006F1C4
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x00071008 File Offset: 0x0006F208
		public bool AllSelected
		{
			get
			{
				return base.GetProperty<bool>(() => this.AllSelected);
			}
			set
			{
				if (this.AllSelected == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.AllSelected, value, new Action(this.OnAllSelectedChanged));
				this.RaisePropertyChanged("AllSelected");
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x00071070 File Offset: 0x0006F270
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x000710B4 File Offset: 0x0006F2B4
		public int SelectedItemOption
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedItemOption);
			}
			set
			{
				if (this.SelectedItemOption != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = 839949751;
				IL_10:
				switch ((num ^ 1821430770) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					num = 1047268658;
					goto IL_10;
				}
				base.SetProperty<int>(() => this.SelectedItemOption, value, new Action(this.Refresh));
				this.RaisePropertyChanged("SelectedItemOption");
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x00071148 File Offset: 0x0006F348
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x0007118C File Offset: 0x0006F38C
		public int SelectedState
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedState);
			}
			set
			{
				if (this.SelectedState == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedState, value, new Action(this.Refresh));
				this.RaisePropertyChanged("SelectedState");
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000711F4 File Offset: 0x0006F3F4
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x00071238 File Offset: 0x0006F438
		public int SelectedCategory
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedCategory);
			}
			set
			{
				if (this.SelectedCategory == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedCategory, value, new Action(this.Refresh));
				this.RaisePropertyChanged("SelectedCategory");
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000712A0 File Offset: 0x0006F4A0
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x000712E4 File Offset: 0x0006F4E4
		public int SelectedStore
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedStore);
			}
			set
			{
				if (this.SelectedStore == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedStore, value, new Action(this.OnSelectedStoreChanged));
				this.RaisePropertyChanged("SelectedStore");
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x0007134C File Offset: 0x0006F54C
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x00071390 File Offset: 0x0006F590
		public string ExportPath
		{
			get
			{
				return base.GetProperty<string>(() => this.ExportPath);
			}
			set
			{
				if (string.Equals(this.ExportPath, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.ExportPath, value, new Action(this.OnExportPathChanged));
				this.RaisePropertyChanged("ExportPath");
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000713FC File Offset: 0x0006F5FC
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x00071440 File Offset: 0x0006F640
		public int SelectedFormat
		{
			get
			{
				return base.GetProperty<int>(() => this.SelectedFormat);
			}
			set
			{
				if (this.SelectedFormat == value)
				{
					return;
				}
				base.SetProperty<int>(() => this.SelectedFormat, value, new Action(this.OnFormatChanged));
				this.RaisePropertyChanged("SelectedFormat");
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000714A8 File Offset: 0x0006F6A8
		private void OnFormatChanged()
		{
			/*
An exception occurred when decompiling this method (06002501)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ASC.ItemsExport.ExportItemsViewModel::OnFormatChanged()

 ---> System.Exception: Inconsistent stack size at IL_80
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00071550 File Offset: 0x0006F750
		public ExportItemsViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this.SetViewName("ItemsExport");
			this.ExportImages = true;
			this.ExportPath = Settings.Default.ExportPath;
			this.PathOfImages = Settings.Default.PathOfImages;
			this.SelectedItemOption = Settings.Default.ExportProductAvailability;
			this._exportWorker = new BackgroundWorker
			{
				WorkerSupportsCancellation = true,
				WorkerReportsProgress = true
			};
			this.Formats = ExportItemsViewModel.GetFormats();
			this.SelectedFormat = 1;
			this.BgInit();
			this._exportWorker.DoWork += this.ExportWork;
			this._exportWorker.WorkerReportsProgress = true;
			this._exportWorker.ProgressChanged += this.ExportProgressChanged;
			this._exportWorker.RunWorkerCompleted += this.ExportComplete;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00071664 File Offset: 0x0006F864
		private static Dictionary<int, string> GetFormats()
		{
			return new Dictionary<int, string>
			{
				{
					1,
					"XML"
				},
				{
					2,
					"JSON"
				}
			};
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00071690 File Offset: 0x0006F890
		private void OnAllSelectedChanged()
		{
			ExportItemsViewModel.<OnAllSelectedChanged>d__67 <OnAllSelectedChanged>d__;
			<OnAllSelectedChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnAllSelectedChanged>d__.<>4__this = this;
			<OnAllSelectedChanged>d__.<>1__state = -1;
			<OnAllSelectedChanged>d__.<>t__builder.Start<ExportItemsViewModel.<OnAllSelectedChanged>d__67>(ref <OnAllSelectedChanged>d__);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000716C8 File Offset: 0x0006F8C8
		private void OnPathOfImagesChanged()
		{
			IExport export = this._export;
			if (export == null)
			{
				return;
			}
			export.SetPathToImages(this.PathOfImages);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000716EC File Offset: 0x0006F8EC
		private void OnExportImagesChanged()
		{
			IExport export = this._export;
			if (export == null)
			{
				return;
			}
			export.SetExportImages(this.ExportImages);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00071710 File Offset: 0x0006F910
		private void OnExportPathChanged()
		{
			IExport export = this._export;
			if (export == null)
			{
				return;
			}
			export.SetExportPath(this.ExportPath);
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00071734 File Offset: 0x0006F934
		private void OnSelectedStoreChanged()
		{
			this.LoadCategories();
			this.Refresh();
			this.SaveLastStore();
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00071754 File Offset: 0x0006F954
		private void ExportComplete(object sender, RunWorkerCompletedEventArgs e)
		{
			this._export.Save("export");
			this.SyncInProgress = false;
			this.SyncProgress = 0.0;
			base.RaiseCanExecuteChanged(() => this.Cancel());
			base.RaiseCanExecuteChanged(() => this.Export());
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00071800 File Offset: 0x0006FA00
		private void ExportProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.SyncProgress = (double)e.UserState / 100.0;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00071828 File Offset: 0x0006FA28
		private void ExportWork(object sender, DoWorkEventArgs e)
		{
			this._export.CreateDocument();
			List<store_items> list = base.Items.Where(delegate(store_items i)
			{
				bool? shop_enable = i.shop_enable;
				return shop_enable.GetValueOrDefault() & shop_enable != null;
			}).ToList<store_items>();
			if (list.Count > 0)
			{
				int count = list.Count;
				int num = 1;
				foreach (store_items item in list)
				{
					if (this._exportWorker.CancellationPending)
					{
						e.Cancel = true;
						break;
					}
					try
					{
						this._export.Add(item);
					}
					catch (Exception)
					{
					}
					finally
					{
						this._exportWorker.ReportProgress(0, (double)num * 10000.0 / (double)count);
						num++;
					}
				}
			}
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00071928 File Offset: 0x0006FB28
		[Command]
		public void SelectPath()
		{
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{
					Settings.Default.ExportPath = folderBrowserDialog.SelectedPath;
					this.ExportPath = folderBrowserDialog.SelectedPath;
				}
			}
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0007198C File Offset: 0x0006FB8C
		[Command]
		public void Refresh()
		{
			this.LoadItems();
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000719A0 File Offset: 0x0006FBA0
		private void LoadItems()
		{
			ExportItemsViewModel.<LoadItems>d__79 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<ExportItemsViewModel.<LoadItems>d__79>(ref <LoadItems>d__);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000719D8 File Offset: 0x0006FBD8
		private void BgInit()
		{
			ExportItemsViewModel.<BgInit>d__80 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<ExportItemsViewModel.<BgInit>d__80>(ref <BgInit>d__);
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00071A10 File Offset: 0x0006FC10
		private void LoadCategories()
		{
			ExportItemsViewModel.<LoadCategories>d__81 <LoadCategories>d__;
			<LoadCategories>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadCategories>d__.<>4__this = this;
			<LoadCategories>d__.<>1__state = -1;
			<LoadCategories>d__.<>t__builder.Start<ExportItemsViewModel.<LoadCategories>d__81>(ref <LoadCategories>d__);
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00071A48 File Offset: 0x0006FC48
		private void SaveLastStore()
		{
			if (this.SelectedStore > 0)
			{
				goto IL_2D;
			}
			IL_09:
			int num = -467285454;
			IL_0E:
			switch ((num ^ -738666583) % 4)
			{
			case 0:
				goto IL_09;
			case 1:
				IL_2D:
				Settings.Default.ExportLastStore = this.SelectedStore;
				num = -356621377;
				goto IL_0E;
			case 3:
				return;
			}
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00071A9C File Offset: 0x0006FC9C
		[Command]
		public void Cancel()
		{
			BackgroundWorker exportWorker = this._exportWorker;
			if (exportWorker == null)
			{
				return;
			}
			exportWorker.CancelAsync();
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x00071ABC File Offset: 0x0006FCBC
		public bool CanCancel()
		{
			return this.SyncInProgress;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00071AD0 File Offset: 0x0006FCD0
		[Command]
		public void ItemExportChanged(object obj)
		{
			if (obj == null)
			{
				return;
			}
			store_items store_items = base.Items.FirstOrDefault((store_items i) => i.id == (int)obj);
			if (store_items == null)
			{
				return;
			}
			this._exportItemsModel.ExportFlagChange(store_items);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00071B1C File Offset: 0x0006FD1C
		[Command]
		public void Export()
		{
			if (!Directory.Exists(this.ExportPath))
			{
				this._toasterService.Info("Path not selected");
				return;
			}
			Settings.Default.PathOfImages = this.PathOfImages;
			this.SyncProgress = 0.0;
			this.SyncInProgress = true;
			base.RaiseCanExecuteChanged(() => this.Export());
			base.RaiseCanExecuteChanged(() => this.Cancel());
			this._exportWorker.RunWorkerAsync();
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00071BF0 File Offset: 0x0006FDF0
		public bool CanExport()
		{
			return !this.SyncInProgress && !string.IsNullOrEmpty(this.ExportPath) && !string.IsNullOrEmpty(this.PathOfImages);
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00071C24 File Offset: 0x0006FE24
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(base.SelectedItem.id, 0);
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x0007198C File Offset: 0x0006FB8C
		private void OnQueryChanged()
		{
			this.LoadItems();
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00071C54 File Offset: 0x0006FE54
		[Command]
		public void Unloaded()
		{
			Settings.Default.ExportProductAvailability = this.SelectedItemOption;
			Settings.Default.Save();
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x00071C7C File Offset: 0x0006FE7C
		[CompilerGenerated]
		private void <OnAllSelectedChanged>b__67_0()
		{
			ExportItemsModel.ExportFlagChange(base.Items, this.AllSelected);
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00071C9C File Offset: 0x0006FE9C
		[CompilerGenerated]
		private Task<List<store_items>> <LoadItems>b__79_2()
		{
			return this._exportItemsModel.LoadItems(this.SelectedStore, this.SelectedCategory, this.SelectedState, this.SelectedItemOption, this.Query);
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00071CD4 File Offset: 0x0006FED4
		[CompilerGenerated]
		private Task<List<store_cats>> <LoadCategories>b__81_0()
		{
			return this._storesModel.LoadStoreCategories(this.SelectedStore, true, false);
		}

		// Token: 0x040013A3 RID: 5027
		private readonly INavigationService _navigationService;

		// Token: 0x040013A4 RID: 5028
		private readonly IToasterService _toasterService;

		// Token: 0x040013A5 RID: 5029
		private IExport _export;

		// Token: 0x040013A6 RID: 5030
		private BackgroundWorker _exportWorker;

		// Token: 0x040013A7 RID: 5031
		private ExportItemsModel _exportItemsModel = new ExportItemsModel();

		// Token: 0x040013A8 RID: 5032
		private StoreModel _storesModel = new StoreModel();

		// Token: 0x040013A9 RID: 5033
		[CompilerGenerated]
		private bool <SyncInProgress>k__BackingField;

		// Token: 0x040013AA RID: 5034
		[CompilerGenerated]
		private double <SyncProgress>k__BackingField;

		// Token: 0x040013AB RID: 5035
		[CompilerGenerated]
		private List<store_cats> <Categories>k__BackingField;

		// Token: 0x040013AC RID: 5036
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x040013AD RID: 5037
		[CompilerGenerated]
		private Dictionary<int, string> <Formats>k__BackingField;

		// Token: 0x040013AE RID: 5038
		[CompilerGenerated]
		private List<items_state> <States>k__BackingField;

		// Token: 0x040013AF RID: 5039
		[CompilerGenerated]
		private List<ItemsOptions> <ItemsOptionses>k__BackingField;

		// Token: 0x040013B0 RID: 5040
		private bool _loaded;

		// Token: 0x040013B1 RID: 5041
		private bool _enableLoad = true;

		// Token: 0x02000311 RID: 785
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnAllSelectedChanged>d__67 : IAsyncStateMachine
		{
			// Token: 0x0600251D RID: 9501 RVA: 0x00071CF4 File Offset: 0x0006FEF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportItemsViewModel exportItemsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						exportItemsViewModel.ShowWait();
						awaiter = Task.Run(delegate()
						{
							ExportItemsModel.ExportFlagChange(base.Items, base.AllSelected);
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportItemsViewModel.<OnAllSelectedChanged>d__67>(ref awaiter, ref this);
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
					exportItemsViewModel.LoadItems();
					exportItemsViewModel.HideWait();
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

			// Token: 0x0600251E RID: 9502 RVA: 0x00071DC4 File Offset: 0x0006FFC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040013B2 RID: 5042
			public int <>1__state;

			// Token: 0x040013B3 RID: 5043
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040013B4 RID: 5044
			public ExportItemsViewModel <>4__this;

			// Token: 0x040013B5 RID: 5045
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000312 RID: 786
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600251F RID: 9503 RVA: 0x00071DE0 File Offset: 0x0006FFE0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002520 RID: 9504 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002521 RID: 9505 RVA: 0x00071DF8 File Offset: 0x0006FFF8
			internal bool <ExportWork>b__74_0(store_items i)
			{
				bool? shop_enable = i.shop_enable;
				return shop_enable.GetValueOrDefault() & shop_enable != null;
			}

			// Token: 0x06002522 RID: 9506 RVA: 0x00071DF8 File Offset: 0x0006FFF8
			internal bool <LoadItems>b__79_0(store_items i)
			{
				bool? shop_enable = i.shop_enable;
				return shop_enable.GetValueOrDefault() & shop_enable != null;
			}

			// Token: 0x06002523 RID: 9507 RVA: 0x00071E20 File Offset: 0x00070020
			internal bool <LoadItems>b__79_1(store_items i)
			{
				bool? shop_enable = i.shop_enable;
				return !shop_enable.GetValueOrDefault() & shop_enable != null;
			}

			// Token: 0x06002524 RID: 9508 RVA: 0x0004DA90 File Offset: 0x0004BC90
			internal Task<List<stores>> <BgInit>b__80_0()
			{
				return StoreModel.LoadStores(false, false);
			}

			// Token: 0x06002525 RID: 9509 RVA: 0x00071E48 File Offset: 0x00070048
			internal Task<List<items_state>> <BgInit>b__80_1()
			{
				return ItemsModel.LoadItemStates(true);
			}

			// Token: 0x040013B6 RID: 5046
			public static readonly ExportItemsViewModel.<>c <>9 = new ExportItemsViewModel.<>c();

			// Token: 0x040013B7 RID: 5047
			public static Func<store_items, bool> <>9__74_0;

			// Token: 0x040013B8 RID: 5048
			public static Func<store_items, bool> <>9__79_0;

			// Token: 0x040013B9 RID: 5049
			public static Func<store_items, bool> <>9__79_1;

			// Token: 0x040013BA RID: 5050
			public static Func<Task<List<stores>>> <>9__80_0;

			// Token: 0x040013BB RID: 5051
			public static Func<Task<List<items_state>>> <>9__80_1;
		}

		// Token: 0x02000313 RID: 787
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__79 : IAsyncStateMachine
		{
			// Token: 0x06002526 RID: 9510 RVA: 0x00071E5C File Offset: 0x0007005C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportItemsViewModel exportItemsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_items>> awaiter;
					if (num != 0)
					{
						if (!exportItemsViewModel._loaded || !exportItemsViewModel._enableLoad)
						{
							goto IL_12F;
						}
						exportItemsViewModel._enableLoad = false;
						exportItemsViewModel.ShowWait();
						awaiter = Task.Run<List<store_items>>(() => exportItemsViewModel._exportItemsModel.LoadItems(base.SelectedStore, base.SelectedCategory, base.SelectedState, base.SelectedItemOption, base.Query)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_items>>, ExportItemsViewModel.<LoadItems>d__79>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_items>>);
						this.<>1__state = -1;
					}
					List<store_items> result = awaiter.GetResult();
					exportItemsViewModel.SetItems(result);
					if (exportItemsViewModel.Items.All(new Func<store_items, bool>(ExportItemsViewModel.<>c.<>9.<LoadItems>b__79_0)))
					{
						exportItemsViewModel.AllSelected = true;
					}
					if (exportItemsViewModel.Items.All(new Func<store_items, bool>(ExportItemsViewModel.<>c.<>9.<LoadItems>b__79_1)))
					{
						exportItemsViewModel.AllSelected = false;
					}
					exportItemsViewModel.HideWait();
					exportItemsViewModel._enableLoad = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_12F:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002527 RID: 9511 RVA: 0x00071FC8 File Offset: 0x000701C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040013BC RID: 5052
			public int <>1__state;

			// Token: 0x040013BD RID: 5053
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040013BE RID: 5054
			public ExportItemsViewModel <>4__this;

			// Token: 0x040013BF RID: 5055
			private TaskAwaiter<List<store_items>> <>u__1;
		}

		// Token: 0x02000314 RID: 788
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__80 : IAsyncStateMachine
		{
			// Token: 0x06002528 RID: 9512 RVA: 0x00071FE4 File Offset: 0x000701E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportItemsViewModel exportItemsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<items_state>> awaiter;
					TaskAwaiter<List<stores>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<List<items_state>>);
							this.<>1__state = -1;
							goto IL_16B;
						}
						exportItemsViewModel.ShowWait();
						exportItemsViewModel._loaded = false;
						awaiter2 = Task.Run<List<stores>>(new Func<Task<List<stores>>>(ExportItemsViewModel.<>c.<>9.<BgInit>b__80_0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, ExportItemsViewModel.<BgInit>d__80>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<stores>>);
						this.<>1__state = -1;
					}
					List<stores> result = awaiter2.GetResult();
					exportItemsViewModel.Stores = result;
					if (exportItemsViewModel.Stores != null && exportItemsViewModel.Stores.Count == 1)
					{
						exportItemsViewModel.SelectedStore = exportItemsViewModel.Stores.First<stores>().id;
					}
					if (Settings.Default.ExportLastStore != 0)
					{
						exportItemsViewModel.SelectedStore = Settings.Default.ExportLastStore;
					}
					exportItemsViewModel.LoadCategories();
					awaiter = Task.Run<List<items_state>>(new Func<Task<List<items_state>>>(ExportItemsViewModel.<>c.<>9.<BgInit>b__80_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<items_state>>, ExportItemsViewModel.<BgInit>d__80>(ref awaiter, ref this);
						return;
					}
					IL_16B:
					List<items_state> result2 = awaiter.GetResult();
					exportItemsViewModel.States = result2;
					exportItemsViewModel.ItemsOptionses = StoreModel.LoadItemsOptionses();
					exportItemsViewModel._loaded = true;
					exportItemsViewModel.HideWait();
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

			// Token: 0x06002529 RID: 9513 RVA: 0x000721D0 File Offset: 0x000703D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040013C0 RID: 5056
			public int <>1__state;

			// Token: 0x040013C1 RID: 5057
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040013C2 RID: 5058
			public ExportItemsViewModel <>4__this;

			// Token: 0x040013C3 RID: 5059
			private TaskAwaiter<List<stores>> <>u__1;

			// Token: 0x040013C4 RID: 5060
			private TaskAwaiter<List<items_state>> <>u__2;
		}

		// Token: 0x02000315 RID: 789
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCategories>d__81 : IAsyncStateMachine
		{
			// Token: 0x0600252A RID: 9514 RVA: 0x000721EC File Offset: 0x000703EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportItemsViewModel exportItemsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<store_cats>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<store_cats>>(() => exportItemsViewModel._storesModel.LoadStoreCategories(base.SelectedStore, true, false)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_cats>>, ExportItemsViewModel.<LoadCategories>d__81>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<store_cats>>);
						this.<>1__state = -1;
					}
					List<store_cats> result = awaiter.GetResult();
					exportItemsViewModel.Categories = new List<store_cats>(result);
					exportItemsViewModel._export.SetCategories(exportItemsViewModel.Categories);
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

			// Token: 0x0600252B RID: 9515 RVA: 0x000722CC File Offset: 0x000704CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040013C5 RID: 5061
			public int <>1__state;

			// Token: 0x040013C6 RID: 5062
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040013C7 RID: 5063
			public ExportItemsViewModel <>4__this;

			// Token: 0x040013C8 RID: 5064
			private TaskAwaiter<List<store_cats>> <>u__1;
		}

		// Token: 0x02000316 RID: 790
		[CompilerGenerated]
		private sealed class <>c__DisplayClass85_0
		{
			// Token: 0x0600252C RID: 9516 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass85_0()
			{
			}

			// Token: 0x0600252D RID: 9517 RVA: 0x000722E8 File Offset: 0x000704E8
			internal bool <ItemExportChanged>b__0(store_items i)
			{
				return i.id == (int)this.obj;
			}

			// Token: 0x040013C9 RID: 5065
			public object obj;
		}
	}
}
