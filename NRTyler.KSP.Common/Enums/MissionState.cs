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
	/// An <see cref="Enum"/> containing the various progression states that any given mission will fall under.
	/// </summary>
	public enum MissionState
    {
        [Description("Planning")]
        Planning = 0,

        [Description("Ongoing")]
        Ongoing = 1,

        [Description("Complete")]
        Complete = 2,
    }
}