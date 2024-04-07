using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using ASC.Common.Models;
using ASC.Models;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Images;
using DevExpress.Mvvm;
using DevExpress.Utils.Design;

namespace ASC.Objects
{
	// Token: 0x020008A9 RID: 2217
	public class OfflineData : BindableBase
	{
		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x00109AD8 File Offset: 0x00107CD8
		public static OfflineData Instance
		{
			get
			{
				return OfflineData._offlineData;
			}
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x00109AEC File Offset: 0x00107CEC
		static OfflineData()
		{
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x00109B04 File Offset: 0x00107D04
		public List<KeyValuePair<string, BitmapImage>> Images
		{
			get
			{
				if (this._Images == null)
				{
					List<KeyValuePair<string, BitmapImage>> list = new List<KeyValuePair<string, BitmapImage>>();
					foreach (ImagesAssemblyImageInfo imagesAssemblyImageInfo in (from i in ImagesAssemblyImageList.Images
					where i.Size == ImageSize.Size16x16 && i.ImageType == ImageType.Colored
					select i).ToList<ImagesAssemblyImageInfo>())
					{
						string uriString = imagesAssemblyImageInfo.MakeUri();
						list.Add(new KeyValuePair<string, BitmapImage>(imagesAssemblyImageInfo.Name, new BitmapImage(new Uri(uriString))));
					}
					this._Images = list;
				}
				return this._Images;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x00109BBC File Offset: 0x00107DBC
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x00109BD0 File Offset: 0x00107DD0
		public Employee Employee
		{
			[CompilerGenerated]
			get
			{
				return this.<Employee>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Employee>k__BackingField, value))
				{
					return;
				}
				this.<Employee>k__BackingField = value;
				this.RaisePropertyChanged("Employee");
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x00109C00 File Offset: 0x00107E00
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x00109C14 File Offset: 0x00107E14
		public List<Company> Companies
		{
			[CompilerGenerated]
			get
			{
				return this.<Companies>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Companies>k__BackingField, value))
				{
					return;
				}
				this.<Companies>k__BackingField = value;
				this.RaisePropertyChanged("CompaniesWithAll");
				this.RaisePropertyChanged("Companies");
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x00109C50 File Offset: 0x00107E50
		public List<Company> CompaniesWithAll
		{
			get
			{
				List<Company> list = new List<Company>(this.Companies);
				list.Insert(0, new Company
				{
					Id = 0,
					Name = Lang.t("All")
				});
				return list;
			}
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00109C8C File Offset: 0x00107E8C
		public void SetEmployee(Employee employee)
		{
			this.Employee = employee;
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x00109CA0 File Offset: 0x00107EA0
		// (set) Token: 0x06004397 RID: 17303 RVA: 0x00109CB4 File Offset: 0x00107EB4
		public SettingsModel Settings
		{
			[CompilerGenerated]
			get
			{
				return this.<Settings>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(this.<Settings>k__BackingField, value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = 1348415571;
				IL_13:
				switch ((num ^ 160534814) % 4)
				{
				case 1:
					return;
				case 2:
					IL_32:
					this.<Settings>k__BackingField = value;
					num = 1020250326;
					goto IL_13;
				case 3:
					goto IL_0E;
				}
				this.RaisePropertyChanged("Settings");
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x00109D10 File Offset: 0x00107F10
		// (set) Token: 0x06004399 RID: 17305 RVA: 0x00109D24 File Offset: 0x00107F24
		public List<offices> Offices
		{
			[CompilerGenerated]
			get
			{
				return this.<Offices>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Offices>k__BackingField, value))
				{
					return;
				}
				this.<Offices>k__BackingField = value;
				this.RaisePropertyChanged("OfficesWithAll");
				this.RaisePropertyChanged("Offices");
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x00109D60 File Offset: 0x00107F60
		public List<offices> OfficesWithAll
		{
			get
			{
				List<offices> list = new List<offices>(this.Offices);
				list.Insert(0, new offices
				{
					id = 0,
					name = Lang.t("All")
				});
				return list;
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x00109D9C File Offset: 0x00107F9C
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x00109DB0 File Offset: 0x00107FB0
		public List<PaymentOptions> PaymentOptionses
		{
			[CompilerGenerated]
			get
			{
				return this.<PaymentOptionses>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<PaymentOptionses>k__BackingField, value))
				{
					return;
				}
				this.<PaymentOptionses>k__BackingField = value;
				this.RaisePropertyChanged("PaymentOptionsesWithAll");
				this.RaisePropertyChanged("PaymentOptionses");
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x00109DEC File Offset: 0x00107FEC
		public List<PaymentOptions> PaymentOptionsesWithAll
		{
			get
			{
				List<PaymentOptions> list = new List<PaymentOptions>(this.PaymentOptionses);
				list.Insert(0, new PaymentOptions
				{
					Id = -100,
					Name = Lang.t("All")
				});
				return list;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x00109E28 File Offset: 0x00108028
		// (set) Token: 0x0600439F RID: 17311 RVA: 0x00109E3C File Offset: 0x0010803C
		public List<Employee> ActiveUsers
		{
			[CompilerGenerated]
			get
			{
				return this.<ActiveUsers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ActiveUsers>k__BackingField, value))
				{
					return;
				}
				this.<ActiveUsers>k__BackingField = value;
				this.RaisePropertyChanged("ActiveUsersWithAll");
				this.RaisePropertyChanged("ActiveUsers");
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x00109E78 File Offset: 0x00108078
		public List<Employee> ActiveUsersWithAll
		{
			get
			{
				List<Employee> list = new List<Employee>(this.ActiveUsers);
				Employee item = new Employee
				{
					Id = 0,
					LastName = Lang.t("All")
				};
				list.Insert(0, item);
				return list;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x00109EB8 File Offset: 0x001080B8
		// (set) Token: 0x060043A2 RID: 17314 RVA: 0x00109ECC File Offset: 0x001080CC
		public List<UserMaster> AdminUsers
		{
			[CompilerGenerated]
			get
			{
				return this.<AdminUsers>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<AdminUsers>k__BackingField, value))
				{
					return;
				}
				this.<AdminUsers>k__BackingField = value;
				this.RaisePropertyChanged("AdminUsers");
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x00109EFC File Offset: 0x001080FC
		// (set) Token: 0x060043A4 RID: 17316 RVA: 0x00109F10 File Offset: 0x00108110
		public List<visit_sources> VisitSources
		{
			[CompilerGenerated]
			get
			{
				return this.<VisitSources>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<VisitSources>k__BackingField, value))
				{
					return;
				}
				this.<VisitSources>k__BackingField = value;
				this.RaisePropertyChanged("VisitSourcesWithAll");
				this.RaisePropertyChanged("VisitSources");
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x00109F4C File Offset: 0x0010814C
		public List<visit_sources> VisitSourcesWithAll
		{
			get
			{
				List<visit_sources> list = new List<visit_sources>(this.VisitSources);
				list.Insert(0, new visit_sources
				{
					id = 0,
					name = Lang.t("All")
				});
				return list;
			}
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00109F88 File Offset: 0x00108188
		public OfflineData()
		{
			this.LoadSettings();
			this.LoadCompanies();
			this.LoadOffices();
			this.LoadPaymentSystems();
			this.ReloadUsers();
			this.LoadVisitSources();
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x00109FCC File Offset: 0x001081CC
		private void LoadSettings()
		{
			OfflineData.<LoadSettings>d__51 <LoadSettings>d__;
			<LoadSettings>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadSettings>d__.<>4__this = this;
			<LoadSettings>d__.<>1__state = -1;
			<LoadSettings>d__.<>t__builder.Start<OfflineData.<LoadSettings>d__51>(ref <LoadSettings>d__);
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x0010A004 File Offset: 0x00108204
		public Task ReloadSettings()
		{
			OfflineData.<ReloadSettings>d__52 <ReloadSettings>d__;
			<ReloadSettings>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReloadSettings>d__.<>4__this = this;
			<ReloadSettings>d__.<>1__state = -1;
			<ReloadSettings>d__.<>t__builder.Start<OfflineData.<ReloadSettings>d__52>(ref <ReloadSettings>d__);
			return <ReloadSettings>d__.<>t__builder.Task;
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x0010A048 File Offset: 0x00108248
		public int CountCompanies()
		{
			List<Company> companies = this.Companies;
			if (companies == null)
			{
				return 1;
			}
			return companies.Count;
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x0010A068 File Offset: 0x00108268
		public List<Employee> GetCurrentOfficeEmployees()
		{
			return (from u in this.ActiveUsers
			where u.OfficeId == this.Employee.OfficeId
			select u).ToList<Employee>();
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x0010A094 File Offset: 0x00108294
		public int GetSelectedCompany()
		{
			if (this.Companies != null && this.Companies.Count == 1)
			{
				return this.Companies.FirstOrDefault<Company>().Id;
			}
			return 0;
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x0010A0CC File Offset: 0x001082CC
		public bool AnyVisitSource()
		{
			return this.VisitSources != null && this.VisitSources.Any<visit_sources>();
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x0010A0F0 File Offset: 0x001082F0
		public int CountOffices()
		{
			List<offices> offices = this.Offices;
			if (offices == null)
			{
				return 1;
			}
			return offices.Count;
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0010A110 File Offset: 0x00108310
		private void LoadCompanies()
		{
			Task.Run<List<Company>>(new Func<Task<List<Company>>>(CompaniesModel.LoadCompanies)).ContinueWith(delegate(Task<List<Company>> t)
			{
				this.Companies = t.Result;
			});
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x0010A140 File Offset: 0x00108340
		private void LoadVisitSources()
		{
			Task.Run<List<visit_sources>>(() => ChartModel.LoadVisitSourcesesAsync(false)).ContinueWith(delegate(Task<List<visit_sources>> t)
			{
				this.VisitSources = t.Result;
			});
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x0010A184 File Offset: 0x00108384
		private void LoadOffices()
		{
			OfflineData.<LoadOffices>d__60 <LoadOffices>d__;
			<LoadOffices>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadOffices>d__.<>4__this = this;
			<LoadOffices>d__.<>1__state = -1;
			<LoadOffices>d__.<>t__builder.Start<OfflineData.<LoadOffices>d__60>(ref <LoadOffices>d__);
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x0010A1BC File Offset: 0x001083BC
		private void LoadPaymentSystems()
		{
			Task.Run<List<PaymentOptions>>(() => PaymentOptions.GetAllOptions(false)).ContinueWith(delegate(Task<List<PaymentOptions>> t)
			{
				this.PaymentOptionses = t.Result;
			});
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0010A200 File Offset: 0x00108400
		private void LoadAdminUsers()
		{
			Task.Run<IEnumerable<UserMaster>>(() => UsersModel.LoadAdmins()).ContinueWith(delegate(Task<IEnumerable<UserMaster>> t)
			{
				this.AdminUsers = new List<UserMaster>(t.Result);
			});
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x0010A244 File Offset: 0x00108444
		private void LoadActiveUsers()
		{
			Task.Run<List<Employee>>(new Func<Task<List<Employee>>>(UsersModel.GetEmployees)).ContinueWith(delegate(Task<List<Employee>> t)
			{
				this.ActiveUsers = t.Result;
			});
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x0010A274 File Offset: 0x00108474
		public void ReloadUsers()
		{
			this.LoadAdminUsers();
			this.LoadActiveUsers();
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x0010A290 File Offset: 0x00108490
		public void ReloadCompanies()
		{
			this.LoadCompanies();
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x0010A2A4 File Offset: 0x001084A4
		public void ReloadOffices()
		{
			this.LoadOffices();
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x0010A2B8 File Offset: 0x001084B8
		public void ReloadVisitSources()
		{
			this.LoadVisitSources();
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x0010A2CC File Offset: 0x001084CC
		public void ReloadPaymentSystems()
		{
			this.LoadPaymentSystems();
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x0010A2E0 File Offset: 0x001084E0
		[CompilerGenerated]
		private bool <GetCurrentOfficeEmployees>b__54_0(Employee u)
		{
			return u.OfficeId == this.Employee.OfficeId;
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x0010A300 File Offset: 0x00108500
		[CompilerGenerated]
		private void <LoadCompanies>b__58_0(Task<List<Company>> t)
		{
			this.Companies = t.Result;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x0010A31C File Offset: 0x0010851C
		[CompilerGenerated]
		private void <LoadVisitSources>b__59_1(Task<List<visit_sources>> t)
		{
			this.VisitSources = t.Result;
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x0010A338 File Offset: 0x00108538
		[CompilerGenerated]
		private void <LoadPaymentSystems>b__61_1(Task<List<PaymentOptions>> t)
		{
			this.PaymentOptionses = t.Result;
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x0010A354 File Offset: 0x00108554
		[CompilerGenerated]
		private void <LoadAdminUsers>b__62_1(Task<IEnumerable<UserMaster>> t)
		{
			this.AdminUsers = new List<UserMaster>(t.Result);
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x0010A374 File Offset: 0x00108574
		[CompilerGenerated]
		private void <LoadActiveUsers>b__63_0(Task<List<Employee>> t)
		{
			this.ActiveUsers = t.Result;
		}

		// Token: 0x04002BB9 RID: 11193
		private static OfflineData _offlineData = new OfflineData();

		// Token: 0x04002BBA RID: 11194
		protected List<KeyValuePair<string, BitmapImage>> _Images;

		// Token: 0x04002BBB RID: 11195
		[CompilerGenerated]
		private Employee <Employee>k__BackingField;

		// Token: 0x04002BBC RID: 11196
		[CompilerGenerated]
		private List<Company> <Companies>k__BackingField;

		// Token: 0x04002BBD RID: 11197
		[CompilerGenerated]
		private SettingsModel <Settings>k__BackingField = new SettingsModel();

		// Token: 0x04002BBE RID: 11198
		[CompilerGenerated]
		private List<offices> <Offices>k__BackingField;

		// Token: 0x04002BBF RID: 11199
		[CompilerGenerated]
		private List<PaymentOptions> <PaymentOptionses>k__BackingField;

		// Token: 0x04002BC0 RID: 11200
		[CompilerGenerated]
		private List<Employee> <ActiveUsers>k__BackingField;

		// Token: 0x04002BC1 RID: 11201
		[CompilerGenerated]
		private List<UserMaster> <AdminUsers>k__BackingField;

		// Token: 0x04002BC2 RID: 11202
		[CompilerGenerated]
		private List<visit_sources> <VisitSources>k__BackingField;

		// Token: 0x020008AA RID: 2218
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060043BF RID: 17343 RVA: 0x0010A390 File Offset: 0x00108590
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060043C0 RID: 17344 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x060043C1 RID: 17345 RVA: 0x0010A3A8 File Offset: 0x001085A8
			internal bool <get_Images>b__6_0(ImagesAssemblyImageInfo i)
			{
				return i.Size == ImageSize.Size16x16 && i.ImageType == ImageType.Colored;
			}

			// Token: 0x060043C2 RID: 17346 RVA: 0x0010A3CC File Offset: 0x001085CC
			internal Task<List<visit_sources>> <LoadVisitSources>b__59_0()
			{
				return ChartModel.LoadVisitSourcesesAsync(false);
			}

			// Token: 0x060043C3 RID: 17347 RVA: 0x0010A3E0 File Offset: 0x001085E0
			internal Task<List<PaymentOptions>> <LoadPaymentSystems>b__61_0()
			{
				return PaymentOptions.GetAllOptions(false);
			}

			// Token: 0x060043C4 RID: 17348 RVA: 0x0010A3F4 File Offset: 0x001085F4
			internal IEnumerable<UserMaster> <LoadAdminUsers>b__62_0()
			{
				return UsersModel.LoadAdmins();
			}

			// Token: 0x04002BC3 RID: 11203
			public static readonly OfflineData.<>c <>9 = new OfflineData.<>c();

			// Token: 0x04002BC4 RID: 11204
			public static Func<ImagesAssemblyImageInfo, bool> <>9__6_0;

			// Token: 0x04002BC5 RID: 11205
			public static Func<Task<List<visit_sources>>> <>9__59_0;

			// Token: 0x04002BC6 RID: 11206
			public static Func<Task<List<PaymentOptions>>> <>9__61_0;

			// Token: 0x04002BC7 RID: 11207
			public static Func<IEnumerable<UserMaster>> <>9__62_0;
		}

		// Token: 0x020008AB RID: 2219
		[CompilerGenerated]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x060043C5 RID: 17349 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x060043C6 RID: 17350 RVA: 0x0010A408 File Offset: 0x00108608
			internal Task<SettingsModel> <LoadSettings>b__0()
			{
				return this.settingsService.GetSettingsAsync();
			}

			// Token: 0x04002BC8 RID: 11208
			public ISettingsService settingsService;
		}

		// Token: 0x020008AC RID: 2220
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadSettings>d__51 : IAsyncStateMachine
		{
			// Token: 0x060043C7 RID: 17351 RVA: 0x0010A420 File Offset: 0x00108620
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfflineData offlineData = this.<>4__this;
				try
				{
					TaskAwaiter<SettingsModel> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<SettingsModel>(new Func<Task<SettingsModel>>(new OfflineData.<>c__DisplayClass51_0
						{
							settingsService = Bootstrapper.Container.Resolve<ISettingsService>()
						}.<LoadSettings>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SettingsModel>, OfflineData.<LoadSettings>d__51>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<SettingsModel>);
						this.<>1__state = -1;
					}
					SettingsModel result = awaiter.GetResult();
					offlineData.Settings = result;
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

			// Token: 0x060043C8 RID: 17352 RVA: 0x0010A4FC File Offset: 0x001086FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BC9 RID: 11209
			public int <>1__state;

			// Token: 0x04002BCA RID: 11210
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002BCB RID: 11211
			public OfflineData <>4__this;

			// Token: 0x04002BCC RID: 11212
			private TaskAwaiter<SettingsModel> <>u__1;
		}

		// Token: 0x020008AD RID: 2221
		[CompilerGenerated]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x060043C9 RID: 17353 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x060043CA RID: 17354 RVA: 0x0010A518 File Offset: 0x00108718
			internal Task<SettingsModel> <ReloadSettings>b__0()
			{
				return this.settingsService.GetSettingsAsync();
			}

			// Token: 0x04002BCD RID: 11213
			public ISettingsService settingsService;
		}

		// Token: 0x020008AE RID: 2222
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ReloadSettings>d__52 : IAsyncStateMachine
		{
			// Token: 0x060043CB RID: 17355 RVA: 0x0010A530 File Offset: 0x00108730
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfflineData offlineData = this.<>4__this;
				try
				{
					TaskAwaiter<SettingsModel> awaiter;
					if (num != 0)
					{
						awaiter = Task.Run<SettingsModel>(new Func<Task<SettingsModel>>(new OfflineData.<>c__DisplayClass52_0
						{
							settingsService = Bootstrapper.Container.Resolve<ISettingsService>()
						}.<ReloadSettings>b__0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SettingsModel>, OfflineData.<ReloadSettings>d__52>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<SettingsModel>);
						this.<>1__state = -1;
					}
					SettingsModel result = awaiter.GetResult();
					offlineData.Settings = result;
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

			// Token: 0x060043CC RID: 17356 RVA: 0x0010A60C File Offset: 0x0010880C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BCE RID: 11214
			public int <>1__state;

			// Token: 0x04002BCF RID: 11215
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04002BD0 RID: 11216
			public OfflineData <>4__this;

			// Token: 0x04002BD1 RID: 11217
			private TaskAwaiter<SettingsModel> <>u__1;
		}

		// Token: 0x020008AF RID: 2223
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadOffices>d__60 : IAsyncStateMachine
		{
			// Token: 0x060043CD RID: 17357 RVA: 0x0010A628 File Offset: 0x00108828
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				OfflineData offlineData = this.<>4__this;
				try
				{
					TaskAwaiter<List<offices>> awaiter;
					if (num != 0)
					{
						awaiter = OfficesModel.LoadAllOffices(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<offices>>, OfflineData.<LoadOffices>d__60>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<List<offices>>);
						this.<>1__state = -1;
					}
					List<offices> result = awaiter.GetResult();
					offlineData.Offices = result;
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

			// Token: 0x060043CE RID: 17358 RVA: 0x0010A6E4 File Offset: 0x001088E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002BD2 RID: 11218
			public int <>1__state;

			// Token: 0x04002BD3 RID: 11219
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002BD4 RID: 11220
			public OfflineData <>4__this;

			// Token: 0x04002BD5 RID: 11221
			private TaskAwaiter<List<offices>> <>u__1;
		}
	}
}
