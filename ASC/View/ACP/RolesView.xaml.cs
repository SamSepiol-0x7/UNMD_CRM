using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ASC.ViewModels.ACP;
using DevExpress.Xpf.Editors;

namespace ASC.View.ACP
{
	// Token: 0x0200039E RID: 926
	public partial class RolesView : UserControl, INotifyPropertyChanged
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06002725 RID: 10021 RVA: 0x0007733C File Offset: 0x0007553C
		// (remove) Token: 0x06002726 RID: 10022 RVA: 0x00077374 File Offset: 0x00075574
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				for (;;)
				{
					IL_5C:
					int num = -104262676;
					for (;;)
					{
						switch ((num ^ -48630268) % 3)
						{
						case 1:
						{
							PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
							PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
							propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
							num = ((propertyChangedEventHandler != propertyChangedEventHandler2) ? -104262676 : -1552623896);
							continue;
						}
						case 2:
							goto IL_5C;
						}
						return;
					}
				}
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000773E4 File Offset: 0x000755E4
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x000773F8 File Offset: 0x000755F8
		private List<roles> Roles
		{
			[CompilerGenerated]
			get
			{
				return this.<Roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Roles>k__BackingField, value))
				{
					return;
				}
				this.<Roles>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Roles);
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00077428 File Offset: 0x00075628
		public RolesView()
		{
			this.InitializeComponent();
			this.FillRoles();
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00077454 File Offset: 0x00075654
		private void FillRoles()
		{
			this.gridAcpRoles.DataContext = this._arm;
			this._arm.LoadData();
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00077480 File Offset: 0x00075680
		private void dataGridRoles_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			DataGrid dataGrid = sender as DataGrid;
			roles roles = ((dataGrid != null) ? dataGrid.SelectedItem : null) as roles;
			if (roles != null)
			{
				this.ButtonSaveRole.IsEnabled = true;
				this.TextBoxRoleName.IsEnabled = true;
				if (roles.id != 1)
				{
					this.ListBoxPermissions.IsEnabled = true;
					this.TextBoxRoleDescription.IsEnabled = true;
					this.ButtonRemoveRole.IsEnabled = true;
				}
				else
				{
					this.ListBoxPermissions.IsEnabled = false;
					this.TextBoxRoleDescription.IsEnabled = false;
					this.ButtonRemoveRole.IsEnabled = false;
				}
				this.TextBoxRoleName.Text = roles.name;
				this.TextBoxRoleDescription.Text = roles.description;
				this.ButtonCancelRoleEdit.IsEnabled = true;
				this._arm.CheckedPermissions = new ObservableCollection<permissions>(this._arm.LoadRole(roles.id));
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00077568 File Offset: 0x00075768
		private void buttonSaveRole_Click(object sender, RoutedEventArgs e)
		{
			this._arm.SaveRole(this.TextBoxRoleName.Text, this.TextBoxRoleDescription.Text);
			this.ClearRolesFields();
			this.FillRoles();
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000775A4 File Offset: 0x000757A4
		private void ClearRolesFields()
		{
			this.TextBoxRoleName.Clear();
			this.TextBoxRoleDescription.Clear();
			this._arm.CheckedPermissions = null;
			this.ListBoxPermissions.IsEnabled = true;
			this.DataGridRoles.UnselectAll();
			this.ButtonCancelRoleEdit.IsEnabled = false;
			this.ButtonNewRole.Visibility = Visibility.Hidden;
			this.TextBoxRoleName.IsEnabled = false;
			this.TextBoxRoleName.ClearValue(Control.BackgroundProperty);
			this.TextBoxRoleDescription.IsEnabled = false;
			this.ButtonSaveRole.IsEnabled = false;
			this.ButtonRemoveRole.IsEnabled = false;
			this._arm.Clear();
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00077650 File Offset: 0x00075850
		private void buttonCancelRoleEdit_Click(object sender, RoutedEventArgs e)
		{
			this.ClearRolesFields();
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00077664 File Offset: 0x00075864
		private void button_Click(object sender, RoutedEventArgs e)
		{
			this.ClearRolesFields();
			this.TextBoxRoleName.Focus();
			this.ButtonNewRole.Visibility = Visibility.Visible;
			this.ButtonCancelRoleEdit.IsEnabled = true;
			this.TextBoxRoleName.IsEnabled = true;
			this.TextBoxRoleName.Focus();
			this.TextBoxRoleName.Background = Brushes.LightGreen;
			this.TextBoxRoleDescription.IsEnabled = true;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000776D0 File Offset: 0x000758D0
		private void buttonNewRole_Click(object sender, RoutedEventArgs e)
		{
			if (this._arm.NewRole(this.TextBoxRoleName.Text, this.TextBoxRoleDescription.Text, this.ListBoxPermissions.SelectedItems))
			{
				this.ClearRolesFields();
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00077714 File Offset: 0x00075914
		private void button_Copy_Click(object sender, RoutedEventArgs e)
		{
			if (this._arm.RemoveRole())
			{
				this.ClearRolesFields();
			}
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00077734 File Offset: 0x00075934
		private void TextBoxRoleName_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.TextBoxRoleName.Text.Length > 2)
			{
				this.TextBoxRoleName.ClearValue(Control.BackgroundProperty);
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000778F0 File Offset: 0x00075AF0
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x04001528 RID: 5416
		private RolesViewModel _arm = new RolesViewModel();
	}
}
