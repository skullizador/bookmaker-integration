// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CasinoPortugalFixtureDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CasinoPortugalFixtureDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.CasinoPortugal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BookmakerIntegration.Domain.ConstantCollections.CasinoPortugal;

    /// <summary>
    /// <see cref="CasinoPortugalFixtureDataModel"/>
    /// </summary>
    public class CasinoPortugalFixtureDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoPortugalFixtureDataModel"/> class.
        /// </summary>
        public CasinoPortugalFixtureDataModel()
        {
            this.away_name = string.Empty;
            this.comp_name = string.Empty;
            this.home_name = string.Empty;
            this.name = string.Empty;
            this.region_name = string.Empty;
            this.markets = new List<CasinoPortugalMarketsDataModel>();
        }

        /// <summary>
        /// Gets the name of the away.
        /// </summary>
        /// <value>The name of the away.</value>
        public string away_name { get; init; }

        /// <summary>
        /// Gets the name of the comp.
        /// </summary>
        /// <value>The name of the comp.</value>
        public string comp_name { get; init; }

        /// <summary>
        /// Gets the name of the home.
        /// </summary>
        /// <value>The name of the home.</value>
        public string home_name { get; init; }

        /// <summary>
        /// Gets the markets.
        /// </summary>
        /// <value>The markets.</value>
        public List<CasinoPortugalMarketsDataModel> markets { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; init; }

        /// <summary>
        /// Gets the name of the region.
        /// </summary>
        /// <value>The name of the region.</value>
        public string region_name { get; init; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime start_time_utc { get; init; }

        /// <summary>
        /// Gets the wanted markets.
        /// </summary>
        /// <value>The wanted markets.</value>
        public List<CasinoPortugalMarketsDataModel> WantedMarkets => this.GetFinalResultMarket();

        /// <summary>
        /// Gets the final result market.
        /// </summary>
        /// <returns></returns>
        private List<CasinoPortugalMarketsDataModel> GetFinalResultMarket()
        {
            return this.markets
                .Where(x => x.name == CasinoPortugalConstantCollection.CasinoPortugalWantedOdds.Value)
                .ToList();
        }
    }
}