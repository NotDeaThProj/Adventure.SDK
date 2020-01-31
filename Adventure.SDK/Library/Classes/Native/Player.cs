using Reloaded.Hooks.Definitions.X86;
using Reloaded.Hooks.X86;
using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Enums;

namespace Adventure.SDK.Library.Classes.Native
{
    public struct Player
    {
        // Variables/Constants
        public static ForcePlayerAction ChangePlayerAction = Wrapper.Create<ForcePlayerAction>(0x441260);
        public static LoadSpecialAnimations LoadSpecialPlayerAnimations = Wrapper.Create<LoadSpecialAnimations>(0x422680);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void ForcePlayerAction(Players playerID, PlayerAction actionID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void LoadSpecialAnimations(Character characterID);
    }
}
