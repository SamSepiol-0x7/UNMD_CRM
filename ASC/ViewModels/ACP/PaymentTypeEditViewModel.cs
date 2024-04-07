using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ASC.Common.Interfaces;
using ASC.Interfaces;
using ASC.Objects;
using ASC.Options;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core.Serialization;
using Poly;

namespace ASC.ViewModels.ACP
{
	// Token: 0x0200056B RID: 1387
	public class PaymentTypeEditViewModel : PopupViewModel, IPopupViewModel
	{
		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x000AD70C File Offset: 0x000AB90C
		// (set) Token: 0x06003358 RID: 13144 RVA: 0x000AD720 File Offset: 0x000AB920
		public ICustomerSearchViewModel CustomerSearchViewModel
		{
			[CompilerGenerated]
			get
			{
				return this.<CustomerSearchViewModel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<CustomerSearchViewModel>k__BackingField, value))
				{
					return;
				}
				this.<CustomerSearchViewModel>k__BackingField = value;
				this.RaisePropertyChanged("CustomerSearchViewModel");
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003359 RID: 13145 RVA: 0x000AD750 File Offset: 0x000AB950
		public payment_types Item
		{
			[CompilerGenerated]
			get
			{
				return this.<Item>k__BackingField;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x000AD764 File Offset: 0x000AB964
		// (set) Token: 0x0600335B RID: 13147 RVA: 0x000AD778 File Offset: 0x000AB978
		public List<int> SelectedUserIds
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedUserIds>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedUserIds>k__BackingField, value))
				{
					return;
				}
				this.<SelectedUserIds>k__BackingField = value;
				this.RaisePropertyChanged("SelectedUserIds");
			}
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000AD7A8 File Offset: 0x000AB9A8
		public PaymentTypeEditViewModel()
		{
			this.CustomerSearchViewModel = Bootstrapper.Container.Resolve<ICustomerSearchViewModel>();
			this._toasterService = Bootstrapper.Container.Resolve<IToasterService>();
			this._orderOptions = new OrderOptions();
			this.SelectedUserIds = new List<int>();
			this.Item = new payment_types
			{
				type = 1,
				periodic = false
			};
			base.SetTitle(Lang.t("NewPaymentType"));
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000AD81C File Offset: 0x000ABA1C
		public PaymentTypeEditViewModel(payment_types paymentType) : this()
		{
			paymentType.CopyProperties(this.Item);
			this._originalItem = paymentType;
			if (this.Item.payment_type_users != null)
			{
				List<int> selectedUserIds = (from p in this.Item.payment_type_users
				select p.user_id).ToList<int>();
				this.SetSelectedUserIds(selectedUserIds);
			}
			if (this.Item.ClientId != null)
			{
				this.CustomerSearchViewModel.SetSelected(this.Item.ClientId.Value);
			}
			base.SetTitle(Lang.t("PaymentTypes") + ": " + this._originalItem.Name);
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000AD8E4 File Offset: 0x000ABAE4
		public void SetSelectedUserIds(List<int> value)
		{
			this.SelectedUserIds.Clear();
			this.SelectedUserIds.AddRange(value);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000AD908 File Offset: 0x000ABB08
		[AsyncCommand]
		public Task Save()
		{
			PaymentTypeEditViewModel.<Save>d__18 <Save>d__;
			<Save>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Save>d__.<>4__this = this;
			<Save>d__.<>1__state = -1;
			<Save>d__.<>t__builder.Start<PaymentTypeEditViewModel.<Save>d__18>(ref <Save>d__);
			return <Save>d__.<>t__builder.Task;
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000AD94C File Offset: 0x000ABB4C
		private void SetCustomerId()
		{
			ICustomer selected = this.CustomerSearchViewModel.GetSelected();
			this.Item.ClientId = ((selected != null) ? new int?(selected.Id) : null);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000AD98C File Offset: 0x000ABB8C
		public bool CanSave()
		{
			return this.Item != null && this.Item.id > 0;
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000AD9B4 File Offset: 0x000ABBB4
		[AsyncCommand]
		public Task Create()
		{
			PaymentTypeEditViewModel.<Create>d__21 <Create>d__;
			<Create>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<PaymentTypeEditViewModel.<Create>d__21>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000AD9F8 File Offset: 0x000ABBF8
		public bool CanCreate()
		{
			return this.Item != null && this.Item.id == 0;
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnLoaded()
		{
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00023150 File Offset: 0x00021350
		[Command]
		public void OnUnloaded()
		{
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000ADA20 File Offset: 0x000ABC20
		private void RefreshParent()
		{
			FinancesViewModel parentViewModel = this._parentViewModel;
			if (parentViewModel == null)
			{
				return;
			}
			parentViewModel.RefreshPaymentTypes();
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x000ADA40 File Offset: 0x000ABC40
		protected override void OnParentViewModelChanged(object obj)
		{
			base.OnParentViewModelChanged(obj);
			this._parentViewModel = (obj as FinancesViewModel);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x0003927C File Offset: 0x0003747C
		[Command]
		public void AllowProperty(AllowPropertyEventArgs e)
		{
			if (e.Property.Name == "TotalSummary")
			{
				e.Allow = false;
			}
		}

		// Token: 0x04001D98 RID: 7576
		private OrderOptions _orderOptions;

		// Token: 0x04001D99 RID: 7577
		[CompilerGenerated]
		private ICustomerSearchViewModel <CustomerSearchViewModel>k__BackingField;

		// Token: 0x04001D9A RID: 7578
		private readonly IToasterService _toasterService;

		// Token: 0x04001D9B RID: 7579
		[CompilerGenerated]
		private readonly payment_types <Item>k__BackingField;

		// Token: 0x04001D9C RID: 7580
		private payment_types _originalItem;

		// Token: 0x04001D9D RID: 7581
		private FinancesViewModel _parentViewModel;

		// Token: 0x04001D9E RID: 7582
		[CompilerGenerated]
		private List<int> <SelectedUserIds>k__BackingField;

		// Token: 0x0200056C RID: 1388
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003369 RID: 13161 RVA: 0x000ADA60 File Offset: 0x000ABC60
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600336A RID: 13162 RVA: 0x000046B4 File Offset: 0x000028B4
			public <>c()
			{
			}

			// Token: 0x0600336B RID: 13163 RVA: 0x000ADA78 File Offset: 0x000ABC78
			internal int <.ctor>b__16_0(payment_type_users p)
			{
				return p.user_id;
			}

			// Token: 0x04001D9F RID: 7583
			public static readonly PaymentTypeEditViewModel.<>c <>9 = new PaymentTypeEditViewModel.<>c();

			// Token: 0x04001DA0 RID: 7584
			public static Func<payment_type_users, int> <>9__16_0;
		}

		// Token: 0x0200056D RID: 1389
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Save>d__18 : IAsyncStateMachine
		{
			// Token: 0x0600336C RID: 13164 RVA: 0x000ADA8C File Offset: 0x000ABC8C
			void IAsyncStateMachine.MoveNext()
			{
				PaymentTypeEditViewModel paymentTypeEditViewModel = this.<>4__this;
				try
				{
					paymentTypeEditViewModel.SetCustomerId();
					bool flag = paymentTypeEditViewModel._orderOptions.SaveExistPaymentType(paymentTypeEditViewModel.Item, paymentTypeEditViewModel.SelectedUserIds);
					paymentTypeEditViewModel.ShowActionResponse(flag, "");
					if (flag)
					{
						OfflineData.Instance.ReloadPaymentSystems();
						paymentTypeEditViewModel.ShowActionResponse(true, "");
						paymentTypeEditViewModel.RefreshParent();
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

			// Token: 0x0600336D RID: 13165 RVA: 0x000ADB28 File Offset: 0x000ABD28
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DA1 RID: 7585
			public int <>1__state;

			// Token: 0x04001DA2 RID: 7586
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001DA3 RID: 7587
			public PaymentTypeEditViewModel <>4__this;
		}

		// Token: 0x0200056E RID: 1390
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <Create>d__21 : IAsyncStateMachine
		{
			// Token: 0x0600336E RID: 13166 RVA: 0x000ADB44 File Offset: 0x000ABD44
			void IAsyncStateMachine.MoveNext()
			{
				PaymentTypeEditViewModel paymentTypeEditViewModel = this.<>4__this;
				try
				{
					if (string.IsNullOrEmpty(paymentTypeEditViewModel.Item.Name))
					{
						paymentTypeEditViewModel._toasterService.Info(Lang.t("InputPaymentType"));
					}
					else
					{
						paymentTypeEditViewModel.SetCustomerId();
						paymentTypeEditViewModel.Item.id = paymentTypeEditViewModel._orderOptions.AddNewPaymentType(paymentTypeEditViewModel.Item, paymentTypeEditViewModel.SelectedUserIds);
						if (paymentTypeEditViewModel.Item.id > 0)
						{
							OfflineData.Instance.ReloadPaymentSystems();
							paymentTypeEditViewModel._toasterService.Success(Lang.t("Saved"));
							paymentTypeEditViewModel.RefreshParent();
						}
						else
						{
							paymentTypeEditViewModel._toasterService.Error("");
						}
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

			// Token: 0x0600336F RID: 13167 RVA: 0x000ADC30 File Offset: 0x000ABE30
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DA4 RID: 7588
			public int <>1__state;

			// Token: 0x04001DA5 RID: 7589
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001DA6 RID: 7590
			public PaymentTypeEditViewModel <>4__this;
		}
	}
}
