using System.Numerics;
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
            set => ChangePlayerAction(PlayerID, value);
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
        public short Lives
        {
            get => GetLives();
            set => *(short*)0x3B0EF34 = value;
        }
        public Vector3 Gravity
        {
            get => *(Vector3*)0x3B0F0F8;
            set => *(Vector3*)0x3B0F0F8 = value;
        }

        // Constructors
        /// <summary>
        /// Gets the player one's game object
        /// </summary>
        public Player()
        {
            Handle = GetCharacterGameObject(Players.P1);
            PlayerID = Players.P1;
        }

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
