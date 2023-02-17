// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetPlacardFootbalDataQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetPlacardFootbalDataQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Placard.GetPlacardFootbalDataQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.DataModels.Placard.Request;
    using BookmakerIntegration.Domain.DataModels.Placard.Response;
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;

    /// <summary>
    /// <see cref="GetPlacardFootbalDataQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetPlacardFootbalDataQuery, PlacardResponseModel}"/>
    public class GetPlacardFootbalDataQueryHandler : IRequestHandler<GetPlacardFootbalDataQuery, PlacardResponseModel>
    {
        /// <summary>
        /// The data collector
        /// </summary>
        private readonly IDataCollector dataCollector;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPlacardFootbalDataQueryHandler"/> class.
        /// </summary>
        /// <param name="dataCollector">The data collector.</param>
        public GetPlacardFootbalDataQueryHandler(IDataCollector dataCollector)
        {
            this.dataCollector = dataCollector;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        public async Task<PlacardResponseModel> Handle(GetPlacardFootbalDataQuery request, CancellationToken cancellationToken)
        {
            PlacardVariablesModel variables = new(
                request.PlacardCompetitionId.ToString(),
                request.Date.ToString("yyyy-MM-dd"),
                request.Sport);

            PlacardRequestModel body = new(variables);

            string url = "https://placard.jogossantacasa.pt/PlacardWeb/screenservices/Plcard_WebEvents_CW/EventsFlow/EventList_EventListBlock/DataActionGetEventsData";

            PlacardResponseModel data = await this.dataCollector.CollectPlacardDataAsync(
                url,
                body,
                cancellationToken);

            return data;
        }
    }
}