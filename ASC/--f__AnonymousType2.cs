using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[CompilerGenerated]
internal sealed class <>f__AnonymousType2<<idt>j__TPar, <text>j__TPar, <title>j__TPar>
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600000E RID: 14 RVA: 0x0000238C File Offset: 0x0000058C
	public <idt>j__TPar idt
	{
		get
		{
			return this.<idt>i__Field;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600000F RID: 15 RVA: 0x000023A0 File Offset: 0x000005A0
	public <text>j__TPar text
	{
		get
		{
			return this.<text>i__Field;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000010 RID: 16 RVA: 0x000023B4 File Offset: 0x000005B4
	public <title>j__TPar title
	{
		get
		{
			return this.<title>i__Field;
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000023C8 File Offset: 0x000005C8
	[DebuggerHidden]
	public <>f__AnonymousType2(<idt>j__TPar idt, <text>j__TPar text, <title>j__TPar title)
	{
		this.<idt>i__Field = idt;
		this.<text>i__Field = text;
		this.<title>i__Field = title;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000023F0 File Offset: 0x000005F0
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType2<<idt>j__TPar, <text>j__TPar, <title>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<idt>j__TPar>.Default.Equals(this.<idt>i__Field, <>f__AnonymousType.<idt>i__Field) && EqualityComparer<<text>j__TPar>.Default.Equals(this.<text>i__Field, <>f__AnonymousType.<text>i__Field) && EqualityComparer<<title>j__TPar>.Default.Equals(this.<title>i__Field, <>f__AnonymousType.<title>i__Field);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002450 File Offset: 0x00000650
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-1529013380 + EqualityComparer<<idt>j__TPar>.Default.GetHashCode(this.<idt>i__Field)) * -1521134295 + EqualityComparer<<text>j__TPar>.Default.GetHashCode(this.<text>i__Field)) * -1521134295 + EqualityComparer<<title>j__TPar>.Default.GetHashCode(this.<title>i__Field);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000024A4 File Offset: 0x000006A4
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ idt = {0}, text = {1}, title = {2} }}";
		object[] array = new object[3];
		int num = 0;
		<idt>j__TPar <idt>j__TPar = this.<idt>i__Field;
		array[num] = ((<idt>j__TPar != null) ? <idt>j__TPar.ToString() : null);
		int num2 = 1;
		<text>j__TPar <text>j__TPar = this.<text>i__Field;
		array[num2] = ((<text>j__TPar != null) ? <text>j__TPar.ToString() : null);
		int num3 = 2;
		<title>j__TPar <title>j__TPar = this.<title>i__Field;
		array[num3] = ((<title>j__TPar != null) ? <title>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000006 RID: 6
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <idt>j__TPar <idt>i__Field;

	// Token: 0x04000007 RID: 7
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <text>j__TPar <text>i__Field;

	// Token: 0x04000008 RID: 8
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <title>j__TPar <title>i__Field;
}
