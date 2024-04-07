using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Objects;
using ASC.Properties;
using ASC.SimpleClasses;
using Newtonsoft.Json;

namespace ASC
{
	// Token: 0x0200007E RID: 126
	public class users
	{
		// Token: 0x06000EE5 RID: 3813 RVA: 0x0001BC4C File Offset: 0x00019E4C
		public users()
		{
			this.pay_repair = 0;
			this.pay_sale = 0;
			this.pay_repair_q_sale = 0;
			this.pay_cartridge_refill = 0;
			this.additional_payments = new HashSet<additional_payments>();
			this.additional_payments1 = new HashSet<additional_payments>();
			this.balance = new HashSet<balance>();
			this.cash_orders = new HashSet<cash_orders>();
			this.cash_orders1 = new HashSet<cash_orders>();
			this.clients = new HashSet<clients>();
			this.dealer_payments = new HashSet<dealer_payments>();
			this.docs = new HashSet<docs>();
			this.docs1 = new HashSet<docs>();
			this.logs = new HashSet<logs>();
			this.media_info = new HashSet<media_info>();
			this.offices = new HashSet<offices>();
			this.roles_users = new HashSet<roles_users>();
			this.salary = new HashSet<salary>();
			this.salary1 = new HashSet<salary>();
			this.store_int_reserve = new HashSet<store_int_reserve>();
			this.store_int_reserve1 = new HashSet<store_int_reserve>();
			this.store_sales = new HashSet<store_sales>();
			this.workshop_parts = new HashSet<workshop_parts>();
			this.works = new HashSet<works>();
			this.workshop = new HashSet<workshop>();
			this.workshop1 = new HashSet<workshop>();
			this.workshop2 = new HashSet<workshop>();
			this.workshop3 = new HashSet<workshop>();
			this.queue_members = new HashSet<queue_members>();
			this.tasks1 = new HashSet<tasks>();
			this.payment_type_users = new HashSet<payment_type_users>();
			this.companies = new HashSet<companies>();
			this.companies1 = new HashSet<companies>();
			this.parts_request = new HashSet<parts_request>();
			this.parts_request_employees = new HashSet<parts_request_employees>();
			this.task_employees = new HashSet<task_employees>();
			this.comments = new HashSet<comments>();
			this.out_sms = new HashSet<out_sms>();
			this.invoice = new HashSet<invoice>();
			this.vat_invoice = new HashSet<vat_invoice>();
			this.p_lists = new HashSet<p_lists>();
			this.w_lists = new HashSet<w_lists>();
			this.cartridge_cards = new HashSet<cartridge_cards>();
			this.kkt_employee = new HashSet<kkt_employee>();
			this.notifications = new HashSet<notifications>();
			this.users_activity = new HashSet<users_activity>();
			this.workshop_issued = new HashSet<workshop_issued>();
			this.repair_status_logs = new HashSet<repair_status_logs>();
			this.repair_status_logs1 = new HashSet<repair_status_logs>();
			this.repair_status_logs2 = new HashSet<repair_status_logs>();
			this.SalaryRates = new HashSet<SalaryRate>();
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0001BE80 File Offset: 0x0001A080
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0001BE94 File Offset: 0x0001A094
		public int id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0001BEBC File Offset: 0x0001A0BC
		public int? sip_user_id
		{
			[CompilerGenerated]
			get
			{
				return this.<sip_user_id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sip_user_id>k__BackingField = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
		public string username
		{
			[CompilerGenerated]
			get
			{
				return this.<username>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<username>k__BackingField = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x0001BF0C File Offset: 0x0001A10C
		public string name
		{
			[CompilerGenerated]
			get
			{
				return this.<name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<name>k__BackingField = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0001BF20 File Offset: 0x0001A120
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0001BF34 File Offset: 0x0001A134
		public string surname
		{
			[CompilerGenerated]
			get
			{
				return this.<surname>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<surname>k__BackingField = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0001BF48 File Offset: 0x0001A148
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0001BF5C File Offset: 0x0001A15C
		public string patronymic
		{
			[CompilerGenerated]
			get
			{
				return this.<patronymic>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<patronymic>k__BackingField = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0001BF70 File Offset: 0x0001A170
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x0001BF84 File Offset: 0x0001A184
		public string phone
		{
			[CompilerGenerated]
			get
			{
				return this.<phone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<phone>k__BackingField = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0001BF98 File Offset: 0x0001A198
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0001BFAC File Offset: 0x0001A1AC
		public string phone2
		{
			[CompilerGenerated]
			get
			{
				return this.<phone2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<phone2>k__BackingField = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		public int phone_mask
		{
			[CompilerGenerated]
			get
			{
				return this.<phone_mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<phone_mask>k__BackingField = value;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		public int phone2_mask
		{
			[CompilerGenerated]
			get
			{
				return this.<phone2_mask>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<phone2_mask>k__BackingField = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0001C010 File Offset: 0x0001A210
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x0001C024 File Offset: 0x0001A224
		public string address
		{
			[CompilerGenerated]
			get
			{
				return this.<address>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<address>k__BackingField = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0001C038 File Offset: 0x0001A238
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x0001C04C File Offset: 0x0001A24C
		public string passport_num
		{
			[CompilerGenerated]
			get
			{
				return this.<passport_num>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<passport_num>k__BackingField = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0001C060 File Offset: 0x0001A260
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x0001C074 File Offset: 0x0001A274
		public DateTime? passport_date
		{
			[CompilerGenerated]
			get
			{
				return this.<passport_date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<passport_date>k__BackingField = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0001C088 File Offset: 0x0001A288
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0001C09C File Offset: 0x0001A29C
		public string passport_organ
		{
			[CompilerGenerated]
			get
			{
				return this.<passport_organ>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<passport_organ>k__BackingField = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x0001C0C4 File Offset: 0x0001A2C4
		public int? state
		{
			[CompilerGenerated]
			get
			{
				return this.<state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<state>k__BackingField = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x0001C0EC File Offset: 0x0001A2EC
		public DateTime? created
		{
			[CompilerGenerated]
			get
			{
				return this.<created>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<created>k__BackingField = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0001C100 File Offset: 0x0001A300
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x0001C114 File Offset: 0x0001A314
		public int office
		{
			[CompilerGenerated]
			get
			{
				return this.<office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<office>k__BackingField = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0001C128 File Offset: 0x0001A328
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0001C13C File Offset: 0x0001A33C
		public DateTime? birthday
		{
			[CompilerGenerated]
			get
			{
				return this.<birthday>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<birthday>k__BackingField = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0001C150 File Offset: 0x0001A350
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x0001C164 File Offset: 0x0001A364
		public DateTime? last_login
		{
			[CompilerGenerated]
			get
			{
				return this.<last_login>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<last_login>k__BackingField = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0001C178 File Offset: 0x0001A378
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x0001C18C File Offset: 0x0001A38C
		public DateTime? last_activity
		{
			[CompilerGenerated]
			get
			{
				return this.<last_activity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<last_activity>k__BackingField = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
		public string email
		{
			[CompilerGenerated]
			get
			{
				return this.<email>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<email>k__BackingField = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		public int? sex
		{
			[CompilerGenerated]
			get
			{
				return this.<sex>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<sex>k__BackingField = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x0001C204 File Offset: 0x0001A404
		public byte[] photo
		{
			[CompilerGenerated]
			get
			{
				return this.<photo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<photo>k__BackingField = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0001C218 File Offset: 0x0001A418
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x0001C22C File Offset: 0x0001A42C
		public int? salary_rate
		{
			[CompilerGenerated]
			get
			{
				return this.<salary_rate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<salary_rate>k__BackingField = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x0001C240 File Offset: 0x0001A440
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x0001C254 File Offset: 0x0001A454
		public int pay_day
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_day>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_day>k__BackingField = value;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x0001C268 File Offset: 0x0001A468
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x0001C27C File Offset: 0x0001A47C
		public int pay_day_off
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_day_off>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_day_off>k__BackingField = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0001C290 File Offset: 0x0001A490
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		public int pay_repair
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_repair>k__BackingField = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x0001C2CC File Offset: 0x0001A4CC
		public int pay_sale
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_sale>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_sale>k__BackingField = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0001C2E0 File Offset: 0x0001A4E0
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x0001C2F4 File Offset: 0x0001A4F4
		public int pay_repair_q_sale
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_repair_q_sale>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_repair_q_sale>k__BackingField = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x0001C308 File Offset: 0x0001A508
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x0001C31C File Offset: 0x0001A51C
		public int pay_cartridge_refill
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_cartridge_refill>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_cartridge_refill>k__BackingField = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0001C330 File Offset: 0x0001A530
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x0001C344 File Offset: 0x0001A544
		public string color_label_ws
		{
			[CompilerGenerated]
			get
			{
				return this.<color_label_ws>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<color_label_ws>k__BackingField = value;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0001C358 File Offset: 0x0001A558
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x0001C36C File Offset: 0x0001A56C
		public int workspace_mode
		{
			[CompilerGenerated]
			get
			{
				return this.<workspace_mode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workspace_mode>k__BackingField = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0001C380 File Offset: 0x0001A580
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x0001C394 File Offset: 0x0001A594
		public bool preview_before_print
		{
			[CompilerGenerated]
			get
			{
				return this.<preview_before_print>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<preview_before_print>k__BackingField = value;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x0001C3BC File Offset: 0x0001A5BC
		public int new_rep_doc_copies
		{
			[CompilerGenerated]
			get
			{
				return this.<new_rep_doc_copies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<new_rep_doc_copies>k__BackingField = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x0001C3E4 File Offset: 0x0001A5E4
		public bool auto_refresh_workspace
		{
			[CompilerGenerated]
			get
			{
				return this.<auto_refresh_workspace>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<auto_refresh_workspace>k__BackingField = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x0001C40C File Offset: 0x0001A60C
		public int refresh_time
		{
			[CompilerGenerated]
			get
			{
				return this.<refresh_time>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<refresh_time>k__BackingField = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0001C420 File Offset: 0x0001A620
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x0001C434 File Offset: 0x0001A634
		public int xls_c1
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c1>k__BackingField = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0001C448 File Offset: 0x0001A648
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x0001C45C File Offset: 0x0001A65C
		public int xls_c2
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c2>k__BackingField = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0001C470 File Offset: 0x0001A670
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x0001C484 File Offset: 0x0001A684
		public int xls_c3
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c3>k__BackingField = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0001C498 File Offset: 0x0001A698
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x0001C4AC File Offset: 0x0001A6AC
		public int xls_c4
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c4>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c4>k__BackingField = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
		public int xls_c5
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c5>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c5>k__BackingField = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x0001C4FC File Offset: 0x0001A6FC
		public int xls_c6
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c6>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c6>k__BackingField = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x0001C510 File Offset: 0x0001A710
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x0001C524 File Offset: 0x0001A724
		public int xls_c7
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c7>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c7>k__BackingField = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x0001C538 File Offset: 0x0001A738
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x0001C54C File Offset: 0x0001A74C
		public int xls_c8
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c8>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c8>k__BackingField = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0001C560 File Offset: 0x0001A760
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x0001C574 File Offset: 0x0001A774
		public int xls_c9
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c9>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c9>k__BackingField = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0001C588 File Offset: 0x0001A788
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x0001C59C File Offset: 0x0001A79C
		public int xls_c10
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c10>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c10>k__BackingField = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
		public int xls_c11
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c11>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c11>k__BackingField = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x0001C5EC File Offset: 0x0001A7EC
		public int xls_c12
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c12>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c12>k__BackingField = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0001C600 File Offset: 0x0001A800
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x0001C614 File Offset: 0x0001A814
		public int xls_c13
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c13>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c13>k__BackingField = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0001C628 File Offset: 0x0001A828
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x0001C63C File Offset: 0x0001A83C
		public int xls_c14
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c14>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c14>k__BackingField = value;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0001C650 File Offset: 0x0001A850
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x0001C664 File Offset: 0x0001A864
		public int xls_c15
		{
			[CompilerGenerated]
			get
			{
				return this.<xls_c15>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<xls_c15>k__BackingField = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0001C678 File Offset: 0x0001A878
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x0001C68C File Offset: 0x0001A88C
		public bool display_out
		{
			[CompilerGenerated]
			get
			{
				return this.<display_out>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<display_out>k__BackingField = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x0001C6B4 File Offset: 0x0001A8B4
		public bool display_complete
		{
			[CompilerGenerated]
			get
			{
				return this.<display_complete>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<display_complete>k__BackingField = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x0001C6DC File Offset: 0x0001A8DC
		public bool is_bot
		{
			[CompilerGenerated]
			get
			{
				return this.<is_bot>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<is_bot>k__BackingField = value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0001C704 File Offset: 0x0001A904
		public bool new_on_top
		{
			[CompilerGenerated]
			get
			{
				return this.<new_on_top>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<new_on_top>k__BackingField = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0001C718 File Offset: 0x0001A918
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x0001C72C File Offset: 0x0001A92C
		public string issued_color
		{
			[CompilerGenerated]
			get
			{
				return this.<issued_color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<issued_color>k__BackingField = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0001C740 File Offset: 0x0001A940
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x0001C754 File Offset: 0x0001A954
		public string fields_cfg
		{
			[CompilerGenerated]
			get
			{
				return this.<fields_cfg>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fields_cfg>k__BackingField = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0001C768 File Offset: 0x0001A968
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x0001C77C File Offset: 0x0001A97C
		public int? kkm_pass
		{
			[CompilerGenerated]
			get
			{
				return this.<kkm_pass>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkm_pass>k__BackingField = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0001C790 File Offset: 0x0001A990
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x0001C7A4 File Offset: 0x0001A9A4
		public bool prefer_regular
		{
			[CompilerGenerated]
			get
			{
				return this.<prefer_regular>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<prefer_regular>k__BackingField = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x0001C7CC File Offset: 0x0001A9CC
		public int fontsize
		{
			[CompilerGenerated]
			get
			{
				return this.<fontsize>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<fontsize>k__BackingField = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x0001C7F4 File Offset: 0x0001A9F4
		public int rowheight
		{
			[CompilerGenerated]
			get
			{
				return this.<rowheight>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<rowheight>k__BackingField = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0001C808 File Offset: 0x0001AA08
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0001C81C File Offset: 0x0001AA1C
		public string animation
		{
			[CompilerGenerated]
			get
			{
				return this.<animation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<animation>k__BackingField = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0001C830 File Offset: 0x0001AA30
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x0001C844 File Offset: 0x0001AA44
		public int pay_device_in
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_device_in>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_device_in>k__BackingField = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0001C858 File Offset: 0x0001AA58
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x0001C86C File Offset: 0x0001AA6C
		public int pay_device_out
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_device_out>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_device_out>k__BackingField = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0001C880 File Offset: 0x0001AA80
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x0001C894 File Offset: 0x0001AA94
		public bool pay_4_sale_in_repair
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_4_sale_in_repair>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_4_sale_in_repair>k__BackingField = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0001C8BC File Offset: 0x0001AABC
		public string row_color
		{
			[CompilerGenerated]
			get
			{
				return this.<row_color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<row_color>k__BackingField = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		public bool save_state_on_close
		{
			[CompilerGenerated]
			get
			{
				return this.<save_state_on_close>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<save_state_on_close>k__BackingField = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0001C8F8 File Offset: 0x0001AAF8
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x0001C90C File Offset: 0x0001AB0C
		public bool group_store_items
		{
			[CompilerGenerated]
			get
			{
				return this.<group_store_items>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<group_store_items>k__BackingField = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0001C920 File Offset: 0x0001AB20
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x0001C934 File Offset: 0x0001AB34
		public bool track_activity
		{
			[CompilerGenerated]
			get
			{
				return this.<track_activity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<track_activity>k__BackingField = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0001C948 File Offset: 0x0001AB48
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0001C95C File Offset: 0x0001AB5C
		public string inn
		{
			[CompilerGenerated]
			get
			{
				return this.<inn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<inn>k__BackingField = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0001C970 File Offset: 0x0001AB70
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x0001C984 File Offset: 0x0001AB84
		public bool inform_comment
		{
			[CompilerGenerated]
			get
			{
				return this.<inform_comment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<inform_comment>k__BackingField = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0001C998 File Offset: 0x0001AB98
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x0001C9AC File Offset: 0x0001ABAC
		public bool inform_status
		{
			[CompilerGenerated]
			get
			{
				return this.<inform_status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<inform_status>k__BackingField = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x0001C9D4 File Offset: 0x0001ABD4
		public int? kkt
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt>k__BackingField = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x0001C9FC File Offset: 0x0001ABFC
		public int? pinpad
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad>k__BackingField = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0001CA10 File Offset: 0x0001AC10
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x0001CA24 File Offset: 0x0001AC24
		public int def_office
		{
			[CompilerGenerated]
			get
			{
				return this.<def_office>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<def_office>k__BackingField = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0001CA38 File Offset: 0x0001AC38
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0001CA4C File Offset: 0x0001AC4C
		public int def_store
		{
			[CompilerGenerated]
			get
			{
				return this.<def_store>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<def_store>k__BackingField = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x0001CA60 File Offset: 0x0001AC60
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x0001CA74 File Offset: 0x0001AC74
		public int def_item_state
		{
			[CompilerGenerated]
			get
			{
				return this.<def_item_state>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<def_item_state>k__BackingField = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0001CA88 File Offset: 0x0001AC88
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x0001CA9C File Offset: 0x0001AC9C
		public int def_employee
		{
			[CompilerGenerated]
			get
			{
				return this.<def_employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<def_employee>k__BackingField = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
		public int? def_status
		{
			[CompilerGenerated]
			get
			{
				return this.<def_status>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<def_status>k__BackingField = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		public int def_ws_filter
		{
			[CompilerGenerated]
			get
			{
				return this.<def_ws_filter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<def_ws_filter>k__BackingField = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0001CB00 File Offset: 0x0001AD00
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x0001CB14 File Offset: 0x0001AD14
		public bool card_on_call
		{
			[CompilerGenerated]
			get
			{
				return this.<card_on_call>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<card_on_call>k__BackingField = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0001CB28 File Offset: 0x0001AD28
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x0001CB3C File Offset: 0x0001AD3C
		public string ge_highlight_color
		{
			[CompilerGenerated]
			get
			{
				return this.<ge_highlight_color>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ge_highlight_color>k__BackingField = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0001CB50 File Offset: 0x0001AD50
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0001CB64 File Offset: 0x0001AD64
		public int pay_repair_quick
		{
			[CompilerGenerated]
			get
			{
				return this.<pay_repair_quick>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pay_repair_quick>k__BackingField = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0001CB78 File Offset: 0x0001AD78
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		public bool advance_disable
		{
			[CompilerGenerated]
			get
			{
				return this.<advance_disable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<advance_disable>k__BackingField = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0001CBA0 File Offset: 0x0001ADA0
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
		public bool salary_disable
		{
			[CompilerGenerated]
			get
			{
				return this.<salary_disable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<salary_disable>k__BackingField = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0001CBC8 File Offset: 0x0001ADC8
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		public string notes
		{
			[CompilerGenerated]
			get
			{
				return this.<notes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<notes>k__BackingField = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x0001CC04 File Offset: 0x0001AE04
		public string signature
		{
			[CompilerGenerated]
			get
			{
				return this.<signature>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<signature>k__BackingField = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0001CC18 File Offset: 0x0001AE18
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x0001CC2C File Offset: 0x0001AE2C
		public virtual ICollection<additional_payments> additional_payments
		{
			[CompilerGenerated]
			get
			{
				return this.<additional_payments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<additional_payments>k__BackingField = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0001CC40 File Offset: 0x0001AE40
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x0001CC54 File Offset: 0x0001AE54
		public virtual ICollection<additional_payments> additional_payments1
		{
			[CompilerGenerated]
			get
			{
				return this.<additional_payments1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<additional_payments1>k__BackingField = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0001CC68 File Offset: 0x0001AE68
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0001CC7C File Offset: 0x0001AE7C
		public virtual ICollection<balance> balance
		{
			[CompilerGenerated]
			get
			{
				return this.<balance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<balance>k__BackingField = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0001CC90 File Offset: 0x0001AE90
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x0001CCA4 File Offset: 0x0001AEA4
		public virtual ICollection<cash_orders> cash_orders
		{
			[CompilerGenerated]
			get
			{
				return this.<cash_orders>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cash_orders>k__BackingField = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x0001CCCC File Offset: 0x0001AECC
		public virtual ICollection<cash_orders> cash_orders1
		{
			[CompilerGenerated]
			get
			{
				return this.<cash_orders1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cash_orders1>k__BackingField = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		public virtual ICollection<clients> clients
		{
			[CompilerGenerated]
			get
			{
				return this.<clients>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<clients>k__BackingField = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0001CD08 File Offset: 0x0001AF08
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x0001CD1C File Offset: 0x0001AF1C
		public virtual ICollection<dealer_payments> dealer_payments
		{
			[CompilerGenerated]
			get
			{
				return this.<dealer_payments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<dealer_payments>k__BackingField = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0001CD30 File Offset: 0x0001AF30
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x0001CD44 File Offset: 0x0001AF44
		public virtual ICollection<docs> docs
		{
			[CompilerGenerated]
			get
			{
				return this.<docs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<docs>k__BackingField = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0001CD58 File Offset: 0x0001AF58
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0001CD6C File Offset: 0x0001AF6C
		public virtual ICollection<docs> docs1
		{
			[CompilerGenerated]
			get
			{
				return this.<docs1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<docs1>k__BackingField = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0001CD80 File Offset: 0x0001AF80
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x0001CD94 File Offset: 0x0001AF94
		public virtual ICollection<logs> logs
		{
			[CompilerGenerated]
			get
			{
				return this.<logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<logs>k__BackingField = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0001CDBC File Offset: 0x0001AFBC
		public virtual ICollection<media_info> media_info
		{
			[CompilerGenerated]
			get
			{
				return this.<media_info>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<media_info>k__BackingField = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		public virtual ICollection<offices> offices
		{
			[CompilerGenerated]
			get
			{
				return this.<offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<offices>k__BackingField = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0001CE0C File Offset: 0x0001B00C
		public virtual offices offices1
		{
			[CompilerGenerated]
			get
			{
				return this.<offices1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<offices1>k__BackingField = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0001CE20 File Offset: 0x0001B020
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0001CE34 File Offset: 0x0001B034
		public virtual ICollection<roles_users> roles_users
		{
			[CompilerGenerated]
			get
			{
				return this.<roles_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<roles_users>k__BackingField = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0001CE48 File Offset: 0x0001B048
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0001CE5C File Offset: 0x0001B05C
		public virtual ICollection<salary> salary
		{
			[CompilerGenerated]
			get
			{
				return this.<salary>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<salary>k__BackingField = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0001CE70 File Offset: 0x0001B070
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x0001CE84 File Offset: 0x0001B084
		public virtual ICollection<salary> salary1
		{
			[CompilerGenerated]
			get
			{
				return this.<salary1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<salary1>k__BackingField = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0001CE98 File Offset: 0x0001B098
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0001CEAC File Offset: 0x0001B0AC
		public virtual ICollection<store_int_reserve> store_int_reserve
		{
			[CompilerGenerated]
			get
			{
				return this.<store_int_reserve>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_int_reserve>k__BackingField = value;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0001CED4 File Offset: 0x0001B0D4
		public virtual ICollection<store_int_reserve> store_int_reserve1
		{
			[CompilerGenerated]
			get
			{
				return this.<store_int_reserve1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_int_reserve1>k__BackingField = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x0001CEFC File Offset: 0x0001B0FC
		public virtual ICollection<store_sales> store_sales
		{
			[CompilerGenerated]
			get
			{
				return this.<store_sales>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<store_sales>k__BackingField = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0001CF10 File Offset: 0x0001B110
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0001CF24 File Offset: 0x0001B124
		public virtual ICollection<workshop_parts> workshop_parts
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_parts>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_parts>k__BackingField = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0001CF38 File Offset: 0x0001B138
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x0001CF4C File Offset: 0x0001B14C
		public virtual ICollection<works> works
		{
			[CompilerGenerated]
			get
			{
				return this.<works>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<works>k__BackingField = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0001CF60 File Offset: 0x0001B160
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x0001CF74 File Offset: 0x0001B174
		public virtual ICollection<workshop> workshop
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop>k__BackingField = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0001CF88 File Offset: 0x0001B188
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0001CF9C File Offset: 0x0001B19C
		public virtual ICollection<workshop> workshop1
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop1>k__BackingField = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
		public virtual ICollection<workshop> workshop2
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop2>k__BackingField = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x0001CFEC File Offset: 0x0001B1EC
		public virtual ICollection<workshop> workshop3
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop3>k__BackingField = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0001D000 File Offset: 0x0001B200
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0001D014 File Offset: 0x0001B214
		public virtual ICollection<queue_members> queue_members
		{
			[CompilerGenerated]
			get
			{
				return this.<queue_members>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<queue_members>k__BackingField = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0001D028 File Offset: 0x0001B228
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x0001D03C File Offset: 0x0001B23C
		public virtual ICollection<tasks> tasks1
		{
			[CompilerGenerated]
			get
			{
				return this.<tasks1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<tasks1>k__BackingField = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0001D050 File Offset: 0x0001B250
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0001D064 File Offset: 0x0001B264
		public virtual ICollection<payment_type_users> payment_type_users
		{
			[CompilerGenerated]
			get
			{
				return this.<payment_type_users>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<payment_type_users>k__BackingField = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0001D078 File Offset: 0x0001B278
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0001D08C File Offset: 0x0001B28C
		public virtual ICollection<companies> companies
		{
			[CompilerGenerated]
			get
			{
				return this.<companies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<companies>k__BackingField = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0001D0B4 File Offset: 0x0001B2B4
		public virtual ICollection<companies> companies1
		{
			[CompilerGenerated]
			get
			{
				return this.<companies1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<companies1>k__BackingField = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0001D0DC File Offset: 0x0001B2DC
		public virtual ICollection<parts_request> parts_request
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<parts_request>k__BackingField = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x0001D104 File Offset: 0x0001B304
		public virtual ICollection<parts_request_employees> parts_request_employees
		{
			[CompilerGenerated]
			get
			{
				return this.<parts_request_employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<parts_request_employees>k__BackingField = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0001D118 File Offset: 0x0001B318
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0001D12C File Offset: 0x0001B32C
		public virtual ICollection<task_employees> task_employees
		{
			[CompilerGenerated]
			get
			{
				return this.<task_employees>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<task_employees>k__BackingField = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0001D140 File Offset: 0x0001B340
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0001D154 File Offset: 0x0001B354
		public virtual ICollection<comments> comments
		{
			[CompilerGenerated]
			get
			{
				return this.<comments>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<comments>k__BackingField = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0001D168 File Offset: 0x0001B368
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0001D17C File Offset: 0x0001B37C
		public virtual ICollection<out_sms> out_sms
		{
			[CompilerGenerated]
			get
			{
				return this.<out_sms>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<out_sms>k__BackingField = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0001D190 File Offset: 0x0001B390
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0001D1A4 File Offset: 0x0001B3A4
		public virtual ICollection<invoice> invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<invoice>k__BackingField = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0001D1CC File Offset: 0x0001B3CC
		public virtual ICollection<vat_invoice> vat_invoice
		{
			[CompilerGenerated]
			get
			{
				return this.<vat_invoice>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<vat_invoice>k__BackingField = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
		public virtual ICollection<p_lists> p_lists
		{
			[CompilerGenerated]
			get
			{
				return this.<p_lists>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<p_lists>k__BackingField = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0001D208 File Offset: 0x0001B408
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0001D21C File Offset: 0x0001B41C
		public virtual ICollection<w_lists> w_lists
		{
			[CompilerGenerated]
			get
			{
				return this.<w_lists>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<w_lists>k__BackingField = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0001D230 File Offset: 0x0001B430
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0001D244 File Offset: 0x0001B444
		public virtual ICollection<cartridge_cards> cartridge_cards
		{
			[CompilerGenerated]
			get
			{
				return this.<cartridge_cards>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<cartridge_cards>k__BackingField = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0001D258 File Offset: 0x0001B458
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0001D26C File Offset: 0x0001B46C
		public virtual kkt kkt1
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt1>k__BackingField = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0001D280 File Offset: 0x0001B480
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0001D294 File Offset: 0x0001B494
		public virtual pinpad pinpad1
		{
			[CompilerGenerated]
			get
			{
				return this.<pinpad1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<pinpad1>k__BackingField = value;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0001D2BC File Offset: 0x0001B4BC
		public virtual ICollection<kkt_employee> kkt_employee
		{
			[CompilerGenerated]
			get
			{
				return this.<kkt_employee>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<kkt_employee>k__BackingField = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		public virtual ICollection<notifications> notifications
		{
			[CompilerGenerated]
			get
			{
				return this.<notifications>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<notifications>k__BackingField = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x0001D30C File Offset: 0x0001B50C
		public virtual ICollection<users_activity> users_activity
		{
			[CompilerGenerated]
			get
			{
				return this.<users_activity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<users_activity>k__BackingField = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0001D320 File Offset: 0x0001B520
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x0001D334 File Offset: 0x0001B534
		public virtual ICollection<workshop_issued> workshop_issued
		{
			[CompilerGenerated]
			get
			{
				return this.<workshop_issued>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<workshop_issued>k__BackingField = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0001D348 File Offset: 0x0001B548
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x0001D35C File Offset: 0x0001B55C
		public virtual ICollection<repair_status_logs> repair_status_logs
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_status_logs>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<repair_status_logs>k__BackingField = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0001D370 File Offset: 0x0001B570
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0001D384 File Offset: 0x0001B584
		public virtual ICollection<repair_status_logs> repair_status_logs1
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_status_logs1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<repair_status_logs1>k__BackingField = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0001D398 File Offset: 0x0001B598
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x0001D3AC File Offset: 0x0001B5AC
		public virtual ICollection<repair_status_logs> repair_status_logs2
		{
			[CompilerGenerated]
			get
			{
				return this.<repair_status_logs2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<repair_status_logs2>k__BackingField = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0001D3C0 File Offset: 0x0001B5C0
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
		public virtual ICollection<SalaryRate> SalaryRates
		{
			[CompilerGenerated]
			get
			{
				return this.<SalaryRates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<SalaryRates>k__BackingField = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0001D410 File Offset: 0x0001B610
		public virtual bool IsArchive
		{
			get
			{
				int? state = this.state;
				return state.GetValueOrDefault() == 0 & state != null;
			}
			set
			{
				this.state = new int?((!value) ? 1 : 0);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0001D430 File Offset: 0x0001B630
		public virtual bool VisClientFullname
		{
			get
			{
				return this.IsFieldVisible("ws_vis_cl") && OfflineData.Instance.Employee.Can(7, 0);
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0001D460 File Offset: 0x0001B660
		public virtual bool VisClientPhone
		{
			get
			{
				return this.IsFieldVisible("ws_vis_cl_phone") && OfflineData.Instance.Employee.Can(7, 0);
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0001D490 File Offset: 0x0001B690
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		public List<RepairFieldsVisibility> FieldsVisibility
		{
			get
			{
				if (this.fields_cfg != null)
				{
					return JsonConvert.DeserializeObject<List<RepairFieldsVisibility>>(this.fields_cfg);
				}
				return new List<RepairFieldsVisibility>();
			}
			set
			{
				this.fields_cfg = JsonConvert.SerializeObject(value);
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0001D4D4 File Offset: 0x0001B6D4
		public void SetFieldVisibility(string fieldName, bool isVisible)
		{
			List<RepairFieldsVisibility> fieldsVisibility = this.FieldsVisibility;
			RepairFieldsVisibility repairFieldsVisibility = (fieldsVisibility != null) ? fieldsVisibility.FirstOrDefault((RepairFieldsVisibility f) => f.Name == fieldName) : null;
			if (repairFieldsVisibility != null)
			{
				repairFieldsVisibility.Visible = isVisible;
				this.FieldsVisibility = fieldsVisibility;
				return;
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0001D520 File Offset: 0x0001B720
		public bool IsFieldVisible(string fieldName)
		{
			if (this.FieldsVisibility == null)
			{
				return false;
			}
			RepairFieldsVisibility repairFieldsVisibility = this.FieldsVisibility.FirstOrDefault((RepairFieldsVisibility f) => f.Name == fieldName);
			if (repairFieldsVisibility == null)
			{
				List<RepairFieldsVisibility> fieldsVisibility = this.FieldsVisibility;
				fieldsVisibility.Add(new RepairFieldsVisibility(fieldName, true));
				this.FieldsVisibility = fieldsVisibility;
				return true;
			}
			return repairFieldsVisibility.Visible;
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool EnClientFullname
		{
			get
			{
				return OfflineData.Instance.Employee.Can(7, 0);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x0001D588 File Offset: 0x0001B788
		public bool EnClientPhone
		{
			get
			{
				return OfflineData.Instance.Employee.Can(7, 0);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
		public string Fio
		{
			get
			{
				return string.Concat(new string[]
				{
					this.surname,
					" ",
					this.name,
					" ",
					this.patronymic
				});
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		public string IntPhoneAndFio
		{
			get
			{
				return string.Format("[{0}] {1} {2} {3}", new object[]
				{
					this.sip_user_id,
					this.surname,
					this.name,
					this.patronymic
				});
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0001D634 File Offset: 0x0001B834
		public bool EnableEdit
		{
			get
			{
				return this.id == 0;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0001D64C File Offset: 0x0001B84C
		public bool ReadOnlyLogin
		{
			get
			{
				return this.id > 0;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0001D664 File Offset: 0x0001B864
		public string FioShort
		{
			get
			{
				if (!string.IsNullOrEmpty(this.name))
				{
					goto IL_85;
				}
				string text = "";
				IL_2B:
				string text2 = text;
				int num;
				if (!string.IsNullOrEmpty(this.patronymic))
				{
					num = 667274780;
					goto IL_66;
				}
				string text3 = "";
				IL_45:
				string text4 = text3;
				num = 1847233405;
				IL_66:
				switch ((num ^ 1409942133) % 4)
				{
				case 1:
					text3 = this.patronymic.Substring(0, 1) + ".";
					goto IL_45;
				case 2:
					text = this.name.Substring(0, 1) + ".";
					goto IL_2B;
				case 3:
					IL_85:
					num = 653869303;
					goto IL_66;
				}
				return string.Concat(new string[]
				{
					this.surname,
					" ",
					text2,
					" ",
					text4
				});
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0001D72C File Offset: 0x0001B92C
		private void LoadStoreCategoriesState()
		{
			string categoriesState = Settings.Default.CategoriesState;
			if (!string.IsNullOrEmpty(categoriesState))
			{
				try
				{
					List<CategoryExpand> list = JsonConvert.DeserializeObject<List<CategoryExpand>>(categoriesState);
					this.StoreCategoriesState = new ObservableCollection<CategoryExpand>(list);
				}
				catch (Exception)
				{
					this.StoreCategoriesState = new ObservableCollection<CategoryExpand>();
				}
				return;
			}
			this.StoreCategoriesState = new ObservableCollection<CategoryExpand>();
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0001D78C File Offset: 0x0001B98C
		public void PutCategoriesStateToUserConfig()
		{
			if (this.StoreCategoriesState == null)
			{
				return;
			}
			string categoriesState = JsonConvert.SerializeObject(new List<CategoryExpand>(this.StoreCategoriesState));
			Settings.Default.CategoriesState = categoriesState;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		public bool IsStoreCategoryExpand(int categoryId)
		{
			if (this.StoreCategoriesState == null)
			{
				this.LoadStoreCategoriesState();
			}
			CategoryExpand categoryExpand = this.StoreCategoriesState.FirstOrDefault((CategoryExpand s) => s.CategoryId == categoryId);
			return categoryExpand != null && categoryExpand.IsExpand;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0001D80C File Offset: 0x0001BA0C
		public void UpdateCategoryState(int categoryId, bool isExpand)
		{
			if (this.StoreCategoriesState == null)
			{
				this.LoadStoreCategoriesState();
			}
			CategoryExpand categoryExpand = this.StoreCategoriesState.FirstOrDefault((CategoryExpand c) => c.CategoryId == categoryId);
			if (categoryExpand == null)
			{
				this.StoreCategoriesState.Add(new CategoryExpand
				{
					CategoryId = categoryId,
					IsExpand = isExpand
				});
				return;
			}
			categoryExpand.IsExpand = isExpand;
		}

		// Token: 0x04000706 RID: 1798
		[CompilerGenerated]
		private int <id>k__BackingField;

		// Token: 0x04000707 RID: 1799
		[CompilerGenerated]
		private int? <sip_user_id>k__BackingField;

		// Token: 0x04000708 RID: 1800
		[CompilerGenerated]
		private string <username>k__BackingField;

		// Token: 0x04000709 RID: 1801
		[CompilerGenerated]
		private string <name>k__BackingField;

		// Token: 0x0400070A RID: 1802
		[CompilerGenerated]
		private string <surname>k__BackingField;

		// Token: 0x0400070B RID: 1803
		[CompilerGenerated]
		private string <patronymic>k__BackingField;

		// Token: 0x0400070C RID: 1804
		[CompilerGenerated]
		private string <phone>k__BackingField;

		// Token: 0x0400070D RID: 1805
		[CompilerGenerated]
		private string <phone2>k__BackingField;

		// Token: 0x0400070E RID: 1806
		[CompilerGenerated]
		private int <phone_mask>k__BackingField;

		// Token: 0x0400070F RID: 1807
		[CompilerGenerated]
		private int <phone2_mask>k__BackingField;

		// Token: 0x04000710 RID: 1808
		[CompilerGenerated]
		private string <address>k__BackingField;

		// Token: 0x04000711 RID: 1809
		[CompilerGenerated]
		private string <passport_num>k__BackingField;

		// Token: 0x04000712 RID: 1810
		[CompilerGenerated]
		private DateTime? <passport_date>k__BackingField;

		// Token: 0x04000713 RID: 1811
		[CompilerGenerated]
		private string <passport_organ>k__BackingField;

		// Token: 0x04000714 RID: 1812
		[CompilerGenerated]
		private int? <state>k__BackingField;

		// Token: 0x04000715 RID: 1813
		[CompilerGenerated]
		private DateTime? <created>k__BackingField;

		// Token: 0x04000716 RID: 1814
		[CompilerGenerated]
		private int <office>k__BackingField;

		// Token: 0x04000717 RID: 1815
		[CompilerGenerated]
		private DateTime? <birthday>k__BackingField;

		// Token: 0x04000718 RID: 1816
		[CompilerGenerated]
		private DateTime? <last_login>k__BackingField;

		// Token: 0x04000719 RID: 1817
		[CompilerGenerated]
		private DateTime? <last_activity>k__BackingField;

		// Token: 0x0400071A RID: 1818
		[CompilerGenerated]
		private string <email>k__BackingField;

		// Token: 0x0400071B RID: 1819
		[CompilerGenerated]
		private int? <sex>k__BackingField;

		// Token: 0x0400071C RID: 1820
		[CompilerGenerated]
		private byte[] <photo>k__BackingField;

		// Token: 0x0400071D RID: 1821
		[CompilerGenerated]
		private int? <salary_rate>k__BackingField;

		// Token: 0x0400071E RID: 1822
		[CompilerGenerated]
		private int <pay_day>k__BackingField;

		// Token: 0x0400071F RID: 1823
		[CompilerGenerated]
		private int <pay_day_off>k__BackingField;

		// Token: 0x04000720 RID: 1824
		[CompilerGenerated]
		private int <pay_repair>k__BackingField;

		// Token: 0x04000721 RID: 1825
		[CompilerGenerated]
		private int <pay_sale>k__BackingField;

		// Token: 0x04000722 RID: 1826
		[CompilerGenerated]
		private int <pay_repair_q_sale>k__BackingField;

		// Token: 0x04000723 RID: 1827
		[CompilerGenerated]
		private int <pay_cartridge_refill>k__BackingField;

		// Token: 0x04000724 RID: 1828
		[CompilerGenerated]
		private string <color_label_ws>k__BackingField;

		// Token: 0x04000725 RID: 1829
		[CompilerGenerated]
		private int <workspace_mode>k__BackingField;

		// Token: 0x04000726 RID: 1830
		[CompilerGenerated]
		private bool <preview_before_print>k__BackingField;

		// Token: 0x04000727 RID: 1831
		[CompilerGenerated]
		private int <new_rep_doc_copies>k__BackingField;

		// Token: 0x04000728 RID: 1832
		[CompilerGenerated]
		private bool <auto_refresh_workspace>k__BackingField;

		// Token: 0x04000729 RID: 1833
		[CompilerGenerated]
		private int <refresh_time>k__BackingField;

		// Token: 0x0400072A RID: 1834
		[CompilerGenerated]
		private int <xls_c1>k__BackingField;

		// Token: 0x0400072B RID: 1835
		[CompilerGenerated]
		private int <xls_c2>k__BackingField;

		// Token: 0x0400072C RID: 1836
		[CompilerGenerated]
		private int <xls_c3>k__BackingField;

		// Token: 0x0400072D RID: 1837
		[CompilerGenerated]
		private int <xls_c4>k__BackingField;

		// Token: 0x0400072E RID: 1838
		[CompilerGenerated]
		private int <xls_c5>k__BackingField;

		// Token: 0x0400072F RID: 1839
		[CompilerGenerated]
		private int <xls_c6>k__BackingField;

		// Token: 0x04000730 RID: 1840
		[CompilerGenerated]
		private int <xls_c7>k__BackingField;

		// Token: 0x04000731 RID: 1841
		[CompilerGenerated]
		private int <xls_c8>k__BackingField;

		// Token: 0x04000732 RID: 1842
		[CompilerGenerated]
		private int <xls_c9>k__BackingField;

		// Token: 0x04000733 RID: 1843
		[CompilerGenerated]
		private int <xls_c10>k__BackingField;

		// Token: 0x04000734 RID: 1844
		[CompilerGenerated]
		private int <xls_c11>k__BackingField;

		// Token: 0x04000735 RID: 1845
		[CompilerGenerated]
		private int <xls_c12>k__BackingField;

		// Token: 0x04000736 RID: 1846
		[CompilerGenerated]
		private int <xls_c13>k__BackingField;

		// Token: 0x04000737 RID: 1847
		[CompilerGenerated]
		private int <xls_c14>k__BackingField;

		// Token: 0x04000738 RID: 1848
		[CompilerGenerated]
		private int <xls_c15>k__BackingField;

		// Token: 0x04000739 RID: 1849
		[CompilerGenerated]
		private bool <display_out>k__BackingField;

		// Token: 0x0400073A RID: 1850
		[CompilerGenerated]
		private bool <display_complete>k__BackingField;

		// Token: 0x0400073B RID: 1851
		[CompilerGenerated]
		private bool <is_bot>k__BackingField;

		// Token: 0x0400073C RID: 1852
		[CompilerGenerated]
		private bool <new_on_top>k__BackingField;

		// Token: 0x0400073D RID: 1853
		[CompilerGenerated]
		private string <issued_color>k__BackingField;

		// Token: 0x0400073E RID: 1854
		[CompilerGenerated]
		private string <fields_cfg>k__BackingField;

		// Token: 0x0400073F RID: 1855
		[CompilerGenerated]
		private int? <kkm_pass>k__BackingField;

		// Token: 0x04000740 RID: 1856
		[CompilerGenerated]
		private bool <prefer_regular>k__BackingField;

		// Token: 0x04000741 RID: 1857
		[CompilerGenerated]
		private int <fontsize>k__BackingField;

		// Token: 0x04000742 RID: 1858
		[CompilerGenerated]
		private int <rowheight>k__BackingField;

		// Token: 0x04000743 RID: 1859
		[CompilerGenerated]
		private string <animation>k__BackingField;

		// Token: 0x04000744 RID: 1860
		[CompilerGenerated]
		private int <pay_device_in>k__BackingField;

		// Token: 0x04000745 RID: 1861
		[CompilerGenerated]
		private int <pay_device_out>k__BackingField;

		// Token: 0x04000746 RID: 1862
		[CompilerGenerated]
		private bool <pay_4_sale_in_repair>k__BackingField;

		// Token: 0x04000747 RID: 1863
		[CompilerGenerated]
		private string <row_color>k__BackingField;

		// Token: 0x04000748 RID: 1864
		[CompilerGenerated]
		private bool <save_state_on_close>k__BackingField;

		// Token: 0x04000749 RID: 1865
		[CompilerGenerated]
		private bool <group_store_items>k__BackingField;

		// Token: 0x0400074A RID: 1866
		[CompilerGenerated]
		private bool <track_activity>k__BackingField;

		// Token: 0x0400074B RID: 1867
		[CompilerGenerated]
		private string <inn>k__BackingField;

		// Token: 0x0400074C RID: 1868
		[CompilerGenerated]
		private bool <inform_comment>k__BackingField;

		// Token: 0x0400074D RID: 1869
		[CompilerGenerated]
		private bool <inform_status>k__BackingField;

		// Token: 0x0400074E RID: 1870
		[CompilerGenerated]
		private int? <kkt>k__BackingField;

		// Token: 0x0400074F RID: 1871
		[CompilerGenerated]
		private int? <pinpad>k__BackingField;

		// Token: 0x04000750 RID: 1872
		[CompilerGenerated]
		private int <def_office>k__BackingField;

		// Token: 0x04000751 RID: 1873
		[CompilerGenerated]
		private int <def_store>k__BackingField;

		// Token: 0x04000752 RID: 1874
		[CompilerGenerated]
		private int <def_item_state>k__BackingField;

		// Token: 0x04000753 RID: 1875
		[CompilerGenerated]
		private int <def_employee>k__BackingField;

		// Token: 0x04000754 RID: 1876
		[CompilerGenerated]
		private int? <def_status>k__BackingField;

		// Token: 0x04000755 RID: 1877
		[CompilerGenerated]
		private int <def_ws_filter>k__BackingField;

		// Token: 0x04000756 RID: 1878
		[CompilerGenerated]
		private bool <card_on_call>k__BackingField;

		// Token: 0x04000757 RID: 1879
		[CompilerGenerated]
		private string <ge_highlight_color>k__BackingField;

		// Token: 0x04000758 RID: 1880
		[CompilerGenerated]
		private int <pay_repair_quick>k__BackingField;

		// Token: 0x04000759 RID: 1881
		[CompilerGenerated]
		private bool <advance_disable>k__BackingField;

		// Token: 0x0400075A RID: 1882
		[CompilerGenerated]
		private bool <salary_disable>k__BackingField;

		// Token: 0x0400075B RID: 1883
		[CompilerGenerated]
		private string <notes>k__BackingField;

		// Token: 0x0400075C RID: 1884
		[CompilerGenerated]
		private string <signature>k__BackingField;

		// Token: 0x0400075D RID: 1885
		[CompilerGenerated]
		private ICollection<additional_payments> <additional_payments>k__BackingField;

		// Token: 0x0400075E RID: 1886
		[CompilerGenerated]
		private ICollection<additional_payments> <additional_payments1>k__BackingField;

		// Token: 0x0400075F RID: 1887
		[CompilerGenerated]
		private ICollection<balance> <balance>k__BackingField;

		// Token: 0x04000760 RID: 1888
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders>k__BackingField;

		// Token: 0x04000761 RID: 1889
		[CompilerGenerated]
		private ICollection<cash_orders> <cash_orders1>k__BackingField;

		// Token: 0x04000762 RID: 1890
		[CompilerGenerated]
		private ICollection<clients> <clients>k__BackingField;

		// Token: 0x04000763 RID: 1891
		[CompilerGenerated]
		private ICollection<dealer_payments> <dealer_payments>k__BackingField;

		// Token: 0x04000764 RID: 1892
		[CompilerGenerated]
		private ICollection<docs> <docs>k__BackingField;

		// Token: 0x04000765 RID: 1893
		[CompilerGenerated]
		private ICollection<docs> <docs1>k__BackingField;

		// Token: 0x04000766 RID: 1894
		[CompilerGenerated]
		private ICollection<logs> <logs>k__BackingField;

		// Token: 0x04000767 RID: 1895
		[CompilerGenerated]
		private ICollection<media_info> <media_info>k__BackingField;

		// Token: 0x04000768 RID: 1896
		[CompilerGenerated]
		private ICollection<offices> <offices>k__BackingField;

		// Token: 0x04000769 RID: 1897
		[CompilerGenerated]
		private offices <offices1>k__BackingField;

		// Token: 0x0400076A RID: 1898
		[CompilerGenerated]
		private ICollection<roles_users> <roles_users>k__BackingField;

		// Token: 0x0400076B RID: 1899
		[CompilerGenerated]
		private ICollection<salary> <salary>k__BackingField;

		// Token: 0x0400076C RID: 1900
		[CompilerGenerated]
		private ICollection<salary> <salary1>k__BackingField;

		// Token: 0x0400076D RID: 1901
		[CompilerGenerated]
		private ICollection<store_int_reserve> <store_int_reserve>k__BackingField;

		// Token: 0x0400076E RID: 1902
		[CompilerGenerated]
		private ICollection<store_int_reserve> <store_int_reserve1>k__BackingField;

		// Token: 0x0400076F RID: 1903
		[CompilerGenerated]
		private ICollection<store_sales> <store_sales>k__BackingField;

		// Token: 0x04000770 RID: 1904
		[CompilerGenerated]
		private ICollection<workshop_parts> <workshop_parts>k__BackingField;

		// Token: 0x04000771 RID: 1905
		[CompilerGenerated]
		private ICollection<works> <works>k__BackingField;

		// Token: 0x04000772 RID: 1906
		[CompilerGenerated]
		private ICollection<workshop> <workshop>k__BackingField;

		// Token: 0x04000773 RID: 1907
		[CompilerGenerated]
		private ICollection<workshop> <workshop1>k__BackingField;

		// Token: 0x04000774 RID: 1908
		[CompilerGenerated]
		private ICollection<workshop> <workshop2>k__BackingField;

		// Token: 0x04000775 RID: 1909
		[CompilerGenerated]
		private ICollection<workshop> <workshop3>k__BackingField;

		// Token: 0x04000776 RID: 1910
		[CompilerGenerated]
		private ICollection<queue_members> <queue_members>k__BackingField;

		// Token: 0x04000777 RID: 1911
		[CompilerGenerated]
		private ICollection<tasks> <tasks1>k__BackingField;

		// Token: 0x04000778 RID: 1912
		[CompilerGenerated]
		private ICollection<payment_type_users> <payment_type_users>k__BackingField;

		// Token: 0x04000779 RID: 1913
		[CompilerGenerated]
		private ICollection<companies> <companies>k__BackingField;

		// Token: 0x0400077A RID: 1914
		[CompilerGenerated]
		private ICollection<companies> <companies1>k__BackingField;

		// Token: 0x0400077B RID: 1915
		[CompilerGenerated]
		private ICollection<parts_request> <parts_request>k__BackingField;

		// Token: 0x0400077C RID: 1916
		[CompilerGenerated]
		private ICollection<parts_request_employees> <parts_request_employees>k__BackingField;

		// Token: 0x0400077D RID: 1917
		[CompilerGenerated]
		private ICollection<task_employees> <task_employees>k__BackingField;

		// Token: 0x0400077E RID: 1918
		[CompilerGenerated]
		private ICollection<comments> <comments>k__BackingField;

		// Token: 0x0400077F RID: 1919
		[CompilerGenerated]
		private ICollection<out_sms> <out_sms>k__BackingField;

		// Token: 0x04000780 RID: 1920
		[CompilerGenerated]
		private ICollection<invoice> <invoice>k__BackingField;

		// Token: 0x04000781 RID: 1921
		[CompilerGenerated]
		private ICollection<vat_invoice> <vat_invoice>k__BackingField;

		// Token: 0x04000782 RID: 1922
		[CompilerGenerated]
		private ICollection<p_lists> <p_lists>k__BackingField;

		// Token: 0x04000783 RID: 1923
		[CompilerGenerated]
		private ICollection<w_lists> <w_lists>k__BackingField;

		// Token: 0x04000784 RID: 1924
		[CompilerGenerated]
		private ICollection<cartridge_cards> <cartridge_cards>k__BackingField;

		// Token: 0x04000785 RID: 1925
		[CompilerGenerated]
		private kkt <kkt1>k__BackingField;

		// Token: 0x04000786 RID: 1926
		[CompilerGenerated]
		private pinpad <pinpad1>k__BackingField;

		// Token: 0x04000787 RID: 1927
		[CompilerGenerated]
		private ICollection<kkt_employee> <kkt_employee>k__BackingField;

		// Token: 0x04000788 RID: 1928
		[CompilerGenerated]
		private ICollection<notifications> <notifications>k__BackingField;

		// Token: 0x04000789 RID: 1929
		[CompilerGenerated]
		private ICollection<users_activity> <users_activity>k__BackingField;

		// Token: 0x0400078A RID: 1930
		[CompilerGenerated]
		private ICollection<workshop_issued> <workshop_issued>k__BackingField;

		// Token: 0x0400078B RID: 1931
		[CompilerGenerated]
		private ICollection<repair_status_logs> <repair_status_logs>k__BackingField;

		// Token: 0x0400078C RID: 1932
		[CompilerGenerated]
		private ICollection<repair_status_logs> <repair_status_logs1>k__BackingField;

		// Token: 0x0400078D RID: 1933
		[CompilerGenerated]
		private ICollection<repair_status_logs> <repair_status_logs2>k__BackingField;

		// Token: 0x0400078E RID: 1934
		[CompilerGenerated]
		private ICollection<SalaryRate> <SalaryRates>k__BackingField;

		// Token: 0x0400078F RID: 1935
		public ObservableCollection<CategoryExpand> StoreCategoriesState;

		// Token: 0x0200007F RID: 127
		[CompilerGenerated]
		private sealed class <>c__DisplayClass559_0
		{
			// Token: 0x0600100B RID: 4107 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass559_0()
			{
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x0001D87C File Offset: 0x0001BA7C
			internal bool <SetFieldVisibility>b__0(RepairFieldsVisibility f)
			{
				return f.Name == this.fieldName;
			}

			// Token: 0x04000790 RID: 1936
			public string fieldName;
		}

		// Token: 0x02000080 RID: 128
		[CompilerGenerated]
		private sealed class <>c__DisplayClass560_0
		{
			// Token: 0x0600100D RID: 4109 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass560_0()
			{
			}

			// Token: 0x0600100E RID: 4110 RVA: 0x0001D89C File Offset: 0x0001BA9C
			internal bool <IsFieldVisible>b__0(RepairFieldsVisibility f)
			{
				return f.Name == this.fieldName;
			}

			// Token: 0x04000791 RID: 1937
			public string fieldName;
		}

		// Token: 0x02000081 RID: 129
		[CompilerGenerated]
		private sealed class <>c__DisplayClass578_0
		{
			// Token: 0x0600100F RID: 4111 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass578_0()
			{
			}

			// Token: 0x06001010 RID: 4112 RVA: 0x0001D8BC File Offset: 0x0001BABC
			internal bool <IsStoreCategoryExpand>b__0(CategoryExpand s)
			{
				return s.CategoryId == this.categoryId;
			}

			// Token: 0x04000792 RID: 1938
			public int categoryId;
		}

		// Token: 0x02000082 RID: 130
		[CompilerGenerated]
		private sealed class <>c__DisplayClass579_0
		{
			// Token: 0x06001011 RID: 4113 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass579_0()
			{
			}

			// Token: 0x06001012 RID: 4114 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
			internal bool <UpdateCategoryState>b__0(CategoryExpand c)
			{
				return c.CategoryId == this.categoryId;
			}

			// Token: 0x04000793 RID: 1939
			public int categoryId;
		}
	}
}
