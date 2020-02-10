using System;
using System.Numerics;
using Reloaded.Hooks.X86;
using static Adventure.SDK.Library.Classes.Native.GameObject;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class GameObject
    {
        // Properties
        public Definitions.Structures.GameObject.GameObject* Handle { get; set; }
        public Definitions.Structures.GameObject.Info* Info => Handle->Info;
        public Definitions.Structures.GameObject.ActorData* ActorData => Handle->ActorData;
        public Definitions.Structures.GameObject.CharacterData* CharacterData => Handle->ActorData->CharacterData;
        public Vector3 Position
        {
            get => Info->Position;
            set => Info->Position = value;
        }

        // Constructors
        public GameObject() { }

        public GameObject(byte flags, int index, IntPtr loadSub)
        {
            Handle = LoadNativeGameObject(flags, index, loadSub);
        }

        // Methods
        public virtual void Main()
        {
            Handle->MainSub(Handle);
        }

        public virtual void Display()
        {
            Handle->DisplaySub(Handle);
        }

        public virtual void Delete()
        {
            Handle->DeleteSub(Handle);
        }
    }
}
