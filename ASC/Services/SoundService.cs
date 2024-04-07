using System;
using System.IO;
using System.Media;
using ASC.Interfaces;
using ASC.Models;

namespace ASC.Services
{
	// Token: 0x0200069D RID: 1693
	public class SoundService : ISoundService
	{
		// Token: 0x060038E8 RID: 14568 RVA: 0x000D0C50 File Offset: 0x000CEE50
		public void Play(SoundService.Sound sound)
		{
			new SoundPlayer(Path.Combine(MediaModel.GetSoundDir(), this.GetSoundFileName(sound))).Play();
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x000D0C78 File Offset: 0x000CEE78
		private string GetSoundFileName(SoundService.Sound sound)
		{
			if (sound == SoundService.Sound.Start)
			{
				return "add.wav";
			}
			throw new ArgumentException();
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x000046B4 File Offset: 0x000028B4
		public SoundService()
		{
		}

		// Token: 0x0200069E RID: 1694
		public enum Sound
		{
			// Token: 0x040022E2 RID: 8930
			Start = 1
		}
	}
}
