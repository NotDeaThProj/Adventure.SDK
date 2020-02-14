using System;
using Adventure.SDK.Library.API.Objects.Main;
using Adventure.SDK.Library.Definitions.Enums.Objects;

namespace Adventure.SDK.Library.API.Objects.Common
{
    public class Snowboard : GameObject
    {
        public Snowboard() : base(ObjectInitilizationFlag.Info | ObjectInitilizationFlag.ActorData, 2, (IntPtr)0x4E9660) { }
    }
}
