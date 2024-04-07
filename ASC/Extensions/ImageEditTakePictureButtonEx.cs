using System;
using System.Windows;
using System.Windows.Input;
using DevExpress.Data.Camera;
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Internal;

namespace ASC.Extensions
{
	// Token: 0x02000B53 RID: 2899
	public class ImageEditTakePictureButtonEx : ImageEditTakePictureButton
	{
		// Token: 0x0600514B RID: 20811 RVA: 0x0015D260 File Offset: 0x0015B460
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			base.Visibility = ((DeviceHelper.GetDevices().Count > 0) ? Visibility.Visible : Visibility.Collapsed);
			base.Command = this.GetCommandFix();
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x0015D298 File Offset: 0x0015B498
		private ICommand GetCommandFix()
		{
			return new DelegateCommand(new Action(this.ShowTakePictureDialogFix));
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x0015D2B8 File Offset: 0x0015B4B8
		private void ShowTakePictureDialogFix()
		{
			ImageEdit imageEdit = (ImageEdit)this.Owner;
			DXWindow dxwindow = new DXWindow();
			dxwindow.Width = (double)350f;
			dxwindow.Height = (double)350f;
			dxwindow.MinHeight = (double)350f;
			dxwindow.MinWidth = (double)350f;
			dxwindow.ShowIcon = false;
			dxwindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			dxwindow.Title = EditorLocalizer.GetString(EditorStringId.CameraTakePictureCaption);
			TakePictureControl takePictureControl = new TakePictureControl();
			PopupBaseEdit popupOwnerEdit = PopupBaseEdit.GetPopupOwnerEdit(imageEdit);
			takePictureControl.SetEditor(imageEdit, popupOwnerEdit as PopupImageEdit);
			dxwindow.Content = takePictureControl;
			dxwindow.ShowDialog();
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x0015D348 File Offset: 0x0015B548
		public ImageEditTakePictureButtonEx()
		{
		}
	}
}
