// ***********************************************************************
// Assembly         : NRTyler.KSP.Common
//
// Author           : Nicholas Tyler
// Created          : 09-24-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 12-22-2017
//
// License          : MIT License
// ***********************************************************************

using System;
using NRTyler.CodeLibrary.Attributes;

namespace NRTyler.KSP.Common.Enums
{
	/// <summary>
	/// An <see cref="Enum"/> containing various vehicle pacification options.
	/// </summary>
	public enum PacificationType
	{
		[StringLabel("Undefined")]
		Undefined = 0,

		[StringLabel("De-Orbit")]
		Deorbit = 1,

		[StringLabel("Graveyard Orbit")]
		GraveyardOrbit = 2,

	    [StringLabel("SOI Ejection")]
	    SOIEjection = 3,

        [StringLabel("Explosion")]
		Explosion = 4,
	}
}