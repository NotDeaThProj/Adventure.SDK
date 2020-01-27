using Adventure.SDK.Numerics;
using System.Numerics;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    public unsafe struct ActorData
    {
        public CharacterData* CharacterData;
        public Vector3 VelocityDirection, SomeCollisionVector;
        public Rotation3 Forward;
        public int field_28, field_2C, field_30;
        public float field_34, field_38, SomeMultiplier;
    }
}
