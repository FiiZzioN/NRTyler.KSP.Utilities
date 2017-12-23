// ***********************************************************************
// Assembly         : NRTyler.KSP.Common
//
// Author           : Nicholas Tyler
// Created          : 09-24-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 10-05-2017
//
// License          : MIT License
// ***********************************************************************

using System;
using NRTyler.CodeLibrary.Attributes;

namespace NRTyler.KSP.Common.Enums
{
	/// <summary>
	/// An <see cref="Enum"/> containing the various states that any vessel or kerbal can be in.
	/// </summary>
	public enum CraftSituation
    {
	    [StringLabel("Undefined")]
	    Undefined = 0,

	    [StringLabel("In Vehicle Assembly Building")]
	    InsideVAB = 1,

	    [StringLabel("In SpacePlane Hanger")]
	    InsideSPH = 2,

		[StringLabel("Landed")]
        Landed = 3,

        [StringLabel("Sub-Orbital")]
        Suborbital = 4,

        [StringLabel("On Orbit")]
        OnOrbit = 5,

        [StringLabel("In Flight")]
        InFlight = 6,

        [StringLabel("Docked To Vessel")]
        Docked = 7,

        [StringLabel("Escaping")]
        Escaping = 8,

        [StringLabel("Splashed Down")]
        SplashDown = 9,
    }
}