using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000011 RID: 17
[CompilerGenerated]
internal sealed class <>f__AnonymousType15<<name>j__TPar, <uid>j__TPar>
{
	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000065 RID: 101 RVA: 0x000037C4 File Offset: 0x000019C4
	public <name>j__TPar name
	{
		get
		{
			return this.<name>i__Field;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000066 RID: 102 RVA: 0x000037D8 File Offset: 0x000019D8
	public <uid>j__TPar uid
	{
		get
		{
			return this.<uid>i__Field;
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000037EC File Offset: 0x000019EC
	[DebuggerHidden]
	public <>f__AnonymousType15(<name>j__TPar name, <uid>j__TPar uid)
	{
		this.<name>i__Field = name;
		this.<uid>i__Field = uid;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003810 File Offset: 0x00001A10
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType15<<name>j__TPar, <uid>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<name>j__TPar>.Default.Equals(this.<name>i__Field, <>f__AnonymousType.<name>i__Field) && EqualityComparer<<uid>j__TPar>.Default.Equals(this.<uid>i__Field, <>f__AnonymousType.<uid>i__Field);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003858 File Offset: 0x00001A58
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1074117929 + EqualityComparer<<name>j__TPar>.Default.GetHashCode(this.<name>i__Field)) * -1521134295 + EqualityComparer<<uid>j__TPar>.Default.GetHashCode(this.<uid>i__Field);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00003894 File Offset: 0x00001A94
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ name = {0}, uid = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<name>j__TPar <name>j__TPar = this.<name>i__Field;
		array[num] = ((<name>j__TPar != null) ? <name>j__TPar.ToString() : null);
		int num2 = 1;
		<uid>j__TPar <uid>j__TPar = this.<uid>i__Field;
		array[num2] = ((<uid>j__TPar != null) ? <uid>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000029 RID: 41
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <name>j__TPar <name>i__Field;

	// Token: 0x0400002A RID: 42
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <uid>j__TPar <uid>i__Field;
}
