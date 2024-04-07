using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Objects;
using ASC.Properties;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.Stickers
{
	// Token: 0x020001F1 RID: 497
	public class StickersViewModel : BaseViewModel
	{
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x000507D0 File Offset: 0x0004E9D0
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x000507E8 File Offset: 0x0004E9E8
		public List<KeyValuePair<string, string>> Variants
		{
			get
			{
				return this._stickersModel.Variants;
			}
			set
			{
				if (object.Equals(this.Variants, value))
				{
					return;
				}
				this._stickersModel.Variants = value;
				this.RaisePropertyChanged("Variants");
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0005081C File Offset: 0x0004EA1C
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x00050830 File Offset: 0x0004EA30
		public ObservableCollection<store_items> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Items>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -714532731;
				IL_13:
				switch ((num ^ -848910316) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<Items>k__BackingField = value;
					num = -286175428;
					goto IL_13;
				}
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0005088C File Offset: 0x0004EA8C
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x000508A0 File Offset: 0x0004EAA0
		public int Copies
		{
			get
			{
				return this._copies;
			}
			set
			{
				if (this._copies == value)
				{
					return;
				}
				this._copies = value;
				this.RaisePropertyChanged("Copies");
				this.CountTotal();
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000508D4 File Offset: 0x0004EAD4
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00050918 File Offset: 0x0004EB18
		public string SelectedVariant
		{
			get
			{
				return base.GetProperty<string>(() => this.SelectedVariant);
			}
			set
			{
				if (string.Equals(this.SelectedVariant, value, StringComparison.Ordinal))
				{
					return;
				}
				base.SetProperty<string>(() => this.SelectedVariant, value, new Action(this.OnVariantChanged));
				this.RaisePropertyChanged("SelectedVariant");
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00050984 File Offset: 0x0004EB84
		private void OnVariantChanged()
		{
			Settings.Default.StickerVariant = this.SelectedVariant;
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x000509A4 File Offset: 0x0004EBA4
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x000509B8 File Offset: 0x0004EBB8
		public int TotalStickers
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalStickers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TotalStickers>k__BackingField == value)
				{
					return;
				}
				this.<TotalStickers>k__BackingField = value;
				this.RaisePropertyChanged("TotalStickers");
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000509E4 File Offset: 0x0004EBE4
		public StickersViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
			this.SetViewName("PrintStickers");
			if (!string.IsNullOrEmpty(Settings.Default.StickerVariant))
			{
				this.SelectedVariant = Settings.Default.StickerVariant;
			}
			this.Items = new ObservableCollection<store_items>();
			this.Items.CollectionChanged += this.ItemsOnCollectionChanged;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00050A80 File Offset: 0x0004EC80
		public StickersViewModel(List<int> itemIds) : this()
		{
			this.SetViewName("PrintStickers");
			this.LoadItems(itemIds);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		private void LoadItems(List<int> itemIds)
		{
			StickersViewModel.<LoadItems>d__25 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.itemIds = itemIds;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<StickersViewModel.<LoadItems>d__25>(ref <LoadItems>d__);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x000407D8 File Offset: 0x0003E9D8
		[Command]
		public void Unloaded(object obj)
		{
			Settings.Default.Save();
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00050AE8 File Offset: 0x0004ECE8
		[Command]
		public void PrintStickers(object obj)
		{
			StickersViewModel.<PrintStickers>d__27 <PrintStickers>d__;
			<PrintStickers>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintStickers>d__.<>4__this = this;
			<PrintStickers>d__.<>1__state = -1;
			<PrintStickers>d__.<>t__builder.Start<StickersViewModel.<PrintStickers>d__27>(ref <PrintStickers>d__);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00050B20 File Offset: 0x0004ED20
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00050B38 File Offset: 0x0004ED38
		private bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.SelectedVariant))
			{
				this._toasterService.Info(Lang.t("SelectStickerVariant"));
				return false;
			}
			return true;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00050B6C File Offset: 0x0004ED6C
		private void ItemsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Remove)
			{
				using (IEnumerator enumerator = e.OldItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						((store_items)obj).PropertyChanged -= this.EntityViewModelPropertyChanged;
					}
					return;
				}
			}
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				foreach (object obj2 in e.NewItems)
				{
					((store_items)obj2).PropertyChanged += this.EntityViewModelPropertyChanged;
				}
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00050C34 File Offset: 0x0004EE34
		public void EntityViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			this.CountTotal();
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00050C48 File Offset: 0x0004EE48
		private void CountTotal()
		{
			if (this.Copies > 0)
			{
				goto IL_66;
			}
			goto IL_DE;
			int num;
			for (;;)
			{
				IL_AC:
				switch ((num ^ -1710973068) % 5)
				{
				case 0:
					goto IL_DE;
				case 1:
					this.TotalStickers = (from i in this.Items
					select i.Available).DefaultIfEmpty<int>().Sum();
					num = -1507290237;
					continue;
				case 2:
					goto IL_66;
				case 4:
					this.TotalStickers = (from i in this.Items
					select i.BuyCount).DefaultIfEmpty<int>().Sum() * this.Copies;
					num = -1925847825;
					continue;
				}
				break;
			}
			return;
			IL_66:
			num = -1540675394;
			goto IL_AC;
			IL_DE:
			num = ((this.Copies == 0) ? -1088188027 : -1507290237);
			goto IL_AC;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00050D40 File Offset: 0x0004EF40
		[CompilerGenerated]
		private XtraReport <PrintStickers>b__27_0()
		{
			return StoreDocument.CreateStickers(this.Items, this.SelectedVariant, this.Copies);
		}

		// Token: 0x04000E49 RID: 3657
		private readonly IToasterService _toasterService;

		// Token: 0x04000E4A RID: 3658
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04000E4B RID: 3659
		private StickersModel _stickersModel = new StickersModel();

		// Token: 0x04000E4C RID: 3660
		private int _copies;

		// Token: 0x04000E4D RID: 3661
		private IReportPrintService _reportPrintService;

		// Token: 0x04000E4E RID: 3662
		[CompilerGenerated]
		private ObservableCollection<store_items> <Items>k__BackingField;

		// Token: 0x04000E4F RID: 3663
		[CompilerGenerated]
		private int <TotalStickers>k__BackingField;

		// Token: 0x020001F2 RID: 498
		[CompilerGenerated]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x06001B48 RID: 6984 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x06001B49 RID: 6985 RVA: 0x00050D64 File Offset: 0x0004EF64
			internal Task<IEnumerable<store_items>> <LoadItems>b__0()
			{
				return ItemsModel.LoadItems(this.itemIds);
			}

			// Token: 0x04000E50 RID: 3664
			public List<int> itemIds;
		}

		// Token: 0x020001F3 RID: 499
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__25 : IAsyncStateMachine
		{
			// Token: 0x06001B4A RID: 6986 RVA: 0x00050D7C File Offset: 0x0004EF7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StickersViewModel stickersViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<store_items>> awaiter;
					if (num != 0)
					{
						StickersViewModel.<>c__DisplayClass25_0 CS$<>8__locals1 = new StickersViewModel.<>c__DisplayClass25_0();
						CS$<>8__locals1.itemIds = this.itemIds;
						stickersViewModel.ShowWait();
						awaiter = Task.Run<IEnumerable<store_items>>(new Func<Task<IEnumerable<store_items>>>(CS$<>8__locals1.<LoadItems>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_items>>, StickersViewModel.<LoadItems>d__25>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<store_items>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					List<store_items>.Enumerator enumerator = new List<store_items>(awaiter.GetResult()).GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							store_items item = enumerator.Current;
							stickersViewModel.Items.Add(item);
							stickersViewModel.CountTotal();
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					stickersViewModel.HideWait();
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

			// Token: 0x06001B4B RID: 6987 RVA: 0x00050EB0 File Offset: 0x0004F0B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000E51 RID: 3665
			public int <>1__state;

			// Token: 0x04000E52 RID: 3666
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000E53 RID: 3667
			public List<int> itemIds;

			// Token: 0x04000E54 RID: 3668
			public StickersViewModel <>4__this;

			// Token: 0x04000E55 RID: 3669
			private TaskAwaiter<IEnumerable<store_items>> <>u__1;
		}

		// Token: 0x020001F4 RID: 500
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintStickers>d__27 : IAsyncStateMachine
		{
			// Token: 0x06001B4C RID: 6988 RVA: 0x00050ECC File Offset: 0x0004F0CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				StickersViewModel stickersViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					if (num != 0)
					{
						if (!stickersViewModel.CheckFields())
						{
							goto IL_D0;
						}
						stickersViewModel.ShowWait();
						awaiter = Task.Run<XtraReport>(() => StoreDocument.CreateStickers(base.Items, base.SelectedVariant, base.Copies)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, StickersViewModel.<PrintStickers>d__27>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<XtraReport>);
						this.<>1__state = -1;
					}
					XtraReport result = awaiter.GetResult();
					stickersViewModel.HideWait();
					PrinterModel.Printer printer = stickersViewModel.SelectedVariant.Contains("price") ? PrinterModel.Printer.PriceTag : PrinterModel.Printer.Stickers;
					stickersViewModel._reportPrintService.PrintPreview(result, printer);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_D0:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06001B4D RID: 6989 RVA: 0x00050FCC File Offset: 0x0004F1CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000E56 RID: 3670
			public int <>1__state;

			// Token: 0x04000E57 RID: 3671
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000E58 RID: 3672
			public StickersViewModel <>4__this;

			// Token: 0x04000E59 RID: 3673
			private TaskAwaiter<XtraReport> <>u__1;
		}

		// Token: 0x020001F5 RID: 501
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001B4E RID: 6990 RVA: 0x00050FE8 File Offset: 0x0004F1E8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001B4F RID: 6991 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001B50 RID: 6992 RVA: 0x0004B824 File Offset: 0x00049A24
			internal int <CountTotal>b__32_0(store_items i)
			{
				return i.BuyCount;
			}

			// Token: 0x06001B51 RID: 6993 RVA: 0x00051000 File Offset: 0x0004F200
			internal int <CountTotal>b__32_1(store_items i)
			{
				return i.Available;
			}

			// Token: 0x04000E5A RID: 3674
			public static readonly StickersViewModel.<>c <>9 = new StickersViewModel.<>c();

			// Token: 0x04000E5B RID: 3675
			public static Func<store_items, int> <>9__32_0;

			// Token: 0x04000E5C RID: 3676
			public static Func<store_items, int> <>9__32_1;
		}
	}
}
