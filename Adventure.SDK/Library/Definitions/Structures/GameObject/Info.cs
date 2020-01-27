using System;
using System.Numerics;
using Adventure.SDK.Library.Definitions.Enums;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    public unsafe struct Info
    {
        public byte Action;
        public PlayerAction NextAction;
        public byte Unknown, Index;
        public Status Status;
        public short InvulnerableTime;
        public byte CharacterIndex;
        public Character CharacterID;
        public short field_a;
        public IntPtr Object;
        public void* LoopData;
        public fixed int Rotation[3];
        public Vector3 Position;
        public Vector3 Properties;
        public void* CollisionInfo, field_3C;
    }
}
