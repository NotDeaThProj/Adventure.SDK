using System;
using System.Runtime.InteropServices;
using static Adventure.SDK.Library.Classes.Native.GameObject;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    public unsafe struct GameObject
    {
        public GameObject* Next, Previous, Parent, Child;
        public IntPtr executor, displayer, destructor;
        public GameObjectSETDataUnion SETData;
        public GameObjectInfo* Info;
        public GameObjectActorData* ActorData;
        public void* UnknownA_ptr, UnknownB_ptr;
        public int field_30;

        public FunctionPointer Executor =>
          Marshal.GetDelegateForFunctionPointer<FunctionPointer>(executor);
        public FunctionPointer Displayer =>
          Marshal.GetDelegateForFunctionPointer<FunctionPointer>(displayer);
        public FunctionPointer Destructor =>
          Marshal.GetDelegateForFunctionPointer<FunctionPointer>(destructor);
    }
}
