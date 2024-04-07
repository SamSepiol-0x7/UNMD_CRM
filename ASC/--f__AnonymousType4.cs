using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000006 RID: 6
[CompilerGenerated]
internal sealed class <>f__AnonymousType4<<Index>j__TPar, <Value>j__TPar>
{
	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600001B RID: 27 RVA: 0x0000267C File Offset: 0x0000087C
	public <Index>j__TPar Index
	{
		get
		{
			return this.<Index>i__Field;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600001C RID: 28 RVA: 0x00002690 File Offset: 0x00000890
	public <Value>j__TPar Value
	{
		get
		{
			return this.<Value>i__Field;
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000026A4 File Offset: 0x000008A4
	[DebuggerHidden]
	public <>f__AnonymousType4(<Index>j__TPar Index, <Value>j__TPar Value)
	{
		this.<Index>i__Field = Index;
		this.<Value>i__Field = Value;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000026C8 File Offset: 0x000008C8
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType4<<Index>j__TPar, <Value>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<Index>j__TPar>.Default.Equals(this.<Index>i__Field, <>f__AnonymousType.<Index>i__Field) && EqualityComparer<<Value>j__TPar>.Default.Equals(this.<Value>i__Field, <>f__AnonymousType.<Value>i__Field);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002710 File Offset: 0x00000910
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1381124481 + EqualityComparer<<Index>j__TPar>.Default.GetHashCode(this.<Index>i__Field)) * -1521134295 + EqualityComparer<<Value>j__TPar>.Default.GetHashCode(this.<Value>i__Field);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000274C File Offset: 0x0000094C
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Index = {0}, Value = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<Index>j__TPar <Index>j__TPar = this.<Index>i__Field;
		array[num] = ((<Index>j__TPar != null) ? <Index>j__TPar.ToString() : null);
		int num2 = 1;
		<Value>j__TPar <Value>j__TPar = this.<Value>i__Field;
		array[num2] = ((<Value>j__TPar != null) ? <Value>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400000B RID: 11
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Index>j__TPar <Index>i__Field;

	// Token: 0x0400000C RID: 12
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Value>j__TPar <Value>i__Field;
}
