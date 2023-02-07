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
    using System.Collections.Generic;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Enum;
    using Domain.AggregateModels.Bookmaker;

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
        /// Adds the competitions.
        /// </summary>
        /// <param name="competitions"></param>
        /// <returns></returns>
        public ISportsBuilder AddCompetitions(List<Competition> competitions)
        {
            foreach (Competition competition in competitions)
            {
                this.sport.AddCompetition(competition);
            }

            return this;
        }

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
        /// <returns></returns>
        public ISportsBuilder NewSport(SportType sportType)
        {
            this.sport = new Sports(sportType);

            return this;
        }
    }
}