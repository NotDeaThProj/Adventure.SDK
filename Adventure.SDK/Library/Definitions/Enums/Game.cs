namespace Adventure.SDK.Library.Definitions.Enums
{
    public enum GameMode : byte
    {
        /// <summary>
        /// Restart
        /// </summary>
        Restart = 0,

        /// <summary>
        /// Title Screen
        /// </summary>
        Logo = 1,

        /// <summary>
        /// Exits the game.
        /// </summary>
        Exit = 2,

        Unknown1 = 3,

        /// <summary>
        /// Action Stage
        /// </summary>        
        Stage = 4,

        /// <summary>
        /// Adventure Field
        /// </summary>
        Field = 5,

        Unknown2,

        Unknown3,

        /// <summary>
        /// CGI Cutscene
        /// </summary>
        Movie = 8,

        /// <summary>
        /// Trial Mode
        /// </summary>
        Trial = 9,

        /// <summary>
        /// Mission Mode
        /// </summary>
        Mission = 10,

        /// <summary>
        /// Character Select
        /// </summary>
        CharacterSelect = 11,

        /// <summary>
        /// Menu
        /// </summary>
        Menu = 12,
        
        Restart2 = 13,

        Unknown4 = 14,

        Unknown5 = 15,

        Unknown6 = 16,

        StartAdventure = 17,

        AdventureStory = 18,

        Unknown7 = 19,

        Unknown8 = 20,

        StartCredits = 21,

        Credits = 22,
    }

    public enum GameState : byte
    {
        ResetLevelBadTexture,
        ClearScreen,
        Crash,
        ClearScreen2,
        ShowLevel,
        LoadAdventureField,
        Die,
        Restart,
        Crash2,
        Transition,
        ClearScreen3,
        Restart2,

        /// <summary>
        /// Restarts the current act of the level.
        /// </summary>
        RestartLevelAct,
        Crash3,
        Credits,
        Normal,
        Paused,
        LoadLevel,
        Crash4,
        ReturnToTitle,
        ReturnToTitle2,
        LoadingScreenBadTexture,
        RestartLevelBadTexture2,
        ReturnToTitle3,
        LoadLevel2
    }
}
