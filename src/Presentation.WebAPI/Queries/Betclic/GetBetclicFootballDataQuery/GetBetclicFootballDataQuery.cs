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
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic;
    using MediatR;

    public class GetBetclicFootballDataQuery : IRequest<BetclicCompetitionDataModel>
    {
        public Guid CompetitionId { get; init; }
    }
}