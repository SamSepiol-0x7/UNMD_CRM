using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ASC.Services.Abstract;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ASC.Services.Concrete
{
	// Token: 0x020007B9 RID: 1977
	public class ToasterService : ISupportParentViewModel, ISupportServices, IToasterService
	{
		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x000EF2AC File Offset: 0x000ED4AC
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x000EF2C0 File Offset: 0x000ED4C0
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

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x000EF2D4 File Offset: 0x000ED4D4
		protected DevExpress.Mvvm.INotificationService _notification
		{
			get
			{
				return this.GetService("notificationService");
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x000EF2EC File Offset: 0x000ED4EC
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

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x000EF314 File Offset: 0x000ED514
		IServiceContainer ISupportServices.ServiceContainer
		{
			get
			{
				return this.ServiceContainer;
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x000EF328 File Offset: 0x000ED528
		public ToasterService()
		{
			this.brushConverter = new BrushConverter();
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x000EF348 File Offset: 0x000ED548
		public void Info(string message)
		{
			ToastNotificationViewModel toastNotificationViewModel = ViewModelSource.Create<ToastNotificationViewModel>(Expression.Lambda<Func<ToastNotificationViewModel>>(Expression.New(typeof(ToastNotificationViewModel)), new ParameterExpression[0]));
			toastNotificationViewModel.Caption = Lang.t("Info");
			toastNotificationViewModel.Content = message;
			toastNotificationViewModel.BorderBrush = (Brush)this.brushConverter.ConvertFromString("#FFC7E5EA");
			toastNotificationViewModel.Background = (Brush)this.brushConverter.ConvertFromString("#FFE5F4F7");
			toastNotificationViewModel.CaptionBackground = (Brush)this.brushConverter.ConvertFromString("#FFD4EDF2");
			toastNotificationViewModel.Foreground = (Brush)this.brushConverter.ConvertFromString("#FF0c5460");
			this._notification.CreateCustomNotification(toastNotificationViewModel).ShowAsync();
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x000EF40C File Offset: 0x000ED60C
		public void Error(string message)
		{
			ToastNotificationViewModel toastNotificationViewModel = ViewModelSource.Create<ToastNotificationViewModel>(Expression.Lambda<Func<ToastNotificationViewModel>>(Expression.New(typeof(ToastNotificationViewModel)), new ParameterExpression[0]));
			toastNotificationViewModel.Caption = Lang.t("Error");
			toastNotificationViewModel.Content = message;
			toastNotificationViewModel.BorderBrush = (Brush)this.brushConverter.ConvertFromString("#FFF1CFD5");
			toastNotificationViewModel.Background = (Brush)this.brushConverter.ConvertFromString("#FFFCEEEE");
			toastNotificationViewModel.CaptionBackground = (Brush)this.brushConverter.ConvertFromString("#FFF9DBDD");
			toastNotificationViewModel.Foreground = (Brush)this.brushConverter.ConvertFromString("#FF59252C");
			this._notification.CreateCustomNotification(toastNotificationViewModel).ShowAsync();
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x000EF4D0 File Offset: 0x000ED6D0
		public void Success(string message)
		{
			ToastNotificationViewModel toastNotificationViewModel = ViewModelSource.Create<ToastNotificationViewModel>(Expression.Lambda<Func<ToastNotificationViewModel>>(Expression.New(typeof(ToastNotificationViewModel)), new ParameterExpression[0]));
			toastNotificationViewModel.Caption = Lang.t("Success");
			toastNotificationViewModel.Content = message;
			toastNotificationViewModel.BorderBrush = (Brush)this.brushConverter.ConvertFromString("#FFCBE4D1");
			toastNotificationViewModel.Background = (Brush)this.brushConverter.ConvertFromString("#FFE5F5EA");
			toastNotificationViewModel.CaptionBackground = (Brush)this.brushConverter.ConvertFromString("#FFD6EFDC");
			toastNotificationViewModel.Foreground = (Brush)this.brushConverter.ConvertFromString("#FF245933");
			this._notification.CreateCustomNotification(toastNotificationViewModel).ShowAsync();
		}

		// Token: 0x04002774 RID: 10100
		[CompilerGenerated]
		private object <ParentViewModel>k__BackingField;

		// Token: 0x04002775 RID: 10101
		private BrushConverter brushConverter;

		// Token: 0x04002776 RID: 10102
		private IServiceContainer serviceContainer;

		// Token: 0x020007BA RID: 1978
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003C10 RID: 15376 RVA: 0x000EF594 File Offset: 0x000ED794
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003C11 RID: 15377 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002777 RID: 10103
			public static readonly ToasterService.<>c <>9 = new ToasterService.<>c();
		}
	}
}
