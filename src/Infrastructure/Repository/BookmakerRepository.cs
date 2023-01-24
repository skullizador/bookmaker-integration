// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.Repository
{
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository;

    /// <summary>
    /// <see cref="BookmakerRepository"/> class
    /// </summary>
    /// <seealso cref="GenericRepository{Bookmaker};"/>
    /// <seealso cref="IBookmakerRepository"/>
    internal class BookmakerRepository : GenericRepository<Bookmaker>, IBookmakerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookmakerRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BookmakerRepository(BookmakerIntegrationDBContext context)
            : base(context)
        {
        }
    }
}