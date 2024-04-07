using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ASC.ViewModel;
using DevExpress.Xpf.Docking;

namespace ASC.ViewModels.Attributes
{
	// Token: 0x020004CF RID: 1231
	public class PanelViewModel : AttributeBase, INotifyPropertyChanged, IMVVMDockingProperties
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06002F7B RID: 12155 RVA: 0x0009BB20 File Offset: 0x00099D20
		// (remove) Token: 0x06002F7C RID: 12156 RVA: 0x0009BB58 File Offset: 0x00099D58
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

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x0009BB94 File Offset: 0x00099D94
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x0009BBA8 File Offset: 0x00099DA8
		public string NullText
		{
			[CompilerGenerated]
			get
			{
				return this.<NullText>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NullText>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NullText>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.NullText);
			}
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x0009BBD8 File Offset: 0x00099DD8
		public PanelViewModel(fields field)
		{
			base.FieldId = field.id;
			base.FieldName = field.name;
			base.Required = field.required;
			base.Text = field.def_values;
			this.NullText = field.name;
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x0009BC28 File Offset: 0x00099E28
		public PanelViewModel(fields field, field_values value) : this(field)
		{
			base.Text = value.value;
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x0009B754 File Offset: 0x00099954
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x0009BC48 File Offset: 0x00099E48
		string IMVVMDockingProperties.TargetName
		{
			get
			{
				return "DockPanels";
			}
			set
			{
				if (!string.Equals(this.DevExpress.Xpf.Docking.IMVVMDockingProperties.TargetName, value, StringComparison.Ordinal))
				{
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x0009BC6C File Offset: 0x00099E6C
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

		// Token: 0x04001AD5 RID: 6869
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001AD6 RID: 6870
		[CompilerGenerated]
		private string <NullText>k__BackingField;
	}
}
