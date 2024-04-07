using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using ASC.Common.Interfaces;
using ASC.DAL;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Services.Abstract;

namespace ASC.Services.Concrete
{
	// Token: 0x020006F3 RID: 1779
	public class CartridgeCardService : ICartridgeCardService
	{
		// Token: 0x060039BE RID: 14782 RVA: 0x000D8F58 File Offset: 0x000D7158
		public CartridgeCardService(ILoggerService<CartridgeCardService> loggerService, IContextFactory contextFactory)
		{
			this._loggerService = loggerService;
			this._contextFactory = contextFactory;
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x000D8F7C File Offset: 0x000D717C
		public Task<int> CreateCartridgeCard(CartridgeCard cartridgeCard)
		{
			CartridgeCardService.<CreateCartridgeCard>d__3 <CreateCartridgeCard>d__;
			<CreateCartridgeCard>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<CreateCartridgeCard>d__.<>4__this = this;
			<CreateCartridgeCard>d__.cartridgeCard = cartridgeCard;
			<CreateCartridgeCard>d__.<>1__state = -1;
			<CreateCartridgeCard>d__.<>t__builder.Start<CartridgeCardService.<CreateCartridgeCard>d__3>(ref <CreateCartridgeCard>d__);
			return <CreateCartridgeCard>d__.<>t__builder.Task;
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x000D8FC8 File Offset: 0x000D71C8
		public Task<bool> IsUnique(string name, int makerId)
		{
			CartridgeCardService.<IsUnique>d__4 <IsUnique>d__;
			<IsUnique>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<IsUnique>d__.<>4__this = this;
			<IsUnique>d__.name = name;
			<IsUnique>d__.makerId = makerId;
			<IsUnique>d__.<>1__state = -1;
			<IsUnique>d__.<>t__builder.Start<CartridgeCardService.<IsUnique>d__4>(ref <IsUnique>d__);
			return <IsUnique>d__.<>t__builder.Task;
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x000D901C File Offset: 0x000D721C
		public Task<ICartridgeCard> GetCartridgeCard(int cardId)
		{
			CartridgeCardService.<GetCartridgeCard>d__5 <GetCartridgeCard>d__;
			<GetCartridgeCard>d__.<>t__builder = AsyncTaskMethodBuilder<ICartridgeCard>.Create();
			<GetCartridgeCard>d__.<>4__this = this;
			<GetCartridgeCard>d__.cardId = cardId;
			<GetCartridgeCard>d__.<>1__state = -1;
			<GetCartridgeCard>d__.<>t__builder.Start<CartridgeCardService.<GetCartridgeCard>d__5>(ref <GetCartridgeCard>d__);
			return <GetCartridgeCard>d__.<>t__builder.Task;
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x000D9068 File Offset: 0x000D7268
		public List<CartridgeColors> GetColors()
		{
			return new List<CartridgeColors>
			{
				new CartridgeColors(0, Brushes.Black, "Black", Brushes.White),
				new CartridgeColors(1, Brushes.Cyan, "Cyan", Brushes.Black),
				new CartridgeColors(2, Brushes.Magenta, "Magenta", Brushes.Black),
				new CartridgeColors(3, Brushes.Yellow, "Yellow", Brushes.Black)
			};
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x000D90E8 File Offset: 0x000D72E8
		public List<KeyValuePair<int, string>> GetMaterialTypes()
		{
			return new List<KeyValuePair<int, string>>
			{
				new KeyValuePair<int, string>(0, Lang.t("Toner")),
				new KeyValuePair<int, string>(2, Lang.t("Chip")),
				new KeyValuePair<int, string>(3, Lang.t("CleaningBlade")),
				new KeyValuePair<int, string>(1, Lang.t("OPCDrum"))
			};
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x000D9154 File Offset: 0x000D7354
		public Task<IEnumerable<ICartridgeCard>> GetCards(int makerId = 0, bool showArchive = false, string name = "")
		{
			CartridgeCardService.<GetCards>d__8 <GetCards>d__;
			<GetCards>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<ICartridgeCard>>.Create();
			<GetCards>d__.<>4__this = this;
			<GetCards>d__.makerId = makerId;
			<GetCards>d__.showArchive = showArchive;
			<GetCards>d__.name = name;
			<GetCards>d__.<>1__state = -1;
			<GetCards>d__.<>t__builder.Start<CartridgeCardService.<GetCards>d__8>(ref <GetCards>d__);
			return <GetCards>d__.<>t__builder.Task;
		}

		// Token: 0x04002449 RID: 9289
		private readonly ILoggerService<CartridgeCardService> _loggerService;

		// Token: 0x0400244A RID: 9290
		private readonly IContextFactory _contextFactory;

		// Token: 0x020006F4 RID: 1780
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateCartridgeCard>d__3 : IAsyncStateMachine
		{
			// Token: 0x060039C5 RID: 14789 RVA: 0x000D91B0 File Offset: 0x000D73B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardService cartridgeCardService = this.<>4__this;
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
								this.<card>5__3 = new cartridge_cards
								{
									maker = this.cartridgeCard.MakerId,
									name = this.cartridgeCard.Name,
									created = Localization.GetServerUtcTime(this.<ctx>5__2),
									notes = this.cartridgeCard.Notes,
									full_weight = this.cartridgeCard.FullWeight,
									toner_weight = this.cartridgeCard.TonerWeight,
									resource = this.cartridgeCard.Resource,
									user = this.cartridgeCard.EmployeeId,
									color = this.cartridgeCard.Color,
									archive = false
								};
								if (this.cartridgeCard.Photo != null)
								{
									this.<card>5__3.images = new images
									{
										img = this.cartridgeCard.Photo,
										added = new DateTime?(Localization.GetServerUtcTime(this.<ctx>5__2)),
										uid = new int?(this.cartridgeCard.EmployeeId),
										preview = null
									};
								}
								this.<ctx>5__2.cartridge_cards.Add(this.<card>5__3);
								if (this.cartridgeCard.Materials.Any<IMaterial>())
								{
									IEnumerator<IMaterial> enumerator = this.cartridgeCard.Materials.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											IMaterial material = enumerator.Current;
											materials entity = new materials
											{
												type = material.Type,
												count = material.Count,
												articul = material.Articul,
												name = material.Name,
												card_id = this.<card>5__3.id,
												price = material.Price,
												works_price = material.WorksPrice
											};
											this.<ctx>5__2.materials.Add(entity);
										}
									}
									finally
									{
										if (num < 0 && enumerator != null)
										{
											enumerator.Dispose();
										}
									}
								}
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeCardService.<CreateCartridgeCard>d__3>(ref awaiter, ref this);
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
							id = this.<card>5__3.id;
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
						cartridgeCardService._loggerService.Error(ex, ex.Message);
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

			// Token: 0x060039C6 RID: 14790 RVA: 0x000D9500 File Offset: 0x000D7700
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400244B RID: 9291
			public int <>1__state;

			// Token: 0x0400244C RID: 9292
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400244D RID: 9293
			public CartridgeCard cartridgeCard;

			// Token: 0x0400244E RID: 9294
			public CartridgeCardService <>4__this;

			// Token: 0x0400244F RID: 9295
			private auseceEntities <ctx>5__2;

			// Token: 0x04002450 RID: 9296
			private cartridge_cards <card>5__3;

			// Token: 0x04002451 RID: 9297
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020006F5 RID: 1781
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x060039C7 RID: 14791 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x04002452 RID: 9298
			public int makerId;

			// Token: 0x04002453 RID: 9299
			public string name;
		}

		// Token: 0x020006F6 RID: 1782
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <IsUnique>d__4 : IAsyncStateMachine
		{
			// Token: 0x060039C8 RID: 14792 RVA: 0x000D951C File Offset: 0x000D771C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardService cartridgeCardService = this.<>4__this;
				bool result;
				try
				{
					CartridgeCardService.<>c__DisplayClass4_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CartridgeCardService.<>c__DisplayClass4_0();
						CS$<>8__locals1.makerId = this.makerId;
						CS$<>8__locals1.name = this.name;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<bool> awaiter;
							if (num != 0)
							{
								awaiter = (from i in this.<ctx>5__2.cartridge_cards
								where i.maker == CS$<>8__locals1.makerId
								where i.name == CS$<>8__locals1.name.Trim()
								select i).AnyAsync<cartridge_cards>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, CartridgeCardService.<IsUnique>d__4>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<bool>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = !awaiter.GetResult();
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
						cartridgeCardService._loggerService.Error(ex, ex.Message);
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

			// Token: 0x060039C9 RID: 14793 RVA: 0x000D976C File Offset: 0x000D796C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002454 RID: 9300
			public int <>1__state;

			// Token: 0x04002455 RID: 9301
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002456 RID: 9302
			public int makerId;

			// Token: 0x04002457 RID: 9303
			public string name;

			// Token: 0x04002458 RID: 9304
			public CartridgeCardService <>4__this;

			// Token: 0x04002459 RID: 9305
			private auseceEntities <ctx>5__2;

			// Token: 0x0400245A RID: 9306
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x020006F7 RID: 1783
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x060039CA RID: 14794 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0400245B RID: 9307
			public int cardId;
		}

		// Token: 0x020006F8 RID: 1784
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060039CB RID: 14795 RVA: 0x000D9788 File Offset: 0x000D7988
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060039CC RID: 14796 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060039CD RID: 14797 RVA: 0x000D97A0 File Offset: 0x000D79A0
			internal ICartridgeCard <GetCards>b__8_4(cartridge_cards c)
			{
				return c.ToCartridgeCard();
			}

			// Token: 0x0400245C RID: 9308
			public static readonly CartridgeCardService.<>c <>9 = new CartridgeCardService.<>c();

			// Token: 0x0400245D RID: 9309
			public static Func<cartridge_cards, ICartridgeCard> <>9__8_4;
		}

		// Token: 0x020006F9 RID: 1785
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCartridgeCard>d__5 : IAsyncStateMachine
		{
			// Token: 0x060039CE RID: 14798 RVA: 0x000D97B4 File Offset: 0x000D79B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardService cartridgeCardService = this.<>4__this;
				ICartridgeCard result;
				try
				{
					CartridgeCardService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CartridgeCardService.<>c__DisplayClass5_0();
						CS$<>8__locals1.cardId = this.cardId;
						this.<ctx>5__2 = cartridgeCardService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<cartridge_cards> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.cartridge_cards.AsNoTracking().Include((cartridge_cards i) => i.materials).SingleAsync((cartridge_cards i) => i.id == CS$<>8__locals1.cardId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<cartridge_cards>, CartridgeCardService.<GetCartridgeCard>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<cartridge_cards>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().ToCartridgeCard();
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

			// Token: 0x060039CF RID: 14799 RVA: 0x000D9988 File Offset: 0x000D7B88
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400245E RID: 9310
			public int <>1__state;

			// Token: 0x0400245F RID: 9311
			public AsyncTaskMethodBuilder<ICartridgeCard> <>t__builder;

			// Token: 0x04002460 RID: 9312
			public int cardId;

			// Token: 0x04002461 RID: 9313
			public CartridgeCardService <>4__this;

			// Token: 0x04002462 RID: 9314
			private auseceEntities <ctx>5__2;

			// Token: 0x04002463 RID: 9315
			private TaskAwaiter<cartridge_cards> <>u__1;
		}

		// Token: 0x020006FA RID: 1786
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060039D0 RID: 14800 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04002464 RID: 9316
			public int makerId;

			// Token: 0x04002465 RID: 9317
			public string name;
		}

		// Token: 0x020006FB RID: 1787
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCards>d__8 : IAsyncStateMachine
		{
			// Token: 0x060039D1 RID: 14801 RVA: 0x000D99A4 File Offset: 0x000D7BA4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCardService cartridgeCardService = this.<>4__this;
				IEnumerable<ICartridgeCard> result;
				try
				{
					CartridgeCardService.<>c__DisplayClass8_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new CartridgeCardService.<>c__DisplayClass8_0();
						CS$<>8__locals1.makerId = this.makerId;
						CS$<>8__locals1.name = this.name;
						this.<ctx>5__2 = cartridgeCardService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<List<cartridge_cards>> awaiter;
						if (num != 0)
						{
							IQueryable<cartridge_cards> source = this.<ctx>5__2.cartridge_cards.AsNoTracking().Include((cartridge_cards i) => i.images).AsQueryable<cartridge_cards>();
							if (CS$<>8__locals1.makerId > 0)
							{
								source = from i in source
								where i.maker == CS$<>8__locals1.makerId
								select i;
							}
							if (!this.showArchive)
							{
								source = from i in source
								where i.archive == false
								select i;
							}
							if (!string.IsNullOrEmpty(CS$<>8__locals1.name))
							{
								source = from i in source
								where i.name.Contains(CS$<>8__locals1.name)
								select i;
							}
							awaiter = (from i in source
							orderby i.name
							select i).ToListAsync<cartridge_cards>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<cartridge_cards>>, CartridgeCardService.<GetCards>d__8>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<cartridge_cards>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult().Select(new Func<cartridge_cards, ICartridgeCard>(CartridgeCardService.<>c.<>9.<GetCards>b__8_4)).ToList<ICartridgeCard>();
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

			// Token: 0x060039D2 RID: 14802 RVA: 0x000D9D00 File Offset: 0x000D7F00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002466 RID: 9318
			public int <>1__state;

			// Token: 0x04002467 RID: 9319
			public AsyncTaskMethodBuilder<IEnumerable<ICartridgeCard>> <>t__builder;

			// Token: 0x04002468 RID: 9320
			public int makerId;

			// Token: 0x04002469 RID: 9321
			public string name;

			// Token: 0x0400246A RID: 9322
			public CartridgeCardService <>4__this;

			// Token: 0x0400246B RID: 9323
			public bool showArchive;

			// Token: 0x0400246C RID: 9324
			private auseceEntities <ctx>5__2;

			// Token: 0x0400246D RID: 9325
			private TaskAwaiter<List<cartridge_cards>> <>u__1;
		}
	}
}
