using System;
using System.Numerics;
using Adventure.SDK.Numerics;
using Adventure.SDK.Library.Definitions.Enums;
using Adventure.SDK.Library.Definitions.Structures.GameObject;
using Reloaded.Memory.Interop;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class Info
    {
        private readonly Pinnable<GameObjectInfo> _info =
            new Pinnable<GameObjectInfo>(new GameObjectInfo());

        public GameObjectInfo* Handle { get; set; }

        public byte Action { get => Handle->Action; set => Handle->Action = value; }
        
        public PlayerAction NextAction { get => Handle->NextAction; set => Handle->NextAction = value; }

        public byte Unknown { get => Handle->Unknown; set => Handle->Unknown = value; }

        public byte Index { get => Handle->Index; set => Handle->Index = value; }

        public Status Status { get => Handle->Status; set => Handle->Status = value; }

        public short InvulnerableTime { get => Handle->InvulnerableTime; set => Handle->InvulnerableTime = value; }

        public byte CharacterIndex { get => Handle->CharacterIndex; set => Handle->CharacterIndex = value; }

        public Character CharacterID { get => Handle->CharacterID; set => Handle->CharacterID = value; }

        public IntPtr Object { get => Handle->Object; set => Handle->Object = value; }

        public IntPtr LoopData { get => (IntPtr)Handle->LoopData; set => Handle->LoopData = (void*)value; }

        public Rotation3 Rotation { get => Handle->Rotation; set => Handle->Rotation = value; }

        public Vector3 Position { get => Handle->Position; set => Handle->Position = value; }

        public Vector3 Properties { get => Handle->Properties; set => Handle->Properties = value; }

        public IntPtr CollisionInfo { get => (IntPtr)Handle->CollisionInfo; set => Handle->CollisionInfo = (void*)value; }

        public IntPtr field_3C { get => (IntPtr)Handle->field_3C; set => Handle->field_3C = (void*)value; }

        public Info()
        {
            Handle = _info.Pointer;   
        }
    }
}
