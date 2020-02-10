using System;
using System.Runtime.InteropServices;
using Reloaded.Hooks.X86;
using Reloaded.Hooks.Definitions.X86;

namespace Adventure.SDK.Library.Classes.Native
{
    public unsafe struct GameObject
    {
        // Variables/Constants
        public static LoadGameObject LoadNativeGameObject = Wrapper.Create<LoadGameObject>(0x40B860);
        public static DeleteGameObject DeleteNativeGameObject = Wrapper.Create<DeleteGameObject>(0x40B570);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate Definitions.Structures.GameObject.GameObject* LoadGameObject(byte flags, int index, IntPtr loadSub);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate void DeleteGameObject(Definitions.Structures.GameObject.GameObject* obj);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate void FunctionPointer(IntPtr functionAddress);
    }
}
