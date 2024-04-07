using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
[CompilerGenerated]
internal sealed class <>f__AnonymousType1<<id>j__TPar, <DiagnosticsCarrying>j__TPar>
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000008 RID: 8 RVA: 0x0000224C File Offset: 0x0000044C
	public <id>j__TPar id
	{
		get
		{
			return this.<id>i__Field;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00002260 File Offset: 0x00000460
	public <DiagnosticsCarrying>j__TPar DiagnosticsCarrying
	{
		get
		{
			return this.<DiagnosticsCarrying>i__Field;
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002274 File Offset: 0x00000474
	[DebuggerHidden]
	public <>f__AnonymousType1(<id>j__TPar id, <DiagnosticsCarrying>j__TPar DiagnosticsCarrying)
	{
		this.<id>i__Field = id;
		this.<DiagnosticsCarrying>i__Field = DiagnosticsCarrying;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002298 File Offset: 0x00000498
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType1<<id>j__TPar, <DiagnosticsCarrying>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<id>j__TPar>.Default.Equals(this.<id>i__Field, <>f__AnonymousType.<id>i__Field) && EqualityComparer<<DiagnosticsCarrying>j__TPar>.Default.Equals(this.<DiagnosticsCarrying>i__Field, <>f__AnonymousType.<DiagnosticsCarrying>i__Field);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000022E0 File Offset: 0x000004E0
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1227417408 + EqualityComparer<<id>j__TPar>.Default.GetHashCode(this.<id>i__Field)) * -1521134295 + EqualityComparer<<DiagnosticsCarrying>j__TPar>.Default.GetHashCode(this.<DiagnosticsCarrying>i__Field);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000231C File Offset: 0x0000051C
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ id = {0}, DiagnosticsCarrying = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<id>j__TPar <id>j__TPar = this.<id>i__Field;
		array[num] = ((<id>j__TPar != null) ? <id>j__TPar.ToString() : null);
		int num2 = 1;
		<DiagnosticsCarrying>j__TPar <DiagnosticsCarrying>j__TPar = this.<DiagnosticsCarrying>i__Field;
		array[num2] = ((<DiagnosticsCarrying>j__TPar != null) ? <DiagnosticsCarrying>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000004 RID: 4
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <id>j__TPar <id>i__Field;

	// Token: 0x04000005 RID: 5
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <DiagnosticsCarrying>j__TPar <DiagnosticsCarrying>i__Field;
}
