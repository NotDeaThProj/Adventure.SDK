using Ninja.SDK.Library.Structures.Mesh;
using Adventure.SDK.Library.Definitions.Enums;
using Adventure.SDK.Library.Definitions.Structures.GameObject;
using Adventure.SDK.Library.Definitions.Structures.Object;
using Adventure.SDK.Library.Definitions.Structures.SETData;
using Reloaded.Memory.Pointers;
using System;

namespace Adventure.SDK.Library.API.Game
{
    public unsafe class GameHandler
    {
        private static readonly Stage _currentLevel          = *(Stage*)0x3B22DCC;
        private static readonly byte _currentAct             = *(byte*)0x3B22DEC;
        private static readonly int _currentLevelObjectCount = *(int*)0x3C4E454;

        private static readonly void** _setDataAddress = (void**)0x3C4E468;
        private static readonly void* _itemBoxItemFunctionArrayAddress = (void*)0x9BF190;
        private static readonly GameObject* _masterGameObject = (GameObject*)0x3ABDBEC;
        private static readonly GameObject* _gameObjectArrayAddress = (GameObject*)0x3ABDBC4;

        public GameMode GameMode { get => *(GameMode*)0x3ABDC7C; set => *(GameMode*)0x3ABDC7C = value; }

        public GameState GameState { get => *(GameState*)0x3B22DE4; set => *(GameState*)0x3B22DE4 = value; }

        public Stage CurrentStage
        {
            get
            {
                switch (_currentLevel)
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
                        return (Stage)(((byte)_currentLevel << 8) + _currentAct);
                    default:
                        return (Stage)((byte)_currentLevel + _currentAct);
                }
            }
        }
        
        public int CurrentLevelObjectCount { get => _currentLevelObjectCount; }

        public ReadOnlySpan<SETEntry> SETData { get => new ReadOnlySpan<SETEntry>(_setDataAddress, _currentLevelObjectCount); }
        public ReadOnlySpan<ItemBoxItem> ItemBoxItemFunctionArray { get => new ReadOnlySpan<ItemBoxItem>(_itemBoxItemFunctionArrayAddress, 9); }

        public Span<GameObject> GameObjectArray { get => new Span<GameObject>(_gameObjectArrayAddress, 8); }

        public bool IsCartOnAutoPilot { get => *(bool*)0x3D08E00; set => *(bool*)0x3D08E00 = value; }
        public bool IsMetalSonic { get => *(bool*)0x3B18DB5; set => *(bool*)0x3B18DB5 = value; }

        public Language VoiceLanguage { get => *(Language*)0x3B0EF38; set => *(Language*)0x3B0EF38 = value; }
        public Language TextLanguage { get => *(Language*)0x3B0F0E8; set => *(Language*)0x3B0F0E8 = value; }

        public float TornadoHealth { get => *(float*)0x3C82304; set => *(float*)0x3C82304 = value; }

        public RefFixedArrayPtr<BlittablePointer<Model>> SonicModel { get => new RefFixedArrayPtr<BlittablePointer<Model>>(*(ulong*)0x38F6E80, 0x4F); }
        public RefFixedArrayPtr<BlittablePointer<Model>> TailsModel { get => new RefFixedArrayPtr<BlittablePointer<Model>>(*(ulong*)0x3AAD124, 0x48); }
        public RefFixedArrayPtr<BlittablePointer<Model>> KnucklesModel { get => new RefFixedArrayPtr<BlittablePointer<Model>>(*(ulong*)0x3A7CF1C, 0x4A); }
        public RefFixedArrayPtr<BlittablePointer<Model>> AmyModel { get => new RefFixedArrayPtr<BlittablePointer<Model>>(*(ulong*)0x38F6E70, 0x50); }
        public RefFixedArrayPtr<BlittablePointer<Model>> BigModel { get => new RefFixedArrayPtr<BlittablePointer<Model>>(*(ulong*)0x38F6E98, 0x2C); }
        public RefFixedArrayPtr<BlittablePointer<Model>> GammaModel { get => new RefFixedArrayPtr<BlittablePointer<Model>>(*(ulong*)0x3A8AF6C, 0x4E); }
    }
}
