using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.WindowsUI;

namespace ASC.Services.Concrete
{
	// Token: 0x020007C1 RID: 1985
	public class WindowedDocumentService : ISupportParentViewModel, ISupportServices, IWindowedDocumentService
	{
		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x000F00B0 File Offset: 0x000EE2B0
		public IDocumentManagerService _service
		{
			get
			{
				return this.GetService("DocumentManagerService");
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x000F00C8 File Offset: 0x000EE2C8
		// (set) Token: 0x06003C36 RID: 15414 RVA: 0x000F00DC File Offset: 0x000EE2DC
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

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x000F00F0 File Offset: 0x000EE2F0
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

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x000F0118 File Offset: 0x000EE318
		IServiceContainer ISupportServices.ServiceContainer
		{
			get
			{
				return this.ServiceContainer;
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x000F012C File Offset: 0x000EE32C
		public WindowedDocumentService(IUserActivityService userActivityService)
		{
			this._userActivityService = userActivityService;
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x000F0148 File Offset: 0x000EE348
		public void TransparentBackground()
		{
			this._transparentBg = true;
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x000F015C File Offset: 0x000EE35C
		public void ShowNewDocument(string view, object viewModel, object parentVm = null, object parameter = null)
		{
			if (OfflineData.Instance.Employee.TrackActivity)
			{
				IBaseViewModel baseViewModel = viewModel as IBaseViewModel;
				this._userActivityService.AddActivity("DocumentManager " + ((baseViewModel != null) ? baseViewModel.ViewName : null));
			}
			IDocument document = this._service.CreateDocument(view, viewModel, parameter, parentVm);
			if (document != null)
			{
				if (this._transparentBg)
				{
					PropertyInfo property = document.GetType().GetProperty("Window");
					if (property != null)
					{
						WinUIDialogWindow winUIDialogWindow = property.GetValue(document) as WinUIDialogWindow;
						if (winUIDialogWindow != null)
						{
							winUIDialogWindow.Background = Brushes.Transparent;
						}
					}
				}
				document.Show();
				this._transparentBg = false;
			}
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x000F0200 File Offset: 0x000EE400
		public void CloseActiveDocument()
		{
			try
			{
				IDocumentManagerService service = this._service;
				if (service != null)
				{
					IDocument activeDocument = service.ActiveDocument;
					if (activeDocument != null)
					{
						activeDocument.Close(true);
					}
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x000F0244 File Offset: 0x000EE444
		public void CloseActiveDocument(string callFrom)
		{
			IDocument document = this._service.Documents.FirstOrDefault<IDocument>();
			if (document != null)
			{
				CustomerCallViewModel customerCallViewModel = document.Content as CustomerCallViewModel;
				if (customerCallViewModel != null && customerCallViewModel.CallFrom == callFrom)
				{
					this.CloseActiveDocument();
				}
			}
		}

		// Token: 0x04002790 RID: 10128
		[CompilerGenerated]
		private object <ParentViewModel>k__BackingField;

		// Token: 0x04002791 RID: 10129
		private IServiceContainer serviceContainer;

		// Token: 0x04002792 RID: 10130
		private readonly IUserActivityService _userActivityService;

		// Token: 0x04002793 RID: 10131
		private bool _transparentBg;
	}
}
