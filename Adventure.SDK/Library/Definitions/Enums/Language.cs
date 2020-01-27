using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.SDK.Library.Definitions.Enums
{
    public enum Language : byte
    {
        /// <summary>
        /// Is available in both audio and text. 
        /// </summary>
        Japanese = 0,

        /// <summary>
        /// Is available in both audio and text. 
        /// </summary>
        English = 1,

        /// <summary>
        /// Is available ONLY as text. 
        /// </summary>
        French = 2,

        /// <summary>
        /// Is available ONLY as text. 
        /// </summary>
        Spanish = 3,

        /// <summary>
        /// Is available ONLY as text. 
        /// </summary>
        German = 4
    }
}
