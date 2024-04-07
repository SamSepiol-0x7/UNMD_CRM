using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x020008F4 RID: 2292
	public class Result : IAscResult
	{
		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x00115F54 File Offset: 0x00114154
		// (set) Token: 0x0600474A RID: 18250 RVA: 0x00115F68 File Offset: 0x00114168
		public bool IsSucces
		{
			[CompilerGenerated]
			get
			{
				return this.<IsSucces>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsSucces>k__BackingField = value;
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x00115F7C File Offset: 0x0011417C
		// (set) Token: 0x0600474C RID: 18252 RVA: 0x00115F90 File Offset: 0x00114190
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

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x00115FA4 File Offset: 0x001141A4
		// (set) Token: 0x0600474E RID: 18254 RVA: 0x00115FB8 File Offset: 0x001141B8
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.<Message>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Message>k__BackingField = value;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x00115FCC File Offset: 0x001141CC
		// (set) Token: 0x06004750 RID: 18256 RVA: 0x00115FE0 File Offset: 0x001141E0
		public List<int> Ids
		{
			[CompilerGenerated]
			get
			{
				return this.<Ids>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ids>k__BackingField = value;
			}
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00115FF4 File Offset: 0x001141F4
		public Result()
		{
			this.Ids = new List<int>();
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x00116014 File Offset: 0x00114214
		public void AddId(int id)
		{
			this.Ids.Add(id);
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00116030 File Offset: 0x00114230
		public void MessageFromResource(string msg)
		{
			this.Message = (string)Application.Current.TryFindResource(msg);
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00116054 File Offset: 0x00114254
		public void SetSuccess()
		{
			this.IsSucces = true;
		}

		// Token: 0x04002DBA RID: 11706
		[CompilerGenerated]
		private bool <IsSucces>k__BackingField;

		// Token: 0x04002DBB RID: 11707
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002DBC RID: 11708
		[CompilerGenerated]
		private string <Message>k__BackingField;

		// Token: 0x04002DBD RID: 11709
		[CompilerGenerated]
		private List<int> <Ids>k__BackingField;
	}
}
