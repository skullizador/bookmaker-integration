// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISportsRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ISportsRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository
{
    using BookmakerIntegration.Domain.AggregateModels.Sports;
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="ISportsRepository"/> interface
    /// </summary>
    /// <seealso cref="IRepository{Sports};"/>
    public interface ISportsRepository : IRepository<Sports>
    {
    }
}