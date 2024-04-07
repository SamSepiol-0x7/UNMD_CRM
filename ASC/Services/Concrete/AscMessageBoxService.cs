using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.Services.Abstract;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ASC.Services.Concrete
{
	// Token: 0x02000734 RID: 1844
	public class AscMessageBoxService : ISupportParentViewModel, ISupportServices, IAscMessageBoxService
	{
		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x000E0020 File Offset: 0x000DE220
		// (set) Token: 0x06003A6B RID: 14955 RVA: 0x000E0034 File Offset: 0x000DE234
		public object ParentViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<ParentViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ParentViewModel>k__BackingField = value;
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x000E0048 File Offset: 0x000DE248
		private IMessageBoxService _messageBoxService
		{
			get
			{
				return this.GetService("MessageService");
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x000E0060 File Offset: 0x000DE260
		protected IServiceContainer ServiceContainer
		{
			get
			{
				if (this.serviceContainer == null)
				{
					this.serviceContainer = new ServiceContainer(this);
				}
				return this.serviceContainer;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x000E0088 File Offset: 0x000DE288
		IServiceContainer ISupportServices.ServiceContainer
		{
			get
			{
				return this.ServiceContainer;
			}
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x000046B4 File Offset: 0x000028B4
		public AscMessageBoxService()
		{
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x000E009C File Offset: 0x000DE29C
		public void ShowMessageBox(string messageBoxText)
		{
			this._messageBoxService.Show(messageBoxText);
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x000E00B8 File Offset: 0x000DE2B8
		public void ShowMessageBox(string caption, string messageBoxText)
		{
			this._messageBoxService.Show(messageBoxText, caption);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x000E00D4 File Offset: 0x000DE2D4
		public MessageBoxResult ShowMessageBox(string messageBoxText, string caption, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
		{
			return this._messageBoxService.Show(messageBoxText, caption, messageBoxButton, messageBoxImage);
		}

		// Token: 0x04002574 RID: 9588
		[CompilerGenerated]
		private object <ParentViewModel>k__BackingField;

		// Token: 0x04002575 RID: 9589
		private IServiceContainer serviceContainer;
	}
}
