using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DevExpress.Xpf.Grid;

namespace ASC.View.Controls
{
	// Token: 0x0200037D RID: 893
	public partial class CallsView : UserControl
	{
		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x00076198 File Offset: 0x00074398
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x000761B0 File Offset: 0x000743B0
		public object TableView
		{
			get
			{
				return base.GetValue(CallsView.TableViewProperty);
			}
			private set
			{
				base.SetValue(CallsView.TableViewProperty, value);
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000761CC File Offset: 0x000743CC
		public CallsView()
		{
			this.InitializeComponent();
			this.TableView = this.CallsTableView;
		}

		// Token: 0x040014DE RID: 5342
		public static readonly DependencyProperty TableViewProperty = DependencyProperty.Register("TableView", typeof(object), typeof(TableView));
	}
}
