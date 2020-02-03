using Reloaded.Hooks.Definitions.X86;
using Reloaded.Hooks.X86;
using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Enums;

namespace Adventure.SDK.Library.Classes.Native
{
    public struct Player
    {
        // Variables/Constants
        public static GetCharacterObject GetCharacterGameObject = Wrapper.Create<GetCharacterObject>(0x42FC40);
        public static ForcePlayerAction ChangePlayerAction = Wrapper.Create<ForcePlayerAction>(0x441260);
        public static LoadSpecialAnimations LoadSpecialPlayerAnimations = Wrapper.Create<LoadSpecialAnimations>(0x422680);
        public static IsControllerEnabled IsGameControllerEnabled = Wrapper.Create<IsControllerEnabled>(0x40EFD0);
        public static IncrementRingCounter AddRings = Wrapper.Create<IncrementRingCounter>(0x425BE0);
        public static GetRingCount GetRings = Wrapper.Create<GetRingCount>(0x425CC0);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate Definitions.Structures.GameObject.GameObject* GetCharacterObject(Players playerID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void ForcePlayerAction(Players playerID, PlayerAction actionID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void LoadSpecialAnimations(Character characterID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate bool IsControllerEnabled(Players playerID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void IncrementRingCounter(short amount);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate short GetRingCount();
    }
}
