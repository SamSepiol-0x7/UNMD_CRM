using System;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;

namespace ASC.Objects
{
	// Token: 0x02000876 RID: 2166
	public class AdditionalPayment : IAdditionalPayment
	{
		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x00101248 File Offset: 0x000FF448
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x0010125C File Offset: 0x000FF45C
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

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x00101270 File Offset: 0x000FF470
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x00101284 File Offset: 0x000FF484
		public string Reason
		{
			[CompilerGenerated]
			get
			{
				return this.<Reason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Reason>k__BackingField = value;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x00101298 File Offset: 0x000FF498
		// (set) Token: 0x060040D6 RID: 16598 RVA: 0x001012AC File Offset: 0x000FF4AC
		public DateTime Date
		{
			[CompilerGenerated]
			get
			{
				return this.<Date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Date>k__BackingField = value;
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060040D7 RID: 16599 RVA: 0x001012C0 File Offset: 0x000FF4C0
		// (set) Token: 0x060040D8 RID: 16600 RVA: 0x001012D4 File Offset: 0x000FF4D4
		public int Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Employee>k__BackingField = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x001012E8 File Offset: 0x000FF4E8
		// (set) Token: 0x060040DA RID: 16602 RVA: 0x001012FC File Offset: 0x000FF4FC
		public int User
		{
			[CompilerGenerated]
			get
			{
				return this.<User>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<User>k__BackingField = value;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060040DB RID: 16603 RVA: 0x00101310 File Offset: 0x000FF510
		// (set) Token: 0x060040DC RID: 16604 RVA: 0x00101324 File Offset: 0x000FF524
		public decimal Summ
		{
			[CompilerGenerated]
			get
			{
				return this.<Summ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Summ>k__BackingField = value;
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x00101338 File Offset: 0x000FF538
		public void SetEmployee(int employeeId)
		{
			this.Employee = employeeId;
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x0010134C File Offset: 0x000FF54C
		public void SetUser(int userId)
		{
			this.User = userId;
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00101360 File Offset: 0x000FF560
		public void SetSumm(decimal summ)
		{
			this.Summ = summ;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00101374 File Offset: 0x000FF574
		public void SetSumm(decimal summ, int percent)
		{
			this.Summ = summ / 100m * percent;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x001013A0 File Offset: 0x000FF5A0
		public void SetDate(DateTime date)
		{
			this.Date = date;
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x001013B4 File Offset: 0x000FF5B4
		public void SetReason(string reason)
		{
			this.Reason = reason;
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x000046B4 File Offset: 0x000028B4
		public AdditionalPayment()
		{
		}

		// Token: 0x04002A52 RID: 10834
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002A53 RID: 10835
		[CompilerGenerated]
		private string <Reason>k__BackingField;

		// Token: 0x04002A54 RID: 10836
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x04002A55 RID: 10837
		[CompilerGenerated]
		private int <Employee>k__BackingField;

		// Token: 0x04002A56 RID: 10838
		[CompilerGenerated]
		private int <User>k__BackingField;

		// Token: 0x04002A57 RID: 10839
		[CompilerGenerated]
		private decimal <Summ>k__BackingField;
	}
}
