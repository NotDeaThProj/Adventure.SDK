namespace Adventure.SDK.Library.Definitions.Enums
{
    public enum PauseMenu : byte
    {
        Continue = 0x1,
        Restart  = 0x2,
        Controls = 0x4,
        Quit     = 0x8,
        Map      = 0x10,
        Camera   = 0x20,
        Missions = 0x40,
        Unknown  = 0x80
    }
}
