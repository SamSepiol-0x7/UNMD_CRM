using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Interfaces;
using ASC.Models;

namespace ASC.Services
{
	// Token: 0x0200067C RID: 1660
	public class ImageService : IImageService
	{
		// Token: 0x0600389A RID: 14490 RVA: 0x000CE11C File Offset: 0x000CC31C
		public Task<List<images>> GetImages(List<int> imageIds)
		{
			ImageService.<GetImages>d__0 <GetImages>d__;
			<GetImages>d__.<>t__builder = AsyncTaskMethodBuilder<List<images>>.Create();
			<GetImages>d__.imageIds = imageIds;
			<GetImages>d__.<>1__state = -1;
			<GetImages>d__.<>t__builder.Start<ImageService.<GetImages>d__0>(ref <GetImages>d__);
			return <GetImages>d__.<>t__builder.Task;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x000CE160 File Offset: 0x000CC360
		public Task<images> GetImage(int imageId)
		{
			ImageService.<GetImage>d__1 <GetImage>d__;
			<GetImage>d__.<>t__builder = AsyncTaskMethodBuilder<images>.Create();
			<GetImage>d__.imageId = imageId;
			<GetImage>d__.<>1__state = -1;
			<GetImage>d__.<>t__builder.Start<ImageService.<GetImage>d__1>(ref <GetImage>d__);
			return <GetImage>d__.<>t__builder.Task;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x000CE1A4 File Offset: 0x000CC3A4
		public void DeleteImages(List<int> imageIds)
		{
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				foreach (int id in imageIds)
				{
					images entity = new images
					{
						id = id
					};
					auseceEntities.images.Attach(entity);
					auseceEntities.images.Remove(entity);
				}
				auseceEntities.SaveChanges();
			}
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x000CE23C File Offset: 0x000CC43C
		public void DeleteImage(int imageId)
		{
			this.DeleteImages(new List<int>
			{
				imageId
			});
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x000CE25C File Offset: 0x000CC45C
		public Task<int> CreateImageAsync(images image)
		{
			ImageService.<CreateImageAsync>d__4 <CreateImageAsync>d__;
			<CreateImageAsync>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateImageAsync>d__.image = image;
			<CreateImageAsync>d__.<>1__state = -1;
			<CreateImageAsync>d__.<>t__builder.Start<ImageService.<CreateImageAsync>d__4>(ref <CreateImageAsync>d__);
			return <CreateImageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x000CE2A0 File Offset: 0x000CC4A0
		public Task<List<int>> CreateImages(List<images> images)
		{
			ImageService.<CreateImages>d__5 <CreateImages>d__;
			<CreateImages>d__.<>t__builder = AsyncTaskMethodBuilder<List<int>>.Create();
			<CreateImages>d__.images = images;
			<CreateImages>d__.<>1__state = -1;
			<CreateImages>d__.<>t__builder.Start<ImageService.<CreateImages>d__5>(ref <CreateImages>d__);
			return <CreateImages>d__.<>t__builder.Task;
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000CE2E4 File Offset: 0x000CC4E4
		public Task UpdateImageAsync(images i)
		{
			ImageService.<UpdateImageAsync>d__6 <UpdateImageAsync>d__;
			<UpdateImageAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateImageAsync>d__.i = i;
			<UpdateImageAsync>d__.<>1__state = -1;
			<UpdateImageAsync>d__.<>t__builder.Start<ImageService.<UpdateImageAsync>d__6>(ref <UpdateImageAsync>d__);
			return <UpdateImageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x000046B4 File Offset: 0x000028B4
		public ImageService()
		{
		}

		// Token: 0x0200067D RID: 1661
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x060038A2 RID: 14498 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x04002268 RID: 8808
			public List<int> imageIds;
		}

		// Token: 0x0200067E RID: 1662
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImages>d__0 : IAsyncStateMachine
		{
			// Token: 0x060038A3 RID: 14499 RVA: 0x000CE328 File Offset: 0x000CC528
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<images> result;
				try
				{
					ImageService.<>c__DisplayClass0_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ImageService.<>c__DisplayClass0_0();
						CS$<>8__locals1.imageIds = this.imageIds;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.images.AsNoTracking()
							where CS$<>8__locals1.imageIds.Contains(i.id)
							select i).ToListAsync<images>().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter, ImageService.<GetImages>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter);
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

			// Token: 0x060038A4 RID: 14500 RVA: 0x000CE4D4 File Offset: 0x000CC6D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002269 RID: 8809
			public int <>1__state;

			// Token: 0x0400226A RID: 8810
			public AsyncTaskMethodBuilder<List<images>> <>t__builder;

			// Token: 0x0400226B RID: 8811
			public List<int> imageIds;

			// Token: 0x0400226C RID: 8812
			private auseceEntities <ctx>5__2;

			// Token: 0x0400226D RID: 8813
			private ConfiguredTaskAwaitable<List<images>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200067F RID: 1663
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x060038A5 RID: 14501 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x0400226E RID: 8814
			public int imageId;
		}

		// Token: 0x02000680 RID: 1664
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImage>d__1 : IAsyncStateMachine
		{
			// Token: 0x060038A6 RID: 14502 RVA: 0x000CE4F0 File Offset: 0x000CC6F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				images result;
				try
				{
					ImageService.<>c__DisplayClass1_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ImageService.<>c__DisplayClass1_0();
						CS$<>8__locals1.imageId = this.imageId;
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						TaskAwaiter<images> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.images.AsNoTracking().FirstOrDefaultAsync((images i) => i.id == CS$<>8__locals1.imageId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<images>, ImageService.<GetImage>d__1>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<images>);
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

			// Token: 0x060038A7 RID: 14503 RVA: 0x000CE670 File Offset: 0x000CC870
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400226F RID: 8815
			public int <>1__state;

			// Token: 0x04002270 RID: 8816
			public AsyncTaskMethodBuilder<images> <>t__builder;

			// Token: 0x04002271 RID: 8817
			public int imageId;

			// Token: 0x04002272 RID: 8818
			private auseceEntities <ctx>5__2;

			// Token: 0x04002273 RID: 8819
			private TaskAwaiter<images> <>u__1;
		}

		// Token: 0x02000681 RID: 1665
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateImageAsync>d__4 : IAsyncStateMachine
		{
			// Token: 0x060038A8 RID: 14504 RVA: 0x000CE68C File Offset: 0x000CC88C
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
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.image.preview = MediaModel.MakePreview(this.image.img);
							this.<ctx>5__2.images.Add(this.image);
							awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, ImageService.<CreateImageAsync>d__4>(ref awaiter, ref this);
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
						id = this.image.id;
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

			// Token: 0x060038A9 RID: 14505 RVA: 0x000CE7BC File Offset: 0x000CC9BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002274 RID: 8820
			public int <>1__state;

			// Token: 0x04002275 RID: 8821
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002276 RID: 8822
			public images image;

			// Token: 0x04002277 RID: 8823
			private auseceEntities <ctx>5__2;

			// Token: 0x04002278 RID: 8824
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000682 RID: 1666
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateImages>d__5 : IAsyncStateMachine
		{
			// Token: 0x060038AA RID: 14506 RVA: 0x000CE7D8 File Offset: 0x000CC9D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<int> result;
				try
				{
					if (num != 0)
					{
						this.<result>5__2 = new List<int>();
						this.<ctx>5__3 = new auseceEntities(true);
					}
					try
					{
						if (num != 0)
						{
							this.<>7__wrap3 = this.images.GetEnumerator();
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num == 0)
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_C5;
							}
							IL_58:
							if (!this.<>7__wrap3.MoveNext())
							{
								goto IL_127;
							}
							this.<image>5__5 = this.<>7__wrap3.Current;
							this.<image>5__5.preview = MediaModel.MakePreview(this.<image>5__5.img);
							this.<ctx>5__3.images.Add(this.<image>5__5);
							awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, ImageService.<CreateImages>d__5>(ref awaiter, ref this);
								return;
							}
							IL_C5:
							awaiter.GetResult();
							this.<result>5__2.Add(this.<image>5__5.id);
							this.<image>5__5 = null;
							goto IL_58;
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>7__wrap3).Dispose();
							}
						}
						IL_127:
						this.<>7__wrap3 = default(List<images>.Enumerator);
						result = this.<result>5__2;
					}
					finally
					{
						if (num < 0 && this.<ctx>5__3 != null)
						{
							((IDisposable)this.<ctx>5__3).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x060038AB RID: 14507 RVA: 0x000CE9C0 File Offset: 0x000CCBC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002279 RID: 8825
			public int <>1__state;

			// Token: 0x0400227A RID: 8826
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			// Token: 0x0400227B RID: 8827
			public List<images> images;

			// Token: 0x0400227C RID: 8828
			private List<int> <result>5__2;

			// Token: 0x0400227D RID: 8829
			private auseceEntities <ctx>5__3;

			// Token: 0x0400227E RID: 8830
			private List<images>.Enumerator <>7__wrap3;

			// Token: 0x0400227F RID: 8831
			private images <image>5__5;

			// Token: 0x04002280 RID: 8832
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000683 RID: 1667
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateImageAsync>d__6 : IAsyncStateMachine
		{
			// Token: 0x060038AC RID: 14508 RVA: 0x000CE9DC File Offset: 0x000CCBDC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = new auseceEntities(true);
					}
					try
					{
						ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							images images = new images
							{
								id = this.i.id
							};
							this.<ctx>5__2.images.Attach(images);
							images.img = this.i.img;
							images.preview = MediaModel.MakePreview(this.i.img);
							awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, ImageService.<UpdateImageAsync>d__6>(ref awaiter, ref this);
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

			// Token: 0x060038AD RID: 14509 RVA: 0x000CEB28 File Offset: 0x000CCD28
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002281 RID: 8833
			public int <>1__state;

			// Token: 0x04002282 RID: 8834
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002283 RID: 8835
			public images i;

			// Token: 0x04002284 RID: 8836
			private auseceEntities <ctx>5__2;

			// Token: 0x04002285 RID: 8837
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
