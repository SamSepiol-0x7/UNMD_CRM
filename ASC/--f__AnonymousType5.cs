using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000007 RID: 7
[CompilerGenerated]
internal sealed class <>f__AnonymousType5<<p>j__TPar, <pr>j__TPar>
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000021 RID: 33 RVA: 0x000027BC File Offset: 0x000009BC
	public <p>j__TPar p
	{
		get
		{
			return this.<p>i__Field;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000022 RID: 34 RVA: 0x000027D0 File Offset: 0x000009D0
	public <pr>j__TPar pr
	{
		get
		{
			return this.<pr>i__Field;
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000027E4 File Offset: 0x000009E4
	[DebuggerHidden]
	public <>f__AnonymousType5(<p>j__TPar p, <pr>j__TPar pr)
	{
		this.<p>i__Field = p;
		this.<pr>i__Field = pr;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002808 File Offset: 0x00000A08
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType5<<p>j__TPar, <pr>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<p>j__TPar>.Default.Equals(this.<p>i__Field, <>f__AnonymousType.<p>i__Field) && EqualityComparer<<pr>j__TPar>.Default.Equals(this.<pr>i__Field, <>f__AnonymousType.<pr>i__Field);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002850 File Offset: 0x00000A50
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1334597356 + EqualityComparer<<p>j__TPar>.Default.GetHashCode(this.<p>i__Field)) * -1521134295 + EqualityComparer<<pr>j__TPar>.Default.GetHashCode(this.<pr>i__Field);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0000288C File Offset: 0x00000A8C
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ p = {0}, pr = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<p>j__TPar <p>j__TPar = this.<p>i__Field;
		array[num] = ((<p>j__TPar != null) ? <p>j__TPar.ToString() : null);
		int num2 = 1;
		<pr>j__TPar <pr>j__TPar = this.<pr>i__Field;
		array[num2] = ((<pr>j__TPar != null) ? <pr>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400000D RID: 13
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <p>j__TPar <p>i__Field;

	// Token: 0x0400000E RID: 14
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <pr>j__TPar <pr>i__Field;
}
