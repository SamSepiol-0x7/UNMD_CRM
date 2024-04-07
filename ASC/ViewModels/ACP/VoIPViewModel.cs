using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ASC.Interfaces;
using ASC.Models;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using Microsoft.Win32;

namespace ASC.ViewModels.ACP
{
	// Token: 0x020005B1 RID: 1457
	public class VoIPViewModel : BaseViewModel, IRefreshable
	{
		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x000B8320 File Offset: 0x000B6520
		// (set) Token: 0x060035FF RID: 13823 RVA: 0x000B8334 File Offset: 0x000B6534
		public config Config
		{
			[CompilerGenerated]
			get
			{
				return this.<Config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Config>k__BackingField, value))
				{
					return;
				}
				this.<Config>k__BackingField = value;
				this.RaisePropertyChanged("Config");
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x000B8364 File Offset: 0x000B6564
		// (set) Token: 0x06003601 RID: 13825 RVA: 0x000B8378 File Offset: 0x000B6578
		public List<ps_endpoints> ZadarmaEndpointses
		{
			[CompilerGenerated]
			get
			{
				return this.<ZadarmaEndpointses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ZadarmaEndpointses>k__BackingField, value))
				{
					return;
				}
				this.<ZadarmaEndpointses>k__BackingField = value;
				this.RaisePropertyChanged("ZadarmaEndpointses");
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x000B83A8 File Offset: 0x000B65A8
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x000B83BC File Offset: 0x000B65BC
		public ps_endpoints SelectedZadarmaEndpoint
		{
			get
			{
				return this._selectedZadarmaEndpoint;
			}
			set
			{
				if (object.Equals(this._selectedZadarmaEndpoint, value))
				{
					return;
				}
				this._selectedZadarmaEndpoint = value;
				this.RaisePropertyChanged("TrunkSelected");
				this.RaisePropertyChanged("SelectedZadarmaEndpoint");
				if (value != null)
				{
					this.LoadZadarmaAor(value.id.ToString());
				}
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x000B840C File Offset: 0x000B660C
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x000B8420 File Offset: 0x000B6620
		public ps_aors SelectedZadarmaAor
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedZadarmaAor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedZadarmaAor>k__BackingField, value))
				{
					return;
				}
				this.<SelectedZadarmaAor>k__BackingField = value;
				this.RaisePropertyChanged("SelectedZadarmaAor");
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x000B8450 File Offset: 0x000B6650
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x000B8464 File Offset: 0x000B6664
		public ps_endpoints NewZadarmaEndpoint
		{
			[CompilerGenerated]
			get
			{
				return this.<NewZadarmaEndpoint>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NewZadarmaEndpoint>k__BackingField, value))
				{
					return;
				}
				this.<NewZadarmaEndpoint>k__BackingField = value;
				this.RaisePropertyChanged("NewZadarmaEndpoint");
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x000B8494 File Offset: 0x000B6694
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x000B84A8 File Offset: 0x000B66A8
		public string NewZadarmaAorContact
		{
			[CompilerGenerated]
			get
			{
				return this.<NewZadarmaAorContact>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewZadarmaAorContact>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewZadarmaAorContact>k__BackingField = value;
				this.RaisePropertyChanged("NewZadarmaAorContact");
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x000B84D8 File Offset: 0x000B66D8
		public bool TrunkSelected
		{
			get
			{
				return this.SelectedZadarmaEndpoint != null;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x000B84F0 File Offset: 0x000B66F0
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x000B8504 File Offset: 0x000B6704
		public List<string> EndpointCodecs
		{
			[CompilerGenerated]
			get
			{
				return this.<EndpointCodecs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<EndpointCodecs>k__BackingField, value))
				{
					return;
				}
				this.<EndpointCodecs>k__BackingField = value;
				this.RaisePropertyChanged("EndpointCodecs");
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x000B8534 File Offset: 0x000B6734
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x000B8548 File Offset: 0x000B6748
		public List<string> Contextsts
		{
			[CompilerGenerated]
			get
			{
				return this.<Contextsts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Contextsts>k__BackingField, value))
				{
					return;
				}
				this.<Contextsts>k__BackingField = value;
				this.RaisePropertyChanged("Contextsts");
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x000B8578 File Offset: 0x000B6778
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x000B858C File Offset: 0x000B678C
		public List<ExtenVisObj> ExtenVisObjs
		{
			[CompilerGenerated]
			get
			{
				return this.<ExtenVisObjs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ExtenVisObjs>k__BackingField, value))
				{
					return;
				}
				this.<ExtenVisObjs>k__BackingField = value;
				this.RaisePropertyChanged("ExtenVisObjs");
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x000B85BC File Offset: 0x000B67BC
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x000B85D0 File Offset: 0x000B67D0
		public string SelectedContext
		{
			get
			{
				return this._selectedContext;
			}
			set
			{
				if (string.Equals(this._selectedContext, value, StringComparison.Ordinal))
				{
					return;
				}
				this._selectedContext = value;
				this.RaisePropertyChanged("DialplanSelected");
				this.RaisePropertyChanged("SelectedContext");
				this.LoadDialpnanFields(value);
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x000B8614 File Offset: 0x000B6814
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x000B8628 File Offset: 0x000B6828
		public ObservableCollection<extensions> ContextDialplan
		{
			[CompilerGenerated]
			get
			{
				return this.<ContextDialplan>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ContextDialplan>k__BackingField, value))
				{
					return;
				}
				this.<ContextDialplan>k__BackingField = value;
				this.RaisePropertyChanged("ContextDialplan");
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x000B8658 File Offset: 0x000B6858
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x000B866C File Offset: 0x000B686C
		public ObservableCollection<ExtensionActions> ExtensionActionses
		{
			[CompilerGenerated]
			get
			{
				return this.<ExtensionActionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ExtensionActionses>k__BackingField, value))
				{
					return;
				}
				this.<ExtensionActionses>k__BackingField = value;
				this.RaisePropertyChanged("ExtensionActionses");
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x000B869C File Offset: 0x000B689C
		// (set) Token: 0x06003618 RID: 13848 RVA: 0x000B86B0 File Offset: 0x000B68B0
		public List<ExtensionActions> AllDialplanActions
		{
			[CompilerGenerated]
			get
			{
				return this.<AllDialplanActions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AllDialplanActions>k__BackingField, value))
				{
					return;
				}
				this.<AllDialplanActions>k__BackingField = value;
				this.RaisePropertyChanged("AllDialplanActions");
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x000B86E0 File Offset: 0x000B68E0
		// (set) Token: 0x0600361A RID: 13850 RVA: 0x000B86F4 File Offset: 0x000B68F4
		public ExtensionActions SelectedDialplan
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDialplan>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedDialplan>k__BackingField, value))
				{
					return;
				}
				this.<SelectedDialplan>k__BackingField = value;
				this.RaisePropertyChanged("SelectedDialplan");
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x000B8724 File Offset: 0x000B6924
		// (set) Token: 0x0600361C RID: 13852 RVA: 0x000B8738 File Offset: 0x000B6938
		public ExtensionActions NewDialplanAction
		{
			get
			{
				return this._newDialplanAction;
			}
			set
			{
				if (object.Equals(this._newDialplanAction, value))
				{
					return;
				}
				this._newDialplanAction = value;
				this.RaisePropertyChanged("ActionToQueueVis");
				this.RaisePropertyChanged("ActionPlayFileVis");
				this.RaisePropertyChanged("ActionToIntNumberVis");
				this.RaisePropertyChanged("ActionSaveSmsVis");
				this.RaisePropertyChanged("ActionToTrunkVis");
				this.RaisePropertyChanged("ActionToDongleVis");
				this.RaisePropertyChanged("NewDialplanAction");
				if (this.NewDialplanAction != null)
				{
					if (this.NewDialplanAction.ActionId == 4)
					{
						this.LoadQueues(true);
					}
					if (this.NewDialplanAction.ActionId == 5)
					{
						this.LoadDialplanSipUsers();
					}
					if (this.NewDialplanAction.ActionId == 9)
					{
						this.LoadZadarmaEndpoints();
					}
					if (this.NewDialplanAction.ActionId == 10)
					{
						this.LoadDongleDevices();
					}
				}
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x000B880C File Offset: 0x000B6A0C
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x000B8820 File Offset: 0x000B6A20
		public List<extensions> ExistDialplanActions
		{
			[CompilerGenerated]
			get
			{
				return this.<ExistDialplanActions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ExistDialplanActions>k__BackingField, value))
				{
					return;
				}
				this.<ExistDialplanActions>k__BackingField = value;
				this.RaisePropertyChanged("ExistDialplanActions");
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x000B8850 File Offset: 0x000B6A50
		// (set) Token: 0x06003620 RID: 13856 RVA: 0x000B8864 File Offset: 0x000B6A64
		public extensions SelectedExistDialplanActions
		{
			get
			{
				return this._selectedExistDialplanActions;
			}
			set
			{
				if (object.Equals(this._selectedExistDialplanActions, value))
				{
					return;
				}
				this._selectedExistDialplanActions = value;
				this.RaisePropertyChanged("SelectedExistDialplanActions");
				RelayCommand removeDialplanActionCommand = this.RemoveDialplanActionCommand;
				if (removeDialplanActionCommand != null)
				{
					removeDialplanActionCommand.RaiseCanExecuteChanged();
				}
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x000B88A4 File Offset: 0x000B6AA4
		// (set) Token: 0x06003622 RID: 13858 RVA: 0x000B88B8 File Offset: 0x000B6AB8
		public List<string> DialplanExtens
		{
			[CompilerGenerated]
			get
			{
				return this.<DialplanExtens>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DialplanExtens>k__BackingField, value))
				{
					return;
				}
				this.<DialplanExtens>k__BackingField = value;
				this.RaisePropertyChanged("DialplanExtens");
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x000B88E8 File Offset: 0x000B6AE8
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x000B88FC File Offset: 0x000B6AFC
		public queues SelectedDialplanQueue
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDialplanQueue>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedDialplanQueue>k__BackingField, value))
				{
					return;
				}
				this.<SelectedDialplanQueue>k__BackingField = value;
				this.RaisePropertyChanged("SelectedDialplanQueue");
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x000B892C File Offset: 0x000B6B2C
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x000B8940 File Offset: 0x000B6B40
		public string SelectedDialplanExten
		{
			get
			{
				return this._selectedDialplanExten;
			}
			set
			{
				if (string.Equals(this._selectedDialplanExten, value, StringComparison.Ordinal))
				{
					return;
				}
				this._selectedDialplanExten = value;
				this.RaisePropertyChanged("SelectedDialplanExten");
				this.AfterExtenVisibility = ((this.DialplanExtens == null || this.DialplanExtens.Contains(value)) ? Visibility.Visible : Visibility.Collapsed);
				this.ExistDialplanActions = ((value == null) ? null : this.GetxExistDialplanExtenActions(value));
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x000B89A4 File Offset: 0x000B6BA4
		public bool DialplanSelected
		{
			get
			{
				return this.SelectedContext != null;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x000B89BC File Offset: 0x000B6BBC
		public Visibility ActionToQueueVis
		{
			get
			{
				if (!this.IsNewAction(ExtensionActions.Actions.SendToQueue))
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x000B89D8 File Offset: 0x000B6BD8
		public Visibility ActionPlayFileVis
		{
			get
			{
				if (!this.IsNewAction(ExtensionActions.Actions.PlayFile))
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x000B89F4 File Offset: 0x000B6BF4
		public Visibility ActionToIntNumberVis
		{
			get
			{
				if (!this.IsNewAction(ExtensionActions.Actions.SendToIntNumber))
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x000B8A10 File Offset: 0x000B6C10
		public Visibility ActionSaveSmsVis
		{
			get
			{
				if (!this.IsNewAction(ExtensionActions.Actions.SaveSms))
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x000B8A2C File Offset: 0x000B6C2C
		public Visibility ActionToTrunkVis
		{
			get
			{
				if (!this.IsNewAction(ExtensionActions.Actions.SendToTrunk))
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x000B8A48 File Offset: 0x000B6C48
		public Visibility ActionToDongleVis
		{
			get
			{
				if (!this.IsNewAction(ExtensionActions.Actions.SendToDongle))
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x000B8A64 File Offset: 0x000B6C64
		private bool IsNewAction(ExtensionActions.Actions action)
		{
			return this.NewDialplanAction != null && this.NewDialplanAction.ActionId == (int)action;
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x000B8A8C File Offset: 0x000B6C8C
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x000B8AA0 File Offset: 0x000B6CA0
		public Visibility AfterExtenVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<AfterExtenVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<AfterExtenVisibility>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -795627111;
				IL_10:
				switch ((num ^ -54255302) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<AfterExtenVisibility>k__BackingField = value;
					this.RaisePropertyChanged("AfterExtenVisibility");
					num = -98969069;
					goto IL_10;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x000B8AF8 File Offset: 0x000B6CF8
		// (set) Token: 0x06003632 RID: 13874 RVA: 0x000B8B0C File Offset: 0x000B6D0C
		public string NewDialplanActionFilePath
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDialplanActionFilePath>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewDialplanActionFilePath>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewDialplanActionFilePath>k__BackingField = value;
				this.RaisePropertyChanged("NewDialplanActionFilePath");
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x000B8B3C File Offset: 0x000B6D3C
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x000B8B50 File Offset: 0x000B6D50
		public string NewDialplanActionAsteriskDbPassword
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDialplanActionAsteriskDbPassword>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewDialplanActionAsteriskDbPassword>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewDialplanActionAsteriskDbPassword>k__BackingField = value;
				this.RaisePropertyChanged("NewDialplanActionAsteriskDbPassword");
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x000B8B80 File Offset: 0x000B6D80
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x000B8B94 File Offset: 0x000B6D94
		public List<users> DialplanSipUsers
		{
			[CompilerGenerated]
			get
			{
				return this.<DialplanSipUsers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DialplanSipUsers>k__BackingField, value))
				{
					return;
				}
				this.<DialplanSipUsers>k__BackingField = value;
				this.RaisePropertyChanged("DialplanSipUsers");
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x000B8BC4 File Offset: 0x000B6DC4
		// (set) Token: 0x06003638 RID: 13880 RVA: 0x000B8BD8 File Offset: 0x000B6DD8
		public users NewDialplanActionSipUser
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDialplanActionSipUser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<NewDialplanActionSipUser>k__BackingField, value))
				{
					return;
				}
				this.<NewDialplanActionSipUser>k__BackingField = value;
				this.RaisePropertyChanged("NewDialplanActionSipUser");
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x000B8C08 File Offset: 0x000B6E08
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x000B8C1C File Offset: 0x000B6E1C
		public bool NewDialplanActionSipUserCalled
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDialplanActionSipUserCalled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NewDialplanActionSipUserCalled>k__BackingField == value)
				{
					return;
				}
				this.<NewDialplanActionSipUserCalled>k__BackingField = value;
				this.RaisePropertyChanged("NewDialplanActionSipUserCalled");
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x000B8C48 File Offset: 0x000B6E48
		// (set) Token: 0x0600363C RID: 13884 RVA: 0x000B8C5C File Offset: 0x000B6E5C
		public ps_endpoints SelectedTrunk
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedTrunk>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SelectedTrunk>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -90723513;
				IL_13:
				switch ((num ^ -1362684866) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					num = -489562683;
					goto IL_13;
				}
				this.<SelectedTrunk>k__BackingField = value;
				this.RaisePropertyChanged("SelectedTrunk");
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x000B8CB8 File Offset: 0x000B6EB8
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x000B8CCC File Offset: 0x000B6ECC
		public string SelectedDialDongle
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDialDongle>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<SelectedDialDongle>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<SelectedDialDongle>k__BackingField = value;
				this.RaisePropertyChanged("SelectedDialDongle");
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x000B8CFC File Offset: 0x000B6EFC
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x000B8D10 File Offset: 0x000B6F10
		public ObservableCollection<queues> Queues
		{
			[CompilerGenerated]
			get
			{
				return this.<Queues>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Queues>k__BackingField, value))
				{
					return;
				}
				this.<Queues>k__BackingField = value;
				this.RaisePropertyChanged("Queues");
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x000B8D40 File Offset: 0x000B6F40
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x000B8D54 File Offset: 0x000B6F54
		public ObservableCollection<queue_members> QueueMembers
		{
			[CompilerGenerated]
			get
			{
				return this.<QueueMembers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<QueueMembers>k__BackingField, value))
				{
					return;
				}
				this.<QueueMembers>k__BackingField = value;
				this.RaisePropertyChanged("QueueMembers");
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x000B8D84 File Offset: 0x000B6F84
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x000B8D98 File Offset: 0x000B6F98
		public List<QueueDiagram> QueueDiagram
		{
			[CompilerGenerated]
			get
			{
				return this.<QueueDiagram>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<QueueDiagram>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1744816872;
				IL_13:
				switch ((num ^ 1282532162) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<QueueDiagram>k__BackingField = value;
					this.RaisePropertyChanged("QueueDiagram");
					num = 1575479783;
					goto IL_13;
				}
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x000B8DF4 File Offset: 0x000B6FF4
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x000B8E08 File Offset: 0x000B7008
		public queue_members SelectedQueueMember
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedQueueMember>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedQueueMember>k__BackingField, value))
				{
					return;
				}
				this.<SelectedQueueMember>k__BackingField = value;
				this.RaisePropertyChanged("SelectedQueueMember");
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x000B8E38 File Offset: 0x000B7038
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x000B8E4C File Offset: 0x000B704C
		public string NewQueueName
		{
			[CompilerGenerated]
			get
			{
				return this.<NewQueueName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewQueueName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewQueueName>k__BackingField = value;
				this.RaisePropertyChanged("NewQueueName");
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x000B8E7C File Offset: 0x000B707C
		public bool CanEditQueue
		{
			get
			{
				return this.SelectedQueue != null;
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x000B8E94 File Offset: 0x000B7094
		// (set) Token: 0x0600364B RID: 13899 RVA: 0x000B8EA8 File Offset: 0x000B70A8
		public queues SelectedQueue
		{
			get
			{
				return this._selectedQueue;
			}
			set
			{
				if (object.Equals(this._selectedQueue, value))
				{
					return;
				}
				this._selectedQueue = value;
				this.RaisePropertyChanged("CanEditQueue");
				this.RaisePropertyChanged("SelectedQueue");
				if (value == null)
				{
					this.QueueMembers = null;
				}
				this.LoadQueuesMembers();
			}
		}

		// Token: 0x17001075 RID: 4213
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x000B8EF4 File Offset: 0x000B70F4
		public object SelectedDiagramItem
		{
			set
			{
				QueueDiagram queueDiagram = value as QueueDiagram;
				if (queueDiagram != null && this.SelectQueueByname(queueDiagram.Name))
				{
					this.SelectedQueueMember = null;
					return;
				}
				queue_members queueMember = value as queue_members;
				if (queueMember != null)
				{
					this.SelectQueueByname(queueMember.queue_name);
					if (this.QueueMembers != null)
					{
						queue_members selectedQueueMember = this.QueueMembers.FirstOrDefault((queue_members m) => m.membername == queueMember.membername);
						this.SelectedQueueMember = selectedQueueMember;
					}
				}
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x000B8F74 File Offset: 0x000B7174
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x000B8F88 File Offset: 0x000B7188
		public string NewModemName
		{
			[CompilerGenerated]
			get
			{
				return this.<NewModemName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<NewModemName>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -798003195;
				IL_14:
				switch ((num ^ -595650616) % 4)
				{
				case 0:
					IL_33:
					this.<NewModemName>k__BackingField = value;
					this.RaisePropertyChanged("NewModemName");
					num = -1594729817;
					goto IL_14;
				case 1:
					return;
				case 2:
					goto IL_0F;
				}
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x000B8FE4 File Offset: 0x000B71E4
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x000B8FF8 File Offset: 0x000B71F8
		public string NewDongleDeviceAudio
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDongleDeviceAudio>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewDongleDeviceAudio>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewDongleDeviceAudio>k__BackingField = value;
				this.RaisePropertyChanged("NewDongleDeviceAudio");
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x000B9028 File Offset: 0x000B7228
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x000B903C File Offset: 0x000B723C
		public string NewDongleDeviceData
		{
			[CompilerGenerated]
			get
			{
				return this.<NewDongleDeviceData>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewDongleDeviceData>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewDongleDeviceData>k__BackingField = value;
				this.RaisePropertyChanged("NewDongleDeviceData");
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x000B906C File Offset: 0x000B726C
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x000B9080 File Offset: 0x000B7280
		public string AsteriskConsole
		{
			[CompilerGenerated]
			get
			{
				return this.<AsteriskConsole>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<AsteriskConsole>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AsteriskConsole>k__BackingField = value;
				this.RaisePropertyChanged("AsteriskConsole");
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x000B90B0 File Offset: 0x000B72B0
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x000B90C4 File Offset: 0x000B72C4
		public string AsteriskConsoleCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AsteriskConsoleCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<AsteriskConsoleCommand>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<AsteriskConsoleCommand>k__BackingField = value;
				this.RaisePropertyChanged("AsteriskConsoleCommand");
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x000B90F4 File Offset: 0x000B72F4
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x000B9108 File Offset: 0x000B7308
		public AsteriskConfigCategory DongleDefaultConfig
		{
			[CompilerGenerated]
			get
			{
				return this.<DongleDefaultConfig>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DongleDefaultConfig>k__BackingField, value))
				{
					return;
				}
				this.<DongleDefaultConfig>k__BackingField = value;
				this.RaisePropertyChanged("DongleDefaultConfig");
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x000B9138 File Offset: 0x000B7338
		// (set) Token: 0x0600365A RID: 13914 RVA: 0x000B914C File Offset: 0x000B734C
		public List<AsteriskConfigCategory> DongleDevicesConfig
		{
			[CompilerGenerated]
			get
			{
				return this.<DongleDevicesConfig>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DongleDevicesConfig>k__BackingField, value))
				{
					return;
				}
				this.<DongleDevicesConfig>k__BackingField = value;
				this.RaisePropertyChanged("DongleDevicesConfig");
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x000B917C File Offset: 0x000B737C
		// (set) Token: 0x0600365C RID: 13916 RVA: 0x000B9190 File Offset: 0x000B7390
		public AsteriskConfigCategory SelectedDongleDevice
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedDongleDevice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedDongleDevice>k__BackingField, value))
				{
					return;
				}
				this.<SelectedDongleDevice>k__BackingField = value;
				this.RaisePropertyChanged("CanEditDongleDevice");
				this.RaisePropertyChanged("SelectedDongleDevice");
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x000B91CC File Offset: 0x000B73CC
		public bool CanEditDongleDevice
		{
			get
			{
				return this.SelectedDongleDevice != null;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x000B91E4 File Offset: 0x000B73E4
		// (set) Token: 0x0600365F RID: 13919 RVA: 0x000B91F8 File Offset: 0x000B73F8
		public int VoipTabIndex
		{
			get
			{
				return this._voipTabIndex;
			}
			set
			{
				if (this._voipTabIndex == value)
				{
					return;
				}
				this._voipTabIndex = value;
				this.RaisePropertyChanged("VoipTabIndex");
				if (value == 0)
				{
					this.LoadDialplanItems();
				}
				if (value == 1)
				{
					this.LoadQueues(false);
				}
				if (value == 3)
				{
					this.LoadDongleConf();
				}
				if (value == 4)
				{
					this.LoadZadarmaEndpoints();
				}
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x000B9250 File Offset: 0x000B7450
		// (set) Token: 0x06003661 RID: 13921 RVA: 0x000B9264 File Offset: 0x000B7464
		public ICommand SaveQueueCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveQueueCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SaveQueueCommand>k__BackingField, value))
				{
					return;
				}
				this.<SaveQueueCommand>k__BackingField = value;
				this.RaisePropertyChanged("SaveQueueCommand");
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x000B9294 File Offset: 0x000B7494
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x000B92A8 File Offset: 0x000B74A8
		public ICommand DeleteUserFromQueueCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DeleteUserFromQueueCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DeleteUserFromQueueCommand>k__BackingField, value))
				{
					return;
				}
				this.<DeleteUserFromQueueCommand>k__BackingField = value;
				this.RaisePropertyChanged("DeleteUserFromQueueCommand");
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x000B92D8 File Offset: 0x000B74D8
		// (set) Token: 0x06003665 RID: 13925 RVA: 0x000B92EC File Offset: 0x000B74EC
		public ICommand AddQueueCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddQueueCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddQueueCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddQueueCommand>k__BackingField = value;
				this.RaisePropertyChanged("AddQueueCommand");
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x000B931C File Offset: 0x000B751C
		// (set) Token: 0x06003667 RID: 13927 RVA: 0x000B9330 File Offset: 0x000B7530
		public ICommand DeleteQueueCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DeleteQueueCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<DeleteQueueCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 118162543;
				IL_13:
				switch ((num ^ 773431476) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<DeleteQueueCommand>k__BackingField = value;
					this.RaisePropertyChanged("DeleteQueueCommand");
					num = 971279986;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x000B938C File Offset: 0x000B758C
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x000B93A0 File Offset: 0x000B75A0
		public ICommand CliExecuteCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<CliExecuteCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CliExecuteCommand>k__BackingField, value))
				{
					return;
				}
				this.<CliExecuteCommand>k__BackingField = value;
				this.RaisePropertyChanged("CliExecuteCommand");
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x000B93D0 File Offset: 0x000B75D0
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x000B93E4 File Offset: 0x000B75E4
		public ICommand SaveDongleDefaultSettingsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveDongleDefaultSettingsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SaveDongleDefaultSettingsCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -2060171799;
				IL_13:
				switch ((num ^ -301877860) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 3:
					IL_32:
					this.<SaveDongleDefaultSettingsCommand>k__BackingField = value;
					num = -1009574138;
					goto IL_13;
				}
				this.RaisePropertyChanged("SaveDongleDefaultSettingsCommand");
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x000B9440 File Offset: 0x000B7640
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x000B9454 File Offset: 0x000B7654
		public ICommand AddModemCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddModemCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddModemCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddModemCommand>k__BackingField = value;
				this.RaisePropertyChanged("AddModemCommand");
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x000B9484 File Offset: 0x000B7684
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x000B9498 File Offset: 0x000B7698
		public ICommand SaveDongleDeviceSettingsCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveDongleDeviceSettingsCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<SaveDongleDeviceSettingsCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1266920355;
				IL_13:
				switch ((num ^ -2106971526) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<SaveDongleDeviceSettingsCommand>k__BackingField = value;
					this.RaisePropertyChanged("SaveDongleDeviceSettingsCommand");
					num = -1053047640;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x000B94F4 File Offset: 0x000B76F4
		// (set) Token: 0x06003671 RID: 13937 RVA: 0x000B9508 File Offset: 0x000B7708
		public ICommand RemoveDongleDeviceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RemoveDongleDeviceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RemoveDongleDeviceCommand>k__BackingField, value))
				{
					return;
				}
				this.<RemoveDongleDeviceCommand>k__BackingField = value;
				this.RaisePropertyChanged("RemoveDongleDeviceCommand");
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x000B9538 File Offset: 0x000B7738
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x000B954C File Offset: 0x000B774C
		public ICommand ExecuteConsoleCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ExecuteConsoleCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ExecuteConsoleCommand>k__BackingField, value))
				{
					return;
				}
				this.<ExecuteConsoleCommand>k__BackingField = value;
				this.RaisePropertyChanged("ExecuteConsoleCommand");
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06003674 RID: 13940 RVA: 0x000B957C File Offset: 0x000B777C
		// (set) Token: 0x06003675 RID: 13941 RVA: 0x000B9590 File Offset: 0x000B7790
		public ICommand RestartDongleDeviceCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RestartDongleDeviceCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RestartDongleDeviceCommand>k__BackingField, value))
				{
					return;
				}
				this.<RestartDongleDeviceCommand>k__BackingField = value;
				this.RaisePropertyChanged("RestartDongleDeviceCommand");
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x000B95C0 File Offset: 0x000B77C0
		// (set) Token: 0x06003677 RID: 13943 RVA: 0x000B95D4 File Offset: 0x000B77D4
		public ICommand AddZadarmaTrunkCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddZadarmaTrunkCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddZadarmaTrunkCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddZadarmaTrunkCommand>k__BackingField = value;
				this.RaisePropertyChanged("AddZadarmaTrunkCommand");
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x000B9604 File Offset: 0x000B7804
		// (set) Token: 0x06003679 RID: 13945 RVA: 0x000B9618 File Offset: 0x000B7818
		public ICommand SaveZadarmaTrunkCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveZadarmaTrunkCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SaveZadarmaTrunkCommand>k__BackingField, value))
				{
					return;
				}
				this.<SaveZadarmaTrunkCommand>k__BackingField = value;
				this.RaisePropertyChanged("SaveZadarmaTrunkCommand");
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x000B9648 File Offset: 0x000B7848
		// (set) Token: 0x0600367B RID: 13947 RVA: 0x000B965C File Offset: 0x000B785C
		public ICommand DeleteZadarmaTrunkCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<DeleteZadarmaTrunkCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<DeleteZadarmaTrunkCommand>k__BackingField, value))
				{
					return;
				}
				this.<DeleteZadarmaTrunkCommand>k__BackingField = value;
				this.RaisePropertyChanged("DeleteZadarmaTrunkCommand");
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x0600367C RID: 13948 RVA: 0x000B968C File Offset: 0x000B788C
		// (set) Token: 0x0600367D RID: 13949 RVA: 0x000B96A0 File Offset: 0x000B78A0
		public ICommand ClearDialPlanCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ClearDialPlanCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<ClearDialPlanCommand>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1767505799;
				IL_13:
				switch ((num ^ 224418774) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0E;
				case 3:
					IL_32:
					num = 888799730;
					goto IL_13;
				}
				this.<ClearDialPlanCommand>k__BackingField = value;
				this.RaisePropertyChanged("ClearDialPlanCommand");
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x000B96FC File Offset: 0x000B78FC
		// (set) Token: 0x0600367F RID: 13951 RVA: 0x000B9710 File Offset: 0x000B7910
		public RelayCommand RemoveDialplanActionCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<RemoveDialplanActionCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<RemoveDialplanActionCommand>k__BackingField, value))
				{
					return;
				}
				this.<RemoveDialplanActionCommand>k__BackingField = value;
				this.RaisePropertyChanged("RemoveDialplanActionCommand");
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x000B9740 File Offset: 0x000B7940
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x000B9754 File Offset: 0x000B7954
		public ICommand AddDialplanActionCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<AddDialplanActionCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AddDialplanActionCommand>k__BackingField, value))
				{
					return;
				}
				this.<AddDialplanActionCommand>k__BackingField = value;
				this.RaisePropertyChanged("AddDialplanActionCommand");
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x000B9784 File Offset: 0x000B7984
		// (set) Token: 0x06003683 RID: 13955 RVA: 0x000B9798 File Offset: 0x000B7998
		public ICommand SaveDialplanCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SaveDialplanCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SaveDialplanCommand>k__BackingField, value))
				{
					return;
				}
				this.<SaveDialplanCommand>k__BackingField = value;
				this.RaisePropertyChanged("SaveDialplanCommand");
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x000B97C8 File Offset: 0x000B79C8
		// (set) Token: 0x06003685 RID: 13957 RVA: 0x000B97DC File Offset: 0x000B79DC
		public ICommand SelectAudioFileCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectAudioFileCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectAudioFileCommand>k__BackingField, value))
				{
					return;
				}
				this.<SelectAudioFileCommand>k__BackingField = value;
				this.RaisePropertyChanged("SelectAudioFileCommand");
			}
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x000B980C File Offset: 0x000B7A0C
		private void InitCommands()
		{
			this.DeleteUserFromQueueCommand = new RelayCommand(new Action<object>(this.DeleteUserFromQueue));
			this.SaveQueueCommand = new RelayCommand(new Action<object>(this.SaveQueue));
			this.AddQueueCommand = new RelayCommand(new Action<object>(this.AddQueue));
			this.DeleteQueueCommand = new RelayCommand(new Action<object>(this.DeleteQueue));
			this.CliExecuteCommand = new RelayCommand(new Action<object>(this.CliExecute));
			this.SaveDongleDefaultSettingsCommand = new RelayCommand(new Action<object>(this.SaveDongleDefaultSettings));
			this.AddModemCommand = new RelayCommand(new Action<object>(this.AddModem));
			this.SaveDongleDeviceSettingsCommand = new RelayCommand(new Action<object>(this.SaveDongleDeviceSettings));
			this.RemoveDongleDeviceCommand = new RelayCommand(new Action<object>(this.RemoveDongleDevice));
			this.ExecuteConsoleCommand = new RelayCommand(new Action<object>(this.ExecuteConsole));
			this.RestartDongleDeviceCommand = new RelayCommand(new Action<object>(this.RestartDongleDevice));
			this.AddZadarmaTrunkCommand = new RelayCommand(new Action<object>(this.AddZadarmaTrunk));
			this.SaveZadarmaTrunkCommand = new RelayCommand(new Action<object>(this.SaveZadarmaTrunk));
			this.DeleteZadarmaTrunkCommand = new RelayCommand(new Action<object>(this.DeleteZadarmaTrunk));
			this.ClearDialPlanCommand = new RelayCommand(new Action<object>(this.ClearDialPlan));
			this.RemoveDialplanActionCommand = new RelayCommand(new Action<object>(this.RemoveDialplanAction), new Func<bool>(this.CanRemoveDialplanAction));
			this.AddDialplanActionCommand = new RelayCommand(new Action<object>(this.AddDialplanAction));
			this.SaveDialplanCommand = new RelayCommand(new Action<object>(this.SaveDialplan), new Func<bool>(this.CanSaveDialplan));
			this.SelectAudioFileCommand = new RelayCommand(new Action<object>(this.SelectAudioFile));
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x000304B4 File Offset: 0x0002E6B4
		private bool CanSaveDialplan()
		{
			return false;
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x000B99E8 File Offset: 0x000B7BE8
		private bool CanRemoveDialplanAction()
		{
			return this.SelectedExistDialplanActions != null;
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x000B9A00 File Offset: 0x000B7C00
		public VoIPViewModel()
		{
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._ascMessageBoxService = Bootstrapper.Container.Resolve<IAscMessageBoxService>();
			this.LoadEndpoints();
			this.LoadDialplanItems();
			this.InitCommands();
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x000B9A98 File Offset: 0x000B7C98
		private bool SelectQueueByname(string queueName)
		{
			queues queues = this.Queues.FirstOrDefault((queues q) => q.name == queueName);
			if (queues != null)
			{
				this.SelectedQueue = queues;
				return false;
			}
			return true;
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x000B9AD8 File Offset: 0x000B7CD8
		private void LoadQueues(bool onlyQueues = false)
		{
			VoIPViewModel.<LoadQueues>d__281 <LoadQueues>d__;
			<LoadQueues>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadQueues>d__.<>4__this = this;
			<LoadQueues>d__.onlyQueues = onlyQueues;
			<LoadQueues>d__.<>1__state = -1;
			<LoadQueues>d__.<>t__builder.Start<VoIPViewModel.<LoadQueues>d__281>(ref <LoadQueues>d__);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x000B9B18 File Offset: 0x000B7D18
		private void LoadEndpoints()
		{
			VoIPViewModel.<LoadEndpoints>d__282 <LoadEndpoints>d__;
			<LoadEndpoints>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadEndpoints>d__.<>4__this = this;
			<LoadEndpoints>d__.<>1__state = -1;
			<LoadEndpoints>d__.<>t__builder.Start<VoIPViewModel.<LoadEndpoints>d__282>(ref <LoadEndpoints>d__);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000B9B50 File Offset: 0x000B7D50
		private void LoadDialplanSipUsers()
		{
			VoIPViewModel.<LoadDialplanSipUsers>d__283 <LoadDialplanSipUsers>d__;
			<LoadDialplanSipUsers>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDialplanSipUsers>d__.<>4__this = this;
			<LoadDialplanSipUsers>d__.<>1__state = -1;
			<LoadDialplanSipUsers>d__.<>t__builder.Start<VoIPViewModel.<LoadDialplanSipUsers>d__283>(ref <LoadDialplanSipUsers>d__);
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x000B9B88 File Offset: 0x000B7D88
		private void LoadQueueDiagram_()
		{
			VoIPViewModel.<LoadQueueDiagram_>d__284 <LoadQueueDiagram_>d__;
			<LoadQueueDiagram_>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadQueueDiagram_>d__.<>4__this = this;
			<LoadQueueDiagram_>d__.<>1__state = -1;
			<LoadQueueDiagram_>d__.<>t__builder.Start<VoIPViewModel.<LoadQueueDiagram_>d__284>(ref <LoadQueueDiagram_>d__);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x000B9BC0 File Offset: 0x000B7DC0
		private void LoadQueuesMembers()
		{
			VoIPViewModel.<LoadQueuesMembers>d__285 <LoadQueuesMembers>d__;
			<LoadQueuesMembers>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadQueuesMembers>d__.<>4__this = this;
			<LoadQueuesMembers>d__.<>1__state = -1;
			<LoadQueuesMembers>d__.<>t__builder.Start<VoIPViewModel.<LoadQueuesMembers>d__285>(ref <LoadQueuesMembers>d__);
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x000B9C0C File Offset: 0x000B7E0C
		public List<ps_endpoints> Endpoints
		{
			[CompilerGenerated]
			get
			{
				return this.<Endpoints>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Endpoints>k__BackingField, value))
				{
					return;
				}
				this.<Endpoints>k__BackingField = value;
				this.RaisePropertyChanged("Endpoints");
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x000B9C3C File Offset: 0x000B7E3C
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x000B9C80 File Offset: 0x000B7E80
		public ps_endpoints SelectedEndpoint
		{
			get
			{
				return base.GetProperty<ps_endpoints>(() => this.SelectedEndpoint);
			}
			set
			{
				if (object.Equals(this.SelectedEndpoint, value))
				{
					return;
				}
				base.SetProperty<ps_endpoints>(() => this.SelectedEndpoint, value, new Action(this.SelectedEndpointChanged));
				this.RaisePropertyChanged("SelectedEndpoint");
			}
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x000B9CEC File Offset: 0x000B7EEC
		private void SelectedEndpointChanged()
		{
			base.RaiseCanExecuteChanged(() => this.AddUserToQueue());
			base.RaiseCanExecuteChanged(() => this.DeleteEndpoint());
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x000B9D70 File Offset: 0x000B7F70
		[Command]
		public void DeleteEndpoint()
		{
			VoIPViewModel.<DeleteEndpoint>d__294 <DeleteEndpoint>d__;
			<DeleteEndpoint>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DeleteEndpoint>d__.<>4__this = this;
			<DeleteEndpoint>d__.<>1__state = -1;
			<DeleteEndpoint>d__.<>t__builder.Start<VoIPViewModel.<DeleteEndpoint>d__294>(ref <DeleteEndpoint>d__);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x000B9DA8 File Offset: 0x000B7FA8
		public bool CanDeleteEndpoint()
		{
			return this.SelectedEndpoint != null;
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x000B9DC0 File Offset: 0x000B7FC0
		[Command]
		public void ShowEndpointEdit()
		{
			if (this.SelectedEndpoint == null)
			{
				return;
			}
			this._windowedDocumentService.ShowNewDocument("EndpointEditView", new EndpointEditViewModel(this.SelectedEndpoint), this, null);
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x000B9DF4 File Offset: 0x000B7FF4
		[Command]
		public void ShowCreateEndpoint()
		{
			this._windowedDocumentService.ShowNewDocument("EndpointEditView", new EndpointEditViewModel(), this, null);
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x000B9E18 File Offset: 0x000B8018
		[Command]
		public void PasswordCopy(object obj)
		{
			string text = obj as string;
			if (text != null)
			{
				Clipboard.SetText(text);
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x000B9E38 File Offset: 0x000B8038
		[Command]
		public void SaveQueueMembers()
		{
			bool flag = this._voipModel.SaveQueueMembers(this.QueueMembers);
			base.ShowActionResponse(flag, "");
			if (flag)
			{
				this.LoadQueueDiagram_();
				return;
			}
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x000B8E7C File Offset: 0x000B707C
		public bool CanSaveQueueMembers()
		{
			return this.SelectedQueue != null;
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x000B9E70 File Offset: 0x000B8070
		[Command]
		public void AddUserToQueue()
		{
			VoIPViewModel.<AddUserToQueue>d__301 <AddUserToQueue>d__;
			<AddUserToQueue>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddUserToQueue>d__.<>4__this = this;
			<AddUserToQueue>d__.<>1__state = -1;
			<AddUserToQueue>d__.<>t__builder.Start<VoIPViewModel.<AddUserToQueue>d__301>(ref <AddUserToQueue>d__);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x000B9EA8 File Offset: 0x000B80A8
		public bool CanAddUserToQueue()
		{
			return this.SelectedEndpoint != null && this.SelectedQueue != null;
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x000B9EC8 File Offset: 0x000B80C8
		private void DeleteUserFromQueue(object obj)
		{
			if (this.SelectedQueueMember == null)
			{
				return;
			}
			this._voipModel.AddQueueMemberToRemoveList(this.SelectedQueueMember);
			this.QueueMembers.Remove(this.SelectedQueueMember);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x000B9F04 File Offset: 0x000B8104
		private void AddQueue(object obj)
		{
			if (string.IsNullOrEmpty(this.NewQueueName))
			{
				this._toasterService.Info(Lang.t("InputQueueName"));
				return;
			}
			if ((from q in this.Queues
			select q.name).ToList<string>().Contains(this.NewQueueName))
			{
				this._toasterService.Info(Lang.t("QueueNameDuplicate"));
				return;
			}
			queues queues = new queues
			{
				name = this.NewQueueName,
				timeout = new int?(30),
				ringinuse = "no",
				autofill = "yes",
				strategy = "ringall",
				weight = new int?(0)
			};
			this.Queues.Add(queues);
			this._voipModel.AddQueueToDb(queues);
			this.NewQueueName = "";
			this._voipModel.ServerReloadQueues();
			this.LoadQueueDiagram_();
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x000BA00C File Offset: 0x000B820C
		private void SaveQueue(object obj)
		{
			if (this.SelectedQueue == null)
			{
				return;
			}
			this._voipModel.SaveExistQueue(this.SelectedQueue);
			this._voipModel.ServerReloadQueues();
			this.LoadQueueDiagram_();
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x000BA044 File Offset: 0x000B8244
		private void DeleteQueue(object obj)
		{
			if (this.SelectedQueue == null)
			{
				return;
			}
			if (this._ascMessageBoxService.ShowMessageBox((string)Application.Current.TryFindResource("ConfirmQueueDelete"), "", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
			{
				this._voipModel.QueueRemoveFromDb(this.SelectedQueue);
				this.Queues.Remove(this.SelectedQueue);
				this.SelectedQueue = null;
				this._voipModel.ServerReloadQueues();
				this.LoadQueueDiagram_();
			}
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x000BA0C0 File Offset: 0x000B82C0
		private void CliExecute(object obj)
		{
			string cmd = obj as string;
			if (obj != null)
			{
				this.ConsoleBeforeExecute(cmd);
				this.ConsoleAfrerExecute(this._voipModel.ServerCliExecute(cmd));
				return;
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x000BA0F4 File Offset: 0x000B82F4
		private void LoadDongleConf()
		{
			this.DongleDefaultConfig = this._voipModel.GetDongleDefaultSettings();
			this.LoadDongleDevices();
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x000BA118 File Offset: 0x000B8318
		private void LoadDongleDevices()
		{
			this.DongleDevicesConfig = this._voipModel.GetDongleDevices();
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x000BA138 File Offset: 0x000B8338
		private void SaveDongleDefaultSettings(object obj)
		{
			this._ascMessageBoxService.ShowMessageBox(this._voipModel.SaveDongleDefSettings(this.DongleDefaultConfig));
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x000BA164 File Offset: 0x000B8364
		private void AddModem(object obj)
		{
			if (this.CheckNewModemFields())
			{
				goto IL_2F;
			}
			IL_08:
			int num = -571521064;
			IL_0D:
			AsteriskConfigCategory category;
			switch ((num ^ -1070515955) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2F:
				category = new AsteriskConfigCategory
				{
					Audio = this.NewDongleDeviceAudio,
					Data = this.NewDongleDeviceData,
					Name = this.NewModemName,
					Rxgain = this.DongleDefaultConfig.Rxgain,
					Txgain = this.DongleDefaultConfig.Txgain,
					Context = this.DongleDefaultConfig.Context,
					Autodeletesms = this.DongleDefaultConfig.Autodeletesms,
					Disablesms = this.DongleDefaultConfig.Disablesms
				};
				num = -246003073;
				goto IL_0D;
			}
			this._ascMessageBoxService.ShowMessageBox(this._voipModel.AddDongleDevice(category));
			this.LoadDongleDevices();
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000BA248 File Offset: 0x000B8448
		private bool CheckNewModemFields()
		{
			if (string.IsNullOrEmpty(this.NewModemName))
			{
				this._toasterService.Info(Lang.t("InputModemName"));
				return false;
			}
			if (string.IsNullOrEmpty(this.NewDongleDeviceAudio))
			{
				this._toasterService.Info(Lang.t("InputModemAudio"));
				return false;
			}
			if (string.IsNullOrEmpty(this.NewDongleDeviceData))
			{
				this._toasterService.Info(Lang.t("InputModemData"));
				return false;
			}
			return true;
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x000BA2C4 File Offset: 0x000B84C4
		private void SaveDongleDeviceSettings(object obj)
		{
			if (this.SelectedDongleDevice == null)
			{
				this._toasterService.Info(Lang.t("SelectModem"));
				return;
			}
			this._ascMessageBoxService.ShowMessageBox(this._voipModel.SaveDongleDevice(this.SelectedDongleDevice));
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x000BA30C File Offset: 0x000B850C
		private void RemoveDongleDevice(object obj)
		{
			if (this.SelectedDongleDevice == null)
			{
				return;
			}
			if (this._ascMessageBoxService.ShowMessageBox((string)Application.Current.TryFindResource("ConfirmModemDelete"), "", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
			{
				this._ascMessageBoxService.ShowMessageBox(this._voipModel.DeleteDongleDevice(this.SelectedDongleDevice));
				this.LoadDongleDevices();
			}
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x000BA370 File Offset: 0x000B8570
		private void ExecuteConsole(object obj)
		{
			this.ConsoleBeforeExecute(this.AsteriskConsoleCommand);
			this.AsteriskConsole += this._voipModel.ServerCliExecute(this.AsteriskConsoleCommand);
			this.AsteriskConsoleCommand = string.Empty;
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x000BA3B8 File Offset: 0x000B85B8
		private void ConsoleAfrerExecute(string response)
		{
			this.AsteriskConsole += response;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x000BA3D8 File Offset: 0x000B85D8
		private void ConsoleBeforeExecute(string cmd)
		{
			this.AsteriskConsole = string.Concat(new string[]
			{
				this.AsteriskConsole,
				"[",
				DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
				"] ",
				cmd,
				"\r\n"
			});
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x000BA430 File Offset: 0x000B8630
		private void RestartDongleDevice(object obj)
		{
			if (this.SelectedDongleDevice != null)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1852481562;
			IL_0D:
			string cmd;
			switch ((num ^ 1407704395) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				cmd = "dongle restart now " + this.SelectedDongleDevice.Name;
				num = 2117395009;
				goto IL_0D;
			}
			this._ascMessageBoxService.ShowMessageBox(this._voipModel.ServerCliExecute(cmd));
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x000BA4A0 File Offset: 0x000B86A0
		private void LoadZadarmaEndpoints()
		{
			VoIPViewModel.<LoadZadarmaEndpoints>d__319 <LoadZadarmaEndpoints>d__;
			<LoadZadarmaEndpoints>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadZadarmaEndpoints>d__.<>4__this = this;
			<LoadZadarmaEndpoints>d__.<>1__state = -1;
			<LoadZadarmaEndpoints>d__.<>t__builder.Start<VoIPViewModel.<LoadZadarmaEndpoints>d__319>(ref <LoadZadarmaEndpoints>d__);
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x000BA4D8 File Offset: 0x000B86D8
		private void AddZadarmaTrunk(object obj)
		{
			if (!this.CheckZadarmaFields())
			{
				return;
			}
			bool flag = this._voipModel.AddZadarmaTrunk(this.NewZadarmaEndpoint, this.NewZadarmaAorContact);
			base.ShowActionResponse(flag, "");
			if (flag)
			{
				this.NewZadarmaEndpoint = new ps_endpoints();
				this.NewZadarmaAorContact = "";
				this.SelectedZadarmaEndpoint = null;
				this.LoadZadarmaEndpoints();
				return;
			}
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x000BA53C File Offset: 0x000B873C
		private bool CheckZadarmaFields()
		{
			if (string.IsNullOrEmpty(this.NewZadarmaAorContact))
			{
				this._toasterService.Info(Lang.t("InputPhone"));
				return false;
			}
			if (this.NewZadarmaEndpoint.id == 0)
			{
				this._toasterService.Info(Lang.t("InputSipLogin"));
				return false;
			}
			if (this.ZadarmaEndpointses != null && this.ZadarmaEndpointses.Any((ps_endpoints e) => e.id == this.NewZadarmaEndpoint.id))
			{
				this._toasterService.Info(Lang.t("SipLoginAlreadyExist"));
				return false;
			}
			return true;
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x000BA5CC File Offset: 0x000B87CC
		private void LoadZadarmaAor(string aorId)
		{
			VoIPViewModel.<LoadZadarmaAor>d__322 <LoadZadarmaAor>d__;
			<LoadZadarmaAor>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadZadarmaAor>d__.<>4__this = this;
			<LoadZadarmaAor>d__.aorId = aorId;
			<LoadZadarmaAor>d__.<>1__state = -1;
			<LoadZadarmaAor>d__.<>t__builder.Start<VoIPViewModel.<LoadZadarmaAor>d__322>(ref <LoadZadarmaAor>d__);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x000BA60C File Offset: 0x000B880C
		private void SaveZadarmaTrunk(object obj)
		{
			if (this.SelectedZadarmaEndpoint == null)
			{
				return;
			}
			if (this._voipModel.EndpointUpdateSetting(this.SelectedZadarmaEndpoint) && this._voipModel.AorUpdateSetting(this.SelectedZadarmaAor))
			{
				this._toasterService.Success(Lang.t("Saved"));
			}
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x000BA660 File Offset: 0x000B8860
		private void DeleteZadarmaTrunk(object obj)
		{
			if (this.SelectedZadarmaEndpoint == null)
			{
				return;
			}
			if (this._ascMessageBoxService.ShowMessageBox((string)Application.Current.TryFindResource("ConfirmDelete"), "", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
			{
				if (this._voipModel.RemoveTrunkFromDb(this.SelectedZadarmaEndpoint.id))
				{
					this._toasterService.Success(Lang.t("Removed"));
					this.LoadZadarmaEndpoints();
				}
			}
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x000BA6D8 File Offset: 0x000B88D8
		private void LoadDialplanItems()
		{
			VoIPViewModel.<LoadDialplanItems>d__325 <LoadDialplanItems>d__;
			<LoadDialplanItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDialplanItems>d__.<>4__this = this;
			<LoadDialplanItems>d__.<>1__state = -1;
			<LoadDialplanItems>d__.<>t__builder.Start<VoIPViewModel.<LoadDialplanItems>d__325>(ref <LoadDialplanItems>d__);
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x000BA710 File Offset: 0x000B8910
		private void ClearDialPlan(object obj)
		{
			if (string.IsNullOrEmpty(this.SelectedContext))
			{
				return;
			}
			if (this._ascMessageBoxService.ShowMessageBox(Lang.t("ConfirmDelete"), "", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes && this._voipModel.RemoveTrunkFromDb(this.SelectedZadarmaEndpoint.id))
			{
				this._toasterService.Success(Lang.t("Removed"));
				this._voipModel.ClearContextDialplan(this.SelectedContext);
				this.SelectedContext = "";
			}
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x000BA798 File Offset: 0x000B8998
		private List<extensions> GetxExistDialplanExtenActions(string value)
		{
			return (from c in this.ContextDialplan
			where c.exten == value
			select c).ToList<extensions>();
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x000BA7D0 File Offset: 0x000B89D0
		private void SaveDialplan(object obj)
		{
			ExtensionActions selectedDialplan = this.SelectedDialplan;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000BA7E4 File Offset: 0x000B89E4
		private void RemoveDialplanAction(object obj)
		{
			if (this.SelectedDialplanExten == null)
			{
				return;
			}
			if (this.SelectedExistDialplanActions == null)
			{
				return;
			}
			if (this._ascMessageBoxService.ShowMessageBox((string)Application.Current.TryFindResource("ConfirmDelete"), "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes && this._voipModel.RemoveDialplanActionFromDb(this.SelectedExistDialplanActions))
			{
				this.RefreshDialplanTabAfterEdit();
			}
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x000BA848 File Offset: 0x000B8A48
		private void AddDialplanAction(object obj)
		{
			VoIPViewModel.<AddDialplanAction>d__330 <AddDialplanAction>d__;
			<AddDialplanAction>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AddDialplanAction>d__.<>4__this = this;
			<AddDialplanAction>d__.<>1__state = -1;
			<AddDialplanAction>d__.<>t__builder.Start<VoIPViewModel.<AddDialplanAction>d__330>(ref <AddDialplanAction>d__);
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x000BA880 File Offset: 0x000B8A80
		private void LoadDialpnanFields(string value)
		{
			this.ContextDialplan = new ObservableCollection<extensions>(this._voipModel.LoadContextDialplan(value));
			this.DialplanExtens = (from c in this.ContextDialplan
			select c.exten).Distinct<string>().ToList<string>();
			this.ExtenVisObjs = this._voipModel.BuildDialplanDiagramm(value, this.DialplanExtens);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000BA8F8 File Offset: 0x000B8AF8
		private void RefreshDialplanTabAfterEdit()
		{
			this.NewDialplanAction = null;
			this.SelectedDialplanExten = null;
			this.SelectedExistDialplanActions = null;
			this.LoadDialpnanFields(this.SelectedContext);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000BA928 File Offset: 0x000B8B28
		private void SelectAudioFile(object obj)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Audio  (*.WAV) | *.WAV",
				Multiselect = false
			};
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				this.NewDialplanActionFilePath = openFileDialog.FileName;
			}
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x000BA974 File Offset: 0x000B8B74
		public void DataRefresh()
		{
			this.LoadEndpoints();
			this.LoadDialplanItems();
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x000BA990 File Offset: 0x000B8B90
		[CompilerGenerated]
		private Task<IEnumerable<queue_members>> <LoadQueuesMembers>b__285_0()
		{
			return VoipModel.LoadQueueMembers(this.SelectedQueue);
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x000BA9A8 File Offset: 0x000B8BA8
		[CompilerGenerated]
		private bool <DeleteEndpoint>b__294_0()
		{
			return VoipModel.RemoveTel(this.SelectedEndpoint.id);
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x000BA9C8 File Offset: 0x000B8BC8
		[CompilerGenerated]
		private bool <AddUserToQueue>b__301_0()
		{
			return VoipModel.AddEndpointToQueue(this.SelectedEndpoint, this.SelectedQueue.name);
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x000BA9EC File Offset: 0x000B8BEC
		[CompilerGenerated]
		private bool <CheckZadarmaFields>b__321_0(ps_endpoints e)
		{
			return e.id == this.NewZadarmaEndpoint.id;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x000BAA0C File Offset: 0x000B8C0C
		[CompilerGenerated]
		private List<string> <LoadDialplanItems>b__325_0()
		{
			return this._voipModel.LoadAllExistContext();
		}

		// Token: 0x04001F17 RID: 7959
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001F18 RID: 7960
		private readonly IToasterService _toasterService;

		// Token: 0x04001F19 RID: 7961
		private readonly IAscMessageBoxService _ascMessageBoxService;

		// Token: 0x04001F1A RID: 7962
		private VoipModel _voipModel = new VoipModel();

		// Token: 0x04001F1B RID: 7963
		[CompilerGenerated]
		private config <Config>k__BackingField = Auth.Config;

		// Token: 0x04001F1C RID: 7964
		[CompilerGenerated]
		private List<ps_endpoints> <ZadarmaEndpointses>k__BackingField;

		// Token: 0x04001F1D RID: 7965
		[CompilerGenerated]
		private ps_aors <SelectedZadarmaAor>k__BackingField;

		// Token: 0x04001F1E RID: 7966
		[CompilerGenerated]
		private ps_endpoints <NewZadarmaEndpoint>k__BackingField = new ps_endpoints();

		// Token: 0x04001F1F RID: 7967
		[CompilerGenerated]
		private string <NewZadarmaAorContact>k__BackingField;

		// Token: 0x04001F20 RID: 7968
		[CompilerGenerated]
		private List<string> <EndpointCodecs>k__BackingField = new List<string>
		{
			"alaw",
			"ulaw"
		};

		// Token: 0x04001F21 RID: 7969
		[CompilerGenerated]
		private List<string> <Contextsts>k__BackingField;

		// Token: 0x04001F22 RID: 7970
		[CompilerGenerated]
		private List<ExtenVisObj> <ExtenVisObjs>k__BackingField;

		// Token: 0x04001F23 RID: 7971
		[CompilerGenerated]
		private ObservableCollection<extensions> <ContextDialplan>k__BackingField;

		// Token: 0x04001F24 RID: 7972
		[CompilerGenerated]
		private ObservableCollection<ExtensionActions> <ExtensionActionses>k__BackingField;

		// Token: 0x04001F25 RID: 7973
		[CompilerGenerated]
		private List<ExtensionActions> <AllDialplanActions>k__BackingField;

		// Token: 0x04001F26 RID: 7974
		[CompilerGenerated]
		private ExtensionActions <SelectedDialplan>k__BackingField;

		// Token: 0x04001F27 RID: 7975
		[CompilerGenerated]
		private List<extensions> <ExistDialplanActions>k__BackingField;

		// Token: 0x04001F28 RID: 7976
		[CompilerGenerated]
		private List<string> <DialplanExtens>k__BackingField;

		// Token: 0x04001F29 RID: 7977
		[CompilerGenerated]
		private queues <SelectedDialplanQueue>k__BackingField;

		// Token: 0x04001F2A RID: 7978
		[CompilerGenerated]
		private Visibility <AfterExtenVisibility>k__BackingField;

		// Token: 0x04001F2B RID: 7979
		[CompilerGenerated]
		private string <NewDialplanActionFilePath>k__BackingField;

		// Token: 0x04001F2C RID: 7980
		[CompilerGenerated]
		private string <NewDialplanActionAsteriskDbPassword>k__BackingField;

		// Token: 0x04001F2D RID: 7981
		[CompilerGenerated]
		private List<users> <DialplanSipUsers>k__BackingField;

		// Token: 0x04001F2E RID: 7982
		[CompilerGenerated]
		private users <NewDialplanActionSipUser>k__BackingField;

		// Token: 0x04001F2F RID: 7983
		[CompilerGenerated]
		private bool <NewDialplanActionSipUserCalled>k__BackingField;

		// Token: 0x04001F30 RID: 7984
		[CompilerGenerated]
		private ps_endpoints <SelectedTrunk>k__BackingField;

		// Token: 0x04001F31 RID: 7985
		[CompilerGenerated]
		private string <SelectedDialDongle>k__BackingField;

		// Token: 0x04001F32 RID: 7986
		[CompilerGenerated]
		private ObservableCollection<queues> <Queues>k__BackingField;

		// Token: 0x04001F33 RID: 7987
		[CompilerGenerated]
		private ObservableCollection<queue_members> <QueueMembers>k__BackingField;

		// Token: 0x04001F34 RID: 7988
		[CompilerGenerated]
		private List<QueueDiagram> <QueueDiagram>k__BackingField;

		// Token: 0x04001F35 RID: 7989
		[CompilerGenerated]
		private queue_members <SelectedQueueMember>k__BackingField;

		// Token: 0x04001F36 RID: 7990
		[CompilerGenerated]
		private string <NewQueueName>k__BackingField;

		// Token: 0x04001F37 RID: 7991
		[CompilerGenerated]
		private string <NewModemName>k__BackingField;

		// Token: 0x04001F38 RID: 7992
		[CompilerGenerated]
		private string <NewDongleDeviceAudio>k__BackingField;

		// Token: 0x04001F39 RID: 7993
		[CompilerGenerated]
		private string <NewDongleDeviceData>k__BackingField;

		// Token: 0x04001F3A RID: 7994
		[CompilerGenerated]
		private string <AsteriskConsole>k__BackingField;

		// Token: 0x04001F3B RID: 7995
		[CompilerGenerated]
		private string <AsteriskConsoleCommand>k__BackingField;

		// Token: 0x04001F3C RID: 7996
		[CompilerGenerated]
		private AsteriskConfigCategory <DongleDefaultConfig>k__BackingField;

		// Token: 0x04001F3D RID: 7997
		[CompilerGenerated]
		private List<AsteriskConfigCategory> <DongleDevicesConfig>k__BackingField;

		// Token: 0x04001F3E RID: 7998
		[CompilerGenerated]
		private AsteriskConfigCategory <SelectedDongleDevice>k__BackingField;

		// Token: 0x04001F3F RID: 7999
		[CompilerGenerated]
		private ICommand <SaveQueueCommand>k__BackingField;

		// Token: 0x04001F40 RID: 8000
		[CompilerGenerated]
		private ICommand <DeleteUserFromQueueCommand>k__BackingField;

		// Token: 0x04001F41 RID: 8001
		[CompilerGenerated]
		private ICommand <AddQueueCommand>k__BackingField;

		// Token: 0x04001F42 RID: 8002
		[CompilerGenerated]
		private ICommand <DeleteQueueCommand>k__BackingField;

		// Token: 0x04001F43 RID: 8003
		[CompilerGenerated]
		private ICommand <CliExecuteCommand>k__BackingField;

		// Token: 0x04001F44 RID: 8004
		[CompilerGenerated]
		private ICommand <SaveDongleDefaultSettingsCommand>k__BackingField;

		// Token: 0x04001F45 RID: 8005
		[CompilerGenerated]
		private ICommand <AddModemCommand>k__BackingField;

		// Token: 0x04001F46 RID: 8006
		[CompilerGenerated]
		private ICommand <SaveDongleDeviceSettingsCommand>k__BackingField;

		// Token: 0x04001F47 RID: 8007
		[CompilerGenerated]
		private ICommand <RemoveDongleDeviceCommand>k__BackingField;

		// Token: 0x04001F48 RID: 8008
		[CompilerGenerated]
		private ICommand <ExecuteConsoleCommand>k__BackingField;

		// Token: 0x04001F49 RID: 8009
		[CompilerGenerated]
		private ICommand <RestartDongleDeviceCommand>k__BackingField;

		// Token: 0x04001F4A RID: 8010
		[CompilerGenerated]
		private ICommand <AddZadarmaTrunkCommand>k__BackingField;

		// Token: 0x04001F4B RID: 8011
		[CompilerGenerated]
		private ICommand <SaveZadarmaTrunkCommand>k__BackingField;

		// Token: 0x04001F4C RID: 8012
		[CompilerGenerated]
		private ICommand <DeleteZadarmaTrunkCommand>k__BackingField;

		// Token: 0x04001F4D RID: 8013
		[CompilerGenerated]
		private ICommand <ClearDialPlanCommand>k__BackingField;

		// Token: 0x04001F4E RID: 8014
		[CompilerGenerated]
		private RelayCommand <RemoveDialplanActionCommand>k__BackingField;

		// Token: 0x04001F4F RID: 8015
		[CompilerGenerated]
		private ICommand <AddDialplanActionCommand>k__BackingField;

		// Token: 0x04001F50 RID: 8016
		[CompilerGenerated]
		private ICommand <SaveDialplanCommand>k__BackingField;

		// Token: 0x04001F51 RID: 8017
		[CompilerGenerated]
		private ICommand <SelectAudioFileCommand>k__BackingField;

		// Token: 0x04001F52 RID: 8018
		private users _selectedUser;

		// Token: 0x04001F53 RID: 8019
		private int _voipTabIndex;

		// Token: 0x04001F54 RID: 8020
		private queues _selectedQueue;

		// Token: 0x04001F55 RID: 8021
		private ps_endpoints _selectedZadarmaEndpoint;

		// Token: 0x04001F56 RID: 8022
		private string _selectedContext;

		// Token: 0x04001F57 RID: 8023
		private string _selectedDialplanExten;

		// Token: 0x04001F58 RID: 8024
		private extensions _selectedExistDialplanActions;

		// Token: 0x04001F59 RID: 8025
		private ExtensionActions _newDialplanAction;

		// Token: 0x04001F5A RID: 8026
		[CompilerGenerated]
		private List<ps_endpoints> <Endpoints>k__BackingField;

		// Token: 0x020005B2 RID: 1458
		[CompilerGenerated]
		private sealed class <>c__DisplayClass154_0
		{
			// Token: 0x060036C3 RID: 14019 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass154_0()
			{
			}

			// Token: 0x060036C4 RID: 14020 RVA: 0x000BAA24 File Offset: 0x000B8C24
			internal bool <set_SelectedDiagramItem>b__0(queue_members m)
			{
				return m.membername == this.queueMember.membername;
			}

			// Token: 0x04001F5B RID: 8027
			public queue_members queueMember;
		}

		// Token: 0x020005B3 RID: 1459
		[CompilerGenerated]
		private sealed class <>c__DisplayClass280_0
		{
			// Token: 0x060036C5 RID: 14021 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass280_0()
			{
			}

			// Token: 0x060036C6 RID: 14022 RVA: 0x000BAA48 File Offset: 0x000B8C48
			internal bool <SelectQueueByname>b__0(queues q)
			{
				return q.name == this.queueName;
			}

			// Token: 0x04001F5C RID: 8028
			public string queueName;
		}

		// Token: 0x020005B4 RID: 1460
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadQueues>d__281 : IAsyncStateMachine
		{
			// Token: 0x060036C7 RID: 14023 RVA: 0x000BAA68 File Offset: 0x000B8C68
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<queues>> awaiter;
					if (num != 0)
					{
						awaiter = voIPViewModel._voipModel.LoadQueueses().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<queues>>, VoIPViewModel.<LoadQueues>d__281>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<queues>>);
						this.<>1__state = -1;
					}
					List<queues> result = awaiter.GetResult();
					voIPViewModel.Queues = new ObservableCollection<queues>(result);
					voIPViewModel.LoadEndpoints();
					if (!this.onlyQueues)
					{
						voIPViewModel.LoadQueueDiagram_();
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

			// Token: 0x060036C8 RID: 14024 RVA: 0x000BAB44 File Offset: 0x000B8D44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F5D RID: 8029
			public int <>1__state;

			// Token: 0x04001F5E RID: 8030
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F5F RID: 8031
			public VoIPViewModel <>4__this;

			// Token: 0x04001F60 RID: 8032
			public bool onlyQueues;

			// Token: 0x04001F61 RID: 8033
			private TaskAwaiter<List<queues>> <>u__1;
		}

		// Token: 0x020005B5 RID: 1461
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadEndpoints>d__282 : IAsyncStateMachine
		{
			// Token: 0x060036C9 RID: 14025 RVA: 0x000BAB60 File Offset: 0x000B8D60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<ps_endpoints>> awaiter;
					if (num != 0)
					{
						awaiter = VoipModel.GetEndpoints().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<ps_endpoints>>, VoIPViewModel.<LoadEndpoints>d__282>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<ps_endpoints>>);
						this.<>1__state = -1;
					}
					IEnumerable<ps_endpoints> result = awaiter.GetResult();
					voIPViewModel.Endpoints = new List<ps_endpoints>(result);
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

			// Token: 0x060036CA RID: 14026 RVA: 0x000BAC20 File Offset: 0x000B8E20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F62 RID: 8034
			public int <>1__state;

			// Token: 0x04001F63 RID: 8035
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F64 RID: 8036
			public VoIPViewModel <>4__this;

			// Token: 0x04001F65 RID: 8037
			private TaskAwaiter<IEnumerable<ps_endpoints>> <>u__1;
		}

		// Token: 0x020005B6 RID: 1462
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDialplanSipUsers>d__283 : IAsyncStateMachine
		{
			// Token: 0x060036CB RID: 14027 RVA: 0x000BAC3C File Offset: 0x000B8E3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<users>> awaiter;
					if (num != 0)
					{
						awaiter = voIPViewModel._voipModel.LoadSipUsers().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, VoIPViewModel.<LoadDialplanSipUsers>d__283>(ref awaiter, ref this);
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
					voIPViewModel.DialplanSipUsers = result;
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

			// Token: 0x060036CC RID: 14028 RVA: 0x000BAD00 File Offset: 0x000B8F00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F66 RID: 8038
			public int <>1__state;

			// Token: 0x04001F67 RID: 8039
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F68 RID: 8040
			public VoIPViewModel <>4__this;

			// Token: 0x04001F69 RID: 8041
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x020005B7 RID: 1463
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060036CD RID: 14029 RVA: 0x000BAD1C File Offset: 0x000B8F1C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060036CE RID: 14030 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060036CF RID: 14031 RVA: 0x000BAD34 File Offset: 0x000B8F34
			internal List<QueueDiagram> <LoadQueueDiagram_>b__284_0()
			{
				return VoipModel.LoadQueueDiagram();
			}

			// Token: 0x060036D0 RID: 14032 RVA: 0x000BAD48 File Offset: 0x000B8F48
			internal string <AddQueue>b__304_0(queues q)
			{
				return q.name;
			}

			// Token: 0x060036D1 RID: 14033 RVA: 0x000BAD5C File Offset: 0x000B8F5C
			internal string <LoadDialpnanFields>b__331_0(extensions c)
			{
				return c.exten;
			}

			// Token: 0x04001F6A RID: 8042
			public static readonly VoIPViewModel.<>c <>9 = new VoIPViewModel.<>c();

			// Token: 0x04001F6B RID: 8043
			public static Func<List<QueueDiagram>> <>9__284_0;

			// Token: 0x04001F6C RID: 8044
			public static Func<queues, string> <>9__304_0;

			// Token: 0x04001F6D RID: 8045
			public static Func<extensions, string> <>9__331_0;
		}

		// Token: 0x020005B8 RID: 1464
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadQueueDiagram_>d__284 : IAsyncStateMachine
		{
			// Token: 0x060036D2 RID: 14034 RVA: 0x000BAD70 File Offset: 0x000B8F70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<QueueDiagram>> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<List<QueueDiagram>>(new Func<List<QueueDiagram>>(VoIPViewModel.<>c.<>9.<LoadQueueDiagram_>b__284_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<QueueDiagram>>, VoIPViewModel.<LoadQueueDiagram_>d__284>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<QueueDiagram>>);
						this.<>1__state = -1;
					}
					List<QueueDiagram> result = awaiter.GetResult();
					voIPViewModel.QueueDiagram = result;
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

			// Token: 0x060036D3 RID: 14035 RVA: 0x000BAE4C File Offset: 0x000B904C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F6E RID: 8046
			public int <>1__state;

			// Token: 0x04001F6F RID: 8047
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F70 RID: 8048
			public VoIPViewModel <>4__this;

			// Token: 0x04001F71 RID: 8049
			private TaskAwaiter<List<QueueDiagram>> <>u__1;
		}

		// Token: 0x020005B9 RID: 1465
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadQueuesMembers>d__285 : IAsyncStateMachine
		{
			// Token: 0x060036D4 RID: 14036 RVA: 0x000BAE68 File Offset: 0x000B9068
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<queue_members>> awaiter;
					if (num != 0)
					{
						if (voIPViewModel.SelectedQueue == null)
						{
							goto IL_B2;
						}
						voIPViewModel.ShowWait();
						awaiter = Task.Run<IEnumerable<queue_members>>(() => VoipModel.LoadQueueMembers(base.SelectedQueue)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<queue_members>>, VoIPViewModel.<LoadQueuesMembers>d__285>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<queue_members>>);
						this.<>1__state = -1;
					}
					IEnumerable<queue_members> result = awaiter.GetResult();
					voIPViewModel.QueueMembers = new ObservableCollection<queue_members>(result);
					voIPViewModel.HideWait();
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

			// Token: 0x060036D5 RID: 14037 RVA: 0x000BAF4C File Offset: 0x000B914C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F72 RID: 8050
			public int <>1__state;

			// Token: 0x04001F73 RID: 8051
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F74 RID: 8052
			public VoIPViewModel <>4__this;

			// Token: 0x04001F75 RID: 8053
			private TaskAwaiter<IEnumerable<queue_members>> <>u__1;
		}

		// Token: 0x020005BA RID: 1466
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeleteEndpoint>d__294 : IAsyncStateMachine
		{
			// Token: 0x060036D6 RID: 14038 RVA: 0x000BAF68 File Offset: 0x000B9168
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (voIPViewModel._ascMessageBoxService.ShowMessageBox(Lang.t("ConfirmDelete"), "", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
						{
							goto IL_BB;
						}
						voIPViewModel.ShowWait();
						awaiter = Task.Run<bool>(() => VoipModel.RemoveTel(base.SelectedEndpoint.id)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, VoIPViewModel.<DeleteEndpoint>d__294>(ref awaiter, ref this);
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
					voIPViewModel.HideWait();
					if (result)
					{
						voIPViewModel.LoadEndpoints();
					}
					voIPViewModel.ShowActionResponse(result, "");
					IL_BB:;
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

			// Token: 0x060036D7 RID: 14039 RVA: 0x000BB070 File Offset: 0x000B9270
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F76 RID: 8054
			public int <>1__state;

			// Token: 0x04001F77 RID: 8055
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F78 RID: 8056
			public VoIPViewModel <>4__this;

			// Token: 0x04001F79 RID: 8057
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020005BB RID: 1467
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddUserToQueue>d__301 : IAsyncStateMachine
		{
			// Token: 0x060036D8 RID: 14040 RVA: 0x000BB08C File Offset: 0x000B928C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						voIPViewModel.ShowWait();
						awaiter = Task.Run<bool>(() => VoipModel.AddEndpointToQueue(base.SelectedEndpoint, base.SelectedQueue.name)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, VoIPViewModel.<AddUserToQueue>d__301>(ref awaiter, ref this);
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
					voIPViewModel.HideWait();
					if (result)
					{
						voIPViewModel.LoadQueuesMembers();
						voIPViewModel.LoadQueueDiagram_();
					}
					voIPViewModel.ShowActionResponse(result, "");
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

			// Token: 0x060036D9 RID: 14041 RVA: 0x000BB174 File Offset: 0x000B9374
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F7A RID: 8058
			public int <>1__state;

			// Token: 0x04001F7B RID: 8059
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F7C RID: 8060
			public VoIPViewModel <>4__this;

			// Token: 0x04001F7D RID: 8061
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020005BC RID: 1468
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadZadarmaEndpoints>d__319 : IAsyncStateMachine
		{
			// Token: 0x060036DA RID: 14042 RVA: 0x000BB190 File Offset: 0x000B9390
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<ps_endpoints>> awaiter;
					if (num != 0)
					{
						awaiter = voIPViewModel._voipModel.GetZadarmaEndpoints().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ps_endpoints>>, VoIPViewModel.<LoadZadarmaEndpoints>d__319>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<ps_endpoints>>);
						this.<>1__state = -1;
					}
					List<ps_endpoints> result = awaiter.GetResult();
					voIPViewModel.ZadarmaEndpointses = result;
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

			// Token: 0x060036DB RID: 14043 RVA: 0x000BB254 File Offset: 0x000B9454
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F7E RID: 8062
			public int <>1__state;

			// Token: 0x04001F7F RID: 8063
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F80 RID: 8064
			public VoIPViewModel <>4__this;

			// Token: 0x04001F81 RID: 8065
			private TaskAwaiter<List<ps_endpoints>> <>u__1;
		}

		// Token: 0x020005BD RID: 1469
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadZadarmaAor>d__322 : IAsyncStateMachine
		{
			// Token: 0x060036DC RID: 14044 RVA: 0x000BB270 File Offset: 0x000B9470
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<ps_aors> awaiter;
					if (num != 0)
					{
						awaiter = VoipModel.GetAorById(this.aorId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ps_aors>, VoIPViewModel.<LoadZadarmaAor>d__322>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<ps_aors>);
						this.<>1__state = -1;
					}
					ps_aors result = awaiter.GetResult();
					voIPViewModel.SelectedZadarmaAor = result;
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

			// Token: 0x060036DD RID: 14045 RVA: 0x000BB334 File Offset: 0x000B9534
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F82 RID: 8066
			public int <>1__state;

			// Token: 0x04001F83 RID: 8067
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F84 RID: 8068
			public string aorId;

			// Token: 0x04001F85 RID: 8069
			public VoIPViewModel <>4__this;

			// Token: 0x04001F86 RID: 8070
			private TaskAwaiter<ps_aors> <>u__1;
		}

		// Token: 0x020005BE RID: 1470
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDialplanItems>d__325 : IAsyncStateMachine
		{
			// Token: 0x060036DE RID: 14046 RVA: 0x000BB350 File Offset: 0x000B9550
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<string>> awaiter;
					if (num != 0)
					{
						voIPViewModel.ShowWait();
						awaiter = Task.Run<List<string>>(() => voIPViewModel._voipModel.LoadAllExistContext()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, VoIPViewModel.<LoadDialplanItems>d__325>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<string>>);
						this.<>1__state = -1;
					}
					List<string> result = awaiter.GetResult();
					voIPViewModel.Contextsts = result;
					ExtensionActions extensionActions = new ExtensionActions();
					voIPViewModel.AllDialplanActions = extensionActions.GetActions();
					voIPViewModel.HideWait();
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

			// Token: 0x060036DF RID: 14047 RVA: 0x000BB438 File Offset: 0x000B9638
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F87 RID: 8071
			public int <>1__state;

			// Token: 0x04001F88 RID: 8072
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F89 RID: 8073
			public VoIPViewModel <>4__this;

			// Token: 0x04001F8A RID: 8074
			private TaskAwaiter<List<string>> <>u__1;
		}

		// Token: 0x020005BF RID: 1471
		[CompilerGenerated]
		private sealed class <>c__DisplayClass327_0
		{
			// Token: 0x060036E0 RID: 14048 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass327_0()
			{
			}

			// Token: 0x060036E1 RID: 14049 RVA: 0x000BB454 File Offset: 0x000B9654
			internal bool <GetxExistDialplanExtenActions>b__0(extensions c)
			{
				return c.exten == this.value;
			}

			// Token: 0x04001F8B RID: 8075
			public string value;
		}

		// Token: 0x020005C0 RID: 1472
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddDialplanAction>d__330 : IAsyncStateMachine
		{
			// Token: 0x060036E2 RID: 14050 RVA: 0x000BB474 File Offset: 0x000B9674
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VoIPViewModel voIPViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<AudioFileUploadResponse> awaiter;
					if (num != 0)
					{
						if (string.IsNullOrEmpty(voIPViewModel.SelectedContext))
						{
							goto IL_3CF;
						}
						if (voIPViewModel.NewDialplanAction == null)
						{
							voIPViewModel._toasterService.Info(Lang.t("SelectAction"));
							goto IL_3CF;
						}
						extensions selectedExistDialplanActions = voIPViewModel.SelectedExistDialplanActions;
						this.<priority>5__2 = ((selectedExistDialplanActions != null) ? selectedExistDialplanActions.priority : 0);
						if (voIPViewModel.NewDialplanAction.ActionId == 4)
						{
							voIPViewModel._voipModel.AddDialplanActionQueueToDb(voIPViewModel.SelectedDialplanQueue.name, voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
							voIPViewModel.RefreshDialplanTabAfterEdit();
							goto IL_3CF;
						}
						if (voIPViewModel.NewDialplanAction.ActionId != 3)
						{
							if (voIPViewModel.NewDialplanAction.ActionId != 5)
							{
								if (voIPViewModel.NewDialplanAction.ActionId != 8)
								{
									if (voIPViewModel.NewDialplanAction.ActionId != 9)
									{
										if (voIPViewModel.NewDialplanAction.ActionId == 6)
										{
											voIPViewModel._voipModel.AddDialplanActionHangUpToDb(voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
											voIPViewModel.RefreshDialplanTabAfterEdit();
											goto IL_3CF;
										}
										if (voIPViewModel.NewDialplanAction.ActionId != 2)
										{
											if (voIPViewModel.NewDialplanAction.ActionId == 10)
											{
												if (!string.IsNullOrEmpty(voIPViewModel.SelectedDialDongle))
												{
													voIPViewModel._voipModel.AddDialplanActionSendToModemToDb(voIPViewModel.SelectedDialDongle, voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
													voIPViewModel.RefreshDialplanTabAfterEdit();
												}
												else
												{
													voIPViewModel._toasterService.Info(Lang.t("SelectModem"));
												}
											}
											goto IL_3CF;
										}
										voIPViewModel._voipModel.AddDialplanActionRecordCallToDb(voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
										voIPViewModel.RefreshDialplanTabAfterEdit();
										goto IL_3CF;
									}
									else
									{
										if (voIPViewModel.SelectedTrunk == null)
										{
											voIPViewModel._toasterService.Info(Lang.t("SelectTrunk"));
											goto IL_3CF;
										}
										voIPViewModel._voipModel.AddDialplanActionSendToTrunkToDb(voIPViewModel.SelectedTrunk, voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
										voIPViewModel.RefreshDialplanTabAfterEdit();
										goto IL_3CF;
									}
								}
								else
								{
									if (!string.IsNullOrEmpty(voIPViewModel.NewDialplanActionAsteriskDbPassword))
									{
										voIPViewModel._voipModel.AddDialplanActionSaveSmsToDb(voIPViewModel.NewDialplanActionAsteriskDbPassword, voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
										voIPViewModel.RefreshDialplanTabAfterEdit();
										goto IL_3CF;
									}
									voIPViewModel._toasterService.Info(Lang.t("InputAsteriskDbPassword"));
									goto IL_3CF;
								}
							}
							else
							{
								if (voIPViewModel.NewDialplanActionSipUser == null && !voIPViewModel.NewDialplanActionSipUserCalled)
								{
									voIPViewModel._toasterService.Info(Lang.t("SelectPhone"));
									goto IL_3CF;
								}
								voIPViewModel._voipModel.AddDialplanActionSendToIntNumberToDb(voIPViewModel.NewDialplanActionSipUser, voIPViewModel.NewDialplanActionSipUserCalled, voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
								voIPViewModel.RefreshDialplanTabAfterEdit();
								goto IL_3CF;
							}
						}
						else
						{
							if (string.IsNullOrEmpty(voIPViewModel.NewDialplanActionFilePath))
							{
								voIPViewModel._toasterService.Info(Lang.t("SelectFileErr"));
								goto IL_3CF;
							}
							awaiter = voIPViewModel._voipModel.SendRecordToServer(voIPViewModel.NewDialplanActionFilePath).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<AudioFileUploadResponse>, VoIPViewModel.<AddDialplanAction>d__330>(ref awaiter, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<AudioFileUploadResponse>);
						this.<>1__state = -1;
					}
					AudioFileUploadResponse result = awaiter.GetResult();
					if (result != null && result.status)
					{
						voIPViewModel._voipModel.AddDialplanActionPlayFileToDb(result.destination.Replace(".wav", ""), voIPViewModel.SelectedContext, voIPViewModel.SelectedDialplanExten, this.<priority>5__2);
						voIPViewModel.RefreshDialplanTabAfterEdit();
					}
					else
					{
						voIPViewModel._toasterService.Error(Lang.t("FileUploadErr"));
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_3CF:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060036E3 RID: 14051 RVA: 0x000BB880 File Offset: 0x000B9A80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F8C RID: 8076
			public int <>1__state;

			// Token: 0x04001F8D RID: 8077
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F8E RID: 8078
			public VoIPViewModel <>4__this;

			// Token: 0x04001F8F RID: 8079
			private int <priority>5__2;

			// Token: 0x04001F90 RID: 8080
			private TaskAwaiter<AudioFileUploadResponse> <>u__1;
		}
	}
}
