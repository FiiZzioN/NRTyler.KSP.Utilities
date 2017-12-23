// ************************************************************************
// Assembly         : NRTyler.KSP.Common
// 
// Author           : Nicholas Tyler
// Created          : 12-22-2017
// 
// Last Modified By : Nicholas Tyler
// Last Modified On : 12-22-2017
// 
// License          : MIT License
// ***********************************************************************

using System;

using NRTyler.CodeLibrary.Attributes;

namespace NRTyler.KSP.Common.Enums
{
    /// <summary>
    /// An <see cref="Enum"/> containing a wide variety of orbits that any vehicle can achieve or be injected into.
    /// </summary>
    /// <remarks>
    /// You can find more info about these orbits at: http://enwp.org/List_of_orbits
    /// </remarks>
    public enum OrbitType
    {
        [StringLabel("Undefined")]
        Undefined = 0,

        #region Altitude classifications

        [StringLabel("Low Earth Orbit")]
        LEO = 1,

        [StringLabel("Medium Earth Orbit")]
        MEO = 2,

        [StringLabel("Geostationary Orbit")]
        GEO = 3,

        [StringLabel("High Earth Orbit")]
        HEO = 4,

        [StringLabel("Graveyard Orbit")]
        Graveyard = 5,

        #endregion

        #region Inclination Classifications

        [StringLabel("Sun-Synchronous Orbit")]
        SSO = 6,

        [StringLabel("Polar Orbit")]
        Polar = 7,

        [StringLabel("Non-Inclined Orbit")]
        NonInclined = 8,

        [StringLabel("Inclined Orbit")]
        Inclined = 9,

        [StringLabel("Equatorial Orbit")]
        Equatorial = 10,

        #endregion

        #region Eccentricity Classifications
        
        [StringLabel("Circular Orbit")]
        Circular = 11,

        [StringLabel("Parabolic Orbit")]
        Parabolic = 12,

        [StringLabel("Hyperbolic Orbit")]
        Hyperbolic = 13,

        #endregion

        #region Synchronicity Classifications

        [StringLabel("Semi-Synchronous Orbit")]
        SemiSynchronous = 14,

        [StringLabel("Sub-Synchronous Orbit")]
        SubSynchronous = 15,

        [StringLabel("Super-Synchronous Orbit")]
        SuperSynchronous = 16,

        [StringLabel("Tundra Orbit")]
        Tundra = 17,

        [StringLabel("Molniya Orbit")]
        Molniya = 18,

        #endregion

        #region Special Classifications

        [StringLabel("Parking Orbit")]
        Parking = 19,

        [StringLabel("Heliocentric Orbit")]
        Heliocentric = 20,

        #endregion

        #region Injection Classifications

        [StringLabel("Geostationary Transfer Orbit")]
        GTO = 21,

        [StringLabel("Trans-Lunar Injection")]
        LunarInjection = 22,

        [StringLabel("Trans-Mars Injection")]
        MarsInjection = 23,

        #endregion
    }
}