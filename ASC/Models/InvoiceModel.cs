using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ASC.Common;
using ASC.Common.Interfaces;
using ASC.Common.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.Options;
using ASC.Services.Abstract;
using Autofac;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000973 RID: 2419
	public class InvoiceModel : InvoiceModel
	{
		// Token: 0x060049A9 RID: 18857 RVA: 0x00123160 File Offset: 0x00121360
		public InvoiceModel()
		{
			this._uoW = Bootstrapper.Container.Resolve<IUoW>();
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x00123184 File Offset: 0x00121384
		public InvoiceModel(IUoW uow)
		{
			this._uoW = uow;
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x001231A0 File Offset: 0x001213A0
		public static Task<int> AddPaymentDetails(IPaymentDetails details)
		{
			InvoiceModel.<AddPaymentDetails>d__4 <AddPaymentDetails>d__;
			<AddPaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<AddPaymentDetails>d__.details = details;
			<AddPaymentDetails>d__.<>1__state = -1;
			<AddPaymentDetails>d__.<>t__builder.Start<InvoiceModel.<AddPaymentDetails>d__4>(ref <AddPaymentDetails>d__);
			return <AddPaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x001231E4 File Offset: 0x001213E4
		public static Task UpdatePaymentDetails(IPaymentDetails details)
		{
			InvoiceModel.<UpdatePaymentDetails>d__5 <UpdatePaymentDetails>d__;
			<UpdatePaymentDetails>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdatePaymentDetails>d__.details = details;
			<UpdatePaymentDetails>d__.<>1__state = -1;
			<UpdatePaymentDetails>d__.<>t__builder.Start<InvoiceModel.<UpdatePaymentDetails>d__5>(ref <UpdatePaymentDetails>d__);
			return <UpdatePaymentDetails>d__.<>t__builder.Task;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x00123228 File Offset: 0x00121428
		private static int? UpdateImage(byte[] newImage, int? banksImgId, auseceEntities ctx)
		{
			if (newImage == null)
			{
				if (banksImgId != null)
				{
					images images = ctx.images.Find(new object[]
					{
						banksImgId
					});
					if (images != null)
					{
						ctx.images.Remove(images);
					}
				}
				return null;
			}
			if (banksImgId == null)
			{
				return new int?(InvoiceModel.AddNewPaymentImg(ctx, newImage));
			}
			images images2 = ctx.images.Find(new object[]
			{
				banksImgId
			});
			if (images2 != null)
			{
				images2.img = newImage;
				images2.preview = MediaModel.MakePreview(newImage);
				return banksImgId;
			}
			return new int?(InvoiceModel.AddNewPaymentImg(ctx, newImage));
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x001232CC File Offset: 0x001214CC
		private static int AddNewPaymentImg(auseceEntities ctx, byte[] newImage)
		{
			images images = InvoiceModel.NewPaymentImg(newImage);
			ctx.images.Add(images);
			ctx.SaveChanges();
			return images.id;
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x001232FC File Offset: 0x001214FC
		private static images NewPaymentImg(byte[] input)
		{
			return new images
			{
				img = input,
				preview = MediaModel.MakePreview(input),
				uid = new int?(Auth.User.id),
				added = new DateTime?(DateTime.UtcNow)
			};
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00123348 File Offset: 0x00121548
		public static Task<VATInvoice> GetVATInvoice(int invoiceId)
		{
			InvoiceModel.<GetVATInvoice>d__9 <GetVATInvoice>d__;
			<GetVATInvoice>d__.<>t__builder = AsyncTaskMethodBuilder<VATInvoice>.Create();
			<GetVATInvoice>d__.invoiceId = invoiceId;
			<GetVATInvoice>d__.<>1__state = -1;
			<GetVATInvoice>d__.<>t__builder.Start<InvoiceModel.<GetVATInvoice>d__9>(ref <GetVATInvoice>d__);
			return <GetVATInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x0012338C File Offset: 0x0012158C
		public static Task<VATInvoice> GetVATInvoice(IInvoice invoice)
		{
			InvoiceModel.<GetVATInvoice>d__10 <GetVATInvoice>d__;
			<GetVATInvoice>d__.<>t__builder = AsyncTaskMethodBuilder<VATInvoice>.Create();
			<GetVATInvoice>d__.invoice = invoice;
			<GetVATInvoice>d__.<>1__state = -1;
			<GetVATInvoice>d__.<>t__builder.Start<InvoiceModel.<GetVATInvoice>d__10>(ref <GetVATInvoice>d__);
			return <GetVATInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x001233D0 File Offset: 0x001215D0
		public static Task<PackingList> GetPackingList(int invoiceId)
		{
			InvoiceModel.<GetPackingList>d__11 <GetPackingList>d__;
			<GetPackingList>d__.<>t__builder = AsyncTaskMethodBuilder<PackingList>.Create();
			<GetPackingList>d__.invoiceId = invoiceId;
			<GetPackingList>d__.<>1__state = -1;
			<GetPackingList>d__.<>t__builder.Start<InvoiceModel.<GetPackingList>d__11>(ref <GetPackingList>d__);
			return <GetPackingList>d__.<>t__builder.Task;
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00123414 File Offset: 0x00121614
		public static Task<PackingList> GetPackingList(IInvoice invoice)
		{
			InvoiceModel.<GetPackingList>d__12 <GetPackingList>d__;
			<GetPackingList>d__.<>t__builder = AsyncTaskMethodBuilder<PackingList>.Create();
			<GetPackingList>d__.invoice = invoice;
			<GetPackingList>d__.<>1__state = -1;
			<GetPackingList>d__.<>t__builder.Start<InvoiceModel.<GetPackingList>d__12>(ref <GetPackingList>d__);
			return <GetPackingList>d__.<>t__builder.Task;
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x00123458 File Offset: 0x00121658
		public static Task<WorksList> GetWorksList(IInvoice invoice)
		{
			InvoiceModel.<GetWorksList>d__13 <GetWorksList>d__;
			<GetWorksList>d__.<>t__builder = AsyncTaskMethodBuilder<WorksList>.Create();
			<GetWorksList>d__.invoice = invoice;
			<GetWorksList>d__.<>1__state = -1;
			<GetWorksList>d__.<>t__builder.Start<InvoiceModel.<GetWorksList>d__13>(ref <GetWorksList>d__);
			return <GetWorksList>d__.<>t__builder.Task;
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x0012349C File Offset: 0x0012169C
		public static PaymentDetails BankToCustomerPaymentDetails(banks b)
		{
			return new PaymentDetails
			{
				Id = b.id,
				CustomerId = b.client.GetValueOrDefault(),
				Name = b.ur_name,
				Inn = b.inn,
				Kpp = b.kpp,
				Address = b.address,
				CorrespondentAccount = b.correspondent_account,
				CheckingAccount = b.checking_account,
				Bank = b.bank,
				Bic = b.BIC,
				Chief = b.chief,
				Accountant = b.accountant,
				Email = b.email,
				Ogrn = b.ogrn,
				IsArchive = b.archive
			};
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x0012356C File Offset: 0x0012176C
		public static int CreateInvoice(IInvoice invoice)
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							invoice invoice2 = new invoice
							{
								num = invoice.Num,
								created = invoice.Date,
								user = invoice.Employee.Id,
								seller = invoice.Seller.Id,
								customer = invoice.Customer.Id,
								tax = invoice.Tax,
								summ = invoice.Summ,
								total = invoice.Total,
								state = 1,
								office = invoice.Employee.OfficeId,
								notes = invoice.Notes
							};
							auseceEntities.invoice.Add(invoice2);
							auseceEntities.SaveChanges();
							foreach (IInvoiceItem invoiceItem in invoice.Items)
							{
								invoice_items entity = new invoice_items
								{
									name = invoiceItem.Name,
									price = invoiceItem.Price,
									count = invoiceItem.Count,
									units = invoiceItem.Units,
									tax = invoiceItem.Tax.GetValueOrDefault(),
									tax_mode = invoiceItem.TaxMode,
									total = invoiceItem.Total,
									invoice = new int?(invoice2.id),
									repair = invoiceItem.RepairId,
									document = invoiceItem.DocumentId
								};
								if (invoiceItem.RepairId != null)
								{
									workshop workshop = auseceEntities.workshop.Find(new object[]
									{
										invoiceItem.RepairId
									});
									if (workshop != null)
									{
										workshop.payment_system = 1;
										workshop.invoice = new int?(invoice2.id);
									}
								}
								if (invoiceItem.DocumentId != null)
								{
									docs docs = auseceEntities.docs.Find(new object[]
									{
										invoiceItem.DocumentId
									});
									if (docs != null)
									{
										docs.payment_system = 1;
										docs.invoice = new int?(invoice2.id);
										docs.reserve_days += 30;
									}
								}
								auseceEntities.invoice_items.Add(entity);
							}
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							result = invoice2.id;
						}
						catch (Exception ex)
						{
							Exception innerException = ex.InnerException;
							if (((innerException != null) ? innerException.InnerException : null) != null && ex.InnerException.InnerException.Message.Contains("for key 'num'"))
							{
								MessageBox.Show((string)Application.Current.TryFindResource("InvoiceNumErr"));
							}
							InvoiceModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							result = -1;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				InvoiceModel.Log.Error(ex2, ex2.Message);
				result = -1;
			}
			return result;
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x001238F8 File Offset: 0x00121AF8
		public static int CreateVATInvoice(IVATInvoice doc)
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							vat_invoice vat_invoice = new vat_invoice
							{
								num = doc.Num,
								created = doc.Date,
								user = doc.Employee.Id,
								seller = doc.Seller.Id,
								customer = doc.Customer.Id,
								tax = doc.Tax,
								summ = doc.Summ,
								total = doc.Total,
								office = doc.Employee.OfficeId,
								notes = doc.Notes,
								state_contract = doc.StateContract,
								currency = doc.Currency,
								currency_code = doc.CurrencyCode,
								payment_order = doc.PaymentOrder,
								payment_order_date = doc.PaymentOrderDate,
								invoice = doc.InvoiceId
							};
							auseceEntities.vat_invoice.Add(vat_invoice);
							auseceEntities.SaveChanges();
							foreach (IInvoiceItem invoiceItem in doc.Items)
							{
								invoice_items entity = new invoice_items
								{
									name = invoiceItem.Name,
									price = invoiceItem.Price,
									count = invoiceItem.Count,
									units = invoiceItem.Units,
									tax = invoiceItem.Tax.GetValueOrDefault(),
									tax_mode = invoiceItem.TaxMode,
									total = invoiceItem.Total,
									vat_invoice = new int?(vat_invoice.id),
									repair = invoiceItem.RepairId,
									document = invoiceItem.DocumentId
								};
								auseceEntities.invoice_items.Add(entity);
							}
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							result = vat_invoice.id;
						}
						catch (Exception ex)
						{
							Exception innerException = ex.InnerException;
							if (((innerException != null) ? innerException.InnerException : null) != null && ex.InnerException.InnerException.Message.Contains("for key 'num'"))
							{
								MessageBox.Show((string)Application.Current.TryFindResource("InvoiceNumErr"));
							}
							InvoiceModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							result = -1;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				InvoiceModel.Log.Error(ex2, ex2.Message);
				result = -1;
			}
			return result;
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x00123C10 File Offset: 0x00121E10
		public static int CreatePackingList(IPackingList doc)
		{
			int result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							p_lists p_lists = new p_lists
							{
								num = doc.Num,
								created = doc.Date,
								user = doc.Employee.Id,
								seller = doc.Seller.Id,
								customer = doc.Customer.Id,
								tax = doc.Tax,
								summ = doc.Summ,
								total = doc.Total,
								office = doc.Employee.OfficeId,
								notes = doc.Notes,
								invoice = doc.InvoiceId,
								reason = doc.Reason
							};
							auseceEntities.p_lists.Add(p_lists);
							auseceEntities.SaveChanges();
							foreach (IInvoiceItem invoiceItem in doc.Items)
							{
								invoice_items entity = new invoice_items
								{
									name = invoiceItem.Name,
									price = invoiceItem.Price,
									count = invoiceItem.Count,
									units = invoiceItem.Units,
									tax = invoiceItem.Tax.GetValueOrDefault(),
									tax_mode = invoiceItem.TaxMode,
									total = invoiceItem.Total,
									p_list = new int?(p_lists.id),
									repair = invoiceItem.RepairId,
									document = invoiceItem.DocumentId
								};
								auseceEntities.invoice_items.Add(entity);
							}
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
							result = p_lists.id;
						}
						catch (Exception ex)
						{
							Exception innerException = ex.InnerException;
							if (((innerException != null) ? innerException.InnerException : null) != null && ex.InnerException.InnerException.Message.Contains("for key 'num'"))
							{
								MessageBox.Show((string)Application.Current.TryFindResource("InvoiceNumErr"));
							}
							InvoiceModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							result = -1;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				InvoiceModel.Log.Error(ex2, ex2.Message);
				result = -1;
			}
			return result;
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x00123EF8 File Offset: 0x001220F8
		public static Task<bool> ArchiveInvoice(int invoiceId)
		{
			InvoiceModel.<ArchiveInvoice>d__18 <ArchiveInvoice>d__;
			<ArchiveInvoice>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<ArchiveInvoice>d__.invoiceId = invoiceId;
			<ArchiveInvoice>d__.<>1__state = -1;
			<ArchiveInvoice>d__.<>t__builder.Start<InvoiceModel.<ArchiveInvoice>d__18>(ref <ArchiveInvoice>d__);
			return <ArchiveInvoice>d__.<>t__builder.Task;
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00123F3C File Offset: 0x0012213C
		public override IEnumerable<string> GetUnits()
		{
			return new List<string>
			{
				Lang.t("Pcs"),
				Lang.t("ServicesShort"),
				Lang.t("Gram"),
				Lang.t("Kilogram")
			};
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00123F90 File Offset: 0x00122190
		public override Dictionary<int, string> GetTaxModes()
		{
			return new Dictionary<int, string>
			{
				{
					0,
					Lang.t("NoNds")
				},
				{
					1,
					Lang.t("Add")
				},
				{
					2,
					Lang.t("Extract")
				}
			};
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x00123FD8 File Offset: 0x001221D8
		public override Dictionary<int, string> GetDocTypes()
		{
			return new Dictionary<int, string>
			{
				{
					0,
					Lang.t("Invoice")
				},
				{
					1,
					Lang.t("VatInvoice")
				},
				{
					2,
					Lang.t("PackingList")
				},
				{
					3,
					Lang.t("Act")
				}
			};
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00124030 File Offset: 0x00122230
		public override IEnumerable<IIdName> GetStates(bool includeAll = false)
		{
			List<IIdName> list = new List<IIdName>
			{
				new InvoiceOptions(1, Lang.t("InvoiceIssued")),
				new InvoiceOptions(2, Lang.t("InvoicePaid")),
				new InvoiceOptions(3, Lang.t("Arhive"))
			};
			if (includeAll)
			{
				list.Insert(0, new InvoiceOptions(0, Lang.t("All")));
			}
			return list;
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x001240A0 File Offset: 0x001222A0
		public override Dictionary<InvoiceModel.InvoicePrintTypes, string> GetInvoicePrintTypes()
		{
			return new Dictionary<InvoiceModel.InvoicePrintTypes, string>
			{
				{
					InvoiceModel.InvoicePrintTypes.Normal,
					Lang.t("InvoiceNormal")
				},
				{
					InvoiceModel.InvoicePrintTypes.NormalPlusPp,
					Lang.t("NormalPlusPp")
				},
				{
					InvoiceModel.InvoicePrintTypes.WithNdsCol,
					Lang.t("WithNdsCol")
				},
				{
					InvoiceModel.InvoicePrintTypes.WithNdsColPlusPp,
					Lang.t("WithNdsColPlusPp")
				}
			};
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x001240F8 File Offset: 0x001222F8
		public override Dictionary<InvoiceModel.PackingListPrintTypes, string> GetPackingListPrintTypes()
		{
			return new Dictionary<InvoiceModel.PackingListPrintTypes, string>
			{
				{
					InvoiceModel.PackingListPrintTypes.Torg12,
					Lang.t("Torg12")
				}
			};
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x0012411C File Offset: 0x0012231C
		public override Dictionary<InvoiceModel.VatInvoiceType, string> GetVatInvoiceTypes()
		{
			Dictionary<InvoiceModel.VatInvoiceType, string> dictionary = new Dictionary<InvoiceModel.VatInvoiceType, string>();
			dictionary[InvoiceModel.VatInvoiceType.Normal] = Lang.t("InvoiceNormal");
			return dictionary;
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x00124140 File Offset: 0x00122340
		public override Dictionary<InvoiceModel.WorksListPrintTypes, string> GetWorksListPrintTypes()
		{
			Dictionary<InvoiceModel.WorksListPrintTypes, string> dictionary = new Dictionary<InvoiceModel.WorksListPrintTypes, string>();
			dictionary[InvoiceModel.WorksListPrintTypes.Normal] = Lang.t("InvoiceNormal");
			return dictionary;
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00124164 File Offset: 0x00122364
		public override Task<IEnumerable<IInvoice>> GetInvoices(IPeriod period, int officeId, int state, InvoiceModel.DocType docType, string filter)
		{
			switch (docType)
			{
			default:
				return Bootstrapper.Container.Resolve<IInvoiceService>().GetInvoices(period, officeId, state, filter);
			case InvoiceModel.DocType.VATInvoice:
				return this._uoW.VATInvoices.GetInvoices(period, officeId, state, filter);
			case InvoiceModel.DocType.PakingList:
				return this._uoW.PackingLists.GetInvoices(period, officeId, state, filter);
			case InvoiceModel.DocType.ActWorks:
				return this._uoW.WorksList.GetInvoices(period, officeId, state, filter);
			}
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x001241E0 File Offset: 0x001223E0
		// Note: this type is marked as 'beforefieldinit'.
		static InvoiceModel()
		{
		}

		// Token: 0x04002EF0 RID: 12016
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x04002EF1 RID: 12017
		private readonly IUoW _uoW;

		// Token: 0x02000974 RID: 2420
		public enum TaxMode
		{
			// Token: 0x04002EF3 RID: 12019
			NoTax,
			// Token: 0x04002EF4 RID: 12020
			Add,
			// Token: 0x04002EF5 RID: 12021
			Extract
		}

		// Token: 0x02000975 RID: 2421
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AddPaymentDetails>d__4 : IAsyncStateMachine
		{
			// Token: 0x060049C4 RID: 18884 RVA: 0x001241F8 File Offset: 0x001223F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				int result;
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
								banks banks = new banks
								{
									ur_name = this.details.Name,
									client = null,
									company = new int?(this.details.CompanyId),
									inn = this.details.Inn,
									kpp = this.details.Kpp,
									address = this.details.Address,
									correspondent_account = this.details.CorrespondentAccount,
									checking_account = this.details.CheckingAccount,
									bank = this.details.Bank,
									BIC = this.details.Bic,
									chief = this.details.Chief,
									accountant = this.details.Accountant,
									email = this.details.Email,
									ogrn = this.details.Ogrn
								};
								this.<ctx>5__2.banks.Add(banks);
								ISellerPaymentDetails sellerPaymentDetails = this.details as ISellerPaymentDetails;
								if (sellerPaymentDetails != null)
								{
									banks.seal = InvoiceModel.UpdateImage(sellerPaymentDetails.Seal, banks.seal, this.<ctx>5__2);
									banks.chief_signature = InvoiceModel.UpdateImage(sellerPaymentDetails.ChiefSignature, banks.chief_signature, this.<ctx>5__2);
									banks.accountant_signature = InvoiceModel.UpdateImage(sellerPaymentDetails.AccountantSignature, banks.accountant_signature, this.<ctx>5__2);
								}
								awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, InvoiceModel.<AddPaymentDetails>d__4>(ref awaiter, ref this);
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
						InvoiceModel.Log.Error(ex, ex.Message);
						result = 0;
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

			// Token: 0x060049C5 RID: 18885 RVA: 0x001244A4 File Offset: 0x001226A4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002EF6 RID: 12022
			public int <>1__state;

			// Token: 0x04002EF7 RID: 12023
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04002EF8 RID: 12024
			public IPaymentDetails details;

			// Token: 0x04002EF9 RID: 12025
			private auseceEntities <ctx>5__2;

			// Token: 0x04002EFA RID: 12026
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000976 RID: 2422
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdatePaymentDetails>d__5 : IAsyncStateMachine
		{
			// Token: 0x060049C6 RID: 18886 RVA: 0x001244C0 File Offset: 0x001226C0
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
							banks banks = this.<ctx>5__2.banks.Find(new object[]
							{
								this.details.Id
							});
							banks.ur_name = this.details.Name;
							banks.client = ((this.details.CustomerId == 0) ? null : new int?(this.details.CustomerId));
							banks.company = ((this.details.CompanyId == 0) ? null : new int?(this.details.CompanyId));
							banks.inn = this.details.Inn;
							banks.kpp = this.details.Kpp;
							banks.address = this.details.Address;
							banks.correspondent_account = this.details.CorrespondentAccount;
							banks.checking_account = this.details.CheckingAccount;
							banks.bank = this.details.Bank;
							banks.BIC = this.details.Bic;
							banks.chief = this.details.Chief;
							banks.accountant = this.details.Accountant;
							banks.email = this.details.Email;
							banks.ogrn = this.details.Ogrn;
							banks.archive = this.details.IsArchive;
							ISellerPaymentDetails sellerPaymentDetails = this.details as ISellerPaymentDetails;
							if (sellerPaymentDetails != null)
							{
								banks.seal = InvoiceModel.UpdateImage(sellerPaymentDetails.Seal, banks.seal, this.<ctx>5__2);
								banks.chief_signature = InvoiceModel.UpdateImage(sellerPaymentDetails.ChiefSignature, banks.chief_signature, this.<ctx>5__2);
								banks.accountant_signature = InvoiceModel.UpdateImage(sellerPaymentDetails.AccountantSignature, banks.accountant_signature, this.<ctx>5__2);
							}
							awaiter = this.<ctx>5__2.SaveChangesAsync().ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, InvoiceModel.<UpdatePaymentDetails>d__5>(ref awaiter, ref this);
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

			// Token: 0x060049C7 RID: 18887 RVA: 0x001247A4 File Offset: 0x001229A4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002EFB RID: 12027
			public int <>1__state;

			// Token: 0x04002EFC RID: 12028
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002EFD RID: 12029
			public IPaymentDetails details;

			// Token: 0x04002EFE RID: 12030
			private auseceEntities <ctx>5__2;

			// Token: 0x04002EFF RID: 12031
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000977 RID: 2423
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060049C8 RID: 18888 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x04002F00 RID: 12032
			public int invoiceId;
		}

		// Token: 0x02000978 RID: 2424
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetVATInvoice>d__9 : IAsyncStateMachine
		{
			// Token: 0x060049C9 RID: 18889 RVA: 0x001247C0 File Offset: 0x001229C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VATInvoice result;
				try
				{
					InvoiceModel.<>c__DisplayClass9_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceModel.<>c__DisplayClass9_0();
						CS$<>8__locals1.invoiceId = this.invoiceId;
						this.<repo>5__2 = new GenericRepository<vat_invoice>();
					}
					try
					{
						TaskAwaiter<vat_invoice> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((vat_invoice i) => i.id == CS$<>8__locals1.invoiceId, "invoice_items,users,banks,banks1").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<vat_invoice>, InvoiceModel.<GetVATInvoice>d__9>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<vat_invoice>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						VATInvoice vatinvoice = VATInvoiceMapper.VATInvoiveConvert(awaiter.GetResult());
						if (vatinvoice != null)
						{
							vatinvoice.CalcTotal();
						}
						result = vatinvoice;
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

			// Token: 0x060049CA RID: 18890 RVA: 0x0012494C File Offset: 0x00122B4C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F01 RID: 12033
			public int <>1__state;

			// Token: 0x04002F02 RID: 12034
			public AsyncTaskMethodBuilder<VATInvoice> <>t__builder;

			// Token: 0x04002F03 RID: 12035
			public int invoiceId;

			// Token: 0x04002F04 RID: 12036
			private GenericRepository<vat_invoice> <repo>5__2;

			// Token: 0x04002F05 RID: 12037
			private TaskAwaiter<vat_invoice> <>u__1;
		}

		// Token: 0x02000979 RID: 2425
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetVATInvoice>d__10 : IAsyncStateMachine
		{
			// Token: 0x060049CB RID: 18891 RVA: 0x00124968 File Offset: 0x00122B68
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				VATInvoice result;
				try
				{
					TaskAwaiter<VATInvoice> awaiter;
					if (num != 0)
					{
						awaiter = InvoiceModel.GetVATInvoice(this.invoice.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<VATInvoice>, InvoiceModel.<GetVATInvoice>d__10>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<VATInvoice>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060049CC RID: 18892 RVA: 0x00124A20 File Offset: 0x00122C20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F06 RID: 12038
			public int <>1__state;

			// Token: 0x04002F07 RID: 12039
			public AsyncTaskMethodBuilder<VATInvoice> <>t__builder;

			// Token: 0x04002F08 RID: 12040
			public IInvoice invoice;

			// Token: 0x04002F09 RID: 12041
			private TaskAwaiter<VATInvoice> <>u__1;
		}

		// Token: 0x0200097A RID: 2426
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060049CD RID: 18893 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04002F0A RID: 12042
			public int invoiceId;
		}

		// Token: 0x0200097B RID: 2427
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPackingList>d__11 : IAsyncStateMachine
		{
			// Token: 0x060049CE RID: 18894 RVA: 0x00124A3C File Offset: 0x00122C3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingList result;
				try
				{
					InvoiceModel.<>c__DisplayClass11_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceModel.<>c__DisplayClass11_0();
						CS$<>8__locals1.invoiceId = this.invoiceId;
						this.<repo>5__2 = new GenericRepository<p_lists>();
					}
					try
					{
						TaskAwaiter<p_lists> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((p_lists i) => i.id == CS$<>8__locals1.invoiceId, "invoice_items,users,banks,banks1").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<p_lists>, InvoiceModel.<GetPackingList>d__11>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<p_lists>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						PackingList packingList = PackingListMapper.PackingListConvert(awaiter.GetResult());
						if (packingList != null)
						{
							packingList.CalcTotal();
						}
						result = packingList;
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

			// Token: 0x060049CF RID: 18895 RVA: 0x00124BC8 File Offset: 0x00122DC8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F0B RID: 12043
			public int <>1__state;

			// Token: 0x04002F0C RID: 12044
			public AsyncTaskMethodBuilder<PackingList> <>t__builder;

			// Token: 0x04002F0D RID: 12045
			public int invoiceId;

			// Token: 0x04002F0E RID: 12046
			private GenericRepository<p_lists> <repo>5__2;

			// Token: 0x04002F0F RID: 12047
			private TaskAwaiter<p_lists> <>u__1;
		}

		// Token: 0x0200097C RID: 2428
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetPackingList>d__12 : IAsyncStateMachine
		{
			// Token: 0x060049D0 RID: 18896 RVA: 0x00124BE4 File Offset: 0x00122DE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				PackingList result;
				try
				{
					TaskAwaiter<PackingList> awaiter;
					if (num != 0)
					{
						awaiter = InvoiceModel.GetPackingList(this.invoice.Id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PackingList>, InvoiceModel.<GetPackingList>d__12>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<PackingList>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x060049D1 RID: 18897 RVA: 0x00124C9C File Offset: 0x00122E9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F10 RID: 12048
			public int <>1__state;

			// Token: 0x04002F11 RID: 12049
			public AsyncTaskMethodBuilder<PackingList> <>t__builder;

			// Token: 0x04002F12 RID: 12050
			public IInvoice invoice;

			// Token: 0x04002F13 RID: 12051
			private TaskAwaiter<PackingList> <>u__1;
		}

		// Token: 0x0200097D RID: 2429
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x060049D2 RID: 18898 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x04002F14 RID: 12052
			public IInvoice invoice;
		}

		// Token: 0x0200097E RID: 2430
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetWorksList>d__13 : IAsyncStateMachine
		{
			// Token: 0x060049D3 RID: 18899 RVA: 0x00124CB8 File Offset: 0x00122EB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				WorksList result2;
				try
				{
					InvoiceModel.<>c__DisplayClass13_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new InvoiceModel.<>c__DisplayClass13_0();
						CS$<>8__locals1.invoice = this.invoice;
						this.<repo>5__2 = new GenericRepository<w_lists>();
					}
					try
					{
						TaskAwaiter<w_lists> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetFirstOrDefaultAsync((w_lists i) => i.invoice == (int?)CS$<>8__locals1.invoice.Id, "invoice_items,users,banks,banks1").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<w_lists>, InvoiceModel.<GetWorksList>d__13>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<w_lists>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						w_lists result = awaiter.GetResult();
						if (result != null)
						{
							WorksList worksList = WorksListMapper.WorksListConvert(result);
							if (worksList != null)
							{
								worksList.CalcTotal();
							}
							result2 = worksList;
						}
						else
						{
							result2 = null;
						}
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

			// Token: 0x060049D4 RID: 18900 RVA: 0x00124E74 File Offset: 0x00123074
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F15 RID: 12053
			public int <>1__state;

			// Token: 0x04002F16 RID: 12054
			public AsyncTaskMethodBuilder<WorksList> <>t__builder;

			// Token: 0x04002F17 RID: 12055
			public IInvoice invoice;

			// Token: 0x04002F18 RID: 12056
			private GenericRepository<w_lists> <repo>5__2;

			// Token: 0x04002F19 RID: 12057
			private TaskAwaiter<w_lists> <>u__1;
		}

		// Token: 0x0200097F RID: 2431
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x060049D5 RID: 18901 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x04002F1A RID: 12058
			public int invoiceId;
		}

		// Token: 0x02000980 RID: 2432
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ArchiveInvoice>d__18 : IAsyncStateMachine
		{
			// Token: 0x060049D6 RID: 18902 RVA: 0x00124E90 File Offset: 0x00123090
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				bool result3;
				try
				{
					if (num > 2)
					{
						this.<>8__1 = new InvoiceModel.<>c__DisplayClass18_0();
						this.<>8__1.invoiceId = this.invoiceId;
					}
					try
					{
						if (num > 2)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<invoice> awaiter;
							TaskAwaiter<List<workshop>> awaiter2;
							TaskAwaiter<List<docs>> awaiter3;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<invoice>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<List<workshop>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1A9;
							}
							case 2:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<List<docs>>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_294;
							}
							default:
								awaiter = this.<ctx>5__2.invoice.FindAsync(new object[]
								{
									this.<>8__1.invoiceId
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num5 = 0;
									num = 0;
									this.<>1__state = num5;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<invoice>, InvoiceModel.<ArchiveInvoice>d__18>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult().state = 3;
							awaiter2 = (from r in this.<ctx>5__2.workshop
							where r.invoice == (int?)this.<>8__1.invoiceId
							select r).ToListAsync<workshop>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num6 = 1;
								num = 1;
								this.<>1__state = num6;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<workshop>>, InvoiceModel.<ArchiveInvoice>d__18>(ref awaiter2, ref this);
								return;
							}
							IL_1A9:
							List<workshop> result = awaiter2.GetResult();
							this.<repairs>5__3 = result;
							awaiter3 = (from d in this.<ctx>5__2.docs
							where d.invoice == (int?)this.<>8__1.invoiceId
							select d).ToListAsync<docs>().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num7 = 2;
								num = 2;
								this.<>1__state = num7;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<docs>>, InvoiceModel.<ArchiveInvoice>d__18>(ref awaiter3, ref this);
								return;
							}
							IL_294:
							List<docs> result2 = awaiter3.GetResult();
							if (this.<repairs>5__3.Any<workshop>())
							{
								List<workshop>.Enumerator enumerator = this.<repairs>5__3.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										workshop workshop = enumerator.Current;
										workshop.invoice = null;
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
							}
							if (result2.Any<docs>())
							{
								List<docs>.Enumerator enumerator2 = result2.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										docs docs = enumerator2.Current;
										docs.invoice = null;
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
							this.<ctx>5__2.SaveChanges();
							this.<repairs>5__3 = null;
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
					catch (Exception ex)
					{
						InvoiceModel.Log.Error(ex, ex.Message);
						result3 = false;
						goto IL_3A5;
					}
					result3 = true;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_3A5:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result3);
			}

			// Token: 0x060049D7 RID: 18903 RVA: 0x001252DC File Offset: 0x001234DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F1B RID: 12059
			public int <>1__state;

			// Token: 0x04002F1C RID: 12060
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04002F1D RID: 12061
			public int invoiceId;

			// Token: 0x04002F1E RID: 12062
			private InvoiceModel.<>c__DisplayClass18_0 <>8__1;

			// Token: 0x04002F1F RID: 12063
			private auseceEntities <ctx>5__2;

			// Token: 0x04002F20 RID: 12064
			private List<workshop> <repairs>5__3;

			// Token: 0x04002F21 RID: 12065
			private TaskAwaiter<invoice> <>u__1;

			// Token: 0x04002F22 RID: 12066
			private TaskAwaiter<List<workshop>> <>u__2;

			// Token: 0x04002F23 RID: 12067
			private TaskAwaiter<List<docs>> <>u__3;
		}
	}
}
