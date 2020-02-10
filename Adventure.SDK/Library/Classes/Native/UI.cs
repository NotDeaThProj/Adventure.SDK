using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Enums.Objects;
using Reloaded.Hooks.X86;
using Reloaded.Hooks.Definitions.X86;

namespace Adventure.SDK.Library.Classes.Native
{
    public struct UI
    {
        // Variables/Constants
        public static CreateItemDisplay CreateItemDisplayHUD = Wrapper.Create<CreateItemDisplay>(0x4C00B0);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate int CreateItemDisplay(ItemBoxItem item);
    }
}
