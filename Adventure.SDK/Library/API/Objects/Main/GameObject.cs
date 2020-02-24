using Adventure.SDK.Library.Definitions.Enums.Objects;
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
        private Pinnable<MissionSETData> _missionSETData = new Pinnable<MissionSETData>(new MissionSETData());
        private Pinnable<SETData> _setData = new Pinnable<SETData>(new SETData());

        // Properties
        public ObjectInitilizationFlag InitializationFlags { get; set; }
        public int ObjectIndex { get; set; }
        public IntPtr LoadFunction { get; set; }

        public Definitions.Structures.GameObject.GameObject* Handle { get; set; }
        public Info* Info => Handle->Info;
        public SETData* SETData => Handle->SETData.SETData;
        public MissionSETData* MissionSETData => Handle->SETData.MissionSETData;
        public ActorData* ActorData => Handle->ActorData;
        public CharacterData* CharacterData => Handle->ActorData->CharacterData;
        public Vector3 Position { get => Info->Position; set => Info->Position = value; }
        public Rotation3 Rotation { get => Info->Rotation; set => Info->Rotation = value; }

        // Constructors
        public GameObject() => Handle = CreateNativeGameObject(0, 0, IntPtr.Zero);

        public GameObject(ObjectInitilizationFlag flags, int index, IntPtr loadSub)
        {
            InitializationFlags = flags;
            ObjectIndex = index;
            LoadFunction = loadSub;
            Handle = CreateNativeGameObject(InitializationFlags, ObjectIndex, LoadFunction);
        }

        public GameObject(IntPtr handle) => Handle = (Definitions.Structures.GameObject.GameObject*)handle;

        public Definitions.Structures.GameObject.GameObject* CreateNativeGameObject(ObjectInitilizationFlag flags, int index, IntPtr loadSub)
        {
            Definitions.Structures.GameObject.GameObject* instance = LoadNativeGameObject(flags, index, loadSub);
            instance->SETData.MissionSETData = _missionSETData.Pointer;
            instance->SETData.SETData = _setData.Pointer;

            return instance;
        }
        public void Dispose() => DeleteNativeGameObject(Handle);

        // Methods
        public virtual void Executor(IntPtr handle)
        {
            Handle->Executor(handle);
        }

        public virtual void Displayer(IntPtr handle)
        {
            Handle->Displayer(handle);
        }

        public virtual void Destructor(IntPtr handle)
        {
            Handle->Destructor(handle);
        }
    }
}