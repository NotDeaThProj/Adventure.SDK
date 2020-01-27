namespace Adventure.SDK.Library.Definitions.Enums
{
    public enum PlayerAction : byte
    {
        Nothing,
        RunningOnWindPath,
        Unknown1,
        VerticalSpring,
        Spring,
        Launched,
        TrampolineBounce1,
        TrampolineBounce2,
        TrampolineBounce3,
        SomethingTrampolineRelated,
        SomethingTrampolineRelated2,
        FloatingOnAirCurrent,
        ObjectControl,
        ObjectControlWithSpin,
        RunningInAir,
        PushingInAir,
        Helicopter,
        FallingWithoutFalling,
        BumperCar,
        Victory,
        GrabbingRocket,
        HorizontalRocket,
        VerticalRocket,
        Waterslide,
        ReturnToNormal,
        Bowling,
        Loop,
        Unknown2,
        ExitBumperCar,
        MonkeyBars,
        HangingOnIcicle,
        Ladder,
        ClingingToCylinderInSkyDeck,
        TrappedInFinalEggRobot,
        LookAround,
        HitSomething,
        BreatheBubble,
        Unknown3,
        Frozen,
        Drown,
        Shower,
        Unknown4,
        ShakeOffGarbage,
        RunDownBuilding,
        Snowboard,
        PinballMode,
        SuperSonic,
        UnsuperSonic,
        MakesTailsStartFlying,
        TailsCharacterSelectPose,
        Die
    }

    public enum Status : ushort
    {
        OnGround       = 0x1,
        Unknown1       = 0x2,
        Hurt           = 0x4,
        Interact       = 0x8,
        Unknown2       = 0x10,
        Unknown3       = 0x20,
        Unknown4       = 0x40,
        Unknown5       = 0x80,
        Ball           = 0x100,
        LightDash      = 0x200,
        Attack         = 0x400,
        HoldingObject  = 0x800,
        DoNextAction   = 0x1000,
        OnPath         = 0x2000,
        DisableControl = 0x4000,
        Unknown6       = 0x8000
    }

    public enum Powerup : ushort
    {
        Shield         = 0x1,
        ElectricShield = 0x2,
        Unknown1       = 0x4,
        Unknown2       = 0x8,
        Unknown3       = 0x10,
        Unknown4       = 0x20,
        Unknown5       = 0x40,
        Unknown6       = 0x80,
        Unknown7       = 0x100,
        Unknown8       = 0x200,
        Unknown9       = 0x400,
        Unknown10      = 0x800,
        Unknown11      = 0x1000,
        Unknown12      = 0x2000,
        Dead           = 0x4000,
        Invincibility  = 0x8000,
    }

    public enum Upgrade : ushort
    {
        /// <summary>
        /// List of upgrades for Sonic in Sonic Adventure
        /// </summary>
        CrystalRing  = 0x1,
        LightShoes   = 0x2,
        AncientLight = 0x4,

        /// <summary>
        /// List of upgrades for Tails in Sonic Adventure
        /// </summary>
        JetAnklet   = 0x8,
        RhythmBadge = 0x10,

        /// <summary>
        /// List of upgrades for Knuckles in Sonic Adventure
        /// </summary>
        FightingGloves = 0x20,
        ShovelClaw     = 0x40,

        /// <summary>
        /// List of upgrades for Amy in Sonic Adventure
        /// </summary>
        LongHammer     = 0x80,
        WarriorFeather = 0x100,

        /// <summary>
        /// List of upgrades for Gamma in Sonic Adventure
        /// </summary>
        LaserBlaster = 0x200,
        JetBooster   = 0x400,

        /// <summary>
        /// List of upgrades for Big in Sonic Adventure
        /// </summary>
        PowerRod = 0x800,
        LifeRing = 0x1000,

        /// <summary>
        /// List of upgrades for Super Sonic in Sonic Adventure
        /// </summary>
        SuperSonic = 0x8000
    }

    public enum Character : byte
    {
        Sonic,
        Eggman,
        Tails,
        Knuckles,
        Tikal,
        Amy,
        Gamma,
        Big
    }
}
