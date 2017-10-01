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
	/// An <see cref="Enum"/> containing the various progression states that any given mission will fall under.
	/// </summary>
	public enum MissionState
    {
        [StringLabel("Planning")]
        Planning = 0,

        [StringLabel("Ongoing")]
        Ongoing = 1,

        [StringLabel("Complete")]
        Complete = 2,
    }
}