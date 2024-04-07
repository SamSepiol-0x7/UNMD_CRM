using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ASC.Models
{
	// Token: 0x02000A0A RID: 2570
	public class LockCardModel
	{
		// Token: 0x06004C26 RID: 19494 RVA: 0x00138914 File Offset: 0x00136B14
		public LockCardModel(int repairId)
		{
			this._repairId = repairId;
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00138940 File Offset: 0x00136B40
		public bool IsRepairCardLocked()
		{
			if (this._lastLockQueryTime != null && (DateTime.Now - this._lastLockQueryTime.Value).TotalMinutes < 300.0)
			{
				return this._lastQueryLockResult;
			}
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					var <>f__AnonymousType = (from r in (from r in auseceEntities.workshop
					where r.id == this._repairId
					select r).AsNoTracking<workshop>()
					select new
					{
						User = r.user_lock,
						Time = r.lock_datetime
					}).FirstOrDefault();
					if (<>f__AnonymousType == null)
					{
						result = false;
					}
					else
					{
						int? user = <>f__AnonymousType.User;
						DateTime? time = <>f__AnonymousType.Time;
						bool flag;
						if (time != null && (this._localization.Now - time.Value).TotalMinutes < 1.0 && user != null)
						{
							int? num = user;
							int id = Auth.User.id;
							flag = !(num.GetValueOrDefault() == id & num != null);
						}
						else
						{
							flag = false;
						}
						bool flag2 = flag;
						this._lastQueryLockResult = flag2;
						this._lastLockQueryTime = new DateTime?(DateTime.Now);
						result = flag2;
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x00138B9C File Offset: 0x00136D9C
		private void Tick(object state)
		{
			uint num;
			if (this._stop)
			{
				num = 1995050251U;
				return;
			}
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					workshop workshop = new workshop
					{
						id = this._repairId
					};
					auseceEntities.workshop.Attach(workshop);
					workshop.user_lock = new int?(Auth.User.id);
					workshop.lock_datetime = new DateTime?(this._localization.Now);
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception)
			{
				return;
			}
			if (this.LockStarted != null)
			{
				IL_14A:
				while (Auth.Config.card_close_time != 0)
				{
					for (;;)
					{
						IL_137:
						if (Auth.Config.card_close_time >= 60)
						{
							goto IL_12A;
						}
						int num2 = 60;
						IL_134:
						int num3 = num2;
						for (;;)
						{
							IL_10C:
							TimeSpan timeSpan = this._localization.Now - this.LockStarted.Value;
							IL_FF:
							while (timeSpan.TotalSeconds > (double)num3)
							{
								for (;;)
								{
									Timer tmr = this._tmr;
									if (tmr != null)
									{
										tmr.Dispose();
										switch ((num = (num * 3352342717U ^ 518016787U ^ 3225629887U)) % 10U)
										{
										case 0U:
										case 4U:
											goto IL_14A;
										case 1U:
											goto IL_137;
										case 2U:
											goto IL_10C;
										case 5U:
											continue;
										case 6U:
											return;
										case 7U:
											goto IL_FF;
										case 8U:
											goto IL_12A;
										case 9U:
											goto IL_159;
										}
										goto Block_5;
									}
									goto IL_158;
								}
							}
							goto Block_6;
						}
						IL_12A:
						num2 = Auth.Config.card_close_time;
						goto IL_134;
					}
					Block_5:
					Block_6:
					return;
					IL_158:
					IL_159:
					EventHandler closeCard = this.CloseCard;
					if (closeCard != null)
					{
						closeCard(this, new EventArgs());
						return;
					}
					return;
				}
			}
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00138D38 File Offset: 0x00136F38
		private void EnableLock()
		{
			this._stop = false;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x00138D4C File Offset: 0x00136F4C
		private void DisableLock()
		{
			this._stop = true;
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x00138D60 File Offset: 0x00136F60
		public void Lock()
		{
			this.EnableLock();
			if (this.IsRepairCardLocked())
			{
				return;
			}
			if (Auth.Config.card_close_time > 0)
			{
				this.LockStarted = new DateTime?(this._localization.Now);
			}
			if (this._tmr == null)
			{
				this._tmr = new Timer(new TimerCallback(this.Tick), null, 0, 10000);
			}
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x00138DC8 File Offset: 0x00136FC8
		public void Unlock()
		{
			if (!this.IsRepairCardLocked())
			{
				goto IL_2C;
			}
			IL_08:
			int num = 1608848860;
			IL_0D:
			switch ((num ^ 1476296913) % 4)
			{
			case 0:
				goto IL_08;
			case 1:
				return;
			case 3:
				IL_2C:
				this.DirectUnlock();
				num = 886951423;
				goto IL_0D;
			}
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00138E10 File Offset: 0x00137010
		public void DirectUnlock()
		{
			this.DisableLock();
			for (;;)
			{
				Timer tmr = this._tmr;
				if (tmr != null)
				{
					tmr.Dispose();
					uint num;
					switch ((num = (num * 1542279732U ^ 2450868585U ^ 1834511627U)) % 4U)
					{
					case 1U:
					case 3U:
						continue;
					case 2U:
						goto IL_43;
					}
					break;
				}
				goto IL_42;
			}
			goto IL_4A;
			IL_42:
			IL_43:
			this._tmr = null;
			IL_4A:
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				try
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					workshop workshop = new workshop
					{
						id = this._repairId,
						user_lock = new int?(Auth.User.id)
					};
					auseceEntities.workshop.Attach(workshop);
					workshop.user_lock = null;
					auseceEntities.SaveChanges();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x04003142 RID: 12610
		private Timer _tmr;

		// Token: 0x04003143 RID: 12611
		private readonly int _repairId;

		// Token: 0x04003144 RID: 12612
		private Localization _localization = new Localization("UTC");

		// Token: 0x04003145 RID: 12613
		private DateTime? LockStarted;

		// Token: 0x04003146 RID: 12614
		public EventHandler CloseCard;

		// Token: 0x04003147 RID: 12615
		private bool _stop;

		// Token: 0x04003148 RID: 12616
		private DateTime? _lastLockQueryTime;

		// Token: 0x04003149 RID: 12617
		private bool _lastQueryLockResult;

		// Token: 0x02000A0B RID: 2571
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C2E RID: 19502 RVA: 0x00138EF0 File Offset: 0x001370F0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004C2F RID: 19503 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0400314A RID: 12618
			public static readonly LockCardModel.<>c <>9 = new LockCardModel.<>c();
		}
	}
}
