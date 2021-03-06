﻿using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Enums;
using Reloaded.Hooks.X86;
using Reloaded.Hooks.Definitions.X86;
using static Reloaded.Hooks.Definitions.X86.FunctionAttribute;
using Adventure.SDK.Library.Definitions.Structures.GameObject;

namespace Adventure.SDK.Library.Classes.Native
{
    public unsafe struct Player
    {
        // Variables/Constants
        public static GetCharacterObject GetCharacterGameObject = Wrapper.Create<GetCharacterObject>(0x441AC0);
        public static ForcePlayerAction ChangePlayerAction = Wrapper.Create<ForcePlayerAction>(0x441260);
        public static LoadSpecialAnimations LoadSpecialPlayerAnimations = Wrapper.Create<LoadSpecialAnimations>(0x422680);
        public static IsControllerEnabled IsGameControllerEnabled = Wrapper.Create<IsControllerEnabled>(0x40EFD0);
        public static IncrementRingCounter AddRings = Wrapper.Create<IncrementRingCounter>(0x425BE0);
        public static GetRingCount GetRings = Wrapper.Create<GetRingCount>(0x425CC0);
        public static GetLifeCount GetLives = Wrapper.Create<GetLifeCount>(0x425FE0);
        public static HurtPlayerCharacter HurtPlayer = Wrapper.Create<HurtPlayerCharacter>(0x4506F0);
        public static GiveSpeedUpPowerup GiveSpeedUp = Wrapper.Create<GiveSpeedUpPowerup>(0x441DF0);
        public static HurtTornado HurtTornadoPlayer = Wrapper.Create<HurtTornado>(0x627930);

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

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate short GetLifeCount();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void HurtPlayerCharacter(Players playerID = Players.P1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void GiveSpeedUpPowerup(Players playerID);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(new[] { Register.esi }, Register.eax, StackCleanup.Caller)]
        public delegate int HurtTornado(Info* info);
    }
}
