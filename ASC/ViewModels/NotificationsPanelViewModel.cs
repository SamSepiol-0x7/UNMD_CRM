using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000430 RID: 1072
	public class NotificationsPanelViewModel : CollectionViewModel<IAscNotification>
	{
		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000871E0 File Offset: 0x000853E0
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x000871F4 File Offset: 0x000853F4
		public double NotificationMaxHeight
		{
			[CompilerGenerated]
			get
			{
				return this.<NotificationMaxHeight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.<NotificationMaxHeight>k__BackingField == value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 550420642;
				IL_13:
				switch ((num ^ 1663130275) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					num = 285296757;
					goto IL_13;
				}
				this.<NotificationMaxHeight>k__BackingField = value;
				this.RaisePropertyChanged("NotificationMaxHeight");
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x00087250 File Offset: 0x00085450
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x00087264 File Offset: 0x00085464
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Count>k__BackingField == value)
				{
					return;
				}
				this.<Count>k__BackingField = value;
				this.RaisePropertyChanged("Count");
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x00087290 File Offset: 0x00085490
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x000872A4 File Offset: 0x000854A4
		public bool PanelVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<PanelVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PanelVisible>k__BackingField == value)
				{
					return;
				}
				this.<PanelVisible>k__BackingField = value;
				this.RaisePropertyChanged("PanelVisible");
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x000872D0 File Offset: 0x000854D0
		// (set) Token: 0x06002ACD RID: 10957 RVA: 0x000872E4 File Offset: 0x000854E4
		public string CountText
		{
			[CompilerGenerated]
			get
			{
				return this.<CountText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CountText>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CountText>k__BackingField = value;
				this.RaisePropertyChanged("CountText");
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x00087314 File Offset: 0x00085514
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x00087328 File Offset: 0x00085528
		public double BellOpacity
		{
			[CompilerGenerated]
			get
			{
				return this.<BellOpacity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<BellOpacity>k__BackingField == value)
				{
					return;
				}
				this.<BellOpacity>k__BackingField = value;
				this.RaisePropertyChanged("BellOpacity");
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x00087358 File Offset: 0x00085558
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x0008736C File Offset: 0x0008556C
		public bool IsExpand
		{
			[CompilerGenerated]
			get
			{
				return this.<IsExpand>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsExpand>k__BackingField == value)
				{
					return;
				}
				this.<IsExpand>k__BackingField = value;
				this.RaisePropertyChanged("IsExpand");
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x00087398 File Offset: 0x00085598
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x000873AC File Offset: 0x000855AC
		public ScrollBarVisibility VerticalScrollBarVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<VerticalScrollBarVisibility>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<VerticalScrollBarVisibility>k__BackingField == value)
				{
					return;
				}
				this.<VerticalScrollBarVisibility>k__BackingField = value;
				this.RaisePropertyChanged("VerticalScrollBarVisibility");
			}
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000873D8 File Offset: 0x000855D8
		public NotificationsPanelViewModel(ASC.Services.Abstract.INotificationService notificationService, ASC.Services.Abstract.INavigationService navigationService, IToasterService toasterService, IAscMessageBoxService ascMessageBoxService, IWindowedDocumentService windowedDocumentService)
		{
			this._notificationService = notificationService;
			this._navigationService = navigationService;
			this._toasterService = toasterService;
			this._ascMessageBoxService = ascMessageBoxService;
			this._windowedDocumentService = windowedDocumentService;
			((ISupportParentViewModel)this._navigationService).ParentViewModel = this;
			this.BellOpacity = 0.4;
			this.NotificationMaxHeight = SystemParameters.PrimaryScreenHeight * 0.85;
			this.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00087458 File Offset: 0x00085658
		public void Start()
		{
			NotificationsPanelViewModel.<Start>d__37 <Start>d__;
			<Start>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<NotificationsPanelViewModel.<Start>d__37>(ref <Start>d__);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00087490 File Offset: 0x00085690
		private Task CountNotifications()
		{
			NotificationsPanelViewModel.<CountNotifications>d__38 <CountNotifications>d__;
			<CountNotifications>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CountNotifications>d__.<>4__this = this;
			<CountNotifications>d__.<>1__state = -1;
			<CountNotifications>d__.<>t__builder.Start<NotificationsPanelViewModel.<CountNotifications>d__38>(ref <CountNotifications>d__);
			return <CountNotifications>d__.<>t__builder.Task;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000874D4 File Offset: 0x000856D4
		private void SetCount(int actualCount)
		{
			if (actualCount < 0)
			{
				actualCount = 0;
			}
			if (this.Count != actualCount)
			{
				this.PanelVisible = (actualCount > 0);
			}
			this.Count = actualCount;
			this.CountText = this.GetCountText(this.Count);
			this.BellOpacity = this.GetBellOpacity(this.Count);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00087528 File Offset: 0x00085728
		private double GetBellOpacity(int count)
		{
			if (count <= 0)
			{
				return 0.4;
			}
			return 1.0;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0008754C File Offset: 0x0008574C
		private string GetCountText(int count)
		{
			if (count >= 10)
			{
				return "+";
			}
			return string.Format("{0}", count);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00087574 File Offset: 0x00085774
		public Task LoadNotifications()
		{
			NotificationsPanelViewModel.<LoadNotifications>d__42 <LoadNotifications>d__;
			<LoadNotifications>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadNotifications>d__.<>4__this = this;
			<LoadNotifications>d__.<>1__state = -1;
			<LoadNotifications>d__.<>t__builder.Start<NotificationsPanelViewModel.<LoadNotifications>d__42>(ref <LoadNotifications>d__);
			return <LoadNotifications>d__.<>t__builder.Task;
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000875B8 File Offset: 0x000857B8
		[Command]
		public void HideNotification(object obj)
		{
			NotificationsPanelViewModel.<HideNotification>d__43 <HideNotification>d__;
			<HideNotification>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<HideNotification>d__.<>4__this = this;
			<HideNotification>d__.obj = obj;
			<HideNotification>d__.<>1__state = -1;
			<HideNotification>d__.<>t__builder.Start<NotificationsPanelViewModel.<HideNotification>d__43>(ref <HideNotification>d__);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000875F8 File Offset: 0x000857F8
		public bool CanHideNotification(object obj)
		{
			return obj is IAscNotification;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x00087610 File Offset: 0x00085810
		[Command]
		public void ItemClick()
		{
			if (base.SelectedItem == null)
			{
				return;
			}
			if (base.SelectedItem.Type != 1 && base.SelectedItem.Type != 2)
			{
				if (base.SelectedItem.Type != 4)
				{
					if (base.SelectedItem.Type != 5)
					{
						if (base.SelectedItem.Type != 6)
						{
							if (base.SelectedItem.Type != 12)
							{
								if (base.SelectedItem.Type == 7)
								{
									if (base.SelectedItem.TaskId != null)
									{
										this._navigationService.NavigateSiteOrderTask(base.SelectedItem.TaskId.Value);
										return;
									}
								}
								if (base.SelectedItem.Type == 8)
								{
									if (base.SelectedItem.RequestId != null)
									{
										this._navigationService.NavigatePartsRequest(base.SelectedItem.RequestId.Value);
									}
									return;
								}
								if (base.SelectedItem.Type == 9)
								{
									if (base.SelectedItem.BuyPartRequestId != null)
									{
										this._navigationService.NavigateRequestCard(base.SelectedItem.BuyPartRequestId.Value);
									}
									return;
								}
								if (base.SelectedItem.Type == 11 && base.SelectedItem.CustomerId != null)
								{
									this._navigationService.NavigateToCustomerCard(base.SelectedItem.CustomerId.Value, null);
								}
								if (base.SelectedItem.Type != 10)
								{
									return;
								}
								if (base.SelectedItem.CustomerId == null)
								{
									this._windowedDocumentService.ShowNewDocument("NewCustomerCallView", new NewCustomerCallViewModel(base.SelectedItem.Tel), null, null);
									return;
								}
								this._navigationService.NavigateToCustomerCard(base.SelectedItem.CustomerId.Value, null);
								return;
							}
						}
					}
					if (base.SelectedItem.TaskId != null)
					{
						this._navigationService.NavigateEmployeeTask(base.SelectedItem.TaskId.Value);
					}
					return;
				}
			}
			if (base.SelectedItem.RepairId != null)
			{
				this._navigationService.NavigateRepairCard(base.SelectedItem.RepairId.Value);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00087870 File Offset: 0x00085A70
		[Command]
		public void ReadAll()
		{
			NotificationsPanelViewModel.<ReadAll>d__46 <ReadAll>d__;
			<ReadAll>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ReadAll>d__.<>4__this = this;
			<ReadAll>d__.<>1__state = -1;
			<ReadAll>d__.<>t__builder.Start<NotificationsPanelViewModel.<ReadAll>d__46>(ref <ReadAll>d__);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000878A8 File Offset: 0x00085AA8
		[Command]
		public void BellClick()
		{
			if (this.Count < 1)
			{
				this.PanelVisible = false;
			}
			else
			{
				this.PanelVisible = !this.PanelVisible;
			}
			base.RaisePropertyChanged<bool>(() => this.PanelVisible);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0008790C File Offset: 0x00085B0C
		[Command]
		public void ExpandList()
		{
			NotificationsPanelViewModel.<ExpandList>d__48 <ExpandList>d__;
			<ExpandList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ExpandList>d__.<>4__this = this;
			<ExpandList>d__.<>1__state = -1;
			<ExpandList>d__.<>t__builder.Start<NotificationsPanelViewModel.<ExpandList>d__48>(ref <ExpandList>d__);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00087944 File Offset: 0x00085B44
		public bool CanExpandList()
		{
			return !this.IsExpand && base.Items != null && this.Count > base.Items.Count;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00087978 File Offset: 0x00085B78
		[Command]
		public void CollapseList()
		{
			NotificationsPanelViewModel.<CollapseList>d__50 <CollapseList>d__;
			<CollapseList>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CollapseList>d__.<>4__this = this;
			<CollapseList>d__.<>1__state = -1;
			<CollapseList>d__.<>t__builder.Start<NotificationsPanelViewModel.<CollapseList>d__50>(ref <CollapseList>d__);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000879B0 File Offset: 0x00085BB0
		public bool CanCollapseList()
		{
			return this.IsExpand;
		}

		// Token: 0x040017BE RID: 6078
		private readonly ASC.Services.Abstract.INotificationService _notificationService;

		// Token: 0x040017BF RID: 6079
		private readonly ASC.Services.Abstract.INavigationService _navigationService;

		// Token: 0x040017C0 RID: 6080
		private readonly IToasterService _toasterService;

		// Token: 0x040017C1 RID: 6081
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x040017C2 RID: 6082
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x040017C3 RID: 6083
		private const int RefreshDelay = 2;

		// Token: 0x040017C4 RID: 6084
		private readonly ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x040017C5 RID: 6085
		[CompilerGenerated]
		private double <NotificationMaxHeight>k__BackingField;

		// Token: 0x040017C6 RID: 6086
		public const int DisplayItems = 5;

		// Token: 0x040017C7 RID: 6087
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x040017C8 RID: 6088
		[CompilerGenerated]
		private bool <PanelVisible>k__BackingField;

		// Token: 0x040017C9 RID: 6089
		[CompilerGenerated]
		private string <CountText>k__BackingField;

		// Token: 0x040017CA RID: 6090
		[CompilerGenerated]
		private double <BellOpacity>k__BackingField;

		// Token: 0x040017CB RID: 6091
		[CompilerGenerated]
		private bool <IsExpand>k__BackingField;

		// Token: 0x040017CC RID: 6092
		[CompilerGenerated]
		private ScrollBarVisibility <VerticalScrollBarVisibility>k__BackingField;

		// Token: 0x02000431 RID: 1073
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Start>d__37 : IAsyncStateMachine
		{
			// Token: 0x06002AE4 RID: 10980 RVA: 0x000879C4 File Offset: 0x00085BC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationsPanelViewModel notificationsPanelViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_B0;
						}
						awaiter = Task.Delay(TimeSpan.FromSeconds(5.0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<Start>d__37>(ref awaiter, ref this);
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
					awaiter = notificationsPanelViewModel.CountNotifications().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<Start>d__37>(ref awaiter, ref this);
						return;
					}
					IL_B0:
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

			// Token: 0x06002AE5 RID: 10981 RVA: 0x00087AE4 File Offset: 0x00085CE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017CD RID: 6093
			public int <>1__state;

			// Token: 0x040017CE RID: 6094
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017CF RID: 6095
			public NotificationsPanelViewModel <>4__this;

			// Token: 0x040017D0 RID: 6096
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000432 RID: 1074
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CountNotifications>d__38 : IAsyncStateMachine
		{
			// Token: 0x06002AE6 RID: 10982 RVA: 0x00087B00 File Offset: 0x00085D00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationsPanelViewModel notificationsPanelViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
						goto IL_8E;
					}
					case 1:
					case 2:
						IL_A2:
						try
						{
							TaskAwaiter<int> awaiter2;
							if (num != 1)
							{
								if (num == 2)
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									int num3 = -1;
									num = -1;
									this.<>1__state = num3;
									goto IL_19B;
								}
								awaiter2 = notificationsPanelViewModel._notificationService.CountEmployeeNotificationsAsync(OfflineData.Instance.Employee.Id).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num4 = 1;
									num = 1;
									this.<>1__state = num4;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, NotificationsPanelViewModel.<CountNotifications>d__38>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
							}
							int result = awaiter2.GetResult();
							this.<count>5__2 = result;
							if (notificationsPanelViewModel.Items != null && this.<count>5__2 == notificationsPanelViewModel.Items.Count)
							{
								goto IL_1A2;
							}
							awaiter = notificationsPanelViewModel.LoadNotifications().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num6 = 2;
								num = 2;
								this.<>1__state = num6;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<CountNotifications>d__38>(ref awaiter, ref this);
								return;
							}
							IL_19B:
							awaiter.GetResult();
							IL_1A2:
							notificationsPanelViewModel.SetCount(this.<count>5__2);
						}
						catch (EntityException ex)
						{
							if (ex.Message == "The underlying provider failed on Open.")
							{
								notificationsPanelViewModel._serverInfo.SetServerUnreachable();
								if (notificationsPanelViewModel._ascMessageBoxService.ShowMessageBox("Потеряно соединение с сервером.", "Server unreachable", MessageBoxButton.OK, MessageBoxImage.Hand) == MessageBoxResult.OK)
								{
									notificationsPanelViewModel._serverInfo.SetServerReachable();
								}
							}
						}
						catch (Exception ex2)
						{
							notificationsPanelViewModel._toasterService.Error(ex2.Message);
							notificationsPanelViewModel.Items.Clear();
						}
						awaiter = Task.Delay(TimeSpan.FromSeconds(2.0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 3;
							num = 3;
							this.<>1__state = num7;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<CountNotifications>d__38>(ref awaiter, ref this);
							return;
						}
						break;
					case 3:
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						int num8 = -1;
						num = -1;
						this.<>1__state = num8;
						break;
					}
					default:
						goto IL_95;
					}
					awaiter.GetResult();
					goto IL_95;
					IL_8E:
					awaiter.GetResult();
					IL_95:
					if (notificationsPanelViewModel._serverInfo.Connected)
					{
						goto IL_A2;
					}
					awaiter = Task.Delay(TimeSpan.FromSeconds(2.0)).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_8E;
					}
					int num9 = 0;
					num = 0;
					this.<>1__state = num9;
					this.<>u__1 = awaiter;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<CountNotifications>d__38>(ref awaiter, ref this);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
				}
			}

			// Token: 0x06002AE7 RID: 10983 RVA: 0x00087DF0 File Offset: 0x00085FF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017D1 RID: 6097
			public int <>1__state;

			// Token: 0x040017D2 RID: 6098
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040017D3 RID: 6099
			public NotificationsPanelViewModel <>4__this;

			// Token: 0x040017D4 RID: 6100
			private TaskAwaiter <>u__1;

			// Token: 0x040017D5 RID: 6101
			private int <count>5__2;

			// Token: 0x040017D6 RID: 6102
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x02000433 RID: 1075
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadNotifications>d__42 : IAsyncStateMachine
		{
			// Token: 0x06002AE8 RID: 10984 RVA: 0x00087E0C File Offset: 0x0008600C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationsPanelViewModel notificationsPanelViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter<IEnumerable<IAscNotification>> awaiter;
						if (num != 0)
						{
							int limit = notificationsPanelViewModel.IsExpand ? notificationsPanelViewModel.Count : 5;
							awaiter = notificationsPanelViewModel._notificationService.GetEmployeeNotifications(OfflineData.Instance.Employee.Id, limit).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscNotification>>, NotificationsPanelViewModel.<LoadNotifications>d__42>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<IAscNotification>>);
							this.<>1__state = -1;
						}
						List<IAscNotification> items = new List<IAscNotification>(awaiter.GetResult());
						notificationsPanelViewModel.SetItems(items);
					}
					catch (Exception ex)
					{
						notificationsPanelViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x06002AE9 RID: 10985 RVA: 0x00087F1C File Offset: 0x0008611C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017D7 RID: 6103
			public int <>1__state;

			// Token: 0x040017D8 RID: 6104
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040017D9 RID: 6105
			public NotificationsPanelViewModel <>4__this;

			// Token: 0x040017DA RID: 6106
			private TaskAwaiter<IEnumerable<IAscNotification>> <>u__1;
		}

		// Token: 0x02000434 RID: 1076
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <HideNotification>d__43 : IAsyncStateMachine
		{
			// Token: 0x06002AEA RID: 10986 RVA: 0x00087F38 File Offset: 0x00086138
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationsPanelViewModel notificationsPanelViewModel = this.<>4__this;
				try
				{
					IAscNotification ascNotification;
					if (num > 1)
					{
						ascNotification = (this.obj as IAscNotification);
						if (ascNotification == null)
						{
							goto IL_132;
						}
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								this.<>1__state = -1;
								goto IL_F8;
							}
							awaiter = notificationsPanelViewModel._notificationService.MarkAsRead(ascNotification.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<HideNotification>d__43>(ref awaiter, ref this);
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
						notificationsPanelViewModel.SetCount(notificationsPanelViewModel.Count - 1);
						awaiter = notificationsPanelViewModel.LoadNotifications().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<HideNotification>d__43>(ref awaiter, ref this);
							return;
						}
						IL_F8:
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						notificationsPanelViewModel._toasterService.Error(ex.Message);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_132:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06002AEB RID: 10987 RVA: 0x000880C0 File Offset: 0x000862C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017DB RID: 6107
			public int <>1__state;

			// Token: 0x040017DC RID: 6108
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017DD RID: 6109
			public object obj;

			// Token: 0x040017DE RID: 6110
			public NotificationsPanelViewModel <>4__this;

			// Token: 0x040017DF RID: 6111
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000435 RID: 1077
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ReadAll>d__46 : IAsyncStateMachine
		{
			// Token: 0x06002AEC RID: 10988 RVA: 0x000880DC File Offset: 0x000862DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationsPanelViewModel notificationsPanelViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = notificationsPanelViewModel._notificationService.MarkAllAsRead(OfflineData.Instance.Employee.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<ReadAll>d__46>(ref awaiter, ref this);
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
						notificationsPanelViewModel.SetCount(0);
					}
					catch (Exception ex)
					{
						notificationsPanelViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x06002AED RID: 10989 RVA: 0x000881D0 File Offset: 0x000863D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017E0 RID: 6112
			public int <>1__state;

			// Token: 0x040017E1 RID: 6113
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017E2 RID: 6114
			public NotificationsPanelViewModel <>4__this;

			// Token: 0x040017E3 RID: 6115
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000436 RID: 1078
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExpandList>d__48 : IAsyncStateMachine
		{
			// Token: 0x06002AEE RID: 10990 RVA: 0x000881EC File Offset: 0x000863EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationsPanelViewModel notificationsPanelViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						notificationsPanelViewModel.IsExpand = true;
						notificationsPanelViewModel.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
						awaiter = notificationsPanelViewModel.LoadNotifications().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<ExpandList>d__48>(ref awaiter, ref this);
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

			// Token: 0x06002AEF RID: 10991 RVA: 0x000882AC File Offset: 0x000864AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017E4 RID: 6116
			public int <>1__state;

			// Token: 0x040017E5 RID: 6117
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017E6 RID: 6118
			public NotificationsPanelViewModel <>4__this;

			// Token: 0x040017E7 RID: 6119
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000437 RID: 1079
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CollapseList>d__50 : IAsyncStateMachine
		{
			// Token: 0x06002AF0 RID: 10992 RVA: 0x000882C8 File Offset: 0x000864C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				NotificationsPanelViewModel notificationsPanelViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						notificationsPanelViewModel.IsExpand = false;
						notificationsPanelViewModel.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
						awaiter = notificationsPanelViewModel.LoadNotifications().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NotificationsPanelViewModel.<CollapseList>d__50>(ref awaiter, ref this);
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

			// Token: 0x06002AF1 RID: 10993 RVA: 0x00088388 File Offset: 0x00086588
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017E8 RID: 6120
			public int <>1__state;

			// Token: 0x040017E9 RID: 6121
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017EA RID: 6122
			public NotificationsPanelViewModel <>4__this;

			// Token: 0x040017EB RID: 6123
			private TaskAwaiter <>u__1;
		}
	}
}
