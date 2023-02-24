// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinOddDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinOddDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    /// <summary>
    /// <see cref="BwinOddDataModel"/>
    /// </summary>
    public class BwinOddDataModel
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public BwinNameDataModel name { get; init; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>The price.</value>
        public BwinOddPriceDataModel price { get; init; }
    }
}