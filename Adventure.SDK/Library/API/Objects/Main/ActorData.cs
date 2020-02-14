using System;
using System.Numerics;
using Adventure.SDK.Numerics;
using Adventure.SDK.Library.Definitions.Enums;
using Adventure.SDK.Library.Definitions.Structures.GameObject;
using Reloaded.Memory.Interop;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class ActorData
    {
        private Pinnable<GameObjectActorData> _actorData =
            new Pinnable<GameObjectActorData>(new GameObjectActorData());

        public GameObjectActorData* Handle { get; set; }

        public CharacterData* CharacterData { get => Handle->CharacterData; set => Handle->CharacterData = value; }

        public Vector3 VelocityDirection { get => Handle->VelocityDirection; set => Handle->VelocityDirection = value; }
        public Vector3 SomeCollisionVector { get => Handle->SomeCollisionVector; set => Handle->SomeCollisionVector = value; }
        public Rotation3 Forward { get => Handle->Forward; set => Handle->Forward = value; }
        public int field_28 { get => Handle->field_28; set => Handle->field_28 = value; }
        public int field_2C { get => Handle->field_2C; set => Handle->field_2C = value; }
        public int field_30 { get => Handle->field_30; set => Handle->field_30 = value; }
        public float field_34 { get => Handle->field_34; set => Handle->field_34 = value; }
        public float field_38 { get => Handle->field_38; set => Handle->field_38 = value; }
        public float SomeMultiplier { get => Handle->SomeMultiplier; set => Handle->SomeMultiplier = value; }

        public ActorData()
        {
            Handle = _actorData.Pointer;
        }
    }
}
