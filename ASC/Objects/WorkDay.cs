using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ASC.Common.Interfaces;
using Newtonsoft.Json;

namespace ASC.Objects
{
	// Token: 0x020008FD RID: 2301
	public class WorkDay : IWorkDay
	{
		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x00116D00 File Offset: 0x00114F00
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x00116D14 File Offset: 0x00114F14
		[JsonIgnore]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060047B1 RID: 18353 RVA: 0x00116D28 File Offset: 0x00114F28
		// (set) Token: 0x060047B2 RID: 18354 RVA: 0x00116D3C File Offset: 0x00114F3C
		[JsonIgnore]
		public string ShortName
		{
			[CompilerGenerated]
			get
			{
				return this.<ShortName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ShortName>k__BackingField = value;
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x00116D50 File Offset: 0x00114F50
		// (set) Token: 0x060047B4 RID: 18356 RVA: 0x00116D64 File Offset: 0x00114F64
		public DayOfWeek DayOfWeek
		{
			[CompilerGenerated]
			get
			{
				return this.<DayOfWeek>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<DayOfWeek>k__BackingField = value;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x00116D78 File Offset: 0x00114F78
		// (set) Token: 0x060047B6 RID: 18358 RVA: 0x00116D8C File Offset: 0x00114F8C
		public bool IsWorkday
		{
			[CompilerGenerated]
			get
			{
				return this.<IsWorkday>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<IsWorkday>k__BackingField = value;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x00116DA0 File Offset: 0x00114FA0
		// (set) Token: 0x060047B8 RID: 18360 RVA: 0x00116DB4 File Offset: 0x00114FB4
		public int OpenHours
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenHours>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OpenHours>k__BackingField = value;
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x00116DC8 File Offset: 0x00114FC8
		// (set) Token: 0x060047BA RID: 18362 RVA: 0x00116DDC File Offset: 0x00114FDC
		public int OpenMinutes
		{
			[CompilerGenerated]
			get
			{
				return this.<OpenMinutes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OpenMinutes>k__BackingField = value;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x00116DF0 File Offset: 0x00114FF0
		// (set) Token: 0x060047BC RID: 18364 RVA: 0x00116E04 File Offset: 0x00115004
		public int CloseHours
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseHours>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CloseHours>k__BackingField = value;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x00116E18 File Offset: 0x00115018
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x00116E2C File Offset: 0x0011502C
		public int CloseMinutes
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseMinutes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CloseMinutes>k__BackingField = value;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x00116E40 File Offset: 0x00115040
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x00116E68 File Offset: 0x00115068
		[JsonIgnore]
		public DateTime Open
		{
			get
			{
				return new DateTime(2018, 1, 1, this.OpenHours, this.OpenMinutes, 0, 0);
			}
			set
			{
				this.SetOpen((uint)value.Hour, (uint)value.Minute);
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x00116E8C File Offset: 0x0011508C
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x00116EB4 File Offset: 0x001150B4
		[JsonIgnore]
		public DateTime Close
		{
			get
			{
				return new DateTime(2018, 1, 1, this.CloseHours, this.CloseMinutes, 0, 0);
			}
			set
			{
				this.SetClose((uint)value.Hour, (uint)value.Minute);
			}
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x00116ED8 File Offset: 0x001150D8
		public TimeSpan GetWorkHours()
		{
			TimeSpan t = new TimeSpan(this.OpenHours, this.OpenMinutes, 0);
			return new TimeSpan(this.CloseHours, this.CloseMinutes, 0) - t;
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x00116F14 File Offset: 0x00115114
		public void SetOpen(uint h, uint m)
		{
			if (h > 23U || m > 59U)
			{
				throw new ArgumentException("Invalid time specified");
			}
			this.OpenHours = (int)h;
			this.OpenMinutes = (int)m;
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x00116F44 File Offset: 0x00115144
		public void SetClose(uint h, uint m)
		{
			if (h > 23U || m > 59U)
			{
				throw new ArgumentException("Invalid time specified");
			}
			this.CloseHours = (int)h;
			this.CloseMinutes = (int)m;
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x00116F74 File Offset: 0x00115174
		public void SetWork()
		{
			this.IsWorkday = true;
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x00116F88 File Offset: 0x00115188
		public void SetHoliDay()
		{
			this.IsWorkday = false;
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x00116F9C File Offset: 0x0011519C
		public void ConstructName()
		{
			switch (this.DayOfWeek)
			{
			case DayOfWeek.Sunday:
				this.Name = (string)Application.Current.TryFindResource("Sunday");
				this.ShortName = (string)Application.Current.TryFindResource("SundayShort");
				return;
			case DayOfWeek.Monday:
				this.Name = (string)Application.Current.TryFindResource("Monday");
				this.ShortName = (string)Application.Current.TryFindResource("MondayShort");
				return;
			case DayOfWeek.Tuesday:
				this.Name = (string)Application.Current.TryFindResource("Tuesday");
				this.ShortName = (string)Application.Current.TryFindResource("TuesdayShort");
				return;
			case DayOfWeek.Wednesday:
				this.Name = (string)Application.Current.TryFindResource("Wednesday");
				this.ShortName = (string)Application.Current.TryFindResource("WednesdayShort");
				return;
			case DayOfWeek.Thursday:
				this.Name = (string)Application.Current.TryFindResource("Thursday");
				this.ShortName = (string)Application.Current.TryFindResource("ThursdayShort");
				return;
			case DayOfWeek.Friday:
				this.Name = (string)Application.Current.TryFindResource("Friday");
				this.ShortName = (string)Application.Current.TryFindResource("FridayShort");
				return;
			case DayOfWeek.Saturday:
				this.Name = (string)Application.Current.TryFindResource("Saturday");
				this.ShortName = (string)Application.Current.TryFindResource("SaturdayShort");
				return;
			default:
				return;
			}
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x000046B4 File Offset: 0x000028B4
		public WorkDay()
		{
		}

		// Token: 0x04002DEA RID: 11754
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x04002DEB RID: 11755
		[CompilerGenerated]
		private string <ShortName>k__BackingField;

		// Token: 0x04002DEC RID: 11756
		[CompilerGenerated]
		private DayOfWeek <DayOfWeek>k__BackingField;

		// Token: 0x04002DED RID: 11757
		[CompilerGenerated]
		private bool <IsWorkday>k__BackingField;

		// Token: 0x04002DEE RID: 11758
		[CompilerGenerated]
		private int <OpenHours>k__BackingField;

		// Token: 0x04002DEF RID: 11759
		[CompilerGenerated]
		private int <OpenMinutes>k__BackingField;

		// Token: 0x04002DF0 RID: 11760
		[CompilerGenerated]
		private int <CloseHours>k__BackingField;

		// Token: 0x04002DF1 RID: 11761
		[CompilerGenerated]
		private int <CloseMinutes>k__BackingField;
	}
}
