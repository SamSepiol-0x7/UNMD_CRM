using System;
using System.Runtime.CompilerServices;

namespace ASC
{
	// Token: 0x02000023 RID: 35
	public class ServerInfo
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00005C04 File Offset: 0x00003E04
		public static ServerInfo Instance
		{
			get
			{
				return ServerInfo._serverInfo;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00005C18 File Offset: 0x00003E18
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00005C2C File Offset: 0x00003E2C
		public bool Connected
		{
			[CompilerGenerated]
			get
			{
				return this.<Connected>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Connected>k__BackingField = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00005C40 File Offset: 0x00003E40
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00005C54 File Offset: 0x00003E54
		public string ServerVersion
		{
			[CompilerGenerated]
			get
			{
				return this.<ServerVersion>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ServerVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00005C68 File Offset: 0x00003E68
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00005C7C File Offset: 0x00003E7C
		public string ServerOS
		{
			[CompilerGenerated]
			get
			{
				return this.<ServerOS>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ServerOS>k__BackingField = value;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005C90 File Offset: 0x00003E90
		static ServerInfo()
		{
			ServerInfo._serverInfo.SetServerReachable();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005CB4 File Offset: 0x00003EB4
		public void SetServerUnreachable()
		{
			this.Connected = false;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public void SetServerReachable()
		{
			this.Connected = true;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000046B4 File Offset: 0x000028B4
		public ServerInfo()
		{
		}

		// Token: 0x04000079 RID: 121
		private static ServerInfo _serverInfo = new ServerInfo();

		// Token: 0x0400007A RID: 122
		[CompilerGenerated]
		private bool <Connected>k__BackingField;

		// Token: 0x0400007B RID: 123
		[CompilerGenerated]
		private string <ServerVersion>k__BackingField;

		// Token: 0x0400007C RID: 124
		[CompilerGenerated]
		private string <ServerOS>k__BackingField;
	}
}
