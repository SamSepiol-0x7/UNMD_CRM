using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Extensions;
using ASC.Models;
using ASC.Services;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000599 RID: 1433
	public class ReportsViewModel : BaseViewModel
	{
		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x000B3F68 File Offset: 0x000B2168
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x000B3F7C File Offset: 0x000B217C
		public ObservableCollection<DocumentTemplateInfo> Templates
		{
			[CompilerGenerated]
			get
			{
				return this.<Templates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Templates>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1905806482;
				IL_13:
				switch ((num ^ 846745605) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					IL_32:
					this.<Templates>k__BackingField = value;
					this.RaisePropertyChanged("Templates");
					num = 604627468;
					goto IL_13;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x000B3FD8 File Offset: 0x000B21D8
		// (set) Token: 0x060034EC RID: 13548 RVA: 0x000B3FEC File Offset: 0x000B21EC
		public ReportStorage ReportStorage
		{
			[CompilerGenerated]
			get
			{
				return this.<ReportStorage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ReportStorage>k__BackingField, value))
				{
					return;
				}
				this.<ReportStorage>k__BackingField = value;
				this.RaisePropertyChanged("ReportStorage");
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x060034ED RID: 13549 RVA: 0x000B401C File Offset: 0x000B221C
		// (set) Token: 0x060034EE RID: 13550 RVA: 0x000B4030 File Offset: 0x000B2230
		public DocumentTemplateInfo SelectedTemplate
		{
			get
			{
				return this._selectedTemplate;
			}
			set
			{
				if (object.Equals(this._selectedTemplate, value))
				{
					return;
				}
				this._selectedTemplate = value;
				this.RaisePropertyChanged("SelectedTemplate");
				this.RefreshCommands();
				this.MakeCopyVisible = this.CanMakeTemplateCopy();
				this.LoadDxReport(value);
			}
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x000B4078 File Offset: 0x000B2278
		private void LoadDxReport(DocumentTemplateInfo value)
		{
			if (value != null)
			{
				base.ShowWait();
				Task.Run<XtraReport>(() => ReportPrintModel.CreateReport(value.Name)).ContinueWith(delegate(Task<XtraReport> t)
				{
					ReportStorage reportStorage = this.ReportStorage;
					if (reportStorage != null)
					{
						reportStorage.SetReportId(value.Id);
					}
					this.Report = t.Result;
					this.EditorVisible = true;
					this.HideWait();
				}, TaskScheduler.FromCurrentSynchronizationContext());
				return;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x000B40D0 File Offset: 0x000B22D0
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x000B40E4 File Offset: 0x000B22E4
		public bool MakeCopyVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<MakeCopyVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MakeCopyVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -257191942;
				IL_10:
				switch ((num ^ -1192475039) % 4)
				{
				case 0:
					goto IL_0B;
				case 2:
					IL_2F:
					this.<MakeCopyVisible>k__BackingField = value;
					num = -1867320660;
					goto IL_10;
				case 3:
					return;
				}
				this.RaisePropertyChanged("MakeCopyVisible");
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x000B413C File Offset: 0x000B233C
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x000B4150 File Offset: 0x000B2350
		public string CopyName
		{
			[CompilerGenerated]
			get
			{
				return this.<CopyName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<CopyName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<CopyName>k__BackingField = value;
				this.RaisePropertyChanged("CopyName");
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x000B4180 File Offset: 0x000B2380
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x000B4194 File Offset: 0x000B2394
		public bool EditorVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<EditorVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EditorVisible>k__BackingField == value)
				{
					return;
				}
				this.<EditorVisible>k__BackingField = value;
				this.RaisePropertyChanged("EditorVisible");
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x000B41C0 File Offset: 0x000B23C0
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x000B41D4 File Offset: 0x000B23D4
		public XtraReport Report
		{
			[CompilerGenerated]
			get
			{
				return this.<Report>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Report>k__BackingField, value))
				{
					return;
				}
				this.<Report>k__BackingField = value;
				this.RaisePropertyChanged("Report");
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x000B4204 File Offset: 0x000B2404
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x000B4218 File Offset: 0x000B2418
		public RelayCommand ImportTemplateCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ImportTemplateCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ImportTemplateCommand>k__BackingField, value))
				{
					return;
				}
				this.<ImportTemplateCommand>k__BackingField = value;
				this.RaisePropertyChanged("ImportTemplateCommand");
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x000B4248 File Offset: 0x000B2448
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x000B425C File Offset: 0x000B245C
		public RelayCommand ExportTemplateCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<ExportTemplateCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ExportTemplateCommand>k__BackingField, value))
				{
					return;
				}
				this.<ExportTemplateCommand>k__BackingField = value;
				this.RaisePropertyChanged("ExportTemplateCommand");
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x000B428C File Offset: 0x000B248C
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x000B42A0 File Offset: 0x000B24A0
		public RelayCommand MakeCopyCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<MakeCopyCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<MakeCopyCommand>k__BackingField, value))
				{
					return;
				}
				this.<MakeCopyCommand>k__BackingField = value;
				this.RaisePropertyChanged("MakeCopyCommand");
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x000B42D0 File Offset: 0x000B24D0
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x000B42E4 File Offset: 0x000B24E4
		public RelayCommand UpdateTemplateDescriptionCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdateTemplateDescriptionCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<UpdateTemplateDescriptionCommand>k__BackingField, value))
				{
					return;
				}
				this.<UpdateTemplateDescriptionCommand>k__BackingField = value;
				this.RaisePropertyChanged("UpdateTemplateDescriptionCommand");
			}
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000B4314 File Offset: 0x000B2514
		private void InitCommands()
		{
			this.ImportTemplateCommand = new RelayCommand(new Action<object>(this.ImportTemplate), new Func<bool>(this.CanImportExport));
			this.ExportTemplateCommand = new RelayCommand(new Action<object>(this.ExportTemplate), new Func<bool>(this.CanImportExport));
			this.MakeCopyCommand = new RelayCommand(new Action<object>(this.MakeCopy), new Func<bool>(this.CanMakeTemplateCopy));
			this.UpdateTemplateDescriptionCommand = new RelayCommand(new Action<object>(this.UpdateTemplateDescription));
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000B43A4 File Offset: 0x000B25A4
		private bool CanMakeTemplateCopy()
		{
			DocumentTemplateInfo selectedTemplate = this.SelectedTemplate;
			return ((selectedTemplate != null) ? selectedTemplate.Name : null) != null && (this.SelectedTemplate.Name.Contains("price") || this.SelectedTemplate.Name == "new_rep");
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000B43F8 File Offset: 0x000B25F8
		private bool CanImportExport()
		{
			return this.SelectedTemplate != null;
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000B4410 File Offset: 0x000B2610
		private void RefreshCommands()
		{
			RelayCommand importTemplateCommand = this.ImportTemplateCommand;
			if (importTemplateCommand == null)
			{
				goto IL_28;
			}
			importTemplateCommand.RaiseCanExecuteChanged();
			goto IL_5D;
			IL_13:
			RelayCommand makeCopyCommand = this.MakeCopyCommand;
			int num;
			if (makeCopyCommand != null)
			{
				makeCopyCommand.RaiseCanExecuteChanged();
				num = -297547046;
				goto IL_3E;
			}
			return;
			IL_28:
			RelayCommand exportTemplateCommand = this.ExportTemplateCommand;
			if (exportTemplateCommand == null)
			{
				goto IL_13;
			}
			exportTemplateCommand.RaiseCanExecuteChanged();
			num = -1839238272;
			IL_3E:
			switch ((num ^ -707457729) % 4)
			{
			case 0:
				IL_5D:
				num = -1089140123;
				goto IL_3E;
			case 2:
				goto IL_28;
			case 3:
				goto IL_13;
			}
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000B4484 File Offset: 0x000B2684
		public ReportsViewModel()
		{
			this._reportTemplateService = Bootstrapper.Container.Resolve<IReportTemplateService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._LoadTemplates();
			this.InitCommands();
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x000B44DC File Offset: 0x000B26DC
		private void _LoadTemplates()
		{
			ReportsViewModel.<_LoadTemplates>d__53 <_LoadTemplates>d__;
			<_LoadTemplates>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<_LoadTemplates>d__.<>4__this = this;
			<_LoadTemplates>d__.<>1__state = -1;
			<_LoadTemplates>d__.<>t__builder.Start<ReportsViewModel.<_LoadTemplates>d__53>(ref <_LoadTemplates>d__);
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x000B4514 File Offset: 0x000B2714
		private void ExportTemplate(object obj)
		{
			this._reportPrintModel.ExportTemplate2File(this.SelectedTemplate.Id);
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x000B4538 File Offset: 0x000B2738
		private void ImportTemplate(object obj)
		{
			if (this._reportPrintModel.ImportTemplateFromFile(this.SelectedTemplate.Id))
			{
				this.LoadDxReport(this.SelectedTemplate);
				this._toasterService.Success("");
				return;
			}
			this._toasterService.Error("");
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x000B458C File Offset: 0x000B278C
		private void MakeCopy(object obj)
		{
			if (!this.CheckCopyTemplateFields())
			{
				return;
			}
			string text = this.SelectedTemplate.Name.RemoveIntegers();
			int? maxNumber = this._reportPrintModel.GetMaxNumber(this.Templates, text);
			doc_templates templateItemByName = this._reportPrintModel.GetTemplateItemByName(string.Format("{0}{1}", text, maxNumber));
			if (templateItemByName == null)
			{
				return;
			}
			if (maxNumber == null)
			{
				maxNumber = new int?(1);
			}
			doc_templates template = new doc_templates
			{
				name = string.Format("{0}{1}", text, maxNumber + 1),
				description = this.CopyName,
				data = templateItemByName.data,
				checksum = templateItemByName.checksum
			};
			if (this._reportPrintModel.AddTemplateToDb(template))
			{
				this._LoadTemplates();
				this.SelectedTemplate = null;
				this.CopyName = "";
			}
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x000B4684 File Offset: 0x000B2884
		private bool CheckCopyTemplateFields()
		{
			if (string.IsNullOrEmpty(this.CopyName))
			{
				this._toasterService.Info(Lang.t("NameTooShort"));
				return false;
			}
			return true;
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x000B46B8 File Offset: 0x000B28B8
		private void UpdateTemplateDescription(object obj)
		{
			ReportsViewModel.<UpdateTemplateDescription>d__58 <UpdateTemplateDescription>d__;
			<UpdateTemplateDescription>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateTemplateDescription>d__.<>4__this = this;
			<UpdateTemplateDescription>d__.<>1__state = -1;
			<UpdateTemplateDescription>d__.<>t__builder.Start<ReportsViewModel.<UpdateTemplateDescription>d__58>(ref <UpdateTemplateDescription>d__);
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void SaveReport()
		{
		}

		// Token: 0x04001E84 RID: 7812
		protected IReportTemplateService _reportTemplateService;

		// Token: 0x04001E85 RID: 7813
		private readonly IToasterService _toasterService;

		// Token: 0x04001E86 RID: 7814
		private ReportPrintModel _reportPrintModel = new ReportPrintModel();

		// Token: 0x04001E87 RID: 7815
		private DocumentTemplateInfo _selectedTemplate;

		// Token: 0x04001E88 RID: 7816
		[CompilerGenerated]
		private ObservableCollection<DocumentTemplateInfo> <Templates>k__BackingField;

		// Token: 0x04001E89 RID: 7817
		[CompilerGenerated]
		private ReportStorage <ReportStorage>k__BackingField = new ReportStorage();

		// Token: 0x04001E8A RID: 7818
		[CompilerGenerated]
		private bool <MakeCopyVisible>k__BackingField;

		// Token: 0x04001E8B RID: 7819
		[CompilerGenerated]
		private string <CopyName>k__BackingField;

		// Token: 0x04001E8C RID: 7820
		[CompilerGenerated]
		private bool <EditorVisible>k__BackingField;

		// Token: 0x04001E8D RID: 7821
		[CompilerGenerated]
		private XtraReport <Report>k__BackingField;

		// Token: 0x04001E8E RID: 7822
		[CompilerGenerated]
		private RelayCommand <ImportTemplateCommand>k__BackingField;

		// Token: 0x04001E8F RID: 7823
		[CompilerGenerated]
		private RelayCommand <ExportTemplateCommand>k__BackingField;

		// Token: 0x04001E90 RID: 7824
		[CompilerGenerated]
		private RelayCommand <MakeCopyCommand>k__BackingField;

		// Token: 0x04001E91 RID: 7825
		[CompilerGenerated]
		private RelayCommand <UpdateTemplateDescriptionCommand>k__BackingField;

		// Token: 0x0200059A RID: 1434
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x0600350C RID: 13580 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x0600350D RID: 13581 RVA: 0x000B46F0 File Offset: 0x000B28F0
			internal Task<XtraReport> <LoadDxReport>b__0()
			{
				return ReportPrintModel.CreateReport(this.value.Name);
			}

			// Token: 0x0600350E RID: 13582 RVA: 0x000B4710 File Offset: 0x000B2910
			internal void <LoadDxReport>b__1(Task<XtraReport> t)
			{
				ReportStorage reportStorage = this.<>4__this.ReportStorage;
				if (reportStorage != null)
				{
					reportStorage.SetReportId(this.value.Id);
				}
				this.<>4__this.Report = t.Result;
				this.<>4__this.EditorVisible = true;
				this.<>4__this.HideWait();
			}

			// Token: 0x04001E92 RID: 7826
			public DocumentTemplateInfo value;

			// Token: 0x04001E93 RID: 7827
			public ReportsViewModel <>4__this;
		}

		// Token: 0x0200059B RID: 1435
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <_LoadTemplates>d__53 : IAsyncStateMachine
		{
			// Token: 0x0600350F RID: 13583 RVA: 0x000B4768 File Offset: 0x000B2968
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ReportsViewModel reportsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<DocumentTemplateInfo>> awaiter;
					if (num != 0)
					{
						reportsViewModel.ShowWait();
						awaiter = reportsViewModel._reportTemplateService.GetAllAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<DocumentTemplateInfo>>, ReportsViewModel.<_LoadTemplates>d__53>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<DocumentTemplateInfo>>);
						this.<>1__state = -1;
					}
					List<DocumentTemplateInfo> result = awaiter.GetResult();
					reportsViewModel.Templates = new ObservableCollection<DocumentTemplateInfo>(result);
					reportsViewModel.HideWait();
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

			// Token: 0x06003510 RID: 13584 RVA: 0x000B483C File Offset: 0x000B2A3C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E94 RID: 7828
			public int <>1__state;

			// Token: 0x04001E95 RID: 7829
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E96 RID: 7830
			public ReportsViewModel <>4__this;

			// Token: 0x04001E97 RID: 7831
			private TaskAwaiter<List<DocumentTemplateInfo>> <>u__1;
		}

		// Token: 0x0200059C RID: 1436
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateTemplateDescription>d__58 : IAsyncStateMachine
		{
			// Token: 0x06003511 RID: 13585 RVA: 0x000B4858 File Offset: 0x000B2A58
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ReportsViewModel reportsViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (reportsViewModel.SelectedTemplate == null)
						{
							goto IL_F7;
						}
						reportsViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = reportsViewModel._reportTemplateService.UpdateTemplateDescription(reportsViewModel.SelectedTemplate.Id, reportsViewModel.SelectedTemplate.Description).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ReportsViewModel.<UpdateTemplateDescription>d__58>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						reportsViewModel._toasterService.Success(Lang.t("Saved"));
						reportsViewModel._LoadTemplates();
					}
					catch (Exception ex)
					{
						reportsViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							reportsViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_F7:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003512 RID: 13586 RVA: 0x000B4998 File Offset: 0x000B2B98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E98 RID: 7832
			public int <>1__state;

			// Token: 0x04001E99 RID: 7833
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001E9A RID: 7834
			public ReportsViewModel <>4__this;

			// Token: 0x04001E9B RID: 7835
			private TaskAwaiter <>u__1;
		}
	}
}
