using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ASC.ViewModel;
using DevExpress.Xpf.Docking;

namespace ASC.ViewModels.Attributes
{
	// Token: 0x020004CC RID: 1228
	public class ComboBoxViewModel : AttributeBase, INotifyPropertyChanged, IMVVMDockingProperties
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06002F5D RID: 12125 RVA: 0x0009B588 File Offset: 0x00099788
		// (remove) Token: 0x06002F5E RID: 12126 RVA: 0x0009B5C0 File Offset: 0x000997C0
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

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x0009B5FC File Offset: 0x000997FC
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x0009B610 File Offset: 0x00099810
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
				if (!string.Equals(this.<NullText>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1532406517;
				IL_14:
				switch ((num ^ -999529246) % 4)
				{
				case 0:
					IL_33:
					num = -671552135;
					goto IL_14;
				case 1:
					return;
				case 2:
					goto IL_0F;
				}
				this.<NullText>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.NullText);
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x0009B66C File Offset: 0x0009986C
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x0009B680 File Offset: 0x00099880
		public List<string> Values
		{
			[CompilerGenerated]
			get
			{
				return this.<Values>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Values>k__BackingField, value))
				{
					return;
				}
				this.<Values>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Values);
			}
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x0009B6B0 File Offset: 0x000998B0
		public ComboBoxViewModel(fields field)
		{
			base.FieldId = field.id;
			base.FieldName = field.name;
			base.Required = field.required;
			this.NullText = field.name;
			string def_values = field.def_values;
			if (string.IsNullOrEmpty(def_values))
			{
				return;
			}
			this.Values = new List<string>();
			string[] separator = new string[]
			{
				"\r\n"
			};
			string[] collection = def_values.Split(separator, StringSplitOptions.None);
			this.Values.AddRange(collection);
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x0009B734 File Offset: 0x00099934
		public ComboBoxViewModel(fields field, field_values value) : this(field)
		{
			base.Text = value.value;
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x0009B754 File Offset: 0x00099954
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x0009B768 File Offset: 0x00099968
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

		// Token: 0x06002F67 RID: 12135 RVA: 0x0009B78C File Offset: 0x0009998C
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

		// Token: 0x04001ACE RID: 6862
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001ACF RID: 6863
		[CompilerGenerated]
		private string <NullText>k__BackingField;

		// Token: 0x04001AD0 RID: 6864
		[CompilerGenerated]
		private List<string> <Values>k__BackingField;
	}
}
