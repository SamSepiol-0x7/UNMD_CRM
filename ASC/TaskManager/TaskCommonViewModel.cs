using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.ViewModels;

namespace ASC.TaskManager
{
	// Token: 0x020002D4 RID: 724
	public class TaskCommonViewModel : BaseViewModel
	{
		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0006B230 File Offset: 0x00069430
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x0006B244 File Offset: 0x00069444
		public List<KeyValuePair<int, string>> TaskTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<TaskTypes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TaskTypes>k__BackingField, value))
				{
					return;
				}
				this.<TaskTypes>k__BackingField = value;
				this.RaisePropertyChanged("TaskTypes");
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0006B274 File Offset: 0x00069474
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x0006B288 File Offset: 0x00069488
		public List<KeyValuePair<int, string>> TaskStatuses
		{
			[CompilerGenerated]
			get
			{
				return this.<TaskStatuses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TaskStatuses>k__BackingField, value))
				{
					return;
				}
				this.<TaskStatuses>k__BackingField = value;
				this.RaisePropertyChanged("TaskStatuses");
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0006B2B8 File Offset: 0x000694B8
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x0006B2CC File Offset: 0x000694CC
		public List<KeyValuePair<int, string>> Priorities
		{
			[CompilerGenerated]
			get
			{
				return this.<Priorities>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Priorities>k__BackingField, value))
				{
					return;
				}
				this.<Priorities>k__BackingField = value;
				this.RaisePropertyChanged("Priorities");
			}
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0006B2FC File Offset: 0x000694FC
		public TaskCommonViewModel()
		{
		}

		// Token: 0x040012CA RID: 4810
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <TaskTypes>k__BackingField;

		// Token: 0x040012CB RID: 4811
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <TaskStatuses>k__BackingField;

		// Token: 0x040012CC RID: 4812
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <Priorities>k__BackingField;
	}
}
