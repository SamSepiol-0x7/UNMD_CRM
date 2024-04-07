using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ASC.Common;
using ASC.Common.Repositories;
using ASC.Persistence.Repositories;
using Autofac;

namespace ASC.Persistence
{
	// Token: 0x020002E1 RID: 737
	public class UoW : IDisposable, IUoW
	{
		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x0006CD08 File Offset: 0x0006AF08
		public IPackingListRepository PackingLists
		{
			[CompilerGenerated]
			get
			{
				return this.<PackingLists>k__BackingField;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x0006CD1C File Offset: 0x0006AF1C
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0006CD30 File Offset: 0x0006AF30
		public IVATInvoiceRepository VATInvoices
		{
			[CompilerGenerated]
			get
			{
				return this.<VATInvoices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<VATInvoices>k__BackingField = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x0006CD44 File Offset: 0x0006AF44
		public IWorksListRepository WorksList
		{
			[CompilerGenerated]
			get
			{
				return this.<WorksList>k__BackingField;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0006CD58 File Offset: 0x0006AF58
		public IPaymentDetailRepository PaymentDetails
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentDetails>k__BackingField;
			}
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0006CD6C File Offset: 0x0006AF6C
		public UoW()
		{
			this._context = Bootstrapper.Container.Resolve<auseceEntities>();
			this.PackingLists = new PackingListRepository(this._context);
			this.VATInvoices = new VATInvoiceRepository(this._context);
			this.WorksList = new WokrsListRepository(this._context);
			this.PaymentDetails = new PaymentDetailRepository(this._context);
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x0006CDD4 File Offset: 0x0006AFD4
		public UoW(auseceEntities context) : this()
		{
			this._context = context;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0006CDF0 File Offset: 0x0006AFF0
		public void Complete()
		{
			this._context.SaveChanges();
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0006CE0C File Offset: 0x0006B00C
		public Task CompleteAsync()
		{
			return this._context.SaveChangesAsync();
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0006CE24 File Offset: 0x0006B024
		public void Dispose()
		{
			auseceEntities context = this._context;
			if (context == null)
			{
				return;
			}
			context.Dispose();
		}

		// Token: 0x0400130C RID: 4876
		private readonly auseceEntities _context;

		// Token: 0x0400130D RID: 4877
		[CompilerGenerated]
		private readonly IPackingListRepository <PackingLists>k__BackingField;

		// Token: 0x0400130E RID: 4878
		[CompilerGenerated]
		private IVATInvoiceRepository <VATInvoices>k__BackingField;

		// Token: 0x0400130F RID: 4879
		[CompilerGenerated]
		private readonly IWorksListRepository <WorksList>k__BackingField;

		// Token: 0x04001310 RID: 4880
		[CompilerGenerated]
		private readonly IPaymentDetailRepository <PaymentDetails>k__BackingField;
	}
}
