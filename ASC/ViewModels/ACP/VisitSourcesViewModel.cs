using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ASC.ViewModels.ACP
{
	// Token: 0x020005AE RID: 1454
	public class VisitSourcesViewModel : BaseViewModel
	{
		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x000B7C3C File Offset: 0x000B5E3C
		// (set) Token: 0x060035DD RID: 13789 RVA: 0x000B7C50 File Offset: 0x000B5E50
		public ObservableCollection<visit_sources> VisitSourceses
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitSourceses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<VisitSourceses>k__BackingField, value))
				{
					return;
				}
				this.<VisitSourceses>k__BackingField = value;
				this.RaisePropertyChanged("VisitSourceses");
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x000B7C80 File Offset: 0x000B5E80
		// (set) Token: 0x060035DF RID: 13791 RVA: 0x000B7C94 File Offset: 0x000B5E94
		public visit_sources SelectedItem
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedItem>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedItem>k__BackingField, value))
				{
					return;
				}
				this.<SelectedItem>k__BackingField = value;
				this.RaisePropertyChanged("EnableSourceEdit");
				this.RaisePropertyChanged("SelectedItem");
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x000B7CD0 File Offset: 0x000B5ED0
		// (set) Token: 0x060035E1 RID: 13793 RVA: 0x000B7CE4 File Offset: 0x000B5EE4
		public bool ForceVisitSource
		{
			[CompilerGenerated]
			get
			{
				return this.<ForceVisitSource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ForceVisitSource>k__BackingField == value)
				{
					return;
				}
				this.<ForceVisitSource>k__BackingField = value;
				this.RaisePropertyChanged("ForceVisitSource");
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060035E2 RID: 13794 RVA: 0x000B7D10 File Offset: 0x000B5F10
		// (set) Token: 0x060035E3 RID: 13795 RVA: 0x000B7D24 File Offset: 0x000B5F24
		public string NewFieldName
		{
			[CompilerGenerated]
			get
			{
				return this.<NewFieldName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewFieldName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewFieldName>k__BackingField = value;
				this.RaisePropertyChanged("NewFieldName");
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x000B7D54 File Offset: 0x000B5F54
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x000B7D68 File Offset: 0x000B5F68
		public string NewSourceName
		{
			[CompilerGenerated]
			get
			{
				return this.<NewSourceName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewSourceName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewSourceName>k__BackingField = value;
				this.RaisePropertyChanged("NewSourceName");
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x000B7D98 File Offset: 0x000B5F98
		public bool EnableSourceEdit
		{
			get
			{
				return this.SelectedItem != null;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x000B7DB0 File Offset: 0x000B5FB0
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x000B7DC4 File Offset: 0x000B5FC4
		public ObservableCollection<VisitTriggers> VisitSourceTriggers
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitSourceTriggers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<VisitSourceTriggers>k__BackingField, value))
				{
					return;
				}
				this.<VisitSourceTriggers>k__BackingField = value;
				this.RaisePropertyChanged("VisitSourceTriggers");
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x000B7DF4 File Offset: 0x000B5FF4
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x000B7E08 File Offset: 0x000B6008
		public bool ShowDisabled
		{
			get
			{
				return this._showDisabled;
			}
			set
			{
				if (this._showDisabled == value)
				{
					return;
				}
				this._showDisabled = value;
				this.RaisePropertyChanged("ShowDisabled");
				this.LoadVisitSources();
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x000B7E3C File Offset: 0x000B603C
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x000B7E50 File Offset: 0x000B6050
		public AdditionalFieldsListViewModel AdditionalFieldsListViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<AdditionalFieldsListViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AdditionalFieldsListViewModel>k__BackingField, value))
				{
					return;
				}
				this.<AdditionalFieldsListViewModel>k__BackingField = value;
				this.RaisePropertyChanged("AdditionalFieldsListViewModel");
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x000B7E80 File Offset: 0x000B6080
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x000B7E94 File Offset: 0x000B6094
		public ProductAttributesListViewModel ProductAttributesListViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductAttributesListViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ProductAttributesListViewModel>k__BackingField, value))
				{
					return;
				}
				this.<ProductAttributesListViewModel>k__BackingField = value;
				this.RaisePropertyChanged("ProductAttributesListViewModel");
			}
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x000B7EC4 File Offset: 0x000B60C4
		public VisitSourcesViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.LoadVisitSources();
			this.AdditionalFieldsListViewModel = Bootstrapper.Container.Resolve<AdditionalFieldsListViewModel>();
			this.ProductAttributesListViewModel = Bootstrapper.Container.Resolve<ProductAttributesListViewModel>();
			this.AdditionalFieldsListViewModel.SetParentViewModel(this);
			this.ProductAttributesListViewModel.SetParentViewModel(this);
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x000B7F60 File Offset: 0x000B6160
		private void LoadVisitSources()
		{
			VisitSourcesViewModel.<LoadVisitSources>d__43 <LoadVisitSources>d__;
			<LoadVisitSources>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadVisitSources>d__.<>4__this = this;
			<LoadVisitSources>d__.<>1__state = -1;
			<LoadVisitSources>d__.<>t__builder.Start<VisitSourcesViewModel.<LoadVisitSources>d__43>(ref <LoadVisitSources>d__);
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x000B7F98 File Offset: 0x000B6198
		[Command]
		public void CloseDocument()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x000B7FB0 File Offset: 0x000B61B0
		[Command]
		public void RefreshVS()
		{
			this.LoadVisitSources();
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x000B7FC4 File Offset: 0x000B61C4
		[Command]
		public void ShowCreateVS()
		{
			int? num;
			if (this.VisitSourceses.Any<visit_sources>())
			{
				num = (from s in this.VisitSourceses
				select s.position).DefaultIfEmpty<int?>().Max();
			}
			else
			{
				num = new int?(0);
			}
			int? num2 = num;
			this.SelectedItem = new visit_sources
			{
				name = this.NewSourceName,
				enabled = new bool?(true),
				position = num2 + 1
			};
			this._windowedDocumentService.ShowNewDocument("VisitSourceEditView", this, null, null);
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x000B807C File Offset: 0x000B627C
		[Command]
		public void ShowVSEdit()
		{
			if (this.SelectedItem == null)
			{
				return;
			}
			this._windowedDocumentService.ShowNewDocument("VisitSourceEditView", this, null, null);
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x000B80A8 File Offset: 0x000B62A8
		public bool CheckVisitSource()
		{
			if (string.IsNullOrEmpty(this.SelectedItem.name))
			{
				this._toasterService.Info(Lang.t("InputVisitSourceName"));
				return false;
			}
			return true;
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x000B80E0 File Offset: 0x000B62E0
		[Command]
		public void SaveVS()
		{
			if (this.SelectedItem == null || !this.CheckVisitSource())
			{
				return;
			}
			if ((this.SelectedItem.id == 0) ? ChartModel.AddNewVisitSource(this.SelectedItem) : ChartModel.SaveVisitSources(this.SelectedItem))
			{
				this._windowedDocumentService.CloseActiveDocument();
				this.LoadVisitSources();
				OfflineData.Instance.ReloadVisitSources();
				this._toasterService.Success(Lang.t("Saved"));
				return;
			}
			this._toasterService.Error("");
		}

		// Token: 0x04001F02 RID: 7938
		private IToasterService _toasterService;

		// Token: 0x04001F03 RID: 7939
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001F04 RID: 7940
		private ChartModel _chartModel = new ChartModel();

		// Token: 0x04001F05 RID: 7941
		[CompilerGenerated]
		private ObservableCollection<visit_sources> <VisitSourceses>k__BackingField;

		// Token: 0x04001F06 RID: 7942
		[CompilerGenerated]
		private visit_sources <SelectedItem>k__BackingField;

		// Token: 0x04001F07 RID: 7943
		public List<int> Items2Delete = new List<int>();

		// Token: 0x04001F08 RID: 7944
		private bool _showDisabled;

		// Token: 0x04001F09 RID: 7945
		[CompilerGenerated]
		private bool <ForceVisitSource>k__BackingField = Auth.Config.visit_source_force;

		// Token: 0x04001F0A RID: 7946
		[CompilerGenerated]
		private string <NewFieldName>k__BackingField;

		// Token: 0x04001F0B RID: 7947
		[CompilerGenerated]
		private string <NewSourceName>k__BackingField;

		// Token: 0x04001F0C RID: 7948
		[CompilerGenerated]
		private ObservableCollection<VisitTriggers> <VisitSourceTriggers>k__BackingField;

		// Token: 0x04001F0D RID: 7949
		[CompilerGenerated]
		private AdditionalFieldsListViewModel <AdditionalFieldsListViewModel>k__BackingField;

		// Token: 0x04001F0E RID: 7950
		[CompilerGenerated]
		private ProductAttributesListViewModel <ProductAttributesListViewModel>k__BackingField;

		// Token: 0x020005AF RID: 1455
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060035F7 RID: 13815 RVA: 0x000B8168 File Offset: 0x000B6368
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060035F8 RID: 13816 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060035F9 RID: 13817 RVA: 0x000B8180 File Offset: 0x000B6380
			internal bool <LoadVisitSources>b__43_0(visit_sources s)
			{
				return s.fire_on != null;
			}

			// Token: 0x060035FA RID: 13818 RVA: 0x000B819C File Offset: 0x000B639C
			internal int <LoadVisitSources>b__43_1(visit_sources s)
			{
				return s.fire_on.Value;
			}

			// Token: 0x060035FB RID: 13819 RVA: 0x000B81B8 File Offset: 0x000B63B8
			internal int? <ShowCreateVS>b__46_0(visit_sources s)
			{
				return s.position;
			}

			// Token: 0x04001F0F RID: 7951
			public static readonly VisitSourcesViewModel.<>c <>9 = new VisitSourcesViewModel.<>c();

			// Token: 0x04001F10 RID: 7952
			public static Func<visit_sources, bool> <>9__43_0;

			// Token: 0x04001F11 RID: 7953
			public static Func<visit_sources, int> <>9__43_1;

			// Token: 0x04001F12 RID: 7954
			public static Func<visit_sources, int?> <>9__46_0;
		}

		// Token: 0x020005B0 RID: 1456
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadVisitSources>d__43 : IAsyncStateMachine
		{
			// Token: 0x060035FC RID: 13820 RVA: 0x000B81CC File Offset: 0x000B63CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VisitSourcesViewModel visitSourcesViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<visit_sources>> awaiter;
					if (num != 0)
					{
						awaiter = ChartModel.LoadVisitSourcesesAsync(visitSourcesViewModel.ShowDisabled).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<visit_sources>>, VisitSourcesViewModel.<LoadVisitSources>d__43>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<visit_sources>>);
						this.<>1__state = -1;
					}
					List<visit_sources> result = awaiter.GetResult();
					visitSourcesViewModel.VisitSourceses = new ObservableCollection<visit_sources>(result);
					List<int> existTriggers = visitSourcesViewModel.VisitSourceses.Where(new Func<visit_sources, bool>(VisitSourcesViewModel.<>c.<>9.<LoadVisitSources>b__43_0)).Select(new Func<visit_sources, int>(VisitSourcesViewModel.<>c.<>9.<LoadVisitSources>b__43_1)).ToList<int>();
					visitSourcesViewModel.VisitSourceTriggers = new ObservableCollection<VisitTriggers>(visitSourcesViewModel._chartModel.GetTriggers(existTriggers));
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

			// Token: 0x060035FD RID: 13821 RVA: 0x000B8304 File Offset: 0x000B6504
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F13 RID: 7955
			public int <>1__state;

			// Token: 0x04001F14 RID: 7956
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001F15 RID: 7957
			public VisitSourcesViewModel <>4__this;

			// Token: 0x04001F16 RID: 7958
			private TaskAwaiter<List<visit_sources>> <>u__1;
		}
	}
}
