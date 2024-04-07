using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.LayoutControl;

namespace ASC
{
	// Token: 0x020000B6 RID: 182
	public class NewRepairView : System.Windows.Controls.UserControl, IComponentConnector
	{
		// Token: 0x06001317 RID: 4887 RVA: 0x00029B7C File Offset: 0x00027D7C
		public NewRepairView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00029B98 File Offset: 0x00027D98
		private void En_GotFocus(object sender, RoutedEventArgs e)
		{
			if (Auth.Config.auto_switch_layout)
			{
				InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00029BC8 File Offset: 0x00027DC8
		private void Ru_GotFocus(object sender, RoutedEventArgs e)
		{
			if (Auth.Config.auto_switch_layout)
			{
				InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CurrentCulture);
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00029BF0 File Offset: 0x00027DF0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1674023567;
			IL_0D:
			Uri resourceLocator;
			switch ((num ^ 2086252802) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 2:
				IL_2C:
				this._contentLoaded = true;
				resourceLocator = new Uri("/ASC;component/newrepair/newrepairview.xaml", UriKind.Relative);
				num = 693716973;
				goto IL_0D;
			}
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00021F40 File Offset: 0x00020140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00029C4C File Offset: 0x00027E4C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.repairWindow = (NewRepairView)target;
				return;
			case 2:
				this.LeftMenuLayoutModeSwitch = (SimpleButton)target;
				return;
			case 3:
				this.NewOrderLeftMenuLayout = (LayoutControl)target;
				return;
			case 4:
				this.CheckBoxQuickRepair = (CheckEdit)target;
				return;
			case 5:
				this.wasInService = (CheckEdit)target;
				return;
			case 6:
				this.warrantyRepair = (CheckEdit)target;
				return;
			case 7:
				this.ComboBoxCompany = (ComboBoxEdit)target;
				return;
			case 8:
				this.ExpandButton = (ToggleButton)target;
				return;
			case 9:
				((ComboBoxEdit)target).GotFocus += this.En_GotFocus;
				return;
			case 10:
				((ComboBoxEdit)target).GotFocus += this.En_GotFocus;
				return;
			case 11:
				((ButtonEdit)target).GotFocus += this.En_GotFocus;
				return;
			case 12:
				((TextEdit)target).GotFocus += this.Ru_GotFocus;
				return;
			case 13:
				((TextEdit)target).GotFocus += this.Ru_GotFocus;
				return;
			case 14:
				((TextEdit)target).GotFocus += this.Ru_GotFocus;
				return;
			case 15:
				this.Phone1Mask = (ComboBoxEdit)target;
				return;
			case 16:
				((TextEdit)target).GotFocus += this.Ru_GotFocus;
				return;
			case 17:
				((TextEdit)target).GotFocus += this.En_GotFocus;
				return;
			case 18:
				this.Phone2Mask = (ComboBoxEdit)target;
				return;
			case 19:
				this.PhoneUrMask = (ComboBoxEdit)target;
				return;
			case 20:
				((TextEdit)target).GotFocus += this.Ru_GotFocus;
				return;
			case 21:
				((TextEdit)target).GotFocus += this.Ru_GotFocus;
				return;
			case 22:
				this.CheckBoxPrePaid = (System.Windows.Controls.CheckBox)target;
				return;
			case 23:
				this.checkBoxPreAgreedAmount = (System.Windows.Controls.CheckBox)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x0400092A RID: 2346
		internal NewRepairView repairWindow;

		// Token: 0x0400092B RID: 2347
		internal SimpleButton LeftMenuLayoutModeSwitch;

		// Token: 0x0400092C RID: 2348
		internal LayoutControl NewOrderLeftMenuLayout;

		// Token: 0x0400092D RID: 2349
		internal CheckEdit CheckBoxQuickRepair;

		// Token: 0x0400092E RID: 2350
		internal CheckEdit wasInService;

		// Token: 0x0400092F RID: 2351
		internal CheckEdit warrantyRepair;

		// Token: 0x04000930 RID: 2352
		internal ComboBoxEdit ComboBoxCompany;

		// Token: 0x04000931 RID: 2353
		internal ToggleButton ExpandButton;

		// Token: 0x04000932 RID: 2354
		internal ComboBoxEdit Phone1Mask;

		// Token: 0x04000933 RID: 2355
		internal ComboBoxEdit Phone2Mask;

		// Token: 0x04000934 RID: 2356
		internal ComboBoxEdit PhoneUrMask;

		// Token: 0x04000935 RID: 2357
		internal System.Windows.Controls.CheckBox CheckBoxPrePaid;

		// Token: 0x04000936 RID: 2358
		internal System.Windows.Controls.CheckBox checkBoxPreAgreedAmount;

		// Token: 0x04000937 RID: 2359
		private bool _contentLoaded;
	}
}
