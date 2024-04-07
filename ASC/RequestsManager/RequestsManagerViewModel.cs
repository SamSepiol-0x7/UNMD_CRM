using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.ItemsArrival;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.RequestsManager
{
	// Token: 0x02000233 RID: 563
	public class RequestsManagerViewModel : CollectionViewModel<parts_request>
	{
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00058350 File Offset: 0x00056550
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x00058364 File Offset: 0x00056564
		public Period Period
		{
			[CompilerGenerated]
			get
			{
				return this.<Period>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Period>k__BackingField, value))
				{
					return;
				}
				this.<Period>k__BackingField = value;
				this.RaisePropertyChanged("Period");
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00058394 File Offset: 0x00056594
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000583A8 File Offset: 0x000565A8
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000583D8 File Offset: 0x000565D8
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000583EC File Offset: 0x000565EC
		public List<KeyValuePair<int, string>> Priorities
		{
			[CompilerGenerated]
			get
			{
				return this.<Priorities>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Priorities>k__BackingField, value))
				{
					return;
				}
				this.<Priorities>k__BackingField = value;
				this.RaisePropertyChanged("Priorities");
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x0005841C File Offset: 0x0005661C
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00058430 File Offset: 0x00056630
		public int SelectedPriority
		{
			get
			{
				return this._selectedPriority;
			}
			set
			{
				if (this._selectedPriority == value)
				{
					return;
				}
				this._selectedPriority = value;
				this.RaisePropertyChanged("SelectedPriority");
				this.LoadItems();
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00058464 File Offset: 0x00056664
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x00058478 File Offset: 0x00056678
		public int SelectedEmployee
		{
			get
			{
				return this._selectedEmployee;
			}
			set
			{
				if (this._selectedEmployee == value)
				{
					return;
				}
				this._selectedEmployee = value;
				this.RaisePropertyChanged("SelectedEmployee");
				this.LoadItems();
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x000584AC File Offset: 0x000566AC
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x000584C0 File Offset: 0x000566C0
		public int SelectedRequestStatus
		{
			get
			{
				return this._selectedRequestStatus;
			}
			set
			{
				if (this._selectedRequestStatus == value)
				{
					return;
				}
				this._selectedRequestStatus = value;
				this.RaisePropertyChanged("SelectedRequestStatus");
				this.LoadItems();
			}
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x000584F4 File Offset: 0x000566F4
		public RequestsManagerViewModel()
		{
			this._navigationService = Bootstrapper.Container.Resolve<INavigationService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._taskService = Bootstrapper.Container.Resolve<ITaskService>();
			this._partsRequestService = Bootstrapper.Container.Resolve<IPartsRequestService>();
			this.SetViewName("RequestManager");
			this.Period = new Period(this._localization.Now.AddMonths(-6), this._localization.Now);
			this.Statuses = this._partsRequestService.GetPartsRequestStatuses(true);
			this.Priorities = this._taskService.LoadPriorities(true);
			this.LoadItems();
			Period period = this.Period;
			period.RefreshEventHandler = (EventHandler)Delegate.Combine(period.RefreshEventHandler, new EventHandler(this.Refresh));
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000585E0 File Offset: 0x000567E0
		private void Refresh(object sender, EventArgs e)
		{
			this.LoadItems();
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000585F4 File Offset: 0x000567F4
		private void LoadItems()
		{
			RequestsManagerViewModel.<LoadItems>d__31 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<RequestsManagerViewModel.<LoadItems>d__31>(ref <LoadItems>d__);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000585E0 File Offset: 0x000567E0
		[Command]
		public void Refresh()
		{
			this.LoadItems();
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0005862C File Offset: 0x0005682C
		[Command]
		public void Delivered()
		{
			List<parts_request> list;
			if (base.SelectedItems != null && base.SelectedItems.Any<parts_request>())
			{
				list = base.SelectedItems;
			}
			else
			{
				(list = new List<parts_request>()).Add(base.SelectedItem);
			}
			List<parts_request> requestItems = list;
			this._navigationService.Navigate("InItems", new ItemsArrivalViewModel(requestItems));
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00058680 File Offset: 0x00056880
		public bool CanDelivered()
		{
			if (base.SelectedItems == null)
			{
				return base.SelectedItem != null;
			}
			if (!base.SelectedItems.Any<parts_request>())
			{
				return false;
			}
			return base.SelectedItems.All((parts_request i) => i.state == 1);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x000586D8 File Offset: 0x000568D8
		[Command]
		public void Create()
		{
			this._navigationService.Navigate("RequestCardView", new RequestCardViewModel());
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000586FC File Offset: 0x000568FC
		[Command]
		public void RequestDoubleClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			this._navigationService.Navigate("RequestCardView", new RequestCardViewModel(base.SelectedItem.id));
		}

		// Token: 0x0400100D RID: 4109
		private readonly Localization _localization = new Localization("UTC");

		// Token: 0x0400100E RID: 4110
		private int _selectedRequestStatus;

		// Token: 0x0400100F RID: 4111
		private int _selectedEmployee;

		// Token: 0x04001010 RID: 4112
		private int _selectedPriority;

		// Token: 0x04001011 RID: 4113
		private readonly INavigationService _navigationService;

		// Token: 0x04001012 RID: 4114
		private readonly IToasterService _toasterService;

		// Token: 0x04001013 RID: 4115
		private readonly ITaskService _taskService;

		// Token: 0x04001014 RID: 4116
		private readonly IPartsRequestService _partsRequestService;

		// Token: 0x04001015 RID: 4117
		[CompilerGenerated]
		private Period <Period>k__BackingField;

		// Token: 0x04001016 RID: 4118
		[CompilerGenerated]
		private Dictionary<int, string> <Statuses>k__BackingField;

		// Token: 0x04001017 RID: 4119
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <Priorities>k__BackingField;

		// Token: 0x02000234 RID: 564
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__31 : IAsyncStateMachine
		{
			// Token: 0x06001EC3 RID: 7875 RVA: 0x00058734 File Offset: 0x00056934
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RequestsManagerViewModel requestsManagerViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						requestsManagerViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<List<parts_request>> awaiter;
						if (num != 0)
						{
							awaiter = requestsManagerViewModel._partsRequestService.GetRequests(requestsManagerViewModel.Period, requestsManagerViewModel.SelectedEmployee, requestsManagerViewModel.SelectedRequestStatus, requestsManagerViewModel.SelectedPriority).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<parts_request>>, RequestsManagerViewModel.<LoadItems>d__31>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<parts_request>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<parts_request> result = awaiter.GetResult();
						requestsManagerViewModel.SetItems(result);
					}
					catch (Exception ex)
					{
						requestsManagerViewModel._toasterService.Error(ex.Message);
						throw;
					}
					finally
					{
						if (num < 0)
						{
							requestsManagerViewModel.HideWait();
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

			// Token: 0x06001EC4 RID: 7876 RVA: 0x00058854 File Offset: 0x00056A54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001018 RID: 4120
			public int <>1__state;

			// Token: 0x04001019 RID: 4121
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400101A RID: 4122
			public RequestsManagerViewModel <>4__this;

			// Token: 0x0400101B RID: 4123
			private TaskAwaiter<List<parts_request>> <>u__1;
		}

		// Token: 0x02000235 RID: 565
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001EC5 RID: 7877 RVA: 0x00058870 File Offset: 0x00056A70
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001EC6 RID: 7878 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06001EC7 RID: 7879 RVA: 0x00058888 File Offset: 0x00056A88
			internal bool <CanDelivered>b__34_0(parts_request i)
			{
				return i.state == 1;
			}

			// Token: 0x0400101C RID: 4124
			public static readonly RequestsManagerViewModel.<>c <>9 = new RequestsManagerViewModel.<>c();

			// Token: 0x0400101D RID: 4125
			public static Func<parts_request, bool> <>9__34_0;
		}
	}
}
