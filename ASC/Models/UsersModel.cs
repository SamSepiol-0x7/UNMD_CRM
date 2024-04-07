using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Extensions;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.SimpleClasses;

namespace ASC.Models
{
	// Token: 0x02000A50 RID: 2640
	public class UsersModel : GenericModel
	{
		// Token: 0x06004CF8 RID: 19704 RVA: 0x0014105C File Offset: 0x0013F25C
		public static users DefaultUser()
		{
			Localization localization = new Localization("UTC");
			return new users
			{
				row_color = "#D8008EA4",
				ge_highlight_color = "#FFFFDD70",
				color_label_ws = "#FF000000",
				preview_before_print = true,
				state = new int?(1),
				created = new DateTime?(localization.Now),
				pay_cartridge_refill = 0,
				pay_day_off = 0,
				pay_repair = 0,
				pay_repair_q_sale = 0,
				pay_sale = 0,
				fields_cfg = "[{\"Name\":\"ws_vis_id\",\"Visible\":true},{\"Name\":\"ws_vis_device\",\"Visible\":true},{\"Name\":\"ws_vis_sn\",\"Visible\":true},{\"Name\":\"ws_vis_fault\",\"Visible\":true},{\"Name\":\"ws_vis_master\",\"Visible\":true},{\"Name\":\"ws_vis_manager\",\"Visible\":false},{\"Name\":\"ws_vis_state\",\"Visible\":true},{\"Name\":\"ws_vis_summ\",\"Visible\":true},{\"Name\":\"ws_vis_cl\",\"Visible\":false},{\"Name\":\"ws_vis_cl_phone\",\"Visible\":false},{\"Name\":\"ws_vis_box\",\"Visible\":false},{\"Name\":\"ws_vis_date\",\"Visible\":true}]",
				refresh_time = 10,
				issued_color = "#00000000",
				prefer_regular = true,
				animation = "None",
				group_store_items = false,
				fontsize = 13,
				rowheight = 30,
				track_activity = true,
				inform_comment = true,
				inform_status = true,
				phone_mask = 1,
				phone2_mask = 1,
				def_ws_filter = 2
			};
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x00141154 File Offset: 0x0013F354
		[Obsolete("use EmployeeService.GetEmployeesByRole(SystemRoles role) instead")]
		public static IEnumerable<UserMaster> LoadUsers(IEnumerable<int> roleIds)
		{
			IEnumerable<UserMaster> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					ParameterExpression parameterExpression;
					ParameterExpression parameterExpression2;
					result = (from u in (from u in auseceEntities.users.Join(auseceEntities.roles_users, (users ru) => ru.id, (roles_users u) => u.user_id, Expression.Lambda<Func<users, roles_users, UserMaster>>(Expression.MemberInit(Expression.New(typeof(UserMaster)), new MemberBinding[]
					{
						Expression.Bind(methodof(UserMaster.set_RoleId(int)), Expression.Property(parameterExpression2, methodof(roles_users.get_role_id()))),
						Expression.Bind(methodof(UserMaster.set_Uid(int)), Expression.Property(parameterExpression, methodof(users.get_id()))),
						Expression.Bind(methodof(UserMaster.set_Username(string)), Expression.Property(parameterExpression, methodof(users.get_username()))),
						Expression.Bind(methodof(UserMaster.set_Name(string)), Expression.Property(parameterExpression, methodof(users.get_name()))),
						Expression.Bind(methodof(UserMaster.set_Surname(string)), Expression.Property(parameterExpression, methodof(users.get_surname()))),
						Expression.Bind(methodof(UserMaster.set_Patronymic(string)), Expression.Property(parameterExpression, methodof(users.get_patronymic())))
					}), new ParameterExpression[]
					{
						parameterExpression,
						parameterExpression2
					}))
					where roleIds.Contains(u.RoleId)
					select u).ToList<UserMaster>()
					orderby u.Fio
					select u).DistinctBy((UserMaster u) => u.Uid);
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = new List<UserMaster>();
			}
			return result;
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x00141484 File Offset: 0x0013F684
		public static Task<List<users>> LoadUsers(bool includeAll = false)
		{
			UsersModel.<LoadUsers>d__2 <LoadUsers>d__;
			<LoadUsers>d__.<>t__builder = AsyncTaskMethodBuilder<List<users>>.Create();
			<LoadUsers>d__.includeAll = includeAll;
			<LoadUsers>d__.<>1__state = -1;
			<LoadUsers>d__.<>t__builder.Start<UsersModel.<LoadUsers>d__2>(ref <LoadUsers>d__);
			return <LoadUsers>d__.<>t__builder.Task;
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x001414C8 File Offset: 0x0013F6C8
		public static Task<List<Employee>> GetEmployees()
		{
			UsersModel.<GetEmployees>d__3 <GetEmployees>d__;
			<GetEmployees>d__.<>t__builder = AsyncTaskMethodBuilder<List<Employee>>.Create();
			<GetEmployees>d__.<>1__state = -1;
			<GetEmployees>d__.<>t__builder.Start<UsersModel.<GetEmployees>d__3>(ref <GetEmployees>d__);
			return <GetEmployees>d__.<>t__builder.Task;
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x00141504 File Offset: 0x0013F704
		private IEnumerable<Employee> GetEmployees(int officeId, bool includeAchive = false)
		{
			IEnumerable<Employee> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(false))
				{
					IQueryable<users> source = from r in auseceEntities.users
					where !r.is_bot
					select r;
					if (officeId > 0)
					{
						source = from r in source
						where r.office == officeId
						select r;
					}
					if (!includeAchive)
					{
						source = from r in source
						where r.state == (int?)1
						select r;
					}
					result = source.Select(EmployeeConverter.User2EmployeeSelector()).ToList<Employee>();
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = new List<Employee>();
			}
			return result;
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x001416BC File Offset: 0x0013F8BC
		public static IEnumerable<int> LoadRolesByPermission(int permissionId)
		{
			IEnumerable<int> result;
			using (auseceEntities auseceEntities = new auseceEntities(true))
			{
				try
				{
					result = (from p in auseceEntities.permissions_roles
					where p.permission_id == permissionId
					select p.role_id).ToList<int>();
				}
				catch (Exception exception)
				{
					GenericModel.Log.Error(exception, "Load users by permission error ");
					result = new List<int>();
				}
			}
			return result;
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x001417D0 File Offset: 0x0013F9D0
		public static IEnumerable<UserMaster> LoadMasters(bool withAll = false)
		{
			List<UserMaster> list = new List<UserMaster>(UsersModel.LoadUsers(new List<int>
			{
				2
			}));
			if (withAll)
			{
				list.Insert(0, new UserMaster
				{
					Surname = Lang.t("AllMasters"),
					Uid = 0
				});
			}
			return list;
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x0014181C File Offset: 0x0013FA1C
		public static List<UserMaster> LoadManagers(bool withAll = false)
		{
			List<UserMaster> list = new List<UserMaster>(UsersModel.LoadUsers(new List<int>
			{
				3
			}));
			if (withAll)
			{
				list.Insert(0, new UserMaster
				{
					Surname = Lang.t("AllManagers"),
					Uid = 0
				});
			}
			return list;
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00141868 File Offset: 0x0013FA68
		public static IEnumerable<UserMaster> LoadAdmins()
		{
			return new List<UserMaster>(UsersModel.LoadUsers(UsersModel.LoadRolesByPermission(1)));
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00141888 File Offset: 0x0013FA88
		public Task<List<users>> LoadPartRequestManagers()
		{
			UsersModel.<LoadPartRequestManagers>d__9 <LoadPartRequestManagers>d__;
			<LoadPartRequestManagers>d__.<>t__builder = AsyncTaskMethodBuilder<List<users>>.Create();
			<LoadPartRequestManagers>d__.<>1__state = -1;
			<LoadPartRequestManagers>d__.<>t__builder.Start<UsersModel.<LoadPartRequestManagers>d__9>(ref <LoadPartRequestManagers>d__);
			return <LoadPartRequestManagers>d__.<>t__builder.Task;
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x001418C4 File Offset: 0x0013FAC4
		public static IEnumerable<UserMaster> LoadMasterManagers()
		{
			List<UserMaster> list = new List<UserMaster>();
			list.AddRange(UsersModel.LoadMasters(false));
			list.AddRange(UsersModel.LoadManagers(false));
			List<UserMaster> list2 = (from u in list
			orderby u.Fio
			select u).DistinctBy((UserMaster u) => u.Uid).ToList<UserMaster>();
			list2.Insert(0, new UserMaster
			{
				Surname = Lang.t("AllEmployees"),
				Uid = 0
			});
			return list2;
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00141960 File Offset: 0x0013FB60
		public static Task<List<string>> LoadUserRoles()
		{
			UsersModel.<LoadUserRoles>d__11 <LoadUserRoles>d__;
			<LoadUserRoles>d__.<>t__builder = AsyncTaskMethodBuilder<List<string>>.Create();
			<LoadUserRoles>d__.<>1__state = -1;
			<LoadUserRoles>d__.<>t__builder.Start<UsersModel.<LoadUserRoles>d__11>(ref <LoadUserRoles>d__);
			return <LoadUserRoles>d__.<>t__builder.Task;
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x0014199C File Offset: 0x0013FB9C
		public Task<List<roles>> LoadRoles()
		{
			UsersModel.<LoadRoles>d__12 <LoadRoles>d__;
			<LoadRoles>d__.<>t__builder = AsyncTaskMethodBuilder<List<roles>>.Create();
			<LoadRoles>d__.<>1__state = -1;
			<LoadRoles>d__.<>t__builder.Start<UsersModel.<LoadRoles>d__12>(ref <LoadRoles>d__);
			return <LoadRoles>d__.<>t__builder.Task;
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x001419D8 File Offset: 0x0013FBD8
		public static Task<List<int>> LoadUserRoleIds(int userId)
		{
			UsersModel.<LoadUserRoleIds>d__13 <LoadUserRoleIds>d__;
			<LoadUserRoleIds>d__.<>t__builder = AsyncTaskMethodBuilder<List<int>>.Create();
			<LoadUserRoleIds>d__.userId = userId;
			<LoadUserRoleIds>d__.<>1__state = -1;
			<LoadUserRoleIds>d__.<>t__builder.Start<UsersModel.<LoadUserRoleIds>d__13>(ref <LoadUserRoleIds>d__);
			return <LoadUserRoleIds>d__.<>t__builder.Task;
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00141A1C File Offset: 0x0013FC1C
		public static Task<List<int>> GetEmployeeKkt(int userId)
		{
			UsersModel.<GetEmployeeKkt>d__14 <GetEmployeeKkt>d__;
			<GetEmployeeKkt>d__.<>t__builder = AsyncTaskMethodBuilder<List<int>>.Create();
			<GetEmployeeKkt>d__.userId = userId;
			<GetEmployeeKkt>d__.<>1__state = -1;
			<GetEmployeeKkt>d__.<>t__builder.Start<UsersModel.<GetEmployeeKkt>d__14>(ref <GetEmployeeKkt>d__);
			return <GetEmployeeKkt>d__.<>t__builder.Task;
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00141A60 File Offset: 0x0013FC60
		public static void ChangePassword(string username, string password)
		{
			string text = Generators.HashPassword(password);
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Database.ExecuteSqlCommand("update mysql.user set password=password(@p0) where user=@p1; FLUSH PRIVILEGES;", new object[]
					{
						text,
						username
					});
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Change user password fail");
			}
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00141AD8 File Offset: 0x0013FCD8
		private static bool DbUserExist(string login)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = !string.IsNullOrEmpty(auseceEntities.Database.SqlQuery<string>("SELECT LOWER(user) AS user FROM mysql.user WHERE user = @p0", new object[]
					{
						login
					}).FirstOrDefault<string>());
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x00141B54 File Offset: 0x0013FD54
		public void CreateDbUser(auseceEntities ctx, users user, string password)
		{
			string database = ctx.Database.Connection.Database;
			string text = user.is_bot ? password : Generators.HashPassword(password);
			try
			{
				ctx.add_User(user.username, text, database);
			}
			catch (Exception exception)
			{
				if (!UsersModel.DbUserExist(user.username))
				{
					GenericModel.Log.Error(exception, "Create DB user error: ");
					throw;
				}
				UsersModel.ChangePassword(user.username, text);
			}
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x00141BD4 File Offset: 0x0013FDD4
		public Task CreateUser(users user, string password, IEnumerable<int> roles, IEnumerable<kkt> kkts)
		{
			UsersModel.<CreateUser>d__18 <CreateUser>d__;
			<CreateUser>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateUser>d__.<>4__this = this;
			<CreateUser>d__.user = user;
			<CreateUser>d__.password = password;
			<CreateUser>d__.roles = roles;
			<CreateUser>d__.kkts = kkts;
			<CreateUser>d__.<>1__state = -1;
			<CreateUser>d__.<>t__builder.Start<UsersModel.<CreateUser>d__18>(ref <CreateUser>d__);
			return <CreateUser>d__.<>t__builder.Task;
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00141C38 File Offset: 0x0013FE38
		private static Task CreateSalaryRate(auseceEntities ctx, HistoryV2 history, int userId, int value)
		{
			UsersModel.<CreateSalaryRate>d__19 <CreateSalaryRate>d__;
			<CreateSalaryRate>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CreateSalaryRate>d__.ctx = ctx;
			<CreateSalaryRate>d__.history = history;
			<CreateSalaryRate>d__.userId = userId;
			<CreateSalaryRate>d__.value = value;
			<CreateSalaryRate>d__.<>1__state = -1;
			<CreateSalaryRate>d__.<>t__builder.Start<UsersModel.<CreateSalaryRate>d__19>(ref <CreateSalaryRate>d__);
			return <CreateSalaryRate>d__.<>t__builder.Task;
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00141C94 File Offset: 0x0013FE94
		public Task SetUserRoles(auseceEntities ctx, int userId, IEnumerable<int> roles)
		{
			UsersModel.<SetUserRoles>d__20 <SetUserRoles>d__;
			<SetUserRoles>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetUserRoles>d__.ctx = ctx;
			<SetUserRoles>d__.userId = userId;
			<SetUserRoles>d__.roles = roles;
			<SetUserRoles>d__.<>1__state = -1;
			<SetUserRoles>d__.<>t__builder.Start<UsersModel.<SetUserRoles>d__20>(ref <SetUserRoles>d__);
			return <SetUserRoles>d__.<>t__builder.Task;
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00141CE8 File Offset: 0x0013FEE8
		public Task RemoveAllRoles(auseceEntities ctx, int userId)
		{
			UsersModel.<RemoveAllRoles>d__21 <RemoveAllRoles>d__;
			<RemoveAllRoles>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RemoveAllRoles>d__.ctx = ctx;
			<RemoveAllRoles>d__.userId = userId;
			<RemoveAllRoles>d__.<>1__state = -1;
			<RemoveAllRoles>d__.<>t__builder.Start<UsersModel.<RemoveAllRoles>d__21>(ref <RemoveAllRoles>d__);
			return <RemoveAllRoles>d__.<>t__builder.Task;
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00141D34 File Offset: 0x0013FF34
		public static int CountActiveEmployees()
		{
			int result;
			using (GenericRepository<users> genericRepository = new GenericRepository<users>())
			{
				result = genericRepository.Count((users u) => u.state == (int?)1);
			}
			return result;
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00141DD0 File Offset: 0x0013FFD0
		public users GetEmployee(int userId)
		{
			users firstOrDefault;
			using (GenericRepository<users> genericRepository = new GenericRepository<users>())
			{
				firstOrDefault = genericRepository.GetFirstOrDefault((users u) => u.id == userId, "");
			}
			return firstOrDefault;
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00141E78 File Offset: 0x00140078
		public static Employee GetEmployeeForReport(int employeeId)
		{
			Employee result;
			using (GenericRepository<users> genericRepository = new GenericRepository<users>())
			{
				genericRepository.AsNoTracking();
				result = genericRepository.GetFirstOrDefault((users e) => e.id == employeeId, "").User2Employee();
			}
			return result;
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00141F2C File Offset: 0x0014012C
		public static void ReloadCurrentUser()
		{
			using (GenericRepository<users> genericRepository = new GenericRepository<users>())
			{
				users firstOrDefault = genericRepository.GetFirstOrDefault((users u) => u.id == Auth.User.id, "offices1,offices1.companies,kkt1,roles_users");
				if (firstOrDefault != null)
				{
					Auth.User = firstOrDefault;
					OfflineData.Instance.SetEmployee(firstOrDefault.User2Employee());
				}
			}
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00141FE8 File Offset: 0x001401E8
		public static users GetEmployee(string username)
		{
			users firstOrDefault;
			using (GenericRepository<users> genericRepository = new GenericRepository<users>())
			{
				firstOrDefault = genericRepository.GetFirstOrDefault((users u) => u.username == username && u.state == (int?)1, "offices1,offices1.companies,kkt1,pinpad1");
			}
			return firstOrDefault;
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x001420D4 File Offset: 0x001402D4
		public static bool SaveUserSettings(users user)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.users.Attach(user);
					auseceEntities.Entry<users>(user).State = EntityState.Modified;
					auseceEntities.SaveChanges();
				}
				return true;
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Save user settings fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x0014214C File Offset: 0x0014034C
		public void DeleteUserFromServer(string username)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.delete_User(username);
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error("User delete error: " + ex.Message);
			}
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x001421B0 File Offset: 0x001403B0
		public Task UpdateUser(users user, List<int> roles, string password, string newLogin, List<kkt> kkts)
		{
			UsersModel.<UpdateUser>d__29 <UpdateUser>d__;
			<UpdateUser>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateUser>d__.<>4__this = this;
			<UpdateUser>d__.user = user;
			<UpdateUser>d__.roles = roles;
			<UpdateUser>d__.password = password;
			<UpdateUser>d__.newLogin = newLogin;
			<UpdateUser>d__.kkts = kkts;
			<UpdateUser>d__.<>1__state = -1;
			<UpdateUser>d__.<>t__builder.Start<UsersModel.<UpdateUser>d__29>(ref <UpdateUser>d__);
			return <UpdateUser>d__.<>t__builder.Task;
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00142220 File Offset: 0x00140420
		public Task ChangeLogin(auseceEntities ctx, string oldLogin, string newLogin)
		{
			UsersModel.<ChangeLogin>d__30 <ChangeLogin>d__;
			<ChangeLogin>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ChangeLogin>d__.ctx = ctx;
			<ChangeLogin>d__.oldLogin = oldLogin;
			<ChangeLogin>d__.newLogin = newLogin;
			<ChangeLogin>d__.<>1__state = -1;
			<ChangeLogin>d__.<>t__builder.Start<UsersModel.<ChangeLogin>d__30>(ref <ChangeLogin>d__);
			return <ChangeLogin>d__.<>t__builder.Task;
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x00142274 File Offset: 0x00140474
		public static List<int> UsersByPermission(int permission, int officeId = 0)
		{
			List<int> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<int> roles = (from r in auseceEntities.permissions_roles
					where r.permission_id == permission
					select r.role_id).ToList<int>();
					IQueryable<roles_users> source = (from r in auseceEntities.roles_users
					where roles.Contains(r.role_id)
					select r).AsQueryable<roles_users>();
					if (officeId != 0)
					{
						source = from r in source
						where r.users.office == officeId
						select r;
					}
					result = (from r in source
					select r.user_id).ToList<int>();
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = new List<int>();
			}
			return result;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x00142514 File Offset: 0x00140714
		private List<UsersActivity> GetEmployeesActivity(IPeriod period, IEnumerable<IEmployee> employees)
		{
			DateTime from = period.From.Date;
			DateTime to = period.To.Date.AddDays(1.0).AddSeconds(-1.0);
			List<int> ids = (from e in employees
			select e.Id).ToList<int>();
			List<UsersActivity> result;
			using (auseceEntities auseceEntities = new auseceEntities(false))
			{
				result = (from a in auseceEntities.users_activity.AsNoTracking()
				where ids.Contains(a.user_id) && a.datetime_ >= @from && a.datetime_ <= to
				select a).Select(UserActivityConverter.ToDtoSelector()).ToList<UsersActivity>();
			}
			return result;
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x0014270C File Offset: 0x0014090C
		public List<EmployeeActivityReport> GetEmployeeActivityReport(IPeriod period, int officeId, bool includeAchive)
		{
			List<EmployeeActivityReport> list = new List<EmployeeActivityReport>();
			IEnumerable<Employee> employees = this.GetEmployees(officeId, includeAchive);
			List<UsersActivity> employeesActivity = this.GetEmployeesActivity(period, employees);
			DateTime serverUtcTime = Localization.GetServerUtcTime();
			using (IEnumerator<Employee> enumerator = employees.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Employee employee = enumerator.Current;
					EmployeeActivityReport employeeActivityReport = new EmployeeActivityReport
					{
						Employee = employee
					};
					employeeActivityReport.SetActivity(period, (from e in employeesActivity
					where e.EmployeeId == employee.Id
					select e).ToList<UsersActivity>());
					employeeActivityReport.SetIsOnline(serverUtcTime);
					list.Add(employeeActivityReport);
				}
			}
			return list;
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x0005E808 File Offset: 0x0005CA08
		public UsersModel()
		{
		}

		// Token: 0x02000A51 RID: 2641
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06004D1B RID: 19739 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x0400325C RID: 12892
			public IEnumerable<int> roleIds;
		}

		// Token: 0x02000A52 RID: 2642
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004D1C RID: 19740 RVA: 0x001427C4 File Offset: 0x001409C4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004D1D RID: 19741 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004D1E RID: 19742 RVA: 0x001427DC File Offset: 0x001409DC
			internal string <LoadUsers>b__1_4(UserMaster u)
			{
				return u.Fio;
			}

			// Token: 0x06004D1F RID: 19743 RVA: 0x001427F0 File Offset: 0x001409F0
			internal int <LoadUsers>b__1_5(UserMaster u)
			{
				return u.Uid;
			}

			// Token: 0x06004D20 RID: 19744 RVA: 0x000CD278 File Offset: 0x000CB478
			internal string <LoadUsers>b__2_0(users u)
			{
				return u.Fio;
			}

			// Token: 0x06004D21 RID: 19745 RVA: 0x00142804 File Offset: 0x00140A04
			internal string <GetEmployees>b__3_0(Employee u)
			{
				return u.Fio;
			}

			// Token: 0x06004D22 RID: 19746 RVA: 0x001427DC File Offset: 0x001409DC
			internal string <LoadMasterManagers>b__10_0(UserMaster u)
			{
				return u.Fio;
			}

			// Token: 0x06004D23 RID: 19747 RVA: 0x001427F0 File Offset: 0x001409F0
			internal int <LoadMasterManagers>b__10_1(UserMaster u)
			{
				return u.Uid;
			}

			// Token: 0x06004D24 RID: 19748 RVA: 0x00142818 File Offset: 0x00140A18
			internal int <GetEmployeesActivity>b__32_0(IEmployee e)
			{
				return e.Id;
			}

			// Token: 0x0400325D RID: 12893
			public static readonly UsersModel.<>c <>9 = new UsersModel.<>c();

			// Token: 0x0400325E RID: 12894
			public static Func<UserMaster, string> <>9__1_4;

			// Token: 0x0400325F RID: 12895
			public static Func<UserMaster, int> <>9__1_5;

			// Token: 0x04003260 RID: 12896
			public static Func<users, string> <>9__2_0;

			// Token: 0x04003261 RID: 12897
			public static Func<Employee, string> <>9__3_0;

			// Token: 0x04003262 RID: 12898
			public static Func<UserMaster, string> <>9__10_0;

			// Token: 0x04003263 RID: 12899
			public static Func<UserMaster, int> <>9__10_1;

			// Token: 0x04003264 RID: 12900
			public static Func<IEmployee, int> <>9__32_0;
		}

		// Token: 0x02000A53 RID: 2643
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadUsers>d__2 : IAsyncStateMachine
		{
			// Token: 0x06004D25 RID: 19749 RVA: 0x0014282C File Offset: 0x00140A2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<users> result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<users>();
					}
					try
					{
						TaskAwaiter<IEnumerable<users>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync((users u) => u.state == (int?)1 && !u.is_bot, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<users>>, UsersModel.<LoadUsers>d__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<users>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						List<users> list = new List<users>(awaiter.GetResult()).OrderBy(new Func<users, string>(UsersModel.<>c.<>9.<LoadUsers>b__2_0)).ToList<users>();
						if (this.includeAll)
						{
							list.Insert(0, new users
							{
								id = 0,
								surname = Lang.t("All")
							});
						}
						result = list;
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004D26 RID: 19750 RVA: 0x00142A18 File Offset: 0x00140C18
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003265 RID: 12901
			public int <>1__state;

			// Token: 0x04003266 RID: 12902
			public AsyncTaskMethodBuilder<List<users>> <>t__builder;

			// Token: 0x04003267 RID: 12903
			public bool includeAll;

			// Token: 0x04003268 RID: 12904
			private GenericRepository<users> <repo>5__2;

			// Token: 0x04003269 RID: 12905
			private TaskAwaiter<IEnumerable<users>> <>u__1;
		}

		// Token: 0x02000A54 RID: 2644
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployees>d__3 : IAsyncStateMachine
		{
			// Token: 0x06004D27 RID: 19751 RVA: 0x00142A34 File Offset: 0x00140C34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<Employee> result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<Employee>> awaiter;
							if (num != 0)
							{
								awaiter = (from u in this.<ctx>5__2.users
								where u.state == (int?)1 && !u.is_bot
								select u).Select(EmployeeConverter.User2EmployeeSelector()).ToListAsync<Employee>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Employee>>, UsersModel.<GetEmployees>d__3>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<Employee>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult().OrderBy(new Func<Employee, string>(UsersModel.<>c.<>9.<GetEmployees>b__3_0)).ToList<Employee>();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						GenericModel.Log.Error(ex, ex.Message);
						result = new List<Employee>();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004D28 RID: 19752 RVA: 0x00142C30 File Offset: 0x00140E30
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400326A RID: 12906
			public int <>1__state;

			// Token: 0x0400326B RID: 12907
			public AsyncTaskMethodBuilder<List<Employee>> <>t__builder;

			// Token: 0x0400326C RID: 12908
			private auseceEntities <ctx>5__2;

			// Token: 0x0400326D RID: 12909
			private TaskAwaiter<List<Employee>> <>u__1;
		}

		// Token: 0x02000A55 RID: 2645
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004D29 RID: 19753 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x0400326E RID: 12910
			public int officeId;
		}

		// Token: 0x02000A56 RID: 2646
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004D2A RID: 19754 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0400326F RID: 12911
			public int permissionId;
		}

		// Token: 0x02000A57 RID: 2647
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadPartRequestManagers>d__9 : IAsyncStateMachine
		{
			// Token: 0x06004D2B RID: 19755 RVA: 0x00142C4C File Offset: 0x00140E4C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<users> result;
				try
				{
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<users>> awaiter;
							if (num != 0)
							{
								awaiter = (from u in this.<ctx>5__2.users
								where u.state == (int?)1 && !u.is_bot && u.roles_users.Any((roles_users r) => r.roles.permissions_roles.Any((permissions_roles p) => p.permission_id == 70))
								select u).ToListAsync<users>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<users>>, UsersModel.<LoadPartRequestManagers>d__9>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<users>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Load all active users fail");
						result = new List<users>();
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004D2C RID: 19756 RVA: 0x00142F14 File Offset: 0x00141114
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003270 RID: 12912
			public int <>1__state;

			// Token: 0x04003271 RID: 12913
			public AsyncTaskMethodBuilder<List<users>> <>t__builder;

			// Token: 0x04003272 RID: 12914
			private auseceEntities <ctx>5__2;

			// Token: 0x04003273 RID: 12915
			private TaskAwaiter<List<users>> <>u__1;
		}

		// Token: 0x02000A58 RID: 2648
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadUserRoles>d__11 : IAsyncStateMachine
		{
			// Token: 0x06004D2D RID: 19757 RVA: 0x00142F30 File Offset: 0x00141130
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<string> result2;
				try
				{
					if (num != 0)
					{
						this.<result>5__2 = new List<string>();
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							var awaiter;
							if (num != 0)
							{
								awaiter = (from r in this.<ctx>5__3.roles.Join(this.<ctx>5__3.roles_users, (roles r) => r.id, (roles_users ru) => ru.role_id, (roles ru, roles_users r) => new
								{
									name = ru.name,
									uid = r.user_id
								})
								where r.uid == Auth.User.id
								select r).ToListAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<<>f__AnonymousType15<string, int>>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							var result = awaiter.GetResult();
							if (result.Any())
							{
								var enumerator = result.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										var <>f__AnonymousType = enumerator.Current;
										this.<result>5__2.Add(<>f__AnonymousType.name);
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
					}
					catch (Exception value)
					{
						GenericModel.Log.Error<Exception>(value);
					}
					result2 = this.<result>5__2;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<result>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<result>5__2 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06004D2E RID: 19758 RVA: 0x001432B8 File Offset: 0x001414B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003274 RID: 12916
			public int <>1__state;

			// Token: 0x04003275 RID: 12917
			public AsyncTaskMethodBuilder<List<string>> <>t__builder;

			// Token: 0x04003276 RID: 12918
			private List<string> <result>5__2;

			// Token: 0x04003277 RID: 12919
			private auseceEntities <ctx>5__3;

			// Token: 0x04003278 RID: 12920
			private TaskAwaiter<List<<>f__AnonymousType15<string, int>>> <>u__1;
		}

		// Token: 0x02000A59 RID: 2649
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadRoles>d__12 : IAsyncStateMachine
		{
			// Token: 0x06004D2F RID: 19759 RVA: 0x001432D4 File Offset: 0x001414D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<roles> result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<roles>();
					}
					try
					{
						TaskAwaiter<IEnumerable<roles>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync(null, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<roles>>, UsersModel.<LoadRoles>d__12>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<roles>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = new List<roles>(awaiter.GetResult());
					}
					finally
					{
						if (num < 0 && this.<repo>5__2 != null)
						{
							((IDisposable)this.<repo>5__2).Dispose();
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004D30 RID: 19760 RVA: 0x001433C8 File Offset: 0x001415C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003279 RID: 12921
			public int <>1__state;

			// Token: 0x0400327A RID: 12922
			public AsyncTaskMethodBuilder<List<roles>> <>t__builder;

			// Token: 0x0400327B RID: 12923
			private GenericRepository<roles> <repo>5__2;

			// Token: 0x0400327C RID: 12924
			private TaskAwaiter<IEnumerable<roles>> <>u__1;
		}

		// Token: 0x02000A5A RID: 2650
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004D31 RID: 19761 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0400327D RID: 12925
			public int userId;
		}

		// Token: 0x02000A5B RID: 2651
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadUserRoleIds>d__13 : IAsyncStateMachine
		{
			// Token: 0x06004D32 RID: 19762 RVA: 0x001433E4 File Offset: 0x001415E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<int> result;
				try
				{
					UsersModel.<>c__DisplayClass13_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new UsersModel.<>c__DisplayClass13_0();
						CS$<>8__locals1.userId = this.userId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<int>> awaiter;
							if (num != 0)
							{
								awaiter = (from r in this.<ctx>5__2.roles
								join ru in this.<ctx>5__2.roles_users on r.id equals ru.role_id
								where ru.user_id == CS$<>8__locals1.userId
								select r.id).ToListAsync<int>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, UsersModel.<LoadUserRoleIds>d__13>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<int>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						GenericModel.Log.Error(ex, ex.Message);
						result = new List<int>();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004D33 RID: 19763 RVA: 0x00143738 File Offset: 0x00141938
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400327E RID: 12926
			public int <>1__state;

			// Token: 0x0400327F RID: 12927
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			// Token: 0x04003280 RID: 12928
			public int userId;

			// Token: 0x04003281 RID: 12929
			private auseceEntities <ctx>5__2;

			// Token: 0x04003282 RID: 12930
			private TaskAwaiter<List<int>> <>u__1;
		}

		// Token: 0x02000A5C RID: 2652
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06004D34 RID: 19764 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x04003283 RID: 12931
			public int userId;
		}

		// Token: 0x02000A5D RID: 2653
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEmployeeKkt>d__14 : IAsyncStateMachine
		{
			// Token: 0x06004D35 RID: 19765 RVA: 0x00143754 File Offset: 0x00141954
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				List<int> result;
				try
				{
					UsersModel.<>c__DisplayClass14_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new UsersModel.<>c__DisplayClass14_0();
						CS$<>8__locals1.userId = this.userId;
					}
					try
					{
						if (num != 0)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<List<int>> awaiter;
							if (num != 0)
							{
								awaiter = (from k in this.<ctx>5__2.kkt_employee.Include((kkt_employee k) => k.kkt1)
								where k.employee == CS$<>8__locals1.userId
								select k.kkt).ToListAsync<int>().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<int>>, UsersModel.<GetEmployeeKkt>d__14>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<List<int>>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							result = awaiter.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						GenericModel.Log.Error(ex, ex.Message);
						result = new List<int>();
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004D36 RID: 19766 RVA: 0x00143994 File Offset: 0x00141B94
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003284 RID: 12932
			public int <>1__state;

			// Token: 0x04003285 RID: 12933
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			// Token: 0x04003286 RID: 12934
			public int userId;

			// Token: 0x04003287 RID: 12935
			private auseceEntities <ctx>5__2;

			// Token: 0x04003288 RID: 12936
			private TaskAwaiter<List<int>> <>u__1;
		}

		// Token: 0x02000A5E RID: 2654
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06004D37 RID: 19767 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06004D38 RID: 19768 RVA: 0x001439B0 File Offset: 0x00141BB0
			internal bool <CreateUser>b__0(kkt k)
			{
				int? office = k.office;
				int office2 = this.user.office;
				return office.GetValueOrDefault() == office2 & office != null;
			}

			// Token: 0x04003289 RID: 12937
			public users user;
		}

		// Token: 0x02000A5F RID: 2655
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateUser>d__18 : IAsyncStateMachine
		{
			// Token: 0x06004D39 RID: 19769 RVA: 0x001439E4 File Offset: 0x00141BE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				UsersModel usersModel = this.<>4__this;
				try
				{
					if (num > 4)
					{
						this.<>8__1 = new UsersModel.<>c__DisplayClass18_0();
						this.<>8__1.user = this.user;
					}
					try
					{
						if (num > 4)
						{
							this.<history>5__2 = new HistoryV2();
							this.<ctx>5__3 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter<int> awaiter;
							TaskAwaiter awaiter2;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_1DF;
							}
							case 2:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_331;
							}
							case 3:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_3C1;
							}
							case 4:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_421;
							}
							default:
								usersModel.CreateDbUser(this.<ctx>5__3, this.<>8__1.user, this.password);
								this.<ctx>5__3.users.Add(this.<>8__1.user);
								this.<history>5__2.Add(5, new string[]
								{
									this.<>8__1.user.username,
									this.<>8__1.user.surname,
									this.<>8__1.user.name,
									this.<>8__1.user.patronymic
								});
								awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num7 = 0;
									num = 0;
									this.<>1__state = num7;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UsersModel.<CreateUser>d__18>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult();
							if (this.<>8__1.user.is_bot)
							{
								goto IL_1E6;
							}
							awaiter2 = usersModel.SetUserRoles(this.<ctx>5__3, this.<>8__1.user.id, this.roles).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num8 = 1;
								num = 1;
								this.<>1__state = num8;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<CreateUser>d__18>(ref awaiter2, ref this);
								return;
							}
							IL_1DF:
							awaiter2.GetResult();
							IL_1E6:
							if (this.kkts == null || !this.kkts.Any<kkt>())
							{
								goto IL_339;
							}
							IEnumerator<kkt> enumerator = this.kkts.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									kkt kkt = enumerator.Current;
									if (kkt.office != null)
									{
										kkt_employee entity = new kkt_employee
										{
											employee = this.<>8__1.user.id,
											kkt = kkt.id,
											office = kkt.office.Value
										};
										this.<ctx>5__3.kkt_employee.Add(entity);
									}
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							kkt kkt2 = this.kkts.FirstOrDefault(new Func<kkt, bool>(this.<>8__1.<CreateUser>b__0));
							if (kkt2 != null)
							{
								this.<>8__1.user.kkt = new int?(kkt2.id);
							}
							awaiter = this.<ctx>5__3.SaveChangesAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num9 = 2;
								num = 2;
								this.<>1__state = num9;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UsersModel.<CreateUser>d__18>(ref awaiter, ref this);
								return;
							}
							IL_331:
							awaiter.GetResult();
							IL_339:
							awaiter2 = UsersModel.CreateSalaryRate(this.<ctx>5__3, this.<history>5__2, this.<>8__1.user.id, this.<>8__1.user.salary_rate.GetValueOrDefault()).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num10 = 3;
								num = 3;
								this.<>1__state = num10;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<CreateUser>d__18>(ref awaiter2, ref this);
								return;
							}
							IL_3C1:
							awaiter2.GetResult();
							awaiter2 = this.<history>5__2.SaveAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num11 = 4;
								num = 4;
								this.<>1__state = num11;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<CreateUser>d__18>(ref awaiter2, ref this);
								return;
							}
							IL_421:
							awaiter2.GetResult();
						}
						finally
						{
							if (num < 0 && this.<ctx>5__3 != null)
							{
								((IDisposable)this.<ctx>5__3).Dispose();
							}
						}
						this.<ctx>5__3 = null;
						this.<history>5__2 = null;
					}
					catch (Exception ex)
					{
						GenericModel.Log.Error(ex, ex.Message);
						throw;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004D3A RID: 19770 RVA: 0x00143EFC File Offset: 0x001420FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400328A RID: 12938
			public int <>1__state;

			// Token: 0x0400328B RID: 12939
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400328C RID: 12940
			public users user;

			// Token: 0x0400328D RID: 12941
			public UsersModel <>4__this;

			// Token: 0x0400328E RID: 12942
			public string password;

			// Token: 0x0400328F RID: 12943
			private UsersModel.<>c__DisplayClass18_0 <>8__1;

			// Token: 0x04003290 RID: 12944
			public IEnumerable<int> roles;

			// Token: 0x04003291 RID: 12945
			public IEnumerable<kkt> kkts;

			// Token: 0x04003292 RID: 12946
			private HistoryV2 <history>5__2;

			// Token: 0x04003293 RID: 12947
			private auseceEntities <ctx>5__3;

			// Token: 0x04003294 RID: 12948
			private TaskAwaiter<int> <>u__1;

			// Token: 0x04003295 RID: 12949
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000A60 RID: 2656
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <CreateSalaryRate>d__19 : IAsyncStateMachine
		{
			// Token: 0x06004D3B RID: 19771 RVA: 0x00143F18 File Offset: 0x00142118
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						DateTime serverUtcTime = Localization.GetServerUtcTime(this.ctx);
						this.ctx.SalaryRates.Add(new SalaryRate
						{
							CreatedAt = serverUtcTime,
							StartFrom = new DateTime(serverUtcTime.Year, serverUtcTime.Month, 1),
							UserId = this.userId,
							Value = this.value
						});
						awaiter = this.ctx.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UsersModel.<CreateSalaryRate>d__19>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					this.history.AddUserLog("SalaryRateChanged", this.userId, new string[]
					{
						string.Format("{0}", this.value)
					});
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004D3C RID: 19772 RVA: 0x00144060 File Offset: 0x00142260
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04003296 RID: 12950
			public int <>1__state;

			// Token: 0x04003297 RID: 12951
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04003298 RID: 12952
			public auseceEntities ctx;

			// Token: 0x04003299 RID: 12953
			public int userId;

			// Token: 0x0400329A RID: 12954
			public int value;

			// Token: 0x0400329B RID: 12955
			public HistoryV2 history;

			// Token: 0x0400329C RID: 12956
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000A61 RID: 2657
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetUserRoles>d__20 : IAsyncStateMachine
		{
			// Token: 0x06004D3D RID: 19773 RVA: 0x0014407C File Offset: 0x0014227C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num == 0 || this.roles != null)
					{
						try
						{
							TaskAwaiter<int> awaiter;
							if (num != 0)
							{
								IEnumerator<int> enumerator = this.roles.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										int role_id = enumerator.Current;
										roles_users entity = new roles_users
										{
											role_id = role_id,
											user_id = this.userId
										};
										this.ctx.roles_users.Add(entity);
									}
								}
								finally
								{
									if (num < 0 && enumerator != null)
									{
										enumerator.Dispose();
									}
								}
								awaiter = this.ctx.SaveChangesAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.<>1__state = num2;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UsersModel.<SetUserRoles>d__20>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<int>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
							}
							awaiter.GetResult();
						}
						catch (Exception ex)
						{
							GenericModel.Log.Error(ex, ex.Message);
							throw;
						}
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004D3E RID: 19774 RVA: 0x001441D0 File Offset: 0x001423D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400329D RID: 12957
			public int <>1__state;

			// Token: 0x0400329E RID: 12958
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400329F RID: 12959
			public IEnumerable<int> roles;

			// Token: 0x040032A0 RID: 12960
			public int userId;

			// Token: 0x040032A1 RID: 12961
			public auseceEntities ctx;

			// Token: 0x040032A2 RID: 12962
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000A62 RID: 2658
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06004D3F RID: 19775 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x040032A3 RID: 12963
			public int userId;
		}

		// Token: 0x02000A63 RID: 2659
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <RemoveAllRoles>d__21 : IAsyncStateMachine
		{
			// Token: 0x06004D40 RID: 19776 RVA: 0x001441EC File Offset: 0x001423EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<int> awaiter;
					TaskAwaiter<List<roles_users>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<int>);
							this.<>1__state = -1;
							goto IL_166;
						}
						UsersModel.<>c__DisplayClass21_0 CS$<>8__locals1 = new UsersModel.<>c__DisplayClass21_0();
						CS$<>8__locals1.userId = this.userId;
						awaiter2 = (from ru in this.ctx.roles_users
						where ru.user_id == CS$<>8__locals1.userId
						select ru).ToListAsync<roles_users>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<roles_users>>, UsersModel.<RemoveAllRoles>d__21>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<roles_users>>);
						this.<>1__state = -1;
					}
					List<roles_users> result = awaiter2.GetResult();
					if (!result.Any<roles_users>())
					{
						goto IL_16E;
					}
					this.ctx.roles_users.RemoveRange(result);
					awaiter = this.ctx.SaveChangesAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UsersModel.<RemoveAllRoles>d__21>(ref awaiter, ref this);
						return;
					}
					IL_166:
					awaiter.GetResult();
					IL_16E:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004D41 RID: 19777 RVA: 0x001443B4 File Offset: 0x001425B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040032A4 RID: 12964
			public int <>1__state;

			// Token: 0x040032A5 RID: 12965
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040032A6 RID: 12966
			public int userId;

			// Token: 0x040032A7 RID: 12967
			public auseceEntities ctx;

			// Token: 0x040032A8 RID: 12968
			private TaskAwaiter<List<roles_users>> <>u__1;

			// Token: 0x040032A9 RID: 12969
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x02000A64 RID: 2660
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06004D42 RID: 19778 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x040032AA RID: 12970
			public int userId;
		}

		// Token: 0x02000A65 RID: 2661
		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x06004D43 RID: 19779 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x040032AB RID: 12971
			public int employeeId;
		}

		// Token: 0x02000A66 RID: 2662
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06004D44 RID: 19780 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x040032AC RID: 12972
			public string username;
		}

		// Token: 0x02000A67 RID: 2663
		[CompilerGenerated]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06004D45 RID: 19781 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x06004D46 RID: 19782 RVA: 0x001443D0 File Offset: 0x001425D0
			internal bool <UpdateUser>b__1(kkt k)
			{
				int? office = k.office;
				int office2 = this.user.office;
				return office.GetValueOrDefault() == office2 & office != null;
			}

			// Token: 0x040032AD RID: 12973
			public users user;
		}

		// Token: 0x02000A68 RID: 2664
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateUser>d__29 : IAsyncStateMachine
		{
			// Token: 0x06004D47 RID: 19783 RVA: 0x00144404 File Offset: 0x00142604
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				UsersModel usersModel = this.<>4__this;
				try
				{
					if (num > 7)
					{
						this.<>8__1 = new UsersModel.<>c__DisplayClass29_0();
						this.<>8__1.user = this.user;
					}
					try
					{
						if (num > 7)
						{
							this.<ctx>5__2 = new auseceEntities(true);
						}
						try
						{
							TaskAwaiter awaiter;
							TaskAwaiter<users> awaiter2;
							TaskAwaiter<List<kkt_employee>> awaiter3;
							TaskAwaiter<int> awaiter4;
							switch (num)
							{
							case 0:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								break;
							}
							case 1:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_224;
							}
							case 2:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num4 = -1;
								num = -1;
								this.<>1__state = num4;
								goto IL_2CB;
							}
							case 3:
							{
								awaiter2 = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<users>);
								int num5 = -1;
								num = -1;
								this.<>1__state = num5;
								goto IL_3ED;
							}
							case 4:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num6 = -1;
								num = -1;
								this.<>1__state = num6;
								goto IL_543;
							}
							case 5:
							{
								awaiter3 = this.<>u__3;
								this.<>u__3 = default(TaskAwaiter<List<kkt_employee>>);
								int num7 = -1;
								num = -1;
								this.<>1__state = num7;
								goto IL_64F;
							}
							case 6:
							{
								awaiter4 = this.<>u__4;
								this.<>u__4 = default(TaskAwaiter<int>);
								int num8 = -1;
								num = -1;
								this.<>1__state = num8;
								goto IL_822;
							}
							case 7:
							{
								awaiter = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								int num9 = -1;
								num = -1;
								this.<>1__state = num9;
								goto IL_883;
							}
							default:
								this.<history>5__3 = new HistoryV2();
								awaiter = usersModel.RemoveAllRoles(this.<ctx>5__2, this.<>8__1.user.id).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num10 = 0;
									num = 0;
									this.<>1__state = num10;
									this.<>u__1 = awaiter;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<UpdateUser>d__29>(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult();
							if (this.<>8__1.user.IsArchive)
							{
								this.<>8__1.user.state = new int?(0);
								usersModel.DeleteUserFromServer(this.<>8__1.user.username);
								this.<history>5__3.Add(6, new string[]
								{
									this.<>8__1.user.username,
									this.<>8__1.user.surname,
									this.<>8__1.user.name,
									this.<>8__1.user.patronymic
								});
								goto IL_310;
							}
							this.<>8__1.user.state = new int?(1);
							if (this.<>8__1.user.is_bot)
							{
								goto IL_22B;
							}
							awaiter = usersModel.SetUserRoles(this.<ctx>5__2, this.<>8__1.user.id, this.roles).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num11 = 1;
								num = 1;
								this.<>1__state = num11;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<UpdateUser>d__29>(ref awaiter, ref this);
								return;
							}
							IL_224:
							awaiter.GetResult();
							IL_22B:
							if (string.IsNullOrEmpty(this.newLogin) || !(this.newLogin != this.<>8__1.user.username))
							{
								goto IL_2E8;
							}
							awaiter = usersModel.ChangeLogin(this.<ctx>5__2, this.<>8__1.user.username, this.newLogin).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num12 = 2;
								num = 2;
								this.<>1__state = num12;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<UpdateUser>d__29>(ref awaiter, ref this);
								return;
							}
							IL_2CB:
							awaiter.GetResult();
							this.<>8__1.user.username = this.newLogin;
							IL_2E8:
							if (!string.IsNullOrEmpty(this.password))
							{
								UsersModel.ChangePassword(this.<>8__1.user.username, this.password);
							}
							IL_310:
							this.<history>5__3.Add(7, new string[]
							{
								this.<>8__1.user.username,
								this.<>8__1.user.surname,
								this.<>8__1.user.name,
								this.<>8__1.user.patronymic
							});
							awaiter2 = this.<ctx>5__2.users.FindAsync(new object[]
							{
								this.<>8__1.user.id
							}).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num13 = 3;
								num = 3;
								this.<>1__state = num13;
								this.<>u__2 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<users>, UsersModel.<UpdateUser>d__29>(ref awaiter2, ref this);
								return;
							}
							IL_3ED:
							users result = awaiter2.GetResult();
							this.<usr>5__4 = result;
							int? num14 = this.<usr>5__4.state;
							if (num14.GetValueOrDefault() == 0 & num14 != null)
							{
								num14 = this.<>8__1.user.state;
								if (num14.GetValueOrDefault() == 1 & num14 != null)
								{
									usersModel.CreateDbUser(this.<ctx>5__2, this.<>8__1.user, string.IsNullOrEmpty(this.password) ? "P123456d" : this.password);
								}
							}
							num14 = this.<usr>5__4.salary_rate;
							int? salary_rate = this.<>8__1.user.salary_rate;
							if (num14.GetValueOrDefault() == salary_rate.GetValueOrDefault() & num14 != null == (salary_rate != null))
							{
								goto IL_54A;
							}
							awaiter = UsersModel.CreateSalaryRate(this.<ctx>5__2, this.<history>5__3, this.<>8__1.user.id, this.<>8__1.user.salary_rate.GetValueOrDefault()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num15 = 4;
								num = 4;
								this.<>1__state = num15;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<UpdateUser>d__29>(ref awaiter, ref this);
								return;
							}
							IL_543:
							awaiter.GetResult();
							IL_54A:
							this.<ctx>5__2.Entry<users>(this.<usr>5__4).CurrentValues.SetValues(this.<>8__1.user);
							awaiter3 = (from k in this.<ctx>5__2.kkt_employee
							where k.employee == this.<>8__1.user.id
							select k).ToListAsync<kkt_employee>().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num16 = 5;
								num = 5;
								this.<>1__state = num16;
								this.<>u__3 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<kkt_employee>>, UsersModel.<UpdateUser>d__29>(ref awaiter3, ref this);
								return;
							}
							IL_64F:
							List<kkt_employee> result2 = awaiter3.GetResult();
							if (result2.Any<kkt_employee>())
							{
								List<kkt_employee>.Enumerator enumerator = result2.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										kkt_employee entity = enumerator.Current;
										this.<ctx>5__2.kkt_employee.Remove(entity);
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator).Dispose();
									}
								}
							}
							if (!this.<>8__1.user.IsArchive && this.kkts.Any<kkt>())
							{
								List<kkt>.Enumerator enumerator2 = this.kkts.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										kkt kkt = enumerator2.Current;
										if (kkt.office != null)
										{
											this.<ctx>5__2.kkt_employee.Add(new kkt_employee
											{
												employee = this.<>8__1.user.id,
												kkt = kkt.id,
												office = kkt.office.Value
											});
										}
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2).Dispose();
									}
								}
								kkt kkt2 = this.kkts.FirstOrDefault(new Func<kkt, bool>(this.<>8__1.<UpdateUser>b__1));
								if (kkt2 == null)
								{
									this.<usr>5__4.kkt = null;
								}
								else
								{
									this.<usr>5__4.kkt = new int?(kkt2.id);
								}
							}
							else
							{
								this.<usr>5__4.kkt = null;
							}
							awaiter4 = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								int num17 = 6;
								num = 6;
								this.<>1__state = num17;
								this.<>u__4 = awaiter4;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UsersModel.<UpdateUser>d__29>(ref awaiter4, ref this);
								return;
							}
							IL_822:
							awaiter4.GetResult();
							awaiter = this.<history>5__3.SaveAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num18 = 7;
								num = 7;
								this.<>1__state = num18;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, UsersModel.<UpdateUser>d__29>(ref awaiter, ref this);
								return;
							}
							IL_883:
							awaiter.GetResult();
							if (this.<>8__1.user.id == Auth.User.id)
							{
								Auth.User.kkm_pass = this.<>8__1.user.kkm_pass;
							}
							this.<history>5__3 = null;
							this.<usr>5__4 = null;
						}
						finally
						{
							if (num < 0 && this.<ctx>5__2 != null)
							{
								((IDisposable)this.<ctx>5__2).Dispose();
							}
						}
						this.<ctx>5__2 = null;
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Save user fail [ACP]");
						throw;
					}
				}
				catch (Exception exception2)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception2);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004D48 RID: 19784 RVA: 0x00144DD4 File Offset: 0x00142FD4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040032AE RID: 12974
			public int <>1__state;

			// Token: 0x040032AF RID: 12975
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040032B0 RID: 12976
			public users user;

			// Token: 0x040032B1 RID: 12977
			public UsersModel <>4__this;

			// Token: 0x040032B2 RID: 12978
			private UsersModel.<>c__DisplayClass29_0 <>8__1;

			// Token: 0x040032B3 RID: 12979
			public List<int> roles;

			// Token: 0x040032B4 RID: 12980
			public string newLogin;

			// Token: 0x040032B5 RID: 12981
			public string password;

			// Token: 0x040032B6 RID: 12982
			public List<kkt> kkts;

			// Token: 0x040032B7 RID: 12983
			private auseceEntities <ctx>5__2;

			// Token: 0x040032B8 RID: 12984
			private HistoryV2 <history>5__3;

			// Token: 0x040032B9 RID: 12985
			private users <usr>5__4;

			// Token: 0x040032BA RID: 12986
			private TaskAwaiter <>u__1;

			// Token: 0x040032BB RID: 12987
			private TaskAwaiter<users> <>u__2;

			// Token: 0x040032BC RID: 12988
			private TaskAwaiter<List<kkt_employee>> <>u__3;

			// Token: 0x040032BD RID: 12989
			private TaskAwaiter<int> <>u__4;
		}

		// Token: 0x02000A69 RID: 2665
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ChangeLogin>d__30 : IAsyncStateMachine
		{
			// Token: 0x06004D49 RID: 19785 RVA: 0x00144DF0 File Offset: 0x00142FF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						string database = this.ctx.Database.Connection.Database;
						string sql = string.Concat(new string[]
						{
							"REVOKE ALL PRIVILEGES ON *.* FROM '",
							this.oldLogin,
							"'@'%'; \r\n                UPDATE mysql.user SET User = '",
							this.newLogin,
							"' WHERE User = '",
							this.oldLogin,
							"';\r\n                FLUSH PRIVILEGES;\r\n                GRANT ALL PRIVILEGES ON ",
							database,
							".* TO '",
							this.newLogin,
							"'@'%'; "
						});
						awaiter = this.ctx.Database.ExecuteSqlCommandAsync(sql, new object[0]).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, UsersModel.<ChangeLogin>d__30>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004D4A RID: 19786 RVA: 0x00144F30 File Offset: 0x00143130
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040032BE RID: 12990
			public int <>1__state;

			// Token: 0x040032BF RID: 12991
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040032C0 RID: 12992
			public auseceEntities ctx;

			// Token: 0x040032C1 RID: 12993
			public string oldLogin;

			// Token: 0x040032C2 RID: 12994
			public string newLogin;

			// Token: 0x040032C3 RID: 12995
			private TaskAwaiter<int> <>u__1;
		}

		// Token: 0x02000A6A RID: 2666
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06004D4B RID: 19787 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x040032C4 RID: 12996
			public int permission;

			// Token: 0x040032C5 RID: 12997
			public int officeId;
		}

		// Token: 0x02000A6B RID: 2667
		[CompilerGenerated]
		private sealed class <>c__DisplayClass31_1
		{
			// Token: 0x06004D4C RID: 19788 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass31_1()
			{
			}

			// Token: 0x040032C6 RID: 12998
			public List<int> roles;
		}

		// Token: 0x02000A6C RID: 2668
		[CompilerGenerated]
		private sealed class <>c__DisplayClass32_0
		{
			// Token: 0x06004D4D RID: 19789 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass32_0()
			{
			}

			// Token: 0x040032C7 RID: 12999
			public List<int> ids;

			// Token: 0x040032C8 RID: 13000
			public DateTime from;

			// Token: 0x040032C9 RID: 13001
			public DateTime to;
		}

		// Token: 0x02000A6D RID: 2669
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06004D4E RID: 19790 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x06004D4F RID: 19791 RVA: 0x00144F4C File Offset: 0x0014314C
			internal bool <GetEmployeeActivityReport>b__0(UsersActivity e)
			{
				return e.EmployeeId == this.employee.Id;
			}

			// Token: 0x040032CA RID: 13002
			public Employee employee;
		}
	}
}
