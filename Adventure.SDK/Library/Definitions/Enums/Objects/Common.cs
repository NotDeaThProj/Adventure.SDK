namespace Adventure.SDK.Library.Definitions.Enums.Objects
{
    public enum ObjectInitilizationFlag : byte
    {
        None           = 0x0,
        Info           = 0x1,
        ActorData      = 0x2,
        Unknown1       = 0x4,
        Unknown2       = 0x8,
        SETData        = 0x10,
        MissionSETData = 0x20
    }
    public enum ItemBoxItem : byte
    {
        SpeedShoes,
        Invincibility,
        FiveRings,
        TenRings,
        RandomRings,
        Shield,
        ExtraLife,
        Bomb,
        MagneticShield
    }
}
