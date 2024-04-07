using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ASC.SimpleClasses
{
	// Token: 0x02000201 RID: 513
	public class LicenseVerify
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x00051BA8 File Offset: 0x0004FDA8
		public LicenseVerify()
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					this.Repairs = auseceEntities.workshop.Count<workshop>();
					this.Items = auseceEntities.store_items.Count<store_items>();
					string[] array = (from c in auseceEntities.companies
					where c.status
					select c.name).ToArray<string>();
					if (array.Any<string>())
					{
						this.Org = string.Join(" ## ", array);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000E97 RID: 3735
		public string License = Auth.Config.key;

		// Token: 0x04000E98 RID: 3736
		public string ProductName;

		// Token: 0x04000E99 RID: 3737
		public string ProductVersion;

		// Token: 0x04000E9A RID: 3738
		public int Repairs;

		// Token: 0x04000E9B RID: 3739
		public int Items;

		// Token: 0x04000E9C RID: 3740
		public string Org;

		// Token: 0x02000202 RID: 514
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001BAF RID: 7087 RVA: 0x00051CC4 File Offset: 0x0004FEC4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001BB0 RID: 7088 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x04000E9D RID: 3741
			public static readonly LicenseVerify.<>c <>9 = new LicenseVerify.<>c();
		}
	}
}
