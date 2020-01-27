using System;
using Adventure.SDK.Library.API.Objects.Main;

namespace Adventure.SDK.Library.API.Objects
{
    // Enums
    public enum Color : byte
    {
        Black,
        Blue,
        Green,
        Lightblue,
        Orange,
        Pink,
        Red
    }

    public enum Size : byte
    {
        Normal,
        Wide,
        Long
    }

    public unsafe class Cart : GameObject
    {
        // Constructors
        public Cart() : base(15, 3, (IntPtr)0x79A9E0) { }

        // Properties
        public Color Color
        {
            get => (Color)Info->Properties.X;
            set => Info->Properties.X = (byte)value;
        }

        public bool IsUnoccupied
        {
            get => Convert.ToBoolean((byte)Info->Properties.Y);
            set => Info->Properties.Y = Convert.ToByte(value);
        }

        public Size Size
        {
            get => (Size)Info->Properties.Z;
            set => Info->Properties.Z = (byte)value;
        }
    }
}