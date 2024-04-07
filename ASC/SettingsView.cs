using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using ASC.ViewModels.ACP;
using DevExpress.Xpf.WindowsUI;

namespace ASC
{
	// Token: 0x020000C2 RID: 194
	public class SettingsView : NavigationPage, INotifyPropertyChanged, IComponentConnector
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06001362 RID: 4962 RVA: 0x0002AD38 File Offset: 0x00028F38
		// (remove) Token: 0x06001363 RID: 4963 RVA: 0x0002ADA8 File Offset: 0x00028FA8
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				for (;;)
				{
					IL_5C:
					int num = 525592125;
					for (;;)
					{
						switch ((num ^ 122008958) % 3)
						{
						case 1:
						{
							PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
							PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
							propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
							num = ((propertyChangedEventHandler != propertyChangedEventHandler2) ? 525592125 : 1167221323);
							continue;
						}
						case 2:
							goto IL_5C;
						}
						return;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				for (;;)
				{
					IL_5C:
					int num = 267946138;
					for (;;)
					{
						switch ((num ^ 1384616955) % 3)
						{
						case 0:
							goto IL_5C;
						case 2:
						{
							PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
							PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
							propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
							num = ((propertyChangedEventHandler == propertyChangedEventHandler2) ? 542451702 : 267946138);
							continue;
						}
						}
						return;
					}
				}
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0002AE18 File Offset: 0x00029018
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0002AE2C File Offset: 0x0002902C
		public AcpViewModel AcpModel
		{
			[CompilerGenerated]
			get
			{
				return this.<AcpModel>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<AcpModel>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 182758418;
				IL_13:
				switch ((num ^ 102390081) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					num = 958367955;
					goto IL_13;
				case 3:
					return;
				}
				this.<AcpModel>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.AcpModel);
			}
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0002AE88 File Offset: 0x00029088
		public SettingsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0002AEAC File Offset: 0x000290AC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/ASC;component/view/acp/settingsview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0002AEDC File Offset: 0x000290DC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.ACPView = (SettingsView)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0002AF04 File Offset: 0x00029104
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

		// Token: 0x0400095B RID: 2395
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0400095C RID: 2396
		[CompilerGenerated]
		private AcpViewModel <AcpModel>k__BackingField = new AcpViewModel();

		// Token: 0x0400095D RID: 2397
		internal SettingsView ACPView;

		// Token: 0x0400095E RID: 2398
		private bool _contentLoaded;
	}
}
