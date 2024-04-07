using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.Extensions.EpochtaSms;
using ASC.Extensions.SmsRu;
using ASC.Interfaces;
using ASC.Models;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.DataProcessing;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200040E RID: 1038
	public class RepairSendSmsViewModel : CollectionViewModel<sms_templates>, IIsDataLoading
	{
		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000839EC File Offset: 0x00081BEC
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x00083A00 File Offset: 0x00081C00
		public string Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Tel>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Tel>k__BackingField = value;
				this.RaisePropertyChanged("Tel");
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x00083A30 File Offset: 0x00081C30
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x00083A44 File Offset: 0x00081C44
		public List<tel> Phones
		{
			[CompilerGenerated]
			get
			{
				return this.<Phones>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Phones>k__BackingField, value))
				{
					return;
				}
				this.<Phones>k__BackingField = value;
				this.RaisePropertyChanged("Phones");
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x00083A74 File Offset: 0x00081C74
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x00083A88 File Offset: 0x00081C88
		public string MessageText
		{
			[CompilerGenerated]
			get
			{
				return this.<MessageText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<MessageText>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MessageText>k__BackingField = value;
				this.RaisePropertyChanged("MessageText");
			}
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00083AB8 File Offset: 0x00081CB8
		public RepairSendSmsViewModel(ISmsService smsService, ICustomerService customerService, IToasterService toasterService, IWindowedDocumentService windowedDocumentService)
		{
			this.SmsService = smsService;
			this.CustomerService = customerService;
			this._toasterService = toasterService;
			this._windowedDocumentService = windowedDocumentService;
			this.LoadData();
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00083AF0 File Offset: 0x00081CF0
		protected void LoadData()
		{
			RepairSendSmsViewModel.<LoadData>d__19 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<RepairSendSmsViewModel.<LoadData>d__19>(ref <LoadData>d__);
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x00083B28 File Offset: 0x00081D28
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x00083B3C File Offset: 0x00081D3C
		public bool IsLoadingData
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoadingData>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsLoadingData>k__BackingField == value)
				{
					return;
				}
				this.<IsLoadingData>k__BackingField = value;
				this.RaisePropertyChanged("IsLoadingData");
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00083B68 File Offset: 0x00081D68
		public void SetIsDataLoading(bool value)
		{
			this.IsLoadingData = value;
			base.RaiseCanExecuteChanged(() => this.Send());
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00083BB8 File Offset: 0x00081DB8
		public override void OnSelectedItemChanged(sms_templates i)
		{
			RepairSendSmsViewModel.<OnSelectedItemChanged>d__25 <OnSelectedItemChanged>d__;
			<OnSelectedItemChanged>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnSelectedItemChanged>d__.<>4__this = this;
			<OnSelectedItemChanged>d__.<>1__state = -1;
			<OnSelectedItemChanged>d__.<>t__builder.Start<RepairSendSmsViewModel.<OnSelectedItemChanged>d__25>(ref <OnSelectedItemChanged>d__);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00083BF0 File Offset: 0x00081DF0
		[Command]
		public void Send()
		{
			RepairSendSmsViewModel.<Send>d__26 <Send>d__;
			<Send>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Send>d__.<>4__this = this;
			<Send>d__.<>1__state = -1;
			<Send>d__.<>t__builder.Start<RepairSendSmsViewModel.<Send>d__26>(ref <Send>d__);
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00083C28 File Offset: 0x00081E28
		public bool CanSend()
		{
			return this.Order != null && this.Order.clients != null && base.SelectedItem != null && !string.IsNullOrEmpty(this.MessageText) && !string.IsNullOrEmpty(this.Tel) && !this.IsLoadingData;
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00083C78 File Offset: 0x00081E78
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00083C90 File Offset: 0x00081E90
		public void SetOrder(workshop order)
		{
			RepairSendSmsViewModel.<SetOrder>d__29 <SetOrder>d__;
			<SetOrder>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetOrder>d__.<>4__this = this;
			<SetOrder>d__.order = order;
			<SetOrder>d__.<>1__state = -1;
			<SetOrder>d__.<>t__builder.Start<RepairSendSmsViewModel.<SetOrder>d__29>(ref <SetOrder>d__);
		}

		// Token: 0x04001731 RID: 5937
		protected ISmsService SmsService;

		// Token: 0x04001732 RID: 5938
		protected ICustomerService CustomerService;

		// Token: 0x04001733 RID: 5939
		private readonly IToasterService _toasterService;

		// Token: 0x04001734 RID: 5940
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001735 RID: 5941
		protected workshop Order;

		// Token: 0x04001736 RID: 5942
		protected clients Customer;

		// Token: 0x04001737 RID: 5943
		[CompilerGenerated]
		private string <Tel>k__BackingField;

		// Token: 0x04001738 RID: 5944
		[CompilerGenerated]
		private List<tel> <Phones>k__BackingField;

		// Token: 0x04001739 RID: 5945
		[CompilerGenerated]
		private string <MessageText>k__BackingField;

		// Token: 0x0400173A RID: 5946
		[CompilerGenerated]
		private bool <IsLoadingData>k__BackingField;

		// Token: 0x0200040F RID: 1039
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadData>d__19 : IAsyncStateMachine
		{
			// Token: 0x060029E9 RID: 10729 RVA: 0x00083CD0 File Offset: 0x00081ED0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairSendSmsViewModel repairSendSmsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<sms_templates>> awaiter;
					if (num != 0)
					{
						repairSendSmsViewModel.SetIsDataLoading(true);
						awaiter = repairSendSmsViewModel.SmsService.GetTemplates().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<sms_templates>>, RepairSendSmsViewModel.<LoadData>d__19>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<sms_templates>>);
						this.<>1__state = -1;
					}
					List<sms_templates> result = awaiter.GetResult();
					repairSendSmsViewModel.Items.Clear();
					repairSendSmsViewModel.Items.AddRange(result);
					repairSendSmsViewModel.SetIsDataLoading(false);
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

			// Token: 0x060029EA RID: 10730 RVA: 0x00083DB0 File Offset: 0x00081FB0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400173B RID: 5947
			public int <>1__state;

			// Token: 0x0400173C RID: 5948
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400173D RID: 5949
			public RepairSendSmsViewModel <>4__this;

			// Token: 0x0400173E RID: 5950
			private TaskAwaiter<List<sms_templates>> <>u__1;
		}

		// Token: 0x02000410 RID: 1040
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <OnSelectedItemChanged>d__25 : IAsyncStateMachine
		{
			// Token: 0x060029EB RID: 10731 RVA: 0x00083DCC File Offset: 0x00081FCC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairSendSmsViewModel repairSendSmsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = repairSendSmsViewModel.SmsService.ConstructSms(repairSendSmsViewModel.SelectedItem.message, repairSendSmsViewModel.Order.id, repairSendSmsViewModel.Customer.IoOrUrName).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, RepairSendSmsViewModel.<OnSelectedItemChanged>d__25>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<string>);
						this.<>1__state = -1;
					}
					string result = awaiter.GetResult();
					repairSendSmsViewModel.MessageText = result;
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

			// Token: 0x060029EC RID: 10732 RVA: 0x00083EB0 File Offset: 0x000820B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400173F RID: 5951
			public int <>1__state;

			// Token: 0x04001740 RID: 5952
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001741 RID: 5953
			public RepairSendSmsViewModel <>4__this;

			// Token: 0x04001742 RID: 5954
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x02000411 RID: 1041
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Send>d__26 : IAsyncStateMachine
		{
			// Token: 0x060029ED RID: 10733 RVA: 0x00083ECC File Offset: 0x000820CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairSendSmsViewModel repairSendSmsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						SmsClientConfig smsClientConfig;
						ISmsClient smsClient;
						for (;;)
						{
							IL_DD:
							smsClientConfig = SmsModel.GetSmsClientConfig();
							if (smsClientConfig == null)
							{
								goto IL_176;
							}
							for (;;)
							{
								IL_D9:
								smsClient = null;
								for (;;)
								{
									IL_CF:
									int provider = smsClientConfig.Provider;
									for (;;)
									{
										IL_B5:
										switch (provider)
										{
										case 1:
											goto IL_EB;
										case 2:
											goto IL_F4;
										case 3:
											goto IL_FD;
										default:
										{
											uint num3;
											uint num2 = num3 * 311101458U ^ 3847223631U;
											for (;;)
											{
												switch ((num3 = (num2 ^ 3410053677U)) % 26U)
												{
												case 0U:
													num2 = (num3 * 344135840U ^ 990965386U);
													continue;
												case 1U:
													goto IL_1E0;
												case 2U:
													goto IL_FD;
												case 3U:
													goto IL_1D3;
												case 4U:
												case 7U:
												case 10U:
													goto IL_10D;
												case 5U:
													goto IL_F4;
												case 6U:
													goto IL_EB;
												case 8U:
													goto IL_171;
												case 9U:
												case 24U:
													goto IL_DD;
												case 12U:
													goto IL_113;
												case 13U:
													goto IL_152;
												case 14U:
													goto IL_176;
												case 15U:
													goto IL_18B;
												case 16U:
													goto IL_B5;
												case 18U:
													goto IL_1A8;
												case 19U:
													goto IL_1BE;
												case 20U:
													goto IL_D9;
												case 21U:
													goto IL_193;
												case 22U:
													goto IL_CF;
												case 25U:
													goto IL_120;
												}
												goto Block_4;
											}
											break;
										}
										}
									}
								}
							}
						}
						Block_4:
						goto IL_1F0;
						IL_EB:
						smsClient = new SmsRuClient(smsClientConfig);
						goto IL_10D;
						IL_F4:
						smsClient = new EpochtaSmsClient(smsClientConfig);
						goto IL_10D;
						IL_FD:
						smsClient = Bootstrapper.Container.ResolveKeyed("SMSC");
						IL_10D:
						if (smsClient == null)
						{
							goto IL_1F0;
						}
						IL_113:
						repairSendSmsViewModel.SetIsDataLoading(true);
						repairSendSmsViewModel.ShowWait();
						IL_120:
						awaiter = smsClient.SendAsync(repairSendSmsViewModel.Tel, repairSendSmsViewModel.MessageText, new int?(repairSendSmsViewModel.Order.client)).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_1A8;
						}
						IL_152:
						this.<>1__state = 0;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, RepairSendSmsViewModel.<Send>d__26>(ref awaiter, ref this);
						IL_171:
						return;
						IL_176:
						repairSendSmsViewModel._toasterService.Error("SMS client not configured");
						goto IL_20B;
					}
					IL_18B:
					awaiter = this.<>u__1;
					IL_193:
					this.<>u__1 = default(TaskAwaiter<bool>);
					this.<>1__state = -1;
					IL_1A8:
					bool result = awaiter.GetResult();
					repairSendSmsViewModel.HideWait();
					repairSendSmsViewModel.SetIsDataLoading(false);
					if (!result)
					{
						goto IL_1E0;
					}
					IL_1BE:
					repairSendSmsViewModel._toasterService.Success(Lang.t("MessegeSent"));
					IL_1D3:
					repairSendSmsViewModel._windowedDocumentService.CloseActiveDocument();
					goto IL_1F0;
					IL_1E0:
					repairSendSmsViewModel._toasterService.Error("");
					IL_1F0:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_20B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060029EE RID: 10734 RVA: 0x00084114 File Offset: 0x00082314
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001743 RID: 5955
			public int <>1__state;

			// Token: 0x04001744 RID: 5956
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001745 RID: 5957
			public RepairSendSmsViewModel <>4__this;

			// Token: 0x04001746 RID: 5958
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000412 RID: 1042
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060029EF RID: 10735 RVA: 0x00084130 File Offset: 0x00082330
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060029F0 RID: 10736 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060029F1 RID: 10737 RVA: 0x00084148 File Offset: 0x00082348
			internal bool <SetOrder>b__29_0(tel i)
			{
				return i.type == 1;
			}

			// Token: 0x060029F2 RID: 10738 RVA: 0x00084160 File Offset: 0x00082360
			internal string <SetOrder>b__29_1(tel i)
			{
				return i.phone_clean;
			}

			// Token: 0x04001747 RID: 5959
			public static readonly RepairSendSmsViewModel.<>c <>9 = new RepairSendSmsViewModel.<>c();

			// Token: 0x04001748 RID: 5960
			public static Func<tel, bool> <>9__29_0;

			// Token: 0x04001749 RID: 5961
			public static Func<tel, string> <>9__29_1;
		}

		// Token: 0x02000413 RID: 1043
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetOrder>d__29 : IAsyncStateMachine
		{
			// Token: 0x060029F3 RID: 10739 RVA: 0x00084174 File Offset: 0x00082374
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairSendSmsViewModel repairSendSmsViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<List<tel>> awaiter;
					if (num != 0)
					{
						repairSendSmsViewModel.Order = this.order;
						repairSendSmsViewModel.Customer = this.order.clients;
						awaiter = repairSendSmsViewModel.CustomerService.GetPhonesAsync(repairSendSmsViewModel.Order.client).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<tel>>, RepairSendSmsViewModel.<SetOrder>d__29>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<tel>>);
						this.<>1__state = -1;
					}
					List<tel> result = awaiter.GetResult();
					repairSendSmsViewModel.Phones = result;
					repairSendSmsViewModel.Tel = repairSendSmsViewModel.Phones.Where(new Func<tel, bool>(RepairSendSmsViewModel.<>c.<>9.<SetOrder>b__29_0)).Select(new Func<tel, string>(RepairSendSmsViewModel.<>c.<>9.<SetOrder>b__29_1)).DefaultIfEmpty<string>().FirstOrDefault<string>();
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

			// Token: 0x060029F4 RID: 10740 RVA: 0x000842C0 File Offset: 0x000824C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400174A RID: 5962
			public int <>1__state;

			// Token: 0x0400174B RID: 5963
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x0400174C RID: 5964
			public RepairSendSmsViewModel <>4__this;

			// Token: 0x0400174D RID: 5965
			public workshop order;

			// Token: 0x0400174E RID: 5966
			private TaskAwaiter<List<tel>> <>u__1;
		}
	}
}
