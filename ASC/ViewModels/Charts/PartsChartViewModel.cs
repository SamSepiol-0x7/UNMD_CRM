using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Objects;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.Charts
{
	// Token: 0x0200053A RID: 1338
	public class PartsChartViewModel : BaseViewModel
	{
		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x000A65DC File Offset: 0x000A47DC
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x000A65F0 File Offset: 0x000A47F0
		public List<KeyValuePair<string, int>> ChartData
		{
			[CompilerGenerated]
			get
			{
				return this.<ChartData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ChartData>k__BackingField, value))
				{
					return;
				}
				this.<ChartData>k__BackingField = value;
				this.RaisePropertyChanged("ChartData");
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x000A6620 File Offset: 0x000A4820
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x000A6634 File Offset: 0x000A4834
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
				int num = 587176579;
				IL_13:
				switch ((num ^ 1142025106) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					this.<Stores>k__BackingField = value;
					this.RaisePropertyChanged("Stores");
					num = 523026294;
					goto IL_13;
				}
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x000A6690 File Offset: 0x000A4890
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x000A66A4 File Offset: 0x000A48A4
		public int SelectedStore
		{
			get
			{
				return this._selectedStore;
			}
			set
			{
				if (this._selectedStore == value)
				{
					return;
				}
				this._selectedStore = value;
				this.RaisePropertyChanged("SelectedStore");
				this.GenerateReport();
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x000A66D8 File Offset: 0x000A48D8
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x000A66EC File Offset: 0x000A48EC
		public int TotalItems
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalItems>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<TotalItems>k__BackingField == value)
				{
					return;
				}
				this.<TotalItems>k__BackingField = value;
				this.RaisePropertyChanged("TotalItems");
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000A6718 File Offset: 0x000A4918
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x000A672C File Offset: 0x000A492C
		public decimal TotalInSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalInSumm>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<TotalInSumm>k__BackingField, value))
				{
					return;
				}
				this.<TotalInSumm>k__BackingField = value;
				this.RaisePropertyChanged("TotalInSumm");
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x000A675C File Offset: 0x000A495C
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x000A6770 File Offset: 0x000A4970
		public decimal TotalOutSummPrice2
		{
			[CompilerGenerated]
			get
			{
				return this.<TotalOutSummPrice2>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<TotalOutSummPrice2>k__BackingField, value))
				{
					return;
				}
				this.<TotalOutSummPrice2>k__BackingField = value;
				this.RaisePropertyChanged("TotalOutSummPrice2");
			}
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000A67A0 File Offset: 0x000A49A0
		public PartsChartViewModel()
		{
			this.SetViewName("PartsChart");
			this.SelectedStore = OfflineData.Instance.Employee.StoreDefault;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000A67E0 File Offset: 0x000A49E0
		private void LoadStores()
		{
			Task.Run<List<stores>>(() => StoreModel.LoadStores(true, false)).ContinueWith(delegate(Task<List<stores>> t)
			{
				this.Stores = t.Result;
				if (this.Stores.Count((stores s) => s.id != 0) == 1)
				{
					stores stores = this.Stores.FirstOrDefault((stores s) => s.id != 0);
					if (stores != null)
					{
						this.SelectedStore = stores.id;
					}
				}
			});
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000A6824 File Offset: 0x000A4A24
		[Command]
		public void Refresh()
		{
			this.GenerateReport();
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000A6838 File Offset: 0x000A4A38
		private void GenerateReport()
		{
			PartsChartViewModel.<GenerateReport>d__28 <GenerateReport>d__;
			<GenerateReport>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GenerateReport>d__.<>4__this = this;
			<GenerateReport>d__.<>1__state = -1;
			<GenerateReport>d__.<>t__builder.Start<PartsChartViewModel.<GenerateReport>d__28>(ref <GenerateReport>d__);
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000A6870 File Offset: 0x000A4A70
		public override void OnLoad()
		{
			base.OnLoad();
			this.LoadStores();
			this.GenerateReport();
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000A6890 File Offset: 0x000A4A90
		[CompilerGenerated]
		private void <LoadStores>b__26_1(Task<List<stores>> t)
		{
			this.Stores = t.Result;
			if (this.Stores.Count((stores s) => s.id != 0) == 1)
			{
				stores stores = this.Stores.FirstOrDefault((stores s) => s.id != 0);
				if (stores != null)
				{
					this.SelectedStore = stores.id;
				}
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000A6910 File Offset: 0x000A4B10
		[CompilerGenerated]
		private Task<int> <GenerateReport>b__28_0()
		{
			return this._partsChartModel.CountTotalParts(this.SelectedStore);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000A6930 File Offset: 0x000A4B30
		[CompilerGenerated]
		private Task<decimal> <GenerateReport>b__28_1()
		{
			return this._partsChartModel.CountTotalInSumm(this.SelectedStore);
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000A6950 File Offset: 0x000A4B50
		[CompilerGenerated]
		private Task<decimal> <GenerateReport>b__28_2()
		{
			return this._partsChartModel.CountTotalOutSummPrice2(this.SelectedStore);
		}

		// Token: 0x04001C8F RID: 7311
		private ChartModel _partsChartModel = new ChartModel();

		// Token: 0x04001C90 RID: 7312
		private int _selectedStore;

		// Token: 0x04001C91 RID: 7313
		[CompilerGenerated]
		private List<KeyValuePair<string, int>> <ChartData>k__BackingField;

		// Token: 0x04001C92 RID: 7314
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x04001C93 RID: 7315
		[CompilerGenerated]
		private int <TotalItems>k__BackingField;

		// Token: 0x04001C94 RID: 7316
		[CompilerGenerated]
		private decimal <TotalInSumm>k__BackingField;

		// Token: 0x04001C95 RID: 7317
		[CompilerGenerated]
		private decimal <TotalOutSummPrice2>k__BackingField;

		// Token: 0x0200053B RID: 1339
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060031DF RID: 12767 RVA: 0x000A6970 File Offset: 0x000A4B70
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060031E0 RID: 12768 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060031E1 RID: 12769 RVA: 0x000A6988 File Offset: 0x000A4B88
			internal Task<List<stores>> <LoadStores>b__26_0()
			{
				return StoreModel.LoadStores(true, false);
			}

			// Token: 0x060031E2 RID: 12770 RVA: 0x000A699C File Offset: 0x000A4B9C
			internal bool <LoadStores>b__26_2(stores s)
			{
				return s.id != 0;
			}

			// Token: 0x060031E3 RID: 12771 RVA: 0x000A699C File Offset: 0x000A4B9C
			internal bool <LoadStores>b__26_3(stores s)
			{
				return s.id != 0;
			}

			// Token: 0x04001C96 RID: 7318
			public static readonly PartsChartViewModel.<>c <>9 = new PartsChartViewModel.<>c();

			// Token: 0x04001C97 RID: 7319
			public static Func<Task<List<stores>>> <>9__26_0;

			// Token: 0x04001C98 RID: 7320
			public static Func<stores, bool> <>9__26_2;

			// Token: 0x04001C99 RID: 7321
			public static Func<stores, bool> <>9__26_3;
		}

		// Token: 0x0200053C RID: 1340
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GenerateReport>d__28 : IAsyncStateMachine
		{
			// Token: 0x060031E4 RID: 12772 RVA: 0x000A69B4 File Offset: 0x000A4BB4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsChartViewModel partsChartViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					TaskAwaiter<decimal> awaiter2;
					TaskAwaiter<List<KeyValuePair<string, int>>> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_107;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_17A;
					case 3:
						awaiter3 = this.<>u__3;
						this.<>u__3 = default(TaskAwaiter<List<KeyValuePair<string, int>>>);
						this.<>1__state = -1;
						goto IL_1EA;
					default:
						if (partsChartViewModel.SelectedStore == 0)
						{
							goto IL_21C;
						}
						partsChartViewModel.ShowWait();
						awaiter = Task.Run<int>(() => partsChartViewModel._partsChartModel.CountTotalParts(base.SelectedStore)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PartsChartViewModel.<GenerateReport>d__28>(ref awaiter, ref this);
							return;
						}
						break;
					}
					int result = awaiter.GetResult();
					partsChartViewModel.TotalItems = result;
					awaiter2 = Task.Run<decimal>(() => partsChartViewModel._partsChartModel.CountTotalInSumm(base.SelectedStore)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, PartsChartViewModel.<GenerateReport>d__28>(ref awaiter2, ref this);
						return;
					}
					IL_107:
					decimal result2 = awaiter2.GetResult();
					partsChartViewModel.TotalInSumm = result2;
					awaiter2 = Task.Run<decimal>(() => partsChartViewModel._partsChartModel.CountTotalOutSummPrice2(base.SelectedStore)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, PartsChartViewModel.<GenerateReport>d__28>(ref awaiter2, ref this);
						return;
					}
					IL_17A:
					result2 = awaiter2.GetResult();
					partsChartViewModel.TotalOutSummPrice2 = result2;
					awaiter3 = partsChartViewModel._partsChartModel.LoadPartsChartData(partsChartViewModel.SelectedStore).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__3 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<KeyValuePair<string, int>>>, PartsChartViewModel.<GenerateReport>d__28>(ref awaiter3, ref this);
						return;
					}
					IL_1EA:
					List<KeyValuePair<string, int>> result3 = awaiter3.GetResult();
					partsChartViewModel.ChartData = result3;
					partsChartViewModel.HideWait();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_21C:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060031E5 RID: 12773 RVA: 0x000A6C0C File Offset: 0x000A4E0C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001C9A RID: 7322
			public int <>1__state;

			// Token: 0x04001C9B RID: 7323
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001C9C RID: 7324
			public PartsChartViewModel <>4__this;

			// Token: 0x04001C9D RID: 7325
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04001C9E RID: 7326
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x04001C9F RID: 7327
			private TaskAwaiter<List<KeyValuePair<string, int>>> <>u__3;
		}
	}
}
