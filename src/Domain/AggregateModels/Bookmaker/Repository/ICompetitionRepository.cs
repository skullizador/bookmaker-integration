// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICompetitionRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ICompetitionRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="ICompetitionRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Competition}"/>
    public interface ICompetitionRepository : IRepository<Competition>
    {
        /// <summary>
        /// Gets the by competition asynchronous.
        /// </summary>
        /// <param name="competitionId">The competition identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<Competition> GetByCompetitionAsync(Guid competitionId, CancellationToken cancellationToken);
    }
}