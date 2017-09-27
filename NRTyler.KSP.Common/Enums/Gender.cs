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
	/// An <see cref="Enum"/> holding the available genders that a kerbal can be assigned to.
	/// </summary>
	public enum Gender
    {
        [Description("Male")]
        Male = 0,

        [Description("Female")]
        Female = 1,
    }
}