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
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Enum;
    using Domain.AggregateModels.Sports;

    /// <summary>
    /// <see cref="ISportsBuilder"/> interface
    /// </summary>
    public interface ISportsBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Sports Build();

        /// <summary>
        /// Creates new sports.
        /// </summary>
        /// <param name="sportType">Type of the sport.</param>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        ISportsBuilder NewSport(SportType sportType, string url);
    }
}