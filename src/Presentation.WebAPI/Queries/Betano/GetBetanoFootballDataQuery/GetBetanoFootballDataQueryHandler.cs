// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetanoFootballDataQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetanoFootballDataQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Betano.GetBetanoFootballDataQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class GetBetanoFootballDataQueryHandler : INotificationHandler<GetBetanoFootballDataQuery>
    {
        public Task Handle(GetBetanoFootballDataQuery notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}