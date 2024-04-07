using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.ViewModel
{
	// Token: 0x020002A1 RID: 673
	public class AttributeBase : IAttribute
	{
		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000661DC File Offset: 0x000643DC
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x000661F0 File Offset: 0x000643F0
		public bool Required
		{
			[CompilerGenerated]
			get
			{
				return this.<Required>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Required>k__BackingField = value;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00066204 File Offset: 0x00064404
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x00066218 File Offset: 0x00064418
		public bool Printable
		{
			[CompilerGenerated]
			get
			{
				return this.<Printable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Printable>k__BackingField = value;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x0006622C File Offset: 0x0006442C
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x00066240 File Offset: 0x00064440
		public string FieldName
		{
			[CompilerGenerated]
			get
			{
				return this.<FieldName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<FieldName>k__BackingField = value;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x00066254 File Offset: 0x00064454
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x00066268 File Offset: 0x00064468
		public bool IsReadOnly
		{
			[CompilerGenerated]
			get
			{
				return this.<IsReadOnly>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<IsReadOnly>k__BackingField = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0006627C File Offset: 0x0006447C
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x00066290 File Offset: 0x00064490
		public bool ShowCaption
		{
			[CompilerGenerated]
			get
			{
				return this.<ShowCaption>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ShowCaption>k__BackingField = value;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000662A4 File Offset: 0x000644A4
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x000662B8 File Offset: 0x000644B8
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000662CC File Offset: 0x000644CC
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x000662E0 File Offset: 0x000644E0
		public int FieldId
		{
			[CompilerGenerated]
			get
			{
				return this.<FieldId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<FieldId>k__BackingField = value;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000662F4 File Offset: 0x000644F4
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x00066308 File Offset: 0x00064508
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0006631C File Offset: 0x0006451C
		public void SetShowCaption(bool value)
		{
			this.ShowCaption = value;
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00066330 File Offset: 0x00064530
		public void SetIsReadOnly(bool value)
		{
			this.IsReadOnly = value;
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x000046B4 File Offset: 0x000028B4
		public AttributeBase()
		{
		}

		// Token: 0x040011FB RID: 4603
		[CompilerGenerated]
		private bool <Required>k__BackingField;

		// Token: 0x040011FC RID: 4604
		[CompilerGenerated]
		private bool <Printable>k__BackingField;

		// Token: 0x040011FD RID: 4605
		[CompilerGenerated]
		private string <FieldName>k__BackingField;

		// Token: 0x040011FE RID: 4606
		[CompilerGenerated]
		private bool <IsReadOnly>k__BackingField;

		// Token: 0x040011FF RID: 4607
		[CompilerGenerated]
		private bool <ShowCaption>k__BackingField;

		// Token: 0x04001200 RID: 4608
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04001201 RID: 4609
		[CompilerGenerated]
		private int <FieldId>k__BackingField;

		// Token: 0x04001202 RID: 4610
		[CompilerGenerated]
		private string <Text>k__BackingField;
	}
}
