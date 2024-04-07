using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Objects.Reports;
using ASC.SimpleClasses;
using ASC.ViewModel;
using DevExpress.XtraReports.UI;
using Microsoft.Win32;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000AB9 RID: 2745
	public class ReportPrintModel
	{
		// Token: 0x06004E5C RID: 20060 RVA: 0x0014F36C File Offset: 0x0014D56C
		public doc_templates GetTemplateItemByName(string name)
		{
			doc_templates firstOrDefault;
			using (GenericRepository<doc_templates> genericRepository = new GenericRepository<doc_templates>())
			{
				firstOrDefault = genericRepository.GetFirstOrDefault((doc_templates t) => t.name == name, "");
			}
			return firstOrDefault;
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x0014F414 File Offset: 0x0014D614
		public bool AddTemplateToDb(doc_templates template)
		{
			bool result;
			using (auseceEntities auseceEntities = new auseceEntities(false))
			{
				try
				{
					auseceEntities.doc_templates.Add(template);
					auseceEntities.SaveChanges();
					result = true;
				}
				catch (Exception exception)
				{
					ReportPrintModel.Log.Error(exception, "Add template to DB fail");
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x0014F47C File Offset: 0x0014D67C
		private doc_templates LoadTemplateById(int id)
		{
			doc_templates result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(false))
				{
					result = auseceEntities.doc_templates.FirstOrDefault((doc_templates t) => t.id == id);
				}
			}
			catch (Exception exception)
			{
				ReportPrintModel.Log.Error(exception, "Load document template error");
				result = null;
			}
			return result;
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x0014F548 File Offset: 0x0014D748
		public static Task<List<DocumentTemplateInfo>> LoadTemplates()
		{
			ReportPrintModel.<LoadTemplates>d__4 <LoadTemplates>d__;
			<LoadTemplates>d__.<>t__builder = AsyncTaskMethodBuilder<List<DocumentTemplateInfo>>.Create();
			<LoadTemplates>d__.<>1__state = -1;
			<LoadTemplates>d__.<>t__builder.Start<ReportPrintModel.<LoadTemplates>d__4>(ref <LoadTemplates>d__);
			return <LoadTemplates>d__.<>t__builder.Task;
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x0014F584 File Offset: 0x0014D784
		public void ExportTemplate2File(int templateId)
		{
			doc_templates doc_templates = this.LoadTemplateById(templateId);
			if (doc_templates != null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					FileName = doc_templates.description,
					Filter = "Fast Report Files (*.frx)|*.frx",
					AddExtension = true,
					DefaultExt = "frx"
				};
				bool? flag = saveFileDialog.ShowDialog();
				if (flag.GetValueOrDefault() & flag != null)
				{
					try
					{
						FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
						using (MemoryStream memoryStream = new MemoryStream(doc_templates.data))
						{
							memoryStream.WriteTo(stream);
						}
					}
					catch (Exception exception)
					{
						ReportPrintModel.Log.Error(exception, "Save document template from db to file error");
					}
				}
				return;
			}
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x0014F650 File Offset: 0x0014D850
		public bool ImportTemplateFromFile(int templateId)
		{
			MemoryStream memoryStream = this.LoadTemplateFromFile();
			if (memoryStream == null)
			{
				return false;
			}
			bool result;
			using (auseceEntities auseceEntities = new auseceEntities(false))
			{
				doc_templates doc_templates = auseceEntities.doc_templates.FirstOrDefault((doc_templates t) => t.id == templateId);
				if (doc_templates != null)
				{
					try
					{
						byte[] array = memoryStream.ToArray();
						doc_templates.data = array;
						doc_templates.checksum = ReportPrintModel.CalculateTemplateCheckSum(array);
						auseceEntities.SaveChanges();
						return true;
					}
					catch (Exception exception)
					{
						ReportPrintModel.Log.Error(exception, "Save document template from file to DB error");
						return false;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x0014F75C File Offset: 0x0014D95C
		private static byte[] CalculateTemplateCheckSum(byte[] template)
		{
			byte[] result;
			using (SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
			{
				try
				{
					result = sha1CryptoServiceProvider.ComputeHash(template);
				}
				catch (Exception exception)
				{
					ReportPrintModel.Log.Error(exception, "Document template checksum calculate error");
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x0014F7B8 File Offset: 0x0014D9B8
		private MemoryStream LoadTemplateFromFile()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Fast Report Files (*.frx)|*.frx"
			};
			bool? flag = openFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				MemoryStream result;
				try
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
						{
							byte[] buffer = new byte[fileStream.Length];
							fileStream.Read(buffer, 0, (int)fileStream.Length);
							memoryStream.Write(buffer, 0, (int)fileStream.Length);
						}
						result = memoryStream;
					}
				}
				catch (Exception exception)
				{
					ReportPrintModel.Log.Error(exception, "Get document template from file error");
					result = null;
				}
				return result;
			}
			return null;
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x0014F8A0 File Offset: 0x0014DAA0
		public int? GetMaxNumber(IEnumerable<DocumentTemplateInfo> templates, string name)
		{
			List<string> list = (from i in templates
			where i.Name.Contains(name)
			select i.Name).ToList<string>();
			if (list.Count != 0)
			{
				if (list.Count == 1)
				{
					if (list.First<string>().All((char c) => !char.IsDigit(c)))
					{
						goto IL_E7;
					}
				}
				List<int> list2 = new List<int>();
				using (List<string>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int item;
						if (int.TryParse(enumerator.Current.Replace(name, ""), out item))
						{
							list2.Add(item);
						}
					}
				}
				return new int?(list2.Max());
			}
			IL_E7:
			return null;
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x0014F9B0 File Offset: 0x0014DBB0
		public static Stream GenerateStreamFromString(string s)
		{
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(memoryStream);
			streamWriter.Write(s);
			streamWriter.Flush();
			memoryStream.Position = 0L;
			return memoryStream;
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x0014F9E4 File Offset: 0x0014DBE4
		private static byte[] GetBuffer(XtraReport report)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				report.SaveLayout(memoryStream);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x0014FA24 File Offset: 0x0014DC24
		public static Task<XtraReport> CreateReport(string templateName)
		{
			ReportPrintModel.<CreateReport>d__12 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.templateName = templateName;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<ReportPrintModel.<CreateReport>d__12>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x0014FA68 File Offset: 0x0014DC68
		private static void AddItemsDemoData(IInvoice invoice)
		{
			InvoiceItem invoiceItem = new InvoiceItem
			{
				Name = "Ремонт ноутбука Asus F5R [TEST]",
				Count = 2.0,
				Price = 2000m,
				Units = "шт."
			};
			invoiceItem.Calculate();
			InvoiceItem invoiceItem2 = new InvoiceItem
			{
				Name = "Ремонт ноутбука Acer Aspire V5 [TEST]",
				Count = 1.0,
				Price = 2300m,
				Units = "шт."
			};
			invoiceItem2.Calculate();
			invoice.Items.Add(invoiceItem);
			invoice.Items.Add(invoiceItem2);
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x0014FB10 File Offset: 0x0014DD10
		private static SellerPaymentDetails SellerDemoData()
		{
			return new SellerPaymentDetails
			{
				Name = "ООО Продавец",
				Address = "г. Подольск пр-т. Жукова 100",
				Bank = "ООО ДРУГОЙ БАНК",
				Bic = "044525225",
				Accountant = "Фёдоров А.Б.",
				Chief = "Фёдоров А.А.",
				CorrespondentAccount = "00000000000000000003",
				CheckingAccount = "00000000000000000004",
				Inn = "1111111111",
				Kpp = "444444444"
			};
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x0014FB90 File Offset: 0x0014DD90
		private static PaymentDetails CustomerDemoData()
		{
			return new PaymentDetails
			{
				Name = "ООО Организация-клиент",
				Address = "г. Москва, ул. Ленина 1а",
				Bank = "ООО БАНК клиента",
				Bic = "522525440",
				Accountant = "Иванов А.Б.",
				Chief = "Иванов А.А.",
				CorrespondentAccount = "00000000000000000001",
				CheckingAccount = "00000000000000000002",
				Inn = "2222222222",
				Kpp = "333333333"
			};
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x0014FC10 File Offset: 0x0014DE10
		public static Task<XtraReport> CreateReport(string templateName, IInvoice invoice)
		{
			ReportPrintModel.<CreateReport>d__16 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.templateName = templateName;
			<CreateReport>d__.invoice = invoice;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<ReportPrintModel.<CreateReport>d__16>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x0014FC5C File Offset: 0x0014DE5C
		public static Task<XtraReport> CreateReport(string templateName, CartridgeReport cartridge)
		{
			ReportPrintModel.<CreateReport>d__17 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.templateName = templateName;
			<CreateReport>d__.cartridge = cartridge;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<ReportPrintModel.<CreateReport>d__17>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x0014FCA8 File Offset: 0x0014DEA8
		public static Task<XtraReport> CreateReport(string templateName, CartridgeIssueReport cartridge)
		{
			ReportPrintModel.<CreateReport>d__18 <CreateReport>d__;
			<CreateReport>d__.<>t__builder = AsyncTaskMethodBuilder<XtraReport>.Create();
			<CreateReport>d__.templateName = templateName;
			<CreateReport>d__.cartridge = cartridge;
			<CreateReport>d__.<>1__state = -1;
			<CreateReport>d__.<>t__builder.Start<ReportPrintModel.<CreateReport>d__18>(ref <CreateReport>d__);
			return <CreateReport>d__.<>t__builder.Task;
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x0014FCF4 File Offset: 0x0014DEF4
		public static Task<byte[]> CreatePdfReport(string templateName, IInvoice invoice)
		{
			ReportPrintModel.<CreatePdfReport>d__19 <CreatePdfReport>d__;
			<CreatePdfReport>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<CreatePdfReport>d__.templateName = templateName;
			<CreatePdfReport>d__.invoice = invoice;
			<CreatePdfReport>d__.<>1__state = -1;
			<CreatePdfReport>d__.<>t__builder.Start<ReportPrintModel.<CreatePdfReport>d__19>(ref <CreatePdfReport>d__);
			return <CreatePdfReport>d__.<>t__builder.Task;
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x0014FD40 File Offset: 0x0014DF40
		public static void SaveTemplate(int templateId, XtraReport report)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					doc_templates doc_templates = auseceEntities.doc_templates.Find(new object[]
					{
						templateId
					});
					if (doc_templates != null)
					{
						doc_templates.data = ReportPrintModel.GetBuffer(report);
						doc_templates.checksum = ReportPrintModel.CalculateTemplateCheckSum(doc_templates.data);
						auseceEntities.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				ReportPrintModel.Log.Error(ex, ex.Message);
			}
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x000046B4 File Offset: 0x000028B4
		public ReportPrintModel()
		{
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x0014FDD8 File Offset: 0x0014DFD8
		// Note: this type is marked as 'beforefieldinit'.
		static ReportPrintModel()
		{
		}

		// Token: 0x040033C7 RID: 13255
		private static readonly ILogger Log = LogManager.GetCurrentClassLogger();

		// Token: 0x02000ABA RID: 2746
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06004E72 RID: 20082 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x040033C8 RID: 13256
			public string name;
		}

		// Token: 0x02000ABB RID: 2747
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004E73 RID: 20083 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040033C9 RID: 13257
			public int id;
		}

		// Token: 0x02000ABC RID: 2748
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E74 RID: 20084 RVA: 0x0014FDF0 File Offset: 0x0014DFF0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004E75 RID: 20085 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004E76 RID: 20086 RVA: 0x0014FE08 File Offset: 0x0014E008
			internal string <GetMaxNumber>b__9_1(DocumentTemplateInfo i)
			{
				return i.Name;
			}

			// Token: 0x06004E77 RID: 20087 RVA: 0x0014FE1C File Offset: 0x0014E01C
			internal bool <GetMaxNumber>b__9_2(char c)
			{
				return !char.IsDigit(c);
			}

			// Token: 0x040033CA RID: 13258
			public static readonly ReportPrintModel.<>c <>9 = new ReportPrintModel.<>c();

			// Token: 0x040033CB RID: 13259
			public static Func<DocumentTemplateInfo, string> <>9__9_1;

			// Token: 0x040033CC RID: 13260
			public static Func<char, bool> <>9__9_2;
		}

		// Token: 0x02000ABD RID: 2749
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadTemplates>d__4 : IAsyncStateMachine
		{
			// Token: 0x06004E78 RID: 20088 RVA: 0x0014FE34 File Offset: 0x0014E034
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<DocumentTemplateInfo> result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(false);
						}
						try
						{
							TaskAwaiter<List<DocumentTemplateInfo>> awaiter;
							if (num != 0)
							{
								ParameterExpression parameterExpression;
								awaiter = (from o in this.<ctx>5__2.doc_templates.Select(Expression.Lambda<Func<doc_templates, DocumentTemplateInfo>>(Expression.MemberInit(Expression.New(typeof(DocumentTemplateInfo)), new MemberBinding[]
								{
									Expression.Bind(methodof(DocumentTemplateInfo.set_Id(int)), Expression.Property(parameterExpression, methodof(doc_templates.get_id()))),
									Expression.Bind(methodof(DocumentTemplateInfo.set_Name(string)), Expression.Property(parameterExpression, methodof(doc_templates.get_name()))),
									Expression.Bind(methodof(DocumentTemplateInfo.set_Description(string)), Expression.Property(parameterExpression, methodof(doc_templates.get_description())))
								}), new ParameterExpression[]
								{
									parameterExpression
								}))
								orderby o.Description
								select o).ToListAsync<DocumentTemplateInfo>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<DocumentTemplateInfo>>, ReportPrintModel.<LoadTemplates>d__4>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<DocumentTemplateInfo>>);
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
						ReportPrintModel.Log.Error(exception, "Load document templates fail");
						result = new List<DocumentTemplateInfo>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004E79 RID: 20089 RVA: 0x00150078 File Offset: 0x0014E278
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033CD RID: 13261
			public int <>1__state;

			// Token: 0x040033CE RID: 13262
			public AsyncTaskMethodBuilder<List<DocumentTemplateInfo>> <>t__builder;

			// Token: 0x040033CF RID: 13263
			private auseceEntities <ctx>5__2;

			// Token: 0x040033D0 RID: 13264
			private TaskAwaiter<List<DocumentTemplateInfo>> <>u__1;
		}

		// Token: 0x02000ABE RID: 2750
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06004E7A RID: 20090 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x040033D1 RID: 13265
			public int templateId;
		}

		// Token: 0x02000ABF RID: 2751
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004E7B RID: 20091 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06004E7C RID: 20092 RVA: 0x00150094 File Offset: 0x0014E294
			internal bool <GetMaxNumber>b__0(DocumentTemplateInfo i)
			{
				return i.Name.Contains(this.name);
			}

			// Token: 0x040033D2 RID: 13266
			public string name;
		}

		// Token: 0x02000AC0 RID: 2752
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004E7D RID: 20093 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x040033D3 RID: 13267
			public string templateName;
		}

		// Token: 0x02000AC1 RID: 2753
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__12 : IAsyncStateMachine
		{
			// Token: 0x06004E7E RID: 20094 RVA: 0x001500B4 File Offset: 0x0014E2B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				XtraReport result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new ReportPrintModel.<>c__DisplayClass12_0();
						this.<>8__1.templateName = this.templateName;
						this.<report>5__2 = new XtraReport();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<doc_templates> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__3.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == this.<>8__1.templateName).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, ReportPrintModel.<CreateReport>d__12>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<doc_templates>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							doc_templates result = awaiter.GetResult();
							if (result == null)
							{
								result2 = this.<report>5__2;
								goto IL_781;
							}
							string @string = Encoding.UTF8.GetString(result.data);
							this.<report>5__2.Tag = result.id;
							this.<report>5__2.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
							if (!this.<>8__1.templateName.Contains("vatinvoice"))
							{
								if (!(this.<>8__1.templateName == "pko") && !(this.<>8__1.templateName == "rko"))
								{
									if (!(this.<>8__1.templateName == "pn") && !(this.<>8__1.templateName == "rn"))
									{
										if (this.<>8__1.templateName == "buyout")
										{
											BuyoutReport item = new BuyoutReport();
											this.<report>5__2.DataSource = new List<BuyoutReport>
											{
												item
											};
										}
										else if (!(this.<>8__1.templateName == "move"))
										{
											if (!(this.<>8__1.templateName == "new_rep") && !(this.<>8__1.templateName == "works") && !(this.<>8__1.templateName == "warranty") && !(this.<>8__1.templateName == "diag") && !(this.<>8__1.templateName == "reject") && !(this.<>8__1.templateName == "rep_label"))
											{
												if (this.<>8__1.templateName == "sticker_cartridge")
												{
													CartridgeReport item2 = new CartridgeReport();
													this.<report>5__2.DataSource = new List<CartridgeReport>
													{
														item2
													};
												}
												else if (this.<>8__1.templateName == "lost")
												{
													RepairLostDocReport item3 = new RepairLostDocReport();
													this.<report>5__2.DataSource = new List<RepairLostDocReport>
													{
														item3
													};
												}
												else if (!this.<>8__1.templateName.Contains("sticker") && !this.<>8__1.templateName.Contains("price"))
												{
													if (!this.<>8__1.templateName.Contains("p_list"))
													{
														if (!this.<>8__1.templateName.Contains("w_list"))
														{
															if (!this.<>8__1.templateName.Contains("new_cartridge") && !this.<>8__1.templateName.Contains("sticker_cartridge"))
															{
																if (!this.<>8__1.templateName.Contains("issue_cartridge"))
																{
																	if (string.Equals(this.<>8__1.templateName, "slip", StringComparison.Ordinal))
																	{
																		SlipReport slipReport = new SlipReport();
																		string slip = "16.01 18:50:56 SCHEDLR: LINE1\r\n                        16.01 18:50:56 SCHEDLR: LINE2";
																		slipReport.SetSlip(slip);
																		this.<report>5__2.DataSource = new List<SlipReport>
																		{
																			slipReport
																		};
																	}
																	else
																	{
																		Invoice invoice = new Invoice
																		{
																			Customer = ReportPrintModel.CustomerDemoData(),
																			Seller = ReportPrintModel.SellerDemoData()
																		};
																		ReportPrintModel.AddItemsDemoData(invoice);
																		invoice.CalcTotal();
																		this.<report>5__2.DataSource = new List<Invoice>
																		{
																			invoice
																		};
																	}
																}
																else
																{
																	CartridgeIssueReport item4 = new CartridgeIssueReport();
																	this.<report>5__2.DataSource = new List<CartridgeIssueReport>
																	{
																		item4
																	};
																}
															}
															else
															{
																CartridgeReport item5 = new CartridgeReport();
																this.<report>5__2.DataSource = new List<CartridgeReport>
																{
																	item5
																};
															}
														}
														else
														{
															WorksList worksList = new WorksList
															{
																Customer = ReportPrintModel.CustomerDemoData(),
																Seller = ReportPrintModel.SellerDemoData()
															};
															ReportPrintModel.AddItemsDemoData(worksList);
															worksList.CalcTotal();
															this.<report>5__2.DataSource = new List<WorksList>
															{
																worksList
															};
														}
													}
													else
													{
														PackingList packingList = new PackingList
														{
															Customer = ReportPrintModel.CustomerDemoData(),
															Seller = ReportPrintModel.SellerDemoData()
														};
														ReportPrintModel.AddItemsDemoData(packingList);
														packingList.CalcTotal();
														this.<report>5__2.DataSource = new List<PackingList>
														{
															packingList
														};
													}
												}
												else
												{
													GoodsStickerReport goodsStickerReport = new GoodsStickerReport();
													goodsStickerReport.Goods.Add(new SaleItem
													{
														Name = "Test item",
														Price = 1000m,
														InPrice = 600m,
														Articul = 200,
														Id = 1,
														Attributes = new List<IAttribute>
														{
															new AttributeBase
															{
																FieldName = "Цвет",
																Text = "Зелёный",
																Printable = true
															},
															new AttributeBase
															{
																FieldName = "Пароль",
																Text = "qwerty",
																Printable = true
															}
														}
													});
													this.<report>5__2.DataSource = new List<GoodsStickerReport>
													{
														goodsStickerReport
													};
												}
											}
											else
											{
												RepairReport item6 = new RepairReport();
												this.<report>5__2.DataSource = new List<RepairReport>
												{
													item6
												};
											}
										}
										else
										{
											GoodsMoveReport item7 = new GoodsMoveReport();
											this.<report>5__2.DataSource = new List<GoodsMoveReport>
											{
												item7
											};
										}
									}
									else
									{
										GoodsInvoiceReport item8 = new GoodsInvoiceReport();
										this.<report>5__2.DataSource = new List<GoodsInvoiceReport>
										{
											item8
										};
									}
								}
								else
								{
									CashOrderReport item9 = new CashOrderReport();
									this.<report>5__2.DataSource = new List<CashOrderReport>
									{
										item9
									};
								}
							}
							else
							{
								VATInvoice vatinvoice = new VATInvoice(Auth.CurrencyModel.SelectedCurrency)
								{
									Customer = ReportPrintModel.CustomerDemoData(),
									Seller = ReportPrintModel.SellerDemoData()
								};
								ReportPrintModel.AddItemsDemoData(vatinvoice);
								vatinvoice.CalcTotal();
								this.<report>5__2.DataSource = new List<VATInvoice>
								{
									vatinvoice
								};
							}
							this.<report>5__2.CreateDocument();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception ex)
					{
						ReportPrintModel.Log.Error(ex, ex.Message);
					}
					result2 = this.<report>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_781:
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004E7F RID: 20095 RVA: 0x001508B0 File Offset: 0x0014EAB0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033D4 RID: 13268
			public int <>1__state;

			// Token: 0x040033D5 RID: 13269
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x040033D6 RID: 13270
			public string templateName;

			// Token: 0x040033D7 RID: 13271
			private ReportPrintModel.<>c__DisplayClass12_0 <>8__1;

			// Token: 0x040033D8 RID: 13272
			private XtraReport <report>5__2;

			// Token: 0x040033D9 RID: 13273
			private auseceEntities <ctx>5__3;

			// Token: 0x040033DA RID: 13274
			private TaskAwaiter<doc_templates> <>u__1;
		}

		// Token: 0x02000AC2 RID: 2754
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06004E80 RID: 20096 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x040033DB RID: 13275
			public string templateName;
		}

		// Token: 0x02000AC3 RID: 2755
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__16 : IAsyncStateMachine
		{
			// Token: 0x06004E81 RID: 20097 RVA: 0x001508CC File Offset: 0x0014EACC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				XtraReport result2;
				try
				{
					ReportPrintModel.<>c__DisplayClass16_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ReportPrintModel.<>c__DisplayClass16_0();
						CS$<>8__locals1.templateName = this.templateName;
						this.<report>5__2 = new XtraReport();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<doc_templates> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__3.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == CS$<>8__locals1.templateName).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, ReportPrintModel.<CreateReport>d__16>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<doc_templates>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							doc_templates result = awaiter.GetResult();
							if (result == null)
							{
								result2 = this.<report>5__2;
								goto IL_275;
							}
							string @string = Encoding.UTF8.GetString(result.data);
							this.<report>5__2.Tag = result.id;
							this.<report>5__2.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
							if (this.invoice is IVATInvoice)
							{
								this.<report>5__2.DataSource = new List<IVATInvoice>
								{
									(IVATInvoice)this.invoice
								};
							}
							else if (!(this.invoice is IPackingList))
							{
								if (this.invoice is IWorksList)
								{
									this.<report>5__2.DataSource = new List<IWorksList>
									{
										(IWorksList)this.invoice
									};
								}
								else if (this.invoice != null)
								{
									this.<report>5__2.DataSource = new List<IInvoice>
									{
										this.invoice
									};
								}
							}
							else
							{
								this.<report>5__2.DataSource = new List<IPackingList>
								{
									(IPackingList)this.invoice
								};
							}
							this.<report>5__2.CreateDocument();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception ex)
					{
						ReportPrintModel.Log.Error(ex, ex.Message);
					}
					result2 = this.<report>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_275:
				this.<>1__state = -2;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004E82 RID: 20098 RVA: 0x00150BB8 File Offset: 0x0014EDB8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033DC RID: 13276
			public int <>1__state;

			// Token: 0x040033DD RID: 13277
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x040033DE RID: 13278
			public string templateName;

			// Token: 0x040033DF RID: 13279
			public IInvoice invoice;

			// Token: 0x040033E0 RID: 13280
			private XtraReport <report>5__2;

			// Token: 0x040033E1 RID: 13281
			private auseceEntities <ctx>5__3;

			// Token: 0x040033E2 RID: 13282
			private TaskAwaiter<doc_templates> <>u__1;
		}

		// Token: 0x02000AC4 RID: 2756
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06004E83 RID: 20099 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x040033E3 RID: 13283
			public string templateName;
		}

		// Token: 0x02000AC5 RID: 2757
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__17 : IAsyncStateMachine
		{
			// Token: 0x06004E84 RID: 20100 RVA: 0x00150BD4 File Offset: 0x0014EDD4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				XtraReport result2;
				try
				{
					ReportPrintModel.<>c__DisplayClass17_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ReportPrintModel.<>c__DisplayClass17_0();
						CS$<>8__locals1.templateName = this.templateName;
						this.<report>5__2 = new XtraReport();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<doc_templates> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__3.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == CS$<>8__locals1.templateName).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, ReportPrintModel.<CreateReport>d__17>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<doc_templates>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							doc_templates result = awaiter.GetResult();
							if (result == null)
							{
								result2 = this.<report>5__2;
								goto IL_1DA;
							}
							string @string = Encoding.UTF8.GetString(result.data);
							this.<report>5__2.Tag = result.id;
							this.<report>5__2.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
							this.<report>5__2.DataSource = new List<CartridgeReport>
							{
								this.cartridge
							};
							this.<report>5__2.CreateDocument();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception ex)
					{
						ReportPrintModel.Log.Error(ex, ex.Message);
					}
					result2 = this.<report>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1DA:
				this.<>1__state = -2;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004E85 RID: 20101 RVA: 0x00150E24 File Offset: 0x0014F024
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033E4 RID: 13284
			public int <>1__state;

			// Token: 0x040033E5 RID: 13285
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x040033E6 RID: 13286
			public string templateName;

			// Token: 0x040033E7 RID: 13287
			public CartridgeReport cartridge;

			// Token: 0x040033E8 RID: 13288
			private XtraReport <report>5__2;

			// Token: 0x040033E9 RID: 13289
			private auseceEntities <ctx>5__3;

			// Token: 0x040033EA RID: 13290
			private TaskAwaiter<doc_templates> <>u__1;
		}

		// Token: 0x02000AC6 RID: 2758
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06004E86 RID: 20102 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x040033EB RID: 13291
			public string templateName;
		}

		// Token: 0x02000AC7 RID: 2759
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateReport>d__18 : IAsyncStateMachine
		{
			// Token: 0x06004E87 RID: 20103 RVA: 0x00150E40 File Offset: 0x0014F040
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				XtraReport result2;
				try
				{
					ReportPrintModel.<>c__DisplayClass18_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ReportPrintModel.<>c__DisplayClass18_0();
						CS$<>8__locals1.templateName = this.templateName;
						this.<report>5__2 = new XtraReport();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<doc_templates> awaiter;
							if (num != 0)
							{
								awaiter = this.<ctx>5__3.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == CS$<>8__locals1.templateName).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, ReportPrintModel.<CreateReport>d__18>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<doc_templates>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							doc_templates result = awaiter.GetResult();
							if (result == null)
							{
								result2 = this.<report>5__2;
								goto IL_1DA;
							}
							string @string = Encoding.UTF8.GetString(result.data);
							this.<report>5__2.Tag = result.id;
							this.<report>5__2.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
							this.<report>5__2.DataSource = new List<CartridgeIssueReport>
							{
								this.cartridge
							};
							this.<report>5__2.CreateDocument();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception ex)
					{
						ReportPrintModel.Log.Error(ex, ex.Message);
					}
					result2 = this.<report>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<report>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_1DA:
				this.<>1__state = -2;
				this.<report>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004E88 RID: 20104 RVA: 0x00151090 File Offset: 0x0014F290
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033EC RID: 13292
			public int <>1__state;

			// Token: 0x040033ED RID: 13293
			public AsyncTaskMethodBuilder<XtraReport> <>t__builder;

			// Token: 0x040033EE RID: 13294
			public string templateName;

			// Token: 0x040033EF RID: 13295
			public CartridgeIssueReport cartridge;

			// Token: 0x040033F0 RID: 13296
			private XtraReport <report>5__2;

			// Token: 0x040033F1 RID: 13297
			private auseceEntities <ctx>5__3;

			// Token: 0x040033F2 RID: 13298
			private TaskAwaiter<doc_templates> <>u__1;
		}

		// Token: 0x02000AC8 RID: 2760
		[CompilerGenerated]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06004E89 RID: 20105 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x040033F3 RID: 13299
			public string templateName;
		}

		// Token: 0x02000AC9 RID: 2761
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreatePdfReport>d__19 : IAsyncStateMachine
		{
			// Token: 0x06004E8A RID: 20106 RVA: 0x001510AC File Offset: 0x0014F2AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				byte[] result2;
				try
				{
					ReportPrintModel.<>c__DisplayClass19_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new ReportPrintModel.<>c__DisplayClass19_0();
						CS$<>8__locals1.templateName = this.templateName;
						this.<ms>5__2 = new MemoryStream();
					}
					try
					{
						if (num != 0)
						{
							this.<report>5__3 = new XtraReport();
						}
						try
						{
							if (num != 0)
							{
								this.<ctx>5__4 = new auseceEntities(true);
							}
							try
							{
								TaskAwaiter<doc_templates> awaiter;
								if (num != 0)
								{
									awaiter = this.<ctx>5__4.doc_templates.FirstOrDefaultAsync((doc_templates t) => t.name == CS$<>8__locals1.templateName).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num2 = 0;
										num = 0;
										this.<>1__state = num2;
										this.<>u__1 = awaiter;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<doc_templates>, ReportPrintModel.<CreatePdfReport>d__19>(ref awaiter, ref this);
										return;
									}
								}
								else
								{
									awaiter = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter<doc_templates>);
									int num3 = -1;
									num = -1;
									this.<>1__state = num3;
								}
								doc_templates result = awaiter.GetResult();
								if (result == null)
								{
									result2 = null;
									goto IL_294;
								}
								string @string = Encoding.UTF8.GetString(result.data);
								this.<report>5__3.Tag = result.id;
								this.<report>5__3.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
								if (!(this.invoice is IVATInvoice))
								{
									if (!(this.invoice is IPackingList))
									{
										if (this.invoice is IWorksList)
										{
											this.<report>5__3.DataSource = new List<IWorksList>
											{
												(IWorksList)this.invoice
											};
										}
										else if (this.invoice != null)
										{
											this.<report>5__3.DataSource = new List<IInvoice>
											{
												this.invoice
											};
										}
									}
									else
									{
										this.<report>5__3.DataSource = new List<IPackingList>
										{
											(IPackingList)this.invoice
										};
									}
								}
								else
								{
									this.<report>5__3.DataSource = new List<IVATInvoice>
									{
										(IVATInvoice)this.invoice
									};
								}
								this.<report>5__3.ExportToPdf(this.<ms>5__2);
								result2 = this.<ms>5__2.ToArray();
								goto IL_294;
							}
							finally
							{
								if (num < 0 && this.<ctx>5__4 != null)
								{
									((IDisposable)this.<ctx>5__4).Dispose();
								}
							}
						}
						catch (Exception ex)
						{
							ReportPrintModel.Log.Error(ex, ex.Message);
						}
						result2 = null;
					}
					finally
					{
						if (num < 0 && this.<ms>5__2 != null)
						{
							((IDisposable)this.<ms>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_294:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004E8B RID: 20107 RVA: 0x001513C8 File Offset: 0x0014F5C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033F4 RID: 13300
			public int <>1__state;

			// Token: 0x040033F5 RID: 13301
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			// Token: 0x040033F6 RID: 13302
			public string templateName;

			// Token: 0x040033F7 RID: 13303
			public IInvoice invoice;

			// Token: 0x040033F8 RID: 13304
			private MemoryStream <ms>5__2;

			// Token: 0x040033F9 RID: 13305
			private XtraReport <report>5__3;

			// Token: 0x040033FA RID: 13306
			private auseceEntities <ctx>5__4;

			// Token: 0x040033FB RID: 13307
			private TaskAwaiter<doc_templates> <>u__1;
		}
	}
}
