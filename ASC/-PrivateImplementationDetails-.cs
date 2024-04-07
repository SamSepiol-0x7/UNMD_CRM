using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C07 RID: 3079
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails>
{
	// Token: 0x06005533 RID: 21811 RVA: 0x0016E860 File Offset: 0x0016CA60
	internal static uint ComputeStringHash(string s)
	{
		uint num;
		if (s != null)
		{
			num = 2166136261U;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((uint)s[i] ^ num) * 16777619U;
			}
		}
		return num;
	}
}
