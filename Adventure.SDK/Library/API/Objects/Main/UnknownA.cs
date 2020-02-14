using System;
using Reloaded.Memory.Interop;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class UnknownA
    {
        private Pinnable<IntPtr> _unknownA = new Pinnable<IntPtr>(new IntPtr());

        public void* Handle { get; set; }

        public UnknownA()
        {
            Handle = _unknownA.Pointer;
        }
    }
}
