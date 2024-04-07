using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using Poly;

namespace ASC.ViewModels
{
	// Token: 0x0200041C RID: 1052
	public class TelEditViewModel : BaseViewModel
	{
		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x00084F10 File Offset: 0x00083110
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x00084F24 File Offset: 0x00083124
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Title>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Title>k__BackingField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00084F54 File Offset: 0x00083154
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x00084F68 File Offset: 0x00083168
		public Tel Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Tel>k__BackingField, value))
				{
					return;
				}
				this.<Tel>k__BackingField = value;
				this.RaisePropertyChanged("Tel");
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x00084F98 File Offset: 0x00083198
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x00084FAC File Offset: 0x000831AC
		public List<PhoneOptions> Masks
		{
			[CompilerGenerated]
			get
			{
				return this.<Masks>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Masks>k__BackingField, value))
				{
					return;
				}
				this.<Masks>k__BackingField = value;
				this.RaisePropertyChanged("Masks");
			}
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00084FDC File Offset: 0x000831DC
		public TelEditViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._telService = Bootstrapper.Container.Resolve<ITelService>();
			this.Masks = new PhoneOptions().GetAllOptions();
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00085030 File Offset: 0x00083230
		public TelEditViewModel(CustomerCard customer) : this()
		{
			this._customer = customer;
			this.Tel = new Tel
			{
				IsMain = !customer.Phones.Any<Tel>(),
				Mask = 1,
				Notify = true
			};
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00085078 File Offset: 0x00083278
		public TelEditViewModel(CustomerCard customer, Tel tel) : this(customer)
		{
			this._original = new Tel();
			tel.CopyProperties(this._original);
			this.Tel = tel;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000850AC File Offset: 0x000832AC
		[AsyncCommand]
		public Task Delete()
		{
			TelEditViewModel.<Delete>d__20 <Delete>d__;
			<Delete>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Delete>d__.<>4__this = this;
			<Delete>d__.<>1__state = -1;
			<Delete>d__.<>t__builder.Start<TelEditViewModel.<Delete>d__20>(ref <Delete>d__);
			return <Delete>d__.<>t__builder.Task;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000850F0 File Offset: 0x000832F0
		public bool CanDelete()
		{
			return this.Tel != null && ((this._customer.Id > 0 && this.Tel.Id > 0) || (this._customer.Id == 0 && this.Tel.Id < 0));
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00085144 File Offset: 0x00083344
		private bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.Tel.Phone))
			{
				this._toasterService.Info("Phone empty");
				return false;
			}
			return true;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00085178 File Offset: 0x00083378
		[AsyncCommand]
		public Task Save()
		{
			TelEditViewModel.<Save>d__23 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<TelEditViewModel.<Save>d__23>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000851BC File Offset: 0x000833BC
		public bool CanSave()
		{
			return this.Tel != null && this.Tel.Id > 0;
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000851E4 File Offset: 0x000833E4
		[AsyncCommand]
		public Task Create()
		{
			TelEditViewModel.<Create>d__25 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<TelEditViewModel.<Create>d__25>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00085228 File Offset: 0x00083428
		public bool CanCreate()
		{
			return this.Tel != null && this.Tel.Id == 0;
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00085250 File Offset: 0x00083450
		[Command]
		public void Close()
		{
			if (this._original != null)
			{
				this._original.CopyProperties(this.Tel);
			}
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x04001770 RID: 6000
		private readonly IToasterService _toasterService;

		// Token: 0x04001771 RID: 6001
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001772 RID: 6002
		private readonly ITelService _telService;

		// Token: 0x04001773 RID: 6003
		[CompilerGenerated]
		private string <Title>k__BackingField;

		// Token: 0x04001774 RID: 6004
		private CustomerCard _customer;

		// Token: 0x04001775 RID: 6005
		[CompilerGenerated]
		private Tel <Tel>k__BackingField;

		// Token: 0x04001776 RID: 6006
		[CompilerGenerated]
		private List<PhoneOptions> <Masks>k__BackingField;

		// Token: 0x04001777 RID: 6007
		private Tel _original;

		// Token: 0x0200041D RID: 1053
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Delete>d__20 : IAsyncStateMachine
		{
			// Token: 0x06002A3B RID: 10811 RVA: 0x00085284 File Offset: 0x00083484
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TelEditViewModel telEditViewModel = this.<>4__this;
				try
				{
					if (num != 0 && telEditViewModel._customer.Id == 0)
					{
						telEditViewModel._customer.Phones.Remove(telEditViewModel.Tel);
						telEditViewModel._windowedDocumentService.CloseActiveDocument();
					}
					else
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = telEditViewModel._telService.DeleteTel(telEditViewModel._customer.Id, telEditViewModel.Tel.Id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TelEditViewModel.<Delete>d__20>(ref awaiter, ref this);
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
						catch (Exception ex)
						{
							telEditViewModel._toasterService.Error(ex.Message);
							goto IL_11E;
						}
						telEditViewModel._customer.Phones.Remove(telEditViewModel.Tel);
						telEditViewModel.ShowActionResponse(true, Lang.t("Complete"));
						telEditViewModel.Close();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_11E:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002A3C RID: 10812 RVA: 0x000853E0 File Offset: 0x000835E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001778 RID: 6008
			public int <>1__state;

			// Token: 0x04001779 RID: 6009
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400177A RID: 6010
			public TelEditViewModel <>4__this;

			// Token: 0x0400177B RID: 6011
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200041E RID: 1054
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__23 : IAsyncStateMachine
		{
			// Token: 0x06002A3D RID: 10813 RVA: 0x000853FC File Offset: 0x000835FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TelEditViewModel telEditViewModel = this.<>4__this;
				try
				{
					if (num == 0 || telEditViewModel.CheckFields())
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = telEditViewModel._telService.UpdateTel(telEditViewModel._customer.Id, telEditViewModel.Tel).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, TelEditViewModel.<Save>d__23>(ref awaiter, ref this);
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
							telEditViewModel._toasterService.Success(Lang.t("Saved"));
							telEditViewModel._windowedDocumentService.CloseActiveDocument();
						}
						catch (Exception ex)
						{
							telEditViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x06002A3E RID: 10814 RVA: 0x0008551C File Offset: 0x0008371C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400177C RID: 6012
			public int <>1__state;

			// Token: 0x0400177D RID: 6013
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400177E RID: 6014
			public TelEditViewModel <>4__this;

			// Token: 0x0400177F RID: 6015
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200041F RID: 1055
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__25 : IAsyncStateMachine
		{
			// Token: 0x06002A3F RID: 10815 RVA: 0x00085538 File Offset: 0x00083738
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				TelEditViewModel telEditViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						if (!telEditViewModel.CheckFields())
						{
							goto IL_138;
						}
						if (telEditViewModel._customer.Id == 0)
						{
							Random random = new Random();
							telEditViewModel.Tel.Id = -random.Next(1, 1000);
							telEditViewModel._customer.AddTelToList(telEditViewModel.Tel);
							telEditViewModel._windowedDocumentService.CloseActiveDocument();
							goto IL_138;
						}
						awaiter = telEditViewModel._telService.CreateTel(telEditViewModel._customer.Id, telEditViewModel.Tel).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, TelEditViewModel.<Create>d__25>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter.GetResult();
					telEditViewModel.ShowActionResponse(result > 0, "");
					if (result > 0)
					{
						telEditViewModel.Tel.Id = result;
						telEditViewModel._customer.AddTelToList(telEditViewModel.Tel);
						telEditViewModel._windowedDocumentService.CloseActiveDocument();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_138:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002A40 RID: 10816 RVA: 0x000856AC File Offset: 0x000838AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001780 RID: 6016
			public int <>1__state;

			// Token: 0x04001781 RID: 6017
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001782 RID: 6018
			public TelEditViewModel <>4__this;

			// Token: 0x04001783 RID: 6019
			private TaskAwaiter<int> <>u__1;
		}
	}
}
