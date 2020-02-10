using System;
using System.Text;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Adventure.SDK.Numerics
{
    public partial struct SETRotation3 : IEquatable<SETRotation3>, IFormattable
    {
        #region Public Static Properties
        public static SETRotation3 Zero { get { return new SETRotation3(); } }
        public static SETRotation3 One { get { return new SETRotation3(1, 1, 1); } }
        public static SETRotation3 UnitX { get { return new SETRotation3(1, 0, 0); } }
        public static SETRotation3 UnitY { get { return new SETRotation3(0, 1, 0); } }
        public static SETRotation3 UnitZ { get { return new SETRotation3(0, 0, 1); } }
        #endregion Public Static Properties

        #region Public Instance Methods
        public override int GetHashCode() => (X, Y, Z).GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            if (!(obj is SETRotation3))
                return false;
            return Equals((SETRotation3)obj);
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
        public static SETRotation3 Add(SETRotation3 left, SETRotation3 right)
        {
            return left + right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Subtract(SETRotation3 left, SETRotation3 right)
        {
            return left - right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Multiply(SETRotation3 left, SETRotation3 right)
        {
            return left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Multiply(SETRotation3 left, ushort right)
        {
            return left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Multiply(ushort left, SETRotation3 right)
        {
            return left * right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Divide(SETRotation3 left, SETRotation3 right)
        {
            return left / right;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Divide(SETRotation3 left, ushort divisor)
        {
            return left / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SETRotation3 Negate(SETRotation3 value)
        {
            return -value;
        }
        #endregion Public Operator Methods
    }
}