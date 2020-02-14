using System.Numerics;
using Adventure.SDK.Numerics;

namespace Adventure.SDK.Library.Definitions.Structures.SETData
{
    public struct SETEntry
    {
        public short ObjectType;
        public SETRotation3 Rotation;
        public Vector3 Position, Properties;
    }
}
