// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sports.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Sports
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Enum;
    using BookmakerIntegration.Domain.Exceptions;
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="Sports"/> class
    /// </summary>
    /// <seealso cref="EntityBase"/>
    public class Sports : EntityBase
    {
        /// <summary>
        /// The competitions
        /// </summary>
        private readonly List<Competition> competitions;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sports"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        internal Sports(SportType type)
            : this()
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sports"/> class.
        /// </summary>
        protected Sports()
        {
            this.competitions = new();
        }

        /// <summary>
        /// Gets the competitions.
        /// </summary>
        /// <value>The competitions.</value>
        public IReadOnlyCollection<Competition> Competitions => this.competitions;

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public SportType Type { get; private set; }

        /// <summary>
        /// Adds the competition.
        /// </summary>
        /// <param name="competition">The competition.</param>
        /// <exception cref="ArgumentNullException">
        /// competition - The Competition cannot be null.
        /// </exception>
        /// <exception cref="DuplicatedException">
        /// The Competition with id {competition.CompetitionId} already exists.
        /// </exception>
        public void AddCompetition(Competition competition)
        {
            if (competition is null)
            {
                throw new ArgumentNullException(nameof(competition), "The Competition cannot be null.");
            }

            if (this.competitions.Any(x => x.CompetitionId == competition.CompetitionId))
            {
                throw new DuplicatedException($"The Competition with id {competition.CompetitionId} already exists.");
            }

            this.competitions.Add(competition);
        }

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