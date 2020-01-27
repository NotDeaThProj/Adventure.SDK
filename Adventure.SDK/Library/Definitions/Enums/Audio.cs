namespace Adventure.SDK.Library.Definitions.Enums
{
	public enum Music : uint
	{
		#region Menu
		/// <summary>
		/// Plays -Choose Your Buddy!-
		/// </summary>
		CharacterSelect = 0x18,

		/// <summary>
		/// Plays -Will You Continue?-
		/// </summary>
		GameOver = 0x1A,

		/// <summary>
		/// Plays -Funky Groove Makes U Hot!? ...for Options-
		/// </summary>
		Options = 0x48,

		/// <summary>
		/// 
		/// </summary>
		MainMenu = 0x65,

		/// <summary>
		/// 
		/// </summary>
		TitleScreen,

		/// <summary>
		/// Plays -Challange for Another Aim-
		/// </summary>
		Trial,
		#endregion

		#region Theme
		/// <summary>
		/// Plays -My Sweet Passion ...THEME OF "AMY"-
		/// </summary>
		Amy = 0x6,

		/// <summary>
		/// Plays -Lazy Days ~Livin' in Paradise~ ...THEME OF "BIG"-
		/// </summary>
		Big,

		/// <summary>
		/// Plays -Theme of "CHAO"-
		/// </summary>
		Chao = 0x10,

		/// <summary>
		/// Plays -Theme of "E-102γ"-
		/// </summary>
		E102 = 0x1B,

		/// <summary>
		/// Plays -Theme of "Dr.EGGMAN"-
		/// </summary>
		Eggman = 0x21,

		/// <summary>
		/// Plays -Unknown from M.E. ...THEME OF "KNUCKLES"-
		/// </summary>
		Knuckles = 0x3D,

		/// <summary>
		/// Plays -Open Your Heart ...MAIN THEME OF "SONIC Adventure"-
		/// </summary>
		MainTheme = 0x41,

		/// <summary>
		/// Plays -It Doesn't Matter ...THEME OF "SONIC"-
		/// </summary>
		Sonic = 0x53,

		/// <summary>
		/// 
		/// </summary>
		SuperSonic = 0x56,

		/// <summary>
		/// Plays -Believe In Myself ...THEME OF "MILES"-
		/// </summary>
		Tails = 0x58,

		/// <summary>
		/// Plays -Theme of "TIKAL"-
		/// </summary>
		Tikal = 0x5F,
		#endregion

		#region Event
		/// <summary>
		/// Plays -Event: Sadness-
		/// </summary>
		Sadness = 0x24,

		/// <summary>
		/// Plays -Event: Strain-
		/// </summary>
		Strain,

		/// <summary>
		/// Plays -Event: Unbound-
		/// </summary>
		Unbound,

		/// <summary>
		/// Plays -Event: Good-bye!-
		/// </summary>
		Goodbye,

		/// <summary>
		/// Plays -Event: The Past-
		/// </summary>
		Past,

		/// <summary>
		/// Plays -Event: Fanfare for "Dr.EGGMAN"-
		/// </summary>
		FanfareEggman,
		#endregion

		#region Field
		/// <summary>
		/// Plays -Egg Carrier - A Song That Keeps Us On The Move-
		/// </summary>
		EggCarrier = 0xF,

		/// <summary>
		/// Plays -Calm After the Storm ...Egg Carrier -the ocean--
		/// </summary>
		EggCarrierOcean,

		/// <summary>
		/// Plays -Mystic Ruin-
		/// </summary>
		MysticRuins = 0x42,

		/// <summary>
		/// Plays -Welcome to Station Square-
		/// </summary>
		StationSquare = 0x4C,
		#endregion

		#region Stage
		/// <summary>
		/// Plays -The Dreamy Stage ...for Casinopolis-
		/// </summary>
		Casinopolis = 0xC,

		/// <summary>
		/// Plays -Dilapidated Way ...for Casinopolis-
		/// </summary>
		CasinopolisSewer,

		/// <summary>
		/// Plays -Blue Star ...for Casinopolis-
		/// </summary>
		CasionpolisPinball,

		/// <summary>
		/// 
		/// </summary>
		NightsPinball,

		/// <summary>
		/// Plays -Twinkle Circuit-
		/// </summary>
		TwinkleCircuit = 0x19,

		/// <summary>
		/// Plays -Azure Blue World ...for Emerald Coast-
		/// </summary>
		EmeraldCoastOne = 0x1C,

		/// <summary>
		/// Plays -Windy and Ripply ...for Emerald Coast-
		/// </summary>
		EmeraldCoastTwo,

		/// <summary>
		/// Plays -BIG fishes at Emerald Coast...-
		/// </summary>
		EmeraldCoastBig,

		/// <summary>
		/// Plays -Mechanical Resonance ...for Final Egg-
		/// </summary>
		FinalEggOne = 0x2A,

		/// <summary>
		/// Plays -Crank the Heat Up!! ...for Final Egg-
		/// </summary>
		FinalEggTwo,

		/// <summary>
		/// Plays -Sweet Punch ...for Hedgehog Hammer-
		/// </summary>
		HedgehogHammer = 0x2E,

		/// <summary>
		/// Plays -Run Through the Speed Highway ...for Speed Highway-
		/// </summary>
		SpeedHighwayOne,

		/// <summary>
		/// Plays -Goin' Down!? ...for Speed Highway-
		/// </summary>
		SpeedHighwayTwo,

		/// <summary>
		/// Plays -At Dawn ...for Speed Highway-
		/// </summary>
		SpeedHighwayThree,

		/// <summary>
		/// Plays -Snowy Mountain ...for Icecap-
		/// </summary>
		IceCapOne = 0x33,

		/// <summary>
		/// Plays -Limestone Cave ...for Icecap-
		/// </summary>
		IceCapTwo,

		/// <summary>
		/// Plays -Be Cool, Be Wild and Be Groovy ...for Icecap-
		/// </summary>
		IceCapThree,

		/// <summary>
		/// Plays -Tricky Maze ...for Lost World-
		/// </summary>
		LostWorldOne = 0x3E,

		/// <summary>
		/// Plays -Danger! Chased by Rock ...for Lost World-
		/// </summary>
		LostWorldTwo,

		/// <summary>
		/// Plays -Leading Lights ...for Lost World-
		/// </summary>
		LostWorldThree,

		/// <summary>
		/// Plays -Mt Red: a Symbol of Thrill ...for Red Mountain-
		/// </summary>
		RedMountainOne = 0x49,

		/// <summary>
		/// Plays -Red Hot Skull ...for Red Mountain-
		/// </summary>
		RedMountainTwo,

		/// <summary>
		/// Plays -Sand Hill-
		/// </summary>
		SandHill = 0x4D,

		/// <summary>
		/// Plays -Tornado Scramble ...for Sky Chase-
		/// </summary>
		SkyChase,

		/// <summary>
		/// Plays -Bad Taste Aquarium ...for Hot Shelter-
		/// </summary>
		HotShelterOne,

		/// <summary>
		/// Plays -Red Barrage Area ...for Hot Shelter-
		/// </summary>
		HotShelterTwo,

		/// <summary>
		/// Plays -Skydeck A Go! Go! ...for Sky Deck-
		/// </summary>
		SkyDeckOne,

		/// <summary>
		/// Plays -General Offensive ...for Sky Deck-
		/// </summary>
		SkyDeckTwo,

		/// <summary>
		/// Plays -Twinkle Cart ...for Twinkle Park
		/// </summary>
		TwinkleParkOne = 0x68,

		/// <summary>
		/// Plays -Pleasure Castle ...for Twinkle Park-
		/// </summary>
		TwinkleParkTwo,

		/// <summary>
		/// Plays -Fakery Way ...for Twinkle Park-
		/// </summary>
		TwinkleParkThree,

		/// <summary>
		/// Plays -Windy Hill ...for Windy Valley-
		/// </summary>
		WindyValleyOne,

		/// <summary>
		/// Plays -Tornado ...for Windy Valley-
		/// </summary>
		WindyValleyTwo,

		/// <summary>
		/// Plays -The Air ...for Windy Valley-
		/// </summary>
		WindyValleyThree,
		#endregion

		#region Boss
		/// <summary>
		/// Plays -Egg Mobile ...Boss: Egg Hornet-
		/// </summary>
		BossAll = 0x8,

		/// <summary>
		/// Plays -Crazy Robo ...Boss: E-101R-
		/// </summary>
		E101R,

		/// <summary>
		/// Plays -Fight for My Own Way ...Boss: Event-
		/// </summary>
		Rival,

		/// <summary>
		/// Plays -Heartless Colleague ...Boss: E-Series Targets-
		/// </summary>
		ESeries,

		/// <summary>
		/// Plays -Boss: CHAOS ver.0, 2, 4-
		/// </summary>
		Chaos024 = 0x14,

		/// <summary>
		/// Plays -Boss: CHAOS ver.6-
		/// </summary>
		Chaos6,

		/// <summary>
		/// Plays -Open Your Heart -Main Theme of "SONIC Adventure"--
		/// </summary>
		PerfectChaosPhaseOne,

		/// <summary>
		/// Plays -Perfect CHAOS Revival! ...Boss: Perfect CHAOS-
		/// </summary>
		PerfectChaosPhaseTwo,

		/// <summary>
		/// Plays -Militant Missionary ...Boss: Egg Walker & Egg Viper-
		/// </summary>
		EggWalker = 0x22, EggViper = 0x22,

		/// <summary>
		/// Plays -ZERO The Chase-master ...Boss: Eggman Robot -ZERO--
		/// </summary>
		Zero,
		#endregion

		#region Chao
		ChaoGoal = 0x11,
		ChaoHall,

		/// <summary>
		/// Plays -Join Us 4 Happy Time ...for CHAO Race-
		/// </summary>
		ChaoRace,
		
		ChaoLevelUp = 0x70,
		ChaoGoodbye,
		ChaoNaming,

		/// <summary>
		/// Plays -Letz Get This Party Started ...for CHAO Race Entrance-
		/// </summary>
		ChaoRaceEntrance,

		ChaoRaceGateOpen,
		ChaoHeroBornOne = 0x78,
		ChaoDarkBornOne = 0x79,
		ChaoBorn = 0x77,
		ChaoHeroBornTwo = 0x75,
		ChaoDarkBornTWo = 0x76,
		ChaoDied = 0x7A,
		ChaoDance,
		ChaoBlackMarket,
		#endregion

		#region Introduction
		AmyIntro = 0x59,
		BigIntro,
		GammaIntro,
		KnucklesIntro,
		TailsIntro,
		SonicIntro,
		#endregion

		#region Tutorial
		AmyTutorial = 0x00,
		BigTutorial,
		GammaTutorial,
		KnucklesTutorial,
		TailsTutorial,
		SonicTutorial,
		#endregion

		#region Jingle
		FishGet = 0x2B,

		/// <summary>
		/// Plays -and... Fish Hits!-
		/// </summary>
		FishHits,

		FishMiss,

		/// <summary>
		/// Plays -Danger is Imminent-
		/// </summary>
		HurryUp = 0x32,

		/// <summary>
		/// Plays -Invincible ...No Fear!-
		/// </summary>
		Invincibility = 0x36,

		ItemOne,
		One,
		Two,
		Three,
		Four,
		Five,
		OneUp = 0x47,
		RoundClear = 0x4B,

		/// <summary>
		/// Plays -Hey You! It's Time to Speed Up!!!-
		/// </summary>
		SpeedUp = 0x55,

		Timer = 0x60,
		EggCarrierTransform,
		UnusedOne,
		UnusedTwo,
		TrialQuit,
		MissionStart = 0x6E,
		MissionClear,
		NoMusic = 0xFFFFFFFF
		#endregion
	}
}
