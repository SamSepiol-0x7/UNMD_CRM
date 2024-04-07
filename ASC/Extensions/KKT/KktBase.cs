using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Models;
using Autofac;
using NLog;

namespace ASC.Extensions.KKT
{
	// Token: 0x02000BA5 RID: 2981
	public class KktBase
	{
		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x00165A34 File Offset: 0x00163C34
		// (set) Token: 0x06005393 RID: 21395 RVA: 0x00165A48 File Offset: 0x00163C48
		public int OrderPaymentItemSign
		{
			[CompilerGenerated]
			get
			{
				return this.<OrderPaymentItemSign>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OrderPaymentItemSign>k__BackingField = value;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x00165A5C File Offset: 0x00163C5C
		// (set) Token: 0x06005395 RID: 21397 RVA: 0x00165A70 File Offset: 0x00163C70
		public int ProductPaymentItemSign
		{
			[CompilerGenerated]
			get
			{
				return this.<ProductPaymentItemSign>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ProductPaymentItemSign>k__BackingField = value;
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x00165A84 File Offset: 0x00163C84
		// (set) Token: 0x06005397 RID: 21399 RVA: 0x00165A98 File Offset: 0x00163C98
		public string STpl
		{
			[CompilerGenerated]
			get
			{
				return this.<STpl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<STpl>k__BackingField = value;
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x00165AAC File Offset: 0x00163CAC
		// (set) Token: 0x06005399 RID: 21401 RVA: 0x00165AC0 File Offset: 0x00163CC0
		public string RTpl
		{
			[CompilerGenerated]
			get
			{
				return this.<RTpl>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RTpl>k__BackingField = value;
			}
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00165AD4 File Offset: 0x00163CD4
		public string ConstructSaleItemName(store_sales item)
		{
			string stpl = this.STpl;
			if (stpl == null)
			{
				return "";
			}
			return stpl.Replace("{ITEM}", item.store_items.name);
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00165B08 File Offset: 0x00163D08
		protected Task<string> ConstructKkmReason(int repairId)
		{
			KktBase.<ConstructKkmReason>d__18 <ConstructKkmReason>d__;
			<ConstructKkmReason>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ConstructKkmReason>d__.<>4__this = this;
			<ConstructKkmReason>d__.repairId = repairId;
			<ConstructKkmReason>d__.<>1__state = -1;
			<ConstructKkmReason>d__.<>t__builder.Start<KktBase.<ConstructKkmReason>d__18>(ref <ConstructKkmReason>d__);
			return <ConstructKkmReason>d__.<>t__builder.Task;
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00165B54 File Offset: 0x00163D54
		public static void SetOrderFiscalDocumentNumber(int orderId, uint fdn, int paymentItemSign)
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				cash_orders cash_orders = auseceEntities.cash_orders.Find(new object[]
				{
					orderId
				});
				cash_orders.fdn = new long?((long)((ulong)fdn));
				cash_orders.payment_item_sign = new int?(paymentItemSign);
				auseceEntities.SaveChanges();
			}
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00165BC0 File Offset: 0x00163DC0
		public static Dictionary<int, string> GetPaymentItemSigns()
		{
			return new Dictionary<int, string>
			{
				{
					1,
					"Товар"
				},
				{
					2,
					"Подакцизный товар"
				},
				{
					3,
					"Работа"
				},
				{
					4,
					"Услуга"
				},
				{
					5,
					"Ставка азартной игры"
				},
				{
					6,
					"Выигрыш азартной игры"
				},
				{
					7,
					"Лотерейный билет"
				},
				{
					8,
					"Выигрыш лотереи"
				},
				{
					9,
					"Предоставление РИД"
				},
				{
					10,
					"Платеж"
				},
				{
					11,
					"Агеннтское вознаграждение"
				},
				{
					12,
					"Составной предмет расчета"
				},
				{
					13,
					"Иной предмет расчета"
				},
				{
					14,
					"Имущественное право"
				},
				{
					15,
					"Внереализационный доход"
				},
				{
					16,
					"Страховые взносы"
				},
				{
					17,
					"Торговый сбор"
				},
				{
					18,
					"Курортный сбор"
				},
				{
					19,
					"Залог"
				}
			};
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x000046B4 File Offset: 0x000028B4
		public KktBase()
		{
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00165CC4 File Offset: 0x00163EC4
		// Note: this type is marked as 'beforefieldinit'.
		static KktBase()
		{
		}

		// Token: 0x04003700 RID: 14080
		protected static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04003701 RID: 14081
		[CompilerGenerated]
		private int <OrderPaymentItemSign>k__BackingField;

		// Token: 0x04003702 RID: 14082
		[CompilerGenerated]
		private int <ProductPaymentItemSign>k__BackingField;

		// Token: 0x04003703 RID: 14083
		[CompilerGenerated]
		private string <STpl>k__BackingField;

		// Token: 0x04003704 RID: 14084
		[CompilerGenerated]
		private string <RTpl>k__BackingField;

		// Token: 0x02000BA6 RID: 2982
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ConstructKkmReason>d__18 : IAsyncStateMachine
		{
			// Token: 0x060053A0 RID: 21408 RVA: 0x00165CDC File Offset: 0x00163EDC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				KktBase kktBase = this.<>4__this;
				string result2;
				try
				{
					if (num == 0 || kktBase.RTpl != null)
					{
						try
						{
							TaskAwaiter<RepairDeviceInfo> awaiter;
							if (num != 0)
							{
								awaiter = Bootstrapper.Container.Resolve<IWorkshopService>().GetRepairDeviceInfo(this.repairId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.<>1__state = 0;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RepairDeviceInfo>, KktBase.<ConstructKkmReason>d__18>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<RepairDeviceInfo>);
								this.<>1__state = -1;
							}
							RepairDeviceInfo result = awaiter.GetResult();
							result2 = kktBase.RTpl.Replace("{DEVICE}", result.Type).Replace("{MAKER}", result.Brand).Replace("{MODEL}", result.Model);
							goto IL_105;
						}
						catch (Exception ex)
						{
							KktBase.Log.Error(ex, ex.Message);
							result2 = "";
							goto IL_105;
						}
					}
					result2 = "";
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_105:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060053A1 RID: 21409 RVA: 0x00165E20 File Offset: 0x00164020
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003705 RID: 14085
			public int <>1__state;

			// Token: 0x04003706 RID: 14086
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x04003707 RID: 14087
			public KktBase <>4__this;

			// Token: 0x04003708 RID: 14088
			public int repairId;

			// Token: 0x04003709 RID: 14089
			private TaskAwaiter<RepairDeviceInfo> <>u__1;
		}
	}
}
