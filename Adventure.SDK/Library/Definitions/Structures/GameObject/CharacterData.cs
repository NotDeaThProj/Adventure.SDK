using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using Adventure.SDK.Library.Definitions.Enums;

namespace Adventure.SDK.Library.Definitions.Structures.GameObject
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CharacterData
    {
        public float SpindashSpeed;
        public Upgrade Upgrades;
        public Powerup Powerups;
        public short JumpTime, field_A, UnderwaterTime, IdleTime, StatusBackup;
        public int field_12;
        private fixed byte gap16[2];
        public float PathDistance, Up;
        public Vector3 SpeedOffset, field_2C, Speed, field_44, SurfaceNormal;
        public CollisionFlags SurfaceFlags, SurfaceFlags_Old;
        public void* array_1x132;
        public GameObject* HeldObject;
        public void* field_6C, SomePointer;
        public int field_74;
        public void* array_15x32;
        public short SonicSpinTimeProbably, SonicSpinTimer, LightDashTime, LightDashTimer;
        public int field_84;
        public Vector3 field_88;
        public float SomeFrameNumberThing, TailsFlightTime;
        public PhysicsData PhysicsData;
        public AnimationThing AnimationThing;
        private fixed float SoManyVectors[36];
        public void* Struct_A3;
    }
}
