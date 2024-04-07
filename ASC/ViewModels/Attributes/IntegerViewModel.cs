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
	// Token: 0x020004CE RID: 1230
	public class IntegerViewModel : AttributeBase, INotifyPropertyChanged, IMVVMDockingProperties
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06002F71 RID: 12145 RVA: 0x0009B91C File Offset: 0x00099B1C
		// (remove) Token: 0x06002F72 RID: 12146 RVA: 0x0009B958 File Offset: 0x00099B58
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

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x0009B990 File Offset: 0x00099B90
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x0009B9A4 File Offset: 0x00099BA4
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

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x0009B754 File Offset: 0x00099954
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x0009B9D4 File Offset: 0x00099BD4
		public string TargetName
		{
			get
			{
				return "DockPanels";
			}
			set
			{
				if (!string.Equals(this.TargetName, value, StringComparison.Ordinal))
				{
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x0009B9F8 File Offset: 0x00099BF8
		public IntegerViewModel(fields field)
		{
			base.FieldId = field.id;
			base.FieldName = field.name;
			base.Required = field.required;
			base.Text = field.def_values;
			this.NullText = field.name;
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x0009BA48 File Offset: 0x00099C48
		public IntegerViewModel(fields field, field_values value) : this(field)
		{
			base.Text = value.value;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x0009BA68 File Offset: 0x00099C68
		public int? GetValue()
		{
			if (string.IsNullOrEmpty(base.Text))
			{
				goto IL_1C;
			}
			goto IL_63;
			int num;
			int? result;
			for (;;)
			{
				IL_30:
				switch ((num ^ 904070797) % 6)
				{
				case 0:
					result = null;
					num = 46696684;
					continue;
				case 2:
					goto IL_76;
				case 3:
					goto IL_1C;
				case 4:
					goto IL_80;
				case 5:
					goto IL_63;
				}
				break;
			}
			return result;
			IL_76:
			result = null;
			return result;
			IL_80:
			int value;
			return new int?(value);
			IL_1C:
			num = 1702133527;
			goto IL_30;
			IL_63:
			num = ((!int.TryParse(base.Text, out value)) ? 1086335855 : 2113272921);
			goto IL_30;
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x0009BAFC File Offset: 0x00099CFC
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

		// Token: 0x04001AD3 RID: 6867
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04001AD4 RID: 6868
		[CompilerGenerated]
		private string <NullText>k__BackingField;
	}
}
