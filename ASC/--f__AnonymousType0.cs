using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000002 RID: 2
[CompilerGenerated]
internal sealed class <>f__AnonymousType0<<id>j__TPar, <created>j__TPar, <salary_rate>j__TPar>
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x0000209C File Offset: 0x0000029C
	public <id>j__TPar id
	{
		get
		{
			return this.<id>i__Field;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2 RVA: 0x000020B0 File Offset: 0x000002B0
	public <created>j__TPar created
	{
		get
		{
			return this.<created>i__Field;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000003 RID: 3 RVA: 0x000020C4 File Offset: 0x000002C4
	public <salary_rate>j__TPar salary_rate
	{
		get
		{
			return this.<salary_rate>i__Field;
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000020D8 File Offset: 0x000002D8
	[DebuggerHidden]
	public <>f__AnonymousType0(<id>j__TPar id, <created>j__TPar created, <salary_rate>j__TPar salary_rate)
	{
		this.<id>i__Field = id;
		this.<created>i__Field = created;
		this.<salary_rate>i__Field = salary_rate;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002100 File Offset: 0x00000300
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType0<<id>j__TPar, <created>j__TPar, <salary_rate>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<id>j__TPar>.Default.Equals(this.<id>i__Field, <>f__AnonymousType.<id>i__Field) && EqualityComparer<<created>j__TPar>.Default.Equals(this.<created>i__Field, <>f__AnonymousType.<created>i__Field) && EqualityComparer<<salary_rate>j__TPar>.Default.Equals(this.<salary_rate>i__Field, <>f__AnonymousType.<salary_rate>i__Field);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002160 File Offset: 0x00000360
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-154451018 + EqualityComparer<<id>j__TPar>.Default.GetHashCode(this.<id>i__Field)) * -1521134295 + EqualityComparer<<created>j__TPar>.Default.GetHashCode(this.<created>i__Field)) * -1521134295 + EqualityComparer<<salary_rate>j__TPar>.Default.GetHashCode(this.<salary_rate>i__Field);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000021B4 File Offset: 0x000003B4
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ id = {0}, created = {1}, salary_rate = {2} }}";
		object[] array = new object[3];
		int num = 0;
		<id>j__TPar <id>j__TPar = this.<id>i__Field;
		array[num] = ((<id>j__TPar != null) ? <id>j__TPar.ToString() : null);
		int num2 = 1;
		<created>j__TPar <created>j__TPar = this.<created>i__Field;
		array[num2] = ((<created>j__TPar != null) ? <created>j__TPar.ToString() : null);
		int num3 = 2;
		<salary_rate>j__TPar <salary_rate>j__TPar = this.<salary_rate>i__Field;
		array[num3] = ((<salary_rate>j__TPar != null) ? <salary_rate>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000001 RID: 1
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <id>j__TPar <id>i__Field;

	// Token: 0x04000002 RID: 2
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <created>j__TPar <created>i__Field;

	// Token: 0x04000003 RID: 3
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <salary_rate>j__TPar <salary_rate>i__Field;
}
