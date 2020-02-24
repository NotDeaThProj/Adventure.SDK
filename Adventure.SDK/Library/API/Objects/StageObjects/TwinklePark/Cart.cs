using System;
using System.Numerics;
using Adventure.SDK.Library.API.Objects.Main;
using Adventure.SDK.Library.Definitions.Enums.Objects;

namespace Adventure.SDK.Library.API.Objects.StageObjects.TwinklePark
{
    public unsafe class Cart : GameObject
    {
        // Properties
        public CartColor Color
        {
            get => (CartColor)Info->Properties.X;
            set => Info->Properties.X = (byte)value;
        }

        public bool IsUnoccupied
        {
            get => (byte)Info->Properties.Y > 0;
            set => Info->Properties.Y = Convert.ToByte(value);
        }

        public CartSize Size
        {
            get => (CartSize)Info->Properties.Z;
            set => Info->Properties.Z = (byte)value;
        }

        public static IntPtr MainFunction { get; } = (IntPtr)0x79A9E0;
        public static new ObjectInitilizationFlag InitializationFlag { get; } =
            ObjectInitilizationFlag.Info | ObjectInitilizationFlag.ActorData | ObjectInitilizationFlag.Unknown1 |
            ObjectInitilizationFlag.Unknown2 | ObjectInitilizationFlag.SETData | ObjectInitilizationFlag.MissionSETData;

        // Constructors
        public Cart() : base(InitializationFlag, 3, MainFunction) { }
    }
}