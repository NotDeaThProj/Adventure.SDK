using Adventure.SDK.Library.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using static Adventure.SDK.Library.Definitions.Structures.Audio.Audio;

namespace Adventure.SDK.Library.API.Audio
{
	// Classes
	public unsafe class AudioManager
	{
		// Properties
		public Music Song
		{
			get => GetCurrentSong();
			set => PlaySong(value);
		}

		public int Voice
		{
			get => GetCurrentVoice();
			set => PlayVoiceClip(value);
		}

		public int Sound
		{
			set => PlaySoundEffect(value, IntPtr.Zero, 0, IntPtr.Zero);
		}

		// Methods
		private static Music GetCurrentSong()
		{
			Music* currentSong = (Music*)0x912698;
			return *currentSong;
		}

		private static int GetCurrentVoice()
		{
			int* currentVoice = (int*)0x912694;
			return *currentVoice;
		}
	}
}
