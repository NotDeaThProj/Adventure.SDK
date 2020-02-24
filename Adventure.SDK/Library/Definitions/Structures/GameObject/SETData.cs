using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Structures.SETData;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct SETDataUnion
    {
        [FieldOffset(0)]
        public SETData* SETData;
        [FieldOffset(0)]
        public MissionSETData* MissionSETData;
    }

    public unsafe struct SETData
    {
        public byte LoadCount, field_1;
        public short Flags;
        public GameObject* ObjectInstance;
        public SETEntry* SETEntry;
        public float Distance;
    }

    public unsafe struct MissionSETData
    {
        public SETData SETData;
        public void* PRMEntry;
    }
}
