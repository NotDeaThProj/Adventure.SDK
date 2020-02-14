using System;
using System.Numerics;
using Adventure.SDK.Library.API.Objects.Main;
using Adventure.SDK.Library.Definitions.Enums.Objects;

namespace Adventure.SDK.Library.API.Objects.StageObjects.TwinklePark
{
    public class Cart : GameObject
    {
        // Properties
        public CartColor Color
        {
            get => (CartColor)Info.Properties.X;
            set => Info.Properties = new Vector3((byte)value, Info.Properties.Y, Info.Properties.Z);
        }

        public bool IsUnoccupied
        {
            get => (byte)Info.Properties.Y > 0;
            set => Info.Properties = new Vector3(Info.Properties.X, Convert.ToByte(value), Info.Properties.Z);
        }

        public CartSize Size
        {
            get => (CartSize)Info.Properties.Z;
            set => Info.Properties = new Vector3(Info.Properties.X, Info.Properties.Y, (byte)value);
        }

        public static IntPtr MainFunction { get; } = (IntPtr)0x79A9E0;
        public static new ObjectInitilizationFlag InitializationFlag { get; } =
            ObjectInitilizationFlag.Info | ObjectInitilizationFlag.ActorData | ObjectInitilizationFlag.Unknown1 |
            ObjectInitilizationFlag.Unknown2 | ObjectInitilizationFlag.SETData | ObjectInitilizationFlag.MissionSETData;

        // Constructors
        public Cart() : base(InitializationFlag, 3, MainFunction) { }
    }
}