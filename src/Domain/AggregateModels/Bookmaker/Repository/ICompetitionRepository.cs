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
    using BookmakerIntegration.Domain.SeedWork;

    /// <summary>
    /// <see cref="ICompetitionRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Competition}"/>
    public interface ICompetitionRepository : IRepository<Competition>
    {
    }
}