using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x020005A6 RID: 1446
	public class EmployeesViewModel : BaseViewModel, ICVMActions
	{
		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x000B6970 File Offset: 0x000B4B70
		// (set) Token: 0x06003593 RID: 13715 RVA: 0x000B6984 File Offset: 0x000B4B84
		public ObservableCollection<users> Users
		{
			[CompilerGenerated]
			get
			{
				return this.<Users>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Users>k__BackingField, value))
				{
					return;
				}
				this.<Users>k__BackingField = value;
				this.RaisePropertyChanged("Users");
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x000B69B4 File Offset: 0x000B4BB4
		// (set) Token: 0x06003595 RID: 13717 RVA: 0x000B69C8 File Offset: 0x000B4BC8
		public List<roles> Roles
		{
			[CompilerGenerated]
			get
			{
				return this.<Roles>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Roles>k__BackingField, value))
				{
					return;
				}
				this.<Roles>k__BackingField = value;
				this.RaisePropertyChanged("Roles");
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x000B69F8 File Offset: 0x000B4BF8
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x000B6A0C File Offset: 0x000B4C0C
		public List<IdNameClass> Offices
		{
			[CompilerGenerated]
			get
			{
				return this.<Offices>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Offices>k__BackingField, value))
				{
					return;
				}
				this.<Offices>k__BackingField = value;
				this.RaisePropertyChanged("Offices");
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x000B6A3C File Offset: 0x000B4C3C
		// (set) Token: 0x06003599 RID: 13721 RVA: 0x000B6A50 File Offset: 0x000B4C50
		public string Password
		{
			[CompilerGenerated]
			get
			{
				return this.<Password>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Password>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Password>k__BackingField = value;
				this.RaisePropertyChanged("Password");
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x000B6A80 File Offset: 0x000B4C80
		public bool DetailsEditable
		{
			get
			{
				return this.SelectedUser != null;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x000B6A98 File Offset: 0x000B4C98
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x000B6AAC File Offset: 0x000B4CAC
		public bool IsCreateNewUser
		{
			[CompilerGenerated]
			get
			{
				return this.<IsCreateNewUser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsCreateNewUser>k__BackingField == value)
				{
					return;
				}
				this.<IsCreateNewUser>k__BackingField = value;
				this.RaisePropertyChanged("IsCreateNewUser");
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x000B6AD8 File Offset: 0x000B4CD8
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x000B6AEC File Offset: 0x000B4CEC
		public List<int> UserRoles
		{
			[CompilerGenerated]
			get
			{
				return this.<UserRoles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UserRoles>k__BackingField, value))
				{
					return;
				}
				this.<UserRoles>k__BackingField = value;
				this.RaisePropertyChanged("UserRoles");
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x000B6B1C File Offset: 0x000B4D1C
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x000B6B30 File Offset: 0x000B4D30
		public List<PhoneOptions> PhoneOptions
		{
			[CompilerGenerated]
			get
			{
				return this.<PhoneOptions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PhoneOptions>k__BackingField, value))
				{
					return;
				}
				this.<PhoneOptions>k__BackingField = value;
				this.RaisePropertyChanged("PhoneOptions");
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x000999FC File Offset: 0x00097BFC
		public bool CanChangePassword
		{
			get
			{
				return OfflineData.Instance.Employee.Login == "admin";
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x000B6B60 File Offset: 0x000B4D60
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x000B6B74 File Offset: 0x000B4D74
		public bool NewLoginVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<NewLoginVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NewLoginVisible>k__BackingField == value)
				{
					return;
				}
				this.<NewLoginVisible>k__BackingField = value;
				this.RaisePropertyChanged("NewLoginVisible");
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x000B6BA0 File Offset: 0x000B4DA0
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x000B6BB4 File Offset: 0x000B4DB4
		public string NewLogin
		{
			[CompilerGenerated]
			get
			{
				return this.<NewLogin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewLogin>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewLogin>k__BackingField = value;
				this.RaisePropertyChanged("NewLogin");
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x000B6BE4 File Offset: 0x000B4DE4
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x000B6BF8 File Offset: 0x000B4DF8
		public List<kkt> Kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<Kkt>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Kkt>k__BackingField, value))
				{
					return;
				}
				this.<Kkt>k__BackingField = value;
				this.RaisePropertyChanged("Kkt");
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x000B6C28 File Offset: 0x000B4E28
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x000B6C3C File Offset: 0x000B4E3C
		public List<pinpad> Pinpads
		{
			[CompilerGenerated]
			get
			{
				return this.<Pinpads>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Pinpads>k__BackingField, value))
				{
					return;
				}
				this.<Pinpads>k__BackingField = value;
				this.RaisePropertyChanged("Pinpads");
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x000B6C6C File Offset: 0x000B4E6C
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x000B6C80 File Offset: 0x000B4E80
		public List<int> SelectedKkts
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedKkts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedKkts>k__BackingField, value))
				{
					return;
				}
				this.<SelectedKkts>k__BackingField = value;
				this.RaisePropertyChanged("SelectedKkts");
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x000B6CB0 File Offset: 0x000B4EB0
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x000B6CC4 File Offset: 0x000B4EC4
		public users SelectedUser
		{
			get
			{
				return this._selectedUser;
			}
			set
			{
				if (object.Equals(this._selectedUser, value))
				{
					return;
				}
				this._selectedUser = value;
				this.RaisePropertyChanged("DetailsEditable");
				this.RaisePropertyChanged("SelectedUser");
				if (this.SelectedUser != null)
				{
					this.GetAdditionalInfo();
				}
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x000B6D0C File Offset: 0x000B4F0C
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x000B6D20 File Offset: 0x000B4F20
		public bool ShowArhive
		{
			get
			{
				return this._showArhive;
			}
			set
			{
				if (this._showArhive == value)
				{
					return;
				}
				this._showArhive = value;
				this.RaisePropertyChanged("ShowArhive");
				this.Refresh();
			}
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x000B6D54 File Offset: 0x000B4F54
		public EmployeesViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._employeeService = Bootstrapper.Container.Resolve<IEmployeeService>();
			this.PhoneOptions = new PhoneOptions().GetAllOptions();
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x000B6DC8 File Offset: 0x000B4FC8
		private Task LoadKkts()
		{
			EmployeesViewModel.<LoadKkts>d__65 <LoadKkts>d__;
			<LoadKkts>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadKkts>d__.<>4__this = this;
			<LoadKkts>d__.<>1__state = -1;
			<LoadKkts>d__.<>t__builder.Start<EmployeesViewModel.<LoadKkts>d__65>(ref <LoadKkts>d__);
			return <LoadKkts>d__.<>t__builder.Task;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x000B6E0C File Offset: 0x000B500C
		private Task LoadPinpads()
		{
			EmployeesViewModel.<LoadPinpads>d__66 <LoadPinpads>d__;
			<LoadPinpads>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadPinpads>d__.<>4__this = this;
			<LoadPinpads>d__.<>1__state = -1;
			<LoadPinpads>d__.<>t__builder.Start<EmployeesViewModel.<LoadPinpads>d__66>(ref <LoadPinpads>d__);
			return <LoadPinpads>d__.<>t__builder.Task;
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x000B6E50 File Offset: 0x000B5050
		[Command]
		public void GenPassword()
		{
			this.Password = Generators.RandomString(8, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x000B6E70 File Offset: 0x000B5070
		[AsyncCommand]
		public Task CreateUser()
		{
			EmployeesViewModel.<CreateUser>d__68 <CreateUser>d__;
			<CreateUser>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateUser>d__.<>4__this = this;
			<CreateUser>d__.<>1__state = -1;
			<CreateUser>d__.<>t__builder.Start<EmployeesViewModel.<CreateUser>d__68>(ref <CreateUser>d__);
			return <CreateUser>d__.<>t__builder.Task;
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x000B6EB4 File Offset: 0x000B50B4
		private void GetAdditionalInfo()
		{
			EmployeesViewModel.<GetAdditionalInfo>d__69 <GetAdditionalInfo>d__;
			<GetAdditionalInfo>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GetAdditionalInfo>d__.<>4__this = this;
			<GetAdditionalInfo>d__.<>1__state = -1;
			<GetAdditionalInfo>d__.<>t__builder.Start<EmployeesViewModel.<GetAdditionalInfo>d__69>(ref <GetAdditionalInfo>d__);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x000B6EEC File Offset: 0x000B50EC
		private List<kkt> GetSelectedKkts()
		{
			if (this.Kkt != null && this.Kkt.Any<kkt>() && this.SelectedKkts != null)
			{
				return (from k in this.Kkt
				where this.SelectedKkts.Contains(k.id)
				select k).ToList<kkt>();
			}
			return new List<kkt>();
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x000B6F38 File Offset: 0x000B5138
		[AsyncCommand]
		public Task UpdateUser()
		{
			EmployeesViewModel.<UpdateUser>d__71 <UpdateUser>d__;
			<UpdateUser>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateUser>d__.<>4__this = this;
			<UpdateUser>d__.<>1__state = -1;
			<UpdateUser>d__.<>t__builder.Start<EmployeesViewModel.<UpdateUser>d__71>(ref <UpdateUser>d__);
			return <UpdateUser>d__.<>t__builder.Task;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanUpdateUser()
		{
			return true;
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x000B6F7C File Offset: 0x000B517C
		[Command]
		public void Cancell()
		{
			this.ClearUser();
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x000B6F9C File Offset: 0x000B519C
		private void ClearUser()
		{
			this.SelectedUser = null;
			this.IsCreateNewUser = false;
			this.UserRoles = new List<int>();
			this.Password = string.Empty;
			this.NewLoginVisible = false;
			this.NewLogin = "";
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x000B6FE0 File Offset: 0x000B51E0
		[Command]
		public void NewUser()
		{
			if (OfflineData.Instance.Employee.Login != "admin")
			{
				this._toasterService.Info(Lang.t("OnlyAdminCanCreateEmployee"));
				return;
			}
			if (this.Users.Count >= Auth.MaxUsers)
			{
				this._toasterService.Info(Lang.t("MaximumNumberOfEmployeesReached"));
				return;
			}
			this.SelectedUser = UsersModel.DefaultUser();
			this.IsCreateNewUser = true;
			this._windowedDocumentService.ShowNewDocument("EmployeeEditView", this, null, null);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x000B706C File Offset: 0x000B526C
		public bool CanNewUser()
		{
			return this.Users != null;
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x000B7084 File Offset: 0x000B5284
		private bool CheckFields(bool existUserUpdate = false)
		{
			if (string.IsNullOrEmpty(this.SelectedUser.username))
			{
				this._toasterService.Info(Lang.t("EmptyUsername"));
				return false;
			}
			if (this.Users != null && !existUserUpdate)
			{
				if ((from u in this.Users
				select u.username).ToList<string>().Contains(this.SelectedUser.username))
				{
					this._toasterService.Info(Lang.t("UsernameExist"));
					return false;
				}
			}
			if (!existUserUpdate && (string.IsNullOrEmpty(this.Password) || this.Password.Length <= 4))
			{
				this._toasterService.Info(Lang.t("EmptyPassword"));
				return false;
			}
			if (string.IsNullOrEmpty(this.SelectedUser.name))
			{
				this._toasterService.Info(Lang.t("EmptyName"));
				return false;
			}
			if (this.SelectedUser.office == 0)
			{
				this._toasterService.Info(Lang.t("NoOffice"));
				return false;
			}
			if (this.SelectedUser.id == Auth.User.id && this.SelectedUser.IsArchive)
			{
				this._toasterService.Info(Lang.t("ArchUserWarning"));
				this.SelectedUser.IsArchive = false;
				return false;
			}
			if (!string.IsNullOrEmpty(this.Password) && Auth.User.username != "admin")
			{
				this._toasterService.Info(Lang.t("ChangePasswordWarning"));
				return false;
			}
			List<kkt> selectedKkts = this.GetSelectedKkts();
			if (selectedKkts != null && selectedKkts.Count > 1)
			{
				if ((from k in selectedKkts
				group k by k.office).Any((IGrouping<int?, kkt> k) => k.Count<kkt>() > 1))
				{
					this._toasterService.Info("ККТ должны быть в разных офисах");
					return false;
				}
			}
			return true;
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000B7298 File Offset: 0x000B5498
		[Command]
		public void Loaded()
		{
			EmployeesViewModel.<Loaded>d__78 <Loaded>d__;
			<Loaded>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Loaded>d__.<>4__this = this;
			<Loaded>d__.<>1__state = -1;
			<Loaded>d__.<>t__builder.Start<EmployeesViewModel.<Loaded>d__78>(ref <Loaded>d__);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x000B72D0 File Offset: 0x000B54D0
		private void LoadUsers()
		{
			base.ShowWait();
			Task.Run<IEnumerable<users>>(() => this._employeeService.GetEmployeesForAcp(this.ShowArhive)).ContinueWith(delegate(Task<IEnumerable<users>> t)
			{
				this.Users = new ObservableCollection<users>(t.Result);
				base.HideWait();
			});
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x000B7308 File Offset: 0x000B5508
		[Command]
		public void OpenCard()
		{
			if (this.SelectedUser == null)
			{
				return;
			}
			this._windowedDocumentService.ShowNewDocument("EmployeeEditView", this, null, null);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x000B7334 File Offset: 0x000B5534
		[Command]
		public void ShowNewLogin()
		{
			this.NewLoginVisible = true;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x000B7348 File Offset: 0x000B5548
		public bool CanShowNewLogin()
		{
			return OfflineData.Instance.Employee.Login == "admin" && this.SelectedUser != null && this.SelectedUser.id > 0 && this.SelectedUser.username != "admin";
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0007E558 File Offset: 0x0007C758
		public void Save()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x000304B4 File Offset: 0x0002E6B4
		public bool CanSave()
		{
			return false;
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x000B73A0 File Offset: 0x000B55A0
		public void Refresh()
		{
			this.LoadUsers();
			this.ClearUser();
			base.RaiseCanExecuteChanged(() => this.NewUser());
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool CanRefresh()
		{
			return true;
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0009582C File Offset: 0x00093A2C
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			ACPV2ViewModel acpv2ViewModel = parentViewModel as ACPV2ViewModel;
			if (acpv2ViewModel != null)
			{
				acpv2ViewModel.SetChildViewModel(this);
			}
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x000B73F4 File Offset: 0x000B55F4
		[CompilerGenerated]
		private bool <GetSelectedKkts>b__70_0(kkt k)
		{
			return this.SelectedKkts.Contains(k.id);
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x000B7414 File Offset: 0x000B5614
		[CompilerGenerated]
		private Task<IEnumerable<users>> <LoadUsers>b__79_0()
		{
			return this._employeeService.GetEmployeesForAcp(this.ShowArhive);
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x000B7434 File Offset: 0x000B5634
		[CompilerGenerated]
		private void <LoadUsers>b__79_1(Task<IEnumerable<users>> t)
		{
			this.Users = new ObservableCollection<users>(t.Result);
			base.HideWait();
		}

		// Token: 0x04001ED3 RID: 7891
		private readonly IToasterService _toasterService;

		// Token: 0x04001ED4 RID: 7892
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001ED5 RID: 7893
		private readonly IEmployeeService _employeeService;

		// Token: 0x04001ED6 RID: 7894
		private readonly UsersModel _usersModel = new UsersModel();

		// Token: 0x04001ED7 RID: 7895
		private users _selectedUser;

		// Token: 0x04001ED8 RID: 7896
		private bool _showArhive;

		// Token: 0x04001ED9 RID: 7897
		[CompilerGenerated]
		private ObservableCollection<users> <Users>k__BackingField;

		// Token: 0x04001EDA RID: 7898
		[CompilerGenerated]
		private List<roles> <Roles>k__BackingField;

		// Token: 0x04001EDB RID: 7899
		[CompilerGenerated]
		private List<IdNameClass> <Offices>k__BackingField;

		// Token: 0x04001EDC RID: 7900
		[CompilerGenerated]
		private string <Password>k__BackingField;

		// Token: 0x04001EDD RID: 7901
		[CompilerGenerated]
		private bool <IsCreateNewUser>k__BackingField;

		// Token: 0x04001EDE RID: 7902
		[CompilerGenerated]
		private List<int> <UserRoles>k__BackingField = new List<int>();

		// Token: 0x04001EDF RID: 7903
		[CompilerGenerated]
		private List<PhoneOptions> <PhoneOptions>k__BackingField;

		// Token: 0x04001EE0 RID: 7904
		[CompilerGenerated]
		private bool <NewLoginVisible>k__BackingField;

		// Token: 0x04001EE1 RID: 7905
		[CompilerGenerated]
		private string <NewLogin>k__BackingField;

		// Token: 0x04001EE2 RID: 7906
		[CompilerGenerated]
		private List<kkt> <Kkt>k__BackingField;

		// Token: 0x04001EE3 RID: 7907
		[CompilerGenerated]
		private List<pinpad> <Pinpads>k__BackingField;

		// Token: 0x04001EE4 RID: 7908
		[CompilerGenerated]
		private List<int> <SelectedKkts>k__BackingField = new List<int>();

		// Token: 0x020005A7 RID: 1447
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadKkts>d__65 : IAsyncStateMachine
		{
			// Token: 0x060035CB RID: 13771 RVA: 0x000B7458 File Offset: 0x000B5658
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeesViewModel employeesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<kkt>> awaiter;
					if (num != 0)
					{
						awaiter = KassaModel.GetAllKkt().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<kkt>>, EmployeesViewModel.<LoadKkts>d__65>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<kkt>>);
						this.<>1__state = -1;
					}
					IEnumerable<kkt> result = awaiter.GetResult();
					employeesViewModel.Kkt = new List<kkt>(result);
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

			// Token: 0x060035CC RID: 13772 RVA: 0x000B7518 File Offset: 0x000B5718
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EE5 RID: 7909
			public int <>1__state;

			// Token: 0x04001EE6 RID: 7910
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001EE7 RID: 7911
			public EmployeesViewModel <>4__this;

			// Token: 0x04001EE8 RID: 7912
			private TaskAwaiter<IEnumerable<kkt>> <>u__1;
		}

		// Token: 0x020005A8 RID: 1448
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPinpads>d__66 : IAsyncStateMachine
		{
			// Token: 0x060035CD RID: 13773 RVA: 0x000B7534 File Offset: 0x000B5734
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeesViewModel employeesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<pinpad>> awaiter;
					if (num != 0)
					{
						awaiter = KassaModel.GetAllPinpads().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<pinpad>>, EmployeesViewModel.<LoadPinpads>d__66>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<pinpad>>);
						this.<>1__state = -1;
					}
					IEnumerable<pinpad> result = awaiter.GetResult();
					employeesViewModel.Pinpads = new List<pinpad>(result);
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

			// Token: 0x060035CE RID: 13774 RVA: 0x000B75F4 File Offset: 0x000B57F4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EE9 RID: 7913
			public int <>1__state;

			// Token: 0x04001EEA RID: 7914
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001EEB RID: 7915
			public EmployeesViewModel <>4__this;

			// Token: 0x04001EEC RID: 7916
			private TaskAwaiter<IEnumerable<pinpad>> <>u__1;
		}

		// Token: 0x020005A9 RID: 1449
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateUser>d__68 : IAsyncStateMachine
		{
			// Token: 0x060035CF RID: 13775 RVA: 0x000B7610 File Offset: 0x000B5810
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeesViewModel employeesViewModel = this.<>4__this;
				try
				{
					if (num == 0 || employeesViewModel.CheckFields(false))
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = employeesViewModel._usersModel.CreateUser(employeesViewModel.SelectedUser, employeesViewModel.Password, employeesViewModel.UserRoles, employeesViewModel.GetSelectedKkts()).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, EmployeesViewModel.<CreateUser>d__68>(ref awaiter, ref this);
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
							employeesViewModel.Refresh();
							employeesViewModel._windowedDocumentService.CloseActiveDocument();
							OfflineData.Instance.ReloadUsers();
							employeesViewModel._toasterService.Success(Lang.t("Complete"));
						}
						catch (Exception ex)
						{
							employeesViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x060035D0 RID: 13776 RVA: 0x000B7748 File Offset: 0x000B5948
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EED RID: 7917
			public int <>1__state;

			// Token: 0x04001EEE RID: 7918
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001EEF RID: 7919
			public EmployeesViewModel <>4__this;

			// Token: 0x04001EF0 RID: 7920
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020005AA RID: 1450
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAdditionalInfo>d__69 : IAsyncStateMachine
		{
			// Token: 0x060035D1 RID: 13777 RVA: 0x000B7764 File Offset: 0x000B5964
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeesViewModel employeesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<int>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<int>>);
							this.<>1__state = -1;
							goto IL_DF;
						}
						awaiter = UsersModel.LoadUserRoleIds(employeesViewModel.SelectedUser.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, EmployeesViewModel.<GetAdditionalInfo>d__69>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<int>>);
						this.<>1__state = -1;
					}
					List<int> result = awaiter.GetResult();
					employeesViewModel.UserRoles = result;
					awaiter = UsersModel.GetEmployeeKkt(employeesViewModel.SelectedUser.id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, EmployeesViewModel.<GetAdditionalInfo>d__69>(ref awaiter, ref this);
						return;
					}
					IL_DF:
					result = awaiter.GetResult();
					employeesViewModel.SelectedKkts = result;
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

			// Token: 0x060035D2 RID: 13778 RVA: 0x000B78A0 File Offset: 0x000B5AA0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EF1 RID: 7921
			public int <>1__state;

			// Token: 0x04001EF2 RID: 7922
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001EF3 RID: 7923
			public EmployeesViewModel <>4__this;

			// Token: 0x04001EF4 RID: 7924
			private TaskAwaiter<List<int>> <>u__1;
		}

		// Token: 0x020005AB RID: 1451
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateUser>d__71 : IAsyncStateMachine
		{
			// Token: 0x060035D3 RID: 13779 RVA: 0x000B78BC File Offset: 0x000B5ABC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeesViewModel employeesViewModel = this.<>4__this;
				try
				{
					if (num == 0 || employeesViewModel.CheckFields(true))
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = employeesViewModel._usersModel.UpdateUser(employeesViewModel.SelectedUser, employeesViewModel.UserRoles, employeesViewModel.Password, employeesViewModel.NewLogin, employeesViewModel.GetSelectedKkts()).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, EmployeesViewModel.<UpdateUser>d__71>(ref awaiter, ref this);
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
							employeesViewModel._windowedDocumentService.CloseActiveDocument();
							employeesViewModel.ClearUser();
							employeesViewModel.LoadUsers();
							OfflineData.Instance.ReloadUsers();
							employeesViewModel._toasterService.Success(Lang.t("Saved"));
						}
						catch (Exception ex)
						{
							employeesViewModel._toasterService.Error(ex.Message);
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

			// Token: 0x060035D4 RID: 13780 RVA: 0x000B7A00 File Offset: 0x000B5C00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EF5 RID: 7925
			public int <>1__state;

			// Token: 0x04001EF6 RID: 7926
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001EF7 RID: 7927
			public EmployeesViewModel <>4__this;

			// Token: 0x04001EF8 RID: 7928
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020005AC RID: 1452
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060035D5 RID: 13781 RVA: 0x000B7A1C File Offset: 0x000B5C1C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060035D6 RID: 13782 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060035D7 RID: 13783 RVA: 0x000B7A34 File Offset: 0x000B5C34
			internal string <CheckFields>b__77_0(users u)
			{
				return u.username;
			}

			// Token: 0x060035D8 RID: 13784 RVA: 0x000B7A48 File Offset: 0x000B5C48
			internal int? <CheckFields>b__77_1(kkt k)
			{
				return k.office;
			}

			// Token: 0x060035D9 RID: 13785 RVA: 0x000B7A5C File Offset: 0x000B5C5C
			internal bool <CheckFields>b__77_2(IGrouping<int?, kkt> k)
			{
				return k.Count<kkt>() > 1;
			}

			// Token: 0x04001EF9 RID: 7929
			public static readonly EmployeesViewModel.<>c <>9 = new EmployeesViewModel.<>c();

			// Token: 0x04001EFA RID: 7930
			public static Func<users, string> <>9__77_0;

			// Token: 0x04001EFB RID: 7931
			public static Func<kkt, int?> <>9__77_1;

			// Token: 0x04001EFC RID: 7932
			public static Func<IGrouping<int?, kkt>, bool> <>9__77_2;
		}

		// Token: 0x020005AD RID: 1453
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Loaded>d__78 : IAsyncStateMachine
		{
			// Token: 0x060035DA RID: 13786 RVA: 0x000B7A74 File Offset: 0x000B5C74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmployeesViewModel employeesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<roles>> awaiter;
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<roles>>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_F1;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_14C;
					default:
						awaiter = employeesViewModel._usersModel.LoadRoles().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<roles>>, EmployeesViewModel.<Loaded>d__78>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<roles> result = awaiter.GetResult();
					employeesViewModel.Roles = result;
					employeesViewModel.Offices = OfficesModel.LoadOffices(false);
					employeesViewModel.LoadUsers();
					awaiter2 = employeesViewModel.LoadKkts().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, EmployeesViewModel.<Loaded>d__78>(ref awaiter2, ref this);
						return;
					}
					IL_F1:
					awaiter2.GetResult();
					awaiter2 = employeesViewModel.LoadPinpads().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__2 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, EmployeesViewModel.<Loaded>d__78>(ref awaiter2, ref this);
						return;
					}
					IL_14C:
					awaiter2.GetResult();
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

			// Token: 0x060035DB RID: 13787 RVA: 0x000B7C20 File Offset: 0x000B5E20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EFD RID: 7933
			public int <>1__state;

			// Token: 0x04001EFE RID: 7934
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001EFF RID: 7935
			public EmployeesViewModel <>4__this;

			// Token: 0x04001F00 RID: 7936
			private TaskAwaiter<List<roles>> <>u__1;

			// Token: 0x04001F01 RID: 7937
			private TaskAwaiter <>u__2;
		}
	}
}
