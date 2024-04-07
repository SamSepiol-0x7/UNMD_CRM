using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace ASC.ViewModel
{
	// Token: 0x020002A2 RID: 674
	public class ActionResponseViewModel
	{
		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x00066344 File Offset: 0x00064544
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x00066358 File Offset: 0x00064558
		public string Response
		{
			[CompilerGenerated]
			get
			{
				return this.<Response>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Response>k__BackingField = value;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x0006636C File Offset: 0x0006456C
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x00066380 File Offset: 0x00064580
		public SolidColorBrush Background
		{
			[CompilerGenerated]
			get
			{
				return this.<Background>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Background>k__BackingField = value;
			}
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x000046B4 File Offset: 0x000028B4
		public ActionResponseViewModel()
		{
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00066394 File Offset: 0x00064594
		public ActionResponseViewModel(bool success, string msg = "")
		{
			this.Response = (success ? ((string)Application.Current.TryFindResource("Saved")) : ((string)Application.Current.TryFindResource("Error")));
			if (!string.IsNullOrEmpty(msg))
			{
				this.Response = msg;
			}
			this.Background = (success ? new SolidColorBrush(Colors.LimeGreen) : new SolidColorBrush(Colors.Orange));
		}

		// Token: 0x04001203 RID: 4611
		[CompilerGenerated]
		private string <Response>k__BackingField;

		// Token: 0x04001204 RID: 4612
		[CompilerGenerated]
		private SolidColorBrush <Background>k__BackingField;
	}
}
