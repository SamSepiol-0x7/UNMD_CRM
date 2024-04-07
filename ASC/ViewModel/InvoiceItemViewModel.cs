using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.ViewModels;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModel
{
	// Token: 0x020002A5 RID: 677
	public class InvoiceItemViewModel : BaseViewModel
	{
		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0006669C File Offset: 0x0006489C
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x000666B0 File Offset: 0x000648B0
		public IInvoiceItem Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Item>k__BackingField, value))
				{
					return;
				}
				this.<Item>k__BackingField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000666E0 File Offset: 0x000648E0
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x000666F4 File Offset: 0x000648F4
		public List<KeyValuePair<int, string>> TaxModes
		{
			[CompilerGenerated]
			get
			{
				return this.<TaxModes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<TaxModes>k__BackingField, value))
				{
					return;
				}
				this.<TaxModes>k__BackingField = value;
				this.RaisePropertyChanged("TaxModes");
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x00066724 File Offset: 0x00064924
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x00066738 File Offset: 0x00064938
		public List<string> Units
		{
			[CompilerGenerated]
			get
			{
				return this.<Units>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Units>k__BackingField, value))
				{
					return;
				}
				this.<Units>k__BackingField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00066768 File Offset: 0x00064968
		public InvoiceItemViewModel()
		{
			IInvoiceModel invoiceModel = Bootstrapper.Container.Resolve<IInvoiceModel>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._invoiceService = Bootstrapper.Container.Resolve<IInvoiceService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this.Item = new InvoiceItem();
			this.TaxModes = new List<KeyValuePair<int, string>>(invoiceModel.GetTaxModes());
			this.Units = new List<string>(invoiceModel.GetUnits());
			IInvoiceItem item = this.Item;
			List<string> units = this.Units;
			item.Units = ((units != null) ? units.FirstOrDefault<string>() : null);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00066800 File Offset: 0x00064A00
		public InvoiceItemViewModel(IInvoiceItem item) : this()
		{
			this.Item = item;
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0006681C File Offset: 0x00064A1C
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IInvoiceItemAdd);
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0006683C File Offset: 0x00064A3C
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00066854 File Offset: 0x00064A54
		[AsyncCommand]
		public Task Save()
		{
			InvoiceItemViewModel.<Save>d__20 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<InvoiceItemViewModel.<Save>d__20>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00066898 File Offset: 0x00064A98
		private bool CheckFields()
		{
			if (string.IsNullOrEmpty(this.Item.Name))
			{
				this._toasterService.Info(Lang.t("InputItemName"));
				return false;
			}
			return true;
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000668D0 File Offset: 0x00064AD0
		[Command]
		public void Calculate()
		{
			IInvoiceItem item = this.Item;
			if (item == null)
			{
				return;
			}
			item.Calculate();
		}

		// Token: 0x0400120A RID: 4618
		private readonly IInvoiceService _invoiceService;

		// Token: 0x0400120B RID: 4619
		private readonly IToasterService _toasterService;

		// Token: 0x0400120C RID: 4620
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400120D RID: 4621
		private IInvoiceItemAdd _parentViewModel;

		// Token: 0x0400120E RID: 4622
		[CompilerGenerated]
		private IInvoiceItem <Item>k__BackingField;

		// Token: 0x0400120F RID: 4623
		[CompilerGenerated]
		private List<KeyValuePair<int, string>> <TaxModes>k__BackingField;

		// Token: 0x04001210 RID: 4624
		[CompilerGenerated]
		private List<string> <Units>k__BackingField;

		// Token: 0x020002A6 RID: 678
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__20 : IAsyncStateMachine
		{
			// Token: 0x060022F3 RID: 8947 RVA: 0x000668F0 File Offset: 0x00064AF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				InvoiceItemViewModel invoiceItemViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!invoiceItemViewModel.CheckFields())
						{
							goto IL_138;
						}
						if (invoiceItemViewModel.Item.Id <= 0)
						{
							invoiceItemViewModel._parentViewModel.InvoiceItemAdd(invoiceItemViewModel.Item);
							invoiceItemViewModel._windowedDocumentService.CloseActiveDocument();
							goto IL_11D;
						}
						invoiceItemViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							IInvoice document = invoiceItemViewModel._parentViewModel.Document;
							document.CalcTotal();
							awaiter = invoiceItemViewModel._invoiceService.UpdateInvoiceItem(invoiceItemViewModel.Item, document, document.Total).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, InvoiceItemViewModel.<Save>d__20>(ref awaiter, ref this);
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
						invoiceItemViewModel._toasterService.Success(Lang.t("Saved"));
						invoiceItemViewModel._windowedDocumentService.CloseActiveDocument();
					}
					catch (Exception ex)
					{
						invoiceItemViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							invoiceItemViewModel.HideWait();
						}
					}
					IL_11D:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_138:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060022F4 RID: 8948 RVA: 0x00066A94 File Offset: 0x00064C94
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001211 RID: 4625
			public int <>1__state;

			// Token: 0x04001212 RID: 4626
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001213 RID: 4627
			public InvoiceItemViewModel <>4__this;

			// Token: 0x04001214 RID: 4628
			private TaskAwaiter <>u__1;
		}
	}
}
