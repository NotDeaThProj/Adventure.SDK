using System;
using System.Runtime.InteropServices;
using static Adventure.SDK.Library.Classes.Native.GameObject;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    public unsafe struct GameObject
    {
        public GameObject* Next, Previous, Parent, Child;
        public IntPtr mainSub, displaySub, deleteSub;
        public IntPtr SETData;
        public Info* Info;
        public ActorData* ActorData;
        public void* UnknownA_ptr, UnknownB_ptr;
        public int field_30;

        public FunctionPointer MainSub =>
          Marshal.GetDelegateForFunctionPointer<FunctionPointer>(mainSub);
        public FunctionPointer DisplaySub =>
          Marshal.GetDelegateForFunctionPointer<FunctionPointer>(displaySub);
        public FunctionPointer DeleteSub =>
          Marshal.GetDelegateForFunctionPointer<FunctionPointer>(deleteSub);
    }
}
