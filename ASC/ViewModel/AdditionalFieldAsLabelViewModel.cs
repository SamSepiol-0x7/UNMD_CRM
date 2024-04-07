using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using DevExpress.Xpf.Docking;

namespace ASC.ViewModel
{
	// Token: 0x020002BD RID: 701
	public class AdditionalFieldAsLabelViewModel : AttributeBase, INotifyPropertyChanged, IMVVMDockingProperties
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600236F RID: 9071 RVA: 0x00068E4C File Offset: 0x0006704C
		// (remove) Token: 0x06002370 RID: 9072 RVA: 0x00068E84 File Offset: 0x00067084
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

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x00068EC0 File Offset: 0x000670C0
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x00068ED4 File Offset: 0x000670D4
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

		// Token: 0x06002373 RID: 9075 RVA: 0x00068F04 File Offset: 0x00067104
		public AdditionalFieldAsLabelViewModel(fields field)
		{
			base.FieldId = field.id;
			base.FieldName = field.name;
			base.Required = field.required;
			base.Text = field.def_values;
			this.NullText = field.name;
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00068F54 File Offset: 0x00067154
		public AdditionalFieldAsLabelViewModel(fields field, field_values value) : this(field)
		{
			base.Text = value.value;
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x00068F74 File Offset: 0x00067174
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x00068F88 File Offset: 0x00067188
		string IMVVMDockingProperties.TargetName
		{
			get
			{
				return "UserFields";
			}
			set
			{
				if (!string.Equals(this.DevExpress.Xpf.Docking.IMVVMDockingProperties.TargetName, value, StringComparison.Ordinal))
				{
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00068FAC File Offset: 0x000671AC
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

		// Token: 0x04001271 RID: 4721
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001272 RID: 4722
		[CompilerGenerated]
		private string <NullText>k__BackingField;
	}
}
