using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Services.Concrete;
using Autofac;
using Poly;

namespace ASC.PartsRequest
{
	// Token: 0x02000179 RID: 377
	public class PartsRequestModel : UsersModel
	{
		// Token: 0x0600178F RID: 6031 RVA: 0x0003D508 File Offset: 0x0003B708
		public Task<store_int_reserve> LoadReserve(int reserveId)
		{
			PartsRequestModel.<LoadReserve>d__1 <LoadReserve>d__;
			<LoadReserve>d__.<>t__builder = AsyncTaskMethodBuilder<store_int_reserve>.Create();
			<LoadReserve>d__.<>4__this = this;
			<LoadReserve>d__.reserveId = reserveId;
			<LoadReserve>d__.<>1__state = -1;
			<LoadReserve>d__.<>t__builder.Start<PartsRequestModel.<LoadReserve>d__1>(ref <LoadReserve>d__);
			return <LoadReserve>d__.<>t__builder.Task;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0003D554 File Offset: 0x0003B754
		public bool MakeReserve(store_int_reserve reserve)
		{
			reserve.from_user = Auth.User.id;
			reserve.created = new DateTime?(this._localization.Now);
			reserve.state = 1;
			store_items store_items = this._context.store_items.FirstOrDefault((store_items i) => i.id == reserve.item_id);
			if (store_items == null)
			{
				return false;
			}
			store_items.reserved += reserve.count;
			users employee = base.GetEmployee(reserve.to_user);
			string prm = string.Concat(new string[]
			{
				employee.surname,
				" ",
				employee.name,
				" ",
				employee.patronymic
			});
			this._history.AddItemLog("GivePart2User", store_items.id, prm, "");
			return base.SaveContext(true);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0003D6B8 File Offset: 0x0003B8B8
		[Obsolete("NEED MERGE WITH WorkshopPartService.RemovePart")]
		public Task RemoveItemFromRepair(store_int_reserve reserve)
		{
			PartsRequestModel.<RemoveItemFromRepair>d__3 <RemoveItemFromRepair>d__;
			<RemoveItemFromRepair>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemoveItemFromRepair>d__.reserve = reserve;
			<RemoveItemFromRepair>d__.<>1__state = -1;
			<RemoveItemFromRepair>d__.<>t__builder.Start<PartsRequestModel.<RemoveItemFromRepair>d__3>(ref <RemoveItemFromRepair>d__);
			return <RemoveItemFromRepair>d__.<>t__builder.Task;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0003D6FC File Offset: 0x0003B8FC
		public IAscResult MakeRequest(store_int_reserve Reserve)
		{
			Result result = new Result();
			List<int> list = UsersModel.UsersByPermission(45, OfflineData.Instance.Employee.OfficeId);
			if (list.Any<int>())
			{
				int from_user = list.First<int>();
				Reserve.created = new DateTime?(this._localization.Now);
				Reserve.to_user = Auth.User.id;
				Reserve.from_user = from_user;
				Reserve.state = 0;
				result.IsSucces = base.SaveContext(false);
				if (result.IsSucces && OfflineData.Instance.Settings.InformIntRequest)
				{
					NotificationService.CreateIntRequestNotification(list, Reserve.id, Reserve.name);
				}
				return result;
			}
			result.Message = "Нет кладовщика в офисе";
			return result;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0003D7B0 File Offset: 0x0003B9B0
		public store_int_reserve ReferenceReserve(store_int_reserve Reserve)
		{
			try
			{
				if (!this._context.Exists<store_int_reserve>(Reserve))
				{
					this._context.store_int_reserve.Add(Reserve);
				}
				this._context.Entry<store_int_reserve>(Reserve).Reference<store_items>((store_int_reserve r) => r.store_items).Load();
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load reference fail");
			}
			return Reserve;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0003D854 File Offset: 0x0003BA54
		public bool CancellReserve(store_int_reserve reserve, PartsRequestModel.State state)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					store_items store_items = auseceEntities.store_items.FirstOrDefault((store_items i) => i.id == reserve.item_id);
					if (store_items == null)
					{
						result = false;
					}
					else
					{
						HistoryV2 historyV = new HistoryV2();
						if (state == PartsRequestModel.State.Installed)
						{
							store_items.count += reserve.count;
							this.CalculateItemReserve(store_items, -reserve.count);
							historyV.AddItemLog("ReserveRestored", store_items.id, reserve.repair_id.ToString(), "");
						}
						if (state == PartsRequestModel.State.Archive)
						{
							this.CalculateItemReserve(store_items, reserve.count);
							users employee = base.GetEmployee(reserve.to_user);
							historyV.AddItemLog("CancellReserve", store_items.id, employee.Fio, "");
						}
						this.SetReserveState(reserve.id, state);
						auseceEntities.SaveChanges();
						historyV.Save();
						result = true;
					}
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Cancell reserve fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0003DA28 File Offset: 0x0003BC28
		public bool SetReserveState(int reserveId, PartsRequestModel.State state)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					store_int_reserve store_int_reserve = auseceEntities.store_int_reserve.Find(new object[]
					{
						reserveId
					});
					if (store_int_reserve == null)
					{
						return false;
					}
					store_int_reserve.state = (int)state;
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Set reserve state fail");
				return false;
			}
			return true;
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0003DAB0 File Offset: 0x0003BCB0
		private void CalculateItemReserve(store_items item, int reserveCount)
		{
			item.reserved -= reserveCount;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0003DACC File Offset: 0x0003BCCC
		public bool SoldItemRepairOut(store_int_reserve reserve)
		{
			if (reserve == null || reserve.id == 0)
			{
				return false;
			}
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					store_items store_items = auseceEntities.store_items.FirstOrDefault((store_items i) => i.id == reserve.item_id);
					if (store_items == null)
					{
						result = false;
					}
					else
					{
						if (store_items.is_realization)
						{
							HistoryV2 historyV = new HistoryV2();
							KassaModel kassaModel = new KassaModel();
							store_items item = new store_items
							{
								id = store_items.id,
								dealer = store_items.dealer,
								is_realization = store_items.is_realization,
								return_percent = store_items.return_percent,
								in_price = store_items.in_price,
								BuyCount = reserve.count,
								BuyCost = reserve.price
							};
							kassaModel.RealizatorItems2Balance(item, historyV);
							historyV.Save();
						}
						this.CalculateItemReserve(store_items, reserve.count);
						store_items.count -= reserve.count;
						store_items.sold += reserve.count;
						this.SetReserveState(reserve.id, PartsRequestModel.State.InstalledSold);
						auseceEntities.SaveChanges();
						result = true;
					}
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Sold item rOut error");
				result = false;
			}
			return result;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0003DCD4 File Offset: 0x0003BED4
		public int GetRepairState(int repairId)
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from r in auseceEntities.workshop
					where r.id == repairId
					select r.state).FirstOrDefault<int>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Get repair state fail");
				result = 0;
			}
			return result;
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0003DDE4 File Offset: 0x0003BFE4
		public Task<IEnumerable<logs>> GetHistory(int requestId)
		{
			PartsRequestModel.<GetHistory>d__11 <GetHistory>d__;
			<GetHistory>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<logs>>.Create();
			<GetHistory>d__.requestId = requestId;
			<GetHistory>d__.<>1__state = -1;
			<GetHistory>d__.<>t__builder.Start<PartsRequestModel.<GetHistory>d__11>(ref <GetHistory>d__);
			return <GetHistory>d__.<>t__builder.Task;
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0003DE28 File Offset: 0x0003C028
		public static Task<IAscResult> UpdateSn(int reserveId, string sn)
		{
			PartsRequestModel.<UpdateSn>d__12 <UpdateSn>d__;
			<UpdateSn>d__.<>t__builder = AsyncTaskMethodBuilder<IAscResult>.Create();
			<UpdateSn>d__.reserveId = reserveId;
			<UpdateSn>d__.sn = sn;
			<UpdateSn>d__.<>1__state = -1;
			<UpdateSn>d__.<>t__builder.Start<PartsRequestModel.<UpdateSn>d__12>(ref <UpdateSn>d__);
			return <UpdateSn>d__.<>t__builder.Task;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0003DE74 File Offset: 0x0003C074
		public static IAscResult<store_int_reserve> AllocateRequest(store_int_reserve item, int quantity)
		{
			Result<store_int_reserve> result = new Result<store_int_reserve>();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							store_int_reserve store_int_reserve = auseceEntities.store_int_reserve.Find(new object[]
							{
								item.id
							});
							store_int_reserve.count -= quantity;
							store_int_reserve store_int_reserve2 = new store_int_reserve();
							store_int_reserve.CopyProperties(store_int_reserve2);
							store_int_reserve2.id = 0;
							store_int_reserve2.count = quantity;
							auseceEntities.store_int_reserve.Add(store_int_reserve2);
							auseceEntities.SaveChanges();
							string notes = store_int_reserve.notes + Environment.NewLine + string.Format("Отделение {0} шт. из запроса {1:d6} в {2:d6}", quantity, store_int_reserve.id, store_int_reserve2.id);
							store_int_reserve.notes = notes;
							store_int_reserve2.notes = notes;
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							result.Object = store_int_reserve2;
						}
						catch (Exception ex)
						{
							GenericModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							result.Message = ex.Message;
							return result;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				GenericModel.Log.Error(ex2, ex2.Message);
				result.Message = ex2.Message;
				return result;
			}
			result.SetSuccess();
			return result;
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0003E03C File Offset: 0x0003C23C
		public PartsRequestModel()
		{
		}

		// Token: 0x04000BBA RID: 3002
		private Localization _localization = new Localization("UTC");

		// Token: 0x0200017A RID: 378
		public enum State
		{
			// Token: 0x04000BBC RID: 3004
			Waiting,
			// Token: 0x04000BBD RID: 3005
			onMaster,
			// Token: 0x04000BBE RID: 3006
			Installed,
			// Token: 0x04000BBF RID: 3007
			InstalledSold,
			// Token: 0x04000BC0 RID: 3008
			Archive,
			// Token: 0x04000BC1 RID: 3009
			Rejected
		}

		// Token: 0x0200017B RID: 379
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x0600179D RID: 6045 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x04000BC2 RID: 3010
			public int reserveId;
		}

		// Token: 0x0200017C RID: 380
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600179E RID: 6046 RVA: 0x0003E060 File Offset: 0x0003C260
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600179F RID: 6047 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04000BC3 RID: 3011
			public static readonly PartsRequestModel.<>c <>9 = new PartsRequestModel.<>c();
		}

		// Token: 0x0200017D RID: 381
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadReserve>d__1 : IAsyncStateMachine
		{
			// Token: 0x060017A0 RID: 6048 RVA: 0x0003E078 File Offset: 0x0003C278
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PartsRequestModel partsRequestModel = this.<>4__this;
				store_int_reserve result;
				try
				{
					PartsRequestModel.<>c__DisplayClass1_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PartsRequestModel.<>c__DisplayClass1_0();
						CS$<>8__locals1.reserveId = this.reserveId;
					}
					try
					{
						TaskAwaiter<store_int_reserve> awaiter;
						if (num != 0)
						{
							awaiter = partsRequestModel._context.store_int_reserve.Include((store_int_reserve r) => r.users).Include((store_int_reserve r) => r.users1).FirstOrDefaultAsync((store_int_reserve r) => r.id == CS$<>8__locals1.reserveId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, PartsRequestModel.<LoadReserve>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
							this.<>1__state = -1;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Load int reserve fail");
						result = null;
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060017A1 RID: 6049 RVA: 0x0003E274 File Offset: 0x0003C474
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BC4 RID: 3012
			public int <>1__state;

			// Token: 0x04000BC5 RID: 3013
			public AsyncTaskMethodBuilder<store_int_reserve> <>t__builder;

			// Token: 0x04000BC6 RID: 3014
			public int reserveId;

			// Token: 0x04000BC7 RID: 3015
			public PartsRequestModel <>4__this;

			// Token: 0x04000BC8 RID: 3016
			private TaskAwaiter<store_int_reserve> <>u__1;
		}

		// Token: 0x0200017E RID: 382
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x060017A2 RID: 6050 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x04000BC9 RID: 3017
			public store_int_reserve reserve;
		}

		// Token: 0x0200017F RID: 383
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x060017A3 RID: 6051 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x04000BCA RID: 3018
			public store_int_reserve reserve;
		}

		// Token: 0x02000180 RID: 384
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveItemFromRepair>d__3 : IAsyncStateMachine
		{
			// Token: 0x060017A4 RID: 6052 RVA: 0x0003E290 File Offset: 0x0003C490
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new PartsRequestModel.<>c__DisplayClass3_0();
						this.<>8__1.reserve = this.reserve;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<store_int_reserve> awaiter;
						TaskAwaiter<int> awaiter2;
						TaskAwaiter awaiter3;
						switch (num)
						{
						case 0:
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							break;
						}
						case 1:
						{
							awaiter2 = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
							goto IL_1A1;
						}
						case 2:
						{
							awaiter3 = this.<>u__3;
							this.<>u__3 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
							goto IL_244;
						}
						default:
							awaiter = this.<ctx>5__2.store_int_reserve.FirstAsync((store_int_reserve i) => i.id == this.<>8__1.reserve.id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 0;
								num = 0;
								this.<>1__state = num5;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, PartsRequestModel.<RemoveItemFromRepair>d__3>(ref awaiter, ref this);
								return;
							}
							break;
						}
						store_int_reserve result = awaiter.GetResult();
						result.state = 1;
						result.repair_id = null;
						result.work_id = null;
						awaiter2 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.<>1__state = num6;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, PartsRequestModel.<RemoveItemFromRepair>d__3>(ref awaiter2, ref this);
							return;
						}
						IL_1A1:
						awaiter2.GetResult();
						if (this.<>8__1.reserve.repair_id == null)
						{
							goto IL_24B;
						}
						awaiter3 = Bootstrapper.Container.Resolve<IWorkshopService>().UpdateRepairCostAndWarranty(this.<ctx>5__2, this.<>8__1.reserve.repair_id.Value).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num7 = 2;
							num = 2;
							this.<>1__state = num7;
							this.<>u__3 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PartsRequestModel.<RemoveItemFromRepair>d__3>(ref awaiter3, ref this);
							return;
						}
						IL_244:
						awaiter3.GetResult();
						IL_24B:;
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
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060017A5 RID: 6053 RVA: 0x0003E57C File Offset: 0x0003C77C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BCB RID: 3019
			public int <>1__state;

			// Token: 0x04000BCC RID: 3020
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000BCD RID: 3021
			public store_int_reserve reserve;

			// Token: 0x04000BCE RID: 3022
			private PartsRequestModel.<>c__DisplayClass3_0 <>8__1;

			// Token: 0x04000BCF RID: 3023
			private auseceEntities <ctx>5__2;

			// Token: 0x04000BD0 RID: 3024
			private TaskAwaiter<store_int_reserve> <>u__1;

			// Token: 0x04000BD1 RID: 3025
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04000BD2 RID: 3026
			private TaskAwaiter <>u__3;
		}

		// Token: 0x02000181 RID: 385
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060017A6 RID: 6054 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x04000BD3 RID: 3027
			public store_int_reserve reserve;
		}

