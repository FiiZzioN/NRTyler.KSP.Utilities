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
	/// An <see cref="Enum"/> containing the various specializations that a kerbal will be assigned to.
	/// </summary>
	public enum Specialization
    {
	    [StringLabel("Undefined")]
	    Undefined = 0,

		[StringLabel("Pilot")]
        Pilot = 1,

        [StringLabel("Scientist")]
        Scientist = 2,

        [StringLabel("Engineer")]
        Engineer = 3,

        [StringLabel("Tourist")]
        Tourist = 4,
    }
}