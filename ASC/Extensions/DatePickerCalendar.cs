using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace ASC.Extensions
{
	// Token: 0x02000B6D RID: 2925
	public class DatePickerCalendar
	{
		// Token: 0x060051CC RID: 20940 RVA: 0x0015F858 File Offset: 0x0015DA58
		public static bool GetIsMonthYear(DependencyObject dobj)
		{
			return (bool)dobj.GetValue(DatePickerCalendar.IsMonthYearProperty);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x0015F878 File Offset: 0x0015DA78
		public static void SetIsMonthYear(DependencyObject dobj, bool value)
		{
			dobj.SetValue(DatePickerCalendar.IsMonthYearProperty, value);
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x0015F898 File Offset: 0x0015DA98
		private static void OnIsMonthYearChanged(DependencyObject dobj, DependencyPropertyChangedEventArgs e)
		{
			DatePicker arg = (DatePicker)dobj;
			Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, new Action<DatePicker, DependencyPropertyChangedEventArgs>(DatePickerCalendar.SetCalendarEventHandlers), arg, new object[]
			{
				e
			});
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x0015F8DC File Offset: 0x0015DADC
		private static void SetCalendarEventHandlers(DatePicker datePicker, DependencyPropertyChangedEventArgs e)
		{
			if (e.NewValue == e.OldValue)
			{
				return;
			}
			if ((bool)e.NewValue)
			{
				datePicker.CalendarOpened += DatePickerCalendar.DatePickerOnCalendarOpened;
				datePicker.CalendarClosed += DatePickerCalendar.DatePickerOnCalendarClosed;
				return;
			}
			datePicker.CalendarOpened -= DatePickerCalendar.DatePickerOnCalendarOpened;
			datePicker.CalendarClosed -= DatePickerCalendar.DatePickerOnCalendarClosed;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x0015F954 File Offset: 0x0015DB54
		private static void DatePickerOnCalendarOpened(object sender, RoutedEventArgs e)
		{
			Calendar datePickerCalendar = DatePickerCalendar.GetDatePickerCalendar(sender);
			datePickerCalendar.DisplayMode = CalendarMode.Year;
			datePickerCalendar.DisplayModeChanged += DatePickerCalendar.CalendarOnDisplayModeChanged;
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x0015F980 File Offset: 0x0015DB80
		private static void DatePickerOnCalendarClosed(object sender, RoutedEventArgs e)
		{
			DatePicker datePicker = (DatePicker)sender;
			Calendar datePickerCalendar = DatePickerCalendar.GetDatePickerCalendar(sender);
			datePicker.SelectedDate = datePickerCalendar.SelectedDate;
			datePickerCalendar.DisplayModeChanged -= DatePickerCalendar.CalendarOnDisplayModeChanged;
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x0015F9B8 File Offset: 0x0015DBB8
		private static void CalendarOnDisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
		{
			Calendar calendar = (Calendar)sender;
			if (calendar.DisplayMode == CalendarMode.Month)
			{
				calendar.SelectedDate = DatePickerCalendar.GetSelectedCalendarDate(new DateTime?(calendar.DisplayDate));
				DatePickerCalendar.GetCalendarsDatePicker(calendar).IsDropDownOpen = false;
				return;
			}
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x0015F9F8 File Offset: 0x0015DBF8
		private static Calendar GetDatePickerCalendar(object sender)
		{
			DatePicker datePicker = (DatePicker)sender;
			return (Calendar)((Popup)datePicker.Template.FindName("PART_Popup", datePicker)).Child;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x0015FA2C File Offset: 0x0015DC2C
		private static DatePicker GetCalendarsDatePicker(FrameworkElement child)
		{
			FrameworkElement frameworkElement = (FrameworkElement)child.Parent;
			if (frameworkElement.Name == "PART_Root")
			{
				return (DatePicker)frameworkElement.TemplatedParent;
			}
			return DatePickerCalendar.GetCalendarsDatePicker(frameworkElement);
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x0015FA6C File Offset: 0x0015DC6C
		private static DateTime? GetSelectedCalendarDate(DateTime? selectedDate)
		{
			if (selectedDate != null)
			{
				goto IL_2D;
			}
			IL_09:
			int num = 1477450811;
			IL_0E:
			DateTime value;
			switch ((num ^ 719919534) % 4)
			{
			case 0:
				IL_2D:
				value = selectedDate.Value;
				num = 123067813;
				goto IL_0E;
			case 1:
				return null;
			case 2:
				goto IL_09;
			}
			int year = value.Year;
			value = selectedDate.Value;
			return new DateTime?(new DateTime(year, value.Month, 1));
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x000046B4 File Offset: 0x000028B4
		public DatePickerCalendar()
		{
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x0015FAE0 File Offset: 0x0015DCE0
		// Note: this type is marked as 'beforefieldinit'.
		static DatePickerCalendar()
		{
		}

		// Token: 0x040035B9 RID: 13753
		public static readonly DependencyProperty IsMonthYearProperty = DependencyProperty.RegisterAttached("IsMonthYear", typeof(bool), typeof(DatePickerCalendar), new PropertyMetadata(new PropertyChangedCallback(DatePickerCalendar.OnIsMonthYearChanged)));
	}
}
