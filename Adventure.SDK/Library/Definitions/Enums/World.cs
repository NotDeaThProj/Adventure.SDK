namespace Adventure.SDK.Library.Definitions.Enums
{
    public enum CollisionFlags : uint
    {
        Solid                = 0x1,
        Water                = 0x2,
        NoFriction           = 0x4,
        NoAcceleration       = 0x8,
        UseSkyDrawDistance   = 0x20,
        IncreaseAcceleration = 0x80,
        Dig                  = 0x100,
        NoClimb              = 0x1000,
        Hurt                 = 0x10000,
        Footprints           = 0x100000,
        UseAlphaSort         = 0x1000000,
        AlphaSort            = 0x2000000,
        UVManipulation       = 0x4000000,
        UseRotation          = 0x10000000,
        Visible              = 0x80000000
    }

    public enum TimeOfDay : byte
    {
        Day,
        Evening,
        Night
    }
}
