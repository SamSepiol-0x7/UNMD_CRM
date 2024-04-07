using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000012 RID: 18
[CompilerGenerated]
internal sealed class <>f__AnonymousType16<<r>j__TPar, <ru>j__TPar>
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600006B RID: 107 RVA: 0x00003904 File Offset: 0x00001B04
	public <r>j__TPar r
	{
		get
		{
			return this.<r>i__Field;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00003918 File Offset: 0x00001B18
	public <ru>j__TPar ru
	{
		get
		{
			return this.<ru>i__Field;
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0000392C File Offset: 0x00001B2C
	[DebuggerHidden]
	public <>f__AnonymousType16(<r>j__TPar r, <ru>j__TPar ru)
	{
		this.<r>i__Field = r;
		this.<ru>i__Field = ru;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00003950 File Offset: 0x00001B50
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType16<<r>j__TPar, <ru>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<r>j__TPar>.Default.Equals(this.<r>i__Field, <>f__AnonymousType.<r>i__Field) && EqualityComparer<<ru>j__TPar>.Default.Equals(this.<ru>i__Field, <>f__AnonymousType.<ru>i__Field);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003998 File Offset: 0x00001B98
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1652878347 + EqualityComparer<<r>j__TPar>.Default.GetHashCode(this.<r>i__Field)) * -1521134295 + EqualityComparer<<ru>j__TPar>.Default.GetHashCode(this.<ru>i__Field);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000039D4 File Offset: 0x00001BD4
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ r = {0}, ru = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<r>j__TPar <r>j__TPar = this.<r>i__Field;
		array[num] = ((<r>j__TPar != null) ? <r>j__TPar.ToString() : null);
		int num2 = 1;
		<ru>j__TPar <ru>j__TPar = this.<ru>i__Field;
		array[num2] = ((<ru>j__TPar != null) ? <ru>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400002B RID: 43
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <r>j__TPar <r>i__Field;

	// Token: 0x0400002C RID: 44
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <ru>j__TPar <ru>i__Field;
}
