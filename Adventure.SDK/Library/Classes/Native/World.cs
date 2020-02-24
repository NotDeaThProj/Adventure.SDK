using Adventure.SDK.Library.Definitions.Enums;
using Reloaded.Hooks.Definitions.X86;
using Reloaded.Hooks.X86;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Adventure.SDK.Library.Classes.Native
{
    public struct World
    {
        // Variables/Constants
        public static SetTimeOfDay SetAdventureFieldTime = Wrapper.Create<SetTimeOfDay>(0x412C00);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public delegate void SetTimeOfDay(TimeOfDay timeOfDay);
    }
}
