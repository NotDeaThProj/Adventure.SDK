using System;
using System.Runtime.CompilerServices;

namespace Adventure.SDK.Numerics
{
    public partial struct SETRotation3
    {
        public ushort X;
        public ushort Y;
        public ushort Z;

        #region Constructors
        public SETRotation3(ushort value) : this(value, value, value) { }

        public SETRotation3(ushort x, ushort y, ushort z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion Constructors

        #region Public Instance Methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyTo(ushort[] array)
        {
            CopyTo(array, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyTo(ushort[] array, int index)
        {
            if (array == null)
                throw new NullReferenceException("Arg_NullArgumentNullRef");
            if (index < 0 || index >= array.Length)
                throw new ArgumentOutOfRangeException("Arg_ArgumentOutOfRangeException");
            if ((array.Length - index) < 3)
                throw new ArgumentException("Arg_ElementsInSourceIsGreaterThanDestination");

            array[index] = X;
            array[index + 1] = X;
            array[index + 2] = X;
        }

        public bool Equals(SETRotation3 other)
        {
            return X == other.X &&
                   Y == other.Y &&
                   Z == other.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(SETRotation3 rotation1, SETRotation3 rotation2)
        {
            return rotation1.X * rotation2.X +
                   rotation1.Y * rotation2.Y +
                   rotation1.Z * rotation2.Z;
        }

        public static SETRotation3 Min(SETRotation3 value1, SETRotation3 value2)
        {
            return new SETRotation3(
                (value1.X < value2.X) ? value1.X : value2.X,
                (value1.Y < value2.Y) ? value1.Y : value2.Y,
                (value1.Z < value2.Z) ? value1.Z : value2.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Max(SETRotation3 value1, SETRotation3 value2)
        {
            return new SETRotation3(
                (value1.X > value2.X) ? value1.X : value2.X,
                (value1.Y > value2.Y) ? value1.Y : value2.Y,
                (value1.Z > value2.Z) ? value1.Z : value2.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Abs(SETRotation3 value)
        {
            return new SETRotation3((ushort)Math.Abs(value.X), (ushort)Math.Abs(value.Y), (ushort)Math.Abs(value.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 SquareRoot(SETRotation3 value)
        {
            return new SETRotation3((ushort)Math.Sqrt(value.X), (ushort)Math.Sqrt(value.Y), (ushort)Math.Sqrt(value.Z));
        }
        #endregion Public Instance Methods

        #region Public Static Operators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator +(SETRotation3 left, SETRotation3 right)
        {
            return new SETRotation3((ushort)(left.X + right.X), (ushort)(left.Y + right.Y), (ushort)(left.Z + right.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator -(SETRotation3 left, SETRotation3 right)
        {
            return new SETRotation3((ushort)(left.X - right.X), (ushort)(left.Y - right.Y), (ushort)(left.Z - right.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator *(SETRotation3 left, SETRotation3 right)
        {
            return new SETRotation3((ushort)(left.X * right.X), (ushort)(left.Y * right.Y), (ushort)(left.Z * right.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator *(SETRotation3 left, ushort right)
        {
            return left * new SETRotation3(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator *(ushort left, SETRotation3 right)
        {
            return new SETRotation3(left) * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator /(SETRotation3 left, SETRotation3 right)
        {
            return new SETRotation3((ushort)(left.X / right.X), (ushort)(left.Y / right.Y), (ushort)(left.Z / right.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator /(SETRotation3 value1, ushort value2)
        {
            return new SETRotation3((ushort)(value1.X / value2), (ushort)(value1.Y / value2), (ushort)(value1.Z / value2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 operator -(SETRotation3 value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(SETRotation3 left, SETRotation3 right)
        {
            return (left.X == right.X &&
                    left.Y == right.Y &&
                    left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(SETRotation3 left, SETRotation3 right)
        {
            return (left.X != right.X ||
                    left.Y != right.Y ||
                    left.Z != right.Z);
        }
        #endregion Public Static Operators
    }
}