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
	/// An <see cref="Enum"/> containing the various specializations that a kerbal will be assigned to.
	/// </summary>
	public enum Specialization
    {
	    [Description("Undefined")]
	    Undefined = 0,

		[Description("Pilot")]
        Pilot = 1,

        [Description("Scientist")]
        Scientist = 2,

        [Description("Engineer")]
        Engineer = 3,

        [Description("Tourist")]
        Tourist = 4,
    }
}