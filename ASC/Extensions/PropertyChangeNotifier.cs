using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Data;

namespace ASC.Extensions
{
	// Token: 0x02000B68 RID: 2920
	public class PropertyChangeNotifier : DependencyObject
	{
		// Token: 0x060051B0 RID: 20912 RVA: 0x0015F1DC File Offset: 0x0015D3DC
		private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((PropertyChangeNotifier)d).OnValueChanged(e);
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060051B1 RID: 20913 RVA: 0x0015F1F8 File Offset: 0x0015D3F8
		// (remove) Token: 0x060051B2 RID: 20914 RVA: 0x0015F230 File Offset: 0x0015D430
		public event EventHandler ValueChanged
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.ValueChanged;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ValueChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.ValueChanged;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ValueChanged, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060051B3 RID: 20915 RVA: 0x0015F26C File Offset: 0x0015D46C
		// (set) Token: 0x060051B4 RID: 20916 RVA: 0x0015F284 File Offset: 0x0015D484
		public object Value
		{
			get
			{
				return base.GetValue(PropertyChangeNotifier.ValueProperty);
			}
			set
			{
				base.SetValue(PropertyChangeNotifier.ValueProperty, value);
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x0015F2A0 File Offset: 0x0015D4A0
		public DependencyObject PropertySource
		{
			get
			{
				if (this._propertySource != null && this._propertySource.IsAlive)
				{
					return (DependencyObject)this._propertySource.Target;
				}
				return null;
			}
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x0015F2D4 File Offset: 0x0015D4D4
		public PropertyChangeNotifier(DependencyObject propertySource, DependencyProperty property)
		{
			if (propertySource == null)
			{
				throw new ArgumentNullException("propertySource");
			}
			if (property == null)
			{
				throw new ArgumentNullException("property");
			}
			this._propertySource = new WeakReference(propertySource);
			Binding binding = new Binding();
			binding.Path = new PropertyPath(property);
			binding.Mode = BindingMode.OneWay;
			binding.Source = propertySource;
			BindingOperations.SetBinding(this, PropertyChangeNotifier.ValueProperty, binding);
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x0015F33C File Offset: 0x0015D53C
		protected virtual void OnValueChanged(DependencyPropertyChangedEventArgs e)
		{
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, EventArgs.Empty);
			}
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x0015F364 File Offset: 0x0015D564
		public void Dispose()
		{
			this.ValueChanged = null;
			BindingOperations.ClearBinding(this, PropertyChangeNotifier.ValueProperty);
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x0015F384 File Offset: 0x0015D584
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyChangeNotifier()
		{
		}

		// Token: 0x040035B4 RID: 13748
		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(object), typeof(PropertyChangeNotifier), new FrameworkPropertyMetadata(null, new PropertyChangedCallback(PropertyChangeNotifier.OnValuePropertyChanged)));

		// Token: 0x040035B5 RID: 13749
		private WeakReference _propertySource;

		// Token: 0x040035B6 RID: 13750
		[CompilerGenerated]
		private EventHandler ValueChanged;
	}
}
