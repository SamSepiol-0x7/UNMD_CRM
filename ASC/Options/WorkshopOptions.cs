using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Extensions;
using ASC.Interfaces;
using ASC.SimpleClasses;
using Newtonsoft.Json;

namespace ASC.Options
{
	// Token: 0x0200026B RID: 619
	public class WorkshopOptions : IOptions<WorkshopOptions>
	{
		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0005FF40 File Offset: 0x0005E140
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x0005FF54 File Offset: 0x0005E154
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0005FF68 File Offset: 0x0005E168
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x0005FF7C File Offset: 0x0005E17C
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

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x0005FF90 File Offset: 0x0005E190
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x0005FFA4 File Offset: 0x0005E1A4
		public List<int> Contains
		{
			[CompilerGenerated]
			get
			{
				return this.<Contains>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Contains>k__BackingField = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x0005FFCC File Offset: 0x0005E1CC
		public List<int> Actions
		{
			[CompilerGenerated]
			get
			{
				return this.<Actions>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Actions>k__BackingField = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0005FFE0 File Offset: 0x0005E1E0
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x0005FFF4 File Offset: 0x0005E1F4
		public List<int> Roles
		{
			[CompilerGenerated]
			get
			{
				return this.<Roles>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Roles>k__BackingField = value;
			}
		} = new List<int>();

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x00060008 File Offset: 0x0005E208
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0006001C File Offset: 0x0005E21C
		public string Color
		{
			[CompilerGenerated]
			get
			{
				return this.<Color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Color>k__BackingField = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00060030 File Offset: 0x0005E230
		[JsonIgnore]
		public bool AllowEditing
		{
			get
			{
				return this.Id > 30;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x00060048 File Offset: 0x0005E248
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0006005C File Offset: 0x0005E25C
		[JsonIgnore]
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<Enabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Enabled>k__BackingField = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00060070 File Offset: 0x0005E270
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x00060084 File Offset: 0x0005E284
		public TimeSpan Terms
		{
			[CompilerGenerated]
			get
			{
				return this.<Terms>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Terms>k__BackingField = value;
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00060098 File Offset: 0x0005E298
		public WorkshopOptions()
		{
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000600B8 File Offset: 0x0005E2B8
		public WorkshopOptions(int id)
		{
			this.Id = id;
			this.Name = WorkshopOptions.GetSystemStatusNameByid(id);
			this.Terms = this.TermsOption(id);
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x000600F8 File Offset: 0x0005E2F8
		public WorkshopOptions(int id, string name)
		{
			this.Id = id;
			this.Name = name;
			this.Contains = this.OptionsByOptionNew(id);
			this.Terms = this.TermsOption(id);
			this.Actions = this.ActionsById(id);
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0006014C File Offset: 0x0005E34C
		private WorkshopOptions(int id, string name, List<int> contains, List<int> actions)
		{
			this.Id = id;
			this.Name = name;
			this.Contains = contains;
			this.Terms = this.TermsOption(id);
			this.Actions = actions;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00060194 File Offset: 0x0005E394
		public List<WorkshopOptions> GetAllOptions()
		{
			if (WorkshopOptions._optionsConfig == null)
			{
				WorkshopOptions.RefreshConfig();
			}
			List<WorkshopOptions> list = new List<WorkshopOptions>();
			foreach (WorkshopOptions workshopOptions in WorkshopOptions._optionsConfig)
			{
				list.Add(new WorkshopOptions
				{
					Id = workshopOptions.Id,
					Name = ((workshopOptions.Id < 30) ? WorkshopOptions.GetSystemStatusNameByid(workshopOptions.Id) : workshopOptions.Name),
					Contains = workshopOptions.Contains,
					Actions = workshopOptions.Actions,
					Roles = (workshopOptions.Roles ?? new List<int>()),
					Terms = workshopOptions.Terms,
					Color = (workshopOptions.Color ?? "#00000000")
				});
			}
			return list;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00060284 File Offset: 0x0005E484
		public bool TermsExpired(DateTime startDate, DateTime now)
		{
			return !(this.Terms == TimeSpan.Zero) && now > startDate.AddMinutes(this.Terms.TotalMinutes);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000602C0 File Offset: 0x0005E4C0
		public static List<WorkshopOptions> GetCartridgeStatuses()
		{
			return new List<WorkshopOptions>
			{
				new WorkshopOptions(0)
				{
					Enabled = true
				},
				new WorkshopOptions(4)
				{
					Enabled = true
				},
				new WorkshopOptions(6)
				{
					Enabled = true
				},
				new WorkshopOptions(7)
				{
					Enabled = true
				},
				new WorkshopOptions(8),
				new WorkshopOptions(12)
			};
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00060338 File Offset: 0x0005E538
		private static string GetSystemStatusNameByid(int statusId)
		{
			if (statusId == 0)
			{
				goto IL_BF;
			}
			goto IL_2A7;
			int num;
			for (;;)
			{
				IL_1FC:
				switch ((num ^ -881177575) % 35)
				{
				case 0:
					goto IL_2B0;
				case 1:
					num = ((statusId != 6) ? -1500849782 : -817903888);
					continue;
				case 2:
					goto IL_2BB;
				case 3:
					goto IL_2C6;
				case 4:
					num = ((statusId == 5) ? -533796796 : -1427611372);
					continue;
				case 5:
					num = ((statusId != 2) ? -548926466 : -598147383);
					continue;
				case 6:
					goto IL_2D1;
				case 7:
					goto IL_2DC;
				case 8:
					num = ((statusId != 13) ? -1460791297 : -838175635);
					continue;
				case 9:
					goto IL_2E7;
				case 10:
					goto IL_2F2;
				case 11:
					goto IL_2FD;
				case 12:
					num = ((statusId != 3) ? -1139369933 : -1509760431);
					continue;
				case 13:
					goto IL_308;
				case 15:
					goto IL_2A7;
				case 16:
					goto IL_319;
				case 17:
					goto IL_324;
				case 18:
					goto IL_32F;
				case 19:
					num = ((statusId == 8) ? -826426416 : -1624368810);
					continue;
				case 20:
					num = ((statusId != 15) ? -1933047642 : -1089008519);
					continue;
				case 21:
					num = ((statusId != 4) ? -1411382688 : -433892368);
					continue;
				case 22:
					num = ((statusId != 16) ? -906756418 : -780935329);
					continue;
				case 23:
					num = ((statusId != 14) ? -541054543 : -646796712);
					continue;
				case 24:
					goto IL_33A;
				case 25:
					goto IL_345;
				case 26:
					goto IL_BF;
				case 27:
					num = ((statusId != 9) ? -223536313 : -410190142);
					continue;
				case 28:
					goto IL_350;
				case 29:
					goto IL_35B;
				case 30:
					num = ((statusId != 7) ? -90525245 : -83185834);
					continue;
				case 31:
					num = ((statusId == 12) ? -544648825 : -1253478010);
					continue;
				case 32:
					goto IL_366;
				case 33:
					num = ((statusId == 10) ? -519945492 : -1157516467);
					continue;
				case 34:
					num = ((statusId != 11) ? -564382827 : -38353610);
					continue;
				}
				break;
			}
			goto IL_313;
			IL_2B0:
			return Lang.t("DiagnosticComplete");
			IL_2BB:
			return Lang.t("IsInDebt");
			IL_2C6:
			return Lang.t("WaitingClientDecision");
			IL_2D1:
			return Lang.t("Ready2IssueWithoutRepair");
			IL_2DC:
			return Lang.t("ClientRefused2Repair");
			IL_2E7:
			return Lang.t("AcceptWaiting");
			IL_2F2:
			return Lang.t("Issued2CustomerWithoutRepair");
			IL_2FD:
			return Lang.t("DiagAccepted");
			IL_308:
			return Lang.t("PerformanceOfWorks");
			IL_313:
			return "";
			IL_319:
			return Lang.t("ChangeOfOffice");
			IL_324:
			return Lang.t("Issued2Client");
			IL_32F:
			return Lang.t("ReceptionRepair");
			IL_33A:
			return Lang.t("Ready2Issue");
			IL_345:
			return Lang.t("AgreedWithClient");
			IL_350:
			return Lang.t("DiagnosticsCarrying");
			IL_35B:
			return Lang.t("Waiting4Parts");
			IL_366:
			return Lang.t("FaultDidNotAppear");
			IL_BF:
			num = -1226886334;
			goto IL_1FC;
			IL_2A7:
			num = ((statusId != 1) ? -2107180095 : -1777112929);
			goto IL_1FC;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x000606B8 File Offset: 0x0005E8B8
		public static void RefreshConfig()
		{
			if (Auth.Config.statuses != null)
			{
				WorkshopOptions._optionsConfig = JsonConvert.DeserializeObject<List<WorkshopOptions>>(Auth.Config.statuses);
			}
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000606E8 File Offset: 0x0005E8E8
		public List<WorkshopOptions> GetAllOptionsWithDummy()
		{
			List<WorkshopOptions> allOptions = this.GetAllOptions();
			allOptions.Insert(0, new WorkshopOptions(99, Lang.t("AllStatuses")));
			return allOptions;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00060714 File Offset: 0x0005E914
		public WorkshopOptions GetOption(int id)
		{
			return this.GetAllOptions().FirstOrDefault((WorkshopOptions o) => o.Id == id);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00060748 File Offset: 0x0005E948
		public List<WorkshopOptions> OptionsByOption(int optionId)
		{
			List<WorkshopOptions> allOptions = this.GetAllOptions();
			WorkshopOptions workshopOptions = allOptions.FirstOrDefault((WorkshopOptions o) => o.Id == optionId);
			List<int> xx = (from o in allOptions
			where o.Id == optionId
			select o.Contains).FirstOrDefault<List<int>>();
			if (xx != null)
			{
				List<WorkshopOptions> list = (from o in allOptions
				where xx.Contains(o.Id)
				select o).ToList<WorkshopOptions>();
				if (workshopOptions != null)
				{
					list.Add(workshopOptions);
				}
				return list;
			}
			return new List<WorkshopOptions>();
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000607F0 File Offset: 0x0005E9F0
		private List<int> OptionsByOptionNew(int optionId)
		{
			WorkshopOptions.LoadStateObject();
			return (from o in WorkshopOptions._optionsConfig
			where o.Id == optionId
			select o.Contains).FirstOrDefault<List<int>>();
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00060850 File Offset: 0x0005EA50
		private List<int> ActionsById(int optionId)
		{
			WorkshopOptions.LoadStateObject();
			return (from o in WorkshopOptions._optionsConfig
			where o.Id == optionId
			select o.Actions).FirstOrDefault<List<int>>();
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000608B0 File Offset: 0x0005EAB0
		private TimeSpan TermsOption(int optionId)
		{
			WorkshopOptions.LoadStateObject();
			return (from o in WorkshopOptions._optionsConfig
			where o.Id == optionId
			select o.Terms).FirstOrDefault<TimeSpan>();
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00060910 File Offset: 0x0005EB10
		public static double GetTotalRepairDays()
		{
			WorkshopOptions.LoadStateObject();
			TimeSpan t = default(TimeSpan);
			using (List<WorkshopOptions>.Enumerator enumerator = WorkshopOptions._optionsConfig.GetEnumerator())
			{
				for (;;)
				{
					IL_74:
					int num = enumerator.MoveNext() ? -576470995 : -122179857;
					for (;;)
					{
						switch ((num ^ -88013032) % 4)
						{
						case 0:
							goto IL_74;
						case 1:
						{
							WorkshopOptions workshopOptions = enumerator.Current;
							t += workshopOptions.Terms;
							num = -951442340;
							continue;
						}
						case 2:
							num = -576470995;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
			if (t.TotalDays != 0.0)
			{
				return t.TotalDays;
			}
			return 1.0;
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x000609E0 File Offset: 0x0005EBE0
		private static void LoadStateObject()
		{
			if (WorkshopOptions._optionsConfig == null)
			{
				WorkshopOptions.RefreshConfig();
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x000609FC File Offset: 0x0005EBFC
		public static double GetTermsByState(int state)
		{
			WorkshopOptions.LoadStateObject();
			TimeSpan timeSpan = (from o in WorkshopOptions._optionsConfig
			where o.Id == state
			select o.Terms).FirstOrDefault<TimeSpan>();
			if (timeSpan.TotalDays <= 0.0)
			{
				return 1.0;
			}
			return timeSpan.TotalDays;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00060A80 File Offset: 0x0005EC80
		public List<StatusActions> GetActions()
		{
			List<StatusActions> list = new List<StatusActions>();
			list.Add(new StatusActions(0, 1, Lang.t("AddWorksAndParts"), null));
			list.Add(new StatusActions(0, 2, Lang.t("ClientInformReset"), null));
			list.Add(new StatusActions(0, 3, Lang.t("RepairDiagEdit"), null));
			list.Add(new StatusActions(0, 4, Lang.t("ManagerInformStatus"), null));
			list.Add(new StatusActions(0, 5, Lang.t("MasterInformStatus"), null));
			list.Add(new StatusActions(0, 6, Lang.t("TermsNotification"), null));
			list.AddRange(this.GetSmsActions());
			return list;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00060B30 File Offset: 0x0005ED30
		private bool ActionInStatus(int statusId, int actionId)
		{
			WorkshopOptions option = this.GetOption(statusId);
			return option.Actions != null && option.Actions.Contains(actionId);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00060B5C File Offset: 0x0005ED5C
		public bool NeedInformStatusReset(int statusId)
		{
			return this.ActionInStatus(statusId, 2);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00060B74 File Offset: 0x0005ED74
		public List<int> TermNotificationStatuses()
		{
			return (from s in this.GetAllOptions()
			where s.Actions != null && s.Actions.Contains(6)
			select s.Id).ToList<int>();
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00060BD4 File Offset: 0x0005EDD4
		public bool InformManager(int statusId)
		{
			return this.ActionInStatus(statusId, 4);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00060BEC File Offset: 0x0005EDEC
		public bool InformMaster(int statusId)
		{
			return this.ActionInStatus(statusId, 5);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00060C04 File Offset: 0x0005EE04
		private IEnumerable<StatusActions> GetSmsActions()
		{
			List<StatusActions> list = new List<StatusActions>();
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				List<sms_templates> list2 = auseceEntities.sms_templates.AsNoTracking().ToListSafe<sms_templates>();
				if (list2.Count > 0)
				{
					foreach (sms_templates sms_templates in list2)
					{
						list.Add(new StatusActions(1, 100 + sms_templates.id, Lang.t("SmsSend") + " " + sms_templates.name, "#FF3c3c3c"));
					}
				}
			}
			return list;
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00060CC4 File Offset: 0x0005EEC4
		public bool CanWorksAndParts(int statusId)
		{
			return this.ActionInStatus(statusId, 1);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00060CDC File Offset: 0x0005EEDC
		public bool CanDiagnosticEdit(int statusId)
		{
			return this.ActionInStatus(statusId, 3);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00060CF4 File Offset: 0x0005EEF4
		public int GetSmsTemplateId(int statusId)
		{
			WorkshopOptions option = this.GetOption(statusId);
			if (option.Actions == null)
			{
				return 0;
			}
			int num = option.Actions.FirstOrDefault((int i) => i >= 100);
			if (num != 0)
			{
				return num - 100;
			}
			return 0;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00060D48 File Offset: 0x0005EF48
		public List<WorkshopOptions> GetDefaults()
		{
			return new List<WorkshopOptions>
			{
				new WorkshopOptions(0, "", new List<int>
				{
					1,
					10,
					11
				}, null),
				new WorkshopOptions(1, "", new List<int>
				{
					15
				}, null),
				new WorkshopOptions(2, "", new List<int>
				{
					3,
					7
				}, null),
				new WorkshopOptions(3, "", new List<int>
				{
					4
				}, null),
				new WorkshopOptions(4, "", new List<int>
				{
					5,
					6,
					7
				}, new List<int>
				{
					1
				}),
				new WorkshopOptions(5, "", new List<int>
				{
					4
				}, null),
				new WorkshopOptions(6, "", new List<int>
				{
					8
				}, null),
				new WorkshopOptions(7, "", new List<int>
				{
					12,
					1
				}, null),
				new WorkshopOptions(8, "", new List<int>(), null),
				new WorkshopOptions(9, "", new List<int>
				{
					7
				}, null),
				new WorkshopOptions(10, "", new List<int>
				{
					1
				}, null),
				new WorkshopOptions(11, "", new List<int>
				{
					7
				}, null),
				new WorkshopOptions(12, "", new List<int>(), null),
				new WorkshopOptions(13, "", new List<int>
				{
					14
				}, null),
				new WorkshopOptions(14, "", new List<int>
				{
					4
				}, null),
				new WorkshopOptions(15, "", new List<int>
				{
					13
				}, null),
				new WorkshopOptions(16, "", new List<int>(), null)
			};
		}

		// Token: 0x040010F9 RID: 4345
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x040010FA RID: 4346
		[CompilerGenerated]
		private string <Name>k__BackingField;

		// Token: 0x040010FB RID: 4347
		[CompilerGenerated]
		private List<int> <Contains>k__BackingField;

		// Token: 0x040010FC RID: 4348
		[CompilerGenerated]
		private List<int> <Actions>k__BackingField;

		// Token: 0x040010FD RID: 4349
		[CompilerGenerated]
		private List<int> <Roles>k__BackingField;

		// Token: 0x040010FE RID: 4350
		[CompilerGenerated]
		private string <Color>k__BackingField;

		// Token: 0x040010FF RID: 4351
		[CompilerGenerated]
		private bool <Enabled>k__BackingField;

		// Token: 0x04001100 RID: 4352
		[CompilerGenerated]
		private TimeSpan <Terms>k__BackingField;

		// Token: 0x04001101 RID: 4353
		[JsonIgnore]
		private static List<WorkshopOptions> _optionsConfig;

		// Token: 0x04001102 RID: 4354
		[JsonIgnore]
		public const int LastSystemStatusId = 30;

		// Token: 0x0200026C RID: 620
		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x0600215A RID: 8538 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x0600215B RID: 8539 RVA: 0x00060F88 File Offset: 0x0005F188
			internal bool <GetOption>b__0(WorkshopOptions o)
			{
				return o.Id == this.id;
			}

			// Token: 0x04001103 RID: 4355
			public int id;
		}

		// Token: 0x0200026D RID: 621
		[CompilerGenerated]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x0600215C RID: 8540 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass47_0()
			{
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x00060FA4 File Offset: 0x0005F1A4
			internal bool <OptionsByOption>b__0(WorkshopOptions o)
			{
				return o.Id == this.optionId;
			}

			// Token: 0x0600215E RID: 8542 RVA: 0x00060FA4 File Offset: 0x0005F1A4
			internal bool <OptionsByOption>b__1(WorkshopOptions o)
			{
				return o.Id == this.optionId;
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x00060FC0 File Offset: 0x0005F1C0
			internal bool <OptionsByOption>b__3(WorkshopOptions o)
			{
				return this.xx.Contains(o.Id);
			}

			// Token: 0x04001104 RID: 4356
			public int optionId;

			// Token: 0x04001105 RID: 4357
			public List<int> xx;
		}

		// Token: 0x0200026E RID: 622
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002160 RID: 8544 RVA: 0x00060FE0 File Offset: 0x0005F1E0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002161 RID: 8545 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002162 RID: 8546 RVA: 0x00060FF8 File Offset: 0x0005F1F8
			internal List<int> <OptionsByOption>b__47_2(WorkshopOptions o)
			{
				return o.Contains;
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x00060FF8 File Offset: 0x0005F1F8
			internal List<int> <OptionsByOptionNew>b__48_1(WorkshopOptions o)
			{
				return o.Contains;
			}

			// Token: 0x06002164 RID: 8548 RVA: 0x0006100C File Offset: 0x0005F20C
			internal List<int> <ActionsById>b__49_1(WorkshopOptions o)
			{
				return o.Actions;
			}

			// Token: 0x06002165 RID: 8549 RVA: 0x00061020 File Offset: 0x0005F220
			internal TimeSpan <TermsOption>b__50_1(WorkshopOptions o)
			{
				return o.Terms;
			}

			// Token: 0x06002166 RID: 8550 RVA: 0x00061020 File Offset: 0x0005F220
			internal TimeSpan <GetTermsByState>b__53_1(WorkshopOptions o)
			{
				return o.Terms;
			}

			// Token: 0x06002167 RID: 8551 RVA: 0x00061034 File Offset: 0x0005F234
			internal bool <TermNotificationStatuses>b__57_0(WorkshopOptions s)
			{
				return s.Actions != null && s.Actions.Contains(6);
			}

			// Token: 0x06002168 RID: 8552 RVA: 0x00061058 File Offset: 0x0005F258
			internal int <TermNotificationStatuses>b__57_1(WorkshopOptions s)
			{
				return s.Id;
			}

			// Token: 0x06002169 RID: 8553 RVA: 0x0006106C File Offset: 0x0005F26C
			internal bool <GetSmsTemplateId>b__63_0(int i)
			{
				return i >= 100;
			}

			// Token: 0x04001106 RID: 4358
			public static readonly WorkshopOptions.<>c <>9 = new WorkshopOptions.<>c();

			// Token: 0x04001107 RID: 4359
			public static Func<WorkshopOptions, List<int>> <>9__47_2;

			// Token: 0x04001108 RID: 4360
			public static Func<WorkshopOptions, List<int>> <>9__48_1;

			// Token: 0x04001109 RID: 4361
			public static Func<WorkshopOptions, List<int>> <>9__49_1;

			// Token: 0x0400110A RID: 4362
			public static Func<WorkshopOptions, TimeSpan> <>9__50_1;

			// Token: 0x0400110B RID: 4363
			public static Func<WorkshopOptions, TimeSpan> <>9__53_1;

			// Token: 0x0400110C RID: 4364
			public static Func<WorkshopOptions, bool> <>9__57_0;

			// Token: 0x0400110D RID: 4365
			public static Func<WorkshopOptions, int> <>9__57_1;

			// Token: 0x0400110E RID: 4366
			public static Func<int, bool> <>9__63_0;
		}

		// Token: 0x0200026F RID: 623
		[CompilerGenerated]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x0600216A RID: 8554 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x0600216B RID: 8555 RVA: 0x00061084 File Offset: 0x0005F284
			internal bool <OptionsByOptionNew>b__0(WorkshopOptions o)
			{
				return o.Id == this.optionId;
			}

			// Token: 0x0400110F RID: 4367
			public int optionId;
		}

		// Token: 0x02000270 RID: 624
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x0600216C RID: 8556 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x0600216D RID: 8557 RVA: 0x000610A0 File Offset: 0x0005F2A0
			internal bool <ActionsById>b__0(WorkshopOptions o)
			{
				return o.Id == this.optionId;
			}

			// Token: 0x04001110 RID: 4368
			public int optionId;
		}

		// Token: 0x02000271 RID: 625
		[CompilerGenerated]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x0600216E RID: 8558 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0600216F RID: 8559 RVA: 0x000610BC File Offset: 0x0005F2BC
			internal bool <TermsOption>b__0(WorkshopOptions o)
			{
				return o.Id == this.optionId;
			}

			// Token: 0x04001111 RID: 4369
			public int optionId;
		}

		// Token: 0x02000272 RID: 626
		[CompilerGenerated]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06002170 RID: 8560 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x06002171 RID: 8561 RVA: 0x000610D8 File Offset: 0x0005F2D8
			internal bool <GetTermsByState>b__0(WorkshopOptions o)
			{
				return o.Id == this.state;
			}

			// Token: 0x04001112 RID: 4370
			public int state;
		}
	}
}
