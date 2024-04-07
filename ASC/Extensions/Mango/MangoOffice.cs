using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Objects;
using ASC.Common.Objects.VoIP;
using ASC.Common.Repositories;
using ASC.Objects;
using ASC.Voip.Mango.Core;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace ASC.Extensions.Mango
{
	// Token: 0x02000BC1 RID: 3009
	public class MangoOffice : IVoIP
	{
		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06005446 RID: 21574 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		public bool IsBalanceCheckAvailable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x00169E7C File Offset: 0x0016807C
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x00169E90 File Offset: 0x00168090
		public EventHandler<AscCallArgs> OnAgentCalled
		{
			[CompilerGenerated]
			get
			{
				return this.<OnAgentCalled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnAgentCalled>k__BackingField = value;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x00169EA4 File Offset: 0x001680A4
		// (set) Token: 0x0600544A RID: 21578 RVA: 0x00169EB8 File Offset: 0x001680B8
		public EventHandler<AscCallArgs> OnAnswer
		{
			[CompilerGenerated]
			get
			{
				return this.<OnAnswer>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<OnAnswer>k__BackingField = value;
			}
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00169ECC File Offset: 0x001680CC
		public MangoOffice(IRepository<hooks> hooksRepository)
		{
			this._hooksRepository = hooksRepository;
			this._hooksRepository.AsNoTracking();
			this._hooksRepository.SetTimeout(5);
			this._extension = OfflineData.Instance.Employee.Tel;
			this._rows = -1;
			this._client = new MangoVPBXClient(new AuthorizeInfo(OfflineData.Instance.Settings.VoipKey, OfflineData.Instance.Settings.VoipSecret));
			this._backupTimer = new Timer(new TimerCallback(this.CheckCalls), null, 2000, 1000);
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00169F74 File Offset: 0x00168174
		private void CheckCalls(object state)
		{
			if (!this._busy && this._serverInfo.Connected)
			{
				this._busy = true;
				try
				{
					int num = this._hooksRepository.Count((hooks i) => i.hook_id == 5L && i.@event == "APPEARED" && i.p0 == (long?)this._extension);
					if (num == -1)
					{
						return;
					}
					if (this._rows == -1)
					{
						this._rows = num;
					}
					if (num != this._rows)
					{
						this._rows = num;
						hooks firstOrDefault = this._hooksRepository.GetFirstOrDefault((hooks i) => i.hook_id == 5L && i.@event == "APPEARED" && i.p0 == (long?)this._extension, delegate(IQueryable<hooks> i)
						{
							return from o in i
							orderby o.id descending
							select o;
						}, "");
						if (firstOrDefault != null && firstOrDefault.prm != null)
						{
							object arg = JsonConvert.DeserializeObject<object>(firstOrDefault.prm);
							if (MangoOffice.<>o__18.<>p__2 == null)
							{
								MangoOffice.<>o__18.<>p__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MangoOffice), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> target = MangoOffice.<>o__18.<>p__2.Target;
							CallSite <>p__ = MangoOffice.<>o__18.<>p__2;
							if (MangoOffice.<>o__18.<>p__1 == null)
							{
								MangoOffice.<>o__18.<>p__1 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(MangoOffice), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, object, object> target2 = MangoOffice.<>o__18.<>p__1.Target;
							CallSite <>p__2 = MangoOffice.<>o__18.<>p__1;
							if (MangoOffice.<>o__18.<>p__0 == null)
							{
								MangoOffice.<>o__18.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "timestamp", typeof(MangoOffice), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (target(<>p__, target2(<>p__2, MangoOffice.<>o__18.<>p__0.Target(MangoOffice.<>o__18.<>p__0, arg), null)))
							{
								if (MangoOffice.<>o__18.<>p__4 == null)
								{
									MangoOffice.<>o__18.<>p__4 = CallSite<Func<CallSite, System.Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToDouble", null, typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, System.Type, object, object> target3 = MangoOffice.<>o__18.<>p__4.Target;
								CallSite <>p__3 = MangoOffice.<>o__18.<>p__4;
								System.Type typeFromHandle = typeof(Convert);
								if (MangoOffice.<>o__18.<>p__3 == null)
								{
									MangoOffice.<>o__18.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "timestamp", typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object arg2 = target3(<>p__3, typeFromHandle, MangoOffice.<>o__18.<>p__3.Target(MangoOffice.<>o__18.<>p__3, arg));
								if (MangoOffice.<>o__18.<>p__5 == null)
								{
									MangoOffice.<>o__18.<>p__5 = CallSite<Func<CallSite, System.Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "UnixTimeStampToDateTime", null, typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object arg3 = MangoOffice.<>o__18.<>p__5.Target(MangoOffice.<>o__18.<>p__5, typeof(MangoVPBXClient), arg2);
								if (MangoOffice.<>o__18.<>p__14 == null)
								{
									MangoOffice.<>o__18.<>p__14 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, bool> target4 = MangoOffice.<>o__18.<>p__14.Target;
								CallSite <>p__4 = MangoOffice.<>o__18.<>p__14;
								if (MangoOffice.<>o__18.<>p__8 == null)
								{
									MangoOffice.<>o__18.<>p__8 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Func<CallSite, object, object, object> target5 = MangoOffice.<>o__18.<>p__8.Target;
								CallSite <>p__5 = MangoOffice.<>o__18.<>p__8;
								if (MangoOffice.<>o__18.<>p__7 == null)
								{
									MangoOffice.<>o__18.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "number", typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target6 = MangoOffice.<>o__18.<>p__7.Target;
								CallSite <>p__6 = MangoOffice.<>o__18.<>p__7;
								if (MangoOffice.<>o__18.<>p__6 == null)
								{
									MangoOffice.<>o__18.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "from", typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object obj = target5(<>p__5, target6(<>p__6, MangoOffice.<>o__18.<>p__6.Target(MangoOffice.<>o__18.<>p__6, arg)), null);
								if (MangoOffice.<>o__18.<>p__13 == null)
								{
									MangoOffice.<>o__18.<>p__13 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(MangoOffice), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object arg5;
								if (!MangoOffice.<>o__18.<>p__13.Target(MangoOffice.<>o__18.<>p__13, obj))
								{
									if (MangoOffice.<>o__18.<>p__12 == null)
									{
										MangoOffice.<>o__18.<>p__12 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object, object> target7 = MangoOffice.<>o__18.<>p__12.Target;
									CallSite <>p__7 = MangoOffice.<>o__18.<>p__12;
									object arg4 = obj;
									if (MangoOffice.<>o__18.<>p__11 == null)
									{
										MangoOffice.<>o__18.<>p__11 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
										}));
									}
									Func<CallSite, object, object, object> target8 = MangoOffice.<>o__18.<>p__11.Target;
									CallSite <>p__8 = MangoOffice.<>o__18.<>p__11;
									if (MangoOffice.<>o__18.<>p__10 == null)
									{
										MangoOffice.<>o__18.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "extension", typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target9 = MangoOffice.<>o__18.<>p__10.Target;
									CallSite <>p__9 = MangoOffice.<>o__18.<>p__10;
									if (MangoOffice.<>o__18.<>p__9 == null)
									{
										MangoOffice.<>o__18.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "to", typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									arg5 = target7(<>p__7, arg4, target8(<>p__8, target9(<>p__9, MangoOffice.<>o__18.<>p__9.Target(MangoOffice.<>o__18.<>p__9, arg)), null));
								}
								else
								{
									arg5 = obj;
								}
								if (target4(<>p__4, arg5))
								{
									if (MangoOffice.<>o__18.<>p__17 == null)
									{
										MangoOffice.<>o__18.<>p__17 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target10 = MangoOffice.<>o__18.<>p__17.Target;
									CallSite <>p__10 = MangoOffice.<>o__18.<>p__17;
									if (MangoOffice.<>o__18.<>p__16 == null)
									{
										MangoOffice.<>o__18.<>p__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "number", typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target11 = MangoOffice.<>o__18.<>p__16.Target;
									CallSite <>p__11 = MangoOffice.<>o__18.<>p__16;
									if (MangoOffice.<>o__18.<>p__15 == null)
									{
										MangoOffice.<>o__18.<>p__15 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "from", typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									object arg6 = target10(<>p__10, target11(<>p__11, MangoOffice.<>o__18.<>p__15.Target(MangoOffice.<>o__18.<>p__15, arg)));
									if (MangoOffice.<>o__18.<>p__20 == null)
									{
										MangoOffice.<>o__18.<>p__20 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target12 = MangoOffice.<>o__18.<>p__20.Target;
									CallSite <>p__12 = MangoOffice.<>o__18.<>p__20;
									if (MangoOffice.<>o__18.<>p__19 == null)
									{
										MangoOffice.<>o__18.<>p__19 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "extension", typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target13 = MangoOffice.<>o__18.<>p__19.Target;
									CallSite <>p__13 = MangoOffice.<>o__18.<>p__19;
									if (MangoOffice.<>o__18.<>p__18 == null)
									{
										MangoOffice.<>o__18.<>p__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "to", typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									object arg7 = target12(<>p__12, target13(<>p__13, MangoOffice.<>o__18.<>p__18.Target(MangoOffice.<>o__18.<>p__18, arg)));
									if (MangoOffice.<>o__18.<>p__21 == null)
									{
										MangoOffice.<>o__18.<>p__21 = CallSite<Func<CallSite, System.Type, object, object, object, AscCallArgs>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(MangoOffice), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									this.RaiseOnAgentCalled(MangoOffice.<>o__18.<>p__21.Target(MangoOffice.<>o__18.<>p__21, typeof(AscCallArgs), arg6, arg7, arg3));
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
				this._busy = false;
				return;
			}
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x0016A904 File Offset: 0x00168B04
		private void RaiseOnAgentCalled(AscCallArgs args)
		{
			if (this.OnAgentCalled != null)
			{
				this.OnAgentCalled(this, args);
			}
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x0016A928 File Offset: 0x00168B28
		public Task<UserBalance> Balance()
		{
			return this._client.Balance();
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x0016A940 File Offset: 0x00168B40
		public Task<Callback> Callback(string user, string phone)
		{
			return this._client.Callback(user, phone);
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x0016A95C File Offset: 0x00168B5C
		public Task<IEnumerable<IAscCDR>> GetCdr(IPeriod period, CallType type)
		{
			MangoOffice.<GetCdr>d__22 <GetCdr>d__;
			<GetCdr>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscCDR>>.Create();
			<GetCdr>d__.<>4__this = this;
			<GetCdr>d__.period = period;
			<GetCdr>d__.<>1__state = -1;
			<GetCdr>d__.<>t__builder.Start<MangoOffice.<GetCdr>d__22>(ref <GetCdr>d__);
			return <GetCdr>d__.<>t__builder.Task;
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x0016A9A8 File Offset: 0x00168BA8
		public Task<IEnumerable<IAscCDR>> GetCdr(IPeriod period, CallType type, string callParty)
		{
			MangoOffice.<GetCdr>d__23 <GetCdr>d__;
			<GetCdr>d__.<>t__builder = AsyncTaskMethodBuilder<IEnumerable<IAscCDR>>.Create();
			<GetCdr>d__.<>4__this = this;
			<GetCdr>d__.period = period;
			<GetCdr>d__.callParty = callParty;
			<GetCdr>d__.<>1__state = -1;
			<GetCdr>d__.<>t__builder.Start<MangoOffice.<GetCdr>d__23>(ref <GetCdr>d__);
			return <GetCdr>d__.<>t__builder.Task;
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x0016A9FC File Offset: 0x00168BFC
		public Task<RecordRequest> RecordRequest(IAscCDR callDetails)
		{
			return this._client.Recording(callDetails.CallId);
		}

		// Token: 0x040037A6 RID: 14246
		private ServerInfo _serverInfo = ServerInfo.Instance;

		// Token: 0x040037A7 RID: 14247
		private MangoVPBXClient _client;

		// Token: 0x040037A8 RID: 14248
		private IRepository<hooks> _hooksRepository;

		// Token: 0x040037A9 RID: 14249
		private Timer _backupTimer;

		// Token: 0x040037AA RID: 14250
		private readonly int? _extension;

		// Token: 0x040037AB RID: 14251
		private int _rows;

		// Token: 0x040037AC RID: 14252
		private bool _busy;

		// Token: 0x040037AD RID: 14253
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAgentCalled>k__BackingField;

		// Token: 0x040037AE RID: 14254
		[CompilerGenerated]
		private EventHandler<AscCallArgs> <OnAnswer>k__BackingField;

		// Token: 0x02000BC2 RID: 3010
		[CompilerGenerated]
		private static class <>o__18
		{
			// Token: 0x040037AF RID: 14255
			public static CallSite<Func<CallSite, object, object>> <>p__0;

			// Token: 0x040037B0 RID: 14256
			public static CallSite<Func<CallSite, object, object, object>> <>p__1;

			// Token: 0x040037B1 RID: 14257
			public static CallSite<Func<CallSite, object, bool>> <>p__2;

			// Token: 0x040037B2 RID: 14258
			public static CallSite<Func<CallSite, object, object>> <>p__3;

			// Token: 0x040037B3 RID: 14259
			public static CallSite<Func<CallSite, System.Type, object, object>> <>p__4;

			// Token: 0x040037B4 RID: 14260
			public static CallSite<Func<CallSite, System.Type, object, object>> <>p__5;

			// Token: 0x040037B5 RID: 14261
			public static CallSite<Func<CallSite, object, object>> <>p__6;

			// Token: 0x040037B6 RID: 14262
			public static CallSite<Func<CallSite, object, object>> <>p__7;

			// Token: 0x040037B7 RID: 14263
			public static CallSite<Func<CallSite, object, object, object>> <>p__8;

			// Token: 0x040037B8 RID: 14264
			public static CallSite<Func<CallSite, object, object>> <>p__9;

			// Token: 0x040037B9 RID: 14265
			public static CallSite<Func<CallSite, object, object>> <>p__10;

			// Token: 0x040037BA RID: 14266
			public static CallSite<Func<CallSite, object, object, object>> <>p__11;

			// Token: 0x040037BB RID: 14267
			public static CallSite<Func<CallSite, object, object, object>> <>p__12;

			// Token: 0x040037BC RID: 14268
			public static CallSite<Func<CallSite, object, bool>> <>p__13;

			// Token: 0x040037BD RID: 14269
			public static CallSite<Func<CallSite, object, bool>> <>p__14;

			// Token: 0x040037BE RID: 14270
			public static CallSite<Func<CallSite, object, object>> <>p__15;

			// Token: 0x040037BF RID: 14271
			public static CallSite<Func<CallSite, object, object>> <>p__16;

			// Token: 0x040037C0 RID: 14272
			public static CallSite<Func<CallSite, object, object>> <>p__17;

			// Token: 0x040037C1 RID: 14273
			public static CallSite<Func<CallSite, object, object>> <>p__18;

			// Token: 0x040037C2 RID: 14274
			public static CallSite<Func<CallSite, object, object>> <>p__19;

			// Token: 0x040037C3 RID: 14275
			public static CallSite<Func<CallSite, object, object>> <>p__20;

			// Token: 0x040037C4 RID: 14276
			public static CallSite<Func<CallSite, System.Type, object, object, object, AscCallArgs>> <>p__21;
		}

		// Token: 0x02000BC3 RID: 3011
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005453 RID: 21587 RVA: 0x0016AA1C File Offset: 0x00168C1C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06005454 RID: 21588 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06005455 RID: 21589 RVA: 0x00162218 File Offset: 0x00160418
			internal IOrderedQueryable<hooks> <CheckCalls>b__18_2(IQueryable<hooks> i)
			{
				return from o in i
				orderby o.id descending
				select o;
			}

			// Token: 0x040037C5 RID: 14277
			public static readonly MangoOffice.<>c <>9 = new MangoOffice.<>c();

			// Token: 0x040037C6 RID: 14278
			public static Func<IQueryable<hooks>, IOrderedQueryable<hooks>> <>9__18_2;
		}

		// Token: 0x02000BC4 RID: 3012
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCdr>d__22 : IAsyncStateMachine
		{
			// Token: 0x06005456 RID: 21590 RVA: 0x0016AA34 File Offset: 0x00168C34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MangoOffice mangoOffice = this.<>4__this;
				IEnumerable<IAscCDR> result;
				try
				{
					TaskAwaiter<IEnumerable<IAscCDR>> awaiter;
					if (num != 0)
					{
						awaiter = mangoOffice._client.Stats(this.period, "").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscCDR>>, MangoOffice.<GetCdr>d__22>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IAscCDR>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x06005457 RID: 21591 RVA: 0x0016AAFC File Offset: 0x00168CFC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040037C7 RID: 14279
			public int <>1__state;

			// Token: 0x040037C8 RID: 14280
			public AsyncTaskMethodBuilder<IEnumerable<IAscCDR>> <>t__builder;

			// Token: 0x040037C9 RID: 14281
			public MangoOffice <>4__this;

			// Token: 0x040037CA RID: 14282
			public IPeriod period;

			// Token: 0x040037CB RID: 14283
			private TaskAwaiter<IEnumerable<IAscCDR>> <>u__1;
		}

		// Token: 0x02000BC5 RID: 3013
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetCdr>d__23 : IAsyncStateMachine
		{
			// Token: 0x06005458 RID: 21592 RVA: 0x0016AB18 File Offset: 0x00168D18
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				MangoOffice mangoOffice = this.<>4__this;
				IEnumerable<IAscCDR> result;
				try
				{
					TaskAwaiter<IEnumerable<IAscCDR>> awaiter;
					if (num != 0)
					{
						awaiter = mangoOffice._client.Stats(this.period, this.callParty).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<IAscCDR>>, MangoOffice.<GetCdr>d__23>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<IAscCDR>>);
						this.<>1__state = -1;
					}
					result = awaiter.GetResult();
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

			// Token: 0x06005459 RID: 21593 RVA: 0x0016ABE0 File Offset: 0x00168DE0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040037CC RID: 14284
			public int <>1__state;

			// Token: 0x040037CD RID: 14285
			public AsyncTaskMethodBuilder<IEnumerable<IAscCDR>> <>t__builder;

			// Token: 0x040037CE RID: 14286
			public MangoOffice <>4__this;

			// Token: 0x040037CF RID: 14287
			public IPeriod period;

			// Token: 0x040037D0 RID: 14288
			public string callParty;

			// Token: 0x040037D1 RID: 14289
			private TaskAwaiter<IEnumerable<IAscCDR>> <>u__1;
		}
	}
}
