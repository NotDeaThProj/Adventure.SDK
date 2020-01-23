namespace Adventure.SDK.Library.Definitions.Enums
{
    public enum Stage : int
    {
        HedgehogHammer = 0x1,
        
        EmeraldCoast = 0x2,
        EmeraldCoastOne = EmeraldCoast << 8,
        EmeraldCoastTwo,
        EmeraldCoastThree,

        WindyValley = 0x4,
        WindyValleyOne = WindyValley << 8,
        WindyValleyTwo,
        WindyValleyThree,

        TwinklePark = 0x8,
        TwinkleParkOne = TwinklePark << 8,
        TwinkleParkTwo,
        TwinkleParkThree,

        SpeedHighway = 0x10,
        SpeedHighwayOne = SpeedHighway << 8,
        SpeedHighwayTwo,
        SpeedHighwayThree,

        RedMountain = 0x20,
        RedMountainOne = RedMountain << 8,
        RedMountainTwo,

        SkyDeck = 0x40,
        SkyDeckOne = SkyDeck << 8,
        SkyDeckTwo,
        SkyDeckThree,
        
        LostWorld = 0x80,
        LostWorldOne = LostWorld << 8,
        LostWorldTwo,
        LostWorldThree,

        IceCap = 0x100,
        IceCapOne = IceCap << 8,
        IceCapTwo,
        IceCapThree,
        IceCapFour,

        Casinopolis = 0x200,
        CasinopolisOne = Casinopolis << 8,
        CasinopolisTwo,
        CasinopolisThree,
        CasinopolisFour,

        FinalEgg = 0x400,
        FinalEggOne = FinalEgg << 8,
        FinalEggTwo,
        FinalEggThree,

        HotShelter = 0x800,
        HotShelterOne = HotShelter << 8,
        HotShelterTwo,
        HotShelterThree,
        HotShelterFour,

    }
}