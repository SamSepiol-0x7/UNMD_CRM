using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Clients;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.TaskManager;
using ASC.ViewModel;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RequestsManager
{
	// Token: 0x0200022D RID: 557
	public class RequestCardViewModel : TaskCommonViewModel, IItemsSelect, ICustomerSelect
	{
		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00057558 File Offset: 0x00055758
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x0005756C File Offset: 0x0005576C
		public List<users> Employees
		{
			[CompilerGenerated]
			get
			{
				return this.<Employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Employees>k__BackingField, value))
				{
					return;
				}
				this.<Employees>k__BackingField = value;
				this.RaisePropertyChanged("Employees");
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0005759C File Offset: 0x0005579C
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x000575B0 File Offset: 0x000557B0
		public List<int> SelectedResponsibleUsers
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedResponsibleUsers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedResponsibleUsers>k__BackingField, value))
				{
					return;
				}
				this.<SelectedResponsibleUsers>k__BackingField = value;
				this.RaisePropertyChanged("SelectedResponsibleUsers");
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x000575E0 File Offset: 0x000557E0
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x000575F4 File Offset: 0x000557F4
		public Dictionary<int, string> Statuses
		{
			[CompilerGenerated]
			get
			{
				return this.<Statuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Statuses>k__BackingField, value))
				{
					return;
				}
				this.<Statuses>k__BackingField = value;
				this.RaisePropertyChanged("Statuses");
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x00057624 File Offset: 0x00055824
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x00057638 File Offset: 0x00055838
		public int RequestId
		{
			[CompilerGenerated]
			get
			{
				return this.<RequestId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<RequestId>k__BackingField == value)
				{
					return;
				}
				this.<RequestId>k__BackingField = value;
				this.RaisePropertyChanged("RequestId");
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00057664 File Offset: 0x00055864
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x00057678 File Offset: 0x00055878
		public parts_request Request
		{
			[CompilerGenerated]
			get
			{
				return this.<Request>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Request>k__BackingField, value))
				{
					return;
				}
				this.<Request>k__BackingField = value;
				this.RaisePropertyChanged("ExistRequest");
				this.RaisePropertyChanged("ExistRequestInvert");
				this.RaisePropertyChanged("CanSetEndDate");
				this.RaisePropertyChanged("Request");
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x000576C8 File Offset: 0x000558C8
		public bool ExistRequest
		{
			get
			{
				return this.Request != null && this.Request.id != 0;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000576F0 File Offset: 0x000558F0
		public bool ExistRequestInvert
		{
			get
			{
				return !this.ExistRequest;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x00057708 File Offset: 0x00055908
		public bool CanSetEndDate
		{
			get
			{
				return this.Request != null && this.Request.state > 1 && OfflineData.Instance.Employee.Can(70, 0);
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00057740 File Offset: 0x00055940
		public bool CanEditRequest
		{
			get
			{
				return OfflineData.Instance.Employee.Can(70, 0);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00057760 File Offset: 0x00055960
		public bool CanEditRequestInvert
		{
			get
			{
				return !this.CanEditRequest;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00057778 File Offset: 0x00055978
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0005778C File Offset: 0x0005598C
		public DateTime CurrentDateTime
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentDateTime>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<CurrentDateTime>k__BackingField, value))
				{
					return;
				}
				this.<CurrentDateTime>k__BackingField = value;
				this.RaisePropertyChanged("CurrentDateTime");
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000577BC File Offset: 0x000559BC
		private void IoC()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._taskService = Bootstrapper.Container.Resolve<ITaskService>();
			this._partsRequestService = Bootstrapper.Container.Resolve<IPartsRequestService>();
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0005780C File Offset: 0x00055A0C
		public RequestCardViewModel()
		{
			this.IoC();
			this.SetViewName("BuyItemRequest");
			this.Init();
			this.Request = this._partsRequestService.NewRequest();
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00057868 File Offset: 0x00055A68
		public RequestCardViewModel(int requestId)
		{
			this.IoC();
			this.SetViewName("BuyItemRequest", requestId);
			this.RequestId = requestId;
			this.Init();
			this.LoadRequest();
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000578C4 File Offset: 0x00055AC4
		public RequestCardViewModel(workshop repair)
		{
			this.IoC();
			this.SetViewName("BuyItemRequest");
			this.Init();
			this.Request = this._partsRequestService.NewRequest(repair);
			this.RefreshFields();
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00057928 File Offset: 0x00055B28
		private void RefreshFields()
		{
			base.RaisePropertyChanged<bool>(() => this.ExistRequestInvert);
			base.RaisePropertyChanged<bool>(() => this.ExistRequest);
			base.RaisePropertyChanged<bool>(() => this.CanSetEndDate);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000579D4 File Offset: 0x00055BD4
		private void LoadRequest()
		{
			RequestCardViewModel.<LoadRequest>d__44 <LoadRequest>d__;
			<LoadRequest>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadRequest>d__.<>4__this = this;
			<LoadRequest>d__.<>1__state = -1;
			<LoadRequest>d__.<>t__builder.Start<RequestCardViewModel.<LoadRequest>d__44>(ref <LoadRequest>d__);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00057A0C File Offset: 0x00055C0C
		private void Init()
		{
			RequestCardViewModel.<Init>d__45 <Init>d__;
			<Init>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RequestCardViewModel.<Init>d__45>(ref <Init>d__);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00057A44 File Offset: 0x00055C44
		[AsyncCommand]
		public Task SaveAndClose()
		{
			RequestCardViewModel.<SaveAndClose>d__46 <SaveAndClose>d__;
			<SaveAndClose>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveAndClose>d__.<>4__this = this;
			<SaveAndClose>d__.<>1__state = -1;
			<SaveAndClose>d__.<>t__builder.Start<RequestCardViewModel.<SaveAndClose>d__46>(ref <SaveAndClose>d__);
			return <SaveAndClose>d__.<>t__builder.Task;
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00057A88 File Offset: 0x00055C88
		public bool CanSaveAndClose()
		{
			return this.Request != null;
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00057AA0 File Offset: 0x00055CA0
		private bool CheckNewRequestFields()
		{
			if (this.SelectedResponsibleUsers.Any<int>())
			{
				goto IL_50;
			}
			IL_1C:
			int num = 574734753;
			IL_21:
			switch ((num ^ 842237014) % 5)
			{
			case 0:
				IL_50:
				num = (string.IsNullOrEmpty(this.Request.item_name) ? 292565202 : 485675286);
				goto IL_21;
			case 1:
				this._toasterService.Info(Lang.t("InputTaskResponsibleUsers"));
				return false;
			case 2:
				goto IL_1C;
			case 4:
				this._toasterService.Info(Lang.t("InputItemName"));
				return false;
			}
			return true;
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00057B40 File Offset: 0x00055D40
		[Command]
		public void CreateAndClose()
		{
			if (!this.CheckNewRequestFields())
			{
				return;
			}
			base.ShowActionResponse(this._partsRequestService.CreateRequest(this.Request, this.SelectedResponsibleUsers), "");
			if (this.Request != null)
			{
				this.RequestId = this.Request.id;
			}
			this.RefreshFields();
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00057B98 File Offset: 0x00055D98
		[Command]
		public void ItemCardOpen()
		{
			if (this.Request.item_id != null)
			{
				this._navigationService.NavigateToStoreItem(this.Request.item_id.Value, 0);
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00057BDC File Offset: 0x00055DDC
		[Command]
		public void RepairCardOpen()
		{
			if (this.Request.repair != null)
			{
				this._navigationService.NavigateRepairCard(this.Request.repair.Value);
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00057C1C File Offset: 0x00055E1C
		[Command]
		public void ShowHistory()
		{
			this._navigationService.Navigate("HistoryView", new HistoryViewModel(this.Request));
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00057C44 File Offset: 0x00055E44
		public bool CanShowHistory()
		{
			parts_request request = this.Request;
			return request != null && request.id > 0;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00057C68 File Offset: 0x00055E68
		[Command]
		public void SelectExistItem()
		{
			this._navigationService.NavigateToStore(true, ItemsOptions.opName.inStock, this);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00057C84 File Offset: 0x00055E84
		public bool CanSelectExistItem()
		{
			return this.Request != null && this.Request.id == 0;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00057CAC File Offset: 0x00055EAC
		[Command]
		public void TaskOwnerChanged()
		{
			this._partsRequestService.ReferenceFromUser(this.Request);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00057CCC File Offset: 0x00055ECC
		[Command]
		public void SelectDealer()
		{
			this._navigationService.Navigate("ClientsView", new ClientsViewModel("selectDealer"), this);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00057CF4 File Offset: 0x00055EF4
		public bool CanSelectDealer()
		{
			return this.Request != null && this.Request.id == 0 && OfflineData.Instance.Employee.Can(7, 0);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00057D2C File Offset: 0x00055F2C
		public void SelectCustomerFromList(ICustomer customer)
		{
			this.Request.dealer = new int?(customer.Id);
			this._partsRequestService.ReferenceDealer(this.Request);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00057D60 File Offset: 0x00055F60
		public void AddItemsFromStore(List<Product> items, Product selectedItem)
		{
			if (selectedItem != null)
			{
				goto IL_27;
			}
			IL_03:
			int num = 1971189236;
			IL_08:
			switch ((num ^ 607896449) % 4)
			{
			case 0:
				goto IL_03;
			case 1:
				return;
			case 2:
				IL_27:
				this.Request.item_name = selectedItem.Name;
				this.Request.item_id = new int?(selectedItem.Id);
				num = 405300310;
				goto IL_08;
			}
		}

		// Token: 0x04000FE4 RID: 4068
		private INavigationService _navigationService;

		// Token: 0x04000FE5 RID: 4069
		private IPartsRequestService _partsRequestService;

		// Token: 0x04000FE6 RID: 4070
		private readonly UsersModel _usersModel = new UsersModel();

		// Token: 0x04000FE7 RID: 4071
		private IToasterService _toasterService;

		// Token: 0x04000FE8 RID: 4072
		private ITaskService _taskService;

		// Token: 0x04000FE9 RID: 4073
		[CompilerGenerated]
		private List<users> <Employees>k__BackingField;

		// Token: 0x04000FEA RID: 4074
		[CompilerGenerated]
		private List<int> <SelectedResponsibleUsers>k__BackingField = new List<int>();

		// Token: 0x04000FEB RID: 4075
		[CompilerGenerated]
		private Dictionary<int, string> <Statuses>k__BackingField;

		// Token: 0x04000FEC RID: 4076
		[CompilerGenerated]
		private int <RequestId>k__BackingField;

		// Token: 0x04000FED RID: 4077
		[CompilerGenerated]
		private parts_request <Request>k__BackingField;

		// Token: 0x04000FEE RID: 4078
		[CompilerGenerated]
		private DateTime <CurrentDateTime>k__BackingField = DateTime.Now;

		// Token: 0x0200022E RID: 558
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRequest>d__44 : IAsyncStateMachine
		{
			// Token: 0x06001EA2 RID: 7842 RVA: 0x00057DC4 File Offset: 0x00055FC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RequestCardViewModel requestCardViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter<parts_request> awaiter;
						if (num != 0)
						{
							awaiter = requestCardViewModel._partsRequestService.GetRequest(requestCardViewModel.RequestId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<parts_request>, RequestCardViewModel.<LoadRequest>d__44>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<parts_request>);
							this.<>1__state = -1;
						}
						parts_request result = awaiter.GetResult();
						requestCardViewModel.Request = result;
						requestCardViewModel.SelectedResponsibleUsers = requestCardViewModel._partsRequestService.GetResponsibleEmployees(requestCardViewModel.Request);
						requestCardViewModel.RaiseCanExecuteChanged(() => requestCardViewModel.ShowHistory());
					}
					catch (Exception ex)
					{
						requestCardViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x06001EA3 RID: 7843 RVA: 0x00057F08 File Offset: 0x00056108
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000FEF RID: 4079
			public int <>1__state;

			// Token: 0x04000FF0 RID: 4080
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000FF1 RID: 4081
			public RequestCardViewModel <>4__this;

			// Token: 0x04000FF2 RID: 4082
			private TaskAwaiter<parts_request> <>u__1;
		}

		// Token: 0x0200022F RID: 559
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001EA4 RID: 7844 RVA: 0x00057F24 File Offset: 0x00056124
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001EA5 RID: 7845 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001EA6 RID: 7846 RVA: 0x00057F3C File Offset: 0x0005613C
			internal int <Init>b__45_0(users e)
			{
				return e.id;
			}

			// Token: 0x04000FF3 RID: 4083
			public static readonly RequestCardViewModel.<>c <>9 = new RequestCardViewModel.<>c();

			// Token: 0x04000FF4 RID: 4084
			public static Func<users, int> <>9__45_0;
		}

		// Token: 0x02000230 RID: 560
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Init>d__45 : IAsyncStateMachine
		{
			// Token: 0x06001EA7 RID: 7847 RVA: 0x00057F50 File Offset: 0x00056150
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RequestCardViewModel requestCardViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<users>> awaiter;
					if (num != 0)
					{
						awaiter = requestCardViewModel._usersModel.LoadPartRequestManagers().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, RequestCardViewModel.<Init>d__45>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<users>>);
						this.<>1__state = -1;
					}
					List<users> result = awaiter.GetResult();
					requestCardViewModel.Employees = result;
					requestCardViewModel.SelectedResponsibleUsers = requestCardViewModel.Employees.Select(new Func<users, int>(RequestCardViewModel.<>c.<>9.<Init>b__45_0)).ToList<int>();
					requestCardViewModel.Priorities = requestCardViewModel._taskService.LoadPriorities(false);
					requestCardViewModel.Statuses = requestCardViewModel._partsRequestService.GetPartsRequestStatuses(false);
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

			// Token: 0x06001EA8 RID: 7848 RVA: 0x00058070 File Offset: 0x00056270
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000FF5 RID: 4085
			public int <>1__state;

			// Token: 0x04000FF6 RID: 4086
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000FF7 RID: 4087
			public RequestCardViewModel <>4__this;

			// Token: 0x04000FF8 RID: 4088
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x02000231 RID: 561
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SaveAndClose>d__46 : IAsyncStateMachine
		{
			// Token: 0x06001EA9 RID: 7849 RVA: 0x0005808C File Offset: 0x0005628C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RequestCardViewModel requestCardViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						requestCardViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = requestCardViewModel._partsRequestService.UpdateRequest(requestCardViewModel.Request).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RequestCardViewModel.<SaveAndClose>d__46>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						requestCardViewModel._toasterService.Success(Lang.t("Saved"));
						requestCardViewModel.RefreshFields();
					}
					catch (Exception ex)
					{
						requestCardViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							requestCardViewModel.HideWait();
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

			// Token: 0x06001EAA RID: 7850 RVA: 0x000581B0 File Offset: 0x000563B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000FF9 RID: 4089
			public int <>1__state;

			// Token: 0x04000FFA RID: 4090
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000FFB RID: 4091
			public RequestCardViewModel <>4__this;

			// Token: 0x04000FFC RID: 4092
			private TaskAwaiter <>u__1;
		}
	}
}
