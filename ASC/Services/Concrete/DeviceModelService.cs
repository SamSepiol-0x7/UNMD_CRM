using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x02000713 RID: 1811
	public class DeviceModelService : IDeviceModelService
	{
		// Token: 0x06003A1F RID: 14879 RVA: 0x000DCB00 File Offset: 0x000DAD00
		public DeviceModelService(ILoggerService<DeviceModelService> logger)
		{
			this._logger = logger;
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x000DCB1C File Offset: 0x000DAD1C
		public Task<int> CreateDeviceModel(int deviceId, int deviceMakerId, string modelName)
		{
			DeviceModelService.<CreateDeviceModel>d__2 <CreateDeviceModel>d__;
			<CreateDeviceModel>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateDeviceModel>d__.<>4__this = this;
			<CreateDeviceModel>d__.deviceId = deviceId;
			<CreateDeviceModel>d__.deviceMakerId = deviceMakerId;
			<CreateDeviceModel>d__.modelName = modelName;
			<CreateDeviceModel>d__.<>1__state = -1;
			<CreateDeviceModel>d__.<>t__builder.Start<DeviceModelService.<CreateDeviceModel>d__2>(ref <CreateDeviceModel>d__);
			return <CreateDeviceModel>d__.<>t__builder.Task;
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x000DCB78 File Offset: 0x000DAD78
		public Task<device_models> GetDeviceModel(int deviceId, int deviceMakerId, string modelName)
		{
			DeviceModelService.<GetDeviceModel>d__3 <GetDeviceModel>d__;
			<GetDeviceModel>d__.<>t__builder = AsyncTaskMethodBuilder<device_models>.Create();
			<GetDeviceModel>d__.<>4__this = this;
			<GetDeviceModel>d__.deviceId = deviceId;
			<GetDeviceModel>d__.deviceMakerId = deviceMakerId;
			<GetDeviceModel>d__.modelName = modelName;
			<GetDeviceModel>d__.<>1__state = -1;
			<GetDeviceModel>d__.<>t__builder.Start<DeviceModelService.<GetDeviceModel>d__3>(ref <GetDeviceModel>d__);
			return <GetDeviceModel>d__.<>t__builder.Task;
		}

		// Token: 0x040024F0 RID: 9456
		private ILoggerService<DeviceModelService> _logger;

		// Token: 0x02000714 RID: 1812
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateDeviceModel>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003A22 RID: 14882 RVA: 0x000DCBD4 File Offset: 0x000DADD4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceModelService deviceModelService = this.<>4__this;
				int id;
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
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								this.<dm>5__3 = new device_models
								{
									name = this.modelName,
									device = new int?(this.deviceId),
									maker = this.deviceMakerId
								};
								this.<ctx>5__2.device_models.Add(this.<dm>5__3);
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DeviceModelService.<CreateDeviceModel>d__2>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
							id = this.<dm>5__3.id;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						deviceModelService._logger.Error(ex, ex.Message);
						throw;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x06003A23 RID: 14883 RVA: 0x000DCD6C File Offset: 0x000DAF6C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024F1 RID: 9457
			public int <>1__state;

			// Token: 0x040024F2 RID: 9458
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040024F3 RID: 9459
			public string modelName;

			// Token: 0x040024F4 RID: 9460
			public int deviceId;

			// Token: 0x040024F5 RID: 9461
			public int deviceMakerId;

			// Token: 0x040024F6 RID: 9462
			public DeviceModelService <>4__this;

			// Token: 0x040024F7 RID: 9463
			private auseceEntities <ctx>5__2;

			// Token: 0x040024F8 RID: 9464
			private device_models <dm>5__3;

			// Token: 0x040024F9 RID: 9465
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000715 RID: 1813
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003A24 RID: 14884 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040024FA RID: 9466
			public int deviceId;

			// Token: 0x040024FB RID: 9467
			public int deviceMakerId;

			// Token: 0x040024FC RID: 9468
			public string modelName;
		}

		// Token: 0x02000716 RID: 1814
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetDeviceModel>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003A25 RID: 14885 RVA: 0x000DCD88 File Offset: 0x000DAF88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				DeviceModelService deviceModelService = this.<>4__this;
				device_models result;
				try
				{
					DeviceModelService.<>c__DisplayClass3_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new DeviceModelService.<>c__DisplayClass3_0();
						CS$<>8__locals1.deviceId = this.deviceId;
						CS$<>8__locals1.deviceMakerId = this.deviceMakerId;
						CS$<>8__locals1.modelName = this.modelName;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<device_models> awaiter;
							if (num != 0)
							{
								awaiter = (from i in this.<ctx>5__2.device_models.AsNoTracking()
								where i.device == (int?)CS$<>8__locals1.deviceId
								where i.maker == CS$<>8__locals1.deviceMakerId
								where i.name == CS$<>8__locals1.modelName
								select i).FirstOrDefaultAsync<device_models>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<device_models>, DeviceModelService.<GetDeviceModel>d__3>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<device_models>);
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
					catch (Exception ex)
					{
						deviceModelService._logger.Error(ex, ex.Message);
						throw;
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

			// Token: 0x06003A26 RID: 14886 RVA: 0x000DD040 File Offset: 0x000DB240
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040024FD RID: 9469
			public int <>1__state;

			// Token: 0x040024FE RID: 9470
			public AsyncTaskMethodBuilder<device_models> <>t__builder;

			// Token: 0x040024FF RID: 9471
			public int deviceId;

			// Token: 0x04002500 RID: 9472
			public int deviceMakerId;

			// Token: 0x04002501 RID: 9473
			public string modelName;

			// Token: 0x04002502 RID: 9474
			public DeviceModelService <>4__this;

			// Token: 0x04002503 RID: 9475
			private auseceEntities <ctx>5__2;

			// Token: 0x04002504 RID: 9476
			private TaskAwaiter<device_models> <>u__1;
		}
	}
}
