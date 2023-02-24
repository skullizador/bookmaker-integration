// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinGameDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinGameDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="BwinGameDataModel"/>
    /// </summary>
    public class BwinGameDataModel
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public BwinNameDataModel name { get; init; }

        /// <summary>
        /// Gets the option markets.
        /// </summary>
        /// <value>The option markets.</value>
        public List<BwinOptionMarketDataModel> optionMarkets { get; init; }

        /// <summary>
        /// Gets the region.
        /// </summary>
        /// <value>The region.</value>
        public BwinGameRegionDataModel region { get; init; }

        /// <summary>
        /// Gets the sport.
        /// </summary>
        /// <value>The sport.</value>
        public BwinGameSportDataModel sport { get; init; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime startDate { get; init; }
    }
}