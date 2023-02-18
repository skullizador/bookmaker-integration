// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetclicFootballDataQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetclicFootballDataQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Betclic.GetBetclicFootballDataQuery
{
    using BookmakerIntegration.Domain.DataModels.Betclic;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetclicFootballDataQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{BetclicCompetitionDataModel}"/>
    public class GetBetclicFootballDataQuery : IRequest<BetclicCompetitionDataModel>
    {
        /// <summary>
        /// Gets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; init; }
    }
}