using System;
using Reloaded.Memory.Interop;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class UnknownB
    {
        private Pinnable<IntPtr> _unknownB = new Pinnable<IntPtr>(new IntPtr());

        public void* Handle { get; set; }

        public UnknownB()
        {
            Handle = _unknownB.Pointer;
        }
    }
}
