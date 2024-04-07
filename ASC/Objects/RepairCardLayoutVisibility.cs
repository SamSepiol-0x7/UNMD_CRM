using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ASC.RepairCard;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm;

namespace ASC.Objects
{
	// Token: 0x020008F2 RID: 2290
	public class RepairCardLayoutVisibility : BindableBase
	{
		// Token: 0x06004731 RID: 18225 RVA: 0x00115988 File Offset: 0x00113B88
		public RepairCardLayoutVisibility(RepairCardViewModel viewModel)
		{
			this._cardViewModel = viewModel;
			this.OverviewVisible = true;
			this.DiagnosticResultVisible = true;
			this.SetOfficeVisibility();
			this.ColorChooserVisible = (OfflineData.Instance.Employee.Can(61, 0) && Auth.User.offices1.paint_repairs);
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x001159E4 File Offset: 0x00113BE4
		// (set) Token: 0x06004733 RID: 18227 RVA: 0x001159F8 File Offset: 0x00113BF8
		public bool ColorChooserVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<ColorChooserVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ColorChooserVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -2108723926;
				IL_10:
				switch ((num ^ -2039855297) % 4)
				{
				case 0:
					IL_2F:
					num = -1543620867;
					goto IL_10;
				case 1:
					return;
				case 3:
					goto IL_0B;
				}
				this.<ColorChooserVisible>k__BackingField = value;
				this.RaisePropertyChanged("ColorChooserVisible");
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x00115A50 File Offset: 0x00113C50
		// (set) Token: 0x06004735 RID: 18229 RVA: 0x00115A64 File Offset: 0x00113C64
		public bool OverviewVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<OverviewVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OverviewVisible>k__BackingField == value)
				{
					return;
				}
				this.<OverviewVisible>k__BackingField = value;
				this.RaisePropertyChanged("OverviewVisible");
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06004736 RID: 18230 RVA: 0x00115A90 File Offset: 0x00113C90
		// (set) Token: 0x06004737 RID: 18231 RVA: 0x00115AA4 File Offset: 0x00113CA4
		public bool DiagnosticResultVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<DiagnosticResultVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DiagnosticResultVisible>k__BackingField == value)
				{
					return;
				}
				this.<DiagnosticResultVisible>k__BackingField = value;
				this.RaisePropertyChanged("DiagnosticResultVisible");
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x00115AD0 File Offset: 0x00113CD0
		// (set) Token: 0x06004739 RID: 18233 RVA: 0x00115AE4 File Offset: 0x00113CE4
		public bool RejectVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<RejectVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RejectVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -408181260;
				IL_10:
				switch ((num ^ -1088350527) % 4)
				{
				case 0:
					IL_2F:
					num = -1455614214;
					goto IL_10;
				case 1:
					return;
				case 2:
					goto IL_0B;
				}
				this.<RejectVisible>k__BackingField = value;
				this.RaisePropertyChanged("RejectVisible");
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x00115B3C File Offset: 0x00113D3C
		// (set) Token: 0x0600473B RID: 18235 RVA: 0x00115B50 File Offset: 0x00113D50
		public bool CloseDebtVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<CloseDebtVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CloseDebtVisible>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -1037181702;
				IL_10:
				switch ((num ^ -560388441) % 4)
				{
				case 1:
					return;
				case 2:
					goto IL_0B;
				case 3:
					IL_2F:
					this.<CloseDebtVisible>k__BackingField = value;
					num = -345435253;
					goto IL_10;
				}
				this.RaisePropertyChanged("CloseDebtVisible");
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x00115BA8 File Offset: 0x00113DA8
		// (set) Token: 0x0600473D RID: 18237 RVA: 0x00115BBC File Offset: 0x00113DBC
		public bool CreateInvoiceVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<CreateInvoiceVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CreateInvoiceVisible>k__BackingField == value)
				{
					return;
				}
				this.<CreateInvoiceVisible>k__BackingField = value;
				this.RaisePropertyChanged("CreateInvoiceVisible");
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x00115BE8 File Offset: 0x00113DE8
		// (set) Token: 0x0600473F RID: 18239 RVA: 0x00115BFC File Offset: 0x00113DFC
		public bool MakePrepaidVisible
		{
			[CompilerGenerated]
			get
			{
				return this.<MakePrepaidVisible>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MakePrepaidVisible>k__BackingField == value)
				{
					return;
				}
				this.<MakePrepaidVisible>k__BackingField = value;
				this.RaisePropertyChanged("MakePrepaidVisible");
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x00115C28 File Offset: 0x00113E28
		// (set) Token: 0x06004741 RID: 18241 RVA: 0x00115C3C File Offset: 0x00113E3C
		public bool OfficeVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<OfficeVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OfficeVisibility>k__BackingField == value)
				{
					return;
				}
				this.<OfficeVisibility>k__BackingField = value;
				this.RaisePropertyChanged("OfficeVisibility");
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x00115C68 File Offset: 0x00113E68
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x00115C7C File Offset: 0x00113E7C
		public bool CustomerInfoVisibility
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerInfoVisibility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CustomerInfoVisibility>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -732762207;
				IL_10:
				switch ((num ^ -1768538460) % 4)
				{
				case 1:
					return;
				case 2:
					IL_2F:
					num = -32927328;
					goto IL_10;
				case 3:
					goto IL_0B;
				}
				this.<CustomerInfoVisibility>k__BackingField = value;
				this.RaisePropertyChanged("CustomerInfoVisibility");
			}
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x00115CD4 File Offset: 0x00113ED4
		public void DefaultLayoutVisibility(int state)
		{
			if (state != 0)
			{
				if (state != 12)
				{
					if (state == 16)
					{
						this.CloseDebtVisible = true;
					}
				}
				else
				{
					this.RejectVisible = true;
				}
			}
			this.CreateInvoiceVisible = (this._cardViewModel.Repair.invoice == null && this._cardViewModel.Repair.IsCashLess && OfflineData.Instance.Employee.Can(65, 0));
			this.MakePrepaidVisible = (this._cardViewModel.Repair.invoice == null && !this._cardViewModel.Repair.IsCashLess && this._cardViewModel.Repair.state != 16 && this._cardViewModel.Repair.state != 8 && this._cardViewModel.Repair.state != 12 && OfflineData.Instance.Employee.Can(16, 0));
			this.DiagnosticResultVisible = (this._cardViewModel.Repair.cartridge == null);
			this.OverviewVisible = (this._cardViewModel.Repair.cartridge == null);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x00115E0C File Offset: 0x0011400C
		public void SetOfficeVisibility()
		{
			RepairCardLayoutVisibility.<SetOfficeVisibility>d__39 <SetOfficeVisibility>d__;
			<SetOfficeVisibility>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SetOfficeVisibility>d__.<>4__this = this;
			<SetOfficeVisibility>d__.<>1__state = -1;
			<SetOfficeVisibility>d__.<>t__builder.Start<RepairCardLayoutVisibility.<SetOfficeVisibility>d__39>(ref <SetOfficeVisibility>d__);
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x00115E44 File Offset: 0x00114044
		public void SetCustomerInfoVisibility(bool value)
		{
			this.CustomerInfoVisibility = value;
		}

		// Token: 0x04002DAC RID: 11692
		private readonly RepairCardViewModel _cardViewModel;

		// Token: 0x04002DAD RID: 11693
		[CompilerGenerated]
		private bool <ColorChooserVisible>k__BackingField;

		// Token: 0x04002DAE RID: 11694
		[CompilerGenerated]
		private bool <OverviewVisible>k__BackingField;

		// Token: 0x04002DAF RID: 11695
		[CompilerGenerated]
		private bool <DiagnosticResultVisible>k__BackingField;

		// Token: 0x04002DB0 RID: 11696
		[CompilerGenerated]
		private bool <RejectVisible>k__BackingField;

		// Token: 0x04002DB1 RID: 11697
		[CompilerGenerated]
		private bool <CloseDebtVisible>k__BackingField;

		// Token: 0x04002DB2 RID: 11698
		[CompilerGenerated]
		private bool <CreateInvoiceVisible>k__BackingField;

		// Token: 0x04002DB3 RID: 11699
		[CompilerGenerated]
		private bool <MakePrepaidVisible>k__BackingField;

		// Token: 0x04002DB4 RID: 11700
		[CompilerGenerated]
		private bool <OfficeVisibility>k__BackingField;

		// Token: 0x04002DB5 RID: 11701
		[CompilerGenerated]
		private bool <CustomerInfoVisibility>k__BackingField;

		// Token: 0x020008F3 RID: 2291
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <SetOfficeVisibility>d__39 : IAsyncStateMachine
		{
			// Token: 0x06004747 RID: 18247 RVA: 0x00115E58 File Offset: 0x00114058
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCardLayoutVisibility repairCardLayoutVisibility = this.<>4__this;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						awaiter = Bootstrapper.Container.Resolve<IOfficeService>().CountActiveOfficesAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, RepairCardLayoutVisibility.<SetOfficeVisibility>d__39>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<int>);
						this.<>1__state = -1;
					}
					int result = awaiter.GetResult();
					repairCardLayoutVisibility.OfficeVisibility = (OfflineData.Instance.Employee.Can(72, 0) && result > 1);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06004748 RID: 18248 RVA: 0x00115F38 File Offset: 0x00114138
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04002DB6 RID: 11702
			public int <>1__state;

			// Token: 0x04002DB7 RID: 11703
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04002DB8 RID: 11704
			public RepairCardLayoutVisibility <>4__this;

			// Token: 0x04002DB9 RID: 11705
			private TaskAwaiter<int> <>u__1;
		}
	}
}
