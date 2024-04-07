using System;

namespace System.IO
{
	// Token: 0x02000015 RID: 21
	public sealed class WrapStream : Stream
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003C38 File Offset: 0x00001E38
		public override bool CanRead
		{
			get
			{
				return this.Base.CanRead;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003C50 File Offset: 0x00001E50
		public override bool CanSeek
		{
			get
			{
				return this.Base.CanSeek;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003C68 File Offset: 0x00001E68
		public override bool CanWrite
		{
			get
			{
				return this.Base.CanWrite;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003C80 File Offset: 0x00001E80
		public override long Length
		{
			get
			{
				return this.Base.Length;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003C98 File Offset: 0x00001E98
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public override long Position
		{
			get
			{
				return this.Base.Position;
			}
			set
			{
				this.Base.Position = value;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003CCC File Offset: 0x00001ECC
		public WrapStream(Stream inStream)
		{
			this.Base = inStream;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003CE8 File Offset: 0x00001EE8
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.Base.Read(buffer, offset, count);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003D04 File Offset: 0x00001F04
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.Base.Write(buffer, offset, count);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003D20 File Offset: 0x00001F20
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.Base.Seek(offset, origin);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003D3C File Offset: 0x00001F3C
		public override void Flush()
		{
			this.Base.Flush();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003D54 File Offset: 0x00001F54
		public override void SetLength(long value)
		{
			this.Base.SetLength(value);
		}

		// Token: 0x0400002F RID: 47
		private Stream Base;
	}
}
