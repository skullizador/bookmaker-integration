// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Competition.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Competition
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker
{
    using System;
    using System.Collections.Generic;
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="Competition"/>
    /// </summary>
    /// <seealso cref="EntityBase"/>
    public class Competition : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Competition"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="finalUrl">The final URL.</param>
        /// <param name="competitionId">The competition identifier.</param>
        public Competition(string name, string finalUrl, Guid competitionId)
        {
            this.Name = name;
            this.FinalUrl = finalUrl;
            this.CompetitionId = competitionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Competition"/> class.
        /// </summary>
        protected Competition()
        {
        }

        /// <summary>
        /// Gets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; private set; }

        /// <summary>
        /// Gets the final URL.
        /// </summary>
        /// <value>The final URL.</value>
        public string FinalUrl { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.UUId;
        }
    }
}