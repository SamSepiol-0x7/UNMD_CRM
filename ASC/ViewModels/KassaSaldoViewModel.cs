using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.SimpleClasses;
using ASC.Kassa;
using ASC.Services;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000402 RID: 1026
	public class KassaSaldoViewModel : ViewModelBase
	{
		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x00081D94 File Offset: 0x0007FF94
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x00081DA8 File Offset: 0x0007FFA8
		public Saldo Data
		{
			[CompilerGenerated]
			get
			{
				return this.<Data>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Data>k__BackingField, value))
				{
					return;
				}
				this.<Data>k__BackingField = value;
				this.RaisePropertyChanged("Data");
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x00081DD8 File Offset: 0x0007FFD8
		// (set) Token: 0x06002975 RID: 10613 RVA: 0x00081DEC File Offset: 0x0007FFEC
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

		// Token: 0x06002976 RID: 10614 RVA: 0x00081E18 File Offset: 0x00080018
		public KassaSaldoViewModel(IKassaService kassaService)
		{
			this._kassaService = kassaService;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00081E34 File Offset: 0x00080034
		private Task LoadData()
		{
			KassaSaldoViewModel.<LoadData>d__11 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<KassaSaldoViewModel.<LoadData>d__11>(ref <LoadData>d__);
			return <LoadData>d__.<>t__builder.Task;
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00081E78 File Offset: 0x00080078
		[Command]
		public void OnLoad()
		{
			KassaSaldoViewModel.<OnLoad>d__12 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<KassaSaldoViewModel.<OnLoad>d__12>(ref <OnLoad>d__);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00081EB0 File Offset: 0x000800B0
		private void SaldoRefresHandler(object sender, EventArgs e)
		{
			KassaSaldoViewModel.<SaldoRefresHandler>d__13 <SaldoRefresHandler>d__;
			<SaldoRefresHandler>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SaldoRefresHandler>d__.<>4__this = this;
			<SaldoRefresHandler>d__.<>1__state = -1;
			<SaldoRefresHandler>d__.<>t__builder.Start<KassaSaldoViewModel.<SaldoRefresHandler>d__13>(ref <SaldoRefresHandler>d__);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00081EE8 File Offset: 0x000800E8
		[Command]
		public void OnUnload()
		{
			if (this._parentViewModel != null)
			{
				KassaViewModel parentViewModel = this._parentViewModel;
				parentViewModel.FilterChangedHandler = (EventHandler)Delegate.Remove(parentViewModel.FilterChangedHandler, new EventHandler(this.SaldoRefresHandler));
			}
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00081F24 File Offset: 0x00080124
		protected override void OnParentViewModelChanged(object obj)
		{
			this._parentViewModel = (obj as KassaViewModel);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00081F40 File Offset: 0x00080140
		[CompilerGenerated]
		private Task<Saldo> <LoadData>b__11_0()
		{
			return this._kassaService.GetThisMonthSaldo(this._parentViewModel.SelectedCompany, this._parentViewModel.SelectedOffice);
		}

		// Token: 0x040016F1 RID: 5873
		[CompilerGenerated]
		private Saldo <Data>k__BackingField;

		// Token: 0x040016F2 RID: 5874
		private KassaViewModel _parentViewModel;

		// Token: 0x040016F3 RID: 5875
		private readonly IKassaService _kassaService;

		// Token: 0x040016F4 RID: 5876
		[CompilerGenerated]
		private bool <IsBuzy>k__BackingField;

		// Token: 0x02000403 RID: 1027
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__11 : IAsyncStateMachine
		{
			// Token: 0x0600297D RID: 10621 RVA: 0x00081F70 File Offset: 0x00080170
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaSaldoViewModel kassaSaldoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<Saldo> awaiter;
					if (num != 0)
					{
						if (kassaSaldoViewModel._parentViewModel == null)
						{
							goto IL_B2;
						}
						kassaSaldoViewModel.IsBuzy = true;
						awaiter = Task.Run<Saldo>(() => kassaSaldoViewModel._kassaService.GetThisMonthSaldo(kassaSaldoViewModel._parentViewModel.SelectedCompany, kassaSaldoViewModel._parentViewModel.SelectedOffice)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Saldo>, KassaSaldoViewModel.<LoadData>d__11>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<Saldo>);
						this.<>1__state = -1;
					}
					Saldo result = awaiter.GetResult();
					kassaSaldoViewModel.Data = result;
					kassaSaldoViewModel.IsBuzy = false;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_B2:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600297E RID: 10622 RVA: 0x00082054 File Offset: 0x00080254
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016F5 RID: 5877
			public int <>1__state;

			// Token: 0x040016F6 RID: 5878
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040016F7 RID: 5879
			public KassaSaldoViewModel <>4__this;

			// Token: 0x040016F8 RID: 5880
			private TaskAwaiter<Saldo> <>u__1;
		}

		// Token: 0x02000404 RID: 1028
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__12 : IAsyncStateMachine
		{
			// Token: 0x0600297F RID: 10623 RVA: 0x00082070 File Offset: 0x00080270
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaSaldoViewModel kassaSaldoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (kassaSaldoViewModel._parentViewModel != null)
						{
							KassaViewModel parentViewModel = kassaSaldoViewModel._parentViewModel;
							parentViewModel.FilterChangedHandler = (EventHandler)Delegate.Combine(parentViewModel.FilterChangedHandler, new EventHandler(kassaSaldoViewModel.SaldoRefresHandler));
						}
						awaiter = kassaSaldoViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaSaldoViewModel.<OnLoad>d__12>(ref awaiter, ref this);
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

			// Token: 0x06002980 RID: 10624 RVA: 0x00082154 File Offset: 0x00080354
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016F9 RID: 5881
			public int <>1__state;

			// Token: 0x040016FA RID: 5882
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040016FB RID: 5883
			public KassaSaldoViewModel <>4__this;

			// Token: 0x040016FC RID: 5884
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000405 RID: 1029
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaldoRefresHandler>d__13 : IAsyncStateMachine
		{
			// Token: 0x06002981 RID: 10625 RVA: 0x00082170 File Offset: 0x00080370
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KassaSaldoViewModel kassaSaldoViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = kassaSaldoViewModel.LoadData().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, KassaSaldoViewModel.<SaldoRefresHandler>d__13>(ref awaiter, ref this);
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

			// Token: 0x06002982 RID: 10626 RVA: 0x00082224 File Offset: 0x00080424
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040016FD RID: 5885
			public int <>1__state;

			// Token: 0x040016FE RID: 5886
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040016FF RID: 5887
			public KassaSaldoViewModel <>4__this;

			// Token: 0x04001700 RID: 5888
			private TaskAwaiter <>u__1;
		}
	}
}
