// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoGameDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoGameDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Betano
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="BetanoGameDataModel"/>
    /// </summary>
    public class BetanoGameDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoGameDataModel"/> class.
        /// </summary>
        public BetanoGameDataModel()
        {
            this.Id = string.Empty;
            this.Name = string.Empty;
            this.ShortName = string.Empty;
            this.LeagueId = string.Empty;
            this.LeagueDescription = string.Empty;
            this.RegionId = string.Empty;
            this.RegionName = string.Empty;
            this.SportId = string.Empty;
            this.Url = string.Empty;
            this.TvChannel = string.Empty;
            this.Notes = string.Empty;
            this.Markets = new List<BetanoMarketDataModel>();
        }

        /// <summary>
        /// Gets the bet radar identifier.
        /// </summary>
        /// <value>The bet radar identifier.</value>
        public int BetRadarId { get; init; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; init; }

        /// <summary>
        /// Gets the league description.
        /// </summary>
        /// <value>The league description.</value>
        public string LeagueDescription { get; init; }

        /// <summary>
        /// Gets the league identifier.
        /// </summary>
        /// <value>The league identifier.</value>
        public string LeagueId { get; init; }

        /// <summary>
        /// Gets a value indicating whether [live now].
        /// </summary>
        /// <value><c>true</c> if [live now]; otherwise, <c>false</c>.</value>
        public bool LiveNow { get; init; }

        /// <summary>
        /// Gets the markets.
        /// </summary>
        /// <value>The markets.</value>
        public List<BetanoMarketDataModel> Markets { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <value>The notes.</value>
        public string Notes { get; init; }

        /// <summary>
        /// Gets the region identifier.
        /// </summary>
        /// <value>The region identifier.</value>
        public string RegionId { get; init; }

        /// <summary>
        /// Gets the name of the region.
        /// </summary>
        /// <value>The name of the region.</value>
        public string RegionName { get; init; }

        /// <summary>
        /// Gets the short name.
        /// </summary>
        /// <value>The short name.</value>
        public string ShortName { get; init; }

        /// <summary>
        /// Gets the sport identifier.
        /// </summary>
        /// <value>The sport identifier.</value>
        public string SportId { get; init; }

        /// <summary>
        /// Gets the start time.
        /// </summary>
        /// <value>The start time.</value>
        public long StartTime { get; init; }

        /// <summary>
        /// Gets the total markets available.
        /// </summary>
        /// <value>The total markets available.</value>
        public int TotalMarketsAvailable { get; init; }

        /// <summary>
        /// Gets the tv channel.
        /// </summary>
        /// <value>The tv channel.</value>
        public string TvChannel { get; init; }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; init; }

        /// <summary>
        /// Gets a value indicating whether [will go live].
        /// </summary>
        /// <value><c>true</c> if [will go live]; otherwise, <c>false</c>.</value>
        public bool WillGoLive { get; init; }
    }
}