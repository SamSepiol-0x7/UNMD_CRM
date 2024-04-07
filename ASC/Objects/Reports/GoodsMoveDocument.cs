using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ASC.Common.Interfaces;
using ASC.Models;
using DevExpress.XtraReports.UI;

namespace ASC.Objects.Reports
{
	// Token: 0x02000938 RID: 2360
	public class GoodsMoveDocument : GoodsMoveReport, IStoreDocument, IGoodsMoveDocument
	{
		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x0011C9B8 File Offset: 0x0011ABB8
		// (set) Token: 0x06004869 RID: 18537 RVA: 0x0011C9CC File Offset: 0x0011ABCC
		public ObservableCollection<store_items> Items
		{
			[CompilerGenerated]
			get
			{
				return this.<Items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Items>k__BackingField, value))
				{
					return;
				}
				this.<Items>k__BackingField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x0011C9FC File Offset: 0x0011ABFC
		public GoodsMoveDocument()
		{
			this.Items = new ObservableCollection<store_items>();
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x0011CA1C File Offset: 0x0011AC1C
		public GoodsMoveDocument(IStoreDocument d) : base(d)
		{
			this.Items = new ObservableCollection<store_items>();
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x0011CA3C File Offset: 0x0011AC3C
		public void AddItem(store_items product)
		{
			this.Items.Add(product);
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x0011CA58 File Offset: 0x0011AC58
		public void RemoveItem(store_items item)
		{
			this.Items.Remove(item);
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x0011CA74 File Offset: 0x0011AC74
		public XtraReport CreateReport()
		{
			XtraReport xtraReport = new XtraReport();
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					doc_templates doc_templates = auseceEntities.doc_templates.FirstOrDefault((doc_templates t) => t.name == "move");
					if (doc_templates == null)
					{
						return xtraReport;
					}
					string @string = Encoding.UTF8.GetString(doc_templates.data);
					xtraReport.Tag = doc_templates.id;
					xtraReport.LoadLayout(ReportPrintModel.GenerateStreamFromString(@string));
					xtraReport.DataSource = new List<GoodsMoveReport>
					{
						new GoodsMoveReport(this)
					};
					xtraReport.CreateDocument();
				}
			}
			catch (Exception)
			{
			}
			return xtraReport;
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x0011CB74 File Offset: 0x0011AD74
		public string CheckFields()
		{
			if (base.StoreId == null || base.ToStoreId == null)
			{
				return "SelectStore2";
			}
			int? storeId = base.StoreId;
			int? toStoreId = base.ToStoreId;
			if (storeId.GetValueOrDefault() == toStoreId.GetValueOrDefault() & storeId != null == (toStoreId != null))
			{
				return "SameStoreErr";
			}
			if (this.Items.Any((store_items i) => i.category == 0))
			{
				return "ItemErrorCategory";
			}
			return "";
		}

		// Token: 0x04002E2E RID: 11822
		[CompilerGenerated]
		private ObservableCollection<store_items> <Items>k__BackingField;

		// Token: 0x02000939 RID: 2361
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004870 RID: 18544 RVA: 0x0011CC18 File Offset: 0x0011AE18
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004871 RID: 18545 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004872 RID: 18546 RVA: 0x0011CC30 File Offset: 0x0011AE30
			internal bool <CheckFields>b__9_0(store_items i)
			{
				return i.category == 0;
			}

			// Token: 0x04002E2F RID: 11823
			public static readonly GoodsMoveDocument.<>c <>9 = new GoodsMoveDocument.<>c();

			// Token: 0x04002E30 RID: 11824
			public static Func<store_items, bool> <>9__9_0;
		}
	}
}
