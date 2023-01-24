// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookmakerBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBookmakerBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Bookmaker
{
    using System;
    using System.Collections.Generic;
    using Domain.AggregateModels.Bookmaker;
    using Domain.AggregateModels.Sports;

    /// <summary>
    /// <see cref="IBookmakerBuilder"/> interface
    /// </summary>
    public interface IBookmakerBuilder
    {
        /// <summary>
        /// Adds the sport.
        /// </summary>
        /// <param name="sports">The sports.</param>
        /// <returns></returns>
        IBookmakerBuilder AddSports(List<Sports> sports);

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Bookmaker Build();

        /// <summary>
        /// Creates new bookmaker.
        /// </summary>
        /// <param name="BookmakerId">The bookmaker identifier.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <returns></returns>
        IBookmakerBuilder NewBookmaker(Guid bookmakerId, string baseUrl);
    }
}