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
	// Token: 0x020004CD RID: 1229
	public class DatePickerViewModel : AttributeBase, INotifyPropertyChanged, IMVVMDockingProperties
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06002F68 RID: 12136 RVA: 0x0009B7B0 File Offset: 0x000999B0
		// (remove) Token: 0x06002F69 RID: 12137 RVA: 0x0009B7E8 File Offset: 0x000999E8
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x0009B820 File Offset: 0x00099A20
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x0009B834 File Offset: 0x00099A34
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

		// Token: 0x06002F6C RID: 12140 RVA: 0x0009B864 File Offset: 0x00099A64
		public DatePickerViewModel(fields field)
		{
			base.FieldId = field.id;
			base.FieldName = field.name;
			base.Required = field.required;
			base.Text = field.def_values;
			this.NullText = field.name;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x0009B8B4 File Offset: 0x00099AB4
		public DatePickerViewModel(fields field, field_values value) : this(field)
		{
			base.Text = value.value;
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x0009B754 File Offset: 0x00099954
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x0009B8D4 File Offset: 0x00099AD4
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

		// Token: 0x06002F70 RID: 12144 RVA: 0x0009B8F8 File Offset: 0x00099AF8
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

		// Token: 0x04001AD1 RID: 6865
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001AD2 RID: 6866
		[CompilerGenerated]
		private string <NullText>k__BackingField;
	}
}
