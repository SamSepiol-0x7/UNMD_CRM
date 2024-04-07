using System;
using System.Runtime.CompilerServices;

namespace ASC.Annotations
{
	// Token: 0x020000CF RID: 207
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ContractAnnotationAttribute : Attribute
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x0002B860 File Offset: 0x00029A60
		public ContractAnnotationAttribute([NotNull] string contract) : this(contract, false)
		{
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0002B878 File Offset: 0x00029A78
		public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
		{
			this.Contract = contract;
			this.ForceFullStates = forceFullStates;
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0002B89C File Offset: 0x00029A9C
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x0002B8B0 File Offset: 0x00029AB0
		[NotNull]
		public string Contract
		{
			[CompilerGenerated]
			get
			{
				return this.<Contract>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Contract>k__BackingField = value;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0002B8C4 File Offset: 0x00029AC4
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x0002B8D8 File Offset: 0x00029AD8
		public bool ForceFullStates
		{
			[CompilerGenerated]
			get
			{
				return this.<ForceFullStates>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ForceFullStates>k__BackingField = value;
			}
		}

		// Token: 0x04000976 RID: 2422
		[CompilerGenerated]
		private string <Contract>k__BackingField;

		// Token: 0x04000977 RID: 2423
		[CompilerGenerated]
		private bool <ForceFullStates>k__BackingField;
	}
}
