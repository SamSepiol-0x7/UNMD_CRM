using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.Services.Abstract;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ASC.Services.Concrete
{
	// Token: 0x020007C0 RID: 1984
	public class WaitIndicatorService : ISupportParentViewModel, ISupportServices, IWaitIndicatorService
	{
		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x000EFF90 File Offset: 0x000EE190
		// (set) Token: 0x06003C2C RID: 15404 RVA: 0x000EFFA4 File Offset: 0x000EE1A4
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

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x000EFFB8 File Offset: 0x000EE1B8
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

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x000EFFE0 File Offset: 0x000EE1E0
		IServiceContainer ISupportServices.ServiceContainer
		{
			get
			{
				return this.ServiceContainer;
			}
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x000EFFF4 File Offset: 0x000EE1F4
		public WaitIndicatorService()
		{
			this._splashScreenService = this.GetService("WaitIndicatorService");
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x000F0018 File Offset: 0x000EE218
		public void ShowWait()
		{
			if (Application.Current.Dispatcher != null)
			{
				Application.Current.Dispatcher.Invoke(delegate()
				{
					this._splashScreenService.ShowSplashScreen();
				});
			}
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x000F004C File Offset: 0x000EE24C
		public void HideWait()
		{
			if (Application.Current.Dispatcher != null)
			{
				Application.Current.Dispatcher.Invoke(delegate()
				{
					this._splashScreenService.HideSplashScreen();
				});
			}
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x000F0080 File Offset: 0x000EE280
		[CompilerGenerated]
		private void <ShowWait>b__11_0()
		{
			this._splashScreenService.ShowSplashScreen();
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x000F0098 File Offset: 0x000EE298
		[CompilerGenerated]
		private void <HideWait>b__12_0()
		{
			this._splashScreenService.HideSplashScreen();
		}

		// Token: 0x0400278D RID: 10125
		[CompilerGenerated]
		private object <ParentViewModel>k__BackingField;

		// Token: 0x0400278E RID: 10126
		private ISplashScreenService _splashScreenService;

		// Token: 0x0400278F RID: 10127
		private IServiceContainer serviceContainer;
	}
}
