using Adventure.SDK.Library.Definitions.Structures.GameObject;
using Adventure.SDK.Library.Definitions.Structures.SETData;
using Reloaded.Memory.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class SETData
    {
        private readonly Pinnable<GameObjectSETData> _setData =
            new Pinnable<GameObjectSETData>(new GameObjectSETData());

        public GameObjectSETData* Handle { get; set; }

        public byte LoadCount { get => Handle->LoadCount; set => Handle->LoadCount = value; }
        public byte field_1 { get => Handle->field_1; set => Handle->field_1 = value; }
        public short Flags { get => Handle->Flags; set => Handle->Flags = value; }
        public Definitions.Structures.GameObject.GameObject* ObjectInstance { get => Handle->ObjectInstance; set => Handle->ObjectInstance = value; }
        public SETEntry* SETEntry { get => Handle->SETEntry; set => Handle->SETEntry = value; }
        public float Distance { get => Handle->Distance; set => Handle->Distance = value; }

        public SETData()
        {
            Handle = _setData.Pointer;
        }
    }
    public unsafe class MissionSETData
    {
        private readonly Pinnable<GameObjectMissionSETData> _missionSETData =
            new Pinnable<GameObjectMissionSETData>(new GameObjectMissionSETData());

        public GameObjectMissionSETData* Handle { get; set; }

        public GameObjectSETData SETData { get => Handle->SETData; set => Handle->SETData = value; }

        public void* PRMEntry { get => Handle->PRMEntry; set => Handle->PRMEntry = value; }

        public MissionSETData()
        {
            Handle = _missionSETData.Pointer;
        }
    }
}
