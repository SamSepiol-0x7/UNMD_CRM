using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.ItemsExport.Core;
using ASC.ItemsExport.Models;
using ASC.Services.Abstract;
using Flurl;
using Newtonsoft.Json;

namespace ASC.ItemsExport
{
	// Token: 0x02000306 RID: 774
	public class ExportJSON : ExportBase, IDisposable, IExport
	{
		// Token: 0x060024B9 RID: 9401 RVA: 0x0006F81C File Offset: 0x0006DA1C
		public ExportJSON(IProductService productService)
		{
			this._productService = productService;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0006F838 File Offset: 0x0006DA38
		public void Dispose()
		{
			List<store_cats> categories = base.Categories;
			if (categories != null)
			{
				categories.Clear();
			}
			this._doc = null;
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0006F860 File Offset: 0x0006DA60
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x0006F874 File Offset: 0x0006DA74
		public string ExportPath
		{
			[CompilerGenerated]
			get
			{
				return this.<ExportPath>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ExportPath>k__BackingField = value;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x0006F888 File Offset: 0x0006DA88
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x0006F89C File Offset: 0x0006DA9C
		public string PathToImages
		{
			[CompilerGenerated]
			get
			{
				return this.<PathToImages>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<PathToImages>k__BackingField = value;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0006F8B0 File Offset: 0x0006DAB0
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x0006F8C4 File Offset: 0x0006DAC4
		public bool ExportImages
		{
			[CompilerGenerated]
			get
			{
				return this.<ExportImages>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ExportImages>k__BackingField = value;
			}
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0006F8D8 File Offset: 0x0006DAD8
		public void CreateDocument()
		{
			this._doc = new ExportProducts();
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x0006F8F0 File Offset: 0x0006DAF0
		public void SetExportPath(string path)
		{
			this.ExportPath = Path.Combine(path, "export");
			this.CreateImagesDir();
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x0006F914 File Offset: 0x0006DB14
		private void CreateImagesDir()
		{
			Directory.CreateDirectory(this.GetImagesDir());
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x0006F930 File Offset: 0x0006DB30
		private string GetImagesDir()
		{
			return Path.Combine(this.ExportPath, "images");
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0006F950 File Offset: 0x0006DB50
		public void SetExportImages(bool value)
		{
			this.ExportImages = value;
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x0006F964 File Offset: 0x0006DB64
		public void SetPathToImages(string path)
		{
			this.PathToImages = path;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0006EEA0 File Offset: 0x0006D0A0
		public void SetCategories(IEnumerable<store_cats> categories)
		{
			base.Categories.Clear();
			base.Categories.AddRange(categories);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x0006F978 File Offset: 0x0006DB78
		public void Add(store_items item)
		{
			ExportJSON.<Add>d__26 <Add>d__;
			<Add>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Add>d__.<>4__this = this;
			<Add>d__.item = item;
			<Add>d__.<>1__state = -1;
			<Add>d__.<>t__builder.Start<ExportJSON.<Add>d__26>(ref <Add>d__);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0006F9B8 File Offset: 0x0006DBB8
		private Task IncludeImages(store_items item, Product product)
		{
			ExportJSON.<IncludeImages>d__27 <IncludeImages>d__;
			<IncludeImages>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<IncludeImages>d__.<>4__this = this;
			<IncludeImages>d__.item = item;
			<IncludeImages>d__.product = product;
			<IncludeImages>d__.<>1__state = -1;
			<IncludeImages>d__.<>t__builder.Start<ExportJSON.<IncludeImages>d__27>(ref <IncludeImages>d__);
			return <IncludeImages>d__.<>t__builder.Task;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0006FA0C File Offset: 0x0006DC0C
		public void Save(string fileName)
		{
			string value = JsonConvert.SerializeObject(this._doc);
			using (TextWriter textWriter = File.CreateText(Path.Combine(this.ExportPath, fileName + ".json")))
			{
				textWriter.Write(value);
			}
		}

		// Token: 0x04001379 RID: 4985
		protected IProductService _productService;

		// Token: 0x0400137A RID: 4986
		private ExportProducts _doc;

		// Token: 0x0400137B RID: 4987
		private const string Extension = "json";

		// Token: 0x0400137C RID: 4988
		private const string Dir = "export";

		// Token: 0x0400137D RID: 4989
		private const string ImagesDir = "images";

		// Token: 0x0400137E RID: 4990
		[CompilerGenerated]
		private string <ExportPath>k__BackingField;

		// Token: 0x0400137F RID: 4991
		[CompilerGenerated]
		private string <PathToImages>k__BackingField;

		// Token: 0x04001380 RID: 4992
		[CompilerGenerated]
		private bool <ExportImages>k__BackingField;

		// Token: 0x02000307 RID: 775
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060024CB RID: 9419 RVA: 0x0006FA64 File Offset: 0x0006DC64
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060024CC RID: 9420 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060024CD RID: 9421 RVA: 0x0006F064 File Offset: 0x0006D264
			internal string <Add>b__26_0(store_cats c)
			{
				return c.name;
			}

			// Token: 0x04001381 RID: 4993
			public static readonly ExportJSON.<>c <>9 = new ExportJSON.<>c();

			// Token: 0x04001382 RID: 4994
			public static Func<store_cats, string> <>9__26_0;
		}

		// Token: 0x02000308 RID: 776
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Add>d__26 : IAsyncStateMachine
		{
			// Token: 0x060024CE RID: 9422 RVA: 0x0006FA7C File Offset: 0x0006DC7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportJSON exportJSON = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						List<string> list = exportJSON.GetCatsTree(this.item.store_cats, null).Select(new Func<store_cats, string>(ExportJSON.<>c.<>9.<Add>b__26_0)).ToList<string>();
						list.Reverse();
						this.<p>5__2 = new Product();
						this.<p>5__2.SetId(this.item.id.ToString("d6"));
						this.<p>5__2.SetArticul(this.item.articul.ToString("d6"));
						this.<p>5__2.SetName(this.item.name);
						this.<p>5__2.SetCategory(this.item.store_cats.name);
						this.<p>5__2.SetCategoryTree(string.Join(" | ", list));
						this.<p>5__2.SetCondition(this.item.items_state.name);
						this.<p>5__2.SetDescription(this.item.description);
						this.<p>5__2.SetShopTitle(this.item.shop_title);
						this.<p>5__2.SetShopDescription(this.item.shop_description);
						this.<p>5__2.SetQuantity(this.item.Available.ToString());
						this.<p>5__2.SetPrice(this.item.price2);
						this.<p>5__2.SetPriceOpt(this.item.price3);
						this.<p>5__2.SetPriceOpt2(this.item.price4);
						this.<p>5__2.SetPriceOpt3(this.item.price5);
						this.<p>5__2.SetPartnumber(this.item.PN);
						this.<p>5__2.SetAscBarcode(this.item.int_barcode);
						this.<p>5__2.SetWarranty(exportJSON.warranty.Days2Name(this.item.warranty));
						this.<p>5__2.AddAttribute("Warranty", exportJSON.warranty.Days2Name(this.item.warranty));
						this.<p>5__2.AddAttribute("State", this.item.items_state.name);
						this.<p>5__2.AddAttribute("PartNumber", this.item.PN);
						if (this.item.field_values != null && this.item.field_values.Any<field_values>())
						{
							this.<p>5__2.AddAttributes(this.item.field_values);
						}
						if (!exportJSON.ExportImages)
						{
							goto IL_326;
						}
						if (!Directory.Exists(exportJSON.GetImagesDir()))
						{
							exportJSON.CreateImagesDir();
						}
						awaiter = exportJSON.IncludeImages(this.item, this.<p>5__2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportJSON.<Add>d__26>(ref awaiter, ref this);
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
					IL_326:
					exportJSON._doc.Add(this.<p>5__2);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<p>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<p>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060024CF RID: 9423 RVA: 0x0006FE18 File Offset: 0x0006E018
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001383 RID: 4995
			public int <>1__state;

			// Token: 0x04001384 RID: 4996
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001385 RID: 4997
			public ExportJSON <>4__this;

			// Token: 0x04001386 RID: 4998
			public store_items item;

			// Token: 0x04001387 RID: 4999
			private Product <p>5__2;

			// Token: 0x04001388 RID: 5000
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000309 RID: 777
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <IncludeImages>d__27 : IAsyncStateMachine
		{
			// Token: 0x060024D0 RID: 9424 RVA: 0x0006FE34 File Offset: 0x0006E034
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportJSON exportJSON = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<images>> awaiter;
					if (num == 0)
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<images>>);
						int num2 = -1;
						num = -1;
						this.<>1__state = num2;
					}
					else
					{
						awaiter = exportJSON._productService.GetImages(this.item.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.<>1__state = num3;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<images>>, ExportJSON.<IncludeImages>d__27>(ref awaiter, ref this);
							return;
						}
					}
					List<images> list = awaiter.GetResult().ToList<images>();
					if (list.Any<images>())
					{
						for (int i = 0; i < list.Count; i++)
						{
							int num4 = i + 1;
							string text = ExportBase.CleanFileName(string.Format("{0}_{1}_{2}.jpg", this.item.id, Transliteration.Front(this.item.name).Truncate(50, ""), num4));
							string path = Path.Combine(Path.Combine(exportJSON.ExportPath, "images"), text);
							this.product.AddImage(Url.Combine(new string[]
							{
								exportJSON.PathToImages,
								text
							}));
							try
							{
								images images = list[i];
								FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
								try
								{
									fileStream.Write(images.img, 0, images.img.Length);
								}
								finally
								{
									if (num < 0 && fileStream != null)
									{
										((IDisposable)fileStream).Dispose();
									}
								}
							}
							catch (Exception)
							{
							}
						}
						list.Clear();
					}
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

			// Token: 0x060024D1 RID: 9425 RVA: 0x00070038 File Offset: 0x0006E238
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001389 RID: 5001
			public int <>1__state;

			// Token: 0x0400138A RID: 5002
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400138B RID: 5003
			public ExportJSON <>4__this;

			// Token: 0x0400138C RID: 5004
			public store_items item;

			// Token: 0x0400138D RID: 5005
			public Product product;

			// Token: 0x0400138E RID: 5006
			private TaskAwaiter<IEnumerable<images>> <>u__1;
		}
	}
}
