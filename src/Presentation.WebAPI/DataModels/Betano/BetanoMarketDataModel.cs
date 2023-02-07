﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoMarketDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoMarketDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betano
{
    /// <summary>
    /// <see cref="BetanoMarketDataModel"/>
    /// </summary>
    public class BetanoMarketDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoMarketDataModel"/> class.
        /// </summary>
        public BetanoMarketDataModel()
        {
            this.Id = string.Empty;
            this.Name = string.Empty;
            this.Type = string.Empty;
            this.Selections = new List<BetanoOddDataModel>();
        }

        //TODO: MISSING EXACT SCORE SELECTIONS;

        /// <summary>
        /// Gets the handicap.
        /// </summary>
        /// <value>The handicap.</value>
        public decimal Handicap { get; init; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; init; }

        /// <summary>
        /// Gets the market close timemillis.
        /// </summary>
        /// <value>The market close timemillis.</value>
        public long MarketCloseTimemillis { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the rendering layout.
        /// </summary>
        /// <value>The rendering layout.</value>
        public int RenderingLayout { get; init; }

        //TODO: MISSING SCORERSELECTIONS;

        /// <summary>
        /// Gets the selections.
        /// </summary>
        /// <value>The selections.</value>
        public List<BetanoOddDataModel> Selections { get; init; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; init; }
    }
}