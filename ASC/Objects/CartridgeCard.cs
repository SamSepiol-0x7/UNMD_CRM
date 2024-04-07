using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x020008BB RID: 2235
	public class CartridgeCard : BindableBase, ICheckFields, ICartridgeCard
	{
		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06004435 RID: 17461 RVA: 0x0010BDDC File Offset: 0x00109FDC
		// (set) Token: 0x06004436 RID: 17462 RVA: 0x0010BDF0 File Offset: 0x00109FF0
		public int CardId
		{
			[CompilerGenerated]
			get
			{
				return this.<CardId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CardId>k__BackingField == value)
				{
					return;
				}
				this.<CardId>k__BackingField = value;
				this.RaisePropertyChanged("CardId");
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x0010BE1C File Offset: 0x0010A01C
		// (set) Token: 0x06004438 RID: 17464 RVA: 0x0010BE30 File Offset: 0x0010A030
		public int MakerId
		{
			[CompilerGenerated]
			get
			{
				return this.<MakerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MakerId>k__BackingField == value)
				{
					return;
				}
				this.<MakerId>k__BackingField = value;
				this.RaisePropertyChanged("MakerId");
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x0010BE5C File Offset: 0x0010A05C
		// (set) Token: 0x0600443A RID: 17466 RVA: 0x0010BE70 File Offset: 0x0010A070
		public string MakerName
		{
			[CompilerGenerated]
			get
			{
				return this.<MakerName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<MakerName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MakerName>k__BackingField = value;
				this.RaisePropertyChanged("MakerName");
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x0010BEA0 File Offset: 0x0010A0A0
		// (set) Token: 0x0600443C RID: 17468 RVA: 0x0010BEB4 File Offset: 0x0010A0B4
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
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x0010BEE4 File Offset: 0x0010A0E4
		// (set) Token: 0x0600443E RID: 17470 RVA: 0x0010BEF8 File Offset: 0x0010A0F8
		public DateTime Created
		{
			[CompilerGenerated]
			get
			{
				return this.<Created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Created>k__BackingField, value))
				{
					return;
				}
				this.<Created>k__BackingField = value;
				this.RaisePropertyChanged("Created");
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x0010BF28 File Offset: 0x0010A128
		// (set) Token: 0x06004440 RID: 17472 RVA: 0x0010BF3C File Offset: 0x0010A13C
		public string Notes
		{
			[CompilerGenerated]
			get
			{
				return this.<Notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Notes>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = 1188894259;
				IL_14:
				switch ((num ^ 459793064) % 4)
				{
				case 0:
					goto IL_0F;
				case 1:
					IL_33:
					this.<Notes>k__BackingField = value;
					this.RaisePropertyChanged("Notes");
					num = 1070068286;
					goto IL_14;
				case 3:
					return;
				}
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x0010BF98 File Offset: 0x0010A198
		// (set) Token: 0x06004442 RID: 17474 RVA: 0x0010BFAC File Offset: 0x0010A1AC
		public double FullWeight
		{
			[CompilerGenerated]
			get
			{
				return this.<FullWeight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FullWeight>k__BackingField == value)
				{
					return;
				}
				this.<FullWeight>k__BackingField = value;
				this.RaisePropertyChanged("FullWeight");
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x0010BFDC File Offset: 0x0010A1DC
		// (set) Token: 0x06004444 RID: 17476 RVA: 0x0010BFF0 File Offset: 0x0010A1F0
		public double TonerWeight
		{
			[CompilerGenerated]
			get
			{
				return this.<TonerWeight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.<TonerWeight>k__BackingField == value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1275139712;
				IL_13:
				switch ((num ^ 2060713150) % 4)
				{
				case 1:
					IL_32:
					num = 3963110;
					goto IL_13;
				case 2:
					return;
				case 3:
					goto IL_0E;
				}
				this.<TonerWeight>k__BackingField = value;
				this.RaisePropertyChanged("TonerWeight");
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x0010C04C File Offset: 0x0010A24C
		// (set) Token: 0x06004446 RID: 17478 RVA: 0x0010C060 File Offset: 0x0010A260
		public int Color
		{
			[CompilerGenerated]
			get
			{
				return this.<Color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Color>k__BackingField == value)
				{
					return;
				}
				this.<Color>k__BackingField = value;
				this.RaisePropertyChanged("Color");
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x0010C08C File Offset: 0x0010A28C
		// (set) Token: 0x06004448 RID: 17480 RVA: 0x0010C0A0 File Offset: 0x0010A2A0
		public int Resource
		{
			[CompilerGenerated]
			get
			{
				return this.<Resource>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Resource>k__BackingField == value)
				{
					return;
				}
				this.<Resource>k__BackingField = value;
				this.RaisePropertyChanged("Resource");
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x0010C0CC File Offset: 0x0010A2CC
		// (set) Token: 0x0600444A RID: 17482 RVA: 0x0010C0E0 File Offset: 0x0010A2E0
		public int EmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<EmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EmployeeId>k__BackingField == value)
				{
					return;
				}
				this.<EmployeeId>k__BackingField = value;
				this.RaisePropertyChanged("EmployeeId");
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x0010C10C File Offset: 0x0010A30C
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x0010C120 File Offset: 0x0010A320
		public byte[] Photo
		{
			[CompilerGenerated]
			get
			{
				return this.<Photo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Photo>k__BackingField, value))
				{
					return;
				}
				this.<Photo>k__BackingField = value;
				this.RaisePropertyChanged("Photo");
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x0010C150 File Offset: 0x0010A350
		// (set) Token: 0x0600444E RID: 17486 RVA: 0x0010C164 File Offset: 0x0010A364
		public bool Archive
		{
			[CompilerGenerated]
			get
			{
				return this.<Archive>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Archive>k__BackingField == value)
				{
					return;
				}
				this.<Archive>k__BackingField = value;
				this.RaisePropertyChanged("Archive");
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x0010C190 File Offset: 0x0010A390
		// (set) Token: 0x06004450 RID: 17488 RVA: 0x0010C1A4 File Offset: 0x0010A3A4
		public ObservableCollection<IMaterial> Materials
		{
			[CompilerGenerated]
			get
			{
				return this.<Materials>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Materials>k__BackingField, value))
				{
					return;
				}
				this.<Materials>k__BackingField = value;
				this.RaisePropertyChanged("Materials");
			}
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x0010C1D4 File Offset: 0x0010A3D4
		public CartridgeCard()
		{
			this.Materials = new ObservableCollection<IMaterial>();
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x0010C1F4 File Offset: 0x0010A3F4
		public List<IMaterial> GetMaterial(Material.MaterialType type)
		{
			return (from m in this.Materials
			where m.Type == (int)type
			select m).ToList<IMaterial>();
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x0010C22C File Offset: 0x0010A42C
		public CartridgeCard(ICartridgeCard c)
		{
			this.CardId = c.CardId;
			this.MakerId = c.MakerId;
			this.Name = c.Name;
			this.Created = c.Created;
			this.Notes = c.Notes;
			this.FullWeight = c.FullWeight;
			this.TonerWeight = c.TonerWeight;
			this.Color = c.Color;
			this.Resource = c.Resource;
			this.EmployeeId = c.EmployeeId;
			this.Photo = c.Photo;
			this.Materials = c.Materials;
			this.Archive = c.Archive;
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x0010C2DC File Offset: 0x0010A4DC
		public virtual Task<bool> Save()
		{
			CartridgeCard.<Save>d__59 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<CartridgeCard.<Save>d__59>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x0010C320 File Offset: 0x0010A520
		public string CheckFields()
		{
			if (this.MakerId <= 0)
			{
				goto IL_F9;
			}
			goto IL_1E2;
			int num;
			for (;;)
			{
				IL_18B:
				switch ((num ^ 585237352) % 14)
				{
				case 0:
					num = ((!this.Materials.Any((IMaterial m) => m.Price < 0m)) ? 1818971187 : 645459178);
					continue;
				case 2:
					goto IL_1E2;
				case 3:
					num = (this.Materials.Any((IMaterial m) => m.WorksPrice < 0m) ? 645459178 : 2125234515);
					continue;
				case 4:
					goto IL_F9;
				case 5:
					goto IL_1FA;
				case 6:
					goto IL_200;
				case 7:
					num = (this.Materials.Any((IMaterial m) => string.IsNullOrEmpty(m.Name)) ? 984935305 : 1190139191);
					continue;
				case 8:
					goto IL_206;
				case 9:
					goto IL_20C;
				case 10:
					num = ((!this.Materials.Any((IMaterial m) => m.Count <= 0)) ? 1478760135 : 1519330612);
					continue;
				case 11:
					num = (this.Materials.Any(delegate(IMaterial m)
					{
						if (m.Articul == null)
						{
							return true;
						}
						int? articul = m.Articul;
						return articul.GetValueOrDefault() == 0 & articul != null;
					}) ? 1226340126 : 1499037958);
					continue;
				case 12:
					goto IL_212;
				case 13:
					goto IL_218;
				}
				break;
			}
			return "";
			IL_1FA:
			return "InputItemName";
			IL_200:
			return "SelectItems";
			IL_206:
			return "CheckCount";
			IL_20C:
			return "ItemError";
			IL_212:
			return "NegativePrice";
			IL_218:
			return "SelectDeviceMaker";
			IL_F9:
			num = 806895473;
			goto IL_18B;
			IL_1E2:
			num = (string.IsNullOrEmpty(this.Name) ? 111011859 : 1445377926);
			goto IL_18B;
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x0010C54C File Offset: 0x0010A74C
		public void AddMaterial()
		{
			IEnumerable<int> source = (from m in Bootstrapper.Container.Resolve<ICartridgeCardService>().GetMaterialTypes()
			select m.Key).ToList<int>();
			List<int> usedTypes = (from m in this.Materials
			select m.Type).ToList<int>();
			int num = (from t in source
			where !usedTypes.Contains(t)
			select t).ToList<int>().FirstOrDefault<int>();
			for (;;)
			{
				IL_E4:
				int num2 = -1150721436;
				for (;;)
				{
					switch ((num2 ^ -433747567) % 3)
					{
					case 0:
						goto IL_E4;
					case 1:
						this.Materials.Add(new Material
						{
							Type = num,
							Count = ((num == 0) ? Convert.ToInt32(Math.Ceiling(this.TonerWeight)) : 1)
						});
						num2 = -1400973273;
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x0010C644 File Offset: 0x0010A844
		public bool RemoveMaterial(string name)
		{
			IMaterial material = this.Materials.FirstOrDefault((IMaterial m) => m.Name == name);
			if (material == null)
			{
				return false;
			}
			if (material.Id > 0)
			{
				bool result;
				try
				{
					using (auseceEntities auseceEntities = new auseceEntities(true))
					{
						materials materials = auseceEntities.materials.Find(new object[]
						{
							material.Id
						});
						if (materials == null)
						{
							return false;
						}
						auseceEntities.materials.Remove(materials);
						auseceEntities.SaveChanges();
					}
					goto IL_91;
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
					result = false;
				}
				return result;
			}
			IL_91:
			this.Materials.Remove(material);
			return true;
		}

		// Token: 0x04002C10 RID: 11280
		[CompilerGenerated]
		private int <CardId>k__BackingField;

		// Token: 0x04002C11 RID: 11281
		[CompilerGenerated]
		private int <MakerId>k__BackingField;

		// Token: 0x04002C12 RID: 11282
		[CompilerGenerated]
		private string <MakerName>k__BackingField;

		// Token: 0x04002C13 RID: 11283
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002C14 RID: 11284
		[CompilerGenerated]
		private DateTime <Created>k__BackingField;

		// Token: 0x04002C15 RID: 11285
		[CompilerGenerated]
		private string <Notes>k__BackingField;

		// Token: 0x04002C16 RID: 11286
		[CompilerGenerated]
		private double <FullWeight>k__BackingField;

		// Token: 0x04002C17 RID: 11287
		[CompilerGenerated]
		private double <TonerWeight>k__BackingField;

		// Token: 0x04002C18 RID: 11288
		[CompilerGenerated]
		private int <Color>k__BackingField;

		// Token: 0x04002C19 RID: 11289
		[CompilerGenerated]
		private int <Resource>k__BackingField;

		// Token: 0x04002C1A RID: 11290
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;

		// Token: 0x04002C1B RID: 11291
		[CompilerGenerated]
		private byte[] <Photo>k__BackingField;

		// Token: 0x04002C1C RID: 11292
		[CompilerGenerated]
		private bool <Archive>k__BackingField;

		// Token: 0x04002C1D RID: 11293
		[CompilerGenerated]
		private ObservableCollection<IMaterial> <Materials>k__BackingField;

		// Token: 0x020008BC RID: 2236
		[CompilerGenerated]
		private sealed class <>c__DisplayClass57_0
		{
			// Token: 0x06004458 RID: 17496 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass57_0()
			{
			}

			// Token: 0x06004459 RID: 17497 RVA: 0x0010C70C File Offset: 0x0010A90C
			internal bool <GetMaterial>b__0(IMaterial m)
			{
				return m.Type == (int)this.type;
			}

			// Token: 0x04002C1E RID: 11294
			public Material.MaterialType type;
		}

		// Token: 0x020008BD RID: 2237
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__59 : IAsyncStateMachine
		{
			// Token: 0x0600445A RID: 17498 RVA: 0x0010C728 File Offset: 0x0010A928
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeCard cartridgeCard = this.<>4__this;
				bool result;
				try
				{
					try
					{
						Localization localization;
						if (num != 0)
						{
							localization = new Localization("UTC");
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								cartridge_cards cartridge_cards = this.<ctx>5__2.cartridge_cards.Find(new object[]
								{
									cartridgeCard.CardId
								});
								if (cartridge_cards == null)
								{
									result = false;
									goto IL_343;
								}
								cartridge_cards.maker = cartridgeCard.MakerId;
								cartridge_cards.name = cartridgeCard.Name;
								cartridge_cards.notes = cartridgeCard.Notes;
								cartridge_cards.full_weight = cartridgeCard.FullWeight;
								cartridge_cards.toner_weight = cartridgeCard.TonerWeight;
								cartridge_cards.color = cartridgeCard.Color;
								cartridge_cards.resource = cartridgeCard.Resource;
								cartridge_cards.archive = cartridgeCard.Archive;
								if (cartridge_cards.images == null)
								{
									if (cartridgeCard.Photo != null)
									{
										cartridge_cards.images = new images
										{
											img = cartridgeCard.Photo,
											added = new DateTime?(localization.Now),
											uid = new int?(cartridgeCard.EmployeeId),
											preview = null
										};
									}
								}
								else if (cartridgeCard.Photo == null)
								{
									this.<ctx>5__2.images.Remove(cartridge_cards.images);
								}
								else
								{
									cartridge_cards.images.img = cartridgeCard.Photo;
								}
								if (cartridgeCard.Materials.Any<IMaterial>())
								{
									IEnumerator<IMaterial> enumerator = cartridgeCard.Materials.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											IMaterial material = enumerator.Current;
											if (material.Id <= 0)
											{
												materials entity = new materials
												{
													type = material.Type,
													count = material.Count,
													articul = material.Articul,
													name = material.Name,
													card_id = cartridgeCard.CardId,
													price = material.Price,
													works_price = material.WorksPrice
												};
												this.<ctx>5__2.materials.Add(entity);
											}
											else
											{
												materials materials = this.<ctx>5__2.materials.Find(new object[]
												{
													material.Id
												});
												if (materials != null)
												{
													materials.type = material.Type;
													materials.count = material.Count;
													materials.articul = material.Articul;
													materials.name = material.Name;
													materials.price = material.Price;
													materials.works_price = material.WorksPrice;
												}
											}
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
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeCard.<Save>d__59>(ref awaiter, ref this);
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
					catch (Exception)
					{
						result = false;
						goto IL_343;
					}
					result = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_343:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x0600445B RID: 17499 RVA: 0x0010CAF0 File Offset: 0x0010ACF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002C1F RID: 11295
			public int <>1__state;

			// Token: 0x04002C20 RID: 11296
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002C21 RID: 11297
			public CartridgeCard <>4__this;

			// Token: 0x04002C22 RID: 11298
			private auseceEntities <ctx>5__2;

			// Token: 0x04002C23 RID: 11299
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x020008BE RID: 2238
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600445C RID: 17500 RVA: 0x0010CB0C File Offset: 0x0010AD0C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600445D RID: 17501 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600445E RID: 17502 RVA: 0x0010CB24 File Offset: 0x0010AD24
			internal bool <CheckFields>b__60_0(IMaterial m)
			{
				return m.Count <= 0;
			}

			// Token: 0x0600445F RID: 17503 RVA: 0x0010CB40 File Offset: 0x0010AD40
			internal bool <CheckFields>b__60_1(IMaterial m)
			{
				return string.IsNullOrEmpty(m.Name);
			}

			// Token: 0x06004460 RID: 17504 RVA: 0x0010CB58 File Offset: 0x0010AD58
			internal bool <CheckFields>b__60_2(IMaterial m)
			{
				if (m.Articul == null)
				{
					return true;
				}
				int? articul = m.Articul;
				return articul.GetValueOrDefault() == 0 & articul != null;
			}

			// Token: 0x06004461 RID: 17505 RVA: 0x0010CB90 File Offset: 0x0010AD90
			internal bool <CheckFields>b__60_3(IMaterial m)
			{
				return m.Price < 0m;
			}

			// Token: 0x06004462 RID: 17506 RVA: 0x0010CBB0 File Offset: 0x0010ADB0
			internal bool <CheckFields>b__60_4(IMaterial m)
			{
				return m.WorksPrice < 0m;
			}

			// Token: 0x06004463 RID: 17507 RVA: 0x0010CBD0 File Offset: 0x0010ADD0
			internal int <AddMaterial>b__61_0(KeyValuePair<int, string> m)
			{
				return m.Key;
			}

			// Token: 0x06004464 RID: 17508 RVA: 0x0010CBE4 File Offset: 0x0010ADE4
			internal int <AddMaterial>b__61_1(IMaterial m)
			{
				return m.Type;
			}

			// Token: 0x04002C24 RID: 11300
			public static readonly CartridgeCard.<>c <>9 = new CartridgeCard.<>c();

			// Token: 0x04002C25 RID: 11301
			public static Func<IMaterial, bool> <>9__60_0;

			// Token: 0x04002C26 RID: 11302
			public static Func<IMaterial, bool> <>9__60_1;

			// Token: 0x04002C27 RID: 11303
			public static Func<IMaterial, bool> <>9__60_2;

			// Token: 0x04002C28 RID: 11304
			public static Func<IMaterial, bool> <>9__60_3;

			// Token: 0x04002C29 RID: 11305
			public static Func<IMaterial, bool> <>9__60_4;

			// Token: 0x04002C2A RID: 11306
			public static Func<KeyValuePair<int, string>, int> <>9__61_0;

			// Token: 0x04002C2B RID: 11307
			public static Func<IMaterial, int> <>9__61_1;
		}

		// Token: 0x020008BF RID: 2239
		[CompilerGenerated]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x06004465 RID: 17509 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x06004466 RID: 17510 RVA: 0x0010CBF8 File Offset: 0x0010ADF8
			internal bool <AddMaterial>b__2(int t)
			{
				return !this.usedTypes.Contains(t);
			}

			// Token: 0x04002C2C RID: 11308
			public List<int> usedTypes;
		}

		// Token: 0x020008C0 RID: 2240
		[CompilerGenerated]
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x06004467 RID: 17511 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass62_0()
			{
			}

			// Token: 0x06004468 RID: 17512 RVA: 0x0010CC14 File Offset: 0x0010AE14
			internal bool <RemoveMaterial>b__0(IMaterial m)
			{
				return m.Name == this.name;
			}

			// Token: 0x04002C2D RID: 11309
			public string name;
		}
	}
}
