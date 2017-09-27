// ***********************************************************************
// Assembly         : NRTyler.KSP.Common
//
// Author           : Nicholas Tyler
// Created          : 09-24-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 08-16-2017
//
// License          : MIT License
// ***********************************************************************

using System;
using System.ComponentModel;

namespace NRTyler.KSP.Common.Enums
{
	/// <summary>
	/// An <see cref="Enum"/> containing the name and numerical value for a given level.
	/// </summary>
	public enum BuildingLevel
    {
        [Description("One")]
        One = 0,

        [Description("Two")]
        Two = 1,

        [Description("Three")]
        Three = 2,
    }
}