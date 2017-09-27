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
	/// An <see cref="Enum"/> that holds the names of various buildings around the KSC.
	/// </summary>
	public enum BuildingName
	{
		[Description("Vehicle Assembly Building")]
		VAB = 0,

		[Description("Launchpad")]
		LaunchPad = 1,

		[Description("Spaceplane Hangar")]
		SPH = 2,

		[Description("Runway")]
		Runway = 3,

		[Description("Tracking Station")]
		TrackingStation = 4,

		[Description("Astronaut Complex")]
		AstronautComplex = 5,

		[Description("Research And Development")]
		RND = 6,

		[Description("Mission Control")]
		MissionControl = 7,

		[Description("Administration Building")]
		Administration = 8,
	}
}