using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using ASC.ArticulSearch;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Services.Abstract;
using ASC.SimpleClasses;

namespace ASC.ViewModels
{
	// Token: 0x020003B4 RID: 948
	public class CartringeArticulSearchViewModel : ArticulSearchViewModel
	{
		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x00079548 File Offset: 0x00077748
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x0007955C File Offset: 0x0007775C
		public int InsertIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<InsertIndex>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<InsertIndex>k__BackingField == value)
				{
					return;
				}
				this.<InsertIndex>k__BackingField = value;
				this.RaisePropertyChanged("InsertIndex");
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00079588 File Offset: 0x00077788
		public CartringeArticulSearchViewModel(IStoreService storeService, IWindowedDocumentService windowedDocumentService) : base(storeService, windowedDocumentService)
		{
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000795A0 File Offset: 0x000777A0
		public void SetInsertIndex(int index)
		{
			this.InsertIndex = index;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000795B4 File Offset: 0x000777B4
		protected override void ReturnAndClose()
		{
			IArticulSearch parentViewModel = this._parentViewModel;
			if (parentViewModel != null)
			{
				parentViewModel.InsertSearchItem(this.InsertIndex, base.SelectedItem, base.Name, base.Articul, base.Category, base.State);
			}
			base.ReturnAndClose();
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000795FC File Offset: 0x000777FC
		protected override void Search()
		{
			CartringeArticulSearchViewModel.<Search>d__7 <Search>d__;
			<Search>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Search>d__.<>4__this = this;
			<Search>d__.<>1__state = -1;
			<Search>d__.<>t__builder.Start<CartringeArticulSearchViewModel.<Search>d__7>(ref <Search>d__);
		}

		// Token: 0x0400158B RID: 5515
		[CompilerGenerated]
		private int <InsertIndex>k__BackingField;

		// Token: 0x020003B5 RID: 949
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060027AB RID: 10155 RVA: 0x00079634 File Offset: 0x00077834
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060027AC RID: 10156 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060027AD RID: 10157 RVA: 0x0007964C File Offset: 0x0007784C
			internal <>f__AnonymousType6<int, string, int> <Search>b__7_0(ArticulSearchLite i)
			{
				return new
				{
					i.Articul,
					i.Name,
					i.State
				};
			}

			// Token: 0x060027AE RID: 10158 RVA: 0x00079670 File Offset: 0x00077870
			internal ArticulSearchLite <Search>b__7_1(IGrouping<<>f__AnonymousType6<int, string, int>, ArticulSearchLite> i)
			{
				return i.First<ArticulSearchLite>();
			}

			// Token: 0x0400158C RID: 5516
			public static readonly CartringeArticulSearchViewModel.<>c <>9 = new CartringeArticulSearchViewModel.<>c();

			// Token: 0x0400158D RID: 5517
			public static Func<ArticulSearchLite, <>f__AnonymousType6<int, string, int>> <>9__7_0;

			// Token: 0x0400158E RID: 5518
			public static Func<IGrouping<<>f__AnonymousType6<int, string, int>, ArticulSearchLite>, ArticulSearchLite> <>9__7_1;
		}

		// Token: 0x020003B6 RID: 950
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Search>d__7 : IAsyncStateMachine
		{
			// Token: 0x060027AF RID: 10159 RVA: 0x00079684 File Offset: 0x00077884
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartringeArticulSearchViewModel cartringeArticulSearchViewModel = this.<>4__this;
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
							goto IL_120;
						}
						if (string.IsNullOrEmpty(cartringeArticulSearchViewModel.Name))
						{
							ObservableCollection<ArticulSearchLite> items = cartringeArticulSearchViewModel.Items;
							if (items != null)
							{
								items.Clear();
							}
							goto IL_271;
						}
						if (cartringeArticulSearchViewModel.Name.Length < 2)
						{
							goto IL_271;
						}
						cartringeArticulSearchViewModel.ShowWait();
						awaiter2 = cartringeArticulSearchViewModel._storeService.SearchSKU(cartringeArticulSearchViewModel.Name).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.<>1__state = num3;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<int>>, CartringeArticulSearchViewModel.<Search>d__7>(ref awaiter2, ref this);
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
					awaiter = cartringeArticulSearchViewModel._storeService.GetProductsBySKU(result).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 1;
						num = 1;
						this.<>1__state = num5;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IList<ArticulSearchLite>>, CartringeArticulSearchViewModel.<Search>d__7>(ref awaiter, ref this);
						return;
					}
					IL_120:
					IList<ArticulSearchLite> result2 = awaiter.GetResult();
					cartringeArticulSearchViewModel.HideWait();
					IEnumerator<ArticulSearchLite> enumerator = result2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ArticulSearchLite articulSearchLite = enumerator.Current;
							if (!cartringeArticulSearchViewModel.IncludePn)
							{
								articulSearchLite.PartNumber = "";
							}
							if (!cartringeArticulSearchViewModel.IncludeDescription)
							{
								articulSearchLite.Description = "";
							}
							if (!cartringeArticulSearchViewModel.IncludePrice)
							{
								articulSearchLite.Price = 0m;
							}
							if (!cartringeArticulSearchViewModel.IncludePriceOpt)
							{
								articulSearchLite.PriceOpt = 0m;
							}
							if (!cartringeArticulSearchViewModel.IncludePriceOpt2)
							{
								articulSearchLite.PriceOpt2 = 0m;
							}
							if (!cartringeArticulSearchViewModel.IncludePriceOpt3)
							{
								articulSearchLite.PriceOpt3 = 0m;
							}
							if (!cartringeArticulSearchViewModel.IncludePrice4Sc)
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
					cartringeArticulSearchViewModel.SetItems(result2.GroupBy(new Func<ArticulSearchLite, <>f__AnonymousType6<int, string, int>>(CartringeArticulSearchViewModel.<>c.<>9.<Search>b__7_0)).Select(new Func<IGrouping<<>f__AnonymousType6<int, string, int>, ArticulSearchLite>, ArticulSearchLite>(CartringeArticulSearchViewModel.<>c.<>9.<Search>b__7_1)));
					cartringeArticulSearchViewModel.PasteNew = ((cartringeArticulSearchViewModel.Items.Count > 0) ? Visibility.Hidden : Visibility.Visible);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_271:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060027B0 RID: 10160 RVA: 0x0007994C File Offset: 0x00077B4C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400158F RID: 5519
			public int <>1__state;

			// Token: 0x04001590 RID: 5520
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001591 RID: 5521
			public CartringeArticulSearchViewModel <>4__this;

			// Token: 0x04001592 RID: 5522
			private TaskAwaiter<IList<int>> <>u__1;

			// Token: 0x04001593 RID: 5523
			private TaskAwaiter<IList<ArticulSearchLite>> <>u__2;
		}
	}
}
