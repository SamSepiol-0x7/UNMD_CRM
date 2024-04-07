using System;
using ASC.Common.Interfaces;
using ASC.ViewModels;

namespace ASC.Interfaces
{
	// Token: 0x02000B27 RID: 2855
	public interface IKoViewModel : IBaseViewModel, ICustomerSelect
	{
		// Token: 0x0600506A RID: 20586
		void SetOrderType(Kassa.Types type);
	}
}
