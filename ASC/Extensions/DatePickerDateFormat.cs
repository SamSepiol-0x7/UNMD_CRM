using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;

namespace ASC.Extensions
{
	// Token: 0x02000B6E RID: 2926
	public class DatePickerDateFormat
	{
		// Token: 0x060051D8 RID: 20952 RVA: 0x0015FB24 File Offset: 0x0015DD24
		public static string GetDateFormat(DependencyObject dobj)
		{
			return (string)dobj.GetValue(DatePickerDateFormat.DateFormatProperty);
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x0015FB44 File Offset: 0x0015DD44
		public static void SetDateFormat(DependencyObject dobj, string value)
		{
			dobj.SetValue(DatePickerDateFormat.DateFormatProperty, value);
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x0015FB60 File Offset: 0x0015DD60
		private static void OnDateFormatChanged(DependencyObject dobj, DependencyPropertyChangedEventArgs e)
		{
			DatePicker arg = (DatePicker)dobj;
			Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action<DatePicker>(DatePickerDateFormat.ApplyDateFormat), arg);
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x0015FB94 File Offset: 0x0015DD94
		private static void ApplyDateFormat(DatePicker datePicker)
		{
			Binding binding = new Binding("SelectedDate")
			{
				RelativeSource = new RelativeSource
				{
					AncestorType = typeof(DatePicker)
				},
				Converter = new DatePickerDateFormat.DatePickerDateTimeConverter(),
				ConverterParameter = new Tuple<DatePicker, string>(datePicker, DatePickerDateFormat.GetDateFormat(datePicker)),
				StringFormat = DatePickerDateFormat.GetDateFormat(datePicker)
			};
			TextBox templateTextBox = DatePickerDateFormat.GetTemplateTextBox(datePicker);
			templateTextBox.SetBinding(TextBox.TextProperty, binding);
			templateTextBox.PreviewKeyDown -= DatePickerDateFormat.TextBoxOnPreviewKeyDown;
			templateTextBox.PreviewKeyDown += DatePickerDateFormat.TextBoxOnPreviewKeyDown;
			ButtonBase templateButton = DatePickerDateFormat.GetTemplateButton(datePicker);
			datePicker.CalendarOpened -= DatePickerDateFormat.DatePickerOnCalendarOpened;
			datePicker.CalendarOpened += DatePickerDateFormat.DatePickerOnCalendarOpened;
			templateButton.PreviewMouseUp -= DatePickerDateFormat.DropDownButtonPreviewMouseUp;
			templateButton.PreviewMouseUp += DatePickerDateFormat.DropDownButtonPreviewMouseUp;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x0015FC74 File Offset: 0x0015DE74
		private static ButtonBase GetTemplateButton(DatePicker datePicker)
		{
			return (ButtonBase)datePicker.Template.FindName("PART_Button", datePicker);
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x0015FC98 File Offset: 0x0015DE98
		private static void DropDownButtonPreviewMouseUp(object sender, MouseButtonEventArgs e)
		{
			FrameworkElement frameworkElement = sender as FrameworkElement;
			if (frameworkElement == null)
			{
				return;
			}
			DatePicker datePicker = frameworkElement.TryFindParent<DatePicker>();
			if (datePicker != null && datePicker.SelectedDate != null)
			{
				ButtonBase templateButton = DatePickerDateFormat.GetTemplateButton(datePicker);
				if (e.OriginalSource == templateButton)
				{
					if (!datePicker.IsDropDownOpen)
					{
						datePicker.SetCurrentValue(DatePicker.IsDropDownOpenProperty, true);
						datePicker.SetCurrentValue(DatePicker.DisplayDateProperty, datePicker.SelectedDate.Value);
						templateButton.ReleaseMouseCapture();
						e.Handled = true;
					}
				}
				return;
			}
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x0015FD24 File Offset: 0x0015DF24
		private static TextBox GetTemplateTextBox(Control control)
		{
			control.ApplyTemplate();
			object obj;
			if (control == null)
			{
				obj = null;
			}
			else
			{
				ControlTemplate template = control.Template;
				obj = ((template != null) ? template.FindName("PART_TextBox", control) : null);
			}
			return (TextBox)obj;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x0015FD5C File Offset: 0x0015DF5C
		private static void TextBoxOnPreviewKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				goto IL_2D;
			}
			IL_09:
			int num = 288997409;
			IL_0E:
			switch ((num ^ 1161759347) % 4)
			{
			case 0:
				goto IL_09;
			case 1:
			{
				IL_2D:
				e.Handled = true;
				TextBox textBox = (TextBox)sender;
				DatePicker datePicker = (DatePicker)textBox.TemplatedParent;
				string text = textBox.Text;
				string dateFormat = DatePickerDateFormat.GetDateFormat(datePicker);
				datePicker.SelectedDate = DatePickerDateFormat.DatePickerDateTimeConverter.StringToDateTime(datePicker, dateFormat, text);
				num = 75684988;
				goto IL_0E;
			}
			case 2:
				return;
			}
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x0015FDD4 File Offset: 0x0015DFD4
		private static void DatePickerOnCalendarOpened(object sender, RoutedEventArgs e)
		{
			DatePicker datePicker = (DatePicker)sender;
			TextBox templateTextBox = DatePickerDateFormat.GetTemplateTextBox(datePicker);
			string dateFormat = DatePickerDateFormat.GetDateFormat(datePicker);
			templateTextBox.Text = DatePickerDateFormat.DatePickerDateTimeConverter.DateTimeToString(dateFormat, datePicker.SelectedDate);
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x000046B4 File Offset: 0x000028B4
		public DatePickerDateFormat()
		{
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x0015FE08 File Offset: 0x0015E008
		// Note: this type is marked as 'beforefieldinit'.
		static DatePickerDateFormat()
		{
		}

		// Token: 0x040035BA RID: 13754
		public static readonly DependencyProperty DateFormatProperty = DependencyProperty.RegisterAttached("DateFormat", typeof(string), typeof(DatePickerDateFormat), new PropertyMetadata(new PropertyChangedCallback(DatePickerDateFormat.OnDateFormatChanged)));

		// Token: 0x02000B6F RID: 2927
		private class DatePickerDateTimeConverter : IValueConverter
		{
			// Token: 0x060051E3 RID: 20963 RVA: 0x0015FE4C File Offset: 0x0015E04C
			public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			{
				string item = ((Tuple<DatePicker, string>)parameter).Item2;
				DateTime? selectedDate = (DateTime?)value;
				return DatePickerDateFormat.DatePickerDateTimeConverter.DateTimeToString(item, selectedDate);
			}

			// Token: 0x060051E4 RID: 20964 RVA: 0x0015FE74 File Offset: 0x0015E074
			public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			{
				Tuple<DatePicker, string> tuple = (Tuple<DatePicker, string>)parameter;
				string dateStr = (string)value;
				return DatePickerDateFormat.DatePickerDateTimeConverter.StringToDateTime(tuple.Item1, tuple.Item2, dateStr);
			}

			// Token: 0x060051E5 RID: 20965 RVA: 0x0015FEA8 File Offset: 0x0015E0A8
			public static string DateTimeToString(string formatStr, DateTime? selectedDate)
			{
				if (selectedDate == null)
				{
					return null;
				}
				return selectedDate.Value.ToString(formatStr);
			}

			// Token: 0x060051E6 RID: 20966 RVA: 0x0015FED0 File Offset: 0x0015E0D0
			public static DateTime? StringToDateTime(DatePicker datePicker, string formatStr, string dateStr)
			{
				DateTime value;
				bool flag = DateTime.TryParseExact(dateStr, formatStr, CultureInfo.CurrentCulture, DateTimeStyles.None, out value) ?? DateTime.TryParse(dateStr, CultureInfo.CurrentCulture, DateTimeStyles.None, out value);
				if (flag)
				{
					return new DateTime?(value);
				}
				return datePicker.SelectedDate;
			}

			// Token: 0x060051E7 RID: 20967 RVA: 0x000046B4 File Offset: 0x000028B4
			public DatePickerDateTimeConverter()
			{
			}
		}
	}
}
