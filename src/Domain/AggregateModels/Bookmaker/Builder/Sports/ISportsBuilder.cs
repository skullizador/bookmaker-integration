// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISportsBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ISportsBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Sports
{
    using System.Collections.Generic;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Enum;
    using Domain.AggregateModels.Bookmaker;

    /// <summary>
    /// <see cref="ISportsBuilder"/> interface
    /// </summary>
    public interface ISportsBuilder
    {
        /// <summary>
        /// Adds the competitions.
        /// </summary>
        /// <param name="competitions">The competitions.</param>
        /// <returns></returns>
        ISportsBuilder AddCompetitions(List<Competition> competitions);

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Sports Build();

        /// <summary>
        /// Creates new sports.
        /// </summary>
        /// <param name="sportType">Type of the sport.</param>
        /// <returns></returns>
        ISportsBuilder NewSport(SportType sportType);
    }
}