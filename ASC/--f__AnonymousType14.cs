using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000010 RID: 16
[CompilerGenerated]
internal sealed class <>f__AnonymousType14<<User>j__TPar, <Time>j__TPar>
{
	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600005F RID: 95 RVA: 0x00003684 File Offset: 0x00001884
	public <User>j__TPar User
	{
		get
		{
			return this.<User>i__Field;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000060 RID: 96 RVA: 0x00003698 File Offset: 0x00001898
	public <Time>j__TPar Time
	{
		get
		{
			return this.<Time>i__Field;
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000036AC File Offset: 0x000018AC
	[DebuggerHidden]
	public <>f__AnonymousType14(<User>j__TPar User, <Time>j__TPar Time)
	{
		this.<User>i__Field = User;
		this.<Time>i__Field = Time;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000036D0 File Offset: 0x000018D0
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType14<<User>j__TPar, <Time>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<User>j__TPar>.Default.Equals(this.<User>i__Field, <>f__AnonymousType.<User>i__Field) && EqualityComparer<<Time>j__TPar>.Default.Equals(this.<Time>i__Field, <>f__AnonymousType.<Time>i__Field);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003718 File Offset: 0x00001918
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-2074516176 + EqualityComparer<<User>j__TPar>.Default.GetHashCode(this.<User>i__Field)) * -1521134295 + EqualityComparer<<Time>j__TPar>.Default.GetHashCode(this.<Time>i__Field);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003754 File Offset: 0x00001954
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ User = {0}, Time = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<User>j__TPar <User>j__TPar = this.<User>i__Field;
		array[num] = ((<User>j__TPar != null) ? <User>j__TPar.ToString() : null);
		int num2 = 1;
		<Time>j__TPar <Time>j__TPar = this.<Time>i__Field;
		array[num2] = ((<Time>j__TPar != null) ? <Time>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000027 RID: 39
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <User>j__TPar <User>i__Field;

	// Token: 0x04000028 RID: 40
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Time>j__TPar <Time>i__Field;
}
