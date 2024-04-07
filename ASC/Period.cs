using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC
{
	// Token: 0x020000B9 RID: 185
	public class Period : ViewModelBase, IPeriod
	{
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0002A430 File Offset: 0x00028630
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x0002A444 File Offset: 0x00028644
		public DateTime From
		{
			[CompilerGenerated]
			get
			{
				return this.<From>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<From>k__BackingField, value))
				{
					return;
				}
				this.<From>k__BackingField = value;
				this.RaisePropertyChanged("From");
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0002A474 File Offset: 0x00028674
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x0002A488 File Offset: 0x00028688
		public DateTime To
		{
			[CompilerGenerated]
			get
			{
				return this.<To>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<To>k__BackingField, value))
				{
					return;
				}
				this.<To>k__BackingField = value;
				this.RaisePropertyChanged("To");
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0002A4B8 File Offset: 0x000286B8
		public Period()
		{
			this.From = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);
			this.To = DateTime.UtcNow;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0002A4FC File Offset: 0x000286FC
		public Period(DateTime from, DateTime to) : this()
		{
			this.From = from;
			this.To = to;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0002A520 File Offset: 0x00028720
		[Command]
		public void Refresh()
		{
			EventHandler refreshEventHandler = this.RefreshEventHandler;
			if (refreshEventHandler == null)
			{
				return;
			}
			refreshEventHandler(this, new EventArgs());
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0002A544 File Offset: 0x00028744
		[Command]
		public void PlusDay()
		{
			this.AddDays(1);
			this.Refresh();
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0002A560 File Offset: 0x00028760
		[Command]
		public void MinusDay()
		{
			this.SubtractDays(1);
			this.Refresh();
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0002A57C File Offset: 0x0002877C
		[Command]
		public void ThisMonth()
		{
			this.From = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);
			this.To = DateTime.UtcNow;
			this.Refresh();
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0002A5C0 File Offset: 0x000287C0
		public void AddDays(int days = 1)
		{
			this.From = this.From.AddDays((double)days);
			this.To = this.To.AddDays((double)days);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0002A5FC File Offset: 0x000287FC
		public void SubtractDays(int days = 1)
		{
			this.From = this.From.AddDays((double)(-(double)days));
			this.To = this.To.AddDays((double)(-(double)days));
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0002A638 File Offset: 0x00028838
		public IEnumerable<DateTime> EachDay()
		{
			Period.<EachDay>d__17 <EachDay>d__ = new Period.<EachDay>d__17(-2);
			<EachDay>d__.<>4__this = this;
			return <EachDay>d__;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0002A654 File Offset: 0x00028854
		public IEnumerable<DateTime> EachMonth()
		{
			DateTime month = this.From.Date;
			while (month.Date <= this.To.Date || month.Month == this.To.Month)
			{
				yield return month;
				int num;
				if (num != 1)
				{
					yield break;
				}
				month = month.AddMonths(1);
			}
			yield break;
		}

		// Token: 0x04000941 RID: 2369
		[CompilerGenerated]
		private DateTime <From>k__BackingField;

		// Token: 0x04000942 RID: 2370
		[CompilerGenerated]
		private DateTime <To>k__BackingField;

		// Token: 0x04000943 RID: 2371
		public EventHandler RefreshEventHandler;

		// Token: 0x020000BA RID: 186
		[CompilerGenerated]
		private sealed class <EachDay>d__17 : IEnumerable<DateTime>, IEnumerator<DateTime>, IDisposable, IEnumerable, IEnumerator
		{
			// Token: 0x0600133D RID: 4925 RVA: 0x0002A670 File Offset: 0x00028870
			[DebuggerHidden]
			public <EachDay>d__17(int <>1__state)
			{
				this.<>1__state = <>1__state;
				this.<>l__initialThreadId = Environment.CurrentManagedThreadId;
			}

			// Token: 0x0600133E RID: 4926 RVA: 0x00023150 File Offset: 0x00021350
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600133F RID: 4927 RVA: 0x0002A698 File Offset: 0x00028898
			bool IEnumerator.MoveNext()
			{
				int num = this.<>1__state;
				Period period = this;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.<>1__state = -1;
					this.<day>5__2 = this.<day>5__2.AddDays(1.0);
				}
				else
				{
					this.<>1__state = -1;
					this.<day>5__2 = period.From.Date;
				}
				if (!(this.<day>5__2.Date <= period.To.Date))
				{
					return false;
				}
				this.<>2__current = this.<day>5__2;
				this.<>1__state = 1;
				return true;
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06001340 RID: 4928 RVA: 0x0002A730 File Offset: 0x00028930
			DateTime IEnumerator<DateTime>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06001341 RID: 4929 RVA: 0x0002A744 File Offset: 0x00028944
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06001342 RID: 4930 RVA: 0x0002A758 File Offset: 0x00028958
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06001343 RID: 4931 RVA: 0x0002A770 File Offset: 0x00028970
			[DebuggerHidden]
			IEnumerator<DateTime> IEnumerable<DateTime>.GetEnumerator()
			{
				Period.<EachDay>d__17 <EachDay>d__;
				if (this.<>1__state == -2 && this.<>l__initialThreadId == Environment.CurrentManagedThreadId)
				{
					this.<>1__state = 0;
					<EachDay>d__ = this;
				}
				else
				{
					<EachDay>d__ = new Period.<EachDay>d__17(0);
					<EachDay>d__.<>4__this = this;
				}
				return <EachDay>d__;
			}

			// Token: 0x06001344 RID: 4932 RVA: 0x0002A7B4 File Offset: 0x000289B4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.System.Collections.Generic.IEnumerable<System.DateTime>.GetEnumerator();
			}

			// Token: 0x04000944 RID: 2372
			private int <>1__state;

			// Token: 0x04000945 RID: 2373
			private DateTime <>2__current;

			// Token: 0x04000946 RID: 2374
			private int <>l__initialThreadId;

			// Token: 0x04000947 RID: 2375
			public Period <>4__this;

			// Token: 0x04000948 RID: 2376
			private DateTime <day>5__2;
		}

		// Token: 0x020000BB RID: 187
		[CompilerGenerated]
		private sealed class <EachMonth>d__18 : IEnumerable<DateTime>, IEnumerator<DateTime>, IDisposable, IEnumerable, IEnumerator
		{
			// Token: 0x06001345 RID: 4933 RVA: 0x0002A7C8 File Offset: 0x000289C8
			[DebuggerHidden]
			public <EachMonth>d__18(int <>1__state)
			{
				this.<>1__state = <>1__state;
				this.<>l__initialThreadId = Environment.CurrentManagedThreadId;
			}

			// Token: 0x06001346 RID: 4934 RVA: 0x00023150 File Offset: 0x00021350
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06001347 RID: 4935 RVA: 0x0002A7F0 File Offset: 0x000289F0
			bool IEnumerator.MoveNext()
			{
				int num = this.<>1__state;
				Period period = this;
				if (num == 0)
				{
					this.<>1__state = -1;
					month = period.From.Date;
				}
				else
				{
					if (num != 1)
					{
						return false;
					}
					this.<>1__state = -1;
					month = month.AddMonths(1);
				}
				if (month.Date <= period.To.Date || month.Month == period.To.Month)
				{
					this.<>2__current = month;
					this.<>1__state = 1;
					return true;
				}
				return false;
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x06001348 RID: 4936 RVA: 0x0002A89C File Offset: 0x00028A9C
			DateTime IEnumerator<DateTime>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06001349 RID: 4937 RVA: 0x0002A744 File Offset: 0x00028944
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x0600134A RID: 4938 RVA: 0x0002A8B0 File Offset: 0x00028AB0
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x0600134B RID: 4939 RVA: 0x0002A8C8 File Offset: 0x00028AC8
			[DebuggerHidden]
			IEnumerator<DateTime> IEnumerable<DateTime>.GetEnumerator()
			{
				Period.<EachMonth>d__18 <EachMonth>d__;
				if (this.<>1__state == -2 && this.<>l__initialThreadId == Environment.CurrentManagedThreadId)
				{
					this.<>1__state = 0;
					<EachMonth>d__ = this;
				}
				else
				{
					<EachMonth>d__ = new Period.<EachMonth>d__18(0);
					<EachMonth>d__.<>4__this = this;
				}
				return <EachMonth>d__;
			}

			// Token: 0x0600134C RID: 4940 RVA: 0x0002A90C File Offset: 0x00028B0C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.System.Collections.Generic.IEnumerable<System.DateTime>.GetEnumerator();
			}

			// Token: 0x04000949 RID: 2377
			private int <>1__state;

			// Token: 0x0400094A RID: 2378
			private DateTime <>2__current;

			// Token: 0x0400094B RID: 2379
			private int <>l__initialThreadId;

			// Token: 0x0400094C RID: 2380
			public Period <>4__this;

			// Token: 0x0400094D RID: 2381
			private DateTime <month>5__2;
		}
	}
}
