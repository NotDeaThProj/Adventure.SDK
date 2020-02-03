using System;
using Adventure.SDK.Library.API.Objects.Main;

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

        // Enums
        public enum CartColor : byte
        {
            Black,
            Blue,
            Green,
            Lightblue,
            Orange,
            Pink,
            Red
        }

        public enum CartSize : byte
        {
            Normal,
            Wide,
            Long
        }

        public enum CartAction : byte
        {
            Unknown1,
            Unknown2,
            Unknown3,
            Unknown4,
            OccupiedByPlayer,
        }
    }
}