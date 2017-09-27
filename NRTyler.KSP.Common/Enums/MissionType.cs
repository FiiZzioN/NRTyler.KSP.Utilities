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
using NRTyler.KSP.Common.Attributes;

namespace NRTyler.KSP.Common.Enums
{
	/// <summary>
	/// An <see cref="Enum"/> containing various items that will help describe what the mission was about.
	/// </summary>
	public enum MissionType
    {
	    [StringLabel("Undefined")]
	    Undefined = 0,

		[StringLabel("Manned")]
        Manned = 1,

        [StringLabel("Unmanned")]
        Unmanned = 2,

        [StringLabel("Asteroid Redirect")]
        AsteroidRedirect = 3,

        [StringLabel("Contract")]
        Contract = 4,

        [StringLabel("Deorbit Debris")]
        DeorbitDebris = 5,

        [StringLabel("Exploration")]
        Exploration = 6,

        [StringLabel("ISRU")]
        ISRU = 7,

        [StringLabel("Impactor")]
        Impactor = 8,

        [StringLabel("Mapping")]
        Mapping = 9,

        [StringLabel("Rescue")]
        Rescue = 10,

        [StringLabel("Research")]
        Research = 11,

        [StringLabel("Resupply")]
        Resupply = 12,

        [StringLabel("Survey")]
        Survey = 13,
        
        [StringLabel("Tourism")]
        Tourism = 14,


    }
}