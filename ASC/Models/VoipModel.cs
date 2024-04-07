using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Phone;
using ASC.Objects;
using ASC.SimpleClasses;
using AsterNET.Manager;
using AsterNET.Manager.Action;
using AsterNET.Manager.Response;
using Flurl.Http;
using Flurl.Http.Content;

namespace ASC.Models
{
	// Token: 0x02000AA2 RID: 2722
	public class VoipModel : GenericModel
	{
		// Token: 0x06004E05 RID: 19973 RVA: 0x0014BE2C File Offset: 0x0014A02C
		public VoipModel()
		{
			VoIPClient? voip = OfflineData.Instance.Settings.Voip;
			if (!(voip.GetValueOrDefault() == VoIPClient.AsteriskRealtime & voip != null))
			{
				return;
			}
			this.Cnn = new ManagerConnection(Auth.Config.aster_host, Auth.Config.aster_port, Auth.Config.aster_login, Auth.Config.aster_password)
			{
				DefaultEventTimeout = 2000,
				DefaultResponseTimeout = 1500
			};
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x0014BEB0 File Offset: 0x0014A0B0
		public static clients GetCusomerByPhone(string phone)
		{
			clients result;
			try
			{
				phone = Phone.ClearPhoneString(phone);
				string phone8 = "8" + phone.Remove(0, 1);
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.clients.AsNoTracking().Include((clients c) => c.tel).FirstOrDefault((clients c) => (from p in c.tel
					select p.phone_clean).Contains(phone) || (from p in c.tel
					select p.phone_clean).Contains(phone8));
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Get client by phone fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x0014C130 File Offset: 0x0014A330
		public static IAscResult CreateEndpoint(int tel, string password, string context, string allow)
		{
			Result result = new Result();
			ps_auths entity = new ps_auths
			{
				id = tel,
				auth_type = "userpass",
				password = password,
				username = tel.ToString()
			};
			ps_aors entity2 = new ps_aors
			{
				id = tel.ToString(),
				max_contacts = new int?(1)
			};
			ps_endpoints entity3 = new ps_endpoints
			{
				id = tel,
				transport = "transport-udp",
				aors = tel.ToString(),
				auth = tel.ToString(),
				context = context,
				disallow = "all",
				allow = allow,
				direct_media = "no",
				force_rport = "yes",
				callerid = string.Format("{0}", tel)
			};
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							auseceEntities.ps_auths.Add(entity);
							auseceEntities.ps_aors.Add(entity2);
							auseceEntities.ps_endpoints.Add(entity3);
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
						}
						catch (Exception ex)
						{
							GenericModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							result.Message = ex.Message;
							return result;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				GenericModel.Log.Error(ex2, "Add phone to user fail");
				result.Message = ex2.Message;
				return result;
			}
			result.SetSuccess();
			return result;
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x0014C308 File Offset: 0x0014A508
		public static ps_auths GetPsAuth(int id)
		{
			ps_auths firstOrDefault;
			using (GenericRepository<ps_auths> genericRepository = new GenericRepository<ps_auths>())
			{
				genericRepository.AsNoTracking();
				firstOrDefault = genericRepository.GetFirstOrDefault((ps_auths a) => a.id == id, "");
			}
			return firstOrDefault;
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x0014C3B4 File Offset: 0x0014A5B4
		public static bool RemoveTel(int tel)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							string stringId = tel.ToString();
							ps_auths ps_auths = auseceEntities.ps_auths.FirstOrDefault((ps_auths a) => a.id == tel);
							ps_aors ps_aors = auseceEntities.ps_aors.FirstOrDefault((ps_aors a) => a.id == stringId);
							ps_endpoints ps_endpoints = auseceEntities.ps_endpoints.FirstOrDefault((ps_endpoints a) => a.id == tel);
							if (ps_auths != null)
							{
								auseceEntities.ps_auths.Remove(ps_auths);
							}
							if (ps_aors != null)
							{
								auseceEntities.ps_aors.Remove(ps_aors);
							}
							if (ps_endpoints != null)
							{
								auseceEntities.ps_endpoints.Remove(ps_endpoints);
							}
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
						}
						catch (Exception ex)
						{
							GenericModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							return false;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				GenericModel.Log.Error(ex2, ex2.Message);
				return false;
			}
			return true;
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x0014C640 File Offset: 0x0014A840
		public static bool UpdateEndpoint(int id, int tel, string password, string context, string allow)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (DbContextTransaction dbContextTransaction = auseceEntities.Database.BeginTransaction())
					{
						try
						{
							ps_endpoints ps_endpoints = auseceEntities.ps_endpoints.FirstOrDefault((ps_endpoints e) => e.id == id);
							ps_endpoints.id = tel;
							ps_endpoints.context = context;
							ps_endpoints.allow = allow;
							ps_auths ps_auths = auseceEntities.ps_auths.FirstOrDefault((ps_auths a) => a.id == id);
							ps_auths.id = tel;
							ps_auths.username = tel.ToString();
							ps_auths.password = password;
							auseceEntities.SaveChanges();
							dbContextTransaction.Commit();
						}
						catch (Exception ex)
						{
							GenericModel.Log.Error(ex, ex.Message);
							dbContextTransaction.Rollback();
							return false;
						}
					}
				}
			}
			catch (Exception ex2)
			{
				GenericModel.Log.Error(ex2, ex2.Message);
				return false;
			}
			return true;
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x0014C838 File Offset: 0x0014AA38
		public Task<List<queues>> LoadQueueses()
		{
			Task<List<queues>> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = auseceEntities.queues.ToListAsync<queues>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load queues fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x0014C898 File Offset: 0x0014AA98
		public static Task<IEnumerable<queue_members>> LoadQueueMembers(queues queue)
		{
			Task<IEnumerable<queue_members>> allAsync;
			using (GenericRepository<queue_members> genericRepository = new GenericRepository<queue_members>())
			{
				genericRepository.AsNoTracking();
				genericRepository.DisableProxyCreation();
				allAsync = genericRepository.GetAllAsync((queue_members m) => m.queue_name == queue.name, null, "users");
			}
			return allAsync;
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x0014C960 File Offset: 0x0014AB60
		public static List<QueueDiagram> LoadQueueDiagram()
		{
			List<QueueDiagram> list = new List<QueueDiagram>();
			List<QueueDiagram> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<queues> source = auseceEntities.queues.ToList<queues>();
					List<queue_members> allMembers = auseceEntities.queue_members.Include((queue_members m) => m.users).ToList<queue_members>();
					list.AddRange(from queue in source
					select new QueueDiagram
					{
						Name = queue.name,
						Members = (from m in allMembers
						where m.queue_name == queue.name
						select m).ToList<queue_members>()
					});
					result = list;
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = new List<QueueDiagram>();
			}
			return result;
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x0014CA44 File Offset: 0x0014AC44
		public void ServerReloadQueues()
		{
			ManagerConnection cnn = this.Cnn;
			if (cnn == null)
			{
				return;
			}
			cnn.SendAction(new QueueReloadAction());
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x0014CA68 File Offset: 0x0014AC68
		public Task<List<users>> LoadSipUsers()
		{
			Task<List<users>> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from u in auseceEntities.users
					where u.sip_user_id != null
					select u).ToListAsync<users>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load sip users fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x0014CB28 File Offset: 0x0014AD28
		public static Task<IEnumerable<ps_endpoints>> GetEndpoints()
		{
			VoipModel.<GetEndpoints>d__15 <GetEndpoints>d__;
			<GetEndpoints>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<ps_endpoints>>.Create();
			<GetEndpoints>d__.<>1__state = -1;
			<GetEndpoints>d__.<>t__builder.Start<VoipModel.<GetEndpoints>d__15>(ref <GetEndpoints>d__);
			return <GetEndpoints>d__.<>t__builder.Task;
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x0014CB64 File Offset: 0x0014AD64
		public void AddQueueMemberToRemoveList(queue_members user)
		{
			if (this._removedUsers == null)
			{
				this._removedUsers = new List<queue_members>();
			}
			this._removedUsers.Add(user);
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x0014CB90 File Offset: 0x0014AD90
		public void QueueRemoveFromDb(queues queue)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<queue_members> list = (from m in auseceEntities.queue_members
					where m.queue_name == queue.name
					select m).ToList<queue_members>();
					if (list.Any<queue_members>())
					{
						auseceEntities.queue_members.RemoveRange(list);
					}
					List<queues> list2 = (from q in auseceEntities.queues
					where q.name == queue.name
					select q).ToList<queues>();
					if (list2.Any<queues>())
					{
						auseceEntities.queues.RemoveRange(list2);
					}
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Remove queue from db fail");
			}
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x0014CD44 File Offset: 0x0014AF44
		public void DeleteQueueMembersFromDb()
		{
			if (this._removedUsers != null && this._removedUsers.Count != 0)
			{
				using (List<queue_members>.Enumerator enumerator = this._removedUsers.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						queue_members member = enumerator.Current;
						try
						{
							using (auseceEntities auseceEntities = new auseceEntities(true))
							{
								List<queue_members> list = (from m in auseceEntities.queue_members
								where m.membername == member.membername && m.queue_name == member.queue_name
								select m).ToList<queue_members>();
								if (list.Any<queue_members>())
								{
									auseceEntities.queue_members.RemoveRange(list);
									auseceEntities.SaveChanges();
								}
							}
						}
						catch (Exception exception)
						{
							GenericModel.Log.Error(exception, "Delete queue members fail");
						}
					}
				}
				return;
			}
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x0014CF1C File Offset: 0x0014B11C
		public void EmptyRemovedUsersList()
		{
			this._removedUsers = null;
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x0014CF30 File Offset: 0x0014B130
		public void AddQueueToDb(queues queue)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.queues.Add(queue);
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Add new queue to db fail");
			}
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x0014CF98 File Offset: 0x0014B198
		public void SaveExistQueue(queues queue)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.queues.Attach(queue);
					auseceEntities.Entry<queues>(queue).State = EntityState.Modified;
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Save exist queue settings fail");
			}
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x0014D00C File Offset: 0x0014B20C
		public List<AsteriskConfigCategory> GetDongleDevices()
		{
			if (!this.CheckConnection())
			{
				return null;
			}
			ManagerConnection cnn = this.Cnn;
			GetConfigResponse getConfigResponse = (GetConfigResponse)((cnn == null) ? null : cnn.SendAction(new GetConfigAction("dongle.conf")));
			if (getConfigResponse == null)
			{
				return null;
			}
			List<AsteriskConfigCategory> list = new List<AsteriskConfigCategory>();
			List<AsteriskConfigCategory> result;
			try
			{
				foreach (int num in getConfigResponse.Categories.Keys)
				{
					if (num >= 2)
					{
						AsteriskConfigCategory asteriskConfigCategory = new AsteriskConfigCategory(num, getConfigResponse.Categories[num]);
						list.Add(asteriskConfigCategory);
						foreach (int key in getConfigResponse.Lines(num).Keys)
						{
							string[] array = getConfigResponse.Lines(num)[key].Split(new char[]
							{
								'='
							}, StringSplitOptions.RemoveEmptyEntries);
							KeyValuePair<string, string> pair = new KeyValuePair<string, string>(array[0], array[1]);
							asteriskConfigCategory.AddValuePair(pair);
						}
					}
				}
				result = list;
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load dongle devices fail");
				result = null;
			}
			return result;
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x0014D16C File Offset: 0x0014B36C
		public AsteriskConfigCategory GetDongleDefaultSettings()
		{
			if (!this.CheckConnection())
			{
				return null;
			}
			ManagerConnection cnn = this.Cnn;
			GetConfigResponse getConfigResponse = ((cnn == null) ? null : cnn.SendAction(new GetConfigAction("dongle.conf"))) as GetConfigResponse;
			if (getConfigResponse == null)
			{
				return null;
			}
			AsteriskConfigCategory asteriskConfigCategory = null;
			foreach (int num in getConfigResponse.Categories.Keys)
			{
				if (!(getConfigResponse.Categories[num] != "defaults"))
				{
					asteriskConfigCategory = new AsteriskConfigCategory(num, getConfigResponse.Categories[num]);
					foreach (int key in getConfigResponse.Lines(num).Keys)
					{
						string[] array = getConfigResponse.Lines(num)[key].Split(new char[]
						{
							'='
						}, StringSplitOptions.RemoveEmptyEntries);
						KeyValuePair<string, string> pair = new KeyValuePair<string, string>(array[0], array[1]);
						asteriskConfigCategory.AddValuePair(pair);
					}
				}
			}
			return asteriskConfigCategory;
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x0014D2A8 File Offset: 0x0014B4A8
		private bool CheckConnection()
		{
			bool result;
			try
			{
				if (!this.Cnn.IsConnected())
				{
					this.Cnn.Login();
				}
				result = this.Cnn.IsConnected();
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x0014D2F4 File Offset: 0x0014B4F4
		public string SaveDongleDefSettings(AsteriskConfigCategory category)
		{
			if (this.CheckConnection())
			{
				goto IL_2C;
			}
			IL_08:
			int num = 44315109;
			IL_0D:
			UpdateConfigAction updateConfigAction;
			switch ((num ^ 1713582970) % 4)
			{
			case 0:
				IL_2C:
				updateConfigAction = new UpdateConfigAction("dongle.conf", "dongle.conf");
				num = 2088297663;
				goto IL_0D;
			case 2:
				goto IL_08;
			case 3:
				return null;
			}
			VoipModel.DongleDefaults(category, updateConfigAction, "update");
			ManagerConnection cnn = this.Cnn;
			if (cnn != null)
			{
				ManagerResponse managerResponse = cnn.SendAction(updateConfigAction);
				if (managerResponse != null)
				{
					return managerResponse.Response;
				}
			}
			return null;
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x0014D370 File Offset: 0x0014B570
		private static void DongleDefaults(AsteriskConfigCategory category, UpdateConfigAction act, string command)
		{
			act.AddCommand(command, category.Name, "rxgain", category.Rxgain);
			act.AddCommand(command, category.Name, "txgain", category.Txgain);
			act.AddCommand(command, category.Name, "context", category.Context);
			act.AddCommand(command, category.Name, "autodeletesms", category.Autodeletesms);
			act.AddCommand(command, category.Name, "disablesms", category.Disablesms);
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x0014D3F8 File Offset: 0x0014B5F8
		public string SaveDongleDevice(AsteriskConfigCategory category)
		{
			if (!this.CheckConnection())
			{
				return null;
			}
			if (!this.ContextExistInExtensionsConf(category.Context))
			{
				this.CreateRealtimeContextInExtensionsConf(category.Context);
			}
			UpdateConfigAction updateConfigAction = new UpdateConfigAction("dongle.conf", "dongle.conf");
			VoipModel.DongleDefaults(category, updateConfigAction, "update");
			updateConfigAction.AddCommand("update", category.Name, "audio", category.Audio);
			updateConfigAction.AddCommand("update", category.Name, "data", category.Data);
			ManagerConnection cnn = this.Cnn;
			if (cnn != null)
			{
				ManagerResponse managerResponse = cnn.SendAction(updateConfigAction);
				if (managerResponse != null)
				{
					return managerResponse.Response;
				}
			}
			return null;
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x0014D49C File Offset: 0x0014B69C
		public string AddDongleDevice(AsteriskConfigCategory category)
		{
			if (!this.CheckConnection())
			{
				return null;
			}
			if (!this.ContextExistInExtensionsConf(category.Context))
			{
				this.CreateRealtimeContextInExtensionsConf(category.Context);
			}
			UpdateConfigAction updateConfigAction = new UpdateConfigAction("dongle.conf", "dongle.conf");
			updateConfigAction.AddCommand("newcat", category.Name);
			VoipModel.DongleDefaults(category, updateConfigAction, "append");
			updateConfigAction.AddCommand("append", category.Name, "audio", category.Audio);
			updateConfigAction.AddCommand("append", category.Name, "data", category.Data);
			ManagerConnection cnn = this.Cnn;
			if (cnn != null)
			{
				ManagerResponse managerResponse = cnn.SendAction(updateConfigAction);
				if (managerResponse != null)
				{
					return managerResponse.Response;
				}
			}
			return null;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x0014D550 File Offset: 0x0014B750
		public void CreateRealtimeContextInExtensionsConf(string contextName)
		{
			if (!this.CheckConnection())
			{
				return;
			}
			UpdateConfigAction updateConfigAction = new UpdateConfigAction("extensions.conf", "extensions.conf");
			updateConfigAction.AddCommand("newcat", contextName);
			updateConfigAction.AddCommand("append", contextName, "switch", ">Realtime");
			ManagerConnection cnn = this.Cnn;
			if (cnn != null)
			{
				cnn.SendAction(updateConfigAction);
				return;
			}
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x0014D5AC File Offset: 0x0014B7AC
		public string DeleteDongleDevice(AsteriskConfigCategory category)
		{
			if (!this.CheckConnection())
			{
				return null;
			}
			UpdateConfigAction updateConfigAction = new UpdateConfigAction("dongle.conf", "dongle.conf");
			updateConfigAction.AddCommand("delcat", category.Name);
			ManagerConnection cnn = this.Cnn;
			if (cnn != null)
			{
				ManagerResponse managerResponse = cnn.SendAction(updateConfigAction);
				if (managerResponse != null)
				{
					return managerResponse.Response;
				}
			}
			return null;
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x0014D604 File Offset: 0x0014B804
		public string ServerCliExecute(string cmd)
		{
			if (!this.CheckConnection())
			{
				return null;
			}
			ManagerConnection cnn = this.Cnn;
			ManagerResponse managerResponse = (cnn == null) ? null : cnn.SendAction(new CommandAction(cmd));
			if (((managerResponse != null) ? managerResponse.Attributes : null) != null && managerResponse.Attributes.Count > 0)
			{
				string text = "";
				foreach (KeyValuePair<string, string> keyValuePair in managerResponse.Attributes)
				{
					text = text + keyValuePair.Value + "\r\n";
				}
				return text;
			}
			return "";
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x0014D6B4 File Offset: 0x0014B8B4
		public Task<List<ps_endpoints>> GetZadarmaEndpoints()
		{
			Task<List<ps_endpoints>> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from e in auseceEntities.ps_endpoints
					where e.from_domain == "sip.zadarma.com"
					select e).ToListAsync<ps_endpoints>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Get zadarma endpoints fail ");
				result = null;
			}
			return result;
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x0014D76C File Offset: 0x0014B96C
		public static Task<ps_aors> GetAorById(string aorId)
		{
			Task<ps_aors> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from e in auseceEntities.ps_aors
					where e.id == aorId
					select e).FirstOrDefaultAsync<ps_aors>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Get zadarma endpoints fail ");
				result = null;
			}
			return result;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x0014D83C File Offset: 0x0014BA3C
		public bool EndpointUpdateSetting(ps_endpoints endpoint)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.ps_endpoints.Attach(endpoint);
					auseceEntities.Entry<ps_endpoints>(endpoint).State = EntityState.Modified;
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Save endpoint fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x0014D8B4 File Offset: 0x0014BAB4
		public bool AorUpdateSetting(ps_aors aor)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.ps_aors.Attach(aor);
					auseceEntities.Entry<ps_aors>(aor).State = EntityState.Modified;
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Save aor fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x0014D92C File Offset: 0x0014BB2C
		public bool RemoveTrunkFromDb(int id)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<ps_endpoints> list = (from e in auseceEntities.ps_endpoints
					where e.id == id
					select e).ToList<ps_endpoints>();
					if (list.Any<ps_endpoints>())
					{
						auseceEntities.ps_endpoints.RemoveRange(list);
					}
					List<ps_aors> list2 = (from e in auseceEntities.ps_aors
					where e.id == id.ToString()
					select e).ToList<ps_aors>();
					if (list2.Any<ps_aors>())
					{
						auseceEntities.ps_aors.RemoveRange(list2);
					}
					List<ps_endpoint_id_ips> list3 = (from e in auseceEntities.ps_endpoint_id_ips
					where e.endpoint == id.ToString()
					select e).ToList<ps_endpoint_id_ips>();
					if (list3.Any<ps_endpoint_id_ips>())
					{
						auseceEntities.ps_endpoint_id_ips.RemoveRange(list3);
					}
					List<ps_domain_aliases> list4 = (from e in auseceEntities.ps_domain_aliases
					where e.id == id.ToString()
					select e).ToList<ps_domain_aliases>();
					if (list4.Any<ps_domain_aliases>())
					{
						auseceEntities.ps_domain_aliases.RemoveRange(list4);
					}
					List<ps_registrations> list5 = (from e in auseceEntities.ps_registrations
					where e.contact_user == id.ToString()
					select e).ToList<ps_registrations>();
					if (list5.Any<ps_registrations>())
					{
						auseceEntities.ps_registrations.RemoveRange(list5);
					}
					auseceEntities.SaveChanges();
					result = true;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Remove trunk fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x0014DCC0 File Offset: 0x0014BEC0
		public List<string> LoadContextFromPsEndpoints()
		{
			List<string> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from e in auseceEntities.ps_endpoints
					where e.context != ""
					select e.context).Distinct<string>().ToList<string>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load contexts from endpoints fail");
				result = new List<string>();
			}
			return result;
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x0014DDBC File Offset: 0x0014BFBC
		public List<string> LoadContextFromDongleConf()
		{
			List<AsteriskConfigCategory> dongleDevices = this.GetDongleDevices();
			List<string> result;
			if (dongleDevices != null)
			{
				if ((result = (from d in dongleDevices
				select d.Context).ToList<string>()) != null)
				{
					return result;
				}
			}
			result = new List<string>();
			return result;
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x0014DE08 File Offset: 0x0014C008
		public List<string> LoadAllExistContext()
		{
			List<string> list = new List<string>();
			list.AddRange(this.LoadContextFromPsEndpoints());
			list.AddRange(this.LoadContextFromDongleConf());
			return list.Distinct<string>().ToList<string>();
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x0014DE3C File Offset: 0x0014C03C
		public List<extensions> LoadContextDialplan(string contextName)
		{
			List<extensions> result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					result = (from e in auseceEntities.extensions
					where e.context == contextName
					orderby e.exten, e.priority
					select e).ToList<extensions>();
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load context dialplan fail");
				result = new List<extensions>();
			}
			return result;
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x0014DF8C File Offset: 0x0014C18C
		public bool ClearContextDialplan(string contextName)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<extensions> list = (from e in auseceEntities.extensions
					where e.context == contextName
					select e).ToList<extensions>();
					if (!list.Any<extensions>())
					{
						result = false;
					}
					else
					{
						auseceEntities.extensions.RemoveRange(list);
						auseceEntities.SaveChanges();
						result = true;
					}
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Load context dialplan fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x0014E084 File Offset: 0x0014C284
		public bool ContextExistInExtensionsConf(string contextName)
		{
			if (!this.CheckConnection())
			{
				return false;
			}
			ManagerConnection cnn = this.Cnn;
			GetConfigResponse getConfigResponse = ((cnn == null) ? null : cnn.SendAction(new GetConfigAction("extensions.conf"))) as GetConfigResponse;
			if (getConfigResponse != null)
			{
				using (Dictionary<int, string>.KeyCollection.Enumerator enumerator = getConfigResponse.Categories.Keys.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int key = enumerator.Current;
						if (!(getConfigResponse.Categories[key] != contextName))
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
			return false;
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x0014E124 File Offset: 0x0014C324
		public bool RemoveDialplanActionFromDb(extensions extension)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<extensions> list = (from e in auseceEntities.extensions
					where e.context == extension.context && e.exten == extension.exten && e.priority > extension.priority
					select e).ToList<extensions>();
					List<extensions> list2 = (from e in auseceEntities.extensions
					where e.id == extension.id
					select e).ToList<extensions>();
					if (list2.Any<extensions>())
					{
						auseceEntities.extensions.RemoveRange(list2);
						auseceEntities.SaveChanges();
					}
					if (list.Any<extensions>())
					{
						foreach (extensions extensions in list)
						{
							extensions.priority--;
						}
						auseceEntities.SaveChanges();
					}
					result = true;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Remove dialplan action fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x0014E3D0 File Offset: 0x0014C5D0
		public bool AddDialplanActionPlayFileToDb(string path, string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "Background",
				appdata = (path ?? ""),
				action_id = 3
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x0014E41C File Offset: 0x0014C61C
		public bool AddDialplanActionSendToIntNumberToDb(users user, bool toCalled, string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "Dial",
				appdata = (toCalled ? "PJSIP/${EXTEN}" : string.Format("PJSIP/{0}", user.sip_user_id)),
				action_id = 5
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x0014E47C File Offset: 0x0014C67C
		public bool AddDialplanActionSendToTrunkToDb(ps_endpoints endpoint, string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "Dial",
				appdata = "PJSIP/${EXTEN}@" + endpoint.aors,
				action_id = 9
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x0014E4CC File Offset: 0x0014C6CC
		public bool AddDialplanActionSendToModemToDb(string modem, string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "Dial",
				appdata = "Dongle/" + modem + "/${EXTEN}",
				action_id = 10
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x0014E51C File Offset: 0x0014C71C
		public bool AddDialplanActionRecordCallToDb(string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "MixMonitor",
				appdata = "/var/www/html/records/${STRFTIME(${EPOCH},,%Y-%m/%d)}/audio-${UNIQUEID}.wav",
				action_id = 2
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x0014E560 File Offset: 0x0014C760
		public bool AddDialplanActionSaveSmsToDb(string asteriskPasswordDb, string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "System",
				appdata = string.Concat(new string[]
				{
					"echo \"INSERT INTO in_sms VALUES(NULL, NOW(), '${DATACARD}', '${CALLERID(num)}', '${SMS}', '0')\" | mysql --host 127.0.0.1 --port ",
					AuthModel.Port.ToString(),
					" -u asterisk -p",
					asteriskPasswordDb,
					" ",
					AuthModel.DbName
				}),
				action_id = 8
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x0014E5E0 File Offset: 0x0014C7E0
		public bool AddDialplanActionHangUpToDb(string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "Hangup",
				appdata = "",
				action_id = 6
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x0014E624 File Offset: 0x0014C824
		public bool AddDialplanActionQueueToDb(string queueName, string context, string dialplanExten, int priority)
		{
			extensions exten = new extensions
			{
				app = "Queue",
				appdata = queueName + ",t",
				action_id = 4
			};
			this.FillNewExtenCommanFields(context, dialplanExten, priority, exten);
			return this.AddDialplanActionToDb(exten, priority);
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x0014E670 File Offset: 0x0014C870
		private void FillNewExtenCommanFields(string context, string dialplanExten, int priority, extensions exten)
		{
			exten.priority = priority + 1;
			exten.exten = dialplanExten;
			exten.context = context;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x0014E698 File Offset: 0x0014C898
		private bool AddDialplanActionToDb(extensions exten, int priority)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<extensions> list = (from e in auseceEntities.extensions
					where e.context == exten.context && e.exten == exten.exten && e.priority > priority
					select e).ToList<extensions>();
					auseceEntities.extensions.Add(exten);
					auseceEntities.SaveChanges();
					if (list.Any<extensions>())
					{
						foreach (extensions extensions in list)
						{
							extensions.priority++;
						}
						auseceEntities.SaveChanges();
					}
					result = true;
				}
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Add Dialplan Action to db fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x0014E8A8 File Offset: 0x0014CAA8
		public Task<AudioFileUploadResponse> SendRecordToServer(string pathToFile)
		{
			VoipModel.<SendRecordToServer>d__54 <SendRecordToServer>d__;
			<SendRecordToServer>d__.<>t__builder = AsyncTaskMethodBuilder<AudioFileUploadResponse>.Create();
			<SendRecordToServer>d__.pathToFile = pathToFile;
			<SendRecordToServer>d__.<>1__state = -1;
			<SendRecordToServer>d__.<>t__builder.Start<VoipModel.<SendRecordToServer>d__54>(ref <SendRecordToServer>d__);
			return <SendRecordToServer>d__.<>t__builder.Task;
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x0014E8EC File Offset: 0x0014CAEC
		public bool AddZadarmaTrunk(ps_endpoints newZadarmaEndpoint, string newZadarmaAorContact)
		{
			ps_aors entity = new ps_aors
			{
				id = newZadarmaEndpoint.id.ToString(),
				contact = "sip:" + newZadarmaAorContact + "@sip.zadarma.com:5060",
				max_contacts = new int?(1)
			};
			ps_domain_aliases entity2 = new ps_domain_aliases
			{
				id = string.Format("{0}", newZadarmaEndpoint.id),
				domain = "sip.zadarma.com"
			};
			newZadarmaEndpoint.transport = "transport-udp";
			newZadarmaEndpoint.aors = newZadarmaEndpoint.id.ToString();
			newZadarmaEndpoint.context = "from-zadarma";
			newZadarmaEndpoint.from_domain = "sip.zadarma.com";
			newZadarmaEndpoint.disallow = "all";
			newZadarmaEndpoint.allow = "alaw,ulaw";
			newZadarmaEndpoint.direct_media = "no";
			ps_endpoint_id_ips entity3 = new ps_endpoint_id_ips
			{
				id = string.Format("{0}-1", newZadarmaEndpoint.id),
				endpoint = newZadarmaEndpoint.id.ToString(),
				match = "sip.zadarma.com"
			};
			ps_endpoint_id_ips entity4 = new ps_endpoint_id_ips
			{
				id = string.Format("{0}-2", newZadarmaEndpoint.id),
				endpoint = newZadarmaEndpoint.id.ToString(),
				match = "sipfr.zadarma.com"
			};
			ps_endpoint_id_ips entity5 = new ps_endpoint_id_ips
			{
				id = string.Format("{0}-3", newZadarmaEndpoint.id),
				endpoint = newZadarmaEndpoint.id.ToString(),
				match = "sipde.zadarma.com"
			};
			ps_registrations entity6 = new ps_registrations
			{
				id = string.Format("{0}", newZadarmaEndpoint.id),
				client_uri = string.Format("sip:{0}@{1}", newZadarmaEndpoint.id, "sip.zadarma.com"),
				contact_user = string.Format("{0}", newZadarmaEndpoint.id),
				expiration = new int?(120),
				outbound_auth = string.Format("{0}_auth", newZadarmaEndpoint.id),
				retry_interval = new int?(60),
				server_uri = "sip:sip.zadarma.com",
				transport = "transport-udp"
			};
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.ps_aors.Add(entity);
					auseceEntities.ps_domain_aliases.Add(entity2);
					auseceEntities.ps_endpoints.Add(newZadarmaEndpoint);
					auseceEntities.ps_registrations.Add(entity6);
					auseceEntities.ps_endpoint_id_ips.Add(entity3);
					auseceEntities.ps_endpoint_id_ips.Add(entity4);
					auseceEntities.ps_endpoint_id_ips.Add(entity5);
					auseceEntities.SaveChanges();
				}
				return true;
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Add new zadarma trunk fail");
				result = false;
			}
			return result;
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x0014EBE4 File Offset: 0x0014CDE4
		public List<ExtenVisObj> BuildDialplanDiagramm(string contextName, List<string> dialplanExtens)
		{
			ExtenVisObj extenVisObj = new ExtenVisObj
			{
				Name = contextName
			};
			using (List<string>.Enumerator enumerator = dialplanExtens.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string exten = enumerator.Current;
					ExtenVisObj extenVisObj2 = new ExtenVisObj
					{
						Name = exten
					};
					List<extensions> list = (from c in this.LoadContextDialplan(contextName)
					orderby c.priority
					where c.exten == exten
					select c).ToList<extensions>();
					ExtenVisObj extenVisObj3 = null;
					foreach (extensions extensions in list)
					{
						if (extenVisObj3 == null)
						{
							extenVisObj2.Children.Add(new ExtenVisObj
							{
								Priority = extensions.priority,
								Name = extensions.Actions.Name,
								AdditionalInfo = extensions.ActionParam
							});
							extenVisObj3 = extenVisObj2.Children[0];
						}
						else
						{
							extenVisObj3.Children.Add(new ExtenVisObj
							{
								Priority = extensions.priority,
								Name = extensions.Actions.Name,
								AdditionalInfo = extensions.ActionParam
							});
							extenVisObj3 = extenVisObj3.Children[0];
						}
					}
					extenVisObj.Children.Add(extenVisObj2);
				}
			}
			return new List<ExtenVisObj>
			{
				extenVisObj
			};
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x0014EDAC File Offset: 0x0014CFAC
		public bool SaveQueueMembers(IEnumerable<queue_members> members)
		{
			this.DeleteQueueMembersFromDb();
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					using (IEnumerator<queue_members> enumerator = members.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							queue_members m = enumerator.Current;
							queue_members queue_members = auseceEntities.queue_members.FirstOrDefault((queue_members q) => q.uniqueid == m.uniqueid);
							if (queue_members != null)
							{
								auseceEntities.Entry<queue_members>(queue_members).CurrentValues.SetValues(m);
							}
						}
					}
					auseceEntities.SaveChanges();
				}
				goto IL_10F;
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = false;
			}
			return result;
			IL_10F:
			this.ServerReloadQueues();
			this.EmptyRemovedUsersList();
			return true;
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x0014EF00 File Offset: 0x0014D100
		public static bool AddEndpointToQueue(ps_endpoints endpoint, string queueName)
		{
			queue_members entity = new queue_members
			{
				queue_name = queueName,
				@interface = string.Format("PJSIP/{0}", endpoint.id),
				membername = endpoint.id.ToString(),
				penalty = new int?(0)
			};
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.queue_members.Add(entity);
					auseceEntities.SaveChanges();
				}
				return true;
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x0014EFB8 File Offset: 0x0014D1B8
		public static List<IIdName> GetVoIPClients()
		{
			return new List<IIdName>
			{
				new IdNameClass(1, "Zadarma"),
				new IdNameClass(4, "Rostelecom"),
				new IdNameClass(2, "Asterisk Realtime"),
				new IdNameClass(5, "Mango Telecom"),
				new IdNameClass(6, "Megafon")
			};
		}

		// Token: 0x040033A3 RID: 13219
		private const string Transport = "transport-udp";

		// Token: 0x040033A4 RID: 13220
		public ManagerConnection Cnn;

		// Token: 0x040033A5 RID: 13221
		private List<users> Users;

		// Token: 0x040033A6 RID: 13222
		private List<queue_members> _removedUsers;

		// Token: 0x02000AA3 RID: 2723
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004E3D RID: 20029 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040033A7 RID: 13223
			public string phone;

			// Token: 0x040033A8 RID: 13224
			public string phone8;
		}

		// Token: 0x02000AA4 RID: 2724
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E3E RID: 20030 RVA: 0x0014F020 File Offset: 0x0014D220
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004E3F RID: 20031 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004E40 RID: 20032 RVA: 0x0014F038 File Offset: 0x0014D238
			internal string <LoadContextFromDongleConf>b__38_0(AsteriskConfigCategory d)
			{
				return d.Context;
			}

			// Token: 0x06004E41 RID: 20033 RVA: 0x0014F04C File Offset: 0x0014D24C
			internal int <BuildDialplanDiagramm>b__56_0(extensions c)
			{
				return c.priority;
			}

			// Token: 0x040033A9 RID: 13225
			public static readonly VoipModel.<>c <>9 = new VoipModel.<>c();

			// Token: 0x040033AA RID: 13226
			public static Func<AsteriskConfigCategory, string> <>9__38_0;

			// Token: 0x040033AB RID: 13227
			public static Func<extensions, int> <>9__56_0;
		}

		// Token: 0x02000AA5 RID: 2725
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06004E42 RID: 20034 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x040033AC RID: 13228
			public int id;
		}

		// Token: 0x02000AA6 RID: 2726
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004E43 RID: 20035 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x040033AD RID: 13229
			public int tel;
		}

		// Token: 0x02000AA7 RID: 2727
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_1
		{
			// Token: 0x06004E44 RID: 20036 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass8_1()
			{
			}

			// Token: 0x040033AE RID: 13230
			public string stringId;
		}

		// Token: 0x02000AA8 RID: 2728
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004E45 RID: 20037 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x040033AF RID: 13231
			public int id;
		}

		// Token: 0x02000AA9 RID: 2729
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06004E46 RID: 20038 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x040033B0 RID: 13232
			public queues queue;
		}

		// Token: 0x02000AAA RID: 2730
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004E47 RID: 20039 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06004E48 RID: 20040 RVA: 0x0014F060 File Offset: 0x0014D260
			internal QueueDiagram <LoadQueueDiagram>b__1(queues queue)
			{
				VoipModel.<>c__DisplayClass12_1 CS$<>8__locals1 = new VoipModel.<>c__DisplayClass12_1();
				CS$<>8__locals1.queue = queue;
				return new QueueDiagram
				{
					Name = CS$<>8__locals1.queue.name,
					Members = this.allMembers.Where(new Func<queue_members, bool>(CS$<>8__locals1.<LoadQueueDiagram>b__2)).ToList<queue_members>()
				};
			}

			// Token: 0x040033B1 RID: 13233
			public List<queue_members> allMembers;
		}

		// Token: 0x02000AAB RID: 2731
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_1
		{
			// Token: 0x06004E49 RID: 20041 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass12_1()
			{
			}

			// Token: 0x06004E4A RID: 20042 RVA: 0x0014F0B4 File Offset: 0x0014D2B4
			internal bool <LoadQueueDiagram>b__2(queue_members m)
			{
				return m.queue_name == this.queue.name;
			}

			// Token: 0x040033B2 RID: 13234
			public queues queue;
		}

		// Token: 0x02000AAC RID: 2732
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetEndpoints>d__15 : IAsyncStateMachine
		{
			// Token: 0x06004E4B RID: 20043 RVA: 0x0014F0D8 File Offset: 0x0014D2D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				IEnumerable<ps_endpoints> result;
				try
				{
					if (num != 0)
					{
						this.<repo>5__2 = new GenericRepository<ps_endpoints>();
					}
					try
					{
						TaskAwaiter<IEnumerable<ps_endpoints>> awaiter;
						if (num != 0)
						{
							awaiter = this.<repo>5__2.GetAllAsync(null, null, "").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<ps_endpoints>>, VoipModel.<GetEndpoints>d__15>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<IEnumerable<ps_endpoints>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						result = awaiter.GetResult();
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

			// Token: 0x06004E4C RID: 20044 RVA: 0x0014F1C4 File Offset: 0x0014D3C4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033B3 RID: 13235
			public int <>1__state;

			// Token: 0x040033B4 RID: 13236
			public AsyncTaskMethodBuilder<IEnumerable<ps_endpoints>> <>t__builder;

			// Token: 0x040033B5 RID: 13237
			private GenericRepository<ps_endpoints> <repo>5__2;

			// Token: 0x040033B6 RID: 13238
			private TaskAwaiter<IEnumerable<ps_endpoints>> <>u__1;
		}

		// Token: 0x02000AAD RID: 2733
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06004E4D RID: 20045 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x040033B7 RID: 13239
			public queues queue;
		}

		// Token: 0x02000AAE RID: 2734
		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06004E4E RID: 20046 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x040033B8 RID: 13240
			public queue_members member;
		}

		// Token: 0x02000AAF RID: 2735
		[CompilerGenerated]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06004E4F RID: 20047 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x040033B9 RID: 13241
			public string aorId;
		}

		// Token: 0x02000AB0 RID: 2736
		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x06004E50 RID: 20048 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x040033BA RID: 13242
			public int id;
		}

		// Token: 0x02000AB1 RID: 2737
		[CompilerGenerated]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x06004E51 RID: 20049 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x040033BB RID: 13243
			public string contextName;
		}

		// Token: 0x02000AB2 RID: 2738
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06004E52 RID: 20050 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x040033BC RID: 13244
			public string contextName;
		}

		// Token: 0x02000AB3 RID: 2739
		[CompilerGenerated]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x06004E53 RID: 20051 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x040033BD RID: 13245
			public extensions extension;
		}

		// Token: 0x02000AB4 RID: 2740
		[CompilerGenerated]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06004E54 RID: 20052 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x040033BE RID: 13246
			public extensions exten;

			// Token: 0x040033BF RID: 13247
			public int priority;
		}

		// Token: 0x02000AB5 RID: 2741
		[CompilerGenerated]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x06004E55 RID: 20053 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x06004E56 RID: 20054 RVA: 0x0014F1E0 File Offset: 0x0014D3E0
			internal void <SendRecordToServer>b__0(CapturedMultipartContent mp)
			{
				mp.AddFile("file", this.pathToFile, null, 4096);
			}

			// Token: 0x040033C0 RID: 13248
			public string pathToFile;
		}

		// Token: 0x02000AB6 RID: 2742
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SendRecordToServer>d__54 : IAsyncStateMachine
		{
			// Token: 0x06004E57 RID: 20055 RVA: 0x0014F208 File Offset: 0x0014D408
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				AudioFileUploadResponse result;
				try
				{
					VoipModel.<>c__DisplayClass54_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new VoipModel.<>c__DisplayClass54_0();
						CS$<>8__locals1.pathToFile = this.pathToFile;
					}
					try
					{
						TaskAwaiter<AudioFileUploadResponse> awaiter;
						if (num != 0)
						{
							awaiter = string.Format("http://{0}:{1}/uploadRecord.php", Auth.Config.aster_host, Auth.Config.aster_web_port).PostMultipartAsync(new Action<CapturedMultipartContent>(CS$<>8__locals1.<SendRecordToServer>b__0), default(CancellationToken)).ReceiveJson<AudioFileUploadResponse>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<AudioFileUploadResponse>, VoipModel.<SendRecordToServer>d__54>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<AudioFileUploadResponse>);
							this.<>1__state = -1;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						GenericModel.Log.Error(exception, "Send record audio file to Asterisk server fail");
						result = null;
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

			// Token: 0x06004E58 RID: 20056 RVA: 0x0014F330 File Offset: 0x0014D530
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040033C1 RID: 13249
			public int <>1__state;

			// Token: 0x040033C2 RID: 13250
			public AsyncTaskMethodBuilder<AudioFileUploadResponse> <>t__builder;

			// Token: 0x040033C3 RID: 13251
			public string pathToFile;

			// Token: 0x040033C4 RID: 13252
			private TaskAwaiter<AudioFileUploadResponse> <>u__1;
		}

		// Token: 0x02000AB7 RID: 2743
		[CompilerGenerated]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x06004E59 RID: 20057 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x06004E5A RID: 20058 RVA: 0x0014F34C File Offset: 0x0014D54C
			internal bool <BuildDialplanDiagramm>b__1(extensions c)
			{
				return c.exten == this.exten;
			}

			// Token: 0x040033C5 RID: 13253
			public string exten;
		}

		// Token: 0x02000AB8 RID: 2744
		[CompilerGenerated]
		private sealed class <>c__DisplayClass57_0
		{
			// Token: 0x06004E5B RID: 20059 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass57_0()
			{
			}

			// Token: 0x040033C6 RID: 13254
			public queue_members m;
		}
	}
}
