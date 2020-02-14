using System;
using Adventure.SDK.Library.Definitions.Enums.Objects;
using Reloaded.Memory.Interop;
using static Adventure.SDK.Library.Classes.Native.GameObject;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class GameObject : IDisposable
    {
        // Variables/Constants
        private readonly Pinnable<Definitions.Structures.GameObject.GameObject> _gameObject =
            new Pinnable<Definitions.Structures.GameObject.GameObject>(new Definitions.Structures.GameObject.GameObject());

        // Properties
        public ObjectInitilizationFlag InitializationFlag { get; set; }
        public int ObjectIndex { get; set; }
        public IntPtr Loader { get; set; }

        public Definitions.Structures.GameObject.GameObject* Handle { get; set; }

        public Definitions.Structures.GameObject.GameObject* Next { get => Handle->Next; set => Handle->Next = value; }
        public Definitions.Structures.GameObject.GameObject* Previous { get => Handle->Previous; set => Handle->Previous = value; }
        public Definitions.Structures.GameObject.GameObject* Parent { get => Handle->Parent; set => Handle->Parent = value; }
        public Definitions.Structures.GameObject.GameObject* Child { get => Handle->Child; set => Handle->Child = value; }
        public IntPtr ExecutorFunction { get => Handle->executor; set => Handle->executor = value; }
        public IntPtr DisplayerFunction { get => Handle->displayer; set => Handle->displayer = value; }
        public IntPtr DestructorFunction { get => Handle->destructor; set => Handle->destructor = value; }
        public SETData SETObjectData { get; set; }
        public MissionSETData MissionSETObjectData { get; set; }
        public Info Info { get; set; }
        public ActorData ActorData { get; set; }
        public UnknownA UnknownA { get; set; }
        public UnknownB UnknownB { get; set; }

        // Constructors
        public GameObject() => Handle = LoadNativeGameObject(0, 0, IntPtr.Zero);

        public GameObject(ObjectInitilizationFlag initializationFlag, int index, IntPtr loadSub)
        {
            InitializationFlag = initializationFlag;
            ObjectIndex = index;
            Loader = loadSub;

            Handle = LoadNativeGameObject(InitializationFlag, ObjectIndex, Loader);
        }

        public GameObject(ObjectInitilizationFlag initilizationFlag, int index, IntPtr loader, bool asd)
        {
            Handle = _gameObject.Pointer;

            if (initilizationFlag.HasFlag(ObjectInitilizationFlag.Info))
            {
                Info = new Info();
                Handle->Info = Info.Handle;
            }
            if (initilizationFlag.HasFlag(ObjectInitilizationFlag.ActorData))
            {
                ActorData = new ActorData();
                Handle->ActorData = ActorData.Handle;
            }
            if (initilizationFlag.HasFlag(ObjectInitilizationFlag.Unknown1))
            {
                UnknownA = new UnknownA();
                Handle->UnknownA_ptr = UnknownA.Handle;
            }
            if (initilizationFlag.HasFlag(ObjectInitilizationFlag.Unknown2))
            {
                UnknownB = new UnknownB();
                Handle->UnknownB_ptr = UnknownB.Handle;
            }
            if (initilizationFlag.HasFlag(ObjectInitilizationFlag.SETData))
            {
                SETObjectData = new SETData();
                Handle->SETData.SETData = SETObjectData.Handle;
            }
            if (initilizationFlag.HasFlag(ObjectInitilizationFlag.MissionSETData))
            {
                MissionSETObjectData = new MissionSETData();
                Handle->SETData.MissionSETData = MissionSETObjectData.Handle;
            }

            if (loader != IntPtr.Zero)
                Handle->executor = loader;
        }

        public GameObject(IntPtr handle) => Handle = (Definitions.Structures.GameObject.GameObject*)handle;

        public void Dispose() => DeleteNativeGameObject(Handle);

        // Methods
        public virtual void Executor() => Handle->Executor((IntPtr)Handle);

        public virtual void Displayer() => Handle->Displayer((IntPtr)Handle);

        public virtual void Destructor() => Handle->Destructor((IntPtr)Handle);
    }
}