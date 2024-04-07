using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ASC.Interfaces;

namespace ASC.Options
{
	// Token: 0x0200025B RID: 603
	public class CallsOptions : IOptions<CallsOptions>
	{
		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0005E92C File Offset: 0x0005CB2C
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x0005E940 File Offset: 0x0005CB40
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

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0005E954 File Offset: 0x0005CB54
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0005E968 File Offset: 0x0005CB68
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

		// Token: 0x060020D2 RID: 8402 RVA: 0x0005E97C File Offset: 0x0005CB7C
		public CallsOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000046B4 File Offset: 0x000028B4
		public CallsOptions()
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0005E9A0 File Offset: 0x0005CBA0
		public List<CallsOptions> GetAllOptions()
		{
			return new List<CallsOptions>
			{
				new CallsOptions(1, Lang.t("All")),
				new CallsOptions(2, Lang.t("Incoming")),
				new CallsOptions(3, Lang.t("Outcoming"))
			};
		}

		// Token: 0x040010CD RID: 4301
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010CE RID: 4302
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x0200025C RID: 604
		public enum opName
		{
			// Token: 0x040010D0 RID: 4304
			all = 1,
			// Token: 0x040010D1 RID: 4305
			incoming,
			// Token: 0x040010D2 RID: 4306
			outcoming
		}
	}
}
