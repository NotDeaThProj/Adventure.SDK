using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Adventure.SDK.Numerics
{
    public partial struct Rotation3 : IEquatable<Rotation3>, IFormattable
    {
        #region Public Static Properties
        public static Rotation3 Zero { get { return new Rotation3(); } }
        public static Rotation3 One { get { return new Rotation3(1, 1, 1); } }
        public static Rotation3 UnitX { get { return new Rotation3(1, 0, 0); } }
        public static Rotation3 UnitY { get { return new Rotation3(0, 1, 0); } }
        public static Rotation3 UnitZ { get { return new Rotation3(0, 0, 1); } }
        #endregion Public Static Properties

        #region Public Instance Methods
        public override int GetHashCode() => (X, Y, Z).GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            if (!(obj is Rotation3))
                return false;
            return Equals((Rotation3)obj);
        }

        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            StringBuilder sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Y.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Z.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }
        #endregion Public Instance Methods

        #region Public Operator Methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Add(Rotation3 left, Rotation3 right)
        {
            return left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Subtract(Rotation3 left, Rotation3 right)
        {
            return left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Multiply(Rotation3 left, Rotation3 right)
        {
            return left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Multiply(Rotation3 left, ushort right)
        {
            return left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Multiply(ushort left, Rotation3 right)
        {
            return left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Divide(Rotation3 left, Rotation3 right)
        {
            return left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Divide(Rotation3 left, ushort divisor)
        {
            return left / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Rotation3 Negate(Rotation3 value)
        {
            return -value;
        }
        #endregion Public Operator Methods
    }
}