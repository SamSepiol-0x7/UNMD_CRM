using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;

namespace ASC.Options
{
	// Token: 0x02000265 RID: 613
	public class OrderOptions : IPaymentType
	{
		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x0005F064 File Offset: 0x0005D264
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x0005F078 File Offset: 0x0005D278
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x0005F08C File Offset: 0x0005D28C
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x0005F0A0 File Offset: 0x0005D2A0
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x0005F0C8 File Offset: 0x0005D2C8
		public string Reason
		{
			[CompilerGenerated]
			get
			{
				return this.<Reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Reason>k__BackingField = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x0005F0DC File Offset: 0x0005D2DC
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x0005F0F0 File Offset: 0x0005D2F0
		public bool IsUserType
		{
			[CompilerGenerated]
			get
			{
				return this.<IsUserType>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsUserType>k__BackingField = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x0005F104 File Offset: 0x0005D304
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x0005F118 File Offset: 0x0005D318
		public int? ClientId
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientId>k__BackingField = value;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x0005F12C File Offset: 0x0005D32C
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x0005F140 File Offset: 0x0005D340
		public bool IsRegular
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRegular>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsRegular>k__BackingField = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x0005F154 File Offset: 0x0005D354
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x0005F168 File Offset: 0x0005D368
		public decimal? DefaultSumm
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultSumm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DefaultSumm>k__BackingField = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x0005F17C File Offset: 0x0005D37C
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x0005F190 File Offset: 0x0005D390
		public DateTime? PayDate
		{
			[CompilerGenerated]
			get
			{
				return this.<PayDate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PayDate>k__BackingField = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0005F1A4 File Offset: 0x0005D3A4
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x0005F1B8 File Offset: 0x0005D3B8
		public DateTime? UpdatedAt
		{
			[CompilerGenerated]
			get
			{
				return this.<UpdatedAt>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<UpdatedAt>k__BackingField = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x0005F1CC File Offset: 0x0005D3CC
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x0005F1E0 File Offset: 0x0005D3E0
		public int? PaymentSystem
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentSystem>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<PaymentSystem>k__BackingField = value;
			}
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x000046B4 File Offset: 0x000028B4
		public OrderOptions()
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		public OrderOptions(Kassa.Types type, string name)
		{
			this.Id = (int)type;
			this.Name = name;
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0005F218 File Offset: 0x0005D418
		public Task<List<payment_types>> LoadUserPaymentTypes()
		{
			OrderOptions.<LoadUserPaymentTypes>d__42 <LoadUserPaymentTypes>d__;
			<LoadUserPaymentTypes>d__.<>t__builder = AsyncTaskMethodBuilder<List<payment_types>>.Create();
			<LoadUserPaymentTypes>d__.<>1__state = -1;
			<LoadUserPaymentTypes>d__.<>t__builder.Start<OrderOptions.<LoadUserPaymentTypes>d__42>(ref <LoadUserPaymentTypes>d__);
			return <LoadUserPaymentTypes>d__.<>t__builder.Task;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0005F254 File Offset: 0x0005D454
		public int AddNewPaymentType(payment_types type, List<int> userIds)
		{
			int id;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				auseceEntities.payment_types.Add(type);
				auseceEntities.SaveChanges();
				foreach (int user_id in userIds)
				{
					auseceEntities.payment_type_users.Add(new payment_type_users
					{
						user_id = user_id,
						payment_type = type.id
					});
				}
				auseceEntities.SaveChanges();
				id = type.id;
			}
			return id;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0005F304 File Offset: 0x0005D504
		public bool SaveExistPaymentType(payment_types type, List<int> userIds)
		{
			bool result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				payment_types payment_types = auseceEntities.payment_types.Find(new object[]
				{
					type.id
				});
				auseceEntities.Entry<payment_types>(payment_types).CurrentValues.SetValues(type);
				payment_types.updated_at = new DateTime?(DateTime.UtcNow);
				List<payment_type_users> list = (from p in auseceEntities.payment_type_users
				where p.payment_type == type.id
				select p).ToList<payment_type_users>();
				if (list.Any<payment_type_users>())
				{
					auseceEntities.payment_type_users.RemoveRange(list);
				}
				auseceEntities.SaveChanges();
				if (userIds != null)
				{
					foreach (int user_id in userIds)
					{
						auseceEntities.payment_type_users.Add(new payment_type_users
						{
							user_id = user_id,
							payment_type = type.id
						});
					}
					auseceEntities.SaveChanges();
					result = true;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
		public List<IPaymentType> GetRKO()
		{
			List<IPaymentType> list = new List<IPaymentType>(this.LoadUserPaymentTypes().Result);
			List<IPaymentType> list2 = new List<IPaymentType>
			{
				new OrderOptions
				{
					Id = 1,
					Name = Lang.t("RkoFreeReason")
				},
				new OrderOptions
				{
					Id = 2,
					Name = Lang.t("PnPayment")
				},
				new OrderOptions
				{
					Id = 4,
					Name = Lang.t("minusClientBalance")
				}
			};
			if (OfflineData.Instance.Employee.Can(18, 0))
			{
				list2.Add(new OrderOptions
				{
					Id = 3,
					Name = Lang.t("zOrder")
				});
			}
			if (list.Any<IPaymentType>())
			{
				list2.AddRange(list);
			}
			return list2;
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0005F590 File Offset: 0x0005D790
		public List<IPaymentType> GetRkoFull()
		{
			List<IPaymentType> rko = this.GetRKO();
			if (OfflineData.Instance.Employee.Can(48, 0))
			{
				rko.Add(new OrderOptions
				{
					Id = 5,
					Name = Lang.t("PayAdvance")
				});
				rko.Add(new OrderOptions
				{
					Id = 6,
					Name = Lang.t("PaySalary")
				});
				rko.Add(new OrderOptions
				{
					Id = 7,
					Name = Lang.t("WithdrawOrDepositFunds")
				});
			}
			rko.Add(new OrderOptions(Kassa.Types.RepairRefund, Lang.t("RepairRefund")));
			rko.Add(new OrderOptions(Kassa.Types.RefundRko, Lang.t("RefundRko")));
			return rko;
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0005F64C File Offset: 0x0005D84C
		public List<IPaymentType> GetAllOptions()
		{
			List<IPaymentType> list = new List<IPaymentType>();
			list.AddRange(this.GetRKO());
			list.AddRange(OrderOptions.GetPKO(false));
			return list;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0005F678 File Offset: 0x0005D878
		public List<IPaymentType> GetOptions4Kassa()
		{
			List<IPaymentType> list = new List<IPaymentType>();
			list.Insert(0, new OrderOptions
			{
				Id = -1,
				Name = Lang.t("PkoShort")
			});
			list.Insert(0, new OrderOptions
			{
				Id = -2,
				Name = Lang.t("RkoShort")
			});
			list.Insert(0, new OrderOptions
			{
				Id = 0,
				Name = Lang.t("All")
			});
			list.AddRange(this.GetRkoFull());
			list.AddRange(OrderOptions.GetPKO(true));
			return list;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0005F70C File Offset: 0x0005D90C
		public static List<OrderOptions> GetPKO(bool ext = false)
		{
			List<OrderOptions> list = new List<OrderOptions>
			{
				new OrderOptions
				{
					Id = 11,
					Name = Lang.t("pkoFreeReason")
				},
				new OrderOptions
				{
					Id = 12,
					Name = Lang.t("partsPrePayment")
				},
				new OrderOptions
				{
					Id = 13,
					Name = Lang.t("plusClientBalance")
				},
				new OrderOptions
				{
					Id = 14,
					Name = Lang.t("soldByRn")
				},
				new OrderOptions
				{
					Id = 15,
					Name = Lang.t("repairPayment")
				}
			};
			if (ext)
			{
				list.Add(new OrderOptions
				{
					Id = 17,
					Name = Lang.t("InvoicePayment")
				});
				list.Add(new OrderOptions
				{
					Id = 16,
					Name = Lang.t("PnCancelled")
				});
			}
			return list;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0005F818 File Offset: 0x0005DA18
		public bool UpdatePaymentSystems(IEnumerable<payment_systems> systems)
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				auseceEntities.Configuration.ValidateOnSaveEnabled = false;
				foreach (payment_systems payment_systems in systems)
				{
					payment_systems payment_systems2 = auseceEntities.payment_systems.Find(new object[]
					{
						payment_systems.id
					});
					payment_systems2.is_enable = payment_systems.is_enable;
					payment_systems2.name = payment_systems.name;
					payment_systems2.system_data = payment_systems.system_data;
					auseceEntities.SaveChanges();
				}
			}
			return true;
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0005F8D0 File Offset: 0x0005DAD0
		public payment_systems AddPaymentSystem(IEnumerable<payment_systems> systems)
		{
			payment_systems payment_systems = new payment_systems();
			payment_systems.name = "";
			payment_systems.system_id = (from p in systems
			select p.system_id).Max() + 1;
			payment_systems.is_enable = true;
			payment_systems payment_systems2 = payment_systems;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				auseceEntities.payment_systems.Add(payment_systems2);
				auseceEntities.SaveChanges();
			}
			return payment_systems2;
		}

		// Token: 0x040010E7 RID: 4327
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010E8 RID: 4328
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040010E9 RID: 4329
		[CompilerGenerated]
		private string <Reason>k__BackingField;

		// Token: 0x040010EA RID: 4330
		[CompilerGenerated]
		private bool <IsUserType>k__BackingField;

		// Token: 0x040010EB RID: 4331
		[CompilerGenerated]
		private int? <ClientId>k__BackingField;

		// Token: 0x040010EC RID: 4332
		[CompilerGenerated]
		private bool <IsRegular>k__BackingField;

		// Token: 0x040010ED RID: 4333
		[CompilerGenerated]
		private decimal? <DefaultSumm>k__BackingField;

		// Token: 0x040010EE RID: 4334
		[CompilerGenerated]
		private DateTime? <PayDate>k__BackingField;

		// Token: 0x040010EF RID: 4335
		[CompilerGenerated]
		private DateTime? <UpdatedAt>k__BackingField;

		// Token: 0x040010F0 RID: 4336
		[CompilerGenerated]
		private int? <PaymentSystem>k__BackingField;

		// Token: 0x02000266 RID: 614
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600211F RID: 8479 RVA: 0x0005F960 File Offset: 0x0005DB60
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002120 RID: 8480 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002121 RID: 8481 RVA: 0x0005F978 File Offset: 0x0005DB78
			internal int <AddPaymentSystem>b__51_0(payment_systems p)
			{
				return p.system_id;
			}

			// Token: 0x040010F1 RID: 4337
			public static readonly OrderOptions.<>c <>9 = new OrderOptions.<>c();

			// Token: 0x040010F2 RID: 4338
			public static Func<payment_systems, int> <>9__51_0;
		}

		// Token: 0x02000267 RID: 615
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadUserPaymentTypes>d__42 : IAsyncStateMachine
		{
			// Token: 0x06002122 RID: 8482 RVA: 0x0005F98C File Offset: 0x0005DB8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<payment_types> result;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<List<payment_types>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from p in this.<ctx>5__2.payment_types.AsNoTracking()
							where p.is_archive == false
							select p).Include((payment_types p) => p.payment_type_users).Include((payment_types p) => p.clients).ToListAsync<payment_types>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<payment_types>>.ConfiguredTaskAwaiter, OrderOptions.<LoadUserPaymentTypes>d__42>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<payment_types>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
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
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06002123 RID: 8483 RVA: 0x0005FB78 File Offset: 0x0005DD78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040010F3 RID: 4339
			public int <>1__state;

			// Token: 0x040010F4 RID: 4340
			public AsyncTaskMethodBuilder<List<payment_types>> <>t__builder;

			// Token: 0x040010F5 RID: 4341
			private auseceEntities <ctx>5__2;

			// Token: 0x040010F6 RID: 4342
			private ConfiguredTaskAwaitable<List<payment_types>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000268 RID: 616
		[CompilerGenerated]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06002124 RID: 8484 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x040010F7 RID: 4343
			public payment_types type;
		}
	}
}
