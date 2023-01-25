// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bookmaker.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Bookmaker
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BookmakerIntegration.Domain.AggregateModels.Sports;
    using BookmakerIntegration.Domain.Exceptions;
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="Bookmaker"/> class
    /// </summary>
    /// <seealso cref="EntityBase"/>
    /// <seealso cref="IAggregateRoot"/>
    public class Bookmaker : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// The sports
        /// </summary>
        private readonly List<Sports> sports;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmaker"/> class.
        /// </summary>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="baseUrl">The base URL.</param>
        internal Bookmaker(Guid bookmakerId, string baseUrl)
            : this()
        {
            this.BookmakerId = bookmakerId;
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmaker"/> class.
        /// </summary>
        protected Bookmaker()
        {
            this.sports = new List<Sports>();
        }

        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        public string BaseUrl { get; private set; }

        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; private set; }

        /// <summary>
        /// Gets the sports.
        /// </summary>
        /// <value>The sports.</value>
        public virtual IReadOnlyCollection<Sports> Sports => this.sports;

        /// <summary>
        /// Adds the sport.
        /// </summary>
        /// <param name="sport">The sport.</param>
        /// <exception cref="ArgumentNullException">sport - Sport is null.</exception>
        /// <exception cref="DuplicatedException">The {sport.Type} Sport already exists.</exception>
        public void AddSport(Sports sport)
        {
            if (sport is null)
            {
                throw new ArgumentNullException(nameof(sport), "The Sport cannot be null.");
            }

            if (this.sports.Any(x => x.Type == sport.Type))
            {
                throw new DuplicatedException($"The {sport.Type} Sport already exists.");
            }

            this.sports.Add(sport);
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