using System;
using Adventure.SDK.Library.Definitions.Enums;
using Reloaded.Hooks.X86;
using static Adventure.SDK.Library.Classes.Native.GameObject;
using static Adventure.SDK.Library.Classes.Native.Player;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class GameObject
    {
        // Variables/Constants
        private ReverseWrapper<FunctionPointer> _mainFunction;
        private ReverseWrapper<FunctionPointer> _displayFunction;
        private ReverseWrapper<FunctionPointer> _deleteFunction;

        // Properties
        public Definitions.Structures.GameObject.GameObject* Handle { get; set; }
        public Definitions.Structures.GameObject.Info* Info => Handle->Info;
        public Definitions.Structures.GameObject.ActorData* ActorData => Handle->ActorData;
        public Definitions.Structures.GameObject.CharacterData* CharacterData => Handle->ActorData->CharacterData;
        public PlayerAction NextAction
        {
            get => Info->NextAction;
            set => ChangePlayerAction(0, value);
        }
        public Character CharacterID
        {
            get => Info->CharacterID;
            set => Info->CharacterID = value;
        }

        // Constructors
        /// <summary>
        /// Gets the player object
        /// </summary>
        /// <param name="playerID"></param>
        public GameObject(byte playerID)
        {
            Handle = GetCharacterGameObject(playerID);
        }

        public GameObject(byte flags, int index)
        {
            _mainFunction = new ReverseWrapper<FunctionPointer>((obj) => Main());
            _displayFunction = new ReverseWrapper<FunctionPointer>((obj) => Display());
            _deleteFunction = new ReverseWrapper<FunctionPointer>((obj) => Delete());
            Handle = LoadNativeGameObject(flags, index, _mainFunction.WrapperPointer);
        }

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
