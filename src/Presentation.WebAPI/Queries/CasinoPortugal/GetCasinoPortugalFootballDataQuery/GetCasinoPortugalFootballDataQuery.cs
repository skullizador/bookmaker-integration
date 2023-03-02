// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetCasinoPortugalFootballDataQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetCasinoPortugalFootballDataQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.CasinoPortugal.GetCasinoPortugalFootballDataQuery
{
    using BookmakerIntegration.Domain.DataModels.CasinoPortugal;
    using MediatR;

    /// <summary>
    /// <see cref="GetCasinoPortugalFootballDataQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{CasinoPortugalJsonDataModel}"/>
    public class GetCasinoPortugalFootballDataQuery : IRequest<CasinoPortugalJsonDataModel>
    {
        /// <summary>
        /// Gets or sets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; set; }
    }
}