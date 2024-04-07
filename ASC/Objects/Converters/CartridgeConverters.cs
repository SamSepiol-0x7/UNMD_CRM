using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;

namespace ASC.Objects.Converters
{
	// Token: 0x02000928 RID: 2344
	public static class CartridgeConverters
	{
		// Token: 0x06004836 RID: 18486 RVA: 0x0011AE18 File Offset: 0x00119018
		public static Task<CartridgeEx> ToCartridgeEx(this workshop c)
		{
			CartridgeConverters.<ToCartridgeEx>d__0 <ToCartridgeEx>d__;
			<ToCartridgeEx>d__.<>t__builder = AsyncTaskMethodBuilder<CartridgeEx>.Create();
			<ToCartridgeEx>d__.c = c;
			<ToCartridgeEx>d__.<>1__state = -1;
			<ToCartridgeEx>d__.<>t__builder.Start<CartridgeConverters.<ToCartridgeEx>d__0>(ref <ToCartridgeEx>d__);
			return <ToCartridgeEx>d__.<>t__builder.Task;
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x0011AE5C File Offset: 0x0011905C
		public static Cartridge ToCartridge(this workshop c)
		{
			Cartridge cartridge = new Cartridge();
			cartridge.CompanyId = c.company;
			cartridge.CurrentOfficeId = c.office;
			cartridge.CardId = c.c_workshop.card_id;
			cartridge.MakerId = c.maker;
			device_makers device_makers = c.device_makers;
			cartridge.MakerName = ((device_makers != null) ? device_makers.name : null);
			cartridge.Name = c.c_workshop.cartridge_cards.name;
			cartridge.Created = c.c_workshop.cartridge_cards.created;
			cartridge.Notes = c.c_workshop.cartridge_cards.notes;
			cartridge.FullWeight = c.c_workshop.cartridge_cards.full_weight;
			cartridge.TonerWeight = c.c_workshop.cartridge_cards.toner_weight;
			cartridge.Resource = c.c_workshop.cartridge_cards.resource;
			cartridge.EmployeeId = c.c_workshop.cartridge_cards.user;
			cartridge.Color = c.c_workshop.cartridge_cards.color;
			images images = c.c_workshop.cartridge_cards.images;
			cartridge.Photo = ((images != null) ? images.img : null);
			ObservableCollection<IMaterial> materials;
			if (c.c_workshop.cartridge_cards.materials != null)
			{
				materials = new ObservableCollection<IMaterial>(from cc in c.c_workshop.cartridge_cards.materials
				select cc.ToMaterial());
			}
			else
			{
				materials = new ObservableCollection<IMaterial>();
			}
			cartridge.Materials = materials;
			cartridge.Id = c.id;
			cartridge.SerialNumber = c.serial_number;
			cartridge.Barcode = c.barcode;
			cartridge.CartridgeNotes = c.ext_notes;
			cartridge.BoxId = c.box;
			cartridge.Chip = c.c_workshop.chip;
			cartridge.Refill = c.c_workshop.refill;
			cartridge.OPCDrum = c.c_workshop.opc_drum;
			cartridge.CleaningBlade = c.c_workshop.c_blade;
			cartridge.CustomerId = c.client;
			return cartridge;
		}

		// Token: 0x02000929 RID: 2345
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06004838 RID: 18488 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x06004839 RID: 18489 RVA: 0x0011B074 File Offset: 0x00119274
			internal Task <ToCartridgeEx>b__0()
			{
				return this.result.CalcTotal();
			}

			// Token: 0x04002E15 RID: 11797
			public CartridgeEx result;
		}

		// Token: 0x0200092A RID: 2346
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600483A RID: 18490 RVA: 0x0011B08C File Offset: 0x0011928C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600483B RID: 18491 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600483C RID: 18492 RVA: 0x0011B0A4 File Offset: 0x001192A4
			internal IMaterial <ToCartridgeEx>b__0_1(materials cc)
			{
				return cc.ToMaterial();
			}

