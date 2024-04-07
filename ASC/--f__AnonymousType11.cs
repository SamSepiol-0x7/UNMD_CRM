using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000D RID: 13
[CompilerGenerated]
internal sealed class <>f__AnonymousType11<<created>j__TPar, <count>j__TPar, <price>j__TPar, <username>j__TPar, <name>j__TPar>
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00003100 File Offset: 0x00001300
	public <created>j__TPar created
	{
		get
		{
			return this.<created>i__Field;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00003114 File Offset: 0x00001314
	public <count>j__TPar count
	{
		get
		{
			return this.<count>i__Field;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00003128 File Offset: 0x00001328
	public <price>j__TPar price
	{
		get
		{
			return this.<price>i__Field;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600004C RID: 76 RVA: 0x0000313C File Offset: 0x0000133C
	public <username>j__TPar username
	{
		get
		{
			return this.<username>i__Field;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600004D RID: 77 RVA: 0x00003150 File Offset: 0x00001350
	public <name>j__TPar name
	{
		get
		{
			return this.<name>i__Field;
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003164 File Offset: 0x00001364
	[DebuggerHidden]
	public <>f__AnonymousType11(<created>j__TPar created, <count>j__TPar count, <price>j__TPar price, <username>j__TPar username, <name>j__TPar name)
	{
		this.<created>i__Field = created;
		this.<count>i__Field = count;
		this.<price>i__Field = price;
		this.<username>i__Field = username;
		this.<name>i__Field = name;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000319C File Offset: 0x0000139C
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType11<<created>j__TPar, <count>j__TPar, <price>j__TPar, <username>j__TPar, <name>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<created>j__TPar>.Default.Equals(this.<created>i__Field, <>f__AnonymousType.<created>i__Field) && EqualityComparer<<count>j__TPar>.Default.Equals(this.<count>i__Field, <>f__AnonymousType.<count>i__Field) && EqualityComparer<<price>j__TPar>.Default.Equals(this.<price>i__Field, <>f__AnonymousType.<price>i__Field) && EqualityComparer<<username>j__TPar>.Default.Equals(this.<username>i__Field, <>f__AnonymousType.<username>i__Field) && EqualityComparer<<name>j__TPar>.Default.Equals(this.<name>i__Field, <>f__AnonymousType.<name>i__Field);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000322C File Offset: 0x0000142C
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((((704700507 + EqualityComparer<<created>j__TPar>.Default.GetHashCode(this.<created>i__Field)) * -1521134295 + EqualityComparer<<count>j__TPar>.Default.GetHashCode(this.<count>i__Field)) * -1521134295 + EqualityComparer<<price>j__TPar>.Default.GetHashCode(this.<price>i__Field)) * -1521134295 + EqualityComparer<<username>j__TPar>.Default.GetHashCode(this.<username>i__Field)) * -1521134295 + EqualityComparer<<name>j__TPar>.Default.GetHashCode(this.<name>i__Field);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000032AC File Offset: 0x000014AC
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ created = {0}, count = {1}, price = {2}, username = {3}, name = {4} }}";
		object[] array = new object[5];
		int num = 0;
		<created>j__TPar <created>j__TPar = this.<created>i__Field;
		array[num] = ((<created>j__TPar != null) ? <created>j__TPar.ToString() : null);
		int num2 = 1;
		<count>j__TPar <count>j__TPar = this.<count>i__Field;
		array[num2] = ((<count>j__TPar != null) ? <count>j__TPar.ToString() : null);
		int num3 = 2;
		<price>j__TPar <price>j__TPar = this.<price>i__Field;
		array[num3] = ((<price>j__TPar != null) ? <price>j__TPar.ToString() : null);
		int num4 = 3;
		<username>j__TPar <username>j__TPar = this.<username>i__Field;
		array[num4] = ((<username>j__TPar != null) ? <username>j__TPar.ToString() : null);
		int num5 = 4;
		<name>j__TPar <name>j__TPar = this.<name>i__Field;
		array[num5] = ((<name>j__TPar != null) ? <name>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400001D RID: 29
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <created>j__TPar <created>i__Field;

	// Token: 0x0400001E RID: 30
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <count>j__TPar <count>i__Field;

	// Token: 0x0400001F RID: 31
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <price>j__TPar <price>i__Field;

	// Token: 0x04000020 RID: 32
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <username>j__TPar <username>i__Field;

	// Token: 0x04000021 RID: 33
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <name>j__TPar <name>i__Field;
}
