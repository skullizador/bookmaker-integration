// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetPlacardFootbalDataQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetPlacardFootbalDataQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Placard.GetPlacardFootbalDataQuery
{
    using BookmakerIntegration.Domain.DataModels.Placard.Response;
    using MediatR;

    /// <summary>
    /// <see cref="GetPlacardFootbalDataQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{PlacardResponseModel}"/>
    public class GetPlacardFootbalDataQuery : IRequest<PlacardResponseModel>
    {
        /// <summary>
        /// Gets or sets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the placard competition identifier.
        /// </summary>
        /// <value>The placard competition identifier.</value>
        public int PlacardCompetitionId { get; set; }

        /// <summary>
        /// Gets or sets the sport.
        /// </summary>
        /// <value>The sport.</value>
        public string Sport { get; set; }
    }
}