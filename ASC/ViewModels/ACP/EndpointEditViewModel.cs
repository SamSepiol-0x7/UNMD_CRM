using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Models;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels.ACP
{
	// Token: 0x02000564 RID: 1380
	public class EndpointEditViewModel : BaseViewModel
	{
		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x000AC730 File Offset: 0x000AA930
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x000AC744 File Offset: 0x000AA944
		public int? Tel
		{
			[CompilerGenerated]
			get
			{
				return this.<Tel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<int>(this.<Tel>k__BackingField, value))
				{
					return;
				}
				this.<Tel>k__BackingField = value;
				this.RaisePropertyChanged("Tel");
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x000AC774 File Offset: 0x000AA974
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x000AC788 File Offset: 0x000AA988
		public string Password
		{
			[CompilerGenerated]
			get
			{
				return this.<Password>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Password>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Password>k__BackingField = value;
				this.RaisePropertyChanged("Password");
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x000AC7B8 File Offset: 0x000AA9B8
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x000AC7CC File Offset: 0x000AA9CC
		public string Context
		{
			[CompilerGenerated]
			get
			{
				return this.<Context>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(this.<Context>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -986121191;
				IL_14:
				switch ((num ^ -1674117144) % 4)
				{
				case 0:
					IL_33:
					num = -657492773;
					goto IL_14;
				case 1:
					return;
				case 2:
					goto IL_0F;
				}
				this.<Context>k__BackingField = value;
				this.RaisePropertyChanged("Context");
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000AC828 File Offset: 0x000AAA28
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x000AC83C File Offset: 0x000AAA3C
		public string Allow
		{
			[CompilerGenerated]
			get
			{
				return this.<Allow>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Allow>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Allow>k__BackingField = value;
				this.RaisePropertyChanged("AllowList");
				this.RaisePropertyChanged("Allow");
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000AC878 File Offset: 0x000AAA78
		// (set) Token: 0x0600332C RID: 13100 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		public List<object> AllowList
		{
			get
			{
				if (!string.IsNullOrEmpty(this.Allow))
				{
					return new List<object>(this.Allow.Split(new char[]
					{
						','
					}).ToList<string>());
				}
				return new List<object>();
			}
			set
			{
				if (object.Equals(this.AllowList, value))
				{
					return;
				}
				if (value == null)
				{
					this.Allow = null;
				}
				else
				{
					this.Allow = string.Join(",", value.ToArray());
				}
				this.RaisePropertyChanged("AllowList");
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x000AC904 File Offset: 0x000AAB04
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x000AC918 File Offset: 0x000AAB18
		public bool PasswordVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<PasswordVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PasswordVisible>k__BackingField == value)
				{
					return;
				}
				this.<PasswordVisible>k__BackingField = value;
				this.RaisePropertyChanged("PasswordVisible");
			}
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x000AC944 File Offset: 0x000AAB44
		private void IoC()
		{
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000AC974 File Offset: 0x000AAB74
		public EndpointEditViewModel()
		{
			this.IoC();
			this.PasswordVisible = true;
			this.Context = "testing";
			this.Allow = "g722";
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x000AC9AC File Offset: 0x000AABAC
		public EndpointEditViewModel(ps_endpoints e)
		{
			this.IoC();
			this._endpointId = e.id;
			this._auth = this.GetAuth(e.id);
			this.Tel = new int?(e.id);
			ps_auths auth = this._auth;
			this.Password = ((auth != null) ? auth.password : null);
			this.Context = e.context;
			this.Allow = e.allow;
			this.PasswordVisible = (this._auth != null);
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x000ACA34 File Offset: 0x000AAC34
		private ps_auths GetAuth(int id)
		{
			return VoipModel.GetPsAuth(id);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x000ACA48 File Offset: 0x000AAC48
		[Command]
		public void Close()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000ACA60 File Offset: 0x000AAC60
		[Command]
		public void Save()
		{
			EndpointEditViewModel.<Save>d__32 <Save>d__;
			<Save>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<EndpointEditViewModel.<Save>d__32>(ref <Save>d__);
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x000ACA98 File Offset: 0x000AAC98
		public bool CanSave()
		{
			return this._endpointId > 0;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x000ACAB0 File Offset: 0x000AACB0
		[Command]
		public void Create()
		{
			EndpointEditViewModel.<Create>d__34 <Create>d__;
			<Create>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<EndpointEditViewModel.<Create>d__34>(ref <Create>d__);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x000ACAE8 File Offset: 0x000AACE8
		public bool CanCreate()
		{
			return this._endpointId == 0;
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x000ACB00 File Offset: 0x000AAD00
		private bool CheckFields()
		{
			if (this.Tel != null)
			{
				int? tel = this.Tel;
				if (!(tel.GetValueOrDefault() < 0 & tel != null))
				{
					if (string.IsNullOrEmpty(this.Password))
					{
						this._toasterService.Info("Password empty");
						return false;
					}
					if (!string.IsNullOrEmpty(this.Context))
					{
						return true;
					}
					this._toasterService.Info("Context empty");
					return false;
				}
			}
			this._toasterService.Info("Tel check");
			return false;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000ACB8C File Offset: 0x000AAD8C
		protected override void OnParentViewModelChanged(object parentViewModel)
		{
			base.OnParentViewModelChanged(parentViewModel);
			this._parentViewModel = (parentViewModel as IRefreshable);
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000ACBAC File Offset: 0x000AADAC
		[Command]
		public void GenPassword()
		{
			this.Password = Generators.RandomString(12, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x000ACBCC File Offset: 0x000AADCC
		[CompilerGenerated]
		private bool <Save>b__32_0()
		{
			return VoipModel.UpdateEndpoint(this._endpointId, this.Tel.Value, this.Password, this.Context, this.Allow);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000ACC04 File Offset: 0x000AAE04
		[CompilerGenerated]
		private IAscResult <Create>b__34_0()
		{
			return VoipModel.CreateEndpoint(this.Tel.Value, this.Password, this.Context, this.Allow);
		}

		// Token: 0x04001D74 RID: 7540
		private IToasterService _toasterService;

		// Token: 0x04001D75 RID: 7541
		private IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001D76 RID: 7542
		private int _endpointId;

		// Token: 0x04001D77 RID: 7543
		private ps_auths _auth;

		// Token: 0x04001D78 RID: 7544
		[CompilerGenerated]
		private int? <Tel>k__BackingField;

		// Token: 0x04001D79 RID: 7545
		[CompilerGenerated]
		private string <Password>k__BackingField;

		// Token: 0x04001D7A RID: 7546
		[CompilerGenerated]
		private string <Context>k__BackingField;

		// Token: 0x04001D7B RID: 7547
		[CompilerGenerated]
		private string <Allow>k__BackingField;

		// Token: 0x04001D7C RID: 7548
		[CompilerGenerated]
		private bool <PasswordVisible>k__BackingField;

		// Token: 0x04001D7D RID: 7549
		private IRefreshable _parentViewModel;

		// Token: 0x02000565 RID: 1381
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__32 : IAsyncStateMachine
		{
			// Token: 0x0600333D RID: 13117 RVA: 0x000ACC38 File Offset: 0x000AAE38
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EndpointEditViewModel endpointEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						goto IL_95;
					}
					goto IL_D8;
					TaskAwaiter<bool> awaiter;
					bool result;
					for (;;)
					{
						IL_C3:
						result = awaiter.GetResult();
						for (;;)
						{
							IL_87:
							endpointEditViewModel.HideWait();
							if (!result)
							{
								goto IL_118;
							}
							for (;;)
							{
								IRefreshable parentViewModel = endpointEditViewModel._parentViewModel;
								if (parentViewModel != null)
								{
									parentViewModel.DataRefresh();
									uint num2;
									switch ((num2 = (num2 * 4145898416U ^ 3817668748U ^ 1762341436U)) % 15U)
									{
									case 1U:
										continue;
									case 2U:
										goto IL_87;
									case 3U:
										goto IL_112;
									case 4U:
										goto IL_C3;
									case 5U:
										goto IL_CD;
									case 6U:
									case 11U:
										goto IL_95;
									case 7U:
										goto IL_F8;
									case 8U:
										goto IL_A3;
									case 9U:
										goto IL_ED;
									case 10U:
										goto IL_9D;
									case 12U:
										goto IL_10F;
									case 13U:
										goto IL_D8;
									case 14U:
										goto IL_FA;
									}
									goto Block_5;
								}
								goto IL_111;
							}
						}
					}
					Block_5:
					goto IL_118;
					IL_111:
					IL_112:
					endpointEditViewModel.Close();
					IL_118:
					endpointEditViewModel.ShowActionResponse(result, "");
					goto IL_13F;
					IL_95:
					if (!endpointEditViewModel.CheckFields())
					{
						goto IL_F8;
					}
					IL_9D:
					endpointEditViewModel.ShowWait();
					IL_A3:
					awaiter = Task.Run<bool>(() => VoipModel.UpdateEndpoint(endpointEditViewModel._endpointId, base.Tel.Value, base.Password, base.Context, base.Allow)).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_C3;
					}
					goto IL_ED;
					IL_CD:
					this.<>1__state = -1;
					goto IL_C3;
					IL_D8:
					awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<bool>);
					goto IL_CD;
					IL_ED:
					this.<>1__state = 0;
					goto IL_FA;
					IL_F8:
					goto IL_13F;
					IL_FA:
					this.<>u__1 = awaiter;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, EndpointEditViewModel.<Save>d__32>(ref awaiter, ref this);
					IL_10F:
					return;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_13F:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600333E RID: 13118 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D7E RID: 7550
			public int <>1__state;

			// Token: 0x04001D7F RID: 7551
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D80 RID: 7552
			public EndpointEditViewModel <>4__this;

			// Token: 0x04001D81 RID: 7553
			private TaskAwaiter<bool> <>u__1;
		}

		// Token: 0x02000566 RID: 1382
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__34 : IAsyncStateMachine
		{
			// Token: 0x0600333F RID: 13119 RVA: 0x000ACDD0 File Offset: 0x000AAFD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				EndpointEditViewModel endpointEditViewModel = this.<>4__this;
				try
				{
					if (num != 0)
					{
						goto IL_A3;
					}
					goto IL_FA;
					TaskAwaiter<IAscResult> awaiter;
					IAscResult result;
					for (;;)
					{
						IL_D1:
						result = awaiter.GetResult();
						endpointEditViewModel.HideWait();
						IL_96:
						while (result.IsSucces)
						{
							for (;;)
							{
								IRefreshable parentViewModel = endpointEditViewModel._parentViewModel;
								if (parentViewModel != null)
								{
									parentViewModel.DataRefresh();
									uint num2;
									switch ((num2 = (num2 * 3691880107U ^ 3103937685U ^ 1904819954U)) % 18U)
									{
									case 0U:
									case 8U:
										goto IL_A3;
									case 1U:
										goto IL_121;
									case 2U:
										goto IL_103;
									case 3U:
										goto IL_AB;
									case 4U:
										continue;
									case 7U:
										goto IL_128;
									case 9U:
										goto IL_139;
									case 10U:
										goto IL_118;
									case 11U:
										goto IL_96;
									case 12U:
										goto IL_D1;
									case 13U:
										goto IL_FA;
									case 14U:
										goto IL_EC;
									case 15U:
										goto IL_136;
									case 16U:
										goto IL_13F;
									case 17U:
										goto IL_E1;
									}
									goto Block_5;
								}
								goto IL_138;
							}
						}
						goto Block_6;
					}
					Block_5:
					goto IL_150;
					Block_6:
					IL_103:
					endpointEditViewModel._toasterService.Error(result.Message);
					goto IL_150;
					IL_138:
					IL_139:
					endpointEditViewModel.Close();
					IL_13F:
					endpointEditViewModel.ShowActionResponse(result.IsSucces, "");
					IL_150:
					goto IL_16B;
					IL_A3:
					if (!endpointEditViewModel.CheckFields())
					{
						goto IL_116;
					}
					IL_AB:
					endpointEditViewModel.ShowWait();
					awaiter = Task.Run<IAscResult>(() => VoipModel.CreateEndpoint(base.Tel.Value, base.Password, base.Context, base.Allow)).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_D1;
					}
					goto IL_118;
					IL_E1:
					this.<>1__state = -1;
					goto IL_D1;
					IL_EC:
					this.<>u__1 = default(TaskAwaiter<IAscResult>);
					goto IL_E1;
					IL_FA:
					awaiter = this.<>u__1;
					goto IL_EC;
					IL_116:
					goto IL_16B;
					IL_118:
					this.<>1__state = 0;
					IL_121:
					this.<>u__1 = awaiter;
					IL_128:
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IAscResult>, EndpointEditViewModel.<Create>d__34>(ref awaiter, ref this);
					IL_136:
					return;
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				IL_16B:
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003340 RID: 13120 RVA: 0x000ACF78 File Offset: 0x000AB178
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D82 RID: 7554
			public int <>1__state;

			// Token: 0x04001D83 RID: 7555
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001D84 RID: 7556
			public EndpointEditViewModel <>4__this;

			// Token: 0x04001D85 RID: 7557
			private TaskAwaiter<IAscResult> <>u__1;
		}
	}
}
