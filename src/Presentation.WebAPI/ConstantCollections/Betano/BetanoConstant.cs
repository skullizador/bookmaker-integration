// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoConstant.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoConstant
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.ConstantCollections.Betano
{
    /// <summary>
    /// <see cref="BetanoConstant"/>
    /// </summary>
    public class BetanoConstant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoConstant"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public BetanoConstant(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; init; }
    }
}