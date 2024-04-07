using System;
using System.Collections.Generic;

namespace ASC.Interfaces
{
	// Token: 0x02000B2F RID: 2863
	public interface IExport : IDisposable
	{
		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060050B1 RID: 20657
		string ExportPath { get; }

		// Token: 0x060050B2 RID: 20658
		void CreateDocument();

		// Token: 0x060050B3 RID: 20659
		void SetExportPath(string path);

		// Token: 0x060050B4 RID: 20660
		void SetExportImages(bool value);

		// Token: 0x060050B5 RID: 20661
		void SetPathToImages(string path);

		// Token: 0x060050B6 RID: 20662
		void SetCategories(IEnumerable<store_cats> categories);

		// Token: 0x060050B7 RID: 20663
		void Add(store_items item);

		// Token: 0x060050B8 RID: 20664
		void Save(string fileName);
	}
}
