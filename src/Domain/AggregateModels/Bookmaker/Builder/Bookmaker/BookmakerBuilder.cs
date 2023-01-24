// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Builder.Bookmaker
{
    using System;
    using System.Collections.Generic;
    using Domain.AggregateModels.Bookmaker;
    using Domain.AggregateModels.Sports;

    /// <summary>
    /// <see cref="BookmakerBuilder"/> class
    /// </summary>
    /// <seealso cref="IBookmakerBuilder"/>
    internal class BookmakerBuilder : IBookmakerBuilder
    {
        /// <summary>
        /// The bookmaker
        /// </summary>
        private Bookmaker bookmaker;

        /// <summary>
        /// Adds the sport.
        /// </summary>
        /// <param name="sports">The sports.</param>
        /// <returns></returns>
        public IBookmakerBuilder AddSports(List<Sports> sports)
        {
            foreach (Sports sport in sports)
            {
                this.bookmaker.AddSport(sport);
            }
            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Bookmaker Build()
        {
            return this.bookmaker;
        }

        /// <summary>
        /// Creates new bookmaker.
        /// </summary>
        /// <param name="bookmakerId"></param>
        /// <param name="baseUrl">The base URL.</param>
        /// <returns></returns>
        public IBookmakerBuilder NewBookmaker(Guid bookmakerId, string baseUrl)
        {
            this.bookmaker = new Bookmaker(bookmakerId, baseUrl);
            return this;
        }
    }
}