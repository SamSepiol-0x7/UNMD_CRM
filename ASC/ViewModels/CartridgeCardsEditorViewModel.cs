using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200046B RID: 1131
	public class CartridgeCardsEditorViewModel : BaseSearchViewModel
	{
		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x0008EAAC File Offset: 0x0008CCAC
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x0008EAC0 File Offset: 0x0008CCC0
		public string Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				if (string.Equals(this._filter, value, StringComparison.Ordinal))
				{
					return;
				}
				this._filter = value;
				this.RaisePropertyChanged("Filter");
				base.StopSearchTimer();
				base.StartSearchTimer();
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x0008EAFC File Offset: 0x0008CCFC
		// (set) Token: 0x06002C78 RID: 11384 RVA: 0x0008EB10 File Offset: 0x0008CD10
		public List<IManufacturer> Makers
		{
			[CompilerGenerated]
			get
			{
				return this.<Makers>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Makers>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -98675904;
				IL_13:
				switch ((num ^ -890997858) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<Makers>k__BackingField = value;
					this.RaisePropertyChanged("Makers");
					num = -1657552837;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x0008EB6C File Offset: 0x0008CD6C
		// (set) Token: 0x06002C7A RID: 11386 RVA: 0x0008EB80 File Offset: 0x0008CD80
		public List<CartridgeColors> Colors
		{
			[CompilerGenerated]
			get
			{
				return this.<Colors>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Colors>k__BackingField, value))
				{
					return;
				}
				this.<Colors>k__BackingField = value;
				this.RaisePropertyChanged("Colors");
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x0008EBB0 File Offset: 0x0008CDB0
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x0008EBC4 File Offset: 0x0008CDC4
		public ObservableCollection<ICartridgeCard> CartridgeCards
		{
			[CompilerGenerated]
			get
			{
				return this.<CartridgeCards>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<CartridgeCards>k__BackingField, value))
				{
					return;
				}
				this.<CartridgeCards>k__BackingField = value;
				this.RaisePropertyChanged("CartridgeCards");
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002C7D RID: 11389 RVA: 0x0008EBF4 File Offset: 0x0008CDF4
		// (set) Token: 0x06002C7E RID: 11390 RVA: 0x0008EC08 File Offset: 0x0008CE08
		public ICartridgeCard SelectedCard
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedCard>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedCard>k__BackingField, value))
				{
					return;
				}
				this.<SelectedCard>k__BackingField = value;
				this.RaisePropertyChanged("SelectedCard");
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x0008EC38 File Offset: 0x0008CE38
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x0008EC4C File Offset: 0x0008CE4C
		public int SelectedMaker
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedMaker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedMaker>k__BackingField == value)
				{
					return;
				}
				this.<SelectedMaker>k__BackingField = value;
				this.RaisePropertyChanged("SelectedMaker");
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0008EC78 File Offset: 0x0008CE78
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x0008EC8C File Offset: 0x0008CE8C
		public bool ShowArchive
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowArchive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShowArchive>k__BackingField == value)
				{
					return;
				}
				this.<ShowArchive>k__BackingField = value;
				this.RaisePropertyChanged("ShowArchive");
			}
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0008ECB8 File Offset: 0x0008CEB8
		public CartridgeCardsEditorViewModel(IWorkshopService workshopService, IWindowedDocumentService windowedDocumentService, IToasterService toasterService, ICartridgeCardService cartridgeCardService)
		{
			this._workshopService = workshopService;
			this._windowedDocumentService = windowedDocumentService;
			this._toasterService = toasterService;
			this._cartridgeCardService = cartridgeCardService;
			this.Colors = this._cartridgeCardService.GetColors();
			this.Init();
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0008ED00 File Offset: 0x0008CF00
		private void Init()
		{
			CartridgeCardsEditorViewModel.<Init>d__33 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<CartridgeCardsEditorViewModel.<Init>d__33>(ref <Init>d__);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0008ED38 File Offset: 0x0008CF38
		public override void OnSearchTimer()
		{
			this.Refresh();
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x0008ED4C File Offset: 0x0008CF4C
		[Command]
		public void Refresh()
		{
			base.ShowWait();
			Task.Run<IEnumerable<ICartridgeCard>>(() => this._cartridgeCardService.GetCards(this.SelectedMaker, this.ShowArchive, this.Filter)).ContinueWith(delegate(Task<IEnumerable<ICartridgeCard>> t)
			{
				this.CartridgeCards = new ObservableCollection<ICartridgeCard>(t.Result);
				base.HideWait();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x0008ED88 File Offset: 0x0008CF88
		[Command]
		public void SaveAll()
		{
			CartridgeCardsEditorViewModel.<SaveAll>d__36 <SaveAll>d__;
			<SaveAll>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaveAll>d__.<>4__this = this;
			<SaveAll>d__.<>1__state = -1;
			<SaveAll>d__.<>t__builder.Start<CartridgeCardsEditorViewModel.<SaveAll>d__36>(ref <SaveAll>d__);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x0008EDC0 File Offset: 0x0008CFC0
		[Command]
		public void ShowCartridgeCard()
		{
			CartridgeCardViewModel cartridgeCardViewModel = Bootstrapper.Container.Resolve<CartridgeCardViewModel>();
			cartridgeCardViewModel.SetCardId(this.SelectedCard.CardId);
			this._windowedDocumentService.ShowNewDocument("CartridgeCardView", cartridgeCardViewModel, this, null);
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x0008EDFC File Offset: 0x0008CFFC
		public bool CanShowCartridgeCard()
		{
			return this.SelectedCard != null;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x0008EE14 File Offset: 0x0008D014
		[CompilerGenerated]
		private Task<IEnumerable<ICartridgeCard>> <Refresh>b__35_0()
		{
			return this._cartridgeCardService.GetCards(this.SelectedMaker, this.ShowArchive, this.Filter);
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x0008EE40 File Offset: 0x0008D040
		[CompilerGenerated]
		private void <Refresh>b__35_1(Task<IEnumerable<ICartridgeCard>> t)
		{
			this.CartridgeCards = new ObservableCollection<ICartridgeCard>(t.Result);
			base.HideWait();
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x0008EE64 File Offset: 0x0008D064
		[CompilerGenerated]
		private void <SaveAll>b__36_0()
		{
			foreach (ICartridgeCard cartridgeCard in this.CartridgeCards)
			{
				cartridgeCard.Save();
			}
		}

		// Token: 0x040018C3 RID: 6339
		protected IWorkshopService _workshopService;

		// Token: 0x040018C4 RID: 6340
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040018C5 RID: 6341
		private readonly IToasterService _toasterService;

		// Token: 0x040018C6 RID: 6342
		private readonly ICartridgeCardService _cartridgeCardService;

		// Token: 0x040018C7 RID: 6343
		private string _filter;

		// Token: 0x040018C8 RID: 6344
		[CompilerGenerated]
		private List<IManufacturer> <Makers>k__BackingField;

		// Token: 0x040018C9 RID: 6345
		[CompilerGenerated]
		private List<CartridgeColors> <Colors>k__BackingField;

		// Token: 0x040018CA RID: 6346
		[CompilerGenerated]
		private ObservableCollection<ICartridgeCard> <CartridgeCards>k__BackingField;

		// Token: 0x040018CB RID: 6347
		[CompilerGenerated]
		private ICartridgeCard <SelectedCard>k__BackingField;

		// Token: 0x040018CC RID: 6348
		[CompilerGenerated]
		private int <SelectedMaker>k__BackingField;

		// Token: 0x040018CD RID: 6349
		[CompilerGenerated]
		private bool <ShowArchive>k__BackingField;

		// Token: 0x0200046C RID: 1132
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06002C8D RID: 11405 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x06002C8E RID: 11406 RVA: 0x0008EEB0 File Offset: 0x0008D0B0
			internal Task<IDevice> <Init>b__0()
			{
				return this.<>4__this._workshopService.GetRefillDevice();
			}

			// Token: 0x06002C8F RID: 11407 RVA: 0x0008EED0 File Offset: 0x0008D0D0
			internal Task<IEnumerable<IManufacturer>> <Init>b__1()
			{
				return this.<>4__this._workshopService.GetManufacturers(this.device.CompanyList);
			}

			// Token: 0x040018CE RID: 6350
			public CartridgeCardsEditorViewModel <>4__this;

			// Token: 0x040018CF RID: 6351
			public IDevice device;
		}

		// Token: 0x0200046D RID: 1133
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__33 : IAsyncStateMachine
		{
			// Token: 0x06002C90 RID: 11408 RVA: 0x0008EEF8 File Offset: 0x0008D0F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardsEditorViewModel cartridgeCardsEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter;
					TaskAwaiter<IDevice> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
							this.<>1__state = -1;
							goto IL_11B;
						}
						this.<>8__1 = new CartridgeCardsEditorViewModel.<>c__DisplayClass33_0();
						this.<>8__1.<>4__this = this.<>4__this;
						cartridgeCardsEditorViewModel.ShowWait();
						awaiter2 = Task.Run<IDevice>(new Func<Task<IDevice>>(this.<>8__1.<Init>b__0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IDevice>, CartridgeCardsEditorViewModel.<Init>d__33>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IDevice>);
						this.<>1__state = -1;
					}
					IDevice result = awaiter2.GetResult();
					this.<>8__1.device = result;
					awaiter = Task.Run<IEnumerable<IManufacturer>>(new Func<Task<IEnumerable<IManufacturer>>>(this.<>8__1.<Init>b__1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, CartridgeCardsEditorViewModel.<Init>d__33>(ref awaiter, ref this);
						return;
					}
					IL_11B:
					IEnumerable<IManufacturer> result2 = awaiter.GetResult();
					cartridgeCardsEditorViewModel.Makers = new List<IManufacturer>(result2);
					cartridgeCardsEditorViewModel.HideWait();
					cartridgeCardsEditorViewModel.Refresh();
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

			// Token: 0x06002C91 RID: 11409 RVA: 0x0008F09C File Offset: 0x0008D29C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018D0 RID: 6352
			public int <>1__state;

			// Token: 0x040018D1 RID: 6353
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040018D2 RID: 6354
			public CartridgeCardsEditorViewModel <>4__this;

			// Token: 0x040018D3 RID: 6355
			private CartridgeCardsEditorViewModel.<>c__DisplayClass33_0 <>8__1;

			// Token: 0x040018D4 RID: 6356
			private TaskAwaiter<IDevice> <>u__1;

			// Token: 0x040018D5 RID: 6357
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__2;
		}

		// Token: 0x0200046E RID: 1134
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveAll>d__36 : IAsyncStateMachine
		{
			// Token: 0x06002C92 RID: 11410 RVA: 0x0008F0B8 File Offset: 0x0008D2B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardsEditorViewModel cartridgeCardsEditorViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						cartridgeCardsEditorViewModel.ShowWait();
						Task task = Task.Run(delegate()
						{
							foreach (ICartridgeCard cartridgeCard in base.CartridgeCards)
							{
								cartridgeCard.Save();
							}
						});
						awaiter = Task.WhenAll(new Task[]
						{
							task
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeCardsEditorViewModel.<SaveAll>d__36>(ref awaiter, ref this);
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
					cartridgeCardsEditorViewModel.HideWait();
					cartridgeCardsEditorViewModel._toasterService.Success(Lang.t("Saved"));
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

			// Token: 0x06002C93 RID: 11411 RVA: 0x0008F1A8 File Offset: 0x0008D3A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018D6 RID: 6358
			public int <>1__state;

			// Token: 0x040018D7 RID: 6359
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040018D8 RID: 6360
			public CartridgeCardsEditorViewModel <>4__this;

			// Token: 0x040018D9 RID: 6361
			private TaskAwaiter <>u__1;
		}
	}
}
