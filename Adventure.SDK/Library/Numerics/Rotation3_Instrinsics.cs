using System;
using System.Runtime.CompilerServices;

namespace Adventure.SDK.Numerics
{
    public partial struct Rotation3
    {
        public int X;
        public int Y;
        public int Z;

        #region Constructors
        public Rotation3(int value) : this(value, value, value) { }

        public Rotation3(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion Constructors

        #region Public Instance Methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyTo(int[] array)
        {
            CopyTo(array, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CopyTo(int[] array, int index)
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

        public bool Equals(Rotation3 other)
        {
            return X == other.X &&
                   Y == other.Y &&
                   Z == other.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(Rotation3 rotation1, Rotation3 rotation2)
        {
            return rotation1.X * rotation2.X +
                   rotation1.Y * rotation2.Y +
                   rotation1.Z * rotation2.Z;
        }

        public static Rotation3 Min(Rotation3 value1, Rotation3 value2)
        {
            return new Rotation3(
                (value1.X < value2.X) ? value1.X : value2.X,
                (value1.Y < value2.Y) ? value1.Y : value2.Y,
                (value1.Z < value2.Z) ? value1.Z : value2.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Max(Rotation3 value1, Rotation3 value2)
        {
            return new Rotation3(
                (value1.X > value2.X) ? value1.X : value2.X,
                (value1.Y > value2.Y) ? value1.Y : value2.Y,
                (value1.Z > value2.Z) ? value1.Z : value2.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Abs(Rotation3 value)
        {
            return new Rotation3(Math.Abs(value.X), Math.Abs(value.Y), Math.Abs(value.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 SquareRoot(Rotation3 value)
        {
            return new Rotation3((int)Math.Sqrt(value.X), (int)Math.Sqrt(value.Y), (int)Math.Sqrt(value.Z));
        }
        #endregion Public Instance Methods

        #region Public Static Operators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator +(Rotation3 left, Rotation3 right)
        {
            return new Rotation3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator -(Rotation3 left, Rotation3 right)
        {
            return new Rotation3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator *(Rotation3 left, Rotation3 right)
        {
            return new Rotation3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator *(Rotation3 left, int right)
        {
            return left * new Rotation3(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator *(int left, Rotation3 right)
        {
            return new Rotation3(left) * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator /(Rotation3 left, Rotation3 right)
        {
            return new Rotation3(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator /(Rotation3 value1, int value2)
        {
            return new Rotation3(value1.X / value2, value1.Y / value2, value1.Z / value2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 operator -(Rotation3 value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Rotation3 left, Rotation3 right)
        {
            return (left.X == right.X &&
                    left.Y == right.Y &&
                    left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Rotation3 left, Rotation3 right)
        {
            return (left.X != right.X ||
                    left.Y != right.Y ||
                    left.Z != right.Z);
        }
        #endregion Public Static Operators
    }
}