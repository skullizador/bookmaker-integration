// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetCasinoPortugalDataQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetCasinoPortugalDataQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.CasinoPortugal.GetCasinoPortugalDataQuery
{
    using BookmakerIntegration.Domain.DataModels.CasinoPortugal;
    using MediatR;

    /// <summary>
    /// <see cref="GetCasinoPortugalDataQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{CasinoPortugalJsonDataModel}"/>
    public class GetCasinoPortugalDataQuery : IRequest<CasinoPortugalJsonDataModel>
    {
        /// <summary>
        /// Gets or sets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; set; }
    }
}