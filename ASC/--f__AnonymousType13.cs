using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000F RID: 15
[CompilerGenerated]
internal sealed class <>f__AnonymousType13<<groupId>j__TPar, <gItems>j__TPar>
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000059 RID: 89 RVA: 0x00003544 File Offset: 0x00001744
	public <groupId>j__TPar groupId
	{
		get
		{
			return this.<groupId>i__Field;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600005A RID: 90 RVA: 0x00003558 File Offset: 0x00001758
	public <gItems>j__TPar gItems
	{
		get
		{
			return this.<gItems>i__Field;
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000356C File Offset: 0x0000176C
	[DebuggerHidden]
	public <>f__AnonymousType13(<groupId>j__TPar groupId, <gItems>j__TPar gItems)
	{
		this.<groupId>i__Field = groupId;
		this.<gItems>i__Field = gItems;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003590 File Offset: 0x00001790
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		var <>f__AnonymousType = value as <>f__AnonymousType13<<groupId>j__TPar, <gItems>j__TPar>;
		return <>f__AnonymousType != null && EqualityComparer<<groupId>j__TPar>.Default.Equals(this.<groupId>i__Field, <>f__AnonymousType.<groupId>i__Field) && EqualityComparer<<gItems>j__TPar>.Default.Equals(this.<gItems>i__Field, <>f__AnonymousType.<gItems>i__Field);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000035D8 File Offset: 0x000017D8
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (454873729 + EqualityComparer<<groupId>j__TPar>.Default.GetHashCode(this.<groupId>i__Field)) * -1521134295 + EqualityComparer<<gItems>j__TPar>.Default.GetHashCode(this.<gItems>i__Field);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003614 File Offset: 0x00001814
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ groupId = {0}, gItems = {1} }}";
		object[] array = new object[2];
		int num = 0;
		<groupId>j__TPar <groupId>j__TPar = this.<groupId>i__Field;
		array[num] = ((<groupId>j__TPar != null) ? <groupId>j__TPar.ToString() : null);
		int num2 = 1;
		<gItems>j__TPar <gItems>j__TPar = this.<gItems>i__Field;
		array[num2] = ((<gItems>j__TPar != null) ? <gItems>j__TPar.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000025 RID: 37
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <groupId>j__TPar <groupId>i__Field;

	// Token: 0x04000026 RID: 38
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly <gItems>j__TPar <gItems>i__Field;
}