		// Token: 0x02000182 RID: 386
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060017A7 RID: 6055 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04000BD4 RID: 3028
			public store_int_reserve reserve;
		}

		// Token: 0x02000183 RID: 387
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060017A8 RID: 6056 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04000BD5 RID: 3029
			public int repairId;
		}

		// Token: 0x02000184 RID: 388
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060017A9 RID: 6057 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04000BD6 RID: 3030
			public int requestId;
		}

		// Token: 0x02000185 RID: 389
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetHistory>d__11 : IAsyncStateMachine
		{
			// Token: 0x060017AA RID: 6058 RVA: 0x0003E598 File Offset: 0x0003C798
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<logs> result;
				try
				{
					PartsRequestModel.<>c__DisplayClass11_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PartsRequestModel.<>c__DisplayClass11_0();
						CS$<>8__locals1.requestId = this.requestId;
						this.<repo>5__2 = new GenericRepository<logs>();
					}
					try
					{
						TaskAwaiter<IEnumerable<logs>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((logs l) => l.part_request == (int?)CS$<>8__locals1.requestId, null, "users").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<logs>>, PartsRequestModel.<GetHistory>d__11>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<logs>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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

			// Token: 0x060017AB RID: 6059 RVA: 0x0003E724 File Offset: 0x0003C924
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BD7 RID: 3031
			public int <>1__state;

			// Token: 0x04000BD8 RID: 3032
			public AsyncTaskMethodBuilder<IEnumerable<logs>> <>t__builder;

			// Token: 0x04000BD9 RID: 3033
			public int requestId;

			// Token: 0x04000BDA RID: 3034
			private GenericRepository<logs> <repo>5__2;

			// Token: 0x04000BDB RID: 3035
			private TaskAwaiter<IEnumerable<logs>> <>u__1;
		}

		// Token: 0x02000186 RID: 390
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060017AC RID: 6060 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x04000BDC RID: 3036
			public int reserveId;
		}

		// Token: 0x02000187 RID: 391
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateSn>d__12 : IAsyncStateMachine
		{
			// Token: 0x060017AD RID: 6061 RVA: 0x0003E740 File Offset: 0x0003C940
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IAscResult result2;
				try
				{
					PartsRequestModel.<>c__DisplayClass12_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new PartsRequestModel.<>c__DisplayClass12_0();
						CS$<>8__locals1.reserveId = this.reserveId;
						this.<repo>5__2 = new GenericRepository<store_int_reserve>();
					}
					try
					{
						TaskAwaiter<store_int_reserve> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((store_int_reserve r) => r.id == CS$<>8__locals1.reserveId, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<store_int_reserve>, PartsRequestModel.<UpdateSn>d__12>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<store_int_reserve>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						store_int_reserve result = awaiter.GetResult();
						result.sn = this.sn;
						result2 = this.<repo>5__2.Update(result);
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
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
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x060017AE RID: 6062 RVA: 0x0003E8D8 File Offset: 0x0003CAD8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000BDD RID: 3037
			public int <>1__state;

			// Token: 0x04000BDE RID: 3038
			public AsyncTaskMethodBuilder<IAscResult> <>t__builder;

			// Token: 0x04000BDF RID: 3039
			public int reserveId;

			// Token: 0x04000BE0 RID: 3040
			public string sn;

			// Token: 0x04000BE1 RID: 3041
			private GenericRepository<store_int_reserve> <repo>5__2;

			// Token: 0x04000BE2 RID: 3042
			private TaskAwaiter<store_int_reserve> <>u__1;
		}
	}
}
