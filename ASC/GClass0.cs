using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASC;
using ASC.Common.Interfaces;
using ASC.Objects;
using ASC.SimpleClasses;
using Flurl.Http;

// Token: 0x0200020E RID: 526
public class GClass0
{
	// Token: 0x06001C02 RID: 7170 RVA: 0x0005258C File Offset: 0x0005078C
	public string method_0(Assembly assembly_0)
	{
		return FileVersionInfo.GetVersionInfo(assembly_0.Location).ProductVersion;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x00002058 File Offset: 0x00000258
	public IAscResult method_1(string string_5 = "")
	{
		Result result = new Result();
		result.SetSuccess();
		return result;
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x000525AC File Offset: 0x000507AC
	private Task<bool> method_2(LicenseVerify licenseVerify_0)
	{
		GClass0.<ValidateRemote>d__8 <ValidateRemote>d__;
		<ValidateRemote>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
		<ValidateRemote>d__.<>4__this = this;
		<ValidateRemote>d__.licenseData = licenseVerify_0;
		<ValidateRemote>d__.<>1__state = -1;
		<ValidateRemote>d__.<>t__builder.Start<GClass0.<ValidateRemote>d__8>(ref <ValidateRemote>d__);
		return <ValidateRemote>d__.<>t__builder.Task;
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x000525F8 File Offset: 0x000507F8
	private string method_3(string string_5)
	{
		HashAlgorithm hashAlgorithm = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_5);
		byte[] array = hashAlgorithm.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00052650 File Offset: 0x00050850
	public GClass0()
	{
	}

	// Token: 0x04000EBD RID: 3773
	private const string string_0 = "https://nbuk1.ru/api/license/validate";

	// Token: 0x04000EBE RID: 3774
	private string string_1 = Auth.Config.key;

	// Token: 0x04000EBF RID: 3775
	private int int_0;

	// Token: 0x04000EC0 RID: 3776
	private const string string_2 = "asccrm.ru";

	// Token: 0x04000EC1 RID: 3777
	private string string_3 = "Tr";

	// Token: 0x04000EC2 RID: 3778
	private string string_4 = "ial";

	// Token: 0x0200020F RID: 527
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	private struct <ValidateRemote>d__8 : IAsyncStateMachine
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x0005268C File Offset: 0x0005088C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.<>1__state;
			GClass0 gclass = this.<>4__this;
			bool result2;
			try
			{
				TaskAwaiter<bool> awaiter;
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter<bool>);
						this.<>1__state = -1;
						goto IL_180;
					}
					num2 = 0;
				}
				try
				{
					TaskAwaiter<ValidationResult> awaiter2;
					if (num != 0)
					{
						awaiter2 = "https://nbuk1.ru/api/license/validate".WithTimeout(15).WithHeader("User-Agent", "ASC Desktop client/" + this.licenseData.ProductVersion).PostJsonAsync(this.licenseData, default(CancellationToken), HttpCompletionOption.ResponseContentRead).ReceiveJson<ValidationResult>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ValidationResult>, GClass0.<ValidateRemote>d__8>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<ValidationResult>);
						this.<>1__state = -1;
					}
					ValidationResult result = awaiter2.GetResult();
					string b = gclass.method_3(DateTime.UtcNow.Date.ToString("dd.MM.yyyy"));
					result2 = (result.IsValid && result.AdditionalInfo == b);
					goto IL_1A7;
				}
				catch (Exception)
				{
					num2 = 1;
				}
				if (num2 == 1)
				{
					if (gclass.int_0 < 5)
					{
						gclass.int_0++;
						awaiter = gclass.method_2(this.licenseData).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__2 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, GClass0.<ValidateRemote>d__8>(ref awaiter, ref this);
							return;
						}
						goto IL_180;
					}
					else
					{
						result2 = false;
					}
				}
				goto IL_1A7;
				IL_180:
				result2 = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.<>1__state = -2;
				this.<>t__builder.SetException(exception);
				return;
			}
			IL_1A7:
			this.<>1__state = -2;
			this.<>t__builder.SetResult(result2);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00052888 File Offset: 0x00050A88
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.<>t__builder.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EC3 RID: 3779
		public int <>1__state;

		// Token: 0x04000EC4 RID: 3780
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		// Token: 0x04000EC5 RID: 3781
		public LicenseVerify licenseData;

		// Token: 0x04000EC6 RID: 3782
		public GClass0 <>4__this;

		// Token: 0x04000EC7 RID: 3783
		private TaskAwaiter<ValidationResult> <>u__1;

		// Token: 0x04000EC8 RID: 3784
		private TaskAwaiter<bool> <>u__2;
	}
}
