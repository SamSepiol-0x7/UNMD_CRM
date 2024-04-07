using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x020003ED RID: 1005
	public class EmailViewModel : BaseViewModel
	{
		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x0007ED7C File Offset: 0x0007CF7C
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0007ED90 File Offset: 0x0007CF90
		public IEmail Email
		{
			[CompilerGenerated]
			get
			{
				return this.<Email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Email>k__BackingField, value))
				{
					return;
				}
				this.<Email>k__BackingField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0007EDC0 File Offset: 0x0007CFC0
		public EmailViewModel()
		{
			this.IoC();
			this.Email = new Email();
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0007EDE4 File Offset: 0x0007CFE4
		public EmailViewModel(string to)
		{
			this.IoC();
			this.Email = new Email(to);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0007EE0C File Offset: 0x0007D00C
		public EmailViewModel(store_items item)
		{
			this.IoC();
			this.Email = new Email(item);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0007EE34 File Offset: 0x0007D034
		public EmailViewModel(IInvoice invoice, string templateName)
		{
			this.IoC();
			this.Email = new InvoiceEmail(invoice, templateName);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0007EE5C File Offset: 0x0007D05C
		public EmailViewModel(IEnumerable<KeyValuePair<IInvoice, string>> documents, string to)
		{
			this.IoC();
			this.Email = new InvoiceEmail(documents, to);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0007EE84 File Offset: 0x0007D084
		public EmailViewModel(string to, string subject)
		{
			this.IoC();
			this.Email = new Email(to, subject);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0007EEAC File Offset: 0x0007D0AC
		private void IoC()
		{
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0007EEDC File Offset: 0x0007D0DC
		[Command]
		public void SendEmail()
		{
			EmailViewModel.<SendEmail>d__13 <SendEmail>d__;
			<SendEmail>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendEmail>d__.<>4__this = this;
			<SendEmail>d__.<>1__state = -1;
			<SendEmail>d__.<>t__builder.Start<EmailViewModel.<SendEmail>d__13>(ref <SendEmail>d__);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0007EF14 File Offset: 0x0007D114
		public bool CanSendEmail()
		{
			return this.Email != null;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0007EF2C File Offset: 0x0007D12C
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x0400167A RID: 5754
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x0400167B RID: 5755
		private IToasterService _toasterService;

		// Token: 0x0400167C RID: 5756
		[CompilerGenerated]
		private IEmail <Email>k__BackingField;

		// Token: 0x020003EE RID: 1006
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendEmail>d__13 : IAsyncStateMachine
		{
			// Token: 0x060028DE RID: 10462 RVA: 0x0007EF44 File Offset: 0x0007D144
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EmailViewModel emailViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						if (!OfflineData.Instance.Employee.Can(81, 0))
						{
							emailViewModel._toasterService.Info("Нет прав на отправку Email, обратитесь к администратору");
							goto IL_E6;
						}
						emailViewModel.ShowWait();
					}
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = emailViewModel.Email.SendEmail().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, EmailViewModel.<SendEmail>d__13>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
						emailViewModel.Close();
					}
					catch (Exception ex)
					{
						emailViewModel._toasterService.Error(ex.Message);
					}
					finally
					{
						if (num < 0)
						{
							emailViewModel.HideWait();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_E6:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060028DF RID: 10463 RVA: 0x0007F074 File Offset: 0x0007D274
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400167D RID: 5757
			public int <>1__state;

			// Token: 0x0400167E RID: 5758
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400167F RID: 5759
			public EmailViewModel <>4__this;

			// Token: 0x04001680 RID: 5760
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
