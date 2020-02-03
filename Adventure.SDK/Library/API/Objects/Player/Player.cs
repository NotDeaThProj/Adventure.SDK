using Adventure.SDK.Library.API.Objects.Main;
using Adventure.SDK.Library.Definitions.Enums;
using static Adventure.SDK.Library.Classes.Native.Player;

namespace Adventure.SDK.Library.API.Objects.Player
{
    public unsafe class Player : GameObject
    {
        // Properties
        public Players PlayerID { get; }
        public PlayerAction NextAction
        {
            get => Info->NextAction;
            set => ChangePlayerAction(Players.P1, value);
        }
        public Character CharacterID
        {
            get => Info->CharacterID;
            set => Info->CharacterID = value;
        }
        public bool IsControllerEnabled => IsGameControllerEnabled(PlayerID);
        public short Rings
        {
            get => GetRings();
            set => AddRings(value);
        }

        // Constructors
        public Player(Players playerID)
        {
            Handle = GetCharacterGameObject(playerID);
            PlayerID = playerID;
        }

        // Enums
        public enum PlayerObjectAction : byte
        {
            Initialize
        }


    }
}
