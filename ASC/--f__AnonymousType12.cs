using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000E RID: 14
[CompilerGenerated]
internal sealed class <>f__AnonymousType12<<name>j__TPar, <category>j__TPar, <state>j__TPar>
{
	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000052 RID: 82 RVA: 0x00003394 File Offset: 0x00001594
	public <name>j__TPar name
	{
		get
		{
			return this.<name>i__Field;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000053 RID: 83 RVA: 0x000033A8 File Offset: 0x000015A8
	public <category>j__TPar category
	{
		get
		{
			return this.<category>i__Field;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000054 RID: 84 RVA: 0x000033BC File Offset: 0x000015BC
	public <state>j__TPar state
	{
		get
		{
			return this.<state>i__Field;
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000033D0 File Offset: 0x000015D0
	[DebuggerHidden]
	public <>f__AnonymousType12(<name>j__TPar name, <category>j__TPar category, <state>j__TPar state)
	{
		this.<name>i__Field = name;
		this.<category>i__Field = category;
		this.<state>i__Field = state;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000033F8 File Offset: 0x000015F8
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType12<<name>j__TPar, <category>j__TPar, <state>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<name>j__TPar>.Default.Equals(this.<name>i__Field, <>f__AnonymousType.<name>i__Field) && EqualityComparer<<category>j__TPar>.Default.Equals(this.<category>i__Field, <>f__AnonymousType.<category>i__Field) && EqualityComparer<<state>j__TPar>.Default.Equals(this.<state>i__Field, <>f__AnonymousType.<state>i__Field);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00003458 File Offset: 0x00001658
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-873243386 + EqualityComparer<<name>j__TPar>.Default.GetHashCode(this.<name>i__Field)) * -1521134295 + EqualityComparer<<category>j__TPar>.Default.GetHashCode(this.<category>i__Field)) * -1521134295 + EqualityComparer<<state>j__TPar>.Default.GetHashCode(this.<state>i__Field);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000034AC File Offset: 0x000016AC
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ name = {0}, category = {1}, state = {2} }}";
		object[] array = new object[3];
		int num = 0;
		<name>j__TPar <name>j__TPar = this.<name>i__Field;
		array[num] = ((<name>j__TPar != null) ? <name>j__TPar.ToString() : null);
		int num2 = 1;
		<category>j__TPar <category>j__TPar = this.<category>i__Field;
		array[num2] = ((<category>j__TPar != null) ? <category>j__TPar.ToString() : null);
		int num3 = 2;
		<state>j__TPar <state>j__TPar = this.<state>i__Field;
		array[num3] = ((<state>j__TPar != null) ? <state>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000022 RID: 34
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <name>j__TPar <name>i__Field;

	// Token: 0x04000023 RID: 35
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <category>j__TPar <category>i__Field;

	// Token: 0x04000024 RID: 36
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <state>j__TPar <state>i__Field;
}
