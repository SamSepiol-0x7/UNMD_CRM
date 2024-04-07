using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ASC.Common.Interfaces;
using ASC.Extensions;

namespace ASC.Objects
{
	// Token: 0x02000878 RID: 2168
	public class AscNotification : IAscNotification
	{
		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060040E7 RID: 16615 RVA: 0x001013F0 File Offset: 0x000FF5F0
		// (set) Token: 0x060040E8 RID: 16616 RVA: 0x00101404 File Offset: 0x000FF604
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

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x00101418 File Offset: 0x000FF618
		// (set) Token: 0x060040EA RID: 16618 RVA: 0x0010142C File Offset: 0x000FF62C
		public DateTime Created
		{
			[CompilerGenerated]
			get
			{
				return this.<Created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Created>k__BackingField = value;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060040EB RID: 16619 RVA: 0x00101440 File Offset: 0x000FF640
		// (set) Token: 0x060040EC RID: 16620 RVA: 0x00101454 File Offset: 0x000FF654
		public int Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x00101468 File Offset: 0x000FF668
		// (set) Token: 0x060040EE RID: 16622 RVA: 0x0010147C File Offset: 0x000FF67C
		public int EmployeeId
		{
			[CompilerGenerated]
			get
			{
				return this.<EmployeeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<EmployeeId>k__BackingField = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x00101490 File Offset: 0x000FF690
		// (set) Token: 0x060040F0 RID: 16624 RVA: 0x001014A4 File Offset: 0x000FF6A4
		public int? CustomerId
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<CustomerId>k__BackingField = value;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x001014B8 File Offset: 0x000FF6B8
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x001014CC File Offset: 0x000FF6CC
		public int? TaskId
		{
			[CompilerGenerated]
			get
			{
				return this.<TaskId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TaskId>k__BackingField = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x001014E0 File Offset: 0x000FF6E0
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x001014F4 File Offset: 0x000FF6F4
		public int? RepairId
		{
			[CompilerGenerated]
			get
			{
				return this.<RepairId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RepairId>k__BackingField = value;
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x00101508 File Offset: 0x000FF708
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x0010151C File Offset: 0x000FF71C
		public int? SmsId
		{
			[CompilerGenerated]
			get
			{
				return this.<SmsId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SmsId>k__BackingField = value;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x00101530 File Offset: 0x000FF730
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x00101544 File Offset: 0x000FF744
		public int? RequestId
		{
			[CompilerGenerated]
			get
			{
				return this.<RequestId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<RequestId>k__BackingField = value;
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x00101558 File Offset: 0x000FF758
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x0010156C File Offset: 0x000FF76C
		public int? BuyPartRequestId
		{
			[CompilerGenerated]
			get
			{
				return this.<BuyPartRequestId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<BuyPartRequestId>k__BackingField = value;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x00101580 File Offset: 0x000FF780
		// (set) Token: 0x060040FC RID: 16636 RVA: 0x00101594 File Offset: 0x000FF794
		public string Subject
		{
			[CompilerGenerated]
			get
			{
				return this.<Subject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Subject>k__BackingField = value;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x001015A8 File Offset: 0x000FF7A8
		// (set) Token: 0x060040FE RID: 16638 RVA: 0x001015BC File Offset: 0x000FF7BC
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x001015D0 File Offset: 0x000FF7D0
		// (set) Token: 0x06004100 RID: 16640 RVA: 0x001015E4 File Offset: 0x000FF7E4
		public string Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Tel>k__BackingField = value;
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x001015F8 File Offset: 0x000FF7F8
		// (set) Token: 0x06004102 RID: 16642 RVA: 0x0010160C File Offset: 0x000FF80C
		public bool Readed
		{
			[CompilerGenerated]
			get
			{
				return this.<Readed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Readed>k__BackingField = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06004103 RID: 16643 RVA: 0x00101620 File Offset: 0x000FF820
		// (set) Token: 0x06004104 RID: 16644 RVA: 0x00101634 File Offset: 0x000FF834
		public Brush Color
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

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06004105 RID: 16645 RVA: 0x00101648 File Offset: 0x000FF848
		public string SubjectWithDate
		{
			get
			{
				return string.Format("{0} [{1:dd.MM.yyyy HH:mm}]", this.Subject, this.Created);
			}
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00101670 File Offset: 0x000FF870
		public void SetColor()
		{
			int type = this.Type;
			for (;;)
			{
				switch (type)
				{
				case 1:
					goto IL_B5;
				case 2:
					goto IL_CB;
				case 3:
					goto IL_E1;
				case 4:
					goto IL_F7;
				case 5:
					goto IL_10D;
				case 6:
					goto IL_123;
				case 7:
					goto IL_139;
				case 8:
					goto IL_14F;
				case 9:
					goto IL_165;
				case 10:
					goto IL_17B;
				default:
				{
					uint num;
					switch ((num = (num * 4246331178U ^ 371280384U ^ 180780137U)) % 21U)
					{
					case 0U:
						goto IL_14F;
					case 1U:
						return;
					case 2U:
						goto IL_17B;
					case 3U:
						goto IL_10D;
					case 4U:
					case 5U:
						continue;
					case 6U:
						goto IL_F7;
					case 8U:
						return;
					case 9U:
						goto IL_123;
					case 10U:
						return;
					case 11U:
						return;
					case 12U:
						return;
					case 13U:
						goto IL_165;
					case 14U:
						goto IL_139;
					case 15U:
						return;
					case 16U:
						return;
					case 17U:
						goto IL_CB;
					case 18U:
						goto IL_E1;
					case 19U:
						return;
					case 20U:
						goto IL_B5;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			return;
			IL_B5:
			this.SetColor(OfflineData.Instance.Settings.InformCommentColor);
			return;
			IL_CB:
			this.SetColor(OfflineData.Instance.Settings.InformStatusColor);
			return;
			IL_E1:
			this.SetColor(OfflineData.Instance.Settings.InformSmsColor);
			return;
			IL_F7:
			this.SetColor(OfflineData.Instance.Settings.InformTermsColor);
			return;
			IL_10D:
			this.SetColor(OfflineData.Instance.Settings.InformTaskCustomColor);
			return;
			IL_123:
			this.SetColor(OfflineData.Instance.Settings.InformTaskMatchColor);
			return;
			IL_139:
			this.SetColor(OfflineData.Instance.Settings.InformTaskRequestColor);
			return;
			IL_14F:
			this.SetColor(OfflineData.Instance.Settings.InformIntRequestColor);
			return;
			IL_165:
			this.SetColor(OfflineData.Instance.Settings.InformPartRequestColor);
			return;
			IL_17B:
			this.SetColor(OfflineData.Instance.Settings.InformCallColor);
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00101810 File Offset: 0x000FFA10
		private void SetColor(string color)
		{
			if (!string.IsNullOrEmpty(color))
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1456721055;
			IL_0D:
			switch ((num ^ 725044314) % 4)
			{
			case 0:
			{
				IL_2C:
				BrushConverter brushConverter = new BrushConverter();
				this.Color = (Brush)brushConverter.ConvertFromString(color);
				num = 902584785;
				goto IL_0D;
			}
			case 1:
				this.Color = Brushes.CadetBlue;
				return;
			case 2:
				goto IL_08;
			}
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00101874 File Offset: 0x000FFA74
		public void CommentNotification(int repairId, string device, string comment)
		{
			this.SetRepair(repairId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.Comment);
			this.SetSubject("NewComment");
			this.SetText(string.Format(Lang.t("RepairNewComment"), repairId, device, comment.Truncate(60, "...")));
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x001018D0 File Offset: 0x000FFAD0
		public void RepairStatusNotification(int repairId, string device, string statusName)
		{
			this.SetRepair(repairId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.StatusChange);
			this.SetSubject("OrderStatusChanged");
			this.SetText(string.Format(Lang.t("RepairStatusNotificationText"), repairId, device, statusName));
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00101920 File Offset: 0x000FFB20
		public void RepairTermsNotification(int repairId, string status)
		{
			this.SetRepair(repairId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.Terms);
			this.SetSubject("StatusTermsTitle");
			this.SetText(string.Format(Lang.t("StatusTermsText"), status, repairId.ToString("d6")));
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00101974 File Offset: 0x000FFB74
		public void SmsNotification(int smsId, string tel, string message, DateTime date)
		{
			this.SetSms(smsId);
			this.Created = date;
			this.SetType(AscNotificationType.Sms);
			this.SetSubject("SmsFrom", tel);
			this.SetText(message);
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x001019AC File Offset: 0x000FFBAC
		public void TaskDeviceMatch(int taskId, string taskText)
		{
			this.SetTask(taskId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.TaskDeviceMatch);
			this.SetSubject("DeviceMatch");
			this.SetText(taskText);
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x001019E4 File Offset: 0x000FFBE4
		public void TaskCustom(int taskId, string subject, string taskText)
		{
			this.SetTask(taskId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.TaskCustom);
			this.SetSubject("TaskSubject", subject);
			this.SetText(taskText);
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00101A20 File Offset: 0x000FFC20
		public void IntReserveRequest(int requestId, string requestText)
		{
			this.SetRequest(requestId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.IntReserveRequest);
			this.SetSubject("RequestItem2");
			this.SetText(requestText);
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00101A58 File Offset: 0x000FFC58
		public void BuyRequest(int requestId, string requestText)
		{
			this.SetBuyRequest(requestId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.BuyPartRequest);
			this.SetSubject("BuyItemRequest");
			this.SetText(requestText);
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00101A94 File Offset: 0x000FFC94
		public void InCall(string tel, string customer, int? customerId)
		{
			this.Tel = tel;
			this.CustomerId = customerId;
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.Call);
			this.SetSubject("InCallFrom", tel);
			if (!string.IsNullOrEmpty(customer))
			{
				this.SetText(customer);
				return;
			}
			this.SetText(Lang.t("NewClient"));
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00101AF0 File Offset: 0x000FFCF0
		public void TaskSiteRequest(int taskId, string text, TaskType type)
		{
			this.SetTask(taskId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.TaskSiteRequest);
			if (type == TaskType.SiteServicesRequest)
			{
				this.SetSubject("RemoteServicesRequest");
			}
			if (type == TaskType.SitePartsRequest)
			{
				this.SetSubject("SitePartRequest");
			}
			if (type == TaskType.Callback)
			{
				this.SetSubject("Callback");
			}
			this.SetText(text);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00101B50 File Offset: 0x000FFD50
		public void NewCustomer(int customerId, string text)
		{
			this.SetCustomer(customerId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.NewCustomer);
			this.SetSubject("NewClient");
			this.SetText(text);
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00101B8C File Offset: 0x000FFD8C
		public void CallbackToCustomer(int customerId, string text)
		{
			this.SetCustomer(customerId);
			this.Created = DateTime.UtcNow;
			this.SetType(AscNotificationType.Callback);
			this.SetSubject("Callback");
			this.SetText(text);
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00101BC8 File Offset: 0x000FFDC8
		public void SetText(string text)
		{
			this.Text = text.Truncate(250, "...");
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00101BEC File Offset: 0x000FFDEC
		private void SetSubject(string resourceName)
		{
			this.Subject = (Lang.t(resourceName) ?? "");
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00101C10 File Offset: 0x000FFE10
		private void SetSubject(string resourceName, string prm1)
		{
			this.Subject = (string.Format(Lang.t(resourceName), prm1) ?? "");
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00101C38 File Offset: 0x000FFE38
		public void SetEmployee(int employeeId)
		{
			this.EmployeeId = employeeId;
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00101C4C File Offset: 0x000FFE4C
		public void SetRequest(int requestId)
		{
			this.RequestId = new int?(requestId);
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00101C68 File Offset: 0x000FFE68
		public void SetBuyRequest(int requestId)
		{
			this.BuyPartRequestId = new int?(requestId);
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00101C84 File Offset: 0x000FFE84
		public void SetTask(int taskId)
		{
			this.TaskId = new int?(taskId);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x00101CA0 File Offset: 0x000FFEA0
		public void SetRepair(int repairId)
		{
			this.RepairId = new int?(repairId);
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00101CBC File Offset: 0x000FFEBC
		public void SetSms(int smsId)
		{
			this.SmsId = new int?(smsId);
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00101CD8 File Offset: 0x000FFED8
		public void SetType(AscNotificationType type)
		{
			this.Type = (int)type;
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00101CEC File Offset: 0x000FFEEC
		public void SetCustomer(int customerId)
		{
			this.CustomerId = new int?(customerId);
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00101D08 File Offset: 0x000FFF08
		public bool MarkAsRead()
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.notifications.Find(new object[]
					{
						this.Id
					}).status = true;
					auseceEntities.SaveChanges();
				}
				return true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x000046B4 File Offset: 0x000028B4
		public AscNotification()
		{
		}

		// Token: 0x04002A59 RID: 10841
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A5A RID: 10842
		[CompilerGenerated]
		private DateTime <Created>k__BackingField;

		// Token: 0x04002A5B RID: 10843
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002A5C RID: 10844
		[CompilerGenerated]
		private int <EmployeeId>k__BackingField;

		// Token: 0x04002A5D RID: 10845
		[CompilerGenerated]
		private int? <CustomerId>k__BackingField;

		// Token: 0x04002A5E RID: 10846
		[CompilerGenerated]
		private int? <TaskId>k__BackingField;

		// Token: 0x04002A5F RID: 10847
		[CompilerGenerated]
		private int? <RepairId>k__BackingField;

		// Token: 0x04002A60 RID: 10848
		[CompilerGenerated]
		private int? <SmsId>k__BackingField;

		// Token: 0x04002A61 RID: 10849
		[CompilerGenerated]
		private int? <RequestId>k__BackingField;

		// Token: 0x04002A62 RID: 10850
		[CompilerGenerated]
		private int? <BuyPartRequestId>k__BackingField;

		// Token: 0x04002A63 RID: 10851
		[CompilerGenerated]
		private string <Subject>k__BackingField;

		// Token: 0x04002A64 RID: 10852
		[CompilerGenerated]
		private string <Text>k__BackingField;

		// Token: 0x04002A65 RID: 10853
		[CompilerGenerated]
		private string <Tel>k__BackingField;

		// Token: 0x04002A66 RID: 10854
		[CompilerGenerated]
		private bool <Readed>k__BackingField;

		// Token: 0x04002A67 RID: 10855
		[CompilerGenerated]
		private Brush <Color>k__BackingField;
	}
}
