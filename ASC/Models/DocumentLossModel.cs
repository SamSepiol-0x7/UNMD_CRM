using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using Autofac;
using DevExpress.XtraReports.UI;

namespace ASC.Models
{
	// Token: 0x020009FB RID: 2555
	public class DocumentLossModel : INotifyPropertyChanged
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06004BE6 RID: 19430 RVA: 0x00136EC8 File Offset: 0x001350C8
		// (remove) Token: 0x06004BE7 RID: 19431 RVA: 0x00136F38 File Offset: 0x00135138
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				for (;;)
				{
					IL_5C:
					int num = 1023165364;
					for (;;)
					{
						switch ((num ^ 2127747725) % 3)
						{
						case 1:
						{
							PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
							PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
							propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
							num = ((propertyChangedEventHandler != propertyChangedEventHandler2) ? 1023165364 : 1194991801);
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
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x00136F70 File Offset: 0x00135170
		// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x00136F84 File Offset: 0x00135184
		public Action CloseAction
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseAction>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<CloseAction>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 2030948306;
				IL_13:
				switch ((num ^ 1300220864) % 4)
				{
				case 0:
					goto IL_0E;
				case 2:
					return;
				case 3:
					IL_32:
					this.<CloseAction>k__BackingField = value;
					num = 54392429;
					goto IL_13;
				}
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.CloseAction);
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x00136FE0 File Offset: 0x001351E0
		// (set) Token: 0x06004BEB RID: 19435 RVA: 0x00136FF4 File Offset: 0x001351F4
		public string DocumentName
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DocumentName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DocumentName>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DocumentName);
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06004BEC RID: 19436 RVA: 0x00137024 File Offset: 0x00135224
		// (set) Token: 0x06004BED RID: 19437 RVA: 0x00137038 File Offset: 0x00135238
		public string DocumentNumber
		{
			[CompilerGenerated]
			get
			{
				return this.<DocumentNumber>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<DocumentNumber>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -233618570;
				IL_14:
				switch ((num ^ -1443719107) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					this.<DocumentNumber>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DocumentNumber);
					num = -523510281;
					goto IL_14;
				case 3:
					return;
				}
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x00137094 File Offset: 0x00135294
		// (set) Token: 0x06004BEF RID: 19439 RVA: 0x001370A8 File Offset: 0x001352A8
		public string Fio
		{
			[CompilerGenerated]
			get
			{
				return this.<Fio>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Fio>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Fio>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Fio);
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x001370D8 File Offset: 0x001352D8
		// (set) Token: 0x06004BF1 RID: 19441 RVA: 0x001370EC File Offset: 0x001352EC
		public List<string> Documents
		{
			[CompilerGenerated]
			get
			{
				return this.<Documents>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Documents>k__BackingField, value))
				{
					return;
				}
				this.<Documents>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Documents);
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x0013711C File Offset: 0x0013531C
		// (set) Token: 0x06004BF3 RID: 19443 RVA: 0x00137130 File Offset: 0x00135330
		public ICommand PrintDocumentCommand
		{
			[CompilerGenerated]
			get
			{
				return this.<PrintDocumentCommand>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PrintDocumentCommand>k__BackingField, value))
				{
					return;
				}
				this.<PrintDocumentCommand>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.PrintDocumentCommand);
			}
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x00137160 File Offset: 0x00135360
		public DocumentLossModel(int repairId)
		{
			this._workshopService = Bootstrapper.Container.Resolve<IWorkshopService>();
			this._repairId = repairId;
			this.Documents = new List<string>
			{
				Lang.t("Passport"),
				Lang.t("DriversLicense"),
				Lang.t("MilitaryId"),
				Lang.t("PensionersId")
			};
			this.GetClient();
			this.PrintDocumentCommand = new RelayCommand(new Action<object>(this.PrintDocumentLossBlank));
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x001371F4 File Offset: 0x001353F4
		public void GetClient()
		{
			DocumentLossModel.<GetClient>d__30 <GetClient>d__;
			<GetClient>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GetClient>d__.<>4__this = this;
			<GetClient>d__.<>1__state = -1;
			<GetClient>d__.<>t__builder.Start<DocumentLossModel.<GetClient>d__30>(ref <GetClient>d__);
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x0013722C File Offset: 0x0013542C
		public void PrintDocumentLossBlank(object obj)
		{
			DocumentLossModel.<PrintDocumentLossBlank>d__31 <PrintDocumentLossBlank>d__;
			<PrintDocumentLossBlank>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintDocumentLossBlank>d__.<>4__this = this;
			<PrintDocumentLossBlank>d__.obj = obj;
			<PrintDocumentLossBlank>d__.<>1__state = -1;
			<PrintDocumentLossBlank>d__.<>t__builder.Start<DocumentLossModel.<PrintDocumentLossBlank>d__31>(ref <PrintDocumentLossBlank>d__);
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x0013726C File Offset: 0x0013546C
		private bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.Fio))
			{
				MessageBox.Show(Lang.t("InputFullName"));
				return false;
			}
			if (string.IsNullOrEmpty(this.DocumentName))
			{
				MessageBox.Show(Lang.t("InputDocumentName"));
				return false;
			}
			if (!string.IsNullOrEmpty(this.DocumentNumber))
			{
				return true;
			}
			MessageBox.Show(Lang.t("InputDocumentNumber"));
			return false;
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x001372D8 File Offset: 0x001354D8
		public void Close()
		{
			this.CloseAction();
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x001372F0 File Offset: 0x001354F0
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

		// Token: 0x040030FE RID: 12542
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x040030FF RID: 12543
		[CompilerGenerated]
		private Action <CloseAction>k__BackingField;

		// Token: 0x04003100 RID: 12544
		private int _repairId;

		// Token: 0x04003101 RID: 12545
		[CompilerGenerated]
		private string <DocumentName>k__BackingField;

		// Token: 0x04003102 RID: 12546
		[CompilerGenerated]
		private string <DocumentNumber>k__BackingField;

		// Token: 0x04003103 RID: 12547
		[CompilerGenerated]
		private string <Fio>k__BackingField;

		// Token: 0x04003104 RID: 12548
		[CompilerGenerated]
		private List<string> <Documents>k__BackingField;

		// Token: 0x04003105 RID: 12549
		[CompilerGenerated]
		private ICommand <PrintDocumentCommand>k__BackingField;

		// Token: 0x04003106 RID: 12550
		protected IWorkshopService _workshopService;

		// Token: 0x020009FC RID: 2556
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetClient>d__30 : IAsyncStateMachine
		{
			// Token: 0x06004BFA RID: 19450 RVA: 0x00137314 File Offset: 0x00135514
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DocumentLossModel documentLossModel = this.<>4__this;
				try
				{
					TaskAwaiter<ICustomer> awaiter;
					if (num != 0)
					{
						awaiter = documentLossModel._workshopService.GetOrderCustomer(documentLossModel._repairId).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICustomer>, DocumentLossModel.<GetClient>d__30>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<ICustomer>);
						this.<>1__state = -1;
					}
					ICustomer result = awaiter.GetResult();
					documentLossModel.Fio = result.FioOrUrName;
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

			// Token: 0x06004BFB RID: 19451 RVA: 0x001373E0 File Offset: 0x001355E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003107 RID: 12551
			public int <>1__state;

			// Token: 0x04003108 RID: 12552
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04003109 RID: 12553
			public DocumentLossModel <>4__this;

			// Token: 0x0400310A RID: 12554
			private TaskAwaiter<ICustomer> <>u__1;
		}

		// Token: 0x020009FD RID: 2557
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintDocumentLossBlank>d__31 : IAsyncStateMachine
		{
			// Token: 0x06004BFC RID: 19452 RVA: 0x001373FC File Offset: 0x001355FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DocumentLossModel documentLossModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					TaskAwaiter<IRepairCard> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							this.<>1__state = -1;
							goto IL_C8;
						}
						if (!documentLossModel.CheckFields())
						{
							goto IL_12D;
						}
						awaiter2 = RepairModel.GetRepairCard(documentLossModel._repairId).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IRepairCard>, DocumentLossModel.<PrintDocumentLossBlank>d__31>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IRepairCard>);
						this.<>1__state = -1;
					}
					awaiter = ((RepairCard)awaiter2.GetResult()).CreateLostReport(documentLossModel.DocumentName, documentLossModel.DocumentNumber).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, DocumentLossModel.<PrintDocumentLossBlank>d__31>(ref awaiter, ref this);
						return;
					}
					IL_C8:
					XtraReport result = awaiter.GetResult();
					result.ShowRibbonPreview();
					result.PrintDialog();
					Window window = this.obj as Window;
					if (window != null)
					{
						window.Focus();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_12D:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004BFD RID: 19453 RVA: 0x00137568 File Offset: 0x00135768
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400310B RID: 12555
			public int <>1__state;

			// Token: 0x0400310C RID: 12556
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400310D RID: 12557
			public DocumentLossModel <>4__this;

			// Token: 0x0400310E RID: 12558
			public object obj;

			// Token: 0x0400310F RID: 12559
			private TaskAwaiter<IRepairCard> <>u__1;

			// Token: 0x04003110 RID: 12560
			private TaskAwaiter<XtraReport> <>u__2;
		}
	}
}
