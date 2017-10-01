// ***********************************************************************
// Assembly         : NRTyler.KSP.Common
//
// Author           : Nicholas Tyler
// Created          : 09-24-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 10-01-2017
//
// License          : MIT License
// ***********************************************************************

using System;
using NRTyler.CodeLibrary.Attributes;

namespace NRTyler.KSP.Common.Enums
{
	/// <summary>
	/// An <see cref="Enum"/> holding different flight profiles that a mission can take.
	/// </summary>
	public enum FlightProfile
    {
	    [StringLabel("Undefined")]
	    Undefined = 0,

	    [StringLabel("Ground Based")]
	    GroundBased = 1,

		[StringLabel("Atmospheric Flight")]
        AtmosphericFlight = 2,

        [StringLabel("Suborbital")]
        Suborbital = 3,

        [StringLabel("Orbital")]
        Orbital = 4,

        [StringLabel("Interplanetary")]
        Interplanetary = 5,
    }
}