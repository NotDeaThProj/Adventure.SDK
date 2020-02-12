using Adventure.SDK.Library.Definitions.Structures.GameObject;
using Adventure.SDK.Numerics;
using Reloaded.Memory.Interop;
using System;
using System.Numerics;
using static Adventure.SDK.Library.Classes.Native.GameObject;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class GameObject : IDisposable
    {
        private static Pinnable<MissionSETObjectData> _missionSETData = new Pinnable<MissionSETObjectData>(new MissionSETObjectData());
        private static Pinnable<SETObjectData> _setData = new Pinnable<SETObjectData>(new SETObjectData());

        // Properties
        public byte ObjectFlags { get; set; }
        public int ObjectIndex { get; set; }
        public IntPtr LoadFunction { get; set; }

        public Definitions.Structures.GameObject.GameObject *Handle { get; set; }
        public Info Info => *(Handle->Info);
        public SETObjectData SETObjectData => *(Handle->SETData.SETData);
        public MissionSETObjectData MissionSETObjectData => *(Handle->SETData.MissionSETData);
        public ActorData ActorData => *(Handle->ActorData);
        public CharacterData CharacterData => *(Handle->ActorData->CharacterData);
        public Vector3 Position => Info.Position;
        public Rotation3 Rotation => Info.Rotation;

        // Constructors
        public GameObject() => Handle = CreateNativeGameObject(0, 0, IntPtr.Zero);

        public GameObject(byte flags, int index, IntPtr loadSub)
        {
            ObjectFlags = flags;
            ObjectIndex = index;
            LoadFunction = loadSub;
            CreateNativeGameObject(ObjectFlags, ObjectIndex, LoadFunction);
        }

        public GameObject(IntPtr handle) => Handle = (Definitions.Structures.GameObject.GameObject*)handle;

        public Definitions.Structures.GameObject.GameObject* CreateNativeGameObject(byte flags, int index, IntPtr loadSub)
        {
            Definitions.Structures.GameObject.GameObject* instance = LoadNativeGameObject(flags, index, loadSub);
            instance->SETData.MissionSETData = _missionSETData.Pointer;
            instance->SETData.SETData = _setData.Pointer;

            return instance;
        }
        public void Dispose() => DeleteNativeGameObject(Handle);

        // Methods
        public virtual void Main()
        {
            Handle->MainSub((IntPtr)Handle);
        }

        public virtual void Display()
        {
            Handle->DisplaySub((IntPtr)Handle);
        }

        public virtual void Delete()
        {
            Handle->DeleteSub((IntPtr)Handle);
        }
    }
}