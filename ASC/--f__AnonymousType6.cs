using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000008 RID: 8
[CompilerGenerated]
internal sealed class <>f__AnonymousType6<<Articul>j__TPar, <Name>j__TPar, <State>j__TPar>
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000027 RID: 39 RVA: 0x000028FC File Offset: 0x00000AFC
	public <Articul>j__TPar Articul
	{
		get
		{
			return this.<Articul>i__Field;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000028 RID: 40 RVA: 0x00002910 File Offset: 0x00000B10
	public <Name>j__TPar Name
	{
		get
		{
			return this.<Name>i__Field;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000029 RID: 41 RVA: 0x00002924 File Offset: 0x00000B24
	public <State>j__TPar State
	{
		get
		{
			return this.<State>i__Field;
		}
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002938 File Offset: 0x00000B38
	[DebuggerHidden]
	public <>f__AnonymousType6(<Articul>j__TPar Articul, <Name>j__TPar Name, <State>j__TPar State)
	{
		this.<Articul>i__Field = Articul;
		this.<Name>i__Field = Name;
		this.<State>i__Field = State;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002960 File Offset: 0x00000B60
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType6<<Articul>j__TPar, <Name>j__TPar, <State>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<Articul>j__TPar>.Default.Equals(this.<Articul>i__Field, <>f__AnonymousType.<Articul>i__Field) && EqualityComparer<<Name>j__TPar>.Default.Equals(this.<Name>i__Field, <>f__AnonymousType.<Name>i__Field) && EqualityComparer<<State>j__TPar>.Default.Equals(this.<State>i__Field, <>f__AnonymousType.<State>i__Field);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000029C0 File Offset: 0x00000BC0
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((1067571596 + EqualityComparer<<Articul>j__TPar>.Default.GetHashCode(this.<Articul>i__Field)) * -1521134295 + EqualityComparer<<Name>j__TPar>.Default.GetHashCode(this.<Name>i__Field)) * -1521134295 + EqualityComparer<<State>j__TPar>.Default.GetHashCode(this.<State>i__Field);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002A14 File Offset: 0x00000C14
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Articul = {0}, Name = {1}, State = {2} }}";
		object[] array = new object[3];
		int num = 0;
		<Articul>j__TPar <Articul>j__TPar = this.<Articul>i__Field;
		array[num] = ((<Articul>j__TPar != null) ? <Articul>j__TPar.ToString() : null);
		int num2 = 1;
		<Name>j__TPar <Name>j__TPar = this.<Name>i__Field;
		array[num2] = ((<Name>j__TPar != null) ? <Name>j__TPar.ToString() : null);
		int num3 = 2;
		<State>j__TPar <State>j__TPar = this.<State>i__Field;
		array[num3] = ((<State>j__TPar != null) ? <State>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400000F RID: 15
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Articul>j__TPar <Articul>i__Field;

	// Token: 0x04000010 RID: 16
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <Name>j__TPar <Name>i__Field;

	// Token: 0x04000011 RID: 17
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <State>j__TPar <State>i__Field;
}
