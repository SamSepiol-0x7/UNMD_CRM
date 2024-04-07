using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.DAL;
using ASC.Interfaces;
using ASC.Models;
using Newtonsoft.Json;

namespace ASC.Services
{
	// Token: 0x02000684 RID: 1668
	public class OrderService : IOrderService
	{
		// Token: 0x060038AE RID: 14510 RVA: 0x000CEB44 File Offset: 0x000CCD44
		public OrderService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x000CEB60 File Offset: 0x000CCD60
		public Task<List<images>> GetImages(int orderId)
		{
			OrderService.<GetImages>d__2 <GetImages>d__;
			<GetImages>d__.<>t__builder = AsyncTaskMethodBuilder<List<images>>.Create();
			<GetImages>d__.<>4__this = this;
			<GetImages>d__.orderId = orderId;
			<GetImages>d__.<>1__state = -1;
			<GetImages>d__.<>t__builder.Start<OrderService.<GetImages>d__2>(ref <GetImages>d__);
			return <GetImages>d__.<>t__builder.Task;
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x000CEBAC File Offset: 0x000CCDAC
		public Task UpdateImageIds(int orderId, List<int> imageIds)
		{
			OrderService.<UpdateImageIds>d__3 <UpdateImageIds>d__;
			<UpdateImageIds>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateImageIds>d__.<>4__this = this;
			<UpdateImageIds>d__.orderId = orderId;
			<UpdateImageIds>d__.imageIds = imageIds;
			<UpdateImageIds>d__.<>1__state = -1;
			<UpdateImageIds>d__.<>t__builder.Start<OrderService.<UpdateImageIds>d__3>(ref <UpdateImageIds>d__);
			return <UpdateImageIds>d__.<>t__builder.Task;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x000CEC00 File Offset: 0x000CCE00
		public Task CancellOrder(int repairId, int nextStatus, int paymentSystem)
		{
			OrderService.<CancellOrder>d__4 <CancellOrder>d__;
			<CancellOrder>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CancellOrder>d__.repairId = repairId;
			<CancellOrder>d__.nextStatus = nextStatus;
			<CancellOrder>d__.paymentSystem = paymentSystem;
			<CancellOrder>d__.<>1__state = -1;
			<CancellOrder>d__.<>t__builder.Start<OrderService.<CancellOrder>d__4>(ref <CancellOrder>d__);
			return <CancellOrder>d__.<>t__builder.Task;
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x000CEC54 File Offset: 0x000CCE54
		public Task DeleteWorkshopIssuedData(int repairId)
		{
			OrderService.<DeleteWorkshopIssuedData>d__5 <DeleteWorkshopIssuedData>d__;
			<DeleteWorkshopIssuedData>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<DeleteWorkshopIssuedData>d__.<>4__this = this;
			<DeleteWorkshopIssuedData>d__.repairId = repairId;
			<DeleteWorkshopIssuedData>d__.<>1__state = -1;
			<DeleteWorkshopIssuedData>d__.<>t__builder.Start<OrderService.<DeleteWorkshopIssuedData>d__5>(ref <DeleteWorkshopIssuedData>d__);
			return <DeleteWorkshopIssuedData>d__.<>t__builder.Task;
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x000CECA0 File Offset: 0x000CCEA0
		public Task<DateTime?> GetDateOfIssue(int repairId)
		{
			OrderService.<GetDateOfIssue>d__6 <GetDateOfIssue>d__;
			<GetDateOfIssue>d__.<>t__builder = AsyncTaskMethodBuilder<DateTime?>.Create();
			<GetDateOfIssue>d__.<>4__this = this;
			<GetDateOfIssue>d__.repairId = repairId;
			<GetDateOfIssue>d__.<>1__state = -1;
			<GetDateOfIssue>d__.<>t__builder.Start<OrderService.<GetDateOfIssue>d__6>(ref <GetDateOfIssue>d__);
			return <GetDateOfIssue>d__.<>t__builder.Task;
		}

		// Token: 0x04002286 RID: 8838
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000685 RID: 1669
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x060038B4 RID: 14516 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04002287 RID: 8839
			public int orderId;
		}

		// Token: 0x02000686 RID: 1670
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x060038B5 RID: 14517 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_1()
			{
			}

			// Token: 0x04002288 RID: 8840
			public List<int?> ids;
		}

		// Token: 0x02000687 RID: 1671
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060038B6 RID: 14518 RVA: 0x000CECEC File Offset: 0x000CCEEC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060038B7 RID: 14519 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002289 RID: 8841
			public static readonly OrderService.<>c <>9 = new OrderService.<>c();
		}

		// Token: 0x02000688 RID: 1672
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImages>d__2 : IAsyncStateMachine
		{
			// Token: 0x060038B8 RID: 14520 RVA: 0x000CED04 File Offset: 0x000CCF04
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OrderService orderService = this.<>4__this;
				List<images> result2;
				try
				{
					OrderService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new OrderService.<>c__DisplayClass2_0();
						CS$<>8__locals1.orderId = this.orderId;
						this.<ctx>5__2 = orderService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_272;
							}
							this.<>8__1 = new OrderService.<>c__DisplayClass2_1();
							awaiter2 = (from w in this.<ctx>5__2.workshop
							where w.id == CS$<>8__locals1.orderId
							select w.image_ids).FirstOrDefaultAsync<string>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, OrderService.<GetImages>d__2>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						string result = awaiter2.GetResult();
						if (string.IsNullOrEmpty(result))
						{
							result2 = new List<images>();
							goto IL_2CE;
						}
						this.<>8__1.ids = JsonConvert.DeserializeObject<List<int?>>(result);
						awaiter = (from i in this.<ctx>5__2.images.AsNoTracking()
						where this.<>8__1.ids.Contains((int?)i.id)
						select i).ToListAsync<images>().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter, OrderService.<GetImages>d__2>(ref awaiter, ref this);
							return;
						}
						IL_272:
						result2 = awaiter.GetResult();
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
				IL_2CE:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060038B9 RID: 14521 RVA: 0x000CF028 File Offset: 0x000CD228
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400228A RID: 8842
			public int <>1__state;

			// Token: 0x0400228B RID: 8843
			public AsyncTaskMethodBuilder<List<images>> <>t__builder;

			// Token: 0x0400228C RID: 8844
			public int orderId;

			// Token: 0x0400228D RID: 8845
			public OrderService <>4__this;

			// Token: 0x0400228E RID: 8846
			private OrderService.<>c__DisplayClass2_1 <>8__1;

			// Token: 0x0400228F RID: 8847
			private auseceEntities <ctx>5__2;

			// Token: 0x04002290 RID: 8848
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04002291 RID: 8849
			private ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000689 RID: 1673
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateImageIds>d__3 : IAsyncStateMachine
		{
			// Token: 0x060038BA RID: 14522 RVA: 0x000CF044 File Offset: 0x000CD244
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OrderService orderService = this.<>4__this;
				try
				{
					string image_ids;
					if (num != 0)
					{
						image_ids = JsonConvert.SerializeObject(this.imageIds);
						this.<ctx>5__2 = orderService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<ctx>5__2.Configuration.ValidateOnSaveEnabled = false;
							workshop workshop = new workshop
							{
								id = this.orderId
							};
							this.<ctx>5__2.workshop.Attach(workshop);
							workshop.image_ids = image_ids;
							awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, OrderService.<UpdateImageIds>d__3>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
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

			// Token: 0x060038BB RID: 14523 RVA: 0x000CF198 File Offset: 0x000CD398
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002292 RID: 8850
			public int <>1__state;

			// Token: 0x04002293 RID: 8851
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002294 RID: 8852
			public List<int> imageIds;

			// Token: 0x04002295 RID: 8853
			public OrderService <>4__this;

			// Token: 0x04002296 RID: 8854
			public int orderId;

			// Token: 0x04002297 RID: 8855
			private auseceEntities <ctx>5__2;

			// Token: 0x04002298 RID: 8856
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200068A RID: 1674
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x060038BC RID: 14524 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002299 RID: 8857
			public int repairId;
		}

		// Token: 0x0200068B RID: 1675
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CancellOrder>d__4 : IAsyncStateMachine
		{
			// Token: 0x060038BD RID: 14525 RVA: 0x000CF1B4 File Offset: 0x000CD3B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new OrderService.<>c__DisplayClass4_0();
						this.<>8__1.repairId = this.repairId;
						this.<ctx>5__2 = new auseceEntities(false);
					}
					try
					{
						ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<workshop>.ConfiguredTaskAwaiter awaiter2;
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(ConfiguredTaskAwaitable<workshop>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_217;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_2C9;
						}
						default:
							awaiter = (from o in this.<ctx>5__2.cash_orders
							where o.repair == (int?)this.<>8__1.repairId
							select o.summa).DefaultIfEmpty<decimal>().SumAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter, OrderService.<CancellOrder>d__4>(ref awaiter, ref this);
								return;
							}
							break;
						}
						decimal result = awaiter.GetResult();
						this.<refundSumm>5__3 = result;
						if (this.<refundSumm>5__3 == 0m)
						{
							goto IL_314;
						}
						awaiter2 = this.<ctx>5__2.workshop.FindAsync(new object[]
						{
							this.<>8__1.repairId
						}).ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<workshop>.ConfiguredTaskAwaiter, OrderService.<CancellOrder>d__4>(ref awaiter2, ref this);
							return;
						}
						IL_217:
						workshop result2 = awaiter2.GetResult();
						KassaModel kassaModel = new KassaModel();
						kassaModel.NewCashOrder(8, result2.client, this.<refundSumm>5__3, new int?(this.<>8__1.repairId));
						kassaModel.SetPaymentSystem(this.paymentSystem);
						kassaModel.MakeRko();
						result2.prepaid_summ = 0m;
						awaiter3 = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, OrderService.<CancellOrder>d__4>(ref awaiter3, ref this);
							return;
						}
						IL_2C9:
						awaiter3.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_314:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060038BE RID: 14526 RVA: 0x000CF524 File Offset: 0x000CD724
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400229A RID: 8858
			public int <>1__state;

