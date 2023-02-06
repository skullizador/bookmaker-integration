// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompetitionBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CompetitionBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Competition
{
    using System;
    using Domain.AggregateModels.Bookmaker;

    /// <summary>
    /// <see cref="CompetitionBuilder"/>
    /// </summary>
    /// <seealso cref="ICompetitionBuilder"/>
    internal class CompetitionBuilder : ICompetitionBuilder
    {
        /// <summary>
        /// The competition
        /// </summary>
        private Competition competition;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Competition Build()
        {
            return this.competition;
        }

        /// <summary>
        /// Creates new competition.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="finalUrl">The final URL.</param>
        /// <param name="competitionId">The competition identifier.</param>
        /// <returns></returns>
        public ICompetitionBuilder NewCompetition(string name, string finalUrl, Guid competitionId)
        {
            this.competition = new(name, finalUrl, competitionId);

            return this;
        }
    }
}