using System;

namespace Adventure.SDK.Numerics
{
    public static class FloatConversion
    {
        public unsafe static string ToHex(this float f)
        {
            var i = *((int*)&f);
            return i.ToString("X8");
        }
        public unsafe static float ToFloat(this string s)
        {
            var i = Convert.ToInt32(s, 16);
            return *((float*)&i);
        }
    }
}
