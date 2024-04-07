using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ASC.Kassa;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using ASC.ViewModel;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x02000478 RID: 1144
	public class MoneyMoveViewModel : BaseViewModel
	{
		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x000907A4 File Offset: 0x0008E9A4
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x000907B8 File Offset: 0x0008E9B8
		public MoneyMove Move
		{
			[CompilerGenerated]
			get
			{
				return this.<Move>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Move>k__BackingField, value))
				{
					return;
				}
				this.<Move>k__BackingField = value;
				this.RaisePropertyChanged("Move");
			}
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000907E8 File Offset: 0x0008E9E8
		public MoneyMoveViewModel(INavigationService navigationService, IWindowedDocumentService windowedDocumentService, IToasterService toasterService)
		{
			this._navigationService = navigationService;
			this._windowedDocumentService = windowedDocumentService;
			this._toasterService = toasterService;
			this.Move = new MoneyMove();
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0009081C File Offset: 0x0008EA1C
		[Command]
		public void MoneyMove()
		{
			if (base.CheckFields(this.Move))
			{
				Result result;
				for (;;)
				{
					IL_80:
					result = this.Move.Move();
					if (result.IsSucces)
					{
						IL_76:
						while (this.parentViewModel != null)
						{
							for (;;)
							{
								IIdCallback idCallback = this.parentViewModel;
								if (idCallback != null)
								{
									idCallback.SetId(result.Ids.FirstOrDefault<int>());
									uint num;
									switch ((num = (num * 937803904U ^ 1497962628U ^ 945270371U)) % 10U)
									{
									case 0U:
										continue;
									case 1U:
										goto IL_98;
									case 2U:
										goto IL_80;
									case 3U:
										goto IL_ED;
									case 4U:
										goto IL_CC;
									case 5U:
										goto IL_BB;
									case 6U:
									case 8U:
										return;
									case 7U:
										goto IL_76;
									}
									goto Block_3;
								}
								goto IL_97;
							}
						}
						goto IL_BB;
					}
					goto IL_ED;
				}
				Block_3:
				return;
				IL_97:
				IL_98:
				KassaViewModel kassaViewModel = Bootstrapper.Container.Resolve<KassaViewModel>();
				kassaViewModel.SetSelectedOffice(0);
				this._navigationService.Navigate("KassaView", kassaViewModel);
				IL_BB:
				KassaViewModel kassaViewModel2 = this.kassaParentViewModel;
				if (kassaViewModel2 != null)
				{
					kassaViewModel2.Refresh();
				}
				IL_CC:
				this._windowedDocumentService.CloseActiveDocument();
				this._toasterService.Success(Lang.t("Complete"));
				return;
				IL_ED:
				this._toasterService.Error(result.Message);
				return;
			}
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00090928 File Offset: 0x0008EB28
		[Command]
		public void Cancel()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00090940 File Offset: 0x0008EB40
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			IIdCallback idCallback = obj as IIdCallback;
			if (idCallback != null)
			{
				this.parentViewModel = idCallback;
			}
			KassaViewModel kassaViewModel = obj as KassaViewModel;
			if (kassaViewModel != null)
			{
				this.kassaParentViewModel = kassaViewModel;
			}
		}

		// Token: 0x04001913 RID: 6419
		private readonly INavigationService _navigationService;

		// Token: 0x04001914 RID: 6420
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001915 RID: 6421
		private readonly IToasterService _toasterService;

		// Token: 0x04001916 RID: 6422
		[CompilerGenerated]
		private MoneyMove <Move>k__BackingField;

		// Token: 0x04001917 RID: 6423
		private IIdCallback parentViewModel;

		// Token: 0x04001918 RID: 6424
		private KassaViewModel kassaParentViewModel;
	}
}
