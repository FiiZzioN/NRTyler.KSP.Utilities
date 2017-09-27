// ***********************************************************************
// Assembly         : NRTyler.KSPManager.Common
//
// Author           : Nicholas Tyler
// Created          : 08-16-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 08-16-2017
//
// License          : GNU General Public License v3.0
// ***********************************************************************

using System;
using System.ComponentModel;

namespace NRTyler.KSP.Common.Enums
{
	/// <summary>
	/// An <see cref="Enum"/> containing the various states that any vessel or kerbal can be in.
	/// </summary>
	public enum CraftSituation
    {
	    [Description("Undefined")]
	    Undefined = 0,

	    [Description("In Vehicle Assembly Building")]
	    InsideVAB = 1,

	    [Description("In SpacePlane Hanger")]
	    InsideSPH = 2,

		[Description("Landed")]
        Landed = 3,

        [Description("Suborbital")]
        Suborbital = 4,

        [Description("On Orbit")]
        OnOrbit = 5,

        [Description("In Flight")]
        InFlight = 6,
    }
}