using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000C RID: 12
[CompilerGenerated]
internal sealed class <>f__AnonymousType10<<in_date>j__TPar, <out_date>j__TPar, <office>j__TPar, <type>j__TPar, <maker>j__TPar>
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000040 RID: 64 RVA: 0x00002E6C File Offset: 0x0000106C
	public <in_date>j__TPar in_date
	{
		get
		{
			return this.<in_date>i__Field;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000041 RID: 65 RVA: 0x00002E80 File Offset: 0x00001080
	public <out_date>j__TPar out_date
	{
		get
		{
			return this.<out_date>i__Field;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000042 RID: 66 RVA: 0x00002E94 File Offset: 0x00001094
	public <office>j__TPar office
	{
		get
		{
			return this.<office>i__Field;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000043 RID: 67 RVA: 0x00002EA8 File Offset: 0x000010A8
	public <type>j__TPar type
	{
		get
		{
			return this.<type>i__Field;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000044 RID: 68 RVA: 0x00002EBC File Offset: 0x000010BC
	public <maker>j__TPar maker
	{
		get
		{
			return this.<maker>i__Field;
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002ED0 File Offset: 0x000010D0
	[DebuggerHidden]
	public <>f__AnonymousType10(<in_date>j__TPar in_date, <out_date>j__TPar out_date, <office>j__TPar office, <type>j__TPar type, <maker>j__TPar maker)
	{
		this.<in_date>i__Field = in_date;
		this.<out_date>i__Field = out_date;
		this.<office>i__Field = office;
		this.<type>i__Field = type;
		this.<maker>i__Field = maker;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002F08 File Offset: 0x00001108
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType10<<in_date>j__TPar, <out_date>j__TPar, <office>j__TPar, <type>j__TPar, <maker>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<in_date>j__TPar>.Default.Equals(this.<in_date>i__Field, <>f__AnonymousType.<in_date>i__Field) && EqualityComparer<<out_date>j__TPar>.Default.Equals(this.<out_date>i__Field, <>f__AnonymousType.<out_date>i__Field) && EqualityComparer<<office>j__TPar>.Default.Equals(this.<office>i__Field, <>f__AnonymousType.<office>i__Field) && EqualityComparer<<type>j__TPar>.Default.Equals(this.<type>i__Field, <>f__AnonymousType.<type>i__Field) && EqualityComparer<<maker>j__TPar>.Default.Equals(this.<maker>i__Field, <>f__AnonymousType.<maker>i__Field);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002F98 File Offset: 0x00001198
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((((-342340513 + EqualityComparer<<in_date>j__TPar>.Default.GetHashCode(this.<in_date>i__Field)) * -1521134295 + EqualityComparer<<out_date>j__TPar>.Default.GetHashCode(this.<out_date>i__Field)) * -1521134295 + EqualityComparer<<office>j__TPar>.Default.GetHashCode(this.<office>i__Field)) * -1521134295 + EqualityComparer<<type>j__TPar>.Default.GetHashCode(this.<type>i__Field)) * -1521134295 + EqualityComparer<<maker>j__TPar>.Default.GetHashCode(this.<maker>i__Field);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003018 File Offset: 0x00001218
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ in_date = {0}, out_date = {1}, office = {2}, type = {3}, maker = {4} }}";
		object[] array = new object[5];
		int num = 0;
		<in_date>j__TPar <in_date>j__TPar = this.<in_date>i__Field;
		array[num] = ((<in_date>j__TPar != null) ? <in_date>j__TPar.ToString() : null);
		int num2 = 1;
		<out_date>j__TPar <out_date>j__TPar = this.<out_date>i__Field;
		array[num2] = ((<out_date>j__TPar != null) ? <out_date>j__TPar.ToString() : null);
		int num3 = 2;
		<office>j__TPar <office>j__TPar = this.<office>i__Field;
		array[num3] = ((<office>j__TPar != null) ? <office>j__TPar.ToString() : null);
		int num4 = 3;
		<type>j__TPar <type>j__TPar = this.<type>i__Field;
		array[num4] = ((<type>j__TPar != null) ? <type>j__TPar.ToString() : null);
		int num5 = 4;
		<maker>j__TPar <maker>j__TPar = this.<maker>i__Field;
		array[num5] = ((<maker>j__TPar != null) ? <maker>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000018 RID: 24
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <in_date>j__TPar <in_date>i__Field;

	// Token: 0x04000019 RID: 25
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <out_date>j__TPar <out_date>i__Field;

	// Token: 0x0400001A RID: 26
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <office>j__TPar <office>i__Field;

	// Token: 0x0400001B RID: 27
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <type>j__TPar <type>i__Field;

	// Token: 0x0400001C RID: 28
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <maker>j__TPar <maker>i__Field;
}