			// Token: 0x0600483D RID: 18493 RVA: 0x0011B0B8 File Offset: 0x001192B8
			internal bool <ToCartridgeEx>b__0_2(works w)
			{
				return w.type == 1;
			}

			// Token: 0x0600483E RID: 18494 RVA: 0x0011B0D0 File Offset: 0x001192D0
			internal bool <ToCartridgeEx>b__0_3(works w)
			{
				return w.type == 3;
			}

			// Token: 0x0600483F RID: 18495 RVA: 0x0011B0E8 File Offset: 0x001192E8
			internal bool <ToCartridgeEx>b__0_4(works w)
			{
				return w.type == 2;
			}

			// Token: 0x06004840 RID: 18496 RVA: 0x0011B100 File Offset: 0x00119300
			internal bool <ToCartridgeEx>b__0_5(works w)
			{
				return w.type == 4;
			}

			// Token: 0x06004841 RID: 18497 RVA: 0x0011B0A4 File Offset: 0x001192A4
			internal IMaterial <ToCartridge>b__1_0(materials cc)
			{
				return cc.ToMaterial();
			}

			// Token: 0x04002E16 RID: 11798
			public static readonly CartridgeConverters.<>c <>9 = new CartridgeConverters.<>c();

			// Token: 0x04002E17 RID: 11799
			public static Func<materials, IMaterial> <>9__0_1;

			// Token: 0x04002E18 RID: 11800
			public static Func<works, bool> <>9__0_2;

			// Token: 0x04002E19 RID: 11801
			public static Func<works, bool> <>9__0_3;

			// Token: 0x04002E1A RID: 11802
			public static Func<works, bool> <>9__0_4;

			// Token: 0x04002E1B RID: 11803
			public static Func<works, bool> <>9__0_5;

			// Token: 0x04002E1C RID: 11804
			public static Func<materials, IMaterial> <>9__1_0;
		}

