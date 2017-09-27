// ************************************************************************
// Assembly         : NRTyler.KSP.Common
// 
// Author           : Nicholas Tyler
// Created          : 09-25-2017
// 
// Last Modified By : Nicholas Tyler
// Last Modified On : 09-25-2017
// 
// License          : MIT License
// ***********************************************************************

using System;

namespace NRTyler.KSP.Common.Attributes
{
    /// <summary>
    /// An <see cref="Attribute"/> that allows a member to be referenced by or assigned a label that's held as a <see cref="string"/> value.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public sealed class StringLabelAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringLabelAttribute"/> class.
        /// </summary>
        /// <param name="label">The label that you want to be applied to an item.</param>
        public StringLabelAttribute(string label)
        {
            Label = label;
        }

        /// <summary>
        /// Gets the label that was applied to the member.
        /// </summary>
        public string Label { get; }
    }
}