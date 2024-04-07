using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000B RID: 11
[CompilerGenerated]
internal sealed class <>f__AnonymousType9<<Id>j__TPar, <Name>j__TPar>
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600003A RID: 58 RVA: 0x00002D2C File Offset: 0x00000F2C
	public <Id>j__TPar Id
	{
		get
		{
			return this.<Id>i__Field;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600003B RID: 59 RVA: 0x00002D40 File Offset: 0x00000F40
	public <Name>j__TPar Name
	{
		get
		{
			return this.<Name>i__Field;
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002D54 File Offset: 0x00000F54
	[DebuggerHidden]
	public <>f__AnonymousType9(<Id>j__TPar Id, <Name>j__TPar Name)
	{
		this.<Id>i__Field = Id;
		this.<Name>i__Field = Name;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002D78 File Offset: 0x00000F78
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType9<<Id>j__TPar, <Name>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<Id>j__TPar>.Default.Equals(this.<Id>i__Field, <>f__AnonymousType.<Id>i__Field) && EqualityComparer<<Name>j__TPar>.Default.Equals(this.<Name>i__Field, <>f__AnonymousType.<Name>i__Field);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-2039462260 + EqualityComparer<<Id>j__TPar>.Default.GetHashCode(this.<Id>i__Field)) * -1521134295 + EqualityComparer<<Name>j__TPar>.Default.GetHashCode(this.<Name>i__Field);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002DFC File Offset: 0x00000FFC
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Id = {0}, Name = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<Id>j__TPar <Id>j__TPar = this.<Id>i__Field;
		array[num] = ((<Id>j__TPar != null) ? <Id>j__TPar.ToString() : null);
		int num2 = 1;
		<Name>j__TPar <Name>j__TPar = this.<Name>i__Field;
		array[num2] = ((<Name>j__TPar != null) ? <Name>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000016 RID: 22
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Id>j__TPar <Id>i__Field;

	// Token: 0x04000017 RID: 23
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Name>j__TPar <Name>i__Field;
}
