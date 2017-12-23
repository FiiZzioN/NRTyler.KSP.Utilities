// ***********************************************************************
// Assembly         : NRTyler.KSP.Common
//
// Author           : Nicholas Tyler
// Created          : 10-05-2017
//
// Last Modified By : Nicholas Tyler
// Last Modified On : 10-05-2017
//
// License          : MIT License
// ***********************************************************************

using System;
using NRTyler.CodeLibrary.Utilities;

namespace NRTyler.KSP.Common.Utilities
{
	/// <summary>
	/// Contains methods that help calculate the amount of delta-v a given object has at its' disposal.
	/// </summary>
	public class DeltaVCalculator
	{
        /// <summary>
        /// Calculates a vehicle's or stage's available Delta-V.
        /// </summary>
        /// <param name="dryMass">The dry mass of the vehicle or stage.</param>
        /// <param name="wetMass">The wet mass of the vehicle or stage.</param>
        /// <param name="specificImpulse">The specific impulse of the vehicle or stage.</param>
        /// <returns>The vehicle's or stage's total Delta-V.</returns>
        public static double CalculateDeltaV(double dryMass, double wetMass, double? specificImpulse)
		{
			// We have to have a specific impulse in order for our reaction mass to do anything.
			// If we don't have that, in the form of null, zero, or NaN, then we have no delta-v.
			if (specificImpulse == null || specificImpulse <= 0 || Double.IsNaN((double)specificImpulse)) return 0;

			// Tsiolkovsky Rocket Equation, more info here: http://enwp.org/Tsiolkovsky_rocket_equation
			var ve = specificImpulse * ExtendedMathConstants.ɡ;
			var m0 = wetMass;
			var mf = dryMass;
			var ln = Math.Log(m0 / mf);

			var deltaV = ve * ln;

			return (double)deltaV;
		}
	}
}