using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Services.Abstract;
using Autofac;

namespace ASC.Objects
{
	// Token: 0x0200089C RID: 2204
	public class CartridgeEx : Cartridge
	{
		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00106F44 File Offset: 0x00105144
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x00106F58 File Offset: 0x00105158
		public string Maker
		{
			[CompilerGenerated]
			get
			{
				return this.<Maker>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Maker>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Maker>k__BackingField = value;
				this.RaisePropertyChanged("Maker");
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x00106F88 File Offset: 0x00105188
		// (set) Token: 0x06004349 RID: 17225 RVA: 0x00106F9C File Offset: 0x0010519C
		public bool MakeRefill
		{
			[CompilerGenerated]
			get
			{
				return this.<MakeRefill>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MakeRefill>k__BackingField == value)
				{
					return;
				}
				this.<MakeRefill>k__BackingField = value;
				this.RaisePropertyChanged("MakeRefill");
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x00106FC8 File Offset: 0x001051C8
		// (set) Token: 0x0600434B RID: 17227 RVA: 0x00106FDC File Offset: 0x001051DC
		public bool MakeChip
		{
			[CompilerGenerated]
			get
			{
				return this.<MakeChip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MakeChip>k__BackingField == value)
				{
					return;
				}
				this.<MakeChip>k__BackingField = value;
				this.RaisePropertyChanged("MakeChip");
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x00107008 File Offset: 0x00105208
		// (set) Token: 0x0600434D RID: 17229 RVA: 0x0010701C File Offset: 0x0010521C
		public bool MakeOPCDrum
		{
			[CompilerGenerated]
			get
			{
				return this.<MakeOPCDrum>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MakeOPCDrum>k__BackingField == value)
				{
					return;
				}
				this.<MakeOPCDrum>k__BackingField = value;
				this.RaisePropertyChanged("MakeOPCDrum");
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x00107048 File Offset: 0x00105248
		// (set) Token: 0x0600434F RID: 17231 RVA: 0x0010705C File Offset: 0x0010525C
		public bool MakeCleaningBlade
		{
			[CompilerGenerated]
			get
			{
				return this.<MakeCleaningBlade>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MakeCleaningBlade>k__BackingField == value)
				{
					return;
				}
				this.<MakeCleaningBlade>k__BackingField = value;
				this.RaisePropertyChanged("MakeCleaningBlade");
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x00107088 File Offset: 0x00105288
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x0010709C File Offset: 0x0010529C
		public CustomerCard Customer
		{
			[CompilerGenerated]
			get
			{
				return this.<Customer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Customer>k__BackingField, value))
				{
					return;
				}
				this.<Customer>k__BackingField = value;
				this.RaisePropertyChanged("Customer");
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x001070CC File Offset: 0x001052CC
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x001070E0 File Offset: 0x001052E0
		public int? InvoiceId
		{
			[CompilerGenerated]
			get
			{
				return this.<InvoiceId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<InvoiceId>k__BackingField, value))
				{
					return;
				}
				this.<InvoiceId>k__BackingField = value;
				this.RaisePropertyChanged("InvoiceId");
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x00107110 File Offset: 0x00105310
		public bool HistoryOptionsVisible
		{
			get
			{
				if (base.SelectedHistoryOption != null)
				{
					int? selectedHistoryOption = base.SelectedHistoryOption;
					return selectedHistoryOption.GetValueOrDefault() > 0 & selectedHistoryOption != null;
				}
				return false;
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x00107148 File Offset: 0x00105348
		// (set) Token: 0x06004356 RID: 17238 RVA: 0x0010715C File Offset: 0x0010535C
		public decimal Total
		{
			[CompilerGenerated]
			get
			{
				return this.<Total>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<Total>k__BackingField, value))
				{
					return;
				}
				this.<Total>k__BackingField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x0010718C File Offset: 0x0010538C
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x001071A0 File Offset: 0x001053A0
		public decimal PrePaid
		{
			[CompilerGenerated]
			get
			{
				return this.<PrePaid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<PrePaid>k__BackingField, value))
				{
					return;
				}
				this.<PrePaid>k__BackingField = value;
				this.RaisePropertyChanged("PrePaid");
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x001071D0 File Offset: 0x001053D0
		// (set) Token: 0x0600435A RID: 17242 RVA: 0x001071E4 File Offset: 0x001053E4
		public decimal FinalAmount
		{
			[CompilerGenerated]
			get
			{
				return this.<FinalAmount>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (decimal.Equals(this.<FinalAmount>k__BackingField, value))
				{
					return;
				}
				this.<FinalAmount>k__BackingField = value;
				this.RaisePropertyChanged("FinalAmount");
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x00107214 File Offset: 0x00105414
		// (set) Token: 0x0600435C RID: 17244 RVA: 0x00107228 File Offset: 0x00105428
		public string OutMessage
		{
			[CompilerGenerated]
			get
			{
				return this.<OutMessage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<OutMessage>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<OutMessage>k__BackingField = value;
				this.RaisePropertyChanged("OutMessage");
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x00107258 File Offset: 0x00105458
		public bool CanStatusChange
		{
			get
			{
				return base.Status != 8 && base.Status != 12;
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x00107280 File Offset: 0x00105480
		// (set) Token: 0x0600435F RID: 17247 RVA: 0x00107294 File Offset: 0x00105494
		public List<works> Works
		{
			[CompilerGenerated]
			get
			{
				return this.<Works>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(this.<Works>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -173622463;
				IL_13:
				switch ((num ^ -1287049461) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					IL_32:
					this.<Works>k__BackingField = value;
					this.RaisePropertyChanged("WorksText");
					this.RaisePropertyChanged("Works");
					num = -1770777968;
					goto IL_13;
				case 2:
					return;
				}
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x001072F8 File Offset: 0x001054F8
		// (set) Token: 0x06004361 RID: 17249 RVA: 0x0010730C File Offset: 0x0010550C
		public List<store_int_reserve> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x0010733C File Offset: 0x0010553C
		public string WorksText
		{
			get
			{
				if (!this.Works.Any<works>())
				{
					return "---";
				}
				string text = "";
				using (List<works>.Enumerator enumerator = this.Works.GetEnumerator())
				{
					for (;;)
					{
						IL_86:
						int num = enumerator.MoveNext() ? -2107712795 : -220619541;
						for (;;)
						{
							switch ((num ^ -1063625392) % 4)
							{
							case 0:
								num = -2107712795;
								continue;
							case 1:
							{
								works works = enumerator.Current;
								text = text + works.name + "; ";
								num = -882507042;
								continue;
							}
							case 2:
								goto IL_86;
							}
							goto Block_4;
						}
					}
					Block_4:;
				}
				return text;
			}
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x001073FC File Offset: 0x001055FC
		public CartridgeEx()
		{
			this.localization = new Localization("UTC");
			this.Works = new List<works>();
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x0010742C File Offset: 0x0010562C
		public bool IsAddWorks(Material.MaterialType materialType)
		{
			switch (materialType)
			{
			case Material.MaterialType.Toner:
				return this.MakeRefill;
			case Material.MaterialType.OPCDrum:
				return this.MakeOPCDrum;
			case Material.MaterialType.Chip:
				return this.MakeChip;
			case Material.MaterialType.CleaningBlade:
				return this.MakeCleaningBlade;
			default:
				return false;
			}
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x0010746C File Offset: 0x0010566C
		private Task ReloadWorks()
		{
			CartridgeEx.<ReloadWorks>d__61 <ReloadWorks>d__;
			<ReloadWorks>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReloadWorks>d__.<>4__this = this;
			<ReloadWorks>d__.<>1__state = -1;
			<ReloadWorks>d__.<>t__builder.Start<CartridgeEx.<ReloadWorks>d__61>(ref <ReloadWorks>d__);
			return <ReloadWorks>d__.<>t__builder.Task;
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x001074B0 File Offset: 0x001056B0
		private Task ReloadParts()
		{
			CartridgeEx.<ReloadParts>d__62 <ReloadParts>d__;
			<ReloadParts>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReloadParts>d__.<>4__this = this;
			<ReloadParts>d__.<>1__state = -1;
			<ReloadParts>d__.<>t__builder.Start<CartridgeEx.<ReloadParts>d__62>(ref <ReloadParts>d__);
			return <ReloadParts>d__.<>t__builder.Task;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x001074F4 File Offset: 0x001056F4
		public Task<Result> AddWorks(IMaterial mt)
		{
			CartridgeEx.<AddWorks>d__63 <AddWorks>d__;
			<AddWorks>d__.<>t__builder = AsyncTaskMethodBuilder<Result>.Create();
			<AddWorks>d__.<>4__this = this;
			<AddWorks>d__.mt = mt;
			<AddWorks>d__.<>1__state = -1;
			<AddWorks>d__.<>t__builder.Start<CartridgeEx.<AddWorks>d__63>(ref <AddWorks>d__);
			return <AddWorks>d__.<>t__builder.Task;
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00107540 File Offset: 0x00105740
		public Task<Result> RemoveWorks(Material.MaterialType materialType)
		{
			CartridgeEx.<RemoveWorks>d__64 <RemoveWorks>d__;
			<RemoveWorks>d__.<>t__builder = AsyncTaskMethodBuilder<Result>.Create();
			<RemoveWorks>d__.<>4__this = this;
			<RemoveWorks>d__.materialType = materialType;
			<RemoveWorks>d__.<>1__state = -1;
			<RemoveWorks>d__.<>t__builder.Start<CartridgeEx.<RemoveWorks>d__64>(ref <RemoveWorks>d__);
			return <RemoveWorks>d__.<>t__builder.Task;
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x0010758C File Offset: 0x0010578C
		private void PostWorksChanged(Material.MaterialType materialType, Result result)
		{
			if (!result.IsSucces)
			{
				this.RestorePreviousValues(materialType);
			}
			else
			{
				result.MessageFromResource("Saved");
			}
			Task.Run(new Func<Task>(this.CalcTotal));
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x001075C8 File Offset: 0x001057C8
		public void RestorePreviousValues(Material.MaterialType materialType)
		{
			int num;
			switch (materialType)
			{
			case Material.MaterialType.Toner:
				IL_18:
				this.MakeRefill = !this.MakeRefill;
				num = 1565597510;
				goto IL_33;
			case Material.MaterialType.OPCDrum:
				IL_78:
				this.MakeOPCDrum = !this.MakeOPCDrum;
				return;
			case Material.MaterialType.Chip:
				IL_62:
				this.MakeChip = !this.MakeChip;
				num = 856819880;
				goto IL_33;
			case Material.MaterialType.CleaningBlade:
				IL_8B:
				this.MakeCleaningBlade = !this.MakeCleaningBlade;
				return;
			}
			IL_2E:
			num = 1569528890;
			IL_33:
			switch ((num ^ 638796604) % 8)
			{
			case 0:
				goto IL_8B;
			case 1:
				goto IL_78;
			case 2:
				return;
			case 3:
				goto IL_2E;
			case 4:
				return;
			case 5:
				goto IL_18;
			case 6:
				return;
			case 7:
				goto IL_62;
			default:
				goto IL_8B;
			}
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x00107670 File Offset: 0x00105870
		private store_int_reserve CreateReserve(store_items material, IMaterial mt, int workId, auseceEntities ctx)
		{
			store_int_reserve store_int_reserve = new store_int_reserve
			{
				item_id = material.id,
				name = material.name,
				count = mt.Count,
				created = new DateTime?(this.localization.Now),
				from_user = OfflineData.Instance.Employee.Id,
				to_user = OfflineData.Instance.Employee.Id,
				state = 2,
				repair_id = new int?(base.Id),
				work_id = new int?(workId),
				price = mt.Price / mt.Count,
				sn = "",
				warranty = 0,
				notes = string.Format((string)Application.Current.TryFindResource("GoodsDelivery"), material.name, OfflineData.Instance.Employee.FioShort)
			};
			ctx.store_int_reserve.Add(store_int_reserve);
			material.reserved += store_int_reserve.count;
			return store_int_reserve;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00107790 File Offset: 0x00105990
		private works AddWork(decimal price, auseceEntities ctx, Material.MaterialType materialType, string materialName)
		{
			if (base.MasterId == null)
			{
				base.MasterId = new int?(OfflineData.Instance.Employee.Id);
			}
			works works = new works();
			int? masterId = base.MasterId;
			works.user = ((masterId == null) ? OfflineData.Instance.Employee.Id : masterId.GetValueOrDefault());
			works.repair = new int?(base.Id);
			works.name = this.GetWorkName(materialType, materialName);
			works.price = price;
			works.warranty = 0;
			works.added = new DateTime?(this.localization.Now);
			works.type = (int)this.GetWorkType(materialType);
			works.count = 1L;
			works works2 = works;
			ctx.works.Add(works2);
			return works2;
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x0010786C File Offset: 0x00105A6C
		private string GetWorkName(Material.MaterialType materialType, string materialName)
		{
			switch (materialType)
			{
			case Material.MaterialType.Toner:
				return (string)Application.Current.TryFindResource("Refill");
			case Material.MaterialType.OPCDrum:
				return (string)Application.Current.TryFindResource("Replace") + " " + materialName;
			case Material.MaterialType.Chip:
				return (string)Application.Current.TryFindResource("Replace") + " " + materialName;
			case Material.MaterialType.CleaningBlade:
				return (string)Application.Current.TryFindResource("Replace") + " " + materialName;
			default:
				return (string)Application.Current.TryFindResource("Refill");
			}
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00107918 File Offset: 0x00105B18
		private RepairModel.WorkType GetWorkType(Material.MaterialType materialType)
		{
			switch (materialType)
			{
			case Material.MaterialType.Toner:
				return RepairModel.WorkType.Refill;
			case Material.MaterialType.OPCDrum:
				return RepairModel.WorkType.OPCDrum;
			case Material.MaterialType.Chip:
				return RepairModel.WorkType.Chip;
			case Material.MaterialType.CleaningBlade:
				return RepairModel.WorkType.CleaningBlade;
			default:
				return RepairModel.WorkType.Regular;
			}
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00107944 File Offset: 0x00105B44
		private void CancelReserve(auseceEntities ctx, HistoryV2 history, int workType)
		{
			store_int_reserve reserve = ctx.store_int_reserve.Include((store_int_reserve r) => r.users).Include((store_int_reserve r) => r.works).FirstOrDefault((store_int_reserve r) => r.repair_id == (int?)this.Id && r.works.type == workType);
			if (reserve != null)
			{
				store_items store_items = ctx.store_items.FirstOrDefault((store_items i) => i.id == reserve.item_id);
				if (store_items != null)
				{
					store_items.reserved -= reserve.count;
					history.AddItemLog("CancellReserve", reserve.item_id, reserve.OnFio, "");
				}
				reserve.state = 4;
				reserve.work_id = null;
				reserve.repair_id = null;
				ctx.SaveChanges();
			}
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00107BBC File Offset: 0x00105DBC
		public Task<Result> MasterChanged()
		{
			CartridgeEx.<MasterChanged>d__72 <MasterChanged>d__;
			<MasterChanged>d__.<>t__builder = AsyncTaskMethodBuilder<Result>.Create();
			<MasterChanged>d__.<>4__this = this;
			<MasterChanged>d__.<>1__state = -1;
			<MasterChanged>d__.<>t__builder.Start<CartridgeEx.<MasterChanged>d__72>(ref <MasterChanged>d__);
			return <MasterChanged>d__.<>t__builder.Task;
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00107C00 File Offset: 0x00105E00
		public Task<Result> StatusChanged()
		{
			CartridgeEx.<StatusChanged>d__73 <StatusChanged>d__;
			<StatusChanged>d__.<>t__builder = AsyncTaskMethodBuilder<Result>.Create();
			<StatusChanged>d__.<>4__this = this;
			<StatusChanged>d__.<>1__state = -1;
			<StatusChanged>d__.<>t__builder.Start<CartridgeEx.<StatusChanged>d__73>(ref <StatusChanged>d__);
			return <StatusChanged>d__.<>t__builder.Task;
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00107C44 File Offset: 0x00105E44
		private void FallbackStatus(int originalState)
		{
			if (originalState != 0)
			{
				base.Status = originalState;
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00107C5C File Offset: 0x00105E5C
		public Task CalcTotal()
		{
			CartridgeEx.<CalcTotal>d__75 <CalcTotal>d__;
			<CalcTotal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CalcTotal>d__.<>4__this = this;
			<CalcTotal>d__.<>1__state = -1;
			<CalcTotal>d__.<>t__builder.Start<CartridgeEx.<CalcTotal>d__75>(ref <CalcTotal>d__);
			return <CalcTotal>d__.<>t__builder.Task;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00107CA0 File Offset: 0x00105EA0
		public void SetPaymentSystem(int paymentSystem)
		{
			base.PaymentSystem = paymentSystem;
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06004375 RID: 17269 RVA: 0x00107CB4 File Offset: 0x00105EB4
		// (set) Token: 0x06004376 RID: 17270 RVA: 0x00107CC8 File Offset: 0x00105EC8
		public int _cashOrderId
		{
			[CompilerGenerated]
			get
			{
				return this.<_cashOrderId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<_cashOrderId>k__BackingField == value)
				{
					return;
				}
				this.<_cashOrderId>k__BackingField = value;
				this.RaisePropertyChanged("_cashOrderId");
			}
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00107CF4 File Offset: 0x00105EF4
		public void Issue()
		{
			CartridgeEx.<Issue>d__81 <Issue>d__;
			<Issue>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Issue>d__.<>4__this = this;
			<Issue>d__.<>1__state = -1;
			<Issue>d__.<>t__builder.Start<CartridgeEx.<Issue>d__81>(ref <Issue>d__);
		}

		// Token: 0x04002B5F RID: 11103
		[CompilerGenerated]
		private string <Maker>k__BackingField;

		// Token: 0x04002B60 RID: 11104
		[CompilerGenerated]
		private bool <MakeRefill>k__BackingField;

		// Token: 0x04002B61 RID: 11105
		[CompilerGenerated]
		private bool <MakeChip>k__BackingField;

		// Token: 0x04002B62 RID: 11106
		[CompilerGenerated]
		private bool <MakeOPCDrum>k__BackingField;

		// Token: 0x04002B63 RID: 11107
		[CompilerGenerated]
		private bool <MakeCleaningBlade>k__BackingField;

		// Token: 0x04002B64 RID: 11108
		[CompilerGenerated]
		private CustomerCard <Customer>k__BackingField;

		// Token: 0x04002B65 RID: 11109
		[CompilerGenerated]
		private int? <InvoiceId>k__BackingField;

		// Token: 0x04002B66 RID: 11110
		private Localization localization;

		// Token: 0x04002B67 RID: 11111
		[CompilerGenerated]
		private decimal <Total>k__BackingField;

		// Token: 0x04002B68 RID: 11112
		[CompilerGenerated]
		private decimal <PrePaid>k__BackingField;

		// Token: 0x04002B69 RID: 11113
		[CompilerGenerated]
		private decimal <FinalAmount>k__BackingField;

		// Token: 0x04002B6A RID: 11114
		[CompilerGenerated]
		private string <OutMessage>k__BackingField;

		// Token: 0x04002B6B RID: 11115
		[CompilerGenerated]
		private List<works> <Works>k__BackingField;

		// Token: 0x04002B6C RID: 11116
		[CompilerGenerated]
		private List<store_int_reserve> <Items>k__BackingField;

		// Token: 0x04002B6D RID: 11117
		[CompilerGenerated]
		private int <_cashOrderId>k__BackingField;

		// Token: 0x0200089D RID: 2205
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ReloadWorks>d__61 : IAsyncStateMachine
		{
			// Token: 0x06004378 RID: 17272 RVA: 0x00107D2C File Offset: 0x00105F2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<works>();
					}
					try
					{
						TaskAwaiter<IEnumerable<works>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((works w) => w.repair == (int?)cartridgeEx.Id, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<works>>, CartridgeEx.<ReloadWorks>d__61>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<works>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						IEnumerable<works> result = awaiter.GetResult();
						cartridgeEx.Works = new List<works>(result);
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
					this.<repo>5__2 = null;
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

			// Token: 0x06004379 RID: 17273 RVA: 0x00107EC4 File Offset: 0x001060C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002B6E RID: 11118
			public int <>1__state;

			// Token: 0x04002B6F RID: 11119
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002B70 RID: 11120
			public CartridgeEx <>4__this;

			// Token: 0x04002B71 RID: 11121
			private GenericRepository<works> <repo>5__2;

			// Token: 0x04002B72 RID: 11122
			private TaskAwaiter<IEnumerable<works>> <>u__1;
		}

		// Token: 0x0200089E RID: 2206
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ReloadParts>d__62 : IAsyncStateMachine
		{
			// Token: 0x0600437A RID: 17274 RVA: 0x00107EE0 File Offset: 0x001060E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<store_int_reserve>();
					}
					try
					{
						TaskAwaiter<IEnumerable<store_int_reserve>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((store_int_reserve w) => w.repair_id == (int?)cartridgeEx.Id, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<store_int_reserve>>, CartridgeEx.<ReloadParts>d__62>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<store_int_reserve>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						IEnumerable<store_int_reserve> result = awaiter.GetResult();
						cartridgeEx.Items = new List<store_int_reserve>(result);
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
					this.<repo>5__2 = null;
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

			// Token: 0x0600437B RID: 17275 RVA: 0x00108078 File Offset: 0x00106278
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002B73 RID: 11123
			public int <>1__state;

			// Token: 0x04002B74 RID: 11124
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002B75 RID: 11125
			public CartridgeEx <>4__this;

			// Token: 0x04002B76 RID: 11126
			private GenericRepository<store_int_reserve> <repo>5__2;

			// Token: 0x04002B77 RID: 11127
			private TaskAwaiter<IEnumerable<store_int_reserve>> <>u__1;
		}

		// Token: 0x0200089F RID: 2207
		[CompilerGenerated]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x0600437C RID: 17276 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x04002B78 RID: 11128
			public IMaterial mt;
		}

		// Token: 0x020008A0 RID: 2208
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddWorks>d__63 : IAsyncStateMachine
		{
			// Token: 0x0600437D RID: 17277 RVA: 0x00108094 File Offset: 0x00106294
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				Result result2;
				try
				{
					if (num > 3)
					{
						this.<>8__1 = new CartridgeEx.<>c__DisplayClass63_0();
						this.<>8__1.mt = this.mt;
						this.<result>5__2 = new Result();
						this.<history>5__3 = new HistoryV2();
					}
					try
					{
						if (num > 3)
						{
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							if (num > 3)
							{
								this.<transaction>5__5 = this.<ctx>5__4.Database.BeginTransaction();
							}
							try
							{
								TaskAwaiter<decimal> awaiter;
								TaskAwaiter<Result> awaiter2;
								TaskAwaiter awaiter3;
								switch (num)
								{
								case 0:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<decimal>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									break;
								}
								case 1:
								{
									awaiter2 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<Result>);
									int num3 = -1;
									num = -1;
									this.<>1__state = num3;
									goto IL_2E6;
								}
								case 2:
								{
									awaiter3 = this.<>u__3;
									this.<>u__3 = default(TaskAwaiter);
									int num4 = -1;
									num = -1;
									this.<>1__state = num4;
									goto IL_350;
								}
								case 3:
								{
									awaiter3 = this.<>u__3;
									this.<>u__3 = default(TaskAwaiter);
									int num5 = -1;
									num = -1;
									this.<>1__state = num5;
									goto IL_3AE;
								}
								default:
								{
									works works = cartridgeEx.AddWork(this.<>8__1.mt.WorksPrice, this.<ctx>5__4, (Material.MaterialType)this.<>8__1.mt.Type, this.<>8__1.mt.Name);
									this.<ctx>5__4.SaveChanges();
									this.<history>5__3.AddRepairLog("workAdded", new WorkPartObject
									{
										Name = works.name,
										RepairId = cartridgeEx.Id,
										Count = 1,
										Price = works.price
									});
									store_items material = this.<ctx>5__4.store_items.FirstOrDefault((store_items i) => i.id == this.<>8__1.mt.UseItemId);
									store_int_reserve store_int_reserve = cartridgeEx.CreateReserve(material, this.<>8__1.mt, works.id, this.<ctx>5__4);
									this.<ctx>5__4.SaveChanges();
									this.<history>5__3.AddItemLog("GivePart2User", store_int_reserve.item_id, OfflineData.Instance.Employee.FioShort, "");
									this.<transaction>5__5.Commit();
									this.<>7__wrap5 = cartridgeEx.Id;
									awaiter = RepairModel.GetRepairCostTotal(cartridgeEx.Id).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num6 = 0;
										num = 0;
										this.<>1__state = num6;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, CartridgeEx.<AddWorks>d__63>(ref awaiter, ref this);
										return;
									}
									break;
								}
								}
								decimal result = awaiter.GetResult();
								RepairModel.SetRealRepairCost(this.<>7__wrap5, result);
								if (cartridgeEx.Status == 4)
								{
									goto IL_2EE;
								}
								cartridgeEx.Status = 4;
								awaiter2 = cartridgeEx.StatusChanged().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num7 = 1;
									num = 1;
									this.<>1__state = num7;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Result>, CartridgeEx.<AddWorks>d__63>(ref awaiter2, ref this);
									return;
								}
								IL_2E6:
								awaiter2.GetResult();
								IL_2EE:
								this.<result>5__2.SetSuccess();
								awaiter3 = cartridgeEx.ReloadWorks().GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									int num8 = 2;
									num = 2;
									this.<>1__state = num8;
									this.<>u__3 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<AddWorks>d__63>(ref awaiter3, ref this);
									return;
								}
								IL_350:
								awaiter3.GetResult();
								awaiter3 = cartridgeEx.ReloadParts().GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									int num9 = 3;
									num = 3;
									this.<>1__state = num9;
									this.<>u__3 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<AddWorks>d__63>(ref awaiter3, ref this);
									return;
								}
								IL_3AE:
								awaiter3.GetResult();
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex);
								this.<transaction>5__5.Rollback();
								this.<result>5__2.Message = ex.Message;
							}
							finally
							{
								if (num < 0 && this.<transaction>5__5 != null)
								{
									((IDisposable)this.<transaction>5__5).Dispose();
								}
							}
							this.<transaction>5__5 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
						this.<ctx>5__4 = null;
						this.<history>5__3.Save();
					}
					catch (Exception ex2)
					{
						Console.WriteLine(ex2);
						this.<result>5__2.Message = ex2.Message;
					}
					cartridgeEx.PostWorksChanged((Material.MaterialType)this.<>8__1.mt.Type, this.<result>5__2);
					result2 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<result>5__2 = null;
					this.<history>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<result>5__2 = null;
				this.<history>5__3 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x0600437E RID: 17278 RVA: 0x001085E4 File Offset: 0x001067E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002B79 RID: 11129
			public int <>1__state;

			// Token: 0x04002B7A RID: 11130
			public AsyncTaskMethodBuilder<Result> <>t__builder;

			// Token: 0x04002B7B RID: 11131
			public IMaterial mt;

			// Token: 0x04002B7C RID: 11132
			public CartridgeEx <>4__this;

			// Token: 0x04002B7D RID: 11133
			private CartridgeEx.<>c__DisplayClass63_0 <>8__1;

			// Token: 0x04002B7E RID: 11134
			private Result <result>5__2;

			// Token: 0x04002B7F RID: 11135
			private HistoryV2 <history>5__3;

			// Token: 0x04002B80 RID: 11136
			private auseceEntities <ctx>5__4;

			// Token: 0x04002B81 RID: 11137
			private DbContextTransaction <transaction>5__5;

			// Token: 0x04002B82 RID: 11138
			private int <>7__wrap5;

			// Token: 0x04002B83 RID: 11139
			private TaskAwaiter<decimal> <>u__1;

			// Token: 0x04002B84 RID: 11140
			private TaskAwaiter<Result> <>u__2;

			// Token: 0x04002B85 RID: 11141
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020008A1 RID: 2209
		[CompilerGenerated]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x0600437F RID: 17279 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x04002B86 RID: 11142
			public CartridgeEx <>4__this;

			// Token: 0x04002B87 RID: 11143
			public int workType;
		}

		// Token: 0x020008A2 RID: 2210
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveWorks>d__64 : IAsyncStateMachine
		{
			// Token: 0x06004380 RID: 17280 RVA: 0x00108600 File Offset: 0x00106800
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				Result result3;
				try
				{
					CartridgeEx.<>c__DisplayClass64_0 CS$<>8__locals1;
					if (num > 3)
					{
						CS$<>8__locals1 = new CartridgeEx.<>c__DisplayClass64_0();
						CS$<>8__locals1.<>4__this = this.<>4__this;
						this.<result>5__2 = new Result();
						this.<history>5__3 = new HistoryV2();
					}
					try
					{
						if (num > 3)
						{
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							if (num > 3)
							{
								this.<transaction>5__5 = this.<ctx>5__4.Database.BeginTransaction();
							}
							try
							{
								TaskAwaiter<works> awaiter;
								TaskAwaiter<decimal> awaiter2;
								TaskAwaiter awaiter3;
								switch (num)
								{
								case 0:
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<works>);
									int num2 = -1;
									num = -1;
									this.<>1__state = num2;
									break;
								}
								case 1:
								{
									awaiter2 = this.<>u__2;
									this.<>u__2 = default(TaskAwaiter<decimal>);
									int num3 = -1;
									num = -1;
									this.<>1__state = num3;
									goto IL_291;
								}
								case 2:
								{
									awaiter3 = this.<>u__3;
									this.<>u__3 = default(TaskAwaiter);
									int num4 = -1;
									num = -1;
									this.<>1__state = num4;
									goto IL_309;
								}
								case 3:
								{
									awaiter3 = this.<>u__3;
									this.<>u__3 = default(TaskAwaiter);
									int num5 = -1;
									num = -1;
									this.<>1__state = num5;
									goto IL_367;
								}
								default:
									CS$<>8__locals1.workType = (int)cartridgeEx.GetWorkType(this.materialType);
									cartridgeEx.CancelReserve(this.<ctx>5__4, this.<history>5__3, CS$<>8__locals1.workType);
									awaiter = this.<ctx>5__4.works.FirstOrDefaultAsync((works w) => w.repair == (int?)cartridgeEx.Id && w.type == CS$<>8__locals1.workType).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num6 = 0;
										num = 0;
										this.<>1__state = num6;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<works>, CartridgeEx.<RemoveWorks>d__64>(ref awaiter, ref this);
										return;
									}
									break;
								}
								works result = awaiter.GetResult();
								if (result != null)
								{
									this.<ctx>5__4.works.Remove(result);
									this.<history>5__3.AddRepairLog("workRemoved", new WorkPartObject
									{
										Name = result.name,
										RepairId = cartridgeEx.Id,
										Count = 1,
										Price = result.price
									});
								}
								this.<ctx>5__4.SaveChanges();
								this.<transaction>5__5.Commit();
								awaiter2 = RepairModel.GetRepairCostTotal(cartridgeEx.Id).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									int num7 = 1;
									num = 1;
									this.<>1__state = num7;
									this.<>u__2 = awaiter2;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, CartridgeEx.<RemoveWorks>d__64>(ref awaiter2, ref this);
									return;
								}
								IL_291:
								decimal result2 = awaiter2.GetResult();
								RepairModel.SetRealRepairCost(cartridgeEx.Id, result2);
								this.<result>5__2.SetSuccess();
								awaiter3 = cartridgeEx.ReloadWorks().GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									int num8 = 2;
									num = 2;
									this.<>1__state = num8;
									this.<>u__3 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<RemoveWorks>d__64>(ref awaiter3, ref this);
									return;
								}
								IL_309:
								awaiter3.GetResult();
								awaiter3 = cartridgeEx.ReloadParts().GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									int num9 = 3;
									num = 3;
									this.<>1__state = num9;
									this.<>u__3 = awaiter3;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<RemoveWorks>d__64>(ref awaiter3, ref this);
									return;
								}
								IL_367:
								awaiter3.GetResult();
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex);
								this.<transaction>5__5.Rollback();
								this.<result>5__2.Message = ex.Message;
							}
							finally
							{
								if (num < 0 && this.<transaction>5__5 != null)
								{
									((IDisposable)this.<transaction>5__5).Dispose();
								}
							}
							this.<transaction>5__5 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
						this.<ctx>5__4 = null;
						this.<history>5__3.Save();
					}
					catch (Exception ex2)
					{
						Console.WriteLine(ex2);
						this.<result>5__2.Message = ex2.Message;
					}
					cartridgeEx.PostWorksChanged(this.materialType, this.<result>5__2);
					result3 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<history>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<history>5__3 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x06004381 RID: 17281 RVA: 0x00108AF4 File Offset: 0x00106CF4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002B88 RID: 11144
			public int <>1__state;

			// Token: 0x04002B89 RID: 11145
			public AsyncTaskMethodBuilder<Result> <>t__builder;

			// Token: 0x04002B8A RID: 11146
			public CartridgeEx <>4__this;

			// Token: 0x04002B8B RID: 11147
			public Material.MaterialType materialType;

			// Token: 0x04002B8C RID: 11148
			private Result <result>5__2;

			// Token: 0x04002B8D RID: 11149
			private HistoryV2 <history>5__3;

			// Token: 0x04002B8E RID: 11150
			private auseceEntities <ctx>5__4;

			// Token: 0x04002B8F RID: 11151
			private DbContextTransaction <transaction>5__5;

			// Token: 0x04002B90 RID: 11152
			private TaskAwaiter<works> <>u__1;

			// Token: 0x04002B91 RID: 11153
			private TaskAwaiter<decimal> <>u__2;

			// Token: 0x04002B92 RID: 11154
			private TaskAwaiter <>u__3;
		}

		// Token: 0x020008A3 RID: 2211
		[CompilerGenerated]
		private sealed class <>c__DisplayClass71_0
		{
			// Token: 0x06004382 RID: 17282 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass71_0()
			{
			}

			// Token: 0x04002B93 RID: 11155
			public CartridgeEx <>4__this;

			// Token: 0x04002B94 RID: 11156
			public int workType;

			// Token: 0x04002B95 RID: 11157
			public store_int_reserve reserve;
		}

		// Token: 0x020008A4 RID: 2212
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004383 RID: 17283 RVA: 0x00108B10 File Offset: 0x00106D10
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004384 RID: 17284 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04002B96 RID: 11158
			public static readonly CartridgeEx.<>c <>9 = new CartridgeEx.<>c();
		}

		// Token: 0x020008A5 RID: 2213
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <MasterChanged>d__72 : IAsyncStateMachine
		{
			// Token: 0x06004385 RID: 17285 RVA: 0x00108B28 File Offset: 0x00106D28
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				Result result2;
				try
				{
					if (num > 4)
					{
						this.<result>5__2 = new Result();
						this.<history>5__3 = new HistoryV2();
					}
					try
					{
						if (num > 4)
						{
							this.<ctx>5__4 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<works>> awaiter;
							TaskAwaiter<workshop> awaiter2;
							TaskAwaiter<int> awaiter3;
							TaskAwaiter awaiter4;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<works>>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<workshop>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_23F;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_2BD;
							}
							case 3:
							{
								awaiter4 = this.<>u__4;
								this.<>u__4 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_36D;
							}
							case 4:
							{
								awaiter4 = this.<>u__4;
								this.<>u__4 = default(TaskAwaiter);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_3F6;
							}
							default:
								awaiter = (from w in this.<ctx>5__4.works
								where w.repair == (int?)cartridgeEx.Id
								select w).ToListAsync<works>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num7 = 0;
									num = 0;
									this.<>1__state = num7;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<works>>, CartridgeEx.<MasterChanged>d__72>(ref awaiter, ref this);
									return;
								}
								break;
							}
							List<works>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									works works = enumerator.Current;
									works.user = cartridgeEx.MasterId.Value;
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
							awaiter2 = (from w in this.<ctx>5__4.workshop
							where w.id == cartridgeEx.Id
							select w).FirstOrDefaultAsync<workshop>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num8 = 1;
								num = 1;
								this.<>1__state = num8;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, CartridgeEx.<MasterChanged>d__72>(ref awaiter2, ref this);
								return;
							}
							IL_23F:
							workshop result = awaiter2.GetResult();
							this.<cartridge>5__5 = result;
							this.<cartridge>5__5.master = cartridgeEx.MasterId;
							awaiter3 = this.<ctx>5__4.SaveChangesAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 2;
								num = 2;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeEx.<MasterChanged>d__72>(ref awaiter3, ref this);
								return;
							}
							IL_2BD:
							awaiter3.GetResult();
							awaiter4 = this.<ctx>5__4.Entry<workshop>(this.<cartridge>5__5).Reference<users>((workshop c) => c.master_users).LoadAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								int num10 = 3;
								num = 3;
								this.<>1__state = num10;
								this.<>u__4 = awaiter4;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<MasterChanged>d__72>(ref awaiter4, ref this);
								return;
							}
							IL_36D:
							awaiter4.GetResult();
							this.<history>5__3.AddRepairLog("masterChanged", cartridgeEx.Id, this.<cartridge>5__5.master_users, null, null, null, null, null);
							awaiter4 = this.<history>5__3.SaveAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								int num11 = 4;
								num = 4;
								this.<>1__state = num11;
								this.<>u__4 = awaiter4;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<MasterChanged>d__72>(ref awaiter4, ref this);
								return;
							}
							IL_3F6:
							awaiter4.GetResult();
							this.<cartridge>5__5 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__4 != null)
							{
								((IDisposable)this.<ctx>5__4).Dispose();
							}
						}
						this.<ctx>5__4 = null;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex);
						this.<result>5__2.Message = ex.Message;
					}
					this.<result>5__2.IsSucces = true;
					this.<result>5__2.MessageFromResource("Saved");
					result2 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<history>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<history>5__3 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004386 RID: 17286 RVA: 0x0010904C File Offset: 0x0010724C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002B97 RID: 11159
			public int <>1__state;

			// Token: 0x04002B98 RID: 11160
			public AsyncTaskMethodBuilder<Result> <>t__builder;

			// Token: 0x04002B99 RID: 11161
			public CartridgeEx <>4__this;

			// Token: 0x04002B9A RID: 11162
			private Result <result>5__2;

			// Token: 0x04002B9B RID: 11163
			private HistoryV2 <history>5__3;

			// Token: 0x04002B9C RID: 11164
			private auseceEntities <ctx>5__4;

			// Token: 0x04002B9D RID: 11165
			private workshop <cartridge>5__5;

			// Token: 0x04002B9E RID: 11166
			private TaskAwaiter<List<works>> <>u__1;

			// Token: 0x04002B9F RID: 11167
			private TaskAwaiter<workshop> <>u__2;

			// Token: 0x04002BA0 RID: 11168
			private TaskAwaiter<int> <>u__3;

			// Token: 0x04002BA1 RID: 11169
			private TaskAwaiter <>u__4;
		}

		// Token: 0x020008A6 RID: 2214
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <StatusChanged>d__73 : IAsyncStateMachine
		{
			// Token: 0x06004387 RID: 17287 RVA: 0x00109068 File Offset: 0x00107268
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				Result result;
				try
				{
					if (num > 4)
					{
						this.<result>5__2 = new Result();
						this.<history>5__3 = new HistoryV2();
						this.<originalState>5__4 = 0;
					}
					try
					{
						if (num > 4)
						{
							this.<ctx>5__5 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<workshop> awaiter;
							TaskAwaiter<int> awaiter2;
							TaskAwaiter awaiter3;
							TaskAwaiter<Result> awaiter4;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<workshop>);
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
								goto IL_284;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_2E8;
							}
							case 3:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_360;
							}
							case 4:
							{
								awaiter4 = this.<>u__4;
								this.<>u__4 = default(TaskAwaiter<Result>);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_3E9;
							}
							default:
								if (cartridgeEx.Status == 6 && !this.<ctx>5__5.works.Any((works w) => w.repair == (int?)cartridgeEx.Id))
								{
									this.<result>5__2.MessageFromResource("InputWorkName");
									result = this.<result>5__2;
									goto IL_496;
								}
								awaiter = (from w in this.<ctx>5__5.workshop
								where w.id == cartridgeEx.Id
								select w).FirstOrDefaultAsync<workshop>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num7 = 0;
									num = 0;
									this.<>1__state = num7;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<workshop>, CartridgeEx.<StatusChanged>d__73>(ref awaiter, ref this);
									return;
								}
								break;
							}
							workshop result2 = awaiter.GetResult();
							this.<cartridge>5__6 = result2;
							this.<originalState>5__4 = this.<cartridge>5__6.state;
							this.<cartridge>5__6.new_state = cartridgeEx.Status;
							this.<history>5__3.StateChangeLog(this.<cartridge>5__6);
							this.<cartridge>5__6.state = this.<cartridge>5__6.new_state;
							awaiter2 = this.<ctx>5__5.SaveChangesAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num8 = 1;
								num = 1;
								this.<>1__state = num8;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CartridgeEx.<StatusChanged>d__73>(ref awaiter2, ref this);
								return;
							}
							IL_284:
							awaiter2.GetResult();
							awaiter3 = this.<history>5__3.SaveAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num9 = 2;
								num = 2;
								this.<>1__state = num9;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<StatusChanged>d__73>(ref awaiter3, ref this);
								return;
							}
							IL_2E8:
							awaiter3.GetResult();
							awaiter3 = Bootstrapper.Container.Resolve<IWorkshopStatusService>().UpdateStatusLog(this.<ctx>5__5, new RepairStatusLogModel(this.<cartridge>5__6)).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num10 = 3;
								num = 3;
								this.<>1__state = num10;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, CartridgeEx.<StatusChanged>d__73>(ref awaiter3, ref this);
								return;
							}
							IL_360:
							awaiter3.GetResult();
							if (cartridgeEx.MasterId != null)
							{
								goto IL_3F1;
							}
							cartridgeEx.MasterId = new int?(OfflineData.Instance.Employee.Id);
							awaiter4 = cartridgeEx.MasterChanged().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								int num11 = 4;
								num = 4;
								this.<>1__state = num11;
								this.<>u__4 = awaiter4;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Result>, CartridgeEx.<StatusChanged>d__73>(ref awaiter4, ref this);
								return;
							}
							IL_3E9:
							awaiter4.GetResult();
							IL_3F1:
							this.<cartridge>5__6 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__5 != null)
							{
								((IDisposable)this.<ctx>5__5).Dispose();
							}
						}
						this.<ctx>5__5 = null;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex);
						this.<result>5__2.Message = ex.Message;
						cartridgeEx.FallbackStatus(this.<originalState>5__4);
						result = this.<result>5__2;
						goto IL_496;
					}
					this.<result>5__2.SetSuccess();
					this.<result>5__2.MessageFromResource("Saved");
					result = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<history>5__3 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_496:
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<history>5__3 = null;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004388 RID: 17288 RVA: 0x0010957C File Offset: 0x0010777C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BA2 RID: 11170
			public int <>1__state;

			// Token: 0x04002BA3 RID: 11171
			public AsyncTaskMethodBuilder<Result> <>t__builder;

			// Token: 0x04002BA4 RID: 11172
			public CartridgeEx <>4__this;

			// Token: 0x04002BA5 RID: 11173
			private Result <result>5__2;

			// Token: 0x04002BA6 RID: 11174
			private HistoryV2 <history>5__3;

			// Token: 0x04002BA7 RID: 11175
			private int <originalState>5__4;

			// Token: 0x04002BA8 RID: 11176
			private auseceEntities <ctx>5__5;

			// Token: 0x04002BA9 RID: 11177
			private workshop <cartridge>5__6;

			// Token: 0x04002BAA RID: 11178
			private TaskAwaiter<workshop> <>u__1;

			// Token: 0x04002BAB RID: 11179
			private TaskAwaiter<int> <>u__2;

			// Token: 0x04002BAC RID: 11180
			private TaskAwaiter <>u__3;

			// Token: 0x04002BAD RID: 11181
			private TaskAwaiter<Result> <>u__4;
		}

		// Token: 0x020008A7 RID: 2215
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CalcTotal>d__75 : IAsyncStateMachine
		{
			// Token: 0x06004389 RID: 17289 RVA: 0x00109598 File Offset: 0x00107798
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				try
				{
					TaskAwaiter<decimal> awaiter;
					TaskAwaiter<Invoice> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<decimal>);
						this.<>1__state = -1;
						goto IL_147;
					case 2:
						awaiter2 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<Invoice>);
						this.<>1__state = -1;
						goto IL_175;
					default:
						awaiter = RepairModel.GetRepairCostTotal(cartridgeEx.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, CartridgeEx.<CalcTotal>d__75>(ref awaiter, ref this);
							return;
						}
						break;
					}
					decimal result = awaiter.GetResult();
					cartridgeEx.Total = result;
					if (cartridgeEx.InvoiceId != null)
					{
						awaiter2 = Bootstrapper.Container.Resolve<IInvoiceService>().GetInvoice(cartridgeEx.InvoiceId.Value).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__2 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Invoice>, CartridgeEx.<CalcTotal>d__75>(ref awaiter2, ref this);
							return;
						}
						goto IL_175;
					}
					else
					{
						awaiter = RepairModel.GetAlreadyPayedSumm(cartridgeEx.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<decimal>, CartridgeEx.<CalcTotal>d__75>(ref awaiter, ref this);
							return;
						}
					}
					IL_147:
					result = awaiter.GetResult();
					cartridgeEx.PrePaid = result;
					goto IL_19B;
					IL_175:
					Invoice result2 = awaiter2.GetResult();
					cartridgeEx.PrePaid = ((result2.State == 2) ? cartridgeEx.Total : 0m);
					IL_19B:
					cartridgeEx.FinalAmount = cartridgeEx.Total - cartridgeEx.PrePaid;
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

			// Token: 0x0600438A RID: 17290 RVA: 0x001097A4 File Offset: 0x001079A4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BAE RID: 11182
			public int <>1__state;

			// Token: 0x04002BAF RID: 11183
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002BB0 RID: 11184
			public CartridgeEx <>4__this;

			// Token: 0x04002BB1 RID: 11185
			private TaskAwaiter<decimal> <>u__1;

			// Token: 0x04002BB2 RID: 11186
			private TaskAwaiter<Invoice> <>u__2;
		}

		// Token: 0x020008A8 RID: 2216
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Issue>d__81 : IAsyncStateMachine
		{
			// Token: 0x0600438B RID: 17291 RVA: 0x001097C0 File Offset: 0x001079C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				CartridgeEx cartridgeEx = this.<>4__this;
				try
				{
					if (num != 0)
					{
						this.<history>5__2 = new HistoryV2();
					}
					try
					{
						TaskAwaiter<List<store_int_reserve>> awaiter;
						if (num != 0)
						{
							this.<rModel>5__3 = new RepairModel();
							awaiter = RepairModel.LoadParts(cartridgeEx.Id).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<store_int_reserve>>, CartridgeEx.<Issue>d__81>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<List<store_int_reserve>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<store_int_reserve> result = awaiter.GetResult();
						if (result.Any<store_int_reserve>())
						{
							this.<rModel>5__3.SubstractItems(result, cartridgeEx.Id, cartridgeEx.CustomerId);
						}
						int num4 = this.<rModel>5__3.IsRepairOk(cartridgeEx.Status) ? 8 : 12;
						auseceEntities auseceEntities = new auseceEntities(true);
						try
						{
							workshop workshop = auseceEntities.workshop.Find(new object[]
							{
								cartridgeEx.Id
							});
							if (workshop.box != null)
							{
								string prm = (workshop.boxes == null) ? "" : workshop.boxes.name;
								this.<history>5__2.AddRepairLog("removedFromBox", cartridgeEx.Id, prm, "");
								workshop.box = null;
							}
							workshop.out_date = new DateTime?(cartridgeEx.localization.Now);
							workshop.state = num4;
							workshop.payment_system = cartridgeEx.PaymentSystem;
							auseceEntities.SaveChanges();
							this.<history>5__2.Save();
							if (num4 == 8)
							{
								if (cartridgeEx.FinalAmount > 0m)
								{
									if (cartridgeEx.PaymentSystem != -2)
									{
										KassaModel kassaModel = new KassaModel();
										kassaModel.NewCashOrder(workshop, cartridgeEx.FinalAmount);
										kassaModel.MakePko(false);
										cartridgeEx._cashOrderId = kassaModel.Order.id;
									}
									else
									{
										this.<history>5__2.AddRepairLog("BalancePayment", cartridgeEx.Id, string.Format("{0}", cartridgeEx.FinalAmount), "");
										KassaModel.SubstractCustomerBalance(cartridgeEx.CustomerId, cartridgeEx.FinalAmount, Kassa.Balance.RepairFromBalance, new int?(cartridgeEx.Id), 0);
										this.<history>5__2.Save();
									}
								}
							}
						}
						finally
						{
							if (num < 0 && auseceEntities != null)
							{
								((IDisposable)auseceEntities).Dispose();
							}
						}
						this.<rModel>5__3 = null;
					}
					catch (Exception value)
					{
						Console.WriteLine(value);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<history>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<history>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600438C RID: 17292 RVA: 0x00109ABC File Offset: 0x00107CBC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BB3 RID: 11187
			public int <>1__state;

			// Token: 0x04002BB4 RID: 11188
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002BB5 RID: 11189
			public CartridgeEx <>4__this;

			// Token: 0x04002BB6 RID: 11190
			private HistoryV2 <history>5__2;

			// Token: 0x04002BB7 RID: 11191
			private RepairModel <rModel>5__3;

			// Token: 0x04002BB8 RID: 11192
			private TaskAwaiter<List<store_int_reserve>> <>u__1;
		}
	}
}
