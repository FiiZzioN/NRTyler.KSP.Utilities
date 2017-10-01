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
	/// An <see cref="Enum"/> holding the available genders that a kerbal can be assigned to.
	/// </summary>
	public enum Gender
    {
        [StringLabel("Male")]
        Male = 0,

        [StringLabel("Female")]
        Female = 1,
    }
}