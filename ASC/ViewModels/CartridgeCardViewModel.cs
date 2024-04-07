using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
	// Token: 0x0200046F RID: 1135
	public class CartridgeCardViewModel : BaseViewModel, IArticulSearch
	{
		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x0008F1C4 File Offset: 0x0008D3C4
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x0008F1D8 File Offset: 0x0008D3D8
		public CartridgeCard Card
		{
			[CompilerGenerated]
			get
			{
				return this.<Card>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Card>k__BackingField, value))
				{
					return;
				}
				this.<Card>k__BackingField = value;
				this.RaisePropertyChanged("Card");
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x0008F208 File Offset: 0x0008D408
		// (set) Token: 0x06002C97 RID: 11415 RVA: 0x0008F21C File Offset: 0x0008D41C
		public List<IManufacturer> Makers
		{
			[CompilerGenerated]
			get
			{
				return this.<Makers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Makers>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1798820213;
				IL_13:
				switch ((num ^ 1395461012) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<Makers>k__BackingField = value;
					num = 667570736;
					goto IL_13;
				}
				this.RaisePropertyChanged("Makers");
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x0008F278 File Offset: 0x0008D478
		// (set) Token: 0x06002C99 RID: 11417 RVA: 0x0008F28C File Offset: 0x0008D48C
		public List<CartridgeColors> Colors
		{
			[CompilerGenerated]
			get
			{
				return this.<Colors>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Colors>k__BackingField, value))
				{
					return;
				}
				this.<Colors>k__BackingField = value;
				this.RaisePropertyChanged("Colors");
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x0008F2BC File Offset: 0x0008D4BC
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x0008F2D0 File Offset: 0x0008D4D0
		public IMaterial SelectedMaterial
		{
			get
			{
				return this._selectedMaterial;
			}
			set
			{
				if (object.Equals(this._selectedMaterial, value))
				{
					return;
				}
				this._selectedMaterial = value;
				this.RaisePropertyChanged("SelectedMaterial");
				base.RaiseCanExecuteChanged(() => this.RemoveMaterial());
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x0008F33C File Offset: 0x0008D53C
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x0008F350 File Offset: 0x0008D550
		public List<KeyValuePair<int, string>> MaterialTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<MaterialTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<MaterialTypes>k__BackingField, value))
				{
					return;
				}
				this.<MaterialTypes>k__BackingField = value;
				this.RaisePropertyChanged("MaterialTypes");
			}
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x0008F380 File Offset: 0x0008D580
		public CartridgeCardViewModel(IWorkshopService workshopService, IWindowedDocumentService windowedDocumentService, IToasterService toasterService, ICartridgeCardService cartridgeCardService)
		{
			this._workshopService = workshopService;
			this._windowedDocumentService = windowedDocumentService;
			this._toasterService = toasterService;
			this._cartridgeCardService = cartridgeCardService;
			this.Card = new CartridgeCard
			{
				EmployeeId = OfflineData.Instance.Employee.Id
			};
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0008F3D0 File Offset: 0x0008D5D0
		public void SetMakerId(int makerId)
		{
			this.Card.MakerId = makerId;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0008F3EC File Offset: 0x0008D5EC
		public void SetRefreshOnClose(bool value)
		{
			this._refreshOnClose = value;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0008F400 File Offset: 0x0008D600
		public void SetCardId(int cardId)
		{
			this._cardId = cardId;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0008F414 File Offset: 0x0008D614
		private Task Init()
		{
			CartridgeCardViewModel.<Init>d__31 <Init>d__;
			<Init>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<CartridgeCardViewModel.<Init>d__31>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0008F458 File Offset: 0x0008D658
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x0008F478 File Offset: 0x0008D678
		private Task LoadCard(int cardId)
		{
			CartridgeCardViewModel.<LoadCard>d__33 <LoadCard>d__;
			<LoadCard>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadCard>d__.<>4__this = this;
			<LoadCard>d__.cardId = cardId;
			<LoadCard>d__.<>1__state = -1;
			<LoadCard>d__.<>t__builder.Start<CartridgeCardViewModel.<LoadCard>d__33>(ref <LoadCard>d__);
			return <LoadCard>d__.<>t__builder.Task;
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x0008F4C4 File Offset: 0x0008D6C4
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x0008F4DC File Offset: 0x0008D6DC
		[AsyncCommand]
		public Task Save()
		{
			CartridgeCardViewModel.<Save>d__35 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<CartridgeCardViewModel.<Save>d__35>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x0008F520 File Offset: 0x0008D720
		public bool CanSave()
		{
			CartridgeCard card = this.Card;
			return card != null && card.CardId > 0 && OfflineData.Instance.Employee.Can(80, 0);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x0008F558 File Offset: 0x0008D758
		[AsyncCommand]
		public Task Create()
		{
			CartridgeCardViewModel.<Create>d__37 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<CartridgeCardViewModel.<Create>d__37>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x0008F59C File Offset: 0x0008D79C
		public bool CanCreate()
		{
			CartridgeCard card = this.Card;
			return card != null && card.CardId == 0;
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
		[Command]
		public void MaterialClick()
		{
			IMaterial selectedMaterial = this.SelectedMaterial;
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0008F5D4 File Offset: 0x0008D7D4
		[Command]
		public void AddMaterial()
		{
			this.Card.AddMaterial();
			base.RaiseCanExecuteChanged(() => this.AddMaterial());
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x0008F628 File Offset: 0x0008D828
		[Command]
		public void ArticulClicked(int index)
		{
			CartringeArticulSearchViewModel cartringeArticulSearchViewModel = Bootstrapper.Container.Resolve<CartringeArticulSearchViewModel>();
			cartringeArticulSearchViewModel.SetInsertIndex(index);
			cartringeArticulSearchViewModel.SetOptionsVisible(false);
			this._windowedDocumentService.ShowNewDocument("ArticulSearchView", cartringeArticulSearchViewModel, this, null);
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0008F664 File Offset: 0x0008D864
		public void InsertSearchItem(int insertIndex, IArticulSearchLite item, string name, int articul, int categoryId, int state)
		{
			if (this.Card.Materials.ElementAtOrDefault(insertIndex) == null)
			{
				return;
			}
			IMaterial material = this.Card.Materials[insertIndex];
			material.Articul = new int?(articul);
			material.Name = name;
			if (item != null)
			{
				material.Price = item.MaxPrice * material.Count;
			}
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0008F6CC File Offset: 0x0008D8CC
		[Command]
		public void RemoveMaterial()
		{
			if (this.SelectedMaterial != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 520555940;
			IL_0D:
			switch ((num ^ 1190967785) % 4)
			{
			case 1:
				return;
			case 2:
				goto IL_08;
			case 3:
			{
				IL_2C:
				bool response = this.Card.RemoveMaterial(this.SelectedMaterial.Name);
				base.ShowActionResponse(response, "");
				base.RaiseCanExecuteChanged(() => this.AddMaterial());
				num = 452153317;
				goto IL_0D;
			}
			}
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0008F770 File Offset: 0x0008D970
		public bool CanRemoveMaterial()
		{
			return this.SelectedMaterial != null;
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0008F788 File Offset: 0x0008D988
		public override void OnLoad()
		{
			CartridgeCardViewModel.<OnLoad>d__45 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<CartridgeCardViewModel.<OnLoad>d__45>(ref <OnLoad>d__);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0008F7C0 File Offset: 0x0008D9C0
		[CompilerGenerated]
		private Task<bool> <Save>b__35_0()
		{
			return this.Card.Save();
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x040018DA RID: 6362
		protected IWorkshopService _workshopService;

		// Token: 0x040018DB RID: 6363
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040018DC RID: 6364
		private readonly IToasterService _toasterService;

		// Token: 0x040018DD RID: 6365
		private readonly ICartridgeCardService _cartridgeCardService;

		// Token: 0x040018DE RID: 6366
		[CompilerGenerated]
		private CartridgeCard <Card>k__BackingField;

		// Token: 0x040018DF RID: 6367
		private IRefreshable _parentViewModel;

		// Token: 0x040018E0 RID: 6368
		[CompilerGenerated]
		private List<IManufacturer> <Makers>k__BackingField;

		// Token: 0x040018E1 RID: 6369
		[CompilerGenerated]
		private List<CartridgeColors> <Colors>k__BackingField;

		// Token: 0x040018E2 RID: 6370
		private bool _refreshOnClose;

		// Token: 0x040018E3 RID: 6371
		private IMaterial _selectedMaterial;

		// Token: 0x040018E4 RID: 6372
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <MaterialTypes>k__BackingField;

		// Token: 0x040018E5 RID: 6373
		private int _cardId;

		// Token: 0x02000470 RID: 1136
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__31 : IAsyncStateMachine
		{
			// Token: 0x06002CB3 RID: 11443 RVA: 0x0008F7D8 File Offset: 0x0008D9D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardViewModel cartridgeCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IDevice> awaiter;
					TaskAwaiter<IEnumerable<IManufacturer>> awaiter2;
					TaskAwaiter awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IDevice>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<IEnumerable<IManufacturer>>);
						this.<>1__state = -1;
						goto IL_FD;
					case 2:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_198;
					default:
						awaiter = cartridgeCardViewModel._workshopService.GetRefillDevice().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IDevice>, CartridgeCardViewModel.<Init>d__31>(ref awaiter, ref this);
							return;
						}
						break;
					}
					IDevice result = awaiter.GetResult();
					if (result == null)
					{
						cartridgeCardViewModel._toasterService.Error(Lang.t("CartridgeMakersWarning"));
						goto IL_113;
					}
					awaiter2 = cartridgeCardViewModel._workshopService.GetManufacturers(result.CompanyList).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IManufacturer>>, CartridgeCardViewModel.<Init>d__31>(ref awaiter2, ref this);
						return;
					}
					IL_FD:
					IEnumerable<IManufacturer> result2 = awaiter2.GetResult();
					cartridgeCardViewModel.Makers = new List<IManufacturer>(result2);
					IL_113:
					cartridgeCardViewModel.Colors = cartridgeCardViewModel._cartridgeCardService.GetColors();
					cartridgeCardViewModel.MaterialTypes = cartridgeCardViewModel._cartridgeCardService.GetMaterialTypes();
					if (cartridgeCardViewModel._cardId <= 0)
					{
						goto IL_19F;
					}
					awaiter3 = cartridgeCardViewModel.LoadCard(cartridgeCardViewModel._cardId).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeCardViewModel.<Init>d__31>(ref awaiter3, ref this);
						return;
					}
					IL_198:
					awaiter3.GetResult();
					IL_19F:;
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

			// Token: 0x06002CB4 RID: 11444 RVA: 0x0008F9D0 File Offset: 0x0008DBD0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018E6 RID: 6374
			public int <>1__state;

			// Token: 0x040018E7 RID: 6375
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040018E8 RID: 6376
			public CartridgeCardViewModel <>4__this;

			// Token: 0x040018E9 RID: 6377
			private TaskAwaiter<IDevice> <>u__1;

			// Token: 0x040018EA RID: 6378
			private TaskAwaiter<IEnumerable<IManufacturer>> <>u__2;

			// Token: 0x040018EB RID: 6379
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000471 RID: 1137
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06002CB5 RID: 11445 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x06002CB6 RID: 11446 RVA: 0x0008F9EC File Offset: 0x0008DBEC
			internal Task<ICartridgeCard> <LoadCard>b__2()
			{
				return this.<>4__this._cartridgeCardService.GetCartridgeCard(this.cardId);
			}

			// Token: 0x040018EC RID: 6380
			public CartridgeCardViewModel <>4__this;

			// Token: 0x040018ED RID: 6381
			public int cardId;
		}

		// Token: 0x02000472 RID: 1138
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadCard>d__33 : IAsyncStateMachine
		{
			// Token: 0x06002CB7 RID: 11447 RVA: 0x0008FA10 File Offset: 0x0008DC10
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardViewModel cartridgeCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<ICartridgeCard> awaiter;
					if (num != 0)
					{
						CartridgeCardViewModel.<>c__DisplayClass33_0 CS$<>8__locals1 = new CartridgeCardViewModel.<>c__DisplayClass33_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						CS$<>8__locals1.cardId = this.cardId;
						cartridgeCardViewModel.ShowWait();
						awaiter = Task.Run<ICartridgeCard>(new Func<Task<ICartridgeCard>>(CS$<>8__locals1.<LoadCard>b__2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICartridgeCard>, CartridgeCardViewModel.<LoadCard>d__33>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<ICartridgeCard>);
						this.<>1__state = -1;
					}
					ICartridgeCard result = awaiter.GetResult();
					cartridgeCardViewModel.Card = (CartridgeCard)result;
					cartridgeCardViewModel.RaiseCanExecuteChanged(() => cartridgeCardViewModel.Save());
					cartridgeCardViewModel.RaiseCanExecuteChanged(() => cartridgeCardViewModel.Create());
					cartridgeCardViewModel.HideWait();
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

			// Token: 0x06002CB8 RID: 11448 RVA: 0x0008FB8C File Offset: 0x0008DD8C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018EE RID: 6382
			public int <>1__state;

			// Token: 0x040018EF RID: 6383
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040018F0 RID: 6384
			public CartridgeCardViewModel <>4__this;

			// Token: 0x040018F1 RID: 6385
			public int cardId;

			// Token: 0x040018F2 RID: 6386
			private TaskAwaiter<ICartridgeCard> <>u__1;
		}

		// Token: 0x02000473 RID: 1139
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__35 : IAsyncStateMachine
		{
			// Token: 0x06002CB9 RID: 11449 RVA: 0x0008FBA8 File Offset: 0x0008DDA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardViewModel cartridgeCardViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!cartridgeCardViewModel.CheckFields(cartridgeCardViewModel.Card))
						{
							goto IL_10E;
						}
						cartridgeCardViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<bool>(() => base.Card.Save()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, CartridgeCardViewModel.<Save>d__35>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						if (cartridgeCardViewModel._refreshOnClose)
						{
							IRefreshable parentViewModel = cartridgeCardViewModel._parentViewModel;
							if (parentViewModel != null)
							{
								parentViewModel.DataRefresh();
							}
						}
						cartridgeCardViewModel._windowedDocumentService.CloseActiveDocument();
						cartridgeCardViewModel._toasterService.Success(Lang.t("Saved"));
					}
					catch (Exception ex)
					{
						cartridgeCardViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							cartridgeCardViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_10E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002CBA RID: 11450 RVA: 0x0008FD00 File Offset: 0x0008DF00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018F3 RID: 6387
			public int <>1__state;

			// Token: 0x040018F4 RID: 6388
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040018F5 RID: 6389
			public CartridgeCardViewModel <>4__this;

			// Token: 0x040018F6 RID: 6390
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000474 RID: 1140
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__37 : IAsyncStateMachine
		{
			// Token: 0x06002CBB RID: 11451 RVA: 0x0008FD1C File Offset: 0x0008DF1C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardViewModel cartridgeCardViewModel = this.<>4__this;
				try
				{
					if (num > 1)
					{
						if (!cartridgeCardViewModel.CheckFields(cartridgeCardViewModel.Card))
						{
							goto IL_269;
						}
						cartridgeCardViewModel.ShowWait();
					}
					try
					{
						try
						{
							if (num != 0)
							{
								goto IL_E2;
							}
							goto IL_1A6;
							TaskAwaiter<int> awaiter;
							for (;;)
							{
								IL_103:
								int result = awaiter.GetResult();
								this.<>7__wrap1.CardId = result;
								this.<>7__wrap1 = null;
								IL_D2:
								while (cartridgeCardViewModel._refreshOnClose)
								{
									for (;;)
									{
										IRefreshable parentViewModel = cartridgeCardViewModel._parentViewModel;
										if (parentViewModel != null)
										{
											parentViewModel.DataRefresh();
											uint num2;
											switch ((num2 = (num2 * 1372240806U ^ 692638547U ^ 1573977984U)) % 25U)
											{
											case 0U:
											case 7U:
												goto IL_E2;
											case 2U:
												goto IL_18D;
											case 3U:
												goto IL_D2;
											case 4U:
												goto IL_103;
											case 5U:
												goto IL_1E3;
											case 6U:
												goto IL_1F7;
											case 8U:
												goto IL_14F;
											case 9U:
												goto IL_1B8;
											case 10U:
												goto IL_120;
											case 11U:
												goto IL_1AF;
											case 12U:
												goto IL_E6;
											case 13U:
												goto IL_176;
											case 14U:
												goto IL_1DC;
											case 15U:
												goto IL_1CE;
											case 16U:
												goto IL_219;
											case 18U:
												goto IL_1A6;
											case 19U:
												goto IL_17F;
											case 20U:
												goto IL_FA;
											case 21U:
												goto IL_1C0;
											case 22U:
												goto IL_1D3;
											case 23U:
												continue;
											case 24U:
												goto IL_198;
											}
											goto Block_10;
										}
										goto IL_1F6;
									}
								}
								goto Block_11;
							}
							Block_10:
							goto IL_217;
							Block_11:
							IL_1F6:
							IL_1F7:
							cartridgeCardViewModel._windowedDocumentService.CloseActiveDocument();
							cartridgeCardViewModel._toasterService.Success(Lang.t("Saved"));
							IL_217:
							goto IL_241;
							IL_E2:
							if (num != 1)
							{
								goto IL_14F;
							}
							IL_E6:
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							IL_FA:
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_103;
							IL_120:
							this.<>7__wrap1 = cartridgeCardViewModel.Card;
							awaiter = cartridgeCardViewModel._cartridgeCardService.CreateCartridgeCard(cartridgeCardViewModel.Card).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								goto IL_1AF;
							}
							goto IL_103;
							IL_14F:
							TaskAwaiter<bool> awaiter2 = cartridgeCardViewModel._cartridgeCardService.IsUnique(cartridgeCardViewModel.Card.Name, cartridgeCardViewModel.Card.MakerId).GetAwaiter();
							IL_176:
							if (!awaiter2.IsCompleted)
							{
								goto IL_1D3;
							}
							IL_17F:
							if (awaiter2.GetResult())
							{
								goto IL_120;
							}
							goto IL_219;
							IL_18D:
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_17F;
							IL_198:
							this.<>u__1 = default(TaskAwaiter<bool>);
							goto IL_18D;
							IL_1A6:
							awaiter2 = this.<>u__1;
							goto IL_198;
							IL_1AF:
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							IL_1B8:
							this.<>u__2 = awaiter;
							IL_1C0:
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeCardViewModel.<Create>d__37>(ref awaiter, ref this);
							IL_1CE:
							return;
							IL_1D3:
							int num6 = 0;
							num = 0;
							this.<>1__state = num6;
							IL_1DC:
							this.<>u__1 = awaiter2;
							IL_1E3:
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, CartridgeCardViewModel.<Create>d__37>(ref awaiter2, ref this);
							return;
							IL_219:
							cartridgeCardViewModel._toasterService.Info("Карта картриджа с таким именем уже существует");
						}
						catch (Exception ex)
						{
							cartridgeCardViewModel._toasterService.Error(ex.Message);
						}
						IL_241:;
					}
					finally
					{
						if (num < 0)
						{
							cartridgeCardViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_269:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002CBC RID: 11452 RVA: 0x0008FFF4 File Offset: 0x0008E1F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018F7 RID: 6391
			public int <>1__state;

			// Token: 0x040018F8 RID: 6392
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040018F9 RID: 6393
			public CartridgeCardViewModel <>4__this;

			// Token: 0x040018FA RID: 6394
			private TaskAwaiter<bool> <>u__1;

			// Token: 0x040018FB RID: 6395
			private CartridgeCard <>7__wrap1;

			// Token: 0x040018FC RID: 6396
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x02000475 RID: 1141
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__45 : IAsyncStateMachine
		{
			// Token: 0x06002CBD RID: 11453 RVA: 0x00090010 File Offset: 0x0008E210
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardViewModel cartridgeCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						cartridgeCardViewModel.<>n__0();
						awaiter = cartridgeCardViewModel.Init().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeCardViewModel.<OnLoad>d__45>(ref awaiter, ref this);
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

			// Token: 0x06002CBE RID: 11454 RVA: 0x000900C8 File Offset: 0x0008E2C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018FD RID: 6397
			public int <>1__state;

			// Token: 0x040018FE RID: 6398
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040018FF RID: 6399
			public CartridgeCardViewModel <>4__this;

			// Token: 0x04001900 RID: 6400
			private TaskAwaiter <>u__1;
		}
	}
}
