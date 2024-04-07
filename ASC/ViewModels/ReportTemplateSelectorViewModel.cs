using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Models;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;

namespace ASC.ViewModels
{
	// Token: 0x02000414 RID: 1044
	public class ReportTemplateSelectorViewModel : CollectionViewModel<DocumentTemplateInfo>
	{
		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000842DC File Offset: 0x000824DC
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x000842F0 File Offset: 0x000824F0
		public bool TemplateSelectorVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<TemplateSelectorVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<TemplateSelectorVisible>k__BackingField == value)
				{
					return;
				}
				this.<TemplateSelectorVisible>k__BackingField = value;
				this.RaisePropertyChanged("TemplateSelectorVisible");
			}
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x0008431C File Offset: 0x0008251C
		public ReportTemplateSelectorViewModel()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00084340 File Offset: 0x00082540
		public ReportTemplateSelectorViewModel(string template) : this()
		{
			this._template = template;
			this.LoadItems();
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00084360 File Offset: 0x00082560
		private void LoadItems()
		{
			ReportTemplateSelectorViewModel.<LoadItems>d__8 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<ReportTemplateSelectorViewModel.<LoadItems>d__8>(ref <LoadItems>d__);
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00084398 File Offset: 0x00082598
		public string GetSelected()
		{
			return base.SelectedItem.Name;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x000843B0 File Offset: 0x000825B0
		[CompilerGenerated]
		private bool <LoadItems>b__8_0(DocumentTemplateInfo i)
		{
			return i.Name.Contains(this._template);
		}

		// Token: 0x0400174F RID: 5967
		private readonly IToasterService _toasterService;

		// Token: 0x04001750 RID: 5968
		[CompilerGenerated]
		private bool <TemplateSelectorVisible>k__BackingField;

		// Token: 0x04001751 RID: 5969
		private string _template;

		// Token: 0x02000415 RID: 1045
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060029FC RID: 10748 RVA: 0x000843D0 File Offset: 0x000825D0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060029FD RID: 10749 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060029FE RID: 10750 RVA: 0x000843E8 File Offset: 0x000825E8
			internal int <LoadItems>b__8_1(DocumentTemplateInfo i)
			{
				return i.Id;
			}

			// Token: 0x04001752 RID: 5970
			public static readonly ReportTemplateSelectorViewModel.<>c <>9 = new ReportTemplateSelectorViewModel.<>c();

			// Token: 0x04001753 RID: 5971
			public static Func<DocumentTemplateInfo, int> <>9__8_1;
		}

		// Token: 0x02000416 RID: 1046
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__8 : IAsyncStateMachine
		{
			// Token: 0x060029FF RID: 10751 RVA: 0x000843FC File Offset: 0x000825FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ReportTemplateSelectorViewModel reportTemplateSelectorViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter<List<DocumentTemplateInfo>> awaiter;
						if (num != 0)
						{
							awaiter = Task.Run<List<DocumentTemplateInfo>>(new Func<Task<List<DocumentTemplateInfo>>>(ReportPrintModel.LoadTemplates)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<DocumentTemplateInfo>>, ReportTemplateSelectorViewModel.<LoadItems>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<DocumentTemplateInfo>>);
							this.<>1__state = -1;
						}
						List<DocumentTemplateInfo> list = (from i in awaiter.GetResult()
						where i.Name.Contains(reportTemplateSelectorViewModel._template)
						select i).OrderBy(new Func<DocumentTemplateInfo, int>(ReportTemplateSelectorViewModel.<>c.<>9.<LoadItems>b__8_1)).ToList<DocumentTemplateInfo>();
						reportTemplateSelectorViewModel.SetItems(list);
						reportTemplateSelectorViewModel.SelectedItem = reportTemplateSelectorViewModel.Items.FirstOrDefault<DocumentTemplateInfo>();
						reportTemplateSelectorViewModel.TemplateSelectorVisible = (list.Count > 1);
					}
					catch (Exception ex)
					{
						reportTemplateSelectorViewModel._toasterService.Error(ex.Message);
					}
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

			// Token: 0x06002A00 RID: 10752 RVA: 0x00084548 File Offset: 0x00082748
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001754 RID: 5972
			public int <>1__state;

			// Token: 0x04001755 RID: 5973
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001756 RID: 5974
			public ReportTemplateSelectorViewModel <>4__this;

			// Token: 0x04001757 RID: 5975
			private TaskAwaiter<List<DocumentTemplateInfo>> <>u__1;
		}
	}
}
