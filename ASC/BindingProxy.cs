using System;
using System.Windows;

namespace ASC
{
	// Token: 0x0200009B RID: 155
	public class BindingProxy : Freezable
	{
		// Token: 0x06001273 RID: 4723 RVA: 0x00022DB8 File Offset: 0x00020FB8
		protected override Freezable CreateInstanceCore()
		{
			return new BindingProxy();
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00022DCC File Offset: 0x00020FCC
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x00022DE4 File Offset: 0x00020FE4
		public object Data
		{
			get
			{
				return base.GetValue(BindingProxy.DataProperty);
			}
			set
			{
				base.SetValue(BindingProxy.DataProperty, value);
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00022E00 File Offset: 0x00021000
		public BindingProxy()
		{
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00022E14 File Offset: 0x00021014
		// Note: this type is marked as 'beforefieldinit'.
		static BindingProxy()
		{
		}

		// Token: 0x040008C4 RID: 2244
		public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(object), typeof(BindingProxy));
	}
}
