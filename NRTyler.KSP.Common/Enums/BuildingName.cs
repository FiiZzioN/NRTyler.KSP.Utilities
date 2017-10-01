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
	/// An <see cref="Enum"/> that holds the names of various buildings around the KSC.
	/// </summary>
	public enum BuildingName
	{
		[StringLabel("Vehicle Assembly Building")]
		VAB = 0,

		[StringLabel("Launchpad")]
		LaunchPad = 1,

		[StringLabel("Spaceplane Hangar")]
		SPH = 2,

		[StringLabel("Runway")]
		Runway = 3,

		[StringLabel("Tracking Station")]
		TrackingStation = 4,

		[StringLabel("Astronaut Complex")]
		AstronautComplex = 5,

		[StringLabel("Research And Development")]
		RND = 6,

		[StringLabel("Mission Control")]
		MissionControl = 7,

		[StringLabel("Administration Building")]
		Administration = 8,
	}
}