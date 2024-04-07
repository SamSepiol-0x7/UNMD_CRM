using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ASC.Models;
using DevExpress.Xpf.Core;
using Microsoft.Win32;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;

namespace ASC.Player
{
	// Token: 0x02000247 RID: 583
	public partial class PlayerView : ThemedWindow, INotifyPropertyChanged
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600203A RID: 8250 RVA: 0x0005CCAC File Offset: 0x0005AEAC
		// (remove) Token: 0x0600203B RID: 8251 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x0005CD24 File Offset: 0x0005AF24
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x0005CD38 File Offset: 0x0005AF38
		public bool isPlaying
		{
			[CompilerGenerated]
			get
			{
				return this.<isPlaying>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<isPlaying>k__BackingField == value)
				{
					return;
				}
				this.<isPlaying>k__BackingField = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.isPlaying);
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0005CD64 File Offset: 0x0005AF64
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x0005CD78 File Offset: 0x0005AF78
		public double Progress
		{
			[CompilerGenerated]
			get
			{
				return this.<Progress>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!(this.<Progress>k__BackingField == value))
				{
					goto IL_32;
				}
				IL_0E:
				int num = -1714617869;
				IL_13:
				switch ((num ^ -2083040134) % 4)
				{
				case 0:
					goto IL_0E;
				case 1:
					return;
				case 2:
					IL_32:
					this.<Progress>k__BackingField = value;
					num = -1810371367;
					goto IL_13;
				}
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Progress);
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x0005CDD4 File Offset: 0x0005AFD4
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x0005CDE8 File Offset: 0x0005AFE8
		public int Volume
		{
			get
			{
				return this._volume;
			}
			set
			{
				if (this._volume == value)
				{
					return;
				}
				this._volume = value;
				this.<>OnPropertyChanged(<>PropertyChangedEventArgs.Volume);
				VlcControl vlcControl = this.vlc;
				if (((vlcControl != null) ? vlcControl.MediaPlayer : null) != null)
				{
					this.vlc.MediaPlayer.Audio.Volume = value;
				}
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0005CE40 File Offset: 0x0005B040
		public PlayerView()
		{
			this.InitializeComponent();
			this.vlc.MediaPlayer.VlcLibDirectoryNeeded += this.OnVlcControlNeedsLibDirectory;
			this.vlc.MediaPlayer.EndInit();
			this.fileName = "record";
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0005CE98 File Offset: 0x0005B098
		public PlayerView(string url) : this()
		{
			this.path = url;
			this.fileName = "record" + Path.GetExtension(url);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
		private void BeforeInit()
		{
			this.vlc.MediaPlayer.VlcMediaplayerOptions = new string[]
			{
				"--avcodec-hw=any",
				"--rtsp-tcp"
			};
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0005CEFC File Offset: 0x0005B0FC
		private void OnVlcControlNeedsLibDirectory(object sender, VlcLibDirectoryNeededEventArgs e)
		{
			e.VlcLibDirectory = new DirectoryInfo(Path.Combine(MediaModel.GetAppDir(), "libvlc\\win-x86\\"));
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0005CF24 File Offset: 0x0005B124
		private void OnPlayButtonClick(object sender, RoutedEventArgs e)
		{
			this.Play();
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0005CF38 File Offset: 0x0005B138
		public void Play()
		{
			this.vlc.MediaPlayer.SetMedia(new Uri(this.path), new string[0]);
			this.vlc.MediaPlayer.Playing += this.MediaPlayerOnPlaying;
			this.vlc.MediaPlayer.TimeChanged += this.MediaPlayerOnTimeChanged;
			this.vlc.MediaPlayer.Play();
			this.isPlaying = true;
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0005CFB8 File Offset: 0x0005B1B8
		private void MediaPlayerOnTimeChanged(object sender, VlcMediaPlayerTimeChangedEventArgs e)
		{
			long newTime = e.NewTime;
			this.Progress = 100.0 / this._totalLenght * (double)newTime;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
		private void MediaPlayerOnPlaying(object sender, VlcMediaPlayerPlayingEventArgs e)
		{
			VlcMedia currentMedia = this.vlc.MediaPlayer.GetCurrentMedia();
			this._totalLenght = currentMedia.Duration.TotalMilliseconds;
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00023150 File Offset: 0x00021350
		private void MediaPlayerOnOpening(object sender, VlcMediaPlayerOpeningEventArgs e)
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0005D01C File Offset: 0x0005B21C
		private void Window_Closing(object sender, CancelEventArgs e)
		{
			this.vlc.MediaPlayer.Stop();
			this.vlc.MediaPlayer.Dispose();
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0005D04C File Offset: 0x0005B24C
		private void OnPauseButtonClick(object sender, RoutedEventArgs e)
		{
			this.Pause();
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0005D060 File Offset: 0x0005B260
		private void Pause()
		{
			this.vlc.MediaPlayer.Pause();
			this.isPlaying = false;
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0005D084 File Offset: 0x0005B284
		private void OnStopButtonClick(object sender, RoutedEventArgs e)
		{
			this.Stop();
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0005D098 File Offset: 0x0005B298
		private void Stop()
		{
			this.vlc.MediaPlayer.Stop();
			this.Progress = 0.0;
			this.isPlaying = false;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0005D0CC File Offset: 0x0005B2CC
		private void OnDownloadButtonClick(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				FileName = this.fileName
			};
			bool? flag = saveFileDialog.ShowDialog();
			if (flag.GetValueOrDefault() & flag != null)
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadProgressChanged += this.wc_DownloadProgressChanged;
					webClient.DownloadFileCompleted += this.ws_DownloadComplete;
					webClient.DownloadFileAsync(new Uri(this.path), saveFileDialog.FileName);
				}
			}
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00023150 File Offset: 0x00021350
		private void ws_DownloadComplete(object sender, AsyncCompletedEventArgs e)
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00023150 File Offset: 0x00021350
		private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0005D164 File Offset: 0x0005B364
		private void PlayerView_OnKeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Space)
			{
				this.Pause();
			}
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0005D284 File Offset: 0x0005B484
		[GeneratedCode("PropertyChanged.Fody", "3.1.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		// Token: 0x0400108E RID: 4238
		private string path;

		// Token: 0x0400108F RID: 4239
		private string fileName;

		// Token: 0x04001092 RID: 4242
		private string[] options;

		// Token: 0x04001093 RID: 4243
		private double _totalLenght;

		// Token: 0x04001094 RID: 4244
		private int _volume = 100;
	}
}
