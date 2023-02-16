// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetanoFootballDataQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetanoFootballDataQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Betano.GetBetanoFootballDataQuery
{
    using BookmakerIntegration.Domain.DataModels.Betano;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetanoFootballDataQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{List{BetanoBlocksDataModel}}"/>
    public class GetBetanoFootballDataQuery : IRequest<List<BetanoBlocksDataModel>>
    {
        /// <summary>
        /// Gets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; init; }
    }
}