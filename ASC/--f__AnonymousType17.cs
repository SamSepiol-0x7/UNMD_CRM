using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000013 RID: 19
[CompilerGenerated]
internal sealed class <>f__AnonymousType17<<name>j__TPar, <description>j__TPar>
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000071 RID: 113 RVA: 0x00003A44 File Offset: 0x00001C44
	public <name>j__TPar name
	{
		get
		{
			return this.<name>i__Field;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000072 RID: 114 RVA: 0x00003A58 File Offset: 0x00001C58
	public <description>j__TPar description
	{
		get
		{
			return this.<description>i__Field;
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00003A6C File Offset: 0x00001C6C
	[DebuggerHidden]
	public <>f__AnonymousType17(<name>j__TPar name, <description>j__TPar description)
	{
		this.<name>i__Field = name;
		this.<description>i__Field = description;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003A90 File Offset: 0x00001C90
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType17<<name>j__TPar, <description>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<name>j__TPar>.Default.Equals(this.<name>i__Field, <>f__AnonymousType.<name>i__Field) && EqualityComparer<<description>j__TPar>.Default.Equals(this.<description>i__Field, <>f__AnonymousType.<description>i__Field);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003AD8 File Offset: 0x00001CD8
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1243707857 + EqualityComparer<<name>j__TPar>.Default.GetHashCode(this.<name>i__Field)) * -1521134295 + EqualityComparer<<description>j__TPar>.Default.GetHashCode(this.<description>i__Field);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003B14 File Offset: 0x00001D14
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ name = {0}, description = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<name>j__TPar <name>j__TPar = this.<name>i__Field;
		array[num] = ((<name>j__TPar != null) ? <name>j__TPar.ToString() : null);
		int num2 = 1;
		<description>j__TPar <description>j__TPar = this.<description>i__Field;
		array[num2] = ((<description>j__TPar != null) ? <description>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400002D RID: 45
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <name>j__TPar <name>i__Field;

	// Token: 0x0400002E RID: 46
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <description>j__TPar <description>i__Field;
}
