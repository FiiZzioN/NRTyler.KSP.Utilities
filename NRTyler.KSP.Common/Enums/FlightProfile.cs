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
	/// An <see cref="Enum"/> holding different flight profiles that a mission can take.
	/// </summary>
	public enum FlightProfile
    {
	    [Description("Undefined")]
	    Undefined = 0,

	    [Description("Ground Based")]
	    GroundBased = 1,

		[Description("Atmospheric Flight")]
        AtmosphericFlight = 2,

        [Description("Suborbital")]
        Suborbital = 3,

        [Description("Orbital")]
        Orbital = 4,

        [Description("Interplanetary")]
        Interplanetary = 5,
    }
}