using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using DevExpress.Mvvm;
using Newtonsoft.Json;

namespace ASC.Objects
{
	// Token: 0x020008F7 RID: 2295
	[JsonObject(MemberSerialization.OptIn)]
	public class TimeOfWork : BindableBase, ITimeOfWork
	{
		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x001163E0 File Offset: 0x001145E0
		// (set) Token: 0x06004782 RID: 18306 RVA: 0x001163F4 File Offset: 0x001145F4
		[JsonProperty]
		public List<IWorkDay> WeekDays
		{
			[CompilerGenerated]
			get
			{
				return this.<WeekDays>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<WeekDays>k__BackingField, value))
				{
					return;
				}
				this.<WeekDays>k__BackingField = value;
				this.RaisePropertyChanged("WeekDays");
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x00116424 File Offset: 0x00114624
		// (set) Token: 0x06004784 RID: 18308 RVA: 0x00116438 File Offset: 0x00114638
		[JsonProperty]
		public ObservableCollection<IHoliday> Holidays
		{
			[CompilerGenerated]
			get
			{
				return this.<Holidays>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Holidays>k__BackingField, value))
				{
					return;
				}
				this.<Holidays>k__BackingField = value;
				this.RaisePropertyChanged("Holidays");
			}
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x000069B8 File Offset: 0x00004BB8
		[JsonConstructor]
		public TimeOfWork(int dummy)
		{
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x00116468 File Offset: 0x00114668
		public TimeOfWork()
		{
			if (Auth.Config.TimeOfWork == null)
			{
				this.SetDefaultWeekDays();
				return;
			}
			this.LoadConfig();
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00116494 File Offset: 0x00114694
		private void SetDefaultWeekDays()
		{
			List<IWorkDay> list = new List<IWorkDay>();
			foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)).OfType<DayOfWeek>().ToList<DayOfWeek>())
			{
				WorkDay workDay = new WorkDay
				{
					DayOfWeek = dayOfWeek
				};
				if (workDay.DayOfWeek != DayOfWeek.Saturday && workDay.DayOfWeek != DayOfWeek.Sunday)
				{
					workDay.SetWork();
				}
				workDay.SetOpen(10U, 0U);
				workDay.SetClose(19U, 0U);
				workDay.ConstructName();
				list.Add(workDay);
			}
			this.WeekDays = list;
			this.Holidays = new ObservableCollection<IHoliday>();
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00116550 File Offset: 0x00114750
		public bool IsWorkDay(DateTime date)
		{
			IWorkDay workDay = this.WeekDays.FirstOrDefault((IWorkDay d) => d.DayOfWeek == date.DayOfWeek);
			return workDay.IsWorkday && date.Hour >= workDay.OpenHours && date.Hour <= workDay.CloseHours && date.Minute >= workDay.OpenMinutes && date.Minute <= workDay.CloseMinutes;
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x001165E0 File Offset: 0x001147E0
		public bool IsHoliday(DateTime date)
		{
			return !this.IsWorkDay(date);
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x001165F8 File Offset: 0x001147F8
		public void AddHoliday(IHoliday holiday)
		{
			this.Holidays.Add(holiday);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x0007E558 File Offset: 0x0007C758
		public void RemoveHoliday(IHoliday holiday)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00116614 File Offset: 0x00114814
		public bool SaveConfig()
		{
			try
			{
				string timeOfWork = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
				{
					TypeNameHandling = TypeNameHandling.Auto,
					TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
				});
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					config config = auseceEntities.config.Find(new object[]
					{
						1
					});
					if (config == null)
					{
						return false;
					}
					config.TimeOfWork = timeOfWork;
					auseceEntities.SaveChanges();
					Auth.Config.TimeOfWork = timeOfWork;
				}
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x001166B0 File Offset: 0x001148B0
		public void LoadConfig()
		{
			try
			{
				TimeOfWork timeOfWork = JsonConvert.DeserializeObject<TimeOfWork>(Auth.Config.TimeOfWork, new JsonSerializerSettings
				{
					TypeNameHandling = TypeNameHandling.Auto
				});
				List<IWorkDay> weekDays = timeOfWork.WeekDays;
				foreach (IWorkDay workDay in weekDays)
				{
					workDay.ConstructName();
				}
				this.WeekDays = weekDays;
				this.Holidays = (timeOfWork.Holidays ?? new ObservableCollection<IHoliday>());
			}
			catch (Exception)
			{
				this.SetDefaultWeekDays();
			}
		}

		// Token: 0x04002DD3 RID: 11731
		[CompilerGenerated]
		private List<IWorkDay> <WeekDays>k__BackingField;

		// Token: 0x04002DD4 RID: 11732
		[CompilerGenerated]
		private ObservableCollection<IHoliday> <Holidays>k__BackingField;

		// Token: 0x020008F8 RID: 2296
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600478E RID: 18318 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0600478F RID: 18319 RVA: 0x00116754 File Offset: 0x00114954
			internal bool <IsWorkDay>b__0(IWorkDay d)
			{
				return d.DayOfWeek == this.date.DayOfWeek;
			}

			// Token: 0x04002DD5 RID: 11733
			public DateTime date;
		}
	}
}
