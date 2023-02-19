// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSolVerdeFootballDataQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetSolVerdeFootballDataQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.SolVerde.GetSolVerdeFootballDataQuery
{
    using MediatR;

    /// <summary>
    /// </summary>
    /// <seealso cref="IRequest{String}"/>
    public class GetSolVerdeFootballDataQuery : IRequest<string>
    {
        /// <summary>
        /// Gets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; init; }
    }
}