using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Grid;

namespace ASC.ArticulSearch
{
	// Token: 0x020001AF RID: 431
	public class ArticulSearchViewModel : CollectionViewModel<ArticulSearchLite>
	{
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00044DA4 File Offset: 0x00042FA4
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x00044DB8 File Offset: 0x00042FB8
		public ICommand CloseCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CloseCommand>k__BackingField, value))
				{
					return;
				}
				this.<CloseCommand>k__BackingField = value;
				this.RaisePropertyChanged("CloseCommand");
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00044DE8 File Offset: 0x00042FE8
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x00044DFC File Offset: 0x00042FFC
		public ICommand WindowClosingCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<WindowClosingCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WindowClosingCommand>k__BackingField, value))
				{
					return;
				}
				this.<WindowClosingCommand>k__BackingField = value;
				this.RaisePropertyChanged("WindowClosingCommand");
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x00044E2C File Offset: 0x0004302C
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x00044E40 File Offset: 0x00043040
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

		// Token: 0x060018DF RID: 6367 RVA: 0x00044E70 File Offset: 0x00043070
		private void InitCommands()
		{
			this.CloseCommand = new RelayCommand(new Action<object>(this.Close));
			this.WindowClosingCommand = new RelayCommand(new Action<object>(this.Closing));
			this.RefreshCommand = new RelayCommand(new Action<object>(this.Refresh));
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00044EC4 File Offset: 0x000430C4
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x00044ED8 File Offset: 0x000430D8
		public int Articul
		{
			[CompilerGenerated]
			get
			{
				return this.<Articul>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Articul>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -2045761872;
				IL_10:
				switch ((num ^ -1046094966) % 4)
				{
				case 1:
					IL_2F:
					this.<Articul>k__BackingField = value;
					this.RaisePropertyChanged("Articul");
					num = -1254223026;
					goto IL_10;
				case 2:
					return;
				case 3:
					goto IL_0B;
				}
			}
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00044F30 File Offset: 0x00043130
		public override void OnSelectedItemChanged(ArticulSearchLite item)
		{
			if (item != null)
			{
				goto IL_27;
			}
			IL_03:
			int num = -1240766730;
			IL_08:
			switch ((num ^ -1062584453) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				return;
			case 2:
				IL_27:
				this.Name = item.Name;
				num = -918608468;
				goto IL_08;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00044F78 File Offset: 0x00043178
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x00044F90 File Offset: 0x00043190
		public bool IncludePn
		{
			get
			{
				return Settings.Default.IncludePn;
			}
			set
			{
				if (this.IncludePn == value)
				{
					return;
				}
				Settings.Default.IncludePn = value;
				ArticulSearchViewModel.SaveProperties();
				this.RaisePropertyChanged("IncludePn");
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00044FC4 File Offset: 0x000431C4
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x00044FEC File Offset: 0x000431EC
		public bool IncludePrice
		{
			get
			{
				return Auth.Config.it_vis_rozn && Settings.Default.IncludePrice;
			}
			set
			{
				if (this.IncludePrice == value)
				{
					return;
				}
				Settings.Default.IncludePrice = value;
				ArticulSearchViewModel.SaveProperties();
				this.RaisePropertyChanged("IncludePrice");
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00045020 File Offset: 0x00043220
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x00045048 File Offset: 0x00043248
		public bool IncludePrice4Sc
		{
			get
			{
				return Auth.Config.it_vis_price_for_sc && Settings.Default.IncludePrice4Sc;
			}
			set
			{
				if (this.IncludePrice4Sc == value)
				{
					return;
				}
				Settings.Default.IncludePrice4Sc = value;
				ArticulSearchViewModel.SaveProperties();
				this.RaisePropertyChanged("IncludePrice4Sc");
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0004507C File Offset: 0x0004327C
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x000450A4 File Offset: 0x000432A4
		public bool IncludePriceOpt
		{
			get
			{
				return Auth.Config.it_vis_opt && Settings.Default.IncludePriceOpt;
			}
			set
			{
				if (this.IncludePriceOpt == value)
				{
					return;
				}
				Settings.Default.IncludePriceOpt = value;
				ArticulSearchViewModel.SaveProperties();
				this.RaisePropertyChanged("IncludePriceOpt");
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x000450D8 File Offset: 0x000432D8
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x00045100 File Offset: 0x00043300
		public bool IncludePriceOpt2
		{
			get
			{
				return Auth.Config.it_vis_opt2 && Settings.Default.IncludePriceOpt2;
			}
			set
			{
				if (this.IncludePriceOpt2 == value)
				{
					return;
				}
				Settings.Default.IncludePriceOpt2 = value;
				ArticulSearchViewModel.SaveProperties();
				this.RaisePropertyChanged("IncludePriceOpt2");
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00045134 File Offset: 0x00043334
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0004515C File Offset: 0x0004335C
		public bool IncludePriceOpt3
		{
			get
			{
				return Auth.Config.it_vis_opt3 && Settings.Default.IncludePriceOpt3;
			}
			set
			{
				if (this.IncludePriceOpt3 == value)
				{
					return;
				}
				Settings.Default.IncludePriceOpt3 = value;
				ArticulSearchViewModel.SaveProperties();
				this.RaisePropertyChanged("IncludePriceOpt3");
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00045190 File Offset: 0x00043390
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x000451A8 File Offset: 0x000433A8
		public bool IncludeDescription
		{
			get
			{
				return Settings.Default.IncludeDescription;
			}
			set
			{
				if (this.IncludeDescription == value)
				{
					return;
				}
				Settings.Default.IncludeDescription = value;
				ArticulSearchViewModel.SaveProperties();
				this.RaisePropertyChanged("IncludeDescription");
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000451DC File Offset: 0x000433DC
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x000451F0 File Offset: 0x000433F0
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (string.Equals(this._name, value, StringComparison.Ordinal))
				{
					return;
				}
				this._name = value;
				this.RaisePropertyChanged("Name");
				if (!this._returnResult)
				{
					this._searchTimer.Stop();
					this._searchTimer.Start();
				}
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00045240 File Offset: 0x00043440
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x00045254 File Offset: 0x00043454
		public int Category
		{
			[CompilerGenerated]
			get
			{
				return this.<Category>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Category>k__BackingField == value)
				{
					return;
				}
				this.<Category>k__BackingField = value;
				this.RaisePropertyChanged("Category");
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00045280 File Offset: 0x00043480
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x00045294 File Offset: 0x00043494
		public int State
		{
			[CompilerGenerated]
			get
			{
				return this.<State>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<State>k__BackingField == value)
				{
					return;
				}
				this.<State>k__BackingField = value;
				this.RaisePropertyChanged("State");
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x000452C0 File Offset: 0x000434C0
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x000452D4 File Offset: 0x000434D4
		public Visibility PasteNew
		{
			[CompilerGenerated]
			get
			{
				return this.<PasteNew>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PasteNew>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1780213601;
				IL_10:
				switch ((num ^ -1286397606) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					this.<PasteNew>k__BackingField = value;
					this.RaisePropertyChanged("PasteNew");
					num = -1070593446;
					goto IL_10;
				}
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0004532C File Offset: 0x0004352C
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x00045340 File Offset: 0x00043540
		public bool OptionsVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<OptionsVisible>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<OptionsVisible>k__BackingField == value)
				{
					return;
				}
				this.<OptionsVisible>k__BackingField = value;
				this.RaisePropertyChanged("OptionsVisible");
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0004536C File Offset: 0x0004356C
		public ArticulSearchViewModel()
		{
			this._storeService = Bootstrapper.Container.Resolve<IStoreService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.OptionsVisible = true;
			this._searchTimer = new DispatcherTimer();
			this._searchTimer.Tick += this.dTimer_Tick;
			this._searchTimer.Interval = TimeSpan.FromMilliseconds(300.0);
			this.InitCommands();
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x000453F0 File Offset: 0x000435F0
		public ArticulSearchViewModel(IStoreService storeService, IWindowedDocumentService windowedDocumentService)
		{
			this._storeService = storeService;
			this._windowedDocumentService = windowedDocumentService;
			this.OptionsVisible = true;
			this._searchTimer = new DispatcherTimer();
			this._searchTimer.Tick += this.dTimer_Tick;
			this._searchTimer.Interval = TimeSpan.FromMilliseconds(300.0);
			this.InitCommands();
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00045460 File Offset: 0x00043660
		public void SetOptionsVisible(bool value)
		{
			this.OptionsVisible = value;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00045474 File Offset: 0x00043674
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IArticulSearch);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00045494 File Offset: 0x00043694
		private void dTimer_Tick(object sender, EventArgs e)
		{
			this._searchTimer.Stop();
			this.Search();
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000454B4 File Offset: 0x000436B4
		[Command]
		public void ItemDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			this._returnResult = true;
			this.Articul = base.SelectedItem.Articul;
			this.Name = base.SelectedItem.Name;
			this.Category = base.SelectedItem.Category;
			this.State = base.SelectedItem.State;
			this.ReturnAndClose();
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0004551C File Offset: 0x0004371C
		protected virtual void ReturnAndClose()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x000407D8 File Offset: 0x0003E9D8
		private void Closing(object obj)
		{
			Settings.Default.Save();
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00045534 File Offset: 0x00043734
		private void Close(object obj)
		{
			this.Articul = 0;
			this.ReturnAndClose();
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00045550 File Offset: 0x00043750
		[Command]
		public void Paste()
		{
			this.Articul = 0;
			this.Category = 0;
			this.State = 1;
			this.ReturnAndClose();
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00045578 File Offset: 0x00043778
		public void SetQuery(string query)
		{
			this.Name = query;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0004558C File Offset: 0x0004378C
		protected virtual void Search()
		{
			ArticulSearchViewModel.<Search>d__75 <Search>d__;
			<Search>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Search>d__.<>4__this = this;
			<Search>d__.<>1__state = -1;
			<Search>d__.<>t__builder.Start<ArticulSearchViewModel.<Search>d__75>(ref <Search>d__);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x000455C4 File Offset: 0x000437C4
		private static void SaveProperties()
		{
			try
			{
				Settings.Default.Save();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000455FC File Offset: 0x000437FC
		private void Refresh(object obj)
		{
			this.Search();
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00045610 File Offset: 0x00043810
		[Command]
		public void ItemsSourceChanged(ItemsSourceChangedEventArgs e)
		{
			GridControl gridControl = ((e == null) ? null : e.OriginalSource) as GridControl;
			if (gridControl != null)
			{
				gridControl.CurrentItem = null;
				gridControl.SelectedItem = null;
			}
		}

		// Token: 0x04000CBE RID: 3262
		protected readonly IStoreService _storeService;

		// Token: 0x04000CBF RID: 3263
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000CC0 RID: 3264
		protected IArticulSearch _parentViewModel;

		// Token: 0x04000CC1 RID: 3265
		private DispatcherTimer _searchTimer;

		// Token: 0x04000CC2 RID: 3266
		private bool _returnResult;

		// Token: 0x04000CC3 RID: 3267
		[CompilerGenerated]
		private ICommand <CloseCommand>k__BackingField;

		// Token: 0x04000CC4 RID: 3268
		[CompilerGenerated]
		private ICommand <WindowClosingCommand>k__BackingField;

		// Token: 0x04000CC5 RID: 3269
		[CompilerGenerated]
		private ICommand <RefreshCommand>k__BackingField;

		// Token: 0x04000CC6 RID: 3270
		[CompilerGenerated]
		private int <Articul>k__BackingField;

		// Token: 0x04000CC7 RID: 3271
		[CompilerGenerated]
		private int <Category>k__BackingField;

		// Token: 0x04000CC8 RID: 3272
		[CompilerGenerated]
		private int <State>k__BackingField;

		// Token: 0x04000CC9 RID: 3273
		[CompilerGenerated]
		private Visibility <PasteNew>k__BackingField = Visibility.Hidden;

		// Token: 0x04000CCA RID: 3274
		private string _name;

		// Token: 0x04000CCB RID: 3275
		[CompilerGenerated]
		private bool <OptionsVisible>k__BackingField;

		// Token: 0x020001B0 RID: 432
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Search>d__75 : IAsyncStateMachine
		{
			// Token: 0x0600190A RID: 6410 RVA: 0x00045640 File Offset: 0x00043840
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ArticulSearchViewModel articulSearchViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IList<ArticulSearchLite>> awaiter;
					TaskAwaiter<IList<int>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IList<ArticulSearchLite>>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							goto IL_FF;
						}
						if (string.IsNullOrEmpty(articulSearchViewModel.Name))
						{
							ObservableCollection<ArticulSearchLite> items = articulSearchViewModel.Items;
							if (items != null)
							{
								items.Clear();
							}
							goto IL_229;
						}
						if (articulSearchViewModel.Name.Length < 2)
						{
							goto IL_229;
						}
						articulSearchViewModel.ShowWait();
						awaiter2 = articulSearchViewModel._storeService.SearchSKU(articulSearchViewModel.Name).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.<>1__state = num3;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<int>>, ArticulSearchViewModel.<Search>d__75>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IList<int>>);
						int num4 = -1;
						num = -1;
						this.<>1__state = num4;
					}
					IList<int> result = awaiter2.GetResult();
					awaiter = articulSearchViewModel._storeService.GetProductsBySKU(result).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 1;
						num = 1;
						this.<>1__state = num5;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<ArticulSearchLite>>, ArticulSearchViewModel.<Search>d__75>(ref awaiter, ref this);
						return;
					}
					IL_FF:
					IList<ArticulSearchLite> result2 = awaiter.GetResult();
					articulSearchViewModel.HideWait();
					IEnumerator<ArticulSearchLite> enumerator = result2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ArticulSearchLite articulSearchLite = enumerator.Current;
							if (!articulSearchViewModel.IncludePn)
							{
								articulSearchLite.PartNumber = "";
							}
							if (!articulSearchViewModel.IncludeDescription)
							{
								articulSearchLite.Description = "";
							}
							if (!articulSearchViewModel.IncludePrice)
							{
								articulSearchLite.Price = 0m;
							}
							if (!articulSearchViewModel.IncludePriceOpt)
							{
								articulSearchLite.PriceOpt = 0m;
							}
							if (!articulSearchViewModel.IncludePriceOpt2)
							{
								articulSearchLite.PriceOpt2 = 0m;
							}
							if (!articulSearchViewModel.IncludePriceOpt3)
							{
								articulSearchLite.PriceOpt3 = 0m;
							}
							if (!articulSearchViewModel.IncludePrice4Sc)
							{
								articulSearchLite.Price4Sc = 0m;
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					articulSearchViewModel.SetItems(result2);
					articulSearchViewModel.PasteNew = ((articulSearchViewModel.Items.Count > 0) ? Visibility.Hidden : Visibility.Visible);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_229:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600190B RID: 6411 RVA: 0x000458C0 File Offset: 0x00043AC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000CCC RID: 3276
			public int <>1__state;

			// Token: 0x04000CCD RID: 3277
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000CCE RID: 3278
			public ArticulSearchViewModel <>4__this;

			// Token: 0x04000CCF RID: 3279
			private TaskAwaiter<IList<int>> <>u__1;

			// Token: 0x04000CD0 RID: 3280
			private TaskAwaiter<IList<ArticulSearchLite>> <>u__2;
		}
	}
}
