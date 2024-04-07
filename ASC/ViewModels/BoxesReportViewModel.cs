using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000465 RID: 1125
	public class BoxesReportViewModel : CollectionViewModel<IBox>
	{
		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x0008DAD4 File Offset: 0x0008BCD4
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x0008DAE8 File Offset: 0x0008BCE8
		public List<KeyValuePair<int, string>> BoxStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<BoxStatuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<BoxStatuses>k__BackingField, value))
				{
					return;
				}
				this.<BoxStatuses>k__BackingField = value;
				this.RaisePropertyChanged("BoxStatuses");
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x0008DB18 File Offset: 0x0008BD18
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x0008DB2C File Offset: 0x0008BD2C
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
				if (object.Equals(this.<Stores>k__BackingField, value))
				{
					return;
				}
				this.<Stores>k__BackingField = value;
				this.RaisePropertyChanged("Stores");
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x0008DB5C File Offset: 0x0008BD5C
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x0008DB70 File Offset: 0x0008BD70
		public int SelectedStore
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStore>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedStore>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1315005343;
				IL_10:
				switch ((num ^ -5198410) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					num = -2101772256;
					goto IL_10;
				case 3:
					return;
				}
				this.<SelectedStore>k__BackingField = value;
				this.RaisePropertyChanged("SelectedStore");
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x0008DBC8 File Offset: 0x0008BDC8
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x0008DBDC File Offset: 0x0008BDDC
		public int SelectedStatus
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedStatus>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedStatus>k__BackingField == value)
				{
					return;
				}
				this.<SelectedStatus>k__BackingField = value;
				this.RaisePropertyChanged("SelectedStatus");
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x0008DC08 File Offset: 0x0008BE08
		// (set) Token: 0x06002C53 RID: 11347 RVA: 0x0008DC1C File Offset: 0x0008BE1C
		public IGoods SelectedGoods
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedGoods>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedGoods>k__BackingField, value))
				{
					return;
				}
				this.<SelectedGoods>k__BackingField = value;
				this.RaisePropertyChanged("SelectedGoods");
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x0008DC4C File Offset: 0x0008BE4C
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0008DC60 File Offset: 0x0008BE60
		public IRepair SelectedRepair
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedRepair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedRepair>k__BackingField, value))
				{
					return;
				}
				this.<SelectedRepair>k__BackingField = value;
				this.RaisePropertyChanged("SelectedRepair");
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x0008DC90 File Offset: 0x0008BE90
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x0008DCA4 File Offset: 0x0008BEA4
		public List<IIdName> Types
		{
			[CompilerGenerated]
			get
			{
				return this.<Types>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Types>k__BackingField, value))
				{
					return;
				}
				this.<Types>k__BackingField = value;
				this.RaisePropertyChanged("Types");
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x0008DCD4 File Offset: 0x0008BED4
		// (set) Token: 0x06002C59 RID: 11353 RVA: 0x0008DCE8 File Offset: 0x0008BEE8
		public int SelectedType
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedType>k__BackingField == value)
				{
					return;
				}
				this.<SelectedType>k__BackingField = value;
				this.RaisePropertyChanged("SelectedType");
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x0008DD14 File Offset: 0x0008BF14
		// (set) Token: 0x06002C5B RID: 11355 RVA: 0x0008DD58 File Offset: 0x0008BF58
		public string SearchQuery
		{
			get
			{
				return base.GetProperty<string>(() => this.SearchQuery);
			}
			set
			{
				if (!string.Equals(this.SearchQuery, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 2121940392;
				IL_14:
				switch ((num ^ 474623245) % 4)
				{
				case 1:
					return;
				case 2:
					IL_33:
					base.SetProperty<string>(() => this.SearchQuery, value, new Action(this.OnSearchQueryChanged));
					num = 1769714001;
					goto IL_14;
				case 3:
					goto IL_0F;
				}
				this.RaisePropertyChanged("SearchQuery");
			}
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x0008DDF0 File Offset: 0x0008BFF0
		public BoxesReportViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.SetViewName("StoreBoxes");
			this.BoxStatuses = new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(0, Lang.t("All")),
				new KeyValuePair<int, string>(1, Lang.t("Busy")),
				new KeyValuePair<int, string>(2, Lang.t("PartialBusy")),
				new KeyValuePair<int, string>(3, Lang.t("Empty"))
			};
			this.Types = new List<IIdName>
			{
				new IdNameClass(0, Lang.t("All")),
				new IdNameClass(1, Lang.t("ForOrders")),
				new IdNameClass(2, Lang.t("ForGoods"))
			};
			this.Init();
			this.LoadData();
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0008DEEC File Offset: 0x0008C0EC
		private void OnSearchQueryChanged()
		{
			this.LoadData();
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x0008DF00 File Offset: 0x0008C100
		private void Init()
		{
			base.ShowWait();
			for (;;)
			{
				IL_5E:
				int num = 1623529467;
				for (;;)
				{
					switch ((num ^ 1510429799) % 3)
					{
					case 0:
						goto IL_5E;
					case 1:
						Task.Run<List<stores>>(() => StoreModel.LoadStores(false, true)).ContinueWith(delegate(Task<List<stores>> t)
						{
							this.Stores = t.Result;
							base.HideWait();
						});
						num = 1938604639;
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x0008DF74 File Offset: 0x0008C174
		public void LoadData()
		{
			BoxesReportViewModel.<LoadData>d__40 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<BoxesReportViewModel.<LoadData>d__40>(ref <LoadData>d__);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0008DFAC File Offset: 0x0008C1AC
		public static Task<IEnumerable<IBox>> GetBoxes(int storeId, int status, string query, int type)
		{
			BoxesReportViewModel.<GetBoxes>d__41 <GetBoxes>d__;
			<GetBoxes>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IBox>>.Create();
			<GetBoxes>d__.storeId = storeId;
			<GetBoxes>d__.status = status;
			<GetBoxes>d__.query = query;
			<GetBoxes>d__.type = type;
			<GetBoxes>d__.<>1__state = -1;
			<GetBoxes>d__.<>t__builder.Start<BoxesReportViewModel.<GetBoxes>d__41>(ref <GetBoxes>d__);
			return <GetBoxes>d__.<>t__builder.Task;
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0008E008 File Offset: 0x0008C208
		[Command]
		public void ItemClick()
		{
			BoxesReportViewModel.<ItemClick>d__42 <ItemClick>d__;
			<ItemClick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ItemClick>d__.<>4__this = this;
			<ItemClick>d__.<>1__state = -1;
			<ItemClick>d__.<>t__builder.Start<BoxesReportViewModel.<ItemClick>d__42>(ref <ItemClick>d__);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x0008E040 File Offset: 0x0008C240
		[Command]
		public void GoodsDoubleClick()
		{
			if (this.SelectedGoods == null)
			{
				return;
			}
			this._navigationService.NavigateToStoreItem(this.SelectedGoods.Id, 0);
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0008E078 File Offset: 0x0008C278
		[Command]
		public void RepairDoubleClick()
		{
			if (this.SelectedRepair != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = -762957298;
			IL_0D:
			switch ((num ^ -1931183613) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				this._navigationService.NavigateRepairCard(this.SelectedRepair.Id);
				num = -2004891695;
				goto IL_0D;
			}
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0008DEEC File Offset: 0x0008C0EC
		[Command]
		public void Refresh()
		{
			this.LoadData();
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x0008E0DC File Offset: 0x0008C2DC
		[Command]
		public void Cancel()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x0008E0F4 File Offset: 0x0008C2F4
		[Command]
		public void ColorChanged()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			bool response;
			if (response = base.SelectedItem.SaveColor())
			{
				base.SelectedItem = null;
			}
			base.ShowActionResponse(response, "");
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x0008E12C File Offset: 0x0008C32C
		[CompilerGenerated]
		private void <Init>b__39_1(Task<List<stores>> t)
		{
			this.Stores = t.Result;
			base.HideWait();
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x0008E14C File Offset: 0x0008C34C
		[CompilerGenerated]
		private Task<IEnumerable<IBox>> <LoadData>b__40_0()
		{
			return BoxesReportViewModel.GetBoxes(this.SelectedStore, this.SelectedStatus, this.SearchQuery, this.SelectedType);
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x0008E178 File Offset: 0x0008C378
		[CompilerGenerated]
		private void <ItemClick>b__42_0()
		{
			base.SelectedItem.LoadItems();
		}

		// Token: 0x040018A4 RID: 6308
		private readonly INavigationService _navigationService;

		// Token: 0x040018A5 RID: 6309
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040018A6 RID: 6310
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <BoxStatuses>k__BackingField;

		// Token: 0x040018A7 RID: 6311
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x040018A8 RID: 6312
		[CompilerGenerated]
		private int <SelectedStore>k__BackingField;

		// Token: 0x040018A9 RID: 6313
		[CompilerGenerated]
		private int <SelectedStatus>k__BackingField;

		// Token: 0x040018AA RID: 6314
		[CompilerGenerated]
		private IGoods <SelectedGoods>k__BackingField;

		// Token: 0x040018AB RID: 6315
		[CompilerGenerated]
		private IRepair <SelectedRepair>k__BackingField;

		// Token: 0x040018AC RID: 6316
		[CompilerGenerated]
		private List<IIdName> <Types>k__BackingField;

		// Token: 0x040018AD RID: 6317
		[CompilerGenerated]
		private int <SelectedType>k__BackingField;

		// Token: 0x02000466 RID: 1126
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002C6A RID: 11370 RVA: 0x0008E190 File Offset: 0x0008C390
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002C6B RID: 11371 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002C6C RID: 11372 RVA: 0x00089794 File Offset: 0x00087994
			internal Task<List<stores>> <Init>b__39_0()
			{
				return StoreModel.LoadStores(false, true);
			}

			// Token: 0x06002C6D RID: 11373 RVA: 0x0008E1A8 File Offset: 0x0008C3A8
			internal IBox <GetBoxes>b__41_0(boxes b)
			{
				return b.ToIBox();
			}

			// Token: 0x040018AE RID: 6318
			public static readonly BoxesReportViewModel.<>c <>9 = new BoxesReportViewModel.<>c();

			// Token: 0x040018AF RID: 6319
			public static Func<Task<List<stores>>> <>9__39_0;

			// Token: 0x040018B0 RID: 6320
			public static Func<boxes, IBox> <>9__41_0;
		}

		// Token: 0x02000467 RID: 1127
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__40 : IAsyncStateMachine
		{
			// Token: 0x06002C6E RID: 11374 RVA: 0x0008E1BC File Offset: 0x0008C3BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				BoxesReportViewModel boxesReportViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IBox>> awaiter;
					if (num != 0)
					{
						boxesReportViewModel.ShowWait();
						awaiter = Task.Run<IEnumerable<IBox>>(() => BoxesReportViewModel.GetBoxes(base.SelectedStore, base.SelectedStatus, base.SearchQuery, base.SelectedType)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IBox>>, BoxesReportViewModel.<LoadData>d__40>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IBox>>);
						this.<>1__state = -1;
					}
					IEnumerable<IBox> result = awaiter.GetResult();
					boxesReportViewModel.SetItems(result);
					boxesReportViewModel.HideWait();
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

			// Token: 0x06002C6F RID: 11375 RVA: 0x0008E290 File Offset: 0x0008C490
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018B1 RID: 6321
			public int <>1__state;

			// Token: 0x040018B2 RID: 6322
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040018B3 RID: 6323
			public BoxesReportViewModel <>4__this;

			// Token: 0x040018B4 RID: 6324
			private TaskAwaiter<IEnumerable<IBox>> <>u__1;
		}

		// Token: 0x02000468 RID: 1128
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06002C70 RID: 11376 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x040018B5 RID: 6325
			public int storeId;

			// Token: 0x040018B6 RID: 6326
			public string query;
		}

		// Token: 0x02000469 RID: 1129
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetBoxes>d__41 : IAsyncStateMachine
		{
			// Token: 0x06002C71 RID: 11377 RVA: 0x0008E2AC File Offset: 0x0008C4AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<IBox> result;
				try
				{
					BoxesReportViewModel.<>c__DisplayClass41_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new BoxesReportViewModel.<>c__DisplayClass41_0();
						CS$<>8__locals1.storeId = this.storeId;
						CS$<>8__locals1.query = this.query;
						this.<repo>5__2 = new GenericRepository<boxes>();
					}
					try
					{
						TaskAwaiter<IEnumerable<boxes>> awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							List<KeyValuePair<bool, Expression<Func<boxes, bool>>>> filterList = new List<KeyValuePair<bool, Expression<Func<boxes, bool>>>>
							{
								new KeyValuePair<bool, Expression<Func<boxes, bool>>>(CS$<>8__locals1.storeId != 0, (boxes b) => b.store_id == (int?)CS$<>8__locals1.storeId),
								new KeyValuePair<bool, Expression<Func<boxes, bool>>>(this.status == 1, (boxes b) => b.places != 0 && (b.store_items.Count >= b.places || b.workshop.Count >= b.places)),
								new KeyValuePair<bool, Expression<Func<boxes, bool>>>(this.status == 2, (boxes b) => (b.places == 0 && (b.store_items.Count > 0 || b.workshop.Count > 0)) || (b.store_items.Count < b.places && b.workshop.Count < b.places)),
								new KeyValuePair<bool, Expression<Func<boxes, bool>>>(this.status == 3, (boxes b) => b.store_items.Count == 0 && b.workshop.Count == 0),
								new KeyValuePair<bool, Expression<Func<boxes, bool>>>(this.type == 1, (boxes b) => b.non_items),
								new KeyValuePair<bool, Expression<Func<boxes, bool>>>(this.type == 2, (boxes b) => !b.non_items),
								new KeyValuePair<bool, Expression<Func<boxes, bool>>>(!string.IsNullOrEmpty(CS$<>8__locals1.query), (boxes b) => b.name.Contains(CS$<>8__locals1.query))
							};
							awaiter = this.<repo>5__2.GetAllAsync(filterList, null, "workshop,store_items", false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<boxes>>, BoxesReportViewModel.<GetBoxes>d__41>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<boxes>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<boxes, IBox>(BoxesReportViewModel.<>c.<>9.<GetBoxes>b__41_0)).ToList<IBox>();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06002C72 RID: 11378 RVA: 0x0008E958 File Offset: 0x0008CB58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018B7 RID: 6327
			public int <>1__state;

			// Token: 0x040018B8 RID: 6328
			public AsyncTaskMethodBuilder<IEnumerable<IBox>> <>t__builder;

			// Token: 0x040018B9 RID: 6329
			public int storeId;

			// Token: 0x040018BA RID: 6330
			public string query;

			// Token: 0x040018BB RID: 6331
			public int status;

			// Token: 0x040018BC RID: 6332
			public int type;

			// Token: 0x040018BD RID: 6333
			private GenericRepository<boxes> <repo>5__2;

			// Token: 0x040018BE RID: 6334
			private TaskAwaiter<IEnumerable<boxes>> <>u__1;
		}

		// Token: 0x0200046A RID: 1130
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ItemClick>d__42 : IAsyncStateMachine
		{
			// Token: 0x06002C73 RID: 11379 RVA: 0x0008E974 File Offset: 0x0008CB74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				BoxesReportViewModel boxesReportViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (boxesReportViewModel.SelectedItem == null)
						{
							goto IL_E9;
						}
						boxesReportViewModel.ShowWait();
						awaiter = Task.Run(delegate()
						{
							base.SelectedItem.LoadItems();
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, BoxesReportViewModel.<ItemClick>d__42>(ref awaiter, ref this);
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
					boxesReportViewModel.HideWait();
					if (boxesReportViewModel.SelectedItem is StoreBox)
					{
						boxesReportViewModel._windowedDocumentService.ShowNewDocument("BoxStoreView", boxesReportViewModel, null, null);
					}
					if (boxesReportViewModel.SelectedItem is WorkshopBox)
					{
						boxesReportViewModel._windowedDocumentService.ShowNewDocument("BoxRepairView", boxesReportViewModel, null, null);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_E9:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002C74 RID: 11380 RVA: 0x0008EA90 File Offset: 0x0008CC90
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040018BF RID: 6335
			public int <>1__state;

			// Token: 0x040018C0 RID: 6336
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040018C1 RID: 6337
			public BoxesReportViewModel <>4__this;

			// Token: 0x040018C2 RID: 6338
			private TaskAwaiter <>u__1;
		}
	}
}
