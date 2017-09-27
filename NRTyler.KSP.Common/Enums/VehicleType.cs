// ***********************************************************************
// Assembly         : NRTyler.KSP.Common
//
// Author           : Nicholas Tyler
// Created          : 09-24-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 09-05-2017
//
// License          : MIT License
// ***********************************************************************

using System;
using System.ComponentModel;

namespace NRTyler.KSP.Common.Enums
{
	/// <summary>
	/// An <see cref="Enum"/> containing the various categories that any given vehicle will fall under.
	/// </summary>
	[Serializable]
	public enum VehicleType
    {
	    [Description("Undefined")]
	    Undefined = 0,

		[Description("Satellite")]
        Satellite = 1,

        [Description("Probe")]
        Probe = 2,

        [Description("Rover")]
        Rover = 3,

        [Description("Lander")]
        Lander = 4,

        [Description("Capsule")]
        Capsule = 5,

        [Description("Station")]
        Station = 6,

        [Description("Base")]
        Base = 7,

        [Description("Airplane")]
        Airplane = 8,

        [Description("Kerbal")]
        Kerbal = 9,

	    [Description("Launch Vehicle")]
	    LaunchVehicle = 10,
	}
}