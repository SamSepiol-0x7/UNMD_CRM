using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ASC.Common.Interfaces;
using ASC.Extensions.KKT;
using ASC.Models;

namespace ASC.Objects.Converters
{
	// Token: 0x0200092F RID: 2351
	public static class EmployeeConverter
	{
		// Token: 0x0600484E RID: 18510 RVA: 0x0011BA60 File Offset: 0x00119C60
		public static Employee User2EmployeeLite(this users u)
		{
			if (u == null)
			{
				return null;
			}
			return new Employee
			{
				Id = u.id,
				Login = u.username,
				OfficeId = u.office,
				FirstName = u.name,
				LastName = u.surname,
				Patronymic = u.patronymic,
				State = u.state.GetValueOrDefault(),
				TrackActivity = u.track_activity,
				DisplayCustomerOnCall = u.card_on_call,
				Inn = u.inn,
				KktPassword = u.kkm_pass,
				GroupByArticul = u.group_store_items,
				PreviewReports = u.preview_before_print,
				WorkshopDefaultOffice = u.def_office,
				WorkshopDefaultStatus = u.def_status,
				WorkshopDefDevType = u.def_ws_filter,
				WorkshopDefaultEmployee = u.def_employee,
				StoreDefault = u.def_store,
				StoreDefaultItemState = u.def_item_state,
				LastActivity = u.last_activity,
				LastLogin = u.last_login,
				Tel = u.sip_user_id,
				UiSettings = new UiSettings
				{
					FontSize = u.fontsize,
					RowHeight = u.rowheight,
					RowColor = u.row_color,
					GeHighlightColor = u.ge_highlight_color,
					IssuedRowColor = u.issued_color
				},
				Signature = u.signature
			};
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x0011BBDC File Offset: 0x00119DDC
		public static Employee User2Employee(this users u)
		{
			if (u == null)
			{
				return null;
			}
			Employee employee = u.User2EmployeeLite();
			if (u.offices1 != null)
			{
				employee.Office = u.offices1.ToOffice();
			}
			if (u.kkt1 != null)
			{
				int protocol = u.kkt1.protocol;
				if (protocol == 0)
				{
					employee.Kkt = new ShtrihM
					{
						Name = u.kkt1.name,
						OfficeId = u.kkt1.office,
						OperatorPassword = (u.kkm_pass ?? 30),
						TaxType = u.kkt1.tax_type,
						Tax = u.kkt1.tax,
						RSimple = u.kkt1.r_simple,
						SSimple = u.kkt1.s_simple,
						RTpl = u.kkt1.r_tpl,
						STpl = u.kkt1.s_tpl,
						Footer = u.kkt1.footer,
						OrderPaymentItemSign = u.kkt1.order_payment_item_sign,
						ProductPaymentItemSign = u.kkt1.product_payment_item_sign
					};
				}
				else if (protocol == 1)
				{
					employee.Kkt = new AtolKkt
					{
						Name = u.kkt1.name,
						OfficeId = u.kkt1.office,
						Ip = u.kkt1.ip,
						Port = u.kkt1.port,
						TaxType = u.kkt1.tax_type,
						Tax = u.kkt1.tax,
						RSimple = u.kkt1.r_simple,
						SSimple = u.kkt1.s_simple,
						RTpl = u.kkt1.r_tpl,
						STpl = u.kkt1.s_tpl,
						Footer = u.kkt1.footer,
						OperatorFio = (string.IsNullOrEmpty(u.kkt1.@operator) ? u.FioShort : u.kkt1.@operator),
						OperatorInn = (string.IsNullOrEmpty(u.kkt1.operator_inn) ? u.inn : u.kkt1.operator_inn),
						OrderPaymentItemSign = u.kkt1.order_payment_item_sign,
						ProductPaymentItemSign = u.kkt1.product_payment_item_sign
					};
					employee.Kkt.InitDriver();
				}
			}
			if (u.pinpad1 != null)
			{
				employee.Pinpad = new Pinpad
				{
					PinpadId = u.pinpad1.id,
					Name = u.pinpad1.name,
					OfficeId = u.pinpad1.office,
					Kkt = u.pinpad1.kkt,
					Fee = u.pinpad1.fee,
					FeeMode = u.pinpad1.fee_mode
				};
			}
			if (u.roles_users != null)
			{
				employee.Roles = (from i in u.roles_users
				select i.role_id).Distinct<int>().ToList<int>();
			}
			return employee;
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x0011BF24 File Offset: 0x0011A124
		public static Expression<Func<users, Employee>> User2EmployeeSelector()
		{
			ParameterExpression parameterExpression;
			return Expression.Lambda<Func<users, Employee>>(Expression.MemberInit(Expression.New(typeof(Employee)), new MemberBinding[]
			{
				Expression.Bind(methodof(Employee.set_Id(int)), Expression.Property(parameterExpression, methodof(users.get_id()))),
				Expression.Bind(methodof(Employee.set_Login(string)), Expression.Property(parameterExpression, methodof(users.get_username()))),
				Expression.Bind(methodof(Employee.set_OfficeId(int)), Expression.Property(parameterExpression, methodof(users.get_office()))),
				Expression.Bind(methodof(Employee.set_FirstName(string)), Expression.Property(parameterExpression, methodof(users.get_name()))),
				Expression.Bind(methodof(Employee.set_LastName(string)), Expression.Property(parameterExpression, methodof(users.get_surname()))),
				Expression.Bind(methodof(Employee.set_Patronymic(string)), Expression.Property(parameterExpression, methodof(users.get_patronymic()))),
				Expression.Bind(methodof(Employee.set_State(int)), Expression.Coalesce(Expression.Property(parameterExpression, methodof(users.get_state())), Expression.Constant(0, typeof(int)))),
				Expression.Bind(methodof(Employee.set_TrackActivity(bool)), Expression.Property(parameterExpression, methodof(users.get_track_activity()))),
				Expression.Bind(methodof(Employee.set_DisplayCustomerOnCall(bool)), Expression.Property(parameterExpression, methodof(users.get_card_on_call()))),
				Expression.Bind(methodof(Employee.set_PreviewReports(bool)), Expression.Property(parameterExpression, methodof(users.get_preview_before_print()))),
				Expression.Bind(methodof(Employee.set_LastActivity(DateTime?)), Expression.Property(parameterExpression, methodof(users.get_last_activity()))),
				Expression.Bind(methodof(Employee.set_LastLogin(DateTime?)), Expression.Property(parameterExpression, methodof(users.get_last_login()))),
				Expression.Bind(methodof(Employee.set_Tel(int?)), Expression.Property(parameterExpression, methodof(users.get_sip_user_id()))),
				Expression.Bind(methodof(Employee.set_Inn(string)), Expression.Property(parameterExpression, methodof(users.get_inn()))),
				Expression.Bind(methodof(Employee.set_KktPassword(int?)), Expression.Property(parameterExpression, methodof(users.get_kkm_pass()))),
				Expression.Bind(methodof(Employee.set_UiSettings(IUISettings)), Expression.MemberInit(Expression.New(typeof(UiSettings)), new MemberBinding[]
				{
					Expression.Bind(methodof(UiSettings.set_FontSize(int)), Expression.Property(parameterExpression, methodof(users.get_fontsize()))),
					Expression.Bind(methodof(UiSettings.set_RowHeight(int)), Expression.Property(parameterExpression, methodof(users.get_rowheight()))),
					Expression.Bind(methodof(UiSettings.set_RowColor(string)), Expression.Property(parameterExpression, methodof(users.get_row_color()))),
					Expression.Bind(methodof(UiSettings.set_GeHighlightColor(string)), Expression.Property(parameterExpression, methodof(users.get_ge_highlight_color()))),
					Expression.Bind(methodof(UiSettings.set_IssuedRowColor(string)), Expression.Property(parameterExpression, methodof(users.get_issued_color())))
				}))
			}), new ParameterExpression[]
			{
				parameterExpression
			});
		}

		// Token: 0x02000930 RID: 2352
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004851 RID: 18513 RVA: 0x0011C334 File Offset: 0x0011A534
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004852 RID: 18514 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004853 RID: 18515 RVA: 0x0011C34C File Offset: 0x0011A54C
			internal int <User2Employee>b__1_0(roles_users i)
			{
				return i.role_id;
			}

			// Token: 0x04002E25 RID: 11813
			public static readonly EmployeeConverter.<>c <>9 = new EmployeeConverter.<>c();

			// Token: 0x04002E26 RID: 11814
			public static Func<roles_users, int> <>9__1_0;
		}
	}
}
