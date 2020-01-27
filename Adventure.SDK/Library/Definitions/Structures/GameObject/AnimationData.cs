using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    public unsafe struct AnimationData
    {
        public IntPtr Animation;
        public byte Instance, Property;
        public short NextAnim;
        public float TransitionSpeed, AnimationSpeed;
    }
}
