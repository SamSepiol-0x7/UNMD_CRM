using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;

namespace ASC
{
	// Token: 0x020000C1 RID: 193
	public class RelayCommand : ICommand
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x0002AC10 File Offset: 0x00028E10
		public RelayCommand(Action<object> action)
		{
			this._action = action;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0002AC2C File Offset: 0x00028E2C
		public RelayCommand(Action<object> action, Func<bool> func)
		{
			this._action = action;
			this._canExecute = func;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0002AC50 File Offset: 0x00028E50
		public bool CanExecute(object parameter)
		{
			return this._canExecute == null || this._canExecute();
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600135E RID: 4958 RVA: 0x0002AC74 File Offset: 0x00028E74
		// (remove) Token: 0x0600135F RID: 4959 RVA: 0x0002ACB0 File Offset: 0x00028EB0
		public event EventHandler CanExecuteChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.CanExecuteChanged;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.CanExecuteChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.CanExecuteChanged;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.CanExecuteChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0002ACE8 File Offset: 0x00028EE8
		public void RaiseCanExecuteChanged()
		{
			EventHandler canExecuteChanged = this.CanExecuteChanged;
			if (canExecuteChanged != null)
			{
				canExecuteChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0002AD0C File Offset: 0x00028F0C
		public void Execute(object parameter)
		{
			if (parameter != null)
			{
				this._action(parameter);
				return;
			}
			this._action(null);
		}

		// Token: 0x04000958 RID: 2392
		private Action<object> _action;

		// Token: 0x04000959 RID: 2393
		private Func<bool> _canExecute;

		// Token: 0x0400095A RID: 2394
		[CompilerGenerated]
		private EventHandler CanExecuteChanged;
	}
}
