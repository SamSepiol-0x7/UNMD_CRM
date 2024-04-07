using System;

namespace ASC.Services.Abstract
{
	// Token: 0x02000804 RID: 2052
	public interface IWindowedDocumentService
	{
		// Token: 0x06003D66 RID: 15718
		void ShowNewDocument(string view, object viewModel, object parentVm = null, object parameter = null);

		// Token: 0x06003D67 RID: 15719
		void CloseActiveDocument();

		// Token: 0x06003D68 RID: 15720
		void CloseActiveDocument(string callFrom);

		// Token: 0x06003D69 RID: 15721
		void TransparentBackground();
	}
}
