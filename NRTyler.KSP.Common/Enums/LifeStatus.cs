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
	/// An <see cref="Enum"/> holding various states that a kerbal can be assigned to in the Astronaut Complex.
	/// </summary>
	public enum LifeStatus
    {
        [Description("Available")]
        Available = 0,

        [Description("Assigned")]
        OnMission = 1,

        [Description("Missing in Action")]
        MIA = 2,

        [Description("Killed in Action")]
        KIA = 3,
    }
}