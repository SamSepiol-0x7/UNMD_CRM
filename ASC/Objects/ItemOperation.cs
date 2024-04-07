using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ASC.Common.Interfaces;
using ASC.Converters;

namespace ASC.Objects
{
	// Token: 0x02000885 RID: 2181
	public class ItemOperation : IItemOperation
	{
		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x060041BC RID: 16828 RVA: 0x001030D0 File Offset: 0x001012D0
		// (set) Token: 0x060041BD RID: 16829 RVA: 0x001030E4 File Offset: 0x001012E4
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

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x001030F8 File Offset: 0x001012F8
		// (set) Token: 0x060041BF RID: 16831 RVA: 0x0010310C File Offset: 0x0010130C
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

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x060041C0 RID: 16832 RVA: 0x00103120 File Offset: 0x00101320
		// (set) Token: 0x060041C1 RID: 16833 RVA: 0x00103134 File Offset: 0x00101334
		public string Num
		{
			[CompilerGenerated]
			get
			{
				return this.<Num>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Num>k__BackingField = value;
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x00103148 File Offset: 0x00101348
		// (set) Token: 0x060041C3 RID: 16835 RVA: 0x0010315C File Offset: 0x0010135C
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

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x00103170 File Offset: 0x00101370
		// (set) Token: 0x060041C5 RID: 16837 RVA: 0x00103184 File Offset: 0x00101384
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this.<Count>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Count>k__BackingField = value;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x00103198 File Offset: 0x00101398
		// (set) Token: 0x060041C7 RID: 16839 RVA: 0x001031AC File Offset: 0x001013AC
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

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x001031C0 File Offset: 0x001013C0
		// (set) Token: 0x060041C9 RID: 16841 RVA: 0x001031D4 File Offset: 0x001013D4
		public IEmployee Employee
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

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x001031E8 File Offset: 0x001013E8
		// (set) Token: 0x060041CB RID: 16843 RVA: 0x001031FC File Offset: 0x001013FC
		public int? Status
		{
			[CompilerGenerated]
			get
			{
				return this.<Status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Status>k__BackingField = value;
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x00103210 File Offset: 0x00101410
		public string TypeName
		{
			get
			{
				int type = this.Type;
				for (;;)
				{
					IL_5F:
					switch (type)
					{
					case 0:
						goto IL_81;
					case 1:
						goto IL_8C;
					case 2:
						goto IL_97;
					case 3:
						goto IL_A2;
					case 4:
						goto IL_AD;
					case 5:
						goto IL_B8;
					default:
					{
						uint num2;
						uint num = num2 * 249921891U ^ 387385533U;
						for (;;)
						{
							switch ((num2 = (num ^ 3424394351U)) % 10U)
							{
							case 0U:
								goto IL_97;
							case 1U:
								goto IL_81;
							case 2U:
								num = (num2 * 1695239001U ^ 372941154U);
								continue;
							case 3U:
								goto IL_A2;
							case 4U:
							case 8U:
								goto IL_5F;
							case 5U:
								goto IL_B8;
							case 6U:
								goto IL_AD;
							case 9U:
								goto IL_8C;
							}
							goto Block_1;
						}
						break;
					}
					}
				}
				Block_1:
				return null;
				IL_81:
				return Lang.t("ReserveRepairs");
				IL_8C:
				return Lang.t("ReserveSales");
				IL_97:
				return Lang.t("QuickSale");
				IL_A2:
				return Lang.t("ItemsArrival");
				IL_AD:
				return Lang.t("ItemsCancellation");
				IL_B8:
				return Lang.t("ItemsMovement");
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x001032E0 File Offset: 0x001014E0
		public string StatusName
		{
			get
			{
				if (this.Type == 0)
				{
					goto IL_17;
				}
				goto IL_75;
				int num;
				for (;;)
				{
					IL_3E:
					switch ((num ^ 373325055) % 7)
					{
					case 0:
						num = ((this.Type != 5) ? 170378635 : 901345366);
						continue;
					case 1:
						goto IL_80;
					case 2:
						goto IL_87;
					case 3:
						goto IL_75;
					case 4:
						goto IL_17;
					case 6:
						goto IL_A7;
					}
					break;
				}
				goto IL_A5;
				IL_80:
				return this.GetInternalRelocationStatusName();
				IL_87:
				return new IntReserveState2StringConverter().Convert(this.Status, null, null, null).ToString();
				IL_A5:
				return null;
				IL_A7:
				return this.GetSaleStatusName();
				IL_17:
				num = 963109125;
				goto IL_3E;
				IL_75:
				num = ((this.Type != 2) ? 697615768 : 1960342451);
				goto IL_3E;
			}
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x0010339C File Offset: 0x0010159C
		private string GetInternalRelocationStatusName()
		{
			int? status = this.Status;
			if (status.GetValueOrDefault() == 3 & status != null)
			{
				return Lang.t("InProgress");
			}
			status = this.Status;
			if (status.GetValueOrDefault() == 9 & status != null)
			{
				return Lang.t("Complete");
			}
			return null;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x001033F8 File Offset: 0x001015F8
		private string GetSaleStatusName()
		{
			int? status = this.Status;
			if (status.GetValueOrDefault() == 7 & status != null)
			{
				return Lang.t("RnCancelled");
			}
			status = this.Status;
			if (!(status.GetValueOrDefault() == 5 & status != null))
			{
				return null;
			}
			return Lang.t("Sold");
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060041D0 RID: 16848 RVA: 0x00103454 File Offset: 0x00101654
		public Brush Color
		{
			get
			{
				int? status;
				int valueOrDefault;
				if (this.Type == 0)
				{
					for (;;)
					{
						IL_C7:
						status = this.Status;
						IL_BC:
						while (status != null)
						{
							for (;;)
							{
								IL_91:
								valueOrDefault = status.GetValueOrDefault();
								switch (valueOrDefault)
								{
								case 0:
									goto IL_D0;
								case 1:
									goto IL_D6;
								case 2:
									goto IL_DC;
								case 3:
									goto IL_E2;
								case 4:
									goto IL_E8;
								case 5:
									goto IL_EE;
								default:
								{
									uint num2;
									uint num = num2 * 3789360351U ^ 243890557U;
									for (;;)
									{
										switch ((num2 = (num ^ 3018015194U)) % 20U)
										{
										case 0U:
											goto IL_BC;
										case 1U:
											num = (num2 * 2630493939U ^ 2578088478U);
											continue;
										case 2U:
											goto IL_122;
										case 3U:
											goto IL_DC;
										case 4U:
											goto IL_112;
										case 5U:
											goto IL_FA;
										case 6U:
											goto IL_91;
										case 8U:
										case 18U:
											goto IL_C7;
										case 9U:
											goto IL_11C;
										case 10U:
											goto IL_10A;
										case 11U:
											goto IL_D6;
										case 12U:
											goto IL_D0;
										case 14U:
											goto IL_E2;
										case 15U:
											goto IL_E8;
										case 16U:
											goto IL_EE;
										case 17U:
											goto IL_116;
										case 19U:
											goto IL_F4;
										}
										goto Block_2;
									}
									break;
								}
								}
							}
						}
						goto IL_F4;
					}
					Block_2:
					goto IL_128;
					IL_D0:
					return Brushes.Orange;
					IL_D6:
					return Brushes.LightGreen;
					IL_DC:
					return Brushes.LightGreen;
					IL_E2:
					return Brushes.LightGray;
					IL_E8:
					return Brushes.LightGray;
					IL_EE:
					return Brushes.LightGray;
					IL_F4:
					return Brushes.Transparent;
				}
				IL_FA:
				status = this.Status;
				if (status == null)
				{
					goto IL_128;
				}
				IL_10A:
				valueOrDefault = status.GetValueOrDefault();
				IL_112:
				if (valueOrDefault == 3)
				{
					goto IL_122;
				}
				IL_116:
				if (valueOrDefault != 4)
				{
					goto IL_128;
				}
				IL_11C:
				return Brushes.LightGray;
				IL_122:
				return Brushes.LightGreen;
				IL_128:
				return Brushes.Transparent;
			}
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x000046B4 File Offset: 0x000028B4
		public ItemOperation()
		{
		}

		// Token: 0x04002AB0 RID: 10928
		[CompilerGenerated]
		private int <Type>k__BackingField;

		// Token: 0x04002AB1 RID: 10929
		[CompilerGenerated]
		private int <Id>k__BackingField;

		// Token: 0x04002AB2 RID: 10930
		[CompilerGenerated]
		private string <Num>k__BackingField;

		// Token: 0x04002AB3 RID: 10931
		[CompilerGenerated]
		private DateTime <Date>k__BackingField;

		// Token: 0x04002AB4 RID: 10932
		[CompilerGenerated]
		private int <Count>k__BackingField;

		// Token: 0x04002AB5 RID: 10933
		[CompilerGenerated]
		private decimal <Summ>k__BackingField;

		// Token: 0x04002AB6 RID: 10934
		[CompilerGenerated]
		private IEmployee <Employee>k__BackingField;

		// Token: 0x04002AB7 RID: 10935
		[CompilerGenerated]
		private int? <Status>k__BackingField;
	}
}
