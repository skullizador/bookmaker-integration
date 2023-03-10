// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoConstant.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoConstant
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.ConstantCollections.Betano
{
    using BookmakerIntegration.Domain.Utils;

    /// <summary>
    /// <see cref="BetanoConstant"/>
    /// </summary>
    /// <seealso cref="ConstantObject"/>
    public class BetanoConstant : ConstantObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoConstant"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public BetanoConstant(string value)
            : base(value)
        {
        }
    }
}