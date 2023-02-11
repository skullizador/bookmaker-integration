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
    using MediatR;

    public class GetBetclicFootballDataQuery : IRequest<List<string>>
    {
        //TODO: Change the list type to Betclicdatamodel
        public Guid CompetitionId { get; init; }
    }
}