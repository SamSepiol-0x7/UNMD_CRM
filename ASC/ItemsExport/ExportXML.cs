using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.ItemsExport.Core;
using ASC.Services.Abstract;
using Flurl;

namespace ASC.ItemsExport
{
	// Token: 0x02000302 RID: 770
	public class ExportXML : ExportBase, IDisposable, IExport
	{
		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x0006ED08 File Offset: 0x0006CF08
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x0006ED1C File Offset: 0x0006CF1C
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

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0006ED30 File Offset: 0x0006CF30
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x0006ED44 File Offset: 0x0006CF44
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

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0006ED58 File Offset: 0x0006CF58
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x0006ED6C File Offset: 0x0006CF6C
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

		// Token: 0x060024A4 RID: 9380 RVA: 0x0006ED80 File Offset: 0x0006CF80
		public ExportXML(IProductService productService)
		{
			this._productService = productService;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0006ED9C File Offset: 0x0006CF9C
		public void CreateDocument()
		{
			this._doc = new XmlDocument();
			XmlDeclaration newChild = this._doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlElement documentElement = this._doc.DocumentElement;
			this._doc.InsertBefore(newChild, documentElement);
			this._products = this._doc.CreateElement(string.Empty, "Products", string.Empty);
			this._doc.AppendChild(this._products);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0006EE18 File Offset: 0x0006D018
		public void SetExportPath(string path)
		{
			this.ExportPath = Path.Combine(path, "export");
			this.CreateImagesDir();
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0006EE3C File Offset: 0x0006D03C
		private void CreateImagesDir()
		{
			Directory.CreateDirectory(this.GetImagesDir());
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0006EE58 File Offset: 0x0006D058
		private string GetImagesDir()
		{
			return Path.Combine(this.ExportPath, "images");
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0006EE78 File Offset: 0x0006D078
		public void SetExportImages(bool value)
		{
			this.ExportImages = value;
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0006EE8C File Offset: 0x0006D08C
		public void SetPathToImages(string path)
		{
			this.PathToImages = path;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0006EEA0 File Offset: 0x0006D0A0
		public void SetCategories(IEnumerable<store_cats> categories)
		{
			base.Categories.Clear();
			base.Categories.AddRange(categories);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0006EEC4 File Offset: 0x0006D0C4
		public void Add(store_items item)
		{
			ExportXML.<Add>d__26 <Add>d__;
			<Add>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Add>d__.<>4__this = this;
			<Add>d__.item = item;
			<Add>d__.<>1__state = -1;
			<Add>d__.<>t__builder.Start<ExportXML.<Add>d__26>(ref <Add>d__);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0006EF04 File Offset: 0x0006D104
		public void Save(string fileName)
		{
			this._doc.Save(Path.Combine(this.ExportPath, fileName + ".xml"));
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0006EF34 File Offset: 0x0006D134
		private void AddElement(XmlElement el, string name, string value)
		{
			name = name.Replace(' ', '_');
			XmlElement xmlElement = this._doc.CreateElement(string.Empty, name, string.Empty);
			XmlText newChild = this._doc.CreateTextNode(value);
			xmlElement.AppendChild(newChild);
			el.AppendChild(xmlElement);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0006EF84 File Offset: 0x0006D184
		private void AddElement(XmlElement el, string name, decimal value)
		{
			this.AddElement(el, name, value.ToString());
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0006EFA0 File Offset: 0x0006D1A0
		private Task IncludeImages(store_items item, XmlElement el)
		{
			ExportXML.<IncludeImages>d__30 <IncludeImages>d__;
			<IncludeImages>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<IncludeImages>d__.<>4__this = this;
			<IncludeImages>d__.item = item;
			<IncludeImages>d__.el = el;
			<IncludeImages>d__.<>1__state = -1;
			<IncludeImages>d__.<>t__builder.Start<ExportXML.<IncludeImages>d__30>(ref <IncludeImages>d__);
			return <IncludeImages>d__.<>t__builder.Task;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0006EFF4 File Offset: 0x0006D1F4
		public void Dispose()
		{
			List<store_cats> categories = base.Categories;
			if (categories != null)
			{
				categories.Clear();
				goto IL_3A;
			}
			IL_13:
			this._doc = null;
			int num = -1518481533;
			IL_1F:
			switch ((num ^ -95484374) % 3)
			{
			case 0:
				IL_3A:
				num = -1298779309;
				goto IL_1F;
			case 1:
				goto IL_13;
			}
			this._products = null;
		}

		// Token: 0x04001363 RID: 4963
		protected IProductService _productService;

		// Token: 0x04001364 RID: 4964
		private XmlDocument _doc;

		// Token: 0x04001365 RID: 4965
		private XmlElement _products;

		// Token: 0x04001366 RID: 4966
		private const string Extension = "xml";

		// Token: 0x04001367 RID: 4967
		private const string Dir = "export";

		// Token: 0x04001368 RID: 4968
		private const string ImagesDir = "images";

		// Token: 0x04001369 RID: 4969
		[CompilerGenerated]
		private string <ExportPath>k__BackingField;

		// Token: 0x0400136A RID: 4970
		[CompilerGenerated]
		private string <PathToImages>k__BackingField;

		// Token: 0x0400136B RID: 4971
		[CompilerGenerated]
		private bool <ExportImages>k__BackingField;

		// Token: 0x02000303 RID: 771
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060024B2 RID: 9394 RVA: 0x0006F04C File Offset: 0x0006D24C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060024B3 RID: 9395 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060024B4 RID: 9396 RVA: 0x0006F064 File Offset: 0x0006D264
			internal string <Add>b__26_0(store_cats c)
			{
				return c.name;
			}

			// Token: 0x0400136C RID: 4972
			public static readonly ExportXML.<>c <>9 = new ExportXML.<>c();

			// Token: 0x0400136D RID: 4973
			public static Func<store_cats, string> <>9__26_0;
		}

		// Token: 0x02000304 RID: 772
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Add>d__26 : IAsyncStateMachine
		{
			// Token: 0x060024B5 RID: 9397 RVA: 0x0006F078 File Offset: 0x0006D278
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportXML exportXML = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						XmlElement xmlElement = exportXML._doc.CreateElement(string.Empty, "Product", string.Empty);
						exportXML._products.AppendChild(xmlElement);
						List<string> list = exportXML.GetCatsTree(this.item.store_cats, null).Select(new Func<store_cats, string>(ExportXML.<>c.<>9.<Add>b__26_0)).ToList<string>();
						list.Reverse();
						exportXML.AddElement(xmlElement, "Id", this.item.id.ToString("d6"));
						exportXML.AddElement(xmlElement, "Articul", this.item.articul.ToString("d6"));
						exportXML.AddElement(xmlElement, "Name", this.item.name);
						exportXML.AddElement(xmlElement, "Category", this.item.store_cats.name);
						exportXML.AddElement(xmlElement, "CategoryTree", string.Join(" | ", list));
						exportXML.AddElement(xmlElement, "Condition", this.item.items_state.name);
						exportXML.AddElement(xmlElement, "Description", this.item.description);
						exportXML.AddElement(xmlElement, "ShopTitle", this.item.shop_title);
						exportXML.AddElement(xmlElement, "ShopDescription", this.item.shop_description);
						exportXML.AddElement(xmlElement, "Quantity", this.item.Available.ToString());
						exportXML.AddElement(xmlElement, "Price", this.item.price2);
						exportXML.AddElement(xmlElement, "PriceOpt", this.item.price3);
						exportXML.AddElement(xmlElement, "PriceOpt2", this.item.price4);
						exportXML.AddElement(xmlElement, "PriceOpt3", this.item.price5);
						exportXML.AddElement(xmlElement, "Partnumber", this.item.PN);
						exportXML.AddElement(xmlElement, "AscBarcode", this.item.int_barcode);
						exportXML.AddElement(xmlElement, "Warranty", exportXML.warranty.Days2Name(this.item.warranty));
						XmlElement xmlElement2 = exportXML._doc.CreateElement(string.Empty, "ATTRIBUTES", string.Empty);
						xmlElement.AppendChild(xmlElement2);
						XmlElement xmlElement3 = exportXML._doc.CreateElement(string.Empty, "ATTRIBUTE", string.Empty);
						exportXML.AddElement(xmlElement3, "Name", Lang.t("Warranty"));
						exportXML.AddElement(xmlElement3, "Value", exportXML.warranty.Days2Name(this.item.warranty));
						xmlElement2.AppendChild(xmlElement3);
						XmlElement xmlElement4 = exportXML._doc.CreateElement(string.Empty, "ATTRIBUTE", string.Empty);
						exportXML.AddElement(xmlElement4, "Name", Lang.t("State"));
						exportXML.AddElement(xmlElement4, "Value", this.item.items_state.name);
						xmlElement2.AppendChild(xmlElement4);
						XmlElement xmlElement5 = exportXML._doc.CreateElement(string.Empty, "ATTRIBUTE", string.Empty);
						exportXML.AddElement(xmlElement5, "Name", Lang.t("PartNumber"));
						exportXML.AddElement(xmlElement5, "Value", this.item.PN);
						xmlElement2.AppendChild(xmlElement5);
						if (this.item.field_values != null && this.item.field_values.Any<field_values>())
						{
							IEnumerator<field_values> enumerator = this.item.field_values.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									field_values field_values = enumerator.Current;
									XmlElement xmlElement6 = exportXML._doc.CreateElement(string.Empty, "ATTRIBUTE", string.Empty);
									ExportXML exportXML2 = exportXML;
									XmlElement el = xmlElement6;
									string name = "Name";
									fields fields = field_values.fields;
									if (fields == null)
									{
										goto IL_3F3;
									}
									string value;
									if ((value = fields.name) == null)
									{
										goto IL_3F3;
									}
									IL_3F9:
									exportXML2.AddElement(el, name, value);
									exportXML.AddElement(xmlElement6, "Value", field_values.value);
									xmlElement2.AppendChild(xmlElement6);
									if (field_values.fields != null && field_values.fields.required)
									{
										exportXML.AddElement(xmlElement, field_values.fields.name, field_values.value);
										continue;
									}
									continue;
									IL_3F3:
									value = "";
									goto IL_3F9;
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
						if (!exportXML.ExportImages)
						{
							goto IL_4E8;
						}
						if (!Directory.Exists(exportXML.GetImagesDir()))
						{
							exportXML.CreateImagesDir();
						}
						awaiter = exportXML.IncludeImages(this.item, xmlElement).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportXML.<Add>d__26>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					awaiter.GetResult();
					IL_4E8:;
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

			// Token: 0x060024B6 RID: 9398 RVA: 0x0006F5D0 File Offset: 0x0006D7D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400136E RID: 4974
			public int <>1__state;

			// Token: 0x0400136F RID: 4975
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001370 RID: 4976
			public ExportXML <>4__this;

			// Token: 0x04001371 RID: 4977
			public store_items item;

			// Token: 0x04001372 RID: 4978
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000305 RID: 773
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <IncludeImages>d__30 : IAsyncStateMachine
		{
			// Token: 0x060024B7 RID: 9399 RVA: 0x0006F5EC File Offset: 0x0006D7EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				ExportXML exportXML = this.<>4__this;
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
						awaiter = exportXML._productService.GetImages(this.item.id).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.<>1__state = num3;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<images>>, ExportXML.<IncludeImages>d__30>(ref awaiter, ref this);
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
							string path = Path.Combine(Path.Combine(exportXML.ExportPath, "images"), text);
							exportXML.AddElement(this.el, string.Format("Image_{0}", num4), Url.Combine(new string[]
							{
								exportXML.PathToImages,
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

			// Token: 0x060024B8 RID: 9400 RVA: 0x0006F800 File Offset: 0x0006DA00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001373 RID: 4979
			public int <>1__state;

			// Token: 0x04001374 RID: 4980
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001375 RID: 4981
			public ExportXML <>4__this;

			// Token: 0x04001376 RID: 4982
			public store_items item;

			// Token: 0x04001377 RID: 4983
			public XmlElement el;

			// Token: 0x04001378 RID: 4984
			private TaskAwaiter<IEnumerable<images>> <>u__1;
		}
	}
}
