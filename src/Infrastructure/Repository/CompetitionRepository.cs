// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompetitionRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CompetitionRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.Repository
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// <see cref="CompetitionRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Competition}"/>
    /// <seealso cref="ICompetitionRepository"/>
    internal class CompetitionRepository : GenericRepository<Competition>, ICompetitionRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public CompetitionRepository(BookmakerIntegrationDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the by competition asynchronous.
        /// </summary>
        /// <param name="competitionId">The competition identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Competition> GetByCompetitionAsync(Guid competitionId, CancellationToken cancellationToken)
        {
            return await this.Entities.SingleOrDefaultAsync(x =>
                x.CompetitionId == competitionId,
                cancellationToken);
        }
    }
}