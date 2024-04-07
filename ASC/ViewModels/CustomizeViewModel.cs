using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Properties;
using ASC.SimpleClasses;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.WindowsUI;

namespace ASC.ViewModels
{
	// Token: 0x0200049D RID: 1181
	public class CustomizeViewModel : BaseViewModel, ICVMActions
	{
		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x000953C8 File Offset: 0x000935C8
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x000953DC File Offset: 0x000935DC
		public List<ImportOptions> AllImportOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<AllImportOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AllImportOptionses>k__BackingField, value))
				{
					return;
				}
				this.<AllImportOptionses>k__BackingField = value;
				this.RaisePropertyChanged("AllImportOptionses");
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x0009540C File Offset: 0x0009360C
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x00095420 File Offset: 0x00093620
		public List<KeyValuePair<string, string>> Animations
		{
			[CompilerGenerated]
			get
			{
				return this.<Animations>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Animations>k__BackingField, value))
				{
					return;
				}
				this.<Animations>k__BackingField = value;
				this.RaisePropertyChanged("Animations");
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x00095450 File Offset: 0x00093650
		// (set) Token: 0x06002DEA RID: 11754 RVA: 0x00095464 File Offset: 0x00093664
		public IUISettings UiSettings
		{
			[CompilerGenerated]
			get
			{
				return this.<UiSettings>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UiSettings>k__BackingField, value))
				{
					return;
				}
				this.<UiSettings>k__BackingField = value;
				this.RaisePropertyChanged("UiSettings");
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x00095494 File Offset: 0x00093694
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x000954A8 File Offset: 0x000936A8
		public int TabIndex
		{
			[CompilerGenerated]
			get
			{
				return this.<TabIndex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TabIndex>k__BackingField == value)
				{
					return;
				}
				this.<TabIndex>k__BackingField = value;
				this.RaisePropertyChanged("TabIndex");
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000954D4 File Offset: 0x000936D4
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x000954E8 File Offset: 0x000936E8
		public users User
		{
			[CompilerGenerated]
			get
			{
				return this.<User>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<User>k__BackingField, value))
				{
					return;
				}
				this.<User>k__BackingField = value;
				this.RaisePropertyChanged("User");
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x00095518 File Offset: 0x00093718
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x0009552C File Offset: 0x0009372C
		public List<string> Printers
		{
			[CompilerGenerated]
			get
			{
				return this.<Printers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Printers>k__BackingField, value))
				{
					return;
				}
				this.<Printers>k__BackingField = value;
				this.RaisePropertyChanged("Printers");
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x0009555C File Offset: 0x0009375C
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x00095570 File Offset: 0x00093770
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
				int num = 1281051494;
				IL_13:
				switch ((num ^ 7281068) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					num = 256549717;
					goto IL_13;
				}
				this.<Stores>k__BackingField = value;
				this.RaisePropertyChanged("Stores");
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000955CC File Offset: 0x000937CC
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x000955E0 File Offset: 0x000937E0
		public List<UserMaster> Users
		{
			[CompilerGenerated]
			get
			{
				return this.<Users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Users>k__BackingField, value))
				{
					return;
				}
				this.<Users>k__BackingField = value;
				this.RaisePropertyChanged("Users");
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x00095610 File Offset: 0x00093810
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x00095624 File Offset: 0x00093824
		public List<WorkshopOptions> WorkshopOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopOptions>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<WorkshopOptions>k__BackingField, value))
				{
					return;
				}
				this.<WorkshopOptions>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopOptions");
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x00095654 File Offset: 0x00093854
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x00095668 File Offset: 0x00093868
		public List<IIdName> WorkshopDevices
		{
			[CompilerGenerated]
			get
			{
				return this.<WorkshopDevices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WorkshopDevices>k__BackingField, value))
				{
					return;
				}
				this.<WorkshopDevices>k__BackingField = value;
				this.RaisePropertyChanged("WorkshopDevices");
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		public bool CanOfficeSelect
		{
			get
			{
				return OfflineData.Instance.Employee.Can(23, 0);
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x00095698 File Offset: 0x00093898
		public bool CanUserSelect
		{
			get
			{
				return this.CanOfficeSelect;
			}
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x000956AC File Offset: 0x000938AC
		public CustomizeViewModel()
		{
			this.SetViewName("PersonalSettings");
			this.User = Auth.User;
			this.UiSettings = new UiSettings(OfflineData.Instance.Employee);
			this.LoadAnimationTypes();
			if (!OfflineData.Instance.Employee.Can(23, 0))
			{
				this.User.def_office = OfflineData.Instance.Employee.OfficeId;
				this.User.def_employee = OfflineData.Instance.Employee.Id;
			}
			this.AllImportOptionses = this.ImportOptions.GetAllOptions();
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00095760 File Offset: 0x00093960
		private void LoadAnimationTypes()
		{
			this.Animations = CustomizeModel.GetAnimationTypes();
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00095778 File Offset: 0x00093978
		public override void OnLoad()
		{
			CustomizeViewModel.<OnLoad>d__47 <OnLoad>d__;
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<CustomizeViewModel.<OnLoad>d__47>(ref <OnLoad>d__);
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x000957B0 File Offset: 0x000939B0
		private Task BgInit()
		{
			CustomizeViewModel.<BgInit>d__48 <BgInit>d__;
			<BgInit>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<BgInit>d__.<>4__this = this;
			<BgInit>d__.<>1__state = -1;
			<BgInit>d__.<>t__builder.Start<CustomizeViewModel.<BgInit>d__48>(ref <BgInit>d__);
			return <BgInit>d__.<>t__builder.Task;
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000957F4 File Offset: 0x000939F4
		[Command]
		public void RestoreDefaults(AppBarButton obj)
		{
			CustomizeViewModel.<RestoreDefaults>d__49 <RestoreDefaults>d__;
			<RestoreDefaults>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RestoreDefaults>d__.<>4__this = this;
			<RestoreDefaults>d__.<>1__state = -1;
			<RestoreDefaults>d__.<>t__builder.Start<CustomizeViewModel.<RestoreDefaults>d__49>(ref <RestoreDefaults>d__);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x0009582C File Offset: 0x00093A2C
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			ACPV2ViewModel acpv2ViewModel = parentViewModel as ACPV2ViewModel;
			if (acpv2ViewModel != null)
			{
				acpv2ViewModel.SetChildViewModel(this);
			}
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00095854 File Offset: 0x00093A54
		public void Save()
		{
			CustomizeViewModel.<Save>d__51 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<CustomizeViewModel.<Save>d__51>(ref <Save>d__);
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanSave()
		{
			return true;
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x0007E558 File Offset: 0x0007C758
		public void Refresh()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanRefresh()
		{
			return false;
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x0003401C File Offset: 0x0003221C
		[CompilerGenerated]
		[DebuggerHidden]
		private void <>n__0()
		{
			base.OnLoad();
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x0009588C File Offset: 0x00093A8C
		[CompilerGenerated]
		private bool <Save>b__51_0()
		{
			return UsersModel.SaveUserSettings(this.User);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000958A4 File Offset: 0x00093AA4
		[CompilerGenerated]
		private bool <Save>b__51_1()
		{
			return OfflineData.Instance.Employee.SaveUiSettings(this.UiSettings);
		}

		// Token: 0x040019D1 RID: 6609
		private ImportOptions ImportOptions = new ImportOptions();

		// Token: 0x040019D2 RID: 6610
		[CompilerGenerated]
		private List<ImportOptions> <AllImportOptionses>k__BackingField;

		// Token: 0x040019D3 RID: 6611
		[CompilerGenerated]
		private List<KeyValuePair<string, string>> <Animations>k__BackingField;

		// Token: 0x040019D4 RID: 6612
		[CompilerGenerated]
		private IUISettings <UiSettings>k__BackingField;

		// Token: 0x040019D5 RID: 6613
		[CompilerGenerated]
		private int <TabIndex>k__BackingField;

		// Token: 0x040019D6 RID: 6614
		[CompilerGenerated]
		private users <User>k__BackingField;

		// Token: 0x040019D7 RID: 6615
		[CompilerGenerated]
		private List<string> <Printers>k__BackingField = new List<string>();

		// Token: 0x040019D8 RID: 6616
		[CompilerGenerated]
		private List<stores> <Stores>k__BackingField;

		// Token: 0x040019D9 RID: 6617
		[CompilerGenerated]
		private List<UserMaster> <Users>k__BackingField;

		// Token: 0x040019DA RID: 6618
		[CompilerGenerated]
		private List<WorkshopOptions> <WorkshopOptions>k__BackingField;

		// Token: 0x040019DB RID: 6619
		[CompilerGenerated]
		private List<IIdName> <WorkshopDevices>k__BackingField;

		// Token: 0x0200049E RID: 1182
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnLoad>d__47 : IAsyncStateMachine
		{
			// Token: 0x06002E08 RID: 11784 RVA: 0x000958C8 File Offset: 0x00093AC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomizeViewModel customizeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						customizeViewModel.<>n__0();
						awaiter = customizeViewModel.BgInit().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CustomizeViewModel.<OnLoad>d__47>(ref awaiter, ref this);
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

			// Token: 0x06002E09 RID: 11785 RVA: 0x00095980 File Offset: 0x00093B80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019DC RID: 6620
			public int <>1__state;

			// Token: 0x040019DD RID: 6621
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040019DE RID: 6622
			public CustomizeViewModel <>4__this;

			// Token: 0x040019DF RID: 6623
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200049F RID: 1183
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002E0A RID: 11786 RVA: 0x0009599C File Offset: 0x00093B9C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002E0B RID: 11787 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002E0C RID: 11788 RVA: 0x00089794 File Offset: 0x00087994
			internal Task<List<stores>> <BgInit>b__48_0()
			{
				return StoreModel.LoadStores(false, true);
			}

			// Token: 0x06002E0D RID: 11789 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
			internal IEnumerable<UserMaster> <BgInit>b__48_1()
			{
				return UsersModel.LoadMasterManagers();
			}

			// Token: 0x06002E0E RID: 11790 RVA: 0x000959B4 File Offset: 0x00093BB4
			internal Task<bool> <RestoreDefaults>b__49_0()
			{
				return OfflineData.Instance.Employee.RestoreUiDefaults();
			}

			// Token: 0x040019E0 RID: 6624
			public static readonly CustomizeViewModel.<>c <>9 = new CustomizeViewModel.<>c();

			// Token: 0x040019E1 RID: 6625
			public static Func<Task<List<stores>>> <>9__48_0;

			// Token: 0x040019E2 RID: 6626
			public static Func<IEnumerable<UserMaster>> <>9__48_1;

			// Token: 0x040019E3 RID: 6627
			public static Func<Task<bool>> <>9__49_0;
		}

		// Token: 0x020004A0 RID: 1184
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <BgInit>d__48 : IAsyncStateMachine
		{
			// Token: 0x06002E0F RID: 11791 RVA: 0x000959D0 File Offset: 0x00093BD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomizeViewModel customizeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<UserMaster>> awaiter;
					TaskAwaiter<List<stores>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<IEnumerable<UserMaster>>);
							this.<>1__state = -1;
							goto IL_100;
						}
						customizeViewModel.ShowWait();
						customizeViewModel.WorkshopDevices = RepairModel.GetRepairGridModes();
						awaiter2 = Task.Run<List<stores>>(new Func<Task<List<stores>>>(CustomizeViewModel.<>c.<>9.<BgInit>b__48_0)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<stores>>, CustomizeViewModel.<BgInit>d__48>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<stores>>);
						this.<>1__state = -1;
					}
					List<stores> result = awaiter2.GetResult();
					customizeViewModel.Stores = result;
					awaiter = Task.Run<IEnumerable<UserMaster>>(new Func<IEnumerable<UserMaster>>(CustomizeViewModel.<>c.<>9.<BgInit>b__48_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<UserMaster>>, CustomizeViewModel.<BgInit>d__48>(ref awaiter, ref this);
						return;
					}
					IL_100:
					IEnumerable<UserMaster> result2 = awaiter.GetResult();
					customizeViewModel.Users = new List<UserMaster>(result2);
					customizeViewModel.WorkshopOptions = new WorkshopOptions().GetAllOptionsWithDummy();
					if (customizeViewModel.User.def_status == null)
					{
						customizeViewModel.User.def_status = new int?(99);
					}
					List<string> printers = PrinterSettings.InstalledPrinters.Cast<string>().ToList<string>();
					customizeViewModel.Printers = printers;
					customizeViewModel.HideWait();
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

			// Token: 0x06002E10 RID: 11792 RVA: 0x00095BB4 File Offset: 0x00093DB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019E4 RID: 6628
			public int <>1__state;

			// Token: 0x040019E5 RID: 6629
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040019E6 RID: 6630
			public CustomizeViewModel <>4__this;

			// Token: 0x040019E7 RID: 6631
			private TaskAwaiter<List<stores>> <>u__1;

			// Token: 0x040019E8 RID: 6632
			private TaskAwaiter<IEnumerable<UserMaster>> <>u__2;
		}

		// Token: 0x020004A1 RID: 1185
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RestoreDefaults>d__49 : IAsyncStateMachine
		{
			// Token: 0x06002E11 RID: 11793 RVA: 0x00095BD0 File Offset: 0x00093DD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomizeViewModel customizeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<bool>(new Func<Task<bool>>(CustomizeViewModel.<>c.<>9.<RestoreDefaults>b__49_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, CustomizeViewModel.<RestoreDefaults>d__49>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter.GetResult();
					customizeViewModel.ShowActionResponse(result, "");
					if (result)
					{
						customizeViewModel.UiSettings = new UiSettings(OfflineData.Instance.Employee);
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

			// Token: 0x06002E12 RID: 11794 RVA: 0x00095CC8 File Offset: 0x00093EC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019E9 RID: 6633
			public int <>1__state;

			// Token: 0x040019EA RID: 6634
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040019EB RID: 6635
			public CustomizeViewModel <>4__this;

			// Token: 0x040019EC RID: 6636
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020004A2 RID: 1186
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__51 : IAsyncStateMachine
		{
			// Token: 0x06002E13 RID: 11795 RVA: 0x00095CE4 File Offset: 0x00093EE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CustomizeViewModel customizeViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							this.<>1__state = -1;
							goto IL_FC;
						}
						customizeViewModel.ShowWait();
						Settings.Default.Save();
						awaiter = Task.Run<bool>(() => UsersModel.SaveUserSettings(base.User)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, CustomizeViewModel.<Save>d__51>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
					}
					bool result = awaiter.GetResult();
					this.<result1>5__2 = result;
					awaiter = Task.Run<bool>(() => OfflineData.Instance.Employee.SaveUiSettings(base.UiSettings)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, CustomizeViewModel.<Save>d__51>(ref awaiter, ref this);
						return;
					}
					IL_FC:
					bool result2 = awaiter.GetResult();
					bool response;
					if (response = (this.<result1>5__2 && result2))
					{
						UsersModel.ReloadCurrentUser();
					}
					customizeViewModel.HideWait();
					customizeViewModel.ShowActionResponse(response, "");
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

			// Token: 0x06002E14 RID: 11796 RVA: 0x00095E64 File Offset: 0x00094064
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040019ED RID: 6637
			public int <>1__state;

			// Token: 0x040019EE RID: 6638
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040019EF RID: 6639
			public CustomizeViewModel <>4__this;

			// Token: 0x040019F0 RID: 6640
			private bool <result1>5__2;

			// Token: 0x040019F1 RID: 6641
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
