using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ASC.Properties
{
	// Token: 0x02000236 RID: 566
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class Resources
	{
		// Token: 0x06001EC8 RID: 7880 RVA: 0x000046B4 File Offset: 0x000028B4
		internal Resources()
		{
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x000588A0 File Offset: 0x00056AA0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("ASC.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x000588D8 File Offset: 0x00056AD8
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x000588EC File Offset: 0x00056AEC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400101E RID: 4126
		private static ResourceManager resourceMan;

		// Token: 0x0400101F RID: 4127
		private static CultureInfo resourceCulture;
	}
}
