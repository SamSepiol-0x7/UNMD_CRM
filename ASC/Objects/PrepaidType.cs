using System;
using ASC.Common.Interfaces;
using ASC.SimpleClasses;

namespace ASC.Objects
{
	// Token: 0x0200086F RID: 2159
	public class PrepaidType : IdNameClass, IPrepaidType, IIdName
	{
		// Token: 0x06004021 RID: 16417 RVA: 0x000FFA04 File Offset: 0x000FDC04
		public PrepaidType()
		{
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x000FFA18 File Offset: 0x000FDC18
		public PrepaidType(int id, string name) : base(id, name)
		{
		}
	}
}
