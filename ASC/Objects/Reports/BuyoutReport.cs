using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Services.Abstract;
using Autofac;

namespace ASC.Objects.Reports
{
	// Token: 0x02000935 RID: 2357
	public class BuyoutReport : GoodsInvoiceReport
	{
		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x0011C7D4 File Offset: 0x0011A9D4
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x0011C7E8 File Offset: 0x0011A9E8
		public buyout Document
		{
			[CompilerGenerated]
			get
			{
				return this.<Document>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Document>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1916986923;
				IL_13:
				switch ((num ^ -447424632) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<Document>k__BackingField = value;
					this.RaisePropertyChanged("Document");
					num = -1614012173;
					goto IL_13;
				}
			}
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x0011C844 File Offset: 0x0011AA44
		public BuyoutReport()
		{
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x0011C858 File Offset: 0x0011AA58
		public BuyoutReport(StoreDocument d) : base(d)
		{
			this.LoadDocument();
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x0011C874 File Offset: 0x0011AA74
		private void LoadDocument()
		{
			BuyoutReport.<LoadDocument>d__6 <LoadDocument>d__;
			<LoadDocument>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadDocument>d__.<>4__this = this;
			<LoadDocument>d__.<>1__state = -1;
			<LoadDocument>d__.<>t__builder.Start<BuyoutReport.<LoadDocument>d__6>(ref <LoadDocument>d__);
		}

		// Token: 0x04002E29 RID: 11817
		[CompilerGenerated]
		private buyout <Document>k__BackingField;

		// Token: 0x02000936 RID: 2358
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadDocument>d__6 : IAsyncStateMachine
		{
			// Token: 0x06004860 RID: 18528 RVA: 0x0011C8AC File Offset: 0x0011AAAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				BuyoutReport buyoutReport = this.<>4__this;
				try
				{
					TaskAwaiter<buyout> awaiter;
					if (num != 0)
					{
						awaiter = Bootstrapper.Container.Resolve<IBuyoutService>().GetByDocumentIdAsync(buyoutReport.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<buyout>, BuyoutReport.<LoadDocument>d__6>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<buyout>);
						this.<>1__state = -1;
					}
					buyout result = awaiter.GetResult();
					buyoutReport.Document = result;
					if (string.IsNullOrEmpty(buyoutReport.Document.authority))
					{
						buyoutReport.Document.authority = "___________";
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

			// Token: 0x06004861 RID: 18529 RVA: 0x0011C99C File Offset: 0x0011AB9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E2A RID: 11818
			public int <>1__state;

			// Token: 0x04002E2B RID: 11819
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002E2C RID: 11820
			public BuyoutReport <>4__this;

			// Token: 0x04002E2D RID: 11821
			private TaskAwaiter<buyout> <>u__1;
		}
	}
}
