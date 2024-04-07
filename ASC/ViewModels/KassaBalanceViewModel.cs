using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Kassa;
using ASC.Objects;
using ASC.Services;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020003C3 RID: 963
	public class KassaBalanceViewModel : BaseViewModel, IRefreshable
	{
		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x0007B808 File Offset: 0x00079A08
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x0007B81C File Offset: 0x00079A1C
		public bool IsBuzy
		{
			[CompilerGenerated]
			get
			{
				return this.<IsBuzy>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsBuzy>k__BackingField == value)
				{
					return;
				}
				this.<IsBuzy>k__BackingField = value;
				this.RaisePropertyChanged("IsBuzy");
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x0007B848 File Offset: 0x00079A48
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x0007B85C File Offset: 0x00079A5C
		public decimal Cash
		{
			[CompilerGenerated]
			get
			{
				return this.<Cash>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<Cash>k__BackingField, value))
				{
					return;
				}
				this.<Cash>k__BackingField = value;
				this.RaisePropertyChanged("Cash");
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x0007B88C File Offset: 0x00079A8C
		// (set) Token: 0x06002807 RID: 10247 RVA: 0x0007B8A0 File Offset: 0x00079AA0
		public decimal CashLess
		{
			[CompilerGenerated]
			get
			{
				return this.<CashLess>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<CashLess>k__BackingField, value))
				{
					return;
				}
				this.<CashLess>k__BackingField = value;
				this.RaisePropertyChanged("CashLess");
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x0007B8D0 File Offset: 0x00079AD0
		// (set) Token: 0x06002809 RID: 10249 RVA: 0x0007B8E4 File Offset: 0x00079AE4
		public decimal Card
		{
			[CompilerGenerated]
			get
			{
				return this.<Card>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (decimal.Equals(this.<Card>k__BackingField, value))
				{
					return;
				}
				this.<Card>k__BackingField = value;
				this.RaisePropertyChanged("Card");
			}
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x0007B914 File Offset: 0x00079B14
		public KassaBalanceViewModel(IKassaService kassaService, IToasterService toasterService, IWindowedDocumentService windowedDocumentService)
		{
			this._kassaService = kassaService;
			this._toasterService = toasterService;
			this._windowedDocumentService = windowedDocumentService;
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x0007B93C File Offset: 0x00079B3C
		private Task LoadData()
		{
			KassaBalanceViewModel.<LoadData>d__21 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<KassaBalanceViewModel.<LoadData>d__21>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x0007B980 File Offset: 0x00079B80
		[Command]
		public override void OnLoad()
		{
			KassaBalanceViewModel.<OnLoad>d__22 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<KassaBalanceViewModel.<OnLoad>d__22>(ref <OnLoad>d__);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x0007B9B8 File Offset: 0x00079BB8
		private void FilterChangedHandler(object sender, EventArgs e)
		{
			KassaBalanceViewModel.<FilterChangedHandler>d__23 <FilterChangedHandler>d__;
			<FilterChangedHandler>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FilterChangedHandler>d__.<>4__this = this;
			<FilterChangedHandler>d__.<>1__state = -1;
			<FilterChangedHandler>d__.<>t__builder.Start<KassaBalanceViewModel.<FilterChangedHandler>d__23>(ref <FilterChangedHandler>d__);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x0007B9F0 File Offset: 0x00079BF0
		[Command]
		public override void OnUnload()
		{
			if (this._parentViewModel != null)
			{
				KassaViewModel parentViewModel = this._parentViewModel;
				parentViewModel.FilterChangedHandler = (EventHandler)Delegate.Remove(parentViewModel.FilterChangedHandler, new EventHandler(this.FilterChangedHandler));
			}
			base.OnUnload();
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0007BA34 File Offset: 0x00079C34
		protected override void OnParentViewModelChanged(object obj)
		{
			this._parentViewModel = (obj as KassaViewModel);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0007BA50 File Offset: 0x00079C50
		[Command]
		public void WithdrawFunds()
		{
			WithdrawFundsViewModel viewModel = Bootstrapper.Container.Resolve<WithdrawFundsViewModel>();
			this._windowedDocumentService.ShowNewDocument("ASC.View.WithdrawFundsView", viewModel, this, null);
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x0007BA7C File Offset: 0x00079C7C
		public bool CanWithdrawFunds()
		{
			return OfflineData.Instance.Employee.Can(18, 0);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x0007BA9C File Offset: 0x00079C9C
		public void DataRefresh()
		{
			KassaBalanceViewModel.<DataRefresh>d__28 <DataRefresh>d__;
			<DataRefresh>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DataRefresh>d__.<>4__this = this;
			<DataRefresh>d__.<>1__state = -1;
			<DataRefresh>d__.<>t__builder.Start<KassaBalanceViewModel.<DataRefresh>d__28>(ref <DataRefresh>d__);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0007BAD4 File Offset: 0x00079CD4
		[CompilerGenerated]
		private Task<decimal> <LoadData>b__21_0()
		{
			return this._kassaService.GetCashBalanceAsync(this._parentViewModel.Period, this._parentViewModel.SelectedCompany, this._parentViewModel.SelectedOffice);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0007BB10 File Offset: 0x00079D10
		[CompilerGenerated]
		private Task<decimal> <LoadData>b__21_1()
		{
			return this._kassaService.GetCashLessBalanceAsync(this._parentViewModel.Period, this._parentViewModel.SelectedCompany, this._parentViewModel.SelectedOffice);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0007BB4C File Offset: 0x00079D4C
		[CompilerGenerated]
		private Task<decimal> <LoadData>b__21_2()
		{
			return this._kassaService.GetCardBalanceAsync(this._parentViewModel.Period, this._parentViewModel.SelectedCompany, this._parentViewModel.SelectedOffice);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x040015E0 RID: 5600
		private readonly IToasterService _toasterService;

		// Token: 0x040015E1 RID: 5601
		private readonly IKassaService _kassaService;

		// Token: 0x040015E2 RID: 5602
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040015E3 RID: 5603
		private KassaViewModel _parentViewModel;

		// Token: 0x040015E4 RID: 5604
		[CompilerGenerated]
		private bool <IsBuzy>k__BackingField;

		// Token: 0x040015E5 RID: 5605
		[CompilerGenerated]
		private decimal <Cash>k__BackingField;

		// Token: 0x040015E6 RID: 5606
		[CompilerGenerated]
		private decimal <CashLess>k__BackingField;

		// Token: 0x040015E7 RID: 5607
		[CompilerGenerated]
		private decimal <Card>k__BackingField;

		// Token: 0x020003C4 RID: 964
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__21 : IAsyncStateMachine
		{
			// Token: 0x06002817 RID: 10263 RVA: 0x0007BB88 File Offset: 0x00079D88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaBalanceViewModel kassaBalanceViewModel = this.<>4__this;
				try
				{
					if (num > 2)
					{
						kassaBalanceViewModel.IsBuzy = true;
					}
					try
					{
						TaskAwaiter<decimal> awaiter;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_F9;
						}
						case 2:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<decimal>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_164;
						}
						default:
							awaiter = Task.Run<decimal>(() => kassaBalanceViewModel._kassaService.GetCashBalanceAsync(kassaBalanceViewModel._parentViewModel.Period, kassaBalanceViewModel._parentViewModel.SelectedCompany, kassaBalanceViewModel._parentViewModel.SelectedOffice)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaBalanceViewModel.<LoadData>d__21>(ref awaiter, ref this);
								return;
							}
							break;
						}
						decimal result = awaiter.GetResult();
						kassaBalanceViewModel.Cash = result;
						awaiter = Task.Run<decimal>(() => kassaBalanceViewModel._kassaService.GetCashLessBalanceAsync(kassaBalanceViewModel._parentViewModel.Period, kassaBalanceViewModel._parentViewModel.SelectedCompany, kassaBalanceViewModel._parentViewModel.SelectedOffice)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaBalanceViewModel.<LoadData>d__21>(ref awaiter, ref this);
							return;
						}
						IL_F9:
						result = awaiter.GetResult();
						kassaBalanceViewModel.CashLess = result;
						awaiter = Task.Run<decimal>(() => kassaBalanceViewModel._kassaService.GetCardBalanceAsync(kassaBalanceViewModel._parentViewModel.Period, kassaBalanceViewModel._parentViewModel.SelectedCompany, kassaBalanceViewModel._parentViewModel.SelectedOffice)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, KassaBalanceViewModel.<LoadData>d__21>(ref awaiter, ref this);
							return;
						}
						IL_164:
						result = awaiter.GetResult();
						kassaBalanceViewModel.Card = result;
					}
					catch (Exception ex)
					{
						kassaBalanceViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							kassaBalanceViewModel.IsBuzy = false;
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
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002818 RID: 10264 RVA: 0x0007BDA8 File Offset: 0x00079FA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015E8 RID: 5608
			public int <>1__state;

			// Token: 0x040015E9 RID: 5609
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040015EA RID: 5610
			public KassaBalanceViewModel <>4__this;

			// Token: 0x040015EB RID: 5611
			private TaskAwaiter<decimal> <>u__1;
		}

		// Token: 0x020003C5 RID: 965
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__22 : IAsyncStateMachine
		{
			// Token: 0x06002819 RID: 10265 RVA: 0x0007BDC4 File Offset: 0x00079FC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaBalanceViewModel kassaBalanceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (kassaBalanceViewModel._parentViewModel != null)
						{
							KassaViewModel parentViewModel = kassaBalanceViewModel._parentViewModel;
							parentViewModel.FilterChangedHandler = (EventHandler)Delegate.Combine(parentViewModel.FilterChangedHandler, new EventHandler(kassaBalanceViewModel.FilterChangedHandler));
						}
						awaiter = kassaBalanceViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaBalanceViewModel.<OnLoad>d__22>(ref awaiter, ref this);
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
					kassaBalanceViewModel.<>n__0();
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

			// Token: 0x0600281A RID: 10266 RVA: 0x0007BEAC File Offset: 0x0007A0AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015EC RID: 5612
			public int <>1__state;

			// Token: 0x040015ED RID: 5613
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015EE RID: 5614
			public KassaBalanceViewModel <>4__this;

			// Token: 0x040015EF RID: 5615
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003C6 RID: 966
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <FilterChangedHandler>d__23 : IAsyncStateMachine
		{
			// Token: 0x0600281B RID: 10267 RVA: 0x0007BEC8 File Offset: 0x0007A0C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaBalanceViewModel kassaBalanceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = kassaBalanceViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaBalanceViewModel.<FilterChangedHandler>d__23>(ref awaiter, ref this);
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

			// Token: 0x0600281C RID: 10268 RVA: 0x0007BF7C File Offset: 0x0007A17C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015F0 RID: 5616
			public int <>1__state;

			// Token: 0x040015F1 RID: 5617
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015F2 RID: 5618
			public KassaBalanceViewModel <>4__this;

			// Token: 0x040015F3 RID: 5619
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020003C7 RID: 967
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DataRefresh>d__28 : IAsyncStateMachine
		{
			// Token: 0x0600281D RID: 10269 RVA: 0x0007BF98 File Offset: 0x0007A198
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaBalanceViewModel kassaBalanceViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = kassaBalanceViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaBalanceViewModel.<DataRefresh>d__28>(ref awaiter, ref this);
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

			// Token: 0x0600281E RID: 10270 RVA: 0x0007C04C File Offset: 0x0007A24C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040015F4 RID: 5620
			public int <>1__state;

			// Token: 0x040015F5 RID: 5621
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040015F6 RID: 5622
			public KassaBalanceViewModel <>4__this;

			// Token: 0x040015F7 RID: 5623
			private TaskAwaiter <>u__1;
		}
	}
}
