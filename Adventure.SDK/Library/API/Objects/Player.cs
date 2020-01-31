using Adventure.SDK.Library.Definitions.Enums;
using static Adventure.SDK.Library.Classes.Native.Player;

namespace Adventure.SDK.Library.API.Objects.Main
{
    public unsafe class Player : GameObject
    {
        public Player(Players playerID)
        {
            Handle = GetCharacterGameObject(playerID);
        }

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
    }
}
