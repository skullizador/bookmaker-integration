// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SportsBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// SportsBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Sports
{
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Enum;
    using Domain.AggregateModels.Sports;

    /// <summary>
    /// <see cref="SportsBuilder"/> class
    /// </summary>
    /// <seealso cref="ISportsBuilder"/>
    internal class SportsBuilder : ISportsBuilder
    {
        /// <summary>
        /// The sport
        /// </summary>
        private Sports sport;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Sports Build()
        {
            return this.sport;
        }

        /// <summary>
        /// Creates new sport.
        /// </summary>
        /// <param name="sportType">Type of the sport.</param>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public ISportsBuilder NewSport(SportType sportType, string url)
        {
            this.sport = new Sports(sportType, url);

            return this;
        }
    }
}