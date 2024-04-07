using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;

namespace ASC.ViewModels
{
	// Token: 0x0200045D RID: 1117
	public class BaseSearchViewModel : BaseViewModel
	{
		// Token: 0x06002C0E RID: 11278 RVA: 0x0008CC94 File Offset: 0x0008AE94
		public BaseSearchViewModel()
		{
			Application.Current.Dispatcher.BeginInvoke(new Action(delegate()
			{
				this._searchTimer = new DispatcherTimer();
				this._searchTimer.Tick += this.searchTimer_Tick;
				this._searchTimer.Interval = TimeSpan.FromMilliseconds(300.0);
			}), new object[0]);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0008CCCC File Offset: 0x0008AECC
		private void searchTimer_Tick(object sender, EventArgs e)
		{
			this.StopSearchTimer();
			this.OnSearchTimer();
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0007E558 File Offset: 0x0007C758
		public virtual void OnSearchTimer()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x0008CCE8 File Offset: 0x0008AEE8
		public void StopSearchTimer()
		{
			this._searchTimer.Tick -= this.searchTimer_Tick;
			this._searchTimer.Stop();
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0008CD18 File Offset: 0x0008AF18
		public void StartSearchTimer()
		{
			this._searchTimer.Tick += this.searchTimer_Tick;
			this._searchTimer.Start();
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x0008CD48 File Offset: 0x0008AF48
		[CompilerGenerated]
		private void <.ctor>b__1_0()
		{
			this._searchTimer = new DispatcherTimer();
			this._searchTimer.Tick += this.searchTimer_Tick;
			this._searchTimer.Interval = TimeSpan.FromMilliseconds(300.0);
		}

		// Token: 0x04001889 RID: 6281
		private DispatcherTimer _searchTimer;
	}
}
