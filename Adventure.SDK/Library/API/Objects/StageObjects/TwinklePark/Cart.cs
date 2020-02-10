using System;
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
            get => Convert.ToBoolean((byte)Info->Properties.Y);
            set => Info->Properties.Y = Convert.ToByte(value);
        }

        public CartSize Size
        {
            get => (CartSize)Info->Properties.Z;
            set => Info->Properties.Z = (byte)value;
        }

        public static IntPtr MainFunction { get; } = (IntPtr)0x79A9E0;

        // Constructors
        public Cart() : base(15, 3, MainFunction) { }
    }
}