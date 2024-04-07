using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.SimpleClasses;

namespace ASC
{
	// Token: 0x02000040 RID: 64
	public class extensions
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x0000DA04 File Offset: 0x0000BC04
		public string context
		{
			[CompilerGenerated]
			get
			{
				return this.<context>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<context>k__BackingField = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0000DA18 File Offset: 0x0000BC18
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x0000DA2C File Offset: 0x0000BC2C
		public string exten
		{
			[CompilerGenerated]
			get
			{
				return this.<exten>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<exten>k__BackingField = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0000DA40 File Offset: 0x0000BC40
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0000DA54 File Offset: 0x0000BC54
		public int priority
		{
			[CompilerGenerated]
			get
			{
				return this.<priority>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<priority>k__BackingField = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0000DA68 File Offset: 0x0000BC68
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		public string app
		{
			[CompilerGenerated]
			get
			{
				return this.<app>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<app>k__BackingField = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0000DA90 File Offset: 0x0000BC90
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
		public string appdata
		{
			[CompilerGenerated]
			get
			{
				return this.<appdata>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<appdata>k__BackingField = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0000DACC File Offset: 0x0000BCCC
		public int action_id
		{
			[CompilerGenerated]
			get
			{
				return this.<action_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<action_id>k__BackingField = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
		public ExtensionActions Actions
		{
			get
			{
				return new ExtensionActions(this.action_id);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		public string ActionParam
		{
			get
			{
				int action_id = this.action_id;
				for (;;)
				{
					switch (action_id)
					{
					case 3:
						goto IL_6C;
					case 4:
						goto IL_73;
					case 5:
						goto IL_9F;
					case 6:
					case 7:
					case 8:
						goto IL_FF;
					case 9:
						goto IL_105;
					default:
					{
						uint num;
						switch ((num = (num * 1121219308U ^ 4197986615U ^ 3467579386U)) % 7U)
						{
						case 0U:
							goto IL_86;
						case 2U:
							goto IL_FF;
						case 3U:
							goto IL_80;
						case 4U:
						case 5U:
							continue;
						case 6U:
							goto IL_73;
						}
						goto Block_1;
					}
					}
				}
				Block_1:
				goto IL_105;
				IL_6C:
				return this.appdata;
				IL_73:
				if (!string.IsNullOrEmpty(this.appdata))
				{
					goto IL_86;
				}
				IL_80:
				return "";
				IL_86:
				return this.appdata.Split(new char[]
				{
					','
				})[0];
				IL_9F:
				string text = (string.IsNullOrEmpty(this.appdata) || this.appdata.Length < 6) ? "" : this.appdata.Substring(6, this.appdata.Length - 6);
				if (!(text == "${EXTEN}"))
				{
					return text;
				}
				return (string)Application.Current.TryFindResource("CalledNumber");
				IL_FF:
				return "";
				IL_105:
				string result;
				try
				{
					result = ((!string.IsNullOrEmpty(this.appdata)) ? this.appdata.Split(new char[]
					{
						'@'
					})[1] : "");
				}
				catch (Exception)
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000046B4 File Offset: 0x000028B4
		public extensions()
		{
		}

		// Token: 0x040002BC RID: 700
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x040002BD RID: 701
		[CompilerGenerated]
		private string <context>k__BackingField;

		// Token: 0x040002BE RID: 702
		[CompilerGenerated]
		private string <exten>k__BackingField;

		// Token: 0x040002BF RID: 703
		[CompilerGenerated]
		private int <priority>k__BackingField;

		// Token: 0x040002C0 RID: 704
		[CompilerGenerated]
		private string <app>k__BackingField;

		// Token: 0x040002C1 RID: 705
		[CompilerGenerated]
		private string <appdata>k__BackingField;

		// Token: 0x040002C2 RID: 706
		[CompilerGenerated]
		private int <action_id>k__BackingField;
	}
}
