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
	/// An <see cref="Enum"/> holding various states that a kerbal can be assigned to in the Astronaut Complex.
	/// </summary>
	public enum LifeStatus
    {
        [StringLabel("Available")]
        Available = 0,

        [StringLabel("Assigned")]
        OnMission = 1,

        [StringLabel("Missing in Action")]
        MIA = 2,

        [StringLabel("Killed in Action")]
        KIA = 3,
    }
}