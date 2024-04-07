using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;

namespace ASC.ViewModels
{
	// Token: 0x02000425 RID: 1061
	public class MenuViewModel : BaseViewModel
	{
		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x0008655C File Offset: 0x0008475C
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x000865A0 File Offset: 0x000847A0
		public ObservableCollection<HamburgerMenuItemViewModel> MenuItems
		{
			get
			{
				return base.GetProperty<ObservableCollection<HamburgerMenuItemViewModel>>(() => this.MenuItems);
			}
			set
			{
				if (!object.Equals(this.MenuItems, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1992785037;
				IL_13:
				switch ((num ^ -765968812) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = -1335986034;
					goto IL_13;
				case 3:
					return;
				}
				base.SetProperty<ObservableCollection<HamburgerMenuItemViewModel>>(() => this.MenuItems, value);
				this.RaisePropertyChanged("MenuItems");
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x0008662C File Offset: 0x0008482C
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x00086670 File Offset: 0x00084870
		public HamburgerMenuItemViewModel SelectedMenuItem
		{
			get
			{
				return base.GetProperty<HamburgerMenuItemViewModel>(() => this.SelectedMenuItem);
			}
			set
			{
				if (object.Equals(this.SelectedMenuItem, value))
				{
					return;
				}
				base.SetProperty<HamburgerMenuItemViewModel>(() => this.SelectedMenuItem, value, new Action(this.MenuItemChanged));
				this.RaisePropertyChanged("SelectedMenuItem");
			}
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000866DC File Offset: 0x000848DC
		public MenuViewModel()
		{
			this.MenuItems = new ObservableCollection<HamburgerMenuItemViewModel>();
			this.SelectedMenuItem = null;
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x00023150 File Offset: 0x00021350
		public virtual void MenuItemChanged()
		{
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x00086704 File Offset: 0x00084904
		public virtual void InitMenu()
		{
			this.ClearMenu();
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00086718 File Offset: 0x00084918
		public virtual void ClearMenu()
		{
			Application.Current.Dispatcher.Invoke(delegate()
			{
				this.MenuItems.Clear();
			});
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00086740 File Offset: 0x00084940
		public void AddMenuItem(string captionResource, string viewName, string iconName = "")
		{
			Application.Current.Dispatcher.Invoke(delegate()
			{
				if (string.IsNullOrEmpty(iconName))
				{
					this.MenuItems.Add(new HamburgerMenuItemViewModel(Lang.t(captionResource), viewName));
					return;
				}
				DXImageInfo glyph = (DXImageInfo)new DXImageConverter().ConvertFromString(iconName);
				this.MenuItems.Add(new HamburgerMenuItemViewModel(Lang.t(captionResource), viewName, glyph));
			});
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x0008678C File Offset: 0x0008498C
		public void AddMenuItem(string captionResource, string viewName, string iconName, object prm)
		{
			Application.Current.Dispatcher.Invoke(delegate()
			{
				DXImageInfo glyph = (DXImageInfo)new DXImageConverter().ConvertFromString(iconName);
				this.MenuItems.Add(new HamburgerMenuItemViewModel(Lang.t(captionResource), viewName, glyph, prm));
			});
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000867E0 File Offset: 0x000849E0
		public bool CurrentMenuItemPageName(string name)
		{
			return this.SelectedMenuItem != null && this.SelectedMenuItem.PageName == name;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00086808 File Offset: 0x00084A08
		public bool CurrentMenuItemCaption(string resourceName)
		{
			return this.SelectedMenuItem != null && this.SelectedMenuItem.Caption == Lang.t(resourceName);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00086838 File Offset: 0x00084A38
		public void SelectMenuItebByCaption(string resourceName)
		{
			MenuViewModel.<SelectMenuItebByCaption>d__14 <SelectMenuItebByCaption>d__;
			<SelectMenuItebByCaption>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectMenuItebByCaption>d__.<>4__this = this;
			<SelectMenuItebByCaption>d__.resourceName = resourceName;
			<SelectMenuItebByCaption>d__.<>1__state = -1;
			<SelectMenuItebByCaption>d__.<>t__builder.Start<MenuViewModel.<SelectMenuItebByCaption>d__14>(ref <SelectMenuItebByCaption>d__);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00086878 File Offset: 0x00084A78
		public void SelectFirstMenuItem()
		{
			MenuViewModel.<SelectFirstMenuItem>d__15 <SelectFirstMenuItem>d__;
			<SelectFirstMenuItem>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SelectFirstMenuItem>d__.<>4__this = this;
			<SelectFirstMenuItem>d__.<>1__state = -1;
			<SelectFirstMenuItem>d__.<>t__builder.Start<MenuViewModel.<SelectFirstMenuItem>d__15>(ref <SelectFirstMenuItem>d__);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000868B0 File Offset: 0x00084AB0
		[CompilerGenerated]
		private void <ClearMenu>b__9_0()
		{
			this.MenuItems.Clear();
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x000868C8 File Offset: 0x00084AC8
		[CompilerGenerated]
		private void <SelectFirstMenuItem>b__15_0()
		{
			this.SelectedMenuItem = this.MenuItems[0];
		}

		// Token: 0x02000426 RID: 1062
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06002AA3 RID: 10915 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06002AA4 RID: 10916 RVA: 0x000868E8 File Offset: 0x00084AE8
			internal void <AddMenuItem>b__0()
			{
				if (string.IsNullOrEmpty(this.iconName))
				{
					this.<>4__this.MenuItems.Add(new HamburgerMenuItemViewModel(Lang.t(this.captionResource), this.viewName));
					return;
				}
				DXImageInfo glyph = (DXImageInfo)new DXImageConverter().ConvertFromString(this.iconName);
				this.<>4__this.MenuItems.Add(new HamburgerMenuItemViewModel(Lang.t(this.captionResource), this.viewName, glyph));
			}

			// Token: 0x04001797 RID: 6039
			public string iconName;

			// Token: 0x04001798 RID: 6040
			public MenuViewModel <>4__this;

			// Token: 0x04001799 RID: 6041
			public string captionResource;

			// Token: 0x0400179A RID: 6042
			public string viewName;
		}

		// Token: 0x02000427 RID: 1063
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06002AA5 RID: 10917 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06002AA6 RID: 10918 RVA: 0x00086968 File Offset: 0x00084B68
			internal void <AddMenuItem>b__0()
			{
				DXImageInfo glyph = (DXImageInfo)new DXImageConverter().ConvertFromString(this.iconName);
				this.<>4__this.MenuItems.Add(new HamburgerMenuItemViewModel(Lang.t(this.captionResource), this.viewName, glyph, this.prm));
			}

			// Token: 0x0400179B RID: 6043
			public string iconName;

			// Token: 0x0400179C RID: 6044
			public MenuViewModel <>4__this;

			// Token: 0x0400179D RID: 6045
			public string captionResource;

			// Token: 0x0400179E RID: 6046
			public string viewName;

			// Token: 0x0400179F RID: 6047
			public object prm;
		}

		// Token: 0x02000428 RID: 1064
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06002AA7 RID: 10919 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06002AA8 RID: 10920 RVA: 0x000869B8 File Offset: 0x00084BB8
			internal void <SelectMenuItebByCaption>b__0()
			{
				MenuViewModel menuViewModel = this.<>4__this;
				IEnumerable<HamburgerMenuItemViewModel> menuItems = this.<>4__this.MenuItems;
				Func<HamburgerMenuItemViewModel, bool> predicate;
				if ((predicate = this.<>9__1) == null)
				{
					predicate = (this.<>9__1 = ((HamburgerMenuItemViewModel i) => i.Caption == Lang.t(this.resourceName)));
				}
				menuViewModel.SelectedMenuItem = menuItems.FirstOrDefault(predicate);
			}

			// Token: 0x06002AA9 RID: 10921 RVA: 0x00086A00 File Offset: 0x00084C00
			internal bool <SelectMenuItebByCaption>b__1(HamburgerMenuItemViewModel i)
			{
				return i.Caption == Lang.t(this.resourceName);
			}

			// Token: 0x040017A0 RID: 6048
			public MenuViewModel <>4__this;

			// Token: 0x040017A1 RID: 6049
			public string resourceName;

			// Token: 0x040017A2 RID: 6050
			public Func<HamburgerMenuItemViewModel, bool> <>9__1;
		}

		// Token: 0x02000429 RID: 1065
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectMenuItebByCaption>d__14 : IAsyncStateMachine
		{
			// Token: 0x06002AAA RID: 10922 RVA: 0x00086A24 File Offset: 0x00084C24
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(new MenuViewModel.<>c__DisplayClass14_0
						{
							<>4__this = this.<>4__this,
							resourceName = this.resourceName
						}.<SelectMenuItebByCaption>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MenuViewModel.<SelectMenuItebByCaption>d__14>(ref awaiter, ref this);
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

			// Token: 0x06002AAB RID: 10923 RVA: 0x00086AF8 File Offset: 0x00084CF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017A3 RID: 6051
			public int <>1__state;

			// Token: 0x040017A4 RID: 6052
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017A5 RID: 6053
			public MenuViewModel <>4__this;

			// Token: 0x040017A6 RID: 6054
			public string resourceName;

			// Token: 0x040017A7 RID: 6055
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200042A RID: 1066
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SelectFirstMenuItem>d__15 : IAsyncStateMachine
		{
			// Token: 0x06002AAC RID: 10924 RVA: 0x00086B14 File Offset: 0x00084D14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MenuViewModel @object = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(delegate()
						{
							base.SelectedMenuItem = base.MenuItems[0];
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MenuViewModel.<SelectFirstMenuItem>d__15>(ref awaiter, ref this);
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

			// Token: 0x06002AAD RID: 10925 RVA: 0x00086BD4 File Offset: 0x00084DD4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017A8 RID: 6056
			public int <>1__state;

			// Token: 0x040017A9 RID: 6057
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017AA RID: 6058
			public MenuViewModel <>4__this;

			// Token: 0x040017AB RID: 6059
			private TaskAwaiter <>u__1;
		}
	}
}
