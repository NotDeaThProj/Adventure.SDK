using System;
using System.Runtime.InteropServices;
using Reloaded.Hooks.X86;
using Reloaded.Hooks.Definitions.X86;

namespace Adventure.SDK.Library.Classes.Native
{
    public struct PVM
    {
        // Variables/Constants
        public static LoadPVM LoadPVMFile = Wrapper.Create<LoadPVM>(0x421180);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void LoadPVM(string fileName, IntPtr textureListAddress);
    }
}
