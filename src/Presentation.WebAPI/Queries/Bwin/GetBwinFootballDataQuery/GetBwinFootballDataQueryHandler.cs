// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBwinFootballDataQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBwinFootballDataQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Queries.Bwin.GetBwinFootballDataQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerIntegration.Domain.ConstantCollections.Bwin;
    using BookmakerIntegration.Domain.DataModels.Bwin;
    using BookmakerIntegration.Presentation.WebAPI.Services.DataCollector;
    using MediatR;

    /// <summary>
    /// <see cref="GetBwinFootballDataQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetBwinFootballDataQuery, BwinWidgetDataModel}"/>
    public class GetBwinFootballDataQueryHandler : IRequestHandler<GetBwinFootballDataQuery, BwinWidgetDataModel>
    {
        /// <summary>
        /// The competition repository
        /// </summary>
        private readonly ICompetitionRepository competitionRepository;

        /// <summary>
        /// The data collector
        /// </summary>
        private readonly IDataCollector dataCollector;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBwinFootballDataQueryHandler"/> class.
        /// </summary>
        /// <param name="competitionRepository">The competition repository.</param>
        /// <param name="dataCollector">The data collector.</param>
        public GetBwinFootballDataQueryHandler(
            ICompetitionRepository competitionRepository,
            IDataCollector dataCollector)
        {
            this.competitionRepository = competitionRepository;
            this.dataCollector = dataCollector;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        public async Task<BwinWidgetDataModel> Handle(GetBwinFootballDataQuery request, CancellationToken cancellationToken)
        {
            BwinJsonDataModel data = await this.dataCollector.CollectBwinDataAsync(
                "https://sports.bwin.pt/pt/sports/api/widget?sportId=4&regionId=37&competitionId=102851&compoundCompetitionId=2:102851&forceFresh=1",
                cancellationToken);

            return data.widgets
                .First(x => x.templateName == BwinConstantCollection.CurrentWantedWidgetTemplateName.Value);
        }
    }
}