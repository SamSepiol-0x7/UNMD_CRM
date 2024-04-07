using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000005 RID: 5
[CompilerGenerated]
internal sealed class <>f__AnonymousType3<<pay_repair>j__TPar, <pay_repair_quick>j__TPar>
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000015 RID: 21 RVA: 0x0000253C File Offset: 0x0000073C
	public <pay_repair>j__TPar pay_repair
	{
		get
		{
			return this.<pay_repair>i__Field;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000016 RID: 22 RVA: 0x00002550 File Offset: 0x00000750
	public <pay_repair_quick>j__TPar pay_repair_quick
	{
		get
		{
			return this.<pay_repair_quick>i__Field;
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002564 File Offset: 0x00000764
	[DebuggerHidden]
	public <>f__AnonymousType3(<pay_repair>j__TPar pay_repair, <pay_repair_quick>j__TPar pay_repair_quick)
	{
		this.<pay_repair>i__Field = pay_repair;
		this.<pay_repair_quick>i__Field = pay_repair_quick;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002588 File Offset: 0x00000788
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType3<<pay_repair>j__TPar, <pay_repair_quick>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<pay_repair>j__TPar>.Default.Equals(this.<pay_repair>i__Field, <>f__AnonymousType.<pay_repair>i__Field) && EqualityComparer<<pay_repair_quick>j__TPar>.Default.Equals(this.<pay_repair_quick>i__Field, <>f__AnonymousType.<pay_repair_quick>i__Field);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000025D0 File Offset: 0x000007D0
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-245932024 + EqualityComparer<<pay_repair>j__TPar>.Default.GetHashCode(this.<pay_repair>i__Field)) * -1521134295 + EqualityComparer<<pay_repair_quick>j__TPar>.Default.GetHashCode(this.<pay_repair_quick>i__Field);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000260C File Offset: 0x0000080C
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ pay_repair = {0}, pay_repair_quick = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<pay_repair>j__TPar <pay_repair>j__TPar = this.<pay_repair>i__Field;
		array[num] = ((<pay_repair>j__TPar != null) ? <pay_repair>j__TPar.ToString() : null);
		int num2 = 1;
		<pay_repair_quick>j__TPar <pay_repair_quick>j__TPar = this.<pay_repair_quick>i__Field;
		array[num2] = ((<pay_repair_quick>j__TPar != null) ? <pay_repair_quick>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000009 RID: 9
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <pay_repair>j__TPar <pay_repair>i__Field;

	// Token: 0x0400000A RID: 10
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <pay_repair_quick>j__TPar <pay_repair_quick>i__Field;
}
