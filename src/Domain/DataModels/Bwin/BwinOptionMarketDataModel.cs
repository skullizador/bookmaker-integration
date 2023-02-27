// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinOptionMarketDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinOptionMarketDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="BwinOptionMarketDataModel"/>
    /// </summary>
    public class BwinOptionMarketDataModel
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public BwinNameDataModel name { get; init; }

        /// <summary>
        /// Gets the options.
        /// </summary>
        /// <value>The options.</value>
        public List<BwinOddDataModel> options { get; init; }
    }
}