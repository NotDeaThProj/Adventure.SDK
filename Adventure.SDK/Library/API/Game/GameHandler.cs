using Adventure.SDK.Library.Definitions.Enums;

namespace Adventure.SDK.Library.API.Game
{
    public unsafe class GameHandler
    {
        private static GameMode* _gameMode = (GameMode*)0x3ABDC7C;
        private static GameState* _gameState = (GameState*)0x3B22DE4;
        private static Stage* _currentLevel = (Stage*)0x3B22DCC;
        private static byte* _currentAct = (byte*)0x3B22DEC;
        private static int* _currentLevelObjectCount = (int*)0x3C4E454;
        private static void** _setDataArray = (void**)0x3C4E468;
        private static void* _itemBoxItemFunctionArray = (void*)0x9BF190;
        private static bool* _isCartOnAutoPilot = (bool*)0x3D08E00;

        public GameMode GameMode
        {
            get => *_gameMode;
            set => *_gameMode = value;
        }

        public GameState GameState
        {
            get => *_gameState;
            set => *_gameState = value;
        }

        public Stage CurrentStage
        {
            get
            {
                switch (*_currentLevel)
                {
                    case Stage.HedgehogHammer:
                    case Stage.EmeraldCoast:
                    case Stage.WindyValley:
                    case Stage.TwinklePark:
                    case Stage.SpeedHighway:
                    case Stage.RedMountain:
                    case Stage.SkyDeck:
                    case Stage.LostWorld:
                    case Stage.IceCap:
                    case Stage.Casinopolis:
                    case Stage.FinalEgg:
                    case Stage.HotShelter:
                    case Stage.StationSquare:
                    case Stage.EggCarrierOutside:
                    case Stage.EggCarrierInside:
                    case Stage.MysticRuins:
                    case Stage.Past:
                    case Stage.TwinkleCircuit:
                        return (Stage)(((byte)*_currentLevel << 8) + *_currentAct);
                    default:
                        return (Stage)((byte)*_currentLevel + *_currentAct);
                }
            }
        }
        
        public int CurrentLevelObjectCount
        {
            get => *_currentLevelObjectCount;
        }

        public void* SETEntryArrayAddress
        {
            get => *_setDataArray;
        }

        public void* ItemBoxItemFunctionAddress
        {
            get => _itemBoxItemFunctionArray;
        }

        public bool IsCartOnAutoPilot
        {
            get => *_isCartOnAutoPilot;
            set => *_isCartOnAutoPilot = value;
        }
    }
}
