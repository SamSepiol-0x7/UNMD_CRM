using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Extensions.EpochtaSms;
using ASC.Extensions.SmsRu;
using ASC.Interfaces;
using ASC.SimpleClasses;
using Autofac;
using Newtonsoft.Json;
using NLog;

namespace ASC.Models
{
	// Token: 0x02000989 RID: 2441
	public class SmsModel : GenericModel
	{
		// Token: 0x06004A17 RID: 18967 RVA: 0x00126C20 File Offset: 0x00124E20
		public static IEnumerable<sms_templates> LoadTemplates()
		{
			IEnumerable<sms_templates> all;
			using (GenericRepository<sms_templates> genericRepository = new GenericRepository<sms_templates>())
			{
				all = genericRepository.GetAll(null, null, "");
			}
			return all;
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00126C60 File Offset: 0x00124E60
		public static Task<string> GetBalance()
		{
			SmsModel.<GetBalance>d__1 <GetBalance>d__;
			<GetBalance>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetBalance>d__.<>1__state = -1;
			<GetBalance>d__.<>t__builder.Start<SmsModel.<GetBalance>d__1>(ref <GetBalance>d__);
			return <GetBalance>d__.<>t__builder.Task;
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x00126C9C File Offset: 0x00124E9C
		public static bool SaveSmsTemplates(IEnumerable<sms_templates> templates)
		{
			bool result;
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					List<sms_templates> source = templates.ToList<sms_templates>();
					foreach (sms_templates entity in from t in source
					where t.id == 0
					select t)
					{
						auseceEntities.sms_templates.Add(entity);
					}
					foreach (sms_templates sms_templates in from t in source
					where t.id > 0
					select t)
					{
						sms_templates sms_templates2 = auseceEntities.sms_templates.Find(new object[]
						{
							sms_templates.id
						});
						if (sms_templates2 != null)
						{
							auseceEntities.Entry<sms_templates>(sms_templates2).CurrentValues.SetValues(sms_templates);
						}
					}
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

		// Token: 0x06004A1A RID: 18970 RVA: 0x00126DF8 File Offset: 0x00124FF8
		public static bool SaveEmailConfig(Email emailConfogRaw)
		{
			bool result;
			try
			{
				string email_config = JsonConvert.SerializeObject(emailConfogRaw);
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					config config = new config
					{
						id = 1
					};
					auseceEntities.config.Attach(config);
					config.email_config = email_config;
					auseceEntities.SaveChanges();
					Auth.Config.email_config = email_config;
				}
				return true;
			}
			catch (Exception ex)
			{
				ILogger log = GenericModel.Log;
				string str = "Email config save error ";
				Exception ex2 = ex;
				log.Error(str + ((ex2 != null) ? ex2.ToString() : null));
				result = false;
			}
			return result;
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00126EA8 File Offset: 0x001250A8
		public static bool SaveSmsConfig(SmsClientConfig smsConfigRaw)
		{
			bool result;
			try
			{
				string sms_config = JsonConvert.SerializeObject(smsConfigRaw);
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					auseceEntities.Configuration.ValidateOnSaveEnabled = false;
					config config = new config
					{
						id = 1
					};
					auseceEntities.config.Attach(config);
					config.sms_config = sms_config;
					auseceEntities.SaveChanges();
					Auth.Config.sms_config = sms_config;
				}
				return true;
			}
			catch (Exception exception)
			{
				GenericModel.Log.Error(exception, "Sms config save error ");
				result = false;
			}
			return result;
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00126F48 File Offset: 0x00125148
		public static bool RemoveSmsTemplate(sms_templates template)
		{
			try
			{
				using (auseceEntities auseceEntities = new auseceEntities(true))
				{
					sms_templates sms_templates = auseceEntities.sms_templates.Find(new object[]
					{
						template.id
					});
					if (sms_templates == null)
					{
						return false;
					}
					auseceEntities.sms_templates.Remove(sms_templates);
					auseceEntities.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				return false;
			}
			return true;
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00126FDC File Offset: 0x001251DC
		public static string GetTemplateById(int templateId)
		{
			string result;
			using (GenericRepository<sms_templates> genericRepository = new GenericRepository<sms_templates>())
			{
				sms_templates firstOrDefault = genericRepository.GetFirstOrDefault((sms_templates t) => t.id == templateId, "");
				result = ((firstOrDefault == null) ? "" : firstOrDefault.message);
			}
			return result;
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00127098 File Offset: 0x00125298
		public static SmsClientConfig GetSmsClientConfig()
		{
			SmsClientConfig result;
			try
			{
				result = ((Auth.Config.sms_config == null) ? null : JsonConvert.DeserializeObject<SmsClientConfig>(Auth.Config.sms_config));
			}
			catch (Exception ex)
			{
				GenericModel.Log.Error(ex, ex.Message);
				result = null;
			}
			return result;
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x0005E808 File Offset: 0x0005CA08
		public SmsModel()
		{
		}

		// Token: 0x0200098A RID: 2442
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetBalance>d__1 : IAsyncStateMachine
		{
			// Token: 0x06004A20 RID: 18976 RVA: 0x001270F0 File Offset: 0x001252F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				string result;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						SmsClientConfig smsClientConfig;
						ISmsClient smsClient;
						for (;;)
						{
							IL_CE:
							smsClientConfig = SmsModel.GetSmsClientConfig();
							if (smsClientConfig == null)
							{
								goto IL_13D;
							}
							for (;;)
							{
								IL_CA:
								smsClient = null;
								for (;;)
								{
									IL_C0:
									int provider = smsClientConfig.Provider;
									for (;;)
									{
										IL_A6:
										switch (provider)
										{
										case 1:
											goto IL_D9;
										case 2:
											goto IL_E2;
										case 3:
											goto IL_EB;
										default:
										{
											uint num3;
											uint num2 = num3 * 2031997567U ^ 3973896291U;
											for (;;)
											{
												switch ((num3 = (num2 ^ 4290849295U)) % 24U)
												{
												case 0U:
												case 23U:
													goto IL_CE;
												case 1U:
													goto IL_CA;
												case 2U:
													goto IL_125;
												case 3U:
													goto IL_133;
												case 5U:
													goto IL_13D;
												case 6U:
													goto IL_135;
												case 7U:
													goto IL_A6;
												case 8U:
													goto IL_E2;
												case 9U:
													goto IL_114;
												case 11U:
												case 22U:
													goto IL_FB;
												case 12U:
													goto IL_C0;
												case 13U:
													goto IL_FE;
												case 14U:
													goto IL_10B;
												case 16U:
													goto IL_145;
												case 17U:
													goto IL_D9;
												case 18U:
													goto IL_162;
												case 19U:
													goto IL_EB;
												case 20U:
													goto IL_11D;
												case 21U:
													num2 = (num3 * 2342973734U ^ 2306845282U);
													continue;
												}
												goto Block_4;
											}
											break;
										}
										}
									}
								}
							}
						}
						Block_4:
						goto IL_16A;
						IL_D9:
						smsClient = new SmsRuClient(smsClientConfig);
						goto IL_FB;
						IL_E2:
						smsClient = new EpochtaSmsClient(smsClientConfig);
						goto IL_FB;
						IL_EB:
						smsClient = Bootstrapper.Container.ResolveKeyed("SMSC");
						IL_FB:
						if (smsClient == null)
						{
							goto IL_135;
						}
						IL_FE:
						awaiter = smsClient.BalanceAsync().GetAwaiter();
						IL_10B:
						if (awaiter.IsCompleted)
						{
							goto IL_162;
						}
						IL_114:
						this.<>1__state = 0;
						IL_11D:
						this.<>u__1 = awaiter;
						IL_125:
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SmsModel.<GetBalance>d__1>(ref awaiter, ref this);
						IL_133:
						return;
						IL_135:
						result = "Sms provider not found";
						goto IL_185;
						IL_13D:
						result = "Sms client not configured";
						goto IL_185;
					}
					IL_145:
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<string>);
					this.<>1__state = -1;
					IL_162:
					result = awaiter.GetResult();
					IL_16A:;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_185:
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06004A21 RID: 18977 RVA: 0x001272B4 File Offset: 0x001254B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002F4A RID: 12106
			public int <>1__state;

			// Token: 0x04002F4B RID: 12107
			public AsyncTaskMethodBuilder<string> <>t__builder;

			// Token: 0x04002F4C RID: 12108
			private TaskAwaiter<string> <>u__1;
		}

		// Token: 0x0200098B RID: 2443
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004A22 RID: 18978 RVA: 0x001272D0 File Offset: 0x001254D0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004A23 RID: 18979 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06004A24 RID: 18980 RVA: 0x001272E8 File Offset: 0x001254E8
			internal bool <SaveSmsTemplates>b__2_0(sms_templates t)
			{
				return t.id == 0;
			}

			// Token: 0x06004A25 RID: 18981 RVA: 0x00127300 File Offset: 0x00125500
			internal bool <SaveSmsTemplates>b__2_1(sms_templates t)
			{
				return t.id > 0;
			}

			// Token: 0x04002F4D RID: 12109
			public static readonly SmsModel.<>c <>9 = new SmsModel.<>c();

			// Token: 0x04002F4E RID: 12110
			public static Func<sms_templates, bool> <>9__2_0;

			// Token: 0x04002F4F RID: 12111
			public static Func<sms_templates, bool> <>9__2_1;
		}

		// Token: 0x0200098C RID: 2444
		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06004A26 RID: 18982 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x04002F50 RID: 12112
			public int templateId;
		}
	}
}
