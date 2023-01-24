// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sports.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Sports
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Sports
{
    using System.Collections.Generic;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Enum;
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="Sports"/> class
    /// </summary>
    /// <seealso cref="EntityBase"/>
    public class Sports : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sports"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="type">The type.</param>
        internal Sports(SportType type, string url)
            : this()
        {
            this.Url = url;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sports"/> class.
        /// </summary>
        protected Sports()
        {
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public SportType Type { get; private set; }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; private set; }

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