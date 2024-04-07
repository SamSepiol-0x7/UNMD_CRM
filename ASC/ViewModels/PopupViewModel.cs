using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ASC.Services.Abstract;
using Autofac;
using DevExpress.Mvvm.DataAnnotations;

namespace ASC.ViewModels
{
	// Token: 0x0200040D RID: 1037
	public class PopupViewModel : BaseViewModel
	{
		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x00083908 File Offset: 0x00081B08
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x0008391C File Offset: 0x00081B1C
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (!string.Equals(this.<Title>k__BackingField, value, StringComparison.Ordinal))
				{
					goto IL_33;
				}
				IL_0F:
				int num = -1768161438;
				IL_14:
				switch ((num ^ -2110529921) % 4)
				{
				case 0:
					IL_33:
					this.<Title>k__BackingField = value;
					num = -2111074892;
					goto IL_14;
				case 1:
					return;
				case 2:
					goto IL_0F;
				}
				this.RaisePropertyChanged("Title");
			}
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00083978 File Offset: 0x00081B78
		public PopupViewModel()
		{
			this._windowedDocumentService = Bootstrapper.Container.Resolve<IWindowedDocumentService>();
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0008399C File Offset: 0x00081B9C
		[Command]
		public void OnKeyUp(KeyEventArgs e)
		{
			if (e.Key == Key.Escape)
			{
				this._windowedDocumentService.CloseActiveDocument();
			}
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000839C0 File Offset: 0x00081BC0
		public void SetTitle(string title)
		{
			this.Title = title;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000839D4 File Offset: 0x00081BD4
		public void ClosePopup()
		{
			this._windowedDocumentService.CloseActiveDocument();
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00078C54 File Offset: 0x00076E54
		[Command]
		public virtual void Close()
		{
			this.ClosePopup();
		}

		// Token: 0x0400172F RID: 5935
		private readonly IWindowedDocumentService _windowedDocumentService;

		// Token: 0x04001730 RID: 5936
		[CompilerGenerated]
		private string <Title>k__BackingField;
	}
}
