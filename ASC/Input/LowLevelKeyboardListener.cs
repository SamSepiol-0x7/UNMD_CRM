using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Input;

namespace ASC.Input
{
	// Token: 0x020001E5 RID: 485
	internal class LowLevelKeyboardListener
	{
		// Token: 0x06001AB3 RID: 6835
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardListener.LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

		// Token: 0x06001AB4 RID: 6836
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		// Token: 0x06001AB5 RID: 6837
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x06001AB6 RID: 6838
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06001AB7 RID: 6839 RVA: 0x0004EC34 File Offset: 0x0004CE34
		// (remove) Token: 0x06001AB8 RID: 6840 RVA: 0x0004EC6C File Offset: 0x0004CE6C
		public event EventHandler<KeyPressedArgs> OnKeyPressed
		{
			[CompilerGenerated]
			add
			{
				EventHandler<KeyPressedArgs> eventHandler = this.OnKeyPressed;
				EventHandler<KeyPressedArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<KeyPressedArgs> value2 = (EventHandler<KeyPressedArgs>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<KeyPressedArgs>>(ref this.OnKeyPressed, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<KeyPressedArgs> eventHandler = this.OnKeyPressed;
				EventHandler<KeyPressedArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<KeyPressedArgs> value2 = (EventHandler<KeyPressedArgs>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<KeyPressedArgs>>(ref this.OnKeyPressed, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0004ECA8 File Offset: 0x0004CEA8
		public LowLevelKeyboardListener()
		{
			this._proc = new LowLevelKeyboardListener.LowLevelKeyboardProc(this.HookCallback);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0004ECD8 File Offset: 0x0004CED8
		public void HookKeyboard()
		{
			this._hookID = this.SetHook(this._proc);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0004ECF8 File Offset: 0x0004CEF8
		public void UnHookKeyboard()
		{
			LowLevelKeyboardListener.UnhookWindowsHookEx(this._hookID);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0004ED14 File Offset: 0x0004CF14
		private IntPtr SetHook(LowLevelKeyboardListener.LowLevelKeyboardProc proc)
		{
			IntPtr result;
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				using (ProcessModule mainModule = currentProcess.MainModule)
				{
					result = LowLevelKeyboardListener.SetWindowsHookEx(13, proc, LowLevelKeyboardListener.GetModuleHandle(mainModule.ModuleName), 0U);
				}
			}
			return result;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0004ED78 File Offset: 0x0004CF78
		private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if ((nCode >= 0 && wParam == (IntPtr)256) || wParam == (IntPtr)260)
			{
				int virtualKey = Marshal.ReadInt32(lParam);
				if (this.OnKeyPressed != null)
				{
					this.OnKeyPressed(this, new KeyPressedArgs(KeyInterop.KeyFromVirtualKey(virtualKey)));
				}
			}
			return LowLevelKeyboardListener.CallNextHookEx(this._hookID, nCode, wParam, lParam);
		}

		// Token: 0x04000E01 RID: 3585
		private const int WH_KEYBOARD_LL = 13;

		// Token: 0x04000E02 RID: 3586
		private const int WM_KEYDOWN = 256;

		// Token: 0x04000E03 RID: 3587
		private const int WM_SYSKEYDOWN = 260;

		// Token: 0x04000E04 RID: 3588
		[CompilerGenerated]
		private EventHandler<KeyPressedArgs> OnKeyPressed;

		// Token: 0x04000E05 RID: 3589
		private LowLevelKeyboardListener.LowLevelKeyboardProc _proc;

		// Token: 0x04000E06 RID: 3590
		private IntPtr _hookID = IntPtr.Zero;

		// Token: 0x020001E6 RID: 486
		// (Invoke) Token: 0x06001ABF RID: 6847
		public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
	}
}
