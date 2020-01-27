using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    public unsafe struct AnimationThing
    {
        public short State,
                     field_2,
                     Index,
                     LastIndex,
                     LastIndex2,
                     field_A,
                     field_C,
                     field_E;
        public float Frame;
        public int dword14;
        public float* field_18, field_1C;
        public AnimationData* AnimationData;
        public void* WeldInfo, Action;
    }
}
