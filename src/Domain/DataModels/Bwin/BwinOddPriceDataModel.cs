// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinOddPriceDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinOddPriceDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    /// <summary>
    /// <see cref="BwinOddPriceDataModel"/>
    /// </summary>
    public class BwinOddPriceDataModel
    {
        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public decimal odds { get; init; }
    }
}