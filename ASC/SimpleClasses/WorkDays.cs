using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ASC.SimpleClasses
{
	// Token: 0x0200021A RID: 538
	public class WorkDays : INotifyPropertyChanged
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06001C64 RID: 7268 RVA: 0x00053414 File Offset: 0x00051614
		// (remove) Token: 0x06001C65 RID: 7269 RVA: 0x00053450 File Offset: 0x00051650
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00053488 File Offset: 0x00051688
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0005349C File Offset: 0x0005169C
		public string DayName
		{
			[CompilerGenerated]
			get
			{
				return this.<DayName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DayName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DayName>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.DayName);
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x000534CC File Offset: 0x000516CC
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x000534E0 File Offset: 0x000516E0
		public bool IsWorkingDay
		{
			[CompilerGenerated]
			get
			{
				return this.<IsWorkingDay>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsWorkingDay>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1737984899;
				IL_10:
				switch ((num ^ -786135485) % 4)
				{
				case 0:
					goto IL_0B;
				case 1:
					IL_2F:
					this.<IsWorkingDay>k__BackingField = value;
					this.<>OnPropertyChanged(<>PropertyChangedEventArgs.IsWorkingDay);
					num = -2068525020;
					goto IL_10;
				case 2:
					return;
				}
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00053538 File Offset: 0x00051738
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0005354C File Offset: 0x0005174C
		public DateTime Open
		{
			[CompilerGenerated]
			get
			{
				return this.<Open>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Open>k__BackingField, value))
				{
					return;
				}
				this.<Open>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Open);
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0005357C File Offset: 0x0005177C
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x00053590 File Offset: 0x00051790
		public DateTime Close
		{
			[CompilerGenerated]
			get
			{
				return this.<Close>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Close>k__BackingField, value))
				{
					return;
				}
				this.<Close>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Close);
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000046B4 File Offset: 0x000028B4
		public WorkDays()
		{
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000535C0 File Offset: 0x000517C0
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x04000EF6 RID: 3830
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000EF7 RID: 3831
		[CompilerGenerated]
		private string <DayName>k__BackingField;

		// Token: 0x04000EF8 RID: 3832
		[CompilerGenerated]
		private bool <IsWorkingDay>k__BackingField;

		// Token: 0x04000EF9 RID: 3833
		[CompilerGenerated]
		private DateTime <Open>k__BackingField;

		// Token: 0x04000EFA RID: 3834
		[CompilerGenerated]
		private DateTime <Close>k__BackingField;
	}
}
