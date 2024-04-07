using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ASC.Common.Interfaces;

namespace ASC.SimpleClasses
{
	// Token: 0x02000205 RID: 517
	public class PhotoInfo
	{
		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00051DF0 File Offset: 0x0004FFF0
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x00051E04 File Offset: 0x00050004
		public ImageSource Source
		{
			[CompilerGenerated]
			get
			{
				return this.<Source>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Source>k__BackingField = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00051E18 File Offset: 0x00050018
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00051E2C File Offset: 0x0005002C
		public int ImageId
		{
			[CompilerGenerated]
			get
			{
				return this.<ImageId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ImageId>k__BackingField = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00051E40 File Offset: 0x00050040
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x00051E54 File Offset: 0x00050054
		public string Caption
		{
			[CompilerGenerated]
			get
			{
				return this.<Caption>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Caption>k__BackingField = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00051E68 File Offset: 0x00050068
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x00051E7C File Offset: 0x0005007C
		public string SizeInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<SizeInfo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SizeInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00051E90 File Offset: 0x00050090
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00051EA4 File Offset: 0x000500A4
		public Size ViewSize
		{
			[CompilerGenerated]
			get
			{
				return this.<ViewSize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ViewSize>k__BackingField = value;
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00051EB8 File Offset: 0x000500B8
		public PhotoInfo()
		{
			this.ViewSize = new Size(double.NaN, double.NaN);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00051EE8 File Offset: 0x000500E8
		public PhotoInfo(IImage image, string caption)
		{
			this.ImageId = image.Id;
			this.Caption = caption;
			this.Source = ConvertersStack.ByteArrayToImage(image.Image);
			this.ViewSize = new Size(190.0, 150.0);
		}

		// Token: 0x04000EA4 RID: 3748
		[CompilerGenerated]
		private ImageSource <Source>k__BackingField;

		// Token: 0x04000EA5 RID: 3749
		[CompilerGenerated]
		private int <ImageId>k__BackingField;

		// Token: 0x04000EA6 RID: 3750
		[CompilerGenerated]
		private string <Caption>k__BackingField;

		// Token: 0x04000EA7 RID: 3751
		[CompilerGenerated]
		private string <SizeInfo>k__BackingField;

		// Token: 0x04000EA8 RID: 3752
		[CompilerGenerated]
		private Size <ViewSize>k__BackingField;
	}
}
