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
	/// An <see cref="Enum"/> containing the various categories that any given vehicle will fall under.
	/// </summary>
	[Serializable]
	public enum VehicleType
    {
	    [StringLabel("Undefined")]
	    Undefined = 0,

		[StringLabel("Satellite")]
        Satellite = 1,

        [StringLabel("Probe")]
        Probe = 2,

        [StringLabel("Rover")]
        Rover = 3,

        [StringLabel("Lander")]
        Lander = 4,

        [StringLabel("Capsule")]
        Capsule = 5,

        [StringLabel("Station")]
        Station = 6,

        [StringLabel("Base")]
        Base = 7,

        [StringLabel("Airplane")]
        Airplane = 8,

        [StringLabel("Kerbal")]
        Kerbal = 9,

	    [StringLabel("Launch Vehicle")]
	    LaunchVehicle = 10,
	}
}