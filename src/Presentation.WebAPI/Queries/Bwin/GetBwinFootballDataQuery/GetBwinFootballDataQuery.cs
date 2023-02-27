// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBwinFootballDataQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBwinFootballDataQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Bwin.GetBwinFootballDataQuery
{
    using BookmakerIntegration.Domain.DataModels.Bwin;
    using MediatR;

    /// <summary>
    /// <see cref="GetBwinFootballDataQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{BwinWidgetDataModel}"/>
    public class GetBwinFootballDataQuery : IRequest<BwinWidgetDataModel>
    {
        /// <summary>
        /// Gets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; init; }
    }
}