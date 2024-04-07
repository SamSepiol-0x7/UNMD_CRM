using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Models;
using ASC.Objects;
using ASC.Objects.Converters;
using ASC.RepairCard.Admin;
using ASC.Services.Abstract;
using ASC.SimpleClasses;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;

namespace ASC.ViewModels
{
	// Token: 0x0200043A RID: 1082
	public class RepairCartridgeFullAdminViewModel : AdminViewModel
	{
		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x0008866C File Offset: 0x0008686C
		// (set) Token: 0x06002AFF RID: 11007 RVA: 0x00088680 File Offset: 0x00086880
		public int CardId
		{
			[CompilerGenerated]
			get
			{
				return this.<CardId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CardId>k__BackingField != value)
				{
					goto IL_2F;
				}
				IL_0B:
				int num = -2057119561;
				IL_10:
				switch ((num ^ -927073062) % 4)
				{
				case 0:
					IL_2F:
					this.<CardId>k__BackingField = value;
					this.RaisePropertyChanged("CardId");
					num = -2132511271;
					goto IL_10;
				case 1:
					return;
				case 2:
					goto IL_0B;
				}
			}
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000886D8 File Offset: 0x000868D8
		public RepairCartridgeFullAdminViewModel()
		{
			this.IoC();
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000886F4 File Offset: 0x000868F4
		public RepairCartridgeFullAdminViewModel(int repairId) : base(repairId)
		{
			this.IoC();
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00088710 File Offset: 0x00086910
		private void IoC()
		{
			this._cartridgeService = Bootstrapper.Container.Resolve<ICartridgeService>();
			this._cartridgeCardService = Bootstrapper.Container.Resolve<ICartridgeCardService>();
			this._reportPrintService = Bootstrapper.Container.Resolve<IReportPrintService>();
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00088750 File Offset: 0x00086950
		public override Task InitCard()
		{
			RepairCartridgeFullAdminViewModel.<InitCard>d__9 <InitCard>d__;
			<InitCard>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InitCard>d__.<>4__this = this;
			<InitCard>d__.<>1__state = -1;
			<InitCard>d__.<>t__builder.Start<RepairCartridgeFullAdminViewModel.<InitCard>d__9>(ref <InitCard>d__);
			return <InitCard>d__.<>t__builder.Task;
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00088794 File Offset: 0x00086994
		[Command]
		public override void OpenRepairCommon()
		{
			this._navigationService.Navigate("RepairCartridgeFullView", new RepairCartridgeFullViewModel(base.RepairId));
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000887BC File Offset: 0x000869BC
		[Command]
		public override void PrintSticker()
		{
			RepairCartridgeFullAdminViewModel.<PrintSticker>d__11 <PrintSticker>d__;
			<PrintSticker>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PrintSticker>d__.<>4__this = this;
			<PrintSticker>d__.<>1__state = -1;
			<PrintSticker>d__.<>t__builder.Start<RepairCartridgeFullAdminViewModel.<PrintSticker>d__11>(ref <PrintSticker>d__);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000887F4 File Offset: 0x000869F4
		[Command]
		public override void ShowPrintDocuments()
		{
			this._windowedDocumentService.ShowNewDocument("RepairDocumentsPrintView", new RepairDocumentsPrintViewModel(base.RepairId, base.Repair.cartridge == null), null, null);
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00088834 File Offset: 0x00086A34
		[AsyncCommand]
		public override Task AdminSaveChanges()
		{
			RepairCartridgeFullAdminViewModel.<AdminSaveChanges>d__13 <AdminSaveChanges>d__;
			<AdminSaveChanges>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AdminSaveChanges>d__.<>4__this = this;
			<AdminSaveChanges>d__.<>1__state = -1;
			<AdminSaveChanges>d__.<>t__builder.Start<RepairCartridgeFullAdminViewModel.<AdminSaveChanges>d__13>(ref <AdminSaveChanges>d__);
			return <AdminSaveChanges>d__.<>t__builder.Task;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00088878 File Offset: 0x00086A78
		public override void LoadModels()
		{
			RepairCartridgeFullAdminViewModel.<LoadModels>d__14 <LoadModels>d__;
			<LoadModels>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadModels>d__.<>4__this = this;
			<LoadModels>d__.<>1__state = -1;
			<LoadModels>d__.<>t__builder.Start<RepairCartridgeFullAdminViewModel.<LoadModels>d__14>(ref <LoadModels>d__);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000888B0 File Offset: 0x00086AB0
		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0()
		{
			return base.InitCard();
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000888C4 File Offset: 0x00086AC4
		[CompilerGenerated]
		private Task<CartridgeReport> <PrintSticker>b__11_0()
		{
			return this._cartridgeService.GetCartgidgeReport(base.RepairId);
		}

		// Token: 0x040017F2 RID: 6130
		private ICartridgeService _cartridgeService;

		// Token: 0x040017F3 RID: 6131
		private ICartridgeCardService _cartridgeCardService;

		// Token: 0x040017F4 RID: 6132
		[CompilerGenerated]
		private int <CardId>k__BackingField;

		// Token: 0x0200043B RID: 1083
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <InitCard>d__9 : IAsyncStateMachine
		{
			// Token: 0x06002B0B RID: 11019 RVA: 0x000888E4 File Offset: 0x00086AE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeFullAdminViewModel repairCartridgeFullAdminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = repairCartridgeFullAdminViewModel.<>n__0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCartridgeFullAdminViewModel.<InitCard>d__9>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter.GetResult();
					if (repairCartridgeFullAdminViewModel.Repair.c_workshop != null)
					{
						repairCartridgeFullAdminViewModel.CardId = repairCartridgeFullAdminViewModel.Repair.c_workshop.card_id;
					}
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

			// Token: 0x06002B0C RID: 11020 RVA: 0x000889BC File Offset: 0x00086BBC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017F5 RID: 6133
			public int <>1__state;

			// Token: 0x040017F6 RID: 6134
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040017F7 RID: 6135
			public RepairCartridgeFullAdminViewModel <>4__this;

			// Token: 0x040017F8 RID: 6136
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200043C RID: 1084
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <PrintSticker>d__11 : IAsyncStateMachine
		{
			// Token: 0x06002B0D RID: 11021 RVA: 0x000889D8 File Offset: 0x00086BD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeFullAdminViewModel repairCartridgeFullAdminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<XtraReport> awaiter;
					TaskAwaiter<CartridgeReport> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__2;
							this.<>u__2 = default(TaskAwaiter<XtraReport>);
							this.<>1__state = -1;
							goto IL_E3;
						}
						repairCartridgeFullAdminViewModel.ShowWait();
						awaiter2 = Task.Run<CartridgeReport>(() => repairCartridgeFullAdminViewModel._cartridgeService.GetCartgidgeReport(base.RepairId)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CartridgeReport>, RepairCartridgeFullAdminViewModel.<PrintSticker>d__11>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<CartridgeReport>);
						this.<>1__state = -1;
					}
					CartridgeReport result = awaiter2.GetResult();
					awaiter = ReportPrintModel.CreateReport("sticker_cartridge", result).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__2 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XtraReport>, RepairCartridgeFullAdminViewModel.<PrintSticker>d__11>(ref awaiter, ref this);
						return;
					}
					IL_E3:
					XtraReport result2 = awaiter.GetResult();
					repairCartridgeFullAdminViewModel.HideWait();
					repairCartridgeFullAdminViewModel._reportPrintService.PrintPreview(result2, PrinterModel.Printer.Stickers);
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

			// Token: 0x06002B0E RID: 11022 RVA: 0x00088B24 File Offset: 0x00086D24
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017F9 RID: 6137
			public int <>1__state;

			// Token: 0x040017FA RID: 6138
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040017FB RID: 6139
			public RepairCartridgeFullAdminViewModel <>4__this;

			// Token: 0x040017FC RID: 6140
			private TaskAwaiter<CartridgeReport> <>u__1;

			// Token: 0x040017FD RID: 6141
			private TaskAwaiter<XtraReport> <>u__2;
		}

		// Token: 0x0200043D RID: 1085
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <AdminSaveChanges>d__13 : IAsyncStateMachine
		{
			// Token: 0x06002B0F RID: 11023 RVA: 0x00088B40 File Offset: 0x00086D40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeFullAdminViewModel repairCartridgeFullAdminViewModel = this.<>4__this;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = repairCartridgeFullAdminViewModel._RepairModel.AdminSaveCard(repairCartridgeFullAdminViewModel.Repair, repairCartridgeFullAdminViewModel.CardId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, RepairCartridgeFullAdminViewModel.<AdminSaveChanges>d__13>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
						}
						awaiter.GetResult();
						repairCartridgeFullAdminViewModel._toasterService.Success(Lang.t("Saved"));
						repairCartridgeFullAdminViewModel.DataRefresh();
					}
					catch (Exception ex)
					{
						repairCartridgeFullAdminViewModel._toasterService.Error(ex.Message);
					}
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

			// Token: 0x06002B10 RID: 11024 RVA: 0x00088C48 File Offset: 0x00086E48
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040017FE RID: 6142
			public int <>1__state;

			// Token: 0x040017FF RID: 6143
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001800 RID: 6144
			public RepairCartridgeFullAdminViewModel <>4__this;

			// Token: 0x04001801 RID: 6145
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200043E RID: 1086
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002B11 RID: 11025 RVA: 0x00088C64 File Offset: 0x00086E64
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002B12 RID: 11026 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x06002B13 RID: 11027 RVA: 0x00088C7C File Offset: 0x00086E7C
			internal IdNameClass <LoadModels>b__14_0(ICartridgeCard c)
			{
				return c.ToIdName();
			}

			// Token: 0x06002B14 RID: 11028 RVA: 0x00088C90 File Offset: 0x00086E90
			internal string <LoadModels>b__14_1(IdNameClass c)
			{
				return c.Name;
			}

			// Token: 0x04001802 RID: 6146
			public static readonly RepairCartridgeFullAdminViewModel.<>c <>9 = new RepairCartridgeFullAdminViewModel.<>c();

			// Token: 0x04001803 RID: 6147
			public static Func<ICartridgeCard, IdNameClass> <>9__14_0;

			// Token: 0x04001804 RID: 6148
			public static Func<IdNameClass, string> <>9__14_1;
		}

		// Token: 0x0200043F RID: 1087
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <LoadModels>d__14 : IAsyncStateMachine
		{
			// Token: 0x06002B15 RID: 11029 RVA: 0x00088CA4 File Offset: 0x00086EA4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				RepairCartridgeFullAdminViewModel repairCartridgeFullAdminViewModel = this.<>4__this;
				try
				{
					TaskAwaiter<IEnumerable<ICartridgeCard>> awaiter;
					if (num != 0)
					{
						awaiter = repairCartridgeFullAdminViewModel._cartridgeCardService.GetCards(repairCartridgeFullAdminViewModel.Repair.maker, false, "").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<ICartridgeCard>>, RepairCartridgeFullAdminViewModel.<LoadModels>d__14>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<ICartridgeCard>>);
						this.<>1__state = -1;
					}
					List<IdNameClass> list = awaiter.GetResult().Select(new Func<ICartridgeCard, IdNameClass>(RepairCartridgeFullAdminViewModel.<>c.<>9.<LoadModels>b__14_0)).OrderBy(new Func<IdNameClass, string>(RepairCartridgeFullAdminViewModel.<>c.<>9.<LoadModels>b__14_1)).ToList<IdNameClass>();
					repairCartridgeFullAdminViewModel.Models = new ObservableCollection<IdNameClass>(list);
					if (repairCartridgeFullAdminViewModel.Repair.c_workshop != null)
					{
						repairCartridgeFullAdminViewModel.CardId = repairCartridgeFullAdminViewModel.Repair.c_workshop.card_id;
					}
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

			// Token: 0x06002B16 RID: 11030 RVA: 0x00088DF0 File Offset: 0x00086FF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001805 RID: 6149
			public int <>1__state;

			// Token: 0x04001806 RID: 6150
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04001807 RID: 6151
			public RepairCartridgeFullAdminViewModel <>4__this;

			// Token: 0x04001808 RID: 6152
			private TaskAwaiter<IEnumerable<ICartridgeCard>> <>u__1;
		}
	}
}
