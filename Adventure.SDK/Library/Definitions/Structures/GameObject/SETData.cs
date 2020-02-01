using System.Numerics;
using System.Runtime.InteropServices;
using Adventure.SDK.Numerics;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct SETDataUnion
    {
        [FieldOffset(0)]
        public SETObjectData* SETData;
        [FieldOffset(0)]
        public void* MissionSETData;
    }
    public unsafe struct SETObjectData
    {
        public byte LoadCount, field_1;
        public short Flags;
        public GameObject* ObjectInstance;
        public SETEntry* SETEntry;
        public float Distance;
    }

    public struct SETEntry
    {
        public short ObjectType;
        public SETRotation3 Rotation;
        public Vector3 Position, Properties;
    }
}
