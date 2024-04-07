using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ASC.Common.Interfaces;
using ASC.Extensions;
using ASC.Objects;
using ASC.Objects.Converters;

namespace ASC.Models
{
	// Token: 0x02000A0C RID: 2572
	public class MediaModel : UsersModel
	{
		// Token: 0x06004C30 RID: 19504 RVA: 0x00138F08 File Offset: 0x00137108
		public static string GetAppDir()
		{
			return new FileInfo(Assembly.GetEntryAssembly().Location).DirectoryName;
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00138F2C File Offset: 0x0013712C
		public static string GetSoundDir()
		{
			return Path.Combine(MediaModel.GetAppDir(), "Sound");
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00138F48 File Offset: 0x00137148
		public static byte[] MakePreview(byte[] input)
		{
			byte[] result;
			try
			{
				BitmapImage bitmapImage = ConvertersStack.ByteArrayToImage(input);
				double num = 190.0 / (double)bitmapImage.PixelWidth;
				ScaleTransform newTransform = new ScaleTransform(num, num);
				result = ConvertersStack.ImageToByteArray(new WriteableBitmap(new TransformedBitmap(bitmapImage, newTransform)).ToBitmapImage());
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Make preview image fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00138FB4 File Offset: 0x001371B4
		public static Task<List<AscImage>> GetThumbs(Product item)
		{
			Task<List<AscImage>> result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				ParameterExpression parameterExpression;
				result = (from i in auseceEntities.images
				where i.item_id == (int?)item.Id
				select i).Select(Expression.Lambda<Func<images, AscImage>>(Expression.MemberInit(Expression.New(typeof(AscImage)), new MemberBinding[]
				{
					Expression.Bind(methodof(AscImage.set_Created(DateTime?)), Expression.Property(parameterExpression, methodof(images.get_added()))),
					Expression.Bind(methodof(AscImage.set_Id(int)), Expression.Property(parameterExpression, methodof(images.get_id()))),
					Expression.Bind(methodof(AscImage.set_Image(byte[])), Expression.Property(parameterExpression, methodof(images.get_preview())))
				}), new ParameterExpression[]
				{
					parameterExpression
				})).ToListAsync<AscImage>();
			}
			return result;
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00139158 File Offset: 0x00137358
		public static Task<List<IImage>> GetImages(Product item)
		{
			MediaModel.<GetImages>d__4 <GetImages>d__;
			<GetImages>d__.<>t__builder = AsyncTaskMethodBuilder<List<IImage>>.Create();
			<GetImages>d__.item = item;
			<GetImages>d__.<>1__state = -1;
			<GetImages>d__.<>t__builder.Start<MediaModel.<GetImages>d__4>(ref <GetImages>d__);
			return <GetImages>d__.<>t__builder.Task;
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x0013919C File Offset: 0x0013739C
		public static Task<List<IImage>> GetImages(int itemId)
		{
			MediaModel.<GetImages>d__5 <GetImages>d__;
			<GetImages>d__.<>t__builder = AsyncTaskMethodBuilder<List<IImage>>.Create();
			<GetImages>d__.itemId = itemId;
			<GetImages>d__.<>1__state = -1;
			<GetImages>d__.<>t__builder.Start<MediaModel.<GetImages>d__5>(ref <GetImages>d__);
			return <GetImages>d__.<>t__builder.Task;
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x001391E0 File Offset: 0x001373E0
		public static Task<List<IImage>> GetImages(List<int> imageIds)
		{
			MediaModel.<GetImages>d__6 <GetImages>d__;
			<GetImages>d__.<>t__builder = AsyncTaskMethodBuilder<List<IImage>>.Create();
			<GetImages>d__.imageIds = imageIds;
			<GetImages>d__.<>1__state = -1;
			<GetImages>d__.<>t__builder.Start<MediaModel.<GetImages>d__6>(ref <GetImages>d__);
			return <GetImages>d__.<>t__builder.Task;
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00139224 File Offset: 0x00137424
		public static IImage GetImage(int imageId)
		{
			IImage result;
			using (GenericRepository<images> genericRepository = new GenericRepository<images>())
			{
				result = genericRepository.GetFirstOrDefault((images i) => i.id == imageId, "").BackToImages();
			}
			return result;
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x001392D0 File Offset: 0x001374D0
		public static List<IImage> GetImages(store_items item)
		{
			return MediaModel.GetImages(item.ToStoreItem()).Result;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x001392F0 File Offset: 0x001374F0
		public static int CreateImage(auseceEntities ctx, images img)
		{
			img.uid = new int?(OfflineData.Instance.Employee.Id);
			img.added = new DateTime?(DateTime.UtcNow);
			ctx.images.Add(img);
			ctx.SaveChanges();
			return img.id;
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00139344 File Offset: 0x00137544
		public static int CreateImage(auseceEntities ctx, IImage image)
		{
			images images = image.ToImages();
			images.preview = MediaModel.MakePreview(image.Image);
			return MediaModel.CreateImage(ctx, images);
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00139370 File Offset: 0x00137570
		private static void UpdateImage(auseceEntities ctx, IImage image)
		{
			images images = ctx.images.Find(new object[]
			{
				image.Id
			});
			images.img = image.Image;
			images.preview = MediaModel.MakePreview(image.Image);
			ctx.SaveChanges();
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x001393C0 File Offset: 0x001375C0
		private static void DeleteImage(auseceEntities ctx, IImage image)
		{
			images entity = ctx.images.Find(new object[]
			{
				image.Id
			});
			ctx.images.Remove(entity);
			ctx.SaveChanges();
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x00139404 File Offset: 0x00137604
		public static IAscResult SaveChanges(IImage image)
		{
			return MediaModel.SaveChanges(new List<IImage>
			{
				image
			});
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00139424 File Offset: 0x00137624
		public static IAscResult SaveChanges(IEnumerable<IImage> images)
		{
			Result result = new Result();
			IAscResult result2;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					foreach (IImage image in images)
					{
						if (image.Id > 0 && image.Image != null)
						{
							MediaModel.UpdateImage(auseceEntities, image);
						}
						if (image.Id > 0 && image.Image == null)
						{
							MediaModel.DeleteImage(auseceEntities, image);
							image.Id = 0;
						}
						else if (image.Id == 0 && image.Image != null)
						{
							image.Id = MediaModel.CreateImage(auseceEntities, image);
						}
					}
				}
				goto IL_C0;
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result.Message = ex.Message;
				result2 = result;
			}
			return result2;
			IL_C0:
			result.SetSuccess();
			return result;
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x00139520 File Offset: 0x00137720
		public MediaModel()
		{
		}

		// Token: 0x02000A0D RID: 2573
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004C40 RID: 19520 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0400314B RID: 12619
			public Product item;
		}

		// Token: 0x02000A0E RID: 2574
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C41 RID: 19521 RVA: 0x00139534 File Offset: 0x00137734
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004C42 RID: 19522 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004C43 RID: 19523 RVA: 0x0013954C File Offset: 0x0013774C
			internal IImage <GetImages>b__4_0(images i)
			{
				return i.BackToImages();
			}

			// Token: 0x06004C44 RID: 19524 RVA: 0x0013954C File Offset: 0x0013774C
			internal IImage <GetImages>b__5_0(images i)
			{
				return i.BackToImages();
			}

			// Token: 0x06004C45 RID: 19525 RVA: 0x0013954C File Offset: 0x0013774C
			internal IImage <GetImages>b__6_0(images i)
			{
				return i.BackToImages();
			}

			// Token: 0x0400314C RID: 12620
			public static readonly MediaModel.<>c <>9 = new MediaModel.<>c();

			// Token: 0x0400314D RID: 12621
			public static Func<images, IImage> <>9__4_0;

			// Token: 0x0400314E RID: 12622
			public static Func<images, IImage> <>9__5_0;

			// Token: 0x0400314F RID: 12623
			public static Func<images, IImage> <>9__6_0;
		}

		// Token: 0x02000A0F RID: 2575
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004C46 RID: 19526 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04003150 RID: 12624
			public Product item;
		}

		// Token: 0x02000A10 RID: 2576
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImages>d__4 : IAsyncStateMachine
		{
			// Token: 0x06004C47 RID: 19527 RVA: 0x00139560 File Offset: 0x00137760
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<IImage> result;
				try
				{
					MediaModel.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new MediaModel.<>c__DisplayClass4_0();
						CS$<>8__locals1.item = this.item;
						this.<repo>5__2 = new GenericRepository<images>();
					}
					try
					{
						ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							awaiter = this.<repo>5__2.GetAllAsync((images i) => i.item_id == (int?)CS$<>8__locals1.item.Id, null, "").ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter, MediaModel.<GetImages>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<images, IImage>(MediaModel.<>c.<>9.<GetImages>b__4_0)).ToList<IImage>();
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

			// Token: 0x06004C48 RID: 19528 RVA: 0x00139740 File Offset: 0x00137940
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003151 RID: 12625
			public int <>1__state;

			// Token: 0x04003152 RID: 12626
			public AsyncTaskMethodBuilder<List<IImage>> <>t__builder;

			// Token: 0x04003153 RID: 12627
			public Product item;

			// Token: 0x04003154 RID: 12628
			private GenericRepository<images> <repo>5__2;

			// Token: 0x04003155 RID: 12629
			private ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000A11 RID: 2577
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004C49 RID: 19529 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x04003156 RID: 12630
			public int itemId;
		}

		// Token: 0x02000A12 RID: 2578
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImages>d__5 : IAsyncStateMachine
		{
			// Token: 0x06004C4A RID: 19530 RVA: 0x0013975C File Offset: 0x0013795C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<IImage> result;
				try
				{
					MediaModel.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new MediaModel.<>c__DisplayClass5_0();
						CS$<>8__locals1.itemId = this.itemId;
						this.<repo>5__2 = new GenericRepository<images>();
					}
					try
					{
						ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							awaiter = this.<repo>5__2.GetAllAsync((images i) => i.item_id == (int?)CS$<>8__locals1.itemId, null, "").ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter, MediaModel.<GetImages>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<images, IImage>(MediaModel.<>c.<>9.<GetImages>b__5_0)).ToList<IImage>();
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

			// Token: 0x06004C4B RID: 19531 RVA: 0x00139928 File Offset: 0x00137B28
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003157 RID: 12631
			public int <>1__state;

			// Token: 0x04003158 RID: 12632
			public AsyncTaskMethodBuilder<List<IImage>> <>t__builder;

			// Token: 0x04003159 RID: 12633
			public int itemId;

			// Token: 0x0400315A RID: 12634
			private GenericRepository<images> <repo>5__2;

			// Token: 0x0400315B RID: 12635
			private ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000A13 RID: 2579
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06004C4C RID: 19532 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0400315C RID: 12636
			public List<int> imageIds;
		}

		// Token: 0x02000A14 RID: 2580
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetImages>d__6 : IAsyncStateMachine
		{
			// Token: 0x06004C4D RID: 19533 RVA: 0x00139944 File Offset: 0x00137B44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<IImage> result;
				try
				{
					MediaModel.<>c__DisplayClass6_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new MediaModel.<>c__DisplayClass6_0();
						CS$<>8__locals1.imageIds = this.imageIds;
						this.<repo>5__2 = new GenericRepository<images>();
					}
					try
					{
						ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							this.<repo>5__2.AsNoTracking();
							awaiter = this.<repo>5__2.GetAllAsync((images i) => CS$<>8__locals1.imageIds.Contains(i.id), null, "").ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter, MediaModel.<GetImages>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<images, IImage>(MediaModel.<>c.<>9.<GetImages>b__6_0)).ToList<IImage>();
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

			// Token: 0x06004C4E RID: 19534 RVA: 0x00139B1C File Offset: 0x00137D1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400315D RID: 12637
			public int <>1__state;

			// Token: 0x0400315E RID: 12638
			public AsyncTaskMethodBuilder<List<IImage>> <>t__builder;

			// Token: 0x0400315F RID: 12639
			public List<int> imageIds;

			// Token: 0x04003160 RID: 12640
			private GenericRepository<images> <repo>5__2;

			// Token: 0x04003161 RID: 12641
			private ConfiguredTaskAwaitable<IEnumerable<images>>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000A15 RID: 2581
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004C4F RID: 19535 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04003162 RID: 12642
			public int imageId;
		}
	}
}
