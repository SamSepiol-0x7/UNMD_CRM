using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000A RID: 10
[CompilerGenerated]
internal sealed class <>f__AnonymousType8<<pr>j__TPar, <ru>j__TPar>
{
	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000034 RID: 52 RVA: 0x00002BEC File Offset: 0x00000DEC
	public <pr>j__TPar pr
	{
		get
		{
			return this.<pr>i__Field;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000035 RID: 53 RVA: 0x00002C00 File Offset: 0x00000E00
	public <ru>j__TPar ru
	{
		get
		{
			return this.<ru>i__Field;
		}
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002C14 File Offset: 0x00000E14
	[DebuggerHidden]
	public <>f__AnonymousType8(<pr>j__TPar pr, <ru>j__TPar ru)
	{
		this.<pr>i__Field = pr;
		this.<ru>i__Field = ru;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002C38 File Offset: 0x00000E38
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType8<<pr>j__TPar, <ru>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<pr>j__TPar>.Default.Equals(this.<pr>i__Field, <>f__AnonymousType.<pr>i__Field) && EqualityComparer<<ru>j__TPar>.Default.Equals(this.<ru>i__Field, <>f__AnonymousType.<ru>i__Field);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002C80 File Offset: 0x00000E80
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-494765275 + EqualityComparer<<pr>j__TPar>.Default.GetHashCode(this.<pr>i__Field)) * -1521134295 + EqualityComparer<<ru>j__TPar>.Default.GetHashCode(this.<ru>i__Field);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002CBC File Offset: 0x00000EBC
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ pr = {0}, ru = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<pr>j__TPar <pr>j__TPar = this.<pr>i__Field;
		array[num] = ((<pr>j__TPar != null) ? <pr>j__TPar.ToString() : null);
		int num2 = 1;
		<ru>j__TPar <ru>j__TPar = this.<ru>i__Field;
		array[num2] = ((<ru>j__TPar != null) ? <ru>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000014 RID: 20
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <pr>j__TPar <pr>i__Field;

	// Token: 0x04000015 RID: 21
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <ru>j__TPar <ru>i__Field;
}
