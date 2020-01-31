using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

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

    public unsafe struct SETEntry
    {
        public short ObjectType;
        public fixed ushort Rotation[3];
        public Vector3 Position, Properties;
    }
}
