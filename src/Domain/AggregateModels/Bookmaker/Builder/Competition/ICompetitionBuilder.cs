// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICompetitionBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ICompetitionBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Competition
{
    using System;
    using Domain.AggregateModels.Bookmaker;

    /// <summary>
    /// <see cref="ICompetitionBuilder"/>
    /// </summary>
    public interface ICompetitionBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Competition Build();

        /// <summary>
        /// Creates new competition.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="finalUrl">The final URL.</param>
        /// <param name="competitionId">The competition identifier.</param>
        /// <returns></returns>
        ICompetitionBuilder NewCompetition(string name, string finalUrl, Guid competitionId);
    }
}