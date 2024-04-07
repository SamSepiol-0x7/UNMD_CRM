using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Enum;
using ASC.Common.Interfaces;
using ASC.Common.Interfaces.VoIP;
using ASC.Common.Models;
using ASC.DAL;
using ASC.Services.Abstract;
using Newtonsoft.Json;

namespace ASC.Services.Concrete
{
	// Token: 0x02000797 RID: 1943
	public class SettingsService : ISettingsService
	{
		// Token: 0x06003BA8 RID: 15272 RVA: 0x000EB37C File Offset: 0x000E957C
		public SettingsService(IContextFactory contextFactory)
		{
			this._contextFactory = contextFactory;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x000EB398 File Offset: 0x000E9598
		public Task UpdateSettingsAsync(string name, string value)
		{
			SettingsService.<UpdateSettingsAsync>d__2 <UpdateSettingsAsync>d__;
			<UpdateSettingsAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateSettingsAsync>d__.<>4__this = this;
			<UpdateSettingsAsync>d__.name = name;
			<UpdateSettingsAsync>d__.value = value;
			<UpdateSettingsAsync>d__.<>1__state = -1;
			<UpdateSettingsAsync>d__.<>t__builder.Start<SettingsService.<UpdateSettingsAsync>d__2>(ref <UpdateSettingsAsync>d__);
			return <UpdateSettingsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x000EB3EC File Offset: 0x000E95EC
		public Task UpdateSettingsAsync(Dictionary<SettingsName, string> settings)
		{
			SettingsService.<UpdateSettingsAsync>d__3 <UpdateSettingsAsync>d__;
			<UpdateSettingsAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateSettingsAsync>d__.<>4__this = this;
			<UpdateSettingsAsync>d__.settings = settings;
			<UpdateSettingsAsync>d__.<>1__state = -1;
			<UpdateSettingsAsync>d__.<>t__builder.Start<SettingsService.<UpdateSettingsAsync>d__3>(ref <UpdateSettingsAsync>d__);
			return <UpdateSettingsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x000EB438 File Offset: 0x000E9638
		public Task<KeyValuePair<string, string>> GetSettingsAsync(string name)
		{
			SettingsService.<GetSettingsAsync>d__4 <GetSettingsAsync>d__;
			<GetSettingsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<KeyValuePair<string, string>>.Create();
			<GetSettingsAsync>d__.<>4__this = this;
			<GetSettingsAsync>d__.name = name;
			<GetSettingsAsync>d__.<>1__state = -1;
			<GetSettingsAsync>d__.<>t__builder.Start<SettingsService.<GetSettingsAsync>d__4>(ref <GetSettingsAsync>d__);
			return <GetSettingsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x000EB484 File Offset: 0x000E9684
		public Task<Dictionary<string, string>> GetSettingsAsync(string[] names)
		{
			SettingsService.<GetSettingsAsync>d__5 <GetSettingsAsync>d__;
			<GetSettingsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<Dictionary<string, string>>.Create();
			<GetSettingsAsync>d__.<>4__this = this;
			<GetSettingsAsync>d__.names = names;
			<GetSettingsAsync>d__.<>1__state = -1;
			<GetSettingsAsync>d__.<>t__builder.Start<SettingsService.<GetSettingsAsync>d__5>(ref <GetSettingsAsync>d__);
			return <GetSettingsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x000EB4D0 File Offset: 0x000E96D0
		public Task<SettingsModel> GetSettingsAsync()
		{
			SettingsService.<GetSettingsAsync>d__6 <GetSettingsAsync>d__;
			<GetSettingsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<SettingsModel>.Create();
			<GetSettingsAsync>d__.<>4__this = this;
			<GetSettingsAsync>d__.<>1__state = -1;
			<GetSettingsAsync>d__.<>t__builder.Start<SettingsService.<GetSettingsAsync>d__6>(ref <GetSettingsAsync>d__);
			return <GetSettingsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x000EB514 File Offset: 0x000E9714
		private void GetDocumentsPrintSettings(IDocumentsPrintSettings result, Dictionary<string, string> settings)
		{
			result.PrintNewRepairReport = this.TryGetBoolValue(settings, SettingsName.print_new_repair_report);
			result.PrintRepStickers = this.TryGetBoolValue(settings, SettingsName.print_rep_stickers);
			result.PrintNewCartridgeReport = this.TryGetBoolValue(settings, SettingsName.print_new_cartridge_report);
			result.PrintCartridgeStickers = this.TryGetBoolValue(settings, SettingsName.print_cartridge_stickers);
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x000EB560 File Offset: 0x000E9760
		private string TryGetStringValue(IReadOnlyDictionary<string, string> dict, SettingsName key)
		{
			string result;
			if (!dict.TryGetValue(key.ToString(), out result))
			{
				return "";
			}
			return result;
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x000EB58C File Offset: 0x000E978C
		private bool TryGetBoolValue(IReadOnlyDictionary<string, string> dict, SettingsName key)
		{
			string text;
			return dict.TryGetValue(key.ToString(), out text) && ((text != null) ? text.Trim() : null) == "1";
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x000EB5C8 File Offset: 0x000E97C8
		public KeyValuePair<string, string> GetSettings(string name)
		{
			KeyValuePair<string, string> result;
			using (auseceEntities auseceEntities = this._contextFactory.Create())
			{
				settings settings = auseceEntities.settings.Single((settings i) => i.name == name);
				result = new KeyValuePair<string, string>(name, settings.value);
			}
			return result;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x000EB688 File Offset: 0x000E9888
		public Dictionary<string, string> GetSettings(string[] names)
		{
			Dictionary<string, string> result;
			using (auseceEntities auseceEntities = this._contextFactory.Create())
			{
				result = (from i in auseceEntities.settings
				where names.Contains(i.name)
				select i).ToDictionary((settings i) => i.name, (settings i) => i.value);
			}
			return result;
		}

		// Token: 0x040026E3 RID: 9955
		private readonly IContextFactory _contextFactory;

		// Token: 0x02000798 RID: 1944
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06003BB3 RID: 15283 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x040026E4 RID: 9956
			public string name;
		}

		// Token: 0x02000799 RID: 1945
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateSettingsAsync>d__2 : IAsyncStateMachine
		{
			// Token: 0x06003BB4 RID: 15284 RVA: 0x000EB794 File Offset: 0x000E9994
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SettingsService settingsService = this.<>4__this;
				try
				{
					SettingsService.<>c__DisplayClass2_0 CS$<>8__locals1;
					if (num > 1)
					{
						CS$<>8__locals1 = new SettingsService.<>c__DisplayClass2_0();
						CS$<>8__locals1.name = this.name;
						this.<ctx>5__2 = settingsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						TaskAwaiter<settings> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_173;
							}
							awaiter2 = (from i in this.<ctx>5__2.settings
							where i.name == CS$<>8__locals1.name
							select i).SingleAsync<settings>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.<>1__state = num3;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<settings>, SettingsService.<UpdateSettingsAsync>d__2>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<settings>);
							int num4 = -1;
							num = -1;
							this.<>1__state = num4;
						}
						awaiter2.GetResult().value = this.value;
						awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SettingsService.<UpdateSettingsAsync>d__2>(ref awaiter, ref this);
							return;
						}
						IL_173:
						awaiter.GetResult();
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003BB5 RID: 15285 RVA: 0x000EB9A0 File Offset: 0x000E9BA0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026E5 RID: 9957
			public int <>1__state;

			// Token: 0x040026E6 RID: 9958
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040026E7 RID: 9959
			public string name;

			// Token: 0x040026E8 RID: 9960
			public SettingsService <>4__this;

			// Token: 0x040026E9 RID: 9961
			public string value;

			// Token: 0x040026EA RID: 9962
			private auseceEntities <ctx>5__2;

			// Token: 0x040026EB RID: 9963
			private TaskAwaiter<settings> <>u__1;

			// Token: 0x040026EC RID: 9964
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x0200079A RID: 1946
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06003BB6 RID: 15286 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x040026ED RID: 9965
			public KeyValuePair<SettingsName, string> s;
		}

		// Token: 0x0200079B RID: 1947
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <UpdateSettingsAsync>d__3 : IAsyncStateMachine
		{
			// Token: 0x06003BB7 RID: 15287 RVA: 0x000EB9BC File Offset: 0x000E9BBC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SettingsService settingsService = this.<>4__this;
				try
				{
					if (num > 1)
					{
						this.<ctx>5__2 = settingsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<int> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.<>u__2;
								this.<>u__2 = default(TaskAwaiter<int>);
								int num2 = -1;
								num = -1;
								this.<>1__state = num2;
								goto IL_1F9;
							}
							this.<>7__wrap2 = this.settings.GetEnumerator();
						}
						try
						{
							TaskAwaiter<settings> awaiter2;
							if (num == 0)
							{
								awaiter2 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter<settings>);
								int num3 = -1;
								num = -1;
								this.<>1__state = num3;
								goto IL_16F;
							}
							IL_85:
							if (!this.<>7__wrap2.MoveNext())
							{
								goto IL_1D2;
							}
							this.<>8__1 = new SettingsService.<>c__DisplayClass3_0();
							this.<>8__1.s = this.<>7__wrap2.Current;
							awaiter2 = (from i in this.<ctx>5__2.settings
							where i.name == this.<>8__1.s.Key.ToString()
							select i).SingleAsync<settings>().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 0;
								num = 0;
								this.<>1__state = num4;
								this.<>u__1 = awaiter2;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<settings>, SettingsService.<UpdateSettingsAsync>d__3>(ref awaiter2, ref this);
								return;
							}
							IL_16F:
							awaiter2.GetResult().value = this.<>8__1.s.Value;
							this.<>8__1 = null;
							goto IL_85;
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>7__wrap2).Dispose();
							}
						}
						IL_1D2:
						this.<>7__wrap2 = default(Dictionary<SettingsName, string>.Enumerator);
						awaiter = this.<ctx>5__2.SaveChangesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num5 = 1;
							num = 1;
							this.<>1__state = num5;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, SettingsService.<UpdateSettingsAsync>d__3>(ref awaiter, ref this);
							return;
						}
						IL_1F9:
						awaiter.GetResult();
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06003BB8 RID: 15288 RVA: 0x000EBC88 File Offset: 0x000E9E88
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026EE RID: 9966
			public int <>1__state;

			// Token: 0x040026EF RID: 9967
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040026F0 RID: 9968
			public SettingsService <>4__this;

			// Token: 0x040026F1 RID: 9969
			public Dictionary<SettingsName, string> settings;

			// Token: 0x040026F2 RID: 9970
			private SettingsService.<>c__DisplayClass3_0 <>8__1;

			// Token: 0x040026F3 RID: 9971
			private auseceEntities <ctx>5__2;

			// Token: 0x040026F4 RID: 9972
			private Dictionary<SettingsName, string>.Enumerator <>7__wrap2;

			// Token: 0x040026F5 RID: 9973
			private TaskAwaiter<settings> <>u__1;

			// Token: 0x040026F6 RID: 9974
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x0200079C RID: 1948
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06003BB9 RID: 15289 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x040026F7 RID: 9975
			public string name;
		}

		// Token: 0x0200079D RID: 1949
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetSettingsAsync>d__4 : IAsyncStateMachine
		{
			// Token: 0x06003BBA RID: 15290 RVA: 0x000EBCA4 File Offset: 0x000E9EA4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SettingsService settingsService = this.<>4__this;
				KeyValuePair<string, string> result2;
				try
				{
					if (num != 0)
					{
						this.<>8__1 = new SettingsService.<>c__DisplayClass4_0();
						this.<>8__1.name = this.name;
						this.<ctx>5__2 = settingsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<settings> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.settings
							where i.name == this.<>8__1.name
							select i).SingleAsync<settings>().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<settings>, SettingsService.<GetSettingsAsync>d__4>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<settings>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						settings result = awaiter.GetResult();
						result2 = new KeyValuePair<string, string>(this.<>8__1.name, result.value);
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
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003BBB RID: 15291 RVA: 0x000EBE6C File Offset: 0x000EA06C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040026F8 RID: 9976
			public int <>1__state;

			// Token: 0x040026F9 RID: 9977
			public AsyncTaskMethodBuilder<KeyValuePair<string, string>> <>t__builder;

			// Token: 0x040026FA RID: 9978
			public string name;

			// Token: 0x040026FB RID: 9979
			public SettingsService <>4__this;

			// Token: 0x040026FC RID: 9980
			private SettingsService.<>c__DisplayClass4_0 <>8__1;

			// Token: 0x040026FD RID: 9981
			private auseceEntities <ctx>5__2;

			// Token: 0x040026FE RID: 9982
			private TaskAwaiter<settings> <>u__1;
		}

		// Token: 0x0200079E RID: 1950
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06003BBC RID: 15292 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x040026FF RID: 9983
			public string[] names;
		}

		// Token: 0x0200079F RID: 1951
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003BBD RID: 15293 RVA: 0x000EBE88 File Offset: 0x000EA088
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003BBE RID: 15294 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06003BBF RID: 15295 RVA: 0x000EBEA0 File Offset: 0x000EA0A0
			internal string <GetSettingsAsync>b__5_1(settings i)
			{
				return i.name;
			}

			// Token: 0x06003BC0 RID: 15296 RVA: 0x000EBEB4 File Offset: 0x000EA0B4
			internal string <GetSettingsAsync>b__5_2(settings i)
			{
				return i.value;
			}

			// Token: 0x06003BC1 RID: 15297 RVA: 0x000EBEA0 File Offset: 0x000EA0A0
			internal string <GetSettingsAsync>b__6_0(settings i)
			{
				return i.name;
			}

			// Token: 0x06003BC2 RID: 15298 RVA: 0x000EBEB4 File Offset: 0x000EA0B4
			internal string <GetSettingsAsync>b__6_1(settings i)
			{
				return i.value;
			}

			// Token: 0x06003BC3 RID: 15299 RVA: 0x000EBEA0 File Offset: 0x000EA0A0
			internal string <GetSettings>b__11_1(settings i)
			{
				return i.name;
			}

			// Token: 0x06003BC4 RID: 15300 RVA: 0x000EBEB4 File Offset: 0x000EA0B4
			internal string <GetSettings>b__11_2(settings i)
			{
				return i.value;
			}

			// Token: 0x04002700 RID: 9984
			public static readonly SettingsService.<>c <>9 = new SettingsService.<>c();

			// Token: 0x04002701 RID: 9985
			public static Func<settings, string> <>9__5_1;

			// Token: 0x04002702 RID: 9986
			public static Func<settings, string> <>9__5_2;

			// Token: 0x04002703 RID: 9987
			public static Func<settings, string> <>9__6_0;

			// Token: 0x04002704 RID: 9988
			public static Func<settings, string> <>9__6_1;

			// Token: 0x04002705 RID: 9989
			public static Func<settings, string> <>9__11_1;

			// Token: 0x04002706 RID: 9990
			public static Func<settings, string> <>9__11_2;
		}

		// Token: 0x020007A0 RID: 1952
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetSettingsAsync>d__5 : IAsyncStateMachine
		{
			// Token: 0x06003BC5 RID: 15301 RVA: 0x000EBEC8 File Offset: 0x000EA0C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SettingsService settingsService = this.<>4__this;
				Dictionary<string, string> result;
				try
				{
					SettingsService.<>c__DisplayClass5_0 CS$<>8__locals1;
					if (num != 0)
					{
						CS$<>8__locals1 = new SettingsService.<>c__DisplayClass5_0();
						CS$<>8__locals1.names = this.names;
						this.<ctx>5__2 = settingsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<Dictionary<string, string>> awaiter;
						if (num != 0)
						{
							awaiter = (from i in this.<ctx>5__2.settings
							where CS$<>8__locals1.names.Contains(i.name)
							select i).ToDictionaryAsync(new Func<settings, string>(SettingsService.<>c.<>9.<GetSettingsAsync>b__5_1), new Func<settings, string>(SettingsService.<>c.<>9.<GetSettingsAsync>b__5_2)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, SettingsService.<GetSettingsAsync>d__5>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<Dictionary<string, string>>);
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result);
			}

			// Token: 0x06003BC6 RID: 15302 RVA: 0x000EC0B0 File Offset: 0x000EA2B0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002707 RID: 9991
			public int <>1__state;

			// Token: 0x04002708 RID: 9992
			public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder;

			// Token: 0x04002709 RID: 9993
			public string[] names;

			// Token: 0x0400270A RID: 9994
			public SettingsService <>4__this;

			// Token: 0x0400270B RID: 9995
			private auseceEntities <ctx>5__2;

			// Token: 0x0400270C RID: 9996
			private TaskAwaiter<Dictionary<string, string>> <>u__1;
		}

		// Token: 0x020007A1 RID: 1953
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <GetSettingsAsync>d__6 : IAsyncStateMachine
		{
			// Token: 0x06003BC7 RID: 15303 RVA: 0x000EC0CC File Offset: 0x000EA2CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				SettingsService settingsService = this.<>4__this;
				SettingsModel result2;
				try
				{
					if (num != 0)
					{
						this.<ctx>5__2 = settingsService._contextFactory.Create();
					}
					try
					{
						TaskAwaiter<Dictionary<string, string>> awaiter;
						if (num != 0)
						{
							awaiter = this.<ctx>5__2.settings.ToDictionaryAsync(new Func<settings, string>(SettingsService.<>c.<>9.<GetSettingsAsync>b__6_0), new Func<settings, string>(SettingsService.<>c.<>9.<GetSettingsAsync>b__6_1)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.<>1__state = num2;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, SettingsService.<GetSettingsAsync>d__6>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<Dictionary<string, string>>);
							int num3 = -1;
							num = -1;
							this.<>1__state = num3;
						}
						Dictionary<string, string> result = awaiter.GetResult();
						SettingsModel settingsModel = new SettingsModel();
						string s;
						int value;
						if (result.TryGetValue("voip", out s) && int.TryParse(s, out value))
						{
							settingsModel.Voip = new VoIPClient?((VoIPClient)value);
						}
						settingsModel.VoipEndpoint = settingsService.TryGetStringValue(result, SettingsName.voip_endpoint);
						settingsModel.VoipKey = settingsService.TryGetStringValue(result, SettingsName.voip_key);
						settingsModel.VoipPrefix = settingsService.TryGetStringValue(result, SettingsName.voip_prefix);
						settingsModel.VoipSecret = settingsService.TryGetStringValue(result, SettingsName.voip_secret);
						settingsModel.InformComment = settingsService.TryGetBoolValue(result, SettingsName.inform_comment);
						settingsModel.InformSms = settingsService.TryGetBoolValue(result, SettingsName.inform_sms);
						settingsModel.InformTaskMatch = settingsService.TryGetBoolValue(result, SettingsName.inform_task_match);
						settingsModel.InformTaskCustom = settingsService.TryGetBoolValue(result, SettingsName.inform_task_custom);
						settingsModel.InformTaskRequest = settingsService.TryGetBoolValue(result, SettingsName.inform_task_request);
						settingsModel.InformIntRequest = settingsService.TryGetBoolValue(result, SettingsName.inform_int_request);
						settingsModel.InformPartRequest = settingsService.TryGetBoolValue(result, SettingsName.inform_part_request);
						settingsModel.InformCall = settingsService.TryGetBoolValue(result, SettingsName.inform_call);
						settingsModel.InformCommentColor = settingsService.TryGetStringValue(result, SettingsName.inform_comment_color);
						settingsModel.InformStatusColor = settingsService.TryGetStringValue(result, SettingsName.inform_status_color);
						settingsModel.InformSmsColor = settingsService.TryGetStringValue(result, SettingsName.inform_sms_color);
						settingsModel.InformTermsColor = settingsService.TryGetStringValue(result, SettingsName.inform_terms_color);
						settingsModel.InformTaskMatchColor = settingsService.TryGetStringValue(result, SettingsName.inform_task_match_color);
						settingsModel.InformTaskCustomColor = settingsService.TryGetStringValue(result, SettingsName.inform_task_custom_color);
						settingsModel.InformTaskRequestColor = settingsService.TryGetStringValue(result, SettingsName.inform_task_request_color);
						settingsModel.InformIntRequestColor = settingsService.TryGetStringValue(result, SettingsName.inform_int_request_color);
						settingsModel.InformCallColor = settingsService.TryGetStringValue(result, SettingsName.inform_call_color);
						settingsModel.InformPartRequestColor = settingsService.TryGetStringValue(result, SettingsName.inform_part_request_color);
						settingsModel.AutoAssignUsers = JsonConvert.DeserializeObject<List<int>>(settingsService.TryGetStringValue(result, SettingsName.auto_assign_users));
						settingsModel.MasterAutoAssignCriteria = JsonConvert.DeserializeObject<MasterAutoAssignService.MasterAutoAssignCriteria>(settingsService.TryGetStringValue(result, SettingsName.auto_assign_criteria));
						settingsService.GetDocumentsPrintSettings(settingsModel, result);
						result2 = settingsModel;
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
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult(result2);
			}

			// Token: 0x06003BC8 RID: 15304 RVA: 0x000EC3E4 File Offset: 0x000EA5E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400270D RID: 9997
			public int <>1__state;

			// Token: 0x0400270E RID: 9998
			public AsyncTaskMethodBuilder<SettingsModel> <>t__builder;

			// Token: 0x0400270F RID: 9999
			public SettingsService <>4__this;

			// Token: 0x04002710 RID: 10000
			private auseceEntities <ctx>5__2;

			// Token: 0x04002711 RID: 10001
			private TaskAwaiter<Dictionary<string, string>> <>u__1;
		}

		// Token: 0x020007A2 RID: 1954
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003BC9 RID: 15305 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x04002712 RID: 10002
			public string name;
		}

		// Token: 0x020007A3 RID: 1955
		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06003BCA RID: 15306 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x04002713 RID: 10003
			public string[] names;
		}
	}
}
