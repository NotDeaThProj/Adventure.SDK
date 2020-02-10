using System;
using System.Runtime.InteropServices;
using static Adventure.SDK.Library.Classes.Native.GameObject;

namespace Adventure.SDK.Library.Definitions.Structures.Object
{
    public struct ItemBoxItem
    {
        public int Texture;
        public IntPtr function;

        public FunctionPointer Function =>
            Marshal.GetDelegateForFunctionPointer<FunctionPointer>(function);
    }
}
