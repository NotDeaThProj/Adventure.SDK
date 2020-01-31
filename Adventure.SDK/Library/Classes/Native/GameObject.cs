using System;
using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Enums;
using Reloaded.Hooks.Definitions.X86;
using Reloaded.Hooks.X86;

namespace Adventure.SDK.Library.Classes.Native
{
    public unsafe struct GameObject
    {
        // Variables/Constants
        public static LoadGameObject LoadNativeGameObject = Wrapper.Create<LoadGameObject>(0x40B860);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate Definitions.Structures.GameObject.GameObject* LoadGameObject(byte flags, int index, IntPtr loadSub);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate void FunctionPointer(Definitions.Structures.GameObject.GameObject* functionAddress);
    }
}
