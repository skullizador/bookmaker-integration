// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SportsRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// SportsRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.Repository
{
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository;

    /// <summary>
    /// <see cref="SportsRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Sports}"/>
    /// <seealso cref="ISportsRepository"/>
    internal class SportsRepository : GenericRepository<Sports>, ISportsRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SportsRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public SportsRepository(BookmakerIntegrationDBContext context)
            : base(context)
        {
        }
    }
}