			// Token: 0x0400229B RID: 8859
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400229C RID: 8860
			public int repairId;

			// Token: 0x0400229D RID: 8861
			public int nextStatus;

			// Token: 0x0400229E RID: 8862
			private OrderService.<>c__DisplayClass4_0 <>8__1;

			// Token: 0x0400229F RID: 8863
			public int paymentSystem;

			// Token: 0x040022A0 RID: 8864
			private auseceEntities <ctx>5__2;

			// Token: 0x040022A1 RID: 8865
			private decimal <refundSumm>5__3;

			// Token: 0x040022A2 RID: 8866
			private ConfiguredTaskAwaitable<decimal>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040022A3 RID: 8867
			private ConfiguredTaskAwaitable<workshop>.ConfiguredTaskAwaiter <>u__2;

			// Token: 0x040022A4 RID: 8868
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__3;
		}

		// Token: 0x0200068C RID: 1676
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x060038BF RID: 14527 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040022A5 RID: 8869
			public int repairId;
		}

		// Token: 0x0200068D RID: 1677
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <DeleteWorkshopIssuedData>d__5 : IAsyncStateMachine
		{
			// Token: 0x060038C0 RID: 14528 RVA: 0x000CF540 File Offset: 0x000CD740
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OrderService orderService = this.<>4__this;
				try
				{
					OrderService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new OrderService.<>c__DisplayClass5_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = orderService._contextFactory.Create();
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						ConfiguredTaskAwaitable<List<workshop_issued>>.ConfiguredTaskAwaiter awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_192;
							}
							awaiter2 = (from i in this.<ctx>5__2.workshop_issued
							where i.repair_id == CS$<>8__locals1.repairId
							select i).ToListAsync<workshop_issued>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<workshop_issued>>.ConfiguredTaskAwaiter, OrderService.<DeleteWorkshopIssuedData>d__5>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<workshop_issued>>.ConfiguredTaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						List<workshop_issued> result = awaiter2.GetResult();
						this.<ctx>5__2.workshop_issued.RemoveRange(result);
						awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, OrderService.<DeleteWorkshopIssuedData>d__5>(ref awaiter, ref this);
							return;
						}
						IL_192:
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<ctx>5__2 != null)
						{
							((IDisposable)this.<ctx>5__2).Dispose();
						}
					}
					this.<ctx>5__2 = null;
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

			// Token: 0x060038C1 RID: 14529 RVA: 0x000CF76C File Offset: 0x000CD96C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022A6 RID: 8870
			public int <>1__state;

			// Token: 0x040022A7 RID: 8871
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040022A8 RID: 8872
			public int repairId;

			// Token: 0x040022A9 RID: 8873
			public OrderService <>4__this;

			// Token: 0x040022AA RID: 8874
			private auseceEntities <ctx>5__2;

			// Token: 0x040022AB RID: 8875
			private ConfiguredTaskAwaitable<List<workshop_issued>>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040022AC RID: 8876
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x0200068E RID: 1678
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060038C2 RID: 14530 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x040022AD RID: 8877
			public int repairId;
		}

		// Token: 0x0200068F RID: 1679
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDateOfIssue>d__6 : IAsyncStateMachine
		{
			// Token: 0x060038C3 RID: 14531 RVA: 0x000CF788 File Offset: 0x000CD988
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OrderService orderService = this.<>4__this;
				DateTime? result;
				try
				{
					OrderService.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new OrderService.<>c__DisplayClass6_0();
						CS$<>8__locals1.repairId = this.repairId;
						this.<ctx>5__2 = orderService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<DateTime?> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.workshop
							where i.id == CS$<>8__locals1.repairId
							select i.out_date).FirstOrDefaultAsync<DateTime?>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<DateTime?>, OrderService.<GetDateOfIssue>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<DateTime?>);
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

			// Token: 0x060038C4 RID: 14532 RVA: 0x000CF958 File Offset: 0x000CDB58
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040022AE RID: 8878
			public int <>1__state;

			// Token: 0x040022AF RID: 8879
			public AsyncTaskMethodBuilder<DateTime?> <>t__builder;

			// Token: 0x040022B0 RID: 8880
			public int repairId;

			// Token: 0x040022B1 RID: 8881
			public OrderService <>4__this;

			// Token: 0x040022B2 RID: 8882
			private auseceEntities <ctx>5__2;

			// Token: 0x040022B3 RID: 8883
			private TaskAwaiter<DateTime?> <>u__1;
		}
	}
}
