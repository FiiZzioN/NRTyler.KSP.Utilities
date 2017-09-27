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
	/// An <see cref="Enum"/> containing various vehicle pacification options.
	/// </summary>
	public enum PacificationType
	{
		[Description("Undefined")]
		Undefined = 0,

		[Description("Deorbit")]
		Deorbit = 1,

		[Description("Graveyard Orbit")]
		GraveyardOrbit = 2,

		[Description("Explosion")]
		Explosion = 3,
	}
}