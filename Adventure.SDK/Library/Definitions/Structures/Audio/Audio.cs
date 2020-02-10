using System;
using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Enums;
using Reloaded.Hooks.X86;
using Reloaded.Hooks.Definitions.X86;

namespace Adventure.SDK.Library.Definitions.Structures.Audio
{
    public struct Audio
    {
        // Variables/Constants
        public static PlayMusic PlaySong = Wrapper.Create<PlayMusic>(0x425690);
        public static PlayVoice PlayVoiceClip = Wrapper.Create<PlayVoice>(0x425710);
        public static PlaySound PlaySoundEffect = Wrapper.Create<PlaySound>(0x423D70);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate int PlayMusic(Music songID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void PlayVoice(int voiceID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate int PlaySound(int soundID, IntPtr a2, int a3, IntPtr a4);
    }
}
