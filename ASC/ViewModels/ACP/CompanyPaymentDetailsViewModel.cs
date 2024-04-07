using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Common.Interfaces;
using ASC.Common.Repositories;
using ASC.Interfaces;
using ASC.Services.Abstract;
using ASC.ViewModel;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200055C RID: 1372
	public class CompanyPaymentDetailsViewModel : CollectionViewModel<IPaymentDetailLookup>, IOfficesViewModel, IRefreshable
	{
		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x000AB8C8 File Offset: 0x000A9AC8
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x000AB90C File Offset: 0x000A9B0C
		public bool ShowArchive
		{
			get
			{
				return base.GetProperty<bool>(() => this.ShowArchive);
			}
			set
			{
				if (this.ShowArchive == value)
				{
					return;
				}
				base.SetProperty<bool>(() => this.ShowArchive, value, new Action(this.LoadItems));
				this.RaisePropertyChanged("ShowArchive");
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x000AB974 File Offset: 0x000A9B74
		public string GroupHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupHeader>k__BackingField;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x000AB988 File Offset: 0x000A9B88
		public string ListHeader
		{
			[CompilerGenerated]
			get
			{
				return this.<ListHeader>k__BackingField;
			}
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x000AB99C File Offset: 0x000A9B9C
		public CompanyPaymentDetailsViewModel(IPaymentDetailRepository paymentDetailRepository, IWindowedDocumentService windowedDocumentService)
		{
			this._paymentDetailRepository = paymentDetailRepository;
			this._windowedDocumentService = windowedDocumentService;
			this.GroupHeader = Lang.t("BankDetails");
			this.ListHeader = Lang.t("BanksList");
			this.LoadItems();
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000AB9E4 File Offset: 0x000A9BE4
		[Command]
		public void ShowCreate()
		{
			this._windowedDocumentService.ShowNewDocument("PaymentDetailsView", new PaymentDetailsViewModel(), null, null);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000ABA08 File Offset: 0x000A9C08
		[Command]
		public void ShowEdit()
		{
			this._windowedDocumentService.ShowNewDocument("PaymentDetailsView", new PaymentDetailsViewModel(base.SelectedItem), null, null);
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000ABA34 File Offset: 0x000A9C34
		public bool CanShowEdit()
		{
			return base.SelectedItem != null;
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000ABA4C File Offset: 0x000A9C4C
		[Command]
		public void Refresh()
		{
			this.LoadItems();
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000ABA60 File Offset: 0x000A9C60
		public void LoadItems()
		{
			CompanyPaymentDetailsViewModel.<LoadItems>d__16 <LoadItems>d__;
			<LoadItems>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadItems>d__.<>4__this = this;
			<LoadItems>d__.<>1__state = -1;
			<LoadItems>d__.<>t__builder.Start<CompanyPaymentDetailsViewModel.<LoadItems>d__16>(ref <LoadItems>d__);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000ABA98 File Offset: 0x000A9C98
		public void DataRefresh()
		{
			this.Refresh();
		}

		// Token: 0x04001D51 RID: 7505
		private readonly IPaymentDetailRepository _paymentDetailRepository;

		// Token: 0x04001D52 RID: 7506
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001D53 RID: 7507
		[CompilerGenerated]
		private readonly string <GroupHeader>k__BackingField;

		// Token: 0x04001D54 RID: 7508
		[CompilerGenerated]
		private readonly string <ListHeader>k__BackingField;

		// Token: 0x0200055D RID: 1373
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadItems>d__16 : IAsyncStateMachine
		{
			// Token: 0x060032FE RID: 13054 RVA: 0x000ABAAC File Offset: 0x000A9CAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CompanyPaymentDetailsViewModel companyPaymentDetailsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<IPaymentDetailLookup>> awaiter;
					if (num != 0)
					{
						companyPaymentDetailsViewModel.Items.Clear();
						awaiter = companyPaymentDetailsViewModel._paymentDetailRepository.GetSellerBanksLookup().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IPaymentDetailLookup>>, CompanyPaymentDetailsViewModel.<LoadItems>d__16>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IPaymentDetailLookup>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					IEnumerator<IPaymentDetailLookup> enumerator = awaiter.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							IPaymentDetailLookup paymentDetailLookup = enumerator.Current;
							if (companyPaymentDetailsViewModel.ShowArchive || !paymentDetailLookup.IsArchive)
							{
								companyPaymentDetailsViewModel.Items.Add(paymentDetailLookup);
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
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

			// Token: 0x060032FF RID: 13055 RVA: 0x000ABBC8 File Offset: 0x000A9DC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D55 RID: 7509
			public int <>1__state;

			// Token: 0x04001D56 RID: 7510
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D57 RID: 7511
			public CompanyPaymentDetailsViewModel <>4__this;

			// Token: 0x04001D58 RID: 7512
			private TaskAwaiter<IEnumerable<IPaymentDetailLookup>> <>u__1;
		}
	}
}
