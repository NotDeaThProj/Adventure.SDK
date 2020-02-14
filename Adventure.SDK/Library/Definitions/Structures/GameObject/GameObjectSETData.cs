using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Structures.SETData;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct GameObjectSETDataUnion
    {
        [FieldOffset(0)]
        public GameObjectSETData* SETData;
        [FieldOffset(0)]
        public GameObjectMissionSETData* MissionSETData;
    }

    public unsafe struct GameObjectSETData
    {
        public byte LoadCount, field_1;
        public short Flags;
        public GameObject* ObjectInstance;
        public SETEntry* SETEntry;
        public float Distance;
    }

    public unsafe struct GameObjectMissionSETData
    {
        public GameObjectSETData SETData;
        public void* PRMEntry;
    }
}
