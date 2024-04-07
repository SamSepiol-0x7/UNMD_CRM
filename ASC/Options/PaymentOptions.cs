using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using NLog;

namespace ASC.Options
{
	// Token: 0x02000251 RID: 593
	public class PaymentOptions : IOptions<PaymentOptions>
	{
		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0005DE88 File Offset: 0x0005C088
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x0005DE9C File Offset: 0x0005C09C
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

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x0005DEB0 File Offset: 0x0005C0B0
		// (set) Token: 0x060020A3 RID: 8355 RVA: 0x0005DEC4 File Offset: 0x0005C0C4
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

		// Token: 0x060020A4 RID: 8356 RVA: 0x0005DED8 File Offset: 0x0005C0D8
		public List<PaymentOptions> GetAllOptions()
		{
			List<PaymentOptions> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					ParameterExpression parameterExpression;
					List<PaymentOptions> list = (from p in auseceEntities.payment_systems
					where p.is_enable
					select p).Select(Expression.Lambda<Func<payment_systems, PaymentOptions>>(Expression.MemberInit(Expression.New(typeof(PaymentOptions)), new MemberBinding[]
					{
						Expression.Bind(methodof(PaymentOptions.set_Id(int)), Expression.Property(parameterExpression, methodof(payment_systems.get_system_id()))),
						Expression.Bind(methodof(PaymentOptions.set_Name(string)), Expression.Property(parameterExpression, methodof(payment_systems.get_name())))
					}), new ParameterExpression[]
					{
						parameterExpression
					})).ToList<PaymentOptions>();
					if (!Auth.User.offices1.card_payment)
					{
						PaymentOptions paymentOptions = list.FirstOrDefault((PaymentOptions i) => i.Id == -1);
						if (paymentOptions != null)
						{
							list.Remove(paymentOptions);
						}
					}
					result = (from o in list
					orderby o.Name
					select o).ToList<PaymentOptions>();
				}
			}
			catch (Exception exception)
			{
				PaymentOptions.Log.Error(exception, "Get payment options fail");
				result = new List<PaymentOptions>();
			}
			return result;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0005E0A0 File Offset: 0x0005C2A0
		public static Task<List<PaymentOptions>> GetAllOptions(bool includeAll)
		{
			PaymentOptions.<GetAllOptions>d__11 <GetAllOptions>d__;
			<GetAllOptions>d__.<>t__builder = AsyncTaskMethodBuilder<List<PaymentOptions>>.Create();
			<GetAllOptions>d__.includeAll = includeAll;
			<GetAllOptions>d__.<>1__state = -1;
			<GetAllOptions>d__.<>t__builder.Start<PaymentOptions.<GetAllOptions>d__11>(ref <GetAllOptions>d__);
			return <GetAllOptions>d__.<>t__builder.Task;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0005E0E4 File Offset: 0x0005C2E4
		public string GetOptionName(int optionId)
		{
			string result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from p in auseceEntities.payment_systems
					where p.system_id == optionId
					select p.name).FirstOrDefault<string>();
				}
			}
			catch (Exception exception)
			{
				PaymentOptions.Log.Error(exception, "Get option name fail");
				result = "";
			}
			return result;
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x000046B4 File Offset: 0x000028B4
		public PaymentOptions()
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0005E1F8 File Offset: 0x0005C3F8
		// Note: this type is marked as 'beforefieldinit'.
		static PaymentOptions()
		{
		}

		// Token: 0x040010AD RID: 4269
		public static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x040010AE RID: 4270
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010AF RID: 4271
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x02000252 RID: 594
		public enum Systems
		{
			// Token: 0x040010B1 RID: 4273
			CustomerBalance = -2,
			// Token: 0x040010B2 RID: 4274
			Card,
			// Token: 0x040010B3 RID: 4275
			Cash,
			// Token: 0x040010B4 RID: 4276
			CashLess
		}

		// Token: 0x02000253 RID: 595
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060020A9 RID: 8361 RVA: 0x0005E210 File Offset: 0x0005C410
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060020AA RID: 8362 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060020AB RID: 8363 RVA: 0x0005E228 File Offset: 0x0005C428
			internal bool <GetAllOptions>b__10_3(PaymentOptions i)
			{
				return i.Id == -1;
			}

			// Token: 0x060020AC RID: 8364 RVA: 0x0005E240 File Offset: 0x0005C440
			internal string <GetAllOptions>b__10_2(PaymentOptions o)
			{
				return o.Name;
			}

			// Token: 0x040010B5 RID: 4277
			public static readonly PaymentOptions.<>c <>9 = new PaymentOptions.<>c();

			// Token: 0x040010B6 RID: 4278
			public static Func<PaymentOptions, bool> <>9__10_3;

			// Token: 0x040010B7 RID: 4279
			public static Func<PaymentOptions, string> <>9__10_2;
		}

		// Token: 0x02000254 RID: 596
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetAllOptions>d__11 : IAsyncStateMachine
		{
			// Token: 0x060020AD RID: 8365 RVA: 0x0005E254 File Offset: 0x0005C454
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<PaymentOptions> result2;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<PaymentOptions>> awaiter;
							if (num != 0)
							{
								ParameterExpression parameterExpression;
								awaiter = (from p in this.<ctx>5__2.payment_systems
								where p.is_enable
								where p.system_id != -2
								select p into o
								orderby o.name
								select o).Select(Expression.Lambda<Func<payment_systems, PaymentOptions>>(Expression.MemberInit(Expression.New(typeof(PaymentOptions)), new MemberBinding[]
								{
									Expression.Bind(methodof(PaymentOptions.set_Id(int)), Expression.Property(parameterExpression, methodof(payment_systems.get_system_id()))),
									Expression.Bind(methodof(PaymentOptions.set_Name(string)), Expression.Property(parameterExpression, methodof(payment_systems.get_name())))
								}), new ParameterExpression[]
								{
									parameterExpression
								})).ToListAsync<PaymentOptions>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<PaymentOptions>>, PaymentOptions.<GetAllOptions>d__11>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<PaymentOptions>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							List<PaymentOptions> result = awaiter.GetResult();
							if (this.includeAll)
							{
								result.Insert(0, new PaymentOptions
								{
									Id = -100,
									Name = Lang.t("All")
								});
							}
							result2 = result;
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
						PaymentOptions.Log.Error(exception, "Get payment options fail");
						result2 = new List<PaymentOptions>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060020AE RID: 8366 RVA: 0x0005E540 File Offset: 0x0005C740
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040010B8 RID: 4280
			public int <>1__state;

			// Token: 0x040010B9 RID: 4281
			public AsyncTaskMethodBuilder<List<PaymentOptions>> <>t__builder;

			// Token: 0x040010BA RID: 4282
			public bool includeAll;

			// Token: 0x040010BB RID: 4283
			private auseceEntities <ctx>5__2;

			// Token: 0x040010BC RID: 4284
			private TaskAwaiter<List<PaymentOptions>> <>u__1;
		}

		// Token: 0x02000255 RID: 597
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060020AF RID: 8367 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x040010BD RID: 4285
			public int optionId;
		}
	}
}
