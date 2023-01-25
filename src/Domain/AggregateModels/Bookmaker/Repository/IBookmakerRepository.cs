// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookmakerRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBookmakerRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository
{
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="IBookmakerRepository"/> interface
    /// </summary>
    /// <seealso cref="IRepository{Bookmaker};"/>
    public interface IBookmakerRepository : IRepository<Bookmaker>
    {
    }
}