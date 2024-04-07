using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000009 RID: 9
[CompilerGenerated]
internal sealed class <>f__AnonymousType7<<usr>j__TPar, <ru>j__TPar>
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600002E RID: 46 RVA: 0x00002AAC File Offset: 0x00000CAC
	public <usr>j__TPar usr
	{
		get
		{
			return this.<usr>i__Field;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600002F RID: 47 RVA: 0x00002AC0 File Offset: 0x00000CC0
	public <ru>j__TPar ru
	{
		get
		{
			return this.<ru>i__Field;
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002AD4 File Offset: 0x00000CD4
	[DebuggerHidden]
	public <>f__AnonymousType7(<usr>j__TPar usr, <ru>j__TPar ru)
	{
		this.<usr>i__Field = usr;
		this.<ru>i__Field = ru;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002AF8 File Offset: 0x00000CF8
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType7<<usr>j__TPar, <ru>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<usr>j__TPar>.Default.Equals(this.<usr>i__Field, <>f__AnonymousType.<usr>i__Field) && EqualityComparer<<ru>j__TPar>.Default.Equals(this.<ru>i__Field, <>f__AnonymousType.<ru>i__Field);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002B40 File Offset: 0x00000D40
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (668241931 + EqualityComparer<<usr>j__TPar>.Default.GetHashCode(this.<usr>i__Field)) * -1521134295 + EqualityComparer<<ru>j__TPar>.Default.GetHashCode(this.<ru>i__Field);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002B7C File Offset: 0x00000D7C
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ usr = {0}, ru = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<usr>j__TPar <usr>j__TPar = this.<usr>i__Field;
		array[num] = ((<usr>j__TPar != null) ? <usr>j__TPar.ToString() : null);
		int num2 = 1;
		<ru>j__TPar <ru>j__TPar = this.<ru>i__Field;
		array[num2] = ((<ru>j__TPar != null) ? <ru>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000012 RID: 18
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <usr>j__TPar <usr>i__Field;

	// Token: 0x04000013 RID: 19
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <ru>j__TPar <ru>i__Field;
}