		// Token: 0x0200092B RID: 2347
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ToCartridgeEx>d__0 : IAsyncStateMachine
		{
			// Token: 0x06004842 RID: 18498 RVA: 0x0011B118 File Offset: 0x00119318
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx result;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							this.<>8__1 = new CartridgeConverters.<>c__DisplayClass0_0();
							CartridgeConverters.<>c__DisplayClass0_0 CS$<>8__locals1 = this.<>8__1;
							CartridgeEx cartridgeEx = new CartridgeEx();
							cartridgeEx.CompanyId = this.c.company;
							cartridgeEx.CurrentOfficeId = this.c.office;
							cartridgeEx.CardId = this.c.c_workshop.card_id;
							cartridgeEx.MakerId = this.c.maker;
							cartridgeEx.Name = this.c.c_workshop.cartridge_cards.name;
							cartridgeEx.Created = this.c.c_workshop.cartridge_cards.created;
							cartridgeEx.Notes = this.c.c_workshop.cartridge_cards.notes;
							cartridgeEx.FullWeight = this.c.c_workshop.cartridge_cards.full_weight;
							cartridgeEx.TonerWeight = this.c.c_workshop.cartridge_cards.toner_weight;
							cartridgeEx.Resource = this.c.c_workshop.cartridge_cards.resource;
							cartridgeEx.EmployeeId = this.c.c_workshop.cartridge_cards.user;
							cartridgeEx.Color = this.c.c_workshop.cartridge_cards.color;
							images images = this.c.c_workshop.cartridge_cards.images;
							cartridgeEx.Photo = ((images != null) ? images.img : null);
							ObservableCollection<IMaterial> materials;
							if (this.c.c_workshop.cartridge_cards.materials != null)
							{
								materials = new ObservableCollection<IMaterial>(this.c.c_workshop.cartridge_cards.materials.Select(new Func<materials, IMaterial>(CartridgeConverters.<>c.<>9.<ToCartridgeEx>b__0_1)));
							}
							else
							{
								materials = new ObservableCollection<IMaterial>();
							}
							cartridgeEx.Materials = materials;
							cartridgeEx.Id = this.c.id;
							cartridgeEx.SerialNumber = this.c.serial_number;
							cartridgeEx.Barcode = this.c.barcode;
							cartridgeEx.CartridgeNotes = this.c.ext_notes;
							cartridgeEx.BoxId = this.c.box;
							cartridgeEx.Chip = this.c.c_workshop.chip;
							cartridgeEx.Refill = this.c.c_workshop.refill;
							cartridgeEx.OPCDrum = this.c.c_workshop.opc_drum;
							cartridgeEx.CleaningBlade = this.c.c_workshop.c_blade;
							cartridgeEx.CustomerId = this.c.client;
							cartridgeEx.Customer = this.c.clients.Client2CustomerCard();
							cartridgeEx.InvoiceId = this.c.invoice;
							cartridgeEx.Maker = this.c.device_makers.name;
							cartridgeEx.MakerName = this.c.device_makers.name;
							cartridgeEx.MasterId = this.c.master;
							cartridgeEx.Status = this.c.state;
							ICollection<works> works = this.c.works;
							bool makeRefill;
							if (works == null)
							{
								makeRefill = false;
							}
							else
							{
								makeRefill = works.Any(new Func<works, bool>(CartridgeConverters.<>c.<>9.<ToCartridgeEx>b__0_2));
							}
							cartridgeEx.MakeRefill = makeRefill;
							ICollection<works> works2 = this.c.works;
							bool makeOPCDrum;
							if (works2 == null)
							{
								makeOPCDrum = false;
							}
							else
							{
								makeOPCDrum = works2.Any(new Func<works, bool>(CartridgeConverters.<>c.<>9.<ToCartridgeEx>b__0_3));
							}
							cartridgeEx.MakeOPCDrum = makeOPCDrum;
							ICollection<works> works3 = this.c.works;
							bool makeChip;
							if (works3 == null)
							{
								makeChip = false;
							}
							else
							{
								makeChip = works3.Any(new Func<works, bool>(CartridgeConverters.<>c.<>9.<ToCartridgeEx>b__0_4));
							}
							cartridgeEx.MakeChip = makeChip;
							ICollection<works> works4 = this.c.works;
							bool makeCleaningBlade;
							if (works4 == null)
							{
								makeCleaningBlade = false;
							}
							else
							{
								makeCleaningBlade = works4.Any(new Func<works, bool>(CartridgeConverters.<>c.<>9.<ToCartridgeEx>b__0_5));
							}
							cartridgeEx.MakeCleaningBlade = makeCleaningBlade;
							cartridgeEx.Works = ((this.c.works == null) ? new List<works>() : new List<works>(this.c.works));
							cartridgeEx.Items = ((this.c.store_int_reserve == null) ? new List<store_int_reserve>() : new List<store_int_reserve>(this.c.store_int_reserve));
							cartridgeEx.OutMessage = this.c.issued_msg;
							CS$<>8__locals1.result = cartridgeEx;
							Task task = Task.Run(new Func<Task>(this.<>8__1.<ToCartridgeEx>b__0));
							awaiter = Task.WhenAll(new Task[]
							{
								task
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeConverters.<ToCartridgeEx>d__0>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						result = this.<>8__1.result;
					}
					catch (Exception)
					{
						result = null;
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

			// Token: 0x06004843 RID: 18499 RVA: 0x0011B66C File Offset: 0x0011986C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002E1D RID: 11805
			public int <>1__state;

			// Token: 0x04002E1E RID: 11806
			public AsyncTaskMethodBuilder<CartridgeEx> <>t__builder;

			// Token: 0x04002E1F RID: 11807
			public workshop c;

			// Token: 0x04002E20 RID: 11808
			private CartridgeConverters.<>c__DisplayClass0_0 <>8__1;

			// Token: 0x04002E21 RID: 11809
			private TaskAwaiter <>u__1;
		}
	}
}
