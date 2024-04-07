using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using Newtonsoft.Json;

namespace ASC.Extensions.OpenCart.Models
{
	// Token: 0x02000BA2 RID: 2978
	public class OrderStatus : IIdName
	{
		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x0016573C File Offset: 0x0016393C
		// (set) Token: 0x0600536A RID: 21354 RVA: 0x00165750 File Offset: 0x00163950
		[JsonProperty("order_status_id")]
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

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x00165764 File Offset: 0x00163964
		// (set) Token: 0x0600536C RID: 21356 RVA: 0x00165778 File Offset: 0x00163978
		[JsonProperty("name")]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x000046B4 File Offset: 0x000028B4
		public OrderStatus()
		{
		}

		// Token: 0x040036ED RID: 14061
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040036EE RID: 14062
		[CompilerGenerated]
		private string <Name>k__BackingField;
	}
}
