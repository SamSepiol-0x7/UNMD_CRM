using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ASC.Extensions;
using ASC.Models;
using DevExpress.Xpf.Core;
using NLog;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000547 RID: 1351
	internal class RolesViewModel : GenericModel, INotifyPropertyChanged
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600321B RID: 12827 RVA: 0x000A7994 File Offset: 0x000A5B94
		// (remove) Token: 0x0600321C RID: 12828 RVA: 0x000A79CC File Offset: 0x000A5BCC
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
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x000A7A04 File Offset: 0x000A5C04
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x000A7A18 File Offset: 0x000A5C18
		public ObservableCollection<permissions> CheckedPermissions
		{
			[CompilerGenerated]
			get
			{
				return this.<CheckedPermissions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CheckedPermissions>k__BackingField, value))
				{
					return;
				}
				this.<CheckedPermissions>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CheckedPermissions);
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x000A7A48 File Offset: 0x000A5C48
		// (set) Token: 0x06003220 RID: 12832 RVA: 0x000A7A5C File Offset: 0x000A5C5C
		private int SelectedRole
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedRole>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<SelectedRole>k__BackingField == value)
				{
					return;
				}
				this.<SelectedRole>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.SelectedRole);
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x000A7A88 File Offset: 0x000A5C88
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x000A7A9C File Offset: 0x000A5C9C
		public ObservableCollection<permissions> Permissions
		{
			get
			{
				return this._permissions;
			}
			set
			{
				if (object.Equals(this._permissions, value))
				{
					return;
				}
				this._permissions = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Permissions);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000A7ACC File Offset: 0x000A5CCC
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x000A7AE0 File Offset: 0x000A5CE0
		public ObservableCollection<roles> Roles
		{
			get
			{
				return this._roles;
			}
			set
			{
				if (object.Equals(this._roles, value))
				{
					return;
				}
				this._roles = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Roles);
			}
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x000A7B10 File Offset: 0x000A5D10
		public RolesViewModel()
		{
			this._bw.DoWork += this._bw_DoWork;
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000A7B50 File Offset: 0x000A5D50
		public void LoadData()
		{
			this._bw.RunWorkerAsync();
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000A7B68 File Offset: 0x000A5D68
		public List<permissions> LoadRole(int id)
		{
			this.SelectedRole = id;
			try
			{
				return (from p in this.Permissions
				join pr in this._context.permissions_roles on p.id equals pr.permission_id
				where pr.role_id == id
				where pr.permission_id < 26 || pr.permission_id > 37
				where pr.permission_id != 53
				where pr.permission_id != 64
				orderby p.name
				select p).ToList<permissions>();
			}
			catch (Exception ex)
			{
				ILogger log = GenericModel.Log;
				string str = "Permissions load error ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
			}
			return new List<permissions>();
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000A7D18 File Offset: 0x000A5F18
		public void SaveRole(string name, string description)
		{
			if (this.SelectedRole == 0)
			{
				MessageBox.Show("Error");
				return;
			}
			roles roles = this._context.roles.SingleOrDefault((roles r) => r.id == this.SelectedRole);
			if (roles == null)
			{
				return;
			}
			if (roles.name != name)
			{
				if (roles.name != name)
				{
					this._history.Add(10, new string[]
					{
						roles.name,
						name
					});
				}
				roles.name = name;
			}
			if (roles.id != 1)
			{
				if (roles.description != description)
				{
					if (roles.description != description)
					{
						this._history.Add(11, new string[]
						{
							roles.name,
							roles.description,
							description
						});
					}
					roles.description = description;
				}
			}
			this._context.permissions_roles.RemoveRange(from pr in this._context.permissions_roles
			where pr.role_id == this.SelectedRole
			select pr);
			if (this.CheckedPermissions != null)
			{
				foreach (permissions permissions in this.CheckedPermissions)
				{
					permissions_roles entity = new permissions_roles
					{
						permission_id = permissions.id,
						role_id = this.SelectedRole
					};
					this._context.permissions_roles.Add(entity);
				}
			}
			this._history.Add(9, new string[]
			{
				roles.name
			});
			base.SaveContext(false);
			this._history.Save();
			DXMessageBox.Show(Lang.t("Acl"), Lang.t("Saved"));
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x000A7F90 File Offset: 0x000A6190
		public bool NewRole(string name, string description, IList permissions)
		{
			if (name.Length > 0)
			{
				roles roles = new roles
				{
					name = name,
					description = description
				};
				this._context.roles.Add(roles);
				this._history.Add(12, new string[]
				{
					roles.name
				});
				base.SaveContext(false);
				this._history.Save();
				this.SelectedRole = roles.id;
				if (permissions.Count > 0)
				{
					foreach (object obj in permissions)
					{
						permissions permissions2 = (permissions)obj;
						permissions_roles entity = new permissions_roles
						{
							permission_id = permissions2.id,
							role_id = this.SelectedRole
						};
						this._context.permissions_roles.Add(entity);
					}
					base.SaveContext(false);
				}
				DXMessageBox.Show(Lang.t("Acl"), Lang.t("Saved"));
				this.LoadData();
				return true;
			}
			DXMessageBox.Show(Lang.t("Acl"), Lang.t("EmptyRoleName"));
			return false;
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000A80CC File Offset: 0x000A62CC
		public bool RemoveRole()
		{
			if (this.SelectedRole == 0)
			{
				return false;
			}
			roles roles = this._context.roles.FirstOrDefault((roles r) => r.id == this.SelectedRole);
			if (roles == null)
			{
				return false;
			}
			if (DXMessageBox.Show("Внимание! Удаление назначенных ролей приведёт к потере доступа к базе. Удалить роль " + roles.name + "?", Application.Current.TryFindResource("RemovingRole").ToString(), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
			{
				this._history.Add(13, new string[]
				{
					roles.name
				});
				this._context.roles.Remove(roles);
				base.SaveContext(false);
				this._history.Save();
				this.LoadData();
				return true;
			}
			return false;
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000A81DC File Offset: 0x000A63DC
		public void Clear()
		{
			this.SelectedRole = 0;
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000A81F0 File Offset: 0x000A63F0
		private void _bw_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.Permissions == null)
			{
				this.Permissions = new ObservableCollection<permissions>((from p in this._context.permissions
				orderby p.name
				select p into i
				where i.id != 53 && i.id != 64 && (i.id < 26 || i.id > 37)
				select i).ToListSafe<permissions>());
			}
			this.Roles = new ObservableCollection<roles>((from r in this._context.roles
			orderby r.name
			select r).ToListSafe<roles>());
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000A83B4 File Offset: 0x000A65B4
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

		// Token: 0x04001CCB RID: 7371
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001CCC RID: 7372
		private BackgroundWorker _bw = new BackgroundWorker();

		// Token: 0x04001CCD RID: 7373
		[CompilerGenerated]
		private ObservableCollection<permissions> <CheckedPermissions>k__BackingField = new ObservableCollection<permissions>();

		// Token: 0x04001CCE RID: 7374
		private ObservableCollection<permissions> _permissions;

		// Token: 0x04001CCF RID: 7375
		private ObservableCollection<roles> _roles;

		// Token: 0x04001CD0 RID: 7376
		[CompilerGenerated]
		private int <SelectedRole>k__BackingField;

		// Token: 0x02000548 RID: 1352
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x0600322E RID: 12846 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x0600322F RID: 12847 RVA: 0x000A83D8 File Offset: 0x000A65D8
			internal bool <LoadRole>b__3(<>f__AnonymousType5<permissions, permissions_roles> <>h__TransparentIdentifier0)
			{
				return <>h__TransparentIdentifier0.pr.role_id == this.id;
			}

			// Token: 0x04001CD1 RID: 7377
			public int id;
		}

		// Token: 0x02000549 RID: 1353
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003230 RID: 12848 RVA: 0x000A83F8 File Offset: 0x000A65F8
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003231 RID: 12849 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003232 RID: 12850 RVA: 0x000A8410 File Offset: 0x000A6610
			internal int <LoadRole>b__22_0(permissions p)
			{
				return p.id;
			}

			// Token: 0x06003233 RID: 12851 RVA: 0x000A8424 File Offset: 0x000A6624
			internal int <LoadRole>b__22_1(permissions_roles pr)
			{
				return pr.permission_id;
			}

			// Token: 0x06003234 RID: 12852 RVA: 0x000A8438 File Offset: 0x000A6638
			internal <>f__AnonymousType5<permissions, permissions_roles> <LoadRole>b__22_2(permissions p, permissions_roles pr)
			{
				return new
				{
					p,
					pr
				};
			}

			// Token: 0x06003235 RID: 12853 RVA: 0x000A844C File Offset: 0x000A664C
			internal bool <LoadRole>b__22_4(<>f__AnonymousType5<permissions, permissions_roles> <>h__TransparentIdentifier0)
			{
				return <>h__TransparentIdentifier0.pr.permission_id < 26 || <>h__TransparentIdentifier0.pr.permission_id > 37;
			}

			// Token: 0x06003236 RID: 12854 RVA: 0x000A847C File Offset: 0x000A667C
			internal bool <LoadRole>b__22_5(<>f__AnonymousType5<permissions, permissions_roles> <>h__TransparentIdentifier0)
			{
				return <>h__TransparentIdentifier0.pr.permission_id != 53;
			}

			// Token: 0x06003237 RID: 12855 RVA: 0x000A849C File Offset: 0x000A669C
			internal bool <LoadRole>b__22_6(<>f__AnonymousType5<permissions, permissions_roles> <>h__TransparentIdentifier0)
			{
				return <>h__TransparentIdentifier0.pr.permission_id != 64;
			}

			// Token: 0x06003238 RID: 12856 RVA: 0x000A84BC File Offset: 0x000A66BC
			internal string <LoadRole>b__22_7(<>f__AnonymousType5<permissions, permissions_roles> <>h__TransparentIdentifier0)
			{
				return <>h__TransparentIdentifier0.p.name;
			}

			// Token: 0x06003239 RID: 12857 RVA: 0x000A84D4 File Offset: 0x000A66D4
			internal permissions <LoadRole>b__22_8(<>f__AnonymousType5<permissions, permissions_roles> <>h__TransparentIdentifier0)
			{
				return <>h__TransparentIdentifier0.p;
			}

			// Token: 0x04001CD2 RID: 7378
			public static readonly RolesViewModel.<>c <>9 = new RolesViewModel.<>c();

			// Token: 0x04001CD3 RID: 7379
			public static Func<permissions, int> <>9__22_0;

			// Token: 0x04001CD4 RID: 7380
			public static Func<permissions_roles, int> <>9__22_1;

			// Token: 0x04001CD5 RID: 7381
			public static Func<permissions, permissions_roles, <>f__AnonymousType5<permissions, permissions_roles>> <>9__22_2;

			// Token: 0x04001CD6 RID: 7382
			public static Func<<>f__AnonymousType5<permissions, permissions_roles>, bool> <>9__22_4;

			// Token: 0x04001CD7 RID: 7383
			public static Func<<>f__AnonymousType5<permissions, permissions_roles>, bool> <>9__22_5;

			// Token: 0x04001CD8 RID: 7384
			public static Func<<>f__AnonymousType5<permissions, permissions_roles>, bool> <>9__22_6;

			// Token: 0x04001CD9 RID: 7385
			public static Func<<>f__AnonymousType5<permissions, permissions_roles>, string> <>9__22_7;

			// Token: 0x04001CDA RID: 7386
			public static Func<<>f__AnonymousType5<permissions, permissions_roles>, permissions> <>9__22_8;
		}
	}
}
