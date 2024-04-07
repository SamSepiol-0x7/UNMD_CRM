using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ASC.Services
{
	// Token: 0x020005F9 RID: 1529
	public class VendorService : IVendorService
	{
		// Token: 0x06003764 RID: 14180 RVA: 0x000C01B8 File Offset: 0x000BE3B8
		public Task<List<vendors>> GetVendors()
		{
			Task<List<vendors>> result;
			using (auseceEntities auseceEntities = new auseceEntities(false))
			{
				result = (from i in auseceEntities.vendors.AsNoTracking()
				where !i.archive
				select i).ToListAsync<vendors>();
			}
			return result;
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x000C0240 File Offset: 0x000BE440
		public Task<List<vendors>> GetAllVendors()
		{
			Task<List<vendors>> result;
			using (auseceEntities auseceEntities = new auseceEntities(false))
			{
				result = auseceEntities.vendors.AsNoTracking().ToListAsync<vendors>();
			}
			return result;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x000C0284 File Offset: 0x000BE484
		public Task<vendors> GetVendor(int vendorId)
		{
			Task<vendors> result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				result = auseceEntities.vendors.AsNoTracking().FirstOrDefaultAsync((vendors i) => i.id == vendorId);
			}
			return result;
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x000C0330 File Offset: 0x000BE530
		public Task<int> CreateVendor(vendors data)
		{
			VendorService.<CreateVendor>d__3 <CreateVendor>d__;
			<CreateVendor>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateVendor>d__.data = data;
			<CreateVendor>d__.<>1__state = -1;
			<CreateVendor>d__.<>t__builder.Start<VendorService.<CreateVendor>d__3>(ref <CreateVendor>d__);
			return <CreateVendor>d__.<>t__builder.Task;
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x000C0374 File Offset: 0x000BE574
		public Task UpdateVendor(vendors data)
		{
			Task result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				vendors vendors = auseceEntities.vendors.Find(new object[]
				{
					data.id
				});
				auseceEntities.Entry<vendors>(vendors).CurrentValues.SetValues(data);
				vendors.updated_at = new DateTime?(Localization.GetServerUtcTime(auseceEntities));
				result = auseceEntities.SaveChangesAsync();
			}
			return result;
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x000046B4 File Offset: 0x000028B4
		public VendorService()
		{
		}

		// Token: 0x020005FA RID: 1530
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600376A RID: 14186 RVA: 0x000C03F0 File Offset: 0x000BE5F0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600376B RID: 14187 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0400204D RID: 8269
			public static readonly VendorService.<>c <>9 = new VendorService.<>c();
		}

		// Token: 0x020005FB RID: 1531
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x0600376C RID: 14188 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0400204E RID: 8270
			public int vendorId;
		}

		// Token: 0x020005FC RID: 1532
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateVendor>d__3 : IAsyncStateMachine
		{
			// Token: 0x0600376D RID: 14189 RVA: 0x000C0408 File Offset: 0x000BE608
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int id;
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
							this.<item>5__3 = this.<ctx>5__2.vendors.Add(this.data);
							this.data.created_at = Localization.GetServerUtcTime(this.<ctx>5__2);
							awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, VendorService.<CreateVendor>d__3>(ref awaiter, ref this);
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
						id = this.<item>5__3.id;
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
				this.<>t__builder.SetResult(id);
			}

			// Token: 0x0600376E RID: 14190 RVA: 0x000C052C File Offset: 0x000BE72C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400204F RID: 8271
			public int <>1__state;

			// Token: 0x04002050 RID: 8272
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002051 RID: 8273
			public vendors data;

			// Token: 0x04002052 RID: 8274
			private auseceEntities <ctx>5__2;

			// Token: 0x04002053 RID: 8275
			private vendors <item>5__3;

			// Token: 0x04002054 RID: 8276
			private TaskAwaiter<int> <>u__1;
		}
	}
}